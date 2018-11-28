Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptCompraEditGEU
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
   Private Label5 As DataDynamics.ActiveReports.Label = Nothing
   Private Label6 As DataDynamics.ActiveReports.Label = Nothing
   Private Label14 As DataDynamics.ActiveReports.Label = Nothing
   Private txtCompraDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtCentroCostoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox18 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtCentroCostoCod As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private Label16 As DataDynamics.ActiveReports.Label = Nothing
   Private TextBox22 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox23 As DataDynamics.ActiveReports.TextBox = Nothing
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
   Private TextBox31 As DataDynamics.ActiveReports.TextBox = Nothing
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
   Private WithEvents Label3 As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
   Public WithEvents srptLotesSeries As DataDynamics.ActiveReports.SubReport
   Private WithEvents Shape4 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape5 As DataDynamics.ActiveReports.Shape
   Private WithEvents Label12 As DataDynamics.ActiveReports.Label
   Private WithEvents Label17 As DataDynamics.ActiveReports.Label
   Private WithEvents Label18 As DataDynamics.ActiveReports.Label
   Private WithEvents Label19 As DataDynamics.ActiveReports.Label
   Private WithEvents Label23 As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label26 As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label27 As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Shape6 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape7 As DataDynamics.ActiveReports.Shape
   Public WithEvents txtIsoDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtEmisionDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label24 As DataDynamics.ActiveReports.Label
   Private WithEvents Label25 As DataDynamics.ActiveReports.Label
   Private WithEvents Shape9 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape8 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape10 As DataDynamics.ActiveReports.Shape
   Private WithEvents Line1 As DataDynamics.ActiveReports.Line
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Private WithEvents txtPedCompraNros As DataDynamics.ActiveReports.TextBox
   Private WithEvents Shape11 As DataDynamics.ActiveReports.Shape
   Public WithEvents txtRevisionDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtMoneda As DataDynamics.ActiveReports.TextBox
   Public WithEvents picLogo As DataDynamics.ActiveReports.Picture
   Public WithEvents lblMontoRet As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtMontoRet As DataDynamics.ActiveReports.TextBox
   Private WithEvents Line3 As DataDynamics.ActiveReports.Line

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCompraEditGEU))
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtItemNro = New DataDynamics.ActiveReports.TextBox
      Me.txtItemDes = New DataDynamics.ActiveReports.TextBox
      Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox30 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox31 = New DataDynamics.ActiveReports.TextBox
      Me.srptLotesSeries = New DataDynamics.ActiveReports.SubReport
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.Shape7 = New DataDynamics.ActiveReports.Shape
      Me.picAnulado = New DataDynamics.ActiveReports.Picture
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
      Me.Shape9 = New DataDynamics.ActiveReports.Shape
      Me.Shape8 = New DataDynamics.ActiveReports.Shape
      Me.txtEmisionDes = New DataDynamics.ActiveReports.TextBox
      Me.Shape10 = New DataDynamics.ActiveReports.Shape
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.txtRevisionDes = New DataDynamics.ActiveReports.TextBox
      Me.txtIsoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCompraDes = New DataDynamics.ActiveReports.TextBox
      Me.Label25 = New DataDynamics.ActiveReports.Label
      Me.Label24 = New DataDynamics.ActiveReports.Label
      Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
      Me.Shape5 = New DataDynamics.ActiveReports.Shape
      Me.Shape4 = New DataDynamics.ActiveReports.Shape
      Me.txtPedCompraNros = New DataDynamics.ActiveReports.TextBox
      Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
      Me.Shape2 = New DataDynamics.ActiveReports.Shape
      Me.Shape6 = New DataDynamics.ActiveReports.Shape
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.lblAlmacenIdOrg = New DataDynamics.ActiveReports.Label
      Me.lblAlmacenIdDes = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.txtCentroCostoDes = New DataDynamics.ActiveReports.TextBox
      Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCostoCod = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.Label16 = New DataDynamics.ActiveReports.Label
      Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox23 = New DataDynamics.ActiveReports.TextBox
      Me.txtTipoCambio = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoId = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.Label17 = New DataDynamics.ActiveReports.Label
      Me.Label18 = New DataDynamics.ActiveReports.Label
      Me.Label19 = New DataDynamics.ActiveReports.Label
      Me.Label23 = New DataDynamics.ActiveReports.Label
      Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
      Me.Label26 = New DataDynamics.ActiveReports.Label
      Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
      Me.Label27 = New DataDynamics.ActiveReports.Label
      Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
      Me.Shape11 = New DataDynamics.ActiveReports.Shape
      Me.txtMoneda = New DataDynamics.ActiveReports.TextBox
      Me.picLogo = New DataDynamics.ActiveReports.Picture
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
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label15 = New DataDynamics.ActiveReports.Label
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
      Me.lblMontoRet = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoRet = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtItemNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEmisionDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtRevisionDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIsoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompraDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraNros, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacenIdOrg, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacenIdDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
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
      CType(Me.lblMontoRet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoRet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtItemNro, Me.txtItemDes, Me.TextBox27, Me.TextBox28, Me.TextBox30, Me.TextBox31, Me.srptLotesSeries})
      Me.Detail.Height = 0.1889764!
      Me.Detail.Name = "Detail"
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
      Me.txtItemNro.Width = 0.5!
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
      Me.txtItemDes.Left = 2.5625!
      Me.txtItemDes.Name = "txtItemDes"
      Me.txtItemDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtItemDes.Text = "ItemDes"
      Me.txtItemDes.Top = 0.0!
      Me.txtItemDes.Width = 3.697917!
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
      Me.TextBox27.Left = 1.229167!
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
      Me.TextBox28.Left = 0.5104167!
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
      Me.TextBox30.Width = 0.6875!
      '
      'TextBox31
      '
      Me.TextBox31.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox31.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox31.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox31.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox31.DataField = "Importe"
      Me.TextBox31.Height = 0.1845472!
      Me.TextBox31.Left = 6.274607!
      Me.TextBox31.Name = "TextBox31"
      Me.TextBox31.OutputFormat = resources.GetString("TextBox31.OutputFormat")
      Me.TextBox31.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox31.Text = "Importe"
      Me.TextBox31.Top = 0.0!
      Me.TextBox31.Width = 1.207595!
      '
      'srptLotesSeries
      '
      Me.srptLotesSeries.Border.BottomColor = System.Drawing.Color.Black
      Me.srptLotesSeries.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptLotesSeries.Border.LeftColor = System.Drawing.Color.Black
      Me.srptLotesSeries.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptLotesSeries.Border.RightColor = System.Drawing.Color.Black
      Me.srptLotesSeries.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptLotesSeries.Border.TopColor = System.Drawing.Color.Black
      Me.srptLotesSeries.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptLotesSeries.CloseBorder = False
      Me.srptLotesSeries.Height = 0.1875!
      Me.srptLotesSeries.Left = 2.708333!
      Me.srptLotesSeries.Name = "srptLotesSeries"
      Me.srptLotesSeries.Report = Nothing
      Me.srptLotesSeries.ReportName = ""
      Me.srptLotesSeries.Top = 0.1875!
      Me.srptLotesSeries.Width = 3.3125!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape7, Me.picAnulado, Me.Shape1, Me.Shape9, Me.Shape8, Me.txtEmisionDes, Me.Shape10, Me.TextBox5, Me.Label1, Me.txtRevisionDes, Me.txtIsoDes, Me.txtCompraDes, Me.Label25, Me.Label24, Me.TextBox6, Me.Shape5, Me.Shape4, Me.txtPedCompraNros, Me.TextBox8, Me.Shape2, Me.Shape6, Me.lblTitle, Me.lblAlmacenIdOrg, Me.lblAlmacenIdDes, Me.Label2, Me.Label4, Me.Label5, Me.Label6, Me.Label14, Me.txtCentroCostoDes, Me.TextBox18, Me.txtCentroCostoCod, Me.txtMonedaDes, Me.Label16, Me.TextBox22, Me.TextBox23, Me.txtTipoCambio, Me.txtEstadoId, Me.Label3, Me.TextBox1, Me.Label12, Me.Label17, Me.Label18, Me.Label19, Me.Label23, Me.TextBox7, Me.TextBox11, Me.Label26, Me.TextBox13, Me.Label27, Me.TextBox14, Me.Shape11, Me.txtMoneda, Me.picLogo})
      Me.ReportHeader.Height = 2.874016!
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
      Me.Shape1.Height = 0.8120079!
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
      'Shape10
      '
      Me.Shape10.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape10.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape10.Border.RightColor = System.Drawing.Color.Black
      Me.Shape10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape10.Border.TopColor = System.Drawing.Color.Black
      Me.Shape10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape10.Height = 0.3937008!
      Me.Shape10.Left = 0.0!
      Me.Shape10.LineWeight = 2.0!
      Me.Shape10.Name = "Shape10"
      Me.Shape10.RoundingRadius = 0.0!
      Me.Shape10.Top = 2.472933!
      Me.Shape10.Width = 7.492126!
      '
      'TextBox5
      '
      Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.DataField = "ContactoCargo"
      Me.TextBox5.Height = 0.1875!
      Me.TextBox5.Left = 1.181102!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox5.Text = "Cargo"
      Me.TextBox5.Top = 1.537894!
      Me.TextBox5.Width = 3.681103!
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
      Me.Label1.Left = 4.982776!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label1.Text = "NRO PEDIDO :"
      Me.Label1.Top = 2.239173!
      Me.Label1.Width = 0.8125!
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
      'txtCompraDes
      '
      Me.txtCompraDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompraDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCompraDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompraDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompraDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompraDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraDes.DataField = "CompraDes"
      Me.txtCompraDes.Height = 0.1875!
      Me.txtCompraDes.Left = 1.181102!
      Me.txtCompraDes.Name = "txtCompraDes"
      Me.txtCompraDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtCompraDes.Text = "CompraDes"
      Me.txtCompraDes.Top = 0.738189!
      Me.txtCompraDes.Width = 3.681103!
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
      'TextBox6
      '
      Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.DataField = "ProveedorDes"
      Me.TextBox6.Height = 0.1875!
      Me.TextBox6.Left = 1.181102!
      Me.TextBox6.Name = "TextBox6"
      Me.TextBox6.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox6.Text = "ProveedorDes"
      Me.TextBox6.Top = 1.771654!
      Me.TextBox6.Width = 3.681103!
      '
      'Shape5
      '
      Me.Shape5.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape5.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape5.Border.RightColor = System.Drawing.Color.Black
      Me.Shape5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape5.Border.TopColor = System.Drawing.Color.Black
      Me.Shape5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape5.Height = 1.023622!
      Me.Shape5.Left = 4.92126!
      Me.Shape5.LineWeight = 2.0!
      Me.Shape5.Name = "Shape5"
      Me.Shape5.RoundingRadius = 0.0!
      Me.Shape5.Top = 1.456693!
      Me.Shape5.Width = 2.570866!
      '
      'Shape4
      '
      Me.Shape4.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.RightColor = System.Drawing.Color.Black
      Me.Shape4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.TopColor = System.Drawing.Color.Black
      Me.Shape4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Height = 1.023622!
      Me.Shape4.Left = 0.0!
      Me.Shape4.LineWeight = 2.0!
      Me.Shape4.Name = "Shape4"
      Me.Shape4.RoundingRadius = 0.0!
      Me.Shape4.Top = 1.456693!
      Me.Shape4.Width = 4.92126!
      '
      'txtPedCompraNros
      '
      Me.txtPedCompraNros.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraNros.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPedCompraNros.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraNros.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNros.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraNros.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNros.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraNros.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNros.Height = 0.1875!
      Me.txtPedCompraNros.Left = 5.831693!
      Me.txtPedCompraNros.Name = "txtPedCompraNros"
      Me.txtPedCompraNros.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.txtPedCompraNros.Text = "CompraOrden"
      Me.txtPedCompraNros.Top = 2.239173!
      Me.txtPedCompraNros.Width = 1.574803!
      '
      'TextBox8
      '
      Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.DataField = "ContactoDes"
      Me.TextBox8.Height = 0.1875!
      Me.TextBox8.Left = 1.181102!
      Me.TextBox8.Name = "TextBox8"
      Me.TextBox8.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox8.Text = "ContactoDes"
      Me.TextBox8.Top = 2.005413!
      Me.TextBox8.Width = 3.681103!
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
      Me.Shape2.Height = 0.8120079!
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
      Me.lblAlmacenIdOrg.Text = "SOLICITADO POR :"
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
      Me.lblAlmacenIdDes.Text = "PROYECTO :"
      Me.lblAlmacenIdDes.Top = 0.9719489!
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
      Me.Label2.Text = "COD-PROY :"
      Me.Label2.Top = 1.205709!
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
      Me.Label4.Height = 0.1875!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 4.982776!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label4.Text = "Nro. :  "
      Me.Label4.Top = 0.9719489!
      Me.Label4.Width = 0.472441!
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
      Me.Label5.Height = 0.1875!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 3.740157!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; "
      Me.Label5.Text = "T.C.        :"
      Me.Label5.Top = 2.621555!
      Me.Label5.Visible = False
      Me.Label5.Width = 0.2604167!
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
      Me.Label6.Height = 0.1875!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 4.982776!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label6.Text = "Fecha :  "
      Me.Label6.Top = 1.205709!
      Me.Label6.Width = 0.472441!
      '
      'Label14
      '
      Me.Label14.Border.BottomColor = System.Drawing.Color.Black
      Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.LeftColor = System.Drawing.Color.Black
      Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.RightColor = System.Drawing.Color.Black
      Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.TopColor = System.Drawing.Color.Black
      Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Height = 0.1875!
      Me.Label14.HyperLink = Nothing
      Me.Label14.Left = 4.872047!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label14.Text = "Moneda :"
      Me.Label14.Top = 2.621555!
      Me.Label14.Visible = False
      Me.Label14.Width = 0.5625!
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
      Me.txtCentroCostoDes.Top = 0.9719489!
      Me.txtCentroCostoDes.Width = 3.681103!
      '
      'TextBox18
      '
      Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
      Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.DataField = "CompraNro"
      Me.TextBox18.Height = 0.1875!
      Me.TextBox18.Left = 5.474902!
      Me.TextBox18.Name = "TextBox18"
      Me.TextBox18.Style = "font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.TextBox18.Text = "CompraNro"
      Me.TextBox18.Top = 0.9719489!
      Me.TextBox18.Width = 0.7604167!
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
      Me.txtCentroCostoCod.Left = 1.181102!
      Me.txtCentroCostoCod.Name = "txtCentroCostoCod"
      Me.txtCentroCostoCod.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtCentroCostoCod.Text = "CentroCostoCod"
      Me.txtCentroCostoCod.Top = 1.205709!
      Me.txtCentroCostoCod.Width = 3.681103!
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
      Me.txtMonedaDes.Left = 5.511811!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 2.621555!
      Me.txtMonedaDes.Visible = False
      Me.txtMonedaDes.Width = 0.9583333!
      '
      'Label16
      '
      Me.Label16.Border.BottomColor = System.Drawing.Color.Black
      Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Border.LeftColor = System.Drawing.Color.Black
      Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Border.RightColor = System.Drawing.Color.Black
      Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Border.TopColor = System.Drawing.Color.Black
      Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Height = 0.1875!
      Me.Label16.HyperLink = Nothing
      Me.Label16.Left = 0.03690945!
      Me.Label16.Name = "Label16"
      Me.Label16.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label16.Text = "FORMA DE PAGO :"
      Me.Label16.Top = 2.595062!
      Me.Label16.Width = 1.141732!
      '
      'TextBox22
      '
      Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox22.DataField = "TipoPagoDes"
      Me.TextBox22.Height = 0.1875!
      Me.TextBox22.Left = 1.205709!
      Me.TextBox22.Name = "TextBox22"
      Me.TextBox22.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox22.Text = "TipoPagoDes"
      Me.TextBox22.Top = 2.595062!
      Me.TextBox22.Width = 1.968504!
      '
      'TextBox23
      '
      Me.TextBox23.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox23.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox23.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox23.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox23.DataField = "Fecha"
      Me.TextBox23.Height = 0.1875!
      Me.TextBox23.Left = 5.474902!
      Me.TextBox23.Name = "TextBox23"
      Me.TextBox23.OutputFormat = resources.GetString("TextBox23.OutputFormat")
      Me.TextBox23.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox23.Text = "Fecha"
      Me.TextBox23.Top = 1.205709!
      Me.TextBox23.Width = 0.7604167!
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
      Me.txtTipoCambio.Left = 4.133858!
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.OutputFormat = resources.GetString("txtTipoCambio.OutputFormat")
      Me.txtTipoCambio.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtTipoCambio.Text = "TipoCambio"
      Me.txtTipoCambio.Top = 2.621555!
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
      Me.Label3.Height = 0.1875!
      Me.Label3.HyperLink = Nothing
      Me.Label3.Left = 6.311516!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label3.Text = "NRO. ORD. COMPRA "
      Me.Label3.Top = 0.738189!
      Me.Label3.Width = 1.145833!
      '
      'TextBox1
      '
      Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.DataField = "CompraOrden"
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 6.311516!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox1.Text = "CompraOrden"
      Me.TextBox1.Top = 0.9719489!
      Me.TextBox1.Width = 1.15625!
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
      Me.Label12.Height = 0.1875!
      Me.Label12.HyperLink = Nothing
      Me.Label12.Left = 0.01230315!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label12.Text = "AUTORIZADO POR :"
      Me.Label12.Top = 1.537894!
      Me.Label12.Width = 1.140625!
      '
      'Label17
      '
      Me.Label17.Border.BottomColor = System.Drawing.Color.Black
      Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.LeftColor = System.Drawing.Color.Black
      Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.RightColor = System.Drawing.Color.Black
      Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.TopColor = System.Drawing.Color.Black
      Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Height = 0.1875!
      Me.Label17.HyperLink = Nothing
      Me.Label17.Left = 0.01230315!
      Me.Label17.Name = "Label17"
      Me.Label17.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label17.Text = "PROVEEDOR :"
      Me.Label17.Top = 1.771654!
      Me.Label17.Width = 1.140625!
      '
      'Label18
      '
      Me.Label18.Border.BottomColor = System.Drawing.Color.Black
      Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label18.Border.LeftColor = System.Drawing.Color.Black
      Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label18.Border.RightColor = System.Drawing.Color.Black
      Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label18.Border.TopColor = System.Drawing.Color.Black
      Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label18.Height = 0.1875!
      Me.Label18.HyperLink = Nothing
      Me.Label18.Left = 0.01230315!
      Me.Label18.Name = "Label18"
      Me.Label18.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label18.Text = "CONTACTO :"
      Me.Label18.Top = 2.005413!
      Me.Label18.Width = 1.140625!
      '
      'Label19
      '
      Me.Label19.Border.BottomColor = System.Drawing.Color.Black
      Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Border.LeftColor = System.Drawing.Color.Black
      Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Border.RightColor = System.Drawing.Color.Black
      Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Border.TopColor = System.Drawing.Color.Black
      Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Height = 0.1845473!
      Me.Label19.HyperLink = Nothing
      Me.Label19.Left = 4.982776!
      Me.Label19.Name = "Label19"
      Me.Label19.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label19.Text = "Tel : "
      Me.Label19.Top = 1.537894!
      Me.Label19.Width = 0.4741635!
      '
      'Label23
      '
      Me.Label23.Border.BottomColor = System.Drawing.Color.Black
      Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label23.Border.LeftColor = System.Drawing.Color.Black
      Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label23.Border.RightColor = System.Drawing.Color.Black
      Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label23.Border.TopColor = System.Drawing.Color.Black
      Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label23.Height = 0.1889764!
      Me.Label23.HyperLink = Nothing
      Me.Label23.Left = 4.982776!
      Me.Label23.Name = "Label23"
      Me.Label23.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label23.Text = "e-mail : "
      Me.Label23.Top = 2.005413!
      Me.Label23.Width = 0.4741635!
      '
      'TextBox7
      '
      Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.DataField = "Telefono1"
      Me.TextBox7.Height = 0.1875!
      Me.TextBox7.Left = 5.474902!
      Me.TextBox7.Name = "TextBox7"
      Me.TextBox7.Style = "font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.TextBox7.Text = "Telefono1"
      Me.TextBox7.Top = 1.537894!
      Me.TextBox7.Width = 1.929134!
      '
      'TextBox11
      '
      Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.DataField = "Email"
      Me.TextBox11.Height = 0.1875!
      Me.TextBox11.Left = 5.474902!
      Me.TextBox11.Name = "TextBox11"
      Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
      Me.TextBox11.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox11.Text = "Email"
      Me.TextBox11.Top = 2.005413!
      Me.TextBox11.Width = 1.929134!
      '
      'Label26
      '
      Me.Label26.Border.BottomColor = System.Drawing.Color.Black
      Me.Label26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label26.Border.LeftColor = System.Drawing.Color.Black
      Me.Label26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label26.Border.RightColor = System.Drawing.Color.Black
      Me.Label26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label26.Border.TopColor = System.Drawing.Color.Black
      Me.Label26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label26.Height = 0.1875!
      Me.Label26.HyperLink = Nothing
      Me.Label26.Left = 4.982776!
      Me.Label26.Name = "Label26"
      Me.Label26.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label26.Text = "Fax : "
      Me.Label26.Top = 1.771654!
      Me.Label26.Width = 0.46875!
      '
      'TextBox13
      '
      Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.DataField = "Fax"
      Me.TextBox13.Height = 0.1875!
      Me.TextBox13.Left = 5.474902!
      Me.TextBox13.Name = "TextBox13"
      Me.TextBox13.Style = "ddo-char-set: 1; font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.TextBox13.Text = "Fax"
      Me.TextBox13.Top = 1.771654!
      Me.TextBox13.Width = 1.929134!
      '
      'Label27
      '
      Me.Label27.Border.BottomColor = System.Drawing.Color.Black
      Me.Label27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label27.Border.LeftColor = System.Drawing.Color.Black
      Me.Label27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label27.Border.RightColor = System.Drawing.Color.Black
      Me.Label27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label27.Border.TopColor = System.Drawing.Color.Black
      Me.Label27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label27.Height = 0.1875!
      Me.Label27.HyperLink = Nothing
      Me.Label27.Left = 0.01230315!
      Me.Label27.Name = "Label27"
      Me.Label27.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label27.Text = "NRO_COTIZACION :"
      Me.Label27.Top = 2.239173!
      Me.Label27.Width = 1.140625!
      '
      'TextBox14
      '
      Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.DataField = "ContactoCI"
      Me.TextBox14.Height = 0.1875!
      Me.TextBox14.Left = 1.181102!
      Me.TextBox14.Name = "TextBox14"
      Me.TextBox14.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox14.Text = "ContactoCI"
      Me.TextBox14.Top = 2.239173!
      Me.TextBox14.Width = 3.681103!
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
      Me.lblCompraObs.Text = "Observaciones de la Compra"
      Me.lblCompraObs.Top = 0.0738189!
      Me.lblCompraObs.Width = 1.968504!
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
      Me.txtCompraObs.DataField = "CompraObs"
      Me.txtCompraObs.Height = 0.1845472!
      Me.txtCompraObs.Left = 0.06151575!
      Me.txtCompraObs.Name = "txtCompraObs"
      Me.txtCompraObs.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCompraObs.Text = "CompraObs"
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
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.Label8, Me.Label11, Me.Label9, Me.Label10, Me.Label7, Me.Label15})
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
      Me.Label8.Left = 6.274607!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label8.Text = "COSTO"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 1.218011!
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
      Me.Label11.Left = 1.833169!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: top; "
      Me.Label11.Text = "PRECIO UNITARIO"
      Me.Label11.Top = 0.0!
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
      Me.Label9.Left = 0.5044292!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label9.Text = "CANTIDAD"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.6889763!
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
      Me.Label10.Left = 2.534449!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label10.Text = "DESCRIPCIÓN"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 3.727854!
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
      Me.Label7.Width = 0.5044292!
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
      Me.Label15.Left = 1.193406!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label15.Text = "UNIDAD"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.6274607!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblMontoRec, Me.txtLiteral, Me.txtTotal, Me.TextBox, Me.TextBox4, Me.lblMontoDes, Me.txtMontoDes, Me.lblMontoAnt, Me.lblMontoLiq, Me.txtMontoRec, Me.txtMontoAnt, Me.txtMontoLiq, Me.txtMonedaId, Me.lblMontoRet, Me.txtMontoRet})
      Me.GroupFooter1.Height = 1.220472!
      Me.GroupFooter1.Name = "GroupFooter1"
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
      Me.lblMontoLiq.Top = 0.9448819!
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
      Me.txtMontoLiq.Top = 0.9448819!
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
      'lblMontoRet
      '
      Me.lblMontoRet.Border.BottomColor = System.Drawing.Color.Black
      Me.lblMontoRet.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoRet.Border.LeftColor = System.Drawing.Color.Black
      Me.lblMontoRet.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoRet.Border.RightColor = System.Drawing.Color.Black
      Me.lblMontoRet.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoRet.Border.TopColor = System.Drawing.Color.Black
      Me.lblMontoRet.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoRet.Height = 0.1875!
      Me.lblMontoRet.Left = 3.75!
      Me.lblMontoRet.Name = "lblMontoRet"
      Me.lblMontoRet.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoRet.Text = "Retención (-) :"
      Me.lblMontoRet.Top = 0.75!
      Me.lblMontoRet.Width = 2.520833!
      '
      'txtMontoRet
      '
      Me.txtMontoRet.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoRet.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoRet.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoRet.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoRet.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoRet.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoRet.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoRet.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoRet.Height = 0.1875!
      Me.txtMontoRet.Left = 6.27559!
      Me.txtMontoRet.Name = "txtMontoRet"
      Me.txtMontoRet.OutputFormat = resources.GetString("txtMontoRet.OutputFormat")
      Me.txtMontoRet.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtMontoRet.Text = "0"
      Me.txtMontoRet.Top = 0.75!
      Me.txtMontoRet.Width = 1.208661!
      '
      'rptCompraEditGEU
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
      CType(Me.txtItemNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEmisionDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtRevisionDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIsoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCompraDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraNros, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacenIdOrg, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacenIdDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
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
      CType(Me.lblMontoRet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoRet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Dim mlngNotaId As Long = 0
   Dim lngItemNro As Long = 0

   Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
      If txtEstadoId.Text = "12" Then
         picAnulado.Visible = True
      End If

      txtMoneda.Text = "( en " & txtMonedaDes.Text & " ) "

      Call NotaFind(ToLong(Me.Fields("TipoNotaId").Value), ToLong(Me.Fields("NotaNro").Value), mlngNotaId)
      Dim strCompraDes As String = txtCompraDes.Text

      If strCompraDes.Length > 0 Then
         strCompraDes = strCompraDes.Substring(strCompraDes.IndexOf("-") + 1)
         txtCompraDes.Text = strCompraDes
      End If

      txtCentroCostoDes.Text = CentroCostoDesFind(ToLong(Me.Fields("CentroCostoId").Value), txtCentroCostoCod.Text)
      txtPedCompraNros.Text = getNroPedidosFind(ToLong(Me.Fields("CompraId").Value))
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      Dim decDesplazo As Decimal = 0
      Dim oPoint As System.Drawing.PointF

      txtMontoLiq.Text = ToDecStrDos(ToDouble(txtTotal.Text) + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text) - ToDouble(txtMontoAnt.Text) - ToDouble(txtMontoRet.Text))

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

      oPoint.X = lblMontoRet.Location.X
      oPoint.Y = lblMontoRet.Location.Y - decDesplazo
      lblMontoRet.Location = oPoint

      oPoint.X = txtMontoRet.Location.X
      oPoint.Y = txtMontoRet.Location.Y - decDesplazo
      txtMontoRet.Location = oPoint

      If ToDecimal(txtMontoRet.Text) = 0 Then
         lblMontoRet.Height = 0
         txtMontoRet.Height = 0
         lblMontoRet.Visible = False
         txtMontoRet.Visible = False

         decDesplazo += 0.188
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

      Dim strProformaDetDes As String = ToStr(Me.Fields("CompraDetDes").Value)

      If (strProformaDetDes.Length > 0) Then
         txtItemDes.Text = txtItemDes.Text + "" + vbCrLf + "" + strProformaDetDes
      End If

      ''Lotes y Series
      If (mlngNotaId > 0) And (ToBool(Me.Fields("ControlLote").Value) Or ToBool(Me.Fields("ControlSerie").Value)) Then
         Dim bool As Boolean
         bool = CargarLotesSeriesEnt(ToLong(Me.Fields("ItemId").Value), mlngNotaId, ToBool(Me.Fields("ControlLote").Value), ToBool(Me.Fields("ControlSerie").Value))
         srptLotesSeries.Visible = bool
      Else
         srptLotesSeries.Visible = False
         srptLotesSeries.Height = 0
      End If

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

   Private Function NotaFind(ByVal lngTipoNotaId As Long, ByVal lngNotaNro As Long, ByRef lngNotaId As Long) As Boolean
      Dim oNota As New clsNota(clsAppInfo.ConnectString)

      NotaFind = False

      Try
         With oNota
            .SelectFilter = clsNota.SelectFilters.All
            .WhereFilter = clsNota.WhereFilters.NotaNro
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoNotaId = lngTipoNotaId
            .NotaNro = lngNotaNro

            If .Find Then
               lngNotaId = .NotaId

               NotaFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNota.Dispose()

      End Try
   End Function

   Private Function CargarLotesSeriesEnt(ByVal lngItemId As Long, ByVal lngNotaId As Long, _
                          ByVal boolLote As Boolean, ByVal boolSerie As Boolean) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim strSeries As String = String.Empty
      CargarLotesSeriesEnt = False
      Dim rpSRItemLoteSerie As New rptSRItemLoteSerie

      Try

         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.Report
            .WhereFilter = clsItemLote.WhereFilters.NotaItemId
            .OrderByFilter = clsItemLote.OrderByFilters.ItemLoteId
            .EmpresaId = clsAppInfo.EmpresaId
            .ItemId = lngItemId
            .NotaId = lngNotaId

            If .Open() Then
               If boolLote And (.DataSet.Tables(.TableName).Rows.Count > 0) Then
                  If boolSerie Then
                     For Each oRow In .DataSet.Tables(.TableName).Rows
                        oRow("ItemNroSerieLote") = NroSeriesEntFind(lngItemId, oRow("ItemLoteId"), lngNotaId)
                     Next
                  End If
                  CargarLotesSeriesEnt = True
               Else
                  rpSRItemLoteSerie.Detail.Visible = False
               End If

               If boolSerie And (Not CargarLotesSeriesEnt) Then
                  strSeries = NroSeriesEntFind(lngItemId, 0, lngNotaId)
                  CargarLotesSeriesEnt = True
               Else
                  rpSRItemLoteSerie.GroupFooter.Visible = False
               End If

               If CargarLotesSeriesEnt Then
                  rpSRItemLoteSerie.DataSource = .DataSet.Tables(.TableName).DefaultView
                  rpSRItemLoteSerie.txtSeries.Text = strSeries
                  Me.srptLotesSeries.Report = rpSRItemLoteSerie
                  CargarLotesSeriesEnt = True
               End If

            End If
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oItemLote.Dispose()
      End Try
   End Function

   Private Function NroSeriesEntFind(ByVal lngItemId As Long, ByVal lngItemLoteId As Long, ByVal lngNotaId As Long) As String
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oRow As DataRowView
      Dim strNroSeriesDes As String = String.Empty
      NroSeriesEntFind = ""

      Try
         With oItemNroSerie
            .SelectFilter = clsItemNroSerie.SelectFilters.All
            .WhereFilter = clsItemNroSerie.WhereFilters.NotaItemIdEnt
            .OrderByFilter = clsItemNroSerie.OrderByFilters.ItemNroSerieId
            .EmpresaId = clsAppInfo.EmpresaId
            .NotaIdEnt = lngNotaId
            .ItemId = lngItemId
            .ItemLoteId = lngItemLoteId

            If .Open Then
               For Each oRow In .DataSet.Tables(.TableName).DefaultView
                  strNroSeriesDes &= "- " & ToStr(oRow("ItemNroSerieCod")) & " "
               Next
            End If

            NroSeriesEntFind = strNroSeriesDes
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemNroSerie.Dispose()

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

   Private Function getNroPedidosFind(ByVal lngCompraId As Long) As String
      Dim oCompraPedido As New clsCompraPedidoDet(clsAppInfo.ConnectString)
      Dim oRow As DataRowView
      Dim strNros As String = String.Empty
      getNroPedidosFind = ""

      Try
         With oCompraPedido
            .SelectFilter = clsCompraPedidoDet.SelectFilters.NRO_PEDIDO_CompraId
            .WhereFilter = clsCompraPedidoDet.WhereFilters.NRO_PEDIDO_CompraId
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .CompraId = lngCompraId

            If .Open Then
               For Each oRow In .DataSet.Tables(.TableName).DefaultView
                  strNros &= "," & ToStr(oRow("PedCompraNro")) & ""
               Next
            End If

            getNroPedidosFind = strNros.Substring(strNros.IndexOf(",") + 1)

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPedido.Dispose()

      End Try
   End Function

End Class