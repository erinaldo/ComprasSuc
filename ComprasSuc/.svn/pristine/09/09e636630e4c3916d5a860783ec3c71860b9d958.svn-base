Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptAjuste 
    Inherits DataDynamics.ActiveReports.ActiveReport3

   Private decCapitalBs As Decimal = 0
   Private decCapitalUs As Decimal = 0
   Private decInteresBs As Decimal = 0
   Private decInteresUs As Decimal = 0
   Private decMontoPagBs As Decimal = 0
   Private decMontoPagUs As Decimal = 0

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
   Public lblCompany As DataDynamics.ActiveReports.Label = Nothing
   Public lblTitle As DataDynamics.ActiveReports.Label = Nothing
   Private Line1 As DataDynamics.ActiveReports.Line = Nothing
   Private Label5 As DataDynamics.ActiveReports.Label = Nothing
   Private Label10 As DataDynamics.ActiveReports.Label = Nothing
   Private Label11 As DataDynamics.ActiveReports.Label = Nothing
   Private Label15 As DataDynamics.ActiveReports.Label = Nothing
   Private Label As DataDynamics.ActiveReports.Label = Nothing
   Private Label8 As DataDynamics.ActiveReports.Label = Nothing
   Private Label2 As DataDynamics.ActiveReports.Label = Nothing
   Private Label6 As DataDynamics.ActiveReports.Label = Nothing
   Private Label1 As DataDynamics.ActiveReports.Label = Nothing
   Private Label4 As DataDynamics.ActiveReports.Label = Nothing
   Private txtPagoNro As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtFecha As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtProveedorDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtCapital As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtInteres As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoPag As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPagoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtTipoCompDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtCompNro As DataDynamics.ActiveReports.TextBox = Nothing
   Private Line As DataDynamics.ActiveReports.Line = Nothing
   Private txtCapitalBs As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtInteresBs As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoPagBs As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtCapitalUs As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtInteresUs As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoPagUs As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtBoliviano As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtDolar As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageCount As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox = Nothing
   Private Label3 As DataDynamics.ActiveReports.Label = Nothing
   Private Line2 As DataDynamics.ActiveReports.Line = Nothing
   Public lblDate As DataDynamics.ActiveReports.Label = Nothing
   Public lblTime As DataDynamics.ActiveReports.Label = Nothing
   Public lblLogin As DataDynamics.ActiveReports.Label = Nothing

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptAjuste))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtPagoNro = New DataDynamics.ActiveReports.TextBox
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtProveedorDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCapital = New DataDynamics.ActiveReports.TextBox
      Me.txtInteres = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoPag = New DataDynamics.ActiveReports.TextBox
      Me.txtPagoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtTipoCompDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCompNro = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.Line = New DataDynamics.ActiveReports.Line
      Me.txtCapitalBs = New DataDynamics.ActiveReports.TextBox
      Me.txtInteresBs = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoPagBs = New DataDynamics.ActiveReports.TextBox
      Me.txtCapitalUs = New DataDynamics.ActiveReports.TextBox
      Me.txtInteresUs = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoPagUs = New DataDynamics.ActiveReports.TextBox
      Me.txtBoliviano = New DataDynamics.ActiveReports.TextBox
      Me.txtDolar = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtPagoNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtProveedorDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCapital, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtInteres, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoPag, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPagoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTipoCompDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCapitalBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtInteresBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoPagBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCapitalUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtInteresUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoPagUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtBoliviano, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDolar, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPagoNro, Me.txtFecha, Me.txtProveedorDes, Me.txtMonedaDes, Me.txtCapital, Me.txtInteres, Me.txtMontoPag, Me.txtPagoDes, Me.txtTipoCompDes, Me.txtCompNro})
      Me.Detail.Height = 0.1875!
      Me.Detail.Name = "Detail"
      '
      'txtPagoNro
      '
      Me.txtPagoNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPagoNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPagoNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPagoNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPagoNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtPagoNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPagoNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtPagoNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPagoNro.DataField = "AjusteNro"
      Me.txtPagoNro.Height = 0.1875!
      Me.txtPagoNro.Left = 0.0!
      Me.txtPagoNro.Name = "txtPagoNro"
      Me.txtPagoNro.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPagoNro.Text = "PagoNro"
      Me.txtPagoNro.Top = 0.0!
      Me.txtPagoNro.Width = 0.5!
      '
      'txtFecha
      '
      Me.txtFecha.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFecha.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFecha.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.RightColor = System.Drawing.Color.Black
      Me.txtFecha.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.TopColor = System.Drawing.Color.Black
      Me.txtFecha.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.DataField = "Fecha"
      Me.txtFecha.Height = 0.1875!
      Me.txtFecha.Left = 0.5!
      Me.txtFecha.Name = "txtFecha"
      Me.txtFecha.OutputFormat = resources.GetString("txtFecha.OutputFormat")
      Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtFecha.Text = "Fecha"
      Me.txtFecha.Top = 0.0!
      Me.txtFecha.Width = 0.625!
      '
      'txtProveedorDes
      '
      Me.txtProveedorDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtProveedorDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtProveedorDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtProveedorDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtProveedorDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorDes.DataField = "ProveedorDes"
      Me.txtProveedorDes.Height = 0.1875!
      Me.txtProveedorDes.Left = 1.125!
      Me.txtProveedorDes.Name = "txtProveedorDes"
      Me.txtProveedorDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtProveedorDes.Text = "ProveedorDes"
      Me.txtProveedorDes.Top = 0.0!
      Me.txtProveedorDes.Width = 1.3125!
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
      Me.txtMonedaDes.Left = 3.8125!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 0.0!
      Me.txtMonedaDes.Width = 0.5625!
      '
      'txtCapital
      '
      Me.txtCapital.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCapital.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapital.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCapital.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapital.Border.RightColor = System.Drawing.Color.Black
      Me.txtCapital.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapital.Border.TopColor = System.Drawing.Color.Black
      Me.txtCapital.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapital.DataField = "Capital"
      Me.txtCapital.Height = 0.1875!
      Me.txtCapital.Left = 4.375!
      Me.txtCapital.Name = "txtCapital"
      Me.txtCapital.OutputFormat = resources.GetString("txtCapital.OutputFormat")
      Me.txtCapital.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCapital.Text = "Capital"
      Me.txtCapital.Top = 0.0!
      Me.txtCapital.Width = 0.625!
      '
      'txtInteres
      '
      Me.txtInteres.Border.BottomColor = System.Drawing.Color.Black
      Me.txtInteres.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteres.Border.LeftColor = System.Drawing.Color.Black
      Me.txtInteres.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteres.Border.RightColor = System.Drawing.Color.Black
      Me.txtInteres.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteres.Border.TopColor = System.Drawing.Color.Black
      Me.txtInteres.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteres.DataField = "Interes"
      Me.txtInteres.Height = 0.1875!
      Me.txtInteres.Left = 5.0!
      Me.txtInteres.Name = "txtInteres"
      Me.txtInteres.OutputFormat = resources.GetString("txtInteres.OutputFormat")
      Me.txtInteres.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtInteres.Text = "Interes"
      Me.txtInteres.Top = 0.0!
      Me.txtInteres.Width = 0.625!
      '
      'txtMontoPag
      '
      Me.txtMontoPag.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoPag.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPag.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoPag.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPag.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoPag.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPag.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoPag.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPag.DataField = "MontoPag"
      Me.txtMontoPag.Height = 0.1875!
      Me.txtMontoPag.Left = 5.625!
      Me.txtMontoPag.Name = "txtMontoPag"
      Me.txtMontoPag.OutputFormat = resources.GetString("txtMontoPag.OutputFormat")
      Me.txtMontoPag.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoPag.Text = "MontoPag"
      Me.txtMontoPag.Top = 0.0!
      Me.txtMontoPag.Width = 0.625!
      '
      'txtPagoDes
      '
      Me.txtPagoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPagoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPagoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPagoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPagoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPagoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPagoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPagoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPagoDes.DataField = "AjusteDes"
      Me.txtPagoDes.Height = 0.1875!
      Me.txtPagoDes.Left = 2.4375!
      Me.txtPagoDes.Name = "txtPagoDes"
      Me.txtPagoDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPagoDes.Text = "PagoDes"
      Me.txtPagoDes.Top = 0.0!
      Me.txtPagoDes.Width = 1.375!
      '
      'txtTipoCompDes
      '
      Me.txtTipoCompDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTipoCompDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCompDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTipoCompDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCompDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtTipoCompDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCompDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtTipoCompDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCompDes.DataField = "TipoCompDes"
      Me.txtTipoCompDes.Height = 0.1875!
      Me.txtTipoCompDes.Left = 6.25!
      Me.txtTipoCompDes.Name = "txtTipoCompDes"
      Me.txtTipoCompDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtTipoCompDes.Text = "TipoCompDes"
      Me.txtTipoCompDes.Top = 0.0!
      Me.txtTipoCompDes.Width = 0.625!
      '
      'txtCompNro
      '
      Me.txtCompNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.DataField = "CompNro"
      Me.txtCompNro.Height = 0.1875!
      Me.txtCompNro.Left = 6.875!
      Me.txtCompNro.Name = "txtCompNro"
      Me.txtCompNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtCompNro.Text = "CompNro"
      Me.txtCompNro.Top = 0.0!
      Me.txtCompNro.Width = 0.625!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1})
      Me.ReportHeader.Height = 0.7395833!
      Me.ReportHeader.Name = "ReportHeader"
      '
      'lblCompany
      '
      Me.lblCompany.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCompany.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickDouble
      Me.lblCompany.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCompany.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompany.Border.RightColor = System.Drawing.Color.Black
      Me.lblCompany.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompany.Border.TopColor = System.Drawing.Color.Black
      Me.lblCompany.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.lblCompany.Height = 0.25!
      Me.lblCompany.HyperLink = Nothing
      Me.lblCompany.Left = 0.0625!
      Me.lblCompany.Name = "lblCompany"
      Me.lblCompany.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 8pt; vertical-" & _
          "align: top; "
      Me.lblCompany.Text = ""
      Me.lblCompany.Top = 0.0!
      Me.lblCompany.Width = 7.375!
      '
      'lblTitle
      '
      Me.lblTitle.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblTitle.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.lblTitle.Border.RightColor = System.Drawing.Color.Black
      Me.lblTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.lblTitle.Border.TopColor = System.Drawing.Color.Black
      Me.lblTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.lblTitle.Height = 0.25!
      Me.lblTitle.HyperLink = Nothing
      Me.lblTitle.Left = 0.0!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "text-align: center; font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.3125!
      Me.lblTitle.Width = 7.5!
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
      Me.Line1.Left = 0.0625!
      Me.Line1.LineWeight = 5.0!
      Me.Line1.Name = "Line1"
      Me.Line1.Top = 0.625!
      Me.Line1.Width = 7.4375!
      Me.Line1.X1 = 0.0625!
      Me.Line1.X2 = 7.5!
      Me.Line1.Y1 = 0.625!
      Me.Line1.Y2 = 0.625!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label5, Me.Label10, Me.Label11, Me.Label15, Me.Label, Me.Label8, Me.Label2, Me.Label6, Me.Label1, Me.Label4})
      Me.PageHeader.Height = 0.2291667!
      Me.PageHeader.Name = "PageHeader"
      '
      'Label5
      '
      Me.Label5.Border.BottomColor = System.Drawing.Color.Black
      Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.LeftColor = System.Drawing.Color.Black
      Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.RightColor = System.Drawing.Color.Black
      Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.TopColor = System.Drawing.Color.Black
      Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Height = 0.1875!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 0.0!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label5.Text = "Número"
      Me.Label5.Top = 0.0!
      Me.Label5.Width = 0.5!
      '
      'Label10
      '
      Me.Label10.Border.BottomColor = System.Drawing.Color.Black
      Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Border.LeftColor = System.Drawing.Color.Black
      Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.RightColor = System.Drawing.Color.Black
      Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.TopColor = System.Drawing.Color.Black
      Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 3.8125!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Moneda"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 0.5625!
      '
      'Label11
      '
      Me.Label11.Border.BottomColor = System.Drawing.Color.Black
      Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Border.LeftColor = System.Drawing.Color.Black
      Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.RightColor = System.Drawing.Color.Black
      Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.TopColor = System.Drawing.Color.Black
      Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Height = 0.1875!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 4.375!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label11.Text = "Capital"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.625!
      '
      'Label15
      '
      Me.Label15.Border.BottomColor = System.Drawing.Color.Black
      Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label15.Border.LeftColor = System.Drawing.Color.Black
      Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.RightColor = System.Drawing.Color.Black
      Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.TopColor = System.Drawing.Color.Black
      Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label15.Height = 0.1875!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 1.125!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label15.Text = "Proveedor"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 1.3125!
      '
      'Label
      '
      Me.Label.Border.BottomColor = System.Drawing.Color.Black
      Me.Label.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label.Border.LeftColor = System.Drawing.Color.Black
      Me.Label.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.RightColor = System.Drawing.Color.Black
      Me.Label.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.TopColor = System.Drawing.Color.Black
      Me.Label.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label.Height = 0.1875!
      Me.Label.HyperLink = Nothing
      Me.Label.Left = 5.0!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label.Text = "Interés"
      Me.Label.Top = 0.0!
      Me.Label.Width = 0.625!
      '
      'Label8
      '
      Me.Label8.Border.BottomColor = System.Drawing.Color.Black
      Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.LeftColor = System.Drawing.Color.Black
      Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.RightColor = System.Drawing.Color.Black
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Height = 0.1875!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 0.5!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label8.Text = "Fecha"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 0.625!
      '
      'Label2
      '
      Me.Label2.Border.BottomColor = System.Drawing.Color.Black
      Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Border.LeftColor = System.Drawing.Color.Black
      Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.RightColor = System.Drawing.Color.Black
      Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.TopColor = System.Drawing.Color.Black
      Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Height = 0.1875!
      Me.Label2.HyperLink = Nothing
      Me.Label2.Left = 5.625!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Mto Pag."
      Me.Label2.Top = 0.0!
      Me.Label2.Width = 0.625!
      '
      'Label6
      '
      Me.Label6.Border.BottomColor = System.Drawing.Color.Black
      Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.LeftColor = System.Drawing.Color.Black
      Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.RightColor = System.Drawing.Color.Black
      Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.TopColor = System.Drawing.Color.Black
      Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Height = 0.1875!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 2.4375!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Descripción"
      Me.Label6.Top = 0.0!
      Me.Label6.Width = 1.375!
      '
      'Label1
      '
      Me.Label1.Border.BottomColor = System.Drawing.Color.Black
      Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Border.LeftColor = System.Drawing.Color.Black
      Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.RightColor = System.Drawing.Color.Black
      Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.TopColor = System.Drawing.Color.Black
      Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Height = 0.1875!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 6.25!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label1.Text = "Tipo Comp"
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 0.625!
      '
      'Label4
      '
      Me.Label4.Border.BottomColor = System.Drawing.Color.Black
      Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.LeftColor = System.Drawing.Color.Black
      Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.RightColor = System.Drawing.Color.Black
      Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.TopColor = System.Drawing.Color.Black
      Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Height = 0.1875!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 6.875!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label4.Text = "Nro. Comp"
      Me.Label4.Top = 0.0!
      Me.Label4.Width = 0.625!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3645833!
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
      Me.txtPageCount.Top = 0.1666667!
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
      Me.txtPageNOfM.Top = 0.1666667!
      Me.txtPageNOfM.Width = 0.375!
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
      Me.Label3.Height = 0.2!
      Me.Label3.HyperLink = Nothing
      Me.Label3.Left = 6885.411!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.Label3.Text = "de"
      Me.Label3.Top = 0.1666667!
      Me.Label3.Width = 0.1875!
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
      Me.Line2.Top = 0.125!
      Me.Line2.Width = 7.5!
      Me.Line2.X1 = 0.02083333!
      Me.Line2.X2 = 7.520833!
      Me.Line2.Y1 = 0.125!
      Me.Line2.Y2 = 0.125!
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
      Me.lblDate.Top = 0.1666667!
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
      Me.lblTime.Top = 0.1666667!
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
      Me.lblLogin.Top = 0.1666667!
      Me.lblLogin.Width = 2.0!
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Height = 0.0!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line, Me.txtCapitalBs, Me.txtInteresBs, Me.txtMontoPagBs, Me.txtCapitalUs, Me.txtInteresUs, Me.txtMontoPagUs, Me.txtBoliviano, Me.txtDolar})
      Me.GroupFooter1.Height = 0.3847222!
      Me.GroupFooter1.Name = "GroupFooter1"
      '
      'Line
      '
      Me.Line.Border.BottomColor = System.Drawing.Color.Black
      Me.Line.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line.Border.LeftColor = System.Drawing.Color.Black
      Me.Line.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line.Border.RightColor = System.Drawing.Color.Black
      Me.Line.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line.Border.TopColor = System.Drawing.Color.Black
      Me.Line.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line.Height = 0.0!
      Me.Line.Left = 3.8125!
      Me.Line.LineWeight = 1.0!
      Me.Line.Name = "Line"
      Me.Line.Top = 0.0!
      Me.Line.Width = 2.4375!
      Me.Line.X1 = 3.8125!
      Me.Line.X2 = 6.25!
      Me.Line.Y1 = 0.0!
      Me.Line.Y2 = 0.0!
      '
      'txtCapitalBs
      '
      Me.txtCapitalBs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCapitalBs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalBs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCapitalBs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalBs.Border.RightColor = System.Drawing.Color.Black
      Me.txtCapitalBs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalBs.Border.TopColor = System.Drawing.Color.Black
      Me.txtCapitalBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalBs.Height = 0.1875!
      Me.txtCapitalBs.Left = 4.375!
      Me.txtCapitalBs.Name = "txtCapitalBs"
      Me.txtCapitalBs.OutputFormat = resources.GetString("txtCapitalBs.OutputFormat")
      Me.txtCapitalBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCapitalBs.Text = "Capital"
      Me.txtCapitalBs.Top = 0.0!
      Me.txtCapitalBs.Width = 0.625!
      '
      'txtInteresBs
      '
      Me.txtInteresBs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtInteresBs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresBs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtInteresBs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresBs.Border.RightColor = System.Drawing.Color.Black
      Me.txtInteresBs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresBs.Border.TopColor = System.Drawing.Color.Black
      Me.txtInteresBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresBs.Height = 0.1875!
      Me.txtInteresBs.Left = 5.0!
      Me.txtInteresBs.Name = "txtInteresBs"
      Me.txtInteresBs.OutputFormat = resources.GetString("txtInteresBs.OutputFormat")
      Me.txtInteresBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtInteresBs.Text = "Interes"
      Me.txtInteresBs.Top = 0.0!
      Me.txtInteresBs.Width = 0.625!
      '
      'txtMontoPagBs
      '
      Me.txtMontoPagBs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoPagBs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPagBs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoPagBs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPagBs.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoPagBs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPagBs.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoPagBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPagBs.Height = 0.1875!
      Me.txtMontoPagBs.Left = 5.625!
      Me.txtMontoPagBs.Name = "txtMontoPagBs"
      Me.txtMontoPagBs.OutputFormat = resources.GetString("txtMontoPagBs.OutputFormat")
      Me.txtMontoPagBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoPagBs.Text = "MontoPag"
      Me.txtMontoPagBs.Top = 0.0!
      Me.txtMontoPagBs.Width = 0.625!
      '
      'txtCapitalUs
      '
      Me.txtCapitalUs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCapitalUs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalUs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCapitalUs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalUs.Border.RightColor = System.Drawing.Color.Black
      Me.txtCapitalUs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalUs.Border.TopColor = System.Drawing.Color.Black
      Me.txtCapitalUs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalUs.Height = 0.1875!
      Me.txtCapitalUs.Left = 4.375!
      Me.txtCapitalUs.Name = "txtCapitalUs"
      Me.txtCapitalUs.OutputFormat = resources.GetString("txtCapitalUs.OutputFormat")
      Me.txtCapitalUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCapitalUs.Text = "Capital"
      Me.txtCapitalUs.Top = 0.1875!
      Me.txtCapitalUs.Width = 0.625!
      '
      'txtInteresUs
      '
      Me.txtInteresUs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtInteresUs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresUs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtInteresUs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresUs.Border.RightColor = System.Drawing.Color.Black
      Me.txtInteresUs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresUs.Border.TopColor = System.Drawing.Color.Black
      Me.txtInteresUs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresUs.Height = 0.1875!
      Me.txtInteresUs.Left = 5.0!
      Me.txtInteresUs.Name = "txtInteresUs"
      Me.txtInteresUs.OutputFormat = resources.GetString("txtInteresUs.OutputFormat")
      Me.txtInteresUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtInteresUs.Text = "Interes"
      Me.txtInteresUs.Top = 0.1875!
      Me.txtInteresUs.Width = 0.625!
      '
      'txtMontoPagUs
      '
      Me.txtMontoPagUs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoPagUs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPagUs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoPagUs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPagUs.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoPagUs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPagUs.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoPagUs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoPagUs.Height = 0.1875!
      Me.txtMontoPagUs.Left = 5.625!
      Me.txtMontoPagUs.Name = "txtMontoPagUs"
      Me.txtMontoPagUs.OutputFormat = resources.GetString("txtMontoPagUs.OutputFormat")
      Me.txtMontoPagUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoPagUs.Text = "MontoPag"
      Me.txtMontoPagUs.Top = 0.1875!
      Me.txtMontoPagUs.Width = 0.625!
      '
      'txtBoliviano
      '
      Me.txtBoliviano.Border.BottomColor = System.Drawing.Color.Black
      Me.txtBoliviano.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBoliviano.Border.LeftColor = System.Drawing.Color.Black
      Me.txtBoliviano.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBoliviano.Border.RightColor = System.Drawing.Color.Black
      Me.txtBoliviano.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBoliviano.Border.TopColor = System.Drawing.Color.Black
      Me.txtBoliviano.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBoliviano.Height = 0.1875!
      Me.txtBoliviano.Left = 3.8125!
      Me.txtBoliviano.Name = "txtBoliviano"
      Me.txtBoliviano.OutputFormat = resources.GetString("txtBoliviano.OutputFormat")
      Me.txtBoliviano.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
      Me.txtBoliviano.Text = Nothing
      Me.txtBoliviano.Top = 0.0!
      Me.txtBoliviano.Width = 0.5625!
      '
      'txtDolar
      '
      Me.txtDolar.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDolar.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDolar.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDolar.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDolar.Border.RightColor = System.Drawing.Color.Black
      Me.txtDolar.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDolar.Border.TopColor = System.Drawing.Color.Black
      Me.txtDolar.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDolar.Height = 0.1875!
      Me.txtDolar.Left = 3.8125!
      Me.txtDolar.Name = "txtDolar"
      Me.txtDolar.OutputFormat = resources.GetString("txtDolar.OutputFormat")
      Me.txtDolar.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
      Me.txtDolar.Text = Nothing
      Me.txtDolar.Top = 0.1875!
      Me.txtDolar.Width = 0.5625!
      '
      'rptAjuste
      '
      Me.MasterReport = False
      OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
          "Catalog=DelfinNet;Data Source=DESARROLLO"
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
      CType(Me.txtPagoNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtProveedorDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCapital, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtInteres, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoPag, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPagoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTipoCompDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCompNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCapitalBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtInteresBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoPagBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCapitalUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtInteresUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoPagUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtBoliviano, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDolar, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
      If Me.Fields("MonedaId").Value = 1 Then
         decCapitalBs += ToDecimal(Me.Fields("Capital").Value)
         decInteresBs += ToDecimal(Me.Fields("Interes").Value)
         decMontoPagBs += ToDecimal(Me.Fields("MontoPag").Value)
      Else
         decCapitalUs += ToDecimal(Me.Fields("Capital").Value)
         decInteresUs += ToDecimal(Me.Fields("Interes").Value)
         decMontoPagUs += ToDecimal(Me.Fields("MontoPag").Value)
      End If
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      txtBoliviano.Text = MonedaDesFind(1)
      txtDolar.Text = MonedaDesFind(2)

      txtCapitalBs.Text = ToDecStrDos(decCapitalBs)
      txtInteresBs.Text = ToDecStrDos(decInteresBs)
      txtMontoPagBs.Text = ToDecStrDos(decMontoPagBs)

      txtCapitalUs.Text = ToDecStrDos(decCapitalUs)
      txtInteresUs.Text = ToDecStrDos(decInteresUs)
      txtMontoPagUs.Text = ToDecStrDos(decMontoPagUs)
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

      End Try
   End Function

End Class