Public Class frmCompraDetEdit
   Inherits System.Windows.Forms.Form

   Private moCompraDet As clsCompraDet
    ' Private moItemLote As clsItemLote
   Private mqueItem As New Queue

   Private moDataTableLote As DataTable
    Private moDataTableSerie As DataTable

   Private moDataTableLoteDelete As DataTable

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

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   Property DataObject() As clsCompraDet
      Get
         Return moCompraDet
      End Get

      Set(ByVal Value As clsCompraDet)
         moCompraDet = Value
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
    Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
    Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
    Friend WithEvents grdItemLote As Janus.Windows.GridEX.GridEX
    Friend WithEvents grbDesRec As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeRec As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMontoRec As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeDes As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCompraDetDes As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents ExplorerBar1 As Janus.Windows.ExplorerBar.ExplorerBar
    Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
    Friend WithEvents grdMainSerie As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnGenerarSerie As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboItemLote As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemNroSerieCod As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mnuMainSerie As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuItemSerieDelete As System.Windows.Forms.MenuItem
    Friend WithEvents numAl As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents numDel As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents chkCodBarra As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Cuenta As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpCuenta As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboCentroCostoDetAct As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboCentroCostoAct As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboSucursalAct As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboPlanAddAct As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents chkPlan As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboPlanAct As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lblPlan As System.Windows.Forms.Label
    Friend WithEvents grdItemCosto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnImportar As Janus.Windows.EditControls.UIButton
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
   Friend WithEvents txtCompraDetId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboMedida As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents chkItem As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboItem As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblImporte As System.Windows.Forms.Label
   Friend WithEvents txtPrecioOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblPrecio As System.Windows.Forms.Label
   Friend WithEvents txtCantidad As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents mnuItemLote As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuItemLoteShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuItemLoteNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuItemLoteEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuItemLoteDelete As System.Windows.Forms.MenuItem
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cboItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ExplorerBarGroup4 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim cboPlanAct_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraDetEdit))
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
        Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
        Me.grdItemCosto = New Janus.Windows.GridEX.GridEX
        Me.chkCodBarra = New Janus.Windows.EditControls.UICheckBox
        Me.txtCompraDetDes = New Janus.Windows.GridEX.EditControls.EditBox
        Me.txtCompraDetId = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboMedida = New Janus.Windows.EditControls.UIComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkItem = New Janus.Windows.EditControls.UICheckBox
        Me.cboItem = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblImporte = New System.Windows.Forms.Label
        Me.txtPrecioOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblPrecio = New System.Windows.Forms.Label
        Me.txtCantidad = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.grbDesRec = New Janus.Windows.EditControls.UIGroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPorcentajeRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtMontoRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPorcentajeDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtMontoDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tabItemLote = New Janus.Windows.UI.Tab.UITabPage
        Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.ExplorerBar1 = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.numAl = New Janus.Windows.GridEX.EditControls.EditBox
        Me.numDel = New Janus.Windows.GridEX.EditControls.EditBox
        Me.btnLimpiar = New Janus.Windows.EditControls.UIButton
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnGenerarSerie = New Janus.Windows.EditControls.UIButton
        Me.cboItemLote = New Janus.Windows.EditControls.UIComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtItemNroSerieCod = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Cuenta = New Janus.Windows.UI.Tab.UITabPage
        Me.grpCuenta = New Janus.Windows.EditControls.UIGroupBox
        Me.cboCentroCostoDetAct = New Janus.Windows.EditControls.UIComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cboCentroCostoAct = New Janus.Windows.EditControls.UIComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cboSucursalAct = New Janus.Windows.EditControls.UIComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cboPlanAddAct = New Janus.Windows.EditControls.UIComboBox
        Me.chkPlan = New Janus.Windows.EditControls.UICheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cboPlanAct = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Me.lblPlan = New System.Windows.Forms.Label
        Me.mnuItemLote = New System.Windows.Forms.ContextMenu
        Me.mnuItemLoteShow = New System.Windows.Forms.MenuItem
        Me.mnuItemLoteNew = New System.Windows.Forms.MenuItem
        Me.mnuItemLoteEdit = New System.Windows.Forms.MenuItem
        Me.mnuItemLoteDelete = New System.Windows.Forms.MenuItem
        Me.mnuMainSerie = New System.Windows.Forms.ContextMenu
        Me.mnuItemSerieDelete = New System.Windows.Forms.MenuItem
        Me.btnImportar = New Janus.Windows.EditControls.UIButton
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
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.grdItemCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDesRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDesRec.SuspendLayout()
        Me.tabItemLote.SuspendLayout()
        CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ebrMain.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExplorerBar1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.Cuenta.SuspendLayout()
        CType(Me.grpCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCuenta.SuspendLayout()
        CType(Me.cboPlanAct, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(420, 335)
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
        Me.grdItemLote.Size = New System.Drawing.Size(420, 335)
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
        Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(424, 268)
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
        Me.grdMainSerie.Size = New System.Drawing.Size(424, 268)
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
        Me.bcgMain.Size = New System.Drawing.Size(462, 413)
        Me.bcgMain.TabIndex = 161
        Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'tabMain
        '
        Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Location = New System.Drawing.Point(8, 8)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(448, 400)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabGeneral, Me.tabItemLote, Me.UiTabPage1, Me.Cuenta})
        Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.grpMain)
        Me.tabGeneral.Controls.Add(Me.grbDesRec)
        Me.tabGeneral.Key = "General"
        Me.tabGeneral.Location = New System.Drawing.Point(1, 21)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Size = New System.Drawing.Size(446, 378)
        Me.tabGeneral.TabStop = True
        Me.tabGeneral.Text = "General"
        '
        'grpMain
        '
        Me.grpMain.BackColor = System.Drawing.Color.Transparent
        Me.grpMain.Controls.Add(Me.grdItemCosto)
        Me.grpMain.Controls.Add(Me.chkCodBarra)
        Me.grpMain.Controls.Add(Me.txtCompraDetDes)
        Me.grpMain.Controls.Add(Me.txtCompraDetId)
        Me.grpMain.Controls.Add(Me.Label11)
        Me.grpMain.Controls.Add(Me.Label7)
        Me.grpMain.Controls.Add(Me.cboMedida)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.chkItem)
        Me.grpMain.Controls.Add(Me.cboItem)
        Me.grpMain.Controls.Add(Me.txtImporte)
        Me.grpMain.Controls.Add(Me.lblImporte)
        Me.grpMain.Controls.Add(Me.txtPrecioOrg)
        Me.grpMain.Controls.Add(Me.lblPrecio)
        Me.grpMain.Controls.Add(Me.txtCantidad)
        Me.grpMain.Controls.Add(Me.Label6)
        Me.grpMain.Controls.Add(Me.Label12)
        Me.grpMain.Location = New System.Drawing.Point(8, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(432, 308)
        Me.grpMain.TabIndex = 1
        Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'grdItemCosto
        '
        Me.grdItemCosto.AllowCardSizing = False
        Me.grdItemCosto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdItemCosto.AlternatingColors = True
        Me.grdItemCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdItemCosto.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.grdItemCosto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdItemCosto.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdItemCosto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdItemCosto.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.grdItemCosto.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grdItemCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grdItemCosto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdItemCosto.GroupByBoxVisible = False
        Me.grdItemCosto.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
        Me.grdItemCosto.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdItemCosto.Location = New System.Drawing.Point(4, 200)
        Me.grdItemCosto.Name = "grdItemCosto"
        Me.grdItemCosto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItemCosto.SelectedInactiveFormatStyle.Blend = 0.0!
        Me.grdItemCosto.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.grdItemCosto.Size = New System.Drawing.Size(420, 100)
        Me.grdItemCosto.TabIndex = 13
        Me.grdItemCosto.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdItemCosto.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grdItemCosto.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grdItemCosto.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grdItemCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'chkCodBarra
        '
        Me.chkCodBarra.BackColor = System.Drawing.Color.Transparent
        Me.chkCodBarra.Location = New System.Drawing.Point(76, 44)
        Me.chkCodBarra.Name = "chkCodBarra"
        Me.chkCodBarra.Size = New System.Drawing.Size(16, 16)
        Me.chkCodBarra.TabIndex = 5
        Me.chkCodBarra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txtCompraDetDes
        '
        Me.txtCompraDetDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompraDetDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCompraDetDes.Location = New System.Drawing.Point(116, 160)
        Me.txtCompraDetDes.MaxLength = 255
        Me.txtCompraDetDes.Multiline = True
        Me.txtCompraDetDes.Name = "txtCompraDetDes"
        Me.txtCompraDetDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCompraDetDes.Size = New System.Drawing.Size(308, 32)
        Me.txtCompraDetDes.TabIndex = 12
        Me.txtCompraDetDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtCompraDetDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtCompraDetId
        '
        Me.txtCompraDetId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompraDetId.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCompraDetId.Location = New System.Drawing.Point(116, 16)
        Me.txtCompraDetId.Name = "txtCompraDetId"
        Me.txtCompraDetId.ReadOnly = True
        Me.txtCompraDetId.Size = New System.Drawing.Size(124, 20)
        Me.txtCompraDetId.TabIndex = 2
        Me.txtCompraDetId.TabStop = False
        Me.txtCompraDetId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtCompraDetId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 256
        Me.Label11.Text = "Descripción"
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
        'cboMedida
        '
        Me.cboMedida.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedida.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboMedida.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboMedida.Location = New System.Drawing.Point(116, 64)
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
        Me.Label2.Location = New System.Drawing.Point(8, 68)
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
        Me.chkItem.Location = New System.Drawing.Point(100, 44)
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
        Me.cboItem.Location = New System.Drawing.Point(116, 40)
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
        Me.txtImporte.TabIndex = 11
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
        Me.txtPrecioOrg.TabIndex = 10
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
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCantidad.FormatString = "##,##0.000"
        Me.txtCantidad.Location = New System.Drawing.Point(116, 88)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(124, 20)
        Me.txtCantidad.TabIndex = 9
        Me.txtCantidad.Text = "0,000"
        Me.txtCantidad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtCantidad.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtCantidad.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 230
        Me.Label6.Text = "Cantidad"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 173
        Me.Label12.Text = "Ítem"
        '
        'grbDesRec
        '
        Me.grbDesRec.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grbDesRec.Controls.Add(Me.Label8)
        Me.grbDesRec.Controls.Add(Me.txtPorcentajeRec)
        Me.grbDesRec.Controls.Add(Me.txtMontoRec)
        Me.grbDesRec.Controls.Add(Me.Label9)
        Me.grbDesRec.Controls.Add(Me.Label10)
        Me.grbDesRec.Controls.Add(Me.txtPorcentajeDes)
        Me.grbDesRec.Controls.Add(Me.txtMontoDes)
        Me.grbDesRec.Controls.Add(Me.Label13)
        Me.grbDesRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDesRec.Location = New System.Drawing.Point(7, 308)
        Me.grbDesRec.Name = "grbDesRec"
        Me.grbDesRec.Size = New System.Drawing.Size(432, 64)
        Me.grbDesRec.TabIndex = 13
        Me.grbDesRec.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(300, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 18)
        Me.Label8.TabIndex = 263
        Me.Label8.Text = "%"
        '
        'txtPorcentajeRec
        '
        Me.txtPorcentajeRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentajeRec.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPorcentajeRec.FormatString = "##,##0.000"
        Me.txtPorcentajeRec.Location = New System.Drawing.Point(324, 12)
        Me.txtPorcentajeRec.Name = "txtPorcentajeRec"
        Me.txtPorcentajeRec.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeRec.TabIndex = 15
        Me.txtPorcentajeRec.Text = "0,000"
        Me.txtPorcentajeRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtPorcentajeRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtPorcentajeRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtMontoRec
        '
        Me.txtMontoRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoRec.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoRec.FormatString = "##,##0.000"
        Me.txtMontoRec.Location = New System.Drawing.Point(116, 12)
        Me.txtMontoRec.Name = "txtMontoRec"
        Me.txtMontoRec.Size = New System.Drawing.Size(124, 20)
        Me.txtMontoRec.TabIndex = 14
        Me.txtMontoRec.Text = "0,000"
        Me.txtMontoRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 262
        Me.Label9.Text = "Recargo"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(300, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 259
        Me.Label10.Text = "%"
        '
        'txtPorcentajeDes
        '
        Me.txtPorcentajeDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentajeDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPorcentajeDes.FormatString = "##,##0.000"
        Me.txtPorcentajeDes.Location = New System.Drawing.Point(324, 36)
        Me.txtPorcentajeDes.Name = "txtPorcentajeDes"
        Me.txtPorcentajeDes.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeDes.TabIndex = 17
        Me.txtPorcentajeDes.Text = "0,000"
        Me.txtPorcentajeDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtPorcentajeDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtPorcentajeDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtMontoDes
        '
        Me.txtMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMontoDes.FormatString = "##,##0.000"
        Me.txtMontoDes.Location = New System.Drawing.Point(116, 36)
        Me.txtMontoDes.Name = "txtMontoDes"
        Me.txtMontoDes.Size = New System.Drawing.Size(124, 20)
        Me.txtMontoDes.TabIndex = 16
        Me.txtMontoDes.Text = "0,000"
        Me.txtMontoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtMontoDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtMontoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 16)
        Me.Label13.TabIndex = 171
        Me.Label13.Text = "Descuento"
        '
        'tabItemLote
        '
        Me.tabItemLote.Controls.Add(Me.ebrMain)
        Me.tabItemLote.Key = "ItemLote"
        Me.tabItemLote.Location = New System.Drawing.Point(1, 21)
        Me.tabItemLote.Name = "tabItemLote"
        Me.tabItemLote.Size = New System.Drawing.Size(446, 378)
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
        ExplorerBarGroup4.Container = True
        ExplorerBarGroup4.ContainerControl = Me.ExplorerBarContainerControl4
        ExplorerBarGroup4.ContainerHeight = 336
        ExplorerBarGroup4.Expandable = False
        ExplorerBarGroup4.Key = "Group1"
        Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup4})
        Me.ebrMain.GroupSeparation = 4
        Me.ebrMain.Location = New System.Drawing.Point(4, 4)
        Me.ebrMain.Name = "ebrMain"
        Me.ebrMain.Size = New System.Drawing.Size(436, 368)
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
        Me.UiTabPage1.Controls.Add(Me.UiGroupBox2)
        Me.UiTabPage1.Key = "ItemSerie"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(446, 378)
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
        ExplorerBarGroup3.Container = True
        ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl1
        ExplorerBarGroup3.ContainerHeight = 269
        ExplorerBarGroup3.Expandable = False
        ExplorerBarGroup3.Key = "Group1"
        Me.ExplorerBar1.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
        Me.ExplorerBar1.GroupSeparation = 4
        Me.ExplorerBar1.Location = New System.Drawing.Point(3, 72)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Size = New System.Drawing.Size(440, 301)
        Me.ExplorerBar1.TabIndex = 167
        Me.ExplorerBar1.Text = "ExplorerBar2"
        Me.ExplorerBar1.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
        Me.ExplorerBar1.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        Me.ExplorerBar1.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        Me.ExplorerBar1.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.UiGroupBox2.Controls.Add(Me.btnImportar)
        Me.UiGroupBox2.Controls.Add(Me.numAl)
        Me.UiGroupBox2.Controls.Add(Me.numDel)
        Me.UiGroupBox2.Controls.Add(Me.btnLimpiar)
        Me.UiGroupBox2.Controls.Add(Me.Label15)
        Me.UiGroupBox2.Controls.Add(Me.btnGenerarSerie)
        Me.UiGroupBox2.Controls.Add(Me.cboItemLote)
        Me.UiGroupBox2.Controls.Add(Me.Label4)
        Me.UiGroupBox2.Controls.Add(Me.Label3)
        Me.UiGroupBox2.Controls.Add(Me.txtItemNroSerieCod)
        Me.UiGroupBox2.Controls.Add(Me.Label14)
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 5)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(440, 63)
        Me.UiGroupBox2.TabIndex = 166
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'numAl
        '
        Me.numAl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAl.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.numAl.Location = New System.Drawing.Point(329, 12)
        Me.numAl.Name = "numAl"
        Me.numAl.Size = New System.Drawing.Size(60, 20)
        Me.numAl.TabIndex = 276
        Me.numAl.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.numAl.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'numDel
        '
        Me.numDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.numDel.Location = New System.Drawing.Point(237, 12)
        Me.numDel.Name = "numDel"
        Me.numDel.Size = New System.Drawing.Size(60, 20)
        Me.numDel.TabIndex = 275
        Me.numDel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.numDel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Icon = CType(resources.GetObject("btnLimpiar.Icon"), System.Drawing.Icon)
        Me.btnLimpiar.Location = New System.Drawing.Point(288, 35)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(71, 20)
        Me.btnLimpiar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnLimpiar.TabIndex = 274
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(303, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 16)
        Me.Label15.TabIndex = 273
        Me.Label15.Text = "Al"
        '
        'btnGenerarSerie
        '
        Me.btnGenerarSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarSerie.Icon = CType(resources.GetObject("btnGenerarSerie.Icon"), System.Drawing.Icon)
        Me.btnGenerarSerie.Location = New System.Drawing.Point(214, 35)
        Me.btnGenerarSerie.Name = "btnGenerarSerie"
        Me.btnGenerarSerie.Size = New System.Drawing.Size(71, 20)
        Me.btnGenerarSerie.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGenerarSerie.TabIndex = 271
        Me.btnGenerarSerie.Text = "Generar"
        Me.btnGenerarSerie.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'cboItemLote
        '
        Me.cboItemLote.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboItemLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemLote.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboItemLote.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboItemLote.Location = New System.Drawing.Point(84, 12)
        Me.cboItemLote.Name = "cboItemLote"
        Me.cboItemLote.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboItemLote.Size = New System.Drawing.Size(124, 20)
        Me.cboItemLote.TabIndex = 269
        Me.cboItemLote.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "Lote"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(211, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "Del"
        '
        'txtItemNroSerieCod
        '
        Me.txtItemNroSerieCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemNroSerieCod.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtItemNroSerieCod.Location = New System.Drawing.Point(84, 36)
        Me.txtItemNroSerieCod.Name = "txtItemNroSerieCod"
        Me.txtItemNroSerieCod.Size = New System.Drawing.Size(124, 20)
        Me.txtItemNroSerieCod.TabIndex = 5
        Me.txtItemNroSerieCod.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtItemNroSerieCod.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label14.Location = New System.Drawing.Point(8, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 16)
        Me.Label14.TabIndex = 266
        Me.Label14.Text = "Prefijo Serie"
        '
        'Cuenta
        '
        Me.Cuenta.Controls.Add(Me.grpCuenta)
        Me.Cuenta.Key = "Cuenta"
        Me.Cuenta.Location = New System.Drawing.Point(1, 21)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Size = New System.Drawing.Size(446, 378)
        Me.Cuenta.TabStop = True
        Me.Cuenta.Text = "Cuenta"
        '
        'grpCuenta
        '
        Me.grpCuenta.BackColor = System.Drawing.Color.Transparent
        Me.grpCuenta.Controls.Add(Me.cboCentroCostoDetAct)
        Me.grpCuenta.Controls.Add(Me.Label16)
        Me.grpCuenta.Controls.Add(Me.cboCentroCostoAct)
        Me.grpCuenta.Controls.Add(Me.Label17)
        Me.grpCuenta.Controls.Add(Me.cboSucursalAct)
        Me.grpCuenta.Controls.Add(Me.Label18)
        Me.grpCuenta.Controls.Add(Me.cboPlanAddAct)
        Me.grpCuenta.Controls.Add(Me.chkPlan)
        Me.grpCuenta.Controls.Add(Me.Label19)
        Me.grpCuenta.Controls.Add(Me.cboPlanAct)
        Me.grpCuenta.Controls.Add(Me.lblPlan)
        Me.grpCuenta.Location = New System.Drawing.Point(8, 8)
        Me.grpCuenta.Name = "grpCuenta"
        Me.grpCuenta.Size = New System.Drawing.Size(432, 168)
        Me.grpCuenta.TabIndex = 163
        Me.grpCuenta.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'cboCentroCostoDetAct
        '
        Me.cboCentroCostoDetAct.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoDetAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCostoDetAct.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoDetAct.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoDetAct.Location = New System.Drawing.Point(116, 100)
        Me.cboCentroCostoDetAct.Name = "cboCentroCostoDetAct"
        Me.cboCentroCostoDetAct.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboCentroCostoDetAct.Size = New System.Drawing.Size(308, 20)
        Me.cboCentroCostoDetAct.TabIndex = 226
        Me.cboCentroCostoDetAct.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 16)
        Me.Label16.TabIndex = 228
        Me.Label16.Text = "Actividad de C.C."
        '
        'cboCentroCostoAct
        '
        Me.cboCentroCostoAct.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCostoAct.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoAct.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoAct.Location = New System.Drawing.Point(116, 72)
        Me.cboCentroCostoAct.Name = "cboCentroCostoAct"
        Me.cboCentroCostoAct.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboCentroCostoAct.Size = New System.Drawing.Size(308, 20)
        Me.cboCentroCostoAct.TabIndex = 225
        Me.cboCentroCostoAct.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 16)
        Me.Label17.TabIndex = 227
        Me.Label17.Text = "Centro de Costo"
        '
        'cboSucursalAct
        '
        Me.cboSucursalAct.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboSucursalAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboSucursalAct.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboSucursalAct.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboSucursalAct.Location = New System.Drawing.Point(116, 128)
        Me.cboSucursalAct.Name = "cboSucursalAct"
        Me.cboSucursalAct.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboSucursalAct.Size = New System.Drawing.Size(308, 20)
        Me.cboSucursalAct.TabIndex = 224
        Me.cboSucursalAct.Visible = False
        Me.cboSucursalAct.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 132)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 223
        Me.Label18.Text = "Sucursal"
        Me.Label18.Visible = False
        '
        'cboPlanAddAct
        '
        Me.cboPlanAddAct.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanAddAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboPlanAddAct.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanAddAct.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanAddAct.Location = New System.Drawing.Point(116, 44)
        Me.cboPlanAddAct.Name = "cboPlanAddAct"
        Me.cboPlanAddAct.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboPlanAddAct.Size = New System.Drawing.Size(308, 20)
        Me.cboPlanAddAct.TabIndex = 215
        Me.cboPlanAddAct.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'chkPlan
        '
        Me.chkPlan.BackColor = System.Drawing.Color.Transparent
        Me.chkPlan.Checked = True
        Me.chkPlan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPlan.Location = New System.Drawing.Point(100, 16)
        Me.chkPlan.Name = "chkPlan"
        Me.chkPlan.Size = New System.Drawing.Size(16, 16)
        Me.chkPlan.TabIndex = 202
        Me.chkPlan.TabStop = False
        Me.chkPlan.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 16)
        Me.Label19.TabIndex = 216
        Me.Label19.Text = "Analítico Adicional"
        '
        'cboPlanAct
        '
        cboPlanAct_DesignTimeLayout.LayoutString = resources.GetString("cboPlanAct_DesignTimeLayout.LayoutString")
        Me.cboPlanAct.DesignTimeLayout = cboPlanAct_DesignTimeLayout
        Me.cboPlanAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboPlanAct.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboPlanAct.Location = New System.Drawing.Point(116, 16)
        Me.cboPlanAct.Name = "cboPlanAct"
        Me.cboPlanAct.SelectedIndex = -1
        Me.cboPlanAct.SelectedItem = Nothing
        Me.cboPlanAct.Size = New System.Drawing.Size(308, 20)
        Me.cboPlanAct.TabIndex = 6
        Me.cboPlanAct.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboPlanAct.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lblPlan
        '
        Me.lblPlan.BackColor = System.Drawing.Color.Transparent
        Me.lblPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlan.Location = New System.Drawing.Point(8, 20)
        Me.lblPlan.Name = "lblPlan"
        Me.lblPlan.Size = New System.Drawing.Size(88, 16)
        Me.lblPlan.TabIndex = 203
        Me.lblPlan.Text = "Cuenta "
        '
        'mnuItemLote
        '
        Me.mnuItemLote.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuItemLoteShow, Me.mnuItemLoteNew, Me.mnuItemLoteEdit, Me.mnuItemLoteDelete})
        '
        'mnuItemLoteShow
        '
        Me.mnuItemLoteShow.Index = 0
        Me.mnuItemLoteShow.Text = "Consultar"
        '
        'mnuItemLoteNew
        '
        Me.mnuItemLoteNew.Index = 1
        Me.mnuItemLoteNew.Text = "Nuevo"
        '
        'mnuItemLoteEdit
        '
        Me.mnuItemLoteEdit.Index = 2
        Me.mnuItemLoteEdit.Text = "Editar"
        '
        'mnuItemLoteDelete
        '
        Me.mnuItemLoteDelete.Index = 3
        Me.mnuItemLoteDelete.Text = "Eliminar"
        '
        'mnuMainSerie
        '
        Me.mnuMainSerie.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuItemSerieDelete})
        '
        'mnuItemSerieDelete
        '
        Me.mnuItemSerieDelete.Index = 0
        Me.mnuItemSerieDelete.Text = "Eliminar"
        '
        'btnImportar
        '
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.Icon = CType(resources.GetObject("btnImportar.Icon"), System.Drawing.Icon)
        Me.btnImportar.Location = New System.Drawing.Point(362, 35)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(71, 20)
        Me.btnImportar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnImportar.TabIndex = 278
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'frmCompraDetEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(462, 441)
        Me.Controls.Add(Me.bcgMain)
        Me.Controls.Add(Me.TopRebar1)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompraDetEdit"
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
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.grdItemCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDesRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDesRec.ResumeLayout(False)
        Me.grbDesRec.PerformLayout()
        Me.tabItemLote.ResumeLayout(False)
        CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ebrMain.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExplorerBar1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.Cuenta.ResumeLayout(False)
        CType(Me.grpCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCuenta.ResumeLayout(False)
        Me.grpCuenta.PerformLayout()
        CType(Me.cboPlanAct, System.ComponentModel.ISupportInitialize).EndInit()
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
               mlngID = moCompraDet.ItemId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompraDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompraDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Compra de Item"
         Else
            Call ItemReadOnly()
            Me.Text = "Editar Compra de Item"
         End If
      Else
         Me.Text = "Nueva Compra de Item"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCompraDet
         txtCompraDetId.Text = ToStr(.CompraDetId)
         Call txtProveedorIdLoad(.ProveedorId)
         Call txtAlmacenIdLoad(.AlmacenId)
         cboItem.Value = ListFindItem(cboItem, .ItemId)
         cboItem.Tag = cboItem.Text
         Call ItemParametro(.ItemId)
         Call ItemSaldoParametro(.ItemId, .AlmacenId)
         Call cboMedidaLoad()

         txtCompraDetDes.Text = .CompraDetDes
         cboMedida.SelectedIndex = ListFindItem(cboMedida, .MedidaId)
         txtCantidad.Text = ToDecStr(.Cantidad)
         txtPrecioOrg.Text = ToDecStr(.PrecioOrg)
         txtImporte.Text = ToDecStr(.Importe)
         txtMontoRec.Text = ToDecimal(.PrecioRec * .Cantidad)
         txtMontoDes.Text = ToDecimal(.PrecioDes * .Cantidad)
         txtPorcentajeRec.Text = ToDecimal(txtMontoRec.Text * 100 / ToDivByCero(.Importe))
         txtPorcentajeDes.Text = ToDecimal(txtMontoDes.Text * 100 / ToDivByCero(.Importe))

         txtImporte.Tag = txtImporte.Text
         txtMontoRec.Tag = txtMontoRec.Text
         txtMontoDes.Tag = txtMontoDes.Text
         txtPorcentajeRec.Tag = txtPorcentajeRec.Text
         txtPorcentajeDes.Tag = txtPorcentajeDes.Text

         cboPlanAct.Value = ListFindItem(cboPlanAct, .PlanIdAct)
         cboPlanAddAct.SelectedIndex = ListFindItem(cboPlanAddAct, .PlanAddIdAct)
         cboCentroCostoAct.SelectedIndex = ListFindItem(cboCentroCostoAct, .CentroCostoIdAct)
         cboCentroCostoDetAct.SelectedIndex = ListFindItem(cboCentroCostoDetAct, .CentroCostoDetIdAct)
         cboSucursalAct.SelectedIndex = ListFindItem(cboSucursalAct, .SucursalIdAct)

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

         If clsAppInfo.CentroCostoApli Then
            cboCentroCostoAct.Enabled = False
            cboCentroCostoAct.ReadOnly = True

            If cboCentroCostoDetAct.Items.Count > 0 Then
               cboCentroCostoDetAct.Enabled = True
            Else
               cboCentroCostoDetAct.Enabled = False
            End If
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompraDet
         txtCompraDetId.Text = String.Empty
         Call txtProveedorIdLoad(.ProveedorId)
         Call txtAlmacenIdLoad(.AlmacenId)
         cboItem.Value = Nothing
         Call grdCostoItemLoad(ListPosition(cboItem))
         cboMedida.SelectedIndex = -1
         txtCantidad.Text = "0"
         txtPrecioOrg.Text = "0"
         txtImporte.Text = "0"

         txtMontoRec.Text = "0"
         txtMontoDes.Text = "0"
         txtPorcentajeRec.Text = "0"
         txtPorcentajeDes.Text = "0"
         txtCompraDetDes.Text = ""

         tabMain.TabPages.Item("ItemLote").Enabled = False
         tabMain.TabPages.Item("ItemSerie").Enabled = False
         tabMain.TabPages.Item("General").Selected = True
         tabMain.TabPages.Item("Cuenta").Enabled = False

         'Cuentas de Costo
         cboPlanAct.Value = Nothing
         cboPlanAct.SelectedIndex = -1
         cboPlanAct.ReadOnly = False
         cboPlanAddAct.SelectedIndex = -1
         cboPlanAddAct.Enabled = False
         cboCentroCostoAct.SelectedIndex = -1
         cboCentroCostoAct.Enabled = False
         cboCentroCostoAct.Tag = Nothing
         cboCentroCostoDetAct.SelectedIndex = -1
         cboCentroCostoDetAct.Enabled = False
         cboSucursalAct.SelectedIndex = -1
         cboSucursalAct.Enabled = False

         If clsAppInfo.CentroCostoApli Then
            cboCentroCostoAct.SelectedIndex = ListFindItem(cboCentroCostoAct, .CentroCostoIdAct)
            cboCentroCostoAct.Enabled = False
            cboCentroCostoAct.ReadOnly = True

            Call cboCentroCostoDetActLoad(.CentroCostoIdAct)
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub ItemReadOnly()
      cboItem.ReadOnly = True
      cboMedida.ReadOnly = True

      cboPlanAct.ReadOnly = False 'Poder Editar
   End Sub

   Private Sub DataReadOnly()
      txtCompraDetId.ReadOnly = True
      cboItem.ReadOnly = True
      cboMedida.ReadOnly = True
      txtCantidad.ReadOnly = True
      txtPrecioOrg.ReadOnly = True
      txtImporte.ReadOnly = True
      txtMontoRec.ReadOnly = True
      txtMontoDes.ReadOnly = True
      txtPorcentajeRec.ReadOnly = True
      txtPorcentajeDes.ReadOnly = True
      txtCompraDetDes.ReadOnly = True

      cboPlanAct.ReadOnly = True
      cboPlanAddAct.ReadOnly = True
      cboCentroCostoAct.ReadOnly = True
      cboCentroCostoDetAct.ReadOnly = True
      cboSucursalAct.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCompraDet
         If Not mboolAdding Then
            .CompraDetId = ToLong(txtCompraDetId.Text)
         End If

         .ItemId = ListPosition(cboItem)
         .MedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex)
         .Cantidad = ToDecimal(txtCantidad.Text)
         .PrecioOrg = ToDecimal(txtPrecioOrg.Text)
         .Importe = ToDecimal(txtImporte.Text)
         .PrecioRec = ToDecimal(txtMontoRec.Text / txtCantidad.Text)
         .PrecioDes = ToDecimal(txtMontoDes.Text / txtCantidad.Text)
         .ImporteBru = ToDecimal(ToDouble(txtImporte.Text) + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text))
         .CompraDetDes = ToStr(txtCompraDetDes.Text)

         .PlanIdAct = ListPosition(cboPlanAct)
         .PlanAddIdAct = ListPosition(cboPlanAddAct, cboPlanAddAct.SelectedIndex)
         .CentroCostoIdAct = ListPosition(cboCentroCostoAct, cboCentroCostoAct.SelectedIndex)
         .CentroCostoDetIdAct = ListPosition(cboCentroCostoDetAct, cboCentroCostoDetAct.SelectedIndex)
         .SucursalIdAct = ListPosition(cboSucursalAct, cboSucursalAct.SelectedIndex)

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
               If CuentaCostoCheck() Then
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

         If Not ToDecimal(ToDouble(txtImporte.Text) + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text)) > 0 Then
            strMsg &= "Importe Bruto debe ser mayor  a cero" & vbCrLf
            Throw New Exception(strMsg)
            Return False
         End If

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

         If ToDecimal(txtCantidad.Text) <= 0 Then
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
         If grdItemLoteTotal() <> ToDecimal(txtCantidad.Text) Then
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

   Private Function CuentaCostoCheck() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.Inventario Then

         If cboPlanAct.Enabled Then
            If ListPosition(cboPlanAct) = 0 Then
               strMsg &= "Seleccione la Cuenta de Costo" & vbCrLf
            End If
         End If

         If cboPlanAddAct.Enabled Then
            If ListPosition(cboPlanAddAct, cboPlanAddAct.SelectedIndex) = 0 Then
               strMsg &= "Seleccione el Analítico Adicional de Costo" & vbCrLf
            End If
         End If

         ''If cboSucursalAct.Enabled Then
         ''   If ListPosition(cboSucursalAct, cboSucursalAct.SelectedIndex) = 0 Then
         ''      strMsg &= "Seleccione la Sucursal de Cuenta" & vbCrLf
         ''   End If
         ''End If

         If cboCentroCostoAct.Enabled Then
            If ListPosition(cboCentroCostoAct, cboCentroCostoAct.SelectedIndex) = 0 Then
               strMsg &= "Seleccione el Centro de Costo" & vbCrLf
            End If
         End If

         If cboCentroCostoDetAct.Enabled Then
            If ListPosition(cboCentroCostoDetAct, cboCentroCostoDetAct.SelectedIndex) = 0 Then
               strMsg &= "Seleccione la Actividad de Centro de Costo" & vbCrLf
            End If
         End If

      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         CuentaCostoCheck = False
      Else
         CuentaCostoCheck = True
      End If
   End Function

   Private Function CantidadMaxCheck() As Boolean
      Dim strMsg As String = String.Empty

      If mdecCantidadMax > 0 And mlngTipoItemId <> 2 Then
         If mlngMedidaId = moCompraDet.MedidaId Then
            If (mdecSaldoItem + moCompraDet.Cantidad) > mdecCantidadMax Then
               strMsg = "¡Advertencia! Con esta Entrada, La Cantidad en Stock es Superior al Limite Maximo"
            End If
         Else
            If (mdecSaldoItem + (moCompraDet.Cantidad * mdecMedidaCantEqui)) > mdecCantidadMax Then
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
            .EmpresaId = moCompraDet.EmpresaId
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

      txtCantidad.FormatString = DecimalMask()
      txtPrecioOrg.FormatString = DecimalMask()
      txtImporte.FormatString = DecimalMask()

      txtPorcentajeDes.FormatString = DecimalMask()
      txtMontoDes.FormatString = DecimalMask()
      txtPorcentajeRec.FormatString = DecimalMask()
      txtMontoRec.FormatString = DecimalMask()

      If mboolAdding Then
         mnuItemLoteShow.Enabled = False
         mnuItemLoteNew.Enabled = True
         mnuItemLoteEdit.Enabled = False
         mnuItemLoteDelete.Enabled = False

      ElseIf mboolEditing Then
         mnuItemLoteShow.Enabled = True
         mnuItemLoteNew.Enabled = True
         mnuItemLoteEdit.Enabled = True
         mnuItemLoteDelete.Enabled = True

      Else
         mnuItemLoteShow.Enabled = True
         mnuItemLoteNew.Enabled = False
         mnuItemLoteEdit.Enabled = False
         mnuItemLoteDelete.Enabled = False
         UiGroupBox2.Enabled = False
      End If

      chkCodBarra.Checked = clsAppInfo.CodBarra
      If Not chkCodBarra.Checked Then
         chkCodBarra.Visible = False
      End If

      cboPlanAddAct.SelectedIndex = -1
      cboPlanAddAct.Enabled = False
      cboCentroCostoAct.SelectedIndex = -1
      cboCentroCostoAct.Enabled = False
      cboCentroCostoDetAct.SelectedIndex = -1
      cboCentroCostoDetAct.Enabled = False
      cboSucursalAct.SelectedIndex = -1
      cboSucursalAct.Enabled = False

        'moItemLote = New clsItemLote(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboItemLoad()

      'Cuenta Costo
      Call cboPlanActLoad()
      Call cboSucursalActLoad()
      Call cboCentroCostoActLoad()


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

            .EmpresaId = moCompraDet.EmpresaId
            .ItemId = moCompraDet.ItemId
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
               'txtProveedorId.Tag = .ProveedorId
               'txtProveedorId.Text = ToStr(.ProveedorDes)
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
               'txtAlmacenId.Tag = .AlmacenId
               'txtAlmacenId.Text = ToStr(.AlmacenDes)
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
            .EmpresaId = moCompraDet.EmpresaId
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

   Private Function ItemIdFind(ByVal strItemCod As String) As Long
      Dim oItemBarra As New clsItemBarra(clsAppInfo.ConnectString)

      ItemIdFind = 0

      Try
         With oItemBarra
            .SelectFilter = clsItemBarra.SelectFilters.All
            .WhereFilter = clsItemBarra.WhereFilters.ItemBarraCod
            .EmpresaId = moCompraDet.EmpresaId
            .ItemBarraCod = strItemCod

            If .Find Then
               ItemIdFind = .ItemId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemBarra.Dispose()

      End Try
   End Function

   Private Sub cboItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboItem.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F2 Then
            If mboolAdding Then
               ''Dim frm As New frmItemFind
               Dim frm As New frmItemFind

               Try
                  With frm
                     .EmpresaId = moCompraDet.EmpresaId
                     .ShowDialog()

                     If .Changed Then
                        cboItem.Value = Nothing
                        cboItem.Tag = Nothing
                        cboItem.Value = ListFindItem(cboItem, ToLong(frm.ID))
                        cboItem.DropDownList.Refetch()
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

                     oItem.EmpresaId = moCompraDet.EmpresaId

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
         ElseIf e.KeyCode = Keys.Enter Then
            If chkCodBarra.Checked Then
               Dim lngItemId As Long
               Dim strItemCod As String = ToStr(cboItem.Text)

               If strItemCod <> "" Then
                  lngItemId = ItemIdFind(strItemCod)

                  If lngItemId > 0 Then
                     cboItem.Value = Nothing
                     cboItem.Tag = Nothing
                     cboItem.Value = ListFindItem(cboItem, lngItemId)
                     cboItem.DropDownList.Refetch()
                     txtCantidad.Select()
                  End If
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboItem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItem.LostFocus
      If cboItem.Tag <> cboItem.Text Then
         cboItem.Tag = cboItem.Text

         Dim lngItemId As Long = ListPosition(cboItem)
         txtMontoRec.Text = "0"
         txtMontoDes.Text = "0"
         txtImporte.Text = "0"
         txtPorcentajeDes.Text = "0"
         txtPorcentajeRec.Text = "0"

         If lngItemId <> 0 Then
            Call ItemParametro(lngItemId)
            Call ItemSaldoParametro(lngItemId, moCompraDet.AlmacenId)
            Call cboMedidaLoad()
            cboMedida.Tag = ""
            cboMedida.SelectedIndex = ListFindItem(cboMedida, mlngMedidaId)
            txtImporte.Text = ToDecStr(ToDecimal(txtCantidad.Text) * ToDecimal(txtPrecioOrg.Text))

            moDataTableLote.Clear()
            If mboolControlLote Then
               tabMain.TabPages.Item("ItemLote").Enabled = True
               Call grdItemLoteLoad()
            Else
               tabMain.TabPages.Item("ItemLote").Enabled = False
            End If

            moDataTableSerie.Clear()
            cboItemLote.Items.Clear()
            If mboolControlSerie Then
               tabMain.TabPages.Item("ItemSerie").Enabled = True
               Call grdMainSerieLoad()
            Else
               tabMain.TabPages.Item("ItemSerie").Enabled = False
            End If

            'Cuenta Activo
            tabMain.TabPages.Item("Cuenta").Enabled = True
            cboPlanAct.Value = ListFindItem(cboPlanAct, PlanIdActFind(lngItemId))


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
      Call grdCostoItemLoad(ListPosition(cboItem))

   End Sub

   Private Sub cboMedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedida.SelectedIndexChanged
      If cboMedida.Tag <> cboMedida.Text Then
         cboMedida.Tag = cboMedida.Text

         Dim decUPC As Decimal = ItemProveedorUPC(moCompraDet.ProveedorId, ListPosition(cboItem))

         If mlngMedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex) Then
            If moCompraDet.MonedaId = 1 Then
               If moCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecioOrg.Text = ToDecStr(decUPC)
               Else
                  txtPrecioOrg.Text = ToDecStr(decUPC * moCompraDet.TipoCambio)
               End If

            ElseIf moCompraDet.MonedaId = 2 Then
               If moCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecioOrg.Text = ToDecStr(decUPC)
               Else
                  txtPrecioOrg.Text = ToDecStr(decUPC / moCompraDet.TipoCambio)
               End If
            End If

         ElseIf mlngMedidaIdEqui = ListPosition(cboMedida, cboMedida.SelectedIndex) Then
            If moCompraDet.MonedaId = 1 Then
               If moCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecioOrg.Text = ToDecStr(decUPC * mdecMedidaCantEqui)
               Else
                  txtPrecioOrg.Text = ToDecStr((decUPC * mdecMedidaCantEqui) * moCompraDet.TipoCambio)
               End If

            ElseIf moCompraDet.MonedaId = 2 Then
               If moCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecioOrg.Text = ToDecStr(decUPC * mdecMedidaCantEqui)
               Else
                  txtPrecioOrg.Text = ToDecStr((decUPC * mdecMedidaCantEqui) / moCompraDet.TipoCambio)
               End If
            End If
         Else
            txtPrecioOrg.Text = "0"
         End If

         txtImporte.Text = ToDecStr(ToDecimal(txtCantidad.Text) * ToDecimal(txtPrecioOrg.Text))
         Call MontoRecDesLoad()
      End If
   End Sub

   Private Function ItemProveedorUPC(ByVal lngProveedorId As Long, ByVal lngItemId As Long) As Decimal
      Dim oItemProveedor As New clsItemProveedor(clsAppInfo.ConnectString)

      Try
         With oItemProveedor
            .SelectFilter = clsItemProveedor.SelectFilters.All
            .WhereFilter = clsItemProveedor.WhereFilters.ItemId
            .EmpresaId = moCompraDet.EmpresaId
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

   Private Sub MontoRecDesLoad()
      txtMontoRec.Text = ToDecStr(ToDecimal(ToDouble(txtPorcentajeRec.Text) * ToDouble(txtImporte.Text) / 100))
      txtMontoDes.Text = ToDecStr(ToDecimal(ToDouble(txtPorcentajeDes.Text) * ToDouble(txtImporte.Text) / 100))

   End Sub

   Private Sub chkItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItem.CheckedChanged
      If chkItem.Checked Then
         cboItem.DisplayMember = "ItemDes"
         cboItem.Tag = cboItem.Text
      Else
         cboItem.DisplayMember = "ItemCod"
         cboItem.Tag = cboItem.Text
      End If
   End Sub

   Private Sub txtCantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
      If txtCantidad.ContainsFocus Then
         txtImporte.Text = ToDecStr(ToDecimal(txtCantidad.Text) * ToDecimal(txtPrecioOrg.Text))
         Call MontoRecDesLoad()
      End If
   End Sub

   Private Sub txtPrecioOrg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioOrg.TextChanged
      If txtPrecioOrg.ContainsFocus Then
         txtImporte.Text = ToDecStr(ToDecimal(txtCantidad.Text) * ToDecimal(txtPrecioOrg.Text))
         Call MontoRecDesLoad()
      End If
   End Sub

   Private Sub txtImporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
      If txtImporte.ContainsFocus Then
         txtPrecioOrg.Text = ToDecStr(ToDecimal(txtImporte.Text) / ToDivByCero(txtCantidad.Text))
         Call MontoRecDesLoad()
      End If
   End Sub

   Private Sub txtCantidad_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.LostFocus
      If Not mboolControlLote And mboolControlSerie Then
         If isDataTableVacio() Then
            moDataTableSerie.Clear()
            grdMainSerie.Refetch()
         End If
         Call addRowsToTableSerie(ToLong(txtCantidad.Text), moDataTableSerie.Rows.Count, 0, String.Empty, ListPosition(cboItem))
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
      Dim frm As New frmItemLoteEdit

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
                     frm.MedidaIdNota = moCompraDet.MedidaId
                     frm.ShowDialog()

                     frm.Dispose()
                  End If
               End With

            ElseIf ToStr(grdItemLote.GetValue("Estado")) = "New" Then
               With frm
                  .NewRecord = False
                  .Editing = False

                  oItemLote.EmpresaId = moCompraDet.EmpresaId
                  oItemLote.ItemId = ToLong(grdItemLote.GetValue("ItemId"))
                  oItemLote.ItemLoteDes = ToStr(grdItemLote.GetValue("ItemLoteDes"))
                  oItemLote.SaldoOrg = ToDecimal(grdItemLote.GetValue("SaldoOrg"))
                  oItemLote.FechaVen = ToStr(grdItemLote.GetValue("FechaVen"))
                  oItemLote.ItemLoteIdOrg = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))

                  .DataObject = oItemLote
                  frm.DataTable = moDataTableLote
                  .MedidaIdNota = moCompraDet.MedidaId
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

            oItemLote.EmpresaId = moCompraDet.EmpresaId
            oItemLote.ItemId = moCompraDet.ItemId
            oItemLote.MedidaId = moCompraDet.MedidaId
            oItemLote.SaldoOrg = ToDecimal(txtCantidad.Text) - grdItemLoteTotal()
            oItemLote.FechaVen = moCompraDet.Fecha

            .DataObject = oItemLote
            frm.DataTable = moDataTableLote
            .MedidaIdNota = moCompraDet.MedidaId
            .ShowDialog()

            If .Changed Then
               moDataTableLote.Rows.Add(GetRowNew(frm.DataObject))
               Call addRowsToTableSerie(oItemLote.SaldoOrg, getCantidadRowByLote(oItemLote.ItemLoteDes), _
                                         oItemLote.ItemLoteId, oItemLote.ItemLoteDes, oItemLote.ItemId)
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
      Dim frm As New frmItemLoteEdit
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Try
         If grdItemLote.RowCount > 0 Then
            If ToStr(grdItemLote.GetValue("Estado")) = "Show" Then
               With oItemLote
                  .ItemLoteId = ToLong(grdItemLote.GetValue("ItemLoteId"))

                  If .FindByPK Then
                     Dim strItemLoteDes As String = .ItemLoteDes
                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oItemLote
                     frm.DataTable = moDataTableLote
                     frm.MedidaIdNota = moCompraDet.MedidaId
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call RowNewEdit(moDataTableLote.Rows(grdItemLote.Row), frm.DataObject, "Edit")

                        If strItemLoteDes <> oItemLote.ItemLoteDes Then
                           If Not isLoteSerieConMovimiento(.ItemLoteId) Then
                              Call delRowsToTableSerieByLote(strItemLoteDes)
                           Else
                              Call RemaneRowsToTableSerieByLote(strItemLoteDes, oItemLote.ItemLoteId, oItemLote.ItemLoteDes)
                           End If
                        End If
                        Call addRowsToTableSerie(oItemLote.SaldoOrg, getCantidadRowByLote(oItemLote.ItemLoteDes), _
                                                 oItemLote.ItemLoteId, oItemLote.ItemLoteDes, oItemLote.ItemId)

                     End If

                     frm.Dispose()
                     mboolEditing = True
                  End If
               End With

            ElseIf ToStr(grdItemLote.GetValue("Estado")) = "New" Then
               Dim strItemLoteDes As String = ToStr(grdItemLote.GetValue("ItemLoteDes"))

               With frm
                  .NewRecord = False
                  .Editing = True

                  oItemLote.ItemLoteId = ToLong(grdItemLote.GetValue("ItemLoteId"))
                  oItemLote.EmpresaId = moCompraDet.EmpresaId
                  oItemLote.ItemId = ToLong(grdItemLote.GetValue("ItemId"))
                  oItemLote.ItemLoteDes = ToStr(grdItemLote.GetValue("ItemLoteDes"))
                  oItemLote.SaldoOrg = ToDecimal(grdItemLote.GetValue("SaldoOrg"))
                  oItemLote.FechaVen = ToDateDMY(grdItemLote.GetValue("FechaVen"))
                  oItemLote.ItemLoteIdOrg = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))

                  .DataObject = oItemLote
                  frm.DataTable = moDataTableLote
                  .MedidaIdNota = moCompraDet.MedidaId
                  .ShowDialog()

                  If .Changed Then
                     Call RowNewEdit(moDataTableLote.Rows(grdItemLote.Row), frm.DataObject, "New")

                     If strItemLoteDes <> oItemLote.ItemLoteDes Then
                        Call delRowsToTableSerieByLote(strItemLoteDes)
                     End If
                     Call addRowsToTableSerie(oItemLote.SaldoOrg, getCantidadRowByLote(oItemLote.ItemLoteDes), _
                                              oItemLote.ItemLoteId, oItemLote.ItemLoteDes, oItemLote.ItemId)


                  End If

                  frm.Dispose()
                  mboolEditing = True
               End With

            ElseIf ToStr(grdItemLote.GetValue("Estado")) = "Edit" Then
               Dim strItemLoteDes As String = ToStr(grdItemLote.GetValue("ItemLoteDes"))

               With frm
                  .NewRecord = False
                  .Editing = True

                  oItemLote.ItemLoteId = ToLong(grdItemLote.GetValue("ItemLoteId"))
                  oItemLote.EmpresaId = moCompraDet.EmpresaId
                  oItemLote.ItemId = ToLong(grdItemLote.GetValue("ItemId"))
                  oItemLote.ItemLoteDes = ToStr(grdItemLote.GetValue("ItemLoteDes"))
                  oItemLote.SaldoOrg = ToDecimal(grdItemLote.GetValue("SaldoOrg"))
                  oItemLote.FechaVen = ToDateDMY(grdItemLote.GetValue("FechaVen"))
                  oItemLote.ItemLoteIdOrg = ToLong(grdItemLote.GetValue("ItemLoteIdOrg"))

                  .DataObject = oItemLote
                  frm.DataTable = moDataTableLote
                  .MedidaIdNota = moCompraDet.MedidaId
                  .ShowDialog()

                  If .Changed Then
                     Call RowNewEdit(moDataTableLote.Rows(grdItemLote.Row), frm.DataObject, "Edit")

                     If strItemLoteDes <> oItemLote.ItemLoteDes Then
                        If Not isLoteSerieConMovimiento(oItemLote.ItemLoteId) Then
                           Call delRowsToTableSerieByLote(strItemLoteDes)
                        Else
                           Call RemaneRowsToTableSerieByLote(strItemLoteDes, oItemLote.ItemLoteId, oItemLote.ItemLoteDes)
                        End If
                     End If
                     Call addRowsToTableSerie(oItemLote.SaldoOrg, getCantidadRowByLote(oItemLote.ItemLoteDes), _
                                              oItemLote.ItemLoteId, oItemLote.ItemLoteDes, oItemLote.ItemId)


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

                  'En caso de ser una entrada si tiene movimiento en una salida
                  If Not ItemLoteTieneMovimiento(grdItemLote.GetValue("ItemLoteId")) Then
                     'MessageBox.Show("Imposible Eliminar el Registro, ya tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     moDataTableLoteDelete.Rows.Add(GetRowLoteDelete(moDataTableLote.Rows.Item(grdItemLote.Row)))
                     moDataTableLote.Rows.RemoveAt(grdItemLote.Row)
                  Else
                     MessageBox.Show("Imposible Eliminar el Registro, ya tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
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

         .RootTable.Columns("SaldoOrg").Caption = "Cantidad"
         .RootTable.Columns("SaldoOrg").FormatString = DecimalMask()
         .RootTable.Columns("SaldoOrg").Width = 100
         .RootTable.Columns("SaldoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SaldoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SaldoAct").Visible = False

         .RootTable.Columns("FechaVen").Caption = "Vencimiento"
         .RootTable.Columns("FechaVen").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FechaVen").Width = 100
         .RootTable.Columns("FechaVen").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FechaVen").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Estado").Visible = False

         .RootTable.Columns("ItemLoteIdOrg").Visible = False
      End With
   End Sub

   Private Sub grdItemLote_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdItemLote.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdItemLote.RowCount > 0 Then
               mnuItemLoteShow.Enabled = True
               mnuItemLoteNew.Enabled = True
               mnuItemLoteEdit.Enabled = True
               mnuItemLoteDelete.Enabled = True
            Else
               mnuItemLoteShow.Enabled = False
               mnuItemLoteNew.Enabled = True
               mnuItemLoteEdit.Enabled = False
               mnuItemLoteDelete.Enabled = False
            End If
         Else
            mnuItemLoteShow.Enabled = True
            mnuItemLoteNew.Enabled = False
            mnuItemLoteEdit.Enabled = False
            mnuItemLoteDelete.Enabled = False
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
               mnuItemLoteNew.Enabled = True
               mnuItemLoteEdit.Enabled = True
               mnuItemLoteDelete.Enabled = True
            Else
               mnuItemLoteShow.Enabled = False
               mnuItemLoteNew.Enabled = True
               mnuItemLoteEdit.Enabled = False
               mnuItemLoteDelete.Enabled = False
            End If
         Else
            mnuItemLoteShow.Enabled = True
            mnuItemLoteNew.Enabled = False
            mnuItemLoteEdit.Enabled = False
            mnuItemLoteDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuItemLoteShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLoteShow.Click
      Call grdItemLoteDataShow()
   End Sub

   Private Sub mnuItemLoteNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLoteNew.Click
      Call grdItemLoteFormNew()
      grdMainSerie.Refetch()
   End Sub

   Private Sub mnuItemLoteEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLoteEdit.Click
      Call grdItemLoteDataEdit()
      grdMainSerie.Refetch()
   End Sub

   Private Sub mnuItemLoteDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLoteDelete.Click
      Call grdItemLoteDataDelete()
      grdMainSerie.Refetch()
   End Sub

   Private Function ItemLoteTieneMovimiento(ByVal lngItemLoteId As Long) As Boolean
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Try
         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.All
            .WhereFilter = clsItemLote.WhereFilters.TieneItemLoteIdOrg
            .EmpresaId = clsAppInfo.EmpresaId
            .ItemLoteIdOrg = lngItemLoteId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function PlanIdActFind(ByVal lngItemId As Long) As Long
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim oPlanGrupo As New clsPlanGrupo(clsAppInfo.ConnectString)

      PlanIdActFind = 0

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               With oPlanGrupo
                  .PlanGrupoId = oItem.PlanGrupoId

                  If .FindByPK Then
                     Return .PlanIdAct
                  End If
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()
         oPlanGrupo.Dispose()

      End Try
   End Function

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

   Private Sub cboItemLoteLoad()
      Dim oItem As clsListItem
      cboItemLote.Items.Clear()

      Try

         If mboolControlLote Then
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdItemLote.GetRows
               oItem = New clsListItem(oRow.Cells("ItemLoteIdOrg").Value, oRow.Cells("ItemLoteDes").Value)
               cboItemLote.Items.Add(oItem)
            Next
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem = Nothing

      End Try
   End Sub

   Private Sub grdMainDeleteSerie()
      Try
         If grdMainSerie.RowCount > 0 Then
            If (grdMainSerie.GetValue("ItemLoteIdSal") = 0) And (grdMainSerie.GetValue("TipoNotaIdSal") = 0) And (grdMainSerie.GetValue("NotaIdSal") = 0) Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  moDataTableSerie.Rows.RemoveAt(grdMainSerie.Row)
               End If
            Else
               MessageBox.Show("El Nro de Serie ya tiene movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Function getNumero(ByVal str As String) As String
      For index = 0 To str.Length - 1
         If ToInteger(str.Chars(index).ToString) > 0 Then
            Return str.Substring(index)
         End If
      Next
   End Function

   Private Function stringReplace(ByVal strNum As String, ByVal strCeros As String) As String
      If strCeros.Length - strNum.Length > 0 Then
         Return strCeros.Remove(0, strNum.Length) + strNum
      Else
         Return strNum
      End If
   End Function

   Private Function concatStr(ByVal str As String, ByVal strLength As Integer) As String
      For index = 0 To strLength - 1
         concatStr += str
      Next
   End Function

   Private Sub generarItemNroSerie(ByVal strItemLoteDes As String)
      grdMainSerie.UpdateData()
      Dim strItemNroSerie As String = ToStr(txtItemNroSerieCod.Text)
      Dim lngDel As Long = ToInteger(getNumero(numDel.Text))
      Dim lngAl As Long = ToInteger(getNumero(numAl.Text))
      Dim strCeros As String = concatStr("0", numDel.Text.Length)

      For Each oRow As DataRow In moDataTableSerie.Rows
         If lngDel <= lngAl Then
            If ToStr(oRow("ItemLoteDes")) = strItemLoteDes Then
               If oRow("Estado") = Constant.STATE_DAFAUL Then
                  oRow("ItemNroSerieCod") = strItemNroSerie + stringReplace(ToStr(lngDel), strCeros)
                  oRow("Estado") = Constant.STATE_NEW
                  lngDel += 1
               End If
            End If
         Else
            Exit For
         End If
      Next

      txtItemNroSerieCod.Text = String.Empty
      numDel.Text = "0"
      numAl.Text = "0"

   End Sub

   'Metodo que agrega series al datable cuando solo maneja series 
   Private Sub addRowsToTableSerie(ByVal lngCantidad As Long, ByVal lngCountLimit As Long, ByVal lngItemLoteId As Long, _
                                   ByVal strItemLoteDes As String, ByVal lngItemId As Long)
      Dim oRow As DataRow
      If ListPosition(cboMedida, cboMedida.SelectedIndex) <> mlngMedidaId Then
         lngCantidad *= mdecMedidaCantEqui
      End If
      Dim intDiferencia As Integer = lngCantidad - lngCountLimit

      If intDiferencia > 0 Then
         For index As Integer = 0 To intDiferencia - 1
            oRow = moDataTableSerie.NewRow
            oRow("ItemNroSerieId") = 0
            oRow("ItemLoteId") = lngItemLoteId
            oRow("ItemLoteDes") = strItemLoteDes
            oRow("ItemLoteIdSal") = 0
            oRow("TipoNotaIdSal") = 0
            oRow("NotaIdSal") = 0
            oRow("ItemId") = lngItemId
            oRow("Estado") = Constant.STATE_DAFAUL
            moDataTableSerie.Rows.Add(oRow)
         Next
      End If
   End Sub

   'Metodo que elimina todas las series del datatable dependiendo de la cantidad del lote
   Private Sub delRowsToTableSerieByLote(ByVal strItemLoteDes As String)
      If mboolControlSerie Then
         Dim oRow As DataRow
         Dim index As Integer = 0

         While index < moDataTableSerie.Rows.Count
            oRow = moDataTableSerie.Rows(index)
            If oRow("ItemLoteDes") = strItemLoteDes Then
               moDataTableSerie.Rows.RemoveAt(index)
            Else
               index += 1
            End If
         End While
      End If
   End Sub

   Private Sub RemaneRowsToTableSerieByLote(ByVal strItemLoteDesOrg As String, ByVal strItemLoteId As Long, ByVal strItemLoteDes As String)
      If mboolControlSerie Then
         For Each oRow As DataRow In moDataTableSerie.Rows
            If (oRow("ItemLoteDes") = strItemLoteDesOrg) And (oRow("ItemLoteId") = strItemLoteId) Then
               oRow("ItemLoteDes") = strItemLoteDes
            End If
         Next
      End If
   End Sub

   Private Function getCantidadRowByLote(ByVal strItemLoteDes As String) As Integer
      For Each oRow As DataRow In moDataTableSerie.Rows
         If oRow("ItemLoteDes") = strItemLoteDes Then
            getCantidadRowByLote += 1
         End If
      Next
   End Function

   Private Function getCantidadRowByNroSerieEnt(ByVal strItemSerieDes As String) As Integer
      grdMainSerie.UpdateData()

      For Each oRow As DataRow In moDataTableSerie.Rows
         If ToStr(oRow("ItemNroSerieCod")) = strItemSerieDes Then
            getCantidadRowByNroSerieEnt += 1
         End If
      Next
   End Function

   Private Sub dtSerieClearNroSerie()
      Try
         For Each oRow As DataRow In moDataTableSerie.Rows
            oRow("ItemNroSerieId") = 0
            oRow("ItemNroSerieCod") = String.Empty
            oRow("Estado") = Constant.STATE_DAFAUL
         Next
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally

      End Try
   End Sub

   Private Function dataTableSerieIsEnptyCells() As Boolean
      grdMainSerie.UpdateData()
      For Each oRow As DataRow In moDataTableSerie.Rows
         If ToStr(oRow("ItemNroSerieCod")) = String.Empty Then
            Return True
         End If
      Next
   End Function

   Private Function dataTableSerieIsDuplicateCells() As Boolean
      grdMainSerie.UpdateData()
      For Each oRow As DataRow In moDataTableSerie.Rows
         If ToStr(oRow("ItemNroSerieCod")) <> String.Empty Then
            If getCantidadRowByNroSerieEnt(ToStr(oRow("ItemNroSerieCod"))) > 1 Then
               Return True
            End If
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

   Private Function isSerieConMovimiento() As Boolean
      For Each oRow As DataRow In moDataTableSerie.Rows
         If (ToLong(oRow("ItemLoteIdSal")) <> 0) Or (ToLong(oRow("TipoNotaIdSal")) <> 0) Or (ToLong(oRow("NotaIdSal")) <> 0) Then
            Return True
         End If
      Next
   End Function

   Private Function isLoteSerieConMovimiento(ByVal lngItemLoteId As Long) As Boolean
      For Each oRow As DataRow In moDataTableSerie.Rows
         If (ToLong(oRow("ItemLoteId")) = lngItemLoteId) Then
            If (ToLong(oRow("ItemLoteIdSal")) <> 0) Or (ToLong(oRow("TipoNotaIdSal")) <> 0) Or (ToLong(oRow("NotaIdSal")) <> 0) Then
               Return True
            End If
         End If
      Next
   End Function

   Private Function serieCheck() As Boolean
      Dim strMsg As String = String.Empty

      If mboolControlSerie Then

         If ListPosition(cboMedida, cboMedida.SelectedIndex) <> mlngMedidaId Then
            If grdMainSerie.RowCount <> ToDecimal(txtCantidad.Text) * mdecMedidaCantEqui Then
               strMsg &= "Cantidad de Número de Serie(s) Invalido(s)" & vbCrLf
            End If
         Else
            If grdMainSerie.RowCount <> ToDecimal(txtCantidad.Text) Then
               strMsg &= "Cantidad de Número de Serie(s) Invalido(s)" & vbCrLf
            End If
         End If

         If dataTableSerieIsEnptyCells() Then
            strMsg &= "Algunos Codigos de Series son invalidos" & vbCrLf
         End If

         If dataTableSerieIsDuplicateCells() Then
            strMsg &= "Existen Codigos de Series duplicados" & vbCrLf
         End If

      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         serieCheck = False
      Else
         serieCheck = True
      End If
   End Function

   Private Sub DataViewAll()
      grdMainSerie.RemoveFilters()
   End Sub

   Private Sub grdMainInitSerie()
      With grdMainSerie
         ebrMain.Groups(0).Text = "Detalle de Número de Series"
         .ContextMenu = mnuMainSerie

         .RootTable.Columns("ItemNroSerieId").Visible = False
         .RootTable.Columns("ItemLoteId").Visible = False

         .RootTable.Columns("ItemLoteDes").Visible = mboolControlLote
         .RootTable.Columns("ItemLoteDes").Caption = "Lote"
         .RootTable.Columns("ItemLoteDes").Width = 80
         .RootTable.Columns("ItemLoteDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemLoteDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ItemLoteDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("ItemLoteDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("ItemLoteIdSal").Visible = False
         .RootTable.Columns("TipoNotaIdSal").Visible = False
         .RootTable.Columns("NotaIdSal").Visible = False

         .RootTable.Columns("ItemNroSerieCod").Caption = "Codigo Serie"
         .RootTable.Columns("ItemNroSerieCod").Width = 200
         .RootTable.Columns("ItemNroSerieCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemNroSerieCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemId").Visible = False
         .RootTable.Columns("ItemNroSerieIdDev").Visible = False
         .RootTable.Columns("AppId").Visible = False
         .RootTable.Columns("TipoDocumentoId").Visible = False
         .RootTable.Columns("DocumentoId").Visible = False
         .RootTable.Columns("DocumentoDetId").Visible = False
         .RootTable.Columns("Estado").Visible = False
      End With

      Call grdMainSerieAddConditionalFormatting()
   End Sub

   Private Sub grdMainSerieAddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMainSerie.RootTable.Columns("ItemLoteIdSal"), Janus.Windows.GridEX.ConditionOperator.NotEqual, 0)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMainSerie.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMainSerie.RootTable.Columns("TipoNotaIdSal"), Janus.Windows.GridEX.ConditionOperator.NotEqual, 0)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMainSerie.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMainSerie.RootTable.Columns("NotaIdSal"), Janus.Windows.GridEX.ConditionOperator.Equal.NotEqual, 0)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMainSerie.RootTable.FormatConditions.Add(fc)

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
            Else
               mnuItemSerieDelete.Enabled = False
            End If
         Else
            mnuItemSerieDelete.Enabled = False
         End If
      End If

   End Sub

   Private Sub grdItemSerie_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMainSerie.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdMainSerie.RowCount > 0 Then
               mnuItemSerieDelete.Enabled = True
            Else
               mnuItemSerieDelete.Enabled = False
            End If
         Else
            mnuItemSerieDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuItemSerieDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuItemSerieDelete.Click
      Call grdMainDeleteSerie()
      grdMainSerie.Refetch()
   End Sub

   Private Sub btnGenerarSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarSerie.Click
      Call generarItemNroSerie(cboItemLote.Text)
   End Sub

   Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
      If Not isSerieConMovimiento() Then
         If mboolAdding And mboolControlLote Then
            Call dtSerieClearNroSerie()
         Else
                For Each oRow As DataRow In moDataTableSerie.Rows
                    oRow("ItemNroSerieCod") = String.Empty
                    oRow("Estado") = Constant.STATE_DAFAUL
                Next
                'moDataTableSerie.Clear()
                grdMainSerie.Refetch()
         End If
      Else
         MessageBox.Show("Existen Series con Movimientos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim frm As New frmSerieImpExcel

        With frm
            .ShowDialog()
            If .Changed Then
                grdMainSerie.UpdateData()
                Dim strItemNroSerie As String = ToStr(txtItemNroSerieCod.Text)
                Dim strCeros As String = concatStr("0", numDel.Text.Length)
                Dim strItemLoteDes As String = cboItemLote.Text
                For Each oRow In moDataTableSerie.Rows
                    If ToStr(oRow("ItemLoteDes")) = strItemLoteDes Then
                        If oRow("Estado") = Constant.STATE_DAFAUL Then
                            If .Lista.Count > 0 Then
                                oRow("ItemNroSerieCod") = .Lista.Dequeue() ' strItemNroSerie + stringReplace(ToStr(lngDel), strCeros)
                                oRow("Estado") = Constant.STATE_NEW

                            End If
                        End If
                    End If
                Next

                txtItemNroSerieCod.Text = String.Empty
                numDel.Text = "0"
                numAl.Text = "0"
            End If
            frm.Dispose()
        End With
    End Sub

   Private Sub tabMain_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabMain.SelectedTabChanged
      Call cboItemLoteLoad()
   End Sub

   Private Sub grdMainSerie_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdMainSerie.UpdatingCell
      If ToStr(grdMainSerie.RootTable.Columns(grdMainSerie.Col).DataMember) = "ItemNroSerieCod" Then
         If ToLong(grdMainSerie.GetValue("NotaIdSal")) = 0 Or ToLong(grdMainSerie.GetValue("ItemLoteIdSal")) = 0 Then
            If ToStr(grdMainSerie.GetValue("ItemNroSerieCod")).Trim <> String.Empty Then
               grdMainSerie.SetValue("Estado", Constant.STATE_NEW)
            Else
               grdMainSerie.SetValue("Estado", Constant.STATE_DAFAUL)
            End If
         Else
            MessageBox.Show("Serie con Salida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
         End If
      End If
   End Sub

   Private Sub grdMainSerie_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grdMainSerie.EditingCell
      If ToStr(grdMainSerie.RootTable.Columns(grdMainSerie.Col).DataMember) = "ItemNroSerieCod" Then
         If (mboolAdding Or mboolEditing) Then
            If (grdMainSerie.GetValue("ItemLoteIdSal") = 0) And (grdMainSerie.GetValue("TipoNotaIdSal") = 0) And (grdMainSerie.GetValue("NotaIdSal") = 0) Then
               If mboolControlLote And (ToStr(grdMainSerie.GetValue("ItemLoteDes")) = String.Empty) Then
                  e.Cancel = True
                  MessageBox.Show("Serie sin Lote", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               e.Cancel = True
            End If
         Else
            e.Cancel = True
         End If
      End If
   End Sub

   Private Sub numDel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numDel.KeyPress
      If e.KeyChar.IsDigit(e.KeyChar) Then
         e.Handled = False
      ElseIf e.KeyChar.IsControl(e.KeyChar) Then
         e.Handled = False
      Else
         e.Handled = True
      End If
   End Sub

   Private Sub numAl_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numAl.KeyPress
      If e.KeyChar.IsDigit(e.KeyChar) Then
         e.Handled = False
      ElseIf e.KeyChar.IsControl(e.KeyChar) Then
         e.Handled = False
      Else
         e.Handled = True
      End If
   End Sub

#End Region

#Region " Cuenta"

   Private Sub cboPlanActLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      cboPlanAct.DropDownList.Columns.Clear()

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moCompraDet.EmpresaId
            .EsAna = 1
            .PlanId = moCompraDet.PlanIdAct
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
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
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub cboPlanAddActLoad(ByVal lngPlanId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPlanAddAct.Items.Clear()

      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.ListBox
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes
            .EmpresaId = clsAppInfo.EmpresaId
            .PlanId = lngPlanId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.PlanAddId, .PlanAddDes)

                  cboPlanAddAct.Items.Add(oItem)
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

   Private Sub cboSucursalActLoad()
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSucursalAct.Items.Clear()

      Try
         With oSucursal
            .SelectFilter = clsSucursal.SelectFilters.ListBox
            .WhereFilter = clsSucursal.WhereFilters.EmpresaId
            .OrderByFilter = clsSucursal.OrderByFilters.SucursalDes
            .EmpresaId = moCompraDet.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.SucursalId, .SucursalDes)

                  cboSucursalAct.Items.Add(oItem)
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

   Private Sub cboCentroCostoActLoad()
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCostoAct.Items.Clear()

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.ListBox
            .WhereFilter = clsCentroCosto.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = moCompraDet.EmpresaId
            .EstadoId = clsEstado.ACTIVO
            .CentroCostoId = moCompraDet.CentroCostoIdAct

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.CentroCostoId, .CentroCostoDes)

                  cboCentroCostoAct.Items.Add(oItem)
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

   Private Sub cboCentroCostoDetActLoad(ByVal lngCentroCostoId As Long)
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCostoDetAct.Items.Clear()

      Try
         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.ListBox
            .WhereFilter = clsCentroCostoDet.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCostoDet.OrderByFilters.CentroCostoDetDes
            .EmpresaId = moCompraDet.EmpresaId
            .CentroCostoId = lngCentroCostoId
            .EstadoId = clsEstado.ACTIVO
            .CentroCostoDetId = moCompraDet.CentroCostoDetIdAct

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.CentroCostoDetId, .CentroCostoDetDes)

                  cboCentroCostoDetAct.Items.Add(oItem)
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

   Private Sub cboPlanAct_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlanAct.ValueChanged

      If cboPlanAct.Tag <> cboPlanAct.Text Then
         cboPlanAct.Tag = cboPlanAct.Text

         Dim lngPlanId As Long = ListPosition(cboPlanAct)
         Dim boolTieneAnaAdd As Long
         Dim lngSucCCO As Long = TieneSucCCO(lngPlanId, boolTieneAnaAdd)

         If boolTieneAnaAdd Then
            Call cboPlanAddActLoad(lngPlanId)
            cboPlanAddAct.SelectedIndex = -1
            cboPlanAddAct.Text = ""
            cboPlanAddAct.Enabled = True

         Else
            cboPlanAddAct.Items.Clear()
            cboPlanAddAct.SelectedIndex = -1
            cboPlanAddAct.Text = ""
            cboPlanAddAct.Enabled = False
         End If

         If Not clsAppInfo.CentroCostoApli Then
           If lngSucCCO = 2 Then
               'cboSucursalAct.SelectedIndex = -1
               'cboSucursalAct.Enabled = False
               'cboSucursalAct.Text = ""
               cboCentroCostoAct.SelectedIndex = -1
               cboCentroCostoAct.Enabled = True
               cboCentroCostoAct.Text = ""
               cboCentroCostoDetAct.SelectedIndex = -1
               cboCentroCostoDetAct.Enabled = False
               cboCentroCostoDetAct.Text = ""

            Else
               'cboSucursalAct.SelectedIndex = -1
               'cboSucursalAct.Enabled = False
               'cboSucursalAct.Text = ""
               cboCentroCostoAct.SelectedIndex = -1
               cboCentroCostoAct.Enabled = False
               cboCentroCostoAct.Text = ""
               cboCentroCostoDetAct.SelectedIndex = -1
               cboCentroCostoDetAct.Enabled = False
               cboCentroCostoDetAct.Text = ""
            End If
         Else

            'If lngSucCCO = 1 Then
            '   cboSucursalAct.SelectedIndex = -1
            '   cboSucursalAct.Enabled = True
            '   cboSucursalAct.Text = ""

            'ElseIf lngSucCCO = 2 Then
            '   cboSucursalAct.SelectedIndex = -1
            '   cboSucursalAct.Enabled = False
            '   cboSucursalAct.Text = ""

            'End If
         End If

      End If
   End Sub

   Private Sub chkPlanAct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlan.CheckedChanged
      If chkPlan.Checked Then
         cboPlanAct.DisplayMember = "PlanDes"
      Else
         cboPlanAct.DisplayMember = "PlanCta"
      End If
   End Sub

   Private Sub cboCentroCostoAct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroCostoAct.SelectedIndexChanged
      If cboCentroCostoAct.Tag <> cboCentroCostoAct.Text Then
         cboCentroCostoAct.Tag = cboCentroCostoAct.Text
         cboCentroCostoDetAct.Text = ""

         Call cboCentroCostoDetActLoad(ListPosition(cboCentroCostoAct, cboCentroCostoAct.SelectedIndex))

         If cboCentroCostoDetAct.Items.Count > 0 Then
            cboCentroCostoDetAct.Enabled = True
         Else
            cboCentroCostoDetAct.Enabled = False
         End If
      End If
   End Sub

   Private Function PlanIdActFind(ByVal lngItemId As Long, ByRef lngPlanIdCos As Long, ByRef lngPlanIdIng As Long) As Long
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim oPlanGrupo As New clsPlanGrupo(clsAppInfo.ConnectString)

      PlanIdActFind = 0

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               With oPlanGrupo
                  .PlanGrupoId = oItem.PlanGrupoId

                  If .FindByPK Then
                     lngPlanIdCos = .PlanIdCos
                     lngPlanIdIng = .PlanIdIng
                     Return .PlanIdAct
                  End If
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()
         oPlanGrupo.Dispose()

      End Try
   End Function

