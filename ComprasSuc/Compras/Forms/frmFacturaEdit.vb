Public Class frmFacturaEdit
   Inherits System.Windows.Forms.Form

   Private moFactura As clsFactura

   Private mdatFechaIni As Date
   Private mdatFechaFin As Date
   Private mstrQRDes() As String

   Private mstrSepDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

   Private mlngFacturaIdOrg As Long
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboTipoFacCompra As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblTipoFacCompraId As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtFacturaObs As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents chkBancarizar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtSubTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtDescuento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtImporteIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtExento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIceIehd As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtFacturaMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtQRDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents FormClear1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FormClear As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList

   Private mstrNroAutorizacion As String

   WriteOnly Property NewRecord() As Boolean
      Set(ByVal Value As Boolean)
         mboolAdding = Value
      End Set
   End Property

   WriteOnly Property Editing() As Boolean
      Set(ByVal Value As Boolean)
         mboolEditing = Value
      End Set
   End Property

   Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get

      Set(ByVal Value As Boolean)
         mboolChanged = Value
      End Set
   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   Property DataObject() As clsFactura
      Get
         Return moFactura
      End Get

      Set(ByVal Value As clsFactura)
         moFactura = Value
      End Set
   End Property

   WriteOnly Property FacturaIdOrg() As Long
      Set(ByVal Value As Long)
         mlngFacturaIdOrg = Value
      End Set
   End Property

