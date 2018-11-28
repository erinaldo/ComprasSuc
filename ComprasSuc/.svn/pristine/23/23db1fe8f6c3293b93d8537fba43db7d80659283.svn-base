Public Class frmPedCompraDetEdit
   Inherits System.Windows.Forms.Form

   Private moPedCompraDet As clsPedCompraDet
   Private mqueItem As New Queue

   Private mlngTipoCosteoId As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngMonedaIdCos As Long
   Private mdecCantidadMin As Decimal
   Private mdecCantidadMax As Decimal

   Private mdecPrecioPPP As Decimal
   Private mdecPrecioUPC As Decimal
   Private mdecSaldoItem As Decimal

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents grbDesRec As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtPorcentajeRec As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoRec As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtPorcentajeDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtPedCompraDetDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents chkCodBarra As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboCentroCostoDet As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblActividad As System.Windows.Forms.Label
   Friend WithEvents dtpFechaEnt As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents grdItemCosto As Janus.Windows.GridEX.GridEX
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

   Property DataObject() As clsPedCompraDet
      Get
         Return moPedCompraDet
      End Get

      Set(ByVal Value As clsPedCompraDet)
         moPedCompraDet = Value
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
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuConsultar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNuevo As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEliminar As System.Windows.Forms.MenuItem
   Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaIndi As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaGral As System.Windows.Forms.MenuItem
   Friend WithEvents cboItem As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents chkItem As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents lblImporte As System.Windows.Forms.Label
   Friend WithEvents txtCantidad As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPrecio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblPrecio As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboMedida As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtPedCompraDetId As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cboItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedCompraDetEdit))
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
        Me.grdItemCosto = New Janus.Windows.GridEX.GridEX
        Me.dtpFechaEnt = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPedCompraDetId = New Janus.Windows.GridEX.EditControls.EditBox
        Me.cboCentroCostoDet = New Janus.Windows.EditControls.UIComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblActividad = New System.Windows.Forms.Label
        Me.chkCodBarra = New Janus.Windows.EditControls.UICheckBox
        Me.txtPedCompraDetDes = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboMedida = New Janus.Windows.EditControls.UIComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkItem = New Janus.Windows.EditControls.UICheckBox
        Me.cboItem = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblImporte = New System.Windows.Forms.Label
        Me.txtPrecio = New Janus.Windows.GridEX.EditControls.NumericEditBox
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
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.grdItemCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDesRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDesRec.SuspendLayout()
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
        Me.bcgMain.Controls.Add(Me.grbDesRec)
        Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
        Me.bcgMain.Location = New System.Drawing.Point(0, 28)
        Me.bcgMain.Name = "bcgMain"
        Me.bcgMain.Size = New System.Drawing.Size(462, 417)
        Me.bcgMain.TabIndex = 161
        Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'grpMain
        '
        Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
        Me.grpMain.Controls.Add(Me.grdItemCosto)
        Me.grpMain.Controls.Add(Me.dtpFechaEnt)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.txtPedCompraDetId)
        Me.grpMain.Controls.Add(Me.cboCentroCostoDet)
        Me.grpMain.Controls.Add(Me.Label7)
        Me.grpMain.Controls.Add(Me.lblActividad)
        Me.grpMain.Controls.Add(Me.chkCodBarra)
        Me.grpMain.Controls.Add(Me.txtPedCompraDetDes)
        Me.grpMain.Controls.Add(Me.Label11)
        Me.grpMain.Controls.Add(Me.cboMedida)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.chkItem)
        Me.grpMain.Controls.Add(Me.cboItem)
        Me.grpMain.Controls.Add(Me.txtImporte)
        Me.grpMain.Controls.Add(Me.lblImporte)
        Me.grpMain.Controls.Add(Me.txtPrecio)
        Me.grpMain.Controls.Add(Me.lblPrecio)
        Me.grpMain.Controls.Add(Me.txtCantidad)
        Me.grpMain.Controls.Add(Me.Label6)
        Me.grpMain.Controls.Add(Me.Label12)
        Me.grpMain.Location = New System.Drawing.Point(8, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(444, 347)
        Me.grpMain.TabIndex = 0
        Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
        Me.grdItemCosto.Location = New System.Drawing.Point(4, 240)
        Me.grdItemCosto.Name = "grdItemCosto"
        Me.grdItemCosto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItemCosto.SelectedInactiveFormatStyle.Blend = 0.0!
        Me.grdItemCosto.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.grdItemCosto.Size = New System.Drawing.Size(436, 100)
        Me.grdItemCosto.TabIndex = 12
        Me.grdItemCosto.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdItemCosto.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grdItemCosto.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grdItemCosto.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.grdItemCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'dtpFechaEnt
        '
        Me.dtpFechaEnt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaEnt.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaEnt.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpFechaEnt.DropDownCalendar.Name = ""
        Me.dtpFechaEnt.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.dtpFechaEnt.Location = New System.Drawing.Point(116, 212)
        Me.dtpFechaEnt.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaEnt.Name = "dtpFechaEnt"
        Me.dtpFechaEnt.Size = New System.Drawing.Size(124, 20)
        Me.dtpFechaEnt.TabIndex = 11
        Me.dtpFechaEnt.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaEnt.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "Fecha Ent."
        '
        'txtPedCompraDetId
        '
        Me.txtPedCompraDetId.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPedCompraDetId.Location = New System.Drawing.Point(116, 16)
        Me.txtPedCompraDetId.Name = "txtPedCompraDetId"
        Me.txtPedCompraDetId.ReadOnly = True
        Me.txtPedCompraDetId.Size = New System.Drawing.Size(124, 20)
        Me.txtPedCompraDetId.TabIndex = 0
        Me.txtPedCompraDetId.TabStop = False
        Me.txtPedCompraDetId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtPedCompraDetId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cboCentroCostoDet
        '
        Me.cboCentroCostoDet.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCostoDet.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoDet.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboCentroCostoDet.Location = New System.Drawing.Point(116, 188)
        Me.cboCentroCostoDet.Name = "cboCentroCostoDet"
        Me.cboCentroCostoDet.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
        Me.cboCentroCostoDet.Size = New System.Drawing.Size(320, 20)
        Me.cboCentroCostoDet.TabIndex = 10
        Me.cboCentroCostoDet.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
        'lblActividad
        '
        Me.lblActividad.BackColor = System.Drawing.Color.Transparent
        Me.lblActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividad.Location = New System.Drawing.Point(8, 192)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(104, 16)
        Me.lblActividad.TabIndex = 258
        Me.lblActividad.Text = "Actividad de C.C."
        '
        'chkCodBarra
        '
        Me.chkCodBarra.BackColor = System.Drawing.Color.Transparent
        Me.chkCodBarra.Location = New System.Drawing.Point(76, 44)
        Me.chkCodBarra.Name = "chkCodBarra"
        Me.chkCodBarra.Size = New System.Drawing.Size(16, 16)
        Me.chkCodBarra.TabIndex = 1
        Me.chkCodBarra.TabStop = False
        Me.chkCodBarra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'txtPedCompraDetDes
        '
        Me.txtPedCompraDetDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedCompraDetDes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPedCompraDetDes.Location = New System.Drawing.Point(116, 160)
        Me.txtPedCompraDetDes.MaxLength = 255
        Me.txtPedCompraDetDes.Multiline = True
        Me.txtPedCompraDetDes.Name = "txtPedCompraDetDes"
        Me.txtPedCompraDetDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPedCompraDetDes.Size = New System.Drawing.Size(320, 24)
        Me.txtPedCompraDetDes.TabIndex = 9
        Me.txtPedCompraDetDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtPedCompraDetDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
        Me.cboMedida.TabIndex = 5
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
        Me.chkItem.TabIndex = 2
        Me.chkItem.TabStop = False
        Me.chkItem.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'cboItem
        '
        cboItem_DesignTimeLayout.LayoutString = resources.GetString("cboItem_DesignTimeLayout.LayoutString")
        Me.cboItem.DesignTimeLayout = cboItem_DesignTimeLayout
        Me.cboItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cboItem.Location = New System.Drawing.Point(116, 40)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.SelectedIndex = -1
        Me.cboItem.SelectedItem = Nothing
        Me.cboItem.Size = New System.Drawing.Size(320, 20)
        Me.cboItem.TabIndex = 4
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
        Me.txtImporte.TabIndex = 8
        Me.txtImporte.Text = "0.000"
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
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtPrecio.FormatString = "##,##0.000"
        Me.txtPrecio.Location = New System.Drawing.Point(116, 112)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(124, 20)
        Me.txtPrecio.TabIndex = 7
        Me.txtPrecio.Text = "0.000"
        Me.txtPrecio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtPrecio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.txtPrecio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
        Me.txtCantidad.TabIndex = 6
        Me.txtCantidad.Text = "0.000"
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
        Me.grbDesRec.Location = New System.Drawing.Point(8, 348)
        Me.grbDesRec.Name = "grbDesRec"
        Me.grbDesRec.Size = New System.Drawing.Size(444, 64)
        Me.grbDesRec.TabIndex = 3
        Me.grbDesRec.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(312, 14)
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
        Me.txtPorcentajeRec.Location = New System.Drawing.Point(336, 12)
        Me.txtPorcentajeRec.Name = "txtPorcentajeRec"
        Me.txtPorcentajeRec.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeRec.TabIndex = 13
        Me.txtPorcentajeRec.Text = "0.000"
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
        Me.txtMontoRec.TabIndex = 12
        Me.txtMontoRec.Text = "0.000"
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
        Me.Label10.Location = New System.Drawing.Point(312, 38)
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
        Me.txtPorcentajeDes.Location = New System.Drawing.Point(336, 36)
        Me.txtPorcentajeDes.Name = "txtPorcentajeDes"
        Me.txtPorcentajeDes.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeDes.TabIndex = 15
        Me.txtPorcentajeDes.Text = "0.000"
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
        Me.txtMontoDes.TabIndex = 14
        Me.txtMontoDes.Text = "0.000"
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
        'frmPedCompraDetEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(462, 445)
        Me.Controls.Add(Me.bcgMain)
        Me.Controls.Add(Me.TopRebar1)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedCompraDetEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PedCompraDet Edit"
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
        CType(Me.grdItemCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDesRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDesRec.ResumeLayout(False)
        Me.grbDesRec.PerformLayout()
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
               mlngID = moPedCompraDet.ItemId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPedCompraDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPedCompraDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Pedido de Item"
         Else
            Call ItemReadOnly()
            Me.Text = "Editar Pedido de Item"
         End If
      Else
         Me.Text = "Nuevo Pedido de Item"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moPedCompraDet
         txtPedCompraDetId.Text = ToStr(.PedCompraDetId)
         Call txtProveedorIdLoad(.ProveedorId)
         Call txtAlmacenIdLoad(.AlmacenId)
         cboItem.Value = ListFindItem(cboItem, .ItemId)
         cboItem.Tag = cboItem.Text
         Call ItemParametro(.ItemId)
         Call ItemSaldoParametro(.ItemId, .AlmacenId)
         Call cboMedidaLoad()
         cboMedida.SelectedIndex = ListFindItem(cboMedida, .MedidaId)
         txtCantidad.Text = ToDecStr(.Cantidad)
         txtPrecio.Text = ToDecStr(.Precio)
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
         txtPedCompraDetDes.Text = .PedCompraDetDes
         cboCentroCostoDet.SelectedIndex = ListFindItem(cboCentroCostoDet, .CentroCostoDetId)
         dtpFechaEnt.Text = ToStr(.FechaEnt)
      End With
      mboolShow = False
      cboItem.Select()
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moPedCompraDet
         txtPedCompraDetId.Text = String.Empty
         Call txtProveedorIdLoad(.ProveedorId)
         Call txtAlmacenIdLoad(.AlmacenId)
         cboItem.Value = Nothing
         Call grdCostoItemLoad(ListPosition(cboItem))
         cboMedida.SelectedIndex = -1
         txtCantidad.Text = "0"
         txtPrecio.Text = "0"
         txtImporte.Text = "0"
         txtMontoRec.Text = "0"
         txtMontoDes.Text = "0"
         txtPorcentajeRec.Text = "0"
         txtPorcentajeDes.Text = "0"
         txtPedCompraDetDes.Text = ""
         cboCentroCostoDet.SelectedIndex = ListFindItem(cboCentroCostoDet, .CentroCostoDetId)
         dtpFechaEnt.Text = ToStr(.FechaEnt)
      End With
      mboolShow = False
   End Sub

   Private Sub ItemReadOnly()
      cboItem.ReadOnly = True
      cboMedida.ReadOnly = True
   End Sub

   Private Sub DataReadOnly()
      txtPedCompraDetId.ReadOnly = True
      cboItem.ReadOnly = True
      cboMedida.ReadOnly = True
      txtCantidad.ReadOnly = True
      txtPrecio.ReadOnly = True
      txtImporte.ReadOnly = True
      txtMontoRec.ReadOnly = True
      txtMontoDes.ReadOnly = True
      txtPorcentajeRec.ReadOnly = True
      txtPorcentajeDes.ReadOnly = True
      txtPedCompraDetDes.ReadOnly = True
      cboCentroCostoDet.ReadOnly = True
      dtpFechaEnt.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub MostrarCentroCosto()
      If clsAppInfo.CentroCostoApli Then
         cboCentroCostoDet.Visible = True
         lblActividad.Visible = True
        Else
            If cboCentroCostoDet.Visible Then
                cboCentroCostoDet.Visible = False
                lblActividad.Visible = False

                Label3.Location = New System.Drawing.Point(Label3.Location.X, Label3.Location.Y - 23)
                dtpFechaEnt.Location = New System.Drawing.Point(dtpFechaEnt.Location.X, dtpFechaEnt.Location.Y - 23)
                grpMain.Size = New System.Drawing.Size(grpMain.Width, grpMain.Height - 20)
                grdItemCosto.Location = New System.Drawing.Point(grdItemCosto.Location.X, grdItemCosto.Location.Y - 20)

                grbDesRec.Location = New System.Drawing.Point(grbDesRec.Location.X, grbDesRec.Location.Y - 20)

                Me.Size = New System.Drawing.Size(Me.Width, Me.Height - 20)
            End If
      End If
   End Sub

   Private Sub DataMove()
      With moPedCompraDet
         If Not mboolAdding Then
            .PedCompraDetId = ToLong(txtPedCompraDetId.Text)
         End If

         .ItemId = ListPosition(cboItem)
         .MedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex)
         .Cantidad = ToDecimal(txtCantidad.Text)
         .Precio = ToDecimal(txtPrecio.Text)
         .Importe = ToDecimal(txtImporte.Text)
         .PrecioRec = ToDouble(txtMontoRec.Text / ToDivByCero(txtCantidad.Text))
         .PrecioDes = ToDouble(txtMontoDes.Text / ToDivByCero(txtCantidad.Text))
         .ImporteBru = ToDecimal(ToDouble(txtImporte.Text) + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text))
         .PedCompraDetDes = ToStr(txtPedCompraDetDes.Text)
         .CentroCostoDetId = ListPosition(cboCentroCostoDet, cboCentroCostoDet.SelectedIndex)
         .FechaEnt = ToStr(dtpFechaEnt.Text)
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
            Call DataMove()
            Call CantidadMaxCheck()

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
      Dim lngItemId As Long = ListPosition(cboItem)

      If lngItemId <> 0 Then
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

         ''If ToDecimal(txtPrecio.Text) <= 0 Then
         ''   strMsg &= "Precio Inválido"
         ''End If


         If clsAppInfo.CentroCostoApli Then

            If cboCentroCostoDet.Items.Count > 0 Then
               If cboCentroCostoDet.SelectedIndex = -1 Then
                  strMsg &= "Seleccione la Actividad" & vbCrLf
               End If
            End If
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

   Private Sub CantidadMaxCheck()
      If mdecCantidadMax > 0 Then
         If mlngMedidaId = moPedCompraDet.MedidaId Then
            If (mdecSaldoItem + moPedCompraDet.Cantidad) > mdecCantidadMax Then
               MessageBox.Show("¡Advertencia! Con este Pedido, La Cantidad en Stock es Superior al Limite Maximo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            If (mdecSaldoItem + (moPedCompraDet.Cantidad * mdecMedidaCantEqui)) > mdecCantidadMax Then
               MessageBox.Show("¡Advertencia! Con este Pedido, La Cantidad en Stock es Superior al Limite Maximo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      End If
   End Sub

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngTipoCosteoId = 0
         mlngMedidaId = 0
         mlngMedidaIdEqui = 0
         mdecMedidaCantEqui = 0
         mlngMonedaIdCos = 0
         mdecCantidadMin = 0
         mdecCantidadMax = 0

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngTipoCosteoId = ToLong(.TipoCosteoId)
               mlngMedidaId = ToLong(.MedidaId)
               mlngMedidaIdEqui = ToLong(.MedidaIdEqui)
               mdecMedidaCantEqui = ToDecimal(.MedidaCantEqui)
               mlngMonedaIdCos = ToLong(.MonedaIdCos)
               mdecCantidadMin = ToDecimal(.CantidadMin)
               mdecCantidadMax = ToDecimal(.CantidadMax)
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
            .EmpresaId = moPedCompraDet.EmpresaId
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
      txtPrecio.FormatString = DecimalMask()
      txtImporte.FormatString = DecimalMask()

      txtPorcentajeDes.FormatString = DecimalMask()
      txtMontoDes.FormatString = DecimalMask()
      txtPorcentajeRec.FormatString = DecimalMask()
      txtMontoRec.FormatString = DecimalMask()

      chkCodBarra.Checked = clsAppInfo.CodBarra
      If Not chkCodBarra.Checked Then
         chkCodBarra.Visible = False
      End If

      Call MostrarCentroCosto()
   End Sub

   Private Sub ComboLoad()
      Call cboItemLoad()
      Call cboCentroCostoDetLoad()

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

            .EmpresaId = moPedCompraDet.EmpresaId
            .ItemId = moPedCompraDet.ItemId
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

   Private Sub cboCentroCostoDetLoad()
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCostoDet.Items.Clear()

      Try
         With oCentroCostoDet

            .SelectFilter = clsCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCentroCostoDet.WhereFilters.EstadoId
            .EmpresaId = clsAppInfo.EmpresaId
            .EstadoId = 1
            .CentroCostoId = moPedCompraDet.CentroCostoId
            .CentroCostoDetId = moPedCompraDet.CentroCostoDetId

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
            .EmpresaId = moPedCompraDet.EmpresaId
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
            .EmpresaId = moPedCompraDet.EmpresaId
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
                     .EmpresaId = moPedCompraDet.EmpresaId
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

                     oItem.EmpresaId = moPedCompraDet.EmpresaId

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

   Private Sub cboItem_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItem.ValueChanged
      cboItem.Tag = String.Empty
      cboMedida.Items.Clear()
      cboMedida.Text = ""
      Call grdCostoItemLoad(ListPosition(cboItem))

   End Sub

   Private Sub cboItem_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItem.LostFocus
      If cboItem.Tag <> cboItem.Text Then
         cboItem.Tag = cboItem.Text

         Dim lngItemId As Long = ListPosition(cboItem)

         If lngItemId <> 0 Then
            Call ItemParametro(lngItemId)
            Call ItemSaldoParametro(lngItemId, moPedCompraDet.AlmacenId)
            Call cboMedidaLoad()
            cboMedida.Tag = ""
            cboMedida.SelectedIndex = ListFindItem(cboMedida, mlngMedidaId)
         Else
            cboMedida.Items.Clear()
            cboMedida.Text = ""
         End If
      End If
   End Sub

   Private Sub cboMedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedida.SelectedIndexChanged
      If cboMedida.Tag <> cboMedida.Text Then
         cboMedida.Tag = cboMedida.Text

         Dim decUPC As Decimal = ItemProveedorUPC(moPedCompraDet.ProveedorId, ListPosition(cboItem))
         ''Dim decUPC As Decimal = mdecPrecioUPC

         If mlngMedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex) Then
            If moPedCompraDet.MonedaId = 1 Then
               If moPedCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecio.Text = ToDecStr(decUPC)
               Else
                  txtPrecio.Text = ToDecStr(decUPC * moPedCompraDet.TipoCambio)
               End If

            ElseIf moPedCompraDet.MonedaId = 2 Then
               If moPedCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecio.Text = ToDecStr(decUPC)
               Else
                  txtPrecio.Text = ToDecStr(decUPC / moPedCompraDet.TipoCambio)
               End If
            End If
         Else
            If moPedCompraDet.MonedaId = 1 Then
               If moPedCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecio.Text = ToDecStr(decUPC * mdecMedidaCantEqui)
               Else
                  txtPrecio.Text = ToDecStr((decUPC * mdecMedidaCantEqui) * moPedCompraDet.TipoCambio)
               End If

            ElseIf moPedCompraDet.MonedaId = 2 Then
               If moPedCompraDet.MonedaId = mlngMonedaIdCos Then
                  txtPrecio.Text = ToDecStr(decUPC * mdecMedidaCantEqui)
               Else
                  txtPrecio.Text = ToDecStr((decUPC * mdecMedidaCantEqui) / moPedCompraDet.TipoCambio)
               End If
            End If
         End If

         txtImporte.Text = ToDecStr(ToDecimal(txtCantidad.Text) * ToDecimal(txtPrecio.Text))
         Call MontoRecDesLoad()

      End If
   End Sub

   Private Function ItemProveedorUPC(ByVal lngProveedorId As Long, ByVal lngItemId As Long) As Decimal
      Dim oItemProveedor As New clsItemProveedor(clsAppInfo.ConnectString)

      Try
         With oItemProveedor
            .SelectFilter = clsItemProveedor.SelectFilters.All
            .WhereFilter = clsItemProveedor.WhereFilters.ItemId
            .EmpresaId = moPedCompraDet.EmpresaId
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

#Region "ItemPedidos"

   'Metodo que carga la grilla los ultimos Precios de item de Pedidos
   Private Sub grdCostoItemLoad(ByVal lngItemId As Long)
      Dim oPedCompraDet As New clsPedCompraDet(clsAppInfo.ConnectString)

      Try
         With oPedCompraDet
            .SelectFilter = clsPedCompraDet.SelectFilters.ProveedorUPP
            .WhereFilter = clsPedCompraDet.WhereFilters.ProveedorUPP
            .OrderByFilter = clsPedCompraDet.OrderByFilters.FechaDESC
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .ItemId = lngItemId
            .AlmacenId = moPedCompraDet.AlmacenId
            .ProveedorId = moPedCompraDet.ProveedorId
            '.CompraId = mlngTipoPagoId

            If .Open Then
               grdItemCosto.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdItemCosto.RetrieveStructure()
               Call grdMainInitCosto()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPedCompraDet.Dispose()

      End Try

   End Sub

   Private Sub DataShow()
      Dim oPedCompra As New clsPedCompra(clsAppInfo.ConnectString)

      Try
         If (grdItemCosto.GetRow.Selected) And (ToLong(grdItemCosto.GetValue("PedCompraId")) > 0) Then
            With oPedCompra
               .PedCompraId = ToLong(grdItemCosto.GetValue("PedCompraId"))

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

   Private Sub grdMainInitCosto()
      With grdItemCosto

         .RootTable.Columns("PedCompraId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 70
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         '.RootTable.Columns("TipoPagoId").Visible = False

         '.RootTable.Columns("TipoPagoDes").Caption = "Forma"
         '.RootTable.Columns("TipoPagoDes").Width = 60
         '.RootTable.Columns("TipoPagoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         '.RootTable.Columns("TipoPagoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 70
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 100
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cant."
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 60
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Precio").Caption = "Precio"
         .RootTable.Columns("Precio").FormatString = DecimalMask()
         .RootTable.Columns("Precio").Width = 60
         .RootTable.Columns("Precio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Precio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With
   End Sub

   Private Sub grdItemCosto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdItemCosto.DoubleClick
      Call DataShow()
   End Sub

#End Region

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
      txtImporte.Text = ToDecStr(ToDecimal(txtCantidad.Text) * ToDecimal(txtPrecio.Text))
      Call MontoRecDesLoad()
   End Sub

   Private Sub txtPrecio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.TextChanged
      If txtPrecio.ContainsFocus Then
         txtImporte.Text = ToDecStr(ToDecimal(txtCantidad.Text) * ToDecimal(txtPrecio.Text))
         Call MontoRecDesLoad()
      End If
   End Sub

   Private Sub txtImporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
      If txtImporte.ContainsFocus Then
         txtPrecio.Text = ToDecStr(ToDecimal(txtImporte.Text) / ToDivByCero(txtCantidad.Text))
         Call MontoRecDesLoad()
      End If
   End Sub

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

   Private Sub frmPedCompraDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then

         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moPedCompraDet.ItemId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If

         If (Not mboolAdding) And (Not mboolEditing) And e.KeyCode = Keys.Decimal Then
            e.Handled = True
         End If
      End If
   End Sub

   Private Sub frmPedCompraDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPedCompraDet.Dispose()
      Call ClearMemory()
   End Sub

End Class
