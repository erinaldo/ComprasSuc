Imports DataDynamics.ActiveReports.Document

Module modPago
   Private mlngNroCopia As Long
   Private mboolOrgCopia As Boolean

   Private mlngDosificaId As Long
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolImpDosificaLey As Boolean
   Private mstrDosificaDes As String
   Private mstrDosificaLeyDes As String
   Private mstrTipoActEcoDes As String

   Private moDataView As System.Data.DataView
   Private mdecMontoOrg As Decimal
   Private mdecMontoDes As Decimal

   Private mlngMaxActividad As Long
   Private moPageSettings As DataDynamics.ActiveReports.PageSettings
   Private moDocumento As DataDynamics.ActiveReports.Document.Document

   Private mboolPrintSave As Boolean
   Private mstrDirPrintSave As String

    Public Sub PrintReportPago(ByVal lngTipoPagoId As Long, ByVal lngPagoId As Long, _
          ByVal lngSucursalId As Long, ByVal decMontoAntPag As Decimal, ByVal decCapital As Decimal)
        Dim oTipoFormImp As New clsTipoFormImp(clsAppInfo.ConnectString)
        Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)
        Try

            With oCompraPara
                .SelectFilter = clsCompraPara.SelectFilters.All
                .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId

                .TipoCompraId = 7
                .EmpresaId = clsAppInfo.EmpresaId
                .GestionId = clsAppInfo.GestionId
                .SucursalId = lngSucursalId
                If .Find Then
                    If .TipoImpresionId = clsTipoImpresion.GRAPHIC Then 'Gráfica

                        oTipoFormImp.TipoFormImpId = .TipoFormImpId
                        If oTipoFormImp.FindByPK() Then

                            Select Case oTipoFormImp.TipoFormImpDes
                                Case "KDEORO"   ''TipoFormImpId = 69 
                                    Call PrintPagoKdeoro(lngTipoPagoId, lngPagoId, decMontoAntPag, decCapital, oCompraPara.Firma, oCompraPara.Titulo, oCompraPara.TipoHojaId)

                                Case Else   ''TipoFormImpId = 69 
                                    Call PrintPagoEstandar(lngTipoPagoId, lngPagoId, decMontoAntPag, decCapital, oCompraPara.Firma, oCompraPara.Titulo, oCompraPara.TipoHojaId)

                            End Select

                        End If

                    ElseIf .TipoImpresionId = clsTipoImpresion.TEXT Then 'Texto

                        '' NO hace Nada
                    Else
                        ' Call PrintFacturaEstandar(boolVenta, oVenta, oFactura, oDataView)
                    End If

                End If
            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, "Factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oTipoFormImp.Dispose()
            'oDosifica.Dispose()
        End Try

    End Sub

    Private Sub PrintPagoEstandar(ByVal lngTipoPagoId As Long, ByVal lngPagoId As Long, _
                               ByVal decMontoAntPag As Decimal, ByVal decCapital As Decimal, _
                               ByVal strFirma As String, ByVal strTitulo As String, ByVal lngTipoHojaId As Long)

        Dim rpt As New rptPagoEdit
        Dim oPago As New clsPago(clsAppInfo.ConnectString)
        Try
            If lngTipoPagoId = 1 Then
                oPago.SelectFilter = clsPago.SelectFilters.ReportContado
            Else
                oPago.SelectFilter = clsPago.SelectFilters.Report
            End If

            oPago.WhereFilter = clsPago.WhereFilters.Report
            oPago.OrderByFilter = clsPago.OrderByFilters.Report

            oPago.EmpresaId = clsAppInfo.EmpresaId
            oPago.PagoId = lngPagoId
            If oPago.Find Then
                rpt.DataSource = oPago.DataSet.Tables(oPago.TableName).DefaultView

                rpt.txtFirma.Text = strFirma
                rpt.lblTitle.Text = strTitulo
                rpt.Document.Name = strTitulo
                rpt.lblCompany.Text = clsAppInfo.EmpresaGral
                rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
                rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
                rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

                rpt.txtAnticipo.Text = decMontoAntPag
                rpt.txtMontoPag.Text = decCapital

                Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

                If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
                    rpt.Run(True)
                    Dim frm As frmReportPreview
                    frm = New frmReportPreview(rpt.Document)
                    frm.Show()

                ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
                    rpt.Run(True)
                    Dim frm As frmReportPreviewMultiple
                    frm = New frmReportPreviewMultiple(rpt.Document)
                    frm.numberOfPagesPerPrinterPage = 2
                    frm.TipoHojaId = lngTipoHojaId
                    frm.Show()
                    'frm.PrintReport()
                End If
            End If

        Catch exp As Exception
            MessageBox.Show(exp.Message, "Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            oPago.Dispose()
        End Try
    End Sub

    Private Sub PrintPagoKdeoro(ByVal lngTipoPagoId As Long, ByVal lngPagoId As Long, _
                                ByVal decMontoAntPag As Decimal, ByVal decCapital As Decimal, _
                                ByVal strFirma As String, ByVal strTitulo As String, ByVal lngTipoHojaId As Long)

        Dim rpt As New rptPagoEditKdeoro
        Dim oPago As New clsPago(clsAppInfo.ConnectString)
        Dim strBancoCta, strPlanDes As String
        Try
            If lngTipoPagoId = 1 Then
                oPago.SelectFilter = clsPago.SelectFilters.ReportContado
            Else
                oPago.SelectFilter = clsPago.SelectFilters.Report
            End If

            oPago.WhereFilter = clsPago.WhereFilters.Report
            oPago.OrderByFilter = clsPago.OrderByFilters.Report

            oPago.EmpresaId = clsAppInfo.EmpresaId
            oPago.PagoId = lngPagoId
            If oPago.Find Then
                strPlanDes = PlanDes(oPago.DataSet.Tables(oPago.TableName).Rows(0).Item("PlanId"), strBancoCta)

                If strPlanDes <> String.Empty Then
                    rpt.TextBox6.Text = strPlanDes
                    rpt.TextBox8.Text = strBancoCta
                End If

                rpt.DataSource = oPago.DataSet.Tables(oPago.TableName).DefaultView

                rpt.txtFirma.Text = strFirma
                rpt.lblTitle.Text = strTitulo
                rpt.Document.Name = strTitulo
                rpt.lblCompany.Text = clsAppInfo.EmpresaGral
                rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
                rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
                rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

                rpt.txtAnticipo.Text = decMontoAntPag
                rpt.txtMontoPag.Text = decCapital

                Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

                If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
                    rpt.Run(True)
                    Dim frm As frmReportPreview
                    frm = New frmReportPreview(rpt.Document)
                    frm.Show()

                ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
                    rpt.Run(True)
                    Dim frm As frmReportPreviewMultiple
                    frm = New frmReportPreviewMultiple(rpt.Document)
                    frm.numberOfPagesPerPrinterPage = 2
                    frm.TipoHojaId = lngTipoHojaId
                    frm.Show()
                    'frm.PrintReport()
                End If
            End If

        Catch exp As Exception
            MessageBox.Show(exp.Message, "Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            oPago.Dispose()
        End Try
    End Sub

#Region " Otros Metodos "
    Private Function PlanDes(ByVal lngPlanId As Long, ByRef strBancoCta As String) As String
        Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
        Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

        PlanDes = String.Empty
        Try
            With oPlan
                .PlanId = lngPlanId

                If .FindByPK Then
                    PlanDes = .PlanDes
                    With oCheque
                        .SelectFilter = clsCheque.SelectFilters.All
                        .WhereFilter = clsCheque.WhereFilters.PlanId

                        .EmpresaId = clsAppInfo.EmpresaId
                        .PlanId = lngPlanId
                        If .Find Then
                            strBancoCta = .BancoCta
                        End If
                    End With
                End If

            End With
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            oPlan.Dispose()
            oCheque.Dispose()
        End Try
    End Function
#End Region
    
End Module
