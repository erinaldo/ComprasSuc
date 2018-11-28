Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptVentaPorSucursal
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
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
    Public lblCompany As DataDynamics.ActiveReports.Label
    Public lblTitle As DataDynamics.ActiveReports.Label
    Private Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    Public WithEvents txtPageCount As DataDynamics.ActiveReports.TextBox
    Public WithEvents txtPageNOfM As DataDynamics.ActiveReports.TextBox
    Public WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Public WithEvents lblDate As DataDynamics.ActiveReports.Label
    Public WithEvents lblTime As DataDynamics.ActiveReports.Label
    Public WithEvents lblLogin As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Codigo As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Public WithEvents txtClienteDes As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Public WithEvents txtFechaFin As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents txtMontoOrg As DataDynamics.ActiveReports.TextBox
    Public WithEvents txtFechaIni As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptVentaPorSucursal))
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Codigo = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.txtMontoOrg = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
        Me.lblCompany = New DataDynamics.ActiveReports.Label
        Me.lblTitle = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.txtClienteDes = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.txtFechaIni = New DataDynamics.ActiveReports.TextBox
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.txtFechaFin = New DataDynamics.ActiveReports.TextBox
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
        Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.lblDate = New DataDynamics.ActiveReports.Label
        Me.lblTime = New DataDynamics.ActiveReports.Label
        Me.lblLogin = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoOrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClienteDes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Codigo, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox6, Me.txtMontoOrg, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox5})
        Me.Detail.Height = 0.2076389!
        Me.Detail.Name = "Detail"
        '
        'Codigo
        '
        Me.Codigo.Border.BottomColor = System.Drawing.Color.Black
        Me.Codigo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Codigo.Border.LeftColor = System.Drawing.Color.Black
        Me.Codigo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Codigo.Border.RightColor = System.Drawing.Color.Black
        Me.Codigo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Codigo.Border.TopColor = System.Drawing.Color.Black
        Me.Codigo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Codigo.DataField = "ItemCod"
        Me.Codigo.Height = 0.1875!
        Me.Codigo.Left = 0.45!
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Style = "font-size: 8pt; "
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Top = 0.0!
        Me.Codigo.Width = 0.6!
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
        Me.TextBox1.DataField = "ItemDes"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 1.05!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox1.Text = "Codigo"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 1.45!
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
        Me.TextBox2.DataField = "MedidaDes"
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 2.5!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox2.Text = "Codigo"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.7!
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
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "ProveedorCod"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 3.2!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox3.Text = "Codigo"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.6!
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
        Me.TextBox4.DataField = "ProveedorDes"
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 3.8!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox4.Text = "Codigo"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 1.45!
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
        Me.TextBox5.DataField = "CompraNro"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 0.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox5.Text = "Codigo"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.45!
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
        Me.TextBox6.DataField = "CentroCostoDes"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 5.25!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox6.Text = "Codigo"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 1.45!
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
        Me.txtMontoOrg.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMontoOrg.DataField = "Cantidad"
        Me.txtMontoOrg.Height = 0.1875!
        Me.txtMontoOrg.Left = 7.3!
        Me.txtMontoOrg.Name = "txtMontoOrg"
        Me.txtMontoOrg.OutputFormat = resources.GetString("txtMontoOrg.OutputFormat")
        Me.txtMontoOrg.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.txtMontoOrg.Text = "MontoOrg"
        Me.txtMontoOrg.Top = 0.0!
        Me.txtMontoOrg.Width = 0.7!
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
        Me.TextBox7.DataField = "PrecioOrg"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 8.0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.TextBox7.Text = "MontoOrg"
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.7!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.DataField = "Importe"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 8.7!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.TextBox8.Text = "MontoOrg"
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.7!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.DataField = "CantidadPed"
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 6.7!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.TextBox9.Text = "MontoOrg"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.6!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.DataField = "CompraObs"
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 9.4!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: left; font-size: 8pt; "
        Me.TextBox10.Text = "Codigo"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.6!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label12, Me.txtClienteDes, Me.Label1, Me.txtFechaIni, Me.Label9, Me.txtFechaFin})
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
        Me.lblCompany.Height = 0.35!
        Me.lblCompany.HyperLink = Nothing
        Me.lblCompany.Left = 0.1!
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 8pt; vertical-" & _
            "align: middle; "
        Me.lblCompany.Text = ""
        Me.lblCompany.Top = 0.0625!
        Me.lblCompany.Width = 9.8!
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
        Me.lblTitle.Top = 0.4895833!
        Me.lblTitle.Width = 10.0!
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
        Me.Line1.Left = 0.03472222!
        Me.Line1.LineWeight = 5.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.753472!
        Me.Line1.Width = 9.965278!
        Me.Line1.X1 = 0.03472222!
        Me.Line1.X2 = 10.0!
        Me.Line1.Y1 = 0.753472!
        Me.Line1.Y2 = 0.753472!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 1.2!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
            "tical-align: middle; "
        Me.Label12.Text = "Moneda"
        Me.Label12.Top = 0.8020833!
        Me.Label12.Width = 0.5!
        '
        'txtClienteDes
        '
        Me.txtClienteDes.Border.BottomColor = System.Drawing.Color.Black
        Me.txtClienteDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtClienteDes.Border.LeftColor = System.Drawing.Color.Black
        Me.txtClienteDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtClienteDes.Border.RightColor = System.Drawing.Color.Black
        Me.txtClienteDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtClienteDes.Border.TopColor = System.Drawing.Color.Black
        Me.txtClienteDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtClienteDes.Height = 0.1875!
        Me.txtClienteDes.Left = 1.7!
        Me.txtClienteDes.Name = "txtClienteDes"
        Me.txtClienteDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
        Me.txtClienteDes.Text = Nothing
        Me.txtClienteDes.Top = 0.8020833!
        Me.txtClienteDes.Width = 2.0!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.75!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
            "tical-align: middle; "
        Me.Label1.Text = "Fecha Inicial"
        Me.Label1.Top = 0.8020833!
        Me.Label1.Width = 0.75!
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
        Me.txtFechaIni.Left = 6.5!
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.OutputFormat = resources.GetString("txtFechaIni.OutputFormat")
        Me.txtFechaIni.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
        Me.txtFechaIni.Text = Nothing
        Me.txtFechaIni.Top = 0.8020833!
        Me.txtFechaIni.Width = 0.8!
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
        Me.Label9.Left = 7.75!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
            "tical-align: middle; "
        Me.Label9.Text = "Fecha Final"
        Me.Label9.Top = 0.8020833!
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
        Me.txtFechaFin.Left = 8.5!
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.OutputFormat = resources.GetString("txtFechaFin.OutputFormat")
        Me.txtFechaFin.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
        Me.txtFechaFin.Text = Nothing
        Me.txtFechaFin.Top = 0.802!
        Me.txtFechaFin.Width = 0.8!
        '
        'ReportFooter
        '
        Me.ReportFooter.Height = 0.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label2, Me.Label11, Me.Label13, Me.Label4, Me.Label14, Me.Label15, Me.Label16, Me.Label10})
        Me.PageHeader.Height = 0.1979167!
        Me.PageHeader.Name = "PageHeader"
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
        Me.Label5.Left = 0.45!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
            "ont-size: 8pt; vertical-align: middle; "
        Me.Label5.Text = "Cod. Prod."
        Me.Label5.Top = 0.0!
        Me.Label5.Width = 0.6!
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
        Me.Label6.Left = 1.05!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
            "ont-size: 8pt; vertical-align: middle; "
        Me.Label6.Text = "Producto"
        Me.Label6.Top = 0.0!
        Me.Label6.Width = 1.45!
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
        Me.Label7.Left = 2.5!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
            "ont-size: 8pt; vertical-align: middle; "
        Me.Label7.Text = "Medida"
        Me.Label7.Top = 0.0!
        Me.Label7.Width = 0.7!
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
        Me.Label8.Left = 3.2!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
            "ont-size: 8pt; vertical-align: middle; "
        Me.Label8.Text = "Cod. Prov."
        Me.Label8.Top = 0.0!
        Me.Label8.Width = 0.6!
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
        Me.Label2.Left = 3.8!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
            "ont-size: 8pt; vertical-align: middle; "
        Me.Label2.Text = "Proveedor"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 1.45!
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
        Me.Label11.Left = 5.25!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
            "ont-size: 8pt; vertical-align: middle; "
        Me.Label11.Text = "Centro de Costo"
        Me.Label11.Top = 0.0!
        Me.Label11.Width = 1.45!
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
        Me.Label13.Left = 7.3!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
            " font-size: 8pt; vertical-align: middle; "
        Me.Label13.Text = "Cant. Comp."
        Me.Label13.Top = 0.0!
        Me.Label13.Width = 0.7!
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
        Me.Label4.Left = 8.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
            " font-size: 8pt; vertical-align: middle; "
        Me.Label4.Text = "Prec. Uni."
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 0.7!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 8.7!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
            " font-size: 8pt; vertical-align: middle; "
        Me.Label14.Text = "Importe"
        Me.Label14.Top = 0.0!
        Me.Label14.Width = 0.7!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 6.7!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
            " font-size: 8pt; vertical-align: middle; "
        Me.Label15.Text = "Cant. Ped."
        Me.Label15.Top = 0.0!
        Me.Label15.Width = 0.6!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 9.4!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
            " font-size: 8pt; vertical-align: middle; "
        Me.Label16.Text = "Obs."
        Me.Label16.Top = 0.0!
        Me.Label16.Width = 0.6!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
        Me.PageFooter.Height = 0.3222222!
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
        Me.txtPageCount.Left = 9.5625!
        Me.txtPageCount.Name = "txtPageCount"
        Me.txtPageCount.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
        Me.txtPageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.txtPageCount.Text = "PageCount"
        Me.txtPageCount.Top = 0.0625!
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
        Me.txtPageNOfM.Left = 8.875!
        Me.txtPageNOfM.Name = "txtPageNOfM"
        Me.txtPageNOfM.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.txtPageNOfM.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtPageNOfM.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.txtPageNOfM.Text = "PageNumber"
        Me.txtPageNOfM.Top = 0.0625!
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
        Me.Label3.Left = 9.322917!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
        Me.Label3.Text = "de"
        Me.Label3.Top = 0.0625!
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
        Me.Line2.Top = 0.03125!
        Me.Line2.Width = 9.979!
        Me.Line2.X1 = 0.02083333!
        Me.Line2.X2 = 9.999833!
        Me.Line2.Y1 = 0.03125!
        Me.Line2.Y2 = 0.03125!
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
        Me.lblDate.Top = 0.07291666!
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
        Me.lblTime.Top = 0.07291666!
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
        Me.lblLogin.Top = 0.07291666!
        Me.lblLogin.Width = 2.0!
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
        Me.Label10.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
            "ont-size: 8pt; vertical-align: middle; "
        Me.Label10.Text = "Nro."
        Me.Label10.Top = 0.0!
        Me.Label10.Width = 0.45!
        '
        'rptVentaPorSucursal
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.3!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperName = "Custom paper"
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 9.99292!
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
        CType(Me.Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoOrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClienteDes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class