Public Class clsAnticipoImport

   Private moAnticipo As clsAnticipo
   Private moAnticipoOrg As clsAnticipo
   Private moAnticipoDes As clsAnticipo
   Private moAnticipoDetOrg As clsAnticipoDet
   Private moAnticipoDetDes As clsAnticipoDet

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
      grdMain = mFrm.grdAnticipo
      pbrMain = mFrm.pbrMain
   End Sub

   Private Sub grdErrorColumName()
      ReDim mArrayColumName(5)
      mArrayColumName(0) = "AnticipoId"
      mArrayColumName(1) = "AnticipoDetId"
      mArrayColumName(2) = "AnticipoNro"
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

      If Not AnticipoDuplicadoCheck() Then
         Throw New Exception("Existen Números de Comprobante Duplicados")
         GridCheck = False
      End If

      If Not ProveedorCheck() Then
         Throw New Exception("Una o Mas Proveedores No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not PedCompraCheck() Then
         Throw New Exception("Una o Mas Pedidos de Compra No Existen en la Base de Datos Destino")
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

      GridCheck = True
   End Function

   Private Function AnticipoDuplicadoCheck() As Boolean
      Dim boolFind As Boolean

      AnticipoDuplicadoCheck = True

      moAnticipoDes = New clsAnticipo(clsAppInfo.ConnectString)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If oRow.Cells("AnticipoNro").Value > 0 Then
               For Each oRowFind As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  boolFind = False

                  If (oRow.Cells("AnticipoNro").Value = oRowFind.Cells("AnticipoNro").Value) _
                     And (oRow.Cells("AnticipoId").Value <> oRowFind.Cells("AnticipoId").Value) Then
                     boolFind = True
                     Exit For
                  End If
               Next

               If boolFind Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("AnticipoId").Value), 0, ToLong(oRow.Cells("AnticipoNro").Value), "tblAnticipo", ToLong(oRow.Cells("AnticipoId").Value), "Número de Anticipo Duplicada en Base de Datos Origen"))

                  AnticipoDuplicadoCheck = False
               End If

               With moAnticipoDes
                  .SelectFilter = clsAnticipo.SelectFilters.All
                  .WhereFilter = clsAnticipo.WhereFilters.AnticipoNro
                  .EmpresaId = clsAppInfo.EmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .AnticipoNro = ToLong(oRow.Cells("AnticipoNro").Value)

                  If .Find Then
                     moDataTable.Rows.Add(GetRow(.AnticipoId, 0, .AnticipoNro, .TableName, .AnticipoId, "Número de Anticiporobante Duplicado en Base de Datos Destino"))
                     AnticipoDuplicadoCheck = False
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("AnticipoId").Value), 0, ToLong(oRow.Cells("AnticipoNro").Value), oCompDes.TableName, ToLong(oRow.Cells("CompNro").Value), ToStr(oRow.Cells("CompNro").Value) & " - Comp No Existe en la Base de Datos Destino"))
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("AnticipoId").Value), 0, ToLong(oRow.Cells("AnticipoNro").Value), oProveedorDes.TableName, ToLong(oRow.Cells("ProveedorId").Value), ToStr(oRow.Cells("ProveedorCod").Value) & " - Proveedor No Existe en la Base de Datos Destino"))
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("AnticipoId").Value), 0, ToLong(oRow.Cells("AnticipoNro").Value), oPedCompraDes.TableName, ToLong(oRow.Cells("PedCompraNro").Value), ToStr(oRow.Cells("PedCompraNro").Value) & " - PedCompra No Existe en la Base de Datos Destino"))
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

   Public Function DataImport() As Boolean
      Dim lngAnticipoIdDes As Long
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long

      moStopwatch = Stopwatch.StartNew()
      DataImport = False

      Dim lngProveedorMovId As Long
      Dim lngTipoCompraId As Long
      Dim lngCol As Long

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
                  lngTipoCompraId = 0
                  lngTipoCompId = 0
                  lngCompNro = 0

                  'Add Anticipo
                  If AnticipoAdd(ToLong(oRow.Cells("AnticipoId").Value), lngAnticipoIdDes) Then

                     If moAnticipoDes.TipoAnticipoId = 2 Then 'Anticipo
                        lngCol = 1
                        lngTipoCompraId = 4
                     ElseIf moAnticipoDes.TipoAnticipoId = 1 Then 'Devolucion Anticipo
                        lngCol = 2
                        lngTipoCompraId = 5
                     End If

                     Call isCompFind(moAnticipoDes.CompId, lngTipoCompId, lngCompNro)

                     'Add ProveedorMov
                     If ProveedorMovAdd(lngProveedorMovId, lngTipoCompraId, moAnticipoDes.AnticipoId, 2, moAnticipoDes.MontoAnt _
                                        , lngCol, lngTipoCompId, lngCompNro, moAnticipoDes.PlanId) Then

                        'Add AnticipoDet
                        If AnticipoDetAdd(ToLong(oRow.Cells("AnticipoId").Value), lngAnticipoIdDes) Then

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
            .EmpresaId = moAnticipoDes.EmpresaId
            .GestionId = moAnticipoDes.GestionId
            .ProveedorId = moAnticipoDes.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moAnticipoDes.Fecha
            .ProveedorMovDes = moAnticipoDes.AnticipoDes
            .MonedaId = moAnticipoDes.MonedaId
            .TipoCambio = moAnticipoDes.TipoCambio
            .CentroCostoId = moAnticipoDes.CentroCostoId
            .SucursalId = moAnticipoDes.SucursalId
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

   Private Function AnticipoAdd(ByVal lngAnticipoIdOrg As Long, ByRef lngAnticipoIdDes As Long) As Boolean
      moAnticipoOrg = New clsAnticipo(mstrConnectStringOrg)
      moAnticipoDes = New clsAnticipo(clsAppInfo.ConnectString)

      AnticipoAdd = False

      Dim strPlanCtaOrg As String
      Dim lngTipoPlanIdOrg As String
      Dim lngPlanIdDest As Long

      Try
         moAnticipoOrg.AnticipoId = lngAnticipoIdOrg

         If moAnticipoOrg.FindByPK Then

            With moAnticipoDes
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .TipoAnticipoId = moAnticipoOrg.TipoAnticipoId
               .AnticipoNro = moAnticipoOrg.AnticipoNro
               .Fecha = ToDate(moAnticipoOrg.Fecha)

               Dim lngPedCompraNroOrg As String = PedCompraNroFind(mstrConnectStringOrg, moAnticipoOrg.PedCompraId)
               Dim lngPedCompraIdDest As Long = PedCompraIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngPedCompraNroOrg)
               .PedCompraId = lngPedCompraIdDest

               Dim strProveedorCodOrg As String = ProveedorCodFind(mstrConnectStringOrg, moAnticipoOrg.ProveedorId)
               Dim lngProveedorIdDest As Long = ProveedorIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strProveedorCodOrg)
               .ProveedorId = lngProveedorIdDest

               .MonedaId = moAnticipoOrg.MonedaId
               .TipoCambio = moAnticipoOrg.TipoCambio
               .AnticipoDes = moAnticipoOrg.AnticipoDes
               .AnticipoObs = moAnticipoOrg.AnticipoObs
               .MontoAnt = moAnticipoOrg.MontoAnt
               .MontoDes = moAnticipoOrg.MontoDes
               .SucursalId = moAnticipoOrg.SucursalId
               .CompId = moAnticipoOrg.CompId

               strPlanCtaOrg = PlanCtaFind(mstrConnectStringOrg, moAnticipoOrg.PlanId, lngTipoPlanIdOrg)
               lngPlanIdDest = PlanIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanCtaOrg, lngTipoPlanIdOrg)
               .PlanId = lngPlanIdDest

               .ConFac = moAnticipoOrg.ConFac
               .SinFac = moAnticipoOrg.SinFac
               .EstadoId = moAnticipoOrg.EstadoId

               If .Insert() Then
                  lngAnticipoIdDes = .AnticipoId
                  AnticipoAdd = True
               End If
            End With
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngAnticipoIdOrg, 0, moAnticipoOrg.AnticipoNro, moAnticipoOrg.TableName, lngAnticipoIdOrg, exp.Message))

      End Try
   End Function

   Private Function AnticipoDetAdd(ByVal lngAnticipoIdOrg As Long, ByVal lngAnticipoIdDes As Long) As Boolean
      Dim strItemCodOrg As String
      Dim lngItemIdDes As Long

      AnticipoDetAdd = False

      moAnticipoDetOrg = New clsAnticipoDet(mstrConnectStringOrg)
      moAnticipoDetDes = New clsAnticipoDet(clsAppInfo.ConnectString)

      Dim strPlanCtaOrg As String
      Dim lngPlanIdDest As Long
      Dim lngTipoPlanIdOrg As String

      Try
         moAnticipoDetOrg.SelectFilter = clsAnticipoDet.SelectFilters.All
         moAnticipoDetOrg.WhereFilter = clsAnticipoDet.WhereFilters.AnticipoId
         moAnticipoDetOrg.OrderByFilter = clsAnticipoDet.OrderByFilters.AnticipoDetId
         moAnticipoDetOrg.EmpresaId = mlngEmpresaIdOrg
         moAnticipoDetOrg.AnticipoId = lngAnticipoIdOrg

         If moAnticipoDetOrg.Open() Then
            If moAnticipoDetOrg.DataSet.Tables(moAnticipoDetOrg.TableName).Rows.Count > 0 Then
               Do While moAnticipoDetOrg.Read()

                  With moAnticipoDetDes
                     .AnticipoId = lngAnticipoIdDes
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId

                     Dim strProveedorCodOrg As String = ProveedorCodFind(mstrConnectStringOrg, moAnticipoDetOrg.ProveedorId)
                     Dim lngProveedorIdDest As Long = ProveedorIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strProveedorCodOrg)
                     .ProveedorId = lngProveedorIdDest

                     .TipoCompraId = moAnticipoDetOrg.TipoCompraId
                     .DocumentoId = 0 'moAnticipoDetOrg.DocumentoId 
                     .Fecha = ToDate(moAnticipoDetOrg.Fecha)
                     .AnticipoDetDes = moAnticipoDetOrg.AnticipoDetDes
                     .MonedaId = moAnticipoDetOrg.MonedaId
                     .TipoCambio = moAnticipoDetOrg.TipoCambio
                     .Monto = moAnticipoDetOrg.Monto
                     .TipoCompId = moAnticipoDetOrg.TipoCompId
                     .CompNro = moAnticipoDetOrg.CompNro

                     strPlanCtaOrg = PlanCtaFind(mstrConnectStringOrg, moAnticipoDetOrg.PlanId, lngTipoPlanIdOrg)
                     lngPlanIdDest = PlanIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanCtaOrg, lngTipoPlanIdOrg)
                     .PlanId = lngPlanIdDest

                     .EstadoId = moAnticipoDetOrg.EstadoId

                     If .Insert() Then
                        AnticipoDetAdd = True
                     End If
                  End With

                  moAnticipoDetOrg.MoveNext()
               Loop

            Else
               AnticipoDetAdd = True
            End If
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngAnticipoIdOrg, moAnticipoDetOrg.AnticipoDetId, moAnticipoOrg.AnticipoNro, moAnticipoDetOrg.TableName, moAnticipoDetOrg.AnticipoDetId, exp.Message))

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

   Private Function PedCompraNroFind(ByVal strConnectString As String, ByVal lngPedCompraId As Long) As String
      Dim oPedCompra As New clsPedCompra(strConnectString)

      PedCompraNroFind = ""

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
