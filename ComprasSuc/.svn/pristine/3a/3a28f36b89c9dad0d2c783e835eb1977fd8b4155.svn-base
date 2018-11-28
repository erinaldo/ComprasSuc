Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptUltimoPrecioCompra
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
   Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
   Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
   Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Line1 As DataDynamics.ActiveReports.Line
   Private Label20 As DataDynamics.ActiveReports.Label
   Private Label7 As DataDynamics.ActiveReports.Label
   Private Label17 As DataDynamics.ActiveReports.Label
   Private Label As DataDynamics.ActiveReports.Label
   Private Label21 As DataDynamics.ActiveReports.Label
   Private Label1 As DataDynamics.ActiveReports.Label
   Private lblPrecioDes As DataDynamics.ActiveReports.Label
   Private Label13 As DataDynamics.ActiveReports.Label
   Private Label14 As DataDynamics.ActiveReports.Label
   Private txtMedidaMin As DataDynamics.ActiveReports.TextBox
   Private txtItemDes As DataDynamics.ActiveReports.TextBox
   Private txtPrecioOrg As DataDynamics.ActiveReports.TextBox
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox
   Private txtMonedaDesVen As DataDynamics.ActiveReports.TextBox
   Private txtPrecioDes As DataDynamics.ActiveReports.TextBox
   Private txtPrecioUPC As DataDynamics.ActiveReports.TextBox
   Private txtPrecioCos As DataDynamics.ActiveReports.TextBox
   Private txtMedidaEqui As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Private WithEvents Label2 As DataDynamics.ActiveReports.Label
   Private WithEvents txtFecha As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtAlmacenDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label4 As DataDynamics.ActiveReports.Label
   Public WithEvents txtFechaFin As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label5 As DataDynamics.ActiveReports.Label
   Private WithEvents txtCompraDetId As DataDynamics.ActiveReports.TextBox
   Private WithEvents Line3 As DataDynamics.ActiveReports.Line
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptUltimoPrecioCompra))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtMedidaMin = New DataDynamics.ActiveReports.TextBox
      Me.txtItemDes = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecioOrg = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDesVen = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecioDes = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecioUPC = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecioCos = New DataDynamics.ActiveReports.TextBox
      Me.txtMedidaEqui = New DataDynamics.ActiveReports.TextBox
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtCompraDetId = New DataDynamics.ActiveReports.TextBox
      Me.Line3 = New DataDynamics.ActiveReports.Line
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.txtAlmacenDes = New DataDynamics.ActiveReports.TextBox
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.txtFechaFin = New DataDynamics.ActiveReports.TextBox
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label20 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label17 = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label21 = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.lblPrecioDes = New DataDynamics.ActiveReports.Label
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.txtMedidaMin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecioOrg, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDesVen, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecioDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecioUPC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecioCos, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMedidaEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompraDetId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtAlmacenDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPrecioDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtMedidaMin, Me.txtItemDes, Me.txtPrecioOrg, Me.txtMonedaDes, Me.txtMonedaDesVen, Me.txtPrecioDes, Me.txtPrecioUPC, Me.txtPrecioCos, Me.txtMedidaEqui, Me.txtFecha, Me.txtCompraDetId, Me.Line3})
      Me.Detail.Height = 0.2083333!
      Me.Detail.Name = "Detail"
      '
      'txtMedidaMin
      '
      Me.txtMedidaMin.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMedidaMin.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaMin.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMedidaMin.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaMin.Border.RightColor = System.Drawing.Color.Black
      Me.txtMedidaMin.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaMin.Border.TopColor = System.Drawing.Color.Black
      Me.txtMedidaMin.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaMin.DataField = "CantidadEqui"
      Me.txtMedidaMin.Height = 0.1875!
      Me.txtMedidaMin.Left = 4.0625!
      Me.txtMedidaMin.Name = "txtMedidaMin"
      Me.txtMedidaMin.OutputFormat = resources.GetString("txtMedidaMin.OutputFormat")
      Me.txtMedidaMin.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMedidaMin.Text = "CantidadEqui"
      Me.txtMedidaMin.Top = 0.0!
      Me.txtMedidaMin.Width = 0.625!
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
      Me.txtItemDes.Left = 1.1875!
      Me.txtItemDes.Name = "txtItemDes"
      Me.txtItemDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtItemDes.Text = "ItemDes"
      Me.txtItemDes.Top = 0.0!
      Me.txtItemDes.Width = 2.25!
      '
      'txtPrecioOrg
      '
      Me.txtPrecioOrg.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPrecioOrg.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioOrg.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPrecioOrg.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioOrg.Border.RightColor = System.Drawing.Color.Black
      Me.txtPrecioOrg.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioOrg.Border.TopColor = System.Drawing.Color.Black
      Me.txtPrecioOrg.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioOrg.DataField = "PrecioOrg"
      Me.txtPrecioOrg.Height = 0.1875!
      Me.txtPrecioOrg.Left = 3.4375!
      Me.txtPrecioOrg.Name = "txtPrecioOrg"
      Me.txtPrecioOrg.OutputFormat = resources.GetString("txtPrecioOrg.OutputFormat")
      Me.txtPrecioOrg.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrecioOrg.Text = "PrecioOrg"
      Me.txtPrecioOrg.Top = 0.0!
      Me.txtPrecioOrg.Width = 0.625!
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
      Me.txtMonedaDes.Left = 0.625!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 0.0!
      Me.txtMonedaDes.Width = 0.5625!
      '
      'txtMonedaDesVen
      '
      Me.txtMonedaDesVen.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonedaDesVen.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDesVen.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonedaDesVen.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDesVen.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonedaDesVen.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDesVen.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonedaDesVen.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDesVen.DataField = "PrecioEqui"
      Me.txtMonedaDesVen.Height = 0.1875!
      Me.txtMonedaDesVen.Left = 5.25!
      Me.txtMonedaDesVen.Name = "txtMonedaDesVen"
      Me.txtMonedaDesVen.OutputFormat = resources.GetString("txtMonedaDesVen.OutputFormat")
      Me.txtMonedaDesVen.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMonedaDesVen.Text = "PrecioEqui"
      Me.txtMonedaDesVen.Top = 0.0!
      Me.txtMonedaDesVen.Width = 0.625!
      '
      'txtPrecioDes
      '
      Me.txtPrecioDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPrecioDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPrecioDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPrecioDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPrecioDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioDes.DataField = "PrecioDes"
      Me.txtPrecioDes.Height = 0.1875!
      Me.txtPrecioDes.Left = 5.875!
      Me.txtPrecioDes.Name = "txtPrecioDes"
      Me.txtPrecioDes.OutputFormat = resources.GetString("txtPrecioDes.OutputFormat")
      Me.txtPrecioDes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrecioDes.Text = "PrecioDes"
      Me.txtPrecioDes.Top = 0.0!
      Me.txtPrecioDes.Width = 0.5!
      '
      'txtPrecioUPC
      '
      Me.txtPrecioUPC.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPrecioUPC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioUPC.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPrecioUPC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioUPC.Border.RightColor = System.Drawing.Color.Black
      Me.txtPrecioUPC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioUPC.Border.TopColor = System.Drawing.Color.Black
      Me.txtPrecioUPC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrecioUPC.DataField = "PrecioRec"
      Me.txtPrecioUPC.Height = 0.1875!
      Me.txtPrecioUPC.Left = 6.375!
      Me.txtPrecioUPC.Name = "txtPrecioUPC"
      Me.txtPrecioUPC.OutputFormat = resources.GetString("txtPrecioUPC.OutputFormat")
      Me.txtPrecioUPC.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrecioUPC.Text = "PrecioRec"
      Me.txtPrecioUPC.Top = 0.0!
      Me.txtPrecioUPC.Width = 0.5!
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
      Me.txtPrecioCos.Left = 6.875!
      Me.txtPrecioCos.Name = "txtPrecioCos"
      Me.txtPrecioCos.OutputFormat = resources.GetString("txtPrecioCos.OutputFormat")
      Me.txtPrecioCos.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrecioCos.Text = "PrecioCos"
      Me.txtPrecioCos.Top = 0.0!
      Me.txtPrecioCos.Width = 0.625!
      '
      'txtMedidaEqui
      '
      Me.txtMedidaEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMedidaEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMedidaEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtMedidaEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtMedidaEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaEqui.DataField = "MedidaDesEqui"
      Me.txtMedidaEqui.Height = 0.1875!
      Me.txtMedidaEqui.Left = 4.6875!
      Me.txtMedidaEqui.Name = "txtMedidaEqui"
      Me.txtMedidaEqui.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtMedidaEqui.Text = "MedidaEqui"
      Me.txtMedidaEqui.Top = 0.0!
      Me.txtMedidaEqui.Width = 0.5625!
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
      Me.txtFecha.Left = 0.0!
      Me.txtFecha.Name = "txtFecha"
      Me.txtFecha.OutputFormat = resources.GetString("txtFecha.OutputFormat")
      Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtFecha.Text = "Fecha"
      Me.txtFecha.Top = 0.0!
      Me.txtFecha.Width = 0.625!
      '
      'txtCompraDetId
      '
      Me.txtCompraDetId.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompraDetId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraDetId.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompraDetId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraDetId.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompraDetId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraDetId.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompraDetId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraDetId.DataField = "CompraDetId"
      Me.txtCompraDetId.Height = 0.1875!
      Me.txtCompraDetId.Left = 2.6875!
      Me.txtCompraDetId.Name = "txtCompraDetId"
      Me.txtCompraDetId.OutputFormat = resources.GetString("txtCompraDetId.OutputFormat")
      Me.txtCompraDetId.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCompraDetId.Text = "CompraDetId"
      Me.txtCompraDetId.Top = 0.0!
      Me.txtCompraDetId.Visible = False
      Me.txtCompraDetId.Width = 0.6875!
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
      Me.Line3.Left = 0.0!
      Me.Line3.LineWeight = 1.0!
      Me.Line3.Name = "Line3"
      Me.Line3.Top = 0.1875!
      Me.Line3.Width = 7.5!
      Me.Line3.X1 = 0.0!
      Me.Line3.X2 = 7.5!
      Me.Line3.Y1 = 0.1875!
      Me.Line3.Y2 = 0.1875!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.txtAlmacenDes, Me.Label4, Me.txtFechaFin, Me.Label5})
      Me.ReportHeader.Height = 1.03125!
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
      Me.Line1.Left = 0.03472221!
      Me.Line1.LineWeight = 5.0!
      Me.Line1.Name = "Line1"
      Me.Line1.Top = 0.5972219!
      Me.Line1.Width = 7.4375!
      Me.Line1.X1 = 0.03472221!
      Me.Line1.X2 = 7.472222!
      Me.Line1.Y1 = 0.5972219!
      Me.Line1.Y2 = 0.5972219!
      '
      'txtAlmacenDes
      '
      Me.txtAlmacenDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtAlmacenDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtAlmacenDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtAlmacenDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacenDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtAlmacenDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtAlmacenDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtAlmacenDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtAlmacenDes.Height = 0.1875!
      Me.txtAlmacenDes.Left = 4.3125!
      Me.txtAlmacenDes.Name = "txtAlmacenDes"
      Me.txtAlmacenDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtAlmacenDes.Text = Nothing
      Me.txtAlmacenDes.Top = 0.6875!
      Me.txtAlmacenDes.Width = 2.25!
      '
      'Label4
      '
      Me.Label4.Border.BottomColor = System.Drawing.Color.Black
      Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.LeftColor = System.Drawing.Color.Black
      Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.RightColor = System.Drawing.Color.Black
      Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.TopColor = System.Drawing.Color.Black
      Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Height = 0.1875!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 3.5625!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label4.Text = "Almacén"
      Me.Label4.Top = 0.6875!
      Me.Label4.Width = 0.75!
      '
      'txtFechaFin
      '
      Me.txtFechaFin.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaFin.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaFin.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaFin.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaFin.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaFin.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaFin.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaFin.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaFin.Height = 0.1875!
      Me.txtFechaFin.Left = 6.875!
      Me.txtFechaFin.Name = "txtFechaFin"
      Me.txtFechaFin.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaFin.Text = Nothing
      Me.txtFechaFin.Top = 0.6875!
      Me.txtFechaFin.Width = 0.625!
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
      Me.Label5.Left = 6.6875!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label5.Text = "Al"
      Me.Label5.Top = 0.6875!
      Me.Label5.Width = 0.1875!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label20, Me.Label7, Me.Label17, Me.Label, Me.Label21, Me.Label1, Me.lblPrecioDes, Me.Label13, Me.Label14, Me.Label2})
      Me.PageHeader.Height = 0.2083333!
      Me.PageHeader.Name = "PageHeader"
      '
      'Label20
      '
      Me.Label20.Border.BottomColor = System.Drawing.Color.Black
      Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label20.Border.LeftColor = System.Drawing.Color.Black
      Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Border.RightColor = System.Drawing.Color.Black
      Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Border.TopColor = System.Drawing.Color.Black
      Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label20.Height = 0.1875!
      Me.Label20.HyperLink = Nothing
      Me.Label20.Left = 4.0625!
      Me.Label20.Name = "Label20"
      Me.Label20.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label20.Text = "2da Cant."
      Me.Label20.Top = 0.0!
      Me.Label20.Width = 0.625!
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
      Me.Label7.Left = 4.6875!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label7.Text = "2da Med."
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 0.625!
      '
      'Label17
      '
      Me.Label17.Border.BottomColor = System.Drawing.Color.Black
      Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label17.Border.LeftColor = System.Drawing.Color.Black
      Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.RightColor = System.Drawing.Color.Black
      Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.TopColor = System.Drawing.Color.Black
      Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label17.Height = 0.1875!
      Me.Label17.HyperLink = Nothing
      Me.Label17.Left = 1.1875!
      Me.Label17.Name = "Label17"
      Me.Label17.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
          "ont-size: 8pt; vertical-align: middle; "
      Me.Label17.Text = "Descripción Ítem"
      Me.Label17.Top = 0.0!
      Me.Label17.Width = 2.25!
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
      Me.Label.Left = 3.4375!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label.Text = "P. Compra"
      Me.Label.Top = 0.0!
      Me.Label.Width = 0.625!
      '
      'Label21
      '
      Me.Label21.Border.BottomColor = System.Drawing.Color.Black
      Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label21.Border.LeftColor = System.Drawing.Color.Black
      Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Border.RightColor = System.Drawing.Color.Black
      Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label21.Border.TopColor = System.Drawing.Color.Black
      Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label21.Height = 0.1875!
      Me.Label21.HyperLink = Nothing
      Me.Label21.Left = 0.625!
      Me.Label21.Name = "Label21"
      Me.Label21.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label21.Text = "Moneda"
      Me.Label21.Top = 0.0!
      Me.Label21.Width = 0.5625!
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
      Me.Label1.Left = 5.25!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label1.Text = "2do Pre."
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 0.6354166!
      '
      'lblPrecioDes
      '
      Me.lblPrecioDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPrecioDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPrecioDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPrecioDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPrecioDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblPrecioDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPrecioDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblPrecioDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPrecioDes.Height = 0.1875!
      Me.lblPrecioDes.HyperLink = Nothing
      Me.lblPrecioDes.Left = 5.875!
      Me.lblPrecioDes.Name = "lblPrecioDes"
      Me.lblPrecioDes.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblPrecioDes.Text = "P. Desc."
      Me.lblPrecioDes.Top = 0.0!
      Me.lblPrecioDes.Width = 0.5!
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
      Me.Label13.Left = 6.375!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label13.Text = "P. Rec."
      Me.Label13.Top = 0.0!
      Me.Label13.Width = 0.5!
      '
      'Label14
      '
      Me.Label14.Border.BottomColor = System.Drawing.Color.Black
      Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label14.Border.LeftColor = System.Drawing.Color.Black
      Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.RightColor = System.Drawing.Color.Black
      Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label14.Border.TopColor = System.Drawing.Color.Black
      Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label14.Height = 0.1875!
      Me.Label14.HyperLink = Nothing
      Me.Label14.Left = 6.875!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label14.Text = "P. Costo"
      Me.Label14.Top = 0.0!
      Me.Label14.Width = 0.625!
      '
      'Label2
      '
      Me.Label2.Border.BottomColor = System.Drawing.Color.Black
      Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Border.LeftColor = System.Drawing.Color.Black
      Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Border.RightColor = System.Drawing.Color.Black
      Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.TopColor = System.Drawing.Color.Black
      Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Height = 0.1875!
      Me.Label2.HyperLink = Nothing
      Me.Label2.Left = 0.0!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label2.Text = "Fecha"
      Me.Label2.Top = 0.0!
      Me.Label2.Width = 0.625!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.375!
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
      Me.Line2.Left = 0.02083335!
      Me.Line2.LineWeight = 3.0!
      Me.Line2.Name = "Line2"
      Me.Line2.Top = 0.125!
      Me.Line2.Width = 7.5!
      Me.Line2.X1 = 0.02083335!
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
      Me.lblLogin.Top = 0.1875!
      Me.lblLogin.Width = 2.0!
      '
      'rptUltimoPrecioCompra
      '
      Me.MasterReport = False
      OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
          "Catalog=DelfinNet;Data Source=DESARROLLO1"
      OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
      Me.DataSource = OleDBDataSource1
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
      Me.PrintWidth = 7.5!
      Me.Sections.Add(Me.ReportHeader)
      Me.Sections.Add(Me.PageHeader)
      Me.Sections.Add(Me.Detail)
      Me.Sections.Add(Me.PageFooter)
      Me.Sections.Add(Me.ReportFooter)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                  "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
      CType(Me.txtMedidaMin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecioOrg, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDesVen, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecioDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecioUPC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecioCos, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMedidaEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCompraDetId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtAlmacenDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPrecioDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format

      If ToLong(txtCompraDetId.Text) = -1 Then
         txtItemDes.Style = "ddo-char-set: 1; font-weight: bold;  font-size: 9pt; "
         txtItemDes.Text = "   " + txtItemDes.Text
         txtMonedaDes.Style = "ddo-char-set: 1; font-weight: bold;  font-size: 7pt; "
         Line3.Visible = True

      Else
         Line3.Visible = False
         txtItemDes.Style = "ddo-char-set: 1; font-size: 8pt; "
         txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      End If

   End Sub
End Class