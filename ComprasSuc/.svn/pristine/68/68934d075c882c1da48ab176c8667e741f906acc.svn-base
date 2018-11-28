Public Class frmItemEdit
   Inherits System.Windows.Forms.Form

   Private moItem As clsItem
   Private moSustituto As clsSustituto
   Private moComposicion As clsComposicion
   Private moDatoTecnico As clsDatoTecnico
   Private moItemBarra As clsItemBarra
   Private moItemPrecio As clsItemPrecio

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents ebrDatoTecnico As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdDatoTecnico As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrSustituto As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdSustituto As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrComposicion As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl2 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdComposicion As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrItemBarra As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl3 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdItemBarra As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrItemPrecio As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl5 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdItemPrecio As Janus.Windows.GridEX.GridEX
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox7 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtUtilidad As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label26 As System.Windows.Forms.Label
   Friend WithEvents txtComision As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
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
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents cboPlanGrupo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents tabGeneral As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabParametro As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabSustitucion As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabComposicion As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabPrecio As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents txtObs As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents mnuSustituto As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
   Friend WithEvents mnuComposicion As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowCom As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewCom As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditCom As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeleteCom As System.Windows.Forms.MenuItem
   Friend WithEvents tabDatoTecnico As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents mnuDatoTecnico As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowDato As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewDato As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditDato As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeletedato As System.Windows.Forms.MenuItem
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents txtItemId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents cboSubGrupo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cboGrupo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboLinea As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboTipoItem As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents cboFabrica As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents cboMarca As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtUbicacion As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtItemDesAbr As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtItemDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtItemCod As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents lblMedidaEqui As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents cboMedidaEqui As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtMedidaCantEqui As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboMedida As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox5 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtTipoTasaMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboTipoTasa As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkControlSerie As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkControlLote As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents mnuPrecio As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowPre As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewPre As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditPre As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeletePre As System.Windows.Forms.MenuItem
   Friend WithEvents picImagen As System.Windows.Forms.PictureBox
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label24 As System.Windows.Forms.Label
   Friend WithEvents cboTipoCosteo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtCantidadMax As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents txtCantidadMin As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox8 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboMonedaCos As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label27 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents cboMonedaVen As Janus.Windows.EditControls.UIComboBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents tabItemBarra As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents mnuItemBarra As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowBar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewBar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditBar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeleteBar As System.Windows.Forms.MenuItem
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup4 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup5 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdDatoTecnico = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl1 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdSustituto = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl2 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdComposicion = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl3 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdItemBarra = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl5 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdItemPrecio = New Janus.Windows.GridEX.GridEX
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.tabGeneral = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoCosteo = New Janus.Windows.EditControls.UIComboBox
      Me.Label16 = New System.Windows.Forms.Label
      Me.cboTipoItem = New Janus.Windows.EditControls.UIComboBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.cboFabrica = New Janus.Windows.EditControls.UIComboBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.cboMarca = New Janus.Windows.EditControls.UIComboBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtUbicacion = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtItemDesAbr = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtItemDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtItemCod = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.picImagen = New System.Windows.Forms.PictureBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label25 = New System.Windows.Forms.Label
      Me.txtItemId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label23 = New System.Windows.Forms.Label
      Me.cboSubGrupo = New Janus.Windows.EditControls.UIComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.cboGrupo = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboLinea = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.tabParametro = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox8 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboMonedaVen = New Janus.Windows.EditControls.UIComboBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.cboMonedaCos = New Janus.Windows.EditControls.UIComboBox
      Me.Label27 = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtCantidadMax = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.txtCantidadMin = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.Label24 = New System.Windows.Forms.Label
      Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkControlLote = New Janus.Windows.EditControls.UICheckBox
      Me.chkControlSerie = New Janus.Windows.EditControls.UICheckBox
      Me.UiGroupBox5 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label19 = New System.Windows.Forms.Label
      Me.txtTipoTasaMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboTipoTasa = New Janus.Windows.EditControls.UIComboBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
      Me.lblMedidaEqui = New System.Windows.Forms.Label
      Me.Label21 = New System.Windows.Forms.Label
      Me.Label20 = New System.Windows.Forms.Label
      Me.cboMedidaEqui = New Janus.Windows.EditControls.UIComboBox
      Me.txtMedidaCantEqui = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboMedida = New Janus.Windows.EditControls.UIComboBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label22 = New System.Windows.Forms.Label
      Me.txtObs = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboPlanGrupo = New Janus.Windows.EditControls.UIComboBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.tabDatoTecnico = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrDatoTecnico = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabSustitucion = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrSustituto = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabComposicion = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrComposicion = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabItemBarra = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrItemBarra = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabPrecio = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox7 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtUtilidad = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label26 = New System.Windows.Forms.Label
      Me.txtComision = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.ebrItemPrecio = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.mnuDatoTecnico = New System.Windows.Forms.ContextMenu
      Me.mnuShowDato = New System.Windows.Forms.MenuItem
      Me.mnuNewDato = New System.Windows.Forms.MenuItem
      Me.mnuEditDato = New System.Windows.Forms.MenuItem
      Me.mnuDeletedato = New System.Windows.Forms.MenuItem
      Me.mnuSustituto = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.mnuNew = New System.Windows.Forms.MenuItem
      Me.mnuEdit = New System.Windows.Forms.MenuItem
      Me.mnuDelete = New System.Windows.Forms.MenuItem
      Me.mnuComposicion = New System.Windows.Forms.ContextMenu
      Me.mnuShowCom = New System.Windows.Forms.MenuItem
      Me.mnuNewCom = New System.Windows.Forms.MenuItem
      Me.mnuEditCom = New System.Windows.Forms.MenuItem
      Me.mnuDeleteCom = New System.Windows.Forms.MenuItem
      Me.mnuItemBarra = New System.Windows.Forms.ContextMenu
      Me.mnuShowBar = New System.Windows.Forms.MenuItem
      Me.mnuNewBar = New System.Windows.Forms.MenuItem
      Me.mnuEditBar = New System.Windows.Forms.MenuItem
      Me.mnuDeleteBar = New System.Windows.Forms.MenuItem
      Me.mnuPrecio = New System.Windows.Forms.ContextMenu
      Me.mnuShowPre = New System.Windows.Forms.MenuItem
      Me.mnuNewPre = New System.Windows.Forms.MenuItem
      Me.mnuEditPre = New System.Windows.Forms.MenuItem
      Me.mnuDeletePre = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdDatoTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl1.SuspendLayout()
      CType(Me.grdSustituto, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl2.SuspendLayout()
      CType(Me.grdComposicion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl3.SuspendLayout()
      CType(Me.grdItemBarra, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl5.SuspendLayout()
      CType(Me.grdItemPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
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
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabParametro.SuspendLayout()
      CType(Me.UiGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox8.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox6.SuspendLayout()
      CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox5.SuspendLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox4.SuspendLayout()
      Me.tabDatoTecnico.SuspendLayout()
      CType(Me.ebrDatoTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrDatoTecnico.SuspendLayout()
      Me.tabSustitucion.SuspendLayout()
      CType(Me.ebrSustituto, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrSustituto.SuspendLayout()
      Me.tabComposicion.SuspendLayout()
      CType(Me.ebrComposicion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrComposicion.SuspendLayout()
      Me.tabItemBarra.SuspendLayout()
      CType(Me.ebrItemBarra, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrItemBarra.SuspendLayout()
      Me.tabPrecio.SuspendLayout()
      CType(Me.UiGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox7.SuspendLayout()
      CType(Me.ebrItemPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrItemPrecio.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdDatoTecnico)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(420, 263)
      Me.ExplorerBarContainerControl4.TabIndex = 1
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
      Me.grdDatoTecnico.Size = New System.Drawing.Size(420, 263)
      Me.grdDatoTecnico.TabIndex = 3
      Me.grdDatoTecnico.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdDatoTecnico.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDatoTecnico.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDatoTecnico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl1
      '
      Me.ExplorerBarContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl1.Controls.Add(Me.grdSustituto)
      Me.ExplorerBarContainerControl1.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl1.Name = "ExplorerBarContainerControl1"
      Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(420, 263)
      Me.ExplorerBarContainerControl1.TabIndex = 1
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
      Me.grdSustituto.Size = New System.Drawing.Size(420, 263)
      Me.grdSustituto.TabIndex = 3
      Me.grdSustituto.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdSustituto.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdSustituto.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdSustituto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl2
      '
      Me.ExplorerBarContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl2.Controls.Add(Me.grdComposicion)
      Me.ExplorerBarContainerControl2.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl2.Name = "ExplorerBarContainerControl2"
      Me.ExplorerBarContainerControl2.Size = New System.Drawing.Size(420, 263)
      Me.ExplorerBarContainerControl2.TabIndex = 1
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
      Me.grdComposicion.Size = New System.Drawing.Size(420, 263)
      Me.grdComposicion.TabIndex = 3
      Me.grdComposicion.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdComposicion.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdComposicion.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdComposicion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl3
      '
      Me.ExplorerBarContainerControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl3.Controls.Add(Me.grdItemBarra)
      Me.ExplorerBarContainerControl3.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl3.Name = "ExplorerBarContainerControl3"
      Me.ExplorerBarContainerControl3.Size = New System.Drawing.Size(420, 263)
      Me.ExplorerBarContainerControl3.TabIndex = 1
      '
      'grdItemBarra
      '
      Me.grdItemBarra.AllowCardSizing = False
      Me.grdItemBarra.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdItemBarra.AlternatingColors = True
      Me.grdItemBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdItemBarra.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdItemBarra.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdItemBarra.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdItemBarra.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdItemBarra.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdItemBarra.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdItemBarra.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdItemBarra.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdItemBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdItemBarra.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdItemBarra.GroupByBoxVisible = False
      Me.grdItemBarra.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdItemBarra.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdItemBarra.Location = New System.Drawing.Point(0, 0)
      Me.grdItemBarra.Name = "grdItemBarra"
      Me.grdItemBarra.RecordNavigator = True
      Me.grdItemBarra.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdItemBarra.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdItemBarra.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdItemBarra.Size = New System.Drawing.Size(420, 263)
      Me.grdItemBarra.TabIndex = 3
      Me.grdItemBarra.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdItemBarra.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemBarra.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemBarra.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl5
      '
      Me.ExplorerBarContainerControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl5.Controls.Add(Me.grdItemPrecio)
      Me.ExplorerBarContainerControl5.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl5.Name = "ExplorerBarContainerControl5"
      Me.ExplorerBarContainerControl5.Size = New System.Drawing.Size(420, 191)
      Me.ExplorerBarContainerControl5.TabIndex = 1
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
      Me.grdItemPrecio.Size = New System.Drawing.Size(420, 191)
      Me.grdItemPrecio.TabIndex = 3
      Me.grdItemPrecio.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdItemPrecio.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemPrecio.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdItemPrecio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Print})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Print1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(271, 28)
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
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      Me.Print1.Text = "Código de Barra"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
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
      'Print
      '
      Me.Print.ImageIndex = 3
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "")
      Me.ilsMain.Images.SetKeyName(3, "")
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 363)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(8, 8)
      Me.tabMain.MultiLine = True
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(448, 348)
      Me.tabMain.TabIndex = 0
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabGeneral, Me.tabParametro, Me.tabDatoTecnico, Me.tabSustitucion, Me.tabComposicion, Me.tabItemBarra, Me.tabPrecio})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabGeneral
      '
      Me.tabGeneral.Controls.Add(Me.UiGroupBox3)
      Me.tabGeneral.Controls.Add(Me.UiGroupBox2)
      Me.tabGeneral.Key = "General"
      Me.tabGeneral.Location = New System.Drawing.Point(1, 39)
      Me.tabGeneral.Name = "tabGeneral"
      Me.tabGeneral.Size = New System.Drawing.Size(446, 308)
      Me.tabGeneral.TabStop = True
      Me.tabGeneral.Text = "General"
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox3.Controls.Add(Me.cboTipoCosteo)
      Me.UiGroupBox3.Controls.Add(Me.Label16)
      Me.UiGroupBox3.Controls.Add(Me.cboTipoItem)
      Me.UiGroupBox3.Controls.Add(Me.Label12)
      Me.UiGroupBox3.Controls.Add(Me.cboFabrica)
      Me.UiGroupBox3.Controls.Add(Me.Label10)
      Me.UiGroupBox3.Controls.Add(Me.cboMarca)
      Me.UiGroupBox3.Controls.Add(Me.Label9)
      Me.UiGroupBox3.Controls.Add(Me.txtUbicacion)
      Me.UiGroupBox3.Controls.Add(Me.Label8)
      Me.UiGroupBox3.Controls.Add(Me.txtItemDesAbr)
      Me.UiGroupBox3.Controls.Add(Me.Label7)
      Me.UiGroupBox3.Controls.Add(Me.txtItemDes)
      Me.UiGroupBox3.Controls.Add(Me.Label5)
      Me.UiGroupBox3.Controls.Add(Me.txtItemCod)
      Me.UiGroupBox3.Controls.Add(Me.Label6)
      Me.UiGroupBox3.Location = New System.Drawing.Point(8, 140)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(432, 160)
      Me.UiGroupBox3.TabIndex = 6
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'cboTipoCosteo
      '
      Me.cboTipoCosteo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCosteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoCosteo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCosteo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoCosteo.Location = New System.Drawing.Point(316, 132)
      Me.cboTipoCosteo.Name = "cboTipoCosteo"
      Me.cboTipoCosteo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoCosteo.Size = New System.Drawing.Size(108, 20)
      Me.cboTipoCosteo.TabIndex = 14
      Me.cboTipoCosteo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(232, 136)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(80, 16)
      Me.Label16.TabIndex = 216
      Me.Label16.Text = "Met. Costeo"
      '
      'cboTipoItem
      '
      Me.cboTipoItem.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoItem.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoItem.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoItem.Location = New System.Drawing.Point(116, 132)
      Me.cboTipoItem.Name = "cboTipoItem"
      Me.cboTipoItem.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoItem.Size = New System.Drawing.Size(108, 20)
      Me.cboTipoItem.TabIndex = 13
      Me.cboTipoItem.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 136)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 214
      Me.Label12.Text = "Tipo Ítem"
      '
      'cboFabrica
      '
      Me.cboFabrica.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboFabrica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboFabrica.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboFabrica.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboFabrica.Location = New System.Drawing.Point(316, 108)
      Me.cboFabrica.Name = "cboFabrica"
      Me.cboFabrica.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboFabrica.Size = New System.Drawing.Size(108, 20)
      Me.cboFabrica.TabIndex = 12
      Me.cboFabrica.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(236, 112)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(76, 16)
      Me.Label10.TabIndex = 213
      Me.Label10.Text = "Fabricación"
      '
      'cboMarca
      '
      Me.cboMarca.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMarca.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMarca.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMarca.Location = New System.Drawing.Point(116, 108)
      Me.cboMarca.Name = "cboMarca"
      Me.cboMarca.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMarca.Size = New System.Drawing.Size(108, 20)
      Me.cboMarca.TabIndex = 11
      Me.cboMarca.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 112)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 212
      Me.Label9.Text = "Marca"
      '
      'txtUbicacion
      '
      Me.txtUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtUbicacion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtUbicacion.Location = New System.Drawing.Point(116, 84)
      Me.txtUbicacion.MaxLength = 100
      Me.txtUbicacion.Name = "txtUbicacion"
      Me.txtUbicacion.Size = New System.Drawing.Size(308, 20)
      Me.txtUbicacion.TabIndex = 10
      Me.txtUbicacion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtUbicacion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 88)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 211
      Me.Label8.Text = "Ubicación"
      '
      'txtItemDesAbr
      '
      Me.txtItemDesAbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtItemDesAbr.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemDesAbr.Location = New System.Drawing.Point(116, 60)
      Me.txtItemDesAbr.MaxLength = 40
      Me.txtItemDesAbr.Name = "txtItemDesAbr"
      Me.txtItemDesAbr.Size = New System.Drawing.Size(308, 20)
      Me.txtItemDesAbr.TabIndex = 9
      Me.txtItemDesAbr.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemDesAbr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 64)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 210
      Me.Label7.Text = "Abreviación"
      '
      'txtItemDes
      '
      Me.txtItemDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtItemDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemDes.Location = New System.Drawing.Point(116, 36)
      Me.txtItemDes.MaxLength = 100
      Me.txtItemDes.Name = "txtItemDes"
      Me.txtItemDes.Size = New System.Drawing.Size(308, 20)
      Me.txtItemDes.TabIndex = 8
      Me.txtItemDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 40)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 209
      Me.Label5.Text = "Descripción"
      '
      'txtItemCod
      '
      Me.txtItemCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtItemCod.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemCod.Location = New System.Drawing.Point(116, 12)
      Me.txtItemCod.MaxLength = 50
      Me.txtItemCod.Name = "txtItemCod"
      Me.txtItemCod.Size = New System.Drawing.Size(108, 20)
      Me.txtItemCod.TabIndex = 7
      Me.txtItemCod.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemCod.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 16)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 207
      Me.Label6.Text = "Código"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox2.Controls.Add(Me.picImagen)
      Me.UiGroupBox2.Controls.Add(Me.txtEmpresaId)
      Me.UiGroupBox2.Controls.Add(Me.Label25)
      Me.UiGroupBox2.Controls.Add(Me.txtItemId)
      Me.UiGroupBox2.Controls.Add(Me.Label23)
      Me.UiGroupBox2.Controls.Add(Me.cboSubGrupo)
      Me.UiGroupBox2.Controls.Add(Me.Label3)
      Me.UiGroupBox2.Controls.Add(Me.cboGrupo)
      Me.UiGroupBox2.Controls.Add(Me.Label2)
      Me.UiGroupBox2.Controls.Add(Me.cboLinea)
      Me.UiGroupBox2.Controls.Add(Me.Label1)
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 4)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(432, 136)
      Me.UiGroupBox2.TabIndex = 0
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'picImagen
      '
      Me.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.picImagen.Cursor = System.Windows.Forms.Cursors.Hand
      Me.picImagen.Location = New System.Drawing.Point(316, 36)
      Me.picImagen.Name = "picImagen"
      Me.picImagen.Size = New System.Drawing.Size(108, 92)
      Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.picImagen.TabIndex = 213
      Me.picImagen.TabStop = False
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 36)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(192, 20)
      Me.txtEmpresaId.TabIndex = 2
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label25
      '
      Me.Label25.BackColor = System.Drawing.Color.Transparent
      Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label25.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label25.Location = New System.Drawing.Point(8, 40)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(104, 16)
      Me.Label25.TabIndex = 212
      Me.Label25.Text = "Empresa"
      '
      'txtItemId
      '
      Me.txtItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtItemId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtItemId.Location = New System.Drawing.Point(116, 12)
      Me.txtItemId.Name = "txtItemId"
      Me.txtItemId.ReadOnly = True
      Me.txtItemId.Size = New System.Drawing.Size(104, 20)
      Me.txtItemId.TabIndex = 1
      Me.txtItemId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtItemId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label23
      '
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label23.Location = New System.Drawing.Point(8, 16)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(104, 16)
      Me.Label23.TabIndex = 211
      Me.Label23.Text = "ID"
      '
      'cboSubGrupo
      '
      Me.cboSubGrupo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSubGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSubGrupo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSubGrupo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSubGrupo.Location = New System.Drawing.Point(116, 108)
      Me.cboSubGrupo.Name = "cboSubGrupo"
      Me.cboSubGrupo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSubGrupo.Size = New System.Drawing.Size(192, 20)
      Me.cboSubGrupo.TabIndex = 5
      Me.cboSubGrupo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(8, 112)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 210
      Me.Label3.Text = "SubGrupo"
      '
      'cboGrupo
      '
      Me.cboGrupo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboGrupo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGrupo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGrupo.Location = New System.Drawing.Point(116, 84)
      Me.cboGrupo.Name = "cboGrupo"
      Me.cboGrupo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboGrupo.Size = New System.Drawing.Size(192, 20)
      Me.cboGrupo.TabIndex = 4
      Me.cboGrupo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(8, 88)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 209
      Me.Label2.Text = "Grupo"
      '
      'cboLinea
      '
      Me.cboLinea.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboLinea.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboLinea.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboLinea.Location = New System.Drawing.Point(116, 60)
      Me.cboLinea.Name = "cboLinea"
      Me.cboLinea.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboLinea.Size = New System.Drawing.Size(192, 20)
      Me.cboLinea.TabIndex = 3
      Me.cboLinea.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(8, 64)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 208
      Me.Label1.Text = "Línea"
      '
      'tabParametro
      '
      Me.tabParametro.Controls.Add(Me.UiGroupBox8)
      Me.tabParametro.Controls.Add(Me.UiGroupBox1)
      Me.tabParametro.Controls.Add(Me.cboEstado)
      Me.tabParametro.Controls.Add(Me.Label24)
      Me.tabParametro.Controls.Add(Me.UiGroupBox6)
      Me.tabParametro.Controls.Add(Me.UiGroupBox5)
      Me.tabParametro.Controls.Add(Me.UiGroupBox4)
      Me.tabParametro.Controls.Add(Me.Label22)
      Me.tabParametro.Controls.Add(Me.txtObs)
      Me.tabParametro.Controls.Add(Me.cboPlanGrupo)
      Me.tabParametro.Controls.Add(Me.Label17)
      Me.tabParametro.Key = "Parametro"
      Me.tabParametro.Location = New System.Drawing.Point(1, 39)
      Me.tabParametro.Name = "tabParametro"
      Me.tabParametro.Size = New System.Drawing.Size(446, 308)
      Me.tabParametro.TabStop = True
      Me.tabParametro.Text = "Parámetros"
      Me.tabParametro.Visible = False
      '
      'UiGroupBox8
      '
      Me.UiGroupBox8.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox8.Controls.Add(Me.cboMonedaVen)
      Me.UiGroupBox8.Controls.Add(Me.Label11)
      Me.UiGroupBox8.Controls.Add(Me.cboMonedaCos)
      Me.UiGroupBox8.Controls.Add(Me.Label27)
      Me.UiGroupBox8.Location = New System.Drawing.Point(8, 108)
      Me.UiGroupBox8.Name = "UiGroupBox8"
      Me.UiGroupBox8.Size = New System.Drawing.Size(432, 40)
      Me.UiGroupBox8.TabIndex = 22
      Me.UiGroupBox8.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboMonedaVen
      '
      Me.cboMonedaVen.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMonedaVen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaVen.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaVen.Location = New System.Drawing.Point(316, 12)
      Me.cboMonedaVen.Name = "cboMonedaVen"
      Me.cboMonedaVen.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMonedaVen.Size = New System.Drawing.Size(108, 20)
      Me.cboMonedaVen.TabIndex = 24
      Me.cboMonedaVen.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(240, 16)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(76, 16)
      Me.Label11.TabIndex = 231
      Me.Label11.Text = "Mon. Venta"
      '
      'cboMonedaCos
      '
      Me.cboMonedaCos.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMonedaCos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaCos.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMonedaCos.Location = New System.Drawing.Point(116, 12)
      Me.cboMonedaCos.Name = "cboMonedaCos"
      Me.cboMonedaCos.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMonedaCos.Size = New System.Drawing.Size(108, 20)
      Me.cboMonedaCos.TabIndex = 23
      Me.cboMonedaCos.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label27
      '
      Me.Label27.BackColor = System.Drawing.Color.Transparent
      Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label27.Location = New System.Drawing.Point(8, 16)
      Me.Label27.Name = "Label27"
      Me.Label27.Size = New System.Drawing.Size(104, 16)
      Me.Label27.TabIndex = 229
      Me.Label27.Text = "Moneda Costo"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox1.Controls.Add(Me.txtCantidadMax)
      Me.UiGroupBox1.Controls.Add(Me.Label14)
      Me.UiGroupBox1.Controls.Add(Me.txtCantidadMin)
      Me.UiGroupBox1.Controls.Add(Me.Label13)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 68)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(432, 40)
      Me.UiGroupBox1.TabIndex = 19
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtCantidadMax
      '
      Me.txtCantidadMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCantidadMax.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCantidadMax.FormatString = "##,##0.000"
      Me.txtCantidadMax.Location = New System.Drawing.Point(316, 12)
      Me.txtCantidadMax.Name = "txtCantidadMax"
      Me.txtCantidadMax.Size = New System.Drawing.Size(108, 20)
      Me.txtCantidadMax.TabIndex = 21
      Me.txtCantidadMax.Text = "0,000"
      Me.txtCantidadMax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCantidadMax.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCantidadMax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(232, 16)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(84, 14)
      Me.Label14.TabIndex = 235
      Me.Label14.Text = "Cantidad Max"
      '
      'txtCantidadMin
      '
      Me.txtCantidadMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCantidadMin.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCantidadMin.FormatString = "##,##0.000"
      Me.txtCantidadMin.Location = New System.Drawing.Point(116, 12)
      Me.txtCantidadMin.Name = "txtCantidadMin"
      Me.txtCantidadMin.Size = New System.Drawing.Size(108, 20)
      Me.txtCantidadMin.TabIndex = 20
      Me.txtCantidadMin.Text = "0,000"
      Me.txtCantidadMin.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCantidadMin.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCantidadMin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(8, 14)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(104, 16)
      Me.Label13.TabIndex = 234
      Me.Label13.Text = "Cantidad Min"
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(324, 196)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(108, 20)
      Me.cboEstado.TabIndex = 29
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label24
      '
      Me.Label24.BackColor = System.Drawing.Color.Transparent
      Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label24.Location = New System.Drawing.Point(272, 200)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(48, 16)
      Me.Label24.TabIndex = 225
      Me.Label24.Text = "Estado"
      '
      'UiGroupBox6
      '
      Me.UiGroupBox6.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox6.Controls.Add(Me.chkControlLote)
      Me.UiGroupBox6.Controls.Add(Me.chkControlSerie)
      Me.UiGroupBox6.Location = New System.Drawing.Point(124, 268)
      Me.UiGroupBox6.Name = "UiGroupBox6"
      Me.UiGroupBox6.Size = New System.Drawing.Size(316, 32)
      Me.UiGroupBox6.TabIndex = 31
      Me.UiGroupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkControlLote
      '
      Me.chkControlLote.BackColor = System.Drawing.Color.Transparent
      Me.chkControlLote.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkControlLote.Location = New System.Drawing.Point(8, 12)
      Me.chkControlLote.Name = "chkControlLote"
      Me.chkControlLote.Size = New System.Drawing.Size(112, 16)
      Me.chkControlLote.TabIndex = 32
      Me.chkControlLote.Text = "Control de Lotes"
      Me.chkControlLote.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkControlSerie
      '
      Me.chkControlSerie.BackColor = System.Drawing.Color.Transparent
      Me.chkControlSerie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkControlSerie.Location = New System.Drawing.Point(180, 12)
      Me.chkControlSerie.Name = "chkControlSerie"
      Me.chkControlSerie.Size = New System.Drawing.Size(128, 16)
      Me.chkControlSerie.TabIndex = 33
      Me.chkControlSerie.Text = "Números de Series"
      Me.chkControlSerie.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'UiGroupBox5
      '
      Me.UiGroupBox5.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox5.Controls.Add(Me.Label19)
      Me.UiGroupBox5.Controls.Add(Me.txtTipoTasaMonto)
      Me.UiGroupBox5.Controls.Add(Me.cboTipoTasa)
      Me.UiGroupBox5.Controls.Add(Me.Label18)
      Me.UiGroupBox5.Location = New System.Drawing.Point(8, 148)
      Me.UiGroupBox5.Name = "UiGroupBox5"
      Me.UiGroupBox5.Size = New System.Drawing.Size(432, 40)
      Me.UiGroupBox5.TabIndex = 25
      Me.UiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label19
      '
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(236, 16)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(76, 16)
      Me.Label19.TabIndex = 217
      Me.Label19.Text = "Monto Tasa"
      '
      'txtTipoTasaMonto
      '
      Me.txtTipoTasaMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTipoTasaMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoTasaMonto.FormatString = "##,##0.000"
      Me.txtTipoTasaMonto.Location = New System.Drawing.Point(316, 12)
      Me.txtTipoTasaMonto.Name = "txtTipoTasaMonto"
      Me.txtTipoTasaMonto.Size = New System.Drawing.Size(108, 20)
      Me.txtTipoTasaMonto.TabIndex = 27
      Me.txtTipoTasaMonto.Text = "0,000"
      Me.txtTipoTasaMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoTasaMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoTasaMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboTipoTasa
      '
      Me.cboTipoTasa.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoTasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoTasa.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoTasa.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoTasa.Location = New System.Drawing.Point(116, 12)
      Me.cboTipoTasa.Name = "cboTipoTasa"
      Me.cboTipoTasa.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoTasa.Size = New System.Drawing.Size(108, 20)
      Me.cboTipoTasa.TabIndex = 26
      Me.cboTipoTasa.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 16)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 216
      Me.Label18.Text = "Tipo de Tasa"
      '
      'UiGroupBox4
      '
      Me.UiGroupBox4.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox4.Controls.Add(Me.lblMedidaEqui)
      Me.UiGroupBox4.Controls.Add(Me.Label21)
      Me.UiGroupBox4.Controls.Add(Me.Label20)
      Me.UiGroupBox4.Controls.Add(Me.cboMedidaEqui)
      Me.UiGroupBox4.Controls.Add(Me.txtMedidaCantEqui)
      Me.UiGroupBox4.Controls.Add(Me.cboMedida)
      Me.UiGroupBox4.Controls.Add(Me.Label15)
      Me.UiGroupBox4.Location = New System.Drawing.Point(8, 4)
      Me.UiGroupBox4.Name = "UiGroupBox4"
      Me.UiGroupBox4.Size = New System.Drawing.Size(432, 64)
      Me.UiGroupBox4.TabIndex = 15
      Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'lblMedidaEqui
      '
      Me.lblMedidaEqui.BackColor = System.Drawing.Color.Transparent
      Me.lblMedidaEqui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMedidaEqui.Location = New System.Drawing.Point(232, 40)
      Me.lblMedidaEqui.Name = "lblMedidaEqui"
      Me.lblMedidaEqui.Size = New System.Drawing.Size(192, 16)
      Me.lblMedidaEqui.TabIndex = 231
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.Location = New System.Drawing.Point(236, 16)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(76, 16)
      Me.Label21.TabIndex = 230
      Me.Label21.Text = "Med. Equiv."
      '
      'Label20
      '
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(8, 40)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(104, 16)
      Me.Label20.TabIndex = 229
      Me.Label20.Text = "Equivale a"
      '
      'cboMedidaEqui
      '
      Me.cboMedidaEqui.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedidaEqui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMedidaEqui.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedidaEqui.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedidaEqui.Location = New System.Drawing.Point(316, 12)
      Me.cboMedidaEqui.Name = "cboMedidaEqui"
      Me.cboMedidaEqui.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMedidaEqui.Size = New System.Drawing.Size(108, 20)
      Me.cboMedidaEqui.TabIndex = 17
      Me.cboMedidaEqui.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtMedidaCantEqui
      '
      Me.txtMedidaCantEqui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMedidaCantEqui.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMedidaCantEqui.FormatString = "##,##0.000"
      Me.txtMedidaCantEqui.Location = New System.Drawing.Point(116, 36)
      Me.txtMedidaCantEqui.Name = "txtMedidaCantEqui"
      Me.txtMedidaCantEqui.ReadOnly = True
      Me.txtMedidaCantEqui.Size = New System.Drawing.Size(108, 20)
      Me.txtMedidaCantEqui.TabIndex = 18
      Me.txtMedidaCantEqui.Text = "0,000"
      Me.txtMedidaCantEqui.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMedidaCantEqui.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMedidaCantEqui.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboMedida
      '
      Me.cboMedida.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMedida.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMedida.Location = New System.Drawing.Point(116, 12)
      Me.cboMedida.Name = "cboMedida"
      Me.cboMedida.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMedida.Size = New System.Drawing.Size(108, 20)
      Me.cboMedida.TabIndex = 16
      Me.cboMedida.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 16)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 228
      Me.Label15.Text = "Medida Mínima"
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(16, 228)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(104, 16)
      Me.Label22.TabIndex = 219
      Me.Label22.Text = "Observaciones"
      '
      'txtObs
      '
      Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtObs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtObs.Location = New System.Drawing.Point(124, 224)
      Me.txtObs.Multiline = True
      Me.txtObs.Name = "txtObs"
      Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtObs.Size = New System.Drawing.Size(308, 44)
      Me.txtObs.TabIndex = 30
      Me.txtObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanGrupo
      '
      Me.cboPlanGrupo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanGrupo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanGrupo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanGrupo.Location = New System.Drawing.Point(124, 196)
      Me.cboPlanGrupo.Name = "cboPlanGrupo"
      Me.cboPlanGrupo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPlanGrupo.Size = New System.Drawing.Size(108, 20)
      Me.cboPlanGrupo.TabIndex = 28
      Me.cboPlanGrupo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(16, 200)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(104, 16)
      Me.Label17.TabIndex = 209
      Me.Label17.Text = "Grupo de Cuenta"
      '
      'tabDatoTecnico
      '
      Me.tabDatoTecnico.Controls.Add(Me.ebrDatoTecnico)
      Me.tabDatoTecnico.Key = "DatoTecnico"
      Me.tabDatoTecnico.Location = New System.Drawing.Point(1, 39)
      Me.tabDatoTecnico.Name = "tabDatoTecnico"
      Me.tabDatoTecnico.Size = New System.Drawing.Size(446, 308)
      Me.tabDatoTecnico.TabStop = True
      Me.tabDatoTecnico.Text = "Datos Técnicos"
      '
      'ebrDatoTecnico
      '
      Me.ebrDatoTecnico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrDatoTecnico.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrDatoTecnico.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 264
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrDatoTecnico.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrDatoTecnico.GroupSeparation = 4
      Me.ebrDatoTecnico.Location = New System.Drawing.Point(5, 6)
      Me.ebrDatoTecnico.Name = "ebrDatoTecnico"
      Me.ebrDatoTecnico.Size = New System.Drawing.Size(436, 296)
      Me.ebrDatoTecnico.TabIndex = 4
      Me.ebrDatoTecnico.Text = "ExplorerBar2"
      Me.ebrDatoTecnico.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrDatoTecnico.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDatoTecnico.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDatoTecnico.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabSustitucion
      '
      Me.tabSustitucion.Controls.Add(Me.ebrSustituto)
      Me.tabSustitucion.Key = "Sustitucion"
      Me.tabSustitucion.Location = New System.Drawing.Point(1, 39)
      Me.tabSustitucion.Name = "tabSustitucion"
      Me.tabSustitucion.Size = New System.Drawing.Size(446, 308)
      Me.tabSustitucion.TabStop = True
      Me.tabSustitucion.Text = "Sustituciones"
      '
      'ebrSustituto
      '
      Me.ebrSustituto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrSustituto.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrSustituto.Controls.Add(Me.ExplorerBarContainerControl1)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl1
      ExplorerBarGroup2.ContainerHeight = 264
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ebrSustituto.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ebrSustituto.GroupSeparation = 4
      Me.ebrSustituto.Location = New System.Drawing.Point(5, 6)
      Me.ebrSustituto.Name = "ebrSustituto"
      Me.ebrSustituto.Size = New System.Drawing.Size(436, 296)
      Me.ebrSustituto.TabIndex = 4
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
      Me.tabComposicion.Size = New System.Drawing.Size(446, 308)
      Me.tabComposicion.TabStop = True
      Me.tabComposicion.Text = "Composición"
      '
      'ebrComposicion
      '
      Me.ebrComposicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrComposicion.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrComposicion.Controls.Add(Me.ExplorerBarContainerControl2)
      ExplorerBarGroup3.Container = True
      ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl2
      ExplorerBarGroup3.ContainerHeight = 264
      ExplorerBarGroup3.Expandable = False
      ExplorerBarGroup3.Key = "Group1"
      Me.ebrComposicion.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
      Me.ebrComposicion.GroupSeparation = 4
      Me.ebrComposicion.Location = New System.Drawing.Point(5, 6)
      Me.ebrComposicion.Name = "ebrComposicion"
      Me.ebrComposicion.Size = New System.Drawing.Size(436, 296)
      Me.ebrComposicion.TabIndex = 4
      Me.ebrComposicion.Text = "ExplorerBar2"
      Me.ebrComposicion.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrComposicion.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrComposicion.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrComposicion.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabItemBarra
      '
      Me.tabItemBarra.Controls.Add(Me.ebrItemBarra)
      Me.tabItemBarra.Key = "ItemBarra"
      Me.tabItemBarra.Location = New System.Drawing.Point(1, 39)
      Me.tabItemBarra.Name = "tabItemBarra"
      Me.tabItemBarra.Size = New System.Drawing.Size(446, 308)
      Me.tabItemBarra.TabStop = True
      Me.tabItemBarra.Text = "Códigos de Barra"
      '
      'ebrItemBarra
      '
      Me.ebrItemBarra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrItemBarra.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrItemBarra.Controls.Add(Me.ExplorerBarContainerControl3)
      ExplorerBarGroup4.Container = True
      ExplorerBarGroup4.ContainerControl = Me.ExplorerBarContainerControl3
      ExplorerBarGroup4.ContainerHeight = 264
      ExplorerBarGroup4.Expandable = False
      ExplorerBarGroup4.Key = "Group1"
      Me.ebrItemBarra.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup4})
      Me.ebrItemBarra.GroupSeparation = 4
      Me.ebrItemBarra.Location = New System.Drawing.Point(5, 6)
      Me.ebrItemBarra.Name = "ebrItemBarra"
      Me.ebrItemBarra.Size = New System.Drawing.Size(436, 296)
      Me.ebrItemBarra.TabIndex = 4
      Me.ebrItemBarra.Text = "ExplorerBar2"
      Me.ebrItemBarra.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrItemBarra.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemBarra.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemBarra.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabPrecio
      '
      Me.tabPrecio.Controls.Add(Me.UiGroupBox7)
      Me.tabPrecio.Controls.Add(Me.ebrItemPrecio)
      Me.tabPrecio.Key = "Precio"
      Me.tabPrecio.Location = New System.Drawing.Point(1, 39)
      Me.tabPrecio.Name = "tabPrecio"
      Me.tabPrecio.Size = New System.Drawing.Size(446, 308)
      Me.tabPrecio.TabStop = True
      Me.tabPrecio.Text = "Precios de Venta"
      '
      'UiGroupBox7
      '
      Me.UiGroupBox7.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox7.Controls.Add(Me.txtUtilidad)
      Me.UiGroupBox7.Controls.Add(Me.Label26)
      Me.UiGroupBox7.Controls.Add(Me.txtComision)
      Me.UiGroupBox7.Controls.Add(Me.Label4)
      Me.UiGroupBox7.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox7.Location = New System.Drawing.Point(7, 0)
      Me.UiGroupBox7.Name = "UiGroupBox7"
      Me.UiGroupBox7.Size = New System.Drawing.Size(432, 70)
      Me.UiGroupBox7.TabIndex = 0
      Me.UiGroupBox7.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtUtilidad
      '
      Me.txtUtilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtUtilidad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtUtilidad.FormatString = "##,##0.000"
      Me.txtUtilidad.Location = New System.Drawing.Point(92, 40)
      Me.txtUtilidad.Name = "txtUtilidad"
      Me.txtUtilidad.Size = New System.Drawing.Size(108, 20)
      Me.txtUtilidad.TabIndex = 2
      Me.txtUtilidad.Text = "0,000"
      Me.txtUtilidad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtUtilidad.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtUtilidad.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label26
      '
      Me.Label26.BackColor = System.Drawing.Color.Transparent
      Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label26.Location = New System.Drawing.Point(8, 43)
      Me.Label26.Name = "Label26"
      Me.Label26.Size = New System.Drawing.Size(76, 16)
      Me.Label26.TabIndex = 234
      Me.Label26.Text = "Utilidad %"
      '
      'txtComision
      '
      Me.txtComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtComision.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtComision.FormatString = "##,##0.000"
      Me.txtComision.Location = New System.Drawing.Point(92, 16)
      Me.txtComision.Name = "txtComision"
      Me.txtComision.Size = New System.Drawing.Size(108, 20)
      Me.txtComision.TabIndex = 1
      Me.txtComision.Text = "0,000"
      Me.txtComision.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtComision.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtComision.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 18)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(76, 16)
      Me.Label4.TabIndex = 232
      Me.Label4.Text = "Comisión %"
      '
      'ebrItemPrecio
      '
      Me.ebrItemPrecio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrItemPrecio.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrItemPrecio.Controls.Add(Me.ExplorerBarContainerControl5)
      ExplorerBarGroup5.Container = True
      ExplorerBarGroup5.ContainerControl = Me.ExplorerBarContainerControl5
      ExplorerBarGroup5.ContainerHeight = 192
      ExplorerBarGroup5.Expandable = False
      ExplorerBarGroup5.Key = "Group1"
      Me.ebrItemPrecio.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup5})
      Me.ebrItemPrecio.GroupSeparation = 4
      Me.ebrItemPrecio.Location = New System.Drawing.Point(5, 76)
      Me.ebrItemPrecio.Name = "ebrItemPrecio"
      Me.ebrItemPrecio.Size = New System.Drawing.Size(436, 224)
      Me.ebrItemPrecio.TabIndex = 207
      Me.ebrItemPrecio.Text = "ExplorerBar2"
      Me.ebrItemPrecio.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrItemPrecio.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemPrecio.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrItemPrecio.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'mnuDatoTecnico
      '
      Me.mnuDatoTecnico.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowDato, Me.mnuNewDato, Me.mnuEditDato, Me.mnuDeletedato})
      '
      'mnuShowDato
      '
      Me.mnuShowDato.Index = 0
      Me.mnuShowDato.Text = "Consultar"
      '
      'mnuNewDato
      '
      Me.mnuNewDato.Index = 1
      Me.mnuNewDato.Text = "Nuevo"
      '
      'mnuEditDato
      '
      Me.mnuEditDato.Index = 2
      Me.mnuEditDato.Text = "Editar"
      '
      'mnuDeletedato
      '
      Me.mnuDeletedato.Index = 3
      Me.mnuDeletedato.Text = "Eliminar"
      '
      'mnuSustituto
      '
      Me.mnuSustituto.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuNew, Me.mnuEdit, Me.mnuDelete})
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
      'mnuComposicion
      '
      Me.mnuComposicion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowCom, Me.mnuNewCom, Me.mnuEditCom, Me.mnuDeleteCom})
      '
      'mnuShowCom
      '
      Me.mnuShowCom.Index = 0
      Me.mnuShowCom.Text = "Consultar"
      '
      'mnuNewCom
      '
      Me.mnuNewCom.Index = 1
      Me.mnuNewCom.Text = "Nuevo"
      '
      'mnuEditCom
      '
      Me.mnuEditCom.Index = 2
      Me.mnuEditCom.Text = "Editar"
      '
      'mnuDeleteCom
      '
      Me.mnuDeleteCom.Index = 3
      Me.mnuDeleteCom.Text = "Eliminar"
      '
      'mnuItemBarra
      '
      Me.mnuItemBarra.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowBar, Me.mnuNewBar, Me.mnuEditBar, Me.mnuDeleteBar})
      '
      'mnuShowBar
      '
      Me.mnuShowBar.Index = 0
      Me.mnuShowBar.Text = "Consultar"
      '
      'mnuNewBar
      '
      Me.mnuNewBar.Index = 1
      Me.mnuNewBar.Text = "Nuevo"
      '
      'mnuEditBar
      '
      Me.mnuEditBar.Index = 2
      Me.mnuEditBar.Text = "Editar"
      '
      'mnuDeleteBar
      '
      Me.mnuDeleteBar.Index = 3
      Me.mnuDeleteBar.Text = "Eliminar"
      '
      'mnuPrecio
      '
      Me.mnuPrecio.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowPre, Me.mnuNewPre, Me.mnuEditPre, Me.mnuDeletePre})
      '
      'mnuShowPre
      '
      Me.mnuShowPre.Index = 0
      Me.mnuShowPre.Text = "Consultar"
      '
      'mnuNewPre
      '
      Me.mnuNewPre.Index = 1
      Me.mnuNewPre.Text = "Nuevo"
      '
      'mnuEditPre
      '
      Me.mnuEditPre.Index = 2
      Me.mnuEditPre.Text = "Editar"
      '
      'mnuDeletePre
      '
      Me.mnuDeletePre.Index = 3
      Me.mnuDeletePre.Text = "Eliminar"
      '
      'frmItemEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 391)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmItemEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Item Edit"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdDatoTecnico, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl1.ResumeLayout(False)
      CType(Me.grdSustituto, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl2.ResumeLayout(False)
      CType(Me.grdComposicion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl3.ResumeLayout(False)
      CType(Me.grdItemBarra, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl5.ResumeLayout(False)
      CType(Me.grdItemPrecio, System.ComponentModel.ISupportInitialize).EndInit()
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
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      Me.UiGroupBox3.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabParametro.ResumeLayout(False)
      Me.tabParametro.PerformLayout()
      CType(Me.UiGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox8.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox6.ResumeLayout(False)
      CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox5.ResumeLayout(False)
      Me.UiGroupBox5.PerformLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox4.ResumeLayout(False)
      Me.UiGroupBox4.PerformLayout()
      Me.tabDatoTecnico.ResumeLayout(False)
      CType(Me.ebrDatoTecnico, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrDatoTecnico.ResumeLayout(False)
      Me.tabSustitucion.ResumeLayout(False)
      CType(Me.ebrSustituto, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrSustituto.ResumeLayout(False)
      Me.tabComposicion.ResumeLayout(False)
      CType(Me.ebrComposicion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrComposicion.ResumeLayout(False)
      Me.tabItemBarra.ResumeLayout(False)
      CType(Me.ebrItemBarra, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrItemBarra.ResumeLayout(False)
      Me.tabPrecio.ResumeLayout(False)
      CType(Me.UiGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox7.ResumeLayout(False)
      Me.UiGroupBox7.PerformLayout()
      CType(Me.ebrItemPrecio, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrItemPrecio.ResumeLayout(False)
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
               mlngID = moItem.ItemId
               mboolChanged = True

               If mboolAdding = True Then
                  mboolAdding = False
                  mboolEditing = True

                  Call grdSustitutoLoad()
                  Call grdComposicionLoad()
                  Call grdDatoTecnicoLoad()
                  Call grdItemPrecioLoad()

                  tabMain.TabPages.Item("DatoTecnico").Enabled = True
                  tabMain.TabPages.Item("Sustitucion").Enabled = True
                  tabMain.TabPages.Item("ItemBarra").Enabled = True
                  tabMain.TabPages.Item("Precio").Enabled = True

                  If moItem.TipoItemId = 3 Then
                     ''cboTipoItem.ReadOnly = True
                     chkControlLote.Enabled = False
                     chkControlSerie.Enabled = False
                     tabMain.TabPages.Item("Composicion").Enabled = True
                  Else
                     tabMain.TabPages.Item("Composicion").Enabled = False
                  End If
               Else
                  Me.Close()
               End If

            End If

         Case "Print"
            Call PrintReport()

         Case "Exit"
            If mboolEditing Then
               If ItemTieneComposicion(moItem.ItemId) Then
                  Me.Close()
               End If
            Else
               Me.Close()
            End If

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmItemEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmItemEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Item"
         Else
            Call UpdateReadOnly()
            Me.Text = "Editar Item"
         End If
      Else
         Me.Text = "Nuevo Item"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moItem
         txtItemId.Text = ToStr(.ItemId)
         Call txtEmpresaIdLoad(.EmpresaId)
         cboLinea.SelectedIndex = ListFindItem(cboLinea, .LineaId)
         cboGrupo.SelectedIndex = ListFindItem(cboGrupo, .GrupoId)
         cboSubGrupo.SelectedIndex = ListFindItem(cboSubGrupo, .SubGrupoId)
         Call lblImagenLoad(.Imagen)
         txtItemCod.Text = ToStr(.ItemCod)
         txtItemDes.Text = ToStr(.ItemDes)
         txtItemDesAbr.Text = ToStr(.ItemDesAbr)
         txtUbicacion.Text = ToStr(.Ubicacion)
         cboMarca.SelectedIndex = ListFindItem(cboMarca, .MarcaId)
         cboFabrica.SelectedIndex = ListFindItem(cboFabrica, .FabricaId)
         cboTipoItem.SelectedIndex = ListFindItem(cboTipoItem, .TipoItemId)
         txtCantidadMin.Text = ToStr(.CantidadMin)
         txtCantidadMax.Text = ToStr(.CantidadMax)
         cboMedida.SelectedIndex = ListFindItem(cboMedida, .MedidaId)
         cboMedidaEqui.SelectedIndex = ListFindItem(cboMedidaEqui, .MedidaIdEqui)
         txtMedidaCantEqui.Text = ToStr(.MedidaCantEqui)
         cboMonedaCos.SelectedIndex = ListFindItem(cboMonedaCos, .MonedaIdCos)
         cboMonedaVen.SelectedIndex = ListFindItem(cboMonedaVen, .MonedaIdVen)
         cboPlanGrupo.SelectedIndex = ListFindItem(cboPlanGrupo, .PlanGrupoId)
         cboTipoCosteo.SelectedIndex = ListFindItem(cboTipoCosteo, .TipoCosteoId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         cboTipoTasa.SelectedIndex = ListFindItem(cboTipoTasa, .TipoTasaId)
         txtTipoTasaMonto.Text = ToStr(.TipoTasaMonto)
         txtObs.Text = ToStr(.Obs)
         chkControlLote.Checked = ToBoolean(.ControlLote)
         chkControlSerie.Checked = ToBoolean(.ControlSerie)
         txtComision.Text = ToStr(.Comision)
         txtUtilidad.Text = ToStr(.Utilidad)
      End With

      Call grdSustitutoLoad()
      Call grdComposicionLoad()
      Call grdDatoTecnicoLoad()
      Call grdItemBarraLoad()
      Call grdItemPrecioLoad()

      If moItem.TipoItemId = 3 Then
         tabMain.TabPages.Item("Composicion").Enabled = True
         cboTipoItem.ReadOnly = True
         chkControlLote.Enabled = False
         chkControlSerie.Enabled = False
      Else
         tabMain.TabPages.Item("Composicion").Enabled = False
      End If

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moItem
         txtItemId.Text = String.Empty
         Call txtEmpresaIdLoad(.EmpresaId)
         cboLinea.SelectedIndex = ListFindItem(cboLinea, .LineaId)
         cboGrupo.SelectedIndex = ListFindItem(cboGrupo, .GrupoId)
         cboSubGrupo.SelectedIndex = ListFindItem(cboSubGrupo, .SubGrupoId)
         picImagen.Image = Nothing
         txtItemCod.Text = ItemCodNext()
         txtItemDes.Text = String.Empty
         txtItemDesAbr.Text = String.Empty
         txtUbicacion.Text = String.Empty
         cboMarca.SelectedIndex = ListFindItem(cboMarca, .MarcaId)
         cboFabrica.SelectedIndex = ListFindItem(cboFabrica, .FabricaId)
         cboTipoItem.SelectedIndex = ListFindItem(cboTipoItem, .TipoItemId)
         txtCantidadMin.Text = ToStr(.CantidadMin)
         txtCantidadMax.Text = ToStr(.CantidadMax)
         cboMedida.SelectedIndex = ListFindItem(cboMedida, .MedidaId)
         cboMedidaEqui.SelectedIndex = ListFindItem(cboMedidaEqui, .MedidaIdEqui)
         txtMedidaCantEqui.Text = ToStr(.MedidaCantEqui)
         cboMonedaCos.SelectedIndex = ListFindItem(cboMonedaCos, .MonedaIdCos)
         cboMonedaVen.SelectedIndex = ListFindItem(cboMonedaVen, .MonedaIdVen)
         cboPlanGrupo.SelectedIndex = ListFindItem(cboPlanGrupo, .PlanGrupoId)
         cboTipoCosteo.SelectedIndex = ListFindItem(cboTipoCosteo, .TipoCosteoId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 1)
         cboTipoTasa.SelectedIndex = -1
         txtTipoTasaMonto.Text = "0"
         txtObs.Text = String.Empty
         chkControlLote.Checked = ToBoolean(.ControlLote)
         chkControlSerie.Checked = ToBoolean(.ControlSerie)
         txtComision.Text = ToStr(.Comision)
         txtUtilidad.Text = ToStr(.Utilidad)

         If moItem.TipoItemId = 3 Then
            tabMain.TabPages.Item("Composicion").Enabled = True
         End If
      End With

      tabMain.TabPages.Item("DatoTecnico").Enabled = False
      tabMain.TabPages.Item("Sustitucion").Enabled = False
      tabMain.TabPages.Item("Composicion").Enabled = False
      tabMain.TabPages.Item("ItemBarra").Enabled = False
      tabMain.TabPages.Item("Precio").Enabled = False

      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtItemId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      cboLinea.ReadOnly = True
      cboGrupo.ReadOnly = True
      cboSubGrupo.ReadOnly = True
      picImagen.Enabled = False
      txtItemCod.ReadOnly = True
      txtItemDes.ReadOnly = True
      txtItemDesAbr.ReadOnly = True
      txtUbicacion.ReadOnly = True
      cboMarca.ReadOnly = True
      cboFabrica.ReadOnly = True
      cboTipoItem.ReadOnly = True
      txtCantidadMin.ReadOnly = True
      txtCantidadMax.ReadOnly = True
      cboMedida.ReadOnly = True
      cboMedidaEqui.ReadOnly = True
      txtMedidaCantEqui.ReadOnly = True
      cboMonedaCos.ReadOnly = True
      cboMonedaVen.ReadOnly = True
      cboPlanGrupo.ReadOnly = True
      cboTipoCosteo.ReadOnly = True
      cboEstado.ReadOnly = True
      cboTipoTasa.ReadOnly = True
      txtTipoTasaMonto.ReadOnly = True
      txtObs.ReadOnly = True
      chkControlLote.Enabled = False
      chkControlSerie.Enabled = False
      txtComision.ReadOnly = True
      txtUtilidad.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub UpdateReadOnly()
      'If NotaDetFind(moItem.ItemId) Or VentaDetFind(moItem.ItemId) Then
      If ItemMovFind(moItem.ItemId) Then
         cboTipoItem.ReadOnly = True
         cboMedida.ReadOnly = True
         cboMedidaEqui.ReadOnly = True
         txtMedidaCantEqui.ReadOnly = True
         cboMonedaCos.ReadOnly = True
         cboMonedaVen.ReadOnly = True
         cboPlanGrupo.ReadOnly = True
         cboTipoCosteo.ReadOnly = True
         chkControlLote.Enabled = False
         chkControlSerie.Enabled = False
      End If
      ''End If

   End Sub

   Private Sub DataMove()
      With moItem
         If Not mboolAdding Then
            .ItemId = ToLong(txtItemId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .LineaId = ListPosition(cboLinea, cboLinea.SelectedIndex)
         .GrupoId = ListPosition(cboGrupo, cboGrupo.SelectedIndex)
         .SubGrupoId = ListPosition(cboSubGrupo, cboSubGrupo.SelectedIndex)
         .Imagen = ToStr(picImagen.Tag)
         .ItemCod = ToStr(txtItemCod.Text)
         .ItemDes = ToStr(txtItemDes.Text)
         .ItemDesAbr = ToStr(txtItemDesAbr.Text)
         .Ubicacion = ToStr(txtUbicacion.Text)
         .MarcaId = ListPosition(cboMarca, cboMarca.SelectedIndex)
         .FabricaId = ListPosition(cboFabrica, cboFabrica.SelectedIndex)
         .TipoItemId = ListPosition(cboTipoItem, cboTipoItem.SelectedIndex)
         .CantidadMin = ToDecimal(txtCantidadMin.Text)
         .CantidadMax = ToDecimal(txtCantidadMax.Text)
         .MedidaId = ListPosition(cboMedida, cboMedida.SelectedIndex)
         .MedidaIdEqui = ListPosition(cboMedidaEqui, cboMedidaEqui.SelectedIndex)
         .MedidaCantEqui = ToDecimal(txtMedidaCantEqui.Text)
         .MonedaIdCos = ListPosition(cboMonedaCos, cboMonedaCos.SelectedIndex)
         .MonedaIdVen = ListPosition(cboMonedaVen, cboMonedaVen.SelectedIndex)
         .PlanGrupoId = ListPosition(cboPlanGrupo, cboPlanGrupo.SelectedIndex)
         .TipoCosteoId = ListPosition(cboTipoCosteo, cboTipoCosteo.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .TipoTasaId = ListPosition(cboTipoTasa, cboTipoTasa.SelectedIndex)
         .TipoTasaMonto = ToDecimal(txtTipoTasaMonto.Text)
         .Obs = ToStr(txtObs.Text)
         .ControlLote = ToBoolean(chkControlLote.Checked)
         .ControlSerie = ToBoolean(chkControlSerie.Checked)
         .Comision = ToDecimal(txtComision.Text)
         .Utilidad = ToDecimal(txtUtilidad.Text)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboLinea.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If mboolAdding Then
            DataSave = DataAdd()
         Else
            If ItemTieneComposicion(moItem.ItemId) Then
               DataSave = DataUpdate()
            End If

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moItem.Insert() Then
            'If moItem.TipoItemId = 2 Then 'Item Servicio
            '   If ItemSaldoAdd() Then
            '      txtItemId.Text = ToStr(moItem.ItemId)
            '      DataAdd = True
            '   End If
            'Else
            txtItemId.Text = ToStr(moItem.ItemId)
            DataAdd = True
            'End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moItem.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function ItemSaldoAdd() As Boolean
      Dim oItemSaldo As New clsItemSaldo(clsAppInfo.ConnectString)

      ItemSaldoAdd = False

      Try
         With oItemSaldo
            .EmpresaId = moItem.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .AlmacenId = 0
            .ItemId = moItem.ItemId
            .Saldo = 0
            .PrecioUPC = 0
            .PrecioUPC = 0
            .PrecioFecha = ToDate(Now.Date)

            If .Insert() Then
               ItemSaldoAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemSaldo.Dispose()

      End Try
   End Function

   Private Function NotaDetFind(ByVal lngItemId As Long) As Boolean
      Dim oNotaDet As New clsNotaDet(clsAppInfo.ConnectString)

      Try
         With oNotaDet
            .SelectFilter = clsNotaDet.SelectFilters.ListBox
            .WhereFilter = clsNotaDet.WhereFilters.ItemId
            .EmpresaId = moItem.EmpresaId
            .ItemId = lngItemId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oNotaDet.Dispose()

      End Try
   End Function

   Private Function ItemMovFind(ByVal lngItemId As Long) As Boolean
      Dim oItem As New clsItem(clsAppInfo.ConnectString)

      Try
         With oItem
            .SelectFilter = clsItem.SelectFilters.ListBox
            .WhereFilter = clsItem.WhereFilters.ItemIdTieneMov
            .EmpresaId = moItem.EmpresaId
            .ItemId = lngItemId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   Private Function ItemCodNext() As String
      Dim oItem As New clsItem(clsAppInfo.ConnectString)
      Dim lngNum As Long
      ItemCodNext = ""

      Try
         With oItem
            .SelectFilter = clsItem.SelectFilters.ItemCodNext
            .WhereFilter = clsItem.WhereFilters.EmpresaId
            .EmpresaId = moItem.EmpresaId

            If .Open() Then
               If .Read() Then
                  lngNum = ToLong(.ItemCod)
               End If
            End If

         End With

         If lngNum = 0 Then
            ItemCodNext = ""
         Else
            ItemCodNext = lngNum + 1
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtMedidaCantEqui.FormatString = DecimalMask()
      txtCantidadMin.FormatString = DecimalMask()
      txtCantidadMax.FormatString = DecimalMask()
      txtTipoTasaMonto.FormatString = DecimalMask()

      txtComision.FormatString = DecimalMaskDos()
      txtUtilidad.FormatString = DecimalMaskDos()

      moSustituto = New clsSustituto(clsAppInfo.ConnectString)
      moComposicion = New clsComposicion(clsAppInfo.ConnectString)
      moDatoTecnico = New clsDatoTecnico(clsAppInfo.ConnectString)
      moItemBarra = New clsItemBarra(clsAppInfo.ConnectString)
      moItemPrecio = New clsItemPrecio(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboLineaLoad()
      Call cboMarcaLoad()
      Call cboFabricaLoad()
      Call cboTipoItemLoad()
      Call cboMedidaLoad()
      Call cboTipoCosteoLoad()
      Call cboPlanGrupoLoad()
      Call cboTipoTasaLoad()
      Call cboMonedaLoad()
      Call cboEstadoLoad()
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
            .EmpresaId = moItem.EmpresaId

            If .Open() Then
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

   Private Sub cboGrupoLoad(ByVal lngLineaId As Long)
      Dim oGrupo As New clsGrupo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboGrupo.Items.Clear()
      cboGrupo.Text = ""

      Try
         With oGrupo
            .SelectFilter = clsGrupo.SelectFilters.ListBox
            .WhereFilter = clsGrupo.WhereFilters.LineaId
            .OrderByFilter = clsGrupo.OrderByFilters.GrupoDes
            .EmpresaId = moItem.EmpresaId
            .LineaId = lngLineaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.GrupoId, .GrupoDes)

                  cboGrupo.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGrupo.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboSubGrupoLoad(ByVal lngGrupoId As Long)
      Dim oSubGrupo As New clsSubGrupo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSubGrupo.Items.Clear()
      cboSubGrupo.Text = ""

      Try
         With oSubGrupo
            .SelectFilter = clsSubGrupo.SelectFilters.ListBox
            .WhereFilter = clsSubGrupo.WhereFilters.GrupoId
            .OrderByFilter = clsSubGrupo.OrderByFilters.SubGrupoDes
            .EmpresaId = moItem.EmpresaId
            .GrupoId = lngGrupoId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.SubGrupoId, .SubGrupoDes)

                  cboSubGrupo.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSubGrupo.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboMarcaLoad()
      Dim oMarca As New clsMarca(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMarca.Items.Clear()

      Try
         With oMarca
            .SelectFilter = clsMarca.SelectFilters.ListBox
            .WhereFilter = clsMarca.WhereFilters.EmpresaId
            .OrderByFilter = clsMarca.OrderByFilters.MarcaDes
            .EmpresaId = moItem.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.MarcaId, .MarcaDes)

                  cboMarca.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMarca.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboFabricaLoad()
      Dim oFabrica As New clsFabrica(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboFabrica.Items.Clear()

      Try
         With oFabrica
            .SelectFilter = clsFabrica.SelectFilters.ListBox
            .WhereFilter = clsFabrica.WhereFilters.EmpresaId
            .OrderByFilter = clsFabrica.OrderByFilters.FabricaDes
            .EmpresaId = moItem.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.FabricaId, .FabricaDes)

                  cboFabrica.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFabrica.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoItemLoad()
      Dim oTipoItem As New clsTipoItem(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoItem.Items.Clear()

      Try
         With oTipoItem
            .SelectFilter = clsTipoItem.SelectFilters.ListBox
            .OrderByFilter = clsTipoItem.OrderByFilters.TipoItemDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoItemId, .TipoItemDes)

                  cboTipoItem.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoItem.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboMedidaLoad()
      Dim oMedida As New clsMedida(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMedida.Items.Clear()
      cboMedidaEqui.Items.Clear()

      Try
         With oMedida
            .SelectFilter = clsMedida.SelectFilters.ListBox
            .WhereFilter = clsMedida.WhereFilters.EmpresaId
            .OrderByFilter = clsMedida.OrderByFilters.MedidaDes
            .EmpresaId = moItem.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.MedidaId, .MedidaDes)

                  cboMedida.Items.Add(oItem)
                  cboMedidaEqui.Items.Add(oItem)
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

   Private Sub cboTipoCosteoLoad()
      Dim oTipoCosteo As New clsTipoCosteo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoCosteo.Items.Clear()

      Try
         With oTipoCosteo
            .SelectFilter = clsTipoCosteo.SelectFilters.ListBox
            .OrderByFilter = clsTipoCosteo.OrderByFilters.TipoCosteoDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoCosteoId, .TipoCosteoDes)

                  cboTipoCosteo.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCosteo.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboPlanGrupoLoad()
      Dim oPlanGrupo As New clsPlanGrupo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPlanGrupo.Items.Clear()

      Try
         With oPlanGrupo
            .SelectFilter = clsPlanGrupo.SelectFilters.ListBox
            .WhereFilter = clsPlanGrupo.WhereFilters.EmpresaId
            .OrderByFilter = clsPlanGrupo.OrderByFilters.PlanGrupoDes
            .EmpresaId = moItem.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.PlanGrupoId, .PlanGrupoDes)

                  cboPlanGrupo.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanGrupo.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoTasaLoad()
      Dim oTipoTasa As New clsTipoTasa(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoTasa.Items.Clear()

      Try
         With oTipoTasa
            .SelectFilter = clsTipoTasa.SelectFilters.ListBox
            .OrderByFilter = clsTipoTasa.OrderByFilters.TipoTasaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoTasaId, .TipoTasaDes)

                  cboTipoTasa.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoTasa.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboMonedaLoad()
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMonedaCos.Items.Clear()
      cboMonedaVen.Items.Clear()

      Try
         With oMoneda
            .SelectFilter = clsMoneda.SelectFilters.ListBox
            .OrderByFilter = clsMoneda.OrderByFilters.MonedaDes

            If .Open() Then
               Do While .Read()
                  If .MonedaId > 0 Then
                     oItem = New clsListItem(.MonedaId, .MonedaDes)

                     cboMonedaCos.Items.Add(oItem)
                     cboMonedaVen.Items.Add(oItem)
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

   Private Sub txtEmpresaIdLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               txtEmpresaId.Tag = .EmpresaId
               txtEmpresaId.Text = ToStr(.EmpresaDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Sub

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

   Private Sub cboLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLinea.SelectedIndexChanged
      If cboLinea.Tag <> cboLinea.Text Then
         cboLinea.Tag = cboLinea.Text

         If ListPosition(cboLinea, cboLinea.SelectedIndex) <> 0 Then
            Call cboGrupoLoad(ListPosition(cboLinea, cboLinea.SelectedIndex))
         End If
      End If
   End Sub

   Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged
      If cboGrupo.Tag <> cboGrupo.Text Then
         cboGrupo.Tag = cboGrupo.Text

         If ListPosition(cboGrupo, cboGrupo.SelectedIndex) <> 0 Then
            Call cboSubGrupoLoad(ListPosition(cboGrupo, cboGrupo.SelectedIndex))
         End If
      End If
   End Sub

   Private Sub cboMedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedida.SelectedIndexChanged
      If cboMedida.Tag <> cboMedida.Text Then
         cboMedida.Tag = cboMedida.Text

         lblMedidaEqui.Text = cboMedida.Text + " (s)"
      End If
   End Sub

   Private Sub txtItemDes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemDes.TextChanged
      txtItemDesAbr.Text = Microsoft.VisualBasic.Left(txtItemDes.Text, 40)
   End Sub

   Private Sub cboMedidaEqui_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedidaEqui.SelectedIndexChanged
      If cboMedidaEqui.Tag <> cboMedidaEqui.Text Then
         cboMedidaEqui.Tag = cboMedidaEqui.Text

         If ListPosition(cboMedidaEqui, cboMedidaEqui.SelectedIndex) <> 0 Then
            txtMedidaCantEqui.ReadOnly = False
         Else
            txtMedidaCantEqui.Text = 0
            txtMedidaCantEqui.ReadOnly = True
         End If
      End If
   End Sub

   Private Sub cboTipoTasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoTasa.SelectedIndexChanged
      If cboTipoTasa.Tag <> cboTipoTasa.Text Then
         cboTipoTasa.Tag = cboTipoTasa.Text

         If ListPosition(cboTipoTasa, cboTipoTasa.SelectedIndex) <> 0 Then
            txtTipoTasaMonto.ReadOnly = False
         Else
            txtTipoTasaMonto.Text = 0
            txtTipoTasaMonto.ReadOnly = True
         End If
      End If
   End Sub

   Private Sub cboTipoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoItem.SelectedIndexChanged
      If ListPosition(cboTipoItem, cboTipoItem.SelectedIndex) = 3 Then
         chkControlLote.Enabled = False
         chkControlLote.Checked = False
         chkControlSerie.Enabled = False
         chkControlSerie.Checked = False
         If mboolEditing Then
            tabMain.TabPages.Item("Composicion").Enabled = True
            If ItemMovFind(moItem.ItemId) Then
               cboMedida.ReadOnly = True
               cboMedidaEqui.ReadOnly = True
               txtMedidaCantEqui.ReadOnly = True
               cboMonedaCos.ReadOnly = True
               cboMonedaVen.ReadOnly = True
               cboPlanGrupo.ReadOnly = True
               cboTipoCosteo.ReadOnly = True
            End If

            If grdComposicion.RowCount > 0 Then
               cboTipoItem.ReadOnly = True
            End If
         End If

      Else
         If ListPosition(cboTipoItem, cboTipoItem.SelectedIndex) = clsTipoItem.SERVICIO Then
            chkControlLote.Enabled = False
            chkControlLote.Checked = False
            chkControlSerie.Enabled = False
            chkControlSerie.Checked = False

         Else
            chkControlLote.Enabled = True
            chkControlSerie.Enabled = True
         End If

         tabMain.TabPages.Item("Composicion").Enabled = False
         'chkControlLote.Enabled = True
         'chkControlSerie.Enabled = True
      End If
   End Sub

   Private Sub picImagen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picImagen.DoubleClick
      If mboolAdding Or mboolEditing Then
         Dim strFilename As String
         Dim sfd As New OpenFileDialog

         sfd.Title = "Cargar Imagen a Item"
         sfd.AddExtension = True

         sfd.DefaultExt = "jpg"
         sfd.Filter = "JPG (*.JPG)|*.JPG|JPEG (*.JPEG)|*.JPEG"

         If sfd.ShowDialog() = DialogResult.OK Then
            strFilename = sfd.FileName
            Call lblImagenLoad(strFilename)
         End If
      End If
   End Sub

   Private Sub cboLinea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLinea.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmLineaEdit
               Dim oLinea As New clsLinea(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oLinea.EmpresaId = moItem.EmpresaId

                     .DataObject = oLinea
                     .ShowDialog()

                     If .Changed Then
                        Call cboLineaLoad()
                        cboLinea.SelectedIndex = ListFindItem(cboLinea, frm.ID)
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oLinea.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGrupo.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim lngLineaId As Long = ListPosition(cboLinea, cboLinea.SelectedIndex)

               If lngLineaId > 0 Then
                  Dim frm As New frmGrupoEdit
                  Dim oGrupo As New clsGrupo(clsAppInfo.ConnectString)

                  Try
                     With frm
                        .NewRecord = True
                        .Editing = False

                        oGrupo.EmpresaId = moItem.EmpresaId
                        oGrupo.LineaId = lngLineaId

                        .DataObject = oGrupo
                        .ShowDialog()

                        If .Changed Then
                           Call cboGrupoLoad(lngLineaId)
                           cboGrupo.SelectedIndex = ListFindItem(cboGrupo, frm.ID)
                        End If
                        frm.Dispose()
                     End With

                  Catch exp As Exception
                     MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                  Finally
                     oGrupo.Dispose()

                  End Try
               Else
                  MessageBox.Show("Antes Debe Seleccionar la Linea", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboSubGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSubGrupo.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim lngLineaId As Long = ListPosition(cboLinea, cboLinea.SelectedIndex)
               Dim lngGrupoId As Long = ListPosition(cboGrupo, cboGrupo.SelectedIndex)

               If lngLineaId > 0 Then
                  If lngGrupoId > 0 Then
                     Dim frm As New frmSubGrupoEdit
                     Dim oSubGrupo As New clsSubGrupo(clsAppInfo.ConnectString)

                     Try
                        With frm
                           .NewRecord = True
                           .Editing = False

                           oSubGrupo.EmpresaId = moItem.EmpresaId
                           oSubGrupo.LineaId = lngLineaId
                           oSubGrupo.GrupoId = lngGrupoId

                           .DataObject = oSubGrupo
                           .ShowDialog()

                           If .Changed Then
                              Call cboSubGrupoLoad(lngGrupoId)
                              cboSubGrupo.SelectedIndex = ListFindItem(cboSubGrupo, frm.ID)
                           End If
                           frm.Dispose()
                        End With

                     Catch exp As Exception
                        MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                     Finally
                        oSubGrupo.Dispose()

                     End Try
                  Else
                     MessageBox.Show("Antes Debe Seleccionar el Grupo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Antes Debe Seleccionar la Linea", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         End If
      End If
   End Sub

   Private Sub cboMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMarca.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmMarcaEdit
               Dim oMarca As New clsMarca(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oMarca.EmpresaId = moItem.EmpresaId

                     .DataObject = oMarca
                     .ShowDialog()

                     If .Changed Then
                        Call cboMarcaLoad()
                        cboMarca.SelectedIndex = ListFindItem(cboMarca, frm.ID)
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oMarca.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboFabrica_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFabrica.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmFabricaEdit
               Dim oFabrica As New clsFabrica(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oFabrica.EmpresaId = moItem.EmpresaId

                     .DataObject = oFabrica
                     .ShowDialog()

                     If .Changed Then
                        Call cboFabricaLoad()
                        cboFabrica.SelectedIndex = ListFindItem(cboFabrica, frm.ID)
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oFabrica.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboMedida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMedida.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmMedidaEdit
               Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oMedida.EmpresaId = moItem.EmpresaId

                     .DataObject = oMedida
                     .ShowDialog()

                     If .Changed Then
                        Dim lngMedidaIdEqui As Long = ListPosition(cboMedidaEqui, cboMedidaEqui.SelectedIndex)

                        Call cboMedidaLoad()
                        cboMedida.SelectedIndex = ListFindItem(cboMedida, frm.ID)
                        cboMedidaEqui.SelectedIndex = ListFindItem(cboMedidaEqui, lngMedidaIdEqui)
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oMedida.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboMedidaEqui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMedidaEqui.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmMedidaEdit
               Dim oMedida As New clsMedida(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oMedida.EmpresaId = moItem.EmpresaId

                     .DataObject = oMedida
                     .ShowDialog()

                     If .Changed Then
                        Dim lngMedidaId As Long = ListPosition(cboMedida, cboMedida.SelectedIndex)

                        Call cboMedidaLoad()
                        cboMedidaEqui.SelectedIndex = ListFindItem(cboMedidaEqui, frm.ID)
                        cboMedida.SelectedIndex = ListFindItem(cboMedida, lngMedidaId)
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oMedida.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub cboPlanGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPlanGrupo.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmPlanGrupoEdit
               Dim oPlanGrupo As New clsPlanGrupo(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oPlanGrupo.EmpresaId = moItem.EmpresaId

                     .DataObject = oPlanGrupo
                     .ShowDialog()

                     If .Changed Then
                        Call cboPlanGrupoLoad()
                        cboPlanGrupo.SelectedIndex = ListFindItem(cboPlanGrupo, frm.ID)
                     End If
                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oPlanGrupo.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

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

   Private Sub SustitutoDataShow()
      Dim oSustituto As New clsSustituto(clsAppInfo.ConnectString)

      Try
         If grdSustituto.RowCount > 0 Then
            With oSustituto
               .SustitutoId = ToLong(grdSustituto.GetValue("SustitutoId"))

               If .FindByPK Then
                  Dim frm As New frmSustitutoEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oSustituto

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSustituto = Nothing

      End Try
   End Sub

   Private Sub SustitutoFormNew()
      Dim frm As New frmSustitutoEdit
      Dim oSustituto As New clsSustituto(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oSustituto.EmpresaId = moItem.EmpresaId
            oSustituto.ItemId = moItem.ItemId

            .DataObject = oSustituto
            .ShowDialog()

            If .Changed Then
               Call grdSustitutoLoad()
               Call grdSustitutoFindRow(frm.ID)

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub SustitutoDataEdit()
      Dim oSustituto As New clsSustituto(clsAppInfo.ConnectString)

      Try
         If grdSustituto.RowCount > 0 Then
            With oSustituto
               .SustitutoId = ToLong(grdSustituto.GetValue("SustitutoId"))

               If .FindByPK Then
                  Dim frm As New frmSustitutoEdit

                  frm.NewRecord = False
                  frm.Editing = True
                  frm.DataObject = oSustituto
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdSustitutoLoad()
                     Call grdSustitutoFindRow(frm.ID)

                  End If
                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSustituto = Nothing

      End Try
   End Sub

   Private Sub SustitutoDataDelete()
      Dim oSustituto As New clsSustituto(clsAppInfo.ConnectString)

      Try
         If grdSustituto.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oSustituto
                  .WhereFilter = clsSustituto.WhereFilters.PrimaryKey
                  .SustitutoId = ToLong(grdSustituto.GetValue("SustitutoId"))

                  If .Delete Then
                     Call grdSustitutoLoad()
                  End If
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSustituto = Nothing

      End Try
   End Sub

   Private Sub grdSustitutoFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdSustituto.RootTable.Columns("SustitutoId")

      grdSustituto.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdSustitutoInit()
      With grdSustituto
         ebrSustituto.Groups(0).Text = "Sustituciones"
         .ContextMenu = mnuSustituto

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

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdSustituto.RowCount > 0 Then
               mnuShow.Enabled = True
               mnuNew.Enabled = True
               mnuEdit.Enabled = True
               mnuDelete.Enabled = True
            Else
               mnuShow.Enabled = False
               mnuNew.Enabled = True
               mnuEdit.Enabled = False
               mnuDelete.Enabled = False
            End If

         Else
            mnuShow.Enabled = True
            mnuNew.Enabled = False
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdSustituto_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdSustituto.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdSustituto.RowCount > 0 Then
               mnuShow.Enabled = True
               mnuNew.Enabled = True
               mnuEdit.Enabled = True
               mnuDelete.Enabled = True
            Else
               mnuShow.Enabled = False
               mnuNew.Enabled = True
               mnuEdit.Enabled = False
               mnuDelete.Enabled = False
            End If

         Else
            mnuShow.Enabled = True
            mnuNew.Enabled = False
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call SustitutoDataShow()
   End Sub

   Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
      Call SustitutoFormNew()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call SustitutoDataEdit()
   End Sub

   Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
      Call SustitutoDataDelete()
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
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub ComposicionDataShow()
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try
         If grdComposicion.RowCount > 0 Then
            If ToLong(grdComposicion.GetValue("ComposicionId")) > 0 Then
               With oComposicion
                  .ComposicionId = ToLong(grdComposicion.GetValue("ComposicionId"))

                  If .FindByPK Then
                     Dim frm As New frmComposicionEdit

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oComposicion

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComposicion = Nothing

      End Try
   End Sub

   Private Sub ComposicionFormNew()
      Dim frm As New frmComposicionEdit
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oComposicion.EmpresaId = moItem.EmpresaId
            oComposicion.ItemId = moItem.ItemId

            .DataObject = oComposicion
            .ShowDialog()

            If .Changed Then
               Call grdComposicionLoad()
               Call grdComposicionFindRow(frm.ID)

               If grdComposicion.RowCount > 0 Then
                  cboTipoItem.ReadOnly = True
               End If

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub ComposicionDataEdit()
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try
         If grdComposicion.RowCount > 0 Then
            If ToLong(grdComposicion.GetValue("ComposicionId")) > 0 Then
               With oComposicion
                  .ComposicionId = ToLong(grdComposicion.GetValue("ComposicionId"))

                  If .FindByPK Then
                     Dim frm As New frmComposicionEdit

                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oComposicion
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdComposicionLoad()
                        Call grdComposicionFindRow(frm.ID)

                     End If

                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComposicion = Nothing

      End Try
   End Sub

   Private Sub ComposicionDataDelete()
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try
         If grdComposicion.RowCount > 0 Then
            If ToLong(grdComposicion.GetValue("ComposicionId")) > 0 Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  With oComposicion
                     .WhereFilter = clsComposicion.WhereFilters.PrimaryKey
                     .ComposicionId = ToLong(grdComposicion.GetValue("ComposicionId"))

                     If .Delete Then
                        Call grdComposicionLoad()
                     End If
                     If grdComposicion.RowCount = 0 Then
                        cboTipoItem.ReadOnly = False
                     End If
                  End With
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
         oComposicion = Nothing

      End Try
   End Sub

   Private Sub grdComposicionFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdComposicion.RootTable.Columns("ComposicionId")

      grdComposicion.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Function ItemTieneComposicion(ByVal lngItemId As Long) As Boolean
      ItemTieneComposicion = True

      If moItem.TipoItemId = 3 Then
         If ItemComposicionFind(lngItemId) Then
            Return True
         Else
            MessageBox.Show("El Item es de Tipo Paquete, por lo que debe cargar su composición", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
         End If
      End If

   End Function

   Private Function ItemComposicionFind(ByVal lngItemId As Long) As Boolean
      Dim oComposicion As New clsComposicion(clsAppInfo.ConnectString)

      Try
         With oComposicion
            .SelectFilter = clsComposicion.SelectFilters.All
            .WhereFilter = clsComposicion.WhereFilters.ItemId
            .EmpresaId = moItem.EmpresaId
            .ItemId = lngItemId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComposicion.Dispose()

      End Try
   End Function

   Private Sub grdComposicionInit()
      With grdComposicion
         ebrComposicion.Groups(0).Text = "Composición del Paquete"
         .ContextMenu = mnuComposicion

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

         .RootTable.Columns("PrecioCos").Visible = False
         .RootTable.Columns("PrecioCos").Caption = "Costo"
         .RootTable.Columns("PrecioCos").FormatString = DecimalMask()
         .RootTable.Columns("PrecioCos").Width = 70
         .RootTable.Columns("PrecioCos").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioCos").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdComposicion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdComposicion.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdComposicion.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdComposicion.GetRow.Cells(grdComposicion.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If ItemMovFind(moItem.ItemId) Then
               mnuShowCom.Enabled = True
               mnuNewCom.Enabled = False
               mnuEditCom.Enabled = False
               mnuDeleteCom.Enabled = False
            Else
               If grdComposicion.RowCount > 0 Then
                  mnuShowCom.Enabled = True
                  mnuNewCom.Enabled = True
                  mnuEditCom.Enabled = True
                  mnuDeleteCom.Enabled = True
               Else
                  mnuShowCom.Enabled = False
                  mnuNewCom.Enabled = True
                  mnuEditCom.Enabled = False
                  mnuDeleteCom.Enabled = False
               End If
            End If
         Else
            mnuShowCom.Enabled = True
            mnuNewCom.Enabled = False
            mnuEditCom.Enabled = False
            mnuDeleteCom.Enabled = False
         End If
      End If

   End Sub

   Private Sub grdComposicion_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdComposicion.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If ItemMovFind(moItem.ItemId) Then
               mnuShowCom.Enabled = True
               mnuNewCom.Enabled = False
               mnuEditCom.Enabled = False
               mnuDeleteCom.Enabled = False
            Else
               If grdComposicion.RowCount > 0 Then
                  mnuShowCom.Enabled = True
                  mnuNewCom.Enabled = True
                  mnuEditCom.Enabled = True
                  mnuDeleteCom.Enabled = True
               Else
                  mnuShowCom.Enabled = False
                  mnuNewCom.Enabled = True
                  mnuEditCom.Enabled = False
                  mnuDeleteCom.Enabled = False
               End If
            End If
         Else
            mnuShowCom.Enabled = True
            mnuNewCom.Enabled = False
            mnuEditCom.Enabled = False
            mnuDeleteCom.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuShowCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowCom.Click
      Call ComposicionDataShow()
   End Sub

   Private Sub mnuNewCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewCom.Click
      Call ComposicionFormNew()
   End Sub

   Private Sub mnuEditCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditCom.Click
      Call ComposicionDataEdit()
   End Sub

   Private Sub mnuDeleteCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteCom.Click
      Call ComposicionDataDelete()
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

   Private Sub DatoTecnicoDataShow()
      Dim oDatoTecnico As New clsDatoTecnico(clsAppInfo.ConnectString)

      Try
         If grdDatoTecnico.RowCount > 0 Then
            If ToLong(grdDatoTecnico.GetValue("DatoTecnicoId")) > 0 Then
               With oDatoTecnico
                  .DatoTecnicoId = ToLong(grdDatoTecnico.GetValue("DatoTecnicoId"))

                  If .FindByPK Then
                     Dim frm As New frmDatoTecnicoEdit

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oDatoTecnico

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDatoTecnico = Nothing

      End Try
   End Sub

   Private Sub DatoTecnicoFormNew()
      Dim frm As New frmDatoTecnicoEdit
      Dim oDatoTecnico As New clsDatoTecnico(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oDatoTecnico.EmpresaId = moItem.EmpresaId
            oDatoTecnico.LineaId = moItem.LineaId
            oDatoTecnico.ItemId = moItem.ItemId

            .DataObject = oDatoTecnico
            .ShowDialog()

            If .Changed Then
               Call grdDatoTecnicoLoad()
               Call grdDatoTecnicoFindRow(frm.ID)

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub DatoTecnicoDataEdit()
      Dim oDatoTecnico As New clsDatoTecnico(clsAppInfo.ConnectString)

      Try
         If grdDatoTecnico.RowCount > 0 Then
            If ToLong(grdDatoTecnico.GetValue("DatoTecnicoId")) > 0 Then
               With oDatoTecnico
                  .DatoTecnicoId = ToLong(grdDatoTecnico.GetValue("DatoTecnicoId"))

                  If .FindByPK Then
                     Dim frm As New frmDatoTecnicoEdit

                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oDatoTecnico
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdDatoTecnicoLoad()
                        Call grdDatoTecnicoFindRow(frm.ID)
                     End If
                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDatoTecnico = Nothing

      End Try
   End Sub

   Private Sub DatoTecnicoDataDelete()
      Dim oDatoTecnico As New clsDatoTecnico(clsAppInfo.ConnectString)

      Try
         If grdDatoTecnico.RowCount > 0 Then
            If ToLong(grdDatoTecnico.GetValue("DatoTecnicoId")) > 0 Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  With oDatoTecnico
                     .WhereFilter = clsDatoTecnico.WhereFilters.PrimaryKey
                     .DatoTecnicoId = ToLong(grdDatoTecnico.GetValue("DatoTecnicoId"))

                     If .Delete Then
                        Call grdDatoTecnicoLoad()
                     End If
                  End With
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
         oDatoTecnico = Nothing

      End Try
   End Sub

   Private Sub grdDatoTecnicoFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdDatoTecnico.RootTable.Columns("DatoTecnicoId")

      grdDatoTecnico.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdDatoTecnicoInit()
      With grdDatoTecnico
         ebrDatoTecnico.Groups(0).Text = "Datos Técnicos"
         .ContextMenu = mnuDatoTecnico

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
         .RootTable.Columns("DatoTecnicoDes").Width = 220
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

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdDatoTecnico.RowCount > 0 Then
               mnuShowDato.Enabled = True
               mnuNewDato.Enabled = True
               mnuEditDato.Enabled = True
               mnuDeletedato.Enabled = True
            Else
               mnuShowDato.Enabled = False
               mnuNewDato.Enabled = True
               mnuEditDato.Enabled = False
               mnuDeletedato.Enabled = False
            End If

         Else
            mnuShowDato.Enabled = True
            mnuNewDato.Enabled = False
            mnuEditDato.Enabled = False
            mnuDeletedato.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdDatoTecnico_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdDatoTecnico.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdDatoTecnico.RowCount > 0 Then
               mnuShowDato.Enabled = True
               mnuNewDato.Enabled = True
               mnuEditDato.Enabled = True
               mnuDeletedato.Enabled = True
            Else
               mnuShowDato.Enabled = False
               mnuNewDato.Enabled = True
               mnuEditDato.Enabled = False
               mnuDeletedato.Enabled = False
            End If

         Else
            mnuShowDato.Enabled = True
            mnuNewDato.Enabled = False
            mnuEditDato.Enabled = False
            mnuDeletedato.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuShowDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowDato.Click
      Call DatoTecnicoDataShow()
   End Sub

   Private Sub mnuNewDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewDato.Click
      Call DatoTecnicoFormNew()
   End Sub

   Private Sub mnuEditDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditDato.Click
      Call DatoTecnicoDataEdit()
   End Sub

   Private Sub mnuDeleteDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeletedato.Click
      Call DatoTecnicoDataDelete()
   End Sub

#End Region

#Region " ItemBarra "

   Private Sub grdItemBarraLoad()
      Try
         With moItemBarra
            .SelectFilter = clsItemBarra.SelectFilters.Grid
            .WhereFilter = clsItemBarra.WhereFilters.Grid
            .OrderByFilter = clsItemBarra.OrderByFilters.Grid
            .EmpresaId = moItem.EmpresaId
            .ItemId = moItem.ItemId

            If .Open() Then
               grdItemBarra.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdItemBarra.RetrieveStructure()
               Call grdItemBarraInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub ItemBarraDataShow()
      Dim oItemBarra As New clsItemBarra(clsAppInfo.ConnectString)

      Try
         If grdItemBarra.RowCount > 0 Then
            If ToLong(grdItemBarra.GetValue("ItemBarraId")) > 0 Then
               With oItemBarra
                  .ItemBarraId = ToLong(grdItemBarra.GetValue("ItemBarraId"))

                  If .FindByPK Then
                     Dim frm As New frmItemBarraEdit

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oItemBarra

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemBarra = Nothing

      End Try
   End Sub

   Private Sub ItemBarraFormNew()
      Dim frm As New frmItemBarraEdit
      Dim oItemBarra As New clsItemBarra(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oItemBarra.EmpresaId = moItem.EmpresaId
            oItemBarra.ItemId = moItem.ItemId

            .DataObject = oItemBarra
            .ShowDialog()

            If .Changed Then
               Call grdItemBarraLoad()
               Call grdItemBarraFindRow(frm.ID)

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub ItemBarraDataEdit()
      Dim oItemBarra As New clsItemBarra(clsAppInfo.ConnectString)

      Try
         If grdItemBarra.RowCount > 0 Then
            If ToLong(grdItemBarra.GetValue("ItemBarraId")) > 0 Then
               With oItemBarra
                  .ItemBarraId = ToLong(grdItemBarra.GetValue("ItemBarraId"))

                  If .FindByPK Then
                     Dim frm As New frmItemBarraEdit

                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oItemBarra
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdItemBarraLoad()
                        Call grdItemBarraFindRow(frm.ID)

                     End If
                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemBarra = Nothing

      End Try
   End Sub

   Private Sub ItemBarraDataDelete()
      Dim oItemBarra As New clsItemBarra(clsAppInfo.ConnectString)

      Try
         If grdItemBarra.RowCount > 0 Then
            If ToLong(grdItemBarra.GetValue("ItemBarraId")) > 0 Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  With oItemBarra
                     .WhereFilter = clsItemBarra.WhereFilters.PrimaryKey
                     .ItemBarraId = ToLong(grdItemBarra.GetValue("ItemBarraId"))

                     If .Delete Then
                        Call grdItemBarraLoad()
                     End If
                  End With
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
         oItemBarra = Nothing

      End Try
   End Sub

   Private Sub grdItemBarraFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdItemBarra.RootTable.Columns("ItemBarraId")

      grdItemBarra.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptItemBarra

      rpt.DataSource = moItemBarra.DataSet.Tables(moItemBarra.TableName).DefaultView

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document)
      frm.Show()
   End Sub

   Private Sub grdItemBarraInit()
      With grdItemBarra
         ebrItemBarra.Groups(0).Text = "Códigos de Barra"
         .ContextMenu = mnuItemBarra

         .RootTable.Columns("ItemBarraId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Visible = False

         .RootTable.Columns("ItemDes").Visible = False

         .RootTable.Columns("ItemDesAbr").Visible = False

         .RootTable.Columns("ItemBarraCod").Caption = "Código de Barra"
         .RootTable.Columns("ItemBarraCod").Width = 200
         .RootTable.Columns("ItemBarraCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemBarraCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdItemBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdItemBarra.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdItemBarra.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdItemBarra.GetRow.Cells(grdItemBarra.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdItemBarra.RowCount > 0 Then
               mnuShowBar.Enabled = True
               mnuNewBar.Enabled = True
               mnuEditBar.Enabled = True
               mnuDeleteBar.Enabled = True
            Else
               mnuShowBar.Enabled = False
               mnuNewBar.Enabled = True
               mnuEditBar.Enabled = False
               mnuDeleteBar.Enabled = False
            End If

         Else
            mnuShowBar.Enabled = True
            mnuNewBar.Enabled = False
            mnuEditBar.Enabled = False
            mnuDeleteBar.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdItemBarra_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdItemBarra.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdItemBarra.RowCount > 0 Then
               mnuShowBar.Enabled = True
               mnuNewBar.Enabled = True
               mnuEditBar.Enabled = True
               mnuDeleteBar.Enabled = True
            Else
               mnuShowBar.Enabled = False
               mnuNewBar.Enabled = True
               mnuEditBar.Enabled = False
               mnuDeleteBar.Enabled = False
            End If

         Else
            mnuShowBar.Enabled = True
            mnuNewBar.Enabled = False
            mnuEditBar.Enabled = False
            mnuDeleteBar.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuShowBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowBar.Click
      Call ItemBarraDataShow()
   End Sub

   Private Sub mnuNewBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewBar.Click
      Call ItemBarraFormNew()
   End Sub

   Private Sub mnuEditBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditBar.Click
      Call ItemBarraDataEdit()
   End Sub

   Private Sub mnuDeleteBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteBar.Click
      Call ItemBarraDataDelete()
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

   Private Sub ItemPrecioDataShow()
      Dim oItemPrecio As New clsItemPrecio(clsAppInfo.ConnectString)

      Try
         If grdItemPrecio.RowCount > 0 Then
            If ToLong(grdItemPrecio.GetValue("ItemPrecioId")) > 0 Then
               With oItemPrecio
                  .ItemPrecioId = ToLong(grdItemPrecio.GetValue("ItemPrecioId"))

                  If .FindByPK Then
                     Dim frm As New frmItemPrecioEdit

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.TipoCosteoId = moItem.TipoCosteoId
                     frm.MonedaIdCos = moItem.MonedaIdCos
                     frm.MonedaIdVen = moItem.MonedaIdVen
                     frm.MedidaId = moItem.MedidaId
                     frm.MedidaIdEqui = moItem.MedidaIdEqui
                     frm.MedidaCantEqui = moItem.MedidaCantEqui
                     frm.TipoItemId = moItem.TipoItemId
                     frm.DataObject = oItemPrecio

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPrecio = Nothing

      End Try
   End Sub

   Private Sub ItemPrecioFormNew()
      Dim frm As New frmItemPrecioEdit
      Dim oPrecio As New clsItemPrecio(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oPrecio.EmpresaId = moItem.EmpresaId
            oPrecio.ItemId = moItem.ItemId
            oPrecio.AlmacenId = ToLong(grdItemPrecio.GetValue("AlmacenId"))
            oPrecio.MonedaId = moItem.MonedaIdVen

            .TipoCosteoId = moItem.TipoCosteoId
            .MonedaIdCos = moItem.MonedaIdCos
            .MonedaIdVen = moItem.MonedaIdVen
            .MedidaId = moItem.MedidaId
            .MedidaIdEqui = moItem.MedidaIdEqui
            .MedidaCantEqui = moItem.MedidaCantEqui
            frm.TipoItemId = moItem.TipoItemId
            .DataObject = oPrecio
            .ShowDialog()

            If .Changed Then
               Call grdItemPrecioLoad()
               Call grdItemPrecioFindRow(frm.ID)

            End If
            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub ItemPrecioDataEdit()
      Dim oItemPrecio As New clsItemPrecio(clsAppInfo.ConnectString)

      Try
         If grdItemPrecio.RowCount > 0 Then
            If ToLong(grdItemPrecio.GetValue("ItemPrecioId")) > 0 Then
               With oItemPrecio
                  .ItemPrecioId = ToLong(grdItemPrecio.GetValue("ItemPrecioId"))

                  If .FindByPK Then
                     Dim frm As New frmItemPrecioEdit

                     frm.NewRecord = False
                     frm.Editing = True

                     frm.TipoCosteoId = moItem.TipoCosteoId
                     frm.MonedaIdCos = moItem.MonedaIdCos
                     frm.MonedaIdVen = moItem.MonedaIdVen
                     frm.MedidaId = moItem.MedidaId
                     frm.MedidaIdEqui = moItem.MedidaIdEqui
                     frm.MedidaCantEqui = moItem.MedidaCantEqui
                     frm.TipoItemId = moItem.TipoItemId
                     frm.DataObject = oItemPrecio
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdItemPrecioLoad()
                        Call grdItemPrecioFindRow(frm.ID)

                     End If
                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPrecio = Nothing

      End Try
   End Sub

   Private Sub ItemPrecioDataDelete()
      Dim oItemPrecio As New clsItemPrecio(clsAppInfo.ConnectString)
      Dim strMensaje As String = "¿Realmente quiere eliminar el registro?"

      Try
         If grdItemPrecio.RowCount > 0 Then
            If ToLong(grdItemPrecio.GetValue("ItemPrecioId")) > 0 Then
               If ItemPrecioMovFind(ToLong(grdItemPrecio.GetValue("ItemPrecioId"))) Then
                  strMensaje = "El registro de Precio tiene Movimiento," & vbCrLf & " ¿Realmente quiere eliminar el registro?"
               End If

               If MessageBox.Show(strMensaje, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  With oItemPrecio
                     .WhereFilter = clsItemPrecio.WhereFilters.PrimaryKey
                     .ItemPrecioId = ToLong(grdItemPrecio.GetValue("ItemPrecioId"))

                     If .Delete Then
                        Call grdItemPrecioLoad()
                     End If
                  End With
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
         oItemPrecio = Nothing

      End Try
   End Sub

   Private Function ItemPrecioMovFind(ByVal lngItemPrecioId As Long) As Boolean
      Dim oItemPrecio As New clsItemPrecio(clsAppInfo.ConnectString)
      ItemPrecioMovFind = False

      Try
         With oItemPrecio
            .SelectFilter = clsItemPrecio.SelectFilters.All
            .WhereFilter = clsItemPrecio.WhereFilters.ItemPrecioIdTieneMov
            .EmpresaId = moItem.EmpresaId
            .EncPrecioId = 0
            .ItemPrecioId = lngItemPrecioId

            If .Open Then
               If .DataSet.Tables(.TableName).Rows.Count > 0 Then
                  Return True
               Else
                  Return False
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItemPrecio.Dispose()

      End Try
   End Function

   Private Sub grdItemPrecioFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdItemPrecio.RootTable.Columns("ItemPrecioId")

      grdItemPrecio.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdItemPrecioInit()
      With grdItemPrecio
         ebrItemPrecio.Groups(0).Text = "Precios de Venta"
         .ContextMenu = mnuPrecio

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

   Private Sub grdItemPrecio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdItemPrecio.DoubleClick
      Call ItemPrecioDataShow()
   End Sub

   Private Sub grdItemPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdItemPrecio.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdItemPrecio.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdItemPrecio.GetRow.Cells(grdItemPrecio.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdItemPrecio.RowCount > 0 Then
               mnuShowPre.Enabled = True
               mnuNewPre.Enabled = True
               mnuEditPre.Enabled = True
               mnuDeletePre.Enabled = True
            Else
               mnuShowPre.Enabled = False
               mnuNewPre.Enabled = True
               mnuEditPre.Enabled = False
               mnuDeletePre.Enabled = False
            End If

         Else
            mnuShowPre.Enabled = True
            mnuNewPre.Enabled = False
            mnuEditPre.Enabled = False
            mnuDeletePre.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdItemPrecio_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdItemPrecio.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdItemPrecio.RowCount > 0 Then
               mnuShowPre.Enabled = True
               mnuNewPre.Enabled = True
               mnuEditPre.Enabled = True
               mnuDeletePre.Enabled = True
            Else
               mnuShowPre.Enabled = False
               mnuNewPre.Enabled = True
               mnuEditPre.Enabled = False
               mnuDeletePre.Enabled = False
            End If

         Else
            mnuShowPre.Enabled = True
            mnuNewPre.Enabled = False
            mnuEditPre.Enabled = False
            mnuDeletePre.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuShowPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowPre.Click
      Call ItemPrecioDataShow()
   End Sub

   Private Sub mnuNewPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewPre.Click
      Call ItemPrecioFormNew()
   End Sub

   Private Sub mnuEditPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditPre.Click
      Call ItemPrecioDataEdit()
   End Sub

   Private Sub mnuDeletePre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeletePre.Click
      Call ItemPrecioDataDelete()
   End Sub

#End Region

   Private Sub tabMainPanel(ByVal strKey As String, ByVal strAction As String)
      Select Case strKey
         Case "DatoTecnico"
            Select Case strAction
               Case "Show"
                  Call DatoTecnicoDataShow()

               Case "New"
                  Call DatoTecnicoFormNew()

               Case "Edit"
                  Call DatoTecnicoDataEdit()

               Case "Delete"
                  Call DatoTecnicoDataDelete()
            End Select

         Case "Sustitucion"
            Select Case strAction
               Case "Show"
                  Call SustitutoDataShow()

               Case "New"
                  Call SustitutoFormNew()

               Case "Edit"
                  Call SustitutoDataEdit()

               Case "Delete"
                  Call SustitutoDataDelete()
            End Select

         Case "Composicion"
            Select Case strAction
               Case "Show"
                  Call ComposicionDataShow()

               Case "New"
                  Call ComposicionFormNew()

               Case "Edit"
                  Call ComposicionDataEdit()

               Case "Delete"
                  Call ComposicionDataDelete()
            End Select

         Case "ItemBarra"
            Select Case strAction
               Case "Show"
                  Call ItemBarraDataShow()

               Case "New"
                  Call ItemBarraFormNew()

               Case "Edit"
                  Call ItemBarraDataEdit()

               Case "Delete"
                  Call ItemBarraDataDelete()
            End Select

         Case "Precio"
            Select Case strAction
               Case "Show"
                  Call ItemPrecioDataShow()

               Case "New"
                  Call ItemPrecioFormNew()

               Case "Edit"
                  Call ItemPrecioDataEdit()

               Case "Delete"
                  Call ItemPrecioDataDelete()
            End Select

      End Select
   End Sub

   Private Sub frmItemEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If Save.Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moItem.ItemId
                  mboolChanged = True

                  If mboolAdding = True Then
                     mboolAdding = False
                     mboolEditing = True

                     Call grdSustitutoLoad()
                     Call grdComposicionLoad()
                     Call grdDatoTecnicoLoad()
                     Call grdItemPrecioLoad()

                     tabMain.TabPages.Item("DatoTecnico").Enabled = True
                     tabMain.TabPages.Item("Sustitucion").Enabled = True
                     tabMain.TabPages.Item("ItemBarra").Enabled = True
                     tabMain.TabPages.Item("Precio").Enabled = True

                     If moItem.TipoItemId = 3 Then
                        ''cboTipoItem.ReadOnly = True
                        chkControlLote.Enabled = False
                        chkControlSerie.Enabled = False
                        tabMain.TabPages.Item("Composicion").Enabled = True
                     Else
                        tabMain.TabPages.Item("Composicion").Enabled = False
                     End If
                  Else
                     Me.Close()
                  End If
               End If
            End If

         ElseIf (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If mboolAdding Or mboolEditing Then
               Call tabMainPanel(tabMain.SelectedTab.Key(), "New")
            End If

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            If mboolAdding Or mboolEditing Then
               Call tabMainPanel(tabMain.SelectedTab.Key(), "Edit")
            End If

         ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            If mboolAdding Or mboolEditing Then
               Call tabMainPanel(tabMain.SelectedTab.Key(), "Delete")
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmItemEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moItem.Dispose()
      moSustituto.Dispose()
      moComposicion.Dispose()
      moDatoTecnico.Dispose()
      moItemBarra.Dispose()
      moItemPrecio.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub frmItemEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

      If mboolEditing Then
         If Not ItemTieneComposicion(moItem.ItemId) Then
            e.Cancel = True
            tabMain.TabPages.Item("Composicion").Selected = True
         End If
      End If
   End Sub

End Class
