Public Class frmItemFind
   Inherits System.Windows.Forms.Form

   Private moItem As clsItem
   Private mlngEmpresaId As Long
   Private mlngAlmacenId As Long

   Private mstrSepDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents grpBusquedaDT As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents btnBuscar As Janus.Windows.EditControls.UIButton
   Friend WithEvents ebrDatoTecnico As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdDatoTecnico As Janus.Windows.GridEX.GridEX
   Friend WithEvents cboLinea As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblLinea As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optBusquedaDT As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optBusquedaSust As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optBusquedaGen As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents ebrSustitucion As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl2 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdSustitucion As Janus.Windows.GridEX.GridEX
   Private mlngID As Long

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
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
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents Check As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Consultar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Consultar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemFind))
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Me.ExplorerBarContainerControl2 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdSustitucion = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl1 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdDatoTecnico = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Check1 = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Consultar1 = New Janus.Windows.UI.CommandBars.UICommand("Consultar")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Check = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Consultar = New Janus.Windows.UI.CommandBars.UICommand("Consultar")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.optBusquedaDT = New Janus.Windows.EditControls.UIRadioButton
      Me.optBusquedaSust = New Janus.Windows.EditControls.UIRadioButton
      Me.optBusquedaGen = New Janus.Windows.EditControls.UIRadioButton
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrSustitucion = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpBusquedaDT = New Janus.Windows.EditControls.UIGroupBox
      Me.btnBuscar = New Janus.Windows.EditControls.UIButton
      Me.ebrDatoTecnico = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.cboLinea = New Janus.Windows.EditControls.UIComboBox
      Me.lblLinea = New System.Windows.Forms.Label
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl2.SuspendLayout()
      CType(Me.grdSustitucion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl1.SuspendLayout()
      CType(Me.grdDatoTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrSustitucion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrSustitucion.SuspendLayout()
      CType(Me.grpBusquedaDT, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpBusquedaDT.SuspendLayout()
      CType(Me.ebrDatoTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrDatoTecnico.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl2
      '
      Me.ExplorerBarContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl2.Controls.Add(Me.grdSustitucion)
      Me.ExplorerBarContainerControl2.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl2.Name = "ExplorerBarContainerControl2"
      Me.ExplorerBarContainerControl2.Size = New System.Drawing.Size(728, 63)
      Me.ExplorerBarContainerControl2.TabIndex = 1
      '
      'grdSustitucion
      '
      Me.grdSustitucion.AllowCardSizing = False
      Me.grdSustitucion.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdSustitucion.AlternatingColors = True
      Me.grdSustitucion.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdSustitucion.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdSustitucion.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdSustitucion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
      Me.grdSustitucion.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdSustitucion.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdSustitucion.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdSustitucion.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdSustitucion.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdSustitucion.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdSustitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdSustitucion.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdSustitucion.GroupByBoxVisible = False
      Me.grdSustitucion.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdSustitucion.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdSustitucion.Location = New System.Drawing.Point(0, 0)
      Me.grdSustitucion.Name = "grdSustitucion"
      Me.grdSustitucion.RecordNavigator = True
      Me.grdSustitucion.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdSustitucion.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdSustitucion.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdSustitucion.Size = New System.Drawing.Size(728, 63)
      Me.grdSustitucion.TabIndex = 3
      Me.grdSustitucion.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdSustitucion.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdSustitucion.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdSustitucion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl1
      '
      Me.ExplorerBarContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl1.Controls.Add(Me.grdDatoTecnico)
      Me.ExplorerBarContainerControl1.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl1.Name = "ExplorerBarContainerControl1"
      Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(720, 62)
      Me.ExplorerBarContainerControl1.TabIndex = 1
      '
      'grdDatoTecnico
      '
      Me.grdDatoTecnico.AllowCardSizing = False
      Me.grdDatoTecnico.AlternatingColors = True
      Me.grdDatoTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdDatoTecnico.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdDatoTecnico.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdDatoTecnico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdDatoTecnico.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdDatoTecnico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdDatoTecnico.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdDatoTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdDatoTecnico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdDatoTecnico.GroupByBoxVisible = False
      Me.grdDatoTecnico.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdDatoTecnico.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdDatoTecnico.Location = New System.Drawing.Point(0, 0)
      Me.grdDatoTecnico.Name = "grdDatoTecnico"
      Me.grdDatoTecnico.RecordNavigator = True
      Me.grdDatoTecnico.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdDatoTecnico.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdDatoTecnico.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdDatoTecnico.Size = New System.Drawing.Size(720, 62)
      Me.grdDatoTecnico.TabIndex = 3
      Me.grdDatoTecnico.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdDatoTecnico.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDatoTecnico.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDatoTecnico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdMain)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 55)
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
      Me.grdMain.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
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
      Me.grdMain.Size = New System.Drawing.Size(728, 55)
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Refrescar, Me.ViewAll2, Me.Exit3, Me.Check, Me.Consultar})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Check1, Me.Separator5, Me.Consultar1, Me.Separator1, Me.Refrescar1, Me.Separator6, Me.ViewAll1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(432, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Check1
      '
      Me.Check1.Key = "Check"
      Me.Check1.Name = "Check1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Consultar1
      '
      Me.Consultar1.Key = "Consultar"
      Me.Consultar1.Name = "Consultar1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
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
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 1
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'ViewAll2
      '
      Me.ViewAll2.ImageIndex = 2
      Me.ViewAll2.Key = "ViewAll"
      Me.ViewAll2.Name = "ViewAll2"
      Me.ViewAll2.Text = "Ver Todos"
      '
      'Exit3
      '
      Me.Exit3.ImageIndex = 3
      Me.Exit3.Key = "Exit"
      Me.Exit3.Name = "Exit3"
      Me.Exit3.Text = "Salir"
      '
      'Check
      '
      Me.Check.ImageIndex = 0
      Me.Check.Key = "Check"
      Me.Check.Name = "Check"
      Me.Check.Text = "Seleccionar"
      '
      'Consultar
      '
      Me.Consultar.ImageIndex = 4
      Me.Consultar.Key = "Consultar"
      Me.Consultar.Name = "Consultar"
      Me.Consultar.Text = "Consultar"
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
      Me.TopRebar1.Controls.Add(Me.UiGroupBox3)
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(752, 28)
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.optBusquedaDT)
      Me.UiGroupBox3.Controls.Add(Me.optBusquedaSust)
      Me.UiGroupBox3.Controls.Add(Me.optBusquedaGen)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(472, -1)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(264, 28)
      Me.UiGroupBox3.TabIndex = 21
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optBusquedaDT
      '
      Me.optBusquedaDT.BackColor = System.Drawing.Color.Transparent
      Me.optBusquedaDT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optBusquedaDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optBusquedaDT.Location = New System.Drawing.Point(108, 9)
      Me.optBusquedaDT.Name = "optBusquedaDT"
      Me.optBusquedaDT.Size = New System.Drawing.Size(48, 16)
      Me.optBusquedaDT.TabIndex = 16
      Me.optBusquedaDT.Text = "D.T."
      Me.optBusquedaDT.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optBusquedaSust
      '
      Me.optBusquedaSust.BackColor = System.Drawing.Color.Transparent
      Me.optBusquedaSust.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optBusquedaSust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optBusquedaSust.Location = New System.Drawing.Point(176, 9)
      Me.optBusquedaSust.Name = "optBusquedaSust"
      Me.optBusquedaSust.Size = New System.Drawing.Size(80, 16)
      Me.optBusquedaSust.TabIndex = 17
      Me.optBusquedaSust.Text = "Sustitución"
      Me.optBusquedaSust.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optBusquedaGen
      '
      Me.optBusquedaGen.BackColor = System.Drawing.Color.Transparent
      Me.optBusquedaGen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optBusquedaGen.Checked = True
      Me.optBusquedaGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optBusquedaGen.Location = New System.Drawing.Point(8, 9)
      Me.optBusquedaGen.Name = "optBusquedaGen"
      Me.optBusquedaGen.Size = New System.Drawing.Size(76, 16)
      Me.optBusquedaGen.TabIndex = 15
      Me.optBusquedaGen.TabStop = True
      Me.optBusquedaGen.Text = "Genérica"
      Me.optBusquedaGen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      Me.uiBackground.Controls.Add(Me.ebrSustitucion)
      Me.uiBackground.Controls.Add(Me.grpBusquedaDT)
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 338)
      Me.uiBackground.TabIndex = 5
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrSustitucion
      '
      Me.ebrSustitucion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrSustitucion.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrSustitucion.Controls.Add(Me.ExplorerBarContainerControl2)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl2
      ExplorerBarGroup1.ContainerHeight = 64
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrSustitucion.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrSustitucion.GroupSeparation = 4
      Me.ebrSustitucion.Location = New System.Drawing.Point(4, 144)
      Me.ebrSustitucion.Name = "ebrSustitucion"
      Me.ebrSustitucion.Size = New System.Drawing.Size(744, 96)
      Me.ebrSustitucion.TabIndex = 22
      Me.ebrSustitucion.Text = "ExplorerBar2"
      Me.ebrSustitucion.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrSustitucion.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrSustitucion.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrSustitucion.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'grpBusquedaDT
      '
      Me.grpBusquedaDT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpBusquedaDT.BackColor = System.Drawing.Color.Transparent
      Me.grpBusquedaDT.Controls.Add(Me.btnBuscar)
      Me.grpBusquedaDT.Controls.Add(Me.ebrDatoTecnico)
      Me.grpBusquedaDT.Controls.Add(Me.cboLinea)
      Me.grpBusquedaDT.Controls.Add(Me.lblLinea)
      Me.grpBusquedaDT.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpBusquedaDT.Location = New System.Drawing.Point(4, 4)
      Me.grpBusquedaDT.Name = "grpBusquedaDT"
      Me.grpBusquedaDT.Size = New System.Drawing.Size(744, 137)
      Me.grpBusquedaDT.TabIndex = 0
      Me.grpBusquedaDT.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'btnBuscar
      '
      Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnBuscar.ImageIndex = 2
      Me.btnBuscar.ImageList = Me.ilsMain
      Me.btnBuscar.Location = New System.Drawing.Point(271, 12)
      Me.btnBuscar.Name = "btnBuscar"
      Me.btnBuscar.Size = New System.Drawing.Size(36, 20)
      Me.btnBuscar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnBuscar.TabIndex = 271
      Me.btnBuscar.Tag = ""
      Me.btnBuscar.ToolTipText = "Buscar"
      Me.btnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'ebrDatoTecnico
      '
      Me.ebrDatoTecnico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrDatoTecnico.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrDatoTecnico.Controls.Add(Me.ExplorerBarContainerControl1)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl1
      ExplorerBarGroup2.ContainerHeight = 63
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ebrDatoTecnico.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ebrDatoTecnico.GroupSeparation = 4
      Me.ebrDatoTecnico.Location = New System.Drawing.Point(4, 36)
      Me.ebrDatoTecnico.Name = "ebrDatoTecnico"
      Me.ebrDatoTecnico.Size = New System.Drawing.Size(736, 95)
      Me.ebrDatoTecnico.TabIndex = 2
      Me.ebrDatoTecnico.Text = "ExplorerBar2"
      Me.ebrDatoTecnico.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrDatoTecnico.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDatoTecnico.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDatoTecnico.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'cboLinea
      '
      Me.cboLinea.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboLinea.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboLinea.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboLinea.Location = New System.Drawing.Point(69, 11)
      Me.cboLinea.Name = "cboLinea"
      Me.cboLinea.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboLinea.Size = New System.Drawing.Size(191, 20)
      Me.cboLinea.TabIndex = 1
      Me.cboLinea.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblLinea
      '
      Me.lblLinea.BackColor = System.Drawing.Color.Transparent
      Me.lblLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblLinea.Location = New System.Drawing.Point(10, 15)
      Me.lblLinea.Name = "lblLinea"
      Me.lblLinea.Size = New System.Drawing.Size(61, 16)
      Me.lblLinea.TabIndex = 270
      Me.lblLinea.Text = "Línea"
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup3.Container = True
      ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup3.ContainerHeight = 56
      ExplorerBarGroup3.Expandable = False
      ExplorerBarGroup3.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 248)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 88)
      Me.ebrMain.TabIndex = 1
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow})
      '
      'mnuShow
      '
      Me.mnuShow.Index = 0
      Me.mnuShow.Text = "Consultar"
      '
      'frmItemFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 366)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MinimizeBox = False
      Me.Name = "frmItemFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Buscar Item"
      Me.ExplorerBarContainerControl2.ResumeLayout(False)
      CType(Me.grdSustitucion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl1.ResumeLayout(False)
      CType(Me.grdDatoTecnico, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrSustitucion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrSustitucion.ResumeLayout(False)
      CType(Me.grpBusquedaDT, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpBusquedaDT.ResumeLayout(False)
      CType(Me.ebrDatoTecnico, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrDatoTecnico.ResumeLayout(False)
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
         Case "Check"
            Call SeleccionarItem()

         Case "Consultar"
            Call DataShow()

         Case "Refrescar"
            Call Actualizar()

         Case "ViewAll"
            Call DataViewAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmItemFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmItemFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True
      mboolChanged = False

      Call FormInit()
      Call ComboLoad()

      Call BusquedaGenericaVisible()
      Call grdMainLoad()

      grdMain.Select()
      grdMain.Col = IIf(clsAppInfo.ItemCodShow, 1, 2)
      grdMain.Row = grdMain.filterRowPosition

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub Actualizar()
      If optBusquedaGen.Checked Then
         Call grdMainLoad()
      End If

   End Sub

   Private Sub BusquedaGenericaVisible()

      grpBusquedaDT.Visible = False
      ebrSustitucion.Visible = False

      ebrMain.Location = New System.Drawing.Point(5, 4)
      ebrMain.Height = Me.uiBackground.Height - 6

   End Sub

   Private Sub grdMainLoad()

      Try
         With moItem
            .SelectFilter = clsItem.SelectFilters.GridFind
            .WhereFilter = clsItem.WhereFilters.GridFind
            .OrderByFilter = clsItem.OrderByFilters.GridFind
            .EmpresaId = mlngEmpresaId
            .EstadoId = 1

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

   Private Sub grdMainLoad_BusquedaDT(ByVal strConsulta As String, ByVal lngLineaId As Long)

      Try
         With moItem

            .SelectFilter = clsItem.SelectFilters.GridFindDT
            .WhereFilter = clsItem.WhereFilters.GridFindDT
            .OrderByFilter = clsItem.OrderByFilters.GridFind
            .EmpresaId = mlngEmpresaId
            .EstadoId = 1
            .ItemDes = strConsulta
            .LineaId = lngLineaId

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

   Private Sub grdMainLoad_BusquedaSust(ByVal lngItemId As Long)

      Try
         With moItem
            .SelectFilter = clsItem.SelectFilters.GridFindSustituto
            .WhereFilter = clsItem.WhereFilters.GridFindSustituto
            .OrderByFilter = clsItem.OrderByFilters.GridFind
            .EmpresaId = mlngEmpresaId
            .ItemId = lngItemId
            .EstadoId = 1

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

   Private Sub DataShow()
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("ItemId")) > 0) Then
               With oItem
                  .ItemId = ToLong(grdMain.GetValue("ItemId"))

                  If .FindByPK Then
                     Dim frm As New frmItemFill

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oItem

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Sub

   Private Sub SeleccionarItem()
      If grdMain.RowCount > 0 Then
         If (grdMain.GetRow.Selected) And Not (ToLong(grdMain.GetValue("ItemId")) > 0) Then
            grdMain.Row = grdMain.FirstRow
         End If
         mlngID = ToLong(grdMain.GetValue("ItemId"))
         mboolChanged = True
         Me.Close()
      End If
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("ItemId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      If Me.WindowState <> FormWindowState.Minimized Then
         Me.Location = New Point(20, Me.Location.Y)
         Me.Width = gfrmMain.ClientSize.Width - 40
      End If

      moItem = New clsItem(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboLineaLoad()
   End Sub

   Private Sub cboLineaLoad()
      Dim oLinea As New clsLinea(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboLinea.Items.Clear()

      Try
         With oLinea
            .SelectFilter = clsLinea.SelectFilters.ListBox
            .WhereFilter = clsLinea.WhereFilters.EmpresaId
            .OrderByFilter = clsLinea.OrderByFilters.LineaDes
            .EmpresaId = mlngEmpresaId

            If .Open() Then
               oItem = New clsListItem(0, "(TODOS)")
               cboLinea.Items.Add(oItem)

               Do While .Read()
                  oItem = New clsListItem(.LineaId, .LineaDes)

                  cboLinea.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oLinea.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = " Ítems - Resultado de Busqueda "
         .ContextMenu = mnuMain

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("LineaId").Visible = False

         .RootTable.Columns("LineaDes").Caption = "Línea"
         .RootTable.Columns("LineaDes").Width = 100
         .RootTable.Columns("LineaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("LineaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GrupoId").Visible = False

         .RootTable.Columns("GrupoDes").Caption = "Grupo"
         .RootTable.Columns("GrupoDes").Width = 100
         .RootTable.Columns("GrupoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("GrupoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SubGrupoId").Visible = False

         .RootTable.Columns("SubGrupoDes").Caption = "SubGrupo"
         .RootTable.Columns("SubGrupoDes").Width = 100
         .RootTable.Columns("SubGrupoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("SubGrupoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 100
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Descripción Ítem"
         .RootTable.Columns("ItemDes").Width = 300
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MarcaId").Visible = False

         .RootTable.Columns("MarcaDes").Caption = "Marca"
         .RootTable.Columns("MarcaDes").Width = 100
         .RootTable.Columns("MarcaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MarcaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Saldo").Caption = "Saldo"
         .RootTable.Columns("Saldo").FormatString = DecimalMask()
         .RootTable.Columns("Saldo").Width = 100
         .RootTable.Columns("Saldo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Saldo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Precio").Caption = "Precio"
         .RootTable.Columns("Precio").FormatString = DecimalMask()
         .RootTable.Columns("Precio").Width = 100
         .RootTable.Columns("Precio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Precio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioEqui").Caption = "Precio Equiv"
         .RootTable.Columns("PrecioEqui").FormatString = DecimalMask()
         .RootTable.Columns("PrecioEqui").Width = 100
         .RootTable.Columns("PrecioEqui").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioEqui").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Saldo").Visible = False
         .RootTable.Columns("Precio").Visible = False
         .RootTable.Columns("PrecioEqui").Visible = False

         .RootTable.Columns("FabricaId").Visible = False

         .RootTable.Columns("FabricaDes").Caption = "Fabricación"
         .RootTable.Columns("FabricaDes").Width = 100
         .RootTable.Columns("FabricaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FabricaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 100
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoItemId").Visible = False

         .RootTable.Columns("TipoItemDes").Caption = "Tipo Ítem"
         .RootTable.Columns("TipoItemDes").Width = 100
         .RootTable.Columns("TipoItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaIdEqui").Visible = False

         .RootTable.Columns("MedidaDesEqui").Caption = "Medida Equiv"
         .RootTable.Columns("MedidaDesEqui").Width = 100
         .RootTable.Columns("MedidaDesEqui").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDesEqui").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaCantEqui").Caption = "Cantidad Equi"
         .RootTable.Columns("MedidaCantEqui").FormatString = DecimalMask()
         .RootTable.Columns("MedidaCantEqui").Width = 100
         .RootTable.Columns("MedidaCantEqui").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MedidaCantEqui").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call SeleccionarItem()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      ''If mboolShow Then
      Call DataShow()
      ''End If
   End Sub

   Private Sub optBusquedaGen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBusquedaGen.CheckedChanged
      If optBusquedaGen.Checked Then
         Call BusquedaGenericaVisible()
         If Not IsNothing(moItem) Then     ''Si no esta inicializado el Item
            Call grdMainLoad()
         End If
      End If
   End Sub

   Private Sub optBusquedaDT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBusquedaDT.CheckedChanged
      If optBusquedaDT.Checked Then
         Call BusquedaDTVisible()

         cboLinea.Tag = String.Empty
         cboLinea.Text = ""

         Call grdDatoTecnicoLoad(-1)
         Call grdMainLoad_BusquedaDT("", -1)
      End If
   End Sub

   Private Sub optBusquedaSust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBusquedaSust.CheckedChanged
      If optBusquedaSust.Checked Then
         Call BusquedaSustVisible()
         Call grdSustitucionLoad()
         Call grdMainLoad_BusquedaSust(0)
      End If
   End Sub

#Region "Búsqueda Dato Técnico"

   Private Sub BusquedaDTVisible()

      grpBusquedaDT.Visible = True
      grpBusquedaDT.Height = 180

      ebrSustitucion.Visible = False

      ebrMain.Location = New System.Drawing.Point(4, grpBusquedaDT.Height + 9)
      ebrMain.Height = Me.uiBackground.Height - grpBusquedaDT.Height - 12

   End Sub

   Private Sub BuscarDT()
      Dim lngLineaId As Long
      Dim strConsulta As String

      If cboLinea.SelectedIndex <> -1 Then

         lngLineaId = ListPosition(cboLinea, cboLinea.SelectedIndex)
         strConsulta = getConsulta()

         Call grdMainLoad_BusquedaDT(strConsulta, lngLineaId)

      Else
         MessageBox.Show("Seleccione la Linea", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

   End Sub

   Private Sub grdDatoTecnicoLoad(ByVal lngLineaId As Long)
      Dim oDatoTecnico As New clsDatoTecnico(clsAppInfo.ConnectString)

      Try
         With oDatoTecnico
            .SelectFilter = clsDatoTecnico.SelectFilters.GridFind
            .WhereFilter = clsDatoTecnico.WhereFilters.GridFind
            .OrderByFilter = clsDatoTecnico.OrderByFilters.GridFind
            .EmpresaId = mlngEmpresaId
            .LineaId = lngLineaId

            If .Open() Then
               grdDatoTecnico.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdDatoTecnico.RetrieveStructure()
               Call grdDatoTecnicoInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDatoTecnico.Dispose()

      End Try
   End Sub

   Private Sub grdDatoTecnicoInit()
      With grdDatoTecnico
         ebrDatoTecnico.Groups(0).Text = "Datos Técnicos"

         .RootTable.Columns("TipoDatoTecnicoId").Visible = False

         .RootTable.Columns("TipoDatoTecnicoDes").Caption = "Dato Técnico"
         .RootTable.Columns("TipoDatoTecnicoDes").Width = 100
         .RootTable.Columns("TipoDatoTecnicoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoDatoTecnicoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("TipoDatoTecnicoDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("TipoDatoTecnicoDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         ''.RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("DatoTecnicoDes").Caption = "Descripción"
         .RootTable.Columns("DatoTecnicoDes").Width = 220
         .RootTable.Columns("DatoTecnicoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("DatoTecnicoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ValorMin").Caption = "Valor >="
         .RootTable.Columns("ValorMin").Width = 80
         .RootTable.Columns("ValorMin").FormatString = DecimalMask()
         .RootTable.Columns("ValorMin").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ValorMin").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ValorMax").Caption = "Valor <="
         .RootTable.Columns("ValorMax").Width = 80
         .RootTable.Columns("ValorMax").FormatString = DecimalMask()
         .RootTable.Columns("ValorMax").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ValorMax").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center


      End With
   End Sub

   Private Function getConsulta() As String

      Dim lngCant As Long
      Dim decValMin As Decimal
      Dim decValMax As Decimal

      Dim strConsulta As String
      Dim lngTipDatTecId As Long
      Dim strDatoTecnico As String

      getConsulta = ""

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdDatoTecnico.GetRows

         strConsulta = ""
         If (ToStr(oRow.Cells("DatoTecnicoDes").Value) <> "") Or IsNumeric(oRow.Cells("ValorMin").Value) Or IsNumeric(oRow.Cells("ValorMax").Value) Then

            lngCant += 1

            lngTipDatTecId = ToLong(oRow.Cells("TipoDatoTecnicoId").Value)
            strDatoTecnico = ToStr(oRow.Cells("DatoTecnicoDes").Value)
            decValMin = ToDecimal(oRow.Cells("ValorMin").Value)
            decValMax = ToDecimal(oRow.Cells("ValorMax").Value)

            '' Armando la Consulta
            strConsulta = " AND invDatoTecnico.ItemId IN ( "
            strConsulta &= "  SELECT DatoTec.ItemId "
            strConsulta &= "  FROM invDatoTecnico DatoTec "
            strConsulta &= "  WHERE DatoTec.TipoDatoTecnicoId = " & NumberToField(lngTipDatTecId)

            If strDatoTecnico <> "" Then
               strConsulta &= "  AND (DatoTec.DatoTecnicoDes LIKE '%" & strDatoTecnico & "%') "
            End If

            If IsNumeric(oRow.Cells("ValorMin").Value) And IsNumeric(oRow.Cells("ValorMax").Value) Then
               strConsulta &= "  AND ( DatoTec.Valor >= " & DecimalToField(decValMin) & " AND "
               strConsulta &= "        DatoTec.Valor <= " & DecimalToField(decValMax) & " ) "

            ElseIf IsNumeric(oRow.Cells("ValorMin").Value) Then
               strConsulta &= "  AND ( DatoTec.Valor >= " & DecimalToField(decValMin) & " ) "

            ElseIf IsNumeric(oRow.Cells("ValorMax").Value) Then
               strConsulta &= "  AND ( DatoTec.Valor <= " & DecimalToField(decValMax) & " ) "

            End If

            strConsulta &= " ) "

         End If

         getConsulta &= strConsulta

      Next

   End Function

   ''Private Function getConsulta() As String

   ''   Dim lngCant As Long
   ''   Dim decValMin As Decimal
   ''   Dim decValMax As Decimal

   ''   Dim strConsulta As String
   ''   Dim lngTipDatTecId As Long
   ''   Dim strDatoTecnico As String

   ''   getConsulta = ""

   ''   For Each oRow As Janus.Windows.GridEX.GridEXRow In grdDatoTecnico.GetRows

   ''      strConsulta = ""
   ''      If (ToStr(oRow.Cells("DatoTecnicoDes").Value) <> "") Or IsNumeric(oRow.Cells("ValorMin").Value) Or IsNumeric(oRow.Cells("ValorMax").Value) Then

   ''         lngCant += 1

   ''         lngTipDatTecId = ToLong(oRow.Cells("TipoDatoTecnicoId").Value)
   ''         strDatoTecnico = ToStr(oRow.Cells("DatoTecnicoDes").Value)
   ''         decValMin = ToDecimal(oRow.Cells("ValorMin").Value)
   ''         decValMax = ToDecimal(oRow.Cells("ValorMax").Value)

   ''         '' Armando la Consulta
   ''         strConsulta = " ( invDatoTecnico.TipoDatoTecnicoId = " & NumberToField(lngTipDatTecId)

   ''         If strDatoTecnico <> "" Then
   ''            strConsulta &= "  AND (invDatoTecnico.DatoTecnicoDes LIKE '%" & strDatoTecnico & "%') "
   ''         End If

   ''         If IsNumeric(oRow.Cells("ValorMin").Value) And IsNumeric(oRow.Cells("ValorMax").Value) Then
   ''            strConsulta &= "  AND ( invDatoTecnico.Valor >= " & DecimalToField(decValMin) & " AND "
   ''            strConsulta &= "        invDatoTecnico.Valor <= " & DecimalToField(decValMax) & " ) "

   ''         ElseIf IsNumeric(oRow.Cells("ValorMin").Value) Then
   ''            strConsulta &= "  AND ( invDatoTecnico.Valor >= " & DecimalToField(decValMin) & " ) "

   ''         ElseIf IsNumeric(oRow.Cells("ValorMax").Value) Then
   ''            strConsulta &= "  AND ( invDatoTecnico.Valor <= " & DecimalToField(decValMax) & " ) "

   ''         End If

   ''         strConsulta &= " ) OR "

   ''      End If

   ''      getConsulta &= strConsulta

   ''   Next

   ''   If lngCant > 0 Then
   ''      getConsulta = getConsulta.Remove(getConsulta.Length - 4) ''Eliminando el ultimo OR
   ''      getConsulta = " ( " & getConsulta & " ) "

   ''   End If

   ''End Function

   Private Sub grdDatoTecnico_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdDatoTecnico.UpdatingCell
      If e.Column.DataMember = "ValorMin" Then
         If (Not IsNumeric(e.Value)) And (Not IsDBNull(e.Value)) Then
            e.Cancel = True
            MessageBox.Show("Valor mínimo inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         End If
      End If

      If e.Column.DataMember = "ValorMax" Then
         If (Not IsNumeric(e.Value)) And (Not IsDBNull(e.Value)) Then
            e.Cancel = True
            MessageBox.Show("Valor máximo inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      End If

   End Sub

   Private Sub grdDatoTecnico_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdDatoTecnico.KeyPress

      If Not grdDatoTecnico.CurrentColumn Is Nothing Then
         If ToStr(grdDatoTecnico.RootTable.Columns(grdDatoTecnico.Col).DataMember) = "ValorMin" Or ToStr(grdDatoTecnico.RootTable.Columns(grdDatoTecnico.Col).DataMember) = "ValorMax" Then
            If mstrSepDecimal = "," Then
               If e.KeyChar = "." Then
                  e.Handled = True
                  SendKeys.Send(",")
               End If
            End If
         End If
      End If
   End Sub

   Private Sub grdDatoTecnico_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDatoTecnico.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdDatoTecnico.GetRow.Cells(grdDatoTecnico.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
      Call BuscarDT()
   End Sub

   Private Sub cboLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLinea.SelectedIndexChanged
      If cboLinea.Tag <> cboLinea.Text Then
         cboLinea.Tag = cboLinea.Text

         Dim lngLineaId As Long = ListPosition(cboLinea, cboLinea.SelectedIndex)

         If cboLinea.SelectedIndex <> -1 Then
            Call grdDatoTecnicoLoad(lngLineaId)
            Call grdMainLoad_BusquedaDT("", lngLineaId)

         Else
            Call grdDatoTecnicoLoad(-1)
            Call grdMainLoad_BusquedaDT("", -1)
         End If

      End If
   End Sub

#End Region

#Region "Búsqueda Sustitución"

   Private Sub BusquedaSustVisible()

      grpBusquedaDT.Visible = False

      ebrSustitucion.Visible = True
      ebrSustitucion.Height = 180
      ebrSustitucion.Location = New System.Drawing.Point(4, 5)

      ebrMain.Location = New System.Drawing.Point(4, ebrSustitucion.Height + 9)
      ebrMain.Height = Me.uiBackground.Height - ebrSustitucion.Height - 12

   End Sub

   Private Sub BuscarSustituto()
      Dim lngItemId As Long
      If grdSustitucion.RowCount > 0 Then
         If (grdSustitucion.GetRow.Selected) And Not (ToLong(grdSustitucion.GetValue("ItemId")) > 0) Then

         End If
         lngItemId = ToLong(grdSustitucion.GetValue("ItemId"))
         grdMainLoad_BusquedaSust(lngItemId)
      End If

   End Sub

   Private Sub grdSustitucionLoad()
      Try
         With moItem
            .SelectFilter = clsItem.SelectFilters.GridFind
            .WhereFilter = clsItem.WhereFilters.GridFind
            .OrderByFilter = clsItem.OrderByFilters.GridFind
            .EmpresaId = mlngEmpresaId
            .EstadoId = 1

            If .Open() Then
               grdSustitucion.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdSustitucion.RetrieveStructure()
               Call grdSustitucionInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdSustitucionInit()
      With grdSustitucion
         ebrDatoTecnico.Groups(0).Text = "Items"
         ''.ContextMenu = mnuMain

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("LineaId").Visible = False

         .RootTable.Columns("LineaDes").Caption = "Linea"
         .RootTable.Columns("LineaDes").Width = 100
         .RootTable.Columns("LineaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("LineaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GrupoId").Visible = False

         .RootTable.Columns("GrupoDes").Caption = "Grupo"
         .RootTable.Columns("GrupoDes").Width = 100
         .RootTable.Columns("GrupoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("GrupoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SubGrupoId").Visible = False

         .RootTable.Columns("SubGrupoDes").Caption = "SubGrupo"
         .RootTable.Columns("SubGrupoDes").Width = 100
         .RootTable.Columns("SubGrupoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("SubGrupoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 100
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Descripción Item"
         .RootTable.Columns("ItemDes").Width = 300
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MarcaId").Visible = False

         .RootTable.Columns("MarcaDes").Caption = "Marca"
         .RootTable.Columns("MarcaDes").Width = 100
         .RootTable.Columns("MarcaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MarcaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Saldo").Caption = "Saldo"
         .RootTable.Columns("Saldo").FormatString = DecimalMask()
         .RootTable.Columns("Saldo").Width = 100
         .RootTable.Columns("Saldo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Saldo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Precio").Caption = "Precio"
         .RootTable.Columns("Precio").FormatString = DecimalMask()
         .RootTable.Columns("Precio").Width = 100
         .RootTable.Columns("Precio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Precio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioEqui").Caption = "Precio Equiv"
         .RootTable.Columns("PrecioEqui").FormatString = DecimalMask()
         .RootTable.Columns("PrecioEqui").Width = 100
         .RootTable.Columns("PrecioEqui").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioEqui").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Saldo").Visible = False
         .RootTable.Columns("Precio").Visible = False
         .RootTable.Columns("PrecioEqui").Visible = False

         .RootTable.Columns("FabricaId").Visible = False

         .RootTable.Columns("FabricaDes").Caption = "Fabricación"
         .RootTable.Columns("FabricaDes").Width = 100
         .RootTable.Columns("FabricaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FabricaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 100
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoItemId").Visible = False

         .RootTable.Columns("TipoItemDes").Caption = "Tipo Ítem"
         .RootTable.Columns("TipoItemDes").Width = 100
         .RootTable.Columns("TipoItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaIdEqui").Visible = False

         .RootTable.Columns("MedidaDesEqui").Caption = "Medida Equiv"
         .RootTable.Columns("MedidaDesEqui").Width = 100
         .RootTable.Columns("MedidaDesEqui").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDesEqui").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaCantEqui").Caption = "Cantidad Equi"
         .RootTable.Columns("MedidaCantEqui").FormatString = DecimalMask()
         .RootTable.Columns("MedidaCantEqui").Width = 100
         .RootTable.Columns("MedidaCantEqui").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MedidaCantEqui").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdSustitucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdSustitucion.Click
      Call BuscarSustituto()
   End Sub

   Private Sub grdSustitucion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdSustitucion.KeyUp
      Call BuscarSustituto()
   End Sub

#End Region

   Private Sub frmItemFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.Return Then
            Call SeleccionarItem()

         ElseIf e.KeyCode = Keys.Menu Then
            'cdmMain.CommandBars.Item("tbrMain").

         ElseIf (e.KeyCode = Keys.Enter) Then
            Call SeleccionarItem()

         ElseIf (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If optBusquedaDT.Checked Then
               Call BuscarDT()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmItemFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moItem.Dispose()
      Call ClearMemory()
   End Sub


End Class
