Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptCompraNext 
    Inherits DataDynamics.ActiveReports.ActiveReport3

   Dim mdecMonto As Decimal = 0
   Dim mdecMontoCos As Decimal = 0
   Dim mdecMontoEqui As Decimal = 0
   Dim mdecMontoCosEqui As Decimal = 0

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
   Public WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
   Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
   Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
   Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
   Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Label As DataDynamics.ActiveReports.Label
   Private Label1 As DataDynamics.ActiveReports.Label
   Private Shape1 As DataDynamics.ActiveReports.Shape
   Private Shape2 As DataDynamics.ActiveReports.Shape
   Private lblAlmacenIdOrg As DataDynamics.ActiveReports.Label
   Private lblAlmacenIdDes As DataDynamics.ActiveReports.Label
   Private Label2 As DataDynamics.ActiveReports.Label
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Label4 As DataDynamics.ActiveReports.Label
   Private Label5 As DataDynamics.ActiveReports.Label
   Private Label6 As DataDynamics.ActiveReports.Label
   Private Label14 As DataDynamics.ActiveReports.Label
   Private TextBox16 As DataDynamics.ActiveReports.TextBox
   Private TextBox17 As DataDynamics.ActiveReports.TextBox
   Private TextBox18 As DataDynamics.ActiveReports.TextBox
   Private TextBox19 As DataDynamics.ActiveReports.TextBox
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox
   Private TextBox21 As DataDynamics.ActiveReports.TextBox
   Private Label16 As DataDynamics.ActiveReports.Label
   Private TextBox22 As DataDynamics.ActiveReports.TextBox
   Private TextBox23 As DataDynamics.ActiveReports.TextBox
   Private TextBox24 As DataDynamics.ActiveReports.TextBox
   Private Shape3 As DataDynamics.ActiveReports.Shape
   Private Label8 As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label9 As DataDynamics.ActiveReports.Label
   Private Label10 As DataDynamics.ActiveReports.Label
   Private Label7 As DataDynamics.ActiveReports.Label
   Private Label15 As DataDynamics.ActiveReports.Label
   Private Label17 As DataDynamics.ActiveReports.Label
   Private Label18 As DataDynamics.ActiveReports.Label
   Private TextBox25 As DataDynamics.ActiveReports.TextBox
   Private TextBox26 As DataDynamics.ActiveReports.TextBox
   Private TextBox27 As DataDynamics.ActiveReports.TextBox
   Private TextBox28 As DataDynamics.ActiveReports.TextBox
   Private TextBox30 As DataDynamics.ActiveReports.TextBox
   Private TextBox31 As DataDynamics.ActiveReports.TextBox
   Private txtPrecioCos As DataDynamics.ActiveReports.TextBox
   Private txtImporteCos As DataDynamics.ActiveReports.TextBox
   Private txtCIF As DataDynamics.ActiveReports.TextBox
   Private txtPrecioOrgEqui As DataDynamics.ActiveReports.TextBox
   Private txtImporteEqui As DataDynamics.ActiveReports.TextBox
   Private txtPrecioCosEqui As DataDynamics.ActiveReports.TextBox
   Private txtImporteCosEqui As DataDynamics.ActiveReports.TextBox
   Private Line As DataDynamics.ActiveReports.Line
   Public srptCompraOtroCosto As DataDynamics.ActiveReports.SubReport
   Private Label22 As DataDynamics.ActiveReports.Label
   Private Label21 As DataDynamics.ActiveReports.Label
   Private Label20 As DataDynamics.ActiveReports.Label
   Private txtTotalCompraCos As DataDynamics.ActiveReports.TextBox
   Private txtTotalCompraCosEqui As DataDynamics.ActiveReports.TextBox
   Private txtTotalCompra As DataDynamics.ActiveReports.TextBox
   Private Label19 As DataDynamics.ActiveReports.Label
   Private txtTotalCompraEqui As DataDynamics.ActiveReports.TextBox
   Public lblFirma As DataDynamics.ActiveReports.Label
   Private txtMontoRec As DataDynamics.ActiveReports.TextBox
   Private txtMontoDes As DataDynamics.ActiveReports.TextBox
   Private txtMontoAnt As DataDynamics.ActiveReports.TextBox
   Private txtFacturaNro As DataDynamics.ActiveReports.TextBox
   Private TextBox5 As DataDynamics.ActiveReports.TextBox
   Private TextBox6 As DataDynamics.ActiveReports.TextBox
   Private TextBox7 As DataDynamics.ActiveReports.TextBox
   Private Label23 As DataDynamics.ActiveReports.Label
   Private Label24 As DataDynamics.ActiveReports.Label
   Private Label25 As DataDynamics.ActiveReports.Label
   Private lblFacturaNro As DataDynamics.ActiveReports.TextBox
   Private txtFacturaMonto As DataDynamics.ActiveReports.TextBox
   Private lblFacturaMonto As DataDynamics.ActiveReports.TextBox
   Private txtFacturaId As DataDynamics.ActiveReports.TextBox
   Private txtPolizaId As DataDynamics.ActiveReports.TextBox
   Private Label13 As DataDynamics.ActiveReports.Label
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label12 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCompraNext))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox26 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox30 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox31 = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecioCos = New DataDynamics.ActiveReports.TextBox
      Me.txtImporteCos = New DataDynamics.ActiveReports.TextBox
      Me.txtCIF = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecioOrgEqui = New DataDynamics.ActiveReports.TextBox
      Me.txtImporteEqui = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecioCosEqui = New DataDynamics.ActiveReports.TextBox
      Me.txtImporteCosEqui = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
      Me.Shape2 = New DataDynamics.ActiveReports.Shape
      Me.lblAlmacenIdOrg = New DataDynamics.ActiveReports.Label
      Me.lblAlmacenIdDes = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox19 = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
      Me.Label16 = New DataDynamics.ActiveReports.Label
      Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox23 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox24 = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label12 = New DataDynamics.ActiveReports.Label
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
      Me.Label17 = New DataDynamics.ActiveReports.Label
      Me.Label18 = New DataDynamics.ActiveReports.Label
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.Line = New DataDynamics.ActiveReports.Line
      Me.srptCompraOtroCosto = New DataDynamics.ActiveReports.SubReport
      Me.Label22 = New DataDynamics.ActiveReports.Label
      Me.Label21 = New DataDynamics.ActiveReports.Label
      Me.Label20 = New DataDynamics.ActiveReports.Label
      Me.txtTotalCompraCos = New DataDynamics.ActiveReports.TextBox
      Me.txtTotalCompraCosEqui = New DataDynamics.ActiveReports.TextBox
      Me.txtTotalCompra = New DataDynamics.ActiveReports.TextBox
      Me.Label19 = New DataDynamics.ActiveReports.Label
      Me.txtTotalCompraEqui = New DataDynamics.ActiveReports.TextBox
      Me.lblFirma = New DataDynamics.ActiveReports.Label
      Me.txtMontoRec = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoAnt = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaNro = New DataDynamics.ActiveReports.TextBox
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
      Me.Label23 = New DataDynamics.ActiveReports.Label
      Me.Label24 = New DataDynamics.ActiveReports.Label
      Me.Label25 = New DataDynamics.ActiveReports.Label
      Me.lblFacturaNro = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaMonto = New DataDynamics.ActiveReports.TextBox
      Me.lblFacturaMonto = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaId = New DataDynamics.ActiveReports.TextBox
      Me.txtPolizaId = New DataDynamics.ActiveReports.TextBox
      CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecioCos, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporteCos, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCIF, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecioOrgEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporteEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecioCosEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporteCosEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacenIdOrg, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacenIdDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalCompraCos, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalCompraCosEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalCompra, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalCompraEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblFirma, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoRec, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblFacturaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblFacturaMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPolizaId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox30, Me.TextBox31, Me.txtPrecioCos, Me.txtImporteCos, Me.txtCIF, Me.txtPrecioOrgEqui, Me.txtImporteEqui, Me.txtPrecioCosEqui, Me.txtImporteCosEqui})
      Me.Detail.Height = 0.3847222!
      Me.Detail.Name = "Detail"
      '
      'TextBox25
      '
      Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox25.DataField = "ItemCod"
      Me.TextBox25.Height = 0.1875!
      Me.TextBox25.Left = 0.0!
      Me.TextBox25.Name = "TextBox25"
      Me.TextBox25.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox25.Text = "ItemCod"
      Me.TextBox25.Top = 0.0!
      Me.TextBox25.Width = 0.8125!
      '
      'TextBox26
      '
      Me.TextBox26.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox26.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox26.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox26.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox26.DataField = "ItemDes"
      Me.TextBox26.Height = 0.1875!
      Me.TextBox26.Left = 0.8125!
      Me.TextBox26.Name = "TextBox26"
      Me.TextBox26.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox26.Text = "ItemDes"
      Me.TextBox26.Top = 0.0!
      Me.TextBox26.Width = 2.625!
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
      Me.TextBox27.Left = 3.4375!
      Me.TextBox27.Name = "TextBox27"
      Me.TextBox27.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox27.Text = "MedidaDes"
      Me.TextBox27.Top = 0.0!
      Me.TextBox27.Width = 0.625!
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
      Me.TextBox28.Left = 4.0625!
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
      Me.TextBox30.Left = 4.75!
      Me.TextBox30.Name = "TextBox30"
      Me.TextBox30.OutputFormat = resources.GetString("TextBox30.OutputFormat")
      Me.TextBox30.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox30.Text = "PrecioOrg"
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
      Me.TextBox31.Height = 0.1875!
      Me.TextBox31.Left = 5.4375!
      Me.TextBox31.Name = "TextBox31"
      Me.TextBox31.OutputFormat = resources.GetString("TextBox31.OutputFormat")
      Me.TextBox31.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox31.Text = "Importe"
      Me.TextBox31.Top = 0.0!
      Me.TextBox31.Width = 0.6875!
      '
      'txtPrecioCos
      '
      Me.txtPrecioCos.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPrecioCos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioCos.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPrecioCos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioCos.Border.RightColor = System.Drawing.Color.Black
      Me.txtPrecioCos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioCos.Border.TopColor = System.Drawing.Color.Black
      Me.txtPrecioCos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioCos.DataField = "PrecioCos"
      Me.txtPrecioCos.Height = 0.1875!
      Me.txtPrecioCos.Left = 4.75!
      Me.txtPrecioCos.Name = "txtPrecioCos"
      Me.txtPrecioCos.OutputFormat = resources.GetString("txtPrecioCos.OutputFormat")
      Me.txtPrecioCos.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
      Me.txtPrecioCos.Text = "PrecioCos"
      Me.txtPrecioCos.Top = 0.1875!
      Me.txtPrecioCos.Width = 0.6875!
      '
      'txtImporteCos
      '
      Me.txtImporteCos.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporteCos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteCos.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporteCos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteCos.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporteCos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteCos.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporteCos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteCos.Height = 0.1875!
      Me.txtImporteCos.Left = 5.4375!
      Me.txtImporteCos.Name = "txtImporteCos"
      Me.txtImporteCos.OutputFormat = resources.GetString("txtImporteCos.OutputFormat")
      Me.txtImporteCos.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
      Me.txtImporteCos.Text = "ImporteCos"
      Me.txtImporteCos.Top = 0.1875!
      Me.txtImporteCos.Width = 0.6875!
      '
      'txtCIF
      '
      Me.txtCIF.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCIF.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCIF.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCIF.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCIF.Border.RightColor = System.Drawing.Color.Black
      Me.txtCIF.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCIF.Border.TopColor = System.Drawing.Color.Black
      Me.txtCIF.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCIF.Height = 0.1875!
      Me.txtCIF.Left = 3.4375!
      Me.txtCIF.Name = "txtCIF"
      Me.txtCIF.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
      Me.txtCIF.Text = "CIF"
      Me.txtCIF.Top = 0.1875!
      Me.txtCIF.Width = 0.625!
      '
      'txtPrecioOrgEqui
      '
      Me.txtPrecioOrgEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPrecioOrgEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioOrgEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPrecioOrgEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioOrgEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtPrecioOrgEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioOrgEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtPrecioOrgEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioOrgEqui.Height = 0.1875!
      Me.txtPrecioOrgEqui.Left = 6.125!
      Me.txtPrecioOrgEqui.Name = "txtPrecioOrgEqui"
      Me.txtPrecioOrgEqui.OutputFormat = resources.GetString("txtPrecioOrgEqui.OutputFormat")
      Me.txtPrecioOrgEqui.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrecioOrgEqui.Text = "PrecioOrgEqui"
      Me.txtPrecioOrgEqui.Top = 0.0!
      Me.txtPrecioOrgEqui.Width = 0.6875!
      '
      'txtImporteEqui
      '
      Me.txtImporteEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporteEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporteEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporteEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporteEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteEqui.Height = 0.1875!
      Me.txtImporteEqui.Left = 6.8125!
      Me.txtImporteEqui.Name = "txtImporteEqui"
      Me.txtImporteEqui.OutputFormat = resources.GetString("txtImporteEqui.OutputFormat")
      Me.txtImporteEqui.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtImporteEqui.Text = "ImporteEqui"
      Me.txtImporteEqui.Top = 0.0!
      Me.txtImporteEqui.Width = 0.6875!
      '
      'txtPrecioCosEqui
      '
      Me.txtPrecioCosEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPrecioCosEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioCosEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPrecioCosEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioCosEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtPrecioCosEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioCosEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtPrecioCosEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioCosEqui.Height = 0.1875!
      Me.txtPrecioCosEqui.Left = 6.125!
      Me.txtPrecioCosEqui.Name = "txtPrecioCosEqui"
      Me.txtPrecioCosEqui.OutputFormat = resources.GetString("txtPrecioCosEqui.OutputFormat")
      Me.txtPrecioCosEqui.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
      Me.txtPrecioCosEqui.Text = "PrecioCosEqui"
      Me.txtPrecioCosEqui.Top = 0.1875!
      Me.txtPrecioCosEqui.Width = 0.6875!
      '
      'txtImporteCosEqui
      '
      Me.txtImporteCosEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporteCosEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteCosEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporteCosEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteCosEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporteCosEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteCosEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporteCosEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteCosEqui.Height = 0.1875!
      Me.txtImporteCosEqui.Left = 6.8125!
      Me.txtImporteCosEqui.Name = "txtImporteCosEqui"
      Me.txtImporteCosEqui.OutputFormat = resources.GetString("txtImporteCosEqui.OutputFormat")
      Me.txtImporteCosEqui.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
      Me.txtImporteCosEqui.Text = "ImporteCosEqui"
      Me.txtImporteCosEqui.Top = 0.1875!
      Me.txtImporteCosEqui.Width = 0.6875!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Label, Me.Label1, Me.Shape1, Me.Shape2, Me.lblAlmacenIdOrg, Me.lblAlmacenIdDes, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label14, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.txtMonedaDes, Me.TextBox21, Me.Label16, Me.TextBox22, Me.TextBox23, Me.TextBox24})
      Me.ReportHeader.Height = 1.614583!
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
      Me.lblAlmacenIdDes.Left = 0.0625!
      Me.lblAlmacenIdDes.Name = "lblAlmacenIdDes"
      Me.lblAlmacenIdDes.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblAlmacenIdDes.Text = "Almacén        :"
      Me.lblAlmacenIdDes.Top = 1.0!
      Me.lblAlmacenIdDes.Width = 0.8125!
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
      Me.Label2.Left = 0.0625!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Descripción  :"
      Me.Label2.Top = 1.25!
      Me.Label2.Width = 0.8125!
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
      Me.Label3.Left = 4.75!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label3.Text = "Estado   :"
      Me.Label3.Top = 1.25!
      Me.Label3.Width = 0.5625!
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
      Me.Label5.Left = 6.1875!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; "
      Me.Label5.Text = "T.C."
      Me.Label5.Top = 1.25!
      Me.Label5.Width = 0.4375!
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
      Me.Label14.Left = 4.75!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label14.Text = "Moneda :"
      Me.Label14.Top = 1.0!
      Me.Label14.Width = 0.5625!
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
      Me.TextBox16.DataField = "ProveedorDes"
      Me.TextBox16.Height = 0.1875!
      Me.TextBox16.Left = 0.875!
      Me.TextBox16.Name = "TextBox16"
      Me.TextBox16.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox16.Text = "ProveedorDes"
      Me.TextBox16.Top = 0.75!
      Me.TextBox16.Width = 3.6875!
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
      Me.TextBox17.DataField = "AlmacenDes"
      Me.TextBox17.Height = 0.1875!
      Me.TextBox17.Left = 0.875!
      Me.TextBox17.Name = "TextBox17"
      Me.TextBox17.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox17.Text = "AlmacenDes"
      Me.TextBox17.Top = 1.0!
      Me.TextBox17.Width = 3.6875!
      '
      'TextBox18
      '
      Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.DataField = "CompraNro"
      Me.TextBox18.Height = 0.1875!
      Me.TextBox18.Left = 6.625!
      Me.TextBox18.Name = "TextBox18"
      Me.TextBox18.Style = "font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.TextBox18.Text = "CompraNro"
      Me.TextBox18.Top = 0.75!
      Me.TextBox18.Width = 0.8125!
      '
      'TextBox19
      '
      Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox19.DataField = "CompraDes"
      Me.TextBox19.Height = 0.1875!
      Me.TextBox19.Left = 0.875!
      Me.TextBox19.Name = "TextBox19"
      Me.TextBox19.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox19.Text = "CompraDes"
      Me.TextBox19.Top = 1.25!
      Me.TextBox19.Width = 3.6875!
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
      Me.txtMonedaDes.Top = 1.0!
      Me.txtMonedaDes.Width = 0.6875!
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
      Me.Label16.Left = 4.75!
      Me.Label16.Name = "Label16"
      Me.Label16.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label16.Text = "Forma    :"
      Me.Label16.Top = 0.75!
      Me.Label16.Width = 0.5625!
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
      Me.TextBox22.Left = 5.3125!
      Me.TextBox22.Name = "TextBox22"
      Me.TextBox22.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox22.Text = "TipoPagoDes"
      Me.TextBox22.Top = 0.75!
      Me.TextBox22.Width = 0.6875!
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
      Me.TextBox23.Left = 6.625!
      Me.TextBox23.Name = "TextBox23"
      Me.TextBox23.OutputFormat = resources.GetString("TextBox23.OutputFormat")
      Me.TextBox23.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox23.Text = "Fecha"
      Me.TextBox23.Top = 1.0!
      Me.TextBox23.Width = 0.8125!
      '
      'TextBox24
      '
      Me.TextBox24.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox24.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox24.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox24.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox24.DataField = "TipoCambio"
      Me.TextBox24.Height = 0.1875!
      Me.TextBox24.Left = 6.625!
      Me.TextBox24.Name = "TextBox24"
      Me.TextBox24.OutputFormat = resources.GetString("TextBox24.OutputFormat")
      Me.TextBox24.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox24.Text = "TipoCambio"
      Me.TextBox24.Top = 1.25!
      Me.TextBox24.Width = 0.8125!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Height = 0.0!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label13, Me.txtPageCount, Me.txtPageNOfM, Me.Label12, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3645833!
      Me.PageFooter.Name = "PageFooter"
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
      Me.Label13.Left = 6885.408!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.Label13.Text = "de"
      Me.Label13.Top = 0.1666667!
      Me.Label13.Width = 0.1875!
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
      Me.Label12.Height = 0.2!
      Me.Label12.HyperLink = Nothing
      Me.Label12.Left = 6.885408!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.Label12.Text = "de"
      Me.Label12.Top = 0.1666667!
      Me.Label12.Width = 0.1875!
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
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.Label8, Me.Label11, Me.Label9, Me.Label10, Me.Label7, Me.Label15, Me.Label17, Me.Label18})
      Me.GroupHeader1.Height = 0.2388889!
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
      Me.Shape3.Height = 0.1979165!
      Me.Shape3.Left = 0.0!
      Me.Shape3.LineWeight = 2.0!
      Me.Shape3.Name = "Shape3"
      Me.Shape3.RoundingRadius = 9.999999!
      Me.Shape3.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape3.Top = 0.0!
      Me.Shape3.Width = 7.5!
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
      Me.Label8.Left = 5.4375!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label8.Text = "IMPORTE"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 0.6875!
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
      Me.Label11.Left = 4.75!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label11.Text = "PRECIO"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.6875!
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
      Me.Label9.Left = 4.0625!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label9.Text = "CANTIDAD"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.6875!
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
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.8125!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label10.Text = "DESCRIPCIÓN"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 2.625!
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
      Me.Label7.Left = 0.0!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label7.Text = "CÓDIGO"
      Me.Label7.Top = 0.01041669!
      Me.Label7.Width = 0.8125!
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
      Me.Label15.Height = 0.1875!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 3.4375!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label15.Text = "UNIDAD"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.625!
      '
      'Label17
      '
      Me.Label17.Border.BottomColor = System.Drawing.Color.Black
      Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.LeftColor = System.Drawing.Color.Black
      Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.RightColor = System.Drawing.Color.Black
      Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label17.Border.TopColor = System.Drawing.Color.Black
      Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Height = 0.1875!
      Me.Label17.HyperLink = Nothing
      Me.Label17.Left = 6.125!
      Me.Label17.Name = "Label17"
      Me.Label17.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label17.Text = "PREC EQUI"
      Me.Label17.Top = 0.0!
      Me.Label17.Width = 0.6875!
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
      Me.Label18.Left = 6.8125!
      Me.Label18.Name = "Label18"
      Me.Label18.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label18.Text = "IMP EQUI"
      Me.Label18.Top = 0.0!
      Me.Label18.Width = 0.6875!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line, Me.srptCompraOtroCosto, Me.Label22, Me.Label21, Me.Label20, Me.txtTotalCompraCos, Me.txtTotalCompraCosEqui, Me.txtTotalCompra, Me.Label19, Me.txtTotalCompraEqui, Me.lblFirma, Me.txtMontoRec, Me.txtMontoDes, Me.txtMontoAnt, Me.txtFacturaNro, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.Label23, Me.Label24, Me.Label25, Me.lblFacturaNro, Me.txtFacturaMonto, Me.lblFacturaMonto, Me.txtFacturaId, Me.txtPolizaId})
      Me.GroupFooter1.Height = 3.697917!
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
      Me.Line.Left = 0.0!
      Me.Line.LineWeight = 1.0!
      Me.Line.Name = "Line"
      Me.Line.Top = 0.0!
      Me.Line.Width = 7.5!
      Me.Line.X1 = 0.0!
      Me.Line.X2 = 7.5!
      Me.Line.Y1 = 0.0!
      Me.Line.Y2 = 0.0!
      '
      'srptCompraOtroCosto
      '
      Me.srptCompraOtroCosto.Border.BottomColor = System.Drawing.Color.Black
      Me.srptCompraOtroCosto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptCompraOtroCosto.Border.LeftColor = System.Drawing.Color.Black
      Me.srptCompraOtroCosto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptCompraOtroCosto.Border.RightColor = System.Drawing.Color.Black
      Me.srptCompraOtroCosto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptCompraOtroCosto.Border.TopColor = System.Drawing.Color.Black
      Me.srptCompraOtroCosto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptCompraOtroCosto.CloseBorder = False
      Me.srptCompraOtroCosto.Height = 0.1875!
      Me.srptCompraOtroCosto.Left = 0.0!
      Me.srptCompraOtroCosto.Name = "srptCompraOtroCosto"
      Me.srptCompraOtroCosto.Report = Nothing
      Me.srptCompraOtroCosto.Top = 1.0!
      Me.srptCompraOtroCosto.Width = 7.5!
      '
      'Label22
      '
      Me.Label22.Border.BottomColor = System.Drawing.Color.Black
      Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label22.Border.LeftColor = System.Drawing.Color.Black
      Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label22.Border.RightColor = System.Drawing.Color.Black
      Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label22.Border.TopColor = System.Drawing.Color.Black
      Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label22.Height = 0.25!
      Me.Label22.HyperLink = Nothing
      Me.Label22.Left = 4.8125!
      Me.Label22.Name = "Label22"
      Me.Label22.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.Label22.Text = ">>>>>"
      Me.Label22.Top = 0.6875!
      Me.Label22.Width = 0.75!
      '
      'Label21
      '
      Me.Label21.Border.BottomColor = System.Drawing.Color.Black
      Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Border.LeftColor = System.Drawing.Color.Black
      Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Border.RightColor = System.Drawing.Color.Black
      Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Border.TopColor = System.Drawing.Color.Black
      Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Height = 0.25!
      Me.Label21.HyperLink = Nothing
      Me.Label21.Left = 1.9375!
      Me.Label21.Name = "Label21"
      Me.Label21.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.Label21.Text = "<<<<<"
      Me.Label21.Top = 0.6875!
      Me.Label21.Width = 0.75!
      '
      'Label20
      '
      Me.Label20.Border.BottomColor = System.Drawing.Color.Black
      Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Border.LeftColor = System.Drawing.Color.Black
      Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Border.RightColor = System.Drawing.Color.Black
      Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Border.TopColor = System.Drawing.Color.Black
      Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Height = 0.25!
      Me.Label20.HyperLink = Nothing
      Me.Label20.Left = 2.6875!
      Me.Label20.Name = "Label20"
      Me.Label20.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; vertical" & _
          "-align: middle; "
      Me.Label20.Text = "Otros Costos Aplicables"
      Me.Label20.Top = 0.6875!
      Me.Label20.Width = 2.125!
      '
      'txtTotalCompraCos
      '
      Me.txtTotalCompraCos.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalCompraCos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTotalCompraCos.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalCompraCos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraCos.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalCompraCos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraCos.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalCompraCos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraCos.Height = 0.1875!
      Me.txtTotalCompraCos.Left = 5.4375!
      Me.txtTotalCompraCos.Name = "txtTotalCompraCos"
      Me.txtTotalCompraCos.OutputFormat = resources.GetString("txtTotalCompraCos.OutputFormat")
      Me.txtTotalCompraCos.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
      Me.txtTotalCompraCos.Text = "TotalCompraCos"
      Me.txtTotalCompraCos.Top = 0.1875!
      Me.txtTotalCompraCos.Width = 0.6875!
      '
      'txtTotalCompraCosEqui
      '
      Me.txtTotalCompraCosEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalCompraCosEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTotalCompraCosEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalCompraCosEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraCosEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalCompraCosEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraCosEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalCompraCosEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraCosEqui.Height = 0.1875!
      Me.txtTotalCompraCosEqui.Left = 6.8125!
      Me.txtTotalCompraCosEqui.Name = "txtTotalCompraCosEqui"
      Me.txtTotalCompraCosEqui.OutputFormat = resources.GetString("txtTotalCompraCosEqui.OutputFormat")
      Me.txtTotalCompraCosEqui.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
      Me.txtTotalCompraCosEqui.Text = "TotalCompraCosEqui"
      Me.txtTotalCompraCosEqui.Top = 0.1875!
      Me.txtTotalCompraCosEqui.Width = 0.6875!
      '
      'txtTotalCompra
      '
      Me.txtTotalCompra.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalCompra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompra.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalCompra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompra.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalCompra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompra.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalCompra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompra.Height = 0.1875!
      Me.txtTotalCompra.Left = 5.4375!
      Me.txtTotalCompra.Name = "txtTotalCompra"
      Me.txtTotalCompra.OutputFormat = resources.GetString("txtTotalCompra.OutputFormat")
      Me.txtTotalCompra.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtTotalCompra.Text = "TotalCompra"
      Me.txtTotalCompra.Top = 0.0!
      Me.txtTotalCompra.Width = 0.6875!
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
      Me.Label19.Height = 0.1875!
      Me.Label19.HyperLink = Nothing
      Me.Label19.Left = 4.8125!
      Me.Label19.Name = "Label19"
      Me.Label19.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label19.Text = "Totales :"
      Me.Label19.Top = 0.1875!
      Me.Label19.Width = 0.5625!
      '
      'txtTotalCompraEqui
      '
      Me.txtTotalCompraEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalCompraEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalCompraEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalCompraEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalCompraEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalCompraEqui.Height = 0.1875!
      Me.txtTotalCompraEqui.Left = 6.8125!
      Me.txtTotalCompraEqui.Name = "txtTotalCompraEqui"
      Me.txtTotalCompraEqui.OutputFormat = resources.GetString("txtTotalCompraEqui.OutputFormat")
      Me.txtTotalCompraEqui.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtTotalCompraEqui.Text = "TotalCompraEqui"
      Me.txtTotalCompraEqui.Top = 0.0!
      Me.txtTotalCompraEqui.Width = 0.6875!
      '
      'lblFirma
      '
      Me.lblFirma.Border.BottomColor = System.Drawing.Color.Black
      Me.lblFirma.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFirma.Border.LeftColor = System.Drawing.Color.Black
      Me.lblFirma.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFirma.Border.RightColor = System.Drawing.Color.Black
      Me.lblFirma.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFirma.Border.TopColor = System.Drawing.Color.Black
      Me.lblFirma.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFirma.Height = 0.375!
      Me.lblFirma.HyperLink = Nothing
      Me.lblFirma.Left = 0.0!
      Me.lblFirma.Name = "lblFirma"
      Me.lblFirma.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 8pt; vertica" & _
          "l-align: top; "
      Me.lblFirma.Text = "VoBo"
      Me.lblFirma.Top = 3.3125!
      Me.lblFirma.Width = 7.5!
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
      Me.txtMontoRec.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoRec.DataField = "MontoRec"
      Me.txtMontoRec.Height = 0.1875!
      Me.txtMontoRec.Left = 6.8125!
      Me.txtMontoRec.Name = "txtMontoRec"
      Me.txtMontoRec.OutputFormat = resources.GetString("txtMontoRec.OutputFormat")
      Me.txtMontoRec.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoRec.Text = "MontoRec"
      Me.txtMontoRec.Top = 2.3125!
      Me.txtMontoRec.Width = 0.6875!
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
      Me.txtMontoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoDes.DataField = "MontoDes"
      Me.txtMontoDes.Height = 0.1875!
      Me.txtMontoDes.Left = 6.8125!
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.OutputFormat = resources.GetString("txtMontoDes.OutputFormat")
      Me.txtMontoDes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoDes.Text = "MontoDes"
      Me.txtMontoDes.Top = 2.125!
      Me.txtMontoDes.Width = 0.6875!
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
      Me.txtMontoAnt.Height = 0.1875!
      Me.txtMontoAnt.Left = 6.8125!
      Me.txtMontoAnt.Name = "txtMontoAnt"
      Me.txtMontoAnt.OutputFormat = resources.GetString("txtMontoAnt.OutputFormat")
      Me.txtMontoAnt.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoAnt.Text = "MontoAnt"
      Me.txtMontoAnt.Top = 1.9375!
      Me.txtMontoAnt.Width = 0.6875!
      '
      'txtFacturaNro
      '
      Me.txtFacturaNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaNro.Height = 0.1875!
      Me.txtFacturaNro.Left = 6.8125!
      Me.txtFacturaNro.Name = "txtFacturaNro"
      Me.txtFacturaNro.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtFacturaNro.Text = "FacturaNro"
      Me.txtFacturaNro.Top = 2.5625!
      Me.txtFacturaNro.Visible = False
      Me.txtFacturaNro.Width = 0.6875!
      '
      'TextBox5
      '
      Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Height = 0.1875!
      Me.TextBox5.Left = 5.75!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.TextBox5.Text = "Descuento :"
      Me.TextBox5.Top = 2.125!
      Me.TextBox5.Width = 1.0625!
      '
      'TextBox6
      '
      Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Height = 0.1875!
      Me.TextBox6.Left = 5.75!
      Me.TextBox6.Name = "TextBox6"
      Me.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.TextBox6.Text = "Recargo :"
      Me.TextBox6.Top = 2.3125!
      Me.TextBox6.Width = 1.0625!
      '
      'TextBox7
      '
      Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Height = 0.1875!
      Me.TextBox7.Left = 5.75!
      Me.TextBox7.Name = "TextBox7"
      Me.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.TextBox7.Text = "Anticipo :"
      Me.TextBox7.Top = 1.9375!
      Me.TextBox7.Width = 1.0625!
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
      Me.Label23.Height = 0.25!
      Me.Label23.HyperLink = Nothing
      Me.Label23.Left = 4.8125!
      Me.Label23.Name = "Label23"
      Me.Label23.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.Label23.Text = ">>>>>"
      Me.Label23.Top = 1.5!
      Me.Label23.Width = 0.75!
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
      Me.Label24.Height = 0.25!
      Me.Label24.HyperLink = Nothing
      Me.Label24.Left = 1.9375!
      Me.Label24.Name = "Label24"
      Me.Label24.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.Label24.Text = "<<<<<"
      Me.Label24.Top = 1.5!
      Me.Label24.Width = 0.75!
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
      Me.Label25.Height = 0.25!
      Me.Label25.HyperLink = Nothing
      Me.Label25.Left = 2.6875!
      Me.Label25.Name = "Label25"
      Me.Label25.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; vertical" & _
          "-align: middle; "
      Me.Label25.Text = "Información Adicional"
      Me.Label25.Top = 1.5!
      Me.Label25.Width = 2.125!
      '
      'lblFacturaNro
      '
      Me.lblFacturaNro.Border.BottomColor = System.Drawing.Color.Black
      Me.lblFacturaNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFacturaNro.Border.LeftColor = System.Drawing.Color.Black
      Me.lblFacturaNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFacturaNro.Border.RightColor = System.Drawing.Color.Black
      Me.lblFacturaNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFacturaNro.Border.TopColor = System.Drawing.Color.Black
      Me.lblFacturaNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFacturaNro.Height = 0.1875!
      Me.lblFacturaNro.Left = 5.75!
      Me.lblFacturaNro.Name = "lblFacturaNro"
      Me.lblFacturaNro.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblFacturaNro.Text = Nothing
      Me.lblFacturaNro.Top = 2.5625!
      Me.lblFacturaNro.Visible = False
      Me.lblFacturaNro.Width = 1.0625!
      '
      'txtFacturaMonto
      '
      Me.txtFacturaMonto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaMonto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaMonto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaMonto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaMonto.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaMonto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaMonto.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaMonto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaMonto.Height = 0.1875!
      Me.txtFacturaMonto.Left = 6.8125!
      Me.txtFacturaMonto.Name = "txtFacturaMonto"
      Me.txtFacturaMonto.OutputFormat = resources.GetString("txtFacturaMonto.OutputFormat")
      Me.txtFacturaMonto.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtFacturaMonto.Text = "FacturaMonto"
      Me.txtFacturaMonto.Top = 2.75!
      Me.txtFacturaMonto.Visible = False
      Me.txtFacturaMonto.Width = 0.6875!
      '
      'lblFacturaMonto
      '
      Me.lblFacturaMonto.Border.BottomColor = System.Drawing.Color.Black
      Me.lblFacturaMonto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFacturaMonto.Border.LeftColor = System.Drawing.Color.Black
      Me.lblFacturaMonto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFacturaMonto.Border.RightColor = System.Drawing.Color.Black
      Me.lblFacturaMonto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFacturaMonto.Border.TopColor = System.Drawing.Color.Black
      Me.lblFacturaMonto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFacturaMonto.Height = 0.1875!
      Me.lblFacturaMonto.Left = 5.75!
      Me.lblFacturaMonto.Name = "lblFacturaMonto"
      Me.lblFacturaMonto.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblFacturaMonto.Text = Nothing
      Me.lblFacturaMonto.Top = 2.75!
      Me.lblFacturaMonto.Visible = False
      Me.lblFacturaMonto.Width = 1.0625!
      '
      'txtFacturaId
      '
      Me.txtFacturaId.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaId.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaId.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaId.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaId.DataField = "FacturaId"
      Me.txtFacturaId.Height = 0.1875!
      Me.txtFacturaId.Left = 4.5625!
      Me.txtFacturaId.Name = "txtFacturaId"
      Me.txtFacturaId.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtFacturaId.Text = "FacturaId"
      Me.txtFacturaId.Top = 2.5625!
      Me.txtFacturaId.Visible = False
      Me.txtFacturaId.Width = 1.0!
      '
      'txtPolizaId
      '
      Me.txtPolizaId.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPolizaId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPolizaId.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPolizaId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPolizaId.Border.RightColor = System.Drawing.Color.Black
      Me.txtPolizaId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPolizaId.Border.TopColor = System.Drawing.Color.Black
      Me.txtPolizaId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPolizaId.DataField = "PolizaId"
      Me.txtPolizaId.Height = 0.1875!
      Me.txtPolizaId.Left = 4.5625!
      Me.txtPolizaId.Name = "txtPolizaId"
      Me.txtPolizaId.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPolizaId.Text = "PolizaId"
      Me.txtPolizaId.Top = 2.75!
      Me.txtPolizaId.Visible = False
      Me.txtPolizaId.Width = 1.0!
      '
      'rptCompraNext
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
      CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecioCos, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporteCos, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCIF, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecioOrgEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporteEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecioCosEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporteCosEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacenIdOrg, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacenIdDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalCompraCos, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalCompraCosEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalCompra, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalCompraEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblFirma, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoRec, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblFacturaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaMonto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblFacturaMonto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPolizaId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
      txtImporteCos.Text = ToDecStrDos(Me.Fields("PrecioCos").Value * Me.Fields("Cantidad").Value)

      If Me.Fields("MonedaId").Value = 1 Then
         txtPrecioOrgEqui.Text = ToDecStrDos(Me.Fields("PrecioOrg").Value / Me.Fields("TipoCambio").Value)
         txtImporteEqui.Text = ToDecStrDos(Me.Fields("Importe").Value / Me.Fields("TipoCambio").Value)

         txtPrecioCosEqui.Text = ToDecStrDos(Me.Fields("PrecioCos").Value / Me.Fields("TipoCambio").Value)
         txtImporteCosEqui.Text = ToDecStrDos((Me.Fields("PrecioCos").Value * Me.Fields("Cantidad").Value) / Me.Fields("TipoCambio").Value)

      Else
         txtPrecioOrgEqui.Text = ToDecStrDos(Me.Fields("PrecioOrg").Value * Me.Fields("TipoCambio").Value)
         txtImporteEqui.Text = ToDecStrDos(Me.Fields("Importe").Value * Me.Fields("TipoCambio").Value)

         txtPrecioCosEqui.Text = ToDecStrDos(Me.Fields("PrecioCos").Value * Me.Fields("TipoCambio").Value)
         txtImporteCosEqui.Text = ToDecStrDos((Me.Fields("PrecioCos").Value * Me.Fields("Cantidad").Value) * Me.Fields("TipoCambio").Value)
      End If

      mdecMonto += ToDecimal(Me.Fields("Importe").Value)
      mdecMontoCos += ToDecimal(txtImporteCos.Text)

      mdecMontoEqui += ToDecimal(txtImporteEqui.Text)
      mdecMontoCosEqui += ToDecimal(txtImporteCosEqui.Text)
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      Dim decFacturaMonto As Decimal

      txtTotalCompra.Text = ToDecStrDos(mdecMonto)
      txtTotalCompraCos.Text = ToDecStrDos(mdecMontoCos)

      txtTotalCompraEqui.Text = ToDecStrDos(mdecMontoEqui)
      txtTotalCompraCosEqui.Text = ToDecStrDos(mdecMontoCosEqui)

      TextBox5.Visible = False
      txtMontoDes.Visible = False
      TextBox6.Visible = False
      txtMontoRec.Visible = False

      If Me.Fields("FacturaId").Value <> 0 Then
         lblFacturaNro.Visible = True
         lblFacturaMonto.Visible = True
         lblFacturaNro.Text = "Nro Factura :"
         lblFacturaMonto.Text = "Monto :"

         txtFacturaNro.Visible = True
         txtFacturaMonto.Visible = True
         txtFacturaNro.Text = FacturaNroFind(Me.Fields("FacturaId").Value, decFacturaMonto)
         txtFacturaMonto.Text = ToDecStrDos(decFacturaMonto)

      ElseIf Me.Fields("PolizaId").Value <> 0 Then
         lblFacturaNro.Visible = True
         lblFacturaMonto.Visible = True
         lblFacturaNro.Text = "Nro Poliza :"
         lblFacturaMonto.Text = "Monto :"

         txtFacturaNro.Visible = True
         txtFacturaMonto.Visible = True
         txtFacturaNro.Text = PolizaNroFind(Me.Fields("PolizaId").Value, decFacturaMonto)
         txtFacturaMonto.Text = ToDecStrDos(decFacturaMonto)
      End If

   End Sub

   Private Function FacturaNroFind(ByVal lngFacturaId As Long, ByRef decFacturaMonto As Decimal) As Long
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         FacturaNroFind = 0

         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               decFacturaMonto = .FacturaMonto
               Return .FacturaNro
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function PolizaNroFind(ByVal lngPolizaId As Long, ByRef decIVA As Decimal) As String
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      Try
         PolizaNroFind = ""

         With oPoliza
            .PolizaId = lngPolizaId

            If .FindByPK Then
               decIVA = .IVA
               Return .PolizaNro
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oPoliza.Dispose()

      End Try
   End Function

End Class