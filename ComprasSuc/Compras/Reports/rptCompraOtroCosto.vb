Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptCompraOtroCosto 
    Inherits DataDynamics.ActiveReports.ActiveReport3

   Dim mdecIva As Decimal = 0
   Dim mdecMonto As Decimal = 0
   Dim mdecMontoEqui As Decimal = 0
   Dim mdecTipoCambio As Decimal = 0

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

   Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
   Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
   Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
   Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
   Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource = Nothing
   Private Label4 As DataDynamics.ActiveReports.Label = Nothing
   Private Label8 As DataDynamics.ActiveReports.Label = Nothing
   Private Label11 As DataDynamics.ActiveReports.Label = Nothing
   Private Label10 As DataDynamics.ActiveReports.Label = Nothing
   Private Label As DataDynamics.ActiveReports.Label = Nothing
   Private Label1 As DataDynamics.ActiveReports.Label = Nothing
   Private Label2 As DataDynamics.ActiveReports.Label = Nothing
   Private Label3 As DataDynamics.ActiveReports.Label = Nothing
   Private Label6 As DataDynamics.ActiveReports.Label = Nothing
   Private txtFecha As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPlanOtroCostoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtCompraOtroCostoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonto As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtFacturaNro As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoIva As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoEqui As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtIva As DataDynamics.ActiveReports.TextBox = Nothing
   Private Line As DataDynamics.ActiveReports.Line = Nothing
   Private txtTotalOtroCostoEqui As DataDynamics.ActiveReports.TextBox = Nothing
   Private Label5 As DataDynamics.ActiveReports.Label = Nothing
   Private txtTotalOtroCosto As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtTotalOtroCostoIva As DataDynamics.ActiveReports.TextBox = Nothing

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCompraOtroCosto))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanOtroCostoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCompraOtroCostoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMonto = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaNro = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoIva = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoEqui = New DataDynamics.ActiveReports.TextBox
      Me.txtIva = New DataDynamics.ActiveReports.TextBox
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.Line = New DataDynamics.ActiveReports.Line
      Me.txtTotalOtroCostoEqui = New DataDynamics.ActiveReports.TextBox
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.txtTotalOtroCosto = New DataDynamics.ActiveReports.TextBox
      Me.txtTotalOtroCostoIva = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanOtroCostoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompraOtroCostoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoIva, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIva, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalOtroCostoEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalOtroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalOtroCostoIva, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFecha, Me.txtPlanOtroCostoDes, Me.txtMonedaDes, Me.txtMonto, Me.txtFacturaNro, Me.txtMontoIva, Me.txtMontoEqui, Me.txtIva, Me.txtCompraOtroCostoDes})
      Me.Detail.Height = 0.1875!
      Me.Detail.Name = "Detail"
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
      Me.txtFecha.Width = 0.6875!
      '
      'txtPlanOtroCostoDes
      '
      Me.txtPlanOtroCostoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanOtroCostoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanOtroCostoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanOtroCostoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanOtroCostoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanOtroCostoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanOtroCostoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanOtroCostoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanOtroCostoDes.DataField = "PlanOtroCostoDes"
      Me.txtPlanOtroCostoDes.Height = 0.1875!
      Me.txtPlanOtroCostoDes.Left = 0.6875!
      Me.txtPlanOtroCostoDes.Name = "txtPlanOtroCostoDes"
      Me.txtPlanOtroCostoDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPlanOtroCostoDes.Text = "PlanOtroCostoDes"
      Me.txtPlanOtroCostoDes.Top = 0.0!
      Me.txtPlanOtroCostoDes.Width = 1.5!
      '
      'txtCompraOtroCostoDes
      '
      Me.txtCompraOtroCostoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompraOtroCostoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraOtroCostoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompraOtroCostoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraOtroCostoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompraOtroCostoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraOtroCostoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompraOtroCostoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompraOtroCostoDes.DataField = "CompraOtroCostoDes"
      Me.txtCompraOtroCostoDes.Height = 0.1875!
      Me.txtCompraOtroCostoDes.Left = 2.1875!
      Me.txtCompraOtroCostoDes.Name = "txtCompraOtroCostoDes"
      Me.txtCompraOtroCostoDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCompraOtroCostoDes.Text = "CompraOtroCostoDes"
      Me.txtCompraOtroCostoDes.Top = 0.0!
      Me.txtCompraOtroCostoDes.Width = 1.5!
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
      Me.txtMonedaDes.Left = 3.6875!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 0.0!
      Me.txtMonedaDes.Width = 0.625!
      '
      'txtMonto
      '
      Me.txtMonto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonto.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonto.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonto.DataField = "Monto"
      Me.txtMonto.Height = 0.1875!
      Me.txtMonto.Left = 4.3125!
      Me.txtMonto.Name = "txtMonto"
      Me.txtMonto.OutputFormat = resources.GetString("txtMonto.OutputFormat")
      Me.txtMonto.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMonto.Text = "Monto"
      Me.txtMonto.Top = 0.0!
      Me.txtMonto.Width = 0.625!
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
      Me.txtFacturaNro.Left = 4.9375!
      Me.txtFacturaNro.Name = "txtFacturaNro"
      Me.txtFacturaNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtFacturaNro.Text = "FacturaNro"
      Me.txtFacturaNro.Top = 0.0!
      Me.txtFacturaNro.Width = 0.625!
      '
      'txtMontoIva
      '
      Me.txtMontoIva.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoIva.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoIva.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoIva.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoIva.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoIva.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoIva.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoIva.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoIva.Height = 0.1875!
      Me.txtMontoIva.Left = 6.1875!
      Me.txtMontoIva.Name = "txtMontoIva"
      Me.txtMontoIva.OutputFormat = resources.GetString("txtMontoIva.OutputFormat")
      Me.txtMontoIva.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoIva.Text = "MontoIva"
      Me.txtMontoIva.Top = 0.0!
      Me.txtMontoIva.Width = 0.625!
      '
      'txtMontoEqui
      '
      Me.txtMontoEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoEqui.Height = 0.1875!
      Me.txtMontoEqui.Left = 6.8125!
      Me.txtMontoEqui.Name = "txtMontoEqui"
      Me.txtMontoEqui.OutputFormat = resources.GetString("txtMontoEqui.OutputFormat")
      Me.txtMontoEqui.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMontoEqui.Text = "MontoEqui"
      Me.txtMontoEqui.Top = 0.0!
      Me.txtMontoEqui.Width = 0.625!
      '
      'txtIva
      '
      Me.txtIva.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIva.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIva.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIva.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIva.Border.RightColor = System.Drawing.Color.Black
      Me.txtIva.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIva.Border.TopColor = System.Drawing.Color.Black
      Me.txtIva.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIva.Height = 0.1875!
      Me.txtIva.Left = 5.5625!
      Me.txtIva.Name = "txtIva"
      Me.txtIva.OutputFormat = resources.GetString("txtIva.OutputFormat")
      Me.txtIva.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtIva.Text = "Iva"
      Me.txtIva.Top = 0.0!
      Me.txtIva.Width = 0.625!
      '
      'PageHeader
      '
      Me.PageHeader.Height = 0.0!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Height = 0.0!
      Me.PageFooter.Name = "PageFooter"
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.Label10, Me.Label1, Me.Label11, Me.Label8, Me.Label2, Me.Label6, Me.Label3, Me.Label4})
      Me.GroupHeader1.Height = 0.2395833!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'Label4
      '
      Me.Label4.Border.BottomColor = System.Drawing.Color.Black
      Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.LeftColor = System.Drawing.Color.Black
      Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.RightColor = System.Drawing.Color.Black
      Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.TopColor = System.Drawing.Color.Black
      Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Height = 0.1875!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 6.8125!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label4.Text = "MTO EQUI"
      Me.Label4.Top = 0.0!
      Me.Label4.Width = 0.625!
      '
      'Label8
      '
      Me.Label8.Border.BottomColor = System.Drawing.Color.Black
      Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.LeftColor = System.Drawing.Color.Black
      Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.RightColor = System.Drawing.Color.Black
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Height = 0.1875!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 4.3125!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label8.Text = "MONTO"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 0.625!
      '
      'Label11
      '
      Me.Label11.Border.BottomColor = System.Drawing.Color.Black
      Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Border.LeftColor = System.Drawing.Color.Black
      Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Border.RightColor = System.Drawing.Color.Black
      Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.TopColor = System.Drawing.Color.Black
      Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Height = 0.1875!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 3.6875!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label11.Text = "MONEDA"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.625!
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
      Me.Label10.Left = 0.6875!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label10.Text = "OTRO COSTO APLICABLE"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 1.5!
      '
      'Label
      '
      Me.Label.Border.BottomColor = System.Drawing.Color.Black
      Me.Label.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label.Border.LeftColor = System.Drawing.Color.Black
      Me.Label.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label.Border.RightColor = System.Drawing.Color.Black
      Me.Label.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.TopColor = System.Drawing.Color.Black
      Me.Label.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label.Height = 0.1875!
      Me.Label.HyperLink = Nothing
      Me.Label.Left = 0.0!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label.Text = "FECHA"
      Me.Label.Top = 0.0!
      Me.Label.Width = 0.6875!
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
      Me.Label1.Left = 2.1875!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label1.Text = "DESCRIPCIÓN"
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 1.5!
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
      Me.Label2.Left = 4.9375!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label2.Text = "FACTURA"
      Me.Label2.Top = 0.0!
      Me.Label2.Width = 0.625!
      '
      'Label3
      '
      Me.Label3.Border.BottomColor = System.Drawing.Color.Black
      Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label3.Border.LeftColor = System.Drawing.Color.Black
      Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label3.Border.RightColor = System.Drawing.Color.Black
      Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Border.TopColor = System.Drawing.Color.Black
      Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label3.Height = 0.1875!
      Me.Label3.HyperLink = Nothing
      Me.Label3.Left = 6.1875!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label3.Text = "MTO - IVA"
      Me.Label3.Top = 0.0!
      Me.Label3.Width = 0.625!
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
      Me.Label6.Left = 5.5625!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label6.Text = "IVA"
      Me.Label6.Top = 0.0!
      Me.Label6.Width = 0.625!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line, Me.txtTotalOtroCostoEqui, Me.Label5, Me.txtTotalOtroCosto, Me.txtTotalOtroCostoIva})
      Me.GroupFooter1.Height = 0.1979167!
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
      Me.Line.Width = 7.4375!
      Me.Line.X1 = 0.0!
      Me.Line.X2 = 7.4375!
      Me.Line.Y1 = 0.0!
      Me.Line.Y2 = 0.0!
      '
      'txtTotalOtroCostoEqui
      '
      Me.txtTotalOtroCostoEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalOtroCostoEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTotalOtroCostoEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalOtroCostoEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCostoEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalOtroCostoEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCostoEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalOtroCostoEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCostoEqui.Height = 0.1875!
      Me.txtTotalOtroCostoEqui.Left = 6.8125!
      Me.txtTotalOtroCostoEqui.Name = "txtTotalOtroCostoEqui"
      Me.txtTotalOtroCostoEqui.OutputFormat = resources.GetString("txtTotalOtroCostoEqui.OutputFormat")
      Me.txtTotalOtroCostoEqui.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtTotalOtroCostoEqui.Text = "TotalOtroCostoEqui"
      Me.txtTotalOtroCostoEqui.Top = 0.0!
      Me.txtTotalOtroCostoEqui.Width = 0.625!
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
      Me.Label5.Left = 4.9375!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label5.Text = "Totales :"
      Me.Label5.Top = 0.0!
      Me.Label5.Width = 0.5625!
      '
      'txtTotalOtroCosto
      '
      Me.txtTotalOtroCosto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalOtroCosto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTotalOtroCosto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalOtroCosto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCosto.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalOtroCosto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCosto.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalOtroCosto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCosto.Height = 0.1875!
      Me.txtTotalOtroCosto.Left = 6.1875!
      Me.txtTotalOtroCosto.Name = "txtTotalOtroCosto"
      Me.txtTotalOtroCosto.OutputFormat = resources.GetString("txtTotalOtroCosto.OutputFormat")
      Me.txtTotalOtroCosto.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtTotalOtroCosto.Text = "TotalOtroCosto"
      Me.txtTotalOtroCosto.Top = 0.0!
      Me.txtTotalOtroCosto.Width = 0.625!
      '
      'txtTotalOtroCostoIva
      '
      Me.txtTotalOtroCostoIva.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalOtroCostoIva.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTotalOtroCostoIva.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalOtroCostoIva.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCostoIva.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalOtroCostoIva.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCostoIva.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalOtroCostoIva.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalOtroCostoIva.Height = 0.1875!
      Me.txtTotalOtroCostoIva.Left = 5.5625!
      Me.txtTotalOtroCostoIva.Name = "txtTotalOtroCostoIva"
      Me.txtTotalOtroCostoIva.OutputFormat = resources.GetString("txtTotalOtroCostoIva.OutputFormat")
      Me.txtTotalOtroCostoIva.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtTotalOtroCostoIva.Text = "TotalOtroCostoIva"
      Me.txtTotalOtroCostoIva.Top = 0.0!
      Me.txtTotalOtroCostoIva.Width = 0.625!
      '
      'rptCompraOtroCosto
      '
      Me.MasterReport = False
      OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
          "Catalog=DelfinNet;Data Source=desarrollo1"
      OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
      Me.DataSource = OleDBDataSource1
      Me.PageSettings.PaperHeight = 11.0!
      Me.PageSettings.PaperWidth = 8.5!
      Me.PrintWidth = 7.4375!
      Me.Sections.Add(Me.PageHeader)
      Me.Sections.Add(Me.GroupHeader1)
      Me.Sections.Add(Me.Detail)
      Me.Sections.Add(Me.GroupFooter1)
      Me.Sections.Add(Me.PageFooter)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                  "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanOtroCostoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCompraOtroCostoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoIva, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIva, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalOtroCostoEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalOtroCosto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalOtroCostoIva, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
      mdecTipoCambio = CompraTipoCambioFind(Me.Fields("CompraId").Value)
   End Sub

   Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
      If Me.Fields("FacturaId").Value = 0 Then
         txtFacturaNro.Text = 0
         txtMontoIva.Text = ToDecStrDos(Me.Fields("Monto").Value)
         txtIva.Text = 0

         If Me.Fields("MonedaId").Value = 1 Then
            txtMontoEqui.Text = ToDecStrDos(Me.Fields("Monto").Value / mdecTipoCambio)
         Else
            txtMontoEqui.Text = ToDecStrDos(Me.Fields("Monto").Value * mdecTipoCambio)
         End If
      Else
         txtFacturaNro.Text = FacturaNroFind(Me.Fields("FacturaId").Value)
         txtMontoIva.Text = ToDecStrDos(Me.Fields("Monto").Value - (Me.Fields("Monto").Value * clsAppInfo.IVA))
         txtIva.Text = ToDecStrDos(Me.Fields("Monto").Value * clsAppInfo.IVA)

         If Me.Fields("MonedaId").Value = 1 Then
            txtMontoEqui.Text = ToDecStrDos(ToDecimal(txtMontoIva.Text) / mdecTipoCambio)
         Else
            txtMontoEqui.Text = ToDecStrDos(ToDecimal(txtMontoIva.Text) * mdecTipoCambio)
         End If
      End If

      mdecIva += ToDecimal(txtIva.Text)
      mdecMonto += ToDecimal(txtMontoIva.Text)
      mdecMontoEqui += ToDecimal(txtMontoEqui.Text)
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      txtTotalOtroCostoIva.Text = ToDecStrDos(mdecIva)
      txtTotalOtroCosto.Text = ToDecStrDos(mdecMonto)
      txtTotalOtroCostoEqui.Text = ToDecStrDos(mdecMontoEqui)
   End Sub

   Private Function FacturaNroFind(ByVal lngFacturaId As Long) As Long
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         FacturaNroFind = 0

         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               Return .FacturaNro
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function CompraTipoCambioFind(ByVal lngCompraId As Long) As Decimal
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         CompraTipoCambioFind = 0

         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               Return .TipoCambio
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oCompra.Dispose()

      End Try
   End Function

End Class