Public Class frmCompra
   Inherits System.Windows.Forms.Form

   Private moCompra As clsCompra
   Private mlngEmpresaId As Long

   Private mboolFind As Boolean
   Private mlngTipoPagoId As Long
   Private mboolChanged As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
   Friend WithEvents lblMaxReg As System.Windows.Forms.Label
   Friend WithEvents txtMaxReg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents FacturaDif1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FacturaDif As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Duplicate As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Duplicate1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator10 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator11 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Duplicate2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Duplicate3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator12 As Janus.Windows.UI.CommandBars.UICommand
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

   Property TipoPagoId() As Long
      Get
         Return mlngTipoPagoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoPagoId = Value
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
   Friend WithEvents PrintSelected As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompra))
      Dim ExplorerBarGroup5 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
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
      Me.FacturaDif1 = New Janus.Windows.UI.CommandBars.UICommand("FacturaDif")
      Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Check1 = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
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
      Me.PrintSelected = New Janus.Windows.UI.CommandBars.UICommand("PrintSelected")
      Me.Check = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.FacturaDif = New Janus.Windows.UI.CommandBars.UICommand("FacturaDif")
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
      Me.mnuDelete = New System.Windows.Forms.MenuItem
      Me.Duplicate = New Janus.Windows.UI.CommandBars.UICommand("Duplicate")
      Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Duplicate1 = New Janus.Windows.UI.CommandBars.UICommand("Duplicate")
      Me.Separator10 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator11 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Duplicate2 = New Janus.Windows.UI.CommandBars.UICommand("Duplicate")
      Me.Duplicate3 = New Janus.Windows.UI.CommandBars.UICommand("Duplicate")
      Me.Separator12 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
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
      Me.ilsMain.Images.SetKeyName(8, "")
      Me.ilsMain.Images.SetKeyName(9, "Docx.ico")
      Me.ilsMain.Images.SetKeyName(10, "Copy.ico")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New3, Me.Edit2, Me.Delete2, Me.ViewAll2, Me.Print2, Me.Exit3, Me.PrintSelected, Me.Check, Me.Refrescar, Me.FacturaDif, Me.Duplicate})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New1, Me.Separator1, Me.Edit1, Me.Separator2, Me.Duplicate3, Me.Separator12, Me.FacturaDif1, Me.Separator8, Me.Check1, Me.Separator6, Me.Refrescar1, Me.Separator7, Me.ViewAll1, Me.Separator4, Me.Print1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(752, 28)
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
      'FacturaDif1
      '
      Me.FacturaDif1.Key = "FacturaDif"
      Me.FacturaDif1.Name = "FacturaDif1"
      '
      'Separator8
      '
      Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator8.Key = "Separator"
      Me.Separator8.Name = "Separator8"
      '
      'Check1
      '
      Me.Check1.Key = "Check"
      Me.Check1.Name = "Check1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
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
      'PrintSelected
      '
      Me.PrintSelected.ImageIndex = 6
      Me.PrintSelected.Key = "PrintSelected"
      Me.PrintSelected.Name = "PrintSelected"
      Me.PrintSelected.Text = "Imprimir Selección"
      '
      'Check
      '
      Me.Check.ImageIndex = 7
      Me.Check.Key = "Check"
      Me.Check.Name = "Check"
      Me.Check.Text = "Seleccionar"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 8
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'FacturaDif
      '
      Me.FacturaDif.ImageIndex = 9
      Me.FacturaDif.Key = "FacturaDif"
      Me.FacturaDif.Name = "FacturaDif"
      Me.FacturaDif.Text = "Facturación Dif."
      Me.FacturaDif.ToolTipText = "Aplicar/Quitar Facturación Diferida"
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
      ExplorerBarGroup5.Container = True
      ExplorerBarGroup5.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup5.ContainerHeight = 371
      ExplorerBarGroup5.Expandable = False
      ExplorerBarGroup5.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup5})
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
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuNew, Me.mnuEdit, Me.mnuDelete})
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
      'Duplicate
      '
      Me.Duplicate.ImageIndex = 10
      Me.Duplicate.Key = "Duplicate"
      Me.Duplicate.Name = "Duplicate"
      Me.Duplicate.Text = "Duplicar"
      '
      'Separator9
      '
      Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator9.Key = "Separator"
      Me.Separator9.Name = "Separator9"
      '
      'Duplicate1
      '
      Me.Duplicate1.Key = "Duplicate"
      Me.Duplicate1.Name = "Duplicate1"
      '
      'Separator10
      '
      Me.Separator10.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator10.Key = "Separator"
      Me.Separator10.Name = "Separator10"
      '
      'Separator11
      '
      Me.Separator11.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator11.Key = "Separator"
      Me.Separator11.Name = "Separator11"
      '
      'Duplicate2
      '
      Me.Duplicate2.Key = "Duplicate"
      Me.Duplicate2.Name = "Duplicate2"
      '
      'Duplicate3
      '
      Me.Duplicate3.Key = "Duplicate"
      Me.Duplicate3.Name = "Duplicate3"
      '
      'Separator12
      '
      Me.Separator12.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator12.Key = "Separator"
      Me.Separator12.Name = "Separator12"
      '
      'frmCompra
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCompra"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Notas de Compra"
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

         Case "Duplicate"
            Call FormDuplicate()

         Case "FacturaDif"
            Call FormAplicarQuitarFacturaDif()

         Case "Check"
            Call RecordSelected()

         Case "Refrescar"
            Call grdMainLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "PrintSelected"
            Call PrintReportAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()

      mnuDelete.Visible = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()
      Try
         With moCompra
            .SelectFilter = clsCompra.SelectFilters.Grid

            If Not mboolFind Then
               .WhereFilter = clsCompra.WhereFilters.Grid
               .RowsMax = ToLong(txtMaxReg.Text)

               cdmMain.Commands.Item("Check").Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Check").Visible = Janus.Windows.UI.InheritableBoolean.False
            Else
               If mlngTipoPagoId = 3 Then
                  .WhereFilter = clsCompra.WhereFilters.GridDevCompra
                  .CreditoId = 14 'Venta Programada
                  .EstadoId = 15 'Venta Realizada
               Else
                  .WhereFilter = clsCompra.WhereFilters.GridCredito
                  .TipoPagoId = 2 'Credito
                  .CreditoId = 0 'Compra al Credito sin Plan de pagos
                  .EstadoId = 13 'Pendiente
               End If

               cdmMain.Commands.Item("New").Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Edit").Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Duplicate").Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("FacturaDif").Enabled = Janus.Windows.UI.InheritableBoolean.False

               cdmMain.Commands.Item("New").Visible = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Edit").Visible = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Delete").Visible = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Duplicate").Visible = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("FacturaDif").Visible = Janus.Windows.UI.InheritableBoolean.False

            End If

            .OrderByFilter = clsCompra.OrderByFilters.Grid
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId

            If .Open() Then
               Dim tblCompraPedidosNros As Hashtable = getNrosPedidos()
               Dim tblDifFacturaNros As Hashtable = getNrosFacturasDif()

               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows

                  If (tblCompraPedidosNros.Count > 0) Then
                     oRow("PedCompraNro") = ToStr(tblCompraPedidosNros.Item(ToLong(oRow("CompraId"))))
                  End If

                  ''Facturas
                  If (tblDifFacturaNros.Count > 0) And (ToLong(oRow("FacturaId")) = 0) And ToBoolean(oRow("FacturaDif")) Then
                     oRow("FacturaNros") = ToStr(tblDifFacturaNros.Item(ToLong(oRow("CompraId")))).Trim
                     oRow("FacturaNros") &= IIf(ToStr(oRow("FacturaNros")) = String.Empty, "0", "")
                  Else
                     oRow("FacturaNros") = ToStr(oRow("FacturaNro"))
                  End If
                  ''If ToLong(oRow("TipoRetencionId")) > 0 Then
                  ''   oRow("MontoRetencion") = getCalculoRetencion(ToLong(oRow("TipoRetencionId")), ToDecimal(oRow("MontoBru")), ToLong(oRow("MonedaId")), ToDecimal(oRow("TipoCambio")))
                  ''End If
               Next

               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataShow()
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("CompraId")) > 0) Then
            With oCompra
               .CompraId = ToLong(grdMain.GetValue("CompraId"))

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

   Private Sub FormNew()
      Dim frm As New frmCompraEdit
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oCompra.EmpresaId = mlngEmpresaId
            oCompra.GestionId = clsAppInfo.GestionId
            oCompra.AppId = clsAppInfo.AppId
            oCompra.EstadoId = 13

            oCompra.Fecha = FechaServidor()
            oCompra.MonedaId = ToLong(clsAppInfo.MonedaId)

            .DataObject = oCompra
            .ShowDialog()

            If .Changed Then
               Call .printCompraReport()
               Call grdMainLoad()
               grdMain.Select()

            ElseIf frm.ID > 0 Then
               Call CompraDelete(frm.ID)
            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Sub DataEdit()
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If (ToLong(grdMain.GetValue("CompraId")) > 0) Then
               If (ToLong(grdMain.GetValue("EstadoId")) = 13) _
               Or ((ToLong(grdMain.GetValue("EstadoId")) = 14) And (grdMain.GetValue("MontoOrg") + grdMain.GetValue("MontoRec") - grdMain.GetValue("MontoDes")) = grdMain.GetValue("MontoAnt")) Then

                  If Not isDevolucionCompra(ToLong(grdMain.GetValue("CompraId"))) Then
                     With oCompra
                        .CompraId = ToLong(grdMain.GetValue("CompraId"))

                        If .FindByPK Then
                           Dim frm As New frmCompraEdit

                           frm.NewRecord = False
                           frm.Editing = True
                           frm.DataObject = oCompra
                           frm.ShowDialog()

                           If frm.Changed Then
                              Call frm.printCompraReport()
                              Call grdMainLoad()
                              Call grdMainFindRow(frm.ID)

                           End If
                           frm.Dispose()
                        End If
                     End With
                  Else
                     MessageBox.Show("Imposible Editar la Compra con Devoluciones Realizadas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If

               Else
                  MessageBox.Show("Imposible Editar la Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
         oCompra.Dispose()

      End Try
   End Sub

   Private Sub FormDuplicate()
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim oCompraClone As New clsCompra(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If (ToLong(grdMain.GetValue("CompraId")) > 0) Then
               With oCompra
                  .CompraId = ToLong(grdMain.GetValue("CompraId"))

                  If .FindByPK Then
                     Dim frm As New frmCompraEdit

                     oCompraClone.EmpresaId = mlngEmpresaId
                     oCompraClone.GestionId = clsAppInfo.GestionId
                     oCompraClone.AppId = clsAppInfo.AppId
                     oCompraClone.EstadoId = 13
                     oCompraClone.Fecha = FechaServidor()

                     frm.NewRecord = True
                     frm.Editing = False
                     frm.Duplicate = True

                     frm.DataObject = oCompraClone
                     frm.CompraIdDuplicate = oCompra.CompraId
                     frm.ShowDialog()

                     If frm.Changed Then

                        frm.printCompraReport()
                        Call grdMainLoad()
                        Call grdMainFindRow(frm.ID)
                        'grdMain.Select()

                     ElseIf frm.ID > 0 Then
                        Call CompraDelete(frm.ID)
                     End If

                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar la Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()
         oCompraClone.Dispose()

      End Try
   End Sub

   Private Sub FormAplicarQuitarFacturaDif()
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If (ToLong(grdMain.GetValue("CompraId")) > 0) Then
               If (ToLong(grdMain.GetValue("EstadoId")) <> 12) Then
                  If (ToLong(grdMain.GetValue("FacturaId")) = 0) Then
                     If (ToLong(grdMain.GetValue("TipoRetencionId")) = 0) Then

                        With oCompra
                           .CompraId = ToLong(grdMain.GetValue("CompraId"))

                           If .FindByPK Then
                              Dim frm As New frmAplicarQuitarFacturaDif

                              frm.NewRecord = False
                              frm.Editing = True
                              frm.DataObject = oCompra
                              frm.ShowDialog()

                              If frm.Changed Then
                                 Call grdMainLoad()
                                 Call grdMainFindRow(frm.ID)

                              End If
                              frm.Dispose()
                           End If
                        End With
                     Else
                        MessageBox.Show("Imposible Aplicar/Quitar Factura Diferida, Debido a que ya Existe un Tipo de Retención Para esta Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If

                  Else
                     MessageBox.Show("Imposible Aplicar/Quitar Factura Diferida, Debido a que ya Existe una Factura Para esta Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If

               Else
                  MessageBox.Show("Imposible Aplicar/Quitar Factura Diferida a la Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Debe Seleccionar la Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Else
            MessageBox.Show("Debe Seleccionar la Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   'Metodo que verifica si la compra tiene Devolucion
   Private Function isDevolucionCompra(ByVal lngCompraId As Long) As Boolean
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)
      Try
         With oCompraDet
            .DeleteFilter = clsCompraDet.SelectFilters.All
            .WhereFilter = clsCompraDet.WhereFilters.CompraConDevCompra
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .CompraId = lngCompraId
            If .Find Then
               isDevolucionCompra = True
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()
      End Try
   End Function

   Private Sub DataDelete()
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If ToLong(grdMain.GetValue("CompraNro")) = 0 Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  With oCompra
                     .WhereFilter = clsCompra.WhereFilters.PrimaryKey
                     .CompraId = ToLong(grdMain.GetValue("CompraId"))

                     If .Delete Then
                        .CloseConection()
                        Call grdMainLoad()
                     End If
                  End With
               End If
            Else
               MessageBox.Show("No se puede Eliminar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Sub

   Private Function CompraDelete(ByVal lngCompraId As Long) As Boolean
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)

      CompraDelete = False

      Try
         With oCompra
            .CompraId = lngCompraId

            If .FindByPK Then
               Call CompraDetDelete(lngCompraId)
               Call CompraRecargoDelete(lngCompraId)
               Call CompraDescuentoDelete(lngCompraId)
               Call CompraOtroCostoDelete(lngCompraId)
               Call ProrrateoDelete(lngCompraId)
               Call FacturaDelete(.FacturaId)
               Call PolizaDelete(.PolizaId)

               Return .Delete
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
   End Function

   Private Function CompraDetDelete(ByVal lngCompraId As Long) As Boolean
      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      Try
         With oCompraDet
            .WhereFilter = clsCompraDet.WhereFilters.CompraId
            .EmpresaId = mlngEmpresaId
            .CompraId = lngCompraId
            Return .Delete
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try
   End Function

   Private Function CompraRecargoDelete(ByVal lngCompraId As Long) As Boolean
      Dim oCompraRecargo As New clsCompraRecargo(clsAppInfo.ConnectString)

      Try
         With oCompraRecargo
            .WhereFilter = clsCompraRecargo.WhereFilters.CompraId
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .CompraId = lngCompraId
            Return .Delete
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraRecargo.Dispose()

      End Try
   End Function

   Private Function CompraDescuentoDelete(ByVal lngCompraId As Long) As Boolean
      Dim oCompraDescuento As New clsCompraDescuento(clsAppInfo.ConnectString)

      Try
         With oCompraDescuento
            .WhereFilter = clsCompraDescuento.WhereFilters.CompraId
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .CompraId = lngCompraId
            Return .Delete
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDescuento.Dispose()

      End Try
   End Function

   Private Function CompraOtroCostoDelete(ByVal lngCompraId As Long) As Boolean
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)

      Try
         With oCompraOtroCosto
            .WhereFilter = clsCompraOtroCosto.WhereFilters.CompraId
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .CompraId = lngCompraId
            Return .Delete
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraOtroCosto.Dispose()

      End Try
   End Function

   Private Function ProrrateoDelete(ByVal lngCompraId As Long) As Boolean
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      Try
         With oProrrateo
            .WhereFilter = clsProrrateo.WhereFilters.CompraId
            .EmpresaId = mlngEmpresaId
            .CompraId = lngCompraId
            Return .Delete
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo.Dispose()

      End Try
   End Function

   Private Function FacturaDelete(ByVal lngFacturaId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               Return .Delete
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function PolizaDelete(ByVal lngPolizaId As Long) As Boolean
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      Try
         With oPoliza
            .PolizaId = lngPolizaId

            If .FindByPK Then
               Return .Delete
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza.Dispose()

      End Try
   End Function

   Private Function getNrosPedidos() As Hashtable
      Dim oCompraPedido As New clsCompraPedidoDet(clsAppInfo.ConnectString)
      Dim tblCompra As New Hashtable
      Dim tblPedido As New Hashtable
      Dim tblPedComprasNros As New Hashtable
      Dim nros As String

      With oCompraPedido
         .SelectFilter = clsCompraPedidoDet.SelectFilters.PEDIDO_Compra
         .WhereFilter = clsCompraPedidoDet.WhereFilters.PEDIDO_Compra
         .EmpresaId = clsAppInfo.EmpresaId
         .GestionId = clsAppInfo.GestionId

         If (.Open) Then
            For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
               If ((tblCompra.Contains(ToLong(oRow("CompraId"))))) Then

                  tblPedido = tblCompra.Item(ToLong(oRow("CompraId")))
                  If Not (tblPedido.Contains(ToLong(oRow("PedCompraId")))) Then
                     tblPedido.Add(ToLong(oRow("PedCompraId")), oRow("PedCompraNro"))
                     nros = ToStr(tblPedComprasNros.Item(ToLong(oRow("CompraId")))) + "; " + ToStr(oRow("PedCompraNro"))
                     tblPedComprasNros.Item(ToLong(oRow("CompraId"))) = nros
                  End If
               Else
                  tblPedido = New Hashtable
                  tblPedido.Add(ToLong(oRow("PedCompraId")), oRow("PedCompraNro"))
                  tblCompra.Add(ToLong(oRow("CompraId")), tblPedido)
                  tblPedComprasNros.Add(ToLong(oRow("CompraId")), ToLong(oRow("PedCompraNro")))
               End If
            Next

            .CloseConection()
         End If
      End With

      Return tblPedComprasNros

   End Function

   Private Function getNrosFacturasDif() As Hashtable
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)
      Dim tblCompra As New Hashtable
      Dim tblFactura As New Hashtable
      Dim tblFacturasNros As New Hashtable

      Dim nros As String

      With oCompraFac
         .SelectFilter = clsCompraFac.SelectFilters.NRO_FACTURA_COMPRA
         .WhereFilter = clsCompraFac.WhereFilters.NRO_FACTURA_COMPRA
         .EmpresaId = clsAppInfo.EmpresaId
         .GestionId = clsAppInfo.GestionId

         If (.Open) Then
            For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
               If ((tblCompra.Contains(ToLong(oRow("CompraId"))))) Then

                  tblFactura = tblCompra.Item(ToLong(oRow("CompraId")))
                  If Not (tblFactura.Contains(ToLong(oRow("FacturaId")))) Then
                     tblFactura.Add(ToLong(oRow("FacturaId")), oRow("FacturaNro"))
                     nros = ToStr(tblFacturasNros.Item(ToLong(oRow("CompraId")))) + "; " + ToStr(oRow("FacturaNro"))
                     tblFacturasNros.Item(ToLong(oRow("CompraId"))) = nros
                  End If
               Else
                  tblFactura = New Hashtable
                  tblFactura.Add(ToLong(oRow("FacturaId")), oRow("FacturaNro"))
                  tblCompra.Add(ToLong(oRow("CompraId")), tblFactura)
                  tblFacturasNros.Add(ToLong(oRow("CompraId")), ToLong(oRow("FacturaNro")))
               End If
            Next

            .CloseConection()
         End If
      End With

      Return tblFacturasNros

   End Function

   Private Function getCalculoRetencion(ByVal lngTipoRetencionId As Long, ByVal decMontoBru As Decimal, ByVal lngMonedaId As Long, ByVal decTipoCambio As Decimal) As Decimal

      Dim decIUEBs As Decimal = 0
      Dim decIUEUs As Decimal = 0
      Dim decIUEOrg As Decimal = 0

      Dim decITBs As Decimal = 0
      Dim decITUs As Decimal = 0
      Dim decITOrg As Decimal = 0

      Dim decRetencionIUE_ITBs As Decimal = 0
      Dim decRetencionIUE_ITUs As Decimal = 0

      Dim decPorcentajeRet As Decimal

      If lngTipoRetencionId = 1 Then
         'Por Servicios Asume Empresa
         decPorcentajeRet = 1 - clsAppInfo.IUE_Servicios - clsAppInfo.IT '' 0.845

         If lngMonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(decMontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((decMontoBru / decTipoCambio) / decPorcentajeRet)

            getCalculoRetencion = decRetencionIUE_ITBs - decMontoBru

         ElseIf lngMonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((decMontoBru * decTipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(decMontoBru / decPorcentajeRet)

            getCalculoRetencion = decRetencionIUE_ITUs - decMontoBru
         End If

      ElseIf lngTipoRetencionId = 2 Then
         'Por Bienes Asume Empresa

         decPorcentajeRet = 1 - clsAppInfo.IUE_Bienes - clsAppInfo.IT '' 0.92

         If lngMonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(decMontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((decMontoBru / decTipoCambio) / decPorcentajeRet)

            getCalculoRetencion = decRetencionIUE_ITBs - decMontoBru

         ElseIf lngMonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((decMontoBru * decTipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(decMontoBru / decPorcentajeRet)

            getCalculoRetencion = decRetencionIUE_ITUs - decMontoBru
         End If

      ElseIf lngTipoRetencionId = 3 Then
         'Por Alquiler Asume Empresa

         decPorcentajeRet = 1 - clsAppInfo.IT - clsAppInfo.IVA '' 0.84

         If lngMonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(decMontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((decMontoBru / decTipoCambio) / decPorcentajeRet)

            getCalculoRetencion = decRetencionIUE_ITBs - decMontoBru

         ElseIf lngMonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((decMontoBru * decTipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(decMontoBru / decPorcentajeRet)

            getCalculoRetencion = decRetencionIUE_ITUs - decMontoBru
         End If

         '' Son Retenciones q Asume Proveedor
      ElseIf lngTipoRetencionId = 4 Then
         'Por Servicios Asume Provedor
         If lngMonedaId = 1 Then

            decIUEBs = ToDecimal(decMontoBru * clsAppInfo.IUE_Servicios)
            decIUEUs = ToDecimal((decMontoBru / decTipoCambio) * clsAppInfo.IUE_Servicios)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(decMontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((decMontoBru / decTipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            getCalculoRetencion = decIUEBs + decITBs

         ElseIf lngMonedaId = 2 Then

            decIUEBs = ToDecimal((decMontoBru * decTipoCambio) * clsAppInfo.IUE_Servicios)
            decIUEUs = ToDecimal(decMontoBru * clsAppInfo.IUE_Servicios)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((decMontoBru * decTipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(decMontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            getCalculoRetencion = decIUEUs + decITUs
         End If

      ElseIf lngTipoRetencionId = 5 Then
         'Por Bienes Asume Provedor
         If lngMonedaId = 1 Then

            decIUEBs = ToDecimal(decMontoBru * clsAppInfo.IUE_Bienes)
            decIUEUs = ToDecimal((decMontoBru / decTipoCambio) * clsAppInfo.IUE_Bienes)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(decMontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((decMontoBru / decTipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            getCalculoRetencion = decIUEBs + decITBs

         ElseIf lngMonedaId = 2 Then

            decIUEBs = ToDecimal((decMontoBru * decTipoCambio) * clsAppInfo.IUE_Bienes)
            decIUEUs = ToDecimal(decMontoBru * clsAppInfo.IUE_Bienes)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((decMontoBru * decTipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(decMontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            getCalculoRetencion = decIUEUs + decITUs
         End If

      ElseIf lngTipoRetencionId = 6 Then
         'Por Bienes Asume Provedor
         If lngMonedaId = 1 Then

            decIUEBs = ToDecimal(decMontoBru * clsAppInfo.IVA)
            decIUEUs = ToDecimal((decMontoBru / decTipoCambio) * clsAppInfo.IVA)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(decMontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((decMontoBru / decTipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            getCalculoRetencion = decIUEBs + decITBs

         ElseIf lngMonedaId = 2 Then

            decIUEBs = ToDecimal((decMontoBru * decTipoCambio) * clsAppInfo.IVA)
            decIUEUs = ToDecimal(decMontoBru * clsAppInfo.IVA)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((decMontoBru * decTipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(decMontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            getCalculoRetencion = decIUEUs + decITUs
         End If

      Else
         getCalculoRetencion = 0
      End If

   End Function

   Private Sub GridDevCompra()

      Dim oCompraDet As New clsCompraDet(clsAppInfo.ConnectString)

      Dim lngCantDev As Long = 0
      Dim lngCantCompraDet As Long = 0
      Dim lngItemCant As Long = 0

      Try
         For Each oRow As DataRow In moCompra.DataSet.Tables(moCompra.TableName).Rows

            With oCompraDet
               .SelectFilter = clsCompraDet.SelectFilters.All
               .WhereFilter = clsCompraDet.WhereFilters.CompraId
               .EmpresaId = clsAppInfo.EmpresaId
               .CompraId = oRow("CompraId")

               If .Open Then

                  lngCantCompraDet = .RowCount()
                  lngItemCant = 0

                  Do While .Read

                     lngCantDev = DevCompraDetCantidadDev(.CompraId, .ItemId)

                     If .Cantidad > lngCantDev Then ' Si Existe item para devolver
                        lngItemCant += 1
                     End If

                     Call .MoveNext()
                  Loop
               End If
            End With

            If lngItemCant = 0 Then
               moCompra.DataSet.Tables(moCompra.TableName).Rows.Remove(oRow)
            End If


         Next

         grdMain.DataSource = moCompra.DataSet.Tables(moCompra.TableName).DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraDet.Dispose()

      End Try


   End Sub

   ' --  Devuelve la Canidad de devolucion que se realizaron de una Compra
   Private Function DevCompraDetCantidadDev(ByVal lngCompraId As Long, ByVal lngItemId As Long) As Decimal
      Dim oDevCompraDet As New clsDevCompraDet(clsAppInfo.ConnectString)

      Dim SumaDevolucion As Decimal = 0
      Try
         With oDevCompraDet
            .SelectFilter = clsDevCompraDet.SelectFilters.All
            .WhereFilter = clsDevCompraDet.WhereFilters.CompraItemId
            .EmpresaId = clsAppInfo.EmpresaId
            .CompraId = lngCompraId
            .ItemId = lngItemId

            If .Open() Then
               Do While .Read()
                  SumaDevolucion += .CantidadDev

                  .MoveNext()
               Loop

            End If

         End With

         Return SumaDevolucion

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oDevCompraDet.Dispose()
      End Try
   End Function

   Private Sub RecordSelected()
      If grdMain.RowCount > 0 Then
         mlngID = ToLong(grdMain.GetValue("CompraId"))
         mboolChanged = True
         Me.Close()
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptCompra

      rpt.DataSource = GetDataView(moCompra.DataSet.Tables(moCompra.TableName))

      rpt.lblTitle.Text = "Notas de Compra"
      rpt.Document.Name = "Notas de Compra"
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

   Private Sub PrintReportAll()
      'Dim rpt As New rptCompraEdit
      'Dim rptAll As New rptCompraEdit
      'Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      'Dim lngRow As Long
      'Dim i As Integer

      'Try
      '   If grdMain.SelectedRows.Count > 0 Then

      '      For Each lngRow In grdMain.SelectedRows
      '         If moCompra.DataSet.Tables(moCompra.TableName).Rows(lngRow).Item("CompraId") <> 0 Then
      '            oCompra.SelectFilter = clsCompra.SelectFilters.Report

      '            If moCompra.DataSet.Tables(moCompra.TableName).Rows(lngRow).Item("TipoCompraId") <> 4 Then
      '               oCompra.WhereFilter = clsCompra.WhereFilters.Report
      '            Else
      '               oCompra.WhereFilter = clsCompra.WhereFilters.ReportTraspaso
      '            End If

      '            oCompra.OrderByFilter = clsCompra.OrderByFilters.Report
      '            oCompra.EmpresaId = ToLong(moCompra.DataSet.Tables(moCompra.TableName).Rows(lngRow).Item("EmpresaId"))
      '            oCompra.CompraId = ToLong(moCompra.DataSet.Tables(moCompra.TableName).Rows(lngRow).Item("CompraId"))

      '            If oCompra.Find Then
      '               rpt.ds.ConnectionString = oCompra.ConnectionString
      '               rpt.ds.SQL = oCompra.SQL

      '               If oCompra.DataSet.Tables(oCompra.TableName).Rows(0).Item("TipoCompraId") = 1 Then
      '                  rpt.lblTitle.Text = "Stock Inicial"
      '                  rpt.Document.Name = "Stock Inicial"

      '                  rpt.lblAlmacenIdOrg.Text = "Al Almacén   :"
      '                  rpt.lblAlmacenIdDes.Text = ""

      '               ElseIf oCompra.DataSet.Tables(oCompra.TableName).Rows(0).Item("TipoCompraId") = 2 Then
      '                  rpt.lblTitle.Text = "Compra de Entrada"
      '                  rpt.Document.Name = "Compra de Entrada"

      '                  rpt.lblAlmacenIdOrg.Text = "Al Almacén   :"
      '                  rpt.lblAlmacenIdDes.Text = ""

      '               ElseIf oCompra.DataSet.Tables(oCompra.TableName).Rows(0).Item("TipoCompraId") = 3 Then
      '                  rpt.lblTitle.Text = "Compra de Salida"
      '                  rpt.Document.Name = "Compra de Salida"

      '                  rpt.lblAlmacenIdOrg.Text = "Al Almacén   :"
      '                  rpt.lblAlmacenIdDes.Text = ""

      '               ElseIf oCompra.DataSet.Tables(oCompra.TableName).Rows(0).Item("TipoCompraId") = 4 Then
      '                  rpt.lblTitle.Text = "Compra de Traspaso"
      '                  rpt.Document.Name = "Compra de Traspaso"

      '                  rpt.lblAlmacenIdOrg.Text = "Del Almacén :"
      '                  rpt.lblAlmacenIdDes.Text = "Al Almacén   :"
      '               End If

      '               If Dir(System.AppDomain.CurrentDomain.BaseDirectory() + clsAppInfo.EmpresaDes + ".jpg") <> "" Then
      '                  rpt.picCompany.Image = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() + clsAppInfo.EmpresaDes + ".jpg")
      '               End If

      '               rpt.lblFirma.Text = CompraParaFirma(moCompra.TipoCompraId, moCompra.GestionId)

      '               rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      '               rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      '               rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      '               rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      '               rpt.Document.Printer.DefaultPageSettings.PaperSize = rpt.Document.Printer.PaperSizes(0)

      '               rpt.Run(True)

      '               For i = 0 To rpt.Document.Pages.Count - 1
      '                  rptAll.Document.Pages.Add(rpt.Document.Pages(i))
      '               Next
      '            End If
      '         End If
      '      Next

      '      Dim frm As frmReportPreview
      '      frm = New frmReportPreview(rptAll.Document)
      '      frm.Show()
      '   Else
      '      MessageBox.Show("Seleccione al menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      '   End If

      'Catch exp As Exception
      '   MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      'Finally
      '   oCompra.Dispose()

      'End Try
   End Sub

   Private Function CompraParaFirma(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByRef strTitulo As String, ByRef lngTipoHojaId As Long) As String
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraParaFirma = ""

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moCompra.EmpresaId
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

      oCol = grdMain.RootTable.Columns("CompraId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      If Not mboolFind Then
         cdmMain.Commands.Item("Check").Visible = Janus.Windows.UI.InheritableBoolean.False
      End If

      moCompra = New clsCompra(clsAppInfo.ConnectString)

      txtMaxReg.Text = ToStr(CompraParaRowsMaxFind(clsAppInfo.EmpresaId, clsAppInfo.GestionId, 2, clsAppInfo.SucursalId))
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Notas de Compra"
         .ContextMenu = mnuMain

         If Not grdMainLayoutLoad(System.AppDomain.CurrentDomain.BaseDirectory() + "Layout\") Then

            .RootTable.Columns("CompraId").Visible = False

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

            .RootTable.Columns("CompraNro").Caption = "Número"
            .RootTable.Columns("CompraNro").Width = 100
            .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Fecha").Caption = "Fecha"
            .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
            .RootTable.Columns("Fecha").Width = 100
            .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("TipoPagoId").Visible = False

            .RootTable.Columns("TipoPagoDes").Caption = "Forma Pago"
            .RootTable.Columns("TipoPagoDes").Width = 100
            .RootTable.Columns("TipoPagoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("TipoPagoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("AlmacenId").Visible = False

            .RootTable.Columns("AlmacenDes").Caption = "Almacén"
            .RootTable.Columns("AlmacenDes").Width = 100
            .RootTable.Columns("AlmacenDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("AlmacenDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ProveedorId").Visible = False

            .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
            .RootTable.Columns("ProveedorDes").Width = 200
            .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CompraOrden").Caption = "Nro. Orden"
            .RootTable.Columns("CompraOrden").Width = 100
            .RootTable.Columns("CompraOrden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CompraOrden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CompraDes").Caption = "Descripción"
            .RootTable.Columns("CompraDes").Width = 100
            .RootTable.Columns("CompraDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CompraDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

            .RootTable.Columns("MontoOrg").Caption = "Total Nota"
            .RootTable.Columns("MontoOrg").FormatString = DecimalMask()
            .RootTable.Columns("MontoOrg").Width = 100
            .RootTable.Columns("MontoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoAnt").Caption = "Anticipo"
            .RootTable.Columns("MontoAnt").FormatString = DecimalMask()
            .RootTable.Columns("MontoAnt").Width = 100
            .RootTable.Columns("MontoAnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoAnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

            .RootTable.Columns("MontoOtro").Caption = "Otros Costos"
            .RootTable.Columns("MontoOtro").FormatString = DecimalMask()
            .RootTable.Columns("MontoOtro").Width = 100
            .RootTable.Columns("MontoOtro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoOtro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoRetencion").Caption = "Retención"
            .RootTable.Columns("MontoRetencion").FormatString = DecimalMask()
            .RootTable.Columns("MontoRetencion").Width = 100
            .RootTable.Columns("MontoRetencion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoRetencion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("MontoRetencion").Visible = False

            .RootTable.Columns("MontoBru").Caption = "Monto Bruto"
            .RootTable.Columns("MontoBru").FormatString = DecimalMask()
            .RootTable.Columns("MontoBru").Width = 100
            .RootTable.Columns("MontoBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            ''.RootTable.Columns("MontoNet").Caption = "Total Costo"  ''Antes
            .RootTable.Columns("MontoNet").Caption = "Monto Neto"
            .RootTable.Columns("MontoNet").FormatString = DecimalMask()
            .RootTable.Columns("MontoNet").Width = 100
            .RootTable.Columns("MontoNet").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoNet").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoCos").Caption = "Total Costo"
            .RootTable.Columns("MontoCos").FormatString = DecimalMask()
            .RootTable.Columns("MontoCos").Width = 100
            .RootTable.Columns("MontoCos").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoCos").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MontoLiq").Caption = "Liq. Pagable"
            .RootTable.Columns("MontoLiq").FormatString = DecimalMask()
            .RootTable.Columns("MontoLiq").Width = 100
            .RootTable.Columns("MontoLiq").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoLiq").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            ''.RootTable.Columns("PedCompraId").Visible = False

            .RootTable.Columns("PedCompraNro").Caption = "Nro Pedido"
            .RootTable.Columns("PedCompraNro").Width = 100
            .RootTable.Columns("PedCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("PedCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CreditoId").Visible = False

            .RootTable.Columns("CreditoNro").Caption = "Nro Crédito"
            .RootTable.Columns("CreditoNro").Width = 100
            .RootTable.Columns("CreditoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("CreditoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("TipoNotaId").Visible = False

            .RootTable.Columns("TipoNotaDes").Caption = "Tipo Nota"
            .RootTable.Columns("TipoNotaDes").Width = 100
            .RootTable.Columns("TipoNotaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("TipoNotaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("NotaId").Visible = False
            .RootTable.Columns("NotaNro").Caption = "Nro Nota"
            .RootTable.Columns("NotaNro").Width = 100
            .RootTable.Columns("NotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("NotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("TipoCompId").Visible = False

            .RootTable.Columns("TipoCompDes").Caption = "Tipo Comp."
            .RootTable.Columns("TipoCompDes").Width = 100
            .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CompId").Visible = False
            .RootTable.Columns("CompNro").Caption = "Nro Comp."
            .RootTable.Columns("CompNro").Width = 100
            .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            If clsAppInfo.MultipleNro Then
               .RootTable.Columns("SinFac").Caption = "I"
               .RootTable.Columns("SinFac").Width = 50
               .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

               .RootTable.Columns("ConFac").Caption = "F"
               .RootTable.Columns("ConFac").Width = 50
               .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            Else
               .RootTable.Columns("SinFac").Visible = False
               .RootTable.Columns("ConFac").Visible = False
            End If

            .RootTable.Columns("sLastUpdate_id").Caption = "Usuario"
            .RootTable.Columns("sLastUpdate_id").Width = 150
            .RootTable.Columns("sLastUpdate_id").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("sLastUpdate_id").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("FacturaDif").Caption = "Factura Dif."
            .RootTable.Columns("FacturaDif").Width = 80
            .RootTable.Columns("FacturaDif").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("FacturaDif").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("FacturaId").Visible = False
            .RootTable.Columns("FacturaNro").Caption = "Nro Factura"
            .RootTable.Columns("FacturaNro").Width = 80
            .RootTable.Columns("FacturaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("FacturaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("FacturaNro").Visible = False

            .RootTable.Columns("FacturaNros").Caption = "Nro Factura"
            .RootTable.Columns("FacturaNros").Width = 100
            .RootTable.Columns("FacturaNros").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("FacturaNros").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("TipoRetencionId").Visible = False

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

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 15)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 12)
      fc.FormatStyle.ForeColor = Color.DarkRed
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
         mnuDelete.Enabled = JanusToBooleam(cdmMain.Commands.Item("Delete").Enabled)
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call DataShow()
   End Sub

   Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
      If cdmMain.Commands.Item("New").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
         Call FormNew()
      End If
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      If cdmMain.Commands.Item("Edit").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
         Call DataEdit()
      End If

   End Sub

   Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
      Call DataDelete()
   End Sub

   Private Sub frmCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

   Private Sub frmCompra_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call grdMainLayoutSave(System.AppDomain.CurrentDomain.BaseDirectory() + "Layout")
      moCompra.Dispose()
      Call ClearMemory()
   End Sub

End Class
