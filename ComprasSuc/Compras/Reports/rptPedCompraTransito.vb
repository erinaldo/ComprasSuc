Imports System 
Imports System.Drawing 
Imports System.Collections
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptPedCompraTransito
   Inherits DataDynamics.ActiveReports.ActiveReport3
   Private mboolSaldoItem As Boolean

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
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Line1 As DataDynamics.ActiveReports.Line
   Private Label10 As DataDynamics.ActiveReports.Label
   Private Label8 As DataDynamics.ActiveReports.Label
   Public WithEvents lblAlmacen1 As DataDynamics.ActiveReports.Label
   Public WithEvents lblAlmacen2 As DataDynamics.ActiveReports.Label
   Public WithEvents lblAlmacen3 As DataDynamics.ActiveReports.Label
   Private Label13 As DataDynamics.ActiveReports.Label
   Private txtItemCod As DataDynamics.ActiveReports.TextBox
   Private txtItemDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtAlmacen1 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtAlmacen2 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtAlmacen3 As DataDynamics.ActiveReports.TextBox
   Private txtCantidadTotal As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Private WithEvents txtMedidaDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Public WithEvents txtAlmacen4 As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblAlmacen4 As DataDynamics.ActiveReports.Label
   Private WithEvents Label7 As DataDynamics.ActiveReports.Label
   Public WithEvents txtFechaIni As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label9 As DataDynamics.ActiveReports.Label
   Public WithEvents txtFechaFin As DataDynamics.ActiveReports.TextBox
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedCompraTransito))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtItemCod = New DataDynamics.ActiveReports.TextBox
      Me.txtItemDes = New DataDynamics.ActiveReports.TextBox
      Me.txtAlmacen1 = New DataDynamics.ActiveReports.TextBox
      Me.txtAlmacen2 = New DataDynamics.ActiveReports.TextBox
      Me.txtAlmacen3 = New DataDynamics.ActiveReports.TextBox
      Me.txtCantidadTotal = New DataDynamics.ActiveReports.TextBox
      Me.txtMedidaDes = New DataDynamics.ActiveReports.TextBox
      Me.txtAlmacen4 = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.txtFechaIni = New DataDynamics.ActiveReports.TextBox
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.txtFechaFin = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.lblAlmacen1 = New DataDynamics.ActiveReports.Label
      Me.lblAlmacen2 = New DataDynamics.ActiveReports.Label
      Me.lblAlmacen3 = New DataDynamics.ActiveReports.Label
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.lblAlmacen4 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.txtItemCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtAlmacen1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtAlmacen2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtAlmacen3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCantidadTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMedidaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtAlmacen4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacen1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacen2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacen3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAlmacen4, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtItemCod, Me.txtItemDes, Me.txtAlmacen1, Me.txtAlmacen2, Me.txtAlmacen3, Me.txtCantidadTotal, Me.txtMedidaDes, Me.txtAlmacen4})
      Me.Detail.Height = 0.1979167!
      Me.Detail.Name = "Detail"
      '
      'txtItemCod
      '
      Me.txtItemCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtItemCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtItemCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtItemCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtItemCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemCod.DataField = "ItemCod"
      Me.txtItemCod.Height = 0.1875!
      Me.txtItemCod.Left = 0.0!
      Me.txtItemCod.Name = "txtItemCod"
      Me.txtItemCod.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtItemCod.Text = "ItemCod"
      Me.txtItemCod.Top = 0.0!
      Me.txtItemCod.Width = 0.6875!
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
      Me.txtItemDes.Left = 0.6875!
      Me.txtItemDes.Name = "txtItemDes"
      Me.txtItemDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtItemDes.Text = "ItemDes"
      Me.txtItemDes.Top = 0.0!
      Me.txtItemDes.Width = 2.75!
      '
      'txtAlmacen1
      '
      Me.txtAlmacen1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtAlmacen1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtAlmacen1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen1.Border.RightColor = System.Drawing.Color.Black
      Me.txtAlmacen1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen1.Border.TopColor = System.Drawing.Color.Black
      Me.txtAlmacen1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen1.DataField = "Almacen1"
      Me.txtAlmacen1.Height = 0.1875!
      Me.txtAlmacen1.Left = 4.0625!
      Me.txtAlmacen1.Name = "txtAlmacen1"
      Me.txtAlmacen1.OutputFormat = resources.GetString("txtAlmacen1.OutputFormat")
      Me.txtAlmacen1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtAlmacen1.Text = Nothing
      Me.txtAlmacen1.Top = 0.0!
      Me.txtAlmacen1.Width = 0.6875!
      '
      'txtAlmacen2
      '
      Me.txtAlmacen2.Border.BottomColor = System.Drawing.Color.Black
      Me.txtAlmacen2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen2.Border.LeftColor = System.Drawing.Color.Black
      Me.txtAlmacen2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen2.Border.RightColor = System.Drawing.Color.Black
      Me.txtAlmacen2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen2.Border.TopColor = System.Drawing.Color.Black
      Me.txtAlmacen2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen2.DataField = "Almacen2"
      Me.txtAlmacen2.Height = 0.1875!
      Me.txtAlmacen2.Left = 4.75!
      Me.txtAlmacen2.Name = "txtAlmacen2"
      Me.txtAlmacen2.OutputFormat = resources.GetString("txtAlmacen2.OutputFormat")
      Me.txtAlmacen2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtAlmacen2.Text = Nothing
      Me.txtAlmacen2.Top = 0.0!
      Me.txtAlmacen2.Width = 0.6875!
      '
      'txtAlmacen3
      '
      Me.txtAlmacen3.Border.BottomColor = System.Drawing.Color.Black
      Me.txtAlmacen3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen3.Border.LeftColor = System.Drawing.Color.Black
      Me.txtAlmacen3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen3.Border.RightColor = System.Drawing.Color.Black
      Me.txtAlmacen3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen3.Border.TopColor = System.Drawing.Color.Black
      Me.txtAlmacen3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen3.DataField = "Almacen3"
      Me.txtAlmacen3.Height = 0.1875!
      Me.txtAlmacen3.Left = 5.4375!
      Me.txtAlmacen3.Name = "txtAlmacen3"
      Me.txtAlmacen3.OutputFormat = resources.GetString("txtAlmacen3.OutputFormat")
      Me.txtAlmacen3.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtAlmacen3.Text = Nothing
      Me.txtAlmacen3.Top = 0.0!
      Me.txtAlmacen3.Width = 0.6875!
      '
      'txtCantidadTotal
      '
      Me.txtCantidadTotal.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCantidadTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidadTotal.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCantidadTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidadTotal.Border.RightColor = System.Drawing.Color.Black
      Me.txtCantidadTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidadTotal.Border.TopColor = System.Drawing.Color.Black
      Me.txtCantidadTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCantidadTotal.DataField = "CantidadTotal"
      Me.txtCantidadTotal.Height = 0.1875!
      Me.txtCantidadTotal.Left = 6.75!
      Me.txtCantidadTotal.Name = "txtCantidadTotal"
      Me.txtCantidadTotal.OutputFormat = resources.GetString("txtCantidadTotal.OutputFormat")
      Me.txtCantidadTotal.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCantidadTotal.Text = "Precio04"
      Me.txtCantidadTotal.Top = 0.0!
      Me.txtCantidadTotal.Width = 0.75!
      '
      'txtMedidaDes
      '
      Me.txtMedidaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMedidaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMedidaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMedidaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMedidaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMedidaDes.DataField = "MedidaDes"
      Me.txtMedidaDes.Height = 0.1875!
      Me.txtMedidaDes.Left = 3.4375!
      Me.txtMedidaDes.Name = "txtMedidaDes"
      Me.txtMedidaDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtMedidaDes.Text = "MedidaDes"
      Me.txtMedidaDes.Top = 0.0!
      Me.txtMedidaDes.Width = 0.625!
      '
      'txtAlmacen4
      '
      Me.txtAlmacen4.Border.BottomColor = System.Drawing.Color.Black
      Me.txtAlmacen4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen4.Border.LeftColor = System.Drawing.Color.Black
      Me.txtAlmacen4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen4.Border.RightColor = System.Drawing.Color.Black
      Me.txtAlmacen4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen4.Border.TopColor = System.Drawing.Color.Black
      Me.txtAlmacen4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAlmacen4.DataField = "Almacen4"
      Me.txtAlmacen4.Height = 0.1875!
      Me.txtAlmacen4.Left = 6.125!
      Me.txtAlmacen4.Name = "txtAlmacen4"
      Me.txtAlmacen4.OutputFormat = resources.GetString("txtAlmacen4.OutputFormat")
      Me.txtAlmacen4.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtAlmacen4.Text = Nothing
      Me.txtAlmacen4.Top = 0.0!
      Me.txtAlmacen4.Width = 0.625!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label7, Me.txtFechaIni, Me.Label9, Me.txtFechaFin})
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
      'Label7
      '
      Me.Label7.Border.BottomColor = System.Drawing.Color.Black
      Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.LeftColor = System.Drawing.Color.Black
      Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.RightColor = System.Drawing.Color.Black
      Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.TopColor = System.Drawing.Color.Black
      Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Height = 0.1875!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 4.5625!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label7.Text = "Fecha Inicial"
      Me.Label7.Top = 0.75!
      Me.Label7.Width = 0.75!
      '
      'txtFechaIni
      '
      Me.txtFechaIni.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaIni.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaIni.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaIni.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaIni.Height = 0.1875!
      Me.txtFechaIni.Left = 5.3125!
      Me.txtFechaIni.Name = "txtFechaIni"
      Me.txtFechaIni.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaIni.Text = Nothing
      Me.txtFechaIni.Top = 0.75!
      Me.txtFechaIni.Width = 0.625!
      '
      'Label9
      '
      Me.Label9.Border.BottomColor = System.Drawing.Color.Black
      Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.LeftColor = System.Drawing.Color.Black
      Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.RightColor = System.Drawing.Color.Black
      Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.TopColor = System.Drawing.Color.Black
      Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Height = 0.1875!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 6.0625!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label9.Text = "Fecha Final"
      Me.Label9.Top = 0.75!
      Me.Label9.Width = 0.75!
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
      Me.txtFechaFin.Left = 6.8125!
      Me.txtFechaFin.Name = "txtFechaFin"
      Me.txtFechaFin.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaFin.Text = Nothing
      Me.txtFechaFin.Top = 0.75!
      Me.txtFechaFin.Width = 0.625!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label10, Me.Label8, Me.Label1, Me.lblAlmacen1, Me.lblAlmacen2, Me.lblAlmacen3, Me.Label13, Me.lblAlmacen4})
      Me.PageHeader.Height = 0.3854167!
      Me.PageHeader.Name = "PageHeader"
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
      Me.Label10.Height = 0.375!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.0!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Código"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 0.6875!
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
      Me.Label8.Height = 0.375!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 0.6875!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label8.Text = "Ítem"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 3.3125!
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
      Me.Label1.Height = 0.375!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 3.4375!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label1.Text = "Medida"
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 0.625!
      '
      'lblAlmacen1
      '
      Me.lblAlmacen1.Border.BottomColor = System.Drawing.Color.Black
      Me.lblAlmacen1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblAlmacen1.Border.LeftColor = System.Drawing.Color.Black
      Me.lblAlmacen1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacen1.Border.RightColor = System.Drawing.Color.Black
      Me.lblAlmacen1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacen1.Border.TopColor = System.Drawing.Color.Black
      Me.lblAlmacen1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblAlmacen1.Height = 0.375!
      Me.lblAlmacen1.HyperLink = Nothing
      Me.lblAlmacen1.Left = 4.0625!
      Me.lblAlmacen1.Name = "lblAlmacen1"
      Me.lblAlmacen1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblAlmacen1.Text = "Almacen 1"
      Me.lblAlmacen1.Top = 0.0!
      Me.lblAlmacen1.Width = 0.6875!
      '
      'lblAlmacen2
      '
      Me.lblAlmacen2.Border.BottomColor = System.Drawing.Color.Black
      Me.lblAlmacen2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblAlmacen2.Border.LeftColor = System.Drawing.Color.Black
      Me.lblAlmacen2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacen2.Border.RightColor = System.Drawing.Color.Black
      Me.lblAlmacen2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacen2.Border.TopColor = System.Drawing.Color.Black
      Me.lblAlmacen2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblAlmacen2.Height = 0.375!
      Me.lblAlmacen2.HyperLink = Nothing
      Me.lblAlmacen2.Left = 4.75!
      Me.lblAlmacen2.Name = "lblAlmacen2"
      Me.lblAlmacen2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblAlmacen2.Text = "Almacen 2"
      Me.lblAlmacen2.Top = 0.0!
      Me.lblAlmacen2.Width = 0.6875!
      '
      'lblAlmacen3
      '
      Me.lblAlmacen3.Border.BottomColor = System.Drawing.Color.Black
      Me.lblAlmacen3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblAlmacen3.Border.LeftColor = System.Drawing.Color.Black
      Me.lblAlmacen3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacen3.Border.RightColor = System.Drawing.Color.Black
      Me.lblAlmacen3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacen3.Border.TopColor = System.Drawing.Color.Black
      Me.lblAlmacen3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblAlmacen3.Height = 0.375!
      Me.lblAlmacen3.HyperLink = Nothing
      Me.lblAlmacen3.Left = 5.4375!
      Me.lblAlmacen3.Name = "lblAlmacen3"
      Me.lblAlmacen3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblAlmacen3.Text = "Almacen 3"
      Me.lblAlmacen3.Top = 0.0!
      Me.lblAlmacen3.Width = 0.6875!
      '
      'Label13
      '
      Me.Label13.Border.BottomColor = System.Drawing.Color.Black
      Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Border.LeftColor = System.Drawing.Color.Black
      Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.RightColor = System.Drawing.Color.Black
      Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Border.TopColor = System.Drawing.Color.Black
      Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Height = 0.375!
      Me.Label13.HyperLink = Nothing
      Me.Label13.Left = 6.75!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label13.Text = "TOTAL"
      Me.Label13.Top = 0.0!
      Me.Label13.Width = 0.75!
      '
      'lblAlmacen4
      '
      Me.lblAlmacen4.Border.BottomColor = System.Drawing.Color.Black
      Me.lblAlmacen4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblAlmacen4.Border.LeftColor = System.Drawing.Color.Black
      Me.lblAlmacen4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacen4.Border.RightColor = System.Drawing.Color.Black
      Me.lblAlmacen4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAlmacen4.Border.TopColor = System.Drawing.Color.Black
      Me.lblAlmacen4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblAlmacen4.Height = 0.375!
      Me.lblAlmacen4.HyperLink = Nothing
      Me.lblAlmacen4.Left = 6.125!
      Me.lblAlmacen4.Name = "lblAlmacen4"
      Me.lblAlmacen4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblAlmacen4.Text = "Almacen 4"
      Me.lblAlmacen4.Top = 0.0!
      Me.lblAlmacen4.Width = 0.6875!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
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
      'rptPedCompraTransito
      '
      Me.MasterReport = False
      Me.PageSettings.PaperHeight = 11.0!
      Me.PageSettings.PaperWidth = 8.5!
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
      CType(Me.txtItemCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtAlmacen1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtAlmacen2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtAlmacen3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCantidadTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMedidaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtAlmacen4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacen1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacen2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacen3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAlmacen4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private moListaAlmacen As New Queue

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      If moListaAlmacen.Count > 1 Then  '' SI loa Almacen son mas de 4
         Dim decOtros As Decimal = 0
         For Each strAlmacen As String In moListaAlmacen
            decOtros += Me.Fields(strAlmacen).Value
         Next
         txtAlmacen4.Text = ToDecStrDos(decOtros)
      End If
      
   End Sub

   Property ListaAlmacen() As Queue
      Get
         Return moListaAlmacen
      End Get

      Set(ByVal Value As Queue)
         moListaAlmacen = Value
      End Set
   End Property

End Class