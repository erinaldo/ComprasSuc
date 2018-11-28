Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptProveedorPorPagar
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
   Private Label10 As DataDynamics.ActiveReports.Label
   Private Label8 As DataDynamics.ActiveReports.Label
   Private Label4 As DataDynamics.ActiveReports.Label
   Private Label5 As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label13 As DataDynamics.ActiveReports.Label
   Private txtProveedorCod As DataDynamics.ActiveReports.TextBox
   Private txtProveedorDes As DataDynamics.ActiveReports.TextBox
   Private txtPrimerMes As DataDynamics.ActiveReports.TextBox
   Private txtSegundoMes As DataDynamics.ActiveReports.TextBox
   Private txtTercerMes As DataDynamics.ActiveReports.TextBox
   Private txtCuartoMes As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Private WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
   Private WithEvents lblSaldo As DataDynamics.ActiveReports.Label
   Private WithEvents txtProveedorId As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label7 As DataDynamics.ActiveReports.Label
   Public WithEvents txtFechaIni As DataDynamics.ActiveReports.TextBox
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptProveedorPorPagar))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtProveedorCod = New DataDynamics.ActiveReports.TextBox
      Me.txtProveedorDes = New DataDynamics.ActiveReports.TextBox
      Me.txtPrimerMes = New DataDynamics.ActiveReports.TextBox
      Me.txtSegundoMes = New DataDynamics.ActiveReports.TextBox
      Me.txtTercerMes = New DataDynamics.ActiveReports.TextBox
      Me.txtCuartoMes = New DataDynamics.ActiveReports.TextBox
      Me.txtTotal = New DataDynamics.ActiveReports.TextBox
      Me.txtProveedorId = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.txtFechaIni = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.lblSaldo = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.txtProveedorCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtProveedorDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrimerMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSegundoMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTercerMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCuartoMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtProveedorId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtProveedorCod, Me.txtProveedorDes, Me.txtPrimerMes, Me.txtSegundoMes, Me.txtTercerMes, Me.txtCuartoMes, Me.txtTotal, Me.txtProveedorId})
      Me.Detail.Height = 0.1875!
      Me.Detail.Name = "Detail"
      '
      'txtProveedorCod
      '
      Me.txtProveedorCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtProveedorCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtProveedorCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtProveedorCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtProveedorCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorCod.DataField = "ProveedorCod"
      Me.txtProveedorCod.Height = 0.1875!
      Me.txtProveedorCod.Left = 0.0!
      Me.txtProveedorCod.Name = "txtProveedorCod"
      Me.txtProveedorCod.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtProveedorCod.Text = "ProveedorCod"
      Me.txtProveedorCod.Top = 0.0!
      Me.txtProveedorCod.Width = 0.75!
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
      Me.txtProveedorDes.Left = 0.75!
      Me.txtProveedorDes.Name = "txtProveedorDes"
      Me.txtProveedorDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtProveedorDes.Text = "ProveedorDes"
      Me.txtProveedorDes.Top = 0.0!
      Me.txtProveedorDes.Width = 2.8125!
      '
      'txtPrimerMes
      '
      Me.txtPrimerMes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPrimerMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrimerMes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPrimerMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrimerMes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPrimerMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrimerMes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPrimerMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPrimerMes.DataField = "PrimerMes"
      Me.txtPrimerMes.Height = 0.1875!
      Me.txtPrimerMes.Left = 3.625!
      Me.txtPrimerMes.Name = "txtPrimerMes"
      Me.txtPrimerMes.OutputFormat = resources.GetString("txtPrimerMes.OutputFormat")
      Me.txtPrimerMes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrimerMes.Text = "1-30 Dias"
      Me.txtPrimerMes.Top = 0.0!
      Me.txtPrimerMes.Width = 0.75!
      '
      'txtSegundoMes
      '
      Me.txtSegundoMes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSegundoMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSegundoMes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSegundoMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSegundoMes.Border.RightColor = System.Drawing.Color.Black
      Me.txtSegundoMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSegundoMes.Border.TopColor = System.Drawing.Color.Black
      Me.txtSegundoMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSegundoMes.DataField = "SegundoMes"
      Me.txtSegundoMes.Height = 0.1875!
      Me.txtSegundoMes.Left = 4.3125!
      Me.txtSegundoMes.Name = "txtSegundoMes"
      Me.txtSegundoMes.OutputFormat = resources.GetString("txtSegundoMes.OutputFormat")
      Me.txtSegundoMes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtSegundoMes.Text = "Precio02"
      Me.txtSegundoMes.Top = 0.0!
      Me.txtSegundoMes.Width = 0.75!
      '
      'txtTercerMes
      '
      Me.txtTercerMes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTercerMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTercerMes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTercerMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTercerMes.Border.RightColor = System.Drawing.Color.Black
      Me.txtTercerMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTercerMes.Border.TopColor = System.Drawing.Color.Black
      Me.txtTercerMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTercerMes.DataField = "TercerMes"
      Me.txtTercerMes.Height = 0.1875!
      Me.txtTercerMes.Left = 5.0625!
      Me.txtTercerMes.Name = "txtTercerMes"
      Me.txtTercerMes.OutputFormat = resources.GetString("txtTercerMes.OutputFormat")
      Me.txtTercerMes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtTercerMes.Text = "Precio03"
      Me.txtTercerMes.Top = 0.0!
      Me.txtTercerMes.Width = 0.75!
      '
      'txtCuartoMes
      '
      Me.txtCuartoMes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCuartoMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCuartoMes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCuartoMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCuartoMes.Border.RightColor = System.Drawing.Color.Black
      Me.txtCuartoMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCuartoMes.Border.TopColor = System.Drawing.Color.Black
      Me.txtCuartoMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCuartoMes.DataField = "CuartoMes"
      Me.txtCuartoMes.Height = 0.1875!
      Me.txtCuartoMes.Left = 5.8125!
      Me.txtCuartoMes.Name = "txtCuartoMes"
      Me.txtCuartoMes.OutputFormat = resources.GetString("txtCuartoMes.OutputFormat")
      Me.txtCuartoMes.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCuartoMes.Text = "+91 Dias"
      Me.txtCuartoMes.Top = 0.0!
      Me.txtCuartoMes.Width = 0.75!
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
      Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.DataField = "Total"
      Me.txtTotal.Height = 0.1875!
      Me.txtTotal.Left = 6.5625!
      Me.txtTotal.Name = "txtTotal"
      Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
      Me.txtTotal.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtTotal.Text = "Total"
      Me.txtTotal.Top = 0.0!
      Me.txtTotal.Width = 0.9375!
      '
      'txtProveedorId
      '
      Me.txtProveedorId.Border.BottomColor = System.Drawing.Color.Black
      Me.txtProveedorId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorId.Border.LeftColor = System.Drawing.Color.Black
      Me.txtProveedorId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorId.Border.RightColor = System.Drawing.Color.Black
      Me.txtProveedorId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorId.Border.TopColor = System.Drawing.Color.Black
      Me.txtProveedorId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtProveedorId.DataField = "ProveedorId"
      Me.txtProveedorId.Height = 0.1875!
      Me.txtProveedorId.Left = 3.0!
      Me.txtProveedorId.Name = "txtProveedorId"
      Me.txtProveedorId.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
      Me.txtProveedorId.Text = "ProveedorId"
      Me.txtProveedorId.Top = 0.0!
      Me.txtProveedorId.Visible = False
      Me.txtProveedorId.Width = 0.5!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label7, Me.txtFechaIni})
      Me.ReportHeader.Height = 1.083333!
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
      Me.Label7.Left = 5.9375!
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
      Me.txtFechaIni.Left = 6.6875!
      Me.txtFechaIni.Name = "txtFechaIni"
      Me.txtFechaIni.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaIni.Text = Nothing
      Me.txtFechaIni.Top = 0.75!
      Me.txtFechaIni.Width = 0.75!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label10, Me.Label8, Me.lblSaldo, Me.Label4, Me.Label5, Me.Label11, Me.Label13})
      Me.PageHeader.Height = 0.1979167!
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
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.0!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Código"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 0.75!
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
      Me.Label8.Left = 0.75!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label8.Text = "Proveedor"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 2.8125!
      '
      'lblSaldo
      '
      Me.lblSaldo.Border.BottomColor = System.Drawing.Color.Black
      Me.lblSaldo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo.Border.LeftColor = System.Drawing.Color.Black
      Me.lblSaldo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldo.Border.RightColor = System.Drawing.Color.Black
      Me.lblSaldo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo.Border.TopColor = System.Drawing.Color.Black
      Me.lblSaldo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo.Height = 0.1875!
      Me.lblSaldo.HyperLink = Nothing
      Me.lblSaldo.Left = 6.5625!
      Me.lblSaldo.Name = "lblSaldo"
      Me.lblSaldo.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblSaldo.Text = "TOTAL"
      Me.lblSaldo.Top = 0.0!
      Me.lblSaldo.Width = 0.9375!
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
      Me.Label4.Left = 3.5625!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label4.Text = "1-30 Días"
      Me.Label4.Top = 0.0!
      Me.Label4.Width = 0.75!
      '
      'Label5
      '
      Me.Label5.Border.BottomColor = System.Drawing.Color.Black
      Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.LeftColor = System.Drawing.Color.Black
      Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.RightColor = System.Drawing.Color.Black
      Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.TopColor = System.Drawing.Color.Black
      Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Height = 0.1875!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 4.3125!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label5.Text = "31-60 Días"
      Me.Label5.Top = 0.0!
      Me.Label5.Width = 0.75!
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
      Me.Label11.Left = 5.0625!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label11.Text = "61-90 Días"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.75!
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
      Me.Label13.Left = 5.8125!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label13.Text = "+91 Días"
      Me.Label13.Top = 0.0!
      Me.Label13.Width = 0.75!
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
      'rptProveedorPorPagar
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
      CType(Me.txtProveedorCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtProveedorDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrimerMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSegundoMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTercerMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCuartoMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtProveedorId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSaldo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub rptProveedorPorPagar_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

   End Sub

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      If ToLong(txtProveedorId.Text) = -2 Then

         Me.txtPrimerMes.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
         Me.txtSegundoMes.Style = "ddo-char-set: 1;text-align: right; font-weight: bold; font-size: 8pt; "
         Me.txtTercerMes.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
         Me.txtCuartoMes.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
         Me.txtTotal.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
      End If
   End Sub
End Class