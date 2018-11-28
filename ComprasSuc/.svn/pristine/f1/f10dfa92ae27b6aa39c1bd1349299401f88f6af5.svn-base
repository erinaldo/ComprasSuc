Public Class frmProveedorPorPagarFind
   Inherits System.Windows.Forms.Form
    Private moListaProveedor As Queue

   Private moProveedor As clsProveedor
    Private mlngEmpresaId As Long

    Property EmpresaId() As Long
        Get
            Return mlngEmpresaId
        End Get

        Set(ByVal Value As Long)
            mlngEmpresaId = Value
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
    Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
    Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
    Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorPorPagarFind))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label4 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.lblCentroCosto = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.lblSucursal = New System.Windows.Forms.Label
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdMain)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 269)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 269)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(752, 414)
      Me.bcgMain.TabIndex = 163
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
      ExplorerBarGroup1.ContainerHeight = 270
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 302)
      Me.ebrMain.TabIndex = 16
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.dtpFechaIni)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 316)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(188, 92)
      Me.grpMain.TabIndex = 4
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.FirstMonth = New Date(2008, 4, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.Location = New System.Drawing.Point(56, 18)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaIni.TabIndex = 6
      Me.dtpFechaIni.Value = New Date(2013, 12, 10, 0, 0, 0, 0)
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 22)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 16)
      Me.Label4.TabIndex = 153
      Me.Label4.Text = "Desde"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.cboSucursal)
      Me.UiGroupBox2.Controls.Add(Me.lblSucursal)
      Me.UiGroupBox2.Controls.Add(Me.cboCentroCosto)
      Me.UiGroupBox2.Controls.Add(Me.lblCentroCosto)
      Me.UiGroupBox2.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox2.Controls.Add(Me.Label1)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(204, 316)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(292, 92)
      Me.UiGroupBox2.TabIndex = 7
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(76, 40)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(208, 20)
      Me.cboCentroCosto.TabIndex = 10
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.lblCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCentroCosto.Location = New System.Drawing.Point(8, 44)
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Size = New System.Drawing.Size(64, 16)
      Me.lblCentroCosto.TabIndex = 193
      Me.lblCentroCosto.Text = "C. C."
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(76, 12)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(208, 20)
      Me.cboMoneda.TabIndex = 8
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(64, 16)
      Me.Label1.TabIndex = 163
      Me.Label1.Text = "Moneda"
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll2, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("3585ee71-ff14-4ac4-8752-5d6b7253e051")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator3, Me.ViewAll1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(260, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Movimiento"
      Me.Book1.ToolTipText = "Movimiento de Proveedors"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
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
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Book
      '
      Me.Book.ImageIndex = 0
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Libro"
      '
      'ViewAll2
      '
      Me.ViewAll2.ImageIndex = 3
      Me.ViewAll2.Key = "ViewAll"
      Me.ViewAll2.Name = "ViewAll2"
      Me.ViewAll2.Text = "Ver Todos"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
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
      Me.TopRebar1.Size = New System.Drawing.Size(752, 28)
      '
      'cboSucursal
      '
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(76, 64)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(208, 20)
      Me.cboSucursal.TabIndex = 214
      Me.cboSucursal.Visible = False
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblSucursal
      '
      Me.lblSucursal.BackColor = System.Drawing.Color.Transparent
      Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblSucursal.Location = New System.Drawing.Point(8, 68)
      Me.lblSucursal.Name = "lblSucursal"
      Me.lblSucursal.Size = New System.Drawing.Size(60, 16)
      Me.lblSucursal.TabIndex = 215
      Me.lblSucursal.Text = "Sucursal"
      Me.lblSucursal.Visible = False
      '
      'frmProveedorPorPagarFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmProveedorPorPagarFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Criterios Proveedores por Cobrar"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
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
         Case "Book"
            Call frmKardexLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmProveedorPorPagarFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmProveedorPorPagarFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

        Call ComboLoad()
      Call FormInit()
        Call SecuritySet(Me, AppExeName)
        Call ViewComponent()
        Call grdMainLoad()

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

    Private Sub ComboLoad()
        Call cboMonedaLoad()
        Call cboCentroCostoLoad()
        Call cboSucursalLoad()
    End Sub

#Region " COMBOLOADS "
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

    Private Sub cboCentroCostoLoad()
        Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
        Dim oItem As clsListItem

        cboCentroCosto.Items.Clear()

        Try
            With oCentroCosto
                .SelectFilter = clsCentroCosto.SelectFilters.ListBox
                .WhereFilter = clsCentroCosto.WhereFilters.EmpresaId
                .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
                .EmpresaId = mlngEmpresaId

                If .Open() Then
                    oItem = New clsListItem(0, "(Todos)")
                    cboCentroCosto.Items.Add(oItem)

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

    Private Sub cboSucursalLoad()
        Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)
        Dim oItem As clsListItem

        cboSucursal.Items.Clear()

        Try
            With oCompraPara
                .SelectFilter = clsCompraPara.SelectFilters.SucursalListBox
                .WhereFilter = clsCompraPara.WhereFilters.SucursalListBox
                .OrderByFilter = clsCompraPara.OrderByFilters.SucursalListBox
                .EmpresaId = clsAppInfo.EmpresaId
                .GestionId = clsAppInfo.GestionId
                .TipoCompraId = clsTipoCompra.COMPRA

                If .Open() Then
                    oItem = New clsListItem(0, "(Todos)")
                    cboSucursal.Items.Add(oItem)

                    For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                        oItem = New clsListItem(oRow("SucursalId"), oRow("SucursalDes"))

                        cboSucursal.Items.Add(oItem)
                    Next

                End If
            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oCompraPara.Dispose()
            oItem = Nothing

        End Try
    End Sub
