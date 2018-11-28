Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptAnticipoEdit 
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
   Private Label As DataDynamics.ActiveReports.Label
   Private Label1 As DataDynamics.ActiveReports.Label
   Private Shape1 As DataDynamics.ActiveReports.Shape
   Private Shape2 As DataDynamics.ActiveReports.Shape
   Public lblEntregadoA As DataDynamics.ActiveReports.Label
   Public lblPorConcepto As DataDynamics.ActiveReports.Label
   Private Label4 As DataDynamics.ActiveReports.Label
   Private Label5 As DataDynamics.ActiveReports.Label
   Private Label6 As DataDynamics.ActiveReports.Label
   Private txtAnticipoObs As DataDynamics.ActiveReports.TextBox
   Private lblAnticipoObs As DataDynamics.ActiveReports.Label
   Private Label2 As DataDynamics.ActiveReports.Label
   Private Label14 As DataDynamics.ActiveReports.Label
   Private txtLiteral As DataDynamics.ActiveReports.TextBox
   Private TextBox10 As DataDynamics.ActiveReports.TextBox
   Private TextBox11 As DataDynamics.ActiveReports.TextBox
   Private txtMontoAnt As DataDynamics.ActiveReports.TextBox
   Private TextBox14 As DataDynamics.ActiveReports.TextBox
   Private TextBox15 As DataDynamics.ActiveReports.TextBox
   Private TextBox16 As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public WithEvents txtFirma As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtSucursalCod As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label10 As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptAnticipoEdit))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
      Me.Shape2 = New DataDynamics.ActiveReports.Shape
      Me.lblEntregadoA = New DataDynamics.ActiveReports.Label
      Me.lblPorConcepto = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.txtAnticipoObs = New DataDynamics.ActiveReports.TextBox
      Me.lblAnticipoObs = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoAnt = New DataDynamics.ActiveReports.TextBox
      Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.txtFirma = New DataDynamics.ActiveReports.TextBox
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.txtSucursalCod = New DataDynamics.ActiveReports.TextBox
      Me.Label10 = New DataDynamics.ActiveReports.Label
      CType(Me.lblEntregadoA, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPorConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtAnticipoObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblAnticipoObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSucursalCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Shape2, Me.lblEntregadoA, Me.lblPorConcepto, Me.Label4, Me.Label5, Me.Label6, Me.txtAnticipoObs, Me.lblAnticipoObs, Me.Label2, Me.Label14, Me.txtLiteral, Me.TextBox10, Me.TextBox11, Me.txtMontoAnt, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.txtSucursalCod, Me.Label10})
      Me.Detail.Height = 1.708333!
      Me.Detail.Name = "Detail"
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
      Me.Shape1.Top = 0.0!
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
      Me.Shape2.Top = 0.0!
      Me.Shape2.Width = 1.364583!
      '
      'lblEntregadoA
      '
      Me.lblEntregadoA.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEntregadoA.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEntregadoA.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEntregadoA.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEntregadoA.Border.RightColor = System.Drawing.Color.Black
      Me.lblEntregadoA.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEntregadoA.Border.TopColor = System.Drawing.Color.Black
      Me.lblEntregadoA.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEntregadoA.Height = 0.1875!
      Me.lblEntregadoA.HyperLink = Nothing
      Me.lblEntregadoA.Left = 0.0625!
      Me.lblEntregadoA.Name = "lblEntregadoA"
      Me.lblEntregadoA.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblEntregadoA.Text = "Entregado A :"
      Me.lblEntregadoA.Top = 0.0625!
      Me.lblEntregadoA.Width = 1.125!
      '
      'lblPorConcepto
      '
      Me.lblPorConcepto.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPorConcepto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPorConcepto.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPorConcepto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPorConcepto.Border.RightColor = System.Drawing.Color.Black
      Me.lblPorConcepto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPorConcepto.Border.TopColor = System.Drawing.Color.Black
      Me.lblPorConcepto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPorConcepto.Height = 0.1875!
      Me.lblPorConcepto.HyperLink = Nothing
      Me.lblPorConcepto.Left = 0.0625!
      Me.lblPorConcepto.Name = "lblPorConcepto"
      Me.lblPorConcepto.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblPorConcepto.Text = "Por concepto de :"
      Me.lblPorConcepto.Top = 0.3125!
      Me.lblPorConcepto.Width = 1.125!
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
      Me.Label4.Left = 0.0625!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label4.Text = "La Suma de :"
      Me.Label4.Top = 0.5625!
      Me.Label4.Width = 1.125!
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
      Me.Label5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label5.Text = "Nro. "
      Me.Label5.Top = 0.0625!
      Me.Label5.Width = 0.5!
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
      Me.Label6.Top = 0.3125!
      Me.Label6.Width = 0.5!
      '
      'txtAnticipoObs
      '
      Me.txtAnticipoObs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtAnticipoObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtAnticipoObs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtAnticipoObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAnticipoObs.Border.RightColor = System.Drawing.Color.Black
      Me.txtAnticipoObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtAnticipoObs.Border.TopColor = System.Drawing.Color.Black
      Me.txtAnticipoObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtAnticipoObs.DataField = "AnticipoObs"
      Me.txtAnticipoObs.Height = 0.2!
      Me.txtAnticipoObs.Left = 0.0!
      Me.txtAnticipoObs.Name = "txtAnticipoObs"
      Me.txtAnticipoObs.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtAnticipoObs.Text = "AnticipoObs"
      Me.txtAnticipoObs.Top = 1.5!
      Me.txtAnticipoObs.Width = 7.5!
      '
      'lblAnticipoObs
      '
      Me.lblAnticipoObs.Border.BottomColor = System.Drawing.Color.Black
      Me.lblAnticipoObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAnticipoObs.Border.LeftColor = System.Drawing.Color.Black
      Me.lblAnticipoObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAnticipoObs.Border.RightColor = System.Drawing.Color.Black
      Me.lblAnticipoObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAnticipoObs.Border.TopColor = System.Drawing.Color.Black
      Me.lblAnticipoObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblAnticipoObs.Height = 0.25!
      Me.lblAnticipoObs.HyperLink = Nothing
      Me.lblAnticipoObs.Left = 0.0!
      Me.lblAnticipoObs.Name = "lblAnticipoObs"
      Me.lblAnticipoObs.Style = "text-align: left; font-weight: bold; font-style: italic; vertical-align: bottom; " & _
          ""
      Me.lblAnticipoObs.Text = "Observaciones"
      Me.lblAnticipoObs.Top = 1.25!
      Me.lblAnticipoObs.Width = 1.125!
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
      Me.Label2.Left = 4.6875!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Moneda"
      Me.Label2.Top = 0.5625!
      Me.Label2.Width = 0.5!
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
      Me.Label14.Left = 0.0!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label14.Text = "Son :"
      Me.Label14.Top = 0.9375!
      Me.Label14.Width = 0.3125!
      '
      'txtLiteral
      '
      Me.txtLiteral.Border.BottomColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLiteral.Border.LeftColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.RightColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.TopColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Height = 0.1875!
      Me.txtLiteral.Left = 0.375!
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtLiteral.Text = Nothing
      Me.txtLiteral.Top = 0.9375!
      Me.txtLiteral.Width = 7.125!
      '
      'TextBox10
      '
      Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.DataField = "ProveedorDes"
      Me.TextBox10.Height = 0.1875!
      Me.TextBox10.Left = 1.1875!
      Me.TextBox10.Name = "TextBox10"
      Me.TextBox10.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox10.Text = "ProveedorDes"
      Me.TextBox10.Top = 0.0625!
      Me.TextBox10.Width = 4.75!
      '
      'TextBox11
      '
      Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.DataField = "AnticipoDes"
      Me.TextBox11.Height = 0.1875!
      Me.TextBox11.Left = 1.1875!
      Me.TextBox11.Name = "TextBox11"
      Me.TextBox11.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox11.Text = "AnticipoDes"
      Me.TextBox11.Top = 0.3125!
      Me.TextBox11.Width = 4.75!
      '
      'txtMontoAnt
      '
      Me.txtMontoAnt.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMontoAnt.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.DataField = "MontoAnt"
      Me.txtMontoAnt.Height = 0.1875!
      Me.txtMontoAnt.Left = 1.1875!
      Me.txtMontoAnt.Name = "txtMontoAnt"
      Me.txtMontoAnt.OutputFormat = resources.GetString("txtMontoAnt.OutputFormat")
      Me.txtMontoAnt.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.txtMontoAnt.Text = "MontoAnt"
      Me.txtMontoAnt.Top = 0.5625!
      Me.txtMontoAnt.Width = 0.8125!
      '
      'TextBox14
      '
      Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.DataField = "AnticipoNro"
      Me.TextBox14.Height = 0.1875!
      Me.TextBox14.Left = 6.6875!
      Me.TextBox14.Name = "TextBox14"
      Me.TextBox14.Style = "font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.TextBox14.Text = "AnticipoNro"
      Me.TextBox14.Top = 0.0625!
      Me.TextBox14.Width = 0.75!
      '
      'TextBox15
      '
      Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox15.DataField = "Fecha"
      Me.TextBox15.Height = 0.1875!
      Me.TextBox15.Left = 6.6875!
      Me.TextBox15.Name = "TextBox15"
      Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
      Me.TextBox15.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox15.Text = "Fecha"
      Me.TextBox15.Top = 0.3125!
      Me.TextBox15.Width = 0.75!
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
      Me.TextBox16.DataField = "MonedaDes"
      Me.TextBox16.Height = 0.1875!
      Me.TextBox16.Left = 5.1875!
      Me.TextBox16.Name = "TextBox16"
      Me.TextBox16.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox16.Text = "MonedaDes"
      Me.TextBox16.Top = 0.5625!
      Me.TextBox16.Width = 0.75!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Label, Me.Label1})
      Me.ReportHeader.Height = 0.6756945!
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
      Me.lblTitle.Left = 2.0!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.3125!
      Me.lblTitle.Width = 3.5!
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
      Me.Label.Left = 1.25!
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
      Me.Label1.Left = 5.5!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 16pt; vertical" & _
          "-align: middle; "
      Me.Label1.Text = ">>>>>"
      Me.Label1.Top = 0.3125!
      Me.Label1.Width = 0.75!
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
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
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
      Me.Label3.Top = 0.1875!
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
      Me.txtSucursalCod.Left = 6.6875!
      Me.txtSucursalCod.Name = "txtSucursalCod"
      Me.txtSucursalCod.Style = "font-size: 8.25pt; "
      Me.txtSucursalCod.Text = "SucursalCod"
      Me.txtSucursalCod.Top = 0.5625!
      Me.txtSucursalCod.Width = 0.75!
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
      Me.Label10.Top = 0.5625!
      Me.Label10.Width = 0.5!
      '
      'rptAnticipoEdit
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
      CType(Me.lblEntregadoA, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPorConcepto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtAnticipoObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblAnticipoObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSucursalCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
      txtLiteral.Text = CifraLiteral(Me.Fields("MontoAnt").Value) + "  " + UCase(Me.Fields("MonedaDes").Value)

      If ToStr(txtAnticipoObs.Text) = "" Then
         Detail.Height = 1.25
         lblAnticipoObs.Height = 0
         txtAnticipoObs.Height = 0
         lblAnticipoObs.Visible = False
         txtAnticipoObs.Visible = False
      End If
   End Sub

End Class