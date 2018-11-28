Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptPedCompraEditPust
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
   Private Shape2 As DataDynamics.ActiveReports.Shape = Nothing
   Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
   Public lblAlmacenIdOrg As DataDynamics.ActiveReports.Label = Nothing
   Public lblAlmacenIdDes As DataDynamics.ActiveReports.Label = Nothing
   Private Label2 As DataDynamics.ActiveReports.Label = Nothing
   Private Label3 As DataDynamics.ActiveReports.Label = Nothing
   Private Label4 As DataDynamics.ActiveReports.Label = Nothing
   Private Label5 As DataDynamics.ActiveReports.Label = Nothing
   Private Label6 As DataDynamics.ActiveReports.Label = Nothing
   Private Label14 As DataDynamics.ActiveReports.Label = Nothing
   Private TextBox16 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox17 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox19 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox21 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox22 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox23 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox24 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtEstadoId As DataDynamics.ActiveReports.TextBox = Nothing
   Private Shape3 As DataDynamics.ActiveReports.Shape = Nothing
   Private Label8 As DataDynamics.ActiveReports.Label = Nothing
   Private Label11 As DataDynamics.ActiveReports.Label = Nothing
   Private Label9 As DataDynamics.ActiveReports.Label = Nothing
   Private Label10 As DataDynamics.ActiveReports.Label = Nothing
   Private Label7 As DataDynamics.ActiveReports.Label = Nothing
   Private Label15 As DataDynamics.ActiveReports.Label = Nothing
   Private TextBox25 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtItemDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtCantidad As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPrecio As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtImporte As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtLiteral As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblPedCompraObs As DataDynamics.ActiveReports.Label = Nothing
   Private txtPedCompraObs As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageCount As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox = Nothing
   Private Label13 As DataDynamics.ActiveReports.Label = Nothing
   Private Line2 As DataDynamics.ActiveReports.Line = Nothing
   Public lblDate As DataDynamics.ActiveReports.Label = Nothing
   Public lblTime As DataDynamics.ActiveReports.Label = Nothing
   Public lblLogin As DataDynamics.ActiveReports.Label = Nothing
   Private WithEvents txtMontoRec As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtMontoDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtMontoLiq As DataDynamics.ActiveReports.TextBox
   Private WithEvents lblMontoRec As DataDynamics.ActiveReports.Label
   Private WithEvents lblMontoDes As DataDynamics.ActiveReports.Label
   Private WithEvents lblMontoLiq As DataDynamics.ActiveReports.Label
   Private WithEvents Label20 As DataDynamics.ActiveReports.Label
   Private WithEvents txtMontoOrg As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtImporteRec As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtImporteDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label22 As DataDynamics.ActiveReports.Label
   Public WithEvents txtFirma As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label12 As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label16 As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label21 As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedCompraEditPust))
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
      Me.txtItemDes = New DataDynamics.ActiveReports.TextBox
      Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
      Me.txtCantidad = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecio = New DataDynamics.ActiveReports.TextBox
      Me.txtImporte = New DataDynamics.ActiveReports.TextBox
      Me.txtImporteRec = New DataDynamics.ActiveReports.TextBox
      Me.txtImporteDes = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.picAnulado = New DataDynamics.ActiveReports.Picture
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Shape2 = New DataDynamics.ActiveReports.Shape
      Me.lblAlmacenIdOrg = New DataDynamics.ActiveReports.Label
      Me.lblAlmacenIdDes = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox19 = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox23 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox24 = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoId = New DataDynamics.ActiveReports.TextBox
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.Label16 = New DataDynamics.ActiveReports.Label
      Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
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
      Me.Label22 = New DataDynamics.ActiveReports.Label
      Me.Label21 = New DataDynamics.ActiveReports.Label
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.lblPedCompraObs = New DataDynamics.ActiveReports.Label
      Me.txtPedCompraObs = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoRec = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoLiq = New DataDynamics.ActiveReports.TextBox
      Me.lblMontoRec = New DataDynamics.ActiveReports.Label
      Me.lblMontoDes = New DataDynamics.ActiveReports.Label
      Me.lblMontoLiq = New DataDynamics.ActiveReports.Label
      Me.Label20 = New DataDynamics.ActiveReports.Label
      Me.txtMontoOrg = New DataDynamics.ActiveReports.TextBox
      CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporteRec, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporteDes, System.ComponentModel.ISupportInitialize).BeginInit()
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
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
      CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPedCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoRec, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoLiq, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoRec, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoLiq, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoOrg, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox25, Me.txtItemDes, Me.TextBox27, Me.txtCantidad, Me.txtPrecio, Me.txtImporte, Me.txtImporteRec, Me.txtImporteDes})
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
      Me.txtItemDes.Left = 0.8125!
      Me.txtItemDes.Name = "txtItemDes"
      Me.txtItemDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtItemDes.Text = "ItemDes"
      Me.txtItemDes.Top = 0.0!
      Me.txtItemDes.Width = 2.75!
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
      Me.TextBox27.Left = 3.5625!
      Me.TextBox27.Name = "TextBox27"
      Me.TextBox27.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox27.Text = "MedidaDes"
      Me.TextBox27.Top = 0.0!
      Me.TextBox27.Width = 0.625!
      '
      'txtCantidad
      '
      Me.txtCantidad.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCantidad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidad.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCantidad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidad.Border.RightColor = System.Drawing.Color.Black
      Me.txtCantidad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidad.Border.TopColor = System.Drawing.Color.Black
      Me.txtCantidad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidad.DataField = "Cantidad"
      Me.txtCantidad.Height = 0.1875!
      Me.txtCantidad.Left = 4.1875!
      Me.txtCantidad.Name = "txtCantidad"
      Me.txtCantidad.OutputFormat = resources.GetString("txtCantidad.OutputFormat")
      Me.txtCantidad.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCantidad.Text = "Cantidad"
      Me.txtCantidad.Top = 0.0!
      Me.txtCantidad.Width = 0.6875!
      '
      'txtPrecio
      '
      Me.txtPrecio.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPrecio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecio.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPrecio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecio.Border.RightColor = System.Drawing.Color.Black
      Me.txtPrecio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecio.Border.TopColor = System.Drawing.Color.Black
      Me.txtPrecio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecio.DataField = "Precio"
      Me.txtPrecio.Height = 0.1875!
      Me.txtPrecio.Left = 4.875!
      Me.txtPrecio.Name = "txtPrecio"
      Me.txtPrecio.OutputFormat = resources.GetString("txtPrecio.OutputFormat")
      Me.txtPrecio.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrecio.Text = "Precio"
      Me.txtPrecio.Top = 0.0!
      Me.txtPrecio.Width = 0.6875!
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
      Me.txtImporte.Left = 6.6875!
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.OutputFormat = resources.GetString("txtImporte.OutputFormat")
      Me.txtImporte.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtImporte.Text = "Importe"
      Me.txtImporte.Top = 0.0!
      Me.txtImporte.Width = 0.8125!
      '
      'txtImporteRec
      '
      Me.txtImporteRec.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporteRec.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteRec.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporteRec.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteRec.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporteRec.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteRec.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporteRec.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteRec.DataField = "ImporteRec"
      Me.txtImporteRec.Height = 0.1875!
      Me.txtImporteRec.Left = 5.5625!
      Me.txtImporteRec.Name = "txtImporteRec"
      Me.txtImporteRec.OutputFormat = resources.GetString("txtImporteRec.OutputFormat")
      Me.txtImporteRec.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtImporteRec.Text = "ImporteRec"
      Me.txtImporteRec.Top = 0.0!
      Me.txtImporteRec.Width = 0.5625!
      '
      'txtImporteDes
      '
      Me.txtImporteDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporteDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporteDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporteDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporteDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtImporteDes.DataField = "ImporteDes"
      Me.txtImporteDes.Height = 0.1875!
      Me.txtImporteDes.Left = 6.125!
      Me.txtImporteDes.Name = "txtImporteDes"
      Me.txtImporteDes.OutputFormat = resources.GetString("txtImporteDes.OutputFormat")
      Me.txtImporteDes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtImporteDes.Text = "ImporteDes"
      Me.txtImporteDes.Top = 0.0!
      Me.txtImporteDes.Width = 0.5625!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.picAnulado, Me.lblCompany, Me.lblTitle, Me.Label, Me.Label1, Me.Shape2, Me.lblAlmacenIdOrg, Me.lblAlmacenIdDes, Me.Label2, Me.Label3, Me.Label4, Me.Label6, Me.Label14, Me.TextBox16, Me.TextBox17, Me.TextBox19, Me.txtMonedaDes, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.txtEstadoId, Me.Label5, Me.Label12, Me.TextBox4, Me.Label16, Me.TextBox2, Me.Shape1})
      Me.ReportHeader.Height = 1.625!
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
      Me.picAnulado.Width = 5.75!
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
      Me.Shape2.Height = 0.875!
      Me.Shape2.Left = 6.0625!
      Me.Shape2.LineWeight = 2.0!
      Me.Shape2.Name = "Shape2"
      Me.Shape2.RoundingRadius = 9.999999!
      Me.Shape2.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape2.Top = 0.6875!
      Me.Shape2.Width = 1.4375!
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
      Me.Label3.Top = 1.0!
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
      Me.Label4.Left = 6.125!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label4.Text = "Nro. "
      Me.Label4.Top = 0.75!
      Me.Label4.Width = 0.5!
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
      Me.Label6.Left = 6.125!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label6.Text = "Fecha"
      Me.Label6.Top = 1.125!
      Me.Label6.Width = 0.5!
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
      Me.Label14.Top = 0.75!
      Me.Label14.Width = 0.5625!
      '
      'TextBox16
      '
      Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.DataField = "PedCompraNro"
      Me.TextBox16.Height = 0.1875!
      Me.TextBox16.Left = 6.625!
      Me.TextBox16.Name = "TextBox16"
      Me.TextBox16.Style = "font-weight: bold; font-size: 12pt; vertical-align: top; "
      Me.TextBox16.Text = "PedCompraNro"
      Me.TextBox16.Top = 0.75!
      Me.TextBox16.Width = 0.8125!
      '
      'TextBox17
      '
      Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
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
      Me.TextBox17.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox17.Text = "Fecha"
      Me.TextBox17.Top = 1.125!
      Me.TextBox17.Width = 0.8125!
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
      Me.TextBox19.Left = 5.25!
      Me.TextBox19.Name = "TextBox19"
      Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
      Me.TextBox19.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox19.Text = "TipoCambio"
      Me.TextBox19.Top = 1.25!
      Me.TextBox19.Width = 0.6875!
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
      Me.txtMonedaDes.Left = 5.25!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 0.75!
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
      Me.TextBox21.Left = 5.25!
      Me.TextBox21.Name = "TextBox21"
      Me.TextBox21.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox21.Text = "EstadoDes"
      Me.TextBox21.Top = 1.0!
      Me.TextBox21.Width = 0.6875!
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
      Me.TextBox22.DataField = "ProveedorDes"
      Me.TextBox22.Height = 0.1875!
      Me.TextBox22.Left = 0.875!
      Me.TextBox22.Name = "TextBox22"
      Me.TextBox22.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox22.Text = "ProveedorDes"
      Me.TextBox22.Top = 0.75!
      Me.TextBox22.Width = 3.5625!
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
      Me.TextBox23.DataField = "AlmacenDes"
      Me.TextBox23.Height = 0.1875!
      Me.TextBox23.Left = 0.875!
      Me.TextBox23.Name = "TextBox23"
      Me.TextBox23.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox23.Text = "AlmacenDes"
      Me.TextBox23.Top = 1.0!
      Me.TextBox23.Width = 3.5625!
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
      Me.TextBox24.DataField = "PedCompraDes"
      Me.TextBox24.Height = 0.1875!
      Me.TextBox24.Left = 0.875!
      Me.TextBox24.Name = "TextBox24"
      Me.TextBox24.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox24.Text = "PedCompraDes"
      Me.TextBox24.Top = 1.25!
      Me.TextBox24.Width = 3.5625!
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
      Me.Label5.Left = 4.6875!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; "
      Me.Label5.Text = "T.C.        :"
      Me.Label5.Top = 1.25!
      Me.Label5.Width = 0.5625!
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
      Me.Label12.Left = 6.125!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label12.Text = "Orden. "
      Me.Label12.Top = 0.9375!
      Me.Label12.Width = 0.5!
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
      Me.TextBox4.DataField = "PedCompraOrden"
      Me.TextBox4.Height = 0.1875!
      Me.TextBox4.Left = 6.625!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Style = "font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.TextBox4.Text = "PedCompraOrden"
      Me.TextBox4.Top = 0.9375!
      Me.TextBox4.Width = 0.8125!
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
      Me.Label16.Left = 6.125!
      Me.Label16.Name = "Label16"
      Me.Label16.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label16.Text = "Entrega"
      Me.Label16.Top = 1.3125!
      Me.Label16.Width = 0.5!
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
      Me.TextBox2.DataField = "FechaEnt"
      Me.TextBox2.Height = 0.1875!
      Me.TextBox2.Left = 6.625!
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
      Me.TextBox2.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox2.Text = "FechaEnt"
      Me.TextBox2.Top = 1.3125!
      Me.TextBox2.Width = 0.8125!
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
      Me.Shape1.Height = 0.875!
      Me.Shape1.Left = 0.0!
      Me.Shape1.LineWeight = 2.0!
      Me.Shape1.Name = "Shape1"
      Me.Shape1.RoundingRadius = 9.999999!
      Me.Shape1.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape1.Top = 0.6875!
      Me.Shape1.Width = 6.0!
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFirma})
      Me.ReportFooter.Height = 0.7381945!
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
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.Label8, Me.Label11, Me.Label9, Me.Label10, Me.Label7, Me.Label15, Me.Label22, Me.Label21})
      Me.GroupHeader1.Height = 0.2083333!
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
      Me.Label11.Left = 4.875!
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
      Me.Label9.Left = 4.1875!
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
      Me.Label10.Width = 2.75!
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
      Me.Label15.Left = 3.5625!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label15.Text = "UNIDAD"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.625!
      '
      'Label22
      '
      Me.Label22.Border.BottomColor = System.Drawing.Color.Black
      Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label22.Border.LeftColor = System.Drawing.Color.Black
      Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label22.Border.RightColor = System.Drawing.Color.Black
      Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label22.Border.TopColor = System.Drawing.Color.Black
      Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label22.Height = 0.1875!
      Me.Label22.HyperLink = Nothing
      Me.Label22.Left = 6.125!
      Me.Label22.Name = "Label22"
      Me.Label22.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label22.Text = "IMP. DES"
      Me.Label22.Top = 0.0!
      Me.Label22.Width = 0.5625!
      '
      'Label21
      '
      Me.Label21.Border.BottomColor = System.Drawing.Color.Black
      Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Border.LeftColor = System.Drawing.Color.Black
      Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Border.RightColor = System.Drawing.Color.Black
      Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label21.Border.TopColor = System.Drawing.Color.Black
      Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Height = 0.1875!
      Me.Label21.HyperLink = Nothing
      Me.Label21.Left = 5.5625!
      Me.Label21.Name = "Label21"
      Me.Label21.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label21.Text = "IMP. REC"
      Me.Label21.Top = 0.0!
      Me.Label21.Width = 0.5625!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.txtLiteral, Me.lblPedCompraObs, Me.txtPedCompraObs, Me.TextBox, Me.txtMontoRec, Me.txtMontoDes, Me.txtMontoLiq, Me.lblMontoRec, Me.lblMontoDes, Me.lblMontoLiq, Me.Label20, Me.txtMontoOrg})
      Me.GroupFooter1.Height = 1.0625!
      Me.GroupFooter1.Name = "GroupFooter1"
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
      Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 6.5!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
      Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 8pt; vertical" & _
          "-align: middle; "
      Me.TextBox1.SummaryGroup = "GroupHeader1"
      Me.TextBox1.Text = Nothing
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 0.25!
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
      Me.txtLiteral.Width = 5.4375!
      '
      'lblPedCompraObs
      '
      Me.lblPedCompraObs.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPedCompraObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPedCompraObs.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPedCompraObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPedCompraObs.Border.RightColor = System.Drawing.Color.Black
      Me.lblPedCompraObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPedCompraObs.Border.TopColor = System.Drawing.Color.Black
      Me.lblPedCompraObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPedCompraObs.Height = 0.1875!
      Me.lblPedCompraObs.HyperLink = Nothing
      Me.lblPedCompraObs.Left = 0.0!
      Me.lblPedCompraObs.Name = "lblPedCompraObs"
      Me.lblPedCompraObs.Style = "text-align: left; font-weight: bold; font-style: italic; vertical-align: bottom; " & _
          ""
      Me.lblPedCompraObs.Text = "Observaciones"
      Me.lblPedCompraObs.Top = 0.625!
      Me.lblPedCompraObs.Width = 1.125!
      '
      'txtPedCompraObs
      '
      Me.txtPedCompraObs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtPedCompraObs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraObs.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraObs.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtPedCompraObs.DataField = "PedCompraObs"
      Me.txtPedCompraObs.Height = 0.1875!
      Me.txtPedCompraObs.Left = 0.0!
      Me.txtPedCompraObs.Name = "txtPedCompraObs"
      Me.txtPedCompraObs.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPedCompraObs.Text = "PedCompraObs"
      Me.txtPedCompraObs.Top = 0.8125!
      Me.txtPedCompraObs.Width = 7.5!
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
      Me.TextBox.Height = 0.2!
      Me.TextBox.Left = 0.0!
      Me.TextBox.Name = "TextBox"
      Me.TextBox.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: middle; "
      Me.TextBox.Text = "SON :"
      Me.TextBox.Top = 0.0!
      Me.TextBox.Width = 0.375!
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
      Me.txtMontoRec.DataField = "ImporteRec"
      Me.txtMontoRec.Height = 0.1875!
      Me.txtMontoRec.Left = 6.6875!
      Me.txtMontoRec.Name = "txtMontoRec"
      Me.txtMontoRec.OutputFormat = resources.GetString("txtMontoRec.OutputFormat")
      Me.txtMontoRec.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtMontoRec.SummaryGroup = "GroupHeader1"
      Me.txtMontoRec.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoRec.Text = "ImporteRec"
      Me.txtMontoRec.Top = 0.1875!
      Me.txtMontoRec.Width = 0.8125!
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
      Me.txtMontoDes.DataField = "ImporteDes"
      Me.txtMontoDes.Height = 0.1875!
      Me.txtMontoDes.Left = 6.6875!
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.OutputFormat = resources.GetString("txtMontoDes.OutputFormat")
      Me.txtMontoDes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtMontoDes.SummaryGroup = "GroupHeader1"
      Me.txtMontoDes.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoDes.Text = "ImporteDes"
      Me.txtMontoDes.Top = 0.375!
      Me.txtMontoDes.Width = 0.8125!
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
      Me.txtMontoLiq.DataField = "ImporteBru"
      Me.txtMontoLiq.Height = 0.1875!
      Me.txtMontoLiq.Left = 6.6875!
      Me.txtMontoLiq.Name = "txtMontoLiq"
      Me.txtMontoLiq.OutputFormat = resources.GetString("txtMontoLiq.OutputFormat")
      Me.txtMontoLiq.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.txtMontoLiq.SummaryGroup = "GroupHeader1"
      Me.txtMontoLiq.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoLiq.Text = "ImporteBru"
      Me.txtMontoLiq.Top = 0.5625!
      Me.txtMontoLiq.Width = 0.8125!
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
      Me.lblMontoRec.HyperLink = Nothing
      Me.lblMontoRec.Left = 5.8125!
      Me.lblMontoRec.Name = "lblMontoRec"
      Me.lblMontoRec.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.lblMontoRec.Text = "Recargo (+)"
      Me.lblMontoRec.Top = 0.1875!
      Me.lblMontoRec.Width = 0.8125!
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
      Me.lblMontoDes.HyperLink = Nothing
      Me.lblMontoDes.Left = 5.8125!
      Me.lblMontoDes.Name = "lblMontoDes"
      Me.lblMontoDes.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.lblMontoDes.Text = "Descuento (-)"
      Me.lblMontoDes.Top = 0.375!
      Me.lblMontoDes.Width = 0.8125!
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
      Me.lblMontoLiq.HyperLink = Nothing
      Me.lblMontoLiq.Left = 5.8125!
      Me.lblMontoLiq.Name = "lblMontoLiq"
      Me.lblMontoLiq.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.lblMontoLiq.Text = "Total a Pagar"
      Me.lblMontoLiq.Top = 0.5625!
      Me.lblMontoLiq.Width = 0.8125!
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
      Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label20.Height = 0.1875!
      Me.Label20.HyperLink = Nothing
      Me.Label20.Left = 5.8125!
      Me.Label20.Name = "Label20"
      Me.Label20.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label20.Text = "Total"
      Me.Label20.Top = 0.0!
      Me.Label20.Width = 0.8125!
      '
      'txtMontoOrg
      '
      Me.txtMontoOrg.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoOrg.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoOrg.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoOrg.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoOrg.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoOrg.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoOrg.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoOrg.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMontoOrg.DataField = "Importe"
      Me.txtMontoOrg.Height = 0.1875!
      Me.txtMontoOrg.Left = 6.6875!
      Me.txtMontoOrg.Name = "txtMontoOrg"
      Me.txtMontoOrg.OutputFormat = resources.GetString("txtMontoOrg.OutputFormat")
      Me.txtMontoOrg.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 8pt; vertical" & _
          "-align: middle; "
      Me.txtMontoOrg.SummaryGroup = "GroupHeader1"
      Me.txtMontoOrg.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoOrg.Text = "Importe"
      Me.txtMontoOrg.Top = 0.0!
      Me.txtMontoOrg.Width = 0.8125!
      '
      'rptPedCompraEditPust
      '
      Me.MasterReport = False
      OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
          "Catalog=Delfin;Data Source=DESARROLLO"
      OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
      Me.DataSource = OleDBDataSource1
      Me.PageSettings.DefaultPaperSize = False
      Me.PageSettings.Margins.Bottom = 0.3!
      Me.PageSettings.Margins.Left = 0.5!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
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
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporteRec, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporteDes, System.ComponentModel.ISupportInitialize).EndInit()
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
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
      CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPedCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoRec, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoLiq, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoRec, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoLiq, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoOrg, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
      If txtEstadoId.Text = "12" Then
         picAnulado.Visible = True
      End If

      txtCantidad.OutputFormat = DecimalMask()
      txtPrecio.OutputFormat = DecimalMask()
      txtImporteRec.OutputFormat = DecimalMask()
      txtImporteDes.OutputFormat = DecimalMask()
      txtImporte.OutputFormat = DecimalMask()

      txtMontoOrg.OutputFormat = DecimalMask()
      txtMontoRec.OutputFormat = DecimalMask()
      txtMontoDes.OutputFormat = DecimalMask()
      txtMontoLiq.OutputFormat = DecimalMask()

   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      Dim decDesplazo As Decimal = 0
      Dim oPoint As System.Drawing.PointF

      txtLiteral.Text = CifraLiteral(ToDecimal(txtMontoLiq.Text)) + "  " + UCase(txtMonedaDes.Text)

      If ToStr(txtPedCompraObs.Text) = "" Then
         lblPedCompraObs.Height = 0
         txtPedCompraObs.Height = 0
         lblPedCompraObs.Visible = False
         txtPedCompraObs.Visible = False
      End If

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

      oPoint.X = txtPedCompraObs.Location.X
      oPoint.Y = txtPedCompraObs.Location.Y - decDesplazo
      txtPedCompraObs.Location = oPoint

      oPoint.X = lblPedCompraObs.Location.X
      oPoint.Y = lblPedCompraObs.Location.Y - decDesplazo
      lblPedCompraObs.Location = oPoint

      oPoint.X = txtMontoLiq.Location.X
      oPoint.Y = txtMontoLiq.Location.Y - decDesplazo
      txtMontoLiq.Location = oPoint

      GroupFooter1.Height = GroupFooter1.Height - decDesplazo

      txtMontoOrg.Text = ToDecimal(txtMontoOrg.Text)
      txtMontoRec.Text = ToDecimal(txtMontoRec.Text)
      txtMontoDes.Text = ToDecimal(txtMontoDes.Text)
      txtMontoLiq.Text = ToDecimal(txtMontoLiq.Text)

   End Sub

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      Dim strProformaDetDes As String = ToStr(Me.Fields("PedCompraDetDes").Value)

      If (strProformaDetDes.Length > 0) Then
         txtItemDes.Text = txtItemDes.Text + "" + vbCrLf + "" + strProformaDetDes
      End If

      txtCantidad.Text = ToDecimal(txtCantidad.Text)
      txtPrecio.Text = ToDecimal(txtPrecio.Text)
      txtImporteRec.Text = ToDecimal(txtImporteRec.Text)
      txtImporteDes.Text = ToDecimal(txtImporteDes.Text)
      txtImporte.Text = ToDecimal(txtImporte.Text)

   End Sub
End Class