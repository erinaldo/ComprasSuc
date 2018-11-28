Public Class frmProveedorEdit
   Inherits System.Windows.Forms.Form

   Private moProveedor As clsProveedor
   Private moItemProveedor As clsItemProveedor

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents ebrItemProveedor As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdItemProveedor As Janus.Windows.GridEX.GridEX
   Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtInteresAnual As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label34 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents dudCreditoDias As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents chkCreditoAuto As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents txtCreditoLimite As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label32 As System.Windows.Forms.Label
   Friend WithEvents tabCuentas As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents UiGroupBox7 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboProcedencia As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboRubro As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboBanco As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtNroCuenta As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents cboMonedaCuenta As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label28 As System.Windows.Forms.Label
   Friend WithEvents cboTipoDocIdentidad As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label29 As System.Windows.Forms.Label
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

   WriteOnly Property DataObject() As clsProveedor
      Set(ByVal Value As clsProveedor)
         moProveedor = Value
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
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents tabItemProveedor As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtProveedorCod As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtProveedorNIT As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtProveedorDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtProveedorId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents Label26 As System.Windows.Forms.Label
   Friend WithEvents Label27 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboCiudad As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtWeb As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtFax As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtTelefono2 As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtMovil As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtTelefono1 As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtDireccion As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents Label24 As System.Windows.Forms.Label
   Friend WithEvents tabProveedor As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabContacto As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtContactoCargo As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtContactoCI As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtContactoDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents mnuItemProveedor As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboPlanAct As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanPas As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents lblActivo As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents cboPlanAddPas As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboPlanAddAct As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboPlanAddInt As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents cboPlanInt As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label10 As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup4 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboPlanInt_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorEdit))
      Dim cboPlanAct_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanPas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdItemProveedor = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.tabProveedor = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.cboCiudad = New Janus.Windows.EditControls.UIComboBox
      Me.txtWeb = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmail = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtFax = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtTelefono2 = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtMovil = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtTelefono1 = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtDireccion = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.Label18 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.Label20 = New System.Windows.Forms.Label
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label23 = New System.Windows.Forms.Label
      Me.Label24 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtProveedorCod = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtProveedorNIT = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtProveedorDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtProveedorId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label25 = New System.Windows.Forms.Label
      Me.Label26 = New System.Windows.Forms.Label
      Me.Label27 = New System.Windows.Forms.Label
      Me.tabContacto = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox7 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboProcedencia = New Janus.Windows.EditControls.UIComboBox
      Me.cboRubro = New Janus.Windows.EditControls.UIComboBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label14 = New System.Windows.Forms.Label
      Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtInteresAnual = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label34 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.dudCreditoDias = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.chkCreditoAuto = New Janus.Windows.EditControls.UICheckBox
      Me.txtCreditoLimite = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label32 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtContactoCargo = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtContactoCI = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtContactoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.tabItemProveedor = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrItemProveedor = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabCuentas = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboMonedaCuenta = New Janus.Windows.EditControls.UIComboBox
      Me.Label28 = New System.Windows.Forms.Label
      Me.cboBanco = New Janus.Windows.EditControls.UIComboBox
      Me.txtNroCuenta = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label21 = New System.Windows.Forms.Label
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboPlanAddInt = New Janus.Windows.EditControls.UIComboBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.cboPlanInt = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label10 = New System.Windows.Forms.Label
      Me.cboPlanAddAct = New Janus.Windows.EditControls.UIComboBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.cboPlanAddPas = New Janus.Windows.EditControls.UIComboBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.cboPlanAct = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanPas = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label7 = New System.Windows.Forms.Label
      Me.lblActivo = New System.Windows.Forms.Label
      Me.mnuItemProveedor = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.mnuNew = New System.Windows.Forms.MenuItem
      Me.mnuEdit = New System.Windows.Forms.MenuItem
      Me.mnuDelete = New System.Windows.Forms.MenuItem
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
      Me.cboTipoDocIdentidad = New Janus.Windows.EditControls.UIComboBox
      Me.Label29 = New System.Windows.Forms.Label
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdItemProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabMain.SuspendLayout()
      Me.tabProveedor.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.tabContacto.SuspendLayout()
      CType(Me.UiGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox7.SuspendLayout()
      CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox6.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      Me.tabItemProveedor.SuspendLayout()
      CType(Me.ebrItemProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrItemProveedor.SuspendLayout()
      Me.tabCuentas.SuspendLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox4.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.cboPlanInt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanAct, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanPas, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdItemProveedor)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(420, 271)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdItemProveedor
      '
      Me.grdItemProveedor.AllowCardSizing = False
      Me.grdItemProveedor.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdItemProveedor.AlternatingColors = True
      Me.grdItemProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdItemProveedor.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdItemProveedor.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdItemProveedor.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdItemProveedor.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdItemProveedor.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdItemProveedor.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdItemProveedor.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdItemProveedor.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdItemProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdItemProveedor.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdItemProveedor.GroupByBoxVisible = False
      Me.grdItemProveedor.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdItemProveedor.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdItemProveedor.Location = New System.Drawing.Point(0, 0)
      Me.grdItemProveedor.Name = "grdItemProveedor"
      Me.grdItemProveedor.RecordNavigator = True
      Me.grdItemProveedor.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdItemProveedor.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdItemProveedor.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdItemProveedor.Size = New System.Drawing.Size(420, 271)
      Me.grdItemProveedor.TabIndex = 3
      Me.grdItemProveedor.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdItemProveedor.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemProveedor.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemProveedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.tabMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 349)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(8, 8)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(448, 336)
      Me.tabMain.TabIndex = 10
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabProveedor, Me.tabContacto, Me.tabItemProveedor, Me.tabCuentas})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabProveedor
      '
      Me.tabProveedor.Controls.Add(Me.UiGroupBox1)
      Me.tabProveedor.Controls.Add(Me.grpMain)
      Me.tabProveedor.Key = "Proveedor"
      Me.tabProveedor.Location = New System.Drawing.Point(1, 21)
      Me.tabProveedor.Name = "tabProveedor"
      Me.tabProveedor.Size = New System.Drawing.Size(446, 314)
      Me.tabProveedor.TabStop = True
      Me.tabProveedor.Text = "Proveedor"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox1.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.cboEstado)
      Me.UiGroupBox1.Controls.Add(Me.cboCiudad)
      Me.UiGroupBox1.Controls.Add(Me.txtWeb)
      Me.UiGroupBox1.Controls.Add(Me.txtEmail)
      Me.UiGroupBox1.Controls.Add(Me.txtFax)
      Me.UiGroupBox1.Controls.Add(Me.txtTelefono2)
      Me.UiGroupBox1.Controls.Add(Me.txtMovil)
      Me.UiGroupBox1.Controls.Add(Me.txtTelefono1)
      Me.UiGroupBox1.Controls.Add(Me.txtDireccion)
      Me.UiGroupBox1.Controls.Add(Me.Label15)
      Me.UiGroupBox1.Controls.Add(Me.Label16)
      Me.UiGroupBox1.Controls.Add(Me.Label17)
      Me.UiGroupBox1.Controls.Add(Me.Label18)
      Me.UiGroupBox1.Controls.Add(Me.Label19)
      Me.UiGroupBox1.Controls.Add(Me.Label20)
      Me.UiGroupBox1.Controls.Add(Me.Label22)
      Me.UiGroupBox1.Controls.Add(Me.Label23)
      Me.UiGroupBox1.Controls.Add(Me.Label24)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 96)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(432, 212)
      Me.UiGroupBox1.TabIndex = 5
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(116, 160)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(308, 20)
      Me.cboMoneda.TabIndex = 14
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 164)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 198
      Me.Label3.Text = "Moneda"
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 184)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(308, 20)
      Me.cboEstado.TabIndex = 15
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboCiudad
      '
      Me.cboCiudad.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCiudad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.Location = New System.Drawing.Point(116, 40)
      Me.cboCiudad.Name = "cboCiudad"
      Me.cboCiudad.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCiudad.Size = New System.Drawing.Size(308, 20)
      Me.cboCiudad.TabIndex = 7
      Me.cboCiudad.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtWeb
      '
      Me.txtWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtWeb.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtWeb.Location = New System.Drawing.Point(116, 136)
      Me.txtWeb.MaxLength = 200
      Me.txtWeb.Name = "txtWeb"
      Me.txtWeb.Size = New System.Drawing.Size(308, 20)
      Me.txtWeb.TabIndex = 13
      Me.txtWeb.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtWeb.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmail
      '
      Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmail.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmail.Location = New System.Drawing.Point(116, 112)
      Me.txtEmail.MaxLength = 200
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.Size = New System.Drawing.Size(308, 20)
      Me.txtEmail.TabIndex = 12
      Me.txtEmail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFax
      '
      Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFax.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFax.Location = New System.Drawing.Point(320, 88)
      Me.txtFax.MaxLength = 100
      Me.txtFax.Name = "txtFax"
      Me.txtFax.Size = New System.Drawing.Size(104, 20)
      Me.txtFax.TabIndex = 11
      Me.txtFax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTelefono2
      '
      Me.txtTelefono2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTelefono2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTelefono2.Location = New System.Drawing.Point(320, 64)
      Me.txtTelefono2.MaxLength = 100
      Me.txtTelefono2.Name = "txtTelefono2"
      Me.txtTelefono2.Size = New System.Drawing.Size(104, 20)
      Me.txtTelefono2.TabIndex = 9
      Me.txtTelefono2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTelefono2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMovil
      '
      Me.txtMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMovil.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMovil.Location = New System.Drawing.Point(116, 88)
      Me.txtMovil.MaxLength = 100
      Me.txtMovil.Name = "txtMovil"
      Me.txtMovil.Size = New System.Drawing.Size(104, 20)
      Me.txtMovil.TabIndex = 10
      Me.txtMovil.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtMovil.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTelefono1
      '
      Me.txtTelefono1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTelefono1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTelefono1.Location = New System.Drawing.Point(116, 64)
      Me.txtTelefono1.MaxLength = 100
      Me.txtTelefono1.Name = "txtTelefono1"
      Me.txtTelefono1.Size = New System.Drawing.Size(104, 20)
      Me.txtTelefono1.TabIndex = 8
      Me.txtTelefono1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTelefono1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtDireccion
      '
      Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDireccion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDireccion.Location = New System.Drawing.Point(116, 16)
      Me.txtDireccion.MaxLength = 200
      Me.txtDireccion.Name = "txtDireccion"
      Me.txtDireccion.Size = New System.Drawing.Size(308, 20)
      Me.txtDireccion.TabIndex = 6
      Me.txtDireccion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDireccion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(292, 92)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(24, 16)
      Me.Label15.TabIndex = 196
      Me.Label15.Text = "Fax"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 92)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 195
      Me.Label16.Text = "Móvil"
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(256, 68)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(60, 16)
      Me.Label17.TabIndex = 194
      Me.Label17.Text = "Teléfono 2"
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 188)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 193
      Me.Label18.Text = "Estado"
      '
      'Label19
      '
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(8, 140)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(104, 16)
      Me.Label19.TabIndex = 192
      Me.Label19.Text = "Página Web"
      '
      'Label20
      '
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(8, 116)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(104, 16)
      Me.Label20.TabIndex = 191
      Me.Label20.Text = "Correo Electrónico"
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(8, 44)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(104, 16)
      Me.Label22.TabIndex = 189
      Me.Label22.Text = "Ciudad"
      '
      'Label23
      '
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.Location = New System.Drawing.Point(8, 68)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(104, 16)
      Me.Label23.TabIndex = 188
      Me.Label23.Text = "Teléfono 1"
      '
      'Label24
      '
      Me.Label24.BackColor = System.Drawing.Color.Transparent
      Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label24.Location = New System.Drawing.Point(8, 20)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(104, 16)
      Me.Label24.TabIndex = 187
      Me.Label24.Text = "Dirección"
      '
      'grpMain
      '
      Me.grpMain.BackColor = System.Drawing.Color.Transparent
      Me.grpMain.Controls.Add(Me.txtProveedorCod)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtProveedorNIT)
      Me.grpMain.Controls.Add(Me.txtProveedorDes)
      Me.grpMain.Controls.Add(Me.txtProveedorId)
      Me.grpMain.Controls.Add(Me.Label25)
      Me.grpMain.Controls.Add(Me.Label26)
      Me.grpMain.Controls.Add(Me.Label27)
      Me.grpMain.Location = New System.Drawing.Point(8, 4)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(432, 92)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtProveedorCod
      '
      Me.txtProveedorCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProveedorCod.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtProveedorCod.Location = New System.Drawing.Point(116, 40)
      Me.txtProveedorCod.MaxLength = 50
      Me.txtProveedorCod.Name = "txtProveedorCod"
      Me.txtProveedorCod.Size = New System.Drawing.Size(104, 20)
      Me.txtProveedorCod.TabIndex = 2
      Me.txtProveedorCod.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProveedorCod.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 168
      Me.Label1.Text = "Código"
      '
      'txtProveedorNIT
      '
      Me.txtProveedorNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProveedorNIT.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtProveedorNIT.Location = New System.Drawing.Point(320, 40)
      Me.txtProveedorNIT.MaxLength = 50
      Me.txtProveedorNIT.Name = "txtProveedorNIT"
      Me.txtProveedorNIT.Size = New System.Drawing.Size(104, 20)
      Me.txtProveedorNIT.TabIndex = 3
      Me.txtProveedorNIT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProveedorNIT.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtProveedorDes
      '
      Me.txtProveedorDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProveedorDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtProveedorDes.Location = New System.Drawing.Point(116, 64)
      Me.txtProveedorDes.Name = "txtProveedorDes"
      Me.txtProveedorDes.Size = New System.Drawing.Size(308, 20)
      Me.txtProveedorDes.TabIndex = 4
      Me.txtProveedorDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProveedorDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtProveedorId
      '
      Me.txtProveedorId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProveedorId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtProveedorId.Location = New System.Drawing.Point(116, 16)
      Me.txtProveedorId.Name = "txtProveedorId"
      Me.txtProveedorId.ReadOnly = True
      Me.txtProveedorId.Size = New System.Drawing.Size(104, 20)
      Me.txtProveedorId.TabIndex = 1
      Me.txtProveedorId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProveedorId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label25
      '
      Me.Label25.BackColor = System.Drawing.Color.Transparent
      Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label25.Location = New System.Drawing.Point(292, 44)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(24, 16)
      Me.Label25.TabIndex = 166
      Me.Label25.Text = "NIT"
      '
      'Label26
      '
      Me.Label26.BackColor = System.Drawing.Color.Transparent
      Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label26.Location = New System.Drawing.Point(8, 68)
      Me.Label26.Name = "Label26"
      Me.Label26.Size = New System.Drawing.Size(104, 16)
      Me.Label26.TabIndex = 165
      Me.Label26.Text = "Proveedor"
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
      'tabContacto
      '
      Me.tabContacto.Controls.Add(Me.UiGroupBox7)
      Me.tabContacto.Controls.Add(Me.UiGroupBox6)
      Me.tabContacto.Controls.Add(Me.UiGroupBox2)
      Me.tabContacto.Key = "Contacto"
      Me.tabContacto.Location = New System.Drawing.Point(1, 21)
      Me.tabContacto.Name = "tabContacto"
      Me.tabContacto.Size = New System.Drawing.Size(446, 314)
      Me.tabContacto.TabStop = True
      Me.tabContacto.Text = "Contacto"
      '
      'UiGroupBox7
      '
      Me.UiGroupBox7.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox7.Controls.Add(Me.cboProcedencia)
      Me.UiGroupBox7.Controls.Add(Me.cboRubro)
      Me.UiGroupBox7.Controls.Add(Me.Label11)
      Me.UiGroupBox7.Controls.Add(Me.Label14)
      Me.UiGroupBox7.Location = New System.Drawing.Point(7, 160)
      Me.UiGroupBox7.Name = "UiGroupBox7"
      Me.UiGroupBox7.Size = New System.Drawing.Size(432, 72)
      Me.UiGroupBox7.TabIndex = 25
      Me.UiGroupBox7.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'cboProcedencia
      '
      Me.cboProcedencia.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboProcedencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboProcedencia.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProcedencia.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProcedencia.Location = New System.Drawing.Point(116, 16)
      Me.cboProcedencia.Name = "cboProcedencia"
      Me.cboProcedencia.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboProcedencia.Size = New System.Drawing.Size(308, 20)
      Me.cboProcedencia.TabIndex = 26
      Me.cboProcedencia.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboRubro
      '
      Me.cboRubro.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboRubro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboRubro.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboRubro.Location = New System.Drawing.Point(116, 40)
      Me.cboRubro.Name = "cboRubro"
      Me.cboRubro.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboRubro.Size = New System.Drawing.Size(308, 20)
      Me.cboRubro.TabIndex = 27
      Me.cboRubro.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 18)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 211
      Me.Label11.Text = "Procedencia"
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 42)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(104, 16)
      Me.Label14.TabIndex = 210
      Me.Label14.Text = "Rubro"
      Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'UiGroupBox6
      '
      Me.UiGroupBox6.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox6.Controls.Add(Me.txtInteresAnual)
      Me.UiGroupBox6.Controls.Add(Me.Label34)
      Me.UiGroupBox6.Controls.Add(Me.Label13)
      Me.UiGroupBox6.Controls.Add(Me.dudCreditoDias)
      Me.UiGroupBox6.Controls.Add(Me.chkCreditoAuto)
      Me.UiGroupBox6.Controls.Add(Me.txtCreditoLimite)
      Me.UiGroupBox6.Controls.Add(Me.Label32)
      Me.UiGroupBox6.Location = New System.Drawing.Point(7, 96)
      Me.UiGroupBox6.Name = "UiGroupBox6"
      Me.UiGroupBox6.Size = New System.Drawing.Size(432, 64)
      Me.UiGroupBox6.TabIndex = 20
      Me.UiGroupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'txtInteresAnual
      '
      Me.txtInteresAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtInteresAnual.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtInteresAnual.FormatString = "##,##0.000"
      Me.txtInteresAnual.Location = New System.Drawing.Point(320, 12)
      Me.txtInteresAnual.Name = "txtInteresAnual"
      Me.txtInteresAnual.Size = New System.Drawing.Size(104, 20)
      Me.txtInteresAnual.TabIndex = 23
      Me.txtInteresAnual.Text = "0,000"
      Me.txtInteresAnual.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtInteresAnual.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtInteresAnual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label34
      '
      Me.Label34.BackColor = System.Drawing.Color.Transparent
      Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label34.Location = New System.Drawing.Point(256, 16)
      Me.Label34.Name = "Label34"
      Me.Label34.Size = New System.Drawing.Size(60, 16)
      Me.Label34.TabIndex = 212
      Me.Label34.Text = "Int. Anual"
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(8, 40)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(104, 16)
      Me.Label13.TabIndex = 204
      Me.Label13.Text = "Días Crédito Auto"
      '
      'dudCreditoDias
      '
      Me.dudCreditoDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudCreditoDias.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudCreditoDias.Location = New System.Drawing.Point(116, 36)
      Me.dudCreditoDias.Maximum = 10000
      Me.dudCreditoDias.Name = "dudCreditoDias"
      Me.dudCreditoDias.Size = New System.Drawing.Size(104, 20)
      Me.dudCreditoDias.TabIndex = 22
      Me.dudCreditoDias.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudCreditoDias.Value = 30
      Me.dudCreditoDias.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'chkCreditoAuto
      '
      Me.chkCreditoAuto.BackColor = System.Drawing.Color.Transparent
      Me.chkCreditoAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkCreditoAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkCreditoAuto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkCreditoAuto.Location = New System.Drawing.Point(240, 40)
      Me.chkCreditoAuto.Name = "chkCreditoAuto"
      Me.chkCreditoAuto.Size = New System.Drawing.Size(184, 16)
      Me.chkCreditoAuto.TabIndex = 24
      Me.chkCreditoAuto.Text = "Programar Crédito Automático"
      Me.chkCreditoAuto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtCreditoLimite
      '
      Me.txtCreditoLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCreditoLimite.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCreditoLimite.FormatString = "##,##0.000"
      Me.txtCreditoLimite.Location = New System.Drawing.Point(116, 12)
      Me.txtCreditoLimite.Name = "txtCreditoLimite"
      Me.txtCreditoLimite.Size = New System.Drawing.Size(104, 20)
      Me.txtCreditoLimite.TabIndex = 21
      Me.txtCreditoLimite.Text = "0,000"
      Me.txtCreditoLimite.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCreditoLimite.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCreditoLimite.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label32
      '
      Me.Label32.BackColor = System.Drawing.Color.Transparent
      Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label32.Location = New System.Drawing.Point(8, 16)
      Me.Label32.Name = "Label32"
      Me.Label32.Size = New System.Drawing.Size(104, 16)
      Me.Label32.TabIndex = 165
      Me.Label32.Text = "Límite de Crédito"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox2.Controls.Add(Me.txtContactoCargo)
      Me.UiGroupBox2.Controls.Add(Me.Label5)
      Me.UiGroupBox2.Controls.Add(Me.txtContactoCI)
      Me.UiGroupBox2.Controls.Add(Me.Label2)
      Me.UiGroupBox2.Controls.Add(Me.txtContactoDes)
      Me.UiGroupBox2.Controls.Add(Me.Label4)
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 4)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(432, 92)
      Me.UiGroupBox2.TabIndex = 16
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'txtContactoCargo
      '
      Me.txtContactoCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtContactoCargo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtContactoCargo.Location = New System.Drawing.Point(116, 64)
      Me.txtContactoCargo.Name = "txtContactoCargo"
      Me.txtContactoCargo.Size = New System.Drawing.Size(308, 20)
      Me.txtContactoCargo.TabIndex = 19
      Me.txtContactoCargo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtContactoCargo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 68)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 170
      Me.Label5.Text = "Cargo"
      '
      'txtContactoCI
      '
      Me.txtContactoCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtContactoCI.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtContactoCI.Location = New System.Drawing.Point(116, 40)
      Me.txtContactoCI.MaxLength = 50
      Me.txtContactoCI.Name = "txtContactoCI"
      Me.txtContactoCI.Size = New System.Drawing.Size(104, 20)
      Me.txtContactoCI.TabIndex = 18
      Me.txtContactoCI.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtContactoCI.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 44)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 168
      Me.Label2.Text = "C.I."
      '
      'txtContactoDes
      '
      Me.txtContactoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtContactoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtContactoDes.Location = New System.Drawing.Point(116, 16)
      Me.txtContactoDes.Name = "txtContactoDes"
      Me.txtContactoDes.Size = New System.Drawing.Size(308, 20)
      Me.txtContactoDes.TabIndex = 17
      Me.txtContactoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtContactoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 20)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 165
      Me.Label4.Text = "Contacto"
      '
      'tabItemProveedor
      '
      Me.tabItemProveedor.Controls.Add(Me.ebrItemProveedor)
      Me.tabItemProveedor.Key = "ItemProveedor"
      Me.tabItemProveedor.Location = New System.Drawing.Point(1, 21)
      Me.tabItemProveedor.Name = "tabItemProveedor"
      Me.tabItemProveedor.Size = New System.Drawing.Size(446, 314)
      Me.tabItemProveedor.TabStop = True
      Me.tabItemProveedor.Text = "Ítems"
      Me.tabItemProveedor.Visible = False
      '
      'ebrItemProveedor
      '
      Me.ebrItemProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrItemProveedor.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrItemProveedor.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup4.Container = True
      ExplorerBarGroup4.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup4.ContainerHeight = 272
      ExplorerBarGroup4.Expandable = False
      ExplorerBarGroup4.Key = "Group1"
      Me.ebrItemProveedor.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup4})
      Me.ebrItemProveedor.GroupSeparation = 4
      Me.ebrItemProveedor.Location = New System.Drawing.Point(5, 4)
      Me.ebrItemProveedor.Name = "ebrItemProveedor"
      Me.ebrItemProveedor.Size = New System.Drawing.Size(436, 304)
      Me.ebrItemProveedor.TabIndex = 5
      Me.ebrItemProveedor.Text = "ExplorerBar2"
      Me.ebrItemProveedor.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrItemProveedor.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemProveedor.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemProveedor.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabCuentas
      '
      Me.tabCuentas.Controls.Add(Me.UiGroupBox4)
      Me.tabCuentas.Controls.Add(Me.UiGroupBox3)
      Me.tabCuentas.Location = New System.Drawing.Point(1, 21)
      Me.tabCuentas.Name = "tabCuentas"
      Me.tabCuentas.Size = New System.Drawing.Size(446, 314)
      Me.tabCuentas.TabStop = True
      Me.tabCuentas.Text = "Cuentas"
      '
      'UiGroupBox4
      '
      Me.UiGroupBox4.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox4.Controls.Add(Me.cboTipoDocIdentidad)
      Me.UiGroupBox4.Controls.Add(Me.Label29)
      Me.UiGroupBox4.Controls.Add(Me.cboMonedaCuenta)
      Me.UiGroupBox4.Controls.Add(Me.Label28)
      Me.UiGroupBox4.Controls.Add(Me.cboBanco)
      Me.UiGroupBox4.Controls.Add(Me.txtNroCuenta)
      Me.UiGroupBox4.Controls.Add(Me.Label12)
      Me.UiGroupBox4.Controls.Add(Me.Label21)
      Me.UiGroupBox4.Location = New System.Drawing.Point(8, 168)
      Me.UiGroupBox4.Name = "UiGroupBox4"
      Me.UiGroupBox4.Size = New System.Drawing.Size(432, 128)
      Me.UiGroupBox4.TabIndex = 35
      Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboMonedaCuenta
      '
      Me.cboMonedaCuenta.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMonedaCuenta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaCuenta.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaCuenta.Location = New System.Drawing.Point(116, 64)
      Me.cboMonedaCuenta.Name = "cboMonedaCuenta"
      Me.cboMonedaCuenta.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMonedaCuenta.Size = New System.Drawing.Size(124, 20)
      Me.cboMonedaCuenta.TabIndex = 38
      Me.cboMonedaCuenta.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label28
      '
      Me.Label28.BackColor = System.Drawing.Color.Transparent
      Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label28.Location = New System.Drawing.Point(8, 66)
      Me.Label28.Name = "Label28"
      Me.Label28.Size = New System.Drawing.Size(104, 16)
      Me.Label28.TabIndex = 200
      Me.Label28.Text = "Moneda"
      '
      'cboBanco
      '
      Me.cboBanco.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboBanco.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.Location = New System.Drawing.Point(116, 16)
      Me.cboBanco.Name = "cboBanco"
      Me.cboBanco.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboBanco.Size = New System.Drawing.Size(308, 20)
      Me.cboBanco.TabIndex = 36
      Me.cboBanco.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtNroCuenta
      '
      Me.txtNroCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNroCuenta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroCuenta.Location = New System.Drawing.Point(116, 40)
      Me.txtNroCuenta.MaxLength = 50
      Me.txtNroCuenta.Name = "txtNroCuenta"
      Me.txtNroCuenta.Size = New System.Drawing.Size(124, 20)
      Me.txtNroCuenta.TabIndex = 37
      Me.txtNroCuenta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroCuenta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 20)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 189
      Me.Label12.Text = "Banco"
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.Location = New System.Drawing.Point(8, 44)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(104, 16)
      Me.Label21.TabIndex = 185
      Me.Label21.Text = "Nro Cuenta"
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox3.Controls.Add(Me.cboPlanAddInt)
      Me.UiGroupBox3.Controls.Add(Me.Label9)
      Me.UiGroupBox3.Controls.Add(Me.cboPlanInt)
      Me.UiGroupBox3.Controls.Add(Me.Label10)
      Me.UiGroupBox3.Controls.Add(Me.cboPlanAddAct)
      Me.UiGroupBox3.Controls.Add(Me.Label8)
      Me.UiGroupBox3.Controls.Add(Me.cboPlanAddPas)
      Me.UiGroupBox3.Controls.Add(Me.Label6)
      Me.UiGroupBox3.Controls.Add(Me.cboPlanAct)
      Me.UiGroupBox3.Controls.Add(Me.cboPlanPas)
      Me.UiGroupBox3.Controls.Add(Me.Label7)
      Me.UiGroupBox3.Controls.Add(Me.lblActivo)
      Me.UiGroupBox3.Location = New System.Drawing.Point(8, 4)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(432, 160)
      Me.UiGroupBox3.TabIndex = 28
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'cboPlanAddInt
      '
      Me.cboPlanAddInt.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanAddInt.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddInt.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddInt.Location = New System.Drawing.Point(116, 132)
      Me.cboPlanAddInt.Name = "cboPlanAddInt"
      Me.cboPlanAddInt.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanAddInt.Size = New System.Drawing.Size(308, 20)
      Me.cboPlanAddInt.TabIndex = 34
      Me.cboPlanAddInt.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 136)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 208
      Me.Label9.Text = "Analítico Adicional"
      '
      'cboPlanInt
      '
      cboPlanInt_DesignTimeLayout.LayoutString = resources.GetString("cboPlanInt_DesignTimeLayout.LayoutString")
      Me.cboPlanInt.DesignTimeLayout = cboPlanInt_DesignTimeLayout
      Me.cboPlanInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanInt.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanInt.Location = New System.Drawing.Point(116, 108)
      Me.cboPlanInt.Name = "cboPlanInt"
      Me.cboPlanInt.SelectedIndex = -1
      Me.cboPlanInt.SelectedItem = Nothing
      Me.cboPlanInt.Size = New System.Drawing.Size(308, 20)
      Me.cboPlanInt.TabIndex = 33
      Me.cboPlanInt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanInt.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 112)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 207
      Me.Label10.Text = "Cuenta de Interés"
      '
      'cboPlanAddAct
      '
      Me.cboPlanAddAct.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanAddAct.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddAct.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddAct.Location = New System.Drawing.Point(116, 84)
      Me.cboPlanAddAct.Name = "cboPlanAddAct"
      Me.cboPlanAddAct.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanAddAct.Size = New System.Drawing.Size(308, 20)
      Me.cboPlanAddAct.TabIndex = 32
      Me.cboPlanAddAct.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 88)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 204
      Me.Label8.Text = "Analítico Adicional"
      '
      'cboPlanAddPas
      '
      Me.cboPlanAddPas.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddPas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanAddPas.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddPas.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAddPas.Location = New System.Drawing.Point(116, 36)
      Me.cboPlanAddPas.Name = "cboPlanAddPas"
      Me.cboPlanAddPas.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanAddPas.Size = New System.Drawing.Size(308, 20)
      Me.cboPlanAddPas.TabIndex = 30
      Me.cboPlanAddPas.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 40)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 202
      Me.Label6.Text = "Analítico Adicional"
      '
      'cboPlanAct
      '
      cboPlanAct_DesignTimeLayout.LayoutString = resources.GetString("cboPlanAct_DesignTimeLayout.LayoutString")
      Me.cboPlanAct.DesignTimeLayout = cboPlanAct_DesignTimeLayout
      Me.cboPlanAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanAct.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAct.Location = New System.Drawing.Point(116, 60)
      Me.cboPlanAct.Name = "cboPlanAct"
      Me.cboPlanAct.SelectedIndex = -1
      Me.cboPlanAct.SelectedItem = Nothing
      Me.cboPlanAct.Size = New System.Drawing.Size(308, 20)
      Me.cboPlanAct.TabIndex = 31
      Me.cboPlanAct.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanAct.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanPas
      '
      cboPlanPas_DesignTimeLayout.LayoutString = resources.GetString("cboPlanPas_DesignTimeLayout.LayoutString")
      Me.cboPlanPas.DesignTimeLayout = cboPlanPas_DesignTimeLayout
      Me.cboPlanPas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanPas.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanPas.Location = New System.Drawing.Point(116, 12)
      Me.cboPlanPas.Name = "cboPlanPas"
      Me.cboPlanPas.SelectedIndex = -1
      Me.cboPlanPas.SelectedItem = Nothing
      Me.cboPlanPas.Size = New System.Drawing.Size(308, 20)
      Me.cboPlanPas.TabIndex = 29
      Me.cboPlanPas.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanPas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 64)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 180
      Me.Label7.Text = "Cuenta de Activo"
      '
      'lblActivo
      '
      Me.lblActivo.BackColor = System.Drawing.Color.Transparent
      Me.lblActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblActivo.Location = New System.Drawing.Point(8, 16)
      Me.lblActivo.Name = "lblActivo"
      Me.lblActivo.Size = New System.Drawing.Size(104, 16)
      Me.lblActivo.TabIndex = 176
      Me.lblActivo.Text = "Cuenta de Pasivo"
      '
      'mnuItemProveedor
      '
      Me.mnuItemProveedor.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuNew, Me.mnuEdit, Me.mnuDelete})
      '
      'mnuShow
      '
      Me.mnuShow.Index = 0
      Me.mnuShow.Text = "Consultar"
      '
      'mnuNew
      '
      Me.mnuNew.Index = 1
      Me.mnuNew.Text = "Nuevo"
      '
      'mnuEdit
      '
      Me.mnuEdit.Index = 2
      Me.mnuEdit.Text = "Editar"
      '
      'mnuDelete
      '
      Me.mnuDelete.Index = 3
      Me.mnuDelete.Text = "Eliminar"
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
      'cboTipoDocIdentidad
      '
      Me.cboTipoDocIdentidad.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoDocIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoDocIdentidad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoDocIdentidad.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoDocIdentidad.Location = New System.Drawing.Point(116, 88)
      Me.cboTipoDocIdentidad.Name = "cboTipoDocIdentidad"
      Me.cboTipoDocIdentidad.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoDocIdentidad.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoDocIdentidad.TabIndex = 39
      Me.cboTipoDocIdentidad.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label29
      '
      Me.Label29.BackColor = System.Drawing.Color.Transparent
      Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label29.Location = New System.Drawing.Point(8, 90)
      Me.Label29.Name = "Label29"
      Me.Label29.Size = New System.Drawing.Size(104, 16)
      Me.Label29.TabIndex = 202
      Me.Label29.Text = "Tipo Doc."
      '
      'frmProveedorEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 377)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmProveedorEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Proveedor Edit"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdItemProveedor, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabMain.ResumeLayout(False)
      Me.tabProveedor.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      Me.tabContacto.ResumeLayout(False)
      CType(Me.UiGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox7.ResumeLayout(False)
      CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox6.ResumeLayout(False)
      Me.UiGroupBox6.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      Me.tabItemProveedor.ResumeLayout(False)
      CType(Me.ebrItemProveedor, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrItemProveedor.ResumeLayout(False)
      Me.tabCuentas.ResumeLayout(False)
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox4.ResumeLayout(False)
      Me.UiGroupBox4.PerformLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      Me.UiGroupBox3.PerformLayout()
      CType(Me.cboPlanInt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanAct, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanPas, System.ComponentModel.ISupportInitialize).EndInit()
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
               mlngID = moProveedor.ProveedorId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmProveedorEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmProveedorEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Proveedor"
         Else
            Me.Text = "Editar Proveedor"
         End If
      Else
         Me.Text = "Nuevo Proveedor"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moProveedor
         txtProveedorId.Text = ToStr(.ProveedorId)
         txtProveedorDes.Text = ToStr(.ProveedorDes)
         txtProveedorCod.Text = ToStr(.ProveedorCod)
         txtProveedorNIT.Text = ToStr(.ProveedorNIT)
         txtDireccion.Text = ToStr(.Direccion)
         cboCiudad.SelectedIndex = ListFindItem(cboCiudad, .CiudadId)
         txtTelefono1.Text = ToStr(.Telefono1)
         txtTelefono2.Text = ToStr(.Telefono2)
         txtMovil.Text = ToStr(.Movil)
         txtFax.Text = ToStr(.Fax)
         txtEmail.Text = ToStr(.Email)
         txtWeb.Text = ToStr(.Web)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtContactoDes.Text = ToStr(.ContactoDes)
         txtContactoCI.Text = ToStr(.ContactoCI)
         txtContactoCargo.Text = ToStr(.ContactoCargo)

         cboPlanPas.Value = ListFindItem(cboPlanPas, .PlanIdPas)
         cboPlanPas.Tag = cboPlanPas.Text
         If TieneAnaAdd(.PlanIdPas) Then
            Call cboPlanAddLoad(cboPlanAddPas, .PlanIdPas)
            cboPlanAddPas.SelectedIndex = ListFindItem(cboPlanAddPas, .PlanAddIdPas)
         End If

         cboPlanAct.Value = ListFindItem(cboPlanAct, .PlanIdAct)
         cboPlanAct.Tag = cboPlanAct.Text
         If TieneAnaAdd(.PlanIdAct) Then
            Call cboPlanAddLoad(cboPlanAddAct, .PlanIdAct)
            cboPlanAddAct.SelectedIndex = ListFindItem(cboPlanAddAct, .PlanAddIdAct)
         End If

         cboPlanInt.Value = ListFindItem(cboPlanInt, .PlanIdInt)
         cboPlanInt.Tag = cboPlanInt.Text
         If TieneAnaAdd(.PlanIdInt) Then
            Call cboPlanAddLoad(cboPlanAddInt, .PlanIdInt)
            cboPlanAddInt.SelectedIndex = ListFindItem(cboPlanAddInt, .PlanAddIdInt)
         End If

         txtCreditoLimite.Text = ToDecStr(.CreditoLimite)
         txtInteresAnual.Text = ToDecStr(.InteresAnual)
         chkCreditoAuto.Checked = ToBoolean(.CreditoAuto)
         dudCreditoDias.Value = ToLong(.CreditoDias)

         cboProcedencia.SelectedIndex = ListFindItem(cboProcedencia, .ProcedenciaId)
         cboRubro.SelectedIndex = ListFindItem(cboRubro, .RubroId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         cboBanco.SelectedIndex = ListFindItem(cboBanco, .BancoId)
         txtNroCuenta.Text = ToStr(.NroCuenta)
         cboMonedaCuenta.SelectedIndex = ListFindItem(cboMonedaCuenta, .MonedaIdCuenta)
         cboTipoDocIdentidad.SelectedIndex = ListFindItem(cboTipoDocIdentidad, .TipoDocIdentidadId)
      End With

      Call grdItemProveedorLoad()

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moProveedor
         txtProveedorId.Text = String.Empty
         txtProveedorDes.Text = String.Empty
         txtProveedorCod.Text = String.Empty
         txtProveedorNIT.Text = String.Empty
         txtDireccion.Text = String.Empty
         cboCiudad.SelectedIndex = -1
         txtTelefono1.Text = String.Empty
         txtTelefono2.Text = String.Empty
         txtMovil.Text = String.Empty
         txtFax.Text = String.Empty
         txtEmail.Text = String.Empty
         txtWeb.Text = String.Empty
         cboMoneda.SelectedIndex = -1
         txtContactoDes.Text = String.Empty
         txtContactoCI.Text = String.Empty
         txtContactoCargo.Text = String.Empty
         cboPlanPas.Value = Nothing
         cboPlanAddPas.SelectedIndex = -1
         cboPlanAct.Value = Nothing
         cboPlanAddAct.SelectedIndex = -1
         cboPlanInt.Value = Nothing
         cboPlanAddInt.SelectedIndex = -1
         txtCreditoLimite.Text = "0"
         txtInteresAnual.Text = "0"
         chkCreditoAuto.Checked = True
         dudCreditoDias.Value = 30

         cboProcedencia.SelectedIndex = -1
         cboRubro.SelectedIndex = -1
         cboBanco.SelectedIndex = -1
         txtNroCuenta.Text = String.Empty
         cboTipoDocIdentidad.SelectedIndex = -1
         cboMonedaCuenta.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 1)
         cboEstado.ReadOnly = True
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtProveedorId.ReadOnly = True
      txtProveedorDes.ReadOnly = True
      txtProveedorCod.ReadOnly = True
      txtProveedorNIT.ReadOnly = True
      txtDireccion.ReadOnly = True
      cboCiudad.ReadOnly = True
      txtTelefono1.ReadOnly = True
      txtTelefono2.ReadOnly = True
      txtMovil.ReadOnly = True
      txtFax.ReadOnly = True
      txtEmail.ReadOnly = True
      txtWeb.ReadOnly = True
      cboMoneda.ReadOnly = True
      txtContactoDes.ReadOnly = True
      txtContactoCI.ReadOnly = True
      txtContactoCargo.ReadOnly = True
      cboPlanPas.ReadOnly = True
      cboPlanAddPas.ReadOnly = True
      cboPlanAct.ReadOnly = True
      cboPlanAddAct.ReadOnly = True
      cboPlanInt.ReadOnly = True
      cboPlanAddInt.ReadOnly = True
      txtCreditoLimite.ReadOnly = True
      txtInteresAnual.ReadOnly = True
      chkCreditoAuto.Enabled = False
      dudCreditoDias.ReadOnly = True

      cboProcedencia.ReadOnly = True
      cboRubro.ReadOnly = True
      cboEstado.ReadOnly = True
      cboBanco.ReadOnly = True
      txtNroCuenta.ReadOnly = True
      cboMonedaCuenta.ReadOnly = True
      cboTipoDocIdentidad.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moProveedor
         If Not mboolAdding Then
            .ProveedorId = ToLong(txtProveedorId.Text)
         End If

         .ProveedorDes = ToStr(txtProveedorDes.Text)
         .ProveedorCod = ToStr(txtProveedorCod.Text)
         .ProveedorNIT = ToStr(txtProveedorNIT.Text)
         .Direccion = ToStr(txtDireccion.Text)
         .CiudadId = ListPosition(cboCiudad, cboCiudad.SelectedIndex)
         .Telefono1 = ToStr(txtTelefono1.Text)
         .Telefono2 = ToStr(txtTelefono2.Text)
         .Movil = ToStr(txtMovil.Text)
         .Fax = ToStr(txtFax.Text)
         .Email = ToStr(txtEmail.Text)
         .Web = ToStr(txtWeb.Text)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .ContactoDes = ToStr(txtContactoDes.Text)
         .ContactoCI = ToStr(txtContactoCI.Text)
         .ContactoCargo = ToStr(txtContactoCargo.Text)
         .PlanIdPas = ListPosition(cboPlanPas)
         .PlanAddIdPas = ListPosition(cboPlanAddPas, cboPlanAddPas.SelectedIndex)
         .PlanIdAct = ListPosition(cboPlanAct)
         .PlanAddIdAct = ListPosition(cboPlanAddAct, cboPlanAddAct.SelectedIndex)
         .PlanIdInt = ListPosition(cboPlanInt)
         .PlanAddIdInt = ListPosition(cboPlanAddInt, cboPlanAddInt.SelectedIndex)
         .CreditoLimite = ToDecimal(txtCreditoLimite.Text)
         .InteresAnual = ToDecimal(txtInteresAnual.Text)
         .CreditoAuto = ToBoolean(chkCreditoAuto.Checked)
         .CreditoDias = ToLong(dudCreditoDias.Value)
         .ProcedenciaId = ListPosition(cboProcedencia, cboProcedencia.SelectedIndex)
         .RubroId = ListPosition(cboRubro, cboRubro.SelectedIndex)
         .BancoId = ListPosition(cboBanco, cboBanco.SelectedIndex)
         .NroCuenta = ToStr(txtNroCuenta.Text)
         .MonedaIdCuenta = ListPosition(cboMonedaCuenta, cboMonedaCuenta.SelectedIndex)
         .TipoDocIdentidadId = ListPosition(cboTipoDocIdentidad, cboTipoDocIdentidad.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtProveedorCod.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If moProveedor.Validate Then
            If FormCheck() Then
               If mboolAdding Then
                  DataSave = DataAdd()
               Else
                  DataSave = DataUpdate()
               End If
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

         If moProveedor.Insert() Then
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

         If moProveedor.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.Inventario Then
         If ListPosition(cboPlanPas) <> 0 Then
            If TieneAnaAdd(ListPosition(cboPlanPas)) Then
               If ListPosition(cboPlanAddPas, cboPlanAddPas.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione el Analítico Adicional de la Cuenta de Pasivo" & vbCrLf
               End If
            End If
         Else
            strMsg &= "Seleccione la Cuenta de Pasivo" & vbCrLf
         End If

         If ListPosition(cboPlanAct) <> 0 Then
            If TieneAnaAdd(ListPosition(cboPlanAct)) Then
               If ListPosition(cboPlanAddAct, cboPlanAddAct.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione el Analítico Adicional de la Cuenta de Activo" & vbCrLf
               End If
            End If
         Else
            strMsg &= "Seleccione la Cuenta de Activo" & vbCrLf
         End If

         If ListPosition(cboPlanInt) <> 0 Then
            If TieneAnaAdd(ListPosition(cboPlanInt)) Then
               If ListPosition(cboPlanAddInt, cboPlanAddInt.SelectedIndex) = 0 Then
                  strMsg &= "Seleccione el Analítico Adicional de la Cuenta de Interes" & vbCrLf
               End If
            End If
         Else
            strMsg &= "Seleccione la Cuenta de Interés" & vbCrLf
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      moItemProveedor = New clsItemProveedor(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboCiudadLoad()
      Call cboMonedaLoad()
      Call cboPlanLoad()
      Call cboProcedenciaLoad()
      Call cboRubroLoad()
      Call cboBancoLoad()
      Call cboTipoDocIdentidadLoad()
      Call cboEstadoLoad()
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

   Private Sub cboMonedaLoad()
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMoneda.Items.Clear()
      cboMonedaCuenta.Items.Clear()

      Try
         With oMoneda
            .SelectFilter = clsMoneda.SelectFilters.ListBox
            .OrderByFilter = clsMoneda.OrderByFilters.MonedaDes

            If .Open() Then
               Do While .Read()
                  If .MonedaId > 0 Then
                     oItem = New clsListItem(.MonedaId, .MonedaDes)

                     cboMoneda.Items.Add(oItem)
                     cboMonedaCuenta.Items.Add(oItem)
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
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moProveedor.EmpresaId
            .EsAna = 1

            If .Open() Then
               With cboPlanPas
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

               With cboPlanAct
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

               With cboPlanInt
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

   Private Sub cboPlanAddLoad(ByVal cboPlanAdd As Janus.Windows.EditControls.UIComboBox, ByVal lngPlanId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPlanAdd.Items.Clear()
      cboPlanAdd.Text = ""

      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.ListBox
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes
            .EmpresaId = moProveedor.EmpresaId
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

   Private Sub cboProcedenciaLoad()
      Dim oProcedencia As New clsProcedencia(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboProcedencia.Items.Clear()

      Try
         With oProcedencia
            .SelectFilter = clsProcedencia.SelectFilters.ListBox
            .OrderByFilter = clsProcedencia.OrderByFilters.ProcedenciaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.ProcedenciaId, .ProcedenciaDes)

                  cboProcedencia.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProcedencia.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboRubroLoad()
      Dim oRubro As New clsRubro(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboRubro.Items.Clear()

      Try
         With oRubro
            .SelectFilter = clsRubro.SelectFilters.ListBox
            .OrderByFilter = clsRubro.OrderByFilters.RubroDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.RubroId, .RubroDes)

                  cboRubro.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRubro.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboBancoLoad()
      Dim oBanco As New clsBanco(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboBanco.Items.Clear()

      Try
         With oBanco
            .SelectFilter = clsBanco.SelectFilters.ListBox
            .WhereFilter = clsBanco.WhereFilters.EmpresaId
            .OrderByFilter = clsBanco.OrderByFilters.BancoDes
            .EmpresaId = moProveedor.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.BancoId, .BancoDes)

                  cboBanco.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oBanco.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoDocIdentidadLoad()
      Dim oTipoDocIdentidad As New clsTipoDocIdentidad(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoDocIdentidad.Items.Clear()

      Try
         With oTipoDocIdentidad
            .SelectFilter = clsTipoDocIdentidad.SelectFilters.ListBox
            .OrderByFilter = clsTipoDocIdentidad.OrderByFilters.TipoDocIdentidadDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoDocIdentidadId, .TipoDocIdentidadCod)
                  cboTipoDocIdentidad.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoDocIdentidad.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Function TieneAnaAdd(ByVal lngPlanId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               Return ToBoolean(.TieneAnaAdd)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub cboPlanPas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPlanPas.LostFocus
      If cboPlanPas.Tag <> cboPlanPas.Text Then
         cboPlanPas.Tag = cboPlanPas.Text

         Dim lngPlanId As Long = ListPosition(cboPlanPas)

         If TieneAnaAdd(lngPlanId) Then
            Call cboPlanAddLoad(cboPlanAddPas, lngPlanId)
         Else
            cboPlanAddPas.Items.Clear()
            cboPlanAddPas.Text = ""
         End If
      End If
   End Sub

   Private Sub cboPlanAct_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPlanAct.LostFocus
      If cboPlanAct.Tag <> cboPlanAct.Text Then
         cboPlanAct.Tag = cboPlanAct.Text

         Dim lngPlanId As Long = ListPosition(cboPlanAct)

         If TieneAnaAdd(lngPlanId) Then
            Call cboPlanAddLoad(cboPlanAddAct, lngPlanId)
         Else
            cboPlanAddAct.Items.Clear()
            cboPlanAddAct.Text = ""
         End If
      End If
   End Sub

   Private Sub cboPlanInt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPlanInt.LostFocus
      If cboPlanInt.Tag <> cboPlanInt.Text Then
         cboPlanInt.Tag = cboPlanInt.Text

         Dim lngPlanId As Long = ListPosition(cboPlanInt)

         If TieneAnaAdd(lngPlanId) Then
            Call cboPlanAddLoad(cboPlanAddInt, lngPlanId)
         Else
            cboPlanAddInt.Items.Clear()
            cboPlanAddInt.Text = ""
         End If
      End If
   End Sub

   Private Sub cboPlanAddPas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPlanAddPas.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               If TieneAnaAdd(ListPosition(cboPlanPas)) Then
                  Dim frm As New frmPlanAddEdit
                  Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)

                  Try
                     With frm
                        Dim lngPlanId As Long = ListPosition(cboPlanPas)

                        .NewRecord = True
                        .Editing = False

                        oPlanAdd.EmpresaId = moProveedor.EmpresaId
                        oPlanAdd.PlanId = lngPlanId
                        oPlanAdd.PlanAddCta = ToStr(txtProveedorCod.Text)
                        oPlanAdd.PlanAddDes = ToStr(txtProveedorDes.Text)

                        .DataObject = oPlanAdd
                        .ShowDialog()

                        If .Changed Then

                           Call cboPlanAddLoad(cboPlanAddPas, lngPlanId)
                           cboPlanAddPas.SelectedIndex = ListFindItem(cboPlanAddPas, ToLong(frm.ID))
                        End If
                        frm.Dispose()
                     End With

                  Catch exp As Exception
                     MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                  Finally
                     oPlanAdd.Dispose()

                  End Try
               Else
                  MessageBox.Show("La Cuenta no Permite Analíticos Adicionales", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboPlanAddAct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPlanAddAct.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               If TieneAnaAdd(ListPosition(cboPlanAct)) Then
                  Dim frm As New frmPlanAddEdit
                  Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)

                  Try
                     With frm
                        Dim lngPlanId As Long = ListPosition(cboPlanAct)

                        .NewRecord = True
                        .Editing = False

                        oPlanAdd.EmpresaId = moProveedor.EmpresaId
                        oPlanAdd.PlanId = lngPlanId
                        oPlanAdd.PlanAddCta = ToStr(txtProveedorCod.Text)
                        oPlanAdd.PlanAddDes = ToStr(txtProveedorDes.Text)

                        .DataObject = oPlanAdd
                        .ShowDialog()

                        If .Changed Then

                           Call cboPlanAddLoad(cboPlanAddAct, lngPlanId)
                           cboPlanAddAct.SelectedIndex = ListFindItem(cboPlanAddAct, ToLong(frm.ID))
                        End If
                        frm.Dispose()
                     End With

                  Catch exp As Exception
                     MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                  Finally
                     oPlanAdd.Dispose()

                  End Try
               Else
                  MessageBox.Show("La Cuenta no Permite Analíticos Adicionales", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboPlanAddInt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPlanAddInt.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               If TieneAnaAdd(ListPosition(cboPlanInt)) Then
                  Dim frm As New frmPlanAddEdit
                  Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)

                  Try
                     With frm
                        Dim lngPlanId As Long = ListPosition(cboPlanInt)

                        .NewRecord = True
                        .Editing = False

                        oPlanAdd.EmpresaId = moProveedor.EmpresaId
                        oPlanAdd.PlanId = lngPlanId
                        oPlanAdd.PlanAddCta = ToStr(txtProveedorCod.Text)
                        oPlanAdd.PlanAddDes = ToStr(txtProveedorDes.Text)

                        .DataObject = oPlanAdd
                        .ShowDialog()

                        If .Changed Then

                           Call cboPlanAddLoad(cboPlanAddInt, lngPlanId)
                           cboPlanAddInt.SelectedIndex = ListFindItem(cboPlanAddInt, ToLong(frm.ID))
                        End If
                        frm.Dispose()
                     End With

                  Catch exp As Exception
                     MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                  Finally
                     oPlanAdd.Dispose()

                  End Try
               Else
                  MessageBox.Show("La Cuenta no Permite Analíticos Adicionales", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboProcedencia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProcedencia.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmProcedenciaEdit
               Dim oProcedencia As New clsProcedencia(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     .DataObject = oProcedencia
                     .ShowDialog()

                     If .Changed Then
                        Call cboProcedenciaLoad()
                        cboProcedencia.SelectedIndex = ListFindItem(cboProcedencia, frm.ID)
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oProcedencia.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboRubro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRubro.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmRubroEdit
               Dim oRubro As New clsRubro(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     .DataObject = oRubro
                     .ShowDialog()

                     If .Changed Then
                        Call cboRubroLoad()
                        cboRubro.SelectedIndex = ListFindItem(cboRubro, frm.ID)
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oRubro.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

#Region " ItemProveedor "

   Private Sub grdItemProveedorLoad()
      Try
         With moItemProveedor
            .SelectFilter = clsItemProveedor.SelectFilters.Grid
            .WhereFilter = clsItemProveedor.WhereFilters.Grid
            .OrderByFilter = clsItemProveedor.OrderByFilters.Grid
            .EmpresaId = moProveedor.EmpresaId
            .ProveedorId = moProveedor.ProveedorId

            If .Open() Then
               grdItemProveedor.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdItemProveedor.RetrieveStructure()
               Call grdPrecioInit()
            End If
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub ItemProveedorDataShow()
      Dim oItemProveedor As New clsItemProveedor(clsAppInfo.ConnectString)

      Try
         If grdItemProveedor.RowCount > 0 Then
            With oItemProveedor
               .ItemProveedorId = ToLong(grdItemProveedor.GetValue("ItemProveedorId"))

               If .FindByPK Then
                  Dim frm As New frmItemProveedorEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oItemProveedor

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemProveedor = Nothing

      End Try
   End Sub

   Private Sub ItemProveedorFormNew()
      Dim frm As New frmItemProveedorEdit
      Dim oItemProveedor As New clsItemProveedor(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oItemProveedor.EmpresaId = moProveedor.EmpresaId
            oItemProveedor.ProveedorId = moProveedor.ProveedorId

            .DataObject = oItemProveedor
            .ShowDialog()

            If .Changed Then
               Call grdItemProveedorLoad()
               Call grdItemProveedorFindRow(frm.ID)

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub ItemProveedorDataEdit()
      Dim oItemProveedor As New clsItemProveedor(clsAppInfo.ConnectString)

      Try
         If grdItemProveedor.RowCount > 0 Then
            With oItemProveedor
               .ItemProveedorId = ToLong(grdItemProveedor.GetValue("ItemProveedorId"))

               If .FindByPK Then
                  Dim frm As New frmItemProveedorEdit

                  frm.NewRecord = False
                  frm.Editing = True

                  frm.DataObject = oItemProveedor
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdItemProveedorLoad()
                     Call grdItemProveedorFindRow(frm.ID)

                  End If
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemProveedor = Nothing

      End Try
   End Sub

   Private Sub ItemProveedorDataDelete()
      Dim oItemProveedor As New clsItemProveedor(clsAppInfo.ConnectString)

      Try
         If grdItemProveedor.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oItemProveedor
                  .WhereFilter = clsItemProveedor.WhereFilters.PrimaryKey
                  .ItemProveedorId = ToLong(grdItemProveedor.GetValue("PrecioId"))

                  If .Delete Then
                     Call grdItemProveedorLoad()
                  End If
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemProveedor = Nothing

      End Try
   End Sub

   Private Sub grdItemProveedorFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdItemProveedor.RootTable.Columns("ItemProveedorId")

      grdItemProveedor.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdPrecioInit()
      With grdItemProveedor
         ebrItemProveedor.Groups(0).Text = "Ítems del Proveedor"
         .ContextMenu = mnuItemProveedor

         .RootTable.Columns("ItemProveedorId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("ProveedorId").Visible = False

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 80
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Ítem"
         .RootTable.Columns("ItemDes").Width = 150
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 70
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioUPC").Caption = "UPC"
         .RootTable.Columns("PrecioUPC").FormatString = DecimalMask()
         .RootTable.Columns("PrecioUPC").Width = 80
         .RootTable.Columns("PrecioUPC").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioUPC").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdItemProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdItemProveedor.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdItemProveedor.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdItemProveedor.GetRow.Cells(grdItemProveedor.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call ItemProveedorDataShow()
   End Sub

   Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
      Call ItemProveedorFormNew()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call ItemProveedorDataEdit()
   End Sub

   Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
      Call ItemProveedorDataDelete()
   End Sub

#End Region

   Private Sub frmProveedorEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moProveedor.ProveedorId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmProveedorEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moProveedor.Dispose()
      Call ClearMemory()
   End Sub

End Class