#Region " Windows Form Designer generated code "

   Public Sub New()
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

   End Sub

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents txtCodControl As Janus.Windows.GridEX.EditControls.MaskedEditBox
   Friend WithEvents txtNroAutorizacion As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboRegRUC As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtFacturaNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents dtpFacturaFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents txtFacturaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboNroRUC As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboNroRUC_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaEdit))
      Dim cboRegRUC_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoFacCompra = New Janus.Windows.EditControls.UIComboBox
      Me.lblTipoFacCompraId = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtFacturaObs = New Janus.Windows.GridEX.EditControls.EditBox
      Me.chkBancarizar = New Janus.Windows.EditControls.UICheckBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtSubTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtDescuento = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtImporteIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNeto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtExento = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIceIehd = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtFacturaMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtQRDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboNroRUC = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtCodControl = New Janus.Windows.GridEX.EditControls.MaskedEditBox
      Me.txtNroAutorizacion = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboRegRUC = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.txtFacturaNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.dtpFacturaFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtFacturaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.Label18 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.Label20 = New System.Windows.Forms.Label
      Me.Label21 = New System.Windows.Forms.Label
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.FormClear1 = New Janus.Windows.UI.CommandBars.UICommand("FormClear")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.FormClear = New Janus.Windows.UI.CommandBars.UICommand("FormClear")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cboNroRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboRegRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 426)
      Me.bcgMain.TabIndex = 185
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.cboTipoFacCompra)
      Me.UiGroupBox2.Controls.Add(Me.lblTipoFacCompraId)
      Me.UiGroupBox2.Controls.Add(Me.Label2)
      Me.UiGroupBox2.Controls.Add(Me.txtFacturaObs)
      Me.UiGroupBox2.Controls.Add(Me.chkBancarizar)
      Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(9, 328)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(444, 88)
      Me.UiGroupBox2.TabIndex = 20
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboTipoFacCompra
      '
      Me.cboTipoFacCompra.DropListFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFacCompra.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFacCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.Location = New System.Drawing.Point(116, 36)
      Me.cboTipoFacCompra.Name = "cboTipoFacCompra"
      Me.cboTipoFacCompra.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoFacCompra.Size = New System.Drawing.Size(320, 20)
      Me.cboTipoFacCompra.TabIndex = 19
      Me.cboTipoFacCompra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblTipoFacCompraId
      '
      Me.lblTipoFacCompraId.BackColor = System.Drawing.Color.Transparent
      Me.lblTipoFacCompraId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTipoFacCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblTipoFacCompraId.Location = New System.Drawing.Point(8, 40)
      Me.lblTipoFacCompraId.Name = "lblTipoFacCompraId"
      Me.lblTipoFacCompraId.Size = New System.Drawing.Size(104, 16)
      Me.lblTipoFacCompraId.TabIndex = 216
      Me.lblTipoFacCompraId.Text = "Tipo Compra"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(8, 64)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 217
      Me.Label2.Text = "Observaci�n"
      '
      'txtFacturaObs
      '
      Me.txtFacturaObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtFacturaObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFacturaObs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaObs.Location = New System.Drawing.Point(116, 60)
      Me.txtFacturaObs.MaxLength = 255
      Me.txtFacturaObs.Multiline = True
      Me.txtFacturaObs.Name = "txtFacturaObs"
      Me.txtFacturaObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtFacturaObs.Size = New System.Drawing.Size(320, 20)
      Me.txtFacturaObs.TabIndex = 20
      Me.txtFacturaObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'chkBancarizar
      '
      Me.chkBancarizar.BackColor = System.Drawing.Color.Transparent
      Me.chkBancarizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkBancarizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkBancarizar.Location = New System.Drawing.Point(8, 16)
      Me.chkBancarizar.Name = "chkBancarizar"
      Me.chkBancarizar.Size = New System.Drawing.Size(216, 16)
      Me.chkBancarizar.TabIndex = 18
      Me.chkBancarizar.TabStop = False
      Me.chkBancarizar.Text = "Bancarizar esta Factura"
      Me.chkBancarizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtSubTotal)
      Me.UiGroupBox1.Controls.Add(Me.Label9)
      Me.UiGroupBox1.Controls.Add(Me.txtDescuento)
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Controls.Add(Me.txtImporteIVA)
      Me.UiGroupBox1.Controls.Add(Me.txtIVA)
      Me.UiGroupBox1.Controls.Add(Me.txtNeto)
      Me.UiGroupBox1.Controls.Add(Me.txtExento)
      Me.UiGroupBox1.Controls.Add(Me.txtIceIehd)
      Me.UiGroupBox1.Controls.Add(Me.txtFacturaMonto)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 212)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 116)
      Me.UiGroupBox1.TabIndex = 19
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtSubTotal
      '
      Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Info
      Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSubTotal.FormatString = "##,##0.000"
      Me.txtSubTotal.Location = New System.Drawing.Point(328, 16)
      Me.txtSubTotal.Name = "txtSubTotal"
      Me.txtSubTotal.ReadOnly = True
      Me.txtSubTotal.Size = New System.Drawing.Size(108, 20)
      Me.txtSubTotal.TabIndex = 14
      Me.txtSubTotal.TabStop = False
      Me.txtSubTotal.Text = "0,000"
      Me.txtSubTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtSubTotal.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtSubTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(264, 20)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(60, 16)
      Me.Label9.TabIndex = 198
      Me.Label9.Text = "SubTotal "
      '
      'txtDescuento
      '
      Me.txtDescuento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDescuento.FormatString = "##,##0.000"
      Me.txtDescuento.Location = New System.Drawing.Point(116, 88)
      Me.txtDescuento.Name = "txtDescuento"
      Me.txtDescuento.ReadOnly = True
      Me.txtDescuento.Size = New System.Drawing.Size(108, 20)
      Me.txtDescuento.TabIndex = 13
      Me.txtDescuento.Text = "0,000"
      Me.txtDescuento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDescuento.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDescuento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 92)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 196
      Me.Label1.Text = "Descuento"
      '
      'txtImporteIVA
      '
      Me.txtImporteIVA.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporteIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteIVA.FormatString = "##,##0.000"
      Me.txtImporteIVA.Location = New System.Drawing.Point(328, 88)
      Me.txtImporteIVA.Name = "txtImporteIVA"
      Me.txtImporteIVA.ReadOnly = True
      Me.txtImporteIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtImporteIVA.TabIndex = 16
      Me.txtImporteIVA.TabStop = False
      Me.txtImporteIVA.Text = "0,000"
      Me.txtImporteIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporteIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporteIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIVA
      '
      Me.txtIVA.BackColor = System.Drawing.SystemColors.Info
      Me.txtIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIVA.FormatString = "##,##0.000"
      Me.txtIVA.Location = New System.Drawing.Point(328, 64)
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.ReadOnly = True
      Me.txtIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtIVA.TabIndex = 15
      Me.txtIVA.TabStop = False
      Me.txtIVA.Text = "0,000"
      Me.txtIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNeto
      '
      Me.txtNeto.BackColor = System.Drawing.SystemColors.Info
      Me.txtNeto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNeto.FormatString = "##,##0.000"
      Me.txtNeto.Location = New System.Drawing.Point(328, 40)
      Me.txtNeto.Name = "txtNeto"
      Me.txtNeto.ReadOnly = True
      Me.txtNeto.Size = New System.Drawing.Size(108, 20)
      Me.txtNeto.TabIndex = 14
      Me.txtNeto.TabStop = False
      Me.txtNeto.Text = "0,000"
      Me.txtNeto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtNeto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtNeto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtExento
      '
      Me.txtExento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExento.FormatString = "##,##0.000"
      Me.txtExento.Location = New System.Drawing.Point(116, 64)
      Me.txtExento.Name = "txtExento"
      Me.txtExento.Size = New System.Drawing.Size(108, 20)
      Me.txtExento.TabIndex = 12
      Me.txtExento.Text = "0,000"
      Me.txtExento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExento.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIceIehd
      '
      Me.txtIceIehd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIceIehd.FormatString = "##,##0.000"
      Me.txtIceIehd.Location = New System.Drawing.Point(116, 40)
      Me.txtIceIehd.Name = "txtIceIehd"
      Me.txtIceIehd.Size = New System.Drawing.Size(108, 20)
      Me.txtIceIehd.TabIndex = 11
      Me.txtIceIehd.Text = "0,000"
      Me.txtIceIehd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIceIehd.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIceIehd.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFacturaMonto
      '
      Me.txtFacturaMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaMonto.FormatString = "##,##0.000"
      Me.txtFacturaMonto.Location = New System.Drawing.Point(116, 16)
      Me.txtFacturaMonto.Name = "txtFacturaMonto"
      Me.txtFacturaMonto.ReadOnly = True
      Me.txtFacturaMonto.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaMonto.TabIndex = 10
      Me.txtFacturaMonto.Text = "0,000"
      Me.txtFacturaMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtFacturaMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtFacturaMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(232, 92)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(92, 16)
      Me.Label3.TabIndex = 194
      Me.Label3.Text = "Imp Base - IVA"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(296, 68)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(28, 16)
      Me.Label4.TabIndex = 193
      Me.Label4.Text = "IVA"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(240, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(84, 16)
      Me.Label5.TabIndex = 192
      Me.Label5.Text = "Importe Base"
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 68)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 191
      Me.Label6.Text = "Exento"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 44)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 190
      Me.Label7.Text = "ICE / IEHD"
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 20)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 189
      Me.Label8.Text = "Importe Total"
      '
      'grpMain
      '
      Me.grpMain.BackColor = System.Drawing.Color.WhiteSmoke
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtQRDes)
      Me.grpMain.Controls.Add(Me.cboNroRUC)
      Me.grpMain.Controls.Add(Me.txtCodControl)
      Me.grpMain.Controls.Add(Me.txtNroAutorizacion)
      Me.grpMain.Controls.Add(Me.cboRegRUC)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.txtFacturaNro)
      Me.grpMain.Controls.Add(Me.dtpFacturaFecha)
      Me.grpMain.Controls.Add(Me.txtFacturaId)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.Label19)
      Me.grpMain.Controls.Add(Me.Label20)
      Me.grpMain.Controls.Add(Me.Label21)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 212)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtQRDes
      '
      Me.txtQRDes.BackColor = System.Drawing.SystemColors.Info
      Me.txtQRDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtQRDes.Location = New System.Drawing.Point(232, 16)
      Me.txtQRDes.Name = "txtQRDes"
      Me.txtQRDes.Size = New System.Drawing.Size(204, 20)
      Me.txtQRDes.TabIndex = 204
      Me.txtQRDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtQRDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboNroRUC
      '
      cboNroRUC_DesignTimeLayout.LayoutString = resources.GetString("cboNroRUC_DesignTimeLayout.LayoutString")
      Me.cboNroRUC.DesignTimeLayout = cboNroRUC_DesignTimeLayout
      Me.cboNroRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboNroRUC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboNroRUC.Location = New System.Drawing.Point(116, 112)
      Me.cboNroRUC.MaxLength = 12
      Me.cboNroRUC.Name = "cboNroRUC"
      Me.cboNroRUC.SelectedIndex = -1
      Me.cboNroRUC.SelectedItem = Nothing
      Me.cboNroRUC.Size = New System.Drawing.Size(108, 20)
      Me.cboNroRUC.TabIndex = 5
      Me.cboNroRUC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboNroRUC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCodControl
      '
      Me.txtCodControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtCodControl.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCodControl.Location = New System.Drawing.Point(116, 184)
      Me.txtCodControl.Mask = "&&-&&-&&-&&-&&"
      Me.txtCodControl.Name = "txtCodControl"
      Me.txtCodControl.Size = New System.Drawing.Size(108, 20)
      Me.txtCodControl.TabIndex = 8
      Me.txtCodControl.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCodControl.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNroAutorizacion
      '
      Me.txtNroAutorizacion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroAutorizacion.FormatString = "###############0"
      Me.txtNroAutorizacion.Location = New System.Drawing.Point(116, 160)
      Me.txtNroAutorizacion.MaxLength = 15
      Me.txtNroAutorizacion.Name = "txtNroAutorizacion"
      Me.txtNroAutorizacion.Size = New System.Drawing.Size(108, 20)
      Me.txtNroAutorizacion.TabIndex = 7
      Me.txtNroAutorizacion.Text = "0"
      Me.txtNroAutorizacion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroAutorizacion.Value = CType(0, Long)
      Me.txtNroAutorizacion.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtNroAutorizacion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboRegRUC
      '
      cboRegRUC_DesignTimeLayout.LayoutString = resources.GetString("cboRegRUC_DesignTimeLayout.LayoutString")
      Me.cboRegRUC.DesignTimeLayout = cboRegRUC_DesignTimeLayout
      Me.cboRegRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboRegRUC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboRegRUC.Location = New System.Drawing.Point(116, 136)
      Me.cboRegRUC.Name = "cboRegRUC"
      Me.cboRegRUC.SelectedIndex = -1
      Me.cboRegRUC.SelectedItem = Nothing
      Me.cboRegRUC.Size = New System.Drawing.Size(320, 20)
      Me.cboRegRUC.TabIndex = 6
      Me.cboRegRUC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboRegRUC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 40)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.ReadOnly = True
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(108, 20)
      Me.cboEstado.TabIndex = 2
      Me.cboEstado.TabStop = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtFacturaNro
      '
      Me.txtFacturaNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaNro.FormatString = "##################"
      Me.txtFacturaNro.Location = New System.Drawing.Point(116, 64)
      Me.txtFacturaNro.MaxLength = 18
      Me.txtFacturaNro.Name = "txtFacturaNro"
      Me.txtFacturaNro.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaNro.TabIndex = 3
      Me.txtFacturaNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaNro.Value = CType(0, Long)
      Me.txtFacturaNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtFacturaNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpFacturaFecha
      '
      Me.dtpFacturaFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFacturaFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFacturaFecha.DropDownCalendar.FirstMonth = New Date(2008, 1, 1, 0, 0, 0, 0)
      Me.dtpFacturaFecha.DropDownCalendar.Name = ""
      Me.dtpFacturaFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFacturaFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dtpFacturaFecha.Location = New System.Drawing.Point(116, 88)
      Me.dtpFacturaFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFacturaFecha.Name = "dtpFacturaFecha"
      Me.dtpFacturaFecha.Size = New System.Drawing.Size(108, 20)
      Me.dtpFacturaFecha.TabIndex = 4
      Me.dtpFacturaFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtFacturaId
      '
      Me.txtFacturaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaId.Location = New System.Drawing.Point(116, 16)
      Me.txtFacturaId.Name = "txtFacturaId"
      Me.txtFacturaId.ReadOnly = True
      Me.txtFacturaId.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaId.TabIndex = 1
      Me.txtFacturaId.TabStop = False
      Me.txtFacturaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label14.Location = New System.Drawing.Point(8, 44)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(104, 16)
      Me.Label14.TabIndex = 203
      Me.Label14.Text = "Estado"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label15.Location = New System.Drawing.Point(8, 68)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 202
      Me.Label15.Text = "N�mero Factura"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(8, 92)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 201
      Me.Label16.Text = "Fecha"
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label17.Location = New System.Drawing.Point(8, 164)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(104, 16)
      Me.Label17.TabIndex = 200
      Me.Label17.Text = "Nro Autorizacion"
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label18.Location = New System.Drawing.Point(8, 188)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 199
      Me.Label18.Text = "C�digo Control"
      '
      'Label19
      '
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label19.Location = New System.Drawing.Point(8, 140)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(104, 16)
      Me.Label19.TabIndex = 198
      Me.Label19.Text = "Raz�n Social"
      '
      'Label20
      '
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label20.Location = New System.Drawing.Point(8, 116)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(104, 16)
      Me.Label20.TabIndex = 197
      Me.Label20.Text = "N�mero NIT"
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label21.Location = New System.Drawing.Point(8, 20)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(104, 16)
      Me.Label21.TabIndex = 196
      Me.Label21.Text = "ID"
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.FormClear})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("bc0ea4be-0c5e-474a-80d6-e1e004a3cc09")
      Me.cdmMain.ImageList = Me.ilsMain
      Me.cdmMain.LeftRebar = Me.LeftRebar1
      Me.cdmMain.RightRebar = Me.RightRebar1
      Me.cdmMain.TopRebar = Me.TopRebar1
      Me.cdmMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'BottomRebar1
      '
      Me.BottomRebar1.CommandManager = Me.cdmMain
      Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
      Me.BottomRebar1.Name = "BottomRebar1"
      Me.BottomRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'UiCommandBar1
      '
      Me.UiCommandBar1.CommandManager = Me.cdmMain
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.FormClear1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(228, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'FormClear1
      '
      Me.FormClear1.Key = "FormClear"
      Me.FormClear1.Name = "FormClear1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Save
      '
      Me.Save.ImageIndex = 0
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 1
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'FormClear
      '
      Me.FormClear.ImageIndex = 2
      Me.FormClear.Key = "FormClear"
      Me.FormClear.Name = "FormClear"
      Me.FormClear.Text = "Limpiar"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "1448335895_window_new.png")
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(462, 28)
      '
      'frmFacturaEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 454)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmFacturaEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Factura Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboNroRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboRegRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Save"
            If DataSave() Then
               mlngID = moFactura.FacturaId
               mboolChanged = True
               Me.Close()
            End If

         Case "FormClear"
            Call FormNew()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmFacturaEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmFacturaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor
      Dim strTipoFactura As String

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()

      If moFactura.TipoFacturaId = 1 Then
         strTipoFactura = "Factura de venta"

      ElseIf moFactura.TipoFacturaId = 2 Then
         strTipoFactura = "Factura de Compra"
      End If

      If Not mboolAdding Then
         Call FormShow()
         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta " + strTipoFactura
         Else
            Me.Text = "Editar " + strTipoFactura
            cdmMain.Commands.Item("FormClear").Enabled = Janus.Windows.UI.InheritableBoolean.False
         End If
      Else
         Me.Text = "Nueva " + strTipoFactura
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moFactura
         txtFacturaId.Text = ToStr(.FacturaId)
         dtpFacturaFecha.Text = .FacturaFecha
         cboRegRUC.Tag = ToStr(.RegRUCDes)
         cboRegRUC.Text = ToStr(.RegRUCDes)
         cboNroRUC.Tag = ToStr(.NroRUC)
         cboNroRUC.Text = ToStr(.NroRUC)
         txtNroAutorizacion.Text = ToStr(.NroAutorizacion)
         mstrNroAutorizacion = ToStr(.NroAutorizacion)
         txtCodControl.Text = ToStr(.CodControl)

         txtFacturaNro.Text = ToStr(.FacturaNro)
         txtFacturaMonto.Text = ToDecStr(.FacturaMonto)
         txtIceIehd.Text = ToDecStr(.IceIehd)
         txtExento.Text = ToDecStr(.Exento)
         txtDescuento.Text = ToDecStr(.Descuento)
         txtSubTotal.Text = ToDecStr(.FacturaMonto - (.Exento + .IceIehd))
         txtNeto.Text = ToDecStr(.FacturaMonto - (.Exento + .IceIehd + .Descuento))
         txtIVA.Text = ToDecStr(.IVA)
         txtImporteIVA.Text = ToDecStr((.FacturaMonto - (.Exento + .IceIehd + .Descuento)) - .IVA)

         If mboolEditing Then
            txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
            txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))
         End If

         txtFacturaObs.Text = ToStr(.FacturaObs)
         cboTipoFacCompra.SelectedIndex = ListFindItem(cboTipoFacCompra, .TipoFacCompraId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         cboEstado.ReadOnly = True

         If .FacturaMonto >= 50000 Then
            chkBancarizar.Checked = True
         Else
            chkBancarizar.Checked = False
         End If

         txtFacturaMonto.Select()
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moFactura
         txtFacturaId.Text = String.Empty
         dtpFacturaFecha.Text = .FacturaFecha
         cboRegRUC.Value = Nothing
         cboRegRUC.Tag = Nothing
         cboNroRUC.Value = Nothing
         cboNroRUC.Tag = Nothing

         If moFactura.TipoFacturaId = 1 Then 'Venta
            txtNroAutorizacion.ReadOnly = True

         Else 'Compra
            txtNroAutorizacion.Text = String.Empty
         End If

         txtCodControl.Text = String.Empty
         txtFacturaNro.Text = ToStr(.FacturaNro)
         txtFacturaMonto.Text = .FacturaMonto
         txtIceIehd.Text = "0"
         txtExento.Text = "0"
         ''txtNeto.Text = ToDecStr(.FacturaMonto)
         ''txtIVA.Text = ToDecStr(.FacturaMonto * clsAppInfo.IVA)
         ''txtImporteIVA.Text = ToDecStr(.FacturaMonto - (.FacturaMonto * clsAppInfo.IVA))

         txtDescuento.Text = ToDecStr(.Descuento)
         txtSubTotal.Text = ToDecStr(.FacturaMonto)
         txtNeto.Text = ToDecStr(.FacturaMonto - .Descuento)
         txtIVA.Text = ToDecStr((.FacturaMonto - .Descuento) * clsAppInfo.IVA)
         txtImporteIVA.Text = ToDecStr((.FacturaMonto - .Descuento) - ((.FacturaMonto - .Descuento) * clsAppInfo.IVA))

         txtFacturaObs.Text = String.Empty
         cboTipoFacCompra.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)

         If .FacturaMonto >= 50000 Then
            chkBancarizar.Checked = True
         Else
            chkBancarizar.Checked = False
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtFacturaId.ReadOnly = True
      dtpFacturaFecha.ReadOnly = True
      cboRegRUC.ReadOnly = True
      cboNroRUC.ReadOnly = True
      txtNroAutorizacion.ReadOnly = True
      txtCodControl.ReadOnly = True
      txtFacturaNro.ReadOnly = True
      txtFacturaMonto.ReadOnly = True
      txtIceIehd.ReadOnly = True
      txtExento.ReadOnly = True
      txtNeto.ReadOnly = True
      txtIVA.ReadOnly = True
      txtImporteIVA.ReadOnly = True
      txtFacturaObs.ReadOnly = True
      chkBancarizar.Enabled = False
      cboTipoFacCompra.ReadOnly = True
      cboEstado.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("FormClear").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moFactura
         If Not mboolAdding Then
            .FacturaId = ToLong(txtFacturaId.Text)
         End If

         .MesId = dtpFacturaFecha.Value.Month
         ''.FacturaFecha = ToDate(dtpFacturaFecha.Value)
         .FacturaFecha = ToDateDMY(dtpFacturaFecha.Value)
         .FacturaNro = ToLong(txtFacturaNro.Text)
         .FacturaMonto = ToDecimal(txtFacturaMonto.Text)
         .RegRUCId = ListPosition(cboRegRUC)
         .RegRUCDes = ToStr(cboRegRUC.Text)
         .NroRUC = ToStr(cboNroRUC.Text)
         .NroAutorizacion = ToStr(txtNroAutorizacion.Text)
         .IVA = ToDecimal(txtIVA.Text)
         .IceIehd = ToDecimal(txtIceIehd.Text)
         .Exento = ToDecimal(txtExento.Text)
         .Descuento = ToDecimal(txtDescuento.Text)
         .FacturaObs = ToStr(txtFacturaObs.Text)
         .Bancarizar = ToBoolean(chkBancarizar.Checked)
         .TipoFacCompraId = ListPosition(cboTipoFacCompra, cboTipoFacCompra.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

         .CodControl = ToStr(txtCodControl.Text)

         Do While (Microsoft.VisualBasic.Right(.CodControl, 1) = "-") And (.CodControl.Length > 2)
            .CodControl = Microsoft.VisualBasic.Left(.CodControl, .CodControl.Length - 1)
         Loop
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      If moFactura.TipoFacturaId = 1 Then 'Venta
         If clsAppInfo.CodBarra Then
            txtQRDes.Text = String.Empty
            txtQRDes.Select()
         Else
            txtFacturaNro.Select()
         End If

      Else 'Compra
         If clsAppInfo.CodBarra Then
            txtQRDes.Text = String.Empty
            txtQRDes.Select()
         Else
            txtFacturaNro.Select()
         End If
      End If

   End Sub

   Private Function DataSave() As Boolean
      Try
         txtFacturaNro.Select()
         Call DataMove()

         If mboolAdding Then
            DataSave = DataAdd()
         Else
            DataSave = DataUpdate()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If FormCheck() Then
            If moFactura.Validate() Then

               If moFactura.RegRUCId = 0 Then
                  Call RegRUCAdd()
               Else
                  If mstrNroAutorizacion <> (txtNroAutorizacion.Text).Trim Then
                     RegRUCUpdate()
                  End If
               End If

               mboolAdding = False
               DataAdd = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If FormCheck() Then
            If moFactura.Validate() Then

               ''If moFactura.UpdateOnly() Then
               If moFactura.RegRUCId = 0 Then
                  Call RegRUCAdd()
               Else
                  If mstrNroAutorizacion <> (txtNroAutorizacion.Text).Trim Then
                     RegRUCUpdate()
                  End If
               End If

               DataUpdate = True
               ''End If
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If ToStr(dtpFacturaFecha.Text) = "" Then
         strMsg &= "Fecha de Factura no V�lida" & vbCrLf
      End If

      If moFactura.TipoFacturaId = 1 Then 'Venta
         If moFactura.RegRUCDes = "" Then
            strMsg &= "Raz�n Social Inv�lida" & vbCrLf

            If moFactura.FacturaNro <= 0 Then
               strMsg &= "N�mero de Factura Inv�lido" & vbCrLf
            End If

            If moFactura.NroRUC = "0" Then
               strMsg &= "N�mero de NIT Inv�lido" & vbCrLf
            End If

            If moFactura.NroAutorizacion = "0" Then
               strMsg &= "N�mero de Autorizaci�n Inv�lido" & vbCrLf
            End If

            If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
               strMsg &= "C�digo de Control Inv�lido" & vbCrLf
            End If

            If moFactura.FacturaMonto <= 0 Then
               strMsg &= "Importe Inv�lido" & vbCrLf

            ElseIf moFactura.IceIehd + moFactura.Exento + moFactura.Descuento > moFactura.FacturaMonto Then
               strMsg &= "El (ICE/IEHD + Exento + Descuento) Deben Ser Menor o Igual al Importe Total" & vbCrLf
            End If

            If moFactura.IceIehd < 0 Then
               strMsg &= "ICE/IEHD Inv�lido" & vbCrLf
            End If

            If moFactura.Exento < 0 Then
               strMsg &= "Exento Inv�lido" & vbCrLf
            End If

            If moFactura.Descuento < 0 Then
               strMsg &= "Descuento Inv�lido" & vbCrLf
            End If

         ElseIf (moFactura.RegRUCId > 0) And (moFactura.RegRUCId < 5) Then 'Anuladas
            If moFactura.FacturaNro <= 0 Then
               strMsg &= "N�mero de Factura Inv�lido" & vbCrLf
            End If

            If moFactura.NroRUC <> "0" Then
               strMsg &= "N�mero de NIT Inv�lido" & vbCrLf
            End If

            If moFactura.NroAutorizacion = "0" Then
               strMsg &= "N�mero de Autorizaci�n Inv�lido" & vbCrLf
            End If

            If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
               strMsg &= "C�digo de Control Inv�lido" & vbCrLf
            End If

            If moFactura.FacturaMonto <> 0 Then
               strMsg &= "Importe Inv�lido" & vbCrLf
            End If

         Else
            If moFactura.FacturaNro <= 0 Then
               strMsg &= "N�mero de Factura Inv�lido" & vbCrLf
            End If

            If moFactura.NroRUC = "0" Then
               strMsg &= "N�mero de NIT Inv�lido" & vbCrLf
            End If

            If moFactura.NroAutorizacion = "0" Then
               strMsg &= "N�mero de Autorizaci�n Inv�lido" & vbCrLf
            End If

            If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
               strMsg &= "C�digo de Control Inv�lido" & vbCrLf
            End If

            If moFactura.FacturaMonto <= 0 Then
               strMsg &= "Importe Inv�lido" & vbCrLf

            ElseIf moFactura.IceIehd + moFactura.Exento + moFactura.Descuento > moFactura.FacturaMonto Then
               strMsg &= "El (ICE/IEHD + Exento + Descuento) Deben Ser Menor o Igual al Importe Total" & vbCrLf
            End If

            If moFactura.IceIehd < 0 Then
               strMsg &= "ICE/IEHD Inv�lido" & vbCrLf
            End If

            If moFactura.Exento < 0 Then
               strMsg &= "Exento Inv�lido" & vbCrLf
            End If

            If moFactura.Descuento < 0 Then
               strMsg &= "Descuento Inv�lido" & vbCrLf
            End If

         End If

      Else 'Compra
         If moFactura.FacturaNro <= 0 Then
            strMsg &= "N�mero de Factura Inv�lido" & vbCrLf
         End If

         If moFactura.RegRUCDes = "" Then
            strMsg &= "Raz�n Social Inv�lida" & vbCrLf

         ElseIf (moFactura.RegRUCId > 0) And (moFactura.RegRUCId < 5) Then
            FormCheck = False
            Throw New Exception("Raz�n Social Inv�lida en Factura de Compra")
         End If

         If moFactura.NroRUC = "0" Then
            strMsg &= "N�mero de NIT Inv�lido" & vbCrLf
         End If

         If moFactura.NroAutorizacion = "0" Then
            strMsg &= "N�mero de Autorizaci�n Inv�lido" & vbCrLf
         End If

         If (moFactura.CodControl.Length <> 0) And (moFactura.CodControl.Length <> 11) And (moFactura.CodControl.Length <> 14) Then
            strMsg &= "C�digo de Control Inv�lido" & vbCrLf
         End If

         If moFactura.FacturaMonto <= 0 Then
            strMsg &= "Importe Inv�lido" & vbCrLf

         ElseIf moFactura.IceIehd + moFactura.Exento + moFactura.Descuento > moFactura.FacturaMonto Then
            strMsg &= "El (ICE/IEHD + Exento + Descuento) Deben Ser Menor o Igual al Importe Total" & vbCrLf
         End If

         If moFactura.IceIehd < 0 Then
            strMsg &= "ICE/IEHD Inv�lido" & vbCrLf
         End If

         If moFactura.Exento < 0 Then
            strMsg &= "Exento Inv�lido" & vbCrLf
         End If

         If moFactura.Descuento < 0 Then
            strMsg &= "Descuento Inv�lido" & vbCrLf
         End If

         If moFactura.TipoFacCompraId <= 0 Then
            strMsg &= "Tipo de Compra Inv�lido" & vbCrLf
         End If

         Dim lngFacturaDup As Long = DuplicateFacturaIdFind(moFactura.FacturaId, moFactura.FacturaNro, moFactura.NroAutorizacion)
         If (lngFacturaDup <> mlngFacturaIdOrg) And (lngFacturaDup > 0) Then
            strMsg &= "Factura Duplicada" & vbCrLf
         End If

      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function GestionFind(ByVal lngGestionId As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFind = 0

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               GestionFind = .Gestion
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function NroAutorizacionFind(ByVal lngRegRUCId As Long) As String
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .RegRUCId = lngRegRUCId

            If .FindByPK Then
               NroAutorizacionFind = .NroAutorizacion
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function RegRUCAdd() As Boolean
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.RegRUC
            .EmpresaId = moFactura.EmpresaId
            .NroRUC = moFactura.NroRUC

            If Not .Find Then
               .EmpresaId = moFactura.EmpresaId
               .NroRUC = moFactura.NroRUC
               .RegRUCDes = moFactura.RegRUCDes
               .NroAutorizacion = moFactura.NroAutorizacion
               .PlanId = 0

               If moFactura.TipoFacturaId = 1 Then 'Ventas
                  .NroAutorizacion = "0"
               Else
                  .NroAutorizacion = moFactura.NroAutorizacion
               End If

               If .Insert Then
                  RegRUCAdd = True
               End If
            Else
               RegRUCAdd = True
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function RegRUCUpdate() As Boolean
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC

            .RegRUCId = moFactura.RegRUCId

            If .FindByPK Then
               .NroAutorizacion = moFactura.NroAutorizacion

               If .Update() Then
                  RegRUCUpdate = True
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtFacturaMonto.FormatString = DecimalMask()
      txtIceIehd.FormatString = DecimalMask()
      txtExento.FormatString = DecimalMask()
      txtDescuento.FormatString = DecimalMask()
      txtSubTotal.FormatString = DecimalMask()
      txtNeto.FormatString = DecimalMask()
      txtIVA.FormatString = DecimalMask()
      txtImporteIVA.FormatString = DecimalMask()

      If clsAppInfo.CodBarra Then
         If mboolAdding Then
            txtQRDes.Visible = True
            txtQRDes.Text = String.Empty

         Else
            txtQRDes.Visible = False
         End If

      Else
         txtQRDes.Visible = False
      End If

   End Sub

   Private Sub ComboLoad()
      Call cboRegRUCLoad()
      Call cboTipoFacCompraLoad()
      Call cboEstadoLoad()
   End Sub

   Private Sub cboRegRUCLoad()
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      Try
         With oRegRUC
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.EmpresaId
            .OrderByFilter = clsRegRUC.OrderByFilters.RegRUCDes
            .EmpresaId = moFactura.EmpresaId

            If .Open() Then
               With cboRegRUC
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("RegRUCId")
                  .DropDownList.Columns("RegRUCId").DataMember = "RegRUCId"
                  .DropDownList.Columns("RegRUCId").Visible = False

                  .DropDownList.Columns.Add("NroRUC")
                  .DropDownList.Columns("NroRUC").Caption = "NIT"
                  .DropDownList.Columns("NroRUC").DataMember = "NroRUC"
                  .DropDownList.Columns("NroRUC").Width = 100

                  .DropDownList.Columns.Add("RegRUCDes")
                  .DropDownList.Columns("RegRUCDes").Caption = "Descripci�n"
                  .DropDownList.Columns("RegRUCDes").DataMember = "RegRUCDes"
                  .DropDownList.Columns("RegRUCDes").Width = 205

                  .DataMember = oRegRUC.TableName
                  .DataSource = oRegRUC.DataSet

                  .ValueMember = "RegRUCId"
                  .DisplayMember = "RegRUCDes"
               End With

               With cboNroRUC
                  .DropDownList.Columns.Clear()

                  .DropDownList.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False

                  .DropDownList.Columns.Add("RegRUCId")
                  .DropDownList.Columns("RegRUCId").DataMember = "RegRUCId"
                  .DropDownList.Columns("RegRUCId").Visible = False

                  .DropDownList.Columns.Add("NroRUC")
                  .DropDownList.Columns("NroRUC").DataMember = "NroRUC"
                  .DropDownList.Columns("NroRUC").Width = 90

                  .DataMember = oRegRUC.TableName
                  .DataSource = oRegRUC.DataSet

                  .ValueMember = "RegRUCId"
                  .DisplayMember = "NroRUC"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Sub

   Private Sub cboTipoFacCompraLoad()
      Dim oTipoFacCompra As New clsTipoFacCompra(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoFacCompra.Items.Clear()

      Try
         With oTipoFacCompra
            .SelectFilter = clsTipoFacCompra.SelectFilters.ListBox
            .OrderByFilter = clsTipoFacCompra.OrderByFilters.TipoFacCompraId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoFacCompraId, .TipoFacCompraDes)

                  cboTipoFacCompra.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoFacCompra.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboEstadoLoad()
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboEstado.Items.Clear()

      Try
         With oEstado
            .SelectFilter = clsEstado.SelectFilters.ListBox
            .WhereFilter = clsEstado.WhereFilters.TipoId
            .OrderByFilter = clsEstado.OrderByFilters.EstadoDes
            .TipoId = 2

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.EstadoId, .EstadoDes)

                  cboEstado.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEstado.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Function DuplicateFacturaIdFind(ByVal lngFacturaId As Long, ByVal lngFacturaNro As Long, ByVal strNroAutorzacion As String) As Long
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      DuplicateFacturaIdFind = 0

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaDuplicada
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoFacturaId = 2
            .NroAutorizacion = strNroAutorzacion
            .FacturaNro = lngFacturaNro
            .FacturaId = lngFacturaId

            If .Find Then
               DuplicateFacturaIdFind = .FacturaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Sub cboRegRUC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRegRUC.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            Dim frm As New frmRegRUCEdit
            Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

            Try
               With frm
                  .NewRecord = True
                  .Editing = False

                  oRegRUC.EmpresaId = moFactura.EmpresaId
                  .DataObject = oRegRUC
                  .ShowDialog()

                  If .Changed Then
                     Call cboRegRUCLoad()
                     cboRegRUC.Value = ListFindItem(cboRegRUC, ToLong(frm.ID))
                  End If
                  frm.Dispose()
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Finally
               oRegRUC.Dispose()

            End Try

         ElseIf e.KeyCode = Keys.F2 Then
            If ListPosition(cboRegRUC) <> 0 Then
               Dim frm As New frmRegRUCEdit
               Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

               Try
                  With frm
                     oRegRUC.RegRUCId = ListPosition(cboRegRUC)

                     If oRegRUC.FindByPK Then
                        .NewRecord = False
                        .Editing = True

                        .DataObject = oRegRUC
                        .ShowDialog()

                        If .Changed Then
                           Call cboRegRUCLoad()
                           cboRegRUC.Value = ListFindItem(cboRegRUC, ToLong(frm.ID))
                        End If

                        frm.Dispose()
                     End If
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oRegRUC.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboRegRUC_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegRUC.LostFocus
      If cboRegRUC.Tag <> cboRegRUC.Text Then
         cboRegRUC.Tag = cboRegRUC.Text

         If ListPosition(cboRegRUC) <> 0 Then
            cboNroRUC.Value = ListFindItem(cboNroRUC, ListPosition(cboRegRUC))
            cboNroRUC.Tag = cboNroRUC.Text

            If moFactura.TipoFacturaId = 2 Then 'Compra
               txtNroAutorizacion.Text = NroAutorizacionFind(ListPosition(cboRegRUC))
               mstrNroAutorizacion = txtNroAutorizacion.Text
            End If

            txtCodControl.Text = ""
         End If
      End If
   End Sub

   Private Sub cboNroRUC_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNroRUC.LostFocus
      If cboNroRUC.Tag <> cboNroRUC.Text Then
         cboNroRUC.Tag = cboNroRUC.Text

         If ListPosition(cboNroRUC) <> 0 Then
            cboRegRUC.Value = ListFindItem(cboRegRUC, ListPosition(cboNroRUC))
            cboRegRUC.Tag = cboRegRUC.Text

            If moFactura.TipoFacturaId = 2 Then 'Compra
               txtNroAutorizacion.Text = NroAutorizacionFind(ListPosition(cboNroRUC))
               mstrNroAutorizacion = txtNroAutorizacion.Text
            End If

            txtCodControl.Text = ""
         End If
      End If
   End Sub

   Private Sub cboNroRUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboNroRUC.KeyPress
      Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

      KeyAscii = CShort(SoloNumeros(KeyAscii))
      If KeyAscii = 0 Then
         e.Handled = True
      End If
   End Sub

   Private Sub txtNroAutorizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroAutorizacion.KeyPress
      Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

      KeyAscii = CShort(SoloNumeros(KeyAscii))
      If KeyAscii = 0 Then
         e.Handled = True
      End If
   End Sub

   Private Sub txtFacturaNro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFacturaNro.KeyPress
      Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

      KeyAscii = CShort(SoloNumeros(KeyAscii))
      If KeyAscii = 0 Then
         e.Handled = True
      End If
   End Sub

   Private Sub txtFacturaMonto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFacturaMonto.KeyUp
      txtSubTotal.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text) + ToDecimal(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))

      If ToDecimal(txtFacturaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If
   End Sub

   Private Sub txtFacturaMonto_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacturaMonto.LostFocus
      txtSubTotal.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text) + ToDecimal(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))

   End Sub

   Private Sub txtIceIehd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIceIehd.KeyUp
      txtSubTotal.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text) + ToDecimal(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))
   End Sub

   Private Sub txtExento_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExento.KeyUp
      txtSubTotal.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text) + ToDecimal(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))

   End Sub

   Private Sub txtDescuento_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescuento.KeyUp
      txtSubTotal.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text) + ToDecimal(txtDescuento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))
   End Sub

