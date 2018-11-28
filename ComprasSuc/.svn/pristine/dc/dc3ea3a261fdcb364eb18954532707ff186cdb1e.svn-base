Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptPedCompraEditGEU
   Inherits DataDynamics.ActiveReports.ActiveReport3

#Region " ActiveReports Designer generated code "
   Public Sub New()

      'This call is required by the ActiveReports Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

   End Sub

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
      End If
      MyBase.Dispose(disposing)
   End Sub

   Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
   Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
   Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
   Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
   Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
   Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
   Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource = Nothing
   Private picAnulado As DataDynamics.ActiveReports.Picture = Nothing
   Public lblTitle As DataDynamics.ActiveReports.Label = Nothing
   Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
   Private Shape2 As DataDynamics.ActiveReports.Shape = Nothing
   Private lblAlmacenIdOrg As DataDynamics.ActiveReports.Label = Nothing
   Private lblAlmacenIdDes As DataDynamics.ActiveReports.Label = Nothing
   Private Label2 As DataDynamics.ActiveReports.Label = Nothing
   Private Label4 As DataDynamics.ActiveReports.Label = Nothing
   Private Label6 As DataDynamics.ActiveReports.Label = Nothing
   Private txtCentroCostoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtUbicacionProy As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPedCompraNro As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPedCompraDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtFecha As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtTipoCambio As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtEstadoId As DataDynamics.ActiveReports.TextBox = Nothing
   Private Shape3 As DataDynamics.ActiveReports.Shape = Nothing
   Private Label8 As DataDynamics.ActiveReports.Label = Nothing
   Private Label11 As DataDynamics.ActiveReports.Label = Nothing
   Private Label9 As DataDynamics.ActiveReports.Label = Nothing
   Private Label10 As DataDynamics.ActiveReports.Label = Nothing
   Private Label7 As DataDynamics.ActiveReports.Label = Nothing
   Private Label15 As DataDynamics.ActiveReports.Label = Nothing
   Private txtItemNro As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtItemDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox28 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox30 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtObservacion As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtLiteral As DataDynamics.ActiveReports.TextBox = Nothing
   Public WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
   Private lblCompraObs As DataDynamics.ActiveReports.Label = Nothing
   Private txtCompraObs As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox4 As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblMontoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblMontoRec As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblMontoAnt As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblMontoLiq As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoRec As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoAnt As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoLiq As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaId As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageCount As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox = Nothing
   Private Label13 As DataDynamics.ActiveReports.Label = Nothing
   Private Line2 As DataDynamics.ActiveReports.Line = Nothing
   Public lblDate As DataDynamics.ActiveReports.Label = Nothing
   Public lblTime As DataDynamics.ActiveReports.Label = Nothing
   Public lblLogin As DataDynamics.ActiveReports.Label = Nothing
   Public WithEvents txtFirma As DataDynamics.ActiveReports.TextBox
   Private WithEvents Shape6 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape7 As DataDynamics.ActiveReports.Shape
   Public WithEvents txtIsoDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtEmisionDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label24 As DataDynamics.ActiveReports.Label
   Private WithEvents Label25 As DataDynamics.ActiveReports.Label
   Private WithEvents Shape9 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape8 As DataDynamics.ActiveReports.Shape
   Private WithEvents Line1 As DataDynamics.ActiveReports.Line
   Private WithEvents Shape11 As DataDynamics.ActiveReports.Shape
   Public WithEvents txtRevisionDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtMoneda As DataDynamics.ActiveReports.TextBox
   Public WithEvents picLogo As DataDynamics.ActiveReports.Picture
   Private WithEvents Label3 As DataDynamics.ActiveReports.Label
   Private WithEvents txtCliente As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Private WithEvents Label12 As DataDynamics.ActiveReports.Label
   Private WithEvents txtCentroCostoCod As DataDynamics.ActiveReports.TextBox
   Friend WithEvents chkMateriales As DataDynamics.ActiveReports.CheckBox
   Friend WithEvents chkServicios As DataDynamics.ActiveReports.CheckBox
   Friend WithEvents chkOtros As DataDynamics.ActiveReports.CheckBox
   Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label5 As DataDynamics.ActiveReports.Label
   Private WithEvents Line3 As DataDynamics.ActiveReports.Line

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedCompraEditGEU))
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtItemDes = New DataDynamics.ActiveReports.TextBox
      Me.txtItemNro = New DataDynamics.ActiveReports.TextBox
      Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox30 = New DataDynamics.ActiveReports.TextBox
      Me.txtObservacion = New DataDynamics.ActiveReports.TextBox
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.Shape7 = New DataDynamics.ActiveReports.Shape
      Me.picAnulado = New DataDynamics.ActiveReports.Picture
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
      Me.Shape9 = New DataDynamics.ActiveReports.Shape
      Me.Shape8 = New DataDynamics.ActiveReports.Shape
      Me.txtEmisionDes = New DataDynamics.ActiveReports.TextBox
      Me.txtRevisionDes = New DataDynamics.ActiveReports.TextBox
      Me.txtIsoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCostoDes = New DataDynamics.ActiveReports.TextBox
      Me.Label25 = New DataDynamics.ActiveReports.Label
      Me.Label24 = New DataDynamics.ActiveReports.Label
      Me.Shape2 = New DataDynamics.ActiveReports.Shape
      Me.Shape6 = New DataDynamics.ActiveReports.Shape
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.lblAlmacenIdOrg = New DataDynamics.ActiveReports.Label
      Me.lblAlmacenIdDes = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.txtUbicacionProy = New DataDynamics.ActiveReports.TextBox
      Me.txtPedCompraNro = New DataDynamics.ActiveReports.TextBox
      Me.txtPedCompraDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtTipoCambio = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoId = New DataDynamics.ActiveReports.TextBox
      Me.Shape11 = New DataDynamics.ActiveReports.Shape
      Me.txtMoneda = New DataDynamics.ActiveReports.TextBox
      Me.picLogo = New DataDynamics.ActiveReports.Picture
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.txtCliente = New DataDynamics.ActiveReports.TextBox
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.txtCentroCostoCod = New DataDynamics.ActiveReports.TextBox
      Me.chkMateriales = New DataDynamics.ActiveReports.CheckBox
      Me.chkServicios = New DataDynamics.ActiveReports.CheckBox
      Me.chkOtros = New DataDynamics.ActiveReports.CheckBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.txtFirma = New DataDynamics.ActiveReports.TextBox
      Me.lblCompraObs = New DataDynamics.ActiveReports.Label
      Me.txtCompraObs = New DataDynamics.ActiveReports.TextBox
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.Line3 = New DataDynamics.ActiveReports.Line
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.Shape3 = New DataDynamics.ActiveReports.Shape
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.lblMontoRec = New DataDynamics.ActiveReports.TextBox
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.txtTotal = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.lblMontoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoDes = New DataDynamics.ActiveReports.TextBox
      Me.lblMontoAnt = New DataDynamics.ActiveReports.TextBox
      Me.lblMontoLiq = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoRec = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoAnt = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoLiq = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaId = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtItemNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEmisionDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtRevisionDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIsoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacenIdOrg, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacenIdDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtUbicacionProy, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.chkMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.chkServicios, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.chkOtros, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoRec, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoLiq, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoRec, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoLiq, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtItemDes, Me.txtItemNro, Me.TextBox27, Me.TextBox28, Me.TextBox30, Me.txtObservacion, Me.TextBox1})
      Me.Detail.Height = 0.1889764!
      Me.Detail.Name = "Detail"
      '
      'txtItemDes
      '
      Me.txtItemDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtItemDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtItemDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtItemDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtItemDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemDes.DataField = "ItemDes"
      Me.txtItemDes.Height = 0.1875!
      Me.txtItemDes.Left = 0.4166667!
      Me.txtItemDes.Name = "txtItemDes"
      Me.txtItemDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtItemDes.Text = "ItemDes"
      Me.txtItemDes.Top = 0.0!
      Me.txtItemDes.Width = 3.927084!
      '
      'txtItemNro
      '
      Me.txtItemNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtItemNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtItemNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtItemNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtItemNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemNro.Height = 0.1875!
      Me.txtItemNro.Left = 0.0!
      Me.txtItemNro.Name = "txtItemNro"
      Me.txtItemNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtItemNro.Text = "ItemNro"
      Me.txtItemNro.Top = 0.0!
      Me.txtItemNro.Width = 0.3854167!
      '
      'TextBox27
      '
      Me.TextBox27.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox27.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox27.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox27.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox27.DataField = "MedidaDes"
      Me.TextBox27.Height = 0.1875!
      Me.TextBox27.Left = 4.375!
      Me.TextBox27.Name = "TextBox27"
      Me.TextBox27.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox27.Text = "MedidaDes"
      Me.TextBox27.Top = 0.0!
      Me.TextBox27.Width = 0.59375!
      '
      'TextBox28
      '
      Me.TextBox28.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox28.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox28.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox28.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox28.DataField = "Cantidad"
      Me.TextBox28.Height = 0.1875!
      Me.TextBox28.Left = 5.0!
      Me.TextBox28.Name = "TextBox28"
      Me.TextBox28.OutputFormat = resources.GetString("TextBox28.OutputFormat")
      Me.TextBox28.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox28.Text = "Cantidad"
      Me.TextBox28.Top = 0.0!
      Me.TextBox28.Width = 0.6875!
      '
      'TextBox30
      '
      Me.TextBox30.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox30.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox30.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox30.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox30.DataField = "PrecioOrg"
      Me.TextBox30.Height = 0.1875!
      Me.TextBox30.Left = 1.833333!
      Me.TextBox30.Name = "TextBox30"
      Me.TextBox30.OutputFormat = resources.GetString("TextBox30.OutputFormat")
      Me.TextBox30.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox30.Text = "Precio"
      Me.TextBox30.Top = 0.0!
      Me.TextBox30.Visible = False
      Me.TextBox30.Width = 0.6875!
      '
      'txtObservacion
      '
      Me.txtObservacion.Border.BottomColor = System.Drawing.Color.Black
      Me.txtObservacion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtObservacion.Border.LeftColor = System.Drawing.Color.Black
      Me.txtObservacion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtObservacion.Border.RightColor = System.Drawing.Color.Black
      Me.txtObservacion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtObservacion.Border.TopColor = System.Drawing.Color.Black
      Me.txtObservacion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtObservacion.Height = 0.1845472!
      Me.txtObservacion.Left = 5.680857!
      Me.txtObservacion.Name = "txtObservacion"
      Me.txtObservacion.OutputFormat = resources.GetString("txtObservacion.OutputFormat")
      Me.txtObservacion.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtObservacion.Text = Nothing
      Me.txtObservacion.Top = 0.0!
      Me.txtObservacion.Width = 1.780512!
      '
      'TextBox1
      '
      Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.DataField = "Importe"
      Me.TextBox1.Height = 0.1845472!
      Me.TextBox1.Left = 2.522146!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
      Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox1.Text = "Importe"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Visible = False
      Me.TextBox1.Width = 1.207595!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape7, Me.picAnulado, Me.Shape1, Me.Shape9, Me.Shape8, Me.txtEmisionDes, Me.txtRevisionDes, Me.txtIsoDes, Me.txtCentroCostoDes, Me.Label25, Me.Label24, Me.Shape2, Me.Shape6, Me.lblTitle, Me.lblAlmacenIdOrg, Me.lblAlmacenIdDes, Me.Label2, Me.Label4, Me.Label6, Me.txtUbicacionProy, Me.txtPedCompraNro, Me.txtPedCompraDes, Me.txtMonedaDes, Me.txtFecha, Me.txtTipoCambio, Me.txtEstadoId, Me.Shape11, Me.txtMoneda, Me.picLogo, Me.Label3, Me.txtCliente, Me.Label1, Me.Label12, Me.txtCentroCostoCod, Me.chkMateriales, Me.chkServicios, Me.chkOtros})
      Me.ReportHeader.Height = 1.720472!
      Me.ReportHeader.Name = "ReportHeader"
      '
      'Shape7
      '
      Me.Shape7.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape7.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape7.Border.RightColor = System.Drawing.Color.Black
      Me.Shape7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape7.Border.TopColor = System.Drawing.Color.Black
      Me.Shape7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape7.Height = 0.2214567!
      Me.Shape7.Left = 5.893209!
      Me.Shape7.LineWeight = 2.0!
      Me.Shape7.Name = "Shape7"
      Me.Shape7.RoundingRadius = 0.0!
      Me.Shape7.Top = 0.0!
      Me.Shape7.Width = 1.598425!
      '
      'picAnulado
      '
      Me.picAnulado.Border.BottomColor = System.Drawing.Color.Black
      Me.picAnulado.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picAnulado.Border.LeftColor = System.Drawing.Color.Black
      Me.picAnulado.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picAnulado.Border.RightColor = System.Drawing.Color.Black
      Me.picAnulado.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picAnulado.Border.TopColor = System.Drawing.Color.Black
      Me.picAnulado.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picAnulado.Height = 0.625!
      Me.picAnulado.Image = CType(resources.GetObject("picAnulado.Image"), System.Drawing.Image)
      Me.picAnulado.ImageData = CType(resources.GetObject("picAnulado.ImageData"), System.IO.Stream)
      Me.picAnulado.Left = 0.125!
      Me.picAnulado.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.picAnulado.LineWeight = 0.0!
      Me.picAnulado.Name = "picAnulado"
      Me.picAnulado.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
      Me.picAnulado.Top = 0.78125!
      Me.picAnulado.Visible = False
      Me.picAnulado.Width = 4.72441!
      '
      'Shape1
      '
      Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape1.Border.RightColor = System.Drawing.Color.Black
      Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape1.Border.TopColor = System.Drawing.Color.Black
      Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape1.Height = 1.062992!
      Me.Shape1.Left = 0.0!
      Me.Shape1.LineWeight = 2.0!
      Me.Shape1.Name = "Shape1"
      Me.Shape1.RoundingRadius = 0.0!
      Me.Shape1.Top = 0.6520669!
      Me.Shape1.Width = 4.92126!
      '
      'Shape9
      '
      Me.Shape9.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape9.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape9.Border.RightColor = System.Drawing.Color.Black
      Me.Shape9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape9.Border.TopColor = System.Drawing.Color.Black
      Me.Shape9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape9.Height = 0.2214567!
      Me.Shape9.Left = 5.893209!
      Me.Shape9.LineWeight = 2.0!
      Me.Shape9.Name = "Shape9"
      Me.Shape9.RoundingRadius = 0.0!
      Me.Shape9.Top = 0.4409449!
      Me.Shape9.Width = 1.598425!
      '
      'Shape8
      '
      Me.Shape8.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape8.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape8.Border.RightColor = System.Drawing.Color.Black
      Me.Shape8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape8.Border.TopColor = System.Drawing.Color.Black
      Me.Shape8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape8.Height = 0.2337598!
      Me.Shape8.Left = 5.893209!
      Me.Shape8.LineWeight = 2.0!
      Me.Shape8.Name = "Shape8"
      Me.Shape8.RoundingRadius = 0.0!
      Me.Shape8.Top = 0.2165354!
      Me.Shape8.Width = 1.599409!
      '
      'txtEmisionDes
      '
      Me.txtEmisionDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEmisionDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEmisionDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEmisionDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEmisionDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtEmisionDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEmisionDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtEmisionDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEmisionDes.Height = 0.1875!
      Me.txtEmisionDes.Left = 6.582185!
      Me.txtEmisionDes.Name = "txtEmisionDes"
      Me.txtEmisionDes.OutputFormat = resources.GetString("txtEmisionDes.OutputFormat")
      Me.txtEmisionDes.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.txtEmisionDes.Text = Nothing
      Me.txtEmisionDes.Top = 0.2337598!
      Me.txtEmisionDes.Width = 0.8645833!
      '
      'txtRevisionDes
      '
      Me.txtRevisionDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtRevisionDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtRevisionDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtRevisionDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtRevisionDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtRevisionDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtRevisionDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtRevisionDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtRevisionDes.Height = 0.1889764!
      Me.txtRevisionDes.Left = 6.582185!
      Me.txtRevisionDes.Name = "txtRevisionDes"
      Me.txtRevisionDes.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.txtRevisionDes.Text = Nothing
      Me.txtRevisionDes.Top = 0.4533301!
      Me.txtRevisionDes.Width = 0.8645833!
      '
      'txtIsoDes
      '
      Me.txtIsoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIsoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIsoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIsoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIsoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtIsoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIsoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtIsoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIsoDes.Height = 0.1889764!
      Me.txtIsoDes.Left = 5.942093!
      Me.txtIsoDes.Name = "txtIsoDes"
      Me.txtIsoDes.Style = "font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.txtIsoDes.Text = Nothing
      Me.txtIsoDes.Top = 0.01230315!
      Me.txtIsoDes.Width = 1.5!
      '
      'txtCentroCostoDes
      '
      Me.txtCentroCostoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCentroCostoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes.DataField = "CentroCostoDes"
      Me.txtCentroCostoDes.Height = 0.1875!
      Me.txtCentroCostoDes.Left = 1.181102!
      Me.txtCentroCostoDes.Name = "txtCentroCostoDes"
      Me.txtCentroCostoDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtCentroCostoDes.Text = "CentroCostoDes"
      Me.txtCentroCostoDes.Top = 0.738189!
      Me.txtCentroCostoDes.Width = 3.681103!
      '
      'Label25
      '
      Me.Label25.Border.BottomColor = System.Drawing.Color.Black
      Me.Label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label25.Border.LeftColor = System.Drawing.Color.Black
      Me.Label25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label25.Border.RightColor = System.Drawing.Color.Black
      Me.Label25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label25.Border.TopColor = System.Drawing.Color.Black
      Me.Label25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label25.Height = 0.1889764!
      Me.Label25.HyperLink = Nothing
      Me.Label25.Left = 5.942421!
      Me.Label25.Name = "Label25"
      Me.Label25.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label25.Text = "REVISION:"
      Me.Label25.Top = 0.4533301!
      Me.Label25.Width = 0.625!
      '
      'Label24
      '
      Me.Label24.Border.BottomColor = System.Drawing.Color.Black
      Me.Label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label24.Border.LeftColor = System.Drawing.Color.Black
      Me.Label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label24.Border.RightColor = System.Drawing.Color.Black
      Me.Label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label24.Border.TopColor = System.Drawing.Color.Black
      Me.Label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label24.Height = 0.1875!
      Me.Label24.HyperLink = Nothing
      Me.Label24.Left = 5.942421!
      Me.Label24.Name = "Label24"
      Me.Label24.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label24.Text = "EMISION :"
      Me.Label24.Top = 0.2337598!
      Me.Label24.Width = 0.625!
      '
      'Shape2
      '
      Me.Shape2.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape2.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape2.Border.RightColor = System.Drawing.Color.Black
      Me.Shape2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape2.Border.TopColor = System.Drawing.Color.Black
      Me.Shape2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape2.Height = 1.062992!
      Me.Shape2.Left = 4.92126!
      Me.Shape2.LineWeight = 2.0!
      Me.Shape2.Name = "Shape2"
      Me.Shape2.RoundingRadius = 0.0!
      Me.Shape2.Top = 0.6520669!
      Me.Shape2.Width = 2.571358!
      '
      'Shape6
      '
      Me.Shape6.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape6.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape6.Border.RightColor = System.Drawing.Color.Black
      Me.Shape6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape6.Border.TopColor = System.Drawing.Color.Black
      Me.Shape6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape6.Height = 0.6614173!
      Me.Shape6.Left = 1.587106!
      Me.Shape6.LineWeight = 2.0!
      Me.Shape6.Name = "Shape6"
      Me.Shape6.RoundingRadius = 0.0!
      Me.Shape6.Top = 0.0!
      Me.Shape6.Width = 4.318406!
      '
      'lblTitle
      '
      Me.lblTitle.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.RightColor = System.Drawing.Color.Black
      Me.lblTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.TopColor = System.Drawing.Color.Black
      Me.lblTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Height = 0.246063!
      Me.lblTitle.HyperLink = Nothing
      Me.lblTitle.Left = 1.636319!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.156168!
      Me.lblTitle.Width = 4.202919!
      '
      'lblAlmacenIdOrg
      '
      Me.lblAlmacenIdOrg.Border.BottomColor = System.Drawing.Color.Black
      Me.lblAlmacenIdOrg.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacenIdOrg.Border.LeftColor = System.Drawing.Color.Black
      Me.lblAlmacenIdOrg.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacenIdOrg.Border.RightColor = System.Drawing.Color.Black
      Me.lblAlmacenIdOrg.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacenIdOrg.Border.TopColor = System.Drawing.Color.Black
      Me.lblAlmacenIdOrg.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacenIdOrg.Height = 0.1875!
      Me.lblAlmacenIdOrg.HyperLink = Nothing
      Me.lblAlmacenIdOrg.Left = 0.06151575!
      Me.lblAlmacenIdOrg.Name = "lblAlmacenIdOrg"
      Me.lblAlmacenIdOrg.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.lblAlmacenIdOrg.Text = "PROYECTO :"
      Me.lblAlmacenIdOrg.Top = 0.738189!
      Me.lblAlmacenIdOrg.Width = 1.09375!
      '
      'lblAlmacenIdDes
      '
      Me.lblAlmacenIdDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblAlmacenIdDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacenIdDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblAlmacenIdDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacenIdDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblAlmacenIdDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacenIdDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblAlmacenIdDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacenIdDes.Height = 0.1875!
      Me.lblAlmacenIdDes.HyperLink = Nothing
      Me.lblAlmacenIdDes.Left = 0.06151575!
      Me.lblAlmacenIdDes.Name = "lblAlmacenIdDes"
      Me.lblAlmacenIdDes.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.lblAlmacenIdDes.Text = "UBICACION PROY. :"
      Me.lblAlmacenIdDes.Top = 0.984252!
      Me.lblAlmacenIdDes.Width = 1.09375!
      '
      'Label2
      '
      Me.Label2.Border.BottomColor = System.Drawing.Color.Black
      Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.LeftColor = System.Drawing.Color.Black
      Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.RightColor = System.Drawing.Color.Black
      Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.TopColor = System.Drawing.Color.Black
      Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Height = 0.1875!
      Me.Label2.HyperLink = Nothing
      Me.Label2.Left = 0.06151575!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label2.Text = "SOLICITANTE :"
      Me.Label2.Top = 1.218012!
      Me.Label2.Width = 1.09375!
      '
      'Label4
      '
      Me.Label4.Border.BottomColor = System.Drawing.Color.Black
      Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.LeftColor = System.Drawing.Color.Black
      Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.RightColor = System.Drawing.Color.Black
      Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.TopColor = System.Drawing.Color.Black
      Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Height = 0.1845473!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 4.982776!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label4.Text = "ID PROY. :  "
      Me.Label4.Top = 0.984252!
      Me.Label4.Width = 0.8366142!
      '
      'Label6
      '
      Me.Label6.Border.BottomColor = System.Drawing.Color.Black
      Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.LeftColor = System.Drawing.Color.Black
      Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.RightColor = System.Drawing.Color.Black
      Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.TopColor = System.Drawing.Color.Black
      Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Height = 0.1845472!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 4.982776!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label6.Text = "NRO. :  "
      Me.Label6.Top = 1.218012!
      Me.Label6.Width = 0.8366142!
      '
      'txtUbicacionProy
      '
      Me.txtUbicacionProy.Border.BottomColor = System.Drawing.Color.Black
      Me.txtUbicacionProy.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtUbicacionProy.Border.LeftColor = System.Drawing.Color.Black
      Me.txtUbicacionProy.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtUbicacionProy.Border.RightColor = System.Drawing.Color.Black
      Me.txtUbicacionProy.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtUbicacionProy.Border.TopColor = System.Drawing.Color.Black
      Me.txtUbicacionProy.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtUbicacionProy.Height = 0.1875!
      Me.txtUbicacionProy.Left = 1.181102!
      Me.txtUbicacionProy.Name = "txtUbicacionProy"
      Me.txtUbicacionProy.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtUbicacionProy.Text = Nothing
      Me.txtUbicacionProy.Top = 0.984252!
      Me.txtUbicacionProy.Width = 3.681103!
      '
      'txtPedCompraNro
      '
      Me.txtPedCompraNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
      Me.txtPedCompraNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro.DataField = "PedCompraNro"
      Me.txtPedCompraNro.Height = 0.1875!
      Me.txtPedCompraNro.Left = 5.868603!
      Me.txtPedCompraNro.Name = "txtPedCompraNro"
      Me.txtPedCompraNro.Style = "font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.txtPedCompraNro.Text = "PedCompraNro"
      Me.txtPedCompraNro.Top = 1.218012!
      Me.txtPedCompraNro.Width = 1.574803!
      '
      'txtPedCompraDes
      '
      Me.txtPedCompraDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPedCompraDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraDes.DataField = "PedCompraDes"
      Me.txtPedCompraDes.Height = 0.1875!
      Me.txtPedCompraDes.Left = 1.181102!
      Me.txtPedCompraDes.Name = "txtPedCompraDes"
      Me.txtPedCompraDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtPedCompraDes.Text = "PedCompraDes"
      Me.txtPedCompraDes.Top = 1.218012!
      Me.txtPedCompraDes.Width = 3.681103!
      '
      'txtMonedaDes
      '
      Me.txtMonedaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.DataField = "MonedaDes"
      Me.txtMonedaDes.Height = 0.1875!
      Me.txtMonedaDes.Left = 2.349902!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 0.4429134!
      Me.txtMonedaDes.Visible = False
      Me.txtMonedaDes.Width = 0.9583333!
      '
      'txtFecha
      '
      Me.txtFecha.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFecha.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFecha.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFecha.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.RightColor = System.Drawing.Color.Black
      Me.txtFecha.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.TopColor = System.Drawing.Color.Black
      Me.txtFecha.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.DataField = "Fecha"
      Me.txtFecha.Height = 0.1875!
      Me.txtFecha.Left = 5.868603!
      Me.txtFecha.Name = "txtFecha"
      Me.txtFecha.OutputFormat = resources.GetString("txtFecha.OutputFormat")
      Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFecha.Text = "Fecha"
      Me.txtFecha.Top = 1.464075!
      Me.txtFecha.Width = 1.574803!
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTipoCambio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTipoCambio.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTipoCambio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCambio.Border.RightColor = System.Drawing.Color.Black
      Me.txtTipoCambio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCambio.Border.TopColor = System.Drawing.Color.Black
      Me.txtTipoCambio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCambio.DataField = "TipoCambio"
      Me.txtTipoCambio.Height = 0.1875!
      Me.txtTipoCambio.Left = 1.673228!
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.OutputFormat = resources.GetString("txtTipoCambio.OutputFormat")
      Me.txtTipoCambio.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtTipoCambio.Text = "TipoCambio"
      Me.txtTipoCambio.Top = 0.4429134!
      Me.txtTipoCambio.Visible = False
      Me.txtTipoCambio.Width = 0.6875!
      '
      'txtEstadoId
      '
      Me.txtEstadoId.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEstadoId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoId.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEstadoId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoId.Border.RightColor = System.Drawing.Color.Black
      Me.txtEstadoId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoId.Border.TopColor = System.Drawing.Color.Black
      Me.txtEstadoId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoId.DataField = "EstadoId"
      Me.txtEstadoId.Height = 0.1875!
      Me.txtEstadoId.Left = 5.241142!
      Me.txtEstadoId.Name = "txtEstadoId"
      Me.txtEstadoId.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtEstadoId.Text = "EstadoId"
      Me.txtEstadoId.Top = 0.4429134!
      Me.txtEstadoId.Visible = False
      Me.txtEstadoId.Width = 0.5!
      '
      'Shape11
      '
      Me.Shape11.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape11.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape11.Border.RightColor = System.Drawing.Color.Black
      Me.Shape11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape11.Border.TopColor = System.Drawing.Color.Black
      Me.Shape11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape11.Height = 0.6624836!
      Me.Shape11.Left = 0.0!
      Me.Shape11.LineWeight = 2.0!
      Me.Shape11.Name = "Shape11"
      Me.Shape11.RoundingRadius = 0.0!
      Me.Shape11.Top = 0.0!
      Me.Shape11.Width = 1.587106!
      '
      'txtMoneda
      '
      Me.txtMoneda.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Border.RightColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Border.TopColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Height = 0.1875!
      Me.txtMoneda.Left = 3.346457!
      Me.txtMoneda.Name = "txtMoneda"
      Me.txtMoneda.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMoneda.Text = "Moneda"
      Me.txtMoneda.Top = 0.4306103!
      Me.txtMoneda.Width = 0.9583333!
      '
      'picLogo
      '
      Me.picLogo.Border.BottomColor = System.Drawing.Color.Black
      Me.picLogo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picLogo.Border.LeftColor = System.Drawing.Color.Black
      Me.picLogo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picLogo.Border.RightColor = System.Drawing.Color.Black
      Me.picLogo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picLogo.Border.TopColor = System.Drawing.Color.Black
      Me.picLogo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picLogo.Height = 0.6496063!
      Me.picLogo.Image = Nothing
      Me.picLogo.ImageData = Nothing
      Me.picLogo.Left = 0.0!
      Me.picLogo.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.picLogo.LineWeight = 0.0!
      Me.picLogo.Name = "picLogo"
      Me.picLogo.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
      Me.picLogo.Top = 0.0!
      Me.picLogo.Width = 1.574803!
      '
      'Label3
      '
      Me.Label3.Border.BottomColor = System.Drawing.Color.Black
      Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Border.LeftColor = System.Drawing.Color.Black
      Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Border.RightColor = System.Drawing.Color.Black
      Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Border.TopColor = System.Drawing.Color.Black
      Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Height = 0.1845473!
      Me.Label3.HyperLink = Nothing
      Me.Label3.Left = 4.982776!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label3.Text = "CLIENTE : "
      Me.Label3.Top = 0.738189!
      Me.Label3.Width = 0.8366142!
      '
      'txtCliente
      '
      Me.txtCliente.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCliente.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCliente.Border.RightColor = System.Drawing.Color.Black
      Me.txtCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCliente.Border.TopColor = System.Drawing.Color.Black
      Me.txtCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCliente.Height = 0.1875!
      Me.txtCliente.Left = 5.866142!
      Me.txtCliente.Name = "txtCliente"
      Me.txtCliente.Style = "font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.txtCliente.Text = Nothing
      Me.txtCliente.Top = 0.738189!
      Me.txtCliente.Width = 1.574803!
      '
      'Label1
      '
      Me.Label1.Border.BottomColor = System.Drawing.Color.Black
      Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.LeftColor = System.Drawing.Color.Black
      Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.RightColor = System.Drawing.Color.Black
      Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.TopColor = System.Drawing.Color.Black
      Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Height = 0.1875!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 0.06151575!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label1.Text = "TIPO DE PEDIDO :"
      Me.Label1.Top = 1.464075!
      Me.Label1.Width = 1.09375!
      '
      'Label12
      '
      Me.Label12.Border.BottomColor = System.Drawing.Color.Black
      Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Border.LeftColor = System.Drawing.Color.Black
      Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Border.RightColor = System.Drawing.Color.Black
      Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Border.TopColor = System.Drawing.Color.Black
      Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Height = 0.1845473!
      Me.Label12.HyperLink = Nothing
      Me.Label12.Left = 4.982776!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label12.Text = "FECHA :  "
      Me.Label12.Top = 1.464075!
      Me.Label12.Width = 0.8366142!
      '
      'txtCentroCostoCod
      '
      Me.txtCentroCostoCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCentroCostoCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod.DataField = "CentroCostoCod"
      Me.txtCentroCostoCod.Height = 0.1875!
      Me.txtCentroCostoCod.Left = 5.868603!
      Me.txtCentroCostoCod.Name = "txtCentroCostoCod"
      Me.txtCentroCostoCod.Style = "font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.txtCentroCostoCod.Text = "CentroCostoCod"
      Me.txtCentroCostoCod.Top = 0.984252!
      Me.txtCentroCostoCod.Width = 1.574803!
      '
      'chkMateriales
      '
      Me.chkMateriales.Border.BottomColor = System.Drawing.Color.Black
      Me.chkMateriales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkMateriales.Border.LeftColor = System.Drawing.Color.Black
      Me.chkMateriales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkMateriales.Border.RightColor = System.Drawing.Color.Black
      Me.chkMateriales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkMateriales.Border.TopColor = System.Drawing.Color.Black
      Me.chkMateriales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkMateriales.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
      Me.chkMateriales.Height = 0.1889764!
      Me.chkMateriales.Left = 1.316437!
      Me.chkMateriales.Name = "chkMateriales"
      Me.chkMateriales.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.chkMateriales.Text = "MATERIALES"
      Me.chkMateriales.Top = 1.464075!
      Me.chkMateriales.Width = 0.9791667!
      '
      'chkServicios
      '
      Me.chkServicios.Border.BottomColor = System.Drawing.Color.Black
      Me.chkServicios.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkServicios.Border.LeftColor = System.Drawing.Color.Black
      Me.chkServicios.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkServicios.Border.RightColor = System.Drawing.Color.Black
      Me.chkServicios.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkServicios.Border.TopColor = System.Drawing.Color.Black
      Me.chkServicios.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkServicios.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
      Me.chkServicios.Height = 0.1889764!
      Me.chkServicios.Left = 2.497539!
      Me.chkServicios.Name = "chkServicios"
      Me.chkServicios.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.chkServicios.Text = "SERVICIOS"
      Me.chkServicios.Top = 1.464075!
      Me.chkServicios.Width = 0.9791667!
      '
      'chkOtros
      '
      Me.chkOtros.Border.BottomColor = System.Drawing.Color.Black
      Me.chkOtros.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkOtros.Border.LeftColor = System.Drawing.Color.Black
      Me.chkOtros.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkOtros.Border.RightColor = System.Drawing.Color.Black
      Me.chkOtros.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkOtros.Border.TopColor = System.Drawing.Color.Black
      Me.chkOtros.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.chkOtros.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
      Me.chkOtros.Height = 0.1889764!
      Me.chkOtros.Left = 3.690945!
      Me.chkOtros.Name = "chkOtros"
      Me.chkOtros.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.chkOtros.Text = "OTROS"
      Me.chkOtros.Top = 1.464075!
      Me.chkOtros.Width = 0.9791667!
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFirma, Me.lblCompraObs, Me.txtCompraObs, Me.Line1, Me.Line3})
      Me.ReportFooter.Height = 1.59375!
      Me.ReportFooter.Name = "ReportFooter"
      Me.ReportFooter.PrintAtBottom = True
      '
      'txtFirma
      '
      Me.txtFirma.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFirma.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFirma.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFirma.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFirma.Border.RightColor = System.Drawing.Color.Black
      Me.txtFirma.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFirma.Border.TopColor = System.Drawing.Color.Black
      Me.txtFirma.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFirma.Height = 0.375!
      Me.txtFirma.Left = 0.0!
      Me.txtFirma.Name = "txtFirma"
      Me.txtFirma.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 8pt; vertica" & _
          "l-align: top; "
      Me.txtFirma.Text = "VoBo"
      Me.txtFirma.Top = 1.195538!
      Me.txtFirma.Width = 7.5!
      '
      'lblCompraObs
      '
      Me.lblCompraObs.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCompraObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompraObs.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCompraObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompraObs.Border.RightColor = System.Drawing.Color.Black
      Me.lblCompraObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompraObs.Border.TopColor = System.Drawing.Color.Black
      Me.lblCompraObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompraObs.Height = 0.1875!
      Me.lblCompraObs.HyperLink = Nothing
      Me.lblCompraObs.Left = 2.497539!
      Me.lblCompraObs.Name = "lblCompraObs"
      Me.lblCompraObs.Style = "text-align: center; font-weight: bold; font-style: italic; vertical-align: bottom" & _
          "; "
      Me.lblCompraObs.Text = "Observaciones del Pedido de Compra"
      Me.lblCompraObs.Top = 0.0738189!
      Me.lblCompraObs.Width = 2.755906!
      '
      'txtCompraObs
      '
      Me.txtCompraObs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompraObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtCompraObs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompraObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraObs.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompraObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraObs.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompraObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtCompraObs.DataField = "PedCompraObs"
      Me.txtCompraObs.Height = 0.1845472!
      Me.txtCompraObs.Left = 0.06151575!
      Me.txtCompraObs.Name = "txtCompraObs"
      Me.txtCompraObs.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCompraObs.Text = "PedCompraObs"
      Me.txtCompraObs.Top = 0.2706693!
      Me.txtCompraObs.Width = 7.362205!
      '
      'Line1
      '
      Me.Line1.Border.BottomColor = System.Drawing.Color.Black
      Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line1.Border.LeftColor = System.Drawing.Color.Black
      Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line1.Border.RightColor = System.Drawing.Color.Black
      Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line1.Border.TopColor = System.Drawing.Color.Black
      Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line1.Height = 0.0!
      Me.Line1.Left = 0.0!
      Me.Line1.LineWeight = 3.0!
      Me.Line1.Name = "Line1"
      Me.Line1.Top = 0.0492126!
      Me.Line1.Width = 7.480315!
      Me.Line1.X1 = 0.0!
      Me.Line1.X2 = 7.480315!
      Me.Line1.Y1 = 0.0492126!
      Me.Line1.Y2 = 0.0492126!
      '
      'Line3
      '
      Me.Line3.Border.BottomColor = System.Drawing.Color.Black
      Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line3.Border.LeftColor = System.Drawing.Color.Black
      Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line3.Border.RightColor = System.Drawing.Color.Black
      Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line3.Border.TopColor = System.Drawing.Color.Black
      Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line3.Height = 0.0!
      Me.Line3.Left = 0.06151575!
      Me.Line3.LineWeight = 2.0!
      Me.Line3.Name = "Line3"
      Me.Line3.Top = 0.6397638!
      Me.Line3.Width = 7.418799!
      Me.Line3.X1 = 0.06151575!
      Me.Line3.X2 = 7.480315!
      Me.Line3.Y1 = 0.6397638!
      Me.Line3.Y2 = 0.6397638!
      '
      'PageHeader
      '
      Me.PageHeader.Height = 0.0!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label13, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3868056!
      Me.PageFooter.Name = "PageFooter"
      '
      'txtPageCount
      '
      Me.txtPageCount.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Border.RightColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Border.TopColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Height = 0.1875!
      Me.txtPageCount.Left = 7.125!
      Me.txtPageCount.Name = "txtPageCount"
      Me.txtPageCount.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
      Me.txtPageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageCount.Text = "PageCount"
      Me.txtPageCount.Top = 0.1875!
      Me.txtPageCount.Width = 0.375!
      '
      'txtPageNOfM
      '
      Me.txtPageNOfM.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Border.RightColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Border.TopColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Height = 0.1875!
      Me.txtPageNOfM.Left = 6.4375!
      Me.txtPageNOfM.Name = "txtPageNOfM"
      Me.txtPageNOfM.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPageNOfM.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
      Me.txtPageNOfM.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageNOfM.Text = "PageNumber"
      Me.txtPageNOfM.Top = 0.1875!
      Me.txtPageNOfM.Width = 0.375!
      '
      'Label13
      '
      Me.Label13.Border.BottomColor = System.Drawing.Color.Black
      Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.LeftColor = System.Drawing.Color.Black
      Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.RightColor = System.Drawing.Color.Black
      Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.TopColor = System.Drawing.Color.Black
      Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Height = 0.2!
      Me.Label13.HyperLink = Nothing
      Me.Label13.Left = 6.885408!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.Label13.Text = "de"
      Me.Label13.Top = 0.1875!
      Me.Label13.Width = 0.1875!
      '
      'Line2
      '
      Me.Line2.Border.BottomColor = System.Drawing.Color.Black
      Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line2.Border.LeftColor = System.Drawing.Color.Black
      Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line2.Border.RightColor = System.Drawing.Color.Black
      Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line2.Border.TopColor = System.Drawing.Color.Black
      Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line2.Height = 0.0!
      Me.Line2.Left = 0.02083333!
      Me.Line2.LineWeight = 3.0!
      Me.Line2.Name = "Line2"
      Me.Line2.Top = 0.1458333!
      Me.Line2.Width = 7.5!
      Me.Line2.X1 = 0.02083333!
      Me.Line2.X2 = 7.520833!
      Me.Line2.Y1 = 0.1458333!
      Me.Line2.Y2 = 0.1458333!
      '
      'lblDate
      '
      Me.lblDate.Border.BottomColor = System.Drawing.Color.Black
      Me.lblDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDate.Border.LeftColor = System.Drawing.Color.Black
      Me.lblDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDate.Border.RightColor = System.Drawing.Color.Black
      Me.lblDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDate.Border.TopColor = System.Drawing.Color.Black
      Me.lblDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDate.Height = 0.1875!
      Me.lblDate.HyperLink = Nothing
      Me.lblDate.Left = 0.0!
      Me.lblDate.Name = "lblDate"
      Me.lblDate.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.lblDate.Text = ""
      Me.lblDate.Top = 0.1875!
      Me.lblDate.Width = 2.375!
      '
      'lblTime
      '
      Me.lblTime.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTime.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTime.Border.RightColor = System.Drawing.Color.Black
      Me.lblTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTime.Border.TopColor = System.Drawing.Color.Black
      Me.lblTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTime.Height = 0.1875!
      Me.lblTime.HyperLink = Nothing
      Me.lblTime.Left = 2.4375!
      Me.lblTime.Name = "lblTime"
      Me.lblTime.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.lblTime.Text = ""
      Me.lblTime.Top = 0.1875!
      Me.lblTime.Width = 1.125!
      '
      'lblLogin
      '
      Me.lblLogin.Border.BottomColor = System.Drawing.Color.Black
      Me.lblLogin.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblLogin.Border.LeftColor = System.Drawing.Color.Black
      Me.lblLogin.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblLogin.Border.RightColor = System.Drawing.Color.Black
      Me.lblLogin.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblLogin.Border.TopColor = System.Drawing.Color.Black
      Me.lblLogin.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblLogin.Height = 0.1875!
      Me.lblLogin.HyperLink = Nothing
      Me.lblLogin.Left = 3.625!
      Me.lblLogin.Name = "lblLogin"
      Me.lblLogin.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.lblLogin.Text = ""
      Me.lblLogin.Top = 0.1875!
      Me.lblLogin.Width = 2.0!
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.Label10, Me.Label8, Me.Label11, Me.Label9, Me.Label7, Me.Label15, Me.Label5})
      Me.GroupHeader1.Height = 0.3149606!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'Shape3
      '
      Me.Shape3.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape3.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape3.Border.RightColor = System.Drawing.Color.Black
      Me.Shape3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape3.Border.TopColor = System.Drawing.Color.Black
      Me.Shape3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape3.Height = 0.3149606!
      Me.Shape3.Left = 0.0!
      Me.Shape3.LineWeight = 2.0!
      Me.Shape3.Name = "Shape3"
      Me.Shape3.RoundingRadius = 9.999999!
      Me.Shape3.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape3.Top = 0.0!
      Me.Shape3.Width = 7.485647!
      '
      'Label10
      '
      Me.Label10.Border.BottomColor = System.Drawing.Color.Black
      Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.LeftColor = System.Drawing.Color.Black
      Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.RightColor = System.Drawing.Color.Black
      Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Border.TopColor = System.Drawing.Color.Black
      Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Height = 0.2952756!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.3886156!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label10.Text = "DESCRIPCIÓN"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 3.957021!
      '
      'Label8
      '
      Me.Label8.Border.BottomColor = System.Drawing.Color.Black
      Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.LeftColor = System.Drawing.Color.Black
      Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.RightColor = System.Drawing.Color.Black
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Height = 0.2952756!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 5.680857!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label8.Text = "OBSERVACIONES"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 1.790928!
      '
      'Label11
      '
      Me.Label11.Border.BottomColor = System.Drawing.Color.Black
      Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.LeftColor = System.Drawing.Color.Black
      Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.RightColor = System.Drawing.Color.Black
      Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Border.TopColor = System.Drawing.Color.Black
      Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Height = 0.2952756!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 0.9719489!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: top; "
      Me.Label11.Text = "PRECIO UNITARIO"
      Me.Label11.Top = 0.0!
      Me.Label11.Visible = False
      Me.Label11.Width = 0.6889765!
      '
      'Label9
      '
      Me.Label9.Border.BottomColor = System.Drawing.Color.Black
      Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.LeftColor = System.Drawing.Color.Black
      Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.RightColor = System.Drawing.Color.Black
      Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.TopColor = System.Drawing.Color.Black
      Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Height = 0.2952756!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 4.994013!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label9.Text = "CANTIDAD"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.6889763!
      '
      'Label7
      '
      Me.Label7.Border.BottomColor = System.Drawing.Color.Black
      Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.LeftColor = System.Drawing.Color.Black
      Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.RightColor = System.Drawing.Color.Black
      Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.TopColor = System.Drawing.Color.Black
      Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Height = 0.2952756!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 0.0!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label7.Text = "ITEM"
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 0.3898459!
      '
      'Label15
      '
      Me.Label15.Border.BottomColor = System.Drawing.Color.Black
      Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.LeftColor = System.Drawing.Color.Black
      Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.RightColor = System.Drawing.Color.Black
      Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label15.Border.TopColor = System.Drawing.Color.Black
      Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Height = 0.2952756!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 4.349656!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label15.Text = "UNIDAD"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.6274607!
      '
      'Label5
      '
      Me.Label5.Border.BottomColor = System.Drawing.Color.Black
      Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.LeftColor = System.Drawing.Color.Black
      Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.RightColor = System.Drawing.Color.Black
      Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.TopColor = System.Drawing.Color.Black
      Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Height = 0.2952756!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 3.125!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label5.Text = "COSTO"
      Me.Label5.Top = 0.0!
      Me.Label5.Visible = False
      Me.Label5.Width = 1.218011!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblMontoRec, Me.txtLiteral, Me.txtTotal, Me.TextBox, Me.TextBox4, Me.lblMontoDes, Me.txtMontoDes, Me.lblMontoAnt, Me.lblMontoLiq, Me.txtMontoRec, Me.txtMontoAnt, Me.txtMontoLiq, Me.txtMonedaId})
      Me.GroupFooter1.Height = 0.0!
      Me.GroupFooter1.Name = "GroupFooter1"
      Me.GroupFooter1.Visible = False
      '
      'lblMontoRec
      '
      Me.lblMontoRec.Border.BottomColor = System.Drawing.Color.Black
      Me.lblMontoRec.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoRec.Border.LeftColor = System.Drawing.Color.Black
      Me.lblMontoRec.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoRec.Border.RightColor = System.Drawing.Color.Black
      Me.lblMontoRec.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoRec.Border.TopColor = System.Drawing.Color.Black
      Me.lblMontoRec.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoRec.Height = 0.1875!
      Me.lblMontoRec.Left = 5.208333!
      Me.lblMontoRec.Name = "lblMontoRec"
      Me.lblMontoRec.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoRec.Text = "Recargo (+) :"
      Me.lblMontoRec.Top = 0.375!
      Me.lblMontoRec.Width = 1.0625!
      '
      'txtLiteral
      '
      Me.txtLiteral.Border.BottomColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.LeftColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.RightColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.TopColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLiteral.Height = 0.1875!
      Me.txtLiteral.Left = 0.375!
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtLiteral.Text = Nothing
      Me.txtLiteral.Top = 0.0!
      Me.txtLiteral.Width = 4.822917!
      '
      'txtTotal
      '
      Me.txtTotal.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTotal.DataField = "Importe"
      Me.txtTotal.Height = 0.1845472!
      Me.txtTotal.Left = 6.274607!
      Me.txtTotal.Name = "txtTotal"
      Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
      Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.txtTotal.SummaryGroup = "GroupHeader1"
      Me.txtTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtTotal.Text = "Importe"
      Me.txtTotal.Top = 0.0!
      Me.txtTotal.Width = 1.207595!
      '
      'TextBox
      '
      Me.TextBox.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox.Height = 0.1875!
      Me.TextBox.Left = 0.0!
      Me.TextBox.Name = "TextBox"
      Me.TextBox.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: middle; "
      Me.TextBox.Text = "SON :"
      Me.TextBox.Top = 0.0!
      Me.TextBox.Width = 0.375!
      '
      'TextBox4
      '
      Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox4.Height = 0.1875!
      Me.TextBox4.Left = 5.208333!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.TextBox4.Text = "Total  :    "
      Me.TextBox4.Top = 0.0!
      Me.TextBox4.Width = 1.0625!
      '
      'lblMontoDes
      '
      Me.lblMontoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblMontoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblMontoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblMontoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblMontoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoDes.Height = 0.1875!
      Me.lblMontoDes.Left = 5.208333!
      Me.lblMontoDes.Name = "lblMontoDes"
      Me.lblMontoDes.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoDes.Text = "Descuento (-) :"
      Me.lblMontoDes.Top = 0.5625!
      Me.lblMontoDes.Width = 1.0625!
      '
      'txtMontoDes
      '
      Me.txtMontoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMontoDes.DataField = "ImporteDes"
      Me.txtMontoDes.Height = 0.1845472!
      Me.txtMontoDes.Left = 6.274607!
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.OutputFormat = resources.GetString("txtMontoDes.OutputFormat")
      Me.txtMontoDes.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; verti" & _
          "cal-align: middle; "
      Me.txtMontoDes.SummaryGroup = "GroupHeader1"
      Me.txtMontoDes.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoDes.Text = "ImporteDes"
      Me.txtMontoDes.Top = 0.5659449!
      Me.txtMontoDes.Width = 1.207595!
      '
      'lblMontoAnt
      '
      Me.lblMontoAnt.Border.BottomColor = System.Drawing.Color.Black
      Me.lblMontoAnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoAnt.Border.LeftColor = System.Drawing.Color.Black
      Me.lblMontoAnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoAnt.Border.RightColor = System.Drawing.Color.Black
      Me.lblMontoAnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoAnt.Border.TopColor = System.Drawing.Color.Black
      Me.lblMontoAnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoAnt.Height = 0.1875!
      Me.lblMontoAnt.Left = 5.208333!
      Me.lblMontoAnt.Name = "lblMontoAnt"
      Me.lblMontoAnt.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoAnt.Text = "Anticipo (-) :"
      Me.lblMontoAnt.Top = 0.1875!
      Me.lblMontoAnt.Width = 1.0625!
      '
      'lblMontoLiq
      '
      Me.lblMontoLiq.Border.BottomColor = System.Drawing.Color.Black
      Me.lblMontoLiq.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoLiq.Border.LeftColor = System.Drawing.Color.Black
      Me.lblMontoLiq.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoLiq.Border.RightColor = System.Drawing.Color.Black
      Me.lblMontoLiq.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoLiq.Border.TopColor = System.Drawing.Color.Black
      Me.lblMontoLiq.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoLiq.Height = 0.1875!
      Me.lblMontoLiq.Left = 5.208333!
      Me.lblMontoLiq.Name = "lblMontoLiq"
      Me.lblMontoLiq.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoLiq.Text = "Líquido Pagable :"
      Me.lblMontoLiq.Top = 0.75!
      Me.lblMontoLiq.Width = 1.0625!
      '
      'txtMontoRec
      '
      Me.txtMontoRec.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoRec.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoRec.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoRec.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoRec.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoRec.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoRec.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoRec.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMontoRec.DataField = "ImporteRec"
      Me.txtMontoRec.Height = 0.1968504!
      Me.txtMontoRec.Left = 6.274607!
      Me.txtMontoRec.Name = "txtMontoRec"
      Me.txtMontoRec.OutputFormat = resources.GetString("txtMontoRec.OutputFormat")
      Me.txtMontoRec.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; verti" & _
          "cal-align: middle; "
      Me.txtMontoRec.SummaryGroup = "GroupHeader1"
      Me.txtMontoRec.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoRec.Text = "ImporteRec"
      Me.txtMontoRec.Top = 0.3690945!
      Me.txtMontoRec.Width = 1.207595!
      '
      'txtMontoAnt
      '
      Me.txtMontoAnt.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.DataField = "MontoAnt"
      Me.txtMontoAnt.Height = 0.1845472!
      Me.txtMontoAnt.Left = 6.274607!
      Me.txtMontoAnt.Name = "txtMontoAnt"
      Me.txtMontoAnt.OutputFormat = resources.GetString("txtMontoAnt.OutputFormat")
      Me.txtMontoAnt.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtMontoAnt.Text = "MontoAnt"
      Me.txtMontoAnt.Top = 0.1845472!
      Me.txtMontoAnt.Width = 1.207595!
      '
      'txtMontoLiq
      '
      Me.txtMontoLiq.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoLiq.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoLiq.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoLiq.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoLiq.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoLiq.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoLiq.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoLiq.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMontoLiq.Height = 0.1845472!
      Me.txtMontoLiq.Left = 6.274607!
      Me.txtMontoLiq.Name = "txtMontoLiq"
      Me.txtMontoLiq.OutputFormat = resources.GetString("txtMontoLiq.OutputFormat")
      Me.txtMontoLiq.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.txtMontoLiq.SummaryGroup = "GroupHeader1"
      Me.txtMontoLiq.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoLiq.Text = "ImporteLiq"
      Me.txtMontoLiq.Top = 0.7504922!
      Me.txtMontoLiq.Width = 1.207595!
      '
      'txtMonedaId
      '
      Me.txtMonedaId.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonedaId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaId.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonedaId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaId.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonedaId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaId.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonedaId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaId.DataField = "MonedaId"
      Me.txtMonedaId.Height = 0.1875!
      Me.txtMonedaId.Left = 0.625!
      Me.txtMonedaId.Name = "txtMonedaId"
      Me.txtMonedaId.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtMonedaId.Text = "MonedaId"
      Me.txtMonedaId.Top = 0.1875!
      Me.txtMonedaId.Visible = False
      Me.txtMonedaId.Width = 0.6875!
      '
      'rptPedCompraEditGEU
      '
      Me.MasterReport = False
      OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
          "Catalog=DelfinNet;Data Source=DESARROLLO1"
      OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
      Me.DataSource = OleDBDataSource1
      Me.PageSettings.Margins.Bottom = 0.3!
      Me.PageSettings.Margins.Left = 0.5!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.PaperHeight = 11.0!
      Me.PageSettings.PaperWidth = 8.5!
      Me.PrintWidth = 7.5!
      Me.Sections.Add(Me.ReportHeader)
      Me.Sections.Add(Me.PageHeader)
      Me.Sections.Add(Me.GroupHeader1)
      Me.Sections.Add(Me.Detail)
      Me.Sections.Add(Me.GroupFooter1)
      Me.Sections.Add(Me.PageFooter)
      Me.Sections.Add(Me.ReportFooter)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                  "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtItemNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEmisionDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtRevisionDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIsoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacenIdOrg, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacenIdDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtUbicacionProy, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.chkMateriales, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.chkServicios, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.chkOtros, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoRec, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoLiq, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoRec, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoLiq, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Dim lngItemNro As Long = 0

   Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
      If txtEstadoId.Text = "12" Then
         picAnulado.Visible = True
      End If

      txtMoneda.Text = "( en " & txtMonedaDes.Text & " ) "

      Dim strPedCompraDes As String = txtPedCompraDes.Text

      If strPedCompraDes.Length > 0 Then
         strPedCompraDes = strPedCompraDes.Substring(strPedCompraDes.IndexOf("-") + 1)
         txtPedCompraDes.Text = strPedCompraDes
      End If

      txtCentroCostoDes.Text = CentroCostoDesFind(ToLong(Me.Fields("CentroCostoId").Value), txtCentroCostoCod.Text)
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      Dim decDesplazo As Decimal = 0
      Dim oPoint As System.Drawing.PointF

      txtMontoLiq.Text = ToDecStrDos(ToDouble(txtTotal.Text) + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text) - ToDouble(txtMontoAnt.Text))

      txtLiteral.Text = CifraLiteral(ToDecimal(txtMontoLiq.Text)) + "  " + UCase(txtMonedaDes.Text)

      If ToDecimal(txtMontoAnt.Text) = 0 Then
         lblMontoAnt.Height = 0
         txtMontoAnt.Height = 0
         lblMontoAnt.Visible = False
         txtMontoAnt.Visible = False

         decDesplazo += 0.188
      End If

      oPoint.X = lblMontoRec.Location.X
      oPoint.Y = lblMontoRec.Location.Y - decDesplazo
      lblMontoRec.Location = oPoint

      oPoint.X = txtMontoRec.Location.X
      oPoint.Y = txtMontoRec.Location.Y - decDesplazo
      txtMontoRec.Location = oPoint

      If ToDecimal(txtMontoRec.Text) = 0 Then
         lblMontoRec.Height = 0
         txtMontoRec.Height = 0
         lblMontoRec.Visible = False
         txtMontoRec.Visible = False

         decDesplazo += 0.188
      End If

      oPoint.X = lblMontoDes.Location.X
      oPoint.Y = lblMontoDes.Location.Y - decDesplazo
      lblMontoDes.Location = oPoint

      oPoint.X = txtMontoDes.Location.X
      oPoint.Y = txtMontoDes.Location.Y - decDesplazo
      txtMontoDes.Location = oPoint

      If ToDecimal(txtMontoDes.Text) = 0 Then
         decDesplazo += 0.188
         lblMontoDes.Height = 0
         txtMontoDes.Height = 0
         lblMontoDes.Visible = False
         txtMontoDes.Visible = False
      End If

      oPoint.X = lblMontoLiq.Location.X
      oPoint.Y = lblMontoLiq.Location.Y - decDesplazo
      lblMontoLiq.Location = oPoint

      oPoint.X = txtMontoLiq.Location.X
      oPoint.Y = txtMontoLiq.Location.Y - decDesplazo
      txtMontoLiq.Location = oPoint

      GroupFooter1.Height = GroupFooter1.Height - decDesplazo

   End Sub

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      lngItemNro += 1
      txtItemNro.Text = ToStr(lngItemNro)
   End Sub

   Private Function MonedaDesFind(ByVal lngMonedaId As Long) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      MonedaDesFind = ""

      Try
         With oMoneda
            .MonedaId = lngMonedaId

            If .FindByPK Then
               MonedaDesFind = .MonedaDes
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oMoneda.Dispose()
      End Try
   End Function

   Private Function CentroCostoDesFind(ByVal lngCentroCostoId As Long, ByRef strCentroCostoCod As String) As String
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

      CentroCostoDesFind = ""
      strCentroCostoCod = ""

      Try
         With oCentroCosto
            .CentroCostoId = lngCentroCostoId
            If .FindByPK Then
               strCentroCostoCod = .CentroCostoCod

               CentroCostoDesFind = .CentroCostoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()

      End Try
   End Function

End Class