Public Class frmItemFill
   Inherits System.Windows.Forms.Form

   Private moItem As clsItem
   Private moItemSaldo As clsItemSaldo
   Private moSustituto As clsSustituto
   Private moComposicion As clsComposicion
   Private moDatoTecnico As clsDatoTecnico
   Private moItemPrecio As clsItemPrecio

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents ebrItemSaldo As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdItemSaldo As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrItemPrecio As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdItemPrecio As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrSustituto As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl2 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdSustituto As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrComposicion As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl3 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdComposicion As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrDatoTecnico As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl5 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdDatoTecnico As Janus.Windows.GridEX.GridEX
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

   WriteOnly Property DataObject() As clsItem
      Set(ByVal Value As clsItem)
         moItem = Value
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
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents tabSustitucion As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabComposicion As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabPrecio As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabDatoTecnico As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtItemDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents tabItem As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabStock As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents Check As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents tabImagen As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents picImagen As System.Windows.Forms.PictureBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup4 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup5 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemFill))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdItemSaldo = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl1 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdItemPrecio = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl2 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdSustituto = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl3 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdComposicion = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl5 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdDatoTecnico = New Janus.Windows.GridEX.GridEX
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Check = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.tabItem = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtItemDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.tabStock = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrItemSaldo = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabPrecio = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrItemPrecio = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabSustitucion = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrSustituto = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabComposicion = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrComposicion = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabDatoTecnico = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrDatoTecnico = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabImagen = New Janus.Windows.UI.Tab.UITabPage
      Me.picImagen = New System.Windows.Forms.PictureBox
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdItemSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl1.SuspendLayout()
      CType(Me.grdItemPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl2.SuspendLayout()
      CType(Me.grdSustituto, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl3.SuspendLayout()
      CType(Me.grdComposicion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl5.SuspendLayout()
      CType(Me.grdDatoTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.tabItem.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      Me.tabStock.SuspendLayout()
      CType(Me.ebrItemSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrItemSaldo.SuspendLayout()
      Me.tabPrecio.SuspendLayout()
      CType(Me.ebrItemPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrItemPrecio.SuspendLayout()
      Me.tabSustitucion.SuspendLayout()
      CType(Me.ebrSustituto, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrSustituto.SuspendLayout()
      Me.tabComposicion.SuspendLayout()
      CType(Me.ebrComposicion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrComposicion.SuspendLayout()
      Me.tabDatoTecnico.SuspendLayout()
      CType(Me.ebrDatoTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrDatoTecnico.SuspendLayout()
      Me.tabImagen.SuspendLayout()
      CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdItemSaldo)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(420, 245)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdItemSaldo
      '
      Me.grdItemSaldo.AllowCardSizing = False
      Me.grdItemSaldo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdItemSaldo.AlternatingColors = True
      Me.grdItemSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdItemSaldo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdItemSaldo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdItemSaldo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdItemSaldo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdItemSaldo.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdItemSaldo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdItemSaldo.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdItemSaldo.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdItemSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdItemSaldo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdItemSaldo.GroupByBoxVisible = False
      Me.grdItemSaldo.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdItemSaldo.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdItemSaldo.Location = New System.Drawing.Point(0, 0)
      Me.grdItemSaldo.Name = "grdItemSaldo"
      Me.grdItemSaldo.RecordNavigator = True
      Me.grdItemSaldo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdItemSaldo.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdItemSaldo.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdItemSaldo.Size = New System.Drawing.Size(420, 245)
      Me.grdItemSaldo.TabIndex = 3
      Me.grdItemSaldo.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdItemSaldo.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemSaldo.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemSaldo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl1
      '
      Me.ExplorerBarContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl1.Controls.Add(Me.grdItemPrecio)
      Me.ExplorerBarContainerControl1.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl1.Name = "ExplorerBarContainerControl1"
      Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(420, 245)
      Me.ExplorerBarContainerControl1.TabIndex = 1
      '
      'grdItemPrecio
      '
      Me.grdItemPrecio.AllowCardSizing = False
      Me.grdItemPrecio.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdItemPrecio.AlternatingColors = True
      Me.grdItemPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdItemPrecio.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdItemPrecio.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdItemPrecio.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdItemPrecio.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdItemPrecio.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdItemPrecio.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdItemPrecio.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdItemPrecio.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdItemPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdItemPrecio.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdItemPrecio.GroupByBoxVisible = False
      Me.grdItemPrecio.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdItemPrecio.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdItemPrecio.Location = New System.Drawing.Point(0, 0)
      Me.grdItemPrecio.Name = "grdItemPrecio"
      Me.grdItemPrecio.RecordNavigator = True
      Me.grdItemPrecio.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdItemPrecio.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdItemPrecio.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdItemPrecio.Size = New System.Drawing.Size(420, 245)
      Me.grdItemPrecio.TabIndex = 3
      Me.grdItemPrecio.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdItemPrecio.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemPrecio.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemPrecio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl2
      '
      Me.ExplorerBarContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl2.Controls.Add(Me.grdSustituto)
      Me.ExplorerBarContainerControl2.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl2.Name = "ExplorerBarContainerControl2"
      Me.ExplorerBarContainerControl2.Size = New System.Drawing.Size(420, 245)
      Me.ExplorerBarContainerControl2.TabIndex = 1
      '
      'grdSustituto
      '
      Me.grdSustituto.AllowCardSizing = False
      Me.grdSustituto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdSustituto.AlternatingColors = True
      Me.grdSustituto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdSustituto.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdSustituto.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdSustituto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdSustituto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdSustituto.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdSustituto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdSustituto.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdSustituto.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdSustituto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdSustituto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdSustituto.GroupByBoxVisible = False
      Me.grdSustituto.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdSustituto.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdSustituto.Location = New System.Drawing.Point(0, 0)
      Me.grdSustituto.Name = "grdSustituto"
      Me.grdSustituto.RecordNavigator = True
      Me.grdSustituto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdSustituto.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdSustituto.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdSustituto.Size = New System.Drawing.Size(420, 245)
      Me.grdSustituto.TabIndex = 3
      Me.grdSustituto.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdSustituto.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdSustituto.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdSustituto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl3
      '
      Me.ExplorerBarContainerControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl3.Controls.Add(Me.grdComposicion)
      Me.ExplorerBarContainerControl3.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl3.Name = "ExplorerBarContainerControl3"
      Me.ExplorerBarContainerControl3.Size = New System.Drawing.Size(420, 245)
      Me.ExplorerBarContainerControl3.TabIndex = 1
      '
      'grdComposicion
      '
      Me.grdComposicion.AllowCardSizing = False
      Me.grdComposicion.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdComposicion.AlternatingColors = True
      Me.grdComposicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdComposicion.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdComposicion.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdComposicion.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdComposicion.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdComposicion.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdComposicion.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdComposicion.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdComposicion.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdComposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdComposicion.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdComposicion.GroupByBoxVisible = False
      Me.grdComposicion.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdComposicion.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdComposicion.Location = New System.Drawing.Point(0, 0)
      Me.grdComposicion.Name = "grdComposicion"
      Me.grdComposicion.RecordNavigator = True
      Me.grdComposicion.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdComposicion.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdComposicion.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdComposicion.Size = New System.Drawing.Size(420, 245)
      Me.grdComposicion.TabIndex = 3
      Me.grdComposicion.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdComposicion.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdComposicion.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdComposicion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl5
      '
      Me.ExplorerBarContainerControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl5.Controls.Add(Me.grdDatoTecnico)
      Me.ExplorerBarContainerControl5.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl5.Name = "ExplorerBarContainerControl5"
      Me.ExplorerBarContainerControl5.Size = New System.Drawing.Size(420, 245)
      Me.ExplorerBarContainerControl5.TabIndex = 1
      '
      'grdDatoTecnico
      '
      Me.grdDatoTecnico.AllowCardSizing = False
      Me.grdDatoTecnico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdDatoTecnico.AlternatingColors = True
      Me.grdDatoTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdDatoTecnico.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdDatoTecnico.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdDatoTecnico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdDatoTecnico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdDatoTecnico.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdDatoTecnico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdDatoTecnico.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
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
      Me.grdDatoTecnico.Size = New System.Drawing.Size(420, 245)
      Me.grdDatoTecnico.TabIndex = 3
      Me.grdDatoTecnico.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdDatoTecnico.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDatoTecnico.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDatoTecnico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Check})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(77, 28)
      Me.UiCommandBar1.Text = "tbrMain"
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
      'Check
      '
      Me.Check.Key = "Check"
      Me.Check.Name = "Check"
      Me.Check.Text = "Aceptar"
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 340)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(8, 8)
      Me.tabMain.MultiLine = True
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(448, 328)
      Me.tabMain.TabIndex = 0
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabItem, Me.tabStock, Me.tabPrecio, Me.tabSustitucion, Me.tabComposicion, Me.tabDatoTecnico, Me.tabImagen})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabItem
      '
      Me.tabItem.Controls.Add(Me.UiGroupBox2)
      Me.tabItem.Key = "Item"
      Me.tabItem.Location = New System.Drawing.Point(1, 39)
      Me.tabItem.Name = "tabItem"
      Me.tabItem.Size = New System.Drawing.Size(446, 288)
      Me.tabItem.TabStop = True
      Me.tabItem.Text = "Item"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox2.Controls.Add(Me.txtItemDes)
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 4)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(432, 280)
      Me.UiGroupBox2.TabIndex = 207
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'txtItemDes
      '
      Me.txtItemDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtItemDes.BackColor = System.Drawing.SystemColors.InactiveCaption
      Me.txtItemDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtItemDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemDes.Location = New System.Drawing.Point(8, 16)
      Me.txtItemDes.MaxLength = 255
      Me.txtItemDes.Multiline = True
      Me.txtItemDes.Name = "txtItemDes"
      Me.txtItemDes.ReadOnly = True
      Me.txtItemDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtItemDes.Size = New System.Drawing.Size(416, 256)
      Me.txtItemDes.TabIndex = 214
      Me.txtItemDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'tabStock
      '
      Me.tabStock.Controls.Add(Me.ebrItemSaldo)
      Me.tabStock.Key = "Stock"
      Me.tabStock.Location = New System.Drawing.Point(1, 39)
      Me.tabStock.Name = "tabStock"
      Me.tabStock.Size = New System.Drawing.Size(446, 288)
      Me.tabStock.TabStop = True
      Me.tabStock.Text = "Stock"
      Me.tabStock.Visible = False
      '
      'ebrItemSaldo
      '
      Me.ebrItemSaldo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrItemSaldo.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrItemSaldo.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 246
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrItemSaldo.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrItemSaldo.GroupSeparation = 4
      Me.ebrItemSaldo.Location = New System.Drawing.Point(5, 5)
      Me.ebrItemSaldo.Name = "ebrItemSaldo"
      Me.ebrItemSaldo.Size = New System.Drawing.Size(436, 278)
      Me.ebrItemSaldo.TabIndex = 3
      Me.ebrItemSaldo.Text = "ExplorerBar2"
      Me.ebrItemSaldo.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrItemSaldo.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemSaldo.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemSaldo.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabPrecio
      '
      Me.tabPrecio.Controls.Add(Me.ebrItemPrecio)
      Me.tabPrecio.Key = "Precio"
      Me.tabPrecio.Location = New System.Drawing.Point(1, 39)
      Me.tabPrecio.Name = "tabPrecio"
      Me.tabPrecio.Size = New System.Drawing.Size(446, 288)
      Me.tabPrecio.TabStop = True
      Me.tabPrecio.Text = "Precios"
      '
      'ebrItemPrecio
      '
      Me.ebrItemPrecio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrItemPrecio.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrItemPrecio.Controls.Add(Me.ExplorerBarContainerControl1)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl1
      ExplorerBarGroup2.ContainerHeight = 246
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ebrItemPrecio.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ebrItemPrecio.GroupSeparation = 4
      Me.ebrItemPrecio.Location = New System.Drawing.Point(5, 5)
      Me.ebrItemPrecio.Name = "ebrItemPrecio"
      Me.ebrItemPrecio.Size = New System.Drawing.Size(436, 278)
      Me.ebrItemPrecio.TabIndex = 2
      Me.ebrItemPrecio.Text = "ExplorerBar2"
      Me.ebrItemPrecio.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrItemPrecio.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemPrecio.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemPrecio.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabSustitucion
      '
      Me.tabSustitucion.Controls.Add(Me.ebrSustituto)
      Me.tabSustitucion.Key = "Sustitucion"
      Me.tabSustitucion.Location = New System.Drawing.Point(1, 39)
      Me.tabSustitucion.Name = "tabSustitucion"
      Me.tabSustitucion.Size = New System.Drawing.Size(446, 288)
      Me.tabSustitucion.TabStop = True
      Me.tabSustitucion.Text = "Sustituciones"
      '
      'ebrSustituto
      '
      Me.ebrSustituto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrSustituto.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrSustituto.Controls.Add(Me.ExplorerBarContainerControl2)
      ExplorerBarGroup3.Container = True
      ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl2
      ExplorerBarGroup3.ContainerHeight = 246
      ExplorerBarGroup3.Expandable = False
      ExplorerBarGroup3.Key = "Group1"
      Me.ebrSustituto.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
      Me.ebrSustituto.GroupSeparation = 4
      Me.ebrSustituto.Location = New System.Drawing.Point(5, 5)
      Me.ebrSustituto.Name = "ebrSustituto"
      Me.ebrSustituto.Size = New System.Drawing.Size(436, 278)
      Me.ebrSustituto.TabIndex = 2
      Me.ebrSustituto.Text = "ExplorerBar2"
      Me.ebrSustituto.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrSustituto.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrSustituto.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrSustituto.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabComposicion
      '
      Me.tabComposicion.Controls.Add(Me.ebrComposicion)
      Me.tabComposicion.Key = "Composicion"
      Me.tabComposicion.Location = New System.Drawing.Point(1, 39)
      Me.tabComposicion.Name = "tabComposicion"
      Me.tabComposicion.Size = New System.Drawing.Size(446, 288)
      Me.tabComposicion.TabStop = True
      Me.tabComposicion.Text = "Composición"
      '
      'ebrComposicion
      '
      Me.ebrComposicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrComposicion.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrComposicion.Controls.Add(Me.ExplorerBarContainerControl3)
      ExplorerBarGroup4.Container = True
      ExplorerBarGroup4.ContainerControl = Me.ExplorerBarContainerControl3
      ExplorerBarGroup4.ContainerHeight = 246
      ExplorerBarGroup4.Expandable = False
      ExplorerBarGroup4.Key = "Group1"
      Me.ebrComposicion.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup4})
      Me.ebrComposicion.GroupSeparation = 4
      Me.ebrComposicion.Location = New System.Drawing.Point(5, 5)
      Me.ebrComposicion.Name = "ebrComposicion"
      Me.ebrComposicion.Size = New System.Drawing.Size(436, 278)
      Me.ebrComposicion.TabIndex = 2
      Me.ebrComposicion.Text = "ExplorerBar2"
      Me.ebrComposicion.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrComposicion.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrComposicion.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrComposicion.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabDatoTecnico
      '
      Me.tabDatoTecnico.Controls.Add(Me.ebrDatoTecnico)
      Me.tabDatoTecnico.Key = "DatoTecnico"
      Me.tabDatoTecnico.Location = New System.Drawing.Point(1, 39)
      Me.tabDatoTecnico.Name = "tabDatoTecnico"
      Me.tabDatoTecnico.Size = New System.Drawing.Size(446, 288)
      Me.tabDatoTecnico.TabStop = True
      Me.tabDatoTecnico.Text = "Datos Técnicos"
      '
      'ebrDatoTecnico
      '
      Me.ebrDatoTecnico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrDatoTecnico.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrDatoTecnico.Controls.Add(Me.ExplorerBarContainerControl5)
      ExplorerBarGroup5.Container = True
      ExplorerBarGroup5.ContainerControl = Me.ExplorerBarContainerControl5
      ExplorerBarGroup5.ContainerHeight = 246
      ExplorerBarGroup5.Expandable = False
      ExplorerBarGroup5.Key = "Group1"
      Me.ebrDatoTecnico.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup5})
      Me.ebrDatoTecnico.GroupSeparation = 4
      Me.ebrDatoTecnico.Location = New System.Drawing.Point(5, 5)
      Me.ebrDatoTecnico.Name = "ebrDatoTecnico"
      Me.ebrDatoTecnico.Size = New System.Drawing.Size(436, 278)
      Me.ebrDatoTecnico.TabIndex = 3
      Me.ebrDatoTecnico.Text = "ExplorerBar2"
      Me.ebrDatoTecnico.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrDatoTecnico.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDatoTecnico.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDatoTecnico.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabImagen
      '
      Me.tabImagen.Controls.Add(Me.picImagen)
      Me.tabImagen.Key = "Imagen"
      Me.tabImagen.Location = New System.Drawing.Point(1, 39)
      Me.tabImagen.Name = "tabImagen"
      Me.tabImagen.Size = New System.Drawing.Size(446, 288)
      Me.tabImagen.TabStop = True
      Me.tabImagen.Text = "Imagen"
      '
      'picImagen
      '
      Me.picImagen.BackColor = System.Drawing.Color.Transparent
      Me.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.picImagen.Cursor = System.Windows.Forms.Cursors.Hand
      Me.picImagen.Location = New System.Drawing.Point(8, 8)
      Me.picImagen.Name = "picImagen"
      Me.picImagen.Size = New System.Drawing.Size(428, 272)
      Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.picImagen.TabIndex = 229
      Me.picImagen.TabStop = False
      '
      'frmItemFill
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 368)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmItemFill"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Consulta Item"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdItemSaldo, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl1.ResumeLayout(False)
      CType(Me.grdItemPrecio, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl2.ResumeLayout(False)
      CType(Me.grdSustituto, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl3.ResumeLayout(False)
      CType(Me.grdComposicion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl5.ResumeLayout(False)
      CType(Me.grdDatoTecnico, System.ComponentModel.ISupportInitialize).EndInit()
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
      Me.tabItem.ResumeLayout(False)
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      Me.tabStock.ResumeLayout(False)
      CType(Me.ebrItemSaldo, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrItemSaldo.ResumeLayout(False)
      Me.tabPrecio.ResumeLayout(False)
      CType(Me.ebrItemPrecio, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrItemPrecio.ResumeLayout(False)
      Me.tabSustitucion.ResumeLayout(False)
      CType(Me.ebrSustituto, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrSustituto.ResumeLayout(False)
      Me.tabComposicion.ResumeLayout(False)
      CType(Me.ebrComposicion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrComposicion.ResumeLayout(False)
      Me.tabDatoTecnico.ResumeLayout(False)
      CType(Me.ebrDatoTecnico, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrDatoTecnico.ResumeLayout(False)
      Me.tabImagen.ResumeLayout(False)
      CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmItemFill_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmItemFill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call FormShow()

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      Dim strItemDes As String

      mboolShow = True
      With moItem
         strItemDes = strItemDes + "Linea :" + vbTab + vbTab + LineaDesFind(.LineaId) + vbCrLf
         strItemDes = strItemDes + "Grupo :" + vbTab + vbTab + GrupoDesFind(.GrupoId) + vbCrLf
         strItemDes = strItemDes + "SubGrupo :" + vbTab + SubGrupoDesFind(.SubGrupoId) + vbCrLf
         strItemDes = strItemDes + vbCrLf
         strItemDes = strItemDes + "Código :" + vbTab + vbTab + ToStr(.ItemCod) + vbCrLf
         strItemDes = strItemDes + "Descripción :" + vbTab + ToStr(.ItemDes) + vbCrLf
         strItemDes = strItemDes + "Abreviación :" + vbTab + ToStr(.ItemDesAbr) + vbCrLf
         strItemDes = strItemDes + "Ubicación :" + vbTab + ToStr(.Ubicacion) + vbCrLf
         strItemDes = strItemDes + vbCrLf
         strItemDes = strItemDes + "Marca :" + vbTab + vbTab + MarcaDesFind(.MarcaId) + vbCrLf
         strItemDes = strItemDes + "Fabricación :" + vbTab + FabricaDesFind(.FabricaId) + vbCrLf
         strItemDes = strItemDes + "TipoItem :" + vbTab + vbTab + TipoItemDesFind(.TipoItemId) + vbCrLf
         strItemDes = strItemDes + "Método Costeo :" + vbTab + TipoCosteoDesFind(.TipoCosteoId) + vbCrLf
         strItemDes = strItemDes + vbCrLf
         strItemDes = strItemDes + "Cantidad Minima :" + vbTab + ToDecStr(.CantidadMin) + vbCrLf
         strItemDes = strItemDes + "Cantidad Maxima :" + vbTab + ToDecStr(.CantidadMax) + vbCrLf
         strItemDes = strItemDes + "Medida Mínima :" + vbTab + MedidaDesFind(.MedidaId) + vbCrLf
         strItemDes = strItemDes + "Medida Equival. :" + vbTab + MedidaDesFind(.MedidaIdEqui) + vbCrLf
         strItemDes = strItemDes + "Equivale a :" + vbTab + ToDecStr(.MedidaCantEqui) + vbCrLf
         strItemDes = strItemDes + vbCrLf
         strItemDes = strItemDes + "Moneda Costo :" + vbTab + MonedaDesFind(.MonedaIdCos) + vbCrLf
         strItemDes = strItemDes + "Moneda Venta :" + vbTab + MonedaDesFind(.MonedaIdVen) + vbCrLf
         strItemDes = strItemDes + "Grupo de Cuentas :" + vbTab + PlanGrupoDesFind(.PlanGrupoId) + vbCrLf
         strItemDes = strItemDes + "Tipo de Tasa :" + vbTab + TipoTasaDesFind(.TipoTasaId) + vbCrLf
         strItemDes = strItemDes + "Monto Tasa :" + vbTab + ToDecStr(.TipoTasaMonto) + vbCrLf
         strItemDes = strItemDes + "Estado :" + vbTab + vbTab + EstadoDesFind(.EstadoId) + vbCrLf

         txtItemDes.Text = strItemDes

         Call lblImagenLoad(.Imagen)
      End With

      Call grdItemSaldoLoad()
      Call grdItemPrecioLoad()
      Call grdSustitutoLoad()
      Call grdComposicionLoad()
      Call grdDatoTecnicoLoad()

      If moItem.TipoItemId = 3 Then
         tabMain.TabPages.Item("Composicion").Enabled = True
      Else
         tabMain.TabPages.Item("Composicion").Enabled = False
      End If

      mboolShow = False
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      moItemSaldo = New clsItemSaldo(clsAppInfo.ConnectString)
      moSustituto = New clsSustituto(clsAppInfo.ConnectString)
      moComposicion = New clsComposicion(clsAppInfo.ConnectString)
      moDatoTecnico = New clsDatoTecnico(clsAppInfo.ConnectString)
      moItemPrecio = New clsItemPrecio(clsAppInfo.ConnectString)
   End Sub

   Private Function LineaDesFind(ByVal lngLineaId As Long) As String
      Dim oLinea As New clsLinea(clsAppInfo.ConnectString)

      Try
         With oLinea
            .LineaId = lngLineaId

            If .FindByPK Then
               LineaDesFind = .LineaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oLinea.Dispose()

      End Try
   End Function

   Private Function GrupoDesFind(ByVal lngGrupoId As Long) As String
      Dim oGrupo As New clsGrupo(clsAppInfo.ConnectString)

      Try
         With oGrupo
            .GrupoId = lngGrupoId

            If .FindByPK Then
               GrupoDesFind = .GrupoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGrupo.Dispose()

      End Try
   End Function

   Private Function SubGrupoDesFind(ByVal lngSubGrupoId As Long) As String
      Dim oSubGrupo As New clsSubGrupo(clsAppInfo.ConnectString)

      Try
         With oSubGrupo
            .SubGrupoId = lngSubGrupoId

            If .FindByPK Then
               SubGrupoDesFind = .SubGrupoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSubGrupo.Dispose()

      End Try
   End Function

   Private Function MarcaDesFind(ByVal lngMarcaId As Long) As String
      Dim oMarca As New clsMarca(clsAppInfo.ConnectString)

      Try
         With oMarca
            .MarcaId = lngMarcaId

            If .FindByPK Then
               MarcaDesFind = .MarcaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMarca.Dispose()

      End Try
   End Function

   Private Function FabricaDesFind(ByVal lngFabricaId As Long) As String
      Dim oFabrica As New clsFabrica(clsAppInfo.ConnectString)

      Try
         With oFabrica
            .FabricaId = lngFabricaId

            If .FindByPK Then
               FabricaDesFind = .FabricaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFabrica.Dispose()

      End Try
   End Function

   Private Function TipoItemDesFind(ByVal lngTipoItemId As Long) As String
      Dim oTipoItem As New clsTipoItem(clsAppInfo.ConnectString)

      Try
         With oTipoItem
            .TipoItemId = lngTipoItemId

            If .FindByPK Then
               TipoItemDesFind = .TipoItemDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoItem.Dispose()

      End Try
   End Function

   Private Function TipoCosteoDesFind(ByVal lngTipoCosteoId As Long) As String
      Dim oTipoCosteo As New clsTipoCosteo(clsAppInfo.ConnectString)

      Try
         With oTipoCosteo
            .TipoCosteoId = lngTipoCosteoId

            If .FindByPK Then
               TipoCosteoDesFind = .TipoCosteoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCosteo.Dispose()

      End Try
   End Function

   Private Function MedidaDesFind(ByVal lngMedidaId As Long) As String
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

      Try
         With oMedida
            .MedidaId = lngMedidaId

            If .FindByPK Then
               MedidaDesFind = .MedidaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMedida.Dispose()

      End Try
   End Function

   Private Function MonedaDesFind(ByVal lngMonedaId As Long) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      Try
         With oMoneda
            .MonedaId = lngMonedaId

            If .FindByPK Then
               MonedaDesFind = .MonedaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()

      End Try
   End Function

   Private Function PlanGrupoDesFind(ByVal lngPlanGrupoId As Long) As String
      Dim oPlanGrupo As New clsPlanGrupo(clsAppInfo.ConnectString)

      Try
         With oPlanGrupo
            .PlanGrupoId = lngPlanGrupoId

            If .FindByPK Then
               PlanGrupoDesFind = .PlanGrupoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanGrupo.Dispose()

      End Try
   End Function

   Private Function TipoTasaDesFind(ByVal lngTipoTasaId As Long) As String
      Dim oTipoTasa As New clsTipoTasa(clsAppInfo.ConnectString)

      Try
         With oTipoTasa
            .TipoTasaId = lngTipoTasaId

            If .FindByPK Then
               TipoTasaDesFind = .TipoTasaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoTasa.Dispose()

      End Try
   End Function

   Private Function EstadoDesFind(ByVal lngEstadoId As Long) As String
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)

      Try
         With oEstado
            .EstadoId = lngEstadoId

            If .FindByPK Then
               EstadoDesFind = .EstadoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEstado.Dispose()

      End Try
   End Function

   Private Sub lblImagenLoad(ByVal strRuta As String)
      If ToStr(strRuta) <> "" Then
         If Dir(strRuta) <> "" Then
            picImagen.Image = System.Drawing.Image.FromFile(strRuta)
            picImagen.Tag = strRuta
         Else
            picImagen.Image = Nothing
            picImagen.Tag = ""
         End If
      Else
         picImagen.Image = Nothing
         picImagen.Tag = ""
      End If
   End Sub


#Region " ItemSaldo "

   Private Sub grdItemSaldoLoad()
      Try
         With moItemSaldo
            .SelectFilter = clsItemSaldo.SelectFilters.GridFill
            .WhereFilter = clsItemSaldo.WhereFilters.GridFill
            .OrderByFilter = clsItemSaldo.OrderByFilters.GridFill
            .EmpresaId = moItem.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .ItemId = moItem.ItemId

            If .Open() Then
               grdItemSaldo.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdItemSaldo.RetrieveStructure()
               Call grdItemSaldoInit()
            End If
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdItemSaldoInit()
      With grdItemSaldo
         ebrItemSaldo.Groups(0).Text = "Cantidades en Stock"

         .RootTable.Columns("ItemSaldoId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("AlmacenId").Visible = False

         .RootTable.Columns("AlmacenDes").Caption = "Almacen"
         .RootTable.Columns("AlmacenDes").Width = 180
         .RootTable.Columns("AlmacenDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AlmacenDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 100
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Saldo").Caption = "Saldo"
         .RootTable.Columns("Saldo").FormatString = DecimalMask()
         .RootTable.Columns("Saldo").Width = 100
         .RootTable.Columns("Saldo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Saldo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdItemSaldo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdItemSaldo.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdItemSaldo.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdItemSaldo.GetRow.Cells(grdItemSaldo.CurrentColumn).Text)
         End If
      End If
   End Sub

#End Region

#Region " ItemPrecio "

   Private Sub grdItemPrecioLoad()
      Try
         With moItemPrecio
            .SelectFilter = clsItemPrecio.SelectFilters.GridItem
            .WhereFilter = clsItemPrecio.WhereFilters.GridItem
            .OrderByFilter = clsItemPrecio.OrderByFilters.GridItem
            .EmpresaId = moItem.EmpresaId
            .ItemId = moItem.ItemId

            If .Open() Then
               grdItemPrecio.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdItemPrecio.RetrieveStructure()
               Call grdItemPrecioInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdItemPrecioInit()
      With grdItemPrecio
         ebrItemPrecio.Groups(0).Text = "Precios de Venta"

         .RootTable.Columns("ItemPrecioId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("EncPrecioId").Visible = False

         .RootTable.Columns("EncPrecioDes").Caption = "Lista"
         .RootTable.Columns("EncPrecioDes").Width = 100
         .RootTable.Columns("EncPrecioDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EncPrecioDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AlmacenId").Visible = False

         .RootTable.Columns("AlmacenDes").Caption = "Almacen"
         .RootTable.Columns("AlmacenDes").Width = 80
         .RootTable.Columns("AlmacenDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AlmacenDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("Orden").Caption = "Orden"
         .RootTable.Columns("Orden").Width = 50
         .RootTable.Columns("Orden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Orden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemPrecioDes").Caption = "Descripción"
         .RootTable.Columns("ItemPrecioDes").Width = 80
         .RootTable.Columns("ItemPrecioDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemPrecioDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Porcentaje").Visible = False

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 80
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Precio").Caption = "Precio"
         .RootTable.Columns("Precio").FormatString = DecimalMask()
         .RootTable.Columns("Precio").Width = 80
         .RootTable.Columns("Precio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Precio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioEqui").Caption = "Precio Equi."
         .RootTable.Columns("PrecioEqui").FormatString = DecimalMask()
         .RootTable.Columns("PrecioEqui").Width = 80
         .RootTable.Columns("PrecioEqui").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioEqui").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 80
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 80
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With

   End Sub

   Private Sub grdItemPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdItemPrecio.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdItemPrecio.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdItemPrecio.GetRow.Cells(grdItemPrecio.CurrentColumn).Text)
         End If
      End If
   End Sub

#End Region

#Region " Sustituto "

   Private Sub grdSustitutoLoad()
      Try
         With moSustituto
            .SelectFilter = clsSustituto.SelectFilters.Grid
            .WhereFilter = clsSustituto.WhereFilters.Grid
            .OrderByFilter = clsSustituto.OrderByFilters.Grid
            .EmpresaId = moItem.EmpresaId
            .ItemId = moItem.ItemId

            If .Open() Then
               grdSustituto.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdSustituto.RetrieveStructure()
               Call grdSustitutoInit()
            End If
            .CloseConection()

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdSustitutoInit()
      With grdSustituto
         ebrSustituto.Groups(0).Text = "Sustituciones"

         .RootTable.Columns("SustitutoId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 100
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Descripción"
         .RootTable.Columns("ItemDes").Width = 280
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdSustituto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdSustituto.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdSustituto.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdSustituto.GetRow.Cells(grdSustituto.CurrentColumn).Text)
         End If
      End If
   End Sub

#End Region

#Region " Composicion "

   Private Sub grdComposicionLoad()
      Try
         With moComposicion
            .SelectFilter = clsComposicion.SelectFilters.Grid
            .WhereFilter = clsComposicion.WhereFilters.Grid
            .OrderByFilter = clsComposicion.OrderByFilters.Grid
            .EmpresaId = moItem.EmpresaId
            .ItemId = moItem.ItemId

            If .Open() Then
               grdComposicion.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdComposicion.RetrieveStructure()
               Call grdComposicionInit()
               .CloseConection()

            End If
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdComposicionInit()
      With grdComposicion
         ebrComposicion.Groups(0).Text = "Sustituciones"

         .RootTable.Columns("ComposicionId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 80
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Descripción"
         .RootTable.Columns("ItemDes").Width = 150
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 80
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cantidad"
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 70
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdComposicion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdComposicion.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdComposicion.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdComposicion.GetRow.Cells(grdComposicion.CurrentColumn).Text)
         End If
      End If
   End Sub

#End Region

#Region " DatoTecnico "

   Private Sub grdDatoTecnicoLoad()
      Try
         With moDatoTecnico
            .SelectFilter = clsDatoTecnico.SelectFilters.Grid
            .WhereFilter = clsDatoTecnico.WhereFilters.Grid
            .OrderByFilter = clsDatoTecnico.OrderByFilters.Grid
            .EmpresaId = moItem.EmpresaId
            .ItemId = moItem.ItemId

            If .Open() Then
               grdDatoTecnico.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdDatoTecnico.RetrieveStructure()
               Call grdDatoTecnicoInit()
            End If
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdDatoTecnicoInit()
      With grdDatoTecnico
         ebrDatoTecnico.Groups(0).Text = "Datos Técnicos"

         .RootTable.Columns("DatoTecnicoId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("LineaId").Visible = False

         .RootTable.Columns("TipoDatoTecnicoId").Visible = False

         .RootTable.Columns("TipoDatoTecnicoDes").Caption = "Dato Técnico"
         .RootTable.Columns("TipoDatoTecnicoDes").Width = 100
         .RootTable.Columns("TipoDatoTecnicoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoDatoTecnicoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("DatoTecnicoDes").Caption = "Descripción"
         .RootTable.Columns("DatoTecnicoDes").Width = 280
         .RootTable.Columns("DatoTecnicoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("DatoTecnicoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Valor").Caption = "Valor"
         .RootTable.Columns("Valor").Width = 80
         .RootTable.Columns("Valor").FormatString = DecimalMask()
         .RootTable.Columns("Valor").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Valor").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With
   End Sub

   Private Sub grdDatoTecnico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDatoTecnico.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdDatoTecnico.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdDatoTecnico.GetRow.Cells(grdDatoTecnico.CurrentColumn).Text)
         End If
      End If
   End Sub

#End Region

   Private Sub frmItemFill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Me.Close()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmItemFill_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moItem.Dispose()
      moItemSaldo.Dispose()
      moSustituto.Dispose()
      moComposicion.Dispose()
      moDatoTecnico.Dispose()
      moItemPrecio.Dispose()
      Call ClearMemory()
   End Sub

End Class