#Region "Lectura QR"

   Private Function RegRUCDesFind(ByVal strNroRUC As String, ByRef lngRegRUCId As Long) As String
      Dim oRegRUC As New clsRegRUC(clsAppInfo.ConnectString)

      RegRUCDesFind = ""
      lngRegRUCId = 0

      Try
         With oRegRUC
            .SelectFilter = clsRegRUC.SelectFilters.All
            .WhereFilter = clsRegRUC.WhereFilters.NroRUC
            .EmpresaId = moFactura.EmpresaId
            .NroRUC = strNroRUC

            If .Find Then
               lngRegRUCId = .RegRUCId
               RegRUCDesFind = .RegRUCDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRegRUC.Dispose()

      End Try
   End Function

   Private Function FormCheckQR(ByVal strFechaQR As String) As String
      Dim strMsg As String = String.Empty
      Dim datFechaQR As Date

      datFechaQR = ToDate2(strFechaQR)

      If datFechaQR.Year <> 1 Then
         If moFactura.TipoFacturaId = 1 Then 'Venta
            If datFechaQR < mdatFechaIni Then
               strMsg &= "La Fecha es Inferior a la Fecha Inicial de la Dosificaci�n" & vbCrLf
            End If

            If datFechaQR > mdatFechaFin Then
               strMsg &= "La Fecha es Mayor a la Fecha Final de la Dosificaci�n" & vbCrLf
            End If

         Else 'Compra
            If datFechaQR < dtpFacturaFecha.MinDate Then
               strMsg &= "La Fecha es Inferior a la Fecha Inicial del Periodo" & vbCrLf
            End If

            If datFechaQR > dtpFacturaFecha.MaxDate Then
               strMsg &= "La Fecha es Mayor a la Fecha Final del Periodo" & vbCrLf
            End If
         End If

      Else
         strMsg &= "Formato de Fecha Diferente DD-MM-YYYY <> " & strFechaQR & vbCrLf
      End If

      FormCheckQR = strMsg
   End Function

   Private Function SepDecimalReplace(ByVal strValue As String) As String
      Dim strSepDecimal As String = strValue

      If IsNumeric(strValue) Then
         If mstrSepDecimal = "," Then
            If strValue.Contains(".") Then
               strSepDecimal = Replace(strValue, ".", ",")
            End If

         ElseIf mstrSepDecimal = "." Then
            If strValue.Contains(",") Then
               strSepDecimal = Replace(strValue, ",", ".")
            End If
         End If
      End If

      Return strSepDecimal
   End Function

   Private Function CodControlReplace(ByVal strValue As String) As String
      Dim strCodControl As String = strValue

      If strValue.Contains("'") Then
         strCodControl = Replace(strValue, "'", "-")

      ElseIf strValue.Contains("�") Then
         strCodControl = Replace(strValue, "�", "-")
      End If

      Return UCase(strCodControl)
   End Function

   Private Sub FormNewQR()
      Dim lngRegRUCId As Long
      Dim strNroRUC As String
      Dim strRegRUCDes As String
      Dim strFormCheckQR As String

      Try
         mboolAdding = True

         Call DataClear()

         strFormCheckQR = FormCheckQR(ToStr(mstrQRDes(3)))

         If strFormCheckQR <> String.Empty Then
            If MessageBox.Show(strFormCheckQR & "�Quiere continuar con el llenado de la factura?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
               Exit Sub
            End If
         End If

         If moFactura.TipoFacturaId = 1 Then 'Venta
            cboNroRUC.Select()
            txtNroAutorizacion.TabStop = False
            txtCodControl.TabStop = False
            txtIceIehd.TabStop = False
            txtExento.TabStop = False
            txtDescuento.TabStop = False

         Else 'Compra
            txtFacturaNro.Select()
         End If

         dtpFacturaFecha.Text = ToStr(mstrQRDes(3))
         txtNroAutorizacion.Text = ToStr(mstrQRDes(2))
         txtCodControl.Text = CodControlReplace(ToStr(mstrQRDes(6)))

         txtFacturaNro.Text = ToStr(mstrQRDes(1))
         txtFacturaMonto.Text = SepDecimalReplace(ToStr(mstrQRDes(4)))
         txtIceIehd.Text = SepDecimalReplace(ToStr(mstrQRDes(8)))
         txtExento.Text = SepDecimalReplace(ToStr(mstrQRDes(10)))
         txtDescuento.Text = SepDecimalReplace(ToStr(mstrQRDes(11)))

         txtSubTotal.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtExento.Text) + ToDecimal(txtIceIehd.Text)))
         txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtExento.Text) + ToDecimal(txtIceIehd.Text) + ToDecimal(txtDescuento.Text)))
         txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
         txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))

         If (ToDecimal(txtFacturaMonto.Text) - ToDecimal(txtDescuento.Text)) >= 50000 Then
            chkBancarizar.Checked = True
         Else
            chkBancarizar.Checked = False
         End If

         If moFactura.TipoFacturaId = 1 Then 'Venta
            strNroRUC = ToStr(mstrQRDes(7))
            strRegRUCDes = RegRUCDesFind(strNroRUC, lngRegRUCId)

         Else 'Compra
            strNroRUC = ToStr(mstrQRDes(0))
            strRegRUCDes = RegRUCDesFind(strNroRUC, lngRegRUCId)
         End If

         If lngRegRUCId > 0 Then
            cboRegRUC.Value = ListFindItem(cboRegRUC, lngRegRUCId)
            cboRegRUC.Tag = strRegRUCDes
            cboNroRUC.Value = ListFindItem(cboNroRUC, lngRegRUCId)
            cboNroRUC.Tag = strNroRUC

         Else
            cboNroRUC.Tag = strNroRUC
            cboNroRUC.Value = strNroRUC
         End If

         cboTipoFacCompra.SelectedIndex = ListFindItem(cboTipoFacCompra, 1) 'Compras para mercado interno con destino a actividades gravadas
         cboEstado.ReadOnly = True

         txtFacturaNro.Select()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub txtQRDes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQRDes.KeyDown
      If e.KeyCode = Keys.Return Then
         Dim strQRDes As String

         strQRDes = ToStr(txtQRDes.Text)

         If strQRDes.Contains("|") Then
            mstrQRDes = strQRDes.Split("|")

         ElseIf strQRDes.Contains("]") Then
            mstrQRDes = strQRDes.Split("]")

         ElseIf strQRDes.Contains("�") Then
            mstrQRDes = strQRDes.Split("�")

         Else
            mstrQRDes = strQRDes.Split()
         End If

         If mstrQRDes.Count() = 12 Then
            Call FormNewQR()
         End If
      End If
   End Sub

#End Region

   Private Sub frmFacturaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moFactura.FacturaId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmFacturaEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moFactura.Dispose()
      Call ClearMemory()
   End Sub

End Class
