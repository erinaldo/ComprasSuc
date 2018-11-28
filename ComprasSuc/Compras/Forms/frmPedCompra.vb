Public Class frmPedCompra
   Inherits System.Windows.Forms.Form

   Private moPedCompra As clsPedCompra
   Private mlngEmpresaId As Long
   Private mlngMonedaId As Long

   Private lstPedidos As New Queue()
   Private mlngProveedorId As Long
   Private mlngAlmacenId As Long

   Private mlngSucursalId As Long

   Private mboolFind As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents lblMaxReg As System.Windows.Forms.Label
   Friend WithEvents txtMaxReg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Private mlngID As Long

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property Find() As Boolean
      Get
         Return mboolFind
      End Get

      Set(ByVal Value As Boolean)
         mboolFind = Value
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

   ReadOnly Property Pedidos() As Queue
      Get
         Return lstPedidos
      End Get
   End Property

   ReadOnly Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get
   End Property

   Property ProveedorId() As Long
      Get
         Return mlngProveedorId
      End Get

      Set(ByVal Value As Long)
         mlngProveedorId = Value
      End Set
   End Property

   Property AlmacenId() As Long
      Get
         Return mlngAlmacenId
      End Get

      Set(ByVal Value As Long)
         mlngAlmacenId = Value
      End Set
   End Property

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

