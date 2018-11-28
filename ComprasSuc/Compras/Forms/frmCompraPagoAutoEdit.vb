Public Class frmCompraPagoAutoEdit
   Inherits System.Windows.Forms.Form

   Private moPago As clsPago
   Private mdecUfv As Decimal

   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngTipoPlanId As Long
   Private mboolTieneComp As Boolean

   Private mlngMonedaIdPlan As Long
   Private mboolAplicarITF As Boolean
   Private mstrPlanDes As String

   Private mlngCompraId As Long
   Private mstrCompraNro As String
   Private mlngVendedorId As Long
   Private mdatFecha As Date
   Private mstrProveedorDes As String

   Private mdecMontoPagBs As Decimal
   Private mdecMontoPagUs As Decimal

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

   Property CompraId() As Long
      Get
         Return mlngCompraId
      End Get

      Set(ByVal Value As Long)
         mlngCompraId = Value
      End Set
   End Property

   Property CompraNro() As String
      Get
         Return mstrCompraNro
      End Get

      Set(ByVal Value As String)
         mstrCompraNro = Value
      End Set
   End Property

   Property VendedorId() As Long
      Get
         Return mlngVendedorId
      End Get

      Set(ByVal Value As Long)
         mlngVendedorId = Value
      End Set
   End Property

   Property Fecha() As Date
      Get
         Return mdatFecha
      End Get

      Set(ByVal Value As Date)
         mdatFecha = Value
      End Set
   End Property

   Property ProveedorDes() As String
      Get
         Return mstrProveedorDes
      End Get

      Set(ByVal Value As String)
         mstrProveedorDes = Value
      End Set
   End Property

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

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   Property DataObject() As clsPago
      Get
         Return moPago
      End Get

      Set(ByVal Value As clsPago)
         moPago = Value
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
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtMontoPag As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtPagoDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEquiUfv As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboPlanAdd As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Public WithEvents chkTieneComp As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents chkPlan As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents cboCentroCostoDet As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraPagoAutoEdit))
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCostoDet = New Janus.Windows.EditControls.UIComboBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboPlanAdd = New Janus.Windows.EditControls.UIComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.chkTieneComp = New Janus.Windows.EditControls.UICheckBox
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.chkPlan = New Janus.Windows.EditControls.UICheckBox
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtEquiUfv = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtPagoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtMontoPag = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("0e9a011c-64a3-47fa-80f4-631873a99f25")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(155, 28)
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
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
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
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 278)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboCentroCostoDet)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.cboPlanAdd)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.chkTieneComp)
      Me.grpMain.Controls.Add(Me.cboCentroCosto)
      Me.grpMain.Controls.Add(Me.cboSucursal)
      Me.grpMain.Controls.Add(Me.chkPlan)
      Me.grpMain.Controls.Add(Me.cboPlan)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 112)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 160)
      Me.grpMain.TabIndex = 6
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCostoDet
      '
      Me.cboCentroCostoDet.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.Location = New System.Drawing.Point(116, 84)
      Me.cboCentroCostoDet.Name = "cboCentroCostoDet"
      Me.cboCentroCostoDet.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCostoDet.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCostoDet.TabIndex = 11
      Me.cboCentroCostoDet.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 88)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 218
      Me.Label7.Text = "Actividad de C.C."
      '
      'cboPlanAdd
      '
      Me.cboPlanAdd.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAdd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAdd.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAdd.Location = New System.Drawing.Point(116, 36)
      Me.cboPlanAdd.Name = "cboPlanAdd"
      Me.cboPlanAdd.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanAdd.Size = New System.Drawing.Size(320, 20)
      Me.cboPlanAdd.TabIndex = 9
      Me.cboPlanAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 40)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 214
      Me.Label3.Text = "Analítico Adicioinal"
      '
      'chkTieneComp
      '
      Me.chkTieneComp.BackColor = System.Drawing.Color.Transparent
      Me.chkTieneComp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkTieneComp.Checked = True
      Me.chkTieneComp.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkTieneComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkTieneComp.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkTieneComp.Location = New System.Drawing.Point(292, 136)
      Me.chkTieneComp.Name = "chkTieneComp"
      Me.chkTieneComp.Size = New System.Drawing.Size(144, 16)
      Me.chkTieneComp.TabIndex = 13
      Me.chkTieneComp.Text = "Generar Comprobante"
      Me.chkTieneComp.Visible = False
      Me.chkTieneComp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(116, 60)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCosto.TabIndex = 10
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboSucursal
      '
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(116, 108)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(320, 20)
      Me.cboSucursal.TabIndex = 12
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkPlan
      '
      Me.chkPlan.BackColor = System.Drawing.Color.Transparent
      Me.chkPlan.Checked = True
      Me.chkPlan.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkPlan.Location = New System.Drawing.Point(100, 12)
      Me.chkPlan.Name = "chkPlan"
      Me.chkPlan.Size = New System.Drawing.Size(16, 16)
      Me.chkPlan.TabIndex = 7
      Me.chkPlan.TabStop = False
      Me.chkPlan.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboPlan
      '
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(116, 12)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(320, 20)
      Me.cboPlan.TabIndex = 8
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 64)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 212
      Me.Label5.Text = "Centro de Costo"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 112)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 211
      Me.Label4.Text = "Sucursal"
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(8, 16)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(88, 16)
      Me.Label17.TabIndex = 200
      Me.Label17.Text = "Cuenta"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtEquiUfv)
      Me.UiGroupBox1.Controls.Add(Me.Label13)
      Me.UiGroupBox1.Controls.Add(Me.Label9)
      Me.UiGroupBox1.Controls.Add(Me.txtPagoDes)
      Me.UiGroupBox1.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.txtMontoPag)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 0)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 112)
      Me.UiGroupBox1.TabIndex = 0
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtEquiUfv
      '
      Me.txtEquiUfv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEquiUfv.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEquiUfv.FormatString = "##,##0.000"
      Me.txtEquiUfv.Location = New System.Drawing.Point(312, 36)
      Me.txtEquiUfv.Name = "txtEquiUfv"
      Me.txtEquiUfv.ReadOnly = True
      Me.txtEquiUfv.Size = New System.Drawing.Size(124, 20)
      Me.txtEquiUfv.TabIndex = 3
      Me.txtEquiUfv.TabStop = False
      Me.txtEquiUfv.Text = "0,000"
      Me.txtEquiUfv.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtEquiUfv.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtEquiUfv.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(280, 40)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(28, 16)
      Me.Label13.TabIndex = 261
      Me.Label13.Text = "UFV"
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 68)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 255
      Me.Label9.Text = "Observaciones"
      '
      'txtPagoDes
      '
      Me.txtPagoDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPagoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPagoDes.Location = New System.Drawing.Point(116, 64)
      Me.txtPagoDes.MaxLength = 255
      Me.txtPagoDes.Multiline = True
      Me.txtPagoDes.Name = "txtPagoDes"
      Me.txtPagoDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPagoDes.Size = New System.Drawing.Size(320, 40)
      Me.txtPagoDes.TabIndex = 5
      Me.txtPagoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPagoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(116, 12)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(124, 20)
      Me.cboMoneda.TabIndex = 1
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(8, 16)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 240
      Me.Label2.Text = "Moneda"
      '
      'txtMontoPag
      '
      Me.txtMontoPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoPag.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoPag.FormatString = "##,##0.000"
      Me.txtMontoPag.Location = New System.Drawing.Point(116, 36)
      Me.txtMontoPag.Name = "txtMontoPag"
      Me.txtMontoPag.ReadOnly = True
      Me.txtMontoPag.Size = New System.Drawing.Size(124, 20)
      Me.txtMontoPag.TabIndex = 2
      Me.txtMontoPag.Text = "0,000"
      Me.txtMontoPag.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoPag.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoPag.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 40)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 230
      Me.Label6.Text = "Monto a Pagar"
      '
      'frmCompraPagoAutoEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 306)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompraPagoAutoEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Cobranza Automática de Notas al Contado Edit"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Save"
            cboPlan.Select()

            If DataSave() Then
               mlngID = moPago.PagoId
               mboolChanged = True

               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompraPagoAutoEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompraPagoAutoEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()

      If Not mboolAdding Then
         Call FormShow()
         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Pago de Notas al Contado"
         Else
            Me.Text = "Editar Pago de Notas al Contado"
         End If
      Else
         Me.Text = "Nuevo Pago de Notas al Contado"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moPago
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         'txtMontoPag.Text = ToDecStr(.MontoPag)
         txtPagoDes.Text = ToStr(.PagoDes)
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moPago
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         'txtMontoPag.Text = "0"
         txtPagoDes.Text = String.Empty

         cboPlanAdd.SelectedIndex = -1
         cboPlanAdd.Enabled = False
         cboSucursal.SelectedIndex = -1
         cboSucursal.Enabled = False
         cboCentroCosto.SelectedIndex = -1
         cboCentroCosto.Enabled = False
         cboCentroCostoDet.SelectedIndex = -1
         cboCentroCostoDet.Enabled = False

         If clsAppInfo.CentroCostoApli Then
            cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, .CentroCostoId)
            cboCentroCosto.Enabled = False
            cboCentroCosto.ReadOnly = True

            Call cboCentroCostoDetLoad(.CentroCostoId)
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      cboMoneda.ReadOnly = True
      txtMontoPag.ReadOnly = True
      txtPagoDes.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moPago
         If Not mboolAdding Then

         End If

         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .Capital = ToDecimal(txtMontoPag.Text)
         .Interes = 0
         .MontoPag = ToDecimal(txtMontoPag.Text)
         .PlanRecargoId = 0
         .MontoRec = 0
         .PlanDescuentoId = 0
         .MontoDes = 0
         .PagoDes = ToStr(txtPagoDes.Text)
         .EstadoId = 11

         mboolTieneComp = ToBoolean(chkTieneComp.Checked)

         If mboolTieneComp Then
            mlngPlanId = ListPosition(cboPlan)
            mlngPlanAddId = ListPosition(cboPlanAdd, cboPlanAdd.SelectedIndex)
            mlngSucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
            mlngCentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
            mlngCentroCostoDetId = ListPosition(cboCentroCostoDet, cboCentroCostoDet.SelectedIndex)
            ''mlngTipoPlanId = TipoPlanIdFind(mlngPlanId)
            mlngTipoPlanId = TipoPlanIdFind(mlngPlanId, mstrPlanDes, mlngMonedaIdPlan)
         Else
            mlngPlanId = 0
            mlngPlanAddId = 0
            mlngSucursalId = 0
            mlngCentroCostoId = 0
            mlngCentroCostoDetId = 0
            mlngTipoPlanId = 0

            mstrPlanDes = ""
            mlngMonedaIdPlan = 0
            mboolAplicarITF = False
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtPagoDes.Select()
   End Sub

   Private Function DataSave() As Boolean
      Dim lngCompId As Long
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim ProveedorMovId As Long
      mboolAplicarITF = False

      Try
         Call DataMove()

         If FormCheck() Then
            If mboolAdding Then
               If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad
                  moPago.PagoNro = CompraNroNext(7, clsAppInfo.GestionId, moPago.SucursalId)

                  If mlngTipoPlanId = 3 And mlngMonedaIdPlan = clsMoneda.DOLARES Then  'Tipo Cuenta 3 = Banco -- Cuenta Corriente
                     If MessageBox.Show("¿Desea Aplicar I.T.F. a la Cuenta  " & mstrPlanDes & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        mboolAplicarITF = True
                     End If
                  End If

                  If DataAdd() Then
                     If PagoDetAdd(mlngCompraId, mlngVendedorId, moPago.MontoPag, 0) Then
                        If CompNew(lngCompId, lngTipoCompId, lngCompNro) Then
                           If ProveedorMovAdd(ProveedorMovId, 7, moPago.PagoId, 1, moPago.PagoDes, moPago.MonedaId, moPago.Capital, 3, lngTipoCompId, lngCompNro, mlngPlanId) Then
                              moPago.CompId = lngCompId
                              moPago.PlanId = mlngPlanId 'Cuenta Variable

                              If DataUpdate() Then
                                 DataSave = True
                              End If
                           End If
                        End If
                     End If
                  End If
               Else
                  moPago.PagoNro = CompraNroNext(7, clsAppInfo.GestionId, moPago.SucursalId)

                  If DataAdd() Then
                     If PagoDetAdd(mlngCompraId, mlngVendedorId, moPago.MontoPag, 0) Then
                        If ProveedorMovAdd(ProveedorMovId, 7, moPago.PagoId, 1, moPago.PagoDes, moPago.MonedaId, moPago.Capital, 3, lngTipoCompId, lngCompNro, mlngPlanId) Then
                           DataSave = True
                        End If
                     End If
                  End If
               End If
            Else
               DataSave = DataUpdate()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moPago.Insert() Then
            mboolAdding = False
            DataAdd = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moPago.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If moPago.MonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If ToDecimal(txtMontoPag.Text) <= 0 Then
         strMsg &= "Monto a Pagar Inválido" & vbCrLf
      End If

      If mboolTieneComp Then
         If ListPosition(cboPlan) = 0 Then
            strMsg &= "Seleccione la Cuenta" & vbCrLf
         Else
            If cboPlanAdd.Enabled Then
               If ListPosition(cboPlanAdd, cboPlanAdd.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione el Analítico Adicional" & vbCrLf
               End If
            End If

            If cboSucursal.Enabled Then
               If ListPosition(cboSucursal, cboSucursal.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione la Sucursal" & vbCrLf
               End If
            End If

            If cboCentroCosto.Enabled Then
               If ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione el Centro de Costo" & vbCrLf
               End If
            End If
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function PagoDetAdd(ByVal lngCompraId As Long, ByVal lngVendedorId As Long, ByVal decCapital As Decimal, ByVal decInteres As Decimal) As Boolean
      Dim oPagoDet As New clsPagoDet(clsAppInfo.ConnectString)

      PagoDetAdd = False

      Try
         With oPagoDet
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .TipoPagoId = moPago.TipoPagoId
            .PagoId = moPago.PagoId
            .CompraId = lngCompraId
            .CreditoId = 0
            .CreditoDetId = 0
            .ProveedorId = moPago.ProveedorId
            .Fecha = moPago.Fecha
            .MonedaId = moPago.MonedaId
            .TipoCambio = moPago.TipoCambio
            .CapitalOrg = decCapital
            .InteresOrg = decInteres
            .CapitalAmo = decCapital
            .InteresAmo = decInteres
            .CentroCostoId = moPago.CentroCostoId
            .SucursalId = moPago.SucursalId
            .EstadoId = 14

            If .Insert() Then
               PagoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPagoDet.Dispose()

      End Try
   End Function

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                   ByVal lngTipoPagoId As Long, ByVal strDes As String, ByVal lngMonedaId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                   ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .ProveedorId = moPago.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moPago.Fecha
            .ProveedorMovDes = "Compra Nro. " & mstrCompraNro & "; " & strDes
            .MonedaId = lngMonedaId
            .TipoCambio = moPago.TipoCambio
            .CentroCostoId = moPago.CentroCostoId
            .SucursalId = moPago.SucursalId
            .EstadoId = 11 'Abierto

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeBs = decValor
                  .DebeUs = ToDecimal(decValor / .TipoCambio)

                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberBs = decValor
                  .HaberUs = ToDecimal(decValor / .TipoCambio)

                  .DebeBs = 0
                  .DebeUs = 0

               ElseIf lngCol = 3 Then
                  .DebeBs = decValor
                  .DebeUs = ToDecimal(decValor / .TipoCambio)

                  .HaberBs = .DebeBs
                  .HaberUs = .DebeUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeBs = ToDecimal(decValor * .TipoCambio)
                  .DebeUs = decValor

                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberBs = ToDecimal(decValor * .TipoCambio)
                  .HaberUs = decValor

                  .DebeUs = 0
                  .DebeBs = 0

               ElseIf lngCol = 3 Then
                  .DebeBs = ToDecimal(decValor * .TipoCambio)
                  .DebeUs = decValor

                  .HaberBs = .DebeBs
                  .HaberUs = .DebeUs
               End If
            End If

            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .PlanId = lngPlanId

            If .Insert() Then
               lngProveedorMovId = .ProveedorMovId
               ProveedorMovAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function ProveedorMovUpdate(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, ByVal lngCol As Long, ByVal decValor As Decimal) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovUpdate = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId
            .EmpresaId = moPago.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .EstadoId = 11 'Abierto

            If .Find Then
               .Fecha = ToDate(.Fecha)

               If .MonedaId = 1 Then
                  If lngCol = 1 Then
                     .DebeBs = decValor
                     .DebeUs = ToDecimal(decValor / .TipoCambio)

                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberBs = decValor
                     .HaberUs = ToDecimal(decValor / .TipoCambio)

                     .DebeBs = 0
                     .DebeUs = 0

                  ElseIf lngCol = 3 Then
                     .DebeBs = decValor
                     .DebeUs = ToDecimal(decValor / .TipoCambio)

                     .HaberBs = .DebeBs
                     .HaberUs = .DebeUs
                  End If

               ElseIf .MonedaId = 2 Then
                  If lngCol = 1 Then
                     .DebeBs = ToDecimal(decValor * .TipoCambio)
                     .DebeUs = decValor

                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberBs = ToDecimal(decValor * .TipoCambio)
                     .HaberUs = decValor

                     .DebeUs = 0
                     .DebeBs = 0
                  End If

               ElseIf lngCol = 3 Then
                  .DebeBs = ToDecimal(decValor * .TipoCambio)
                  .DebeUs = decValor

                  .HaberBs = .DebeBs
                  .HaberUs = .DebeUs
               End If

               If .Update() Then
                  ProveedorMovUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function CompNew(ByRef lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      'Dim lngCompId As Long
      Dim lngCompDetId As Long
      Dim lngPlanIdPas As Long
      Dim lngPlanAddIdPas As Long
      Dim lngPlanIdInt As Long
      Dim lngPlanAddIdInt As Long
      Dim lngCompPlanAddId As Long
      Dim lngPlanIdRecargo As Long
      Dim lngPlanIdDescuento As Long

      Dim decITFBs As Decimal = 0
      Dim decITFUs As Decimal = 0
      Dim decITFOrg As Decimal = 0

      Dim decMontoOrg As Decimal
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0

      CompNew = True

      Try
         lngTipoCompId = 2 'Egreso
         '' lngPlanIdAct = PlanIdActFind(moPago.ProveedorId, lngPlanAddIdAct, lngPlanIdInt, lngPlanAddIdInt)
         lngPlanIdPas = PlanIdPasFind(moPago.ProveedorId, lngPlanAddIdPas, lngPlanIdInt, lngPlanAddIdInt)


         If mboolAplicarITF Then
            decITFBs = ToDecimal(mdecMontoPagBs * clsAppInfo.ITF)
            decITFUs = ToDecimal(mdecMontoPagBs * clsAppInfo.ITF)
         End If

         If (mdecMontoPagBs > 0) And (mdecMontoPagUs > 0) Then 'Monto a Pagar
            If CompAdd(lngTipoCompId, lngCompNro, lngCompId, mdecMontoPagBs + decITFBs, mdecMontoPagUs + decITFUs) Then 'Cabecera Comprobante
               If moPago.MonedaId = 1 Then
                  decMontoOrg = mdecMontoPagBs
                  decITFOrg = decITFBs

               ElseIf moPago.MonedaId = 2 Then
                  decMontoOrg = mdecMontoPagUs
                  decITFOrg = decITFUs
               End If

               'Cuenta Pasivo Proveedor
               If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdPas, "", mdecMontoPagBs, mdecMontoPagUs, decMontoOrg, 1, moPago.SucursalId, moPago.CentroCostoId, lngCompDetId) Then
                  If lngPlanAddIdPas <> 0 Then  'Analitico Adicional
                     If CompPlanAddAdd(lngCompId, lngCompDetId, lngPlanIdPas, lngPlanAddIdPas, mdecMontoPagBs, mdecMontoPagUs, 1, moPago.SucursalId) Then
                        CompNew = True
                     End If
                  End If
               End If

               'Cuenta Caja o banco
               If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", mdecMontoPagBs, mdecMontoPagUs, decMontoOrg, 2, mlngSucursalId, mlngCentroCostoId, lngCompDetId) Then
                  If mlngPlanAddId <> 0 Then  'Analitico Adicional
                     If CompPlanAddAdd(lngCompId, lngCompDetId, mlngPlanId, mlngPlanAddId, mdecMontoPagBs, mdecMontoPagUs, 2, moPago.SucursalId) Then
                        CompNew = True
                     End If
                  End If

                  If mlngCentroCostoDetId <> 0 Then  'Actividad
                     If CompCentroCostoDetAdd(lngCompId, lngCompDetId, mlngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, mdecMontoPagBs, mdecMontoPagUs, 2, moPago.SucursalId) Then
                        CompNew = True
                     End If
                  End If

                  If mlngTipoPlanId = 3 Then 'En Caso de que Tenga Chequera
                     If TieneChequeraCreada(mlngPlanId) Then
                        If frmCompChequeEditLoad(lngCompId, lngCompDetId, mlngPlanId, mdecMontoPagBs, mdecMontoPagUs) Then
                           CompNew = True
                        End If
                     Else
                        MessageBox.Show("Debe Definir la Chequera para Esta Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  End If
               End If

               'Aplicando ITF
               If mboolAplicarITF Then
                  If CompDetAdd(lngTipoCompId, lngCompId, mlngPlanId, "", decITFBs, decITFUs, decITFOrg, 2, mlngSucursalId, moPago.CentroCostoId, lngCompDetId, 1) Then
                     CompNew = True
                  End If

                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanITFId, "", decITFBs, decITFUs, decITFOrg, 1, mlngSucursalId, moPago.CentroCostoId, lngCompDetId, 1) Then
                     CompNew = True
                  End If
               End If

            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompAdd(ByVal lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long, ByVal decTotalBs As Decimal, ByVal decTotalUs As Decimal) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = CompNroNext(.TipoCompId, moPago.GestionId, moPago.SucursalId)
            .Fecha = moPago.Fecha
            .MonedaId = moPago.MonedaId
            .TipoCambio = moPago.TipoCambio
            .EntregadoA = mstrProveedorDes
            .PorConcepto = "Pago Nro. " & moPago.PagoNro & ";" & " de Nota de Compra al Contado Nro. " & mstrCompraNro & "; " & ToStr(txtPagoDes.Text)
            .DebeBs = decTotalBs
            .HaberBs = decTotalBs
            .DebeUs = decTotalUs
            .HaberUs = decTotalUs
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF
            .ConFac = moPago.ConFac
            .SinFac = moPago.SinFac

            .Automatico = 0
            .Glosa = ""
            '.TipoNotaId = 0
            '.NotaNro = 0
            .TipoAsientoId = 0
            .EstadoId = 10

            .SucursalId = moPago.SucursalId
            .NotaId = 0
            .AppId = moPago.AppId
            .TipoDocumentoId = clsTipoCompra.PAGO_CREDITO
            .DocumentoId = moPago.PagoId

            If .Insert() Then
               lngCompId = .CompId
               lngCompNro = .CompNro

               CompAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompUpdate(ByVal lngCompId As Long, ByVal decTotalBs As Decimal, ByVal decTotalUs As Decimal) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompUpdate = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               .DebeBs = decTotalBs
               .HaberBs = decTotalBs
               .DebeUs = decTotalUs
               .HaberUs = decTotalUs
               .Fecha = ToDate(.Fecha)
               .EstadoId = clsEstado.CERRADO

               If .Update Then
                  CompUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetAdd(ByVal lngTipoCompId As Long, ByVal lngCompId As Long, ByVal lngPlanId As Long, _
                              ByVal strDes As String, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, _
                              ByVal decValorOrg As Decimal, ByVal lngCol As Long, Optional ByVal lngSucursalId As Long = 0, _
                              Optional ByVal lngCentroCostoId As Long = 0, Optional ByRef lngCompDetId As Long = 0, _
                              Optional ByVal bytAutomatico As Byte = 0) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moPago.Fecha
            .PlanId = lngPlanId
            .CompDetDes = "Nota de Compra al Contado Nro. " & mstrCompraNro & " " & ToStr(txtPagoDes.Text)
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .MonedaId = moPago.MonedaId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorOrg
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorOrg
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeBs = 0
                  .DebeUs = 0
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorOrg
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorOrg
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeUs = 0
                  .DebeBs = 0
               End If
            End If

            .Orden = 0
            .Automatico = bytAutomatico
            .TipoRetencionId = 0
            .EstadoId = 10

            If .Insert() Then
               lngCompDetId = .CompDetId
               CompDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompDetUpdate(ByVal lngCompId As Long, ByVal lngPlanId As Long, ByVal strDes As String, _
                                 ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal decValorOrg As Decimal, _
                                 ByVal lngCol As Long, Optional ByRef lngCompDetId As Long = 0) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetUpdate = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .CompId = lngCompId
            .PlanId = lngPlanId

            If .Find Then
               If .MonedaId = 1 Then
                  If lngCol = 1 Then
                     .DebeOrg = decValorOrg
                     .DebeBs = decValorBs
                     .DebeUs = decValorUs

                     .HaberOrg = 0
                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberOrg = decValorOrg
                     .HaberBs = decValorBs
                     .HaberUs = decValorUs

                     .DebeOrg = 0
                     .DebeBs = 0
                     .DebeUs = 0
                  End If

               ElseIf .MonedaId = 2 Then
                  If lngCol = 1 Then
                     .DebeOrg = decValorOrg
                     .DebeBs = decValorBs
                     .DebeUs = decValorUs

                     .HaberOrg = 0
                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberOrg = decValorOrg
                     .HaberBs = decValorBs
                     .HaberUs = decValorUs

                     .DebeOrg = 0
                     .DebeUs = 0
                     .DebeBs = 0
                  End If
               End If

               .CompDetDes += " " + strDes + ";"
               .Fecha = ToDate(.Fecha)

               If .Update() Then
                  lngCompDetId = .CompDetId
                  CompDetUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompFind(ByRef lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompFind = False

      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .SucursalId = moPago.SucursalId

            If .Find Then
               lngCompId = .CompId
               lngTipoCompId = .TipoCompId
               lngCompNro = .CompNro

               CompFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetFind(ByVal lngCompId As Long, ByRef lngCompDetId As Long, ByVal lngPlanId As Long, _
                               ByVal lngCol As Long, ByRef decValorBs As Decimal, ByRef decValorUs As Decimal, _
                               ByRef decValorOrg As Decimal) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetFind = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .CompId = lngCompId
            .PlanId = lngPlanId

            If .Find Then
               If lngCol = 1 Then
                  If .DebeOrg = 0 Then
                     Return False
                  End If

               ElseIf lngCol = 2 Then
                  If .HaberOrg = 0 Then
                     Return False
                  End If
               End If

               lngCompDetId = .CompDetId

               If lngCol = 1 Then
                  decValorOrg = .DebeOrg
                  decValorBs = .DebeBs
                  decValorUs = .DebeUs

               ElseIf lngCol = 2 Then
                  decValorOrg = .HaberOrg
                  decValorBs = .HaberBs
                  decValorUs = .HaberUs
               End If

               CompDetFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                                 ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAdd = False

      Try
         With oCompPlanAdd
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moPago.Fecha
            .PlanId = lngPlanId
            .MonedaId = moPago.MonedaId
            .PlanAddId = lngPlanAddId
            .SucursalId = lngSucursalId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorBs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorUs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If
            End If

            .EstadoId = 10

            If .Insert() Then
               CompPlanAddAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, _
                                 ByVal lngCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetAdd = False

      Try
         With oCompCentroCostoDet
            .EmpresaId = moPago.EmpresaId
            .GestionId = moPago.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moPago.Fecha
            .PlanId = lngPlanId
            .MonedaId = moPago.MonedaId
            .CentroCostoId = lngCentroCostoId
            .CentroCostoDetId = lngCentroCostoDetId
            .SucursalId = lngSucursalId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorBs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorUs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If
            End If

            .EstadoId = 10

            If .Insert() Then
               CompCentroCostoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moPago.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               If ToBoolean(.NroAuto) Then
                  If ToBoolean(.NroAutoGestion) Then
                     .UpdateFilter = clsCompPara.UpdateFilters.NroActual

                     If Not clsAppInfo.MultipleNro Then
                        .NroActual = .NroActual + 1

                        If .Update Then
                           CompNroNext = .NroActual
                        End If

                     Else
                        If moPago.ConFac Then
                           .NroActualFis = .NroActualFis + 1

                           If .Update Then
                              CompNroNext = .NroActualFis
                           End If

                        ElseIf moPago.SinFac Then
                           .NroActual = .NroActual + 1

                           If .Update Then
                              CompNroNext = .NroActual
                           End If
                        End If
                     End If
                  Else
                     CompNroNext = CompNroMesNext(lngTipoCompId, lngGestionId, lngSucursalId, mdatFecha.Month)
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function

   Private Function CompNroMesNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal intMesId As Integer) As Long
      Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)

      Try
         CompNroMesNext = 0

         With oCompParaMes
            .SelectFilter = clsCompParaMes.SelectFilters.All
            .WhereFilter = clsCompParaMes.WhereFilters.MesId
            .EmpresaId = moPago.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            .MesId = intMesId
            .SucursalId = lngSucursalId

            If .Find Then
               .UpdateFilter = clsCompParaMes.UpdateFilters.NroActual

               If Not clsAppInfo.MultipleNro Then
                  .NroActual = .NroActual + 1

                  If .Update Then
                     CompNroMesNext = .NroActual
                  End If

               Else
                  If moPago.ConFac Then
                     .NroActualFis = .NroActualFis + 1

                     If .Update Then
                        CompNroMesNext = .NroActualFis
                     End If

                  ElseIf moPago.SinFac Then
                     .NroActual = .NroActual + 1

                     If .Update Then
                        CompNroMesNext = .NroActual
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompParaMes.Dispose()

      End Try
   End Function

   Private Function PlanIdPasFind(ByVal lngProveedorId As Long, ByRef lngPlanAddIdPas As Long, ByRef lngPlanIdInt As Long, ByRef lngPlanAddIdInt As Long) As Long
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      PlanIdPasFind = 0

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               lngPlanIdInt = .PlanIdInt
               lngPlanAddIdInt = .PlanAddIdInt
               lngPlanAddIdPas = .PlanAddIdPas
               Return .PlanIdPas
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Function

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moPago.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               .UpdateFilter = clsCompraPara.UpdateFilters.NroActual
               .NroActual = ToLong(.NroActual) + 1

               If .Update Then
                  CompraNroNext = .NroActual
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Private Function TieneChequeraCreada(ByVal lngPlanId As Long) As Boolean
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      TieneChequeraCreada = False

      Try
         With oCheque
            .SelectFilter = clsCheque.SelectFilters.All
            .WhereFilter = clsCheque.WhereFilters.PlanId
            .EmpresaId = moPago.EmpresaId
            .PlanId = lngPlanId

            If .Find Then
               TieneChequeraCreada = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()

      End Try
   End Function

   Private Function frmCompChequeEditLoad(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal decMontoBs As Decimal, ByVal decMontoUs As Decimal) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      Dim frm As New frmCompChequeEdit
      Dim boolFind As Boolean = False

      Try
         frmCompChequeEditLoad = False

         With oCompCheque

            If lngCompId > 0 Then
               .SelectFilter = clsCompCheque.SelectFilters.All
               .WhereFilter = clsCompCheque.WhereFilters.CompDetId
               .CompDetId = lngCompDetId

               If .Find Then
                  boolFind = True
               End If
            End If

            Dim lngMonedaId As Long = PlanMonedaIdFind(lngPlanId)

            If boolFind Then
               frm.NewRecord = False
               frm.Editing = True
               frm.DesdeComp = True

               .MonedaId = lngMonedaId
               .TipoCambio = moPago.TipoCambio
               .EstadoId = 10

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(decMontoBs)
               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(decMontoUs)
               End If

            Else
               frm.NewRecord = True
               frm.Editing = False
               frm.DesdeComp = True

               .EmpresaId = ToLong(moPago.EmpresaId)
               .GestionId = ToLong(moPago.GestionId)
               .CompId = lngCompId
               .CompDetId = lngCompDetId
               .PlanId = lngPlanId
               .MonedaId = lngMonedaId
               .TipoCambio = moPago.TipoCambio
               .Fecha = ConvertDMY(moPago.Fecha)
               .ChequeDes = mstrProveedorDes
               .EstadoId = 10

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(decMontoBs)
               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(decMontoUs)
               End If

            End If

            frm.DataObject = oCompCheque
            frm.ShowDialog()

            If frm.Changed Then
               ''mlngCompChequeId = frm.ID
               frmCompChequeEditLoad = True

            ElseIf boolFind Then
               frmCompChequeEditLoad = False

            Else
               frmCompChequeEditLoad = True
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function CompChequeUpdateComp(ByVal lngCompChequeId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Boolean
      If lngCompChequeId = 0 Then
         Return True
      End If

      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      CompChequeUpdateComp = False

      Try
         With oCompCheque
            .CompChequeId = lngCompChequeId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .FechaCob = ToDate(.FechaCob)
               .CompId = lngCompId
               .CompDetId = lngCompDetId
               .EstadoId = 10

               Return .Update()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function PlanMonedaIdFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanMonedaIdFind = 0

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               Return .MonedaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function TipoPlanIdFind(ByVal lngPlanId As Long, ByRef strPlanDes As String, ByRef lngMonedaIdPlan As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TipoPlanIdFind = 0

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               lngMonedaIdPlan = .MonedaId
               strPlanDes = .PlanDes
               TipoPlanIdFind = .TipoPlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtMontoPag.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboPlanLoad()
      Call cboSucursalLoad()
      Call cboCentroCostoLoad()
   End Sub

   Private Sub cboMonedaLoad()
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMoneda.Items.Clear()

      Try
         With oMoneda
            .SelectFilter = clsMoneda.SelectFilters.ListBox
            .OrderByFilter = clsMoneda.OrderByFilters.MonedaDes

            If .Open() Then
               Do While .Read()
                  If .MonedaId > 0 Then
                     oItem = New clsListItem(.MonedaId, .MonedaDes)

                     cboMoneda.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.CajaBanco
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moPago.EmpresaId
            .EsAna = 1
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
               With cboPlan
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = 205

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub cboPlanAddLoad(ByVal lngPlanId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPlanAdd.Items.Clear()

      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.ListBox
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes
            .EmpresaId = moPago.EmpresaId
            .PlanId = lngPlanId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.PlanAddId, .PlanAddDes)

                  cboPlanAdd.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanAdd.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboSucursalLoad()
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSucursal.Items.Clear()

      Try
         With oSucursal
            .SelectFilter = clsSucursal.SelectFilters.ListBox
            .WhereFilter = clsSucursal.WhereFilters.EmpresaId
            .OrderByFilter = clsSucursal.OrderByFilters.SucursalDes
            .EmpresaId = moPago.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.SucursalId, .SucursalDes)

                  cboSucursal.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboCentroCostoLoad()
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCosto.Items.Clear()

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.ListBox
            .WhereFilter = clsCentroCosto.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = moPago.EmpresaId
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.CentroCostoId, .CentroCostoDes)

                  cboCentroCosto.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboCentroCostoDetLoad(ByVal lngCentroCostoId As Long)
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCostoDet.Items.Clear()

      Try
         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.ListBox
            .WhereFilter = clsCentroCostoDet.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCostoDet.OrderByFilters.CentroCostoDetDes
            .EmpresaId = moPago.EmpresaId
            .CentroCostoId = lngCentroCostoId
            .EstadoId = clsEstado.ACTIVO
            .CentroCostoDetId = 0

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.CentroCostoDetId, .CentroCostoDetDes)

                  cboCentroCostoDet.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Function TieneSucCCO(ByVal lngPlanId As Long, ByRef boolTieneAnaAdd As Boolean) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TieneSucCCO = 0

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               TieneSucCCO = .SucCCOId
               boolTieneAnaAdd = ToBoolean(.TieneAnaAdd)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub txtUfvLoad(ByVal strFecha As String)
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               mdecUfv = .Ufv
            Else
               mdecUfv = 0
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Sub MontoPagar(ByVal lngMonedaId As Long)
      Dim oRow As DataRow
      Dim decMontoLiqBs As Decimal = 0
      Dim decMontoLiqUs As Decimal = 0

      If moPago.MonedaId = 1 Then
         mdecMontoPagBs = moPago.MontoPag
         mdecMontoPagUs = ToDecimal(moPago.MontoPag / moPago.TipoCambio)
      Else
         mdecMontoPagUs = moPago.MontoPag
         mdecMontoPagBs = ToDecimal(moPago.MontoPag * moPago.TipoCambio)
      End If

      If lngMonedaId = 1 Then
         txtMontoPag.Text = mdecMontoPagBs

         If mdecUfv > 0 Then
            txtEquiUfv.Text = ToDecimal(mdecMontoPagBs / mdecUfv)
         Else
            txtEquiUfv.Text = 0
         End If
      Else
         txtMontoPag.Text = mdecMontoPagUs

         If mdecUfv > 0 Then
            txtEquiUfv.Text = ToDecimal((mdecMontoPagUs * moPago.TipoCambio) / mdecUfv)
         Else
            txtEquiUfv.Text = 0
         End If
      End If
   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptPagoEdit
      Dim oPago As New clsPago(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String

      Try
         oPago.SelectFilter = clsPago.SelectFilters.ReportContado
         oPago.WhereFilter = clsPago.WhereFilters.Report
         oPago.OrderByFilter = clsPago.OrderByFilters.Report
         oPago.EmpresaId = moPago.EmpresaId
         oPago.PagoId = moPago.PagoId

         If oPago.Find Then
            rpt.DataSource = oPago.DataSet.Tables(oPago.TableName).DefaultView

            rpt.txtFirma.Text = CompraParaFirma(7, moPago.GestionId, moPago.SucursalId, strTitulo, lngTipoHojaId)
            rpt.lblTitle.Text = strTitulo
            rpt.Document.Name = strTitulo
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As frmReportPreview
               frm = New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As frmReportPreviewMultiple
               frm = New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
               'frm.PrintReport()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPago.Dispose()

      End Try
   End Sub

   Private Function CompraParaFirma(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef strTitulo As String, ByRef lngTipoHojaId As Long) As String
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaFirma = ""

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moPago.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               strTitulo = .Titulo
               lngTipoHojaId = .TipoHojaId
               CompraParaFirma = .Firma
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Private Sub cboMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.SelectedIndexChanged
      If cboMoneda.Tag <> cboMoneda.Text Then
         cboMoneda.Tag = cboMoneda.Text

         Call MontoPagar(ListPosition(cboMoneda, cboMoneda.SelectedIndex))
      End If
   End Sub

   Private Sub cboPlan_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlan.ValueChanged
      If cboPlan.Tag <> cboPlan.Text Then
         cboPlan.Tag = cboPlan.Text

         Dim lngPlanId As Long = ListPosition(cboPlan)
         Dim boolTieneAnaAdd As Long
         Dim lngSucCCO As Long = TieneSucCCO(lngPlanId, boolTieneAnaAdd)

         If boolTieneAnaAdd Then
            Call cboPlanAddLoad(lngPlanId)
            cboPlanAdd.SelectedIndex = -1
            cboPlanAdd.Text = ""
            cboPlanAdd.Enabled = True

         Else
            cboPlanAdd.Items.Clear()
            cboPlanAdd.SelectedIndex = -1
            cboPlanAdd.Text = ""
            cboPlanAdd.Enabled = False
         End If

         If Not clsAppInfo.CentroCostoApli Then
            If lngSucCCO = 1 Then
               cboSucursal.SelectedIndex = -1
               cboSucursal.Enabled = True
               cboSucursal.Text = ""
               cboCentroCosto.SelectedIndex = -1
               cboCentroCosto.Enabled = False
               cboCentroCosto.Text = ""

            ElseIf lngSucCCO = 2 Then
               cboSucursal.SelectedIndex = -1
               cboSucursal.Enabled = False
               cboSucursal.Text = ""
               cboCentroCosto.SelectedIndex = -1
               cboCentroCosto.Enabled = True
               cboCentroCosto.Text = ""

            Else
               cboSucursal.SelectedIndex = -1
               cboSucursal.Enabled = False
               cboSucursal.Text = ""
               cboCentroCosto.SelectedIndex = -1
               cboCentroCosto.Enabled = False
               cboCentroCosto.Text = ""
            End If
         Else

            If lngSucCCO = 1 Then
               cboSucursal.SelectedIndex = -1
               cboSucursal.Enabled = True
               cboSucursal.Text = ""

            ElseIf lngSucCCO = 2 Then
               cboSucursal.SelectedIndex = -1
               cboSucursal.Enabled = False
               cboSucursal.Text = ""

            Else
               cboSucursal.SelectedIndex = -1
               cboSucursal.Enabled = False
               cboSucursal.Text = ""

            End If

            ''If moPago.CentroCostoId > 0 Then
            ''   cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, moPago.CentroCostoId)
            ''   cboCentroCosto.Enabled = False
            ''Else

            ''End If
         End If
      End If
   End Sub

   Private Sub cboCentroCosto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroCosto.SelectedIndexChanged
      If cboCentroCosto.Tag <> cboCentroCosto.Text Then
         cboCentroCosto.Tag = cboCentroCosto.Text
         cboCentroCostoDet.Text = ""

         Call cboCentroCostoDetLoad(ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex))

         If cboCentroCostoDet.Items.Count > 0 Then
            cboCentroCostoDet.Enabled = True
         Else
            cboCentroCostoDet.Enabled = False
         End If
      End If
   End Sub

   Private Sub chkPlan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlan.CheckedChanged
      If chkPlan.Checked Then
         cboPlan.DisplayMember = "PlanDes"
      Else
         cboPlan.DisplayMember = "PlanCta"
      End If
   End Sub

   Private Sub frmCompraPagoAutoEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            cboPlan.Select()

            If DataSave() Then
               mlngID = moPago.PagoId
               mboolChanged = True

               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompraPagoAutoEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPago.Dispose()
      Call ClearMemory()
   End Sub

End Class
