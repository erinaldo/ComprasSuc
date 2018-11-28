Public Class clsPedCompraImport

   Private moPedCompra As clsPedCompra
   Private moPedCompraOrg As clsPedCompra
   Private moPedCompraDes As clsPedCompra
   Private moPedCompraDetOrg As clsPedCompraDet
   Private moPedCompraDetDes As clsPedCompraDet

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
      grdMain = mFrm.grdPedCompra
      pbrMain = mFrm.pbrMain
   End Sub

   Private Sub grdErrorColumName()
      ReDim mArrayColumName(5)
      mArrayColumName(0) = "PedCompraId"
      mArrayColumName(1) = "PedCompraDetId"
      mArrayColumName(2) = "PedCompraNro"
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

      If Not PedCompraSinDetalleCheck() Then
         Throw New Exception("Existen PedCompras Sin Detalle en Base de Datos Origen")
         GridCheck = False
      End If

      If Not PedCompraDuplicadoCheck() Then
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

      If Not MedidaCheck() Then
         Throw New Exception("Una o Mas Medidas No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      GridCheck = True
   End Function

   Private Function PedCompraSinDetalleCheck() As Boolean
      PedCompraSinDetalleCheck = True

      moPedCompraDetOrg = New clsPedCompraDet(mstrConnectStringOrg)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("EstadoId").Value) <> 12 Then
               With moPedCompraDetOrg
                  .SelectFilter = clsPedCompraDet.SelectFilters.All
                  .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraId
                  .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
                  .PedCompraId = ToLong(oRow.Cells("PedCompraId").Value)

                  If .Open() Then
                     If .DataSet.Tables(.TableName).Rows.Count = 0 Then
                        moDataTable.Rows.Add(GetRow(.PedCompraId, 0, ToLong(oRow.Cells("PedCompraNro").Value), "tblPedCompra", .PedCompraId, "PedCompra Sin Detalle"))
                        PedCompraSinDetalleCheck = False
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

   Private Function PedCompraDuplicadoCheck() As Boolean
      Dim boolFind As Boolean

      PedCompraDuplicadoCheck = True

      moPedCompraDes = New clsPedCompra(clsAppInfo.ConnectString)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If oRow.Cells("PedCompraNro").Value > 0 Then
               For Each oRowFind As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  boolFind = False

                  If (oRow.Cells("PedCompraNro").Value = oRowFind.Cells("PedCompraNro").Value) _
                     And (oRow.Cells("PedCompraId").Value <> oRowFind.Cells("PedCompraId").Value) Then

                     boolFind = True
                     Exit For
                  End If
               Next

               If boolFind Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PedCompraId").Value), 0, ToLong(oRow.Cells("PedCompraNro").Value), "tblPedCompra", ToLong(oRow.Cells("PedCompraId").Value), "Número de PedCompra Duplicada en Base de Datos Origen"))

                  PedCompraDuplicadoCheck = False
               End If

               With moPedCompraDes
                  .SelectFilter = clsPedCompra.SelectFilters.All
                  .WhereFilter = clsPedCompra.WhereFilters.PedCompraNro
                  .EmpresaId = clsAppInfo.EmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .PedCompraNro = ToLong(oRow.Cells("PedCompraNro").Value)

                  If .Find Then
                     moDataTable.Rows.Add(GetRow(.PedCompraId, 0, .PedCompraNro, .TableName, .PedCompraId, "Número de PedComprarobante Duplicado en Base de Datos Destino"))

                     PedCompraDuplicadoCheck = False
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

      moPedCompraDetOrg = New clsPedCompraDet(mstrConnectStringOrg)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            With moPedCompraDetOrg
               .SelectFilter = clsPedCompraDet.SelectFilters.PedCompraIdItem
               .WhereFilter = clsPedCompraDet.WhereFilters.PedCompraIdItem
               .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
               .PedCompraId = ToLong(oRow.Cells("PedCompraId").Value)

               If .Open() Then
                  For Each oRowPedCompraDet As DataRow In .DataSet.Tables(.TableName).Rows
                     If Not IsDBNull(oRowPedCompraDet("ItemItemId")) Then
                        If Not moDataTableItemCodFind(ToStr(oRowPedCompraDet("ItemCod"))) Then
                           moDataTableItem.Rows.Add(GetRowItem(oRowPedCompraDet("PedCompraDetId"), oRowPedCompraDet("ItemItemId"), oRowPedCompraDet("ItemCod"), oRowPedCompraDet("ItemDes"), _
                                                               oRowPedCompraDet("MedidaId"), oRowPedCompraDet("MedidaIdEqui"), oRowPedCompraDet("MedidaCantEqui"), oRowPedCompraDet("TipoItemId"), _
                                                               oRowPedCompraDet("ControlLote"), oRowPedCompraDet("ControlSerie"), oRowPedCompraDet("MonedaIdCos"), oRowPedCompraDet("MonedaIdVen"), oRowPedCompraDet("TipoCosteoId"), oRowPedCompraDet("PlanGrupoId")))
                        End If

                     Else
                        moDataTable.Rows.Add(GetRow(ToLong(oRowPedCompraDet("PedCompraId")), ToLong(oRowPedCompraDet("PedCompraDetId")), ToLong(oRowPedCompraDet("PedCompraDetItemId")), "invItem", 0, "ID de Item No Existe en invItem de la Base de Datos Origen"))
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
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, "invMedida", .MedidaId, strMedidaDesOrg & " - Medida Mínima No Existe en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  strMedidaDesOrg = MedidaDesFind(mstrConnectStringOrg, .MedidaIdEqui)
                  lngMedidaIdDes = MedidaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strMedidaDesOrg)

                  If lngMedidaIdDes = 0 Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, "invMedida", .MedidaId, strMedidaDesOrg & " - Medida Equivalente No Existe en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MedidaCantEquiOrg") <> .MedidaCantEqui Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Cantidad Equivalente No Coincide en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("TipoItemIdOrg") <> .TipoItemId Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Tipo de Item Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("ControlLoteOrg") <> .ControlLote Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Control de Lote Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("ControlSerieOrg") <> .ControlSerie Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Control de Número de Serie Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MonedaIdCosOrg") <> .MonedaIdCos Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Moneda de Costo Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("MonedaIdVenOrg") <> .MonedaIdVen Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Moneda de Venta Diferente en la Base de Datos Destino"))
                     ItemCheck = False
                  End If

                  If oRow("TipoCosteoIdOrg") <> .TipoCosteoId Then
                     moDataTable.Rows.Add(GetRow(0, ToLong(oRow("PedCompraDetIdOrg")), 0, .TableName, ToLong(oRow("ItemIdOrg")), ToStr(oRow("ItemCodOrg")) & " - Tipo de Costeo Diferente en la Base de Datos Destino"))
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PedCompraId").Value), 0, ToLong(oRow.Cells("PedCompraNro").Value), oAlmacenDes.TableName, ToLong(oRow.Cells("AlmacenId").Value), ToStr(oRow.Cells("AlmacenCod").Value) & " - Almacen No Existe en la Base de Datos Destino"))
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PedCompraId").Value), 0, ToLong(oRow.Cells("PedCompraNro").Value), oProveedorDes.TableName, ToLong(oRow.Cells("ProveedorId").Value), ToStr(oRow.Cells("ProveedorCod").Value) & " - Proveedor No Existe en la Base de Datos Destino"))
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

   Private Function MedidaCheck() As Boolean
      Dim oMedidaDes As New clsMedida(clsAppInfo.ConnectString)
      MedidaCheck = True

      Try
         moPedCompraDetOrg = New clsPedCompraDet(mstrConnectStringOrg)

         With moPedCompraDetOrg
            .SelectFilter = clsPedCompraDet.SelectFilters.MedidaDistinct
            .WhereFilter = clsPedCompraDet.WhereFilters.MedidaDistinct
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
      Dim lngPedCompraIdDes As Long

      moStopwatch = Stopwatch.StartNew()
      DataImport = False

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
                  If PedCompraAdd(ToLong(oRow.Cells("PedCompraId").Value), lngPedCompraIdDes) Then
                     If PedCompraDetAdd(ToLong(oRow.Cells("PedCompraId").Value), lngPedCompraIdDes, moPedCompraDes.AlmacenId, moPedCompraDes.ProveedorId) Then

                        oRow.BeginEdit()
                        oRow.Cells("RowImport").Value = 1
                        oRow.EndEdit()

                        mintRowExport += 1

                        pbrMain.Value = mintRowExport
                        pbrMain.Update()
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

   Private Function PedCompraAdd(ByVal lngPedCompraIdOrg As Long, ByRef lngPedCompraIdDes As Long) As Boolean
      moPedCompraOrg = New clsPedCompra(mstrConnectStringOrg)
      moPedCompraDes = New clsPedCompra(clsAppInfo.ConnectString)

      PedCompraAdd = False

      Try
         moPedCompraOrg.PedCompraId = lngPedCompraIdOrg

         If moPedCompraOrg.FindByPK Then

            With moPedCompraDes
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .PedCompraNro = moPedCompraOrg.PedCompraNro
               .Fecha = ToDate(moPedCompraOrg.Fecha)

               Dim strAlmacenCodOrg As String = AlmacenCodFind(mstrConnectStringOrg, moPedCompraOrg.AlmacenId)
               Dim lngAlmacenIdDest As Long = AlmacenIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strAlmacenCodOrg)
               .AlmacenId = lngAlmacenIdDest

               Dim strProveedorCodOrg As String = ProveedorCodFind(mstrConnectStringOrg, moPedCompraOrg.ProveedorId)
               Dim lngProveedorIdDest As Long = ProveedorIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strProveedorCodOrg)
               .ProveedorId = lngProveedorIdDest

               .MonedaId = moPedCompraOrg.MonedaId
               .TipoCambio = moPedCompraOrg.TipoCambio
               .PedCompraOrden = moPedCompraOrg.PedCompraOrden
               .PedCompraDes = moPedCompraOrg.PedCompraDes
               .PedCompraObs = moPedCompraOrg.PedCompraObs
               .PedCompraMonto = moPedCompraOrg.PedCompraMonto
               .CompraId = 0 'moPedCompraOrg.CompraId
               .MontoRec = moPedCompraOrg.MontoRec
               .MontoDes = moPedCompraOrg.MontoDes
               .MontoLiq = moPedCompraOrg.MontoLiq
               .CentroCostoId = moPedCompraOrg.CentroCostoId
               .SucursalId = moPedCompraOrg.SucursalId
               .EstadoId = moPedCompraOrg.EstadoId

               If .Insert() Then
                  lngPedCompraIdDes = .PedCompraId
                  PedCompraAdd = True
               End If
            End With
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngPedCompraIdOrg, 0, moPedCompraOrg.PedCompraNro, moPedCompraOrg.TableName, lngPedCompraIdOrg, exp.Message))

      End Try
   End Function

   Private Function PedCompraDetAdd(ByVal lngPedCompraIdOrg As Long, ByVal lngPedCompraIdDes As Long, ByVal lngAlmacenIdDest As Long _
                                    , ByVal lngProveedorIdDest As Long) As Boolean
      Dim strItemCodOrg As String
      Dim lngItemIdDes As Long

      PedCompraDetAdd = False

      moPedCompraDetOrg = New clsPedCompraDet(mstrConnectStringOrg)
      moPedCompraDetDes = New clsPedCompraDet(clsAppInfo.ConnectString)

      Try
         moPedCompraDetOrg.SelectFilter = clsPedCompraDet.SelectFilters.All
         moPedCompraDetOrg.WhereFilter = clsPedCompraDet.WhereFilters.PedCompraId
         moPedCompraDetOrg.OrderByFilter = clsPedCompraDet.OrderByFilters.PedCompraDetId
         moPedCompraDetOrg.EmpresaId = mlngEmpresaIdOrg
         moPedCompraDetOrg.PedCompraId = lngPedCompraIdOrg

         If moPedCompraDetOrg.Open() Then
            If moPedCompraDetOrg.DataSet.Tables(moPedCompraDetOrg.TableName).Rows.Count > 0 Then
               Do While moPedCompraDetOrg.Read()

                  strItemCodOrg = ItemCodFind(mstrConnectStringOrg, moPedCompraDetOrg.ItemId)
                  lngItemIdDes = ItemIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strItemCodOrg)

                  If lngItemIdDes > 0 Then
                     With moPedCompraDetDes
                        .PedCompraId = lngPedCompraIdDes
                        .EmpresaId = clsAppInfo.EmpresaId
                        .GestionId = clsAppInfo.GestionId
                        .Fecha = ToDate(moPedCompraDetOrg.Fecha)
                        .AlmacenId = lngAlmacenIdDest
                        .ProveedorId = lngProveedorIdDest

                        .MonedaId = moPedCompraDetOrg.MonedaId
                        .TipoCambio = moPedCompraDetOrg.TipoCambio
                        .ItemId = lngItemIdDes

                        Dim strMedidaDesOrg As String = MedidaDesFind(mstrConnectStringOrg, moPedCompraDetOrg.MedidaId)
                        Dim lngMedidaIdDest As Long = MedidaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strMedidaDesOrg)
                        .MedidaId = lngMedidaIdDest
                        .Cantidad = moPedCompraDetOrg.Cantidad
                        .Precio = moPedCompraDetOrg.Precio
                        .Importe = moPedCompraDetOrg.Importe
                        .PrecioRec = moPedCompraDetOrg.PrecioRec
                        .PrecioDes = moPedCompraDetOrg.PrecioDes
                        .ImporteBru = moPedCompraDetOrg.ImporteBru
                        .PedCompraDetDes = moPedCompraDetOrg.PedCompraDetDes
                        .CentroCostoId = moPedCompraDetOrg.CentroCostoId
                        .CentroCostoDetId = moPedCompraDetOrg.CentroCostoDetId
                        .SucursalId = moPedCompraDetOrg.SucursalId
                        .EstadoId = moPedCompraDetOrg.EstadoId

                        If .Insert() Then
                           PedCompraDetAdd = True
                        End If
                     End With
                  End If

                  moPedCompraDetOrg.MoveNext()
               Loop

            Else
               PedCompraDetAdd = True
            End If
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngPedCompraIdOrg, moPedCompraDetOrg.PedCompraDetId, moPedCompraOrg.PedCompraNro, moPedCompraDetOrg.TableName, moPedCompraDetOrg.PedCompraDetId, exp.Message))

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

End Class
