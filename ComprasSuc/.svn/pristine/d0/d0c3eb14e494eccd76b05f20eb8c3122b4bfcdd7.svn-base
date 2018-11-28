Public Class frmEmpresaEdit
   Inherits System.Windows.Forms.Form

   Private moEmpresa As clsEmpresa

   Private mlngPlanCreId As Long
   Private mlngPlanDebId As Long
   Private mlngPlanITId As Long
   Private mlngPlanITPId As Long
   Private mlngPlanITFId As Long
   Private mlngPlanAitbId As Long
   Private mlngPlanDifId As Long
   Private mlngPlanResId As Long

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

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

   WriteOnly Property DataObject() As clsEmpresa
      Set(ByVal Value As clsEmpresa)
         moEmpresa = Value
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
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkClonePlan As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents txtWeb As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtCodPostal As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtFax As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtTelefono2 As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtMovil As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtTelefono1 As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtDireccion As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmpresaRUC As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmpresaDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents Label24 As System.Windows.Forms.Label
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents Label26 As System.Windows.Forms.Label
   Friend WithEvents Label27 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
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
   Friend WithEvents chkInventario As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboCiudad As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboMesCierre As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresaEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.cboMesCierre = New Janus.Windows.EditControls.UIComboBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label14 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.cboCiudad = New Janus.Windows.EditControls.UIComboBox
      Me.chkInventario = New Janus.Windows.EditControls.UICheckBox
      Me.chkClonePlan = New Janus.Windows.EditControls.UICheckBox
      Me.txtWeb = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmail = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCodPostal = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtFax = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtTelefono2 = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtMovil = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtTelefono1 = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtDireccion = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmpresaRUC = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmpresaDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.Label18 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.Label20 = New System.Windows.Forms.Label
      Me.Label21 = New System.Windows.Forms.Label
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label23 = New System.Windows.Forms.Label
      Me.Label24 = New System.Windows.Forms.Label
      Me.Label25 = New System.Windows.Forms.Label
      Me.Label26 = New System.Windows.Forms.Label
      Me.Label27 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
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
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 389)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox1.Controls.Add(Me.cboMesCierre)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.Label14)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 312)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 68)
      Me.UiGroupBox1.TabIndex = 161
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(188, 40)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(248, 20)
      Me.cboMoneda.TabIndex = 16
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboMesCierre
      '
      Me.cboMesCierre.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMesCierre.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMesCierre.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMesCierre.Location = New System.Drawing.Point(188, 16)
      Me.cboMesCierre.Name = "cboMesCierre"
      Me.cboMesCierre.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMesCierre.Size = New System.Drawing.Size(248, 20)
      Me.cboMesCierre.TabIndex = 15
      Me.cboMesCierre.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 44)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(176, 16)
      Me.Label7.TabIndex = 161
      Me.Label7.Text = "Moneda por Defecto"
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 20)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(176, 16)
      Me.Label14.TabIndex = 160
      Me.Label14.Text = "Cierre de Gestión en el Mes de:"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.cboCiudad)
      Me.grpMain.Controls.Add(Me.chkInventario)
      Me.grpMain.Controls.Add(Me.chkClonePlan)
      Me.grpMain.Controls.Add(Me.txtWeb)
      Me.grpMain.Controls.Add(Me.txtEmail)
      Me.grpMain.Controls.Add(Me.txtCodPostal)
      Me.grpMain.Controls.Add(Me.txtFax)
      Me.grpMain.Controls.Add(Me.txtTelefono2)
      Me.grpMain.Controls.Add(Me.txtMovil)
      Me.grpMain.Controls.Add(Me.txtTelefono1)
      Me.grpMain.Controls.Add(Me.txtDireccion)
      Me.grpMain.Controls.Add(Me.txtEmpresaRUC)
      Me.grpMain.Controls.Add(Me.txtEmpresaDes)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.Label19)
      Me.grpMain.Controls.Add(Me.Label20)
      Me.grpMain.Controls.Add(Me.Label21)
      Me.grpMain.Controls.Add(Me.Label22)
      Me.grpMain.Controls.Add(Me.Label23)
      Me.grpMain.Controls.Add(Me.Label24)
      Me.grpMain.Controls.Add(Me.Label25)
      Me.grpMain.Controls.Add(Me.Label26)
      Me.grpMain.Controls.Add(Me.Label27)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 312)
      Me.grpMain.TabIndex = 160
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 256)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(320, 20)
      Me.cboEstado.TabIndex = 12
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboCiudad
      '
      Me.cboCiudad.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.Location = New System.Drawing.Point(116, 112)
      Me.cboCiudad.Name = "cboCiudad"
      Me.cboCiudad.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCiudad.Size = New System.Drawing.Size(320, 20)
      Me.cboCiudad.TabIndex = 4
      Me.cboCiudad.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkInventario
      '
      Me.chkInventario.BackColor = System.Drawing.Color.Transparent
      Me.chkInventario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkInventario.Checked = True
      Me.chkInventario.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkInventario.Location = New System.Drawing.Point(8, 284)
      Me.chkInventario.Name = "chkInventario"
      Me.chkInventario.Size = New System.Drawing.Size(120, 20)
      Me.chkInventario.TabIndex = 13
      Me.chkInventario.Text = "Integrado"
      Me.chkInventario.Visible = False
      Me.chkInventario.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkClonePlan
      '
      Me.chkClonePlan.BackColor = System.Drawing.Color.Transparent
      Me.chkClonePlan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkClonePlan.Checked = True
      Me.chkClonePlan.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkClonePlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkClonePlan.Location = New System.Drawing.Point(228, 284)
      Me.chkClonePlan.Name = "chkClonePlan"
      Me.chkClonePlan.Size = New System.Drawing.Size(208, 20)
      Me.chkClonePlan.TabIndex = 14
      Me.chkClonePlan.Text = "Generar Plan de Cuentas Modelo"
      Me.chkClonePlan.Visible = False
      Me.chkClonePlan.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtWeb
      '
      Me.txtWeb.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtWeb.Location = New System.Drawing.Point(116, 232)
      Me.txtWeb.MaxLength = 200
      Me.txtWeb.Name = "txtWeb"
      Me.txtWeb.Size = New System.Drawing.Size(320, 20)
      Me.txtWeb.TabIndex = 11
      Me.txtWeb.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtWeb.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmail
      '
      Me.txtEmail.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmail.Location = New System.Drawing.Point(116, 208)
      Me.txtEmail.MaxLength = 200
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.Size = New System.Drawing.Size(320, 20)
      Me.txtEmail.TabIndex = 10
      Me.txtEmail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCodPostal
      '
      Me.txtCodPostal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCodPostal.Location = New System.Drawing.Point(116, 184)
      Me.txtCodPostal.MaxLength = 100
      Me.txtCodPostal.Name = "txtCodPostal"
      Me.txtCodPostal.Size = New System.Drawing.Size(320, 20)
      Me.txtCodPostal.TabIndex = 9
      Me.txtCodPostal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCodPostal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFax
      '
      Me.txtFax.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFax.Location = New System.Drawing.Point(312, 160)
      Me.txtFax.MaxLength = 100
      Me.txtFax.Name = "txtFax"
      Me.txtFax.Size = New System.Drawing.Size(124, 20)
      Me.txtFax.TabIndex = 8
      Me.txtFax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTelefono2
      '
      Me.txtTelefono2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTelefono2.Location = New System.Drawing.Point(312, 136)
      Me.txtTelefono2.MaxLength = 100
      Me.txtTelefono2.Name = "txtTelefono2"
      Me.txtTelefono2.Size = New System.Drawing.Size(124, 20)
      Me.txtTelefono2.TabIndex = 6
      Me.txtTelefono2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTelefono2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMovil
      '
      Me.txtMovil.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMovil.Location = New System.Drawing.Point(116, 160)
      Me.txtMovil.MaxLength = 100
      Me.txtMovil.Name = "txtMovil"
      Me.txtMovil.Size = New System.Drawing.Size(124, 20)
      Me.txtMovil.TabIndex = 7
      Me.txtMovil.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtMovil.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTelefono1
      '
      Me.txtTelefono1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTelefono1.Location = New System.Drawing.Point(116, 136)
      Me.txtTelefono1.MaxLength = 100
      Me.txtTelefono1.Name = "txtTelefono1"
      Me.txtTelefono1.Size = New System.Drawing.Size(124, 20)
      Me.txtTelefono1.TabIndex = 5
      Me.txtTelefono1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTelefono1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtDireccion
      '
      Me.txtDireccion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDireccion.Location = New System.Drawing.Point(116, 88)
      Me.txtDireccion.MaxLength = 200
      Me.txtDireccion.Name = "txtDireccion"
      Me.txtDireccion.Size = New System.Drawing.Size(320, 20)
      Me.txtDireccion.TabIndex = 3
      Me.txtDireccion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDireccion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaRUC
      '
      Me.txtEmpresaRUC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaRUC.Location = New System.Drawing.Point(116, 64)
      Me.txtEmpresaRUC.MaxLength = 50
      Me.txtEmpresaRUC.Name = "txtEmpresaRUC"
      Me.txtEmpresaRUC.Size = New System.Drawing.Size(124, 20)
      Me.txtEmpresaRUC.TabIndex = 2
      Me.txtEmpresaRUC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaRUC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaDes
      '
      Me.txtEmpresaDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaDes.Location = New System.Drawing.Point(116, 40)
      Me.txtEmpresaDes.Name = "txtEmpresaDes"
      Me.txtEmpresaDes.Size = New System.Drawing.Size(320, 20)
      Me.txtEmpresaDes.TabIndex = 1
      Me.txtEmpresaDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 16)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(124, 20)
      Me.txtEmpresaId.TabIndex = 0
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(284, 164)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(24, 16)
      Me.Label15.TabIndex = 176
      Me.Label15.Text = "Fax"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 164)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 175
      Me.Label16.Text = "Movil"
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(248, 140)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(60, 16)
      Me.Label17.TabIndex = 174
      Me.Label17.Text = "Telefono 2"
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 260)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 173
      Me.Label18.Text = "Estado"
      '
      'Label19
      '
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(8, 236)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(104, 16)
      Me.Label19.TabIndex = 172
      Me.Label19.Text = "Página Web"
      '
      'Label20
      '
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(8, 212)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(104, 16)
      Me.Label20.TabIndex = 171
      Me.Label20.Text = "Correo Electronico"
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.Location = New System.Drawing.Point(8, 188)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(104, 16)
      Me.Label21.TabIndex = 170
      Me.Label21.Text = "Código Postal"
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(8, 116)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(104, 16)
      Me.Label22.TabIndex = 169
      Me.Label22.Text = "Ciudad"
      '
      'Label23
      '
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.Location = New System.Drawing.Point(8, 140)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(104, 16)
      Me.Label23.TabIndex = 168
      Me.Label23.Text = "Telefono 1"
      '
      'Label24
      '
      Me.Label24.BackColor = System.Drawing.Color.Transparent
      Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label24.Location = New System.Drawing.Point(8, 92)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(104, 16)
      Me.Label24.TabIndex = 167
      Me.Label24.Text = "Dirección"
      '
      'Label25
      '
      Me.Label25.BackColor = System.Drawing.Color.Transparent
      Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label25.Location = New System.Drawing.Point(8, 68)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(104, 16)
      Me.Label25.TabIndex = 166
      Me.Label25.Text = "NIT"
      '
      'Label26
      '
      Me.Label26.BackColor = System.Drawing.Color.Transparent
      Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label26.Location = New System.Drawing.Point(8, 44)
      Me.Label26.Name = "Label26"
      Me.Label26.Size = New System.Drawing.Size(104, 16)
      Me.Label26.TabIndex = 165
      Me.Label26.Text = "Empresa"
      '
      'Label27
      '
      Me.Label27.BackColor = System.Drawing.Color.Transparent
      Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label27.Location = New System.Drawing.Point(8, 20)
      Me.Label27.Name = "Label27"
      Me.Label27.Size = New System.Drawing.Size(104, 16)
      Me.Label27.TabIndex = 164
      Me.Label27.Text = "ID"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("baf6352c-6109-4ee4-b203-9e745bf1af4f")
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
      'frmEmpresaEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 417)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmEmpresaEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Empresa Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
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
               mlngID = moEmpresa.EmpresaId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmEmpresaEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmEmpresaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Empresa"

         Else
            Me.Text = "Editar Empresa"
            cboMesCierre.ReadOnly = GestionExits(moEmpresa.EmpresaId)
         End If

      Else
         Me.Text = "Nueva Empresa"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moEmpresa
         txtEmpresaId.Text = ToStr(.EmpresaId)
         txtEmpresaDes.Text = ToStr(.EmpresaDes)
         txtEmpresaRUC.Text = ToStr(.EmpresaRUC)
         txtDireccion.Text = ToStr(.Direccion)
         cboCiudad.SelectedIndex = ListFindItem(cboCiudad, .CiudadId)
         txtTelefono1.Text = ToStr(.Telefono1)
         txtTelefono2.Text = ToStr(.Telefono2)
         txtMovil.Text = ToStr(.Movil)
         txtFax.Text = ToStr(.Fax)
         txtCodPostal.Text = ToStr(.CodPostal)
         txtEmail.Text = ToStr(.Email)
         txtWeb.Text = ToStr(.Web)
         cboMesCierre.SelectedIndex = ListFindItem(cboMesCierre, .MesCierreId)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moEmpresa
         txtEmpresaId.Text = String.Empty
         txtEmpresaDes.Text = String.Empty
         txtEmpresaRUC.Text = String.Empty
         txtDireccion.Text = String.Empty
         cboCiudad.SelectedIndex = -1
         txtTelefono1.Text = String.Empty
         txtTelefono2.Text = String.Empty
         txtMovil.Text = String.Empty
         txtFax.Text = String.Empty
         txtCodPostal.Text = String.Empty
         txtEmail.Text = String.Empty
         txtWeb.Text = String.Empty
         cboMesCierre.SelectedIndex = -1
         cboMoneda.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 1)
         cboEstado.Enabled = False

         chkClonePlan.Visible = True
         chkInventario.Visible = True
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtEmpresaId.ReadOnly = True
      txtEmpresaDes.ReadOnly = True
      txtEmpresaRUC.ReadOnly = True
      txtDireccion.ReadOnly = True
      cboCiudad.Enabled = False
      txtTelefono1.ReadOnly = True
      txtTelefono2.ReadOnly = True
      txtMovil.ReadOnly = True
      txtFax.ReadOnly = True
      txtCodPostal.ReadOnly = True
      txtEmail.ReadOnly = True
      txtWeb.ReadOnly = True
      cboMesCierre.Enabled = False
      cboMoneda.Enabled = False
      cboEstado.Enabled = False
      chkClonePlan.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moEmpresa
         If Not mboolAdding Then
            .EmpresaId = ToLong(txtEmpresaId.Text)
         End If

         .EmpresaDes = ToStr(txtEmpresaDes.Text)
         .EmpresaRUC = ToStr(txtEmpresaRUC.Text)
         .Direccion = ToStr(txtDireccion.Text)
         .CiudadId = ListPosition(cboCiudad, cboCiudad.SelectedIndex)
         .Telefono1 = ToStr(txtTelefono1.Text)
         .Telefono2 = ToStr(txtTelefono2.Text)
         .Movil = ToStr(txtMovil.Text)
         .Fax = ToStr(txtFax.Text)
         .CodPostal = ToStr(txtCodPostal.Text)
         .Email = ToStr(txtEmail.Text)
         .Web = ToStr(txtWeb.Text)
         .MesCierreId = ListPosition(cboMesCierre, cboMesCierre.SelectedIndex)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

         If .MesCierreId <> 0 Then
            If .MesCierreId = 12 Then
               .MesAperturaId = 1
            Else
               .MesAperturaId = .MesCierreId + 1
            End If
         Else
            .MesAperturaId = 0
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtEmpresaDes.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
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

         If moEmpresa.Insert() Then
            If chkClonePlan.Checked = True Then
               If ClonePlan() Then
                  If EmpresaParaAdd() Then
                     If GestionNew() Then
                        clsAppInfo.EmpresaId = moEmpresa.EmpresaId
                        Call EmpresaParaLoad(moEmpresa.EmpresaId)
                        Call StatusEnterpriseDisplay(clsAppInfo.EmpresaDes)

                        mboolAdding = False
                        DataAdd = True
                     End If
                  End If
               Else
                  mboolAdding = False
               End If

            ElseIf ClonePlanNivelUno() Then
               If GestionNew() Then
                  clsAppInfo.EmpresaId = moEmpresa.EmpresaId
                  Call EmpresaParaLoad(moEmpresa.EmpresaId)
                  Call StatusEnterpriseDisplay(clsAppInfo.EmpresaDes)

                  mboolAdding = False
                  DataAdd = True
               End If
            Else
               mboolAdding = False
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moEmpresa.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

   End Sub

   Private Sub ComboLoad()
      Call cboCiudadLoad()
      Call cboEstadoLoad()
      Call cboMesLoad()
      Call cboMonedaLoad()
   End Sub

   Private Sub cboCiudadLoad()
      Dim oCiudad As New clsCiudad(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCiudad.Items.Clear()

      Try
         With oCiudad
            .SelectFilter = clsCiudad.SelectFilters.ListBox
            .OrderByFilter = clsCiudad.OrderByFilters.CiudadDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.CiudadId, .CiudadDes)

                  cboCiudad.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCiudad.Dispose()
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
            .TipoId = 1

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

   Private Sub cboMesLoad()
      Dim oMes As New clsMes(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMesCierre.Items.Clear()

      Try
         With oMes
            .SelectFilter = clsMes.SelectFilters.ListBox
            .OrderByFilter = clsMes.OrderByFilters.MesId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.MesId, .MesDes)

                  cboMesCierre.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMes.Dispose()
         oItem = Nothing

      End Try
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

   Private Function ClonePlan() As Boolean
      Dim oPlanUno As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanDos As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanTres As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanCuatro As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanCinco As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanSeis As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanSiete As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanOcho As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanNueve As New clsPlan(clsAppInfo.ConnectString)
      Dim oPlanDiez As New clsPlan(clsAppInfo.ConnectString)

      Dim lngPadreIdUno As Long
      Dim lngPadreIdDos As Long
      Dim lngPadreIdTres As Long
      Dim lngPadreIdCuatro As Long
      Dim lngPadreIdCinco As Long
      Dim lngPadreIdSeis As Long
      Dim lngPadreIdSiete As Long
      Dim lngPadreIdOcho As Long
      Dim lngPadreIdNueve As Long
      Dim lngPadreIdDiez As Long

      Try
         ClonePlan = False

         'Corte de Control Nivel Uno
         With oPlanUno
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanPadreId
            .OrderByFilter = clsPlan.OrderByFilters.Orden
            .EmpresaId = -1
            .PlanPadreId = 0

            If .Open() Then
               Do While .Read
                  lngPadreIdUno = oPlanUno.PlanId
                  If CloneRow(oPlanUno, 0) Then
                     .CloseConection()

                     'Corte de Control Nivel Dos
                     With oPlanDos
                        .SelectFilter = clsPlan.SelectFilters.All
                        .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                        .OrderByFilter = clsPlan.OrderByFilters.Orden
                        .EmpresaId = -1
                        .PlanPadreId = lngPadreIdUno

                        If .Open() Then
                           Do While .Read
                              lngPadreIdDos = oPlanDos.PlanId
                              If CloneRow(oPlanDos, oPlanUno.PlanId) Then
                                 .CloseConection()

                                 'Corte de Control Nivel Tres
                                 With oPlanTres
                                    .SelectFilter = clsPlan.SelectFilters.All
                                    .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                                    .OrderByFilter = clsPlan.OrderByFilters.Orden
                                    .EmpresaId = -1
                                    .PlanPadreId = lngPadreIdDos

                                    If .Open() Then
                                       Do While .Read
                                          lngPadreIdTres = oPlanTres.PlanId
                                          If CloneRow(oPlanTres, oPlanDos.PlanId) Then
                                             .CloseConection()

                                             'Corte de Control Nivel Cuatro
                                             With oPlanCuatro
                                                .SelectFilter = clsPlan.SelectFilters.All
                                                .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                                                .OrderByFilter = clsPlan.OrderByFilters.Orden
                                                .EmpresaId = -1
                                                .PlanPadreId = lngPadreIdTres

                                                If .Open() Then
                                                   Do While .Read
                                                      lngPadreIdCuatro = oPlanCuatro.PlanId
                                                      If CloneRow(oPlanCuatro, oPlanTres.PlanId) Then
                                                         .CloseConection()

                                                         'Corte de Control Nivel Cinco
                                                         With oPlanCinco
                                                            .SelectFilter = clsPlan.SelectFilters.All
                                                            .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                                                            .OrderByFilter = clsPlan.OrderByFilters.Orden
                                                            .EmpresaId = -1
                                                            .PlanPadreId = lngPadreIdCuatro

                                                            If .Open() Then
                                                               Do While .Read
                                                                  lngPadreIdCinco = oPlanCinco.PlanId
                                                                  If CloneRow(oPlanCinco, oPlanCuatro.PlanId) Then
                                                                     .CloseConection()

                                                                     'Corte de Control Nivel Seis
                                                                     With oPlanSeis
                                                                        .SelectFilter = clsPlan.SelectFilters.All
                                                                        .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                                                                        .OrderByFilter = clsPlan.OrderByFilters.Orden
                                                                        .EmpresaId = -1
                                                                        .PlanPadreId = lngPadreIdCinco

                                                                        If .Open() Then
                                                                           Do While .Read
                                                                              lngPadreIdSeis = oPlanSeis.PlanId
                                                                              If CloneRow(oPlanSeis, oPlanCinco.PlanId) Then
                                                                                 .CloseConection()

                                                                                 'Corte de Control Nivel Siete
                                                                                 With oPlanSiete
                                                                                    .SelectFilter = clsPlan.SelectFilters.All
                                                                                    .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                                                                                    .OrderByFilter = clsPlan.OrderByFilters.Orden
                                                                                    .EmpresaId = -1
                                                                                    .PlanPadreId = lngPadreIdSeis

                                                                                    If .Open() Then
                                                                                       Do While .Read
                                                                                          lngPadreIdSiete = oPlanSiete.PlanId
                                                                                          If CloneRow(oPlanSiete, oPlanSeis.PlanId) Then
                                                                                             .CloseConection()

                                                                                             'Corte de Control Nivel Ocho
                                                                                             With oPlanOcho
                                                                                                .SelectFilter = clsPlan.SelectFilters.All
                                                                                                .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                                                                                                .OrderByFilter = clsPlan.OrderByFilters.Orden
                                                                                                .EmpresaId = -1
                                                                                                .PlanPadreId = lngPadreIdSiete

                                                                                                If .Open() Then
                                                                                                   Do While .Read
                                                                                                      lngPadreIdOcho = oPlanOcho.PlanId
                                                                                                      If CloneRow(oPlanOcho, oPlanSiete.PlanId) Then
                                                                                                         .CloseConection()

                                                                                                         'Corte de Control Nivel Nueve
                                                                                                         With oPlanNueve
                                                                                                            .SelectFilter = clsPlan.SelectFilters.All
                                                                                                            .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                                                                                                            .OrderByFilter = clsPlan.OrderByFilters.Orden
                                                                                                            .EmpresaId = -1
                                                                                                            .PlanPadreId = lngPadreIdOcho

                                                                                                            If .Open() Then
                                                                                                               Do While .Read
                                                                                                                  lngPadreIdNueve = oPlanNueve.PlanId
                                                                                                                  If CloneRow(oPlanNueve, oPlanOcho.PlanId) Then
                                                                                                                     .CloseConection()

                                                                                                                     'Corte de Control Nivel Diez
                                                                                                                     With oPlanDiez
                                                                                                                        .SelectFilter = clsPlan.SelectFilters.All
                                                                                                                        .WhereFilter = clsPlan.WhereFilters.PlanPadreId
                                                                                                                        .OrderByFilter = clsPlan.OrderByFilters.Orden
                                                                                                                        .EmpresaId = -1
                                                                                                                        .PlanPadreId = lngPadreIdNueve

                                                                                                                        If .Open() Then
                                                                                                                           Do While .Read
                                                                                                                              lngPadreIdDiez = oPlanDiez.PlanId
                                                                                                                              If CloneRow(oPlanDiez, oPlanNueve.PlanId) Then
                                                                                                                                 .CloseConection()

                                                                                                                              End If
                                                                                                                              .MoveNext()
                                                                                                                           Loop
                                                                                                                        End If
                                                                                                                     End With

                                                                                                                  End If
                                                                                                                  .MoveNext()
                                                                                                               Loop
                                                                                                            End If
                                                                                                         End With

                                                                                                      End If
                                                                                                      .MoveNext()
                                                                                                   Loop
                                                                                                End If
                                                                                             End With

                                                                                          End If
                                                                                          .MoveNext()
                                                                                       Loop
                                                                                    End If
                                                                                 End With

                                                                              End If
                                                                              .MoveNext()
                                                                           Loop
                                                                        End If
                                                                     End With

                                                                  End If
                                                                  .MoveNext()
                                                               Loop
                                                            End If
                                                         End With

                                                      End If
                                                      .MoveNext()
                                                   Loop
                                                End If
                                             End With

                                          End If
                                          .MoveNext()
                                       Loop
                                    End If
                                 End With

                              End If
                              .MoveNext()
                           Loop
                        End If
                     End With

                  End If
                  .MoveNext()
               Loop
            End If
         End With

         ClonePlan = True

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanUno.Dispose()
         oPlanDos.Dispose()
         oPlanTres.Dispose()
         oPlanCuatro.Dispose()
         oPlanCinco.Dispose()
         oPlanSeis.Dispose()
         oPlanSiete.Dispose()
         oPlanOcho.Dispose()
         oPlanNueve.Dispose()
         oPlanDiez.Dispose()

      End Try
   End Function

   Private Function CloneRow(ByVal oPlan As clsPlan, ByVal lngPlanPadreId As Long) As Boolean
      Dim lngPlanId As Long

      Try
         CloneRow = False

         With oPlan
            lngPlanId = .PlanId

            .EmpresaId = moEmpresa.EmpresaId
            .PlanPadreId = lngPlanPadreId

            If .Insert() Then
               If lngPlanId = 23 Then
                  mlngPlanCreId = lngPlanId

               ElseIf lngPlanId = 41 Then
                  mlngPlanDebId = lngPlanId

               ElseIf lngPlanId = 177 Then
                  mlngPlanITId = lngPlanId

               ElseIf lngPlanId = 42 Then
                  mlngPlanITPId = lngPlanId

               ElseIf lngPlanId = 211 Then
                  mlngPlanITFId = lngPlanId

               ElseIf lngPlanId = 215 Then
                  mlngPlanDifId = lngPlanId

               ElseIf lngPlanId = 214 Then
                  mlngPlanAitbId = lngPlanId

               ElseIf lngPlanId = 52 Then
                  mlngPlanResId = lngPlanId
               End If

               CloneRow = True
            End If
         End With

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function ClonePlanNivelUno() As Boolean
      Dim oPlanUno As New clsPlan(clsAppInfo.ConnectString)
      Dim lngPadreIdUno As Long

      Try
         ClonePlanNivelUno = False

         'Corte de Control Nivel Uno
         With oPlanUno
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanPadreId
            .OrderByFilter = clsPlan.OrderByFilters.Orden
            .EmpresaId = -1
            .PlanPadreId = 0

            If .Open() Then
               Do While .Read
                  lngPadreIdUno = oPlanUno.PlanId
                  If CloneRow(oPlanUno, 0) Then

                  End If
                  .MoveNext()
               Loop
            End If
         End With

         ClonePlanNivelUno = True

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanUno.Dispose()

      End Try
   End Function

   Private Function EmpresaParaAdd() As Boolean
      Dim oEmpresaPara As New clsEmpresaPara(clsAppInfo.ConnectString)

      EmpresaParaAdd = False

      Try
         With oEmpresaPara
            .EmpresaId = moEmpresa.EmpresaId
            .DecimalNro = 3
            .EmpresaGral = moEmpresa.EmpresaDes + "    NIT: " + moEmpresa.EmpresaRUC + "    Dir: " + moEmpresa.Direccion + "    Tel: " + moEmpresa.Telefono1
            .PlanCreId = mlngPlanCreId
            .PlanCreDifId = mlngPlanCreId
            .PlanDebId = mlngPlanDebId
            .PlanDebDifId = mlngPlanDebId
            .PlanITId = mlngPlanITId
            .PlanITPId = mlngPlanITPId
            .PlanITFId = mlngPlanITFId
            .PlanDifId = mlngPlanDifId
            .PlanAitbId = mlngPlanAitbId
            .PlanResId = mlngPlanResId
            .TipoHojaId = 1 'Tamaño Carta
            .Inventario = chkInventario.Checked
            .ItemCodShow = 0
            .PlanCtaShow = 0
            .MultipleNro = 0
            .FechaOpera = 0
            .CodBarra = 0

            If .Insert() Then
               EmpresaParaAdd = True
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oEmpresaPara.Dispose()

      End Try
   End Function

   Private Function GestionNew() As Boolean
      Dim frm As New frmGestionEdit
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionNew = False

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oGestion.EmpresaId = moEmpresa.EmpresaId

            .DataObject = oGestion
            .ShowDialog()

            If .Changed Then
               clsAppInfo.GestionId = frm.ID
               GestionNew = True

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function GestionExits(ByVal lngEmpresaId As Long) As Boolean
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionExits = False

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.ListBox
            .WhereFilter = clsGestion.WhereFilters.EmpresaId
            .EmpresaId = lngEmpresaId

            If .Find Then
               GestionExits = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Sub frmEmpresaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moEmpresa.EmpresaId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmEmpresaEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moEmpresa.Dispose()
      Call ClearMemory()
   End Sub

End Class
