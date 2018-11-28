Public Class clsCompraImport

   Private moCompra As clsCompra
   Private moCompraOrg As clsCompra
   Private moCompraDes As clsCompra
   Private moCompraDetOrg As clsCompraDet
   Private moCompraDetDes As clsCompraDet

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
      grdMain = mFrm.grdCompra
      pbrMain = mFrm.pbrMain
   End Sub

   Private Sub grdErrorColumName()
      ReDim mArrayColumName(5)
      mArrayColumName(0) = "CompraId"
      mArrayColumName(1) = "CompraDetId"
      mArrayColumName(2) = "CompraNro"
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

      If Not CompraSinDetalleCheck() Then
         Throw New Exception("Existen Compras Sin Detalle en Base de Datos Origen")
         GridCheck = False
      End If

      If Not CompraDuplicadoCheck() Then
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

      If Not FacturaCheck() Then
         Throw New Exception("Una o Mas Facturas No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not PolizaCheck() Then
         Throw New Exception("Una o Mas Polizas No Existen en la Base de Datos Destino")
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

      If Not PedCompraCheck() Then
         Throw New Exception("Una o Mas Pedidos de Compra No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      GridCheck = True
   End Function

   Private Function CompraSinDetalleCheck() As Boolean
      CompraSinDetalleCheck = True

      moCompraDetOrg = New clsCompraDet(mstrConnectStringOrg)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("EstadoId").Value) <> 12 Then
               With moCompraDetOrg
                  .SelectFilter = clsCompraDet.SelectFilters.All
                  .WhereFilter = clsCompraDet.WhereFilters.CompraId
                  .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
                  .CompraId = ToLong(oRow.Cells("CompraId").Value)

                  If .Open() Then
                     If .DataSet.Tables(.TableName).Rows.Count = 0 Then
                        moDataTable.Rows.Add(GetRow(.CompraId, 0, ToLong(oRow.Cells("CompraNro").Value), "tblCompra", .CompraId, "Compra Sin Detalle"))
                        CompraSinDetalleCheck = False
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

   Private Function CompraDuplicadoCheck() As Boolean
      Dim boolFind As Boolean

      CompraDuplicadoCheck = True

      moCompraDes = New clsCompra(clsAppInfo.ConnectString)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If oRow.Cells("CompraNro").Value > 0 Then
               For Each oRowFind As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  boolFind = False

                  If (oRow.Cells("CompraNro").Value = oRowFind.Cells("CompraNro").Value) _
                     And (oRow.Cells("CompraId").Value <> oRowFind.Cells("CompraId").Value) Then

                     boolFind = True
                     Exit For
                  End If
               Next

               If boolFind Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), "tblCompra", ToLong(oRow.Cells("CompraId").Value), "Número de Compra Duplicada en Base de Datos Origen"))

                  CompraDuplicadoCheck = False
               End If

               With moCompraDes
                  .SelectFilter = clsCompra.SelectFilters.All
                  .WhereFilter = clsCompra.WhereFilters.COMPRA_NRO
                  .EmpresaId = clsAppInfo.EmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .CompraNro = ToLong(oRow.Cells("CompraNro").Value)

                  If .Find Then
                     moDataTable.Rows.Add(GetRow(.CompraId, 0, .CompraNro, .TableName, .CompraId, "Número de Comprarobante Duplicado en Base de Datos Destino"))

                     CompraDuplicadoCheck = False
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
      moCompraDetOrg = New clsCompraDet(mstrConnectStringOrg)

      Dim listMedida = New Queue()

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            With moCompraDetOrg
               .SelectFilter = clsCompraDet.SelectFilters.CompraIdItem
               .WhereFilter = clsCompraDet.WhereFilters.CompraIdItem
               .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
               .CompraId = ToLong(oRow.Cells("CompraId").Value)

               If .Open() Then
                  For Each oRowCompraDet As DataRow In .DataSet.Tables(.TableName).Rows
                     If Not IsDBNull(oRowCompraDet("ItemItemId")) Then
                        If Not moDataTableItemCodFind(ToStr(oRowCompraDet("ItemCod"))) Then
                           moDataTableItem.Rows.Add(GetRowItem(oRowCompraDet("CompraDetId"), oRowCompraDet("ItemItemId"), oRowCompraDet("ItemCod"), oRowCompraDet("ItemDes"), _
                                                               oRowCompraDet("MedidaId"), oRowCompraDet("MedidaIdEqui"), oRowCompraDet("MedidaCantEqui"), oRowCompraDet("TipoItemId"), _
                                                               oRowCompraDet("ControlLote"), oRowCompraDet("ControlSerie"), oRowCompraDet("MonedaIdCos"), oRowCompraDet("MonedaIdVen"), oRowCompraDet("TipoCosteoId"), oRowCompraDet("PlanGrupoId")))
                        End If
                     Else
                        moDataTable.Rows.Add(GetRow(ToLong(oRowCompraDet("CompraId")), ToLong(oRowCompraDet("CompraDetId")), ToLong(oRowCompraDet("CompraDetItemId")), "invItem", 0, "ID de Item No Existe en invItem de la Base de Datos Origen"))
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
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, "invMedida", .MedidaId, strMedidaDesOrg & " - Medida Mínima No Existe en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  strMedidaDesOrg = MedidaDesFind(mstrConnectStringOrg, .MedidaIdEqui)
                  lngMedidaIdDes = MedidaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strMedidaDesOrg)

                  If lngMedidaIdDes = 0 Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, "invMedida", .MedidaId, strMedidaDesOrg & " - Medida Equivalente No Existe en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MedidaCantEquiOrg") <> .MedidaCantEqui Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Cantidad Equivalente No Coincide en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("TipoItemIdOrg") <> .TipoItemId Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Tipo de Item Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("ControlLoteOrg") <> .ControlLote Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Control de Lote Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("ControlSerieOrg") <> .ControlSerie Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Control de Número de Serie Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MonedaIdCosOrg") <> .MonedaIdCos Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Moneda de Costo Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MonedaIdVenOrg") <> .MonedaIdVen Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Moneda de Venta Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("TipoCosteoIdOrg") <> .TipoCosteoId Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("CompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Tipo de Costeo Diferente en la Base de Datos Destino"))
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), oAlmacenDes.TableName, ToLong(oRow.Cells("AlmacenId").Value), ToStr(oRow.Cells("AlmacenCod").Value) & " - Almacen No Existe en la Base de Datos Destino"))
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), oProveedorDes.TableName, ToLong(oRow.Cells("ProveedorId").Value), ToStr(oRow.Cells("ProveedorCod").Value) & " - Proveedor No Existe en la Base de Datos Destino"))
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

   Private Function FacturaCheck() As Boolean
      Dim oFacturaDes As New clsFactura(clsAppInfo.ConnectString)

      FacturaCheck = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            Dim fac As Long = oRow.Cells("CompraId").Value
            If ToLong(oRow.Cells("FacturaId").Value) > 0 Then
               oFacturaDes.SelectFilter = clsFactura.SelectFilters.All
               oFacturaDes.WhereFilter = clsFactura.WhereFilters.FacturaNroDuplicada
               oFacturaDes.EmpresaId = clsAppInfo.EmpresaId
               oFacturaDes.GestionId = clsAppInfo.GestionId
               oFacturaDes.NroAutorizacion = ToStr(oRow.Cells("NroAutorizacion").Value)
               oFacturaDes.FacturaNro = ToLong(oRow.Cells("FacturaNro").Value)
               oFacturaDes.TipoFacturaId = ToLong(oRow.Cells("TipoFacturaId").Value)

               If Not oFacturaDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), oFacturaDes.TableName, ToLong(oRow.Cells("FacturaId").Value), "Nro. Autorización " & ToStr(oRow.Cells("NroAutorizacion").Value) & " - Factura No Existe en la Base de Datos Destino"))
                  FacturaCheck = False
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

   Private Function PolizaCheck() As Boolean
      Dim oPolizaDes As New clsPoliza(clsAppInfo.ConnectString)

      PolizaCheck = True

      Try
         'For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
         '   If ToLong(oRow.Cells("PolizaId").Value) > 0 Then
         '      Dim strPolizaNro As String = PolizaNroFind(mstrConnectStringOrg, ToLong(oRow.Cells("PolizaId").Value))
         '      oPolizaDes.SelectFilter = clsPoliza.SelectFilters.All
         '      oPolizaDes.WhereFilter = clsPoliza.WhereFilters.PolizaNro
         '      oPolizaDes.EmpresaId = clsAppInfo.EmpresaId
         '      oPolizaDes.GestionId = clsAppInfo.GestionId
         '      oPolizaDes.PolizaNro = strPolizaNro

         '      If Not oPolizaDes.Find Then
         '         moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), oPolizaDes.TableName, ToStr(oRow.Cells("PolizaId").Value), ToStr(oRow.Cells("PolizaNro").Value) & " - Poliza No Existe en la Base de Datos Destino"))
         '         PolizaCheck = False
         '      End If
         '   End If
         'Next

         'If moDataSet.Tables("Errores").Rows.Count() > 0 Then
         '   Dim frm As New frmDataBaseError
         '   frm.MdiParent = mFrm.MdiParent
         '   frm.ArrayColumName = mArrayColumName
         '   frm.DataObject = moDataSet
         '   frm.Show()
         'End If
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), oNotaDes.TableName, ToLong(oRow.Cells("NotaNro").Value), ToStr(oRow.Cells("NotaNro").Value) & " - Nota No Existe en la Base de Datos Destino"))
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), oCompDes.TableName, ToLong(oRow.Cells("CompNro").Value), ToStr(oRow.Cells("CompNro").Value) & " - Comp No Existe en la Base de Datos Destino"))
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), oPlanDes.TableName, ToLong(oRow.Cells("PlanId").Value), "Cuenta " & ToStr(oRow.Cells("PlanCta").Value) & " No Existe en la Base de Datos Destino"))
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

   Private Function PedCompraCheck() As Boolean
      Dim oPedCompraDes As New clsPedCompra(clsAppInfo.ConnectString)

      PedCompraCheck = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("PedCompraId").Value) > 0 Then
               oPedCompraDes.SelectFilter = clsPedCompra.SelectFilters.All
               oPedCompraDes.WhereFilter = clsPedCompra.WhereFilters.PedCompraNro
               oPedCompraDes.EmpresaId = clsAppInfo.EmpresaId
               oPedCompraDes.GestionId = clsAppInfo.GestionId
               oPedCompraDes.PedCompraNro = ToLong(oRow.Cells("PedCompraNro").Value)

               If Not oPedCompraDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompraId").Value), 0, ToLong(oRow.Cells("CompraNro").Value), oPedCompraDes.TableName, ToLong(oRow.Cells("PedCompraNro").Value), ToStr(oRow.Cells("PedCompraNro").Value) & " - PedCompra No Existe en la Base de Datos Destino"))
                  PedCompraCheck = False
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
      Dim lngCompraIdDes As Long
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

                  'Add Compra
                  If CompraAdd(ToLong(oRow.Cells("CompraId").Value), lngCompraIdDes) Then
                     Call isCompFind(oRow.Cells("CompId").Value, lngTipoCompId, lngCompNro)

                     'Update
                     If moCompraDes.PedCompraId > 0 Then
                        Call UpdatePedCompra(clsAppInfo.ConnectString, lngCompraIdDes, moCompraDes.PedCompraId)  'Actualizar PedCompra
                     End If
                     Call UpdateAnticipoDet(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngCompraIdDes, 2) 'Actualizar AnticipoDet
                     'Trspaso
                     Call TraspCompraOtroCosto(ToLong(oRow.Cells("CompraId").Value), lngCompraIdDes)

                     'Add Detalle
                     If CompraDetAdd(ToLong(oRow.Cells("CompraId").Value), lngCompraIdDes, moCompraDes.AlmacenId, moCompraDes.ProveedorId) Then

                        If moCompraDes.TipoPagoId = 1 Then 'Contado

                           'Add Movimiento de Proveedor
                           If ProveedorMovAdd(lngProveedorMovId, 2, moCompraDes.CompraId, moCompraDes.TipoPagoId, moCompraDes.MontoLiq _
                                              , 2, lngTipoCompId, lngCompNro, moCompraDes.PlanId) Then

                              oRow.BeginEdit()
                              oRow.Cells("RowImport").Value = 1
                              oRow.EndEdit()

                              mintRowExport += 1

                              pbrMain.Value = mintRowExport
                              pbrMain.Update()

                           End If
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
            .EmpresaId = moCompraDes.EmpresaId
            .GestionId = moCompraDes.GestionId
            .ProveedorId = moCompraDes.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moCompraDes.Fecha
            .ProveedorMovDes = ""
            .MonedaId = moCompraDes.MonedaId
            .TipoCambio = moCompraDes.TipoCambio
            .CentroCostoId = moCompraDes.CentroCostoId
            .SucursalId = moCompraDes.SucursalId
            .EstadoId = 11 'Abierto

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

   Private Function AnticipoNroFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngCompraId As Long, ByVal lngTipoCompraId As Long) As Long
      Dim oAnticipo As New clsAnticipo(strConnectString)

      AnticipoNroFind = 0

      Try
         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.AnticipoNro
            .WhereFilter = clsAnticipo.WhereFilters.AnticipoNroDet
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .AnticipoId = lngCompraId
            .TipoAnticipoId = lngTipoCompraId

            If .Find Then
               AnticipoNroFind = .AnticipoNro
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function AnticipoIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal strAnticipoNro As String) As Long
      Dim oAnticipo As New clsAnticipo(strConnectString)

      AnticipoIdFind = 0

      Try
         With oAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.All
            .WhereFilter = clsAnticipo.WhereFilters.AnticipoNro
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .AnticipoNro = strAnticipoNro

            If .Find Then
               AnticipoIdFind = .AnticipoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function UpdateAnticipoDet(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngCompraId As Long, ByVal lngTipoCompraId As Long) As Boolean
      Dim oAnticipoDet As New clsAnticipoDet(strConnectString)
      Dim lngAnticipoNroOrg As Long = AnticipoNroFind(mstrConnectStringOrg, mlngEmpresaIdOrg, mlngGestionIdOrg, lngCompraId, lngTipoCompraId)
      Dim lngAnticipoIdDest As Long = AnticipoIdFind(strConnectString, lngEmpresaId, lngGestionId, lngAnticipoNroOrg)
      UpdateAnticipoDet = False

      Try
         If lngAnticipoIdDest > 0 Then

            With oAnticipoDet
               .UpdateFilter = clsAnticipoDet.UpdateFilters.DocumentoId
               .DocumentoId = lngCompraId
               .TipoCompraId = lngTipoCompraId
               .AnticipoId = lngAnticipoIdDest

               If .UpdateOnly Then
                  UpdateAnticipoDet = True
               End If
            End With

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function UpdatePedCompra(ByVal strConnectString As String, ByVal lngCompraId As Long, ByVal lngPedCompraId As Long) As Boolean
      Dim oPedCompra As New clsPedCompra(strConnectString)
      UpdatePedCompra = False

      Try
         With oPedCompra
            .UpdateFilter = clsPedCompra.UpdateFilters.CompraId
            .CompraId = lngCompraId
            .PedCompraId = lngPedCompraId

            If .UpdateOnly Then
               UpdatePedCompra = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Function

   Private Sub ItemParametro(ByVal strConnectString As String, ByVal lngItemId As Long)
      Dim oItem As New clsItem(strConnectString)

      Try
         mlngTipoItemId = 0
         mlngTipoCosteoId = 0
         mlngMedidaId = 0
         mlngMedidaIdEqui = 0
         mdecMedidaCantEqui = 0
         mlngMonedaIdCos = 0
         mboolControlLote = False
         mboolControlSerie = False

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngTipoItemId = .TipoItemId
               mlngTipoCosteoId = .TipoCosteoId
               mlngMedidaId = .MedidaId
               mlngMedidaIdEqui = .MedidaIdEqui
               mdecMedidaCantEqui = .MedidaCantEqui
               mlngMonedaIdCos = .MonedaIdCos
               mboolControlLote = ToBoolean(.ControlLote)
               mboolControlSerie = ToBoolean(.ControlSerie)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Function TraspCompraOtroCosto(ByVal lngCompraIdOrg As Long, ByVal lngCompraIdDst As Long) As Boolean
      Dim oCompraOtroCostoOrg As New clsCompraOtroCosto(mstrConnectStringOrg)
      Dim oCompraOtroCostoDst As New clsCompraOtroCosto(clsAppInfo.ConnectString)

      Dim strNroAutorizacionOrg As String
      Dim lngFacturaNroOrg As Long
      Dim lngTipoFacturaOrg As Long
      Dim lngFacturaIdDst As Long

      Dim strPlanCtaOrg As String
      Dim lngTipoPlanIdOrg As String
      Dim lngPlanIdDest As Long

      Dim lngCompNroOrg As Long
      Dim lngTipoCompIdOrg As Long
      Dim lngCompIdDst As Long

      Try
         oCompraOtroCostoOrg.SelectFilter = clsCompraOtroCosto.SelectFilters.All
         oCompraOtroCostoOrg.WhereFilter = clsCompraOtroCosto.WhereFilters.CompraId
         oCompraOtroCostoOrg.OrderByFilter = clsCompraOtroCosto.OrderByFilters.CompraOtroCostoId
         oCompraOtroCostoOrg.EmpresaId = mlngEmpresaIdOrg
         oCompraOtroCostoOrg.GestionId = mlngGestionIdOrg
         oCompraOtroCostoOrg.CompraId = lngCompraIdOrg

         If oCompraOtroCostoOrg.Open Then
            If oCompraOtroCostoOrg.DataSet.Tables(oCompraOtroCostoOrg.TableName).Rows.Count > 0 Then

               Do While oCompraOtroCostoOrg.Read()
                  With oCompraOtroCostoDst
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .CompraId = lngCompraIdDst
                     .PlanOtroCostoId = oCompraOtroCostoOrg.PlanOtroCostoId
                     .Fecha = ToDate(oCompraOtroCostoOrg.Fecha)
                     .CompraOtroCostoDes = oCompraOtroCostoOrg.CompraOtroCostoDes
                     .MonedaId = oCompraOtroCostoOrg.MonedaId
                     .Monto = oCompraOtroCostoOrg.Monto

                     lngCompNroOrg = CompNroFind(mstrConnectStringOrg, oCompraOtroCostoOrg.CompId, lngTipoCompIdOrg)
                     lngCompIdDst = CompIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngCompNroOrg, lngTipoCompIdOrg, clsAppInfo.SucursalId)
                     .CompId = lngCompIdDst

                     strPlanCtaOrg = PlanCtaFind(mstrConnectStringOrg, oCompraOtroCostoOrg.PlanId, lngTipoPlanIdOrg)
                     lngPlanIdDest = PlanIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanCtaOrg, lngTipoPlanIdOrg)
                     .PlanId = lngPlanIdDest

                     lngFacturaNroOrg = FacturaNroFind(mstrConnectStringOrg, oCompraOtroCostoOrg.FacturaId, strNroAutorizacionOrg, lngTipoFacturaOrg)
                     lngFacturaIdDst = FacturaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngFacturaNroOrg, strNroAutorizacionOrg, lngTipoFacturaOrg)
                     .FacturaId = lngFacturaIdDst

                     .EstadoId = oCompraOtroCostoOrg.EstadoId

                     If .Insert Then
                        Call TraspProrrateo(lngCompraIdOrg, lngCompraIdDst, oCompraOtroCostoOrg.CompraOtroCostoId, .CompraOtroCostoId)
                        TraspCompraOtroCosto = True
                     End If
                  End With

                  oCompraOtroCostoOrg.MoveNext()
               Loop

            End If
         End If
      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompraIdOrg, 0, moCompraOrg.CompraNro, moCompraOrg.TableName, lngCompraIdOrg, exp.Message))
      Finally
         oCompraOtroCostoOrg.Dispose()
         oCompraOtroCostoDst.Dispose()
      End Try

   End Function

   Private Function TraspProrrateo(ByVal lngCompraIdOrg As Long, ByVal lngCompraIdDst As Long, ByVal lngCompraOtroCostoIdOrg As Long, ByVal lngCompraOtroCostoIdDst As Long) As Boolean
      Dim oProrrateoOrg As New clsProrrateo(mstrConnectStringOrg)
      Dim oProrrateoDst As New clsProrrateo(clsAppInfo.ConnectString)

      Dim strItemCodOrg As String
      Dim lngItemIdDes As Long

      Try
         oProrrateoOrg.SelectFilter = clsProrrateo.SelectFilters.All
         oProrrateoOrg.WhereFilter = clsProrrateo.WhereFilters.COMPRA_OTROCOSTO_ID
         oProrrateoOrg.OrderByFilter = clsProrrateo.OrderByFilters.ProrrateoId
         oProrrateoOrg.EmpresaId = mlngEmpresaIdOrg
         oProrrateoOrg.GestionId = mlngGestionIdOrg
         oProrrateoOrg.CompraId = lngCompraIdOrg
         oProrrateoOrg.CompraOtroCostoId = lngCompraOtroCostoIdOrg

         If oProrrateoOrg.Open Then
            If oProrrateoOrg.DataSet.Tables(oProrrateoOrg.TableName).Rows.Count > 0 Then

               Do While oProrrateoOrg.Read()
                  With oProrrateoDst
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .CompraId = lngCompraIdDst
                     .CompraOtroCostoId = lngCompraOtroCostoIdDst

                     strItemCodOrg = ItemCodFind(mstrConnectStringOrg, oProrrateoOrg.ItemId)
                     lngItemIdDes = ItemIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strItemCodOrg)
                     .ItemId = lngItemIdDes

                     .MontoCos = oProrrateoOrg.MontoCos
                     .PrecioCif = oProrrateoOrg.PrecioCif

                     If .Insert Then
                        TraspProrrateo = True
                     End If

                  End With

                  oProrrateoOrg.MoveNext()
               Loop

            End If
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompraIdOrg, 0, moCompraOrg.CompraNro, moCompraOrg.TableName, lngCompraIdOrg, exp.Message))
      Finally
         oProrrateoOrg.Dispose()
         oProrrateoDst.Dispose()
      End Try

   End Function

   Private Function CompraAdd(ByVal lngCompraIdOrg As Long, ByRef lngCompraIdDes As Long) As Boolean
      moCompraOrg = New clsCompra(mstrConnectStringOrg)
      moCompraDes = New clsCompra(clsAppInfo.ConnectString)

      Dim strAlmacenCodOrg As String
      Dim lngAlmacenIdDest As Long

      Dim strProveedorCodOrg As String
      Dim lngProveedorIdDest As Long

      Dim strNroAutorizacionOrg As String
      Dim lngFacturaNroOrg As Long
      Dim lngTipoFacturaOrg As Long
      Dim lngFacturaIdDest As Long

      Dim strPolizaNroOrg As String
      Dim lngPolizaIdDest As Long

      Dim strPlanCtaOrg As String
      Dim lngTipoPlanIdOrg As Long
      Dim lngPlanIdDest As Long

      Dim lngPedCompraNroOrg As Long
      Dim lngPedCompraIdDest As Long

      CompraAdd = False

      Try
         moCompraOrg.CompraId = lngCompraIdOrg

         If moCompraOrg.FindByPK Then

            With moCompraDes
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .CompraNro = moCompraOrg.CompraNro
               .Fecha = ToDate(moCompraOrg.Fecha)

               strAlmacenCodOrg = AlmacenCodFind(mstrConnectStringOrg, moCompraOrg.AlmacenId)
               lngAlmacenIdDest = AlmacenIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strAlmacenCodOrg)
               .AlmacenId = lngAlmacenIdDest

               strProveedorCodOrg = ProveedorCodFind(mstrConnectStringOrg, moCompraOrg.ProveedorId)
               lngProveedorIdDest = ProveedorIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strProveedorCodOrg)
               .ProveedorId = lngProveedorIdDest

               .MonedaId = moCompraOrg.MonedaId
               .TipoCambio = moCompraOrg.TipoCambio
               .CompraOrden = moCompraOrg.CompraOrden
               .CompraDes = moCompraOrg.CompraDes
               .CompraObs = moCompraOrg.CompraObs
               .TipoPagoId = moCompraOrg.TipoPagoId
               .MontoOrg = moCompraOrg.MontoOrg
               .MontoCos = moCompraOrg.MontoCos
               .MontoAnt = moCompraOrg.MontoAnt
               .MontoRec = moCompraOrg.MontoRec
               .MontoDes = moCompraOrg.MontoDes
               .MontoOtro = moCompraOrg.MontoOtro
               .MontoNet = moCompraOrg.MontoNet
               .MontoLiq = moCompraOrg.MontoLiq

               lngFacturaNroOrg = FacturaNroFind(mstrConnectStringOrg, moCompraOrg.FacturaId, strNroAutorizacionOrg, lngTipoFacturaOrg)
               lngFacturaIdDest = FacturaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngFacturaNroOrg, strNroAutorizacionOrg, lngTipoFacturaOrg)
               .FacturaId = lngFacturaIdDest

               'strPolizaNroOrg = PolizaNroFind(mstrConnectStringOrg, moCompraOrg.PolizaId)
               'lngPolizaIdDest = PolizaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, strPolizaNroOrg)
               '.PolizaId = lngPolizaIdDest
               .PolizaId = moCompraOrg.PolizaId

               .PorIVA = moCompraOrg.PorIVA
               .PorPoliza = moCompraOrg.PorPoliza
               '.TipoNotaId = moCompraOrg.TipoNotaId
               '.NotaNro = moCompraOrg.NotaNro
               '.TipoCompId = moCompraOrg.TipoCompId
               '.CompNro = moCompraOrg.CompNro
               .NotaId = moCompra.NotaId
               .CompId = moCompra.CompId
               .SucursalId = moCompra.SucursalId

               strPlanCtaOrg = PlanCtaFind(mstrConnectStringOrg, moCompraOrg.PlanId, lngTipoPlanIdOrg)
               lngPlanIdDest = PlanIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanCtaOrg, lngTipoPlanIdOrg)
               .PlanId = lngPlanIdDest

               lngPedCompraNroOrg = PedCompraNroFind(mstrConnectStringOrg, moCompraOrg.PedCompraId)
               lngPedCompraIdDest = PedCompraIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngPedCompraNroOrg)
               .PedCompraId = lngPedCompraIdDest

               .CreditoId = 0 'moCompraOrg.CreditoId
               .ConFac = moCompraOrg.ConFac
               .SinFac = moCompraOrg.SinFac
               .MontoBru = moCompraOrg.MontoBru
               .EstadoId = moCompraOrg.EstadoId

               If .Insert() Then
                  lngCompraIdDes = .CompraId
                  CompraAdd = True
               End If
            End With
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompraIdOrg, 0, moCompraOrg.CompraNro, moCompraOrg.TableName, lngCompraIdOrg, exp.Message))

      End Try
   End Function

   Private Function CompraDetAdd(ByVal lngCompraIdOrg As Long, ByVal lngCompraIdDes As Long, ByVal lngAlmacenIdDest As Long _
                                 , ByVal lngProveedorIdDest As Long) As Boolean
      Dim strItemCodOrg As String
      Dim lngItemIdDes As Long

      CompraDetAdd = False

      moCompraDetOrg = New clsCompraDet(mstrConnectStringOrg)
      moCompraDetDes = New clsCompraDet(clsAppInfo.ConnectString)

      Try
         moCompraDetOrg.SelectFilter = clsCompraDet.SelectFilters.All
         moCompraDetOrg.WhereFilter = clsCompraDet.WhereFilters.CompraId
         moCompraDetOrg.OrderByFilter = clsCompraDet.OrderByFilters.CompraDetId
         moCompraDetOrg.EmpresaId = mlngEmpresaIdOrg
         moCompraDetOrg.CompraId = lngCompraIdOrg

         If moCompraDetOrg.Open() Then
            If moCompraDetOrg.DataSet.Tables(moCompraDetOrg.TableName).Rows.Count > 0 Then
               Do While moCompraDetOrg.Read()

                  strItemCodOrg = ItemCodFind(mstrConnectStringOrg, moCompraDetOrg.ItemId)
                  lngItemIdDes = ItemIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strItemCodOrg)

                  If lngItemIdDes > 0 Then
                     With moCompraDetDes
                        .CompraId = lngCompraIdDes
                        .EmpresaId = clsAppInfo.EmpresaId
                        .GestionId = clsAppInfo.GestionId
                        .Fecha = ToDate(moCompraDetOrg.Fecha)
                        .AlmacenId = lngAlmacenIdDest
                        .ProveedorId = lngProveedorIdDest
                        .MonedaId = moCompraDetOrg.MonedaId
                        .TipoCambio = moCompraDetOrg.TipoCambio
                        .ItemId = lngItemIdDes

                        Dim strMedidaDesOrg As String = MedidaDesFind(mstrConnectStringOrg, moCompraDetOrg.MedidaId)
                        Dim lngMedidaIdDest As Long = MedidaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strMedidaDesOrg)
                        .MedidaId = lngMedidaIdDest
                        .Cantidad = moCompraDetOrg.Cantidad
                        .PrecioOrg = moCompraDetOrg.PrecioOrg
                        .PrecioCos = moCompraDetOrg.PrecioCos
                        .Importe = moCompraDetOrg.Importe
                        .PrecioRec = moCompraDetOrg.PrecioRec
                        .PrecioDes = moCompraDetOrg.PrecioDes
                        .ImporteBru = moCompraDetOrg.ImporteBru
                        .CompraDetDes = moCompraDetOrg.CompraDetDes
                        .EstadoId = moCompraDetOrg.EstadoId

                        If .Insert() Then
                           CompraDetAdd = True
                        End If
                     End With
                  End If

                  moCompraDetOrg.MoveNext()
               Loop

            Else
               CompraDetAdd = True
            End If
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompraIdOrg, moCompraDetOrg.CompraDetId, moCompraOrg.CompraNro, moCompraDetOrg.TableName, moCompraDetOrg.CompraDetId, exp.Message))

      End Try
   End Function

   Private Function CompNroFind(ByVal strConnectString As String, ByVal lngCompId As Long, ByRef lngTipoCompId As Long) As Long
      Dim oComp As New clsComp(strConnectString)

      CompNroFind = 0

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

   Private Function FacturaNroFind(ByVal strConnectString As String, ByVal lngFacturaId As Long, ByRef strNroAutorizacion As String, ByRef lngTipoFacturaId As Long) As Long
      Dim oFactura As New clsFactura(strConnectString)

      FacturaNroFind = 0

      Try
         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               strNroAutorizacion = .NroAutorizacion
               FacturaNroFind = .FacturaNro
               lngTipoFacturaId = .TipoFacturaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function FacturaIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngFacturaNro As Long, ByVal strNroAutorizacion As String, ByVal lngTipoFacturaId As Long) As Long
      Dim oFactura As New clsFactura(strConnectString)

      FacturaIdFind = 0

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaNroDuplicada
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .NroAutorizacion = strNroAutorizacion
            .FacturaNro = lngFacturaNro
            .TipoFacturaId = lngTipoFacturaId

            If .Find Then
               FacturaIdFind = .FacturaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function PolizaNroFind(ByVal strConnectString As String, ByVal lngPolizaId As Long) As String
      Dim oPoliza As New clsPoliza(strConnectString)

      PolizaNroFind = ""

      Try
         With oPoliza
            .PolizaId = lngPolizaId

            If .FindByPK Then
               PolizaNroFind = .PolizaNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza.Dispose()

      End Try
   End Function

   Private Function PolizaIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal strPolizaNro As String) As Long
      Dim oPoliza As New clsPoliza(strConnectString)

      PolizaIdFind = 0

      Try
         With oPoliza
            .SelectFilter = clsPoliza.SelectFilters.All
            .WhereFilter = clsPoliza.WhereFilters.PolizaNro
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .PolizaNro = strPolizaNro

            If .Find Then
               PolizaIdFind = .PolizaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza.Dispose()

      End Try
   End Function

   Private Function PedCompraNroFind(ByVal strConnectString As String, ByVal lngPedCompraId As Long) As Long
      Dim oPedCompra As New clsPedCompra(strConnectString)

      PedCompraNroFind = 0

      Try
         With oPedCompra
            .PedCompraId = lngPedCompraId

            If .FindByPK Then
               PedCompraNroFind = .PedCompraNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Function

   Private Function PedCompraIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngPedCompraNro As Long) As Long
      Dim oPedCompra As New clsPedCompra(strConnectString)

      PedCompraIdFind = 0

      Try
         With oPedCompra
            .SelectFilter = clsPedCompra.SelectFilters.All
            .WhereFilter = clsPedCompra.WhereFilters.PedCompraNro
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .PedCompraNro = lngPedCompraNro

            If .Find Then
               PedCompraIdFind = .PedCompraId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

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
