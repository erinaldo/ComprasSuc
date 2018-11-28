Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptDevCompraEdit 
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
   Public lblCompany As DataDynamics.ActiveReports.Label = Nothing
   Public lblTitle As DataDynamics.ActiveReports.Label = Nothing
   Private Label As DataDynamics.ActiveReports.Label = Nothing
   Private Label1 As DataDynamics.ActiveReports.Label = Nothing
   Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
   Private Shape2 As DataDynamics.ActiveReports.Shape = Nothing
   Private lblAlmacenIdOrg As DataDynamics.ActiveReports.Label = Nothing
   Private lblAlmacenIdDes As DataDynamics.ActiveReports.Label = Nothing
   Private Label2 As DataDynamics.ActiveReports.Label = Nothing
   Private Label3 As DataDynamics.ActiveReports.Label = Nothing
   Private Label4 As DataDynamics.ActiveReports.Label = Nothing
   Private Label5 As DataDynamics.ActiveReports.Label = Nothing
   Private Label6 As DataDynamics.ActiveReports.Label = Nothing
   Private Label14 As DataDynamics.ActiveReports.Label = Nothing
   Private TextBox19 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox17 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox16 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox21 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox31 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox32 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox35 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtEstadoId As DataDynamics.ActiveReports.TextBox = Nothing
   Private Shape3 As DataDynamics.ActiveReports.Shape = Nothing
   Private Label8 As DataDynamics.ActiveReports.Label = Nothing
   Private Label11 As DataDynamics.ActiveReports.Label = Nothing
   Private Label9 As DataDynamics.ActiveReports.Label = Nothing
   Private Label10 As DataDynamics.ActiveReports.Label = Nothing
   Private Label7 As DataDynamics.ActiveReports.Label = Nothing
   Private Label15 As DataDynamics.ActiveReports.Label = Nothing
   Private TextBox25 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox26 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox28 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox29 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox30 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtLiteral As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtTotal As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblDevCompraObs As DataDynamics.ActiveReports.Label = Nothing
   Private txtDevCompraObs As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageCount As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox = Nothing
   Private Label13 As DataDynamics.ActiveReports.Label = Nothing
   Private Line2 As DataDynamics.ActiveReports.Line = Nothing
   Public lblDate As DataDynamics.ActiveReports.Label = Nothing
   Public lblTime As DataDynamics.ActiveReports.Label = Nothing
   Public WithEvents txtFirma As DataDynamics.ActiveReports.TextBox
   Public WithEvents srptLotesSeries As DataDynamics.ActiveReports.SubReport
   Public lblLogin As DataDynamics.ActiveReports.Label = Nothing

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDevCompraEdit))
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox26 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox29 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox30 = New DataDynamics.ActiveReports.TextBox
      Me.srptLotesSeries = New DataDynamics.ActiveReports.SubReport
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.picAnulado = New DataDynamics.ActiveReports.Picture
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
      Me.TextBox19 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.TextBox31 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox32 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox35 = New DataDynamics.ActiveReports.TextBox
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
      Me.Shape3 = New DataDynamics.ActiveReports.Shape
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.txtTotal = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.lblDevCompraObs = New DataDynamics.ActiveReports.Label
      Me.txtDevCompraObs = New DataDynamics.ActiveReports.TextBox
      CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
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
      CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).BeginInit()
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
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDevCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDevCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.srptLotesSeries})
      Me.Detail.Height = 0.1979167!
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
      Me.TextBox26.Width = 3.875!
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
      Me.TextBox27.Left = 4.6875!
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
      Me.TextBox28.DataField = "CantidadDev"
      Me.TextBox28.Height = 0.1875!
      Me.TextBox28.Left = 5.3125!
      Me.TextBox28.Name = "TextBox28"
      Me.TextBox28.OutputFormat = resources.GetString("TextBox28.OutputFormat")
      Me.TextBox28.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox28.Text = "CantidadDev"
      Me.TextBox28.Top = 0.0!
      Me.TextBox28.Width = 0.6875!
      '
      'TextBox29
      '
      Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox29.DataField = "PrecioOrg"
      Me.TextBox29.Height = 0.1875!
      Me.TextBox29.Left = 6.0!
      Me.TextBox29.Name = "TextBox29"
      Me.TextBox29.OutputFormat = resources.GetString("TextBox29.OutputFormat")
      Me.TextBox29.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox29.Text = "PrecioOrg"
      Me.TextBox29.Top = 0.0!
      Me.TextBox29.Width = 0.6875!
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
      Me.TextBox30.DataField = "Importe"
      Me.TextBox30.Height = 0.1875!
      Me.TextBox30.Left = 6.6875!
      Me.TextBox30.Name = "TextBox30"
      Me.TextBox30.OutputFormat = resources.GetString("TextBox30.OutputFormat")
      Me.TextBox30.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox30.Text = "Importe"
      Me.TextBox30.Top = 0.0!
      Me.TextBox30.Width = 0.8125!
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
      Me.srptLotesSeries.Left = 1.0!
      Me.srptLotesSeries.Name = "srptLotesSeries"
      Me.srptLotesSeries.Report = Nothing
      Me.srptLotesSeries.ReportName = ""
      Me.srptLotesSeries.Top = 0.1875!
      Me.srptLotesSeries.Width = 2.625!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.picAnulado, Me.lblCompany, Me.lblTitle, Me.Label, Me.Label1, Me.Shape1, Me.Shape2, Me.lblAlmacenIdOrg, Me.lblAlmacenIdDes, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label14, Me.TextBox19, Me.TextBox17, Me.TextBox16, Me.TextBox21, Me.txtMonedaDes, Me.TextBox31, Me.TextBox32, Me.TextBox35, Me.txtEstadoId})
      Me.ReportHeader.Height = 1.614583!
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
      Me.lblTitle.Left = 2.5!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.3125!
      Me.lblTitle.Width = 2.5!
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
      Me.Label.Left = 1.75!
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
      Me.Label1.Left = 5.0!
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
      Me.Label3.Left = 4.6875!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label3.Text = "Estado   :"
      Me.Label3.Top = 1.25!
      Me.Label3.Width = 0.625!
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
      Me.Label14.Left = 4.6875!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label14.Text = "Moneda :"
      Me.Label14.Top = 1.0!
      Me.Label14.Width = 0.625!
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
      Me.TextBox19.DataField = "TipoCambio"
      Me.TextBox19.Height = 0.1875!
      Me.TextBox19.Left = 6.625!
      Me.TextBox19.Name = "TextBox19"
      Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
      Me.TextBox19.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox19.Text = "TipoCambio"
      Me.TextBox19.Top = 1.25!
      Me.TextBox19.Width = 0.8125!
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
      Me.TextBox16.DataField = "DevCompraNro"
      Me.TextBox16.Height = 0.1875!
      Me.TextBox16.Left = 6.625!
      Me.TextBox16.Name = "TextBox16"
      Me.TextBox16.Style = "font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.TextBox16.Text = "DevCompraNro"
      Me.TextBox16.Top = 0.75!
      Me.TextBox16.Width = 0.8125!
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
      Me.TextBox31.Width = 3.625!
      '
      'TextBox32
      '
      Me.TextBox32.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox32.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox32.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox32.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox32.DataField = "AlmacenDes"
      Me.TextBox32.Height = 0.1875!
      Me.TextBox32.Left = 0.875!
      Me.TextBox32.Name = "TextBox32"
      Me.TextBox32.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox32.Text = "AlmacenDes"
      Me.TextBox32.Top = 1.0!
      Me.TextBox32.Width = 3.625!
      '
      'TextBox35
      '
      Me.TextBox35.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox35.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox35.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox35.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox35.DataField = "DevCompraDes"
      Me.TextBox35.Height = 0.1875!
      Me.TextBox35.Left = 0.875!
      Me.TextBox35.Name = "TextBox35"
      Me.TextBox35.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox35.Text = "DevCompraDes"
      Me.TextBox35.Top = 1.25!
      Me.TextBox35.Width = 3.625!
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
      Me.txtEstadoId.Left = 6.625!
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
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.Label8, Me.Label11, Me.Label9, Me.Label10, Me.Label7, Me.Label15})
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
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Height = 0.1875!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 6.6875!
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
      Me.Label11.Left = 6.0!
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
      Me.Label9.Left = 5.3125!
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
      Me.Label10.Width = 3.875!
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
      Me.Label15.Left = 4.6875!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label15.Text = "UNIDAD"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.625!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtLiteral, Me.txtTotal, Me.TextBox, Me.lblDevCompraObs, Me.txtDevCompraObs})
      Me.GroupFooter1.Height = 0.6979167!
      Me.GroupFooter1.Name = "GroupFooter1"
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
      Me.txtLiteral.Width = 6.3125!
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
      Me.txtTotal.Height = 0.1875!
      Me.txtTotal.Left = 6.6875!
      Me.txtTotal.Name = "txtTotal"
      Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
      Me.txtTotal.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtTotal.SummaryGroup = "GroupHeader1"
      Me.txtTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtTotal.Text = Nothing
      Me.txtTotal.Top = 0.0!
      Me.txtTotal.Width = 0.8125!
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
      'lblDevCompraObs
      '
      Me.lblDevCompraObs.Border.BottomColor = System.Drawing.Color.Black
      Me.lblDevCompraObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDevCompraObs.Border.LeftColor = System.Drawing.Color.Black
      Me.lblDevCompraObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDevCompraObs.Border.RightColor = System.Drawing.Color.Black
      Me.lblDevCompraObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDevCompraObs.Border.TopColor = System.Drawing.Color.Black
      Me.lblDevCompraObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDevCompraObs.Height = 0.1875!
      Me.lblDevCompraObs.HyperLink = Nothing
      Me.lblDevCompraObs.Left = 0.0!
      Me.lblDevCompraObs.Name = "lblDevCompraObs"
      Me.lblDevCompraObs.Style = "text-align: left; font-weight: bold; font-style: italic; vertical-align: bottom; " & _
          ""
      Me.lblDevCompraObs.Text = "Observaciones"
      Me.lblDevCompraObs.Top = 0.3125!
      Me.lblDevCompraObs.Width = 1.125!
      '
      'txtDevCompraObs
      '
      Me.txtDevCompraObs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDevCompraObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtDevCompraObs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDevCompraObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDevCompraObs.Border.RightColor = System.Drawing.Color.Black
      Me.txtDevCompraObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDevCompraObs.Border.TopColor = System.Drawing.Color.Black
      Me.txtDevCompraObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtDevCompraObs.DataField = "DevCompraObs"
      Me.txtDevCompraObs.Height = 0.1875!
      Me.txtDevCompraObs.Left = 0.0!
      Me.txtDevCompraObs.Name = "txtDevCompraObs"
      Me.txtDevCompraObs.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtDevCompraObs.Text = "DevCompraObs"
      Me.txtDevCompraObs.Top = 0.5!
      Me.txtDevCompraObs.Width = 7.5!
      '
      'rptDevCompraEdit
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
      Me.PrintWidth = 7.489583!
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
      CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).EndInit()
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
      CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).EndInit()
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
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDevCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDevCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Dim mlngNotaId As Long = 0

   Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
      If txtEstadoId.Text = "12" Then
         picAnulado.Visible = True
      End If

      Call NotaFind(ToLong(Me.Fields("TipoNotaId").Value), ToLong(Me.Fields("NotaNro").Value), ToLong(Me.Fields("SucursalId").Value), mlngNotaId)
   End Sub

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      ''Lotes y Series
      If (mlngNotaId > 0) And (ToBool(Me.Fields("ControlLote").Value) Or ToBool(Me.Fields("ControlSerie").Value)) Then
         Dim bool As Boolean
         bool = CargarLotesSeriesSal(ToLong(Me.Fields("ItemId").Value), mlngNotaId, ToBool(Me.Fields("ControlLote").Value), ToBool(Me.Fields("ControlSerie").Value))
         srptLotesSeries.Visible = bool
      Else
         srptLotesSeries.Visible = False
         srptLotesSeries.Height = 0
      End If
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      txtLiteral.Text = CifraLiteral(ToDecimal(txtTotal.Text)) + "  " + UCase(txtMonedaDes.Text)

      If ToStr(txtDevCompraObs.Text) = "" Then
         GroupFooter1.Height = 0.313
         lblDevCompraObs.Height = 0
         txtDevCompraObs.Height = 0
         lblDevCompraObs.Visible = False
         txtDevCompraObs.Visible = False
      End If
   End Sub

   Private Function NotaFind(ByVal lngTipoNotaId As Long, ByVal lngNotaNro As Long, ByVal lngSucursalId As Long, ByRef lngNotaId As Long) As Boolean
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
            .SucursalId = lngSucursalId

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

   Private Function CargarLotesSeriesSal(ByVal lngItemId As Long, ByVal lngNotaId As Long, _
                                ByVal boolLote As Boolean, ByVal boolSerie As Boolean) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim strSeries As String = String.Empty
      CargarLotesSeriesSal = False
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
                        oRow("ItemNroSerieLote") = NroSeriesSalFind(lngItemId, oRow("ItemLoteId"), lngNotaId)
                     Next
                  End If
                  CargarLotesSeriesSal = True
               Else
                  rpSRItemLoteSerie.Detail.Visible = False
               End If

               If boolSerie And (Not CargarLotesSeriesSal) Then
                  strSeries = NroSeriesSalFind(lngItemId, 0, lngNotaId)
                  CargarLotesSeriesSal = True
               Else
                  rpSRItemLoteSerie.GroupFooter.Visible = False
               End If

               If CargarLotesSeriesSal Then
                  rpSRItemLoteSerie.DataSource = .DataSet.Tables(.TableName).DefaultView
                  rpSRItemLoteSerie.txtSeries.Text = strSeries
                  Me.srptLotesSeries.Report = rpSRItemLoteSerie
                  CargarLotesSeriesSal = True
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

   Private Function NroSeriesSalFind(ByVal lngItemId As Long, ByVal lngItemLoteId As Long, ByVal lngNotaId As Long) As String
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oRow As DataRowView
      Dim strNroSeriesDes As String = String.Empty
      NroSeriesSalFind = ""
      Try
         With oItemNroSerie
            .SelectFilter = clsItemNroSerie.SelectFilters.All
            .WhereFilter = clsItemNroSerie.WhereFilters.NotaItemIdSal
            .OrderByFilter = clsItemNroSerie.OrderByFilters.ItemNroSerieId
            .EmpresaId = clsAppInfo.EmpresaId
            .NotaIdSal = lngNotaId
            .ItemId = lngItemId
            .ItemLoteIdSal = lngItemLoteId

            If .Open Then
               ''strNroSeriesDes = "S: "
               For Each oRow In .DataSet.Tables(.TableName).DefaultView
                  strNroSeriesDes &= "- " & ToStr(oRow("ItemNroSerieCod")) & " "
               Next
            End If

            NroSeriesSalFind = strNroSeriesDes
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemNroSerie.Dispose()

      End Try
   End Function

End Class