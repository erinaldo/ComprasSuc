Public Class clsCreditoImport

   Private moCredito As clsCredito
   Private moCreditoOrg As clsCredito
   Private moCreditoDes As clsCredito
   Private moCreditoDetOrg As clsCreditoDet
   Private moCreditoDetDes As clsCreditoDet

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
      grdMain = mFrm.grdCredito
      pbrMain = mFrm.pbrMain
   End Sub

   Private Sub grdErrorColumName()
      ReDim mArrayColumName(5)
      mArrayColumName(0) = "CreditoId"
      mArrayColumName(1) = "CreditoDetId"
      mArrayColumName(2) = "CreditoNro"
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

      If Not CreditoSinDetalleCheck() Then
         Throw New Exception("Existen Creditos Sin Detalle en Base de Datos Origen")
         GridCheck = False
      End If

      If Not CreditoDuplicadoCheck() Then
         Throw New Exception("Existen Números de Comprobante Duplicados")
         GridCheck = False
      End If

      If Not ProveedorCheck() Then
         Throw New Exception("Una o Mas Proveedores No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not CompraCheck() Then
         Throw New Exception("Una o Mas Compras No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      GridCheck = True
   End Function

   Private Function CreditoSinDetalleCheck() As Boolean
      CreditoSinDetalleCheck = True

      moCreditoDetOrg = New clsCreditoDet(mstrConnectStringOrg)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("EstadoId").Value) <> 12 Then
               With moCreditoDetOrg
                  .SelectFilter = clsCreditoDet.SelectFilters.All
                  .WhereFilter = clsCreditoDet.WhereFilters.CreditoId
                  .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
                  .CreditoId = ToLong(oRow.Cells("CreditoId").Value)

                  If .Open() Then
                     If .DataSet.Tables(.TableName).Rows.Count = 0 Then
                        moDataTable.Rows.Add(GetRow(.CreditoId, 0, ToLong(oRow.Cells("CreditoNro").Value), "tblCredito", .CreditoId, "Credito Sin Detalle"))
                        CreditoSinDetalleCheck = False
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

   Private Function CreditoDuplicadoCheck() As Boolean
      Dim boolFind As Boolean

      CreditoDuplicadoCheck = True

      moCreditoDes = New clsCredito(clsAppInfo.ConnectString)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If oRow.Cells("CreditoNro").Value > 0 Then
               For Each oRowFind As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  boolFind = False

                  If (oRow.Cells("CreditoNro").Value = oRowFind.Cells("CreditoNro").Value) _
                     And (oRow.Cells("CreditoId").Value <> oRowFind.Cells("CreditoId").Value) Then

                     boolFind = True
                     Exit For
                  End If
               Next

               If boolFind Then
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CreditoId").Value), 0, ToLong(oRow.Cells("CreditoNro").Value), "tblCredito", ToLong(oRow.Cells("CreditoId").Value), "Número de Credito Duplicada en Base de Datos Origen"))

                  CreditoDuplicadoCheck = False
               End If

               With moCreditoDes
                  .SelectFilter = clsCredito.SelectFilters.All
                  .WhereFilter = clsCredito.WhereFilters.CREDITO_NRO
                  .EmpresaId = clsAppInfo.EmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .CreditoNro = ToLong(oRow.Cells("CreditoNro").Value)

                  If .Find Then
                     moDataTable.Rows.Add(GetRow(.CreditoId, 0, .CreditoNro, .TableName, .CreditoId, "Número de Creditorobante Duplicado en Base de Datos Destino"))

                     CreditoDuplicadoCheck = False
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
                  moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CreditoId").Value), 0, ToLong(oRow.Cells("CreditoNro").Value), oProveedorDes.TableName, ToLong(oRow.Cells("ProveedorId").Value), ToStr(oRow.Cells("ProveedorCod").Value) & " - Proveedor No Existe en la Base de Datos Destino"))
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

   Public Function DataImport() As Boolean
      Dim lngCreditoIdDes As Long

      moStopwatch = Stopwatch.StartNew()
      DataImport = False

      Dim lngCompId As Long
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim lngPlanId As Long
      Dim lngProveedorMovId As Long
      Dim strFecha As String

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
                  lngCompId = 0
                  lngTipoCompId = 0
                  lngCompNro = 0
                  lngPlanId = 0
                  lngProveedorMovId = 0

                  If CreditoAdd(ToLong(oRow.Cells("CreditoId").Value), lngCreditoIdDes) Then
                     'Update
                     Call updateCompra(clsAppInfo.ConnectString, moCreditoDes.CompraId, lngCreditoIdDes _
                                       , lngCompId, lngPlanId, strFecha)

                     Call isCompFind(lngcompId, lngTipoCompId, lngCompNro)

                     Call updateDevCompra(clsAppInfo.ConnectString, moCreditoDes.CompraId, lngCreditoIdDes)

                     If CreditoDetAdd(ToLong(oRow.Cells("CreditoId").Value), lngCreditoIdDes, moCreditoDes.CompraId, moCreditoDes.ProveedorId) Then

                        If ProveedorMovAdd(lngProveedorMovId, 6, moCreditoDes.CreditoId, 2, moCreditoDes.MontoLiq, 2 _
                                           , lngTipoCompId, lngCompNro, lngPlanId, strFecha) Then

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

   Private Function updateCompra(ByVal strConnectString As String, ByVal lngCompraId As Long, ByVal lngCreditoId As Long _
                                 , ByRef lngCompId As Long, ByRef lngPlanId As Long, ByRef strFecha As String) As Boolean
      Dim oCompra As New clsCompra(strConnectString)
      updateCompra = False
      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               'lngTipoCompId = .TipoCompId
               'lngCompNro = .CompNro
               lngCompId = .CompId
               lngPlanId = .PlanId
               strFecha = .Fecha

               .UpdateFilter = clsCompra.UpdateFilters.CREDITOID
               .CreditoId = lngCreditoId

               If .UpdateOnly Then
                  updateCompra = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function updateDevCompra(ByVal strConnectString As String, ByVal lngCompraId As Long, ByVal lngCreditoId As Long) As Boolean
      Dim oDevCompra As New clsDevCompra(strConnectString)
      updateDevCompra = False

      Try
         With oDevCompra
            .UpdateFilter = clsDevCompra.UpdateFilters.CREDITOID
            .CompraId = lngCompraId
            .CreditoId = lngCreditoId

            If .UpdateOnly Then
               updateDevCompra = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, mFrm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDevCompra.Dispose()

      End Try
   End Function

   Private Function CreditoAdd(ByVal lngCreditoIdOrg As Long, ByRef lngCreditoIdDes As Long) As Boolean
      moCreditoOrg = New clsCredito(mstrConnectStringOrg)
      moCreditoDes = New clsCredito(clsAppInfo.ConnectString)

      Dim lngCompraNroOrg As Long
      Dim lngCompraIdDst As Long

      Dim strProveedorCodOrg As String
      Dim lngProveedorIdDest As Long

      CreditoAdd = False

      Try
         moCreditoOrg.CreditoId = lngCreditoIdOrg

         If moCreditoOrg.FindByPK Then

            With moCreditoDes
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId

               lngCompraNroOrg = CompraNroFind(mstrConnectStringOrg, moCreditoOrg.CompraId)
               lngCompraIdDst = CompraIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, lngCompraNroOrg)
               .CompraId = lngCompraIdDst

               .TipoCreditoId = moCreditoOrg.TipoCreditoId
               .CreditoNro = moCreditoOrg.CreditoNro
               .FechaIni = ToDate(moCreditoOrg.FechaIni)
               .FechaFin = ToDate(moCreditoOrg.FechaFin)
               .SucursalId = moCreditoOrg.SucursalId

               strProveedorCodOrg = ProveedorCodFind(mstrConnectStringOrg, moCreditoOrg.ProveedorId)
               lngProveedorIdDest = ProveedorIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strProveedorCodOrg)
               .ProveedorId = lngProveedorIdDest

               .FrecuenciaId = moCreditoOrg.FrecuenciaId
               .FrecuenciaNro = moCreditoOrg.FrecuenciaNro
               .MonedaId = moCreditoOrg.MonedaId
               .TipoCambio = moCreditoOrg.TipoCambio
               .MontoLiq = moCreditoOrg.MontoLiq
               .MontoAmo = moCreditoOrg.MontoAmo
               .CantidadCuota = moCreditoOrg.CantidadCuota
               .MontoCuota = moCreditoOrg.MontoCuota
               .InteresAnual = moCreditoOrg.InteresAnual
               .SaldoIni = moCreditoOrg.SaldoIni

               .ConFac = moCreditoOrg.ConFac
               .SinFac = moCreditoOrg.SinFac
               .EstadoId = moCreditoOrg.EstadoId

               If .Insert() Then
                  lngCreditoIdDes = .CreditoId
                  CreditoAdd = True
               End If
            End With
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCreditoIdOrg, 0, moCreditoOrg.CreditoNro, moCreditoOrg.TableName, lngCreditoIdOrg, exp.Message))

      End Try
   End Function

   Private Function CreditoDetAdd(ByVal lngCreditoIdOrg As Long, ByVal lngCreditoIdDes As Long, ByVal lngCompraIdDst As Long, ByVal lngProveedorIdDst As Long) As Boolean
      CreditoDetAdd = False

      moCreditoDetOrg = New clsCreditoDet(mstrConnectStringOrg)
      moCreditoDetDes = New clsCreditoDet(clsAppInfo.ConnectString)

      Try
         moCreditoDetOrg.SelectFilter = clsCreditoDet.SelectFilters.All
         moCreditoDetOrg.WhereFilter = clsCreditoDet.WhereFilters.CreditoId
         moCreditoDetOrg.OrderByFilter = clsCreditoDet.OrderByFilters.CreditoDetId
         moCreditoDetOrg.EmpresaId = mlngEmpresaIdOrg
         moCreditoDetOrg.CreditoId = lngCreditoIdOrg

         If moCreditoDetOrg.Open() Then
            If moCreditoDetOrg.DataSet.Tables(moCreditoDetOrg.TableName).Rows.Count > 0 Then
               Do While moCreditoDetOrg.Read()

                  With moCreditoDetDes
                     .CreditoId = lngCreditoIdDes
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .Fecha = ToDate(moCreditoDetOrg.Fecha)
                     .CompraId = lngCompraIdDst
                     .TipoCreditoId = moCreditoDetOrg.TipoCreditoId
                     .ProveedorId = lngProveedorIdDst
                     .MonedaId = moCreditoDetOrg.MonedaId
                     .TipoCambio = moCreditoDetOrg.TipoCambio
                     .CuotaNro = moCreditoDetOrg.CuotaNro
                     .Capital = moCreditoDetOrg.Capital
                     .Interes = moCreditoDetOrg.Interes
                     .Importe = moCreditoDetOrg.Importe
                     .CapitalAmo = moCreditoDetOrg.CapitalAmo
                     .InteresAmo = moCreditoDetOrg.InteresAmo
                     .FechaAmo = ToDate(moCreditoDetOrg.FechaAmo)
                     .InteresPen = moCreditoDetOrg.InteresPen
                     .CentroCostoId = moCreditoDetOrg.CentroCostoId
                     .SucursalId = moCreditoDetOrg.SucursalId
                     .EstadoId = moCreditoDetOrg.EstadoId

                     If .Insert() Then
                        CreditoDetAdd = True
                     End If
                  End With

                  moCreditoDetOrg.MoveNext()
               Loop

            Else
               CreditoDetAdd = True
            End If
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCreditoIdOrg, moCreditoDetOrg.CreditoDetId, moCreditoOrg.CreditoNro, moCreditoDetOrg.TableName, moCreditoDetOrg.CreditoDetId, exp.Message))

      End Try
   End Function

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal lngTipoPagoId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long, ByVal strFecha As String) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moCreditoDes.EmpresaId
            .GestionId = moCreditoDes.GestionId
            .ProveedorId = moCreditoDes.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = ToDate(strFecha)
            .ProveedorMovDes = ""
            .MonedaId = moCreditoDes.MonedaId
            .TipoCambio = moCreditoDes.TipoCambio
            .CentroCostoId = moCreditoDes.CentroCostoId
            .SucursalId = moCreditoDes.SucursalId
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

End Class