#End Region

#Region "ItemCosto"

   'Metodo que carga la grilla los ultimos costo de item vendido
   Private Sub grdCostoItemLoad(ByVal lngItemId As Long)
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      Try
         With oCompraDet
            .SelectFilter = clsCompraDet.SelectFilters.ProveedorUPC
            .WhereFilter = clsCompraDet.WhereFilters.ProveedorUPC
            .OrderByFilter = clsCompraDet.OrderByFilters.FechaDESC
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .ItemId = lngItemId
            .AlmacenId = moCompraDet.AlmacenId
            .ProveedorId = moCompraDet.ProveedorId
            '.CompraId = mlngTipoPagoId
            '.TipoCompraId = moCompraDet.TipoCompraId

            If .Open Then
               grdItemCosto.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdItemCosto.RetrieveStructure()
               Call grdMainInitCosto()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try

   End Sub

   Private Sub DataShow()
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         If (grdItemCosto.GetRow.Selected) And (ToLong(grdItemCosto.GetValue("CompraId")) > 0) Then
            With oCompra
               .CompraId = ToLong(grdItemCosto.GetValue("CompraId"))

               If .FindByPK Then
                  Dim frm As New frmCompraEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oCompra

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Sub grdMainInitCosto()
      With grdItemCosto

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 70
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoPagoId").Visible = False

         .RootTable.Columns("TipoPagoDes").Caption = "Forma"
         .RootTable.Columns("TipoPagoDes").Width = 60
         .RootTable.Columns("TipoPagoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoPagoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 70
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 80
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cant."
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 60
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioOrg").Caption = "Precio"
         .RootTable.Columns("PrecioOrg").FormatString = DecimalMask()
         .RootTable.Columns("PrecioOrg").Width = 60
         .RootTable.Columns("PrecioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With
   End Sub

   Private Sub grdItemCosto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdItemCosto.DoubleClick
      Call DataShow()
   End Sub

#End Region

   Private Sub txtMontoRec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoRec.KeyUp
      If txtMontoRec.ContainsFocus Then
         If ToDecimal(txtMontoRec.Text) <> ToDecimal(txtMontoRec.Tag) Then
            If (ToDecimal(txtImporte.Text) = 0) Then
               txtPorcentajeRec.Text = 0
               txtMontoRec.Text = 0
            Else
               txtPorcentajeRec.Text = ToDecStr((ToDecimal(txtMontoRec.Text) * 100) / ToDivByCero(txtImporte.Text))
               txtPorcentajeRec.Tag = ToDecimal(txtPorcentajeRec.Text)
            End If
            txtMontoRec.Tag = txtMontoRec.Text
         End If
      End If
   End Sub

   Private Sub txtPorcentajeRec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPorcentajeRec.KeyUp
      If txtPorcentajeRec.ContainsFocus Then
         If ToDecimal(txtPorcentajeRec.Text) <> ToDecimal(txtPorcentajeRec.Tag) Then
            If (ToDecimal(txtImporte.Text) = 0) Then
               txtPorcentajeRec.Text = 0
               txtMontoRec.Text = 0
            Else
               txtMontoRec.Text = ToDecStr(ToDecimal(txtPorcentajeRec.Text) * ToDouble(txtImporte.Text) / 100)
               txtMontoRec.Tag = ToDecimal(txtMontoRec.Text)
            End If
            txtPorcentajeRec.Tag = txtPorcentajeRec.Text
         End If
      End If
   End Sub

   Private Sub txtMontoDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoDes.KeyUp
      If txtMontoDes.ContainsFocus Then
         If ToDecimal(txtMontoDes.Text) <> ToDecimal(txtMontoDes.Tag) Then
            If (ToDecimal(txtImporte.Text) = 0) Then
               txtPorcentajeDes.Text = 0
               txtMontoDes.Text = 0
            Else
               txtPorcentajeDes.Text = ToDecStr((ToDecimal(txtMontoDes.Text) * 100) / ToDivByCero(txtImporte.Text))
               txtPorcentajeDes.Tag = txtPorcentajeDes.Text
            End If
            txtMontoDes.Tag = txtMontoDes.Text
         End If
      End If
   End Sub

   Private Sub txtPorcentajeDes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPorcentajeDes.KeyUp

      If txtPorcentajeDes.ContainsFocus Then
         If ToDecimal(txtPorcentajeDes.Text) <> ToDecimal(txtPorcentajeDes.Tag) Then
            If (ToDecimal(txtImporte.Text) = 0) Then
               txtPorcentajeDes.Text = 0
               txtMontoDes.Text = 0
            Else
               txtMontoDes.Text = ToDecStr((ToDecimal(txtPorcentajeDes.Text) * ToDouble(txtImporte.Text)) / 100)
               txtMontoDes.Tag = txtMontoDes.Text
            End If
            txtPorcentajeDes.Tag = txtPorcentajeDes.Text
         End If
      End If
   End Sub

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

   Private Sub frmCompraDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then

         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moCompraDet.ItemId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()

         ElseIf (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If mnuItemLoteNew.Enabled Then
               Call tabMainPanel(tabMain.SelectedTab.Key(), "New")
            End If

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            If mnuItemLoteEdit.Enabled Then
               Call tabMainPanel(tabMain.SelectedTab.Key(), "Edit")
            End If

         ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            If mnuItemLoteDelete.Enabled Then
               Call tabMainPanel(tabMain.SelectedTab.Key(), "Delete")
            End If
         End If
      End If
   End Sub

   Private Sub frmCompraDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompraDet.Dispose()
      Call ClearMemory()
   End Sub

   
End Class