#Region " Código generado por el Diseñador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Diseñador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicialización después de la llamada a InitializeComponent()

   End Sub

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Diseñador de Windows Forms. 
   'No lo modifique con el editor de código.
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents New1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents New3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Check As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedCompra))
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.New1 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Edit1 = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Check1 = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New3 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit2 = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete2 = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print2 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Check = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.lblMaxReg = New System.Windows.Forms.Label
      Me.txtMaxReg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.mnuNew = New System.Windows.Forms.MenuItem
      Me.mnuEdit = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdMain)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 370)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdMain
      '
      Me.grdMain.AllowCardSizing = False
      Me.grdMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdMain.AlternatingColors = True
      Me.grdMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMain.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdMain.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdMain.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdMain.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdMain.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdMain.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdMain.GroupByBoxVisible = False
      Me.grdMain.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdMain.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdMain.Location = New System.Drawing.Point(0, 0)
      Me.grdMain.Name = "grdMain"
      Me.grdMain.RecordNavigator = True
      Me.grdMain.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdMain.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdMain.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdMain.Size = New System.Drawing.Size(728, 370)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "")
      Me.ilsMain.Images.SetKeyName(3, "")
      Me.ilsMain.Images.SetKeyName(4, "")
      Me.ilsMain.Images.SetKeyName(5, "")
      Me.ilsMain.Images.SetKeyName(6, "")
      Me.ilsMain.Images.SetKeyName(7, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New3, Me.Edit2, Me.Delete2, Me.ViewAll2, Me.Print2, Me.Exit3, Me.Check, Me.Refrescar})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("55df5f76-479b-4f4e-8e69-68c99cb73b74")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New1, Me.Separator1, Me.Edit1, Me.Separator2, Me.Check1, Me.Separator3, Me.Refrescar1, Me.Separator6, Me.ViewAll1, Me.Separator4, Me.Print1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(562, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'New1
      '
      Me.New1.Key = "New"
      Me.New1.Name = "New1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Edit1
      '
      Me.Edit1.Key = "Edit"
      Me.Edit1.Name = "Edit1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Check1
      '
      Me.Check1.Key = "Check"
      Me.Check1.Name = "Check1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'New3
      '
      Me.New3.ImageIndex = 0
      Me.New3.Key = "New"
      Me.New3.Name = "New3"
      Me.New3.Text = "Nuevo"
      '
      'Edit2
      '
      Me.Edit2.ImageIndex = 1
      Me.Edit2.Key = "Edit"
      Me.Edit2.Name = "Edit2"
      Me.Edit2.Text = "Editar"
      '
      'Delete2
      '
      Me.Delete2.ImageIndex = 2
      Me.Delete2.Key = "Delete"
      Me.Delete2.Name = "Delete2"
      Me.Delete2.Text = "Eliminar"
      '
      'ViewAll2
      '
      Me.ViewAll2.ImageIndex = 3
      Me.ViewAll2.Key = "ViewAll"
      Me.ViewAll2.Name = "ViewAll2"
      Me.ViewAll2.Text = "Ver Todos"
      '
      'Print2
      '
      Me.Print2.ImageIndex = 4
      Me.Print2.Key = "Print"
      Me.Print2.Name = "Print2"
      Me.Print2.Text = "Imprimir"
      '
      'Exit3
      '
      Me.Exit3.ImageIndex = 5
      Me.Exit3.Key = "Exit"
      Me.Exit3.Name = "Exit3"
      Me.Exit3.Text = "Salir"
      '
      'Check
      '
      Me.Check.ImageIndex = 6
      Me.Check.Key = "Check"
      Me.Check.Name = "Check"
      Me.Check.Text = "Seleccionar"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 7
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
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
      Me.TopRebar1.Controls.Add(Me.lblMaxReg)
      Me.TopRebar1.Controls.Add(Me.txtMaxReg)
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(752, 28)
      '
      'lblMaxReg
      '
      Me.lblMaxReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblMaxReg.BackColor = System.Drawing.Color.Transparent
      Me.lblMaxReg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMaxReg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblMaxReg.Location = New System.Drawing.Point(632, 8)
      Me.lblMaxReg.Name = "lblMaxReg"
      Me.lblMaxReg.Size = New System.Drawing.Size(60, 14)
      Me.lblMaxReg.TabIndex = 211
      Me.lblMaxReg.Text = "MAX REG"
      Me.lblMaxReg.TextAlign = System.Drawing.ContentAlignment.TopRight
      '
      'txtMaxReg
      '
      Me.txtMaxReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMaxReg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMaxReg.Location = New System.Drawing.Point(692, 4)
      Me.txtMaxReg.Name = "txtMaxReg"
      Me.txtMaxReg.Size = New System.Drawing.Size(48, 20)
      Me.txtMaxReg.TabIndex = 10
      Me.txtMaxReg.TabStop = False
      Me.txtMaxReg.Text = "0"
      Me.txtMaxReg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtMaxReg.Value = 0
      Me.txtMaxReg.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtMaxReg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'New2
      '
      Me.New2.ImageIndex = 0
      Me.New2.Key = "New"
      Me.New2.Name = "New2"
      Me.New2.Text = "Nuevo"
      '
      'Edit
      '
      Me.Edit.ImageIndex = 1
      Me.Edit.Key = "Edit"
      Me.Edit.Name = "Edit"
      Me.Edit.Text = "Editar"
      '
      'Delete
      '
      Me.Delete.ImageIndex = 2
      Me.Delete.Key = "Delete"
      Me.Delete.Name = "Delete"
      Me.Delete.Text = "Eliminar"
      '
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 5
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
      ExplorerBarGroup1.ContainerHeight = 371
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 403)
      Me.ebrMain.TabIndex = 2
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuNew, Me.mnuEdit})
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
      'frmPedCompra
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmPedCompra"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Pedidos de Compra"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.TopRebar1.PerformLayout()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "New"
            Call FormNew()

         Case "Edit"
            Call DataEdit()

         Case "Check"
            Call RecordSelected()

         Case "Refrescar"
            Call grdMainLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPedCompra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPedCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      If mboolFind Then
         Call grdMainColumFilter(grdMain, 1)
      End If

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()
      Try
         With moPedCompra
            If Not mboolFind Then
               .SelectFilter = clsPedCompra.SelectFilters.Grid
               .WhereFilter = clsPedCompra.WhereFilters.Grid
               .RowsMax = ToLong(txtMaxReg.Text)

               cdmMain.Commands.Item("Check").Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Check").Visible = Janus.Windows.UI.InheritableBoolean.False
            Else
               .SelectFilter = clsPedCompra.SelectFilters.GridEstadoId
               .WhereFilter = clsPedCompra.WhereFilters.GridEstadoId

               cdmMain.Commands.Item("New").Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Edit").Enabled = Janus.Windows.UI.InheritableBoolean.False

               cdmMain.Commands.Item("New").Visible = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Edit").Visible = Janus.Windows.UI.InheritableBoolean.False

               ''para ver Pedidos de Compra de Otras Gestiones que esten parciales o pendientes
               '' que faltan ser descargados
               .CentroCostoId = GestionIdFind(clsAppInfo.Gestion - 1)

            End If

            .OrderByFilter = clsPedCompra.OrderByFilters.Grid
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId

            If .Open() Then

               If mboolFind Then
                  Dim tblAnticiposNros As Hashtable = getNrosAnticipos()
                  For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                     If (tblAnticiposNros.Count > 0) Then
                        oRow("AnticipoNro") = ToStr(tblAnticiposNros.Item(ToLong(oRow("PedCompraId"))))
                     End If
                  Next
               End If

               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            If mboolFind Then
               grdMain.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
               grdMain.Select()
               grdMain.Col = 2
               grdMain.Row = grdMain.filterRowPosition
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataShow()
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("PedCompraId")) > 0) Then
            With oPedCompra
               .PedCompraId = ToLong(grdMain.GetValue("PedCompraId"))

               If .FindByPK Then
                  Dim frm As New frmPedCompraEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oPedCompra

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub FormNew()
      Dim frm As New frmPedCompraEdit
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oPedCompra.EmpresaId = mlngEmpresaId
            oPedCompra.GestionId = clsAppInfo.GestionId
            oPedCompra.Fecha = FechaServidor()
            oPedCompra.MonedaId = ToLong(clsAppInfo.MonedaId)
            oPedCompra.AppId = clsAppInfo.AppId

            .DataObject = oPedCompra
            .ShowDialog()

            If .Changed Then
               Call .printPedidoReport()
               Call grdMainLoad()
               grdMain.Select()
            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub DataEdit()
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If ToLong(grdMain.GetValue("PedCompraId")) > 0 Then
               If (ToLong(grdMain.GetValue("EstadoId")) = 13) Or (ToLong(grdMain.GetValue("EstadoId")) = 7) Or _
               (ToLong(grdMain.GetValue("EstadoId")) = clsEstado.APROBADO) Or (ToLong(grdMain.GetValue("EstadoId")) = clsEstado.REALIZADO) Then

                  With oPedCompra
                     .PedCompraId = ToLong(grdMain.GetValue("PedCompraId"))

                     If .FindByPK Then
                        'If (.EstadoId = 13) Or (.EstadoId = 7) Or (.EstadoId = clsEstado.APROBADO) Then
                        If (.EstadoId = 13) Or (.EstadoId = 7) Or (.EstadoId = clsEstado.APROBADO) Or (.EstadoId = clsEstado.REALIZADO) Then

                           Dim frm As New frmPedCompraEdit

                           frm.NewRecord = False
                           frm.Editing = True
                           frm.DataObject = oPedCompra
                           frm.ShowDialog()

                           If frm.Changed Then
                              'Call frm.printPedidoReport()
                              Call grdMainLoad()
                              Call grdMainFindRow(frm.ID)
                           End If
                           frm.Dispose()
                        Else
                           MessageBox.Show("Imposible Editar El Pedido de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     End If
                  End With
               Else
                  MessageBox.Show("Imposible Editar El Pedido de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Sub DataDelete()
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oPedCompra
                  .WhereFilter = clsPedCompra.WhereFilters.PrimaryKey
                  .PedCompraId = ToLong(grdMain.GetValue("PedCompraId"))

                  If .Delete Then
                     .CloseConection()
                     Call grdMainLoad()
                  End If
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompra.Dispose()

      End Try
   End Sub

   Private Function getNrosAnticipos() As Hashtable
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim tblPedCompra As New Hashtable
      Dim tblAnticipo As New Hashtable
      Dim tblAnticiposNros = New Hashtable

      Dim nros As String

      With oAnticipo
         .SelectFilter = clsAnticipo.SelectFilters.NRO_ANTICIPO_PEDIDO
         .WhereFilter = clsAnticipo.WhereFilters.NRO_ANTICIPO_PEDIDO
         .EmpresaId = clsAppInfo.EmpresaId
         .GestionId = clsAppInfo.GestionId

         If (.Open) Then
            For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows

               If ((tblPedCompra.Contains(ToLong(oRow("PedCompraId"))))) Then

                  tblAnticipo = tblPedCompra.Item(ToLong(oRow("PedCompraId")))
                  If Not (tblAnticipo.Contains(ToLong(oRow("AnticipoId")))) Then
                     tblAnticipo.Add(ToLong(oRow("AnticipoId")), oRow("AnticipoNro"))
                     nros = ToStr(tblAnticiposNros.Item(ToLong(oRow("PedCompraId")))) + "; " + ToStr(oRow("AnticipoNro"))
                     tblAnticiposNros.Item(ToLong(oRow("PedCompraId"))) = nros
                  End If
               Else
                  tblAnticipo = New Hashtable
                  tblAnticipo.Add(ToLong(oRow("AnticipoId")), oRow("AnticipoNro"))
                  tblPedCompra.Add(ToLong(oRow("PedCompraId")), tblAnticipo)
                  tblAnticiposNros.Add(ToLong(oRow("PedCompraId")), ToLong(oRow("AnticipoNro")))
               End If

            Next

            .CloseConection()
         End If
      End With

      Return tblAnticiposNros

   End Function

   Private Function GestionIdFind(ByVal lngGestion As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         GestionIdFind = 0

         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.Gestion
            .EmpresaId = mlngEmpresaId
            .Gestion = lngGestion
            .EstadoId = 11

            If .Find Then
               GestionIdFind = ToLong(.GestionId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Sub RecordSelected()
      If grdMain.RowCount > 0 Then
         lstPedidos.Clear()
         Dim boolPrimerPedido As Boolean
         Dim boolDifProv As Boolean
         Dim boolAnticipo As Boolean
         Dim lngProveedorId, lngAlmacenId, lngMonedaId, lngCentroCostoId, lngSucursalId As Long
         Dim strMsgCli = String.Empty, strMsgAlm As String = String.Empty
         Dim strMsgDif As String = String.Empty

         If grdMain.GetCheckedRows.Length > 0 Then

            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
               If Not (boolPrimerPedido) Then

                  lngProveedorId = ToLong(oRow.Cells("ProveedorId").Value)
                  lngAlmacenId = ToLong(oRow.Cells("AlmacenId").Value)
                  lngMonedaId = ToLong(oRow.Cells("MonedaId").Value)
                  lngCentroCostoId = ToLong(oRow.Cells("CentroCostoId").Value)
                  boolAnticipo = IIf(ToStr(oRow.Cells("AnticipoNro").Value).Trim <> String.Empty, True, False)
                  boolPrimerPedido = True


                  If lngProveedorId <> mlngProveedorId And mlngProveedorId > 0 Then
                     strMsgCli = "- Debe Seleccionar Pedidos del mismo Proveedor de la Compra" & vbCrLf
                     Exit For
                  End If

                  If lngAlmacenId <> mlngAlmacenId And mlngAlmacenId <> 0 Then
                     strMsgCli = "- Debe Seleccionar Pedidos del mismo Almacen de la Compra" & vbCrLf
                     Exit For
                  End If

                  If clsAppInfo.SucursalApli Then
                     If (lngSucursalId <> mlngSucursalId) And (mlngSucursalId <> 0) Then
                        strMsgCli = "Debe Seleccionar Pedidos de la misma Sucursal de la Venta" & vbCrLf
                        Exit For
                     End If
                  End If

                  If mlngProveedorId < 0 Then
                     boolDifProv = True
                     lngProveedorId = 0
                  End If

               Else

                  If mlngProveedorId > 0 Then

                     'If (ToLong(oRow.Cells("ProveedorId").Value) <> lngProveedorId) Then
                     '   strMsgCli &= "- Debe Seleccionar Pedidos del mismo Proveedor de la Compra" & vbCrLf
                     'End If
                     If (ToLong(oRow.Cells("ProveedorId").Value) <> lngProveedorId) And (lngProveedorId <> 0) Then
                        strMsgCli &= "- Debe Seleccionar Pedidos del mismo Proveedor de la Compra" & vbCrLf
                        lngProveedorId = 0
                     End If
                  Else

                     If (ToLong(oRow.Cells("ProveedorId").Value) <> lngProveedorId) Then
                        strMsgDif = "* Los Pedidos son de Diferentes Proveedores " & vbCrLf
                        boolDifProv = True
                        lngProveedorId = 0
                     End If

                     If (ToStr(oRow.Cells("AnticipoNro").Value).Trim <> String.Empty) Then
                        boolAnticipo = True
                     End If

                  End If

                  If (ToLong(oRow.Cells("MonedaId").Value) <> lngMonedaId) And (lngMonedaId <> 0) Then
                     strMsgAlm &= "* Los Pedidos son de diferentes Monedas" & vbCrLf
                     lngMonedaId = 0
                  End If

                  If (ToLong(oRow.Cells("AlmacenId").Value) <> lngAlmacenId) And (lngAlmacenId <> 0) Then
                     strMsgCli &= "- Los Pedidos son de diferentes Almacenes" & vbCrLf
                     lngAlmacenId = 0
                  End If

                  If clsAppInfo.CentroCostoApli Then
                     If (ToLong(oRow.Cells("CentroCostoId").Value) <> lngCentroCostoId) And (lngCentroCostoId <> 0) Then
                        strMsgCli &= "- Debe Seleccionar Pedidos de un mismo Centro de Costo" & vbCrLf
                        lngCentroCostoId = 0
                     End If
                  End If

                  If clsAppInfo.SucursalApli Then
                     If (ToLong(oRow.Cells("SucursalId").Value) <> lngSucursalId) Then
                        strMsgCli = "Debe Seleccionar Pedidos de una misma Sucursal" & vbCrLf
                     End If
                  End If

               End If

               lstPedidos.Enqueue(ToLong(oRow.Cells("PedCompraId").Value))
            Next

            If (boolDifProv And boolAnticipo) Then
               strMsgDif = "- Los Pedidos son de Diferentes Proveedores "
               strMsgCli &= strMsgDif & ", deben ser sin Anticipos " & vbCrLf
               ''MessageBox.Show("Los Pedidos son de Diferentes Proveedores " & vbCrLf & " y debe seleccionar sin Anticipos ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               ''Exit Sub
               strMsgDif = ""
            End If


            If (strMsgCli.Trim <> String.Empty) Then
               MessageBox.Show(strMsgCli + vbCrLf + strMsgDif + strMsgAlm, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Exit Sub

            ElseIf (strMsgDif + strMsgAlm) <> String.Empty Then
               If MessageBox.Show(strMsgDif + strMsgAlm & vbCrLf & "¿Quiere continuar con la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                  Exit Sub
               End If
            End If

            mlngID = ToLong(grdMain.GetValue("PedCompraId"))
            mboolChanged = True
            mlngMonedaId = lngMonedaId
            mlngProveedorId = lngProveedorId
            Me.Close()

         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptPedCompra

      rpt.DataSource = GetDataView(moPedCompra.DataSet.Tables(moPedCompra.TableName))

      rpt.lblTitle.Text = "Pedidos de Compra"
      rpt.Document.Name = "Pedidos de Compra"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As frmReportPreview
      frm = New frmReportPreview(rpt.Document)
      frm.Show()
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Function GetDataView(ByVal oDataTableOrg As DataTable) As System.Data.DataView
      If grdMain.RootTable.FilterApplied Is Nothing Then
         Return oDataTableOrg.DefaultView

      Else
         Dim oDataTable As DataTable
         Dim oRow As DataRow

         oDataTable = oDataTableOrg.Clone

         For Each oRowMain In grdMain.GetRows()
            oRow = oDataTable.NewRow

            For i = 0 To oRowMain.Cells.Count - 1
               oRow(i) = oRowMain.Cells(i).Value
            Next

            oDataTable.Rows.Add(oRow)
         Next

         Return oDataTable.DefaultView
      End If
   End Function

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PedCompraId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      If Not mboolFind Then
         cdmMain.Commands.Item("Check").Visible = Janus.Windows.UI.InheritableBoolean.False
      End If

      moPedCompra = New clsPedCompra(clsAppInfo.ConnectString)

      txtMaxReg.Text = ToStr(CompraParaRowsMaxFind(clsAppInfo.EmpresaId, clsAppInfo.GestionId, 1, clsAppInfo.SucursalId))
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Pedidos de Compra"
         .ContextMenu = mnuMain

         If Not grdMainLayoutLoad(System.AppDomain.CurrentDomain.BaseDirectory() + "Layout\") Then

            If mboolFind Then
               .RootTable.Columns("Sel").Width = 50
               .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("Sel").ActAsSelector = True
               ''Else
               ''   .RootTable.Columns("Sel").Visible = False

            End If


            .RootTable.Columns("PedCompraId").Visible = False

            .RootTable.Columns("EmpresaId").Visible = False

            If clsAppInfo.SucursalApli Then
               .RootTable.Columns("SucursalId").Visible = False
               .RootTable.Columns("SucursalDes").Caption = "Sucursal"
               .RootTable.Columns("SucursalDes").Width = 100
               .RootTable.Columns("SucursalDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
               .RootTable.Columns("SucursalDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            Else
               .RootTable.Columns("SucursalId").Visible = False
               .RootTable.Columns("SucursalDes").Visible = False
            End If

            .RootTable.Columns("PedCompraNro").Caption = "Número"
            .RootTable.Columns("PedCompraNro").Width = 100
            .RootTable.Columns("PedCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("PedCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Fecha").Caption = "Fecha"
            .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
            .RootTable.Columns("Fecha").Width = 100
            .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("FechaEnt").Caption = "Fecha Ent."
            .RootTable.Columns("FechaEnt").FormatString = "dd/MM/yyyy"
            .RootTable.Columns("FechaEnt").Width = 100
            .RootTable.Columns("FechaEnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("FechaEnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("AlmacenId").Visible = False

            .RootTable.Columns("AlmacenDes").Caption = "Almacén"
            .RootTable.Columns("AlmacenDes").Width = 100
            .RootTable.Columns("AlmacenDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("AlmacenDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ProveedorId").Visible = False

            .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
            .RootTable.Columns("ProveedorDes").Width = 100
            .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("PedCompraOrden").Caption = "Nro. Orden"
            .RootTable.Columns("PedCompraOrden").Width = 100
            .RootTable.Columns("PedCompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("PedCompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("PedCompraDes").Caption = "Descripción"
            .RootTable.Columns("PedCompraDes").Width = 120
            .RootTable.Columns("PedCompraDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("PedCompraDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MonedaId").Visible = False

            .RootTable.Columns("MonedaDes").Caption = "Moneda"
            .RootTable.Columns("MonedaDes").Width = 100
            .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
            .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
            .RootTable.Columns("TipoCambio").Width = 100
            .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("PedCompraMonto").Caption = "Monto"
            .RootTable.Columns("PedCompraMonto").FormatString = DecimalMask()
            .RootTable.Columns("PedCompraMonto").Width = 100
            .RootTable.Columns("PedCompraMonto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("PedCompraMonto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoDes").Caption = "Descuento"
            .RootTable.Columns("MontoDes").FormatString = DecimalMask()
            .RootTable.Columns("MontoDes").Width = 100
            .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoRec").Caption = "Recargo"
            .RootTable.Columns("MontoRec").FormatString = DecimalMask()
            .RootTable.Columns("MontoRec").Width = 100
            .RootTable.Columns("MontoRec").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoRec").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoLiq").Caption = "Liq. Pagable"
            .RootTable.Columns("MontoLiq").FormatString = DecimalMask()
            .RootTable.Columns("MontoLiq").Width = 100
            .RootTable.Columns("MontoLiq").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoLiq").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoEnt").Caption = "Entregado"
            .RootTable.Columns("MontoEnt").FormatString = DecimalMask()
            .RootTable.Columns("MontoEnt").Width = 100
            .RootTable.Columns("MontoEnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoEnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoPen").Caption = "Pendiente"
            .RootTable.Columns("MontoPen").FormatString = DecimalMask()
            .RootTable.Columns("MontoPen").Width = 100
            .RootTable.Columns("MontoPen").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoPen").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            If Not mboolFind Then
               .RootTable.Columns("ProveedorId").Visible = False

               .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
               .RootTable.Columns("ProveedorDes").Width = 200
               .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
               .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

               .RootTable.Columns("CompraId").Visible = False

               .RootTable.Columns("CompraNro").Caption = "Nro Compra"
               .RootTable.Columns("CompraNro").Width = 100
               .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            Else

               .RootTable.Columns("AnticipoNro").Caption = "Nro Anticipos"
               .RootTable.Columns("AnticipoNro").Width = 100
               .RootTable.Columns("AnticipoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("AnticipoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            End If

            .RootTable.Columns("sLastUpdate_id").Caption = "Usuario"
            .RootTable.Columns("sLastUpdate_id").Width = 150
            .RootTable.Columns("sLastUpdate_id").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("sLastUpdate_id").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            If clsAppInfo.CentroCostoApli Then
               .RootTable.Columns("CentroCostoId").Visible = False
               .RootTable.Columns("CentroCostoDes").Caption = "Centro Costo"
               .RootTable.Columns("CentroCostoDes").Width = 150
               .RootTable.Columns("CentroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
               .RootTable.Columns("CentroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            Else
               .RootTable.Columns("CentroCostoId").Visible = False
               .RootTable.Columns("CentroCostoDes").Visible = False
            End If

            .RootTable.Columns("AppId").Visible = False
            .RootTable.Columns("AppDes").Caption = "Módulo"
            .RootTable.Columns("AppDes").Width = 120
            .RootTable.Columns("AppDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("AppDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("TipoDocumentoId").Visible = False
            .RootTable.Columns("DocumentoId").Visible = False

            .RootTable.Columns("EstadoId").Visible = False

            .RootTable.Columns("EstadoDes").Caption = "Estado"
            .RootTable.Columns("EstadoDes").Width = 100
            .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         End If
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 12)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, clsEstado.APROBADO)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 14)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Function grdMainLayoutLoad(ByVal strLayoutPath As String) As Boolean
      grdMainLayoutLoad = False

      If Dir(strLayoutPath & Me.Name & ".gxl") <> "" Then
         Dim LayoutStream As New System.IO.FileStream(strLayoutPath & Me.Name & ".gxl", IO.FileMode.Open)

         grdMain.LoadLayoutFile(LayoutStream)
         LayoutStream.Close()

         Return True
      End If
   End Function

   Private Function grdMainLayoutSave(ByVal strLayoutPath As String) As Boolean
      grdMainLayoutSave = False

      If Dir(strLayoutPath, FileAttribute.Directory) <> "" Then
         Call DataViewAll()

         Dim stream As System.IO.FileStream = New System.IO.FileStream(strLayoutPath & "\" & Me.Name & ".gxl", IO.FileMode.Create)
         grdMain.SaveLayoutFile(stream)
         stream.Close()

         Return True
      End If
   End Function

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call DataShow()
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMain.MouseDown
      If e.Button = MouseButtons.Right Then
         mnuShow.Enabled = True
         mnuNew.Enabled = JanusToBooleam(cdmMain.Commands.Item("New").Enabled)
         mnuEdit.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
      End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         mnuShow.Enabled = True
         mnuNew.Enabled = JanusToBooleam(cdmMain.Commands.Item("New").Enabled)
         mnuEdit.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call DataShow()
   End Sub

   Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
      Call FormNew()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call DataEdit()
   End Sub

   Private Sub frmPedCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If cdmMain.Commands.Item("New").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               Call FormNew()
            End If

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Edit").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               Call DataEdit()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPedCompra_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call grdMainLayoutSave(System.AppDomain.CurrentDomain.BaseDirectory() + "Layout")
      moPedCompra.Dispose()
      Call ClearMemory()
   End Sub

End Class
