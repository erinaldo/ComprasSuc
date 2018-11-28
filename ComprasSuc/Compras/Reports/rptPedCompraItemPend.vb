Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptPedCompraItemPend
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
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Line1 As DataDynamics.ActiveReports.Line
   Private Label7 As DataDynamics.ActiveReports.Label
   Public txtFechaIni As DataDynamics.ActiveReports.TextBox
   Private Label9 As DataDynamics.ActiveReports.Label
   Public txtFechaFin As DataDynamics.ActiveReports.TextBox
   Private Label6 As DataDynamics.ActiveReports.Label
   Private lblPedVentaDes As DataDynamics.ActiveReports.Label
   Private Label As DataDynamics.ActiveReports.Label
   Private lblCantidad As DataDynamics.ActiveReports.Label
   Private lblDescuento As DataDynamics.ActiveReports.Label
   Private Label2 As DataDynamics.ActiveReports.Label
   Private lblImporte As DataDynamics.ActiveReports.Label
   Private txtPedCompraEsp As DataDynamics.ActiveReports.TextBox
   Private txtPedCompraDes As DataDynamics.ActiveReports.TextBox
   Private txtFecha As DataDynamics.ActiveReports.TextBox
   Private txtMedidaDes As DataDynamics.ActiveReports.TextBox
   Private txtCantidad As DataDynamics.ActiveReports.TextBox
   Private txtSaldo As DataDynamics.ActiveReports.TextBox
   Private txtProveedorDes As DataDynamics.ActiveReports.TextBox
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Private WithEvents txtPedCompraOrden As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtPageCount As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label3 As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedCompraItemPend))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtPedCompraEsp = New DataDynamics.ActiveReports.TextBox
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtMedidaDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCantidad = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldo = New DataDynamics.ActiveReports.TextBox
      Me.txtProveedorDes = New DataDynamics.ActiveReports.TextBox
      Me.txtPedCompraOrden = New DataDynamics.ActiveReports.TextBox
      Me.txtPedCompraDes = New DataDynamics.ActiveReports.TextBox
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
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.lblCantidad = New DataDynamics.ActiveReports.Label
      Me.lblDescuento = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.lblImporte = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.lblPedVentaDes = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      CType(Me.txtPedCompraEsp, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMedidaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtProveedorDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraOrden, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblImporte, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPedVentaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPedCompraEsp, Me.txtFecha, Me.txtMedidaDes, Me.txtCantidad, Me.txtSaldo, Me.txtProveedorDes, Me.txtPedCompraOrden, Me.txtPedCompraDes})
      Me.Detail.Height = 0.1875!
      Me.Detail.Name = "Detail"
      '
      'txtPedCompraEsp
      '
      Me.txtPedCompraEsp.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraEsp.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraEsp.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraEsp.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraEsp.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraEsp.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraEsp.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraEsp.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraEsp.DataField = "PedCompraEsp"
      Me.txtPedCompraEsp.Height = 0.1875!
      Me.txtPedCompraEsp.Left = 0.0!
      Me.txtPedCompraEsp.Name = "txtPedCompraEsp"
      Me.txtPedCompraEsp.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPedCompraEsp.Text = "PedCompraEsp"
      Me.txtPedCompraEsp.Top = 0.0!
      Me.txtPedCompraEsp.Width = 1.0!
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
      Me.txtFecha.Left = 1.0!
      Me.txtFecha.Name = "txtFecha"
      Me.txtFecha.OutputFormat = resources.GetString("txtFecha.OutputFormat")
      Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtFecha.Text = "Fecha"
      Me.txtFecha.Top = 0.0!
      Me.txtFecha.Width = 0.8125!
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
      Me.txtMedidaDes.Left = 7.260088!
      Me.txtMedidaDes.Name = "txtMedidaDes"
      Me.txtMedidaDes.OutputFormat = resources.GetString("txtMedidaDes.OutputFormat")
      Me.txtMedidaDes.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtMedidaDes.Text = "Medida"
      Me.txtMedidaDes.Top = 0.0!
      Me.txtMedidaDes.Width = 0.8333333!
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
      Me.txtCantidad.Left = 8.094734!
      Me.txtCantidad.Name = "txtCantidad"
      Me.txtCantidad.OutputFormat = resources.GetString("txtCantidad.OutputFormat")
      Me.txtCantidad.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCantidad.Text = "Cantidad"
      Me.txtCantidad.Top = 0.0!
      Me.txtCantidad.Width = 0.9479167!
      '
      'txtSaldo
      '
      Me.txtSaldo.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo.DataField = "Saldo"
      Me.txtSaldo.Height = 0.1875!
      Me.txtSaldo.Left = 9.041667!
      Me.txtSaldo.Name = "txtSaldo"
      Me.txtSaldo.OutputFormat = resources.GetString("txtSaldo.OutputFormat")
      Me.txtSaldo.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtSaldo.Text = "Saldo"
      Me.txtSaldo.Top = 0.0!
      Me.txtSaldo.Width = 0.9375!
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
      Me.txtProveedorDes.Left = 2.635417!
      Me.txtProveedorDes.Name = "txtProveedorDes"
      Me.txtProveedorDes.Style = "ddo-char-set: 1; font-style: normal; font-size: 8pt; "
      Me.txtProveedorDes.Text = "ProveedorDes"
      Me.txtProveedorDes.Top = 0.0!
      Me.txtProveedorDes.Width = 2.0!
      '
      'txtPedCompraOrden
      '
      Me.txtPedCompraOrden.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraOrden.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraOrden.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraOrden.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraOrden.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraOrden.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraOrden.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraOrden.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraOrden.DataField = "PedCompraOrden"
      Me.txtPedCompraOrden.Height = 0.1875!
      Me.txtPedCompraOrden.Left = 1.8125!
      Me.txtPedCompraOrden.Name = "txtPedCompraOrden"
      Me.txtPedCompraOrden.OutputFormat = resources.GetString("txtPedCompraOrden.OutputFormat")
      Me.txtPedCompraOrden.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPedCompraOrden.Text = "PedCompraOrden"
      Me.txtPedCompraOrden.Top = 0.0!
      Me.txtPedCompraOrden.Width = 0.8125!
      '
      'txtPedCompraDes
      '
      Me.txtPedCompraDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraDes.DataField = "PedCompraDes"
      Me.txtPedCompraDes.Height = 0.1875!
      Me.txtPedCompraDes.Left = 4.625!
      Me.txtPedCompraDes.Name = "txtPedCompraDes"
      Me.txtPedCompraDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPedCompraDes.Text = "PedCompraDes"
      Me.txtPedCompraDes.Top = 0.0!
      Me.txtPedCompraDes.Width = 2.625!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label7, Me.txtFechaIni, Me.Label9, Me.txtFechaFin})
      Me.ReportHeader.Height = 1.040972!
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
      Me.lblCompany.Width = 9.875!
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
      Me.lblTitle.Width = 9.979167!
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
      Me.Line1.LineWeight = 5.0!
      Me.Line1.Name = "Line1"
      Me.Line1.Top = 0.59375!
      Me.Line1.Width = 9.979167!
      Me.Line1.X1 = 0.0!
      Me.Line1.X2 = 9.979167!
      Me.Line1.Y1 = 0.59375!
      Me.Line1.Y2 = 0.59375!
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
      Me.Label7.Left = 6.927083!
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
      Me.txtFechaIni.Left = 7.677083!
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
      Me.Label9.Left = 8.4375!
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
      Me.txtFechaFin.Left = 9.1875!
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
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label6, Me.Label, Me.lblCantidad, Me.lblDescuento, Me.Label2, Me.lblImporte, Me.Label1, Me.lblPedVentaDes})
      Me.PageHeader.Height = 0.21875!
      Me.PageHeader.Name = "PageHeader"
      '
      'Label6
      '
      Me.Label6.Border.BottomColor = System.Drawing.Color.Black
      Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.LeftColor = System.Drawing.Color.Black
      Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.RightColor = System.Drawing.Color.Black
      Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.TopColor = System.Drawing.Color.Black
      Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Height = 0.1875!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 0.0!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Especificación"
      Me.Label6.Top = 0.0!
      Me.Label6.Width = 1.0!
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
      Me.Label.Left = 1.0!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label.Text = "Fecha"
      Me.Label.Top = 0.0!
      Me.Label.Width = 0.8125!
      '
      'lblCantidad
      '
      Me.lblCantidad.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCantidad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCantidad.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCantidad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCantidad.Border.RightColor = System.Drawing.Color.Black
      Me.lblCantidad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCantidad.Border.TopColor = System.Drawing.Color.Black
      Me.lblCantidad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCantidad.Height = 0.1875!
      Me.lblCantidad.HyperLink = Nothing
      Me.lblCantidad.Left = 8.09375!
      Me.lblCantidad.Name = "lblCantidad"
      Me.lblCantidad.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCantidad.Text = "Cantidad"
      Me.lblCantidad.Top = 0.0!
      Me.lblCantidad.Width = 0.9479167!
      '
      'lblDescuento
      '
      Me.lblDescuento.Border.BottomColor = System.Drawing.Color.Black
      Me.lblDescuento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDescuento.Border.LeftColor = System.Drawing.Color.Black
      Me.lblDescuento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDescuento.Border.RightColor = System.Drawing.Color.Black
      Me.lblDescuento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDescuento.Border.TopColor = System.Drawing.Color.Black
      Me.lblDescuento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDescuento.Height = 0.1875!
      Me.lblDescuento.HyperLink = Nothing
      Me.lblDescuento.Left = 9.041667!
      Me.lblDescuento.Name = "lblDescuento"
      Me.lblDescuento.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblDescuento.Text = "Saldo"
      Me.lblDescuento.Top = 0.0!
      Me.lblDescuento.Width = 0.9479167!
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
      Me.Label2.Left = 2.635417!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
          "ont-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Proveedor"
      Me.Label2.Top = 0.0!
      Me.Label2.Width = 2.0!
      '
      'lblImporte
      '
      Me.lblImporte.Border.BottomColor = System.Drawing.Color.Black
      Me.lblImporte.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblImporte.Border.LeftColor = System.Drawing.Color.Black
      Me.lblImporte.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblImporte.Border.RightColor = System.Drawing.Color.Black
      Me.lblImporte.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblImporte.Border.TopColor = System.Drawing.Color.Black
      Me.lblImporte.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblImporte.Height = 0.1875!
      Me.lblImporte.HyperLink = Nothing
      Me.lblImporte.Left = 7.260417!
      Me.lblImporte.Name = "lblImporte"
      Me.lblImporte.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.lblImporte.Text = "Medida"
      Me.lblImporte.Top = 0.0!
      Me.lblImporte.Width = 0.8333333!
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
      Me.Label1.Left = 1.8125!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label1.Text = "Nro. Orden"
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 0.8125!
      '
      'lblPedVentaDes
      '
      Me.lblPedVentaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPedVentaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPedVentaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPedVentaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPedVentaDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblPedVentaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPedVentaDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblPedVentaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPedVentaDes.Height = 0.1875!
      Me.lblPedVentaDes.HyperLink = Nothing
      Me.lblPedVentaDes.Left = 4.625984!
      Me.lblPedVentaDes.Name = "lblPedVentaDes"
      Me.lblPedVentaDes.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblPedVentaDes.Text = "Descripción"
      Me.lblPedVentaDes.Top = 0.0!
      Me.lblPedVentaDes.Width = 2.625!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin, Me.txtPageCount, Me.txtPageNOfM, Me.Label3})
      Me.PageFooter.Height = 0.3645833!
      Me.PageFooter.Name = "PageFooter"
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
      Me.Line2.Width = 9.958336!
      Me.Line2.X1 = 0.02083333!
      Me.Line2.X2 = 9.979169!
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
      Me.txtPageCount.Left = 9.596457!
      Me.txtPageCount.Name = "txtPageCount"
      Me.txtPageCount.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
      Me.txtPageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageCount.Text = "PageCount"
      Me.txtPageCount.Top = 0.1722441!
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
      Me.txtPageNOfM.Left = 8.907481!
      Me.txtPageNOfM.Name = "txtPageNOfM"
      Me.txtPageNOfM.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPageNOfM.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
      Me.txtPageNOfM.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageNOfM.Text = "PageNumber"
      Me.txtPageNOfM.Top = 0.1722441!
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
      Me.Label3.Left = 9.350394!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.Label3.Text = "de"
      Me.Label3.Top = 0.1722441!
      Me.Label3.Width = 0.1875!
      '
      'rptPedCompraItemPend
      '
      Me.MasterReport = False
      Me.PageSettings.Margins.Bottom = 0.5!
      Me.PageSettings.Margins.Left = 0.5!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
      Me.PageSettings.PaperHeight = 11.0!
      Me.PageSettings.PaperWidth = 8.5!
      Me.PrintWidth = 10.00394!
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
      CType(Me.txtPedCompraEsp, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMedidaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtProveedorDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraOrden, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCantidad, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDescuento, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblImporte, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPedVentaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      If ToLong(Me.Fields("PedCompraId").Value) = -1 Then
         'txtFecha.Text = ToStr(Me.Fields("FechaCompra").Value)
         txtPedCompraOrden.Text = ToStr(Me.Fields("ItemCod").Value)
         txtProveedorDes.Text = ToStr(Me.Fields("ItemDes").Value)
         txtPedCompraDes.Text = ToStr(Me.Fields("PedCompraDetDes").Value)

         Me.txtPedCompraEsp.Style = "ddo-char-set: 1; font-size: 8pt;"
         Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt;"
         Me.txtPedCompraOrden.Style = "ddo-char-set: 1; font-size: 8pt;"
         Me.txtProveedorDes.Style = "ddo-char-set: 1; font-size: 8pt; "
         Me.txtPedCompraDes.Style = "ddo-char-set: 1; font-size: 8pt;"
         Me.txtMedidaDes.Style = "ddo-char-set: 1;  text-align: center; font-size: 8pt;"
         Me.txtCantidad.Style = "ddo-char-set: 1;  text-align: right; font-size: 8pt;"
         Me.txtSaldo.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt;"

      ElseIf ToLong(Me.Fields("PedCompraId").Value) = 0 Then
         txtFecha.Text = ToStr(Me.Fields("CompraFecha").Value)
         txtPedCompraOrden.Text = ""
         txtProveedorDes.Text = ToStr(Me.Fields("CompraProveedorDes").Value)
         txtPedCompraDes.Text = ""
         txtMedidaDes.Text = ""

         Me.txtPedCompraEsp.Style = "ddo-char-set: 1; font-style: italic; font-size: 7pt; "
         Me.txtFecha.Style = "ddo-char-set: 1; font-style: italic; font-size: 7pt;"
         Me.txtPedCompraOrden.Style = "ddo-char-set: 1; font-style: italic; font-size: 7pt;"
         Me.txtProveedorDes.Style = "ddo-char-set: 1; font-style: italic; font-size: 7pt; "
         Me.txtPedCompraDes.Style = "ddo-char-set: 1; font-style: italic; font-size: 7pt"
         Me.txtMedidaDes.Style = "ddo-char-set: 1;  text-align: center;  font-style: italic; font-size: 7pt;"
         Me.txtCantidad.Style = "ddo-char-set: 1;  text-align: right;  font-style: italic; font-size: 7pt;"
         Me.txtSaldo.Style = "ddo-char-set: 1; text-align: right;  font-style: italic; font-size: 7pt;"
      Else
         Me.txtPedCompraEsp.Style = "ddo-char-set: 1; font-size: 8pt; font-weight: bold;"
         Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt; font-weight: bold;"
         Me.txtPedCompraOrden.Style = "ddo-char-set: 1; font-size: 8pt; font-weight: bold;"
         Me.txtProveedorDes.Style = "ddo-char-set: 1; font-size: 8pt; font-weight: bold;"
         Me.txtPedCompraDes.Style = "ddo-char-set: 1;  font-size: 8pt; font-weight: bold;"
         Me.txtMedidaDes.Style = "ddo-char-set: 1;  text-align: center; font-size: 8pt; font-weight: bold;"
         Me.txtCantidad.Style = "ddo-char-set: 1;  text-align: right; font-size: 8pt; font-weight: bold;"
         Me.txtSaldo.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-weight: bold;"
      End If
   End Sub
End Class