#End Region

    Private Sub FormInit()
        Call FormCenterChild(Me)

        Dim datFechaFin As Date
        Dim datFechaIni As Date = GestionFechaIni(clsAppInfo.GestionId, datFechaFin)

        dtpFechaIni.MinDate = datFechaIni
        dtpFechaIni.MaxDate = datFechaFin

        If (Now.Date > datFechaIni) And (Now.Date < datFechaFin) Then
            dtpFechaIni.Value = Now.Date
        Else
            dtpFechaIni.Value = datFechaFin
        End If

        moProveedor = New clsProveedor(clsAppInfo.ConnectString)
        dtpFechaIni.Value = ToDateDMY(Now.Date)
        cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
        cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, 0)
        cboSucursal.SelectedIndex = ListFindItem(cboSucursal, 0)
    End Sub

   Private Sub ViewComponent()
      If Not clsAppInfo.CentroCostoApli Then
         lblCentroCosto.Visible = False
         cboCentroCosto.Visible = False
      End If

      If clsAppInfo.SucursalApli Then
         lblSucursal.Visible = True
         cboSucursal.Visible = True
      Else
         lblSucursal.Visible = False
         cboSucursal.Visible = False
      End If
   End Sub

    Private Sub frmKardexLoad()
        Try
            If FormCheck() Then
                Dim frm As New frmProveedorPorPagar

                With frm
                    .EmpresaId = mlngEmpresaId
                    .GestionId = clsAppInfo.GestionId
                    .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                    .MonedaDes = ToStr(cboMoneda.Text)
                    ''.VendedorId = ListPosition(cboVendedor, cboVendedor.SelectedIndex)
                    .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
                    .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
                    '.FechaIni = ToDate(GestionFechaIni(clsAppInfo.GestionId))
                    .FechaIni = ToDate(dtpFechaIni.Value)
                    .FechaIniRep = dtpFechaIni.Value

                    .Lista = moListaProveedor
                    .MdiParent = Me.MdiParent
                    .Show()
                End With
            End If

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function FormCheck() As Boolean
        moListaProveedor = New Queue
        Dim strMsg As String = String.Empty

        For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
            If oRow.Cells("Sel").Value Then
                moListaProveedor.Enqueue(oRow.Cells("ProveedorId").Value)
            End If
        Next

        If moListaProveedor.Count = 0 Then
            strMsg &= "Seleccione al Menos un Proveedor" & vbCrLf
        End If

        If ListPosition(cboMoneda, cboMoneda.SelectedIndex) = 0 Then
            strMsg &= "Seleccione la Moneda" & vbCrLf
        End If

        If clsAppInfo.CentroCostoApli Then
            If cboCentroCosto.SelectedIndex = -1 Then
                strMsg &= "Seleccione el Centro de Costo" & vbCrLf
            End If
        End If

        If clsAppInfo.SucursalApli Then
            If cboSucursal.SelectedIndex = -1 Then
                strMsg &= "Seleccione la Sucursal" & vbCrLf
            End If
        End If

        If strMsg.Trim <> String.Empty Then
            Throw New Exception(strMsg)
            FormCheck = False
        Else
            FormCheck = True
        End If
    End Function

