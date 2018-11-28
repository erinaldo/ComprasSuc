Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptPedCompraMov 
    Inherits DataDynamics.ActiveReports.ActiveReport3

   Public mboolDetallado As Boolean

   Property Detallado() As Boolean
      Get
         Return mboolDetallado
      End Get

      Set(ByVal Value As Boolean)
         mboolDetallado = Value
      End Set
   End Property

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
   Private lblPedCompraDes As DataDynamics.ActiveReports.Label
   Private Label As DataDynamics.ActiveReports.Label
   Private lblPrecio As DataDynamics.ActiveReports.Label
   Private Label13 As DataDynamics.ActiveReports.Label
   Private Label2 As DataDynamics.ActiveReports.Label
   Private lblCantidad As DataDynamics.ActiveReports.Label
   Private txtPedCompraEsp As DataDynamics.ActiveReports.TextBox
   Private txtFecha As DataDynamics.ActiveReports.TextBox
   Private txtPedCompraDes As DataDynamics.ActiveReports.TextBox
   Private txtCantidad As DataDynamics.ActiveReports.TextBox
   Private txtPrecio As DataDynamics.ActiveReports.TextBox
   Private txtPedCompraMonto As DataDynamics.ActiveReports.TextBox
   Private txtEstadoDes As DataDynamics.ActiveReports.TextBox
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedCompraMov))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtPedCompraEsp = New DataDynamics.ActiveReports.TextBox
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtPedCompraDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCantidad = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecio = New DataDynamics.ActiveReports.TextBox
      Me.txtPedCompraMonto = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoDes = New DataDynamics.ActiveReports.TextBox
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
      Me.lblPedCompraDes = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.lblPrecio = New DataDynamics.ActiveReports.Label
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.lblCantidad = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.txtPedCompraEsp, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPedCompraDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPedCompraEsp, Me.txtFecha, Me.txtPedCompraDes, Me.txtCantidad, Me.txtPrecio, Me.txtPedCompraMonto, Me.txtEstadoDes})
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
      Me.txtPedCompraDes.Left = 1.8125!
      Me.txtPedCompraDes.Name = "txtPedCompraDes"
      Me.txtPedCompraDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPedCompraDes.Text = "PedCompraDes"
      Me.txtPedCompraDes.Top = 0.0!
      Me.txtPedCompraDes.Width = 2.6875!
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
      Me.txtCantidad.Left = 4.5!
      Me.txtCantidad.Name = "txtCantidad"
      Me.txtCantidad.OutputFormat = resources.GetString("txtCantidad.OutputFormat")
      Me.txtCantidad.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCantidad.Text = "Cantidad"
      Me.txtCantidad.Top = 0.0!
      Me.txtCantidad.Width = 0.75!
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
      Me.txtPrecio.Left = 5.25!
      Me.txtPrecio.Name = "txtPrecio"
      Me.txtPrecio.OutputFormat = resources.GetString("txtPrecio.OutputFormat")
      Me.txtPrecio.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrecio.Text = "Precio"
      Me.txtPrecio.Top = 0.0!
      Me.txtPrecio.Width = 0.75!
      '
      'txtPedCompraMonto
      '
      Me.txtPedCompraMonto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraMonto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraMonto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraMonto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraMonto.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraMonto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraMonto.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraMonto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraMonto.DataField = "PedCompraMonto"
      Me.txtPedCompraMonto.Height = 0.1875!
      Me.txtPedCompraMonto.Left = 6.0!
      Me.txtPedCompraMonto.Name = "txtPedCompraMonto"
      Me.txtPedCompraMonto.OutputFormat = resources.GetString("txtPedCompraMonto.OutputFormat")
      Me.txtPedCompraMonto.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPedCompraMonto.Text = "PedCompraMonto"
      Me.txtPedCompraMonto.Top = 0.0!
      Me.txtPedCompraMonto.Width = 0.75!
      '
      'txtEstadoDes
      '
      Me.txtEstadoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEstadoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEstadoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtEstadoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtEstadoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDes.DataField = "EstadoDes"
      Me.txtEstadoDes.Height = 0.1875!
      Me.txtEstadoDes.Left = 6.75!
      Me.txtEstadoDes.Name = "txtEstadoDes"
      Me.txtEstadoDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtEstadoDes.Text = "EstadoDes"
      Me.txtEstadoDes.Top = 0.0!
      Me.txtEstadoDes.Width = 0.75!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label7, Me.txtFechaIni, Me.Label9, Me.txtFechaFin})
      Me.ReportHeader.Height = 1.052083!
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
      Me.Line1.Left = 0.0!
      Me.Line1.LineWeight = 5.0!
      Me.Line1.Name = "Line1"
      Me.Line1.Top = 0.5972219!
      Me.Line1.Width = 7.472222!
      Me.Line1.X1 = 0.0!
      Me.Line1.X2 = 7.472222!
      Me.Line1.Y1 = 0.5972219!
      Me.Line1.Y2 = 0.5972219!
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
      Me.Label7.Left = 4.625!
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
      Me.txtFechaIni.Left = 5.375!
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
      Me.Label9.Left = 6.125!
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
      Me.txtFechaFin.Left = 6.875!
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
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label6, Me.lblPedCompraDes, Me.Label, Me.lblPrecio, Me.Label13, Me.Label2, Me.lblCantidad})
      Me.PageHeader.Height = 0.2388889!
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
      'lblPedCompraDes
      '
      Me.lblPedCompraDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPedCompraDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPedCompraDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPedCompraDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPedCompraDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblPedCompraDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPedCompraDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblPedCompraDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPedCompraDes.Height = 0.1875!
      Me.lblPedCompraDes.HyperLink = Nothing
      Me.lblPedCompraDes.Left = 1.8125!
      Me.lblPedCompraDes.Name = "lblPedCompraDes"
      Me.lblPedCompraDes.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblPedCompraDes.Text = "Descripción"
      Me.lblPedCompraDes.Top = 0.0!
      Me.lblPedCompraDes.Width = 2.6875!
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
      'lblPrecio
      '
      Me.lblPrecio.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPrecio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPrecio.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPrecio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPrecio.Border.RightColor = System.Drawing.Color.Black
      Me.lblPrecio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPrecio.Border.TopColor = System.Drawing.Color.Black
      Me.lblPrecio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPrecio.Height = 0.1875!
      Me.lblPrecio.HyperLink = Nothing
      Me.lblPrecio.Left = 5.25!
      Me.lblPrecio.Name = "lblPrecio"
      Me.lblPrecio.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblPrecio.Text = "Precio"
      Me.lblPrecio.Top = 0.0!
      Me.lblPrecio.Width = 0.75!
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
      Me.Label13.Left = 6.0!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label13.Text = "Importe"
      Me.Label13.Top = 0.0!
      Me.Label13.Width = 0.75!
      '
      'Label2
      '
      Me.Label2.Border.BottomColor = System.Drawing.Color.Black
      Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Border.LeftColor = System.Drawing.Color.Black
      Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.RightColor = System.Drawing.Color.Black
      Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Border.TopColor = System.Drawing.Color.Black
      Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Height = 0.1875!
      Me.Label2.HyperLink = Nothing
      Me.Label2.Left = 6.75!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
          "ont-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Estado"
      Me.Label2.Top = 0.0!
      Me.Label2.Width = 0.75!
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
      Me.lblCantidad.Left = 4.5!
      Me.lblCantidad.Name = "lblCantidad"
      Me.lblCantidad.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCantidad.Text = "Cantidad"
      Me.lblCantidad.Top = 0.0!
      Me.lblCantidad.Width = 0.75!
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
      'rptPedCompraMov
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
      CType(Me.txtPedCompraEsp, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraMonto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPedCompraDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPrecio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCantidad, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint
      If Not mboolDetallado Then
         lblCantidad.Visible = False
         lblPrecio.Visible = False

         txtCantidad.Visible = False
         txtPrecio.Visible = False

         lblPedCompraDes.Width = 4.188
         txtPedCompraDes.Width = 4.188
      End If
   End Sub

End Class