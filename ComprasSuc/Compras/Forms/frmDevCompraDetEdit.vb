Public Class frmDevCompraDetEdit
   Inherits System.Windows.Forms.Form

   Private moDevCompraDet As clsDevCompraDet
   Private moItemLote As clsItemLote
   Private mqueItem As New Queue

   Private moDataTableLote As DataTable
   Private moDataTableSerie As DataTable

   Private moDataTableLoteDelete As DataTable
   Private mlngNotaId As Long
   Private mboolNewCloneDevCompraDet As Boolean

   Private mlngTipoItemId As Long
   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long
   Private mdecCantidadMin As Decimal
   Private mdecCantidadMax As Decimal
   Private mboolControlLote As Boolean
   Private mboolControlSerie As Boolean

   Private mdecPrecioPPP As Decimal
   Private mdecPrecioUPC As Decimal
   Private mdecSaldoItem As Decimal

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdItemLote As Janus.Windows.GridEX.GridEX
   Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents ExplorerBar1 As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMainSerie As Janus.Windows.GridEX.GridEX
   Friend WithEvents mnuMainSerie As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuItemSerieDelete As System.Windows.Forms.MenuItem
   Friend WithEvents txtCantidadDev As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents mnuItemSerieSep As System.Windows.Forms.MenuItem
   Friend WithEvents mnuItemSerieFind As System.Windows.Forms.MenuItem
   Friend WithEvents mnuItemSerieClear As System.Windows.Forms.MenuItem
   Private mlngID As Long

   Property ItemList() As Queue
      Get
         Return mqueItem
      End Get

      Set(ByVal Value As Queue)
         mqueItem = Value
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

   WriteOnly Property NewCloneDevVentaDet() As Boolean
      Set(ByVal Value As Boolean)
         mboolNewCloneDevCompraDet = Value
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

   Property DataObject() As clsDevCompraDet
      Get
         Return moDevCompraDet
      End Get

      Set(ByVal Value As clsDevCompraDet)
         moDevCompraDet = Value
      End Set
   End Property

   Property DataTableLote() As DataTable
      Get
         Return moDataTableLote
      End Get

      Set(ByVal Value As DataTable)
         moDataTableLote = Value
      End Set

   End Property

   Property DataTableSerie() As DataTable
      Get
         Return moDataTableSerie
      End Get

      Set(ByVal Value As DataTable)
         moDataTableSerie = Value
      End Set

   End Property

   Property DataTableLoteDelete() As DataTable
      Get
         Return moDataTableLoteDelete
      End Get

      Set(ByVal Value As DataTable)
         moDataTableLoteDelete = Value
      End Set

   End Property

   Property NotaId() As Long
      Get
         Return mlngNotaId
      End Get

      Set(ByVal Value As Long)
         mlngNotaId = Value
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
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents tabGeneral As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabItemLote As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtAlmacenId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtProveedorId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtDevCompraDetId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboMedida As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents chkItem As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboItem As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblImporte As System.Windows.Forms.Label
   Friend WithEvents txtPrecioOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblPrecio As System.Windows.Forms.Label
   Friend WithEvents txtCantidadOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents mnuItemLote As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuItemLoteShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuItemLoteEdit As System.Windows.Forms.MenuItem
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevCompraDetEdit))
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdItemLote = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl1 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMainSerie = New Janus.Windows.GridEX.GridEX
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
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.tabGeneral = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtCantidadDev = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.cboMedida = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.chkItem = New Janus.Windows.EditControls.UICheckBox
      Me.cboItem = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblImporte = New System.Windows.Forms.Label
      Me.txtPrecioOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblPrecio = New System.Windows.Forms.Label
      Me.txtCantidadOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtAlmacenId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtProveedorId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtDevCompraDetId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.tabItemLote = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
      Me.ExplorerBar1 = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.mnuItemLote = New System.Windows.Forms.ContextMenu
      Me.mnuItemLoteShow = New System.Windows.Forms.MenuItem
      Me.mnuItemLoteEdit = New System.Windows.Forms.MenuItem
      Me.mnuMainSerie = New System.Windows.Forms.ContextMenu
      Me.mnuItemSerieDelete = New System.Windows.Forms.MenuItem
      Me.mnuItemSerieSep = New System.Windows.Forms.MenuItem
      Me.mnuItemSerieFind = New System.Windows.Forms.MenuItem
      Me.mnuItemSerieClear = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdItemLote, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl1.SuspendLayout()
      CType(Me.grdMainSerie, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabMain.SuspendLayout()
      Me.tabGeneral.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.cboItem, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.tabItemLote.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      Me.UiTabPage1.SuspendLayout()
      CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdItemLote)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(420, 227)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdItemLote
      '
      Me.grdItemLote.AllowCardSizing = False
      Me.grdItemLote.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdItemLote.AlternatingColors = True
      Me.grdItemLote.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdItemLote.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdItemLote.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdItemLote.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdItemLote.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdItemLote.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdItemLote.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdItemLote.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdItemLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdItemLote.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdItemLote.GroupByBoxVisible = False
      Me.grdItemLote.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdItemLote.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdItemLote.Location = New System.Drawing.Point(0, 0)
      Me.grdItemLote.Name = "grdItemLote"
      Me.grdItemLote.RecordNavigator = True
      Me.grdItemLote.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdItemLote.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdItemLote.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdItemLote.Size = New System.Drawing.Size(420, 227)
      Me.grdItemLote.TabIndex = 3
      Me.grdItemLote.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdItemLote.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemLote.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemLote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl1
      '
      Me.ExplorerBarContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl1.Controls.Add(Me.grdMainSerie)
      Me.ExplorerBarContainerControl1.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl1.Name = "ExplorerBarContainerControl1"
      Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(424, 229)
      Me.ExplorerBarContainerControl1.TabIndex = 1
      '
      'grdMainSerie
      '
      Me.grdMainSerie.AllowCardSizing = False
      Me.grdMainSerie.AlternatingColors = True
      Me.grdMainSerie.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMainSerie.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdMainSerie.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdMainSerie.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdMainSerie.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdMainSerie.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdMainSerie.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdMainSerie.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdMainSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdMainSerie.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdMainSerie.GroupByBoxVisible = False
      Me.grdMainSerie.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdMainSerie.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdMainSerie.Location = New System.Drawing.Point(0, 0)
      Me.grdMainSerie.Name = "grdMainSerie"
      Me.grdMainSerie.RecordNavigator = True
      Me.grdMainSerie.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdMainSerie.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdMainSerie.Size = New System.Drawing.Size(424, 229)
      Me.grdMainSerie.TabIndex = 5
      Me.grdMainSerie.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMainSerie.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMainSerie.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMainSerie.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.bcgMain.Controls.Add(Me.tabMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 306)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(8, 8)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(448, 292)
      Me.tabMain.TabIndex = 0
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabGeneral, Me.tabItemLote, Me.UiTabPage1})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabGeneral
      '
      Me.tabGeneral.Controls.Add(Me.UiGroupBox1)
      Me.tabGeneral.Controls.Add(Me.grpMain)
      Me.tabGeneral.Key = "General"
      Me.tabGeneral.Location = New System.Drawing.Point(1, 21)
      Me.tabGeneral.Name = "tabGeneral"
      Me.tabGeneral.Size = New System.Drawing.Size(446, 270)
      Me.tabGeneral.TabStop = True
      Me.tabGeneral.Text = "General"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox1.Controls.Add(Me.txtCantidadDev)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.Controls.Add(Me.cboMedida)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.chkItem)
      Me.UiGroupBox1.Controls.Add(Me.cboItem)
      Me.UiGroupBox1.Controls.Add(Me.txtImporte)
      Me.UiGroupBox1.Controls.Add(Me.lblImporte)
      Me.UiGroupBox1.Controls.Add(Me.txtPrecioOrg)
      Me.UiGroupBox1.Controls.Add(Me.lblPrecio)
      Me.UiGroupBox1.Controls.Add(Me.txtCantidadOrg)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.Label12)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 96)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(432, 164)
      Me.UiGroupBox1.TabIndex = 5
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'txtCantidadDev
      '
      Me.txtCantidadDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCantidadDev.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCantidadDev.FormatString = "##,##0.000"
      Me.txtCantidadDev.Location = New System.Drawing.Point(116, 88)
      Me.txtCantidadDev.Name = "txtCantidadDev"
      Me.txtCantidadDev.Size = New System.Drawing.Size(124, 20)
      Me.txtCantidadDev.TabIndex = 10
      Me.txtCantidadDev.Text = "0,000"
      Me.txtCantidadDev.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCantidadDev.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCantidadDev.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 92)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 242
      Me.Label8.Text = "Cantidad"
      '
      'cboMedida
      '
      Me.cboMedida.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMedida.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.Location = New System.Drawing.Point(116, 40)
      Me.cboMedida.Name = "cboMedida"
      Me.cboMedida.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMedida.Size = New System.Drawing.Size(124, 20)
      Me.cboMedida.TabIndex = 8
      Me.cboMedida.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(8, 44)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 240
      Me.Label2.Text = "Medida"
      '
      'chkItem
      '
      Me.chkItem.BackColor = System.Drawing.Color.Transparent
      Me.chkItem.Checked = True
      Me.chkItem.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkItem.Location = New System.Drawing.Point(100, 20)
      Me.chkItem.Name = "chkItem"
      Me.chkItem.Size = New System.Drawing.Size(16, 16)
      Me.chkItem.TabIndex = 6
      Me.chkItem.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboItem
      '
      cboItem_DesignTimeLayout.LayoutString = resources.GetString("cboItem_DesignTimeLayout.LayoutString")
      Me.cboItem.DesignTimeLayout = cboItem_DesignTimeLayout
      Me.cboItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboItem.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboItem.Location = New System.Drawing.Point(116, 16)
      Me.cboItem.Name = "cboItem"
      Me.cboItem.SelectedIndex = -1
      Me.cboItem.SelectedItem = Nothing
      Me.cboItem.Size = New System.Drawing.Size(308, 20)
      Me.cboItem.TabIndex = 7
      Me.cboItem.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtImporte
      '
      Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtImporte.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporte.FormatString = "##,##0.000"
      Me.txtImporte.Location = New System.Drawing.Point(116, 136)
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.Size = New System.Drawing.Size(124, 20)
      Me.txtImporte.TabIndex = 12
      Me.txtImporte.Text = "0,000"
      Me.txtImporte.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporte.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporte.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblImporte
      '
      Me.lblImporte.BackColor = System.Drawing.Color.Transparent
      Me.lblImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblImporte.Location = New System.Drawing.Point(8, 140)
      Me.lblImporte.Name = "lblImporte"
      Me.lblImporte.Size = New System.Drawing.Size(104, 16)
      Me.lblImporte.TabIndex = 233
      Me.lblImporte.Text = "Importe"
      '
      'txtPrecioOrg
      '
      Me.txtPrecioOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPrecioOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPrecioOrg.FormatString = "##,##0.000"
      Me.txtPrecioOrg.Location = New System.Drawing.Point(116, 112)
      Me.txtPrecioOrg.Name = "txtPrecioOrg"
      Me.txtPrecioOrg.Size = New System.Drawing.Size(124, 20)
      Me.txtPrecioOrg.TabIndex = 11
      Me.txtPrecioOrg.Text = "0,000"
      Me.txtPrecioOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPrecioOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPrecioOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblPrecio
      '
      Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
      Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPrecio.Location = New System.Drawing.Point(8, 116)
      Me.lblPrecio.Name = "lblPrecio"
      Me.lblPrecio.Size = New System.Drawing.Size(104, 16)
      Me.lblPrecio.TabIndex = 231
      Me.lblPrecio.Text = "Precio"
      '
      'txtCantidadOrg
      '
      Me.txtCantidadOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCantidadOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCantidadOrg.FormatString = "##,##0.000"
      Me.txtCantidadOrg.Location = New System.Drawing.Point(116, 64)
      Me.txtCantidadOrg.Name = "txtCantidadOrg"
      Me.txtCantidadOrg.Size = New System.Drawing.Size(124, 20)
      Me.txtCantidadOrg.TabIndex = 9
      Me.txtCantidadOrg.TabStop = False
      Me.txtCantidadOrg.Text = "0,000"
      Me.txtCantidadOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCantidadOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCantidadOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 68)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 230
      Me.Label6.Text = "Cantidad Compra"
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 20)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 173
      Me.Label12.Text = "Ítem"
      '
      'grpMain
      '
      Me.grpMain.BackColor = System.Drawing.Color.Transparent
      Me.grpMain.Controls.Add(Me.txtAlmacenId)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtProveedorId)
      Me.grpMain.Controls.Add(Me.txtDevCompraDetId)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Location = New System.Drawing.Point(8, 4)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(432, 92)
      Me.grpMain.TabIndex = 1
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'txtAlmacenId
      '
      Me.txtAlmacenId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAlmacenId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAlmacenId.Location = New System.Drawing.Point(116, 64)
      Me.txtAlmacenId.Name = "txtAlmacenId"
      Me.txtAlmacenId.ReadOnly = True
      Me.txtAlmacenId.Size = New System.Drawing.Size(308, 20)
      Me.txtAlmacenId.TabIndex = 4
      Me.txtAlmacenId.TabStop = False
      Me.txtAlmacenId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAlmacenId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 68)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 173
      Me.Label1.Text = "Almacen"
      '
      'txtProveedorId
      '
      Me.txtProveedorId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProveedorId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtProveedorId.Location = New System.Drawing.Point(116, 40)
      Me.txtProveedorId.Name = "txtProveedorId"
      Me.txtProveedorId.ReadOnly = True
      Me.txtProveedorId.Size = New System.Drawing.Size(308, 20)
      Me.txtProveedorId.TabIndex = 3
      Me.txtProveedorId.TabStop = False
      Me.txtProveedorId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtProveedorId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtDevCompraDetId
      '
      Me.txtDevCompraDetId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDevCompraDetId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDevCompraDetId.Location = New System.Drawing.Point(116, 16)
      Me.txtDevCompraDetId.Name = "txtDevCompraDetId"
      Me.txtDevCompraDetId.ReadOnly = True
      Me.txtDevCompraDetId.Size = New System.Drawing.Size(124, 20)
      Me.txtDevCompraDetId.TabIndex = 2
      Me.txtDevCompraDetId.TabStop = False
      Me.txtDevCompraDetId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDevCompraDetId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 170
      Me.Label5.Text = "Proveedor"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 20)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 168
      Me.Label7.Text = "ID"
      '
      'tabItemLote
      '
      Me.tabItemLote.Controls.Add(Me.ebrMain)
      Me.tabItemLote.Key = "ItemLote"
      Me.tabItemLote.Location = New System.Drawing.Point(1, 21)
      Me.tabItemLote.Name = "tabItemLote"
      Me.tabItemLote.Size = New System.Drawing.Size(446, 270)
      Me.tabItemLote.TabStop = True
      Me.tabItemLote.Text = "Lotes"
      Me.tabItemLote.Visible = False
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 228
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 4)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(436, 260)
      Me.ebrMain.TabIndex = 3
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiTabPage1
      '
      Me.UiTabPage1.Controls.Add(Me.ExplorerBar1)
      Me.UiTabPage1.Key = "ItemSerie"
      Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
      Me.UiTabPage1.Name = "UiTabPage1"
      Me.UiTabPage1.Size = New System.Drawing.Size(446, 270)
      Me.UiTabPage1.TabStop = True
      Me.UiTabPage1.Text = "Series"
      '
      'ExplorerBar1
      '
      Me.ExplorerBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBar1.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ExplorerBar1.Controls.Add(Me.ExplorerBarContainerControl1)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl1
      ExplorerBarGroup2.ContainerHeight = 230
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ExplorerBar1.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ExplorerBar1.GroupSeparation = 4
      Me.ExplorerBar1.Location = New System.Drawing.Point(3, 3)
      Me.ExplorerBar1.Name = "ExplorerBar1"
      Me.ExplorerBar1.Size = New System.Drawing.Size(440, 262)
      Me.ExplorerBar1.TabIndex = 167
      Me.ExplorerBar1.Text = "ExplorerBar2"
      Me.ExplorerBar1.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ExplorerBar1.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar1.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar1.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'mnuItemLote
      '
      Me.mnuItemLote.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuItemLoteShow, Me.mnuItemLoteEdit})
      '
      'mnuItemLoteShow
      '
      Me.mnuItemLoteShow.Index = 0
      Me.mnuItemLoteShow.Text = "Consultar"
      '
      'mnuItemLoteEdit
      '
      Me.mnuItemLoteEdit.Index = 1
      Me.mnuItemLoteEdit.Text = "Editar"
      '
      'mnuMainSerie
      '
      Me.mnuMainSerie.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuItemSerieDelete, Me.mnuItemSerieSep, Me.mnuItemSerieFind, Me.mnuItemSerieClear})
      '
      'mnuItemSerieDelete
      '
      Me.mnuItemSerieDelete.Index = 0
      Me.mnuItemSerieDelete.Text = "Eliminar"
      '
      'mnuItemSerieSep
      '
      Me.mnuItemSerieSep.Index = 1
      Me.mnuItemSerieSep.Text = "-"
      '
      'mnuItemSerieFind
      '
      Me.mnuItemSerieFind.Index = 2
      Me.mnuItemSerieFind.Text = "Buscar Serie"
      '
      'mnuItemSerieClear
      '
      Me.mnuItemSerieClear.Index = 3
      Me.mnuItemSerieClear.Text = "Limpiar Todos"
      '
      'frmDevCompraDetEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 334)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmDevCompraDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompraDet Edit"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdItemLote, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl1.ResumeLayout(False)
      CType(Me.grdMainSerie, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabMain.ResumeLayout(False)
      Me.tabGeneral.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.cboItem, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      Me.tabItemLote.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      Me.UiTabPage1.ResumeLayout(False)
      CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBar1.ResumeLayout(False)
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
               mlngID = moDevCompraDet.ItemId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDevCompraDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmDevCompraDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Devolución de Compra de Item"
         Else
            Call ItemReadOnly()
            Me.Text = "Editar Devolución de Compra de Item"
         End If
      Else
         Me.Text = "Nueva Devolución de Compra de Item"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moDevCompraDet
         txtDevCompraDetId.Text = ToStr(.DevCompraDetId)
         Call txtProveedorIdLoad(.ProveedorId)
         Call txtAlmacenIdLoad(.AlmacenId)
         cboItem.Value = ListFindItem(cboItem, .ItemId)
         cboItem.Tag = cboItem.Text
         Call ItemParametro(.ItemId)
         Call ItemSaldoParametro(.ItemId, .AlmacenId)
         Call cboMedidaLoad()


         cboMedida.SelectedIndex = ListFindItem(cboMedida, .MedidaId)
         txtCantidadOrg.Text = ToDecStr(.CantidadOrg)
         txtCantidadDev.Text = ToDecStr(.CantidadDev)
         txtPrecioOrg.Text = ToDecStr(.PrecioOrg)
         txtImporte.Text = ToDecStr(.Importe)

         txtImporte.Tag = txtImporte.Text

         If mboolControlLote Then
            tabMain.TabPages.Item("ItemLote").Enabled = True
            Call grdItemLoteLoad()
         Else
            tabMain.TabPages.Item("ItemLote").Enabled = False
         End If

         If mboolControlSerie Then
            tabMain.TabPages.Item("ItemSerie").Enabled = True
            Call grdMainSerieLoad()
         Else
            tabMain.TabPages.Item("ItemSerie").Enabled = False
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moDevCompraDet
         txtDevCompraDetId.Text = String.Empty
         Call txtProveedorIdLoad(.ProveedorId)
         Call txtAlmacenIdLoad(.AlmacenId)
         cboItem.Value = Nothing
         cboMedida.SelectedIndex = -1
         txtCantidadOrg.Text = "0"
         txtPrecioOrg.Text = "0"
         txtImporte.Text = "0"

         tabMain.TabPages.Item("ItemLote").Enabled = False
         tabMain.TabPages.Item("ItemSerie").Enabled = False
         tabMain.TabPages.Item("General").Selected = True
      End With
      mboolShow = False
   End Sub

   Private Sub ItemReadOnly()
      cboItem.ReadOnly = True
      cboMedida.ReadOnly = True
      txtCantidadOrg.ReadOnly = True
      txtImporte.ReadOnly = True
      txtPrecioOrg.ReadOnly = True
   End Sub

   Private Sub DataReadOnly()
      txtDevCompraDetId.ReadOnly = True
      txtProveedorId.ReadOnly = True
      txtAlmacenId.ReadOnly = True
      cboItem.ReadOnly = True
      cboMedida.ReadOnly = True
      txtCantidadOrg.ReadOnly = True
      txtCantidadDev.ReadOnly = True
      txtPrecioOrg.ReadOnly = True
      txtImporte.ReadOnly = True
      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moDevCompraDet
         If Not mboolAdding Then
            .DevCompraDetId = ToLong(txtDevCompraDetId.Text)
         End If

         .ItemId = ListPosition(cboItem)
         .MedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex)
         .CantidadOrg = ToDecimal(txtCantidadOrg.Text)
         .CantidadDev = ToDecimal(txtCantidadDev.Text)
         .PrecioOrg = ToDecimal(txtPrecioOrg.Text)
         .Importe = ToDecimal(txtImporte.Text)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboItem.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try

         If FormCheck() Then
            If LoteCheck() And serieCheck() Then
               Call DataMove()

               If CantidadMaxCheck() Then
                  If mboolAdding Then
                     DataSave = True
                  Else
                     DataSave = True
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim lngItemId As Long = ListPosition(cboItem)

      If lngItemId <> 0 Then

         ''If Not ToDecimal(ToDouble(txtImporte.Text) + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text)) > 0 Then
         ''   strMsg &= "Importe Bruto debe ser mayor  a cero" & vbCrLf
         ''   Throw New Exception(strMsg)
         ''   Return False
         ''End If

         If (mlngTipoItemId = 3) Then
            strMsg &= "Compra Inválida de Item Paquete" & vbCrLf
            Throw New Exception(strMsg)
            Return False
         End If

         For Each lngId As Long In mqueItem
            If lngId = lngItemId Then
               strMsg &= "Item Duplicado"
               Throw New Exception(strMsg)
               Return False
            End If
         Next

         If cboMedida.SelectedIndex = -1 Then
            strMsg &= "Revise la Medida"
            Throw New Exception(strMsg)
            Return False
         End If

         If ToDecimal(txtCantidadOrg.Text) <= 0 Then
            strMsg &= "Cantidad Inválida"
            Throw New Exception(strMsg)
            Return False
         End If

         If ToDecimal(txtPrecioOrg.Text) <= 0 Then
            strMsg &= "Precio Inválido"
         End If
      Else
         strMsg &= "Seleccione el Item" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function LoteCheck() As Boolean
      Dim strMsg As String = String.Empty

      If mboolControlLote Then
         If grdItemLoteTotal() <> ToDecimal(txtCantidadDev.Text) Then
            strMsg &= "Cantidad de Lote(s) Invalido(s)" & vbCrLf
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         LoteCheck = False
      Else
         LoteCheck = True
      End If
   End Function

   Private Function SerieCheck() As Boolean
      Dim strMsg As String = String.Empty


      If mboolControlSerie Then
         If ListPosition(cboMedida, cboMedida.SelectedIndex) <> mlngMedidaId Then
            If grdMainSerie.RowCount <> ToDecimal(txtCantidadDev.Text) * mdecMedidaCantEqui Then
               strMsg &= "Cantidad de Número de Serie(s) Invalido(s)" & vbCrLf
            End If
         Else
            If grdMainSerie.RowCount <> ToDecimal(txtCantidadDev.Text) Then
               strMsg &= "Cantidad de Número de Serie(s) Invalido(s)" & vbCrLf
            End If
         End If

         grdMainSerie.UpdateData()
         If dataTableSerieIsEnptyCells() Then
            strMsg &= "Algunos Codigos de Series son invalidos" & vbCrLf
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         SerieCheck = False
      Else
         SerieCheck = True
      End If
   End Function

   Private Function CantidadMaxCheck() As Boolean
      Dim strMsg As String = String.Empty

      If mdecCantidadMax > 0 Then
         If mlngMedidaId = moDevCompraDet.MedidaId Then
            If (mdecSaldoItem + moDevCompraDet.CantidadDev) > mdecCantidadMax Then
               strMsg = "¡Advertencia! Con esta Entrada, La Cantidad en Stock es Superior al Limite Maximo"
            End If
         Else
            If (mdecSaldoItem + (moDevCompraDet.CantidadDev * mdecMedidaCantEqui)) > mdecCantidadMax Then
               strMsg = "¡Advertencia! Con esta Entrada, La Cantidad en Stock es Superior al Limite Maximo"
            End If
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         If MessageBox.Show(strMsg & vbCrLf & "¿Desea Continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CantidadMaxCheck = True
         Else
            CantidadMaxCheck = False
         End If
      Else
         CantidadMaxCheck = True
      End If

   End Function

   Private Sub CheckFormShow()
      If Not (mboolEditing Or mboolAdding) Then
         Dim strMsgLote As String = String.Empty
         Dim strMsgSerie As String = String.Empty
         Dim strMsg As String = String.Empty

         If mboolControlLote Then
            If grdItemLoteTotal() <> ToDecimal(txtCantidadDev.Text) Then
               strMsgLote &= "Cantidad de Lote(s) Invalido(s)" & vbCrLf
            End If
         End If

         If (strMsgLote.Trim <> String.Empty) Then
            strMsgLote = "-- Lotes --" & vbCrLf & strMsgLote
         End If

         ''Validacion Series
         If mboolControlSerie Then
            If ListPosition(cboMedida, cboMedida.SelectedIndex) <> mlngMedidaId Then
               If grdMainSerie.RowCount <> ToDecimal(txtCantidadDev.Text) * mdecMedidaCantEqui Then
                  strMsgSerie &= "Cantidad de Número de Serie(s) Invalido(s)" & vbCrLf
               End If
            Else
               If grdMainSerie.RowCount <> ToDecimal(txtCantidadDev.Text) Then
                  strMsgSerie &= "Cantidad de Número de Serie(s) Invalido(s)" & vbCrLf
               End If
            End If

            grdMainSerie.UpdateData()
            If dataTableSerieIsEnptyCells() Then
               strMsgSerie &= "Algunos Codigos de Series son invalidos" & vbCrLf
            End If

         End If

         If strMsgSerie.Trim <> String.Empty Then
            strMsgSerie = " --SERIES--" & vbCrLf & strMsgSerie
         End If

         If (strMsgLote.Trim <> String.Empty) And (strMsgSerie.Trim <> String.Empty) Then
            strMsgLote &= vbCrLf
         End If

         strMsg = strMsgLote & strMsgSerie
         If (strMsg.Trim <> String.Empty) And (moDevCompraDet.DevCompraDetId > 0) Then
            MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      End If

   End Sub

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngTipoItemId = 0
         mlngTipoCosteoId = 0
         mlngMedidaId = 0
         mlngMedidaIdEqui = 0
         mdecMedidaCantEqui = 0
         mlngMonedaIdCos = 0
         mdecCantidadMin = 0
         mdecCantidadMax = 0
         mboolControlLote = False
         mboolControlSerie = False

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngTipoItemId = ToLong(.TipoItemId)
               mlngTipoCosteoId = ToLong(.TipoCosteoId)
               mlngMedidaId = ToLong(.MedidaId)
               mlngMedidaIdEqui = ToLong(.MedidaIdEqui)
               mdecMedidaCantEqui = ToDecimal(.MedidaCantEqui)
               mlngMonedaIdCos = ToLong(.MonedaIdCos)
               mdecCantidadMin = ToDecimal(.CantidadMin)
               mdecCantidadMax = ToDecimal(.CantidadMax)
               mboolControlLote = ToBoolean(.ControlLote)
               mboolControlSerie = ToBoolean(.ControlSerie)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub ItemSaldoParametro(ByVal lngItemId As Long, ByVal lngAlmacenId As Long)
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)

      Try
         mdecPrecioPPP = 0
         mdecPrecioUPC = 0
         mdecSaldoItem = 0

         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.All
            .WhereFilter = clsItemSaldo.WhereFilters.ItemId
            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Find Then
               mdecPrecioPPP = ToDecimal(.PrecioPPP)
               mdecPrecioUPC = ToDecimal(.PrecioUPC)
               mdecSaldoItem = ToDecimal(.Saldo)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)
      mboolChanged = False

      txtCantidadOrg.FormatString = DecimalMask()
      txtCantidadDev.FormatString = DecimalMask()
      txtPrecioOrg.FormatString = DecimalMask()
      txtImporte.FormatString = DecimalMask()

      If mboolAdding Then
         mnuItemLoteShow.Enabled = False
         mnuItemLoteEdit.Enabled = False

      ElseIf mboolEditing Then
         mnuItemLoteShow.Enabled = True
         mnuItemLoteEdit.Enabled = True

      Else
         mnuItemLoteShow.Enabled = True
         mnuItemLoteEdit.Enabled = False
      End If

      moItemLote = New clsItemLote(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboItemLoad()
   End Sub

   Private Sub cboItemLoad()
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem

      cboItem.DropDownList.Columns.Clear()

      Try
         With oItem
            .SelectFilter = clsItem.SelectFilters.ListBox
            .WhereFilter = clsItem.WhereFilters.TipoItemIdNot

            If clsAppInfo.ItemCodShow Then
               .OrderByFilter = clsItem.OrderByFilters.ItemCod
            Else
               .OrderByFilter = clsItem.OrderByFilters.ItemDes
            End If

            .EmpresaId = moDevCompraDet.EmpresaId
            .ItemId = moDevCompraDet.ItemId
            .EstadoId = 1
            .TipoItemId = 3 'No Inventario

            If .Open() Then
               With cboItem
                  .DropDownList.Columns.Add("ItemId")
                  .DropDownList.Columns("ItemId").DataMember = "ItemId"
                  .DropDownList.Columns("ItemId").Visible = False

                  .DropDownList.Columns.Add("ItemCod")
                  .DropDownList.Columns("ItemCod").Caption = "Código"
                  .DropDownList.Columns("ItemCod").DataMember = "ItemCod"
                  .DropDownList.Columns("ItemCod").Width = 100

                  .DropDownList.Columns.Add("ItemDes")
                  .DropDownList.Columns("ItemDes").Caption = "Descripción"
                  .DropDownList.Columns("ItemDes").DataMember = "ItemDes"
                  .DropDownList.Columns("ItemDes").Width = 205

                  .DataMember = oItem.TableName
                  .DataSource = oItem.DataSet

                  If clsAppInfo.ItemCodShow Then
                     .ValueMember = "ItemId"
                     .DisplayMember = "ItemCod"
                     chkItem.Checked = False
                  Else
                     .ValueMember = "ItemId"
                     .DisplayMember = "ItemDes"
                     chkItem.Checked = True
                  End If
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()
         oListItem = Nothing

      End Try
   End Sub

   Private Sub txtProveedorIdLoad(ByVal lngProveedorId As Long)
      Dim oProveedor As New clsProveedor(clsAppInfo.ConnectString)

      Try
         With oProveedor
            .ProveedorId = lngProveedorId

            If .FindByPK Then
               txtProveedorId.Tag = .ProveedorId
               txtProveedorId.Text = ToStr(.ProveedorDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedor.Dispose()

      End Try
   End Sub

   Private Sub txtAlmacenIdLoad(ByVal lngAlmacenId As Long)
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)

      Try
         With oAlmacen
            .AlmacenId = lngAlmacenId

            If .FindByPK Then
               txtAlmacenId.Tag = .AlmacenId
               txtAlmacenId.Text = ToStr(.AlmacenDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()

      End Try
   End Sub

   Private Sub cboMedidaLoad()
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMedida.Items.Clear()

      Try
         With oMedida
            .SelectFilter = clsMedida.SelectFilters.ListBox
            .WhereFilter = clsMedida.WhereFilters.MedidaItem
            .OrderByFilter = clsMedida.OrderByFilters.MedidaDes
            .EmpresaId = moDevCompraDet.EmpresaId
            .MedidaId = mlngMedidaId
            .ConcurrencyId = mlngMedidaIdEqui

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.MedidaId, .MedidaDes)

                  cboMedida.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboItem.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F2 Then
            If mboolAdding Then
               ''Dim frm As New frmItemFind
               Dim frm As New frmItemFind

               Try
                  With frm
                     .EmpresaId = moDevCompraDet.EmpresaId
                     .ShowDialog()

                     If .Changed Then
                        cboItem.Value = Nothing
                        cboItem.Tag = Nothing
                        cboItem.Value = ListFindItem(cboItem, ToLong(frm.ID))
                     End If

                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               End Try

            End If

         ElseIf e.KeyCode = Keys.F3 Then
            If mboolAdding Then
               Dim frm As New frmItemEdit
               Dim oItem As New clsItem(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oItem.EmpresaId = moDevCompraDet.EmpresaId

                     .DataObject = oItem
                     .ShowDialog()

                     If .Changed Then
                        Call cboItemLoad()
                        cboItem.Value = ListFindItem(cboItem, ToLong(frm.ID))
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oItem.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboItem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItem.LostFocus
      If cboItem.Tag <> cboItem.Text Then
         cboItem.Tag = cboItem.Text

         Dim lngItemId As Long = ListPosition(cboItem)

         If lngItemId <> 0 Then
            Call ItemParametro(lngItemId)
            Call ItemSaldoParametro(lngItemId, moDevCompraDet.AlmacenId)
            Call cboMedidaLoad()
            cboMedida.Tag = ""
            cboMedida.SelectedIndex = ListFindItem(cboMedida, mlngMedidaId)
            txtImporte.Text = ToDecStr(ToDecimal(txtCantidadOrg.Text) * ToDecimal(txtPrecioOrg.Text))

            moDataTableLote.Clear()
            If mboolControlLote Then
               tabMain.TabPages.Item("ItemLote").Enabled = True
               Call grdItemLoteLoad()
            Else
               tabMain.TabPages.Item("ItemLote").Enabled = False
            End If

            moDataTableSerie.Clear()
            If mboolControlSerie Then
               tabMain.TabPages.Item("ItemSerie").Enabled = True
               Call grdMainSerieLoad()
            Else
               tabMain.TabPages.Item("ItemSerie").Enabled = False
            End If

         Else
            cboMedida.Items.Clear()
            cboMedida.Text = ""
            tabMain.TabPages.Item("ItemLote").Enabled = False
            tabMain.TabPages.Item("ItemSerie").Enabled = False
         End If
      End If
   End Sub

   Private Sub cboItem_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItem.ValueChanged
      cboItem.Tag = String.Empty
      cboMedida.Items.Clear()
      cboMedida.Text = ""

   End Sub

   Private Sub cboMedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedida.SelectedIndexChanged
      If cboMedida.Tag <> cboMedida.Text Then
         cboMedida.Tag = cboMedida.Text

         Dim decUPC As Decimal = ItemProveedorUPC(moDevCompraDet.ProveedorId, ListPosition(cboItem))

         If mlngMedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex) Then
            If moDevCompraDet.MonedaId = 1 Then
               If moDevCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecioOrg.Text = ToDecStr(decUPC)
               Else
                  txtPrecioOrg.Text = ToDecStr(decUPC * moDevCompraDet.TipoCambio)
               End If

            ElseIf moDevCompraDet.MonedaId = 2 Then
               If moDevCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecioOrg.Text = ToDecStr(decUPC)
               Else
                  txtPrecioOrg.Text = ToDecStr(decUPC / moDevCompraDet.TipoCambio)
               End If
            End If

         ElseIf mlngMedidaIdEqui = ListPosition(cboMedida, cboMedida.SelectedIndex) Then
            If moDevCompraDet.MonedaId = 1 Then
               If moDevCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecioOrg.Text = ToDecStr(decUPC * mdecMedidaCantEqui)
               Else
                  txtPrecioOrg.Text = ToDecStr((decUPC * mdecMedidaCantEqui) * moDevCompraDet.TipoCambio)
               End If

            ElseIf moDevCompraDet.MonedaId = 2 Then
               If moDevCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecioOrg.Text = ToDecStr(decUPC * mdecMedidaCantEqui)
               Else
                  txtPrecioOrg.Text = ToDecStr((decUPC * mdecMedidaCantEqui) / moDevCompraDet.TipoCambio)
               End If
            End If
         Else
            txtPrecioOrg.Text = "0"
         End If

         txtImporte.Text = ToDecStr(ToDecimal(txtCantidadOrg.Text) * ToDecimal(txtPrecioOrg.Text))
         ''Call MontoRecDesLoad()
      End If
   End Sub

   Private Function ItemProveedorUPC(ByVal lngProveedorId As Long, ByVal lngItemId As Long) As Decimal
      Dim oItemProveedor As New clsItemProveedor(clsAppInfo.ConnectString)

      Try
         With oItemProveedor
            .SelectFilter = clsItemProveedor.SelectFilters.All
            .WhereFilter = clsItemProveedor.WhereFilters.ItemId
            .EmpresaId = moDevCompraDet.EmpresaId
            .ProveedorId = lngProveedorId
            .ItemId = lngItemId

            If .Find Then
               ItemProveedorUPC = .PrecioUPC
            Else
               ItemProveedorUPC = 0
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemProveedor.Dispose()

      End Try
   End Function

   Private Sub chkItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItem.CheckedChanged
      If chkItem.Checked Then
         cboItem.DisplayMember = "ItemDes"
      Else
         cboItem.DisplayMember = "ItemCod"
      End If
   End Sub

   Private Sub txtCantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidadOrg.TextChanged
      ''If txtCantidadOrg.ContainsFocus Then
      ''   txtImporte.Text = ToDecStr(ToDecimal(txtCantidadOrg.Text) * ToDecimal(txtPrecioOrg.Text))
      ''   ''Call MontoRecDesLoad()
      ''End If

      txtImporte.Text = ToDecStr(ToDecimal(txtCantidadDev.Text) * ToDecimal(txtPrecioOrg.Text))

   End Sub

   Private Sub txtPrecioOrg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioOrg.TextChanged
      If txtPrecioOrg.ContainsFocus Then
         txtImporte.Text = ToDecStr(ToDecimal(txtCantidadOrg.Text) * ToDecimal(txtPrecioOrg.Text))
      End If
   End Sub

   Private Sub txtCantidadDev_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadDev.TextChanged
      ''If txtCantidadDev.ContainsFocus Then
      ''   If txtCantidadDev.Tag <> txtCantidadDev.Text Then
      ''      txtCantidadDev.Tag = txtCantidadDev.Text
      ''   End If
      ''End If

      txtImporte.Text = ToDecStr(ToDecimal(txtCantidadDev.Text) * ToDecimal(txtPrecioOrg.Text))
   End Sub

   Private Sub txtImporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
      If txtImporte.ContainsFocus Then
         txtPrecioOrg.Text = ToDecStr(ToDecimal(txtImporte.Text) / ToDivByCero(txtCantidadOrg.Text))
         ''Call MontoRecDesLoad()
      End If
   End Sub

   Private Sub txtCantidadDev_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadDev.LostFocus
      ''If Not mboolControlLote And mboolControlSerie Then
      ''   If isDataTableVacio() Then
      ''      moDataTableSerie.Clear()
      ''      grdMainSerie.Refetch()
      ''   End If
      ''   Call addRowsToTableSerie(ToLong(txtCantidadDev.Text), moDataTableSerie.Rows.Count, 0, String.Empty, ListPosition(cboItem))
      ''End If

      If mboolControlSerie Then
         If (mboolAdding Or mboolEditing) Then
            If isDataTableVacio() Then
               Call itemLoteTableRestore()
               moDataTableSerie.Clear()
               grdMainSerie.Refetch()
            Else
               delRowsToTableSerieByItem(ListPosition(cboItem), 0)
               grdMainSerie.Refetch()
            End If

            Call addRowsToTableSerie(ToLong(txtCantidadDev.Text), moDataTableSerie.Rows.Count, 0, String.Empty, _
                         ListPosition(cboItem))
         End If
      End If
   End Sub

#Region " ItemLote "

   Private Sub grdItemLoteLoad()
      Dim oRow As DataRow

      Try
         grdItemLote.DataSource = moDataTableLote.DefaultView
         grdItemLote.RetrieveStructure()
         Call grdMainInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function GetRowNew(ByVal oItemLote As clsItemLote) As DataRow

      Dim oRow As DataRow
      oRow = moDataTableLote.NewRow

      oRow("ItemLoteId") = oItemLote.ItemLoteId
      oRow("ItemId") = oItemLote.ItemId
      oRow("ItemLoteDes") = oItemLote.ItemLoteDes
      oRow("SaldoOrg") = oItemLote.SaldoOrg
      oRow("SaldoAct") = oItemLote.SaldoAct
      oRow("FechaVen") = oItemLote.FechaVen
      oRow("ItemLoteIdOrg") = oItemLote.ItemLoteIdOrg
      oRow("Estado") = "New"

      Return oRow
   End Function

   Private Sub RowNewEdit(ByRef oRow As DataRow, ByVal oItemLote As clsItemLote, ByVal strEstado As String)

      oRow("ItemLoteId") = oItemLote.ItemLoteId
      oRow("ItemId") = oItemLote.ItemId
      oRow("ItemLoteDes") = oItemLote.ItemLoteDes
      oRow("SaldoOrg") = oItemLote.SaldoOrg
      oRow("SaldoAct") = oItemLote.SaldoAct
      oRow("FechaVen") = oItemLote.FechaVen
      oRow("ItemLoteIdOrg") = oItemLote.ItemLoteIdOrg
      oRow("ItemLoteIdDev") = oItemLote.ItemLoteIdDev
      oRow("Estado") = strEstado
   End Sub

   Private Function GetRowLoteDelete(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTableLoteDelete.NewRow

      oRow("ItemLoteId") = oDataRow("ItemLoteId")
      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemLoteDes") = oDataRow("ItemLoteDes")
      oRow("SaldoOrg") = oDataRow("SaldoOrg")
      oRow("SaldoAct") = oDataRow("SaldoAct")
      oRow("FechaVen") = oDataRow("FechaVen")
      oRow("ItemLoteIdOrg") = oDataRow("ItemLoteIdOrg")
      oRow("Estado") = "Delete"
      Return oRow
   End Function

   Private Sub grdItemLoteDataShow()
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      'Dim frm As New frmItemLoteEdit
      Dim frm As New frmItemLoteEditDevCompra

      Try
         If grdItemLote.RowCount > 0 Then
            If ToStr(grdItemLote.GetValue("Estado")) = "Show" Then
               With oItemLote
                  .ItemLoteId = ToLong(grdItemLote.GetValue("ItemLoteId"))

                  If .FindByPK Then
                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oItemLote
                     frm.DataTable = moDataTableLote
                     frm.MedidaIdNota = moDevCompraDet.MedidaId
                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With

            ElseIf ToStr(grdItemLote.GetValue("Estado")) = "New" Then
               With frm
                  .NewRecord = False
                  .Editing = False

                  oItemLote.EmpresaId = moDevCompraDet.EmpresaId
                  oItemLote.GestionId = clsAppInfo.GestionId
                  oItemLote.ItemId = ToLong(grdItemLote.GetValue("ItemId"))
                  oItemLote.ItemLoteDes = ToStr(grdItemLote.GetValue("ItemLoteDes"))
                  oItemLote.SaldoOrg = ToDecimal(grdItemLote.GetValue("SaldoOrg"))
                  oItemLote.FechaVen = ToStr(grdItemLote.GetValue("FechaVen"))
                  oItemLote.ItemLoteIdOrg = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))
                  oItemLote.ItemLoteIdDev = ToLong(grdItemLote.GetValue("ItemLoteIdDev"))

                  .DataObject = oItemLote
                  .DataTable = moDataTableLote
                  .MedidaIdNota = moDevCompraDet.MedidaId
                  .ShowDialog()
                  frm.Dispose()
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Sub

   Private Sub grdItemLoteFormNew()
      Dim frm As New frmItemLoteEdit
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Try
         If mboolAdding Then
            Call DataMove()
            Call FormCheck()
         End If

         With frm
            .NewRecord = True
            .Editing = False

            oItemLote.EmpresaId = moDevCompraDet.EmpresaId
            oItemLote.ItemId = moDevCompraDet.ItemId
            oItemLote.MedidaId = moDevCompraDet.MedidaId
            oItemLote.SaldoOrg = ToDecimal(txtCantidadOrg.Text) - grdItemLoteTotal()
            oItemLote.FechaVen = moDevCompraDet.Fecha

            .DataObject = oItemLote
            frm.DataTable = moDataTableLote
            .MedidaIdNota = moDevCompraDet.MedidaId
            .ShowDialog()

            If .Changed Then
               moDataTableLote.Rows.Add(GetRowNew(frm.DataObject))
               Call addRowsToTableSerie(oItemLote.SaldoOrg, getCantidadRowByLote(oItemLote.ItemLoteDes), _
                                         oItemLote.ItemLoteIdOrg, oItemLote.ItemLoteDes, oItemLote.ItemId)
               Call grdItemLoteFindRow(frm.ID)
            End If

            frm.Dispose()
            mboolEditing = True
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Sub

   Private Sub grdItemLoteDataEdit()
      'Dim frm As New frmItemLoteEdit
      Dim frm As New frmItemLoteEditDevCompra
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Try
         If grdItemLote.RowCount > 0 Then
            If ToStr(grdItemLote.GetValue("Estado")) = "Show" Then
               With oItemLote
                  .ItemLoteId = ToLong(grdItemLote.GetValue("ItemLoteId"))
                  Dim lngItemLoteIdOrgAnt As Long = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))

                  If .FindByPK Then
                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oItemLote
                     frm.DataTable = moDataTableLote
                     frm.MedidaIdNota = moDevCompraDet.MedidaId
                     frm.ShowDialog()

                     If frm.Changed Then

                        Call RowNewEdit(moDataTableLote.Rows(grdItemLote.Row), frm.DataObject, "Edit")
                        If lngItemLoteIdOrgAnt <> oItemLote.ItemLoteIdOrg Then
                           Call delRowsToTableSerieByLote(lngItemLoteIdOrgAnt)
                        End If
                        Call addRowsToTableSerie(oItemLote.SaldoOrg, getCantidadRowByLote(oItemLote.ItemLoteIdOrg), _
                                                     oItemLote.ItemLoteIdOrg, oItemLote.ItemLoteDes, oItemLote.ItemId)

                     End If

                     frm.Dispose()
                     mboolEditing = True
                  End If
               End With

            ElseIf ToStr(grdItemLote.GetValue("Estado")) = "New" Then
               Dim lngItemLoteIdOrgAnt As Long = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))
               With frm
                  .NewRecord = False
                  .Editing = True

                  oItemLote.ItemLoteId = ToLong(grdItemLote.GetValue("ItemLoteId"))
                  oItemLote.EmpresaId = moDevCompraDet.EmpresaId
                  oItemLote.GestionId = clsAppInfo.GestionId
                  oItemLote.AlmacenId = moDevCompraDet.AlmacenId
                  oItemLote.ItemId = ToLong(grdItemLote.GetValue("ItemId"))
                  oItemLote.ItemLoteDes = ToStr(grdItemLote.GetValue("ItemLoteDes"))
                  oItemLote.SaldoOrg = ToDecimal(grdItemLote.GetValue("SaldoOrg"))
                  oItemLote.SaldoAct = ToDecimal(grdItemLote.GetValue("SaldoAct"))
                  oItemLote.FechaVen = ToDateDMY(grdItemLote.GetValue("FechaVen"))
                  oItemLote.ItemLoteIdOrg = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))
                  oItemLote.ItemLoteIdDev = ToLong(grdItemLote.GetValue("ItemLoteIdDev"))

                  .DataObject = oItemLote
                  .DataTable = moDataTableLote
                  .MedidaIdNota = moDevCompraDet.MedidaId
                  .ShowDialog()

                  If .Changed Then
                     Call RowNewEdit(moDataTableLote.Rows(grdItemLote.Row), frm.DataObject, "New")
                     If lngItemLoteIdOrgAnt <> oItemLote.ItemLoteIdOrg Then
                        Call delRowsToTableSerieByLote(lngItemLoteIdOrgAnt)
                     End If
                     Call addRowsToTableSerie(oItemLote.SaldoOrg, getCantidadRowByLote(oItemLote.ItemLoteIdOrg), _
                                              oItemLote.ItemLoteIdOrg, oItemLote.ItemLoteDes, oItemLote.ItemId)
                  End If

                  frm.Dispose()
                  mboolEditing = True
               End With

            ElseIf ToStr(grdItemLote.GetValue("Estado")) = "Edit" Then
               Dim lngItemLoteIdOrgAnt As Long = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))
               With frm
                  .NewRecord = False
                  .Editing = True

                  oItemLote.ItemLoteId = ToLong(grdItemLote.GetValue("ItemLoteId"))
                  oItemLote.EmpresaId = moDevCompraDet.EmpresaId
                  oItemLote.GestionId = clsAppInfo.GestionId
                  oItemLote.AlmacenId = moDevCompraDet.AlmacenId
                  oItemLote.ItemId = ToLong(grdItemLote.GetValue("ItemId"))
                  oItemLote.ItemLoteDes = ToStr(grdItemLote.GetValue("ItemLoteDes"))
                  oItemLote.SaldoOrg = ToDecimal(grdItemLote.GetValue("SaldoOrg"))
                  oItemLote.SaldoAct = ToDecimal(grdItemLote.GetValue("SaldoAct"))
                  oItemLote.FechaVen = ToDateDMY(grdItemLote.GetValue("FechaVen"))
                  oItemLote.ItemLoteIdOrg = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))
                  oItemLote.ItemLoteIdDev = ToLong(grdItemLote.GetValue("ItemLoteIdDev"))

                  .DataObject = oItemLote
                  .DataTable = moDataTableLote
                  .MedidaIdNota = moDevCompraDet.MedidaId
                  .ShowDialog()

                  If .Changed Then
                     Call RowNewEdit(moDataTableLote.Rows(grdItemLote.Row), frm.DataObject, "Edit")
                     If lngItemLoteIdOrgAnt <> oItemLote.ItemLoteIdOrg Then
                        Call delRowsToTableSerieByLote(lngItemLoteIdOrgAnt)
                     End If
                     Call addRowsToTableSerie(oItemLote.SaldoOrg, getCantidadRowByLote(oItemLote.ItemLoteIdOrg), _
                                              oItemLote.ItemLoteIdOrg, oItemLote.ItemLoteDes, oItemLote.ItemId)

                  End If

                  frm.Dispose()
                  mboolEditing = True
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Sub

   Private Sub grdItemLoteDataDelete()

      Try
         If grdItemLote.RowCount > 0 Then
            If ToStr(grdItemLote.GetValue("Estado")) = "New" Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call delRowsToTableSerieByLote(grdItemLote.GetValue("ItemLoteDes"))
                  moDataTableLote.Rows.RemoveAt(grdItemLote.Row)
               End If
            Else
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  'MessageBox.Show("Imposible Eliminar el Registro, ya tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  moDataTableLoteDelete.Rows.Add(GetRowLoteDelete(moDataTableLote.Rows.Item(grdItemLote.Row)))
                  moDataTableLote.Rows.RemoveAt(grdItemLote.Row)
               End If
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Function grdItemLoteTotal() As Decimal
      Dim oRow As DataRow
      Dim decSaldo As Decimal = 0

      For Each oRow In moDataTableLote.Rows
         decSaldo += oRow("SaldoOrg")
      Next

      Return ToDecimal(decSaldo)
   End Function

   Private Sub grdItemLoteFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdItemLote.RootTable.Columns("ItemId")

      grdItemLote.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub itemLoteTableRestore()
      For Each oRow As DataRow In moDataTableLote.Rows
         oRow("SaldoOrg") = 0
      Next
   End Sub

   ''Private Sub grdMainInit()
   ''   With grdItemLote
   ''      ebrMain.Groups(0).Text = "Lotes"
   ''      .ContextMenu = mnuItemLote

   ''      .RootTable.Columns("ItemLoteId").Visible = False

   ''      .RootTable.Columns("ItemId").Visible = False

   ''      .RootTable.Columns("ItemLoteDes").Caption = "Descripción"
   ''      .RootTable.Columns("ItemLoteDes").Width = 150
   ''      .RootTable.Columns("ItemLoteDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
   ''      .RootTable.Columns("ItemLoteDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   ''      .RootTable.Columns("SaldoOrg").Caption = "Cantidad"
   ''      .RootTable.Columns("SaldoOrg").FormatString = DecimalMask()
   ''      .RootTable.Columns("SaldoOrg").Width = 100
   ''      .RootTable.Columns("SaldoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
   ''      .RootTable.Columns("SaldoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   ''      .RootTable.Columns("SaldoAct").Visible = False

   ''      .RootTable.Columns("FechaVen").Caption = "Vencimiento"
   ''      .RootTable.Columns("FechaVen").FormatString = "dd/MM/yyyy"
   ''      .RootTable.Columns("FechaVen").Width = 100
   ''      .RootTable.Columns("FechaVen").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
   ''      .RootTable.Columns("FechaVen").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   ''      .RootTable.Columns("Estado").Visible = False

   ''      .RootTable.Columns("ItemLoteIdOrg").Visible = False
   ''   End With
   ''End Sub

   Private Sub grdMainInit()
      With grdItemLote
         ebrMain.Groups(0).Text = "Lotes"
         .ContextMenu = mnuItemLote

         .RootTable.Columns("ItemLoteId").Visible = False

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemLoteDes").Caption = "Descripción"
         .RootTable.Columns("ItemLoteDes").Width = 150
         .RootTable.Columns("ItemLoteDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemLoteDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mboolNewCloneDevCompraDet Then

            .RootTable.Columns("SaldoAct").Caption = "Cantidad"
            .RootTable.Columns("SaldoAct").FormatString = DecimalMask()
            .RootTable.Columns("SaldoAct").Width = 80
            .RootTable.Columns("SaldoAct").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoAct").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoOrg").Caption = "Cantidad Dev"
            .RootTable.Columns("SaldoOrg").FormatString = DecimalMask()
            .RootTable.Columns("SaldoOrg").Width = 80
            .RootTable.Columns("SaldoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         Else
            .RootTable.Columns("SaldoOrg").Caption = "Cantidad Dev"
            .RootTable.Columns("SaldoOrg").FormatString = DecimalMask()
            .RootTable.Columns("SaldoOrg").Width = 100
            .RootTable.Columns("SaldoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoAct").Visible = False
         End If

         .RootTable.Columns("FechaVen").Caption = "Vencimiento"
         .RootTable.Columns("FechaVen").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FechaVen").Width = 100
         .RootTable.Columns("FechaVen").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FechaVen").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Estado").Visible = False

         .RootTable.Columns("ItemLoteIdOrg").Visible = False

         .RootTable.Columns("ItemLoteIdDev").Visible = False
      End With
   End Sub

   Private Sub grdItemLote_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdItemLote.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdItemLote.RowCount > 0 Then
               mnuItemLoteShow.Enabled = True
               mnuItemLoteEdit.Enabled = True
            Else
               mnuItemLoteShow.Enabled = False
               mnuItemLoteEdit.Enabled = False
            End If
         Else
            mnuItemLoteShow.Enabled = True
            mnuItemLoteEdit.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdItemLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdItemLote.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdItemLote.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdItemLote.GetRow.Cells(grdItemLote.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdItemLote.RowCount > 0 Then
               mnuItemLoteShow.Enabled = True
               mnuItemLoteEdit.Enabled = True
            Else
               mnuItemLoteShow.Enabled = False
               mnuItemLoteEdit.Enabled = False
            End If
         Else
            mnuItemLoteShow.Enabled = True
            mnuItemLoteEdit.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuItemLoteShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLoteShow.Click
      Call grdItemLoteDataShow()
   End Sub

   Private Sub mnuItemLoteNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Call grdItemLoteFormNew()
      grdMainSerie.Refetch()
   End Sub

   Private Sub mnuItemLoteEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLoteEdit.Click
      Call grdItemLoteDataEdit()
      grdMainSerie.Refetch()
   End Sub

   Private Sub mnuItemLoteDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Call grdItemLoteDataDelete()
      grdMainSerie.Refetch()
   End Sub

#End Region

#Region "ItemNroSerie"

   Private Sub grdMainSerieLoad()
      Dim oRow As DataRow

      Try
         grdMainSerie.DataSource = moDataTableSerie.DefaultView
         grdMainSerie.RetrieveStructure()
         grdMainInitSerie()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub grdMainDeleteSerie()
      Try
         If grdMainSerie.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               If mboolControlLote Then
                  If ToLong(grdMainSerie.GetValue("ItemLoteId")) > 0 Then
                     Dim countSeriesLote As Long = getCantidadRowByLote(ToLong(grdMainSerie.GetValue("ItemLoteId")))
                     Dim oRow As DataRow = itemLoteRowFind(ToLong(grdMainSerie.GetValue("ItemLoteId")))
                     If oRow Is Nothing Then
                        Exit Sub
                     End If
                     If ToLong(oRow("SaldoOrg")) >= countSeriesLote Then
                        Call itemLoteRowEditOrDel(oRow)
                     End If
                  End If
               End If

               moDataTableSerie.Rows.RemoveAt(grdMainSerie.Row)
               Call addRowsToTableSerieByItem(ToLong(txtCantidadDev.Text), moDataTableSerie.Rows.Count, 0, String.Empty, _
                         ListPosition(cboItem))
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub grdMainSerieFindNroSerie(ByVal boolSelectOne As Boolean)
      Dim frm As New frmItemNroSerieFind

      Try
         If grdMainSerie.RowCount > 0 Then
            If (ToLong(grdMainSerie.GetValue("ItemId")) > 0) Then
               If boolSelectOne Then
                  If mboolControlLote And (ToLong(grdMainSerie.GetValue("ItemLoteId")) = 0) Then
                     MessageBox.Show("Item sin Lote", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     Exit Sub
                  End If

                  With frm
                     .EmpresaId = moDevCompraDet.EmpresaId
                     .GestionId = moDevCompraDet.GestionId
                     .AlmacenId = moDevCompraDet.AlmacenId
                     .NotaId = mlngNotaId
                     .DocumentoDetId = moDevCompraDet.DevCompraDetId
                     .ItemId = moDevCompraDet.ItemId

                     .ItemId = ToLong(grdMainSerie.GetValue("ItemId"))
                     .ItemLoteId = ToLong(grdMainSerie.GetValue("ItemLoteId"))

                     .SelecCheck = False

                     .TipoFind = frmItemNroSerieFind.FIND_DEV_ENTRADA
                     .ShowDialog()

                     If .Changed Then
                        Call CargarItemNroSerie(frm.ID, grdMainSerie.Row)
                        grdMainSerie.Refetch()
                     End If

                     frm.Dispose()
                  End With

               Else
                  If mboolControlLote And (ToLong(grdMainSerie.GetValue("ItemLoteId")) = 0) Then
                     MessageBox.Show("Se asignaran las series con Lotes definidos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If

                  With frm
                     .EmpresaId = moDevCompraDet.EmpresaId
                     .GestionId = moDevCompraDet.GestionId
                     .AlmacenId = moDevCompraDet.AlmacenId
                     .NotaId = mlngNotaId
                     .DocumentoDetId = moDevCompraDet.DevCompraDetId
                     .ItemId = moDevCompraDet.ItemId

                     .ItemId = ToLong(grdMainSerie.GetValue("ItemId"))
                     ''.ItemLoteId = ToLong(grdMainSerie.GetValue("ItemLoteId"))

                     .SelecCheck = True
                     .TipoFind = frmItemNroSerieFind.FIND_DEV_ENTRADA
                     .ShowDialog()

                     If .Changed Then
                        Call CargarItemNroSeriesAll(frm.NroSeries)
                        grdMainSerie.Refetch()
                     End If

                     frm.Dispose()
                  End With
               End If
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub grdMainSerieClearNroSerie(ByVal lngItemId As Long)
      Try
         If grdMainSerie.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere limpiar las series del Item?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               For Each oRow As DataRow In moDataTableSerie.Rows
                  ''If ToLong(oRow("ItemId")) = lngItemId Then
                  oRow("ItemNroSerieId") = 0
                  oRow("ItemNroSerieCod") = String.Empty
                  oRow("ItemNroSerieCodTag") = String.Empty
                  oRow("Estado") = Constant.STATE_DAFAUL
                  ''End If
               Next
            End If
         End If
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
      End Try
   End Sub

   'Metodo que elimina todas las series del datatable dependiendo de la cantidad del lote
   Private Sub delRowsToTableSerieByLote(ByVal lngItemLoteId As Long)
      Dim oRow As DataRow
      Dim index As Integer = 0

      While index < moDataTableSerie.Rows.Count
         oRow = moDataTableSerie.Rows(index)
         If oRow("ItemLoteId") = lngItemLoteId Then
            moDataTableSerie.Rows.RemoveAt(index)
         Else
            index += 1
         End If
      End While
   End Sub

   Private Sub delRowsToTableSerieByItem(ByVal lngItemId As Long, ByVal lngItemLoteId As Long)
      Dim oRow As DataRow
      Dim index As Integer = 0

      While index < moDataTableSerie.Rows.Count
         oRow = moDataTableSerie.Rows(index)
         If (oRow("ItemId") = lngItemId) And (oRow("ItemLoteId") = lngItemLoteId) And (ToStr(oRow("ItemNroSerieCod")) = String.Empty) Then
            moDataTableSerie.Rows.RemoveAt(index)
         Else
            index += 1
         End If
      End While
   End Sub

   'Metodo que agrega series al datable cuando solo maneja series y no lotes
   Private Sub addRowsToTableSerie(ByVal lngCantidad As Long, ByVal lngCountLimit As Long, ByVal lngItemLoteId As Long, _
                                   ByVal strItemLoteDes As String, ByVal lngItemId As Long)

      Dim index As Integer = 0
      Dim oRow As DataRow

      If ListPosition(cboMedida, cboMedida.SelectedIndex) <> mlngMedidaId Then
         lngCantidad *= mdecMedidaCantEqui
      End If
      Dim intDiferencia As Integer = lngCantidad - lngCountLimit

      If intDiferencia > 0 Then
         For Each oRow In moDataTableSerie.Rows
            If index < intDiferencia Then
               If ToLong(oRow("ItemLoteId")) = 0 And oRow("Estado") = Constant.STATE_DAFAUL Then
                  oRow("ItemLoteId") = lngItemLoteId
                  oRow("ItemLoteDes") = strItemLoteDes
                  index += 1
               End If
            End If
         Next

         For index = index To intDiferencia - 1
            oRow = moDataTableSerie.NewRow
            oRow("ItemLoteId") = lngItemLoteId
            oRow("ItemLoteDes") = strItemLoteDes
            oRow("ItemNroSerieId") = 0
            oRow("ItemNroSerieCod") = String.Empty
            oRow("ItemNroSerieCodTag") = String.Empty
            oRow("ItemId") = lngItemId
            oRow("Estado") = Constant.STATE_DAFAUL
            moDataTableSerie.Rows.Add(oRow)
         Next

      End If
   End Sub

   Private Sub addRowsToTableSerieByItem(ByVal lngCantidad As Long, ByVal lngCountLimit As Long, ByVal lngItemLoteId As Long, _
                                ByVal strItemLoteDes As String, ByVal lngItemId As Long)

      Dim index As Integer = 0
      Dim oRow As DataRow

      If ListPosition(cboMedida, cboMedida.SelectedIndex) <> mlngMedidaId Then
         lngCantidad *= mdecMedidaCantEqui
      End If
      Dim intDiferencia As Integer = lngCantidad - lngCountLimit

      If intDiferencia > 0 Then
         For index = index To intDiferencia - 1
            oRow = moDataTableSerie.NewRow
            oRow("ItemLoteId") = lngItemLoteId
            oRow("ItemLoteDes") = strItemLoteDes
            oRow("ItemNroSerieId") = 0
            oRow("ItemNroSerieCod") = String.Empty
            oRow("ItemNroSerieCodTag") = String.Empty
            oRow("ItemId") = lngItemId
            oRow("Estado") = Constant.STATE_DAFAUL
            moDataTableSerie.Rows.Add(oRow)
         Next

      End If
   End Sub

   'Metodo que busca un registro de itemNroSerie en la nota de entrada
   Private Function serieFind(ByVal lngItemId As Long, ByVal strSerieDes As String) As clsItemNroSerie
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)

      Try

         With oItemNroSerie
            .SelectFilter = clsItemNroSerie.SelectFilters.All
            .WhereFilter = clsItemNroSerie.WhereFilters.ItemSerie_DevEnt
            .EmpresaId = moDevCompraDet.EmpresaId
            .GestionId = moDevCompraDet.GestionId
            .NotaIdEnt = mlngNotaId
            .AlmacenId = moDevCompraDet.AlmacenId
            .ItemId = lngItemId
            .ItemNroSerieCod = strSerieDes

            If Not .Find Then
               oItemNroSerie = Nothing
            End If
         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

         If Not oItemNroSerie Is Nothing Then
            oItemNroSerie.Dispose()
         End If

      End Try

      serieFind = oItemNroSerie
   End Function

   Private Function isSerieDuplicate(ByVal lngItemLoteId As Long, ByVal strItemSerieDes As String) As Boolean
      For Each oRow As DataRow In moDataTableSerie.Rows
         If ToLong(oRow("ItemLoteId")) = lngItemLoteId Then
            If ToStr(oRow("ItemNroSerieCod")) = strItemSerieDes Then
               Return True
            End If
         End If
      Next

      grdMainSerie.UpdateData()
   End Function

   Private Function itemLoteRowFind(ByVal lngItemLoteId As Long) As DataRow
      For Each oRow As DataRow In moDataTableLote.Rows
         If ToLong(oRow("ItemLoteIdOrg")) = lngItemLoteId Then
            Return oRow
         End If
      Next
      Return Nothing
   End Function

   Private Function serieValidate(ByVal lngItemId As Long, ByVal strSerieDes As String, ByRef oItemNroSerie As clsItemNroSerie) As Boolean
      If strSerieDes <> String.Empty Then
         oItemNroSerie = serieFind(lngItemId, strSerieDes)

         If Not oItemNroSerie Is Nothing Then
            If Not isSerieDuplicate(oItemNroSerie.ItemLoteId, strSerieDes) Then
               Return True
            Else
               MessageBox.Show("Serie Duplicado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Serie Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      End If
   End Function

   Private Function itemLoteRowInsertOrUpdate(ByVal lngItemId As Long, ByVal lngItemLoteIdSerieFind As Long, ByVal lngItemLoteId As Long, ByVal strSerieDes As String) As Boolean
      itemLoteRowInsertOrUpdate = True
      If mboolControlLote Then

         Dim oRow As DataRow = itemLoteRowFind(lngItemLoteIdSerieFind)
         'Adiciona un nuevo registro en el grid del lote
         If oRow Is Nothing Then
            If itemLoteRowAdd(lngItemLoteIdSerieFind) Then
               'Decrementa o elimina si ya no tiene saldo cuando se sobreescribe la serie
               If lngItemLoteId > 0 Then
                  oRow = itemLoteRowFind(lngItemLoteId)
                  Call itemLoteRowEditOrDel(oRow)
               End If
            Else
               itemLoteRowInsertOrUpdate = False
            End If
         Else
            If lngItemLoteId <> oRow("ItemLoteIdOrg") Then
               'Edita un registro en el grid del lote aumentando en 1 el saldoOrg
               If itemLoteRowEdit(oRow, lngItemLoteId) Then
                  If lngItemLoteId > 0 Then
                     'Decrementa o elimina si ya no tiene saldo cuando se sobreescribe la serie
                     oRow = itemLoteRowFind(lngItemLoteId)
                     Call itemLoteRowEditOrDel(oRow)
                  End If
               Else
                  itemLoteRowInsertOrUpdate = False
               End If
            End If
         End If

      End If

   End Function

   Private Function itemLoteRowEdit(ByVal oRow As DataRow, ByVal lngItemLoteId As Long) As Boolean
      oRow("SaldoOrg") += 1
      If ToStr(oRow("Estado")) = "Show" Then
         oRow("Estado") = "Edit"
      End If

      grdMainSerie.SetValue("ItemLoteDes", ToStr(oRow("ItemLoteDes")))
      itemLoteRowEdit = True
   End Function

   Private Function itemLoteRowEditOrDel(ByVal oRow As DataRow) As Boolean

      oRow("SaldoOrg") -= 1
      If ToStr(oRow("Estado")) = "Show" Then
         oRow("Estado") = "Edit"
      End If

      If ToLong(oRow("SaldoOrg")) <= 0 Then
         ''oRow.Delete()
         grdItemLote.Refetch()
      End If
      itemLoteRowEditOrDel = True
   End Function

   Private Function itemLoteRowAdd(ByVal lngItemLoteId As Long) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Try

         With oItemLote
            .ItemLoteId = lngItemLoteId

            If .FindByPK Then
               .AlmacenId = moDevCompraDet.AlmacenId
               .MedidaId = moDevCompraDet.MedidaId
               .ItemLoteIdOrg = .ItemLoteId
               .ItemLoteId = 0
               .SaldoOrg = 1
               .SaldoAct = 0
               .FechaVen = ToDateDMY(Now.Date)
               moDataTableLote.Rows.Add(GetRowNew(oItemLote))
               grdMainSerie.SetValue("ItemLoteDes", .ItemLoteDes)
               itemLoteRowAdd = True
            End If
         End With

      Catch ex As Exception

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function getCantidadRowByLote(ByVal lngItemLoteId As Long) As Integer
      grdMainSerie.UpdateData()

      For Each oRow As DataRow In moDataTableSerie.Rows
         If oRow("ItemLoteId") = lngItemLoteId Then
            getCantidadRowByLote += 1
         End If
      Next
   End Function

   Private Function dataTableSerieIsEnptyCells() As Boolean
      For Each oRow As DataRow In moDataTableSerie.Rows
         If ToStr(oRow("ItemNroSerieCod")) = String.Empty Then
            Return True
         End If
      Next
   End Function

   Private Function isDataTableVacio() As Boolean
      grdMainSerie.UpdateData()
      For Each oRow As DataRow In moDataTableSerie.Rows
         If ToStr(oRow("ItemNroSerieCod")) <> String.Empty Then
            Return False
         End If
      Next
      Return True
   End Function

   Private Function isDuplicateNroSerieId(ByVal lngItemNroSerieId As Long, Optional ByVal intRow As Long = -1) As Boolean
      isDuplicateNroSerieId = False
      Dim index As Long = 0

      For Each oRow As DataRow In moDataTableSerie.Rows
         If (index <> intRow) And (ToLong(oRow("ItemNroSerieId")) = lngItemNroSerieId) Then
            isDuplicateNroSerieId = True
            Exit For
         End If
         intRow += 1
      Next

   End Function

   Private Function grdTableSerieRowPosition(ByVal lngItemId As Long, ByRef lngItemLoteId As Long) As Integer
      Dim i As Integer = 0

      For Each oRow As DataRow In moDataTableSerie.Rows
         If (oRow("ItemId") = lngItemId) And (oRow("ItemLoteId") = lngItemLoteId) Then
            If (ToStr(oRow("ItemNroSerieCod")) = String.Empty) Then
               Return i
            End If
         End If
         i += 1
      Next

      Return -1
   End Function

   Private Sub CargarItemNroSerie(ByVal lngItemNroSerieId As Long, ByVal intRow As Long)
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim oRow As DataRow

      Try

         With oItemNroSerie
            .ItemNroSerieId = lngItemNroSerieId

            If Not isDuplicateNroSerieId(lngItemNroSerieId, intRow) Then
               If .FindByPK Then
                  oRow = moDataTableSerie.Rows(intRow)
                  oRow("ItemNroSerieId") = oItemNroSerie.ItemNroSerieId
                  oRow("ItemNroSerieCod") = oItemNroSerie.ItemNroSerieCod
                  oRow("ItemNroSerieCodTag") = oItemNroSerie.ItemNroSerieCod
                  oRow("ItemLoteId") = oItemNroSerie.ItemLoteId
                  oRow("Estado") = Constant.STATE_EDIT
               End If
            Else
               MessageBox.Show("Serie Duplicado", "Serie Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemNroSerie.Dispose()
      End Try
   End Sub

   Private Sub CargarItemNroSeriesAll(ByVal Lista As Queue)
      Dim oItemNroSerie As New clsItemNroSerie(clsAppInfo.ConnectString)
      Dim lngItemNroSerieId As Long
      Dim oRow As DataRow

      Try
         For Each lngItemNroSerieId In Lista

            With oItemNroSerie
               .ItemNroSerieId = lngItemNroSerieId

               If Not isDuplicateNroSerieId(lngItemNroSerieId) Then
                  If .FindByPK Then

                     Dim intRow As Integer = grdTableSerieRowPosition(.ItemId, .ItemLoteId)
                     If (intRow >= 0) And (intRow < moDataTableSerie.Rows.Count) Then
                        oRow = moDataTableSerie.Rows(intRow)
                        oRow("ItemNroSerieId") = oItemNroSerie.ItemNroSerieId
                        oRow("ItemNroSerieCod") = oItemNroSerie.ItemNroSerieCod
                        oRow("ItemNroSerieCodTag") = oItemNroSerie.ItemNroSerieCod
                        oRow("ItemLoteId") = oItemNroSerie.ItemLoteId
                        oRow("Estado") = Constant.STATE_EDIT
                     End If
                  End If
               Else
                  MessageBox.Show("Serie Duplicada", "Serie Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End With
         Next

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemNroSerie.Dispose()
      End Try
   End Sub

   Private Sub DataViewAll()
      grdMainSerie.RemoveFilters()
   End Sub

   Private Sub grdMainInitSerie()
      With grdMainSerie
         ebrMain.Groups(0).Text = "Detalle de Número de Series"
         .ContextMenu = mnuMainSerie

         .RootTable.Columns("ItemNroSerieId").Visible = False
         .RootTable.Columns("ItemLoteId").Visible = False
         .RootTable.Columns("ItemLoteIdSal").Visible = False

         .RootTable.Columns("ItemLoteDes").Visible = mboolControlLote
         .RootTable.Columns("ItemLoteDes").Caption = "Lote"
         .RootTable.Columns("ItemLoteDes").Width = 150
         .RootTable.Columns("ItemLoteDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemLoteDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ItemLoteDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("ItemLoteDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("ItemNroSerieCod").Caption = "Código Serie"
         .RootTable.Columns("ItemNroSerieCod").Width = 200
         .RootTable.Columns("ItemNroSerieCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemNroSerieCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemNroSerieCodTag").Visible = False
         .RootTable.Columns("TipoNotaIdSal").Visible = False
         .RootTable.Columns("NotaIdSal").Visible = False

         .RootTable.Columns("ItemId").Visible = False
         .RootTable.Columns("Estado").Visible = False
      End With
   End Sub

   Private Sub grdMainSerie_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMainSerie.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMainSerie.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMainSerie.GetRow.Cells(grdMainSerie.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdMainSerie.RowCount > 0 Then
               mnuItemSerieDelete.Enabled = True
               mnuItemSerieFind.Enabled = True
               mnuItemSerieClear.Enabled = True
            Else
               mnuItemSerieDelete.Enabled = False
               mnuItemSerieFind.Enabled = False
               mnuItemSerieClear.Enabled = False
            End If
         Else
            mnuItemSerieDelete.Enabled = False
            mnuItemSerieFind.Enabled = False
            mnuItemSerieClear.Enabled = False
         End If
      End If

      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F2 Then
            If (mboolAdding Or mboolEditing) Then
               Call grdMainSerieFindNroSerie(True)
            End If

         ElseIf e.KeyCode = Keys.F3 Then
            If (mboolAdding Or mboolEditing) Then
               Call grdMainSerieFindNroSerie(False)
            End If
         End If
      End If

   End Sub

   Private Sub grdItemSerie_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMainSerie.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdMainSerie.RowCount > 0 Then
               mnuItemSerieDelete.Enabled = True
               mnuItemSerieFind.Enabled = True
               mnuItemSerieClear.Enabled = True
            Else
               mnuItemSerieDelete.Enabled = False
               mnuItemSerieFind.Enabled = False
               mnuItemSerieClear.Enabled = False
            End If
         Else
            mnuItemSerieDelete.Enabled = False
            mnuItemSerieFind.Enabled = False
            mnuItemSerieClear.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuItemSerieFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemSerieFind.Click
      If (mboolAdding Or mboolEditing) Then
         Call grdMainSerieFindNroSerie(True)
      End If
   End Sub

   Private Sub mnuItemSerieClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemSerieClear.Click
      If mboolAdding Or mboolEditing Then
         Call grdMainSerieClearNroSerie(True)
         grdMainSerie.Refetch()
      End If
   End Sub

   Private Sub mnuItemSerieDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemSerieDelete.Click
      Call grdMainDeleteSerie()
      grdMainSerie.Refetch()
   End Sub

   Private Sub grdMainSerie_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdMainSerie.UpdatingCell
      If ToStr(grdMainSerie.RootTable.Columns(grdMainSerie.Col).DataMember) = "ItemNroSerieCod" Then
         If ToStr(e.Value) = String.Empty Then
            e.Value = ""
            grdMainSerie.SetValue("ItemNroSerieId", 0)
            grdMainSerie.SetValue("Estado", Constant.STATE_DAFAUL)

         ElseIf ToStr(e.Value) <> String.Empty Then
            Dim oItemNroSerie As clsItemNroSerie
            ''If serieValidate(ListPosition(cboItem), ToStr(e.Value), oItemNroSerie) Then
            If serieValidate(ToLong(grdMainSerie.GetValue("ItemId")), ToStr(e.Value), oItemNroSerie) Then
               If itemLoteRowInsertOrUpdate(ToLong(grdMainSerie.GetValue("ItemId")), oItemNroSerie.ItemLoteId, ToLong(grdMainSerie.GetValue("ItemLoteId")), ToStr(e.Value)) Then
                  grdMainSerie.SetValue("ItemNroSerieId", oItemNroSerie.ItemNroSerieId)
                  grdMainSerie.SetValue("ItemNroSerieCod", oItemNroSerie.ItemNroSerieCod)
                  grdMainSerie.SetValue("ItemNroSerieCodTag", oItemNroSerie.ItemNroSerieCod)
                  grdMainSerie.SetValue("ItemLoteId", oItemNroSerie.ItemLoteId)
                  grdMainSerie.SetValue("Estado", Constant.STATE_EDIT)
               End If
            Else
               e.Cancel = True
            End If
         End If
      End If
   End Sub

   Private Sub grdMainSerie_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grdMainSerie.EditingCell
      If ToStr(grdMainSerie.RootTable.Columns(grdMainSerie.Col).DataMember) = "ItemNroSerieCod" Then
         If (mboolAdding Or mboolEditing) Then
            If mboolControlLote And (ToLong(grdMainSerie.GetValue("ItemLoteId")) = 0) Then
               e.Cancel = True
            End If
         Else
            e.Cancel = True
         End If
      End If
   End Sub

#End Region

   Private Sub tabMainPanel(ByVal strKey As String, ByVal strAction As String)
      Select Case strKey
         Case "ItemLote"
            Select Case strAction
               Case "Show"
                  Call grdItemLoteDataShow()

               Case "New"
                  Call grdItemLoteFormNew()

               Case "Edit"
                  Call grdItemLoteDataEdit()

               Case "Delete"
                  Call grdItemLoteDataDelete()
            End Select
      End Select
   End Sub

   Private Sub frmDevCompraDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then

         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moDevCompraDet.ItemId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            If mnuItemLoteEdit.Enabled Then
               Call tabMainPanel(tabMain.SelectedTab.Key(), "Edit")
            End If

         End If
      End If
   End Sub

   Private Sub frmDevCompraDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moDevCompraDet.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub frmDevCompraDetEdit_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
      Call CheckFormShow()
   End Sub

End Class