#Region " Grid Proveedor "
    Private Sub grdMainInit()
        With grdMain
            ebrMain.Groups(0).Text = "Proveedores"

            .RootTable.Columns("Sel").Width = 50
            .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Sel").ActAsSelector = True

            .RootTable.Columns("ProveedorId").Visible = False

            .RootTable.Columns("EmpresaId").Visible = False

            .RootTable.Columns("ProveedorCod").Caption = "Código"
            .RootTable.Columns("ProveedorCod").Width = 100
            .RootTable.Columns("ProveedorCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ProveedorCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
            .RootTable.Columns("ProveedorDes").Width = 200
            .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ProveedorNIT").Caption = "NIT"
            .RootTable.Columns("ProveedorNIT").Width = 100
            .RootTable.Columns("ProveedorNIT").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ProveedorNIT").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ContactoDes").Caption = "Contacto"
            .RootTable.Columns("ContactoDes").Width = 200
            .RootTable.Columns("ContactoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ContactoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ContactoCI").Caption = "C.I."
            .RootTable.Columns("ContactoCI").Width = 100
            .RootTable.Columns("ContactoCI").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ContactoCI").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ContactoCargo").Caption = "Cargo"
            .RootTable.Columns("ContactoCargo").Width = 100
            .RootTable.Columns("ContactoCargo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ContactoCargo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Direccion").Caption = "Dirección"
            .RootTable.Columns("Direccion").Width = 100
            .RootTable.Columns("Direccion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("Direccion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("CiudadId").Visible = False

            .RootTable.Columns("CiudadDes").Caption = "Ciudad"
            .RootTable.Columns("CiudadDes").Width = 100
            .RootTable.Columns("CiudadDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CiudadDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Telefono1").Caption = "Teléfono 1"
            .RootTable.Columns("Telefono1").Width = 100
            .RootTable.Columns("Telefono1").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("Telefono1").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Telefono2").Caption = "Teléfono 2"
            .RootTable.Columns("Telefono2").Width = 100
            .RootTable.Columns("Telefono2").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("Telefono2").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Movil").Caption = "Móvil"
            .RootTable.Columns("Movil").Width = 100
            .RootTable.Columns("Movil").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("Movil").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Fax").Caption = "Fax"
            .RootTable.Columns("Fax").Width = 100
            .RootTable.Columns("Fax").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("Fax").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Email").Caption = "Correo Electrónico"
            .RootTable.Columns("Email").Width = 100
            .RootTable.Columns("Email").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("Email").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Web").Caption = "Página Web"
            .RootTable.Columns("Web").Width = 100
            .RootTable.Columns("Web").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("Web").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MonedaId").Visible = False

            .RootTable.Columns("MonedaDes").Caption = "Moneda"
            .RootTable.Columns("MonedaDes").Width = 100
            .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ProcedenciaId").Visible = False

            .RootTable.Columns("ProcedenciaDes").Caption = "Procedencia"
            .RootTable.Columns("ProcedenciaDes").Width = 150
            .RootTable.Columns("ProcedenciaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ProcedenciaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("RubroId").Visible = False

            .RootTable.Columns("RubroDes").Caption = "Rubro"
            .RootTable.Columns("RubroDes").Width = 150
            .RootTable.Columns("RubroDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("RubroDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("BancoId").Visible = False

            .RootTable.Columns("BancoDes").Caption = "Banco"
            .RootTable.Columns("BancoDes").Width = 150
            .RootTable.Columns("BancoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("BancoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("NroCuenta").Caption = "Nro Cuenta"
            .RootTable.Columns("NroCuenta").Width = 100
            .RootTable.Columns("NroCuenta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("NroCuenta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("EstadoId").Visible = False

            .RootTable.Columns("EstadoDes").Caption = "Estado"
            .RootTable.Columns("EstadoDes").Width = 100
            .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
    End Sub

    Private Sub DataViewAll()
        grdMain.RemoveFilters()
    End Sub

    Private Sub grdMainLoad()
        Try
            With moProveedor
                .SelectFilter = clsProveedor.SelectFilters.GridCheck
                .WhereFilter = clsProveedor.WhereFilters.GridCheck
                .OrderByFilter = clsProveedor.OrderByFilters.GridCheck

                .EmpresaId = mlngEmpresaId
                If .Open() Then
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
#End Region

    Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
        If e.Control And e.KeyCode = Keys.C Then
            If Not grdMain.CurrentColumn Is Nothing Then
                Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
            End If
        End If
    End Sub

    Private Sub frmProveedorPorPagarFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.WindowState <> FormWindowState.Minimized Then
            If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
                Call frmKardexLoad()

            ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmProveedorPorPagarFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        moProveedor.Dispose()
        Call ClearMemory()
    End Sub

#Region " Otros Metodos "
    Private Function GestionFechaIni(ByVal lngGestionId As Long, ByRef datFechaFin As Date) As Date
        Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

        Try
            With oGestion
                .GestionId = lngGestionId

                If .FindByPK Then
                    datFechaFin = ToDate2(.DataSet.Tables(.TableName).Rows(0).Item("FechaFin"))
                    GestionFechaIni = ToDate2(.DataSet.Tables(.TableName).Rows(0).Item("FechaIni"))
                End If
            End With

        Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Finally
            oGestion.Dispose()
        End Try
    End Function
#End Region

End Class
