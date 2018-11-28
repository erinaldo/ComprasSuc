Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptPedCompraEditBolland
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
   Public lblTitle As DataDynamics.ActiveReports.Label = Nothing
   Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
   Private lblContacto As DataDynamics.ActiveReports.Label = Nothing
   Private lblCargo As DataDynamics.ActiveReports.Label = Nothing
   Private Label2 As DataDynamics.ActiveReports.Label = Nothing
   Private txtContactoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPedCompraNro As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtFecha As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtTipoCambio As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtEstadoId As DataDynamics.ActiveReports.TextBox = Nothing
   Private Shape3 As DataDynamics.ActiveReports.Shape = Nothing
   Private Label11 As DataDynamics.ActiveReports.Label = Nothing
   Private Label9 As DataDynamics.ActiveReports.Label = Nothing
   Private Label10 As DataDynamics.ActiveReports.Label = Nothing
   Private Label7 As DataDynamics.ActiveReports.Label = Nothing
   Private Label15 As DataDynamics.ActiveReports.Label = Nothing
   Private txtItemNro As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtItemDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox28 As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPrecio As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtLiteral As DataDynamics.ActiveReports.TextBox = Nothing
   Public WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
   Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
   Private TextBox4 As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblMontoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoDes As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblMontoRec As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblMontoAnt As DataDynamics.ActiveReports.TextBox = Nothing
   Private lblMontoLiq As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoRec As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoAnt As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMontoLiq As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtMonedaId As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageCount As DataDynamics.ActiveReports.TextBox = Nothing
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox = Nothing
   Private Label13 As DataDynamics.ActiveReports.Label = Nothing
   Private Line2 As DataDynamics.ActiveReports.Line = Nothing
   Public lblDate As DataDynamics.ActiveReports.Label = Nothing
   Public lblTime As DataDynamics.ActiveReports.Label = Nothing
   Public lblLogin As DataDynamics.ActiveReports.Label = Nothing
   Public WithEvents txtFirma As DataDynamics.ActiveReports.TextBox
   Private WithEvents Shape6 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape7 As DataDynamics.ActiveReports.Shape
   Public WithEvents txtIsoDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtProveedorDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents Shape9 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape8 As DataDynamics.ActiveReports.Shape
   Private WithEvents Shape11 As DataDynamics.ActiveReports.Shape
   Public WithEvents txtCiudadDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtMoneda As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label3 As DataDynamics.ActiveReports.Label
   Private WithEvents txtEmail As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label12 As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label5 As DataDynamics.ActiveReports.Label
   Private WithEvents txtMarcaDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label8 As DataDynamics.ActiveReports.Label
   Friend WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
   Friend WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
   Private WithEvents txtPedCompraDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents lblFechaEnt As DataDynamics.ActiveReports.Label
   Private WithEvents txtFechaEnt As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label23 As DataDynamics.ActiveReports.Label
   Private WithEvents txtPedCompraNro2 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label19 As DataDynamics.ActiveReports.Label
   Private WithEvents txtTelefono As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtCargo As DataDynamics.ActiveReports.TextBox
   Public WithEvents picLogo As DataDynamics.ActiveReports.Picture
   Private WithEvents Shape4 As DataDynamics.ActiveReports.Shape
   Public WithEvents lblEmpresaDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblEmpresaRUC As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblFax As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblTelefono As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblDireccion As DataDynamics.ActiveReports.TextBox
   Friend WithEvents GroupHeader3 As DataDynamics.ActiveReports.GroupHeader
   Friend WithEvents GroupFooter3 As DataDynamics.ActiveReports.GroupFooter
   Private WithEvents Line4 As DataDynamics.ActiveReports.Line
   Private WithEvents txtPedCompraObs As DataDynamics.ActiveReports.TextBox

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedCompraEditBolland))
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtItemDes = New DataDynamics.ActiveReports.TextBox
      Me.txtItemNro = New DataDynamics.ActiveReports.TextBox
      Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
      Me.txtPrecio = New DataDynamics.ActiveReports.TextBox
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.txtMarcaDes = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.Shape4 = New DataDynamics.ActiveReports.Shape
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
      Me.picAnulado = New DataDynamics.ActiveReports.Picture
      Me.txtCargo = New DataDynamics.ActiveReports.TextBox
      Me.lblTelefono = New DataDynamics.ActiveReports.TextBox
      Me.Shape6 = New DataDynamics.ActiveReports.Shape
      Me.Shape8 = New DataDynamics.ActiveReports.Shape
      Me.txtProveedorDes = New DataDynamics.ActiveReports.TextBox
      Me.Shape7 = New DataDynamics.ActiveReports.Shape
      Me.txtIsoDes = New DataDynamics.ActiveReports.TextBox
      Me.Shape9 = New DataDynamics.ActiveReports.Shape
      Me.txtCiudadDes = New DataDynamics.ActiveReports.TextBox
      Me.txtContactoDes = New DataDynamics.ActiveReports.TextBox
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.lblContacto = New DataDynamics.ActiveReports.Label
      Me.lblCargo = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.txtPedCompraNro = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtTipoCambio = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoId = New DataDynamics.ActiveReports.TextBox
      Me.Shape11 = New DataDynamics.ActiveReports.Shape
      Me.txtMoneda = New DataDynamics.ActiveReports.TextBox
      Me.picLogo = New DataDynamics.ActiveReports.Picture
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.txtEmail = New DataDynamics.ActiveReports.TextBox
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.Label23 = New DataDynamics.ActiveReports.Label
      Me.txtPedCompraNro2 = New DataDynamics.ActiveReports.TextBox
      Me.Label19 = New DataDynamics.ActiveReports.Label
      Me.txtTelefono = New DataDynamics.ActiveReports.TextBox
      Me.lblEmpresaDes = New DataDynamics.ActiveReports.TextBox
      Me.lblEmpresaRUC = New DataDynamics.ActiveReports.TextBox
      Me.lblFax = New DataDynamics.ActiveReports.TextBox
      Me.lblDireccion = New DataDynamics.ActiveReports.TextBox
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
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.lblMontoRec = New DataDynamics.ActiveReports.TextBox
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.txtTotal = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.lblMontoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoDes = New DataDynamics.ActiveReports.TextBox
      Me.lblMontoAnt = New DataDynamics.ActiveReports.TextBox
      Me.lblMontoLiq = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoRec = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoAnt = New DataDynamics.ActiveReports.TextBox
      Me.txtMontoLiq = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaId = New DataDynamics.ActiveReports.TextBox
      Me.Line4 = New DataDynamics.ActiveReports.Line
      Me.txtPedCompraObs = New DataDynamics.ActiveReports.TextBox
      Me.lblFechaEnt = New DataDynamics.ActiveReports.Label
      Me.txtFechaEnt = New DataDynamics.ActiveReports.TextBox
      Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader
      Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter
      Me.txtPedCompraDes = New DataDynamics.ActiveReports.TextBox
      Me.GroupHeader3 = New DataDynamics.ActiveReports.GroupHeader
      Me.GroupFooter3 = New DataDynamics.ActiveReports.GroupFooter
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtItemNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMarcaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtProveedorDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIsoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCiudadDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtContactoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblContacto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCargo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraNro2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEmpresaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEmpresaRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblFax, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoRec, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMontoLiq, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoRec, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMontoLiq, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraObs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblFechaEnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaEnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPedCompraDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtItemDes, Me.txtItemNro, Me.TextBox27, Me.TextBox28, Me.txtPrecio, Me.TextBox1, Me.txtMarcaDes})
      Me.Detail.Height = 0.1889764!
      Me.Detail.Name = "Detail"
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
      Me.txtItemDes.Height = 0.1845472!
      Me.txtItemDes.Left = 2.312992!
      Me.txtItemDes.Name = "txtItemDes"
      Me.txtItemDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtItemDes.Text = "ItemDes"
      Me.txtItemDes.Top = 0.0!
      Me.txtItemDes.Width = 3.27354!
      '
      'txtItemNro
      '
      Me.txtItemNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtItemNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtItemNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtItemNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtItemNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtItemNro.Height = 0.1845472!
      Me.txtItemNro.Left = 0.0!
      Me.txtItemNro.Name = "txtItemNro"
      Me.txtItemNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtItemNro.Text = "ItemNro"
      Me.txtItemNro.Top = 0.0!
      Me.txtItemNro.Width = 0.3444882!
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
      Me.TextBox27.Height = 0.1845472!
      Me.TextBox27.Left = 1.070374!
      Me.TextBox27.Name = "TextBox27"
      Me.TextBox27.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.TextBox27.Text = "MedidaDes"
      Me.TextBox27.Top = 0.0!
      Me.TextBox27.Width = 0.5782481!
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
      Me.TextBox28.DataField = "Cantidad"
      Me.TextBox28.Height = 0.1845472!
      Me.TextBox28.Left = 0.3690945!
      Me.TextBox28.Name = "TextBox28"
      Me.TextBox28.OutputFormat = resources.GetString("TextBox28.OutputFormat")
      Me.TextBox28.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox28.Text = "Cantidad"
      Me.TextBox28.Top = 0.0!
      Me.TextBox28.Width = 0.6643701!
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
      Me.txtPrecio.Height = 0.1845472!
      Me.txtPrecio.Left = 5.650918!
      Me.txtPrecio.Name = "txtPrecio"
      Me.txtPrecio.OutputFormat = resources.GetString("txtPrecio.OutputFormat")
      Me.txtPrecio.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPrecio.Text = "Precio"
      Me.txtPrecio.Top = 0.0!
      Me.txtPrecio.Width = 0.6719163!
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
      Me.TextBox1.DataField = "Importe"
      Me.TextBox1.Height = 0.1845472!
      Me.TextBox1.Left = 6.422245!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
      Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox1.Text = "Importe"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 0.9813806!
      '
      'txtMarcaDes
      '
      Me.txtMarcaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMarcaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMarcaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMarcaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMarcaDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMarcaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMarcaDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMarcaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMarcaDes.DataField = "MarcaDes"
      Me.txtMarcaDes.Height = 0.1875!
      Me.txtMarcaDes.Left = 1.648622!
      Me.txtMarcaDes.Name = "txtMarcaDes"
      Me.txtMarcaDes.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtMarcaDes.Text = "MarcaDes"
      Me.txtMarcaDes.Top = 0.0!
      Me.txtMarcaDes.Width = 0.59375!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape4, Me.Shape1, Me.picAnulado, Me.txtCargo, Me.lblTelefono, Me.Shape6, Me.Shape8, Me.txtProveedorDes, Me.Shape7, Me.txtIsoDes, Me.Shape9, Me.txtCiudadDes, Me.txtContactoDes, Me.lblTitle, Me.lblContacto, Me.lblCargo, Me.Label2, Me.txtPedCompraNro, Me.txtMonedaDes, Me.txtFecha, Me.txtTipoCambio, Me.txtEstadoId, Me.Shape11, Me.txtMoneda, Me.picLogo, Me.Label3, Me.txtEmail, Me.Label12, Me.Label23, Me.txtPedCompraNro2, Me.Label19, Me.txtTelefono, Me.lblEmpresaDes, Me.lblEmpresaRUC, Me.lblFax, Me.lblDireccion})
      Me.ReportHeader.Height = 2.0!
      Me.ReportHeader.Name = "ReportHeader"
      '
      'Shape4
      '
      Me.Shape4.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.RightColor = System.Drawing.Color.Black
      Me.Shape4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.TopColor = System.Drawing.Color.Black
      Me.Shape4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Height = 1.156496!
      Me.Shape4.Left = 0.9965551!
      Me.Shape4.LineColor = System.Drawing.Color.Transparent
      Me.Shape4.LineWeight = 2.0!
      Me.Shape4.Name = "Shape4"
      Me.Shape4.RoundingRadius = 9.999999!
      Me.Shape4.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape4.Top = 0.0!
      Me.Shape4.Width = 2.492782!
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
      Me.Shape1.Height = 0.8166015!
      Me.Shape1.Left = 0.0!
      Me.Shape1.LineWeight = 2.0!
      Me.Shape1.Name = "Shape1"
      Me.Shape1.RoundingRadius = 0.0!
      Me.Shape1.Top = 1.16601!
      Me.Shape1.Width = 7.492619!
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
      Me.picAnulado.Height = 0.6274606!
      Me.picAnulado.Image = CType(resources.GetObject("picAnulado.Image"), System.Drawing.Image)
      Me.picAnulado.ImageData = CType(resources.GetObject("picAnulado.ImageData"), System.IO.Stream)
      Me.picAnulado.Left = 0.1230315!
      Me.picAnulado.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.picAnulado.LineWeight = 0.0!
      Me.picAnulado.Name = "picAnulado"
      Me.picAnulado.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
      Me.picAnulado.Top = 1.264435!
      Me.picAnulado.Visible = False
      Me.picAnulado.Width = 4.805856!
      '
      'txtCargo
      '
      Me.txtCargo.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCargo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCargo.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCargo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCargo.Border.RightColor = System.Drawing.Color.Black
      Me.txtCargo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCargo.Border.TopColor = System.Drawing.Color.Black
      Me.txtCargo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCargo.DataField = "ContactoCargo"
      Me.txtCargo.Height = 0.1845473!
      Me.txtCargo.Left = 1.139436!
      Me.txtCargo.Name = "txtCargo"
      Me.txtCargo.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtCargo.Text = "ContactoCargo"
      Me.txtCargo.Top = 1.473589!
      Me.txtCargo.Width = 3.777148!
      '
      'lblTelefono
      '
      Me.lblTelefono.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTelefono.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTelefono.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTelefono.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTelefono.Border.RightColor = System.Drawing.Color.Black
      Me.lblTelefono.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTelefono.Border.TopColor = System.Drawing.Color.Black
      Me.lblTelefono.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTelefono.CanGrow = False
      Me.lblTelefono.Height = 0.1599408!
      Me.lblTelefono.Left = 0.9965551!
      Me.lblTelefono.Name = "lblTelefono"
      Me.lblTelefono.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 8pt; font-fami" & _
          "ly: Arial; white-space: nowrap; "
      Me.lblTelefono.Text = "Telefono"
      Me.lblTelefono.Top = 0.5905512!
      Me.lblTelefono.Width = 1.860236!
      '
      'Shape6
      '
      Me.Shape6.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape6.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape6.Border.RightColor = System.Drawing.Color.Black
      Me.Shape6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape6.Border.TopColor = System.Drawing.Color.Black
      Me.Shape6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape6.Height = 1.058071!
      Me.Shape6.Left = 3.55561!
      Me.Shape6.LineWeight = 2.0!
      Me.Shape6.Name = "Shape6"
      Me.Shape6.RoundingRadius = 0.0!
      Me.Shape6.Top = 0.0!
      Me.Shape6.Visible = False
      Me.Shape6.Width = 2.337599!
      '
      'Shape8
      '
      Me.Shape8.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape8.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape8.Border.RightColor = System.Drawing.Color.Black
      Me.Shape8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape8.Border.TopColor = System.Drawing.Color.Black
      Me.Shape8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape8.Height = 0.4429134!
      Me.Shape8.Left = 5.90625!
      Me.Shape8.LineWeight = 2.0!
      Me.Shape8.Name = "Shape8"
      Me.Shape8.RoundingRadius = 0.0!
      Me.Shape8.Top = 0.2214567!
      Me.Shape8.Width = 1.587106!
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
      Me.txtProveedorDes.Height = 0.3937008!
      Me.txtProveedorDes.Left = 5.955463!
      Me.txtProveedorDes.Name = "txtProveedorDes"
      Me.txtProveedorDes.OutputFormat = resources.GetString("txtProveedorDes.OutputFormat")
      Me.txtProveedorDes.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertic" & _
          "al-align: middle; "
      Me.txtProveedorDes.Text = "ProveedorDes"
      Me.txtProveedorDes.Top = 0.2337598!
      Me.txtProveedorDes.Width = 1.488681!
      '
      'Shape7
      '
      Me.Shape7.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape7.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape7.Border.RightColor = System.Drawing.Color.Black
      Me.Shape7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape7.Border.TopColor = System.Drawing.Color.Black
      Me.Shape7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape7.Height = 0.2214567!
      Me.Shape7.Left = 5.90625!
      Me.Shape7.LineWeight = 2.0!
      Me.Shape7.Name = "Shape7"
      Me.Shape7.RoundingRadius = 0.0!
      Me.Shape7.Top = 0.0!
      Me.Shape7.Width = 1.587106!
      '
      'txtIsoDes
      '
      Me.txtIsoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIsoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIsoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIsoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIsoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtIsoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIsoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtIsoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIsoDes.Height = 0.1845472!
      Me.txtIsoDes.Left = 5.955463!
      Me.txtIsoDes.Name = "txtIsoDes"
      Me.txtIsoDes.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.txtIsoDes.Text = "PROVEEDOR"
      Me.txtIsoDes.Top = 0.01230315!
      Me.txtIsoDes.Width = 1.488681!
      '
      'Shape9
      '
      Me.Shape9.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape9.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape9.Border.RightColor = System.Drawing.Color.Black
      Me.Shape9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape9.Border.TopColor = System.Drawing.Color.Black
      Me.Shape9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape9.Height = 0.2214567!
      Me.Shape9.Left = 5.90625!
      Me.Shape9.LineWeight = 2.0!
      Me.Shape9.Name = "Shape9"
      Me.Shape9.RoundingRadius = 0.0!
      Me.Shape9.Top = 0.6520669!
      Me.Shape9.Width = 1.587106!
      '
      'txtCiudadDes
      '
      Me.txtCiudadDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCiudadDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudadDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCiudadDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudadDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtCiudadDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudadDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtCiudadDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudadDes.Height = 0.1845472!
      Me.txtCiudadDes.Left = 5.955463!
      Me.txtCiudadDes.Name = "txtCiudadDes"
      Me.txtCiudadDes.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; vert" & _
          "ical-align: middle; "
      Me.txtCiudadDes.Text = "Santa Cruz - Bolivia"
      Me.txtCiudadDes.Top = 0.6643701!
      Me.txtCiudadDes.Width = 1.488681!
      '
      'txtContactoDes
      '
      Me.txtContactoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtContactoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtContactoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtContactoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtContactoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtContactoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtContactoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtContactoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtContactoDes.DataField = "ContactoDes"
      Me.txtContactoDes.Height = 0.1845473!
      Me.txtContactoDes.Left = 1.139435!
      Me.txtContactoDes.Name = "txtContactoDes"
      Me.txtContactoDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtContactoDes.Text = "ContactoDes"
      Me.txtContactoDes.Top = 1.227526!
      Me.txtContactoDes.Width = 2.060286!
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
      Me.lblTitle.Height = 0.3198819!
      Me.lblTitle.HyperLink = Nothing
      Me.lblTitle.Left = 3.142061!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 14pt; vertical-a" & _
          "lign: top; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.2583661!
      Me.lblTitle.Width = 2.527969!
      '
      'lblContacto
      '
      Me.lblContacto.Border.BottomColor = System.Drawing.Color.Black
      Me.lblContacto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblContacto.Border.LeftColor = System.Drawing.Color.Black
      Me.lblContacto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblContacto.Border.RightColor = System.Drawing.Color.Black
      Me.lblContacto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblContacto.Border.TopColor = System.Drawing.Color.Black
      Me.lblContacto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblContacto.Height = 0.1875!
      Me.lblContacto.HyperLink = Nothing
      Me.lblContacto.Left = 0.01984908!
      Me.lblContacto.Name = "lblContacto"
      Me.lblContacto.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.lblContacto.Text = "CONTACTO :"
      Me.lblContacto.Top = 1.227526!
      Me.lblContacto.Width = 1.09375!
      '
      'lblCargo
      '
      Me.lblCargo.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCargo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCargo.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCargo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCargo.Border.RightColor = System.Drawing.Color.Black
      Me.lblCargo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCargo.Border.TopColor = System.Drawing.Color.Black
      Me.lblCargo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCargo.Height = 0.1875!
      Me.lblCargo.HyperLink = Nothing
      Me.lblCargo.Left = 0.01984908!
      Me.lblCargo.Name = "lblCargo"
      Me.lblCargo.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.lblCargo.Text = "SOLICITADO POR :"
      Me.lblCargo.Top = 1.473589!
      Me.lblCargo.Width = 1.09375!
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
      Me.Label2.Height = 0.1845472!
      Me.Label2.HyperLink = Nothing
      Me.Label2.Left = 0.01984908!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label2.Text = "NRO PEDIDO :"
      Me.Label2.Top = 1.707349!
      Me.Label2.Width = 1.09498!
      '
      'txtPedCompraNro
      '
      Me.txtPedCompraNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPedCompraNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro.DataField = "PedCompraNro"
      Me.txtPedCompraNro.Height = 0.1845472!
      Me.txtPedCompraNro.Left = 1.139435!
      Me.txtPedCompraNro.Name = "txtPedCompraNro"
      Me.txtPedCompraNro.Style = "font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.txtPedCompraNro.Text = "PedCompraNro"
      Me.txtPedCompraNro.Top = 1.707349!
      Me.txtPedCompraNro.Width = 3.784941!
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
      Me.txtMonedaDes.Left = 4.416831!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 0.06151575!
      Me.txtMonedaDes.Visible = False
      Me.txtMonedaDes.Width = 0.65625!
      '
      'txtFecha
      '
      Me.txtFecha.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFecha.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFecha.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFecha.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.RightColor = System.Drawing.Color.Black
      Me.txtFecha.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.TopColor = System.Drawing.Color.Black
      Me.txtFecha.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.DataField = "Fecha"
      Me.txtFecha.Height = 0.1845472!
      Me.txtFecha.Left = 5.839321!
      Me.txtFecha.Name = "txtFecha"
      Me.txtFecha.OutputFormat = resources.GetString("txtFecha.OutputFormat")
      Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFecha.Text = "Fecha"
      Me.txtFecha.Top = 1.707349!
      Me.txtFecha.Width = 1.589895!
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTipoCambio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTipoCambio.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTipoCambio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCambio.Border.RightColor = System.Drawing.Color.Black
      Me.txtTipoCambio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCambio.Border.TopColor = System.Drawing.Color.Black
      Me.txtTipoCambio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCambio.DataField = "TipoCambio"
      Me.txtTipoCambio.Height = 0.1875!
      Me.txtTipoCambio.Left = 3.629429!
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.OutputFormat = resources.GetString("txtTipoCambio.OutputFormat")
      Me.txtTipoCambio.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtTipoCambio.Text = "TipoCambio"
      Me.txtTipoCambio.Top = 0.0738189!
      Me.txtTipoCambio.Visible = False
      Me.txtTipoCambio.Width = 0.6875!
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
      Me.txtEstadoId.Left = 5.302658!
      Me.txtEstadoId.Name = "txtEstadoId"
      Me.txtEstadoId.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtEstadoId.Text = "EstadoId"
      Me.txtEstadoId.Top = 0.08612204!
      Me.txtEstadoId.Visible = False
      Me.txtEstadoId.Width = 0.5!
      '
      'Shape11
      '
      Me.Shape11.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape11.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape11.Border.RightColor = System.Drawing.Color.Black
      Me.Shape11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape11.Border.TopColor = System.Drawing.Color.Black
      Me.Shape11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape11.Height = 1.070374!
      Me.Shape11.Left = 0.0!
      Me.Shape11.LineWeight = 2.0!
      Me.Shape11.Name = "Shape11"
      Me.Shape11.RoundingRadius = 0.0!
      Me.Shape11.Top = 0.0!
      Me.Shape11.Width = 0.984252!
      '
      'txtMoneda
      '
      Me.txtMoneda.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Border.RightColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Border.TopColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Height = 0.1875!
      Me.txtMoneda.Left = 3.764764!
      Me.txtMoneda.Name = "txtMoneda"
      Me.txtMoneda.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMoneda.Text = "Moneda"
      Me.txtMoneda.Top = 0.6274607!
      Me.txtMoneda.Width = 0.9583333!
      '
      'picLogo
      '
      Me.picLogo.Border.BottomColor = System.Drawing.Color.Black
      Me.picLogo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picLogo.Border.LeftColor = System.Drawing.Color.Black
      Me.picLogo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picLogo.Border.RightColor = System.Drawing.Color.Black
      Me.picLogo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picLogo.Border.TopColor = System.Drawing.Color.Black
      Me.picLogo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picLogo.Height = 1.024935!
      Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
      Me.picLogo.ImageData = CType(resources.GetObject("picLogo.ImageData"), System.IO.Stream)
      Me.picLogo.Left = 0.0!
      Me.picLogo.LineColor = System.Drawing.Color.Black
      Me.picLogo.LineWeight = 1.0!
      Me.picLogo.Name = "picLogo"
      Me.picLogo.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
      Me.picLogo.Top = 0.02083333!
      Me.picLogo.Width = 0.9719489!
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
      Me.Label3.Height = 0.1845473!
      Me.Label3.HyperLink = Nothing
      Me.Label3.Left = 5.138041!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label3.Text = "EMAIL : "
      Me.Label3.Top = 1.227526!
      Me.Label3.Width = 0.652067!
      '
      'txtEmail
      '
      Me.txtEmail.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEmail.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmail.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEmail.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEmail.Border.RightColor = System.Drawing.Color.Black
      Me.txtEmail.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEmail.Border.TopColor = System.Drawing.Color.Black
      Me.txtEmail.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEmail.DataField = "Email"
      Me.txtEmail.Height = 0.1845473!
      Me.txtEmail.Left = 5.839321!
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.Style = "font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.txtEmail.Text = Nothing
      Me.txtEmail.Top = 1.227526!
      Me.txtEmail.Width = 1.589895!
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
      Me.Label12.Height = 0.1845472!
      Me.Label12.HyperLink = Nothing
      Me.Label12.Left = 5.138041!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label12.Text = "FECHA :  "
      Me.Label12.Top = 1.707349!
      Me.Label12.Width = 0.652067!
      '
      'Label23
      '
      Me.Label23.Border.BottomColor = System.Drawing.Color.Black
      Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label23.Border.LeftColor = System.Drawing.Color.Black
      Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label23.Border.RightColor = System.Drawing.Color.Black
      Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label23.Border.TopColor = System.Drawing.Color.Black
      Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label23.Height = 0.1845473!
      Me.Label23.HyperLink = Nothing
      Me.Label23.Left = 5.138041!
      Me.Label23.Name = "Label23"
      Me.Label23.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label23.Text = "NRO. :  "
      Me.Label23.Top = 1.473589!
      Me.Label23.Visible = False
      Me.Label23.Width = 0.652067!
      '
      'txtPedCompraNro2
      '
      Me.txtPedCompraNro2.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraNro2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPedCompraNro2.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraNro2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro2.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraNro2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro2.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraNro2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraNro2.DataField = "PedCompraNro"
      Me.txtPedCompraNro2.Height = 0.1845473!
      Me.txtPedCompraNro2.Left = 5.839321!
      Me.txtPedCompraNro2.Name = "txtPedCompraNro2"
      Me.txtPedCompraNro2.OutputFormat = resources.GetString("txtPedCompraNro2.OutputFormat")
      Me.txtPedCompraNro2.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtPedCompraNro2.Text = "PedCompraNro"
      Me.txtPedCompraNro2.Top = 1.473589!
      Me.txtPedCompraNro2.Visible = False
      Me.txtPedCompraNro2.Width = 1.593668!
      '
      'Label19
      '
      Me.Label19.Border.BottomColor = System.Drawing.Color.Black
      Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Border.LeftColor = System.Drawing.Color.Black
      Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Border.RightColor = System.Drawing.Color.Black
      Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Border.TopColor = System.Drawing.Color.Black
      Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Height = 0.1845473!
      Me.Label19.HyperLink = Nothing
      Me.Label19.Left = 3.248032!
      Me.Label19.Name = "Label19"
      Me.Label19.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label19.Text = "Tel : "
      Me.Label19.Top = 1.227526!
      Me.Label19.Width = 0.4741635!
      '
      'txtTelefono
      '
      Me.txtTelefono.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTelefono.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTelefono.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTelefono.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTelefono.Border.RightColor = System.Drawing.Color.Black
      Me.txtTelefono.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTelefono.Border.TopColor = System.Drawing.Color.Black
      Me.txtTelefono.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTelefono.DataField = "Telefono1"
      Me.txtTelefono.Height = 0.1845473!
      Me.txtTelefono.Left = 3.740157!
      Me.txtTelefono.Name = "txtTelefono"
      Me.txtTelefono.Style = "font-weight: normal; font-size: 8pt; vertical-align: middle; "
      Me.txtTelefono.Text = "Telefono1"
      Me.txtTelefono.Top = 1.227526!
      Me.txtTelefono.Width = 1.18873!
      '
      'lblEmpresaDes
      '
      Me.lblEmpresaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEmpresaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEmpresaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresaDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblEmpresaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresaDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblEmpresaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresaDes.Height = 0.1850394!
      Me.lblEmpresaDes.Left = 0.9965551!
      Me.lblEmpresaDes.Name = "lblEmpresaDes"
      Me.lblEmpresaDes.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 10pt; font-famil" & _
          "y: Arial; white-space: inherit; vertical-align: bottom; "
      Me.lblEmpresaDes.Text = "EmpresaDes"
      Me.lblEmpresaDes.Top = 0.01230315!
      Me.lblEmpresaDes.Width = 2.484252!
      '
      'lblEmpresaRUC
      '
      Me.lblEmpresaRUC.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEmpresaRUC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresaRUC.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEmpresaRUC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresaRUC.Border.RightColor = System.Drawing.Color.Black
      Me.lblEmpresaRUC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresaRUC.Border.TopColor = System.Drawing.Color.Black
      Me.lblEmpresaRUC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresaRUC.CanGrow = False
      Me.lblEmpresaRUC.Height = 0.1599411!
      Me.lblEmpresaRUC.Left = 0.9965551!
      Me.lblEmpresaRUC.Name = "lblEmpresaRUC"
      Me.lblEmpresaRUC.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 8pt; font-fami" & _
          "ly: Arial; white-space: nowrap; "
      Me.lblEmpresaRUC.Text = "EmpresaRUC"
      Me.lblEmpresaRUC.Top = 0.2706693!
      Me.lblEmpresaRUC.Width = 1.860236!
      '
      'lblFax
      '
      Me.lblFax.Border.BottomColor = System.Drawing.Color.Black
      Me.lblFax.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFax.Border.LeftColor = System.Drawing.Color.Black
      Me.lblFax.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFax.Border.RightColor = System.Drawing.Color.Black
      Me.lblFax.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFax.Border.TopColor = System.Drawing.Color.Black
      Me.lblFax.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFax.CanGrow = False
      Me.lblFax.Height = 0.1599409!
      Me.lblFax.Left = 0.9965551!
      Me.lblFax.Name = "lblFax"
      Me.lblFax.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 8pt; font-fami" & _
          "ly: Arial; white-space: nowrap; "
      Me.lblFax.Text = "Fax"
      Me.lblFax.Top = 0.4306103!
      Me.lblFax.Width = 1.860236!
      '
      'lblDireccion
      '
      Me.lblDireccion.Border.BottomColor = System.Drawing.Color.Black
      Me.lblDireccion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDireccion.Border.LeftColor = System.Drawing.Color.Black
      Me.lblDireccion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDireccion.Border.RightColor = System.Drawing.Color.Black
      Me.lblDireccion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDireccion.Border.TopColor = System.Drawing.Color.Black
      Me.lblDireccion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDireccion.Height = 0.1722442!
      Me.lblDireccion.Left = 0.9965551!
      Me.lblDireccion.Name = "lblDireccion"
      Me.lblDireccion.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 8pt; font-fami" & _
          "ly: Arial; white-space: inherit; "
      Me.lblDireccion.Text = "Direccion"
      Me.lblDireccion.Top = 0.7504923!
      Me.lblDireccion.Width = 1.860236!
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFirma})
      Me.ReportFooter.Height = 0.8854167!
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
      Me.txtFirma.Top = 0.4675197!
      Me.txtFirma.Width = 7.479167!
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
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.Label10, Me.Label11, Me.Label9, Me.Label7, Me.Label15, Me.Label5, Me.Label8})
      Me.GroupHeader1.Height = 0.3149606!
      Me.GroupHeader1.Name = "GroupHeader1"
      Me.GroupHeader1.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
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
      Me.Shape3.Height = 0.3149606!
      Me.Shape3.Left = 0.0!
      Me.Shape3.LineWeight = 2.0!
      Me.Shape3.Name = "Shape3"
      Me.Shape3.RoundingRadius = 9.999999!
      Me.Shape3.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape3.Top = 0.0!
      Me.Shape3.Width = 7.485647!
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
      Me.Label10.Height = 0.2952756!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 2.214567!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label10.Text = "DESCRIPCIÓN"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 3.432579!
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
      Me.Label11.Height = 0.2952756!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 5.659449!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: top; "
      Me.Label11.Text = "PRECIO UNITARIO"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.7381892!
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
      Me.Label9.Height = 0.2952756!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 0.3567913!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label9.Text = "CANT."
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.6889763!
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
      Me.Label7.Height = 0.2952756!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 0.0!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label7.Text = "ITEM"
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 0.3567913!
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
      Me.Label15.Height = 0.2952756!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 1.033465!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label15.Text = "UM"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.6274607!
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
      Me.Label5.Height = 0.2952756!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 6.409941!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label5.Text = "TOTAL"
      Me.Label5.Top = 0.0!
      Me.Label5.Width = 1.070374!
      '
      'Label8
      '
      Me.Label8.Border.BottomColor = System.Drawing.Color.Black
      Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.LeftColor = System.Drawing.Color.Black
      Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.RightColor = System.Drawing.Color.Black
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Height = 0.2952756!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 1.660925!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.Label8.Text = "MARCA"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 0.5659449!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblMontoRec, Me.txtLiteral, Me.txtTotal, Me.TextBox, Me.TextBox4, Me.lblMontoDes, Me.txtMontoDes, Me.lblMontoAnt, Me.lblMontoLiq, Me.txtMontoRec, Me.txtMontoAnt, Me.txtMontoLiq, Me.txtMonedaId, Me.Line4, Me.txtPedCompraObs, Me.lblFechaEnt, Me.txtFechaEnt})
      Me.GroupFooter1.Height = 2.047244!
      Me.GroupFooter1.Name = "GroupFooter1"
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
      Me.lblMontoRec.Left = 5.208333!
      Me.lblMontoRec.Name = "lblMontoRec"
      Me.lblMontoRec.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoRec.Text = "Recargo (+) :"
      Me.lblMontoRec.Top = 0.375!
      Me.lblMontoRec.Width = 1.0625!
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
      Me.txtLiteral.Width = 4.822917!
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
      Me.txtTotal.Height = 0.1845472!
      Me.txtTotal.Left = 6.274607!
      Me.txtTotal.Name = "txtTotal"
      Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
      Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.txtTotal.SummaryGroup = "GroupHeader1"
      Me.txtTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtTotal.Text = "Importe"
      Me.txtTotal.Top = 0.0!
      Me.txtTotal.Width = 1.155512!
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
      'TextBox4
      '
      Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox4.Height = 0.1875!
      Me.TextBox4.Left = 5.208333!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.TextBox4.Text = "Total  :    "
      Me.TextBox4.Top = 0.0!
      Me.TextBox4.Width = 1.0625!
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
      Me.lblMontoDes.Left = 5.208333!
      Me.lblMontoDes.Name = "lblMontoDes"
      Me.lblMontoDes.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoDes.Text = "Descuento (-) :"
      Me.lblMontoDes.Top = 0.5625!
      Me.lblMontoDes.Width = 1.0625!
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
      Me.txtMontoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMontoDes.DataField = "ImporteDes"
      Me.txtMontoDes.Height = 0.1845472!
      Me.txtMontoDes.Left = 6.274607!
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.OutputFormat = resources.GetString("txtMontoDes.OutputFormat")
      Me.txtMontoDes.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; verti" & _
          "cal-align: middle; "
      Me.txtMontoDes.SummaryGroup = "GroupHeader1"
      Me.txtMontoDes.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoDes.Text = "ImporteDes"
      Me.txtMontoDes.Top = 0.5659449!
      Me.txtMontoDes.Width = 1.155512!
      '
      'lblMontoAnt
      '
      Me.lblMontoAnt.Border.BottomColor = System.Drawing.Color.Black
      Me.lblMontoAnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoAnt.Border.LeftColor = System.Drawing.Color.Black
      Me.lblMontoAnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoAnt.Border.RightColor = System.Drawing.Color.Black
      Me.lblMontoAnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoAnt.Border.TopColor = System.Drawing.Color.Black
      Me.lblMontoAnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblMontoAnt.Height = 0.1875!
      Me.lblMontoAnt.Left = 5.208333!
      Me.lblMontoAnt.Name = "lblMontoAnt"
      Me.lblMontoAnt.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoAnt.Text = "Anticipo (-) :"
      Me.lblMontoAnt.Top = 0.1875!
      Me.lblMontoAnt.Width = 1.0625!
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
      Me.lblMontoLiq.Left = 5.208333!
      Me.lblMontoLiq.Name = "lblMontoLiq"
      Me.lblMontoLiq.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.lblMontoLiq.Text = "Líquido Pagable :"
      Me.lblMontoLiq.Top = 0.75!
      Me.lblMontoLiq.Width = 1.0625!
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
      Me.txtMontoRec.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMontoRec.DataField = "ImporteRec"
      Me.txtMontoRec.Height = 0.1968504!
      Me.txtMontoRec.Left = 6.274607!
      Me.txtMontoRec.Name = "txtMontoRec"
      Me.txtMontoRec.OutputFormat = resources.GetString("txtMontoRec.OutputFormat")
      Me.txtMontoRec.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; verti" & _
          "cal-align: middle; "
      Me.txtMontoRec.SummaryGroup = "GroupHeader1"
      Me.txtMontoRec.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoRec.Text = "ImporteRec"
      Me.txtMontoRec.Top = 0.3690945!
      Me.txtMontoRec.Width = 1.155512!
      '
      'txtMontoAnt
      '
      Me.txtMontoAnt.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.Border.RightColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.Border.TopColor = System.Drawing.Color.Black
      Me.txtMontoAnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMontoAnt.DataField = "MontoAnt"
      Me.txtMontoAnt.Height = 0.1845472!
      Me.txtMontoAnt.Left = 6.274607!
      Me.txtMontoAnt.Name = "txtMontoAnt"
      Me.txtMontoAnt.OutputFormat = resources.GetString("txtMontoAnt.OutputFormat")
      Me.txtMontoAnt.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtMontoAnt.Text = "MontoAnt"
      Me.txtMontoAnt.Top = 0.1845472!
      Me.txtMontoAnt.Width = 1.155512!
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
      Me.txtMontoLiq.Height = 0.1845472!
      Me.txtMontoLiq.Left = 6.274607!
      Me.txtMontoLiq.Name = "txtMontoLiq"
      Me.txtMontoLiq.OutputFormat = resources.GetString("txtMontoLiq.OutputFormat")
      Me.txtMontoLiq.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.txtMontoLiq.SummaryGroup = "GroupHeader1"
      Me.txtMontoLiq.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtMontoLiq.Text = "ImporteLiq"
      Me.txtMontoLiq.Top = 0.7504923!
      Me.txtMontoLiq.Width = 1.155512!
      '
      'txtMonedaId
      '
      Me.txtMonedaId.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonedaId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaId.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonedaId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaId.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonedaId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaId.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonedaId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaId.DataField = "MonedaId"
      Me.txtMonedaId.Height = 0.1875!
      Me.txtMonedaId.Left = 0.625!
      Me.txtMonedaId.Name = "txtMonedaId"
      Me.txtMonedaId.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtMonedaId.Text = "MonedaId"
      Me.txtMonedaId.Top = 0.1875!
      Me.txtMonedaId.Visible = False
      Me.txtMonedaId.Width = 0.6875!
      '
      'Line4
      '
      Me.Line4.Border.BottomColor = System.Drawing.Color.Black
      Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line4.Border.LeftColor = System.Drawing.Color.Black
      Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line4.Border.RightColor = System.Drawing.Color.Black
      Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line4.Border.TopColor = System.Drawing.Color.Black
      Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line4.Height = 0.0!
      Me.Line4.Left = 0.0!
      Me.Line4.LineWeight = 3.0!
      Me.Line4.Name = "Line4"
      Me.Line4.Top = 1.125328!
      Me.Line4.Width = 7.480315!
      Me.Line4.X1 = 0.0!
      Me.Line4.X2 = 7.480315!
      Me.Line4.Y1 = 1.125328!
      Me.Line4.Y2 = 1.125328!
      '
      'txtPedCompraObs
      '
      Me.txtPedCompraObs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPedCompraObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraObs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPedCompraObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraObs.Border.RightColor = System.Drawing.Color.Black
      Me.txtPedCompraObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraObs.Border.TopColor = System.Drawing.Color.Black
      Me.txtPedCompraObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPedCompraObs.DataField = "PedCompraObs"
      Me.txtPedCompraObs.Height = 0.1845472!
      Me.txtPedCompraObs.Left = 0.0!
      Me.txtPedCompraObs.Name = "txtPedCompraObs"
      Me.txtPedCompraObs.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPedCompraObs.Text = "PedCompraObs"
      Me.txtPedCompraObs.Top = 1.284202!
      Me.txtPedCompraObs.Width = 7.362205!
      '
      'lblFechaEnt
      '
      Me.lblFechaEnt.Border.BottomColor = System.Drawing.Color.Black
      Me.lblFechaEnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFechaEnt.Border.LeftColor = System.Drawing.Color.Black
      Me.lblFechaEnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFechaEnt.Border.RightColor = System.Drawing.Color.Black
      Me.lblFechaEnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFechaEnt.Border.TopColor = System.Drawing.Color.Black
      Me.lblFechaEnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFechaEnt.Height = 0.1845472!
      Me.lblFechaEnt.HyperLink = Nothing
      Me.lblFechaEnt.Left = 0.0!
      Me.lblFechaEnt.Name = "lblFechaEnt"
      Me.lblFechaEnt.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.lblFechaEnt.Text = "PLAZO DE ENTREGA :  "
      Me.lblFechaEnt.Top = 1.836942!
      Me.lblFechaEnt.Width = 1.36565!
      '
      'txtFechaEnt
      '
      Me.txtFechaEnt.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaEnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaEnt.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaEnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaEnt.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaEnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaEnt.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaEnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaEnt.DataField = "FechaEnt"
      Me.txtFechaEnt.Height = 0.1875!
      Me.txtFechaEnt.Left = 1.32874!
      Me.txtFechaEnt.Name = "txtFechaEnt"
      Me.txtFechaEnt.OutputFormat = resources.GetString("txtFechaEnt.OutputFormat")
      Me.txtFechaEnt.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaEnt.Text = "Fecha"
      Me.txtFechaEnt.Top = 1.836942!
      Me.txtFechaEnt.Width = 1.574803!
      '
      'GroupHeader2
      '
      Me.GroupHeader2.Height = 0.0!
      Me.GroupHeader2.Name = "GroupHeader2"
      '
      'GroupFooter2
      '
      Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPedCompraDes})
      Me.GroupFooter2.Height = 0.976378!
      Me.GroupFooter2.Name = "GroupFooter2"
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
      Me.txtPedCompraDes.Height = 0.1845472!
      Me.txtPedCompraDes.Left = 2.337599!
      Me.txtPedCompraDes.Name = "txtPedCompraDes"
      Me.txtPedCompraDes.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: middle; "
      Me.txtPedCompraDes.Text = "PedCompraDes"
      Me.txtPedCompraDes.Top = 0.7874016!
      Me.txtPedCompraDes.Width = 3.244177!
      '
      'GroupHeader3
      '
      Me.GroupHeader3.Height = 0.0!
      Me.GroupHeader3.Name = "GroupHeader3"
      '
      'GroupFooter3
      '
      Me.GroupFooter3.Height = 0.0!
      Me.GroupFooter3.Name = "GroupFooter3"
      '
      'rptPedCompraEditBolland
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
      Me.Sections.Add(Me.GroupHeader3)
      Me.Sections.Add(Me.GroupHeader1)
      Me.Sections.Add(Me.GroupHeader2)
      Me.Sections.Add(Me.Detail)
      Me.Sections.Add(Me.GroupFooter2)
      Me.Sections.Add(Me.GroupFooter1)
      Me.Sections.Add(Me.GroupFooter3)
      Me.Sections.Add(Me.PageFooter)
      Me.Sections.Add(Me.ReportFooter)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                  "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
      CType(Me.txtItemDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtItemNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMarcaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTelefono, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtProveedorDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIsoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCiudadDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtContactoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblContacto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCargo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraNro2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEmpresaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEmpresaRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblFax, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDireccion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoRec, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMontoLiq, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoRec, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMontoLiq, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraObs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblFechaEnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaEnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPedCompraDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Dim lngItemNro As Long = 0

   Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
      If txtEstadoId.Text = "12" Then
         picAnulado.Visible = True
      End If

      txtMoneda.Text = "( en " & txtMonedaDes.Text & " ) "
      txtTelefono.Text = txtTelefono.Text & " - " & ToStr(Me.Fields("Movil").Value)
      txtProveedorDes.Text = UCase(txtProveedorDes.Text)

      'Dim strPedCompraDes As String = txtPedCompraDes.Text

      'If strPedCompraDes.Length > 0 Then
      '   strPedCompraDes = strPedCompraDes.Substring(strPedCompraDes.IndexOf("-") + 1)
      '   txtPedCompraDes.Text = strPedCompraDes
      'End If

   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      Dim decDesplazo As Decimal = 0
      Dim oPoint As System.Drawing.PointF

      txtMontoLiq.Text = ToDecStrDos(ToDouble(txtTotal.Text) + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text) - ToDouble(txtMontoAnt.Text))

      txtLiteral.Text = CifraLiteral(ToDecimal(txtMontoLiq.Text)) + "  " + UCase(txtMonedaDes.Text)

      If ToDecimal(txtMontoAnt.Text) = 0 Then
         lblMontoAnt.Height = 0
         txtMontoAnt.Height = 0
         lblMontoAnt.Visible = False
         txtMontoAnt.Visible = False

         decDesplazo += 0.188
      End If

      oPoint.X = lblMontoRec.Location.X
      oPoint.Y = lblMontoRec.Location.Y - decDesplazo
      lblMontoRec.Location = oPoint

      oPoint.X = txtMontoRec.Location.X
      oPoint.Y = txtMontoRec.Location.Y - decDesplazo
      txtMontoRec.Location = oPoint

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

      oPoint.X = txtMontoLiq.Location.X
      oPoint.Y = txtMontoLiq.Location.Y - decDesplazo
      txtMontoLiq.Location = oPoint

      Line4.Y1 = Line4.Y1 - decDesplazo
      Line4.Y2 = Line4.Y2 - decDesplazo

      oPoint.X = txtPedCompraObs.Location.X
      oPoint.Y = txtPedCompraObs.Location.Y - decDesplazo
      txtPedCompraObs.Location = oPoint

      oPoint.X = lblFechaEnt.Location.X
      oPoint.Y = lblFechaEnt.Location.Y - decDesplazo
      lblFechaEnt.Location = oPoint

      oPoint.X = txtFechaEnt.Location.X
      oPoint.Y = txtFechaEnt.Location.Y - decDesplazo
      txtFechaEnt.Location = oPoint

      GroupFooter1.Height = GroupFooter1.Height - decDesplazo

   End Sub

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      lngItemNro += 1
      txtItemNro.Text = ToStr(lngItemNro)
      txtMarcaDes.Text = MarcaDesFind(ToLong(Me.Fields("MarcaId").Value))
   End Sub

   Private Sub ReportHeader_BeforePrint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportHeader.BeforePrint
      Dim oPoint As System.Drawing.PointF
      Dim decPosicion As Decimal = 0

      decPosicion = lblEmpresaDes.Height + lblEmpresaDes.Location.Y

      oPoint.X = lblEmpresaRUC.Location.X
      oPoint.Y = decPosicion
      lblEmpresaRUC.Location = oPoint
      decPosicion += lblEmpresaRUC.Height

      oPoint.X = lblFax.Location.X
      oPoint.Y = decPosicion
      lblFax.Location = oPoint
      decPosicion += lblFax.Height

      oPoint.X = lblTelefono.Location.X
      oPoint.Y = decPosicion
      lblTelefono.Location = oPoint
      decPosicion += lblTelefono.Height

      oPoint.X = lblDireccion.Location.X
      oPoint.Y = decPosicion
      lblDireccion.Location = oPoint
      decPosicion += lblDireccion.Height

   End Sub

   Private Sub GroupFooter2_BeforePrint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter2.BeforePrint
      Dim oPoint As System.Drawing.PointF

      oPoint.X = txtPedCompraDes.Location.X
      oPoint.Y = 0.4
      txtPedCompraDes.Location = oPoint
   End Sub

   Private Function MonedaDesFind(ByVal lngMonedaId As Long) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      MonedaDesFind = ""

      Try
         With oMoneda
            .MonedaId = lngMonedaId

            If .FindByPK Then
               MonedaDesFind = .MonedaDes
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oMoneda.Dispose()
      End Try
   End Function

   Private Function MarcaDesFind(ByVal lngMarcaId As Long) As String
      Dim oMarca As New clsMarca(clsAppInfo.ConnectString)

      MarcaDesFind = ""

      Try
         With oMarca
            .MarcaId = lngMarcaId

            If .FindByPK Then
               MarcaDesFind = .MarcaDes
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oMarca.Dispose()
      End Try
   End Function

End Class