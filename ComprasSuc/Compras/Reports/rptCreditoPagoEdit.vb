Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptCreditoPagoEdit 
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
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Line1 As DataDynamics.ActiveReports.Line
   Private Label10 As DataDynamics.ActiveReports.Label
   Public txtFechaPago As DataDynamics.ActiveReports.TextBox
   Private Label5 As DataDynamics.ActiveReports.Label
   Private Label7 As DataDynamics.ActiveReports.Label
   Private Label8 As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label1 As DataDynamics.ActiveReports.Label
   Private Label6 As DataDynamics.ActiveReports.Label
   Private Label As DataDynamics.ActiveReports.Label
   Private Label4 As DataDynamics.ActiveReports.Label
   Private Label13 As DataDynamics.ActiveReports.Label
   Private Label2 As DataDynamics.ActiveReports.Label
   Private Label9 As DataDynamics.ActiveReports.Label
   Private txtCompraNro As DataDynamics.ActiveReports.TextBox
   Private txtFecha As DataDynamics.ActiveReports.TextBox
   Private txtCreditoNro As DataDynamics.ActiveReports.TextBox
   Private txtCuotaNro As DataDynamics.ActiveReports.TextBox
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox
   Private txtCapital As DataDynamics.ActiveReports.TextBox
   Private txtInteres As DataDynamics.ActiveReports.TextBox
   Private txtImporte As DataDynamics.ActiveReports.TextBox
   Private TextBox As DataDynamics.ActiveReports.TextBox
   Private TextBox1 As DataDynamics.ActiveReports.TextBox
   Private txtAmortiza As DataDynamics.ActiveReports.TextBox
   Public txtCapitalBs As DataDynamics.ActiveReports.TextBox
   Public txtInteresBs As DataDynamics.ActiveReports.TextBox
   Public txtImporteBs As DataDynamics.ActiveReports.TextBox
   Public txtCapitalUs As DataDynamics.ActiveReports.TextBox
   Public txtInteresUs As DataDynamics.ActiveReports.TextBox
   Public txtImporteUs As DataDynamics.ActiveReports.TextBox
   Private TextBox4 As DataDynamics.ActiveReports.TextBox
   Private TextBox2 As DataDynamics.ActiveReports.TextBox
   Public txtMontoPagBs As DataDynamics.ActiveReports.TextBox
   Public txtMontoPagUs As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCreditoPagoEdit))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtCompraNro = New DataDynamics.ActiveReports.TextBox
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtCreditoNro = New DataDynamics.ActiveReports.TextBox
      Me.txtCuotaNro = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCapital = New DataDynamics.ActiveReports.TextBox
      Me.txtInteres = New DataDynamics.ActiveReports.TextBox
      Me.txtImporte = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.txtAmortiza = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.txtFechaPago = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
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
      Me.txtCapitalBs = New DataDynamics.ActiveReports.TextBox
      Me.txtInteresBs = New DataDynamics.ActiveReports.TextBox
      Me.txtImporteBs = New DataDynamics.ActiveReports.TextBox
      Me.txtCapitalUs = New DataDynamics.ActiveReports.TextBox
      Me.txtInteresUs = New DataDynamics.ActiveReports.TextBox
      Me.txtImporteUs = New DataDynamics.ActiveReports.TextBox
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoPagBs = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoPagUs = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtCompraNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCreditoNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCuotaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCapital, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtInteres, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtAmortiza, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaPago, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCapitalBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtInteresBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporteBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCapitalUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtInteresUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporteUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoPagBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoPagUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCompraNro, Me.txtFecha, Me.txtCreditoNro, Me.txtCuotaNro, Me.txtMonedaDes, Me.txtCapital, Me.txtInteres, Me.txtImporte, Me.TextBox, Me.TextBox1, Me.txtAmortiza})
      Me.Detail.Height = 0.1763889!
      Me.Detail.Name = "Detail"
      '
      'txtCompraNro
      '
      Me.txtCompraNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompraNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompraNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompraNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompraNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraNro.DataField = "CompraNro"
      Me.txtCompraNro.Height = 0.1875!
      Me.txtCompraNro.Left = 0.0!
      Me.txtCompraNro.Name = "txtCompraNro"
      Me.txtCompraNro.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCompraNro.Text = "CompraNro"
      Me.txtCompraNro.Top = 0.0!
      Me.txtCompraNro.Width = 0.625!
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
      Me.txtFecha.Left = 3.3125!
      Me.txtFecha.Name = "txtFecha"
      Me.txtFecha.OutputFormat = resources.GetString("txtFecha.OutputFormat")
      Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtFecha.Text = "Fecha"
      Me.txtFecha.Top = 0.0!
      Me.txtFecha.Width = 0.75!
      '
      'txtCreditoNro
      '
      Me.txtCreditoNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCreditoNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCreditoNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCreditoNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCreditoNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtCreditoNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCreditoNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtCreditoNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCreditoNro.DataField = "CreditoNro"
      Me.txtCreditoNro.Height = 0.1875!
      Me.txtCreditoNro.Left = 2.0625!
      Me.txtCreditoNro.Name = "txtCreditoNro"
      Me.txtCreditoNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtCreditoNro.Text = "CreditoNro"
      Me.txtCreditoNro.Top = 0.0!
      Me.txtCreditoNro.Width = 0.625!
      '
      'txtCuotaNro
      '
      Me.txtCuotaNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCuotaNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCuotaNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCuotaNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCuotaNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtCuotaNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCuotaNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtCuotaNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCuotaNro.DataField = "CuotaNro"
      Me.txtCuotaNro.Height = 0.1875!
      Me.txtCuotaNro.Left = 2.6875!
      Me.txtCuotaNro.Name = "txtCuotaNro"
      Me.txtCuotaNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtCuotaNro.Text = "CuotaNro"
      Me.txtCuotaNro.Top = 0.0!
      Me.txtCuotaNro.Width = 0.625!
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
      Me.txtMonedaDes.Left = 4.0625!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 0.0!
      Me.txtMonedaDes.Width = 0.6875!
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
      Me.txtCapital.Left = 4.75!
      Me.txtCapital.Name = "txtCapital"
      Me.txtCapital.OutputFormat = resources.GetString("txtCapital.OutputFormat")
      Me.txtCapital.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCapital.Text = "Capital"
      Me.txtCapital.Top = 0.0!
      Me.txtCapital.Width = 0.6875!
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
      Me.txtInteres.Left = 5.4375!
      Me.txtInteres.Name = "txtInteres"
      Me.txtInteres.OutputFormat = resources.GetString("txtInteres.OutputFormat")
      Me.txtInteres.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtInteres.Text = "Interes"
      Me.txtInteres.Top = 0.0!
      Me.txtInteres.Width = 0.6875!
      '
      'txtImporte
      '
      Me.txtImporte.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporte.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporte.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporte.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporte.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporte.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporte.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporte.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporte.DataField = "Importe"
      Me.txtImporte.Height = 0.1875!
      Me.txtImporte.Left = 6.125!
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.OutputFormat = resources.GetString("txtImporte.OutputFormat")
      Me.txtImporte.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtImporte.Text = "Importe"
      Me.txtImporte.Top = 0.0!
      Me.txtImporte.Width = 0.6875!
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
      Me.TextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.DataField = "CompraOrden"
      Me.TextBox.Height = 0.1875!
      Me.TextBox.Left = 0.625!
      Me.TextBox.Name = "TextBox"
      Me.TextBox.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
      Me.TextBox.Text = "CompraOrden"
      Me.TextBox.Top = 0.0!
      Me.TextBox.Width = 0.625!
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
      Me.TextBox1.DataField = "AlmacenDes"
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 1.25!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox1.Text = "AlmacenDes"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 0.8125!
      '
      'txtAmortiza
      '
      Me.txtAmortiza.Border.BottomColor = System.Drawing.Color.Black
      Me.txtAmortiza.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAmortiza.Border.LeftColor = System.Drawing.Color.Black
      Me.txtAmortiza.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAmortiza.Border.RightColor = System.Drawing.Color.Black
      Me.txtAmortiza.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAmortiza.Border.TopColor = System.Drawing.Color.Black
      Me.txtAmortiza.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAmortiza.DataField = "Amortiza"
      Me.txtAmortiza.Height = 0.1875!
      Me.txtAmortiza.Left = 6.8125!
      Me.txtAmortiza.Name = "txtAmortiza"
      Me.txtAmortiza.OutputFormat = resources.GetString("txtAmortiza.OutputFormat")
      Me.txtAmortiza.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtAmortiza.Text = "Amortiza"
      Me.txtAmortiza.Top = 0.0!
      Me.txtAmortiza.Width = 0.6875!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label10, Me.txtFechaPago})
      Me.ReportHeader.Height = 1.0625!
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
      'Label10
      '
      Me.Label10.Border.BottomColor = System.Drawing.Color.Black
      Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Border.LeftColor = System.Drawing.Color.Black
      Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Border.RightColor = System.Drawing.Color.Black
      Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.TopColor = System.Drawing.Color.Black
      Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 6.125!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Fecha"
      Me.Label10.Top = 0.75!
      Me.Label10.Width = 0.75!
      '
      'txtFechaPago
      '
      Me.txtFechaPago.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaPago.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaPago.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaPago.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaPago.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaPago.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaPago.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaPago.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaPago.Height = 0.1875!
      Me.txtFechaPago.Left = 6.875!
      Me.txtFechaPago.Name = "txtFechaPago"
      Me.txtFechaPago.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaPago.Text = Nothing
      Me.txtFechaPago.Top = 0.75!
      Me.txtFechaPago.Width = 0.625!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label5, Me.Label7, Me.Label8, Me.Label11, Me.Label1, Me.Label6, Me.Label, Me.Label4, Me.Label13, Me.Label2, Me.Label9})
      Me.PageHeader.Height = 0.2388889!
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
      Me.Label5.Text = "Compra"
      Me.Label5.Top = 0.0!
      Me.Label5.Width = 0.625!
      '
      'Label7
      '
      Me.Label7.Border.BottomColor = System.Drawing.Color.Black
      Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.LeftColor = System.Drawing.Color.Black
      Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.RightColor = System.Drawing.Color.Black
      Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.TopColor = System.Drawing.Color.Black
      Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Height = 0.1875!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 0.625!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
          "ont-size: 8pt; vertical-align: middle; "
      Me.Label7.Text = "Nro Orden"
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 0.625!
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
      Me.Label8.Left = 1.25!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label8.Text = "Almacén"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 0.8125!
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
      Me.Label11.Left = 2.0625!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label11.Text = "Crédito"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.625!
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
      Me.Label1.Left = 2.6875!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label1.Text = "Cuota"
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 0.625!
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
      Me.Label6.Left = 3.3125!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Fecha"
      Me.Label6.Top = 0.0!
      Me.Label6.Width = 0.75!
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
      Me.Label.Left = 4.0625!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label.Text = "Moneda"
      Me.Label.Top = 0.0!
      Me.Label.Width = 0.6875!
      '
      'Label4
      '
      Me.Label4.Border.BottomColor = System.Drawing.Color.Black
      Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.LeftColor = System.Drawing.Color.Black
      Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.RightColor = System.Drawing.Color.Black
      Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.TopColor = System.Drawing.Color.Black
      Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Height = 0.1875!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 4.75!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label4.Text = "Capital"
      Me.Label4.Top = 0.0!
      Me.Label4.Width = 0.6875!
      '
      'Label13
      '
      Me.Label13.Border.BottomColor = System.Drawing.Color.Black
      Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Border.LeftColor = System.Drawing.Color.Black
      Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.RightColor = System.Drawing.Color.Black
      Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.TopColor = System.Drawing.Color.Black
      Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Height = 0.1875!
      Me.Label13.HyperLink = Nothing
      Me.Label13.Left = 5.4375!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label13.Text = "Interés"
      Me.Label13.Top = 0.0!
      Me.Label13.Width = 0.6875!
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
      Me.Label2.Left = 6.125!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Importe"
      Me.Label2.Top = 0.0!
      Me.Label2.Width = 0.6875!
      '
      'Label9
      '
      Me.Label9.Border.BottomColor = System.Drawing.Color.Black
      Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.LeftColor = System.Drawing.Color.Black
      Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.RightColor = System.Drawing.Color.Black
      Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.TopColor = System.Drawing.Color.Black
      Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Height = 0.1875!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 6.8125!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label9.Text = "Amortizar"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.6875!
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
      Me.Label3.Left = 6.885411!
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
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCapitalBs, Me.txtInteresBs, Me.txtImporteBs, Me.txtCapitalUs, Me.txtInteresUs, Me.txtImporteUs, Me.TextBox4, Me.TextBox2, Me.txtMontoPagBs, Me.txtMontoPagUs})
      Me.GroupFooter1.Height = 0.3847222!
      Me.GroupFooter1.Name = "GroupFooter1"
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
      Me.txtCapitalBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCapitalBs.Height = 0.1875!
      Me.txtCapitalBs.Left = 4.75!
      Me.txtCapitalBs.Name = "txtCapitalBs"
      Me.txtCapitalBs.OutputFormat = resources.GetString("txtCapitalBs.OutputFormat")
      Me.txtCapitalBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCapitalBs.Text = "CapitalBs"
      Me.txtCapitalBs.Top = 0.0!
      Me.txtCapitalBs.Width = 0.6875!
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
      Me.txtInteresBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtInteresBs.Height = 0.1875!
      Me.txtInteresBs.Left = 5.4375!
      Me.txtInteresBs.Name = "txtInteresBs"
      Me.txtInteresBs.OutputFormat = resources.GetString("txtInteresBs.OutputFormat")
      Me.txtInteresBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtInteresBs.Text = "InteresBs"
      Me.txtInteresBs.Top = 0.0!
      Me.txtInteresBs.Width = 0.6875!
      '
      'txtImporteBs
      '
      Me.txtImporteBs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporteBs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteBs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporteBs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteBs.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporteBs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteBs.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporteBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtImporteBs.Height = 0.1875!
      Me.txtImporteBs.Left = 6.125!
      Me.txtImporteBs.Name = "txtImporteBs"
      Me.txtImporteBs.OutputFormat = resources.GetString("txtImporteBs.OutputFormat")
      Me.txtImporteBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtImporteBs.Text = "ImporteBs"
      Me.txtImporteBs.Top = 0.0!
      Me.txtImporteBs.Width = 0.6875!
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
      Me.txtCapitalUs.Left = 4.75!
      Me.txtCapitalUs.Name = "txtCapitalUs"
      Me.txtCapitalUs.OutputFormat = resources.GetString("txtCapitalUs.OutputFormat")
      Me.txtCapitalUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCapitalUs.Text = "CapitalUs"
      Me.txtCapitalUs.Top = 0.1875!
      Me.txtCapitalUs.Width = 0.6875!
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
      Me.txtInteresUs.Left = 5.4375!
      Me.txtInteresUs.Name = "txtInteresUs"
      Me.txtInteresUs.OutputFormat = resources.GetString("txtInteresUs.OutputFormat")
      Me.txtInteresUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtInteresUs.Text = "InteresUs"
      Me.txtInteresUs.Top = 0.1875!
      Me.txtInteresUs.Width = 0.6875!
      '
      'txtImporteUs
      '
      Me.txtImporteUs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporteUs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteUs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporteUs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteUs.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporteUs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteUs.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporteUs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteUs.Height = 0.1875!
      Me.txtImporteUs.Left = 6.125!
      Me.txtImporteUs.Name = "txtImporteUs"
      Me.txtImporteUs.OutputFormat = resources.GetString("txtImporteUs.OutputFormat")
      Me.txtImporteUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtImporteUs.Text = "ImporteUs"
      Me.txtImporteUs.Top = 0.1875!
      Me.txtImporteUs.Width = 0.6875!
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
      Me.TextBox4.Left = 4.0625!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; vertical" & _
          "-align: middle; "
      Me.TextBox4.Text = "Total Bs :"
      Me.TextBox4.Top = 0.0!
      Me.TextBox4.Width = 0.6875!
      '
      'TextBox2
      '
      Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Height = 0.1875!
      Me.TextBox2.Left = 4.0625!
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; vertical" & _
          "-align: middle; "
      Me.TextBox2.Text = "Total Us :"
      Me.TextBox2.Top = 0.1875!
      Me.TextBox2.Width = 0.6875!
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
      Me.txtMontoPagBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMontoPagBs.Height = 0.1875!
      Me.txtMontoPagBs.Left = 6.8125!
      Me.txtMontoPagBs.Name = "txtMontoPagBs"
      Me.txtMontoPagBs.OutputFormat = resources.GetString("txtMontoPagBs.OutputFormat")
      Me.txtMontoPagBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoPagBs.Text = "MontoPagBs"
      Me.txtMontoPagBs.Top = 0.0!
      Me.txtMontoPagBs.Width = 0.6875!
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
      Me.txtMontoPagUs.Left = 6.8125!
      Me.txtMontoPagUs.Name = "txtMontoPagUs"
      Me.txtMontoPagUs.OutputFormat = resources.GetString("txtMontoPagUs.OutputFormat")
      Me.txtMontoPagUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoPagUs.Text = "MontoPagUs"
      Me.txtMontoPagUs.Top = 0.1875!
      Me.txtMontoPagUs.Width = 0.6875!
      '
      'rptCreditoPagoEdit
      '
      Me.MasterReport = False
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
      CType(Me.txtCompraNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCreditoNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCuotaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCapital, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtInteres, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtAmortiza, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaPago, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCapitalBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtInteresBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporteBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCapitalUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtInteresUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporteUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoPagBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoPagUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

End Class