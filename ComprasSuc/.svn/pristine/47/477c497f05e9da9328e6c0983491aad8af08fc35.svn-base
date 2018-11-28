Public Class frmItemLoteEditDevCompra
   Inherits System.Windows.Forms.Form

   Private moItemLote As clsItemLote
   Private mlngMedidaIdNota As Long
   Private mlngItemLoteIdOld As Long

   Private moDataTable As DataTable

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

   Private mboolNewCloneDevVentaDet As Boolean
   Private mstrItemLoteDesOld As String

   Property MedidaIdNota() As Long
      Get
         Return mlngMedidaIdNota
      End Get

      Set(ByVal Value As Long)
         mlngMedidaIdNota = Value
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
         mboolNewCloneDevVentaDet = Value
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

   Property DataObject() As clsItemLote
      Get
         Return moItemLote
      End Get

      Set(ByVal Value As clsItemLote)
         moItemLote = Value
      End Set
   End Property

   Property DataTable() As DataTable
      Get
         Return moDataTable
      End Get

      Set(ByVal Value As DataTable)
         moDataTable = Value
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
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuConsultar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNuevo As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEliminar As System.Windows.Forms.MenuItem
   Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaIndi As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaGral As System.Windows.Forms.MenuItem
   Friend WithEvents txtItemLoteId As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents txtItemId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtSaldoOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaVen As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents cboItemLote As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboItemLote_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemLoteEditDevCompra))
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
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboItemLote = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.dtpFechaVen = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.txtSaldoOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtItemId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtItemLoteId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuConsultar = New System.Windows.Forms.MenuItem
      Me.mnuNuevo = New System.Windows.Forms.MenuItem
      Me.mnuEditar = New System.Windows.Forms.MenuItem
      Me.mnuEliminar = New System.Windows.Forms.MenuItem
      Me.MenuItem1 = New System.Windows.Forms.MenuItem
      Me.mnuFacturaIndi = New System.Windows.Forms.MenuItem
      Me.mnuFacturaGral = New System.Windows.Forms.MenuItem
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.cboItemLote, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
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
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 169)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.cboItemLote)
      Me.UiGroupBox1.Controls.Add(Me.dtpFechaVen)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.txtSaldoOrg)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 68)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 92)
      Me.UiGroupBox1.TabIndex = 3
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboItemLote
      '
      cboItemLote_DesignTimeLayout.LayoutString = resources.GetString("cboItemLote_DesignTimeLayout.LayoutString")
      Me.cboItemLote.DesignTimeLayout = cboItemLote_DesignTimeLayout
      Me.cboItemLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboItemLote.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboItemLote.Location = New System.Drawing.Point(116, 16)
      Me.cboItemLote.Name = "cboItemLote"
      Me.cboItemLote.SelectedIndex = -1
      Me.cboItemLote.SelectedItem = Nothing
      Me.cboItemLote.Size = New System.Drawing.Size(320, 20)
      Me.cboItemLote.TabIndex = 4
      Me.cboItemLote.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboItemLote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpFechaVen
      '
      Me.dtpFechaVen.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaVen.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaVen.DropDownCalendar.Name = ""
      Me.dtpFechaVen.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaVen.Location = New System.Drawing.Point(116, 64)
      Me.dtpFechaVen.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaVen.Name = "dtpFechaVen"
      Me.dtpFechaVen.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaVen.TabIndex = 6
      Me.dtpFechaVen.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 68)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 244
      Me.Label3.Text = "Vencimiento"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 20)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 242
      Me.Label4.Text = "Lote"
      '
      'txtSaldoOrg
      '
      Me.txtSaldoOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSaldoOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSaldoOrg.FormatString = "##,##0.000"
      Me.txtSaldoOrg.Location = New System.Drawing.Point(116, 40)
      Me.txtSaldoOrg.Name = "txtSaldoOrg"
      Me.txtSaldoOrg.Size = New System.Drawing.Size(124, 20)
      Me.txtSaldoOrg.TabIndex = 5
      Me.txtSaldoOrg.Text = "0,000"
      Me.txtSaldoOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtSaldoOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtSaldoOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 44)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 230
      Me.Label6.Text = "Cantidad"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtItemId)
      Me.grpMain.Controls.Add(Me.txtItemLoteId)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 68)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtItemId
      '
      Me.txtItemId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemId.Location = New System.Drawing.Point(116, 40)
      Me.txtItemId.Name = "txtItemId"
      Me.txtItemId.ReadOnly = True
      Me.txtItemId.Size = New System.Drawing.Size(320, 20)
      Me.txtItemId.TabIndex = 2
      Me.txtItemId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtItemLoteId
      '
      Me.txtItemLoteId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemLoteId.Location = New System.Drawing.Point(116, 16)
      Me.txtItemLoteId.Name = "txtItemLoteId"
      Me.txtItemLoteId.ReadOnly = True
      Me.txtItemLoteId.Size = New System.Drawing.Size(124, 20)
      Me.txtItemLoteId.TabIndex = 1
      Me.txtItemLoteId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemLoteId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 170
      Me.Label5.Text = "Item"
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
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConsultar, Me.mnuNuevo, Me.mnuEditar, Me.mnuEliminar, Me.MenuItem1, Me.mnuFacturaIndi, Me.mnuFacturaGral})
      '
      'mnuConsultar
      '
      Me.mnuConsultar.Index = 0
      Me.mnuConsultar.Text = "Consultar"
      '
      'mnuNuevo
      '
      Me.mnuNuevo.Index = 1
      Me.mnuNuevo.Text = "Nuevo"
      '
      'mnuEditar
      '
      Me.mnuEditar.Index = 2
      Me.mnuEditar.Text = "Editar"
      '
      'mnuEliminar
      '
      Me.mnuEliminar.Index = 3
      Me.mnuEliminar.Text = "Eliminar"
      '
      'MenuItem1
      '
      Me.MenuItem1.Index = 4
      Me.MenuItem1.Text = "-"
      '
      'mnuFacturaIndi
      '
      Me.mnuFacturaIndi.Index = 5
      Me.mnuFacturaIndi.Text = "Factura Individual"
      '
      'mnuFacturaGral
      '
      Me.mnuFacturaGral.Index = 6
      Me.mnuFacturaGral.Text = "Factura General"
      '
      'frmItemLoteEditDevCompra
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 197)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmItemLoteEditDevCompra"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ItemLote Edit"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.cboItemLote, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
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
               mlngID = moItemLote.ItemId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub frmCreditoEstClienteMov_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCreditoEstClienteMov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Lote"
         Else
            Me.Text = "Editar Lote"
         End If
      Else
         Me.Text = "Nuevo Lote"
         Call FormNew()
      End If

      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moItemLote
         txtItemLoteId.Text = ToStr(.ItemLoteId)
         Call txtItemIdLoad(.ItemId)

         If mboolEditing Then
            mlngItemLoteIdOld = .ItemLoteIdOrg
            cboItemLote.Value = ListFindItem(cboItemLote, .ItemLoteIdDev)
         Else
            cboItemLote.Text = ToStr(.ItemLoteDes)
         End If

         txtSaldoOrg.Text = ToDecStr(.SaldoOrg)
         dtpFechaVen.Text = .FechaVen

      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moItemLote

         txtItemLoteId.Text = String.Empty
         Call txtItemIdLoad(.ItemId)
         cboItemLote.Value = Nothing
         txtSaldoOrg.Text = ToDecStr(.SaldoOrg)
         dtpFechaVen.Text = String.Empty
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtItemLoteId.ReadOnly = True
      txtItemId.ReadOnly = True
      cboItemLote.ReadOnly = True
      txtSaldoOrg.ReadOnly = True
      dtpFechaVen.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moItemLote
         If Not mboolAdding Then
            .ItemLoteId = ToLong(txtItemLoteId.Text)
         End If

         .ItemLoteDes = ToStr(cboItemLote.Text)
         .SaldoOrg = ToDecimal(txtSaldoOrg.Text)
         .ItemLoteIdOrg = ListPosition(cboItemLote)
         .FechaVen = ToDateDMY(dtpFechaVen.Value)
         .ItemLoteIdDev = ListPosition(cboItemLote)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()
      cboItemLote.Select()

   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If FormCheck() Then
            If mboolAdding Then
               DataSave = True
            Else
               DataSave = True
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim lngMedidaIdLote As Long = 0
      Dim decItemLoteSaldo As Decimal
      Dim decItemLoteSaldoOld As Decimal

      Dim lngItemLoteIdOrgOld As Long = 0

      Dim decItemLoteSaldoDev As Decimal = 0

      If moItemLote.ItemLoteDes.Trim = String.Empty Then
         strMsg &= "Descripción de Lote Inválido" & vbCrLf
      End If

      If moItemLote.SaldoOrg <= 0 Then
         strMsg &= "Cantidad Inválida" & vbCrLf
         FormCheck = False
         Throw New Exception(strMsg)
      End If


      Call ItemParametro(moItemLote.ItemId)
      decItemLoteSaldo = ItemLoteSaldoFind(moItemLote.ItemLoteIdOrg, lngMedidaIdLote)

      If moItemLote.ItemLoteIdDev > 0 Then
         decItemLoteSaldoDev = ItemLoteCantidadFind(moItemLote.ItemLoteIdDev) - CantidadDevolucion(moItemLote.ItemLoteIdDev)
         If moItemLote.SaldoOrg > decItemLoteSaldoDev Then
            strMsg &= "La cantidad Excede al Saldo de Salida del Lote: " & decItemLoteSaldoDev & vbCrLf
         End If

      Else
         If ItemLoteDesDuplicado(moItemLote.ItemLoteDes.Trim) Then
            strMsg &= "Descripción de Lote Duplicado" & vbCrLf
            FormCheck = False
            Throw New Exception(strMsg)
         End If
      End If


      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function ItemLoteSaldoFind(ByVal lngItemLoteId As Long, ByRef lngMedidaId As Decimal) As Decimal
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      ItemLoteSaldoFind = 0

      Try
         With oItemLote
            .ItemLoteId = lngItemLoteId

            If .FindByPK Then
               lngMedidaId = .MedidaId
               Return ToDecimal(.SaldoOrg - .SaldoAct)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function ItemLoteCantidadFind(ByVal lngItemLoteId As Long) As Decimal
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      ItemLoteCantidadFind = 0

      Try
         With oItemLote
            .ItemLoteId = lngItemLoteId

            If .FindByPK Then
               Return (.SaldoOrg - .SaldoAct)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function ItemLoteCantidadFindSalida(ByVal lngItemLoteId As Long, ByRef lngItemLoteIdOrg As Long) As Decimal
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      ItemLoteCantidadFindSalida = 0
      lngItemLoteIdOrg = 0

      Try
         With oItemLote
            .ItemLoteId = lngItemLoteId

            If .FindByPK Then
               lngItemLoteIdOrg = .ItemLoteIdOrg
               Return .SaldoOrg
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()

      End Try
   End Function

   Private Function ItemLoteDuplicado(ByVal lngItemLoteIdOrg As Long) As Boolean
      Dim oRow As DataRow

      ItemLoteDuplicado = False

      If mboolAdding Then
         For Each oRow In moDataTable.Rows
            If oRow("ItemLoteIdOrg") = lngItemLoteIdOrg Then
               Return True
            End If
         Next

      ElseIf mboolEditing Then
         If mlngItemLoteIdOld <> lngItemLoteIdOrg Then
            For Each oRow In moDataTable.Rows
               If oRow("ItemLoteIdOrg") = lngItemLoteIdOrg Then
                  Return True
               End If
            Next
         End If
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

   Private Sub FormInit()
      Call FormCenter(Me)

      txtSaldoOrg.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()
      Call cboItemLoteLoad()
   End Sub

   Private Sub cboItemLoteLoad()
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem
      Dim oRow As DataRow

      cboItemLote.DropDownList.Columns.Clear()

      Try
         With oItemLote

            If moItemLote.ItemLoteIdDev > 0 Then
               .SelectFilter = clsItemLote.SelectFilters.ListBox
               .WhereFilter = clsItemLote.WhereFilters.SaldoItemLoteId
               .OrderByFilter = clsItemLote.OrderByFilters.ItemLoteId
               .EmpresaId = moItemLote.EmpresaId
               .ItemLoteId = moItemLote.ItemLoteIdDev
            Else
               .SelectFilter = clsItemLote.SelectFilters.ListBox
               .WhereFilter = clsItemLote.WhereFilters.Saldo
               .OrderByFilter = clsItemLote.OrderByFilters.ItemLoteId
               .EmpresaId = moItemLote.EmpresaId
               .GestionId = moItemLote.GestionId
               .AlmacenId = moItemLote.AlmacenId
               .ItemId = moItemLote.ItemId
               .EstadoId = 13
            End If


            If .Open() Then
               With cboItemLote
                  .DropDownList.Columns.Add("ItemLoteId")
                  .DropDownList.Columns("ItemLoteId").DataMember = "ItemLoteId"
                  .DropDownList.Columns("ItemLoteId").Visible = False

                  .DropDownList.Columns.Add("ItemLoteDes")
                  .DropDownList.Columns("ItemLoteDes").Caption = "Lote"
                  .DropDownList.Columns("ItemLoteDes").DataMember = "ItemLoteDes"
                  .DropDownList.Columns("ItemLoteDes").Width = 100

                  .DropDownList.Columns.Add("MedidaDes")
                  .DropDownList.Columns("MedidaDes").Caption = "Medida"
                  .DropDownList.Columns("MedidaDes").DataMember = "MedidaDes"
                  .DropDownList.Columns("MedidaDes").Width = 50

                  .DropDownList.Columns.Add("Saldo")
                  .DropDownList.Columns("Saldo").Caption = "Saldo"
                  .DropDownList.Columns("Saldo").DataMember = "Saldo"
                  .DropDownList.Columns("Saldo").Width = 80
                  .DropDownList.Columns("Saldo").FormatString = DecimalMask()
                  .DropDownList.Columns("Saldo").TextAlignment = Janus.Windows.GridEX.TextAlignment.Far

                  .DropDownList.Columns.Add("FechaVen")
                  .DropDownList.Columns("FechaVen").Caption = "Vencimiento"
                  .DropDownList.Columns("FechaVen").DataMember = "FechaVen"
                  .DropDownList.Columns("FechaVen").Width = 75
                  .DropDownList.Columns("FechaVen").FormatString = "dd/MM/yyyy"

                  .DataMember = oItemLote.TableName
                  .DataSource = oItemLote.DataSet

                  .ValueMember = "ItemLoteId"
                  .DisplayMember = "ItemLoteDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemLote.Dispose()
         oListItem = Nothing

      End Try
   End Sub

   Private Sub cboItemLote_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItemLote.LostFocus
      If cboItemLote.Tag <> cboItemLote.Text Then
         cboItemLote.Tag = cboItemLote.Text

         If cboItemLote.DropDownList.SelectedItems.Count > 0 Then
            dtpFechaVen.Text = cboItemLote.DropDownList.SelectedItems(0).GetRow.Cells("FechaVen").Value
         End If
      End If
   End Sub

   Private Sub txtItemIdLoad(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               txtItemId.Tag = .ItemId
               txtItemId.Text = ToStr(.ItemDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub frmCreditoEstClienteMov_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moItemLote.ItemLoteId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCreditoEstClienteMov_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moItemLote.Dispose()
      Call ClearMemory()
   End Sub

   Private Function CantidadDevolucion(ByVal lngItemLoteId As Long) As Long
      Dim oItemLote As New clsItemLote(clsAppInfo.ConnectString)

      Dim SumaDevolucion As Long = 0
      Try
         With oItemLote
            .SelectFilter = clsItemLote.SelectFilters.All
            .WhereFilter = clsItemLote.WhereFilters.TieneItemLoteIdDev
            .EmpresaId = clsAppInfo.EmpresaId
            .ItemLoteIdDev = lngItemLoteId

            If .Open Then
               Do While .Read()
                  SumaDevolucion += .SaldoOrg
                  .MoveNext()
               Loop
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oItemLote.Dispose()
      End Try
   End Function

   Private Function ItemLoteDesDuplicado(ByVal strItemLoteDes As String) As Boolean
      Dim oRow As DataRow

      ItemLoteDesDuplicado = False

      If mboolAdding Then
         For Each oRow In moDataTable.Rows
            If ToStr(oRow("ItemLoteDes")) = strItemLoteDes Then
               Return True
            End If
         Next

      ElseIf mboolEditing Then
         If mstrItemLoteDesOld <> strItemLoteDes Then
            For Each oRow In moDataTable.Rows
               If ToStr(oRow("ItemLoteDes")) = strItemLoteDes Then
                  Return True
               End If
            Next
         End If
      End If
   End Function


End Class
