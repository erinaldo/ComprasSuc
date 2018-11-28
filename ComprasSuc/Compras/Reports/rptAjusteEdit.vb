Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptAjusteEdit 
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
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource
   Private picAnulado As DataDynamics.ActiveReports.Picture
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Label As DataDynamics.ActiveReports.Label
   Private Label1 As DataDynamics.ActiveReports.Label
   Private Shape1 As DataDynamics.ActiveReports.Shape
   Private Shape2 As DataDynamics.ActiveReports.Shape
   Private lblAlmacenIdOrg As DataDynamics.ActiveReports.Label
   Private Label4 As DataDynamics.ActiveReports.Label
   Private Label6 As DataDynamics.ActiveReports.Label
   Private Label14 As DataDynamics.ActiveReports.Label
   Private TextBox17 As DataDynamics.ActiveReports.TextBox
   Private TextBox16 As DataDynamics.ActiveReports.TextBox
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox
   Private TextBox31 As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private TextBox1 As DataDynamics.ActiveReports.TextBox
   Private Label2 As DataDynamics.ActiveReports.Label
   Private TextBox21 As DataDynamics.ActiveReports.TextBox
   Private txtEstadoId As DataDynamics.ActiveReports.TextBox
   Private Label7 As DataDynamics.ActiveReports.Label
   Private Label8 As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label9 As DataDynamics.ActiveReports.Label
   Private lblCreditoNro As DataDynamics.ActiveReports.Label
   Private lblCuotaNro As DataDynamics.ActiveReports.Label
   Private Shape3 As DataDynamics.ActiveReports.Shape
   Private txtCapitalAmo As DataDynamics.ActiveReports.TextBox
   Private txtInteresAmo As DataDynamics.ActiveReports.TextBox
   Private txtImporte As DataDynamics.ActiveReports.TextBox
   Private txtVentaNro As DataDynamics.ActiveReports.TextBox
   Private txtCreditoNro As DataDynamics.ActiveReports.TextBox
   Private txtCuotaNro As DataDynamics.ActiveReports.TextBox
   Private TextBox3 As DataDynamics.ActiveReports.TextBox
   Private txtCapital1 As DataDynamics.ActiveReports.TextBox
   Private txtInteres1 As DataDynamics.ActiveReports.TextBox
   Private txtMontoPag As DataDynamics.ActiveReports.TextBox
   Private txtLiteral As DataDynamics.ActiveReports.TextBox
   Private TextBox4 As DataDynamics.ActiveReports.TextBox
   Private TextBox As DataDynamics.ActiveReports.TextBox
   Private Label12 As DataDynamics.ActiveReports.Label
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label13 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public WithEvents txtFirma As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtTipoCambio As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label5 As DataDynamics.ActiveReports.Label
   Private WithEvents Label10 As DataDynamics.ActiveReports.Label
   Private WithEvents txtSucursalCod As DataDynamics.ActiveReports.TextBox
   Public lblLogin As DataDynamics.ActiveReports.Label

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptAjusteEdit))
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtCapitalAmo = New DataDynamics.ActiveReports.TextBox
      Me.txtInteresAmo = New DataDynamics.ActiveReports.TextBox
      Me.txtImporte = New DataDynamics.ActiveReports.TextBox
      Me.txtVentaNro = New DataDynamics.ActiveReports.TextBox
      Me.txtCreditoNro = New DataDynamics.ActiveReports.TextBox
      Me.txtCuotaNro = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.picAnulado = New DataDynamics.ActiveReports.Picture
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
      Me.Shape2 = New DataDynamics.ActiveReports.Shape
      Me.lblAlmacenIdOrg = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.TextBox31 = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoId = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.txtFirma = New DataDynamics.ActiveReports.TextBox
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
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.lblCreditoNro = New DataDynamics.ActiveReports.Label
      Me.lblCuotaNro = New DataDynamics.ActiveReports.Label
      Me.Shape3 = New DataDynamics.ActiveReports.Shape
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
      Me.txtCapital1 = New DataDynamics.ActiveReports.TextBox
      Me.txtInteres1 = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoPag = New DataDynamics.ActiveReports.TextBox
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.txtTipoCambio = New DataDynamics.ActiveReports.TextBox
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.txtSucursalCod = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtCapitalAmo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtInteresAmo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtVentaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCreditoNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCuotaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacenIdOrg, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCreditoNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCuotaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCapital1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtInteres1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoPag, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSucursalCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCapitalAmo, Me.txtInteresAmo, Me.txtImporte, Me.txtVentaNro, Me.txtCreditoNro, Me.txtCuotaNro})
      Me.Detail.Height = 0.1979167!
      Me.Detail.Name = "Detail"
      '
      'txtCapitalAmo
      '
      Me.txtCapitalAmo.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCapitalAmo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalAmo.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCapitalAmo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalAmo.Border.RightColor = System.Drawing.Color.Black
      Me.txtCapitalAmo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalAmo.Border.TopColor = System.Drawing.Color.Black
      Me.txtCapitalAmo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapitalAmo.DataField = "CapitalOrg"
      Me.txtCapitalAmo.Height = 0.1875!
      Me.txtCapitalAmo.Left = 0.0!
      Me.txtCapitalAmo.Name = "txtCapitalAmo"
      Me.txtCapitalAmo.OutputFormat = resources.GetString("txtCapitalAmo.OutputFormat")
      Me.txtCapitalAmo.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCapitalAmo.Text = "CapitalOrg"
      Me.txtCapitalAmo.Top = 0.0!
      Me.txtCapitalAmo.Width = 0.8125!
      '
      'txtInteresAmo
      '
      Me.txtInteresAmo.Border.BottomColor = System.Drawing.Color.Black
      Me.txtInteresAmo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresAmo.Border.LeftColor = System.Drawing.Color.Black
      Me.txtInteresAmo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresAmo.Border.RightColor = System.Drawing.Color.Black
      Me.txtInteresAmo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresAmo.Border.TopColor = System.Drawing.Color.Black
      Me.txtInteresAmo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteresAmo.DataField = "InteresOrg"
      Me.txtInteresAmo.Height = 0.1875!
      Me.txtInteresAmo.Left = 0.8125!
      Me.txtInteresAmo.Name = "txtInteresAmo"
      Me.txtInteresAmo.OutputFormat = resources.GetString("txtInteresAmo.OutputFormat")
      Me.txtInteresAmo.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtInteresAmo.Text = "InteresOrg"
      Me.txtInteresAmo.Top = 0.0!
      Me.txtInteresAmo.Width = 0.8125!
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
      Me.txtImporte.DataField = "ImporteOrg"
      Me.txtImporte.Height = 0.1875!
      Me.txtImporte.Left = 1.625!
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.OutputFormat = resources.GetString("txtImporte.OutputFormat")
      Me.txtImporte.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtImporte.Text = "ImporteOrg"
      Me.txtImporte.Top = 0.0!
      Me.txtImporte.Width = 0.8125!
      '
      'txtVentaNro
      '
      Me.txtVentaNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtVentaNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtVentaNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtVentaNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtVentaNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtVentaNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtVentaNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtVentaNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtVentaNro.DataField = "CompraNro"
      Me.txtVentaNro.Height = 0.1875!
      Me.txtVentaNro.Left = 2.4375!
      Me.txtVentaNro.Name = "txtVentaNro"
      Me.txtVentaNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtVentaNro.Text = "CompraNro"
      Me.txtVentaNro.Top = 0.0!
      Me.txtVentaNro.Width = 0.8125!
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
      Me.txtCreditoNro.Left = 3.25!
      Me.txtCreditoNro.Name = "txtCreditoNro"
      Me.txtCreditoNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtCreditoNro.Text = "CreditoNro"
      Me.txtCreditoNro.Top = 0.0!
      Me.txtCreditoNro.Width = 0.8125!
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
      Me.txtCuotaNro.Left = 4.0625!
      Me.txtCuotaNro.Name = "txtCuotaNro"
      Me.txtCuotaNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtCuotaNro.Text = "CuotaNro"
      Me.txtCuotaNro.Top = 0.0!
      Me.txtCuotaNro.Width = 0.8125!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.picAnulado, Me.lblCompany, Me.lblTitle, Me.Label, Me.Label1, Me.Shape1, Me.Shape2, Me.lblAlmacenIdOrg, Me.Label4, Me.Label6, Me.Label14, Me.TextBox17, Me.TextBox16, Me.txtMonedaDes, Me.TextBox31, Me.Label3, Me.TextBox1, Me.Label2, Me.TextBox21, Me.txtEstadoId, Me.txtTipoCambio, Me.Label5, Me.Label10, Me.txtSucursalCod})
      Me.ReportHeader.Height = 1.572917!
      Me.ReportHeader.Name = "ReportHeader"
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
      Me.picAnulado.Top = 0.8125!
      Me.picAnulado.Visible = False
      Me.picAnulado.Width = 5.8125!
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
      Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.RightColor = System.Drawing.Color.Black
      Me.lblTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.TopColor = System.Drawing.Color.Black
      Me.lblTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Height = 0.25!
      Me.lblTitle.HyperLink = Nothing
      Me.lblTitle.Left = 2.75!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.3125!
      Me.lblTitle.Width = 2.0!
      '
      'Label
      '
      Me.Label.Border.BottomColor = System.Drawing.Color.Black
      Me.Label.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.LeftColor = System.Drawing.Color.Black
      Me.Label.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.RightColor = System.Drawing.Color.Black
      Me.Label.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.TopColor = System.Drawing.Color.Black
      Me.Label.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Height = 0.25!
      Me.Label.HyperLink = Nothing
      Me.Label.Left = 2.0!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 16pt; vertical" & _
          "-align: middle; "
      Me.Label.Text = "<<<<<"
      Me.Label.Top = 0.3125!
      Me.Label.Width = 0.75!
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
      Me.Label1.Height = 0.25!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 4.75!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 16pt; vertical" & _
          "-align: middle; "
      Me.Label1.Text = ">>>>>"
      Me.Label1.Top = 0.3125!
      Me.Label1.Width = 0.75!
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
      Me.Shape1.Height = 0.8125!
      Me.Shape1.Left = 0.0!
      Me.Shape1.LineWeight = 2.0!
      Me.Shape1.Name = "Shape1"
      Me.Shape1.RoundingRadius = 9.999999!
      Me.Shape1.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape1.Top = 0.6875!
      Me.Shape1.Width = 6.0625!
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
      Me.Shape2.Height = 0.8125!
      Me.Shape2.Left = 6.125!
      Me.Shape2.LineWeight = 2.0!
      Me.Shape2.Name = "Shape2"
      Me.Shape2.RoundingRadius = 9.999999!
      Me.Shape2.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape2.Top = 0.6875!
      Me.Shape2.Width = 1.364583!
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
      Me.lblAlmacenIdOrg.Left = 0.0625!
      Me.lblAlmacenIdOrg.Name = "lblAlmacenIdOrg"
      Me.lblAlmacenIdOrg.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblAlmacenIdOrg.Text = "Proveedor     :"
      Me.lblAlmacenIdOrg.Top = 0.75!
      Me.lblAlmacenIdOrg.Width = 0.8125!
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
      Me.Label4.Left = 6.1875!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label4.Text = "Nro. "
      Me.Label4.Top = 0.75!
      Me.Label4.Width = 0.4375!
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
      Me.Label6.Left = 6.1875!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label6.Text = "Fecha"
      Me.Label6.Top = 1.0!
      Me.Label6.Width = 0.4375!
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
      Me.Label14.Left = 4.6875!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label14.Text = "Moneda   :"
      Me.Label14.Top = 0.75!
      Me.Label14.Width = 0.625!
      '
      'TextBox17
      '
      Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.DataField = "Fecha"
      Me.TextBox17.Height = 0.1875!
      Me.TextBox17.Left = 6.625!
      Me.TextBox17.Name = "TextBox17"
      Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
      Me.TextBox17.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox17.Text = "Fecha"
      Me.TextBox17.Top = 1.0!
      Me.TextBox17.Width = 0.8125!
      '
      'TextBox16
      '
      Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.DataField = "AjusteNro"
      Me.TextBox16.Height = 0.1875!
      Me.TextBox16.Left = 6.625!
      Me.TextBox16.Name = "TextBox16"
      Me.TextBox16.Style = "font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.TextBox16.Text = "AjusteNro"
      Me.TextBox16.Top = 0.75!
      Me.TextBox16.Width = 0.8125!
      '
      'txtMonedaDes
      '
      Me.txtMonedaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMonedaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.DataField = "MonedaDes"
      Me.txtMonedaDes.Height = 0.1875!
      Me.txtMonedaDes.Left = 5.3125!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 0.75!
      Me.txtMonedaDes.Width = 0.6875!
      '
      'TextBox31
      '
      Me.TextBox31.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox31.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox31.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox31.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox31.DataField = "ProveedorDes"
      Me.TextBox31.Height = 0.1875!
      Me.TextBox31.Left = 0.875!
      Me.TextBox31.Name = "TextBox31"
      Me.TextBox31.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox31.Text = "ProveedorDes"
      Me.TextBox31.Top = 0.75!
      Me.TextBox31.Width = 3.375!
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
      Me.Label3.Left = 0.0625!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label3.Text = "Observación :"
      Me.Label3.Top = 1.25!
      Me.Label3.Width = 0.8125!
      '
      'TextBox1
      '
      Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.DataField = "AjusteDes"
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 0.875!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox1.Text = "AjusteDes"
      Me.TextBox1.Top = 1.25!
      Me.TextBox1.Width = 3.375!
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
      Me.Label2.Left = 4.75!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Estado   :"
      Me.Label2.Top = 1.25!
      Me.Label2.Width = 0.5625!
      '
      'TextBox21
      '
      Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox21.DataField = "EstadoDes"
      Me.TextBox21.Height = 0.1875!
      Me.TextBox21.Left = 5.3125!
      Me.TextBox21.Name = "TextBox21"
      Me.TextBox21.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox21.Text = "EstadoDes"
      Me.TextBox21.Top = 1.25!
      Me.TextBox21.Width = 0.6875!
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
      Me.txtEstadoId.Left = 6.6875!
      Me.txtEstadoId.Name = "txtEstadoId"
      Me.txtEstadoId.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtEstadoId.Text = "EstadoId"
      Me.txtEstadoId.Top = 0.4375!
      Me.txtEstadoId.Visible = False
      Me.txtEstadoId.Width = 0.5!
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFirma})
      Me.ReportFooter.Height = 0.7604167!
      Me.ReportFooter.Name = "ReportFooter"
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
      Me.txtFirma.Top = 0.375!
      Me.txtFirma.Width = 7.5!
      '
      'PageHeader
      '
      Me.PageHeader.Height = 0.0!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label13, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3534722!
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
      Me.Label13.Top = 0.1666667!
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
      Me.Line2.Left = 0.02083331!
      Me.Line2.LineWeight = 3.0!
      Me.Line2.Name = "Line2"
      Me.Line2.Top = 0.125!
      Me.Line2.Width = 7.5!
      Me.Line2.X1 = 0.02083331!
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
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label7, Me.Label8, Me.Label11, Me.Label9, Me.lblCreditoNro, Me.lblCuotaNro, Me.Shape3})
      Me.GroupHeader1.Height = 0.2395833!
      Me.GroupHeader1.Name = "GroupHeader1"
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
      Me.Label7.Height = 0.1875!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 2.4375!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label7.Text = "COMPRA"
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 0.8125!
      '
      'Label8
      '
      Me.Label8.Border.BottomColor = System.Drawing.Color.Black
      Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.LeftColor = System.Drawing.Color.Black
      Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.RightColor = System.Drawing.Color.Black
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Height = 0.1875!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 1.625!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label8.Text = "IMPORTE"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 0.8125!
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
      Me.Label11.Height = 0.1875!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 0.8125!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label11.Text = "INTERÉS"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.8125!
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
      Me.Label9.Height = 0.1875!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 0.0!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label9.Text = "CAPITAL"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.8125!
      '
      'lblCreditoNro
      '
      Me.lblCreditoNro.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCreditoNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCreditoNro.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCreditoNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCreditoNro.Border.RightColor = System.Drawing.Color.Black
      Me.lblCreditoNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCreditoNro.Border.TopColor = System.Drawing.Color.Black
      Me.lblCreditoNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCreditoNro.Height = 0.1875!
      Me.lblCreditoNro.HyperLink = Nothing
      Me.lblCreditoNro.Left = 3.25!
      Me.lblCreditoNro.Name = "lblCreditoNro"
      Me.lblCreditoNro.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.lblCreditoNro.Text = "CRÉDITO"
      Me.lblCreditoNro.Top = 0.0!
      Me.lblCreditoNro.Width = 0.8125!
      '
      'lblCuotaNro
      '
      Me.lblCuotaNro.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCuotaNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCuotaNro.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCuotaNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCuotaNro.Border.RightColor = System.Drawing.Color.Black
      Me.lblCuotaNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCuotaNro.Border.TopColor = System.Drawing.Color.Black
      Me.lblCuotaNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCuotaNro.Height = 0.1875!
      Me.lblCuotaNro.HyperLink = Nothing
      Me.lblCuotaNro.Left = 4.0625!
      Me.lblCuotaNro.Name = "lblCuotaNro"
      Me.lblCuotaNro.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.lblCuotaNro.Text = "CUOTA"
      Me.lblCuotaNro.Top = 0.0!
      Me.lblCuotaNro.Width = 0.8125!
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
      Me.Shape3.Height = 0.1979165!
      Me.Shape3.Left = 0.0!
      Me.Shape3.LineWeight = 2.0!
      Me.Shape3.Name = "Shape3"
      Me.Shape3.RoundingRadius = 9.999999!
      Me.Shape3.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape3.Top = 0.0!
      Me.Shape3.Width = 7.5!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.txtCapital1, Me.txtInteres1, Me.txtMontoPag, Me.txtLiteral, Me.TextBox4, Me.TextBox, Me.Label12})
      Me.GroupFooter1.Height = 0.5625!
      Me.GroupFooter1.Name = "GroupFooter1"
      '
      'TextBox3
      '
      Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox3.Height = 0.1875!
      Me.TextBox3.Left = 2.4375!
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
      Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.TextBox3.Text = Nothing
      Me.TextBox3.Top = 0.0!
      Me.TextBox3.Width = 5.0625!
      '
      'txtCapital1
      '
      Me.txtCapital1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCapital1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapital1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCapital1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapital1.Border.RightColor = System.Drawing.Color.Black
      Me.txtCapital1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCapital1.Border.TopColor = System.Drawing.Color.Black
      Me.txtCapital1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCapital1.DataField = "Capital"
      Me.txtCapital1.Height = 0.1875!
      Me.txtCapital1.Left = 0.0!
      Me.txtCapital1.Name = "txtCapital1"
      Me.txtCapital1.OutputFormat = resources.GetString("txtCapital1.OutputFormat")
      Me.txtCapital1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCapital1.Text = "Capital"
      Me.txtCapital1.Top = 0.0!
      Me.txtCapital1.Width = 0.8125!
      '
      'txtInteres1
      '
      Me.txtInteres1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtInteres1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteres1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtInteres1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteres1.Border.RightColor = System.Drawing.Color.Black
      Me.txtInteres1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtInteres1.Border.TopColor = System.Drawing.Color.Black
      Me.txtInteres1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtInteres1.DataField = "Interes"
      Me.txtInteres1.Height = 0.1875!
      Me.txtInteres1.Left = 0.8125!
      Me.txtInteres1.Name = "txtInteres1"
      Me.txtInteres1.OutputFormat = resources.GetString("txtInteres1.OutputFormat")
      Me.txtInteres1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtInteres1.Text = "Interes"
      Me.txtInteres1.Top = 0.0!
      Me.txtInteres1.Width = 0.8125!
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
      Me.txtMontoPag.Left = 1.625!
      Me.txtMontoPag.Name = "txtMontoPag"
      Me.txtMontoPag.OutputFormat = resources.GetString("txtMontoPag.OutputFormat")
      Me.txtMontoPag.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoPag.Text = "MontoPag"
      Me.txtMontoPag.Top = 0.1875!
      Me.txtMontoPag.Width = 0.8125!
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
      Me.txtLiteral.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Height = 0.1875!
      Me.txtLiteral.Left = 1.625!
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtLiteral.Text = Nothing
      Me.txtLiteral.Top = 0.375!
      Me.txtLiteral.Width = 5.875!
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
      Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Height = 0.1875!
      Me.TextBox4.Left = 1.25!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: middle; "
      Me.TextBox4.Text = "SON :"
      Me.TextBox4.Top = 0.375!
      Me.TextBox4.Width = 0.375!
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
      Me.TextBox.DataField = "ImporteOrg"
      Me.TextBox.Height = 0.1875!
      Me.TextBox.Left = 1.625!
      Me.TextBox.Name = "TextBox"
      Me.TextBox.OutputFormat = resources.GetString("TextBox.OutputFormat")
      Me.TextBox.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox.SummaryGroup = "GroupHeader1"
      Me.TextBox.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.TextBox.Text = "Importe"
      Me.TextBox.Top = 0.0!
      Me.TextBox.Width = 0.8125!
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
      Me.Label12.Left = 0.75!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label12.Text = "Total a Pagar :"
      Me.Label12.Top = 0.1875!
      Me.Label12.Width = 0.875!
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
      Me.txtTipoCambio.Left = 5.3125!
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.OutputFormat = resources.GetString("txtTipoCambio.OutputFormat")
      Me.txtTipoCambio.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtTipoCambio.Text = "TipoCambio"
      Me.txtTipoCambio.Top = 1.0!
      Me.txtTipoCambio.Width = 0.6875!
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
      Me.Label5.Left = 4.75!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; "
      Me.Label5.Text = "T.C.        :"
      Me.Label5.Top = 1.0!
      Me.Label5.Width = 0.53125!
      '
      'Label10
      '
      Me.Label10.Border.BottomColor = System.Drawing.Color.Black
      Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.LeftColor = System.Drawing.Color.Black
      Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.RightColor = System.Drawing.Color.Black
      Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.TopColor = System.Drawing.Color.Black
      Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 6.1875!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label10.Text = "Suc."
      Me.Label10.Top = 1.25!
      Me.Label10.Width = 0.4375!
      '
      'txtSucursalCod
      '
      Me.txtSucursalCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSucursalCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSucursalCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSucursalCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtSucursalCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtSucursalCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalCod.DataField = "SucursalCod"
      Me.txtSucursalCod.Height = 0.1875!
      Me.txtSucursalCod.Left = 6.625!
      Me.txtSucursalCod.Name = "txtSucursalCod"
      Me.txtSucursalCod.Style = "font-size: 8.25pt; "
      Me.txtSucursalCod.Text = "SucursalCod"
      Me.txtSucursalCod.Top = 1.25!
      Me.txtSucursalCod.Width = 0.8125!
      '
      'rptAjusteEdit
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
      CType(Me.txtCapitalAmo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtInteresAmo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtVentaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCreditoNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCuotaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacenIdOrg, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCreditoNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCuotaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCapital1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtInteres1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoPag, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSucursalCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
      If txtEstadoId.Text = "12" Then
         picAnulado.Visible = True
      End If
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      txtLiteral.Text = CifraLiteral(ToDecimal(txtMontoPag.Text)) + "  " + UCase(txtMonedaDes.Text)
   End Sub

End Class