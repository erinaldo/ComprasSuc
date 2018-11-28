Public Class clsDevCompraImport

   Private moDevCompra As clsDevCompra
   Private moDevCompraOrg As clsDevCompra
   Private moDevCompraDes As clsDevCompra
   Private moDevCompraDetOrg As clsDevCompraDet
   Private moDevCompraDetDes As clsDevCompraDet

   Friend mlngEmpresaIdOrg As Long
   Friend mlngGestionIdOrg As Long
   Friend mstrConnectStringOrg As String

   Private mintRowSel As Integer
   Private mintRowExport As Integer

   'Variables de Saldo de Items
   Private moListAlmacen As Queue(Of Hashtable)
   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long
   Private mboolControlLote As Boolean
   Private mboolControlSerie As Boolean

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moDataTableItem As DataTable
   Private mArrayColumName() As String

   Private mFrm As frmDataBaseImport
   Private grdMain As Janus.Windows.GridEX.GridEX
   Private pbrMain As Janus.Windows.EditControls.UIProgressBar
   Private moStopwatch As Stopwatch
   Private moTimeSpan As TimeSpan

   Public ReadOnly Property RowSel()
      Get
         Return mintRowSel
      End Get
   End Property

   Public ReadOnly Property RowExport()
      Get
         Return mintRowExport
      End Get
   End Property

   Public ReadOnly Property TimeSpan()
      Get
         Return moTimeSpan
      End Get
   End Property

   Public Sub New(ByVal ofrmDataBaseImport As frmDataBaseImport)
      Me.mFrm = ofrmDataBaseImport
      Call frmMove()
      Call grdErrorColumName()
   End Sub

   Private Sub frmMove()
      mlngEmpresaIdOrg = mFrm.mlngEmpresaIdOrg
      mlngGestionIdOrg = mFrm.mlngGestionIdOrg
      mstrConnectStringOrg = mFrm.mstrConnectStringOrg
      moDataSet = mFrm.moDataSet
      moDataTable = mFrm.moDataTable
      moDataTableItem = mFrm.moDataTableItem
      grdMain = mFrm.grdDevCompra
      pbrMain = mFrm.pbrMain
   End Sub

   Private Sub grdErrorColumName()
      ReDim mArrayColumName(5)
      mArrayColumName(0) = "DevCompraId"
      mArrayColumName(1) = "DevCompraDetId"
      mArrayColumName(2) = "DevCompraNro"
      mArrayColumName(3) = "Tabla"
      mArrayColumName(4) = "Id"
      mArrayColumName(5) = "Descripción"
   End Sub

   Private Function GridCheck() As Boolean
      Dim strMsg As String = String.Empty

      If grdMain.GetCheckedRows.Count <= 0 Then
         Throw New Exception("Debe Seleccionar al Menos un Registro")
         GridCheck = False
      End If

      If Not DevCompraSinDetalleCheck() Then
         Throw New Exception("Existen DevCompras Sin Detalle en Base de Datos Origen")
         GridCheck = False
      End If

      If Not DevCompraDuplicadoCheck() Then
         Throw New Exception("Existen Números de Comprobante Duplicados")
         GridCheck = False
      End If

      If Not ItemCheck() Then
         Throw New Exception("Uno o Mas Items No Existen o Tienen Propiedades Diferentes en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not AlmacenCheck() Then
         Throw New Exception("Una o Mas Almacenes No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not ProveedorCheck() Then
         Throw New Exception("Una o Mas Proveedores No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not NotaCheck() Then
         Throw New Exception("Una o Mas Notas No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not CompCheck() Then
         Throw New Exception("Una o Mas Comprobantes No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not PlanCheck() Then
         Throw New Exception("Una o Mas Cuentas No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not CompraCheck() Then
         Throw New Exception("Una o Mas Compra No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      GridCheck = True
   End Function

   Private Function DevCompraSinDetalleCheck() As Boolean
      DevCompraSinDetalleCheck = True

      moDevCompraDetOrg = New clsDevCompraDet(mstrConnectStringOrg)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("EstadoId").Value) <> 12 Then
               With moDevCompraDetOrg
                  .SelectFilter = clsDevCompraDet.SelectFilters.All
                  .WhereFilter = clsDevCompraDet.WhereFilters.DEVCOMPRAID
                  .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
                  .DevCompraId = ToLong(oRow.Cells("DevCompraId").Value)

                  If .Open() Then
                     If .DataSet.Tables(.TableName).Rows.Count = 0 Then
                        moDataTable.Rows.Add(GetRow(.DevCompraId, 0, ToLong(oRow.Cells("DevCompraNro").Value), "tblDevCompra", .DevCompraId, "DevCompra Sin Detalle"))
                        DevCompraSinDetalleCheck = False
                     End If
                  End If
               End With
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function DevCompraDuplicadoCheck() As Boolean
      Dim boolFind As Boolean

      DevCompraDuplicadoCheck = True

      moDevCompraDes = New clsDevCompra(clsAppInfo.ConnectString)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If oRow.Cells("DevCompraNro").Value > 0 Then
               For Each oRowFind As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  boolFind = False

                  If (oRow.Cells("DevCompraNro").Value = oRowFind.Cells("DevCompraNro").Value) _
                     And (oRow.Cells("DevCompraId").Value <> oRowFind.Cells("DevCompraId").Value) Then

                     boolFind = True
                     Exit For
                  End If
               Next

               If boolFind Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("DevCompraId").Value), 0, ToLong(oRow.Cells("DevCompraNro").Value), "tblDevCompra", ToLong(oRow.Cells("DevCompraId").Value), "Número de DevCompra Duplicada en Base de Datos Origen"))

                  DevCompraDuplicadoCheck = False
               End If

               With moDevCompraDes
                  .SelectFilter = clsDevCompra.SelectFilters.All
                  .WhereFilter = clsDevCompra.WhereFilters.DEVCOMPRANRO
                  .EmpresaId = clsAppInfo.EmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .DevCompraNro = ToLong(oRow.Cells("DevCompraNro").Value)

                  If .Find Then
                     moDataTable.Rows.Add(GetRow(.DevCompraId, 0, .DevCompraNro, .TableName, .DevCompraId, "Número de DevComprarobante Duplicado en Base de Datos Destino"))

                     DevCompraDuplicadoCheck = False
                  End If
               End With
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function ItemCheck() As Boolean
      Dim oItemDes As New clsItem(clsAppInfo.ConnectString)
      Dim strMedidaDesOrg As String
      Dim lngMedidaIdDes As Long

      ItemCheck = True
      moDevCompraDetOrg = New clsDevCompraDet(mstrConnectStringOrg)

      Dim listMedida = New Queue()

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            With moDevCompraDetOrg
               .SelectFilter = clsDevCompraDet.SelectFilters.DEVCOMPRAID_ITEM
               .WhereFilter = clsDevCompraDet.WhereFilters.DEVCOMPRAID_ITEM
               .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
               .DevCompraId = ToLong(oRow.Cells("DevCompraId").Value)

               If .Open() Then
                  For Each oRowDevCompraDet As DataRow In .DataSet.Tables(.TableName).Rows
                     If Not IsDBNull(oRowDevCompraDet("ItemItemId")) Then
                        If Not moDataTableItemCodFind(ToStr(oRowDevCompraDet("ItemCod"))) Then
                           moDataTableItem.Rows.Add(GetRowItem(oRowDevCompraDet("DevCompraDetId"), oRowDevCompraDet("ItemItemId"), oRowDevCompraDet("ItemCod"), oRowDevCompraDet("ItemDes"), _
                                                               oRowDevCompraDet("MedidaId"), oRowDevCompraDet("MedidaIdEqui"), oRowDevCompraDet("MedidaCantEqui"), oRowDevCompraDet("TipoItemId"), _
                                                               oRowDevCompraDet("ControlLote"), oRowDevCompraDet("ControlSerie"), oRowDevCompraDet("MonedaIdCos"), oRowDevCompraDet("MonedaIdVen"), oRowDevCompraDet("TipoCosteoId"), oRowDevCompraDet("PlanGrupoId")))
                        End If
                     Else
                        moDataTable.Rows.Add(GetRow(ToLong(oRowDevCompraDet("DevCompraId")), ToLong(oRowDevCompraDet("DevCompraDetId")), ToLong(oRowDevCompraDet("DevCompraDetItemId")), "invItem", 0, "ID de Item No Existe en invItem de la Base de Datos Origen"))
                        ItemCheck = False
                     End If

                  Next
               End If
            End With
         Next

         For Each oRow As DataRow In moDataTableItem.Rows
            With oItemDes
               .SelectFilter = clsItem.SelectFilters.All
               .WhereFilter = clsItem.WhereFilters.ItemCod
               .EmpresaId = clsAppInfo.EmpresaId
               .ItemCod = ToStr(oRow("ItemCodOrg"))

               If .Find Then
                  oRow("ItemIdDes") = .ItemId

                  strMedidaDesOrg = MedidaDesFind(mstrConnectStringOrg, .MedidaId)
                  lngMedidaIdDes = MedidaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strMedidaDesOrg)

                  If lngMedidaIdDes = 0 Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, "invMedida", .MedidaId, strMedidaDesOrg & " - Medida Mínima No Existe en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  strMedidaDesOrg = MedidaDesFind(mstrConnectStringOrg, .MedidaIdEqui)
                  lngMedidaIdDes = MedidaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strMedidaDesOrg)

                  If lngMedidaIdDes = 0 Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, "invMedida", .MedidaId, strMedidaDesOrg & " - Medida Equivalente No Existe en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MedidaCantEquiOrg") <> .MedidaCantEqui Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Cantidad Equivalente No Coincide en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("TipoItemIdOrg") <> .TipoItemId Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Tipo de Item Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("ControlLoteOrg") <> .ControlLote Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Control de Lote Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("ControlSerieOrg") <> .ControlSerie Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Control de Número de Serie Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MonedaIdCosOrg") <> .MonedaIdCos Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Moneda de Costo Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MonedaIdVenOrg") <> .MonedaIdVen Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Moneda de Venta Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("TipoCosteoIdOrg") <> .TipoCosteoId Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("DevCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Tipo de Costeo Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

               Else
                  moDataTable.Rows.Add(GetRow(0, 0, 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " " & ToStr(oRow("ItemDesOrg")) & " - No existe el Item en la Base de Datos Destino"))
                  ItemCheck = False
               End If
            End With
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function MedidaCheck() As Boolean
      Dim oMedidaDes As New clsMedida(clsAppInfo.ConnectString)
      MedidaCheck = True

      Try
         moDevCompraDetOrg = New clsDevCompraDet(mstrConnectStringOrg)

         With moDevCompraDetOrg
            .SelectFilter = clsDevCompraDet.SelectFilters.MEDIDA_DISTINCT
            .WhereFilter = clsDevCompraDet.WhereFilters.MEDIDA_DISTINCT
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If ToLong(oRow("MedidaId")) > 0 Then
                     oMedidaDes.SelectFilter = clsMedida.SelectFilters.All
                     oMedidaDes.WhereFilter = clsMedida.WhereFilters.MedidaDes
                     oMedidaDes.EmpresaId = clsAppInfo.EmpresaId
                     oMedidaDes.MedidaDes = ToStr(oRow("MedidaDes"))

                     If Not oMedidaDes.Find Then
                        moDataTable.Rows.Add(GetRow(0, 0, 0, oMedidaDes.TableName, ToLong(oRow("MedidaId")), ToStr(oRow("MedidaDes")) & " - Medida No Existe en la Base de Datos Destino"))
                        MedidaCheck = False
                     End If
                  End If
               Next
            End If
         End With

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function AlmacenCheck() As Boolean
      Dim oAlmacenDes As New clsAlmacen(clsAppInfo.ConnectString)
      AlmacenCheck = True
      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("AlmacenId").Value) > 0 Then
               oAlmacenDes.SelectFilter = clsAlmacen.SelectFilters.All
               oAlmacenDes.WhereFilter = clsAlmacen.WhereFilters.AlmacenCod
               oAlmacenDes.EmpresaId = clsAppInfo.EmpresaId
               oAlmacenDes.AlmacenCod = ToStr(oRow.Cells("AlmacenCod").Value)

               If Not oAlmacenDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("DevCompraId").Value), 0, ToLong(oRow.Cells("DevCompraNro").Value), oAlmacenDes.TableName, ToLong(oRow.Cells("AlmacenId").Value), ToStr(oRow.Cells("AlmacenCod").Value) & " - Almacen No Existe en la Base de Datos Destino"))
                  AlmacenCheck = False
               End If
            End If

         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function ProveedorCheck() As Boolean
      Dim oProveedorDes As New clsProveedor(clsAppInfo.ConnectString)
      ProveedorCheck = True

      Try

         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("ProveedorId").Value) > 0 Then
               oProveedorDes.SelectFilter = clsProveedor.SelectFilters.All
               oProveedorDes.WhereFilter = clsProveedor.WhereFilters.ProveedorCod
               oProveedorDes.EmpresaId = clsAppInfo.EmpresaId
               oProveedorDes.ProveedorCod = ToStr(oRow.Cells("ProveedorCod").Value)

               If Not oProveedorDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("DevCompraId").Value), 0, ToLong(oRow.Cells("DevCompraNro").Value), oProveedorDes.TableName, ToLong(oRow.Cells("ProveedorId").Value), ToStr(oRow.Cells("ProveedorCod").Value) & " - Proveedor No Existe en la Base de Datos Destino"))
                  ProveedorCheck = False
               End If
            End If
         Next


         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function NotaCheck() As Boolean
      Dim oNotaDes As New clsNota(clsAppInfo.ConnectString)

      NotaCheck = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("NotaNro").Value) > 0 Then
               oNotaDes.SelectFilter = clsNota.SelectFilters.All
               oNotaDes.WhereFilter = clsNota.WhereFilters.NotaNro
               oNotaDes.EmpresaId = clsAppInfo.EmpresaId
               oNotaDes.GestionId = clsAppInfo.GestionId
               oNotaDes.TipoNotaId = ToLong(oRow.Cells("TipoNotaId").Value)
               oNotaDes.NotaNro = ToLong(oRow.Cells("NotaNro").Value)
               oNotaDes.SucursalId = ToLong(oRow.Cells("SucursalId").Value)

               If Not oNotaDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("DevCompraId").Value), 0, ToLong(oRow.Cells("DevCompraNro").Value), oNotaDes.TableName, ToLong(oRow.Cells("NotaNro").Value), ToStr(oRow.Cells("NotaNro").Value) & " - Nota No Existe en la Base de Datos Destino"))
                  NotaCheck = False
               End If

               oNotaDes.SelectFilter = clsNota.SelectFilters.All
               oNotaDes.WhereFilter = clsNota.WhereFilters.NotaNro
               oNotaDes.EmpresaId = clsAppInfo.EmpresaId
               oNotaDes.GestionId = clsAppInfo.GestionId
               oNotaDes.TipoNotaId = ToLong(oRow.Cells("TipoNotaId").Value)
               oNotaDes.NotaNro = ToLong(oRow.Cells("NotaNro").Value)
               oNotaDes.SucursalId = ToLong(oRow.Cells("SucursalId").Value)

               If Not oNotaDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("DevCompraId").Value), 0, ToLong(oRow.Cells("DevCompraNro").Value), oNotaDes.TableName, ToLong(oRow.Cells("NotaNro").Value), ToStr(oRow.Cells("NotaNro").Value) & " - Nota No Existe en la Base de Datos Destino"))
                  NotaCheck = False
               End If
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function CompCheck() As Boolean
      Dim oCompDes As New clsComp(clsAppInfo.ConnectString)

      CompCheck = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("CompNro").Value) > 0 Then
               oCompDes.SelectFilter = clsComp.SelectFilters.All
               oCompDes.WhereFilter = clsComp.WhereFilters.CompNro
               oCompDes.EmpresaId = clsAppInfo.EmpresaId
               oCompDes.GestionId = clsAppInfo.GestionId
               oCompDes.TipoCompId = ToLong(oRow.Cells("TipoCompId").Value)
               oCompDes.CompNro = ToLong(oRow.Cells("CompNro").Value)
               oCompDes.SucursalId = ToLong(oRow.Cells("SucursalId").Value)

               If Not oCompDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("DevCompraId").Value), 0, ToLong(oRow.Cells("DevCompraNro").Value), oCompDes.TableName, ToLong(oRow.Cells("CompNro").Value), ToStr(oRow.Cells("CompNro").Value) & " - Comp No Existe en la Base de Datos Destino"))
                  CompCheck = False
               End If
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function PlanCheck() As Boolean
      Dim oPlanDes As New clsPlan(clsAppInfo.ConnectString)

      PlanCheck = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("PlanId").Value) > 0 Then
               oPlanDes.SelectFilter = clsPlan.SelectFilters.All
               oPlanDes.WhereFilter = clsPlan.WhereFilters.PlanCta
               oPlanDes.EmpresaId = clsAppInfo.EmpresaId
               oPlanDes.TipoPlanId = ToLong(oRow.Cells("TipoPlanId").Value)
               oPlanDes.PlanCta = ToStr(oRow.Cells("PlanCta").Value)

               If Not oPlanDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("DevCompraId").Value), 0, ToLong(oRow.Cells("DevCompraNro").Value), oPlanDes.TableName, ToLong(oRow.Cells("PlanId").Value), "Cuenta " & ToStr(oRow.Cells("PlanCta").Value) & " No Existe en la Base de Datos Destino"))
                  PlanCheck = False
               End If
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function CompraCheck() As Boolean
      Dim oCompraDes As New clsCompra(clsAppInfo.ConnectString)

      CompraCheck = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("CompraId").Value) > 0 Then
               oCompraDes.SelectFilter = clsCompra.SelectFilters.All
               oCompraDes.WhereFilter = clsCompra.WhereFilters.COMPRA_NRO
               oCompraDes.EmpresaId = clsAppInfo.EmpresaId
               oCompraDes.GestionId = clsAppInfo.GestionId
               oCompraDes.CompraNro = ToLong(oRow.Cells("CompraNro").Value)

               If Not oCompraDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("DevCompraId").Value), 0, ToLong(oRow.Cells("DevCompraNro").Value), oCompraDes.TableName, ToLong(oRow.Cells("CompraNro").Value), ToStr(oRow.Cells("CompraNro").Value) & " - Compra No Existe en la Base de Datos Destino"))
                  CompraCheck = False
               End If
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = mFrm.MdiParent
            frm.ArrayColumName = mArrayColumName
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function GetRow(ByVal lngTablaId As Long, ByVal lngTablaDetId As Long, ByVal lngTablaNro As Long, _
                        ByVal strTablaDes As String, ByVal lngDocumentoId As Long, ByVal strErrorDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("TablaId") = lngTablaId
      oRow("TablaDetId") = lngTablaDetId
      oRow("TablaNro") = lngTablaNro
      oRow("TablaDes") = strTablaDes
      oRow("DocumentoId") = lngDocumentoId
      oRow("ErrorDes") = strErrorDes

      Return oRow
   End Function

   Private Function GetRowItem(ByVal lngDocumentoDetIdOrg As Long, ByVal lngItemIdOrg As Long, ByVal strItemCodOrg As String, ByVal strItemDesOrg As String, ByVal lngMedidaIdOrg As Long, _
                              ByVal lngMedidaIdEquiOrg As Long, ByVal decMedidaCantEquiOrg As Decimal, ByVal lngTipoItemIdOrg As Long, ByVal bytControlLoteOrg As Byte, _
                              ByVal bytControlSerieOrg As Byte, ByVal lngMonedaIdCosOrg As Long, ByVal lngMonedaIdVenOrg As Long, ByVal lngTipoCosteoIdOrg As Long, ByVal lngPlanGrupoIdOrg As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTableItem.NewRow

      oRow("DocumentoIdDetOrg") = lngDocumentoDetIdOrg
      oRow("ItemIdOrg") = lngItemIdOrg
      oRow("ItemCodOrg") = strItemCodOrg
      oRow("ItemDesOrg") = strItemDesOrg
      oRow("MedidaIdOrg") = lngMedidaIdOrg
      oRow("MedidaIdEquiOrg") = lngMedidaIdEquiOrg
      oRow("MedidaCantEquiOrg") = decMedidaCantEquiOrg
      oRow("TipoItemIdOrg") = lngTipoItemIdOrg
      oRow("ControlLoteOrg") = bytControlLoteOrg
      oRow("ControlSerieOrg") = bytControlSerieOrg
      oRow("MonedaIdCosOrg") = lngMonedaIdCosOrg
      oRow("MonedaIdVenOrg") = lngMonedaIdVenOrg
      oRow("TipoCosteoIdOrg") = lngTipoCosteoIdOrg
      oRow("PlanGrupoIdOrg") = lngPlanGrupoIdOrg

      Return oRow
   End Function

   Private Function moDataTableItemCodFind(ByVal strItemCod As String) As Boolean
      moDataTableItemCodFind = False

      For Each oRow As DataRow In moDataTableItem.Rows
         If ToStr(oRow("ItemCodOrg")) = strItemCod Then
            Return True
         End If
      Next
   End Function

   Private Function MedidaDesFind(ByVal strConnectString As String, ByVal lngMedidaId As Long) As String
      Dim oMedida As New clsMedida(strConnectString)

      MedidaDesFind = ""

      Try
         With oMedida
            .MedidaId = lngMedidaId

            If .FindByPK Then
               MedidaDesFind = .MedidaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()

      End Try
   End Function

   Private Function MedidaIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strMedidaDes As String) As Long
      Dim oMedida As New clsMedida(strConnectString)

      MedidaIdFind = 0

      Try
         With oMedida
            .SelectFilter = clsMedida.SelectFilters.All
            .WhereFilter = clsMedida.WhereFilters.MedidaDes
            .EmpresaId = lngEmpresaId
            .MedidaDes = strMedidaDes

            If .Find Then
               MedidaIdFind = .MedidaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()

      End Try
   End Function

   Private Function ItemCodFind(ByVal strConnectString As String, ByVal lngItemId As Long) As String
      Dim oItem As New clsItem(strConnectString)

      ItemCodFind = ""

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               ItemCodFind = .ItemCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   Private Function ItemIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strItemCod As String) As Long
      Dim oItem As New clsItem(strConnectString)

      ItemIdFind = 0

      Try
         With oItem
            .SelectFilter = clsItem.SelectFilters.All
            .WhereFilter = clsItem.WhereFilters.ItemCod
            .EmpresaId = lngEmpresaId
            .ItemCod = strItemCod

            If .Find Then
               ItemIdFind = .ItemId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   Public Function DataImport() As Boolean
      Dim lngDevCompraIdDes As Long
      Dim lngCompId As Long
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long

      moStopwatch = Stopwatch.StartNew()
      DataImport = False

      Dim lngProveedorMovId As Long

      Try
         If GridCheck() Then
            If MessageBox.Show("¿Realmente Quiere Importar la Información Seleccionada?", mFrm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               mintRowSel = grdMain.GetCheckedRows.Count
               mintRowExport = 0

               pbrMain.Minimum = 0
               pbrMain.Maximum = mintRowSel
               pbrMain.Value = 0
               pbrMain.Show()

               For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  lngProveedorMovId = 0
                  lngCompId = 0
                  lngTipoCompId = 0
                  lngCompNro = 0

                  'Add Compra
                  If DevCompraAdd(ToLong(oRow.Cells("DevCompraId").Value), lngDevCompraIdDes) Then

                     'Add Detalle
                     If DevCompraDetAdd(ToLong(oRow.Cells("DevCompraId").Value), lngDevCompraIdDes, moDevCompraDes.CompraId _
                                        , moDevCompraDes.AlmacenId, moDevCompraDes.ProveedorId) Then

                        Call isCompFind(moDevCompraDes.CompId, lngTipoCompId, lngCompNro)
                        'Add Movimiento de Proveedor
                        If ProveedorMovAdd(lngProveedorMovId, 3, moDevCompraDes.DevCompraId, moDevCompraDes.TipoPagoId, moDevCompraDes.MontoOrg, 1, lngCompId, lngCompNro, moDevCompraDes.PlanId) Then

                           oRow.BeginEdit()
                           oRow.Cells("RowImport").Value = 1
                           oRow.EndEdit()

                           mintRowExport += 1

                           pbrMain.Value = mintRowExport
                           pbrMain.Update()

                        End If

                     End If
                  End If
               Next


               If mintRowExport = mintRowSel Then
                  DataImport = True
               Else
                  If moDataSet.Tables("Errores").Rows.Count() > 0 Then
                     Dim frm As New frmDataBaseError
                     frm.MdiParent = frm.MdiParent
                     frm.ArrayColumName = mArrayColumName
                     frm.DataObject = moDataSet
                     frm.Show()

                  Else
                     MessageBox.Show(ToStr(mintRowExport) & " de " & ToStr(mintRowSel) & " Registros Importados Exitosamente", mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               End If
            End If
         End If

         moTimeSpan = moStopwatch.Elapsed

      Catch exp As Exception
         moTimeSpan = moStopwatch.Elapsed

         MessageBox.Show(exp.Message & vbCrLf & "Tiempo Estimado " & moTimeSpan.ToString, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal lngTipoPagoId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moDevCompraDes.EmpresaId
            .GestionId = moDevCompraDes.GestionId
            .ProveedorId = moDevCompraDes.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moDevCompraDes.Fecha
            .ProveedorMovDes = ""
            .MonedaId = moDevCompraDes.MonedaId
            .TipoCambio = moDevCompraDes.TipoCambio
            .CentroCostoId = moDevCompraDes.CentroCostoId
            .SucursalId = moDevCompraDes.SucursalId
            .EstadoId = 11 'Abierto

            If lngTipoPagoId = 1 Then 'Contado
               If .MonedaId = 1 Then
                  .DebeBs = decValor
                  .DebeUs = ToDecimal(decValor / .TipoCambio)

                  .HaberBs = .DebeBs
                  .HaberUs = .DebeUs

               ElseIf .MonedaId = 2 Then
                  .DebeBs = ToDecimal(decValor * .TipoCambio)
                  .DebeUs = decValor

                  .HaberBs = .DebeBs
                  .HaberUs = .DebeUs
               End If

            Else 'Credito
               If .MonedaId = 1 Then
                  If lngCol = 1 Then
                     .DebeBs = decValor
                     .DebeUs = ToDecimal(decValor / .TipoCambio)

                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberBs = decValor
                     .HaberUs = ToDecimal(decValor / .TipoCambio)

                     .DebeBs = 0
                     .DebeUs = 0
                  End If

               ElseIf .MonedaId = 2 Then
                  If lngCol = 1 Then
                     .DebeBs = ToDecimal(decValor * .TipoCambio)
                     .DebeUs = decValor

                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberBs = ToDecimal(decValor * .TipoCambio)
                     .HaberUs = decValor

                     .DebeUs = 0
                     .DebeBs = 0
                  End If
               End If
            End If

            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .PlanId = lngPlanId

            If .Insert() Then
               lngProveedorMovId = .ProveedorMovId
               ProveedorMovAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function DevCompraAdd(ByVal lngDevCompraIdOrg As Long, ByRef lngDevCompraIdDes As Long) As Boolean
      moDevCompraOrg = New clsDevCompra(mstrConnectStringOrg)
      moDevCompraDes = New clsDevCompra(clsAppInfo.ConnectString)

      Dim strAlmacenCodOrg As String
      Dim lngAlmacenIdDest As Long

      Dim strProveedorCodOrg As String
      Dim lngProveedorIdDest As Long

      Dim strPlanCtaOrg As String
      Dim lngTipoPlanIdOrg As Long
      Dim lngPlanIdDest As Long

      Dim lngCompraNroOrg As Long
      Dim lngCompraIdDst As Long

      DevCompraAdd = False

      Try
         moDevCompraOrg.DevCompraId = lngDevCompraIdOrg

         If moDevCompraOrg.FindByPK Then

            With moDevCompraDes
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .DevCompraNro = moDevCompraOrg.DevCompraNro
               .Fecha = ToDate(moDevCompraOrg.Fecha)

               strAlmacenCodOrg = AlmacenCodFind(mstrConnectStringOrg, moDevCompraOrg.AlmacenId)
               lngAlmacenIdDest = AlmacenIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strAlmacenCodOrg)
               .AlmacenId = lngAlmacenIdDest

               strProveedorCodOrg = ProveedorCodFind(mstrConnectStringOrg, moDevCompraOrg.ProveedorId)
               lngProveedorIdDest = ProveedorIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strProveedorCodOrg)
               .ProveedorId = lngProveedorIdDest

               .MonedaId = moDevCompraOrg.MonedaId
               .TipoCambio = moDevCompraOrg.TipoCambio
               .DevCompraDes = moDevCompraOrg.DevCompraDes
               .DevCompraObs = moDevCompraOrg.DevCompraObs
               .TipoPagoId = moDevCompraOrg.TipoPagoId
               .MontoOrg = moDevCompraOrg.MontoOrg
               .MontoCos = moDevCompraOrg.MontoCos
               .MontoNet = moDevCompraOrg.MontoNet
               '.TipoNotaId = moDevCompraOrg.TipoNotaId
               '.NotaNro = moDevCompraOrg.NotaNro
               '.TipoCompId = moDevCompraOrg.TipoCompId
               '.CompNro = moDevCompraOrg.CompNro
               .NotaId = moDevCompraOrg.NotaId
               .CompId = moDevCompraOrg.CompId
               .SucursalId = moDevCompraOrg.SucursalId

               strPlanCtaOrg = PlanCtaFind(mstrConnectStringOrg, moDevCompraOrg.PlanId, lngTipoPlanIdOrg)
               lngPlanIdDest = PlanIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanCtaOrg, lngTipoPlanIdOrg)
               .PlanId = lngPlanIdDest

               lngCompraNroOrg = CompraNroFind(mstrConnectStringOrg, moDevCompraOrg.CompraId)
               lngCompraIdDst = CompraIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngCompraNroOrg)
               .CompraId = lngCompraIdDst

               .CreditoId = 0 'moDevCompraOrg.CreditoId
               .ConFac = moDevCompraOrg.ConFac
               .SinFac = moDevCompraOrg.SinFac
               .EstadoId = moDevCompraOrg.EstadoId

               If .Insert() Then
                  lngDevCompraIdDes = .DevCompraId
                  DevCompraAdd = True
               End If
            End With
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngDevCompraIdOrg, 0, moDevCompraOrg.DevCompraNro, moDevCompraOrg.TableName, lngDevCompraIdOrg, exp.Message))

      End Try
   End Function

   Private Function DevCompraDetAdd(ByVal lngDevCompraIdOrg As Long, ByVal lngDevCompraIdDes As Long, ByVal lngCompraIdDst As Long _
                                    , ByVal lngAlmacenIdDest As Long, ByVal lngProveedorIdDest As Long) As Boolean
      Dim strItemCodOrg As String
      Dim lngItemIdDes As Long

      DevCompraDetAdd = False

      moDevCompraDetOrg = New clsDevCompraDet(mstrConnectStringOrg)
      moDevCompraDetDes = New clsDevCompraDet(clsAppInfo.ConnectString)

      Try
         moDevCompraDetOrg.SelectFilter = clsDevCompraDet.SelectFilters.All
         moDevCompraDetOrg.WhereFilter = clsDevCompraDet.WhereFilters.DEVCOMPRAID
         moDevCompraDetOrg.OrderByFilter = clsDevCompraDet.OrderByFilters.DevCompraDetId
         moDevCompraDetOrg.EmpresaId = mlngEmpresaIdOrg
         moDevCompraDetOrg.DevCompraId = lngDevCompraIdOrg

         If moDevCompraDetOrg.Open() Then
            If moDevCompraDetOrg.DataSet.Tables(moDevCompraDetOrg.TableName).Rows.Count > 0 Then
               Do While moDevCompraDetOrg.Read()

                  strItemCodOrg = ItemCodFind(mstrConnectStringOrg, moDevCompraDetOrg.ItemId)
                  lngItemIdDes = ItemIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strItemCodOrg)

                  If lngItemIdDes > 0 Then
                     With moDevCompraDetDes
                        .DevCompraId = lngDevCompraIdDes
                        .EmpresaId = clsAppInfo.EmpresaId
                        .GestionId = clsAppInfo.GestionId
                        .Fecha = ToDate(moDevCompraDetOrg.Fecha)

                        .CompraId = lngCompraIdDst
                        .AlmacenId = lngAlmacenIdDest
                        .ProveedorId = lngProveedorIdDest

                        .MonedaId = moDevCompraDetOrg.MonedaId
                        .TipoCambio = moDevCompraDetOrg.TipoCambio
                        .ItemId = lngItemIdDes

                        Dim strMedidaDesOrg As String = MedidaDesFind(mstrConnectStringOrg, moDevCompraDetOrg.MedidaId)
                        Dim lngMedidaIdDest As Long = MedidaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strMedidaDesOrg)
                        .MedidaId = lngMedidaIdDest

                        .CantidadOrg = moDevCompraDetOrg.CantidadOrg
                        .CantidadDev = moDevCompraDetOrg.CantidadDev
                        .PrecioOrg = moDevCompraDetOrg.PrecioOrg
                        .PrecioCos = moDevCompraDetOrg.PrecioCos
                        .PrecioNet = moDevCompraDetOrg.PrecioNet
                        .Importe = moDevCompraDetOrg.Importe
                        .SucursalId = moDevCompraDetOrg.SucursalId

                        .EstadoId = moDevCompraDetOrg.EstadoId

                        If .Insert() Then
                           DevCompraDetAdd = True
                        End If
                     End With
                  End If

                  moDevCompraDetOrg.MoveNext()
               Loop

            Else
               DevCompraDetAdd = True
            End If
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngDevCompraIdOrg, moDevCompraDetOrg.DevCompraDetId, moDevCompraOrg.DevCompraNro, moDevCompraDetOrg.TableName, moDevCompraDetOrg.DevCompraDetId, exp.Message))

      End Try
   End Function

   Private Function CompNroFind(ByVal strConnectString As String, ByVal lngCompId As Long, ByRef lngTipoCompId As Long) As Long
      Dim oComp As New clsComp(strConnectString)

      CompNroFind = ""

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               CompNroFind = .CompNro
               lngTipoCompId = .TipoCompId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngCompNro As Long, ByVal lngTipoCompId As Long, ByVal lngSucursalId As Long) As Long
      Dim oComp As New clsComp(strConnectString)

      CompIdFind = 0
      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .SucursalId = lngSucursalId

            If .Find Then
               CompIdFind = .CompId
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function isCompFind(ByVal lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      isCompFind = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               lngTipoCompId = .TipoCompId
               lngCompNro = .CompNro

               isCompFind = True
            End If
         End With

      Catch exp As Exception
         'MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function AlmacenCodFind(ByVal strConnectString As String, ByVal lngAlmacenId As Long) As String
      Dim oAlmacen As New clsAlmacen(strConnectString)

      AlmacenCodFind = ""

      Try
         With oAlmacen
            .AlmacenId = lngAlmacenId

            If .FindByPK Then
               AlmacenCodFind = .AlmacenCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()

      End Try
   End Function

   Private Function AlmacenIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strAlmacenCod As String) As Long
      Dim oAlmacen As New clsAlmacen(strConnectString)

      AlmacenIdFind = 0

      Try
         With oAlmacen
            .SelectFilter = clsAlmacen.SelectFilters.All
            .WhereFilter = clsAlmacen.WhereFilters.AlmacenCod
            .EmpresaId = lngEmpresaId
            .AlmacenCod = strAlmacenCod

            If .Find Then
               AlmacenIdFind = .AlmacenId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()

      End Try
   End Function

   Private Function CreditoNroFind(ByVal strConnectString As String, ByVal lngCreditoId As Long) As String
      Dim oCredito As New clsCredito(strConnectString)

      CreditoNroFind = ""

      Try
         With oCredito
            .CreditoId = lngCreditoId

            If .FindByPK Then
               CreditoNroFind = .CreditoNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function CreditoIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal strCreditoNro As String) As Long
      Dim oCredito As New clsCredito(strConnectString)

      CreditoIdFind = 0

      Try
         With oCredito
            .SelectFilter = clsCredito.SelectFilters.All
            .WhereFilter = clsCredito.WhereFilters.CREDITO_NRO
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .CreditoNro = strCreditoNro

            If .Find Then
               CreditoIdFind = .CreditoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCredito.Dispose()

      End Try
   End Function

   Private Function CompraNroFind(ByVal strConnectString As String, ByVal lngCompraId As Long) As Long
      Dim oCompra As New clsCompra(strConnectString)

      CompraNroFind = 0

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               CompraNroFind = .CompraNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function CompraIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngCompraNro As Long) As Long
      Dim oCompra As New clsCompra(strConnectString)

      CompraIdFind = 0

      Try
         With oCompra
            .SelectFilter = clsCompra.SelectFilters.All
            .WhereFilter = clsCompra.WhereFilters.COMPRA_NRO
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .CompraNro = lngCompraNro

            If .Find Then
               CompraIdFind = .CompraId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function ProveedorCodFind(ByVal strConnectString As String, ByVal lngProveedorId As Long) As String
      Dim oProveedor As New clsProveedor(strConnectString)

      ProveedorCodFind = ""

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               ProveedorCodFind = .ProveedorCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function ProveedorIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strProveedorCod As String) As Long
      Dim oProveedor As New clsProveedor(strConnectString)

      ProveedorIdFind = 0

      Try
         With oProveedor
            .SelectFilter = clsProveedor.SelectFilters.All
            .WhereFilter = clsProveedor.WhereFilters.ProveedorCod
            .EmpresaId = lngEmpresaId
            .ProveedorCod = strProveedorCod

            If .Find Then
               ProveedorIdFind = .ProveedorId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function PlanCtaFind(ByVal strConnectString As String, ByVal lngPlanId As Long, ByRef lngTipoPlanId As Long) As String
      Dim oPlan As New clsPlan(strConnectString)

      PlanCtaFind = ""

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               lngTipoPlanId = .TipoPlanId
               PlanCtaFind = .PlanCta
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function PlanIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strPlanCta As String, ByRef lngTipoPlanId As Long) As Long
      Dim oPlan As New clsPlan(strConnectString)

      PlanIdFind = 0

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanCta
            .EmpresaId = lngEmpresaId
            .TipoPlanId = lngTipoPlanId
            .PlanCta = strPlanCta

            If .Find Then
               PlanIdFind = .PlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

End Class
