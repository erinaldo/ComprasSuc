Public Class clsPagoImport

   Private moPago As clsPago
   Private moPagoOrg As clsPago
   Private moPagoDes As clsPago
   Private moPagoDetOrg As clsPagoDet
   Private moPagoDetDes As clsPagoDet

   Friend mlngEmpresaIdOrg As Long
   Friend mlngGestionIdOrg As Long
   Friend mstrConnectStringOrg As String

   Private mintRowSel As Integer
   Private mintRowExport As Integer

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
      grdMain = mFrm.grdPago
      pbrMain = mFrm.pbrMain
   End Sub

   Private Sub grdErrorColumName()
      ReDim mArrayColumName(5)
      mArrayColumName(0) = "PagoId"
      mArrayColumName(1) = "PagoDetId"
      mArrayColumName(2) = "PagoNro"
      mArrayColumName(3) = "Tabla"
      mArrayColumName(4) = "Id"
      mArrayColumName(5) = "Descripción"
   End Sub

   Private Function gridCheck() As Boolean
      Dim strMsg As String = String.Empty

      If grdMain.GetCheckedRows.Count <= 0 Then
         Throw New Exception("Debe Seleccionar al Menos un Registro")
         GridCheck = False
      End If

      If Not PagoSinDetalleCheck() Then
         Throw New Exception("Existen Pagos Sin Detalle en Base de Datos Origen")
         GridCheck = False
      End If

      If Not PagoDuplicadoCheck() Then
         Throw New Exception("Existen Números de Comprobante Duplicados")
         GridCheck = False
      End If

      If Not ProveedorCheck() Then
         Throw New Exception("Una o Mas Proveedores No Existen en la Base de Datos Destino")
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

      If Not PlanRecargoCheck() Then
         Throw New Exception("Una o Mas Recargos No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not PlanDescuentoCheck() Then
         Throw New Exception("Una o Mas Descuentos No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not CompraCheck() Then
         Throw New Exception("Una o Mas Compras de Pago No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not CreditoCheck() Then
         Throw New Exception("Una o Mas Creditos de Pago No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      GridCheck = True
   End Function

   Private Function pagoSinDetalleCheck() As Boolean
      pagoSinDetalleCheck = True

      moPagoDetOrg = New clsPagoDet(mstrConnectStringOrg)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("EstadoId").Value) <> 12 Then
               With moPagoDetOrg
                  .SelectFilter = clsPagoDet.SelectFilters.All
                  .WhereFilter = clsPagoDet.WhereFilters.PagoId
                  .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
                  .PagoId = ToLong(oRow.Cells("PagoId").Value)

                  If .Open() Then
                     If .DataSet.Tables(.TableName).Rows.Count = 0 Then
                        moDataTable.Rows.Add(GetRow(.PagoId, 0, ToLong(oRow.Cells("PagoNro").Value), "tblPago", .PagoId, "Pago Sin Detalle"))
                        pagoSinDetalleCheck = False
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

   Private Function pagoDuplicadoCheck() As Boolean
      Dim boolFind As Boolean

      pagoDuplicadoCheck = True

      moPagoDes = New clsPago(clsAppInfo.ConnectString)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If oRow.Cells("PagoNro").Value > 0 Then
               For Each oRowFind As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  boolFind = False

                  If (oRow.Cells("PagoNro").Value = oRowFind.Cells("PagoNro").Value) _
                     And (oRow.Cells("PagoId").Value <> oRowFind.Cells("PagoId").Value) Then
                     boolFind = True
                     Exit For
                  End If
               Next

               If boolFind Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PagoId").Value), 0, ToLong(oRow.Cells("PagoNro").Value), "tblPago", ToLong(oRow.Cells("PagoId").Value), "Número de Pago Duplicada en Base de Datos Origen"))
                  pagoDuplicadoCheck = False
               End If

               With moPagoDes
                  .SelectFilter = clsPago.SelectFilters.All
                  .WhereFilter = clsPago.WhereFilters.PAGO_NRO
                  .EmpresaId = clsAppInfo.EmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .PagoNro = ToLong(oRow.Cells("PagoNro").Value)

                  If .Find Then
                     moDataTable.Rows.Add(GetRow(.PagoId, 0, .PagoNro, .TableName, .PagoId, "Número de Pagorobante Duplicado en Base de Datos Destino"))

                     pagoDuplicadoCheck = False
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

   Private Function proveedorCheck() As Boolean
      Dim oProveedorDes As New clsProveedor(clsAppInfo.ConnectString)
      proveedorCheck = True

      Try

         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("ProveedorId").Value) > 0 Then
               oProveedorDes.SelectFilter = clsProveedor.SelectFilters.All
               oProveedorDes.WhereFilter = clsProveedor.WhereFilters.ProveedorCod
               oProveedorDes.EmpresaId = clsAppInfo.EmpresaId
               oProveedorDes.ProveedorCod = ToStr(oRow.Cells("ProveedorCod").Value)

               If Not oProveedorDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PagoId").Value), 0, ToLong(oRow.Cells("PagoNro").Value), oProveedorDes.TableName, ToLong(oRow.Cells("ProveedorId").Value), ToStr(oRow.Cells("ProveedorCod").Value) & " - Proveedor No Existe en la Base de Datos Destino"))
                  proveedorCheck = False
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

   Private Function compCheck() As Boolean
      Dim oCompDes As New clsComp(clsAppInfo.ConnectString)

      compCheck = True

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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PagoId").Value), 0, ToLong(oRow.Cells("PagoNro").Value), oCompDes.TableName, ToLong(oRow.Cells("CompNro").Value), ToStr(oRow.Cells("CompNro").Value) & " - Comp No Existe en la Base de Datos Destino"))
                  compCheck = False
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

   Private Function planCheck() As Boolean
      Dim oPlanDes As New clsPlan(clsAppInfo.ConnectString)

      planCheck = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("PlanId").Value) > 0 Then
               oPlanDes.SelectFilter = clsPlan.SelectFilters.All
               oPlanDes.WhereFilter = clsPlan.WhereFilters.PlanCta
               oPlanDes.EmpresaId = clsAppInfo.EmpresaId
               oPlanDes.TipoPlanId = ToLong(oRow.Cells("TipoPlanId").Value)
               oPlanDes.PlanCta = ToStr(oRow.Cells("PlanCta").Value)

               If Not oPlanDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PagoId").Value), 0, ToLong(oRow.Cells("PagoNro").Value), oPlanDes.TableName, ToLong(oRow.Cells("PlanId").Value), "Cuenta " & ToStr(oRow.Cells("PlanCta").Value) & " No Existe en la Base de Datos Destino"))
                  planCheck = False
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
         moPagoDetOrg = New clsPagoDet(mstrConnectStringOrg)

         With moPagoDetOrg
            .SelectFilter = clsPagoDet.SelectFilters.COMPRA_DISTINCT
            .WhereFilter = clsPagoDet.WhereFilters.COMPRA_DISTINCT
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If ToLong(oRow("CompraId")) > 0 Then
                     oCompraDes.SelectFilter = clsCompra.SelectFilters.All
                     oCompraDes.WhereFilter = clsCompra.WhereFilters.COMPRA_NRO
                     oCompraDes.EmpresaId = clsAppInfo.EmpresaId
                     oCompraDes.GestionId = clsAppInfo.GestionId
                     oCompraDes.CompraNro = ToLong(oRow("CompraNro"))

                     If Not oCompraDes.Find Then
                        moDataTable.Rows.Add(GetRow(0, 0, 0, oCompraDes.TableName, ToLong(oRow("CompraId")), ToStr(oRow("CompraNro")) & " - Compra No Existe en la Base de Datos Destino"))
                        CompraCheck = False
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

   Private Function CreditoCheck() As Boolean
      Dim oCreditoDes As New clsCredito(clsAppInfo.ConnectString)
      CreditoCheck = True

      Try
         moPagoDetOrg = New clsPagoDet(mstrConnectStringOrg)

         With moPagoDetOrg
            .SelectFilter = clsPagoDet.SelectFilters.CREDITO_DISTINCT
            .WhereFilter = clsPagoDet.WhereFilters.CREDITO_DISTINCT
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If ToLong(oRow("CreditoId")) > 0 Then
                     oCreditoDes.SelectFilter = clsCredito.SelectFilters.All
                     oCreditoDes.WhereFilter = clsCredito.WhereFilters.CREDITO_NRO
                     oCreditoDes.EmpresaId = clsAppInfo.EmpresaId
                     oCreditoDes.GestionId = clsAppInfo.GestionId
                     oCreditoDes.CreditoNro = ToLong(oRow("CreditoNro"))

                     If Not oCreditoDes.Find Then
                        moDataTable.Rows.Add(GetRow(0, 0, 0, oCreditoDes.TableName, ToLong(oRow("CreditoId")), ToStr(oRow("CreditoNro")) & " - Credito No Existe en la Base de Datos Destino"))
                        CreditoCheck = False
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

   Private Function PlanRecargoCheck() As Boolean
      Dim oPlanRecargoDes As New clsPlanRecargo(clsAppInfo.ConnectString)
      PlanRecargoCheck = True

      Try

         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("PlanRecargoId").Value) > 0 Then
               oPlanRecargoDes.SelectFilter = clsPlanRecargo.SelectFilters.All
               oPlanRecargoDes.WhereFilter = clsPlanRecargo.WhereFilters.PlanRecargoDes
               oPlanRecargoDes.EmpresaId = clsAppInfo.EmpresaId
               oPlanRecargoDes.PlanRecargoDes = ToStr(oRow.Cells("PlanRecargoDes").Value)

               If Not oPlanRecargoDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PagoId").Value), 0, ToLong(oRow.Cells("PagoNro").Value), oPlanRecargoDes.TableName, ToLong(oRow.Cells("PlanRecargoId").Value), ToStr(oRow.Cells("PlanRecargoDes").Value) & " - PlanRecargo No Existe en la Base de Datos Destino"))
                  PlanRecargoCheck = False
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

   Private Function PlanDescuentoCheck() As Boolean
      Dim oPlanDescuentoDes As New clsPlanDescuento(clsAppInfo.ConnectString)
      PlanDescuentoCheck = True

      Try

         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("PlanDescuentoId").Value) > 0 Then
               oPlanDescuentoDes.SelectFilter = clsPlanDescuento.SelectFilters.All
               oPlanDescuentoDes.WhereFilter = clsPlanDescuento.WhereFilters.PlanDescuentoDes
               oPlanDescuentoDes.EmpresaId = clsAppInfo.EmpresaId
               oPlanDescuentoDes.PlanDescuentoDes = ToStr(oRow.Cells("PlanDescuentoDes").Value)

               If Not oPlanDescuentoDes.Find Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("PagoId").Value), 0, ToLong(oRow.Cells("PagoNro").Value), oPlanDescuentoDes.TableName, ToLong(oRow.Cells("PlanDescuentoId").Value), ToStr(oRow.Cells("PlanDescuentoDes").Value) & " - PlanDescuento No Existe en la Base de Datos Destino"))
                  PlanDescuentoCheck = False
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

   Public Function DataImport() As Boolean
      Dim lngPagoIdDes As Long
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

                  'Add Pago
                  If PagoAdd(ToLong(oRow.Cells("PagoId").Value), lngPagoIdDes) Then

                     'Add Detalle
                     If PagoDetAdd(ToLong(oRow.Cells("PagoId").Value), lngPagoIdDes, moPagoDes.ProveedorId) Then

                        Call isCompFind(moPagoDes.CompId, lngTipoCompId, lngCompNro)
                        'Add Proveedor
                        If ProveedorMovAdd(lngProveedorMovId, 7, moPagoDes.PagoId, moPagoDes.TipoPagoId, moPagoDes.PagoDes _
                                           , moPagoDes.Capital, 1, lngTipoCompId, lngCompNro, moPagoDes.PlanId) Then

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
                                    ByVal lngTipoPagoId As Long, ByVal strDes As String, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moPagoDes.EmpresaId
            .GestionId = moPagoDes.GestionId
            .ProveedorId = moPagoDes.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moPagoDes.Fecha
            .ProveedorMovDes = strDes
            .MonedaId = moPagoDes.MonedaId
            .TipoCambio = moPagoDes.TipoCambio
            .CentroCostoId = moPagoDes.CentroCostoId
            .SucursalId = moPagoDes.SucursalId
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

   Private Function PagoAdd(ByVal lngPagoIdOrg As Long, ByRef lngPagoIdDes As Long) As Boolean
      moPagoOrg = New clsPago(mstrConnectStringOrg)
      moPagoDes = New clsPago(clsAppInfo.ConnectString)

      Dim strAlmacenCodOrg As String
      Dim lngAlmacenIdDest As Long

      Dim strProveedorCodOrg As String
      Dim lngProveedorIdDest As Long

      Dim strPlanRecargoDesOrg As String
      Dim lngPlanRecargoIdDest As Long

      Dim strPlanDescuentoDesOrg As String
      Dim lngPlanDescuentoIdDest As Long

      Dim strPlanCtaOrg As String
      Dim lngTipoPlanIdOrg As Long
      Dim lngPlanIdDest As Long

      PagoAdd = False

      Try
         moPagoOrg.PagoId = lngPagoIdOrg

         If moPagoOrg.FindByPK Then

            With moPagoDes
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .TipoPagoId = moPagoOrg.TipoPagoId
               .PagoNro = moPagoOrg.PagoNro

               strProveedorCodOrg = ProveedorCodFind(mstrConnectStringOrg, moPagoOrg.ProveedorId)
               lngProveedorIdDest = ProveedorIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strProveedorCodOrg)
               .ProveedorId = lngProveedorIdDest

               .Fecha = ToDate(moPagoOrg.Fecha)
               .PagoDes = moPagoOrg.PagoDes
               .MonedaId = moPagoOrg.MonedaId
               .TipoCambio = moPagoOrg.TipoCambio
               .Capital = moPagoOrg.Capital
               .Interes = moPagoOrg.Interes
               .MontoPag = moPagoOrg.MontoPag

               strPlanRecargoDesOrg = PlanRecargoDesFind(mstrConnectStringOrg, moPagoOrg.PlanRecargoId)
               lngPlanRecargoIdDest = PlanRecargoIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanRecargoDesOrg)
               .PlanRecargoId = lngPlanRecargoIdDest

               .MontoRec = moPagoOrg.MontoRec

               strPlanDescuentoDesOrg = PlanDescuentoDesFind(mstrConnectStringOrg, moPagoOrg.PlanDescuentoId)
               lngPlanDescuentoIdDest = PlanDescuentoIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanDescuentoDesOrg)
               .PlanDescuentoId = lngPlanDescuentoIdDest

               .MontoDes = moPagoOrg.MontoDes
               .CompId = moPagoOrg.CompId

               strPlanCtaOrg = PlanCtaFind(mstrConnectStringOrg, moPagoOrg.PlanId, lngTipoPlanIdOrg)
               lngPlanIdDest = PlanIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanCtaOrg, lngTipoPlanIdOrg)
               .PlanId = lngPlanIdDest

               .ConFac = moPagoOrg.ConFac
               .SinFac = moPagoOrg.SinFac
               .SucursalId = moPagoOrg.SucursalId
               .EstadoId = moPagoOrg.EstadoId

               If .Insert() Then
                  lngPagoIdDes = .PagoId
                  PagoAdd = True
               End If
            End With
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngPagoIdOrg, 0, moPagoOrg.PagoNro, moPagoOrg.TableName, lngPagoIdOrg, exp.Message))

      End Try
   End Function

   Private Function PagoDetAdd(ByVal lngPagoIdOrg As Long, ByVal lngPagoIdDes As Long, ByVal lngProveedorIdDest As Long) As Boolean
      Dim strItemCodOrg As String
      Dim lngItemIdDes As Long

      PagoDetAdd = False

      moPagoDetOrg = New clsPagoDet(mstrConnectStringOrg)
      moPagoDetDes = New clsPagoDet(clsAppInfo.ConnectString)

      Dim lngCompraNroOrg As Long
      Dim lngCompraIdDst As Long

      Dim lngCreditoDetCuotaNroOrg As Long
      Dim lngCreditoDetIdDst As Long

      Dim lngCreditoNroOrg As Long
      Dim lngCreditoIdDst As Long

      Try
         moPagoDetOrg.SelectFilter = clsPagoDet.SelectFilters.All
         moPagoDetOrg.WhereFilter = clsPagoDet.WhereFilters.PagoId
         moPagoDetOrg.OrderByFilter = clsPagoDet.OrderByFilters.PagoDetId
         moPagoDetOrg.EmpresaId = mlngEmpresaIdOrg
         moPagoDetOrg.PagoId = lngPagoIdOrg

         If moPagoDetOrg.Open() Then
            If moPagoDetOrg.DataSet.Tables(moPagoDetOrg.TableName).Rows.Count > 0 Then
               Do While moPagoDetOrg.Read()

                  With moPagoDetDes
                     .PagoId = lngPagoIdDes
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .TipoPagoId = moPagoDetOrg.TipoPagoId

                     lngCompraNroOrg = CompraNroFind(mstrConnectStringOrg, moPagoDetOrg.CompraId)
                     lngCompraIdDst = CompraIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngCompraNroOrg)
                     .CompraId = lngCompraIdDst

                     lngCreditoNroOrg = CreditoNroFind(mstrConnectStringOrg, moPagoDetOrg.CreditoId)
                     lngCreditoIdDst = CreditoIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngCreditoNroOrg)
                     .CreditoId = lngCreditoIdDst

                     lngCreditoDetCuotaNroOrg = CreditoDetCuotaNroFind(mstrConnectStringOrg, moPagoDetOrg.CreditoDetId)
                     lngCreditoIdDst = CreditoDetIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, moPagoDetDes.CreditoId, lngCreditoDetCuotaNroOrg)
                     .CreditoDetId = lngCreditoIdDst

                     .Fecha = ToDate(moPagoDetOrg.Fecha)
                     .ProveedorId = lngProveedorIdDest
                     .MonedaId = moPagoDetOrg.MonedaId
                     .TipoCambio = moPagoDetOrg.TipoCambio
                     .CapitalOrg = moPagoDetOrg.CapitalOrg
                     .InteresOrg = moPagoDetOrg.InteresOrg
                     .CapitalAmo = moPagoDetOrg.CapitalAmo
                     .SucursalId = moPagoDetOrg.SucursalId
                     .EstadoId = moPagoDetOrg.EstadoId

                     If .Insert() Then
                        PagoDetAdd = True
                     End If
                  End With

                  moPagoDetOrg.MoveNext()
               Loop

            Else
               PagoDetAdd = True
            End If
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngPagoIdOrg, moPagoDetOrg.PagoDetId, moPagoOrg.PagoNro, moPagoDetOrg.TableName, moPagoDetOrg.PagoDetId, exp.Message))

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

   Private Function PlanDescuentoDesFind(ByVal strConnectString As String, ByVal lngPlanDescuentoId As Long) As String
      Dim oPlanDescuento As New clsPlanDescuento(strConnectString)

      PlanDescuentoDesFind = ""

      Try
         With oPlanDescuento
            .PlanDescuentoId = lngPlanDescuentoId

            If .FindByPK Then
               PlanDescuentoDesFind = .PlanDescuentoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanDescuento.Dispose()

      End Try
   End Function

   Private Function PlanDescuentoIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strPlanDescuentoDes As String) As Long
      Dim oPlanDescuento As New clsPlanDescuento(strConnectString)

      PlanDescuentoIdFind = 0

      Try
         With oPlanDescuento
            .SelectFilter = clsPlanDescuento.SelectFilters.All
            .WhereFilter = clsPlanDescuento.WhereFilters.PlanDescuentoDes
            .EmpresaId = lngEmpresaId
            .PlanDescuentoDes = strPlanDescuentoDes

            If .Find Then
               PlanDescuentoIdFind = .PlanDescuentoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanDescuento.Dispose()

      End Try
   End Function

   Private Function PlanRecargoDesFind(ByVal strConnectString As String, ByVal lngPlanRecargoId As Long) As String
      Dim oPlanRecargo As New clsPlanRecargo(strConnectString)

      PlanRecargoDesFind = ""

      Try
         With oPlanRecargo
            .PlanRecargoId = lngPlanRecargoId

            If .FindByPK Then
               PlanRecargoDesFind = .PlanRecargoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanRecargo.Dispose()

      End Try
   End Function

   Private Function PlanRecargoIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strPlanRecargoDes As String) As Long
      Dim oPlanRecargo As New clsPlanRecargo(strConnectString)

      PlanRecargoIdFind = 0

      Try
         With oPlanRecargo
            .SelectFilter = clsPlanRecargo.SelectFilters.All
            .WhereFilter = clsPlanRecargo.WhereFilters.PlanRecargoDes
            .EmpresaId = lngEmpresaId
            .PlanRecargoDes = strPlanRecargoDes

            If .Find Then
               PlanRecargoIdFind = .PlanRecargoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanRecargo.Dispose()

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

   Private Function CreditoNroFind(ByVal strConnectString As String, ByVal lngCreditoId As Long) As Long
      Dim oCredito As New clsCredito(strConnectString)

      CreditoNroFind = 0

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

   Private Function CreditoIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngCreditoNro As Long) As Long
      Dim oCredito As New clsCredito(strConnectString)

      CreditoIdFind = 0

      Try
         With oCredito
            .SelectFilter = clsCredito.SelectFilters.All
            .WhereFilter = clsCredito.WhereFilters.CREDITO_NRO
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .CreditoNro = lngCreditoNro

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

   Private Function CreditoDetCuotaNroFind(ByVal strConnectString As String, ByVal lngCreditoDetId As Long) As Long
      Dim oCreditoDet As New clsCreditoDet(strConnectString)

      CreditoDetCuotaNroFind = 0

      Try
         With oCreditoDet
            .CreditoDetId = lngCreditoDetId

            If .FindByPK Then
               CreditoDetCuotaNroFind = .CuotaNro
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

      End Try
   End Function

   Private Function CreditoDetIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngCreditoId As Long, ByVal lngCuotaNro As Long) As Long
      Dim oCreditoDet As New clsCreditoDet(strConnectString)

      CreditoDetIdFind = 0

      Try
         With oCreditoDet
            .SelectFilter = clsCreditoDet.SelectFilters.All
            .WhereFilter = clsCreditoDet.WhereFilters.CUOTA_NRO
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .CreditoId = lngCreditoId
            .CuotaNro = lngCuotaNro

            If .Find Then
               CreditoDetIdFind = .CreditoDetId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCreditoDet.Dispose()

      End Try
   End Function

End Class
