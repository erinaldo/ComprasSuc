Public Class frmItemPrecioEdit
   Inherits System.Windows.Forms.Form

   Private moItemPrecio As clsItemPrecio
   Private mqueItem As New Queue

   Private mlngTipoCosteoId As Long
   Private mlngMonedaIdCos As Long
   Private mlngMonedaIdVen As Long
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngTipoItemId As Long

   Private mboolPorcentaje As Boolean
   Private mboolPrecio As Boolean
   Private mdecPorImpuesto As Decimal

   Private mstrEncPrecioDes As String
   Private mlngEncTipoCosteoId As Long
   Private mboolShowChk As Boolean = False

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolDesdePrecio As Boolean
   Friend WithEvents dudOrden As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents chkAlmacen As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtPrecioEqui As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPorcentaje As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtPrecioNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents txtUtilidadNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtUtilidad As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents txtPrecioMaxPor As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents txtPrecioMinPor As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkCodBarra As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkItem As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboItem As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents chkPorcentaje As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkPrecio As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents cboEncPrecio As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Private mlngID As Long

   Property TipoCosteoId() As Long
      Get
         Return mlngTipoCosteoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCosteoId = Value
      End Set
   End Property

   Property MonedaIdVen() As Long
      Get
         Return mlngMonedaIdVen
      End Get

      Set(ByVal Value As Long)
         mlngMonedaIdVen = Value
      End Set
   End Property

   Property MonedaIdCos() As Long
      Get
         Return mlngMonedaIdCos
      End Get

      Set(ByVal Value As Long)
         mlngMonedaIdCos = Value
      End Set
   End Property

   Property MedidaId() As Long
      Get
         Return mlngMedidaId
      End Get

      Set(ByVal Value As Long)
         mlngMedidaId = Value
      End Set
   End Property

   Property MedidaIdEqui() As Long
      Get
         Return mlngMedidaIdEqui
      End Get

      Set(ByVal Value As Long)
         mlngMedidaIdEqui = Value
      End Set
   End Property

   Property MedidaCantEqui() As Long
      Get
         Return mdecMedidaCantEqui
      End Get

      Set(ByVal Value As Long)
         mdecMedidaCantEqui = Value
      End Set
   End Property

   Property TipoItemId() As Long
      Get
         Return mlngTipoItemId
      End Get

      Set(ByVal Value As Long)
         mlngTipoItemId = Value
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

   Property DataObject() As clsItemPrecio
      Get
         Return moItemPrecio
      End Get

      Set(ByVal Value As clsItemPrecio)
         moItemPrecio = Value
      End Set
   End Property

   Property ItemList() As Queue
      Get
         Return mqueItem
      End Get

      Set(ByVal Value As Queue)
         mqueItem = Value
      End Set
   End Property

   WriteOnly Property DesdePrecio() As Boolean
      Set(ByVal Value As Boolean)
         mboolDesdePrecio = Value
      End Set
   End Property

   Property EncPrecioDes() As String
      Get
         Return mstrEncPrecioDes
      End Get

      Set(ByVal Value As String)
         mstrEncPrecioDes = Value
      End Set
   End Property

   Property EncTipoCosteoId() As Long
      Get
         Return mlngEncTipoCosteoId
      End Get

      Set(ByVal Value As Long)
         mlngEncTipoCosteoId = Value
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
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtItemPrecioId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label30 As System.Windows.Forms.Label
   Friend WithEvents cboTipoCosteo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtPrecioCosto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblAlmacenOrg As System.Windows.Forms.Label
   Friend WithEvents cboAlmacen As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtPrecio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtMedidaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPorcentajeNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtItemPrecioDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboEncPrecio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemPrecioEdit))
      Dim cboItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
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
      Me.cboEncPrecio = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.cboAlmacen = New Janus.Windows.EditControls.UIComboBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.lblAlmacenOrg = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.txtItemPrecioId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.dudOrden = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkPrecio = New Janus.Windows.EditControls.UICheckBox
      Me.chkPorcentaje = New Janus.Windows.EditControls.UICheckBox
      Me.chkCodBarra = New Janus.Windows.EditControls.UICheckBox
      Me.chkItem = New Janus.Windows.EditControls.UICheckBox
      Me.cboItem = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtMedidaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboTipoCosteo = New Janus.Windows.EditControls.UIComboBox
      Me.txtUtilidadNeto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtPrecioCosto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtPrecioNeto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtPorcentajeNeto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label30 = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPrecioMaxPor = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label16 = New System.Windows.Forms.Label
      Me.txtPrecioMinPor = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.txtUtilidad = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtPrecioEqui = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.chkAlmacen = New Janus.Windows.EditControls.UICheckBox
      Me.txtPorcentaje = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.txtItemPrecioDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtPrecio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
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
      CType(Me.cboEncPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.cboItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 391)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboEncPrecio)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.Controls.Add(Me.cboAlmacen)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.lblAlmacenOrg)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.txtItemPrecioId)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.dudOrden)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 116)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboEncPrecio
      '
      cboEncPrecio_DesignTimeLayout.LayoutString = resources.GetString("cboEncPrecio_DesignTimeLayout.LayoutString")
      Me.cboEncPrecio.DesignTimeLayout = cboEncPrecio_DesignTimeLayout
      Me.cboEncPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboEncPrecio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEncPrecio.Location = New System.Drawing.Point(116, 40)
      Me.cboEncPrecio.Name = "cboEncPrecio"
      Me.cboEncPrecio.SelectedIndex = -1
      Me.cboEncPrecio.SelectedItem = Nothing
      Me.cboEncPrecio.Size = New System.Drawing.Size(320, 20)
      Me.cboEncPrecio.TabIndex = 2
      Me.cboEncPrecio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboEncPrecio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(336, 16)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.ReadOnly = True
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(100, 20)
      Me.cboEstado.TabIndex = 6
      Me.cboEstado.TabStop = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(280, 20)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(52, 16)
      Me.Label18.TabIndex = 243
      Me.Label18.Text = "Estado"
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(8, 44)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(104, 16)
      Me.Label17.TabIndex = 241
      Me.Label17.Text = "Lista"
      '
      'cboAlmacen
      '
      Me.cboAlmacen.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAlmacen.Location = New System.Drawing.Point(116, 64)
      Me.cboAlmacen.Name = "cboAlmacen"
      Me.cboAlmacen.ReadOnly = True
      Me.cboAlmacen.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboAlmacen.Size = New System.Drawing.Size(320, 20)
      Me.cboAlmacen.TabIndex = 3
      Me.cboAlmacen.TabStop = False
      Me.cboAlmacen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(336, 88)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.ReadOnly = True
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
      Me.cboMoneda.TabIndex = 5
      Me.cboMoneda.TabStop = False
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblAlmacenOrg
      '
      Me.lblAlmacenOrg.BackColor = System.Drawing.Color.Transparent
      Me.lblAlmacenOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAlmacenOrg.Location = New System.Drawing.Point(8, 68)
      Me.lblAlmacenOrg.Name = "lblAlmacenOrg"
      Me.lblAlmacenOrg.Size = New System.Drawing.Size(104, 16)
      Me.lblAlmacenOrg.TabIndex = 218
      Me.lblAlmacenOrg.Text = "Almacén"
      '
      'Label15
      '
      Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(280, 92)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 16)
      Me.Label15.TabIndex = 241
      Me.Label15.Text = "Moneda"
      '
      'txtItemPrecioId
      '
      Me.txtItemPrecioId.CausesValidation = False
      Me.txtItemPrecioId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemPrecioId.Location = New System.Drawing.Point(116, 16)
      Me.txtItemPrecioId.Name = "txtItemPrecioId"
      Me.txtItemPrecioId.ReadOnly = True
      Me.txtItemPrecioId.Size = New System.Drawing.Size(124, 20)
      Me.txtItemPrecioId.TabIndex = 1
      Me.txtItemPrecioId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemPrecioId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label9.Location = New System.Drawing.Point(8, 92)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 226
      Me.Label9.Text = "Nivel"
      '
      'dudOrden
      '
      Me.dudOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudOrden.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudOrden.Location = New System.Drawing.Point(116, 88)
      Me.dudOrden.Maximum = 999999999
      Me.dudOrden.Name = "dudOrden"
      Me.dudOrden.ReadOnly = True
      Me.dudOrden.Size = New System.Drawing.Size(124, 20)
      Me.dudOrden.TabIndex = 4
      Me.dudOrden.TabStop = False
      Me.dudOrden.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudOrden.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.chkPrecio)
      Me.UiGroupBox2.Controls.Add(Me.chkPorcentaje)
      Me.UiGroupBox2.Controls.Add(Me.chkCodBarra)
      Me.UiGroupBox2.Controls.Add(Me.chkItem)
      Me.UiGroupBox2.Controls.Add(Me.cboItem)
      Me.UiGroupBox2.Controls.Add(Me.txtMedidaId)
      Me.UiGroupBox2.Controls.Add(Me.cboTipoCosteo)
      Me.UiGroupBox2.Controls.Add(Me.txtUtilidadNeto)
      Me.UiGroupBox2.Controls.Add(Me.txtPrecioCosto)
      Me.UiGroupBox2.Controls.Add(Me.Label12)
      Me.UiGroupBox2.Controls.Add(Me.Label1)
      Me.UiGroupBox2.Controls.Add(Me.Label3)
      Me.UiGroupBox2.Controls.Add(Me.txtPrecioNeto)
      Me.UiGroupBox2.Controls.Add(Me.Label6)
      Me.UiGroupBox2.Controls.Add(Me.Label11)
      Me.UiGroupBox2.Controls.Add(Me.Label2)
      Me.UiGroupBox2.Controls.Add(Me.txtPorcentajeNeto)
      Me.UiGroupBox2.Controls.Add(Me.Label30)
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 116)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(444, 136)
      Me.UiGroupBox2.TabIndex = 1
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkPrecio
      '
      Me.chkPrecio.Anchor = System.Windows.Forms.AnchorStyles.Bottom
      Me.chkPrecio.BackColor = System.Drawing.Color.Transparent
      Me.chkPrecio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPrecio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkPrecio.Location = New System.Drawing.Point(284, 112)
      Me.chkPrecio.Name = "chkPrecio"
      Me.chkPrecio.Size = New System.Drawing.Size(68, 16)
      Me.chkPrecio.TabIndex = 10
      Me.chkPrecio.TabStop = False
      Me.chkPrecio.Text = "Precio"
      Me.chkPrecio.ToolTipText = "Actualizar Precio"
      Me.chkPrecio.Visible = False
      Me.chkPrecio.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkPorcentaje
      '
      Me.chkPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.Bottom
      Me.chkPorcentaje.BackColor = System.Drawing.Color.Transparent
      Me.chkPorcentaje.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPorcentaje.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkPorcentaje.Location = New System.Drawing.Point(356, 112)
      Me.chkPorcentaje.Name = "chkPorcentaje"
      Me.chkPorcentaje.Size = New System.Drawing.Size(80, 16)
      Me.chkPorcentaje.TabIndex = 11
      Me.chkPorcentaje.TabStop = False
      Me.chkPorcentaje.Text = "Porcentaje"
      Me.chkPorcentaje.ToolTipText = "Actualizar Porcentaje"
      Me.chkPorcentaje.Visible = False
      Me.chkPorcentaje.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkCodBarra
      '
      Me.chkCodBarra.BackColor = System.Drawing.Color.Transparent
      Me.chkCodBarra.Location = New System.Drawing.Point(76, 16)
      Me.chkCodBarra.Name = "chkCodBarra"
      Me.chkCodBarra.Size = New System.Drawing.Size(16, 16)
      Me.chkCodBarra.TabIndex = 264
      Me.chkCodBarra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkItem
      '
      Me.chkItem.BackColor = System.Drawing.Color.Transparent
      Me.chkItem.Checked = True
      Me.chkItem.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkItem.Location = New System.Drawing.Point(100, 16)
      Me.chkItem.Name = "chkItem"
      Me.chkItem.Size = New System.Drawing.Size(16, 16)
      Me.chkItem.TabIndex = 262
      Me.chkItem.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboItem
      '
      cboItem_DesignTimeLayout.LayoutString = resources.GetString("cboItem_DesignTimeLayout.LayoutString")
      Me.cboItem.DesignTimeLayout = cboItem_DesignTimeLayout
      Me.cboItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboItem.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboItem.Location = New System.Drawing.Point(116, 12)
      Me.cboItem.Name = "cboItem"
      Me.cboItem.ReadOnly = True
      Me.cboItem.SelectedIndex = -1
      Me.cboItem.SelectedItem = Nothing
      Me.cboItem.Size = New System.Drawing.Size(320, 20)
      Me.cboItem.TabIndex = 1
      Me.cboItem.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMedidaId
      '
      Me.txtMedidaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMedidaId.Location = New System.Drawing.Point(116, 36)
      Me.txtMedidaId.Name = "txtMedidaId"
      Me.txtMedidaId.ReadOnly = True
      Me.txtMedidaId.Size = New System.Drawing.Size(124, 20)
      Me.txtMedidaId.TabIndex = 2
      Me.txtMedidaId.TabStop = False
      Me.txtMedidaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtMedidaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboTipoCosteo
      '
      Me.cboTipoCosteo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCosteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoCosteo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCosteo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCosteo.Location = New System.Drawing.Point(336, 36)
      Me.cboTipoCosteo.Name = "cboTipoCosteo"
      Me.cboTipoCosteo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoCosteo.Size = New System.Drawing.Size(100, 20)
      Me.cboTipoCosteo.TabIndex = 3
      Me.cboTipoCosteo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtUtilidadNeto
      '
      Me.txtUtilidadNeto.BackColor = System.Drawing.Color.MistyRose
      Me.txtUtilidadNeto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtUtilidadNeto.FormatString = "##,##0.000"
      Me.txtUtilidadNeto.Location = New System.Drawing.Point(116, 84)
      Me.txtUtilidadNeto.Name = "txtUtilidadNeto"
      Me.txtUtilidadNeto.Size = New System.Drawing.Size(124, 20)
      Me.txtUtilidadNeto.TabIndex = 7
      Me.txtUtilidadNeto.Text = "0,000"
      Me.txtUtilidadNeto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtUtilidadNeto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtUtilidadNeto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPrecioCosto
      '
      Me.txtPrecioCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPrecioCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPrecioCosto.FormatString = "##,##0.000"
      Me.txtPrecioCosto.Location = New System.Drawing.Point(116, 60)
      Me.txtPrecioCosto.Name = "txtPrecioCosto"
      Me.txtPrecioCosto.ReadOnly = True
      Me.txtPrecioCosto.Size = New System.Drawing.Size(124, 20)
      Me.txtPrecioCosto.TabIndex = 4
      Me.txtPrecioCosto.TabStop = False
      Me.txtPrecioCosto.Text = "0,000"
      Me.txtPrecioCosto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPrecioCosto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPrecioCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label12.Location = New System.Drawing.Point(8, 88)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 239
      Me.Label12.Text = "Utilidad Neta"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 173
      Me.Label1.Text = "Ítem"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 64)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 221
      Me.Label3.Text = "Precio Costo"
      '
      'txtPrecioNeto
      '
      Me.txtPrecioNeto.BackColor = System.Drawing.Color.MistyRose
      Me.txtPrecioNeto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPrecioNeto.FormatString = "##,##0.000"
      Me.txtPrecioNeto.Location = New System.Drawing.Point(116, 108)
      Me.txtPrecioNeto.Name = "txtPrecioNeto"
      Me.txtPrecioNeto.Size = New System.Drawing.Size(124, 20)
      Me.txtPrecioNeto.TabIndex = 9
      Me.txtPrecioNeto.Text = "0,000"
      Me.txtPrecioNeto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPrecioNeto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPrecioNeto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label6.Location = New System.Drawing.Point(8, 40)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 228
      Me.Label6.Text = "Medida Mínima"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label11.Location = New System.Drawing.Point(8, 112)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 235
      Me.Label11.Text = "Precio Ven. Neto"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(260, 88)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(96, 16)
      Me.Label2.TabIndex = 231
      Me.Label2.Text = "% Utilidad Neta"
      '
      'txtPorcentajeNeto
      '
      Me.txtPorcentajeNeto.BackColor = System.Drawing.Color.MistyRose
      Me.txtPorcentajeNeto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPorcentajeNeto.FormatString = "##,##0.000"
      Me.txtPorcentajeNeto.Location = New System.Drawing.Point(356, 84)
      Me.txtPorcentajeNeto.Name = "txtPorcentajeNeto"
      Me.txtPorcentajeNeto.Size = New System.Drawing.Size(80, 20)
      Me.txtPorcentajeNeto.TabIndex = 8
      Me.txtPorcentajeNeto.Text = "0,000"
      Me.txtPorcentajeNeto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPorcentajeNeto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPorcentajeNeto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label30
      '
      Me.Label30.BackColor = System.Drawing.Color.Transparent
      Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label30.Location = New System.Drawing.Point(256, 40)
      Me.Label30.Name = "Label30"
      Me.Label30.Size = New System.Drawing.Size(104, 16)
      Me.Label30.TabIndex = 216
      Me.Label30.Text = "Costo Según"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtPrecioMaxPor)
      Me.UiGroupBox1.Controls.Add(Me.Label16)
      Me.UiGroupBox1.Controls.Add(Me.txtPrecioMinPor)
      Me.UiGroupBox1.Controls.Add(Me.Label14)
      Me.UiGroupBox1.Controls.Add(Me.txtUtilidad)
      Me.UiGroupBox1.Controls.Add(Me.Label13)
      Me.UiGroupBox1.Controls.Add(Me.txtPrecioEqui)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.Controls.Add(Me.chkAlmacen)
      Me.UiGroupBox1.Controls.Add(Me.txtPorcentaje)
      Me.UiGroupBox1.Controls.Add(Me.Label10)
      Me.UiGroupBox1.Controls.Add(Me.txtItemPrecioDes)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.Controls.Add(Me.txtPrecio)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 250)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 136)
      Me.UiGroupBox1.TabIndex = 2
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPrecioMaxPor
      '
      Me.txtPrecioMaxPor.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPrecioMaxPor.FormatString = "##,##0.000"
      Me.txtPrecioMaxPor.Location = New System.Drawing.Point(116, 108)
      Me.txtPrecioMaxPor.Name = "txtPrecioMaxPor"
      Me.txtPrecioMaxPor.Size = New System.Drawing.Size(124, 20)
      Me.txtPrecioMaxPor.TabIndex = 8
      Me.txtPrecioMaxPor.Text = "0,000"
      Me.txtPrecioMaxPor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPrecioMaxPor.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPrecioMaxPor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label16.Location = New System.Drawing.Point(8, 111)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(90, 16)
      Me.Label16.TabIndex = 245
      Me.Label16.Text = "% Precio Max"
      '
      'txtPrecioMinPor
      '
      Me.txtPrecioMinPor.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPrecioMinPor.FormatString = "##,##0.000"
      Me.txtPrecioMinPor.Location = New System.Drawing.Point(116, 84)
      Me.txtPrecioMinPor.Name = "txtPrecioMinPor"
      Me.txtPrecioMinPor.Size = New System.Drawing.Size(124, 20)
      Me.txtPrecioMinPor.TabIndex = 7
      Me.txtPrecioMinPor.Text = "0,000"
      Me.txtPrecioMinPor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPrecioMinPor.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPrecioMinPor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label14.Location = New System.Drawing.Point(8, 87)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(116, 16)
      Me.Label14.TabIndex = 243
      Me.Label14.Text = "% Precio Min"
      '
      'txtUtilidad
      '
      Me.txtUtilidad.BackColor = System.Drawing.Color.MistyRose
      Me.txtUtilidad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtUtilidad.FormatString = "##,##0.000"
      Me.txtUtilidad.Location = New System.Drawing.Point(356, 60)
      Me.txtUtilidad.Name = "txtUtilidad"
      Me.txtUtilidad.Size = New System.Drawing.Size(80, 20)
      Me.txtUtilidad.TabIndex = 10
      Me.txtUtilidad.Text = "0,000"
      Me.txtUtilidad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtUtilidad.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtUtilidad.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label13.Location = New System.Drawing.Point(260, 64)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(100, 16)
      Me.Label13.TabIndex = 235
      Me.Label13.Text = "Utilidad Bruta"
      '
      'txtPrecioEqui
      '
      Me.txtPrecioEqui.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPrecioEqui.FormatString = "##,##0.000"
      Me.txtPrecioEqui.Location = New System.Drawing.Point(116, 60)
      Me.txtPrecioEqui.Name = "txtPrecioEqui"
      Me.txtPrecioEqui.Size = New System.Drawing.Size(124, 20)
      Me.txtPrecioEqui.TabIndex = 6
      Me.txtPrecioEqui.Text = "0,000"
      Me.txtPrecioEqui.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPrecioEqui.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPrecioEqui.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label5.Location = New System.Drawing.Point(8, 64)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(116, 16)
      Me.Label5.TabIndex = 230
      Me.Label5.Text = "Precio Venta Equi."
      '
      'chkAlmacen
      '
      Me.chkAlmacen.BackColor = System.Drawing.Color.Transparent
      Me.chkAlmacen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAlmacen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkAlmacen.Location = New System.Drawing.Point(244, 109)
      Me.chkAlmacen.Name = "chkAlmacen"
      Me.chkAlmacen.Size = New System.Drawing.Size(192, 16)
      Me.chkAlmacen.TabIndex = 17
      Me.chkAlmacen.Text = "Aplicar a Todas las L. Precios"
      Me.chkAlmacen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtPorcentaje
      '
      Me.txtPorcentaje.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPorcentaje.FormatString = "##,##0.000"
      Me.txtPorcentaje.Location = New System.Drawing.Point(356, 36)
      Me.txtPorcentaje.Name = "txtPorcentaje"
      Me.txtPorcentaje.Size = New System.Drawing.Size(80, 20)
      Me.txtPorcentaje.TabIndex = 9
      Me.txtPorcentaje.Text = "0,000"
      Me.txtPorcentaje.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPorcentaje.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPorcentaje.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label10.Location = New System.Drawing.Point(260, 40)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(100, 16)
      Me.Label10.TabIndex = 233
      Me.Label10.Text = "% Utilidad Bruta"
      '
      'txtItemPrecioDes
      '
      Me.txtItemPrecioDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemPrecioDes.Location = New System.Drawing.Point(116, 12)
      Me.txtItemPrecioDes.Name = "txtItemPrecioDes"
      Me.txtItemPrecioDes.Size = New System.Drawing.Size(320, 20)
      Me.txtItemPrecioDes.TabIndex = 4
      Me.txtItemPrecioDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemPrecioDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 16)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 228
      Me.Label8.Text = "Descripción"
      '
      'txtPrecio
      '
      Me.txtPrecio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPrecio.FormatString = "##,##0.000"
      Me.txtPrecio.Location = New System.Drawing.Point(116, 36)
      Me.txtPrecio.Name = "txtPrecio"
      Me.txtPrecio.Size = New System.Drawing.Size(124, 20)
      Me.txtPrecio.TabIndex = 5
      Me.txtPrecio.Text = "0,000"
      Me.txtPrecio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPrecio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPrecio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 40)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 224
      Me.Label4.Text = "Precio Venta"
      '
      'frmItemPrecioEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 419)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmItemPrecioEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Precio Edit"
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
      CType(Me.cboEncPrecio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.cboItem, System.ComponentModel.ISupportInitialize).EndInit()
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
            If DataSave() Then
               mlngID = moItemPrecio.ItemPrecioId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmItemPrecioEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmItemPrecioEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Precio de Venta"
         Else
            If mboolDesdePrecio Then
               Call HeaderReadOnly()
               Me.Text = "Editar Precio de Venta"
            Else
               Me.Text = "Editar Precio de Venta"
            End If
         End If
      Else
         Me.Text = "Nuevo Precio de Venta"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moItemPrecio
         txtItemPrecioId.Text = ToStr(.ItemPrecioId)

         If mboolDesdePrecio Then
            cboEncPrecio.Text = mstrEncPrecioDes
            Call ItemParametro(.ItemId)
            'Call txtMedidaIdLoad(mlngMedidaId)
            cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, .AlmacenId)
            'cboTipoCosteo.SelectedIndex = ListFindItem(cboTipoCosteo, mlngTipoCosteoId)
            dudOrden.Value = .Orden

            mlngTipoCosteoId = IIf(mlngEncTipoCosteoId = 0, mlngTipoCosteoId, mlngEncTipoCosteoId)
         Else
            'cboEncPrecio.SelectedIndex = ListFindItem(cboEncPrecio, .EncPrecioId)
            'Call txtEncPrecioIdLoad(ListPosition(cboEncPrecio, cboEncPrecio.SelectedIndex))
            cboEncPrecio.Value = ListFindItem(cboEncPrecio, .EncPrecioId)
            Call txtEncPrecioIdLoad(ListPosition(cboEncPrecio))
            'dudOrden.Value = .Orden
         End If

         cboItem.Value = ListFindItem(cboItem, .ItemId)
         cboItem.Tag = ToStr(cboItem.Text)
         Call txtMedidaIdLoad(mlngMedidaId)
         cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, .AlmacenId)
         cboTipoCosteo.SelectedIndex = ListFindItem(cboTipoCosteo, mlngTipoCosteoId)
         dudOrden.Value = .Orden
         txtPorcentaje.Text = ToDecStr(.Porcentaje)
         txtItemPrecioDes.Text = ToStr(.ItemPrecioDes)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtPrecio.Text = ToDecStr(.Precio)
         txtPrecioEqui.Text = ToDecStr(.PrecioEqui)
         txtPrecioMinPor.Text = ToDecStr(.PrecioMinPor)
         txtPrecioMaxPor.Text = ToDecStr(.PrecioMaxPor)

         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         If mlngMedidaId = mlngMedidaIdEqui Then
            txtPrecioEqui.ReadOnly = True
         End If

         ''If ToDecimal(txtPrecioNeto.Text) = 0 Then
         ''   Dim decCosto As Decimal = ToDecimal(txtPrecioCosto.Text)
         ''   If decCosto = 0 Then
         ''      decCosto = ToDecimal(ToDecimal(txtPrecio.Text) / ToDecimal((100 + ToDecimal(txtPorcentajeNeto.Text)) / 100))
         ''   End If
         ''   txtPrecioNeto.Text = ToDecStr(ToDecimal(txtPrecio.Text) * mdecPorImpuesto)
         ''   txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(decCosto, ToDecimal(txtPrecioNeto.Text)))
         ''End If

         txtPrecioNeto.Text = ToDecStr(ToDecimal(txtPrecio.Text) * mdecPorImpuesto)
         txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))
         txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))
         txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))

         Call ShowUpdatePrecioPorcentaje()

      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moItemPrecio
         txtItemPrecioId.Text = String.Empty
         'Call txtItemIdLoad(.ItemId)

         If mboolDesdePrecio Then
            cboEncPrecio.Text = mstrEncPrecioDes
            cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, .AlmacenId)
            dudOrden.Value = .Orden
            cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)

            cboItem.Value = Nothing
            cboItem.Tag = Nothing
            Call ItemParametro(0)
            txtMedidaId.Text = ""
            mlngTipoCosteoId = IIf(mlngEncTipoCosteoId = 0, mlngTipoCosteoId, mlngEncTipoCosteoId)

         Else
            cboEncPrecio.Value = ListFindItem(cboEncPrecio, .EncPrecioId)
            cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, .AlmacenId)
            dudOrden.Value = 0
            cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
            cboItem.Value = ListFindItem(cboItem, .ItemId)
            cboItem.Tag = ToStr(cboItem.Text)
            Call txtMedidaIdLoad(mlngMedidaId)
         End If

         cboTipoCosteo.SelectedIndex = ListFindItem(cboTipoCosteo, mlngTipoCosteoId)
         txtPorcentaje.Text = String.Empty
         txtItemPrecioDes.Text = String.Empty
         txtPrecio.Text = String.Empty
         txtPrecioEqui.Text = String.Empty
         txtPrecioMinPor.Text = 100
         txtPrecioMaxPor.Text = 100
         cboAlmacen.Tag = cboAlmacen.Text

         If mlngMedidaId = mlngMedidaIdEqui Then
            txtPrecioEqui.ReadOnly = True
         End If

         txtPrecioCosto.Text = String.Empty
         txtPrecioNeto.Text = String.Empty
         txtPorcentajeNeto.Text = String.Empty
         txtUtilidadNeto.Text = String.Empty
         txtUtilidad.Text = String.Empty
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtItemPrecioId.ReadOnly = True
      cboEncPrecio.ReadOnly = True
      cboItem.ReadOnly = True
      txtMedidaId.ReadOnly = True
      cboAlmacen.ReadOnly = True
      cboTipoCosteo.ReadOnly = True
      dudOrden.ReadOnly = True
      txtPorcentaje.ReadOnly = True
      txtItemPrecioDes.ReadOnly = True
      txtPrecio.ReadOnly = True
      txtPrecioEqui.ReadOnly = True
      txtUtilidad.ReadOnly = True
      txtPrecioNeto.ReadOnly = True
      txtPorcentajeNeto.ReadOnly = True
      txtUtilidadNeto.ReadOnly = True
      cboMoneda.ReadOnly = True
      txtPrecioMinPor.ReadOnly = True
      txtPrecioMaxPor.ReadOnly = True
      chkAlmacen.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub HeaderReadOnly()
      txtItemPrecioId.ReadOnly = True
      cboEncPrecio.ReadOnly = True
      cboItem.ReadOnly = True
      txtMedidaId.ReadOnly = True
      cboAlmacen.ReadOnly = True
      'cboTipoCosteo.ReadOnly = True
      dudOrden.ReadOnly = True
      'txtPorcentaje.ReadOnly = True
      'txtPrecio.ReadOnly = True
      'txtPrecioEqui.ReadOnly = True
      'txtUtilidad.ReadOnly = True
      'txtPrecioNeto.ReadOnly = True
      'txtPorcentajeNeto.ReadOnly = True
      'txtUtilidadNeto.ReadOnly = True
      cboMoneda.ReadOnly = True
      chkAlmacen.Enabled = False
      chkAlmacen.Visible = Not mboolDesdePrecio

      If mboolAdding Then
         cboItem.ReadOnly = False
      End If

      'cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moItemPrecio
         If Not mboolAdding Then
            .ItemPrecioId = ToLong(txtItemPrecioId.Text)
         End If

         .ItemId = ListPosition(cboItem)

         If Not mboolDesdePrecio Then
            '.EncPrecioId = ListPosition(cboEncPrecio, cboEncPrecio.SelectedIndex)
            .EncPrecioId = ListPosition(cboEncPrecio)
            .AlmacenId = ListPosition(cboAlmacen, cboAlmacen.SelectedIndex)
            .Orden = ToLong(dudOrden.Value)
            .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
            .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         End If

         .Porcentaje = ToDecimal(txtPorcentaje.Text)
         .ItemPrecioDes = ToStr(txtItemPrecioDes.Text)
         .Precio = ToDecimal(txtPrecio.Text)
         .PrecioEqui = ToDecimal(txtPrecioEqui.Text)
         .PrecioMinPor = ToDecimal(txtPrecioMinPor.Text)
         .PrecioMaxPor = ToDecimal(txtPrecioMaxPor.Text)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      If mboolDesdePrecio Then
         Call HeaderReadOnly()
         cboItem.Select()
      Else
         cboEncPrecio.Select()
      End If

   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If moItemPrecio.Validate Then
            If FormCheck() Then
               If mboolDesdePrecio Then
                  DataSave = True
               Else
                  moItemPrecio.EstadoId = EncPrecioEstadoIdFind(moItemPrecio.EncPrecioId)
                  If mboolAdding Then
                     DataSave = DataAdd()
                  Else
                     DataSave = DataUpdate()
                  End If

                  If DataSave Then
                     If chkAlmacen.Checked Then
                        DataSave = DataSavePreciosAll()
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

      If moItemPrecio.ItemId <> 0 Then

         If mboolDesdePrecio Then

            For Each lngId As Long In mqueItem
               If lngId = moItemPrecio.ItemId Then
                  strMsg &= "Item Duplicado"
                  Throw New Exception(strMsg)
                  Return False
               End If
            Next

         Else
            If moItemPrecio.EncPrecioId = 0 Then
               strMsg &= "Lista de Precio Inválido" & vbCrLf
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

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moItemPrecio.Insert() Then
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

         If moItemPrecio.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataSavePreciosAll() As Boolean
      Dim oEncPrecio As New clsEncPrecio(clsAppInfo.ConnectString)
      Dim oItemPrecio As New clsItemPrecio(clsAppInfo.ConnectString)
      Dim lngEncPrecioId As Long = moItemPrecio.EncPrecioId

      Try
         DataSavePreciosAll = False

         With oEncPrecio
            .SelectFilter = clsEncPrecio.SelectFilters.All
            .WhereFilter = clsEncPrecio.WhereFilters.Orden
            .OrderByFilter = clsEncPrecio.OrderByFilters.EncPrecioDes
            .EmpresaId = moItemPrecio.EmpresaId
            .Orden = moItemPrecio.Orden
            '.EncPrecioId = moItemPrecio.EncPrecioId
            '.EstadoId = clsEstado.ACTIVO

            If .Open Then
               Do While .Read
                  If (.EncPrecioId <> lngEncPrecioId) Then
                     ''Misma moneda
                     If (.MonedaId = moItemPrecio.MonedaId) Then
                        If (.EstadoId = clsEstado.ACTIVO) Then

                           moItemPrecio.EncPrecioId = oEncPrecio.EncPrecioId
                           moItemPrecio.AlmacenId = oEncPrecio.AlmacenId
                           moItemPrecio.EstadoId = oEncPrecio.EstadoId

                           With oItemPrecio
                              .SelectFilter = clsItemPrecio.SelectFilters.All
                              .WhereFilter = clsItemPrecio.WhereFilters.EncPrecioItemId
                              .EmpresaId = moItemPrecio.EmpresaId
                              .EncPrecioId = moItemPrecio.EncPrecioId
                              .ItemId = moItemPrecio.ItemId

                              If Not .Find Then
                                 If moItemPrecio.Insert() Then
                                    mboolAdding = False
                                    DataSavePreciosAll = True
                                 End If

                              Else
                                 .Porcentaje = moItemPrecio.Porcentaje
                                 .ItemPrecioDes = moItemPrecio.ItemPrecioDes
                                 .Precio = moItemPrecio.Precio
                                 .PrecioEqui = moItemPrecio.PrecioEqui
                                 .PrecioMinPor = moItemPrecio.PrecioMinPor
                                 .PrecioMaxPor = moItemPrecio.PrecioMaxPor

                                 If .Update() Then
                                    DataSavePreciosAll = True
                                 End If
                              End If
                           End With

                        End If
                     End If
                  End If
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

         oEncPrecio.Dispose()
         oItemPrecio.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      mboolChanged = False

      txtPrecioCosto.FormatString = DecimalMask()
      txtPrecio.FormatString = DecimalMask()
      txtPrecioEqui.FormatString = DecimalMask()
      txtPorcentaje.FormatString = DecimalMask()
      txtPrecioMinPor.FormatString = DecimalMaskDos()
      txtPrecioMaxPor.FormatString = DecimalMaskDos()
      txtUtilidad.FormatString = DecimalMask()
      txtPrecioNeto.FormatString = DecimalMask()
      txtPorcentajeNeto.FormatString = DecimalMask()
      txtUtilidadNeto.FormatString = DecimalMask()
      mdecPorImpuesto = 1 - clsAppInfo.IVA - clsAppInfo.IT

      chkCodBarra.Checked = clsAppInfo.CodBarra
      If Not chkCodBarra.Checked Then
         chkCodBarra.Visible = False
      End If

      chkCodBarra.Visible = IIf(mboolDesdePrecio, chkCodBarra.Visible, False)

   End Sub

   Private Sub ComboLoad()
      Call cboItemLoad()
      Call cboEncPrecioLoad()
      Call cboAlmacenLoad()
      Call cboTipoCosteoLoad()
      Call cboMonedaLoad()
      Call cboEstadoLoad()
   End Sub

   Private Sub cboEncPrecioLoad()
      Dim oEncPrecio As New clsEncPrecio(clsAppInfo.ConnectString)

      cboEncPrecio.DropDownList.Columns.Clear()

      Try
         With oEncPrecio
            .SelectFilter = clsEncPrecio.SelectFilters.ListBoxExt
            .WhereFilter = clsEncPrecio.WhereFilters.ListBoxExt
            .OrderByFilter = clsEncPrecio.OrderByFilters.EncPrecioDes
            .EmpresaId = moItemPrecio.EmpresaId
            .EncPrecioId = moItemPrecio.EncPrecioId
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
               With cboEncPrecio
                  .DropDownList.Columns.Add("EncPrecioId")
                  .DropDownList.Columns("EncPrecioId").DataMember = "EncPrecioId"
                  .DropDownList.Columns("EncPrecioId").Visible = False

                  .DropDownList.Columns.Add("Orden")
                  .DropDownList.Columns("Orden").Caption = "Orden"
                  .DropDownList.Columns("Orden").DataMember = "Orden"
                  .DropDownList.Columns("Orden").Width = 100

                  .DropDownList.Columns.Add("EncPrecioDesAbr")
                  .DropDownList.Columns("EncPrecioDesAbr").Caption = "Descripción Abr."
                  .DropDownList.Columns("EncPrecioDesAbr").DataMember = "EncPrecioDesAbr"
                  .DropDownList.Columns("EncPrecioDesAbr").Width = 150

                  .DropDownList.Columns.Add("EncPrecioDes")
                  .DropDownList.Columns("EncPrecioDes").Caption = "Descripción"
                  .DropDownList.Columns("EncPrecioDes").DataMember = "EncPrecioDes"
                  .DropDownList.Columns("EncPrecioDes").Width = 205
                  .DropDownList.Columns("EncPrecioDes").Visible = False

                  .DropDownList.Columns.Add("AlmacenDes")
                  .DropDownList.Columns("AlmacenDes").Caption = "Almacén"
                  .DropDownList.Columns("AlmacenDes").DataMember = "AlmacenDes"
                  .DropDownList.Columns("AlmacenDes").Width = 100

                  .DropDownList.Columns.Add("MonedaDes")
                  .DropDownList.Columns("MonedaDes").Caption = "Moneda"
                  .DropDownList.Columns("MonedaDes").DataMember = "MonedaDes"
                  .DropDownList.Columns("MonedaDes").Width = 100

                  .DataMember = oEncPrecio.TableName
                  .DataSource = oEncPrecio.DataSet

                  'If clsAppInfo.EncPrecioCodShow Then
                  '   .ValueMember = "EncPrecioId"
                  '   .DisplayMember = "EncPrecioCod"
                  '   chkEncPrecio.Checked = False
                  'Else
                  .ValueMember = "EncPrecioId"
                  .DisplayMember = "EncPrecioDesAbr"
                  'chkEncPrecio.Checked = True
                  'End If
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEncPrecio.Dispose()

      End Try
   End Sub

   Private Sub cboItemLoad()
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim oListItem As clsListItem

      cboItem.DropDownList.Columns.Clear()

      Try
         With oItem
            .SelectFilter = clsItem.SelectFilters.ListBox
            .WhereFilter = clsItem.WhereFilters.EstadoId

            If clsAppInfo.ItemCodShow Then
               .OrderByFilter = clsItem.OrderByFilters.ItemCod
            Else
               .OrderByFilter = clsItem.OrderByFilters.ItemDes
            End If

            .EmpresaId = moItemPrecio.EmpresaId
            .ItemId = moItemPrecio.ItemId
            .EstadoId = clsEstado.ACTIVO

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

   Private Sub cboAlmacenLoad()
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboAlmacen.Items.Clear()

      Try
         With oAlmacen
            .SelectFilter = clsAlmacen.SelectFilters.ListBox
            .WhereFilter = clsAlmacen.WhereFilters.TipoAlmacenId
            .OrderByFilter = clsAlmacen.OrderByFilters.AlmacenDes
            .EmpresaId = moItemPrecio.EmpresaId
            .TipoAlmacenId = clsTipoAlmacen.INVENTARIO
            .AlmacenId = moItemPrecio.AlmacenId
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.AlmacenId, .AlmacenDes)

                  cboAlmacen.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoCosteoLoad()
      Dim oItem As clsListItem

      cboTipoCosteo.Items.Clear()

      oItem = New clsListItem(1, "PPP")
      cboTipoCosteo.Items.Add(oItem)

      oItem = New clsListItem(2, "UPC")
      cboTipoCosteo.Items.Add(oItem)

      oItem = Nothing
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

   Private Sub txtMedidaIdLoad(ByVal lngMedidaId As Long)
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

      Try
         With oMedida
            .MedidaId = lngMedidaId

            If .FindByPK Then
               txtMedidaId.Tag = .MedidaId
               txtMedidaId.Text = .MedidaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()

      End Try
   End Sub

   Private Sub txtEncPrecioIdLoad(ByVal lngEncPrecioId As Long)
      Dim oEncPrecio As New clsEncPrecio(clsAppInfo.ConnectString)

      Try
         With oEncPrecio
            .EncPrecioId = lngEncPrecioId

            If .FindByPK Then
               cboAlmacen.SelectedIndex = ListFindItem(cboAlmacen, .AlmacenId)
               cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
               cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
               dudOrden.Value = .Orden
               If .EstadoId = 0 Then
                  chkAlmacen.Visible = False
                  chkAlmacen.Checked = False
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEncPrecio.Dispose()

      End Try
   End Sub

   Private Function TipoCambioFind(ByVal strFecha As String) As Decimal
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         TipoCambioFind = 1

         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               TipoCambioFind = .Valor
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Function

   Private Function ItemPrecioPPPPaquete(ByVal lngItemId As Long, ByVal lngAlmacenId As Long, ByVal lngMonedaId As Long) As Decimal

      Try

         Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

         With oComposicion
            .SelectFilter = clsComposicion.SelectFilters.All
            .WhereFilter = clsComposicion.WhereFilters.ItemId
            .EmpresaId = moItemPrecio.EmpresaId
            .ItemId = lngItemId

            ItemPrecioPPPPaquete = 0

            If .Open() Then

               While .Read
                  ItemPrecioPPPPaquete += ItemPrecioPPP(.ItemIdCom, lngAlmacenId, lngMonedaId) * .Cantidad
                  .MoveNext()
               End While
            End If

            .Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Function

   Private Function ItemPrecioUPCPaquete(ByVal lngItemId As Long, ByVal lngAlmacenId As Long, ByVal lngMonedaId As Long) As Decimal
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try

         With oComposicion
            .SelectFilter = clsComposicion.SelectFilters.All
            .WhereFilter = clsComposicion.WhereFilters.ItemId
            .EmpresaId = moItemPrecio.EmpresaId
            .ItemId = lngItemId

            ItemPrecioUPCPaquete = 0

            If .Open() Then

               While .Read
                  ItemPrecioUPCPaquete += ItemPrecioUPC(.ItemIdCom, lngAlmacenId, lngMonedaId) * .Cantidad
                  .MoveNext()

               End While
            End If

            .Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Function

   Private Function ItemPrecioPPP(ByVal lngItemId As Long, ByVal lngAlmacenId As Long, ByVal lngMonedaId As Long) As Decimal
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)

      Try
         ItemPrecioPPP = 0

         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.All
            .WhereFilter = clsItemSaldo.WhereFilters.ItemId
            .EmpresaId = moItemPrecio.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Find Then
               If mlngMonedaIdCos = 1 Then
                  If mlngMonedaIdCos = lngMonedaId Then
                     ItemPrecioPPP = .PrecioPPP
                  Else
                     ItemPrecioPPP = ToDecimal(.PrecioPPP / TipoCambioFind(ToDate(Now.Date)))
                  End If

               ElseIf mlngMonedaIdCos = 2 Then
                  If mlngMonedaIdCos = lngMonedaId Then
                     ItemPrecioPPP = .PrecioPPP
                  Else
                     ItemPrecioPPP = ToDecimal(.PrecioPPP * TipoCambioFind(ToDate(Now.Date)))
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

      End Try
   End Function

   Private Function ItemPrecioUPC(ByVal lngItemId As Long, ByVal lngAlmacenId As Long, ByVal lngMonedaId As Long) As Decimal
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)

      Try
         ItemPrecioUPC = 0

         With oItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.All
            .WhereFilter = clsItemSaldo.WhereFilters.ItemId
            .EmpresaId = moItemPrecio.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .AlmacenId = lngAlmacenId
            .ItemId = lngItemId

            If .Find Then
               If mlngMonedaIdCos = 1 Then
                  If mlngMonedaIdCos = lngMonedaId Then
                     ItemPrecioUPC = .PrecioUPC
                  Else
                     ItemPrecioUPC = ToDecimal(.PrecioUPC / TipoCambioFind(ToDate(Now.Date)))
                  End If

               ElseIf mlngMonedaIdCos = 2 Then
                  If mlngMonedaIdCos = lngMonedaId Then
                     ItemPrecioUPC = .PrecioUPC
                  Else
                     ItemPrecioUPC = ToDecimal(.PrecioUPC * TipoCambioFind(ToDate(Now.Date)))
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

      End Try
   End Function

   Private Sub ItemParametro(ByVal lngItemId As Long)
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         mlngTipoItemId = 0
         mlngTipoCosteoId = 0
         mlngMedidaId = 0
         mlngMedidaIdEqui = 0
         mdecMedidaCantEqui = 0
         mlngMonedaIdVen = 0
         mlngMonedaIdCos = 0

         With oItem
            .ItemId = lngItemId

            If .FindByPK Then
               mlngTipoItemId = ToLong(.TipoItemId)
               mlngTipoCosteoId = ToLong(.TipoCosteoId)
               mlngMedidaId = ToLong(.MedidaId)
               mlngMedidaIdEqui = ToLong(.MedidaIdEqui)
               mdecMedidaCantEqui = ToDecimal(.MedidaCantEqui)
               mlngMonedaIdVen = ToLong(.MonedaIdVen)
               mlngMonedaIdCos = ToLong(.MonedaIdCos)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Function EncPrecioEstadoIdFind(ByVal lngEncPrecioId As Long) As Long
      Dim oEncPrecio As New clsEncPrecio(clsAppInfo.ConnectString)

      Try
         EncPrecioEstadoIdFind = 0

         With oEncPrecio
            .EncPrecioId = lngEncPrecioId

            If .FindByPK Then
               EncPrecioEstadoIdFind = .EstadoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEncPrecio.Dispose()

      End Try
   End Function

   Private Function ItemIdFind(ByVal strItemCod As String) As Long
      Dim oItemBarra As New clsItemBarra(clsAppInfo.ConnectString)

      ItemIdFind = 0

      Try
         With oItemBarra
            .SelectFilter = clsItemBarra.SelectFilters.All
            .WhereFilter = clsItemBarra.WhereFilters.ItemBarraCod
            .EmpresaId = moItemPrecio.EmpresaId
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

   Private Function PrecioVentaPor(ByVal decPrecioCos As Decimal, ByVal decPrecio As Decimal) As Decimal
      PrecioVentaPor = ToDecimal(((decPrecio - decPrecioCos) * 100) / ToDivByCero(decPrecioCos))
   End Function

   Private Function PrecioVentaMonto(ByVal decPrecioCos As Decimal, ByVal decPorcentaje As Decimal) As Decimal
      PrecioVentaMonto = ToDecimal(decPrecioCos + ToDecimal((decPrecioCos * decPorcentaje) / 100))
   End Function

   Private Sub ShowUpdatePrecioPorcentaje()
      If mboolAdding Or mboolEditing Then
         If ToDecimal(txtPrecioCosto.Text) > 0 Then
            Dim decPorcentaje As Decimal = PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecio.Text))
            Dim decPrecio As Decimal = PrecioVentaMonto(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPorcentaje.Text))

            If ToDecimal(txtPorcentaje.Text) <> decPorcentaje Then
               decPrecio = PrecioVentaMonto(ToDecimal(txtPrecioCosto.Text), ToDecimal(decPorcentaje))
               If (decPrecio > 0) Then
                  chkPorcentaje.Visible = mboolShowChk
                  chkPrecio.Visible = mboolShowChk
               Else
                  chkPorcentaje.Visible = mboolShowChk
                  chkPrecio.Visible = False
               End If
            ElseIf ToDecimal(txtPrecio.Text) <> decPrecio Then
               decPorcentaje = PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(decPrecio))
               If (decPorcentaje > 0) Then
                  chkPorcentaje.Visible = mboolShowChk
                  chkPrecio.Visible = mboolShowChk
               Else
                  chkPorcentaje.Visible = False
                  chkPrecio.Visible = mboolShowChk
               End If
            Else
               chkPorcentaje.Visible = False
               chkPrecio.Visible = False
            End If

         Else
            chkPorcentaje.Visible = False
            chkPrecio.Visible = False
         End If
      End If
   End Sub

   Private Sub cboEncPrecio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEncPrecio.ValueChanged
      'If cboEncPrecio.Tag <> cboEncPrecio.Text Then
      '   cboEncPrecio.Tag = cboEncPrecio.Text
      '   Call txtEncPrecioIdLoad(ListPosition(cboEncPrecio, cboEncPrecio.SelectedIndex))
      'End If

      If (mboolAdding Or mboolEditing) And (Not mboolShow) Then
         Call txtEncPrecioIdLoad(ListPosition(cboEncPrecio))
      End If

   End Sub

   Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged

      If cboAlmacen.Tag <> cboAlmacen.Text Then
         cboAlmacen.Tag = cboAlmacen.Text

         If ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex) = 1 Then

            If mlngTipoItemId = 1 Then 'Inventario
               'txtPrecioCosto.Text = ItemPrecioPPP(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex))
               txtPrecioCosto.Text = ItemPrecioPPP(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            ElseIf mlngTipoItemId = 3 Then 'Paquete
               'txtPrecioCosto.Text = ItemPrecioPPPPaquete(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex))
               txtPrecioCosto.Text = ItemPrecioPPPPaquete(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            End If

         ElseIf ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex) = 2 Then
            If mlngTipoItemId = 1 Then 'Inventario
               'txtPrecioCosto.Text = ItemPrecioUPC(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex))
               txtPrecioCosto.Text = ItemPrecioUPC(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            ElseIf mlngTipoItemId = 3 Then 'Paquete
               'txtPrecioCosto.Text = ItemPrecioUPCPaquete(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex))
               txtPrecioCosto.Text = ItemPrecioUPCPaquete(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            End If

         End If
      End If
   End Sub

   Private Sub cboItem_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItem.ValueChanged
      If (mboolAdding Or mboolEditing) And mboolDesdePrecio Then
         Call ItemParametro(ListPosition(cboItem))
         Call txtMedidaIdLoad(mlngMedidaId)
         cboTipoCosteo.SelectedIndex = ListFindItem(cboTipoCosteo, IIf(mlngEncTipoCosteoId = 0, mlngTipoCosteoId, mlngEncTipoCosteoId))
         txtPrecioCosto.Text = 0

         If ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex) = 1 Then
            If mlngTipoItemId = 1 Then 'Inventario
               txtPrecioCosto.Text = ItemPrecioPPP(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            ElseIf mlngTipoItemId = 3 Then 'Paquete
               txtPrecioCosto.Text = ItemPrecioPPPPaquete(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            End If

         ElseIf ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex) = 2 Then
            If mlngTipoItemId = 1 Then 'Inventario
               txtPrecioCosto.Text = ItemPrecioUPC(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            ElseIf mlngTipoItemId = 3 Then 'Paquete
               txtPrecioCosto.Text = ItemPrecioUPCPaquete(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            End If
         End If
      End If

   End Sub

   Private Sub cboItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboItem.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F2 Then
            If mboolAdding And mboolDesdePrecio Then
               Dim frm As New frmItemFind

               Try
                  With frm
                     .EmpresaId = moItemPrecio.EmpresaId
                     '.AlmacenId = moItemPrecio.AlmacenId

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
            If mboolAdding And mboolDesdePrecio Then
               Dim frm As New frmItemEdit
               Dim oItem As New clsItem(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oItem.EmpresaId = moItemPrecio.EmpresaId

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
            If chkCodBarra.Checked And mboolDesdePrecio Then
               Dim lngItemId As Long
               Dim strItemCod As String = ToStr(cboItem.Text)

               If strItemCod <> "" Then
                  lngItemId = ItemIdFind(strItemCod)

                  If lngItemId > 0 Then
                     cboItem.Value = Nothing
                     cboItem.Tag = Nothing
                     cboItem.Value = ListFindItem(cboItem, lngItemId)
                     cboItem.DropDownList.Refetch()
                  End If
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboTipoCosteo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCosteo.SelectedIndexChanged
      If cboTipoCosteo.Tag <> cboTipoCosteo.Text Then
         cboTipoCosteo.Tag = cboTipoCosteo.Text

         If ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex) = 1 Then
            'txtPrecioCosto.Text = ItemPrecioPPP(moItemPrecio.ItemId, ListPosition(cboAlmacen, cboAlmacen.SelectedIndex))
            If mlngTipoItemId = 1 Then 'Inventario
               txtPrecioCosto.Text = ItemPrecioPPP(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            ElseIf mlngTipoItemId = 3 Then 'Paquete
               txtPrecioCosto.Text = ItemPrecioPPPPaquete(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            End If

         ElseIf ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex) = 2 Then
            If mlngTipoItemId = 1 Then 'Inventario
               txtPrecioCosto.Text = ItemPrecioUPC(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            ElseIf mlngTipoItemId = 3 Then 'Paquete
               txtPrecioCosto.Text = ItemPrecioUPCPaquete(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            End If
         End If
      End If
   End Sub

   Private Sub cboMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.SelectedIndexChanged
      If cboMoneda.Tag <> cboMoneda.Text Then
         cboMoneda.Tag = cboMoneda.Text

         If ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex) = 1 Then
            If mlngTipoItemId = 1 Then 'Inventario
               txtPrecioCosto.Text = ItemPrecioPPP(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            ElseIf mlngTipoItemId = 3 Then 'Paquete
               txtPrecioCosto.Text = ItemPrecioPPPPaquete(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            End If

         ElseIf ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex) = 2 Then
            If mlngTipoItemId = 1 Then 'Inventario
               txtPrecioCosto.Text = ItemPrecioUPC(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            ElseIf mlngTipoItemId = 3 Then 'Paquete
               txtPrecioCosto.Text = ItemPrecioUPCPaquete(ListPosition(cboItem), ListPosition(cboAlmacen, cboAlmacen.SelectedIndex), ListPosition(cboMoneda, cboMoneda.SelectedIndex))

            End If
         End If
      End If
   End Sub

   Private Sub chkItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItem.CheckedChanged
      If chkItem.Checked Then
         cboItem.DisplayMember = "ItemDes"
      Else
         cboItem.DisplayMember = "ItemCod"
      End If

      If (mboolAdding Or mboolEditing) And (mboolDesdePrecio) And (Not mboolShow) Then
         Dim oColum As Janus.Windows.GridEX.GridEXColumn = cboItem.DropDownList.Columns().Item(cboItem.DisplayMember)
         Dim gridEXSortKey As Janus.Windows.GridEX.GridEXSortKey = New Janus.Windows.GridEX.GridEXSortKey(oColum, Janus.Windows.GridEX.SortOrder.Ascending)

         If cboItem.DropDownList.SortKeys.Count > 0 Then
            cboItem.DropDownList.SortKeys.Clear()
         End If

         cboItem.DropDownList.SortKeys.Add(gridEXSortKey)
      End If
     
      If (mboolAdding Or mboolEditing) And (Not mboolShow) Then
         If mboolAdding Then
            If ListPosition(cboItem) <> 0 Then
               cboItem.Tag = cboItem.Text
            Else
               Dim str As String = cboItem.Text
               cboItem.Text = String.Empty
               cboItem.Text = str
            End If
         Else
            cboItem.Tag = cboItem.Text
         End If
      End If
   End Sub

   Private Sub chkPorcentaje_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPorcentaje.CheckedChanged
      If chkPorcentaje.ContainsFocus Then
         If chkPorcentaje.Checked Then
            txtPorcentaje.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecio.Text)))
            txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))

            txtPrecioNeto.Text = ToDecStr(ToDecimal(txtPrecio.Text) * mdecPorImpuesto)
            txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))
            txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))

            If mlngMedidaId = mlngMedidaIdEqui Then
               txtPrecioEqui.Text = txtPrecio.Text
            Else
               txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
            End If

            chkPorcentaje.Visible = False
            chkPorcentaje.Checked = False
            chkPrecio.Visible = False
         End If
      End If
   End Sub

   Private Sub chkPrecio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrecio.CheckedChanged
      If chkPrecio.ContainsFocus Then
         If chkPrecio.Checked Then
            txtPrecio.Text = ToDecStr(PrecioVentaMonto(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPorcentaje.Text)))
            txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))

            txtPrecioNeto.Text = ToDecStr(ToDecimal(txtPrecio.Text) * mdecPorImpuesto)
            txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))
            txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))

            If mlngMedidaId = mlngMedidaIdEqui Then
               txtPrecioEqui.Text = txtPrecio.Text
            Else
               txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
            End If

            chkPrecio.Visible = False
            chkPrecio.Checked = False
            chkPorcentaje.Visible = False
         End If
      End If
   End Sub

   Private Sub txtPorcentajeNeto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentajeNeto.TextChanged
      If txtPorcentajeNeto.ContainsFocus Then
         txtPrecioNeto.Text = ToDecStr(PrecioVentaMonto(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPorcentajeNeto.Text)))
         txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))

         txtPrecio.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) / mdecPorImpuesto)
         txtPorcentaje.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecio.Text)))
         txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))

         If mlngMedidaId = mlngMedidaIdEqui Then
            txtPrecioEqui.Text = txtPrecio.Text
         Else
            txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
         End If

      End If
   End Sub

   Private Sub txtPorcentaje_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentaje.TextChanged
      If txtPorcentaje.ContainsFocus Then
         ''txtPrecio.Text = ToDecStr(ToDecimal(txtPrecioCosto.Text) + ToDecimal((ToDecimal(txtPrecioCosto.Text) * ToDecimal(txtPorcentaje.Text)) / 100))
         txtPrecio.Text = ToDecStr(PrecioVentaMonto(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPorcentaje.Text)))
         txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))

         txtPrecioNeto.Text = ToDecStr(ToDecimal(txtPrecio.Text) * mdecPorImpuesto)
         txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))
         txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))

         If mlngMedidaId = mlngMedidaIdEqui Then
            txtPrecioEqui.Text = txtPrecio.Text
         Else
            txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
         End If

      End If
   End Sub

   Private Sub txtPrecioNeto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecioNeto.TextChanged
      If txtPrecioNeto.ContainsFocus Then
         txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))
         txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))

         txtPrecio.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) / mdecPorImpuesto)
         txtPorcentaje.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecio.Text)))
         txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))

         If mlngMedidaId = mlngMedidaIdEqui Then
            txtPrecioEqui.Text = txtPrecio.Text
         Else
            txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
         End If

      End If
   End Sub

   Private Sub txtPrecio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.TextChanged
      If txtPrecio.ContainsFocus Then
         ''txtPorcentaje.Text = ToDecStr(((ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text)) * 100) / ToDivByCero(txtPrecioCosto.Text))
         txtPorcentaje.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecio.Text)))
         txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))

         txtPrecioNeto.Text = ToDecStr(ToDecimal(txtPrecio.Text) * mdecPorImpuesto)
         txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))
         txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))

         If mlngMedidaId = mlngMedidaIdEqui Then
            txtPrecioEqui.Text = txtPrecio.Text
         Else
            txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
         End If
      End If
   End Sub

   Private Sub txtUtilidadNeto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUtilidadNeto.TextChanged
      If txtUtilidadNeto.ContainsFocus Then
         txtPrecioNeto.Text = ToDecStr(ToDecimal(txtUtilidadNeto.Text) + ToDecimal(txtPrecioCosto.Text))
         txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))

         txtPrecio.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) / mdecPorImpuesto)
         txtPorcentaje.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecio.Text)))
         txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))

         If mlngMedidaId = mlngMedidaIdEqui Then
            txtPrecioEqui.Text = txtPrecio.Text
         Else
            txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
         End If
      End If
   End Sub

   Private Sub txtUtilidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUtilidad.TextChanged
      If txtUtilidad.ContainsFocus Then
         txtPrecio.Text = ToDecStr(ToDecimal(txtUtilidad.Text) + ToDecimal(txtPrecioCosto.Text))
         txtPorcentaje.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecio.Text)))

         txtPrecioNeto.Text = ToDecStr(ToDecimal(txtPrecio.Text) * mdecPorImpuesto)
         txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))
         txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))

         If mlngMedidaId = mlngMedidaIdEqui Then
            txtPrecioEqui.Text = txtPrecio.Text
         Else
            txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
         End If
      End If
   End Sub

   Private Sub txtPrecioCosto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioCosto.ValueChanged
      If Not mboolShow Then

         Call ShowUpdatePrecioPorcentaje()

         'If ToDecimal(txtPrecio.Text) <> 0 Then
         '   txtPorcentaje.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecio.Text)))
         '   txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))
         'Else
         '   txtPrecio.Text = ToDecStr(PrecioVentaMonto(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPorcentaje.Text)))
         '   txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))
         'End If

         txtUtilidad.Text = ToDecStr(ToDecimal(txtPrecio.Text) - ToDecimal(txtPrecioCosto.Text))
         txtPrecioNeto.Text = ToDecStr(ToDecimal(txtPrecio.Text) * mdecPorImpuesto)
         txtPorcentajeNeto.Text = ToDecStr(PrecioVentaPor(ToDecimal(txtPrecioCosto.Text), ToDecimal(txtPrecioNeto.Text)))
         txtUtilidadNeto.Text = ToDecStr(ToDecimal(txtPrecioNeto.Text) - ToDecimal(txtPrecioCosto.Text))

         'If mlngMedidaId = mlngMedidaIdEqui Then
         '   txtPrecioEqui.Text = txtPrecio.Text
         'Else
         '   txtPrecioEqui.Text = ToDecimal(ToDecimal(txtPrecio.Text) * mdecMedidaCantEqui)
         'End If

      End If
   End Sub

   Private Sub frmItemPrecioEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If Me.ActiveControl.Name = "txtPorcentaje" Then
            mboolPorcentaje = True
            mboolPrecio = False
         ElseIf Me.ActiveControl.Name = "txtPrecio" Then
            mboolPorcentaje = False
            mboolPrecio = True
         Else
            mboolPorcentaje = False
            mboolPrecio = False
         End If

         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moItemPrecio.ItemPrecioId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmItemPrecioEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moItemPrecio.Dispose()
      Call ClearMemory()
   End Sub

End Class
