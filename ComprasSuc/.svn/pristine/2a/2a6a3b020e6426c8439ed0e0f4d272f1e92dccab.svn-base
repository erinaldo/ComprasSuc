Public Class frmCompraNext
   Inherits System.Windows.Forms.Form

   Private moCompra As clsCompra
   Private mdsCompraDet As DataSet
   Private mdatFecha As Date
   Private mboolConFac As Boolean
   ''Private mboolFacturaDif As Boolean
   Private moCompraRecargo As clsCompraRecargo
   Private moCompraDescuento As clsCompraDescuento
   Private moAnticipo As clsAnticipo
   Private moFactura As clsFactura
   Private mlngCompIdOtrosCosto As Long
   Private moPoliza As clsPoliza
   Private moCompraOtroCosto As clsCompraOtroCosto
   Private moCompraFac As clsCompraFac
   Private mlngRowCosto As Long
   Private mboolErrorFacturaOtroCosto As Boolean
   Private mlstPedCompra As New Queue

   Private moFacturaOrg As clsFactura
   Private moPolizaOrg As clsPoliza

   Private mlngTipoRetencionId As Long

   Private mstrSepDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private moDataTableCompOtroCosto As DataTable
   Private modtDeleteCompraOtroCosto As DataTable
   Private modtFacturaOtroCosto As DataTable
   Private modtDeleteFacturaOtroCosto As DataTable

   Private moDataSetAnticipo As DataSet
   Private moDataTableAnticipo As DataTable

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean

   Private mofrmCompraEdit As frmCompraEdit

   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdProrrateo As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrRecargos As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl2 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdCompraRecargo As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrDescuentos As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl3 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdCompraDescuento As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrOtrosCostos As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl5 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdCompraOtroCosto As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrFactura As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl6 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdFactura As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrPoliza As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl7 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdPoliza As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrAnticipos As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdAnticipo As Janus.Windows.GridEX.GridEX
   Friend WithEvents txtMontoOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents txtMontoDes As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoRec As Janus.Windows.GridEX.EditControls.NumericEditBox
   Private mlngID As Long
   Friend WithEvents grpRetenciones As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents cboTipoRetencion As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtMontoRetencion As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents grpFactDiferida As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtFactDifExento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents chkFacturaDif As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents txtExentoIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblExentoIVA As System.Windows.Forms.Label
   Private CostoIdNro As Long 'Para hacer q se pueda editar

   Property Fecha() As Date
      Get
         Return mdatFecha
      End Get

      Set(ByVal Value As Date)
         mdatFecha = Value
      End Set
   End Property

   Property ConFac() As Boolean
      Get
         Return mboolConFac
      End Get

      Set(ByVal Value As Boolean)
         mboolConFac = Value
      End Set
   End Property

   Property lstPedCompra() As Queue
      Get
         Return mlstPedCompra
      End Get

      Set(ByVal Value As Queue)
         mlstPedCompra = Value
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

   WriteOnly Property DataObject() As clsCompra
      Set(ByVal Value As clsCompra)
         moCompra = Value
      End Set
   End Property

   WriteOnly Property CompraDet() As DataSet
      Set(ByVal Value As DataSet)
         mdsCompraDet = Value
      End Set
   End Property

   Property CompraEdit() As frmCompraEdit
      Get
         Return mofrmCompraEdit
      End Get

      Set(ByVal Value As frmCompraEdit)
         mofrmCompraEdit = Value
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
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents tabCompraRecargo As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabCompraDescuento As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents mnuRecargo As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowRecargo As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewRecargo As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditRecargo As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeleteRecargo As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDescuento As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowDescuento As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewDescuento As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditDescuento As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeleteDescuento As System.Windows.Forms.MenuItem
   Friend WithEvents tabAnticipo As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents mnuAnticipo As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowAnticipo As System.Windows.Forms.MenuItem
   Friend WithEvents tabFactura As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents mnuFactura As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowFactura As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewFactura As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditFactura As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeleteFactura As System.Windows.Forms.MenuItem
   Friend WithEvents tabPoliza As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents mnuPoliza As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowPoliza As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewPoliza As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditPoliza As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeletePoliza As System.Windows.Forms.MenuItem
   Friend WithEvents tabOtroCosto As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents mnuOtroCosto As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeleteOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents tabGeneral As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtMontoLiq As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoAnt As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoNet As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents mnuShowFacturaOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewFacturaOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditFacturaOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeleteFacturaOtroCosto As System.Windows.Forms.MenuItem
   Friend WithEvents txtMontoOtroConIva As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoOtroSinIva As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtFacturaIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtPolizaIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents mnuProrrateo As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowProrrateo As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditProrrateo As System.Windows.Forms.MenuItem
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents txtMontoCos As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents txtMontoFac As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup4 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup5 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup6 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup7 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraNext))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdProrrateo = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl1 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdAnticipo = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl2 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdCompraRecargo = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl3 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdCompraDescuento = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl5 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdCompraOtroCosto = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl6 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdFactura = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl7 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdPoliza = New Janus.Windows.GridEX.GridEX
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
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtExentoIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblExentoIVA = New System.Windows.Forms.Label
      Me.txtMontoRetencion = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.txtMontoDes = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtMontoRec = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtMontoOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtMontoFac = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.txtMontoCos = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.txtPolizaIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.txtFacturaIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtMontoOtroSinIva = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtMontoNet = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtMontoLiq = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtMontoOtroConIva = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtMontoAnt = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.tabAnticipo = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrAnticipos = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabCompraRecargo = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrRecargos = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabCompraDescuento = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrDescuentos = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabOtroCosto = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrOtrosCostos = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabFactura = New Janus.Windows.UI.Tab.UITabPage
      Me.grpRetenciones = New Janus.Windows.EditControls.UIGroupBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.cboTipoRetencion = New Janus.Windows.EditControls.UIComboBox
      Me.ebrFactura = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpFactDiferida = New Janus.Windows.EditControls.UIGroupBox
      Me.chkFacturaDif = New Janus.Windows.EditControls.UICheckBox
      Me.txtFactDifExento = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.tabPoliza = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrPoliza = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.mnuProrrateo = New System.Windows.Forms.ContextMenu
      Me.mnuShowProrrateo = New System.Windows.Forms.MenuItem
      Me.mnuEditProrrateo = New System.Windows.Forms.MenuItem
      Me.mnuAnticipo = New System.Windows.Forms.ContextMenu
      Me.mnuShowAnticipo = New System.Windows.Forms.MenuItem
      Me.mnuRecargo = New System.Windows.Forms.ContextMenu
      Me.mnuShowRecargo = New System.Windows.Forms.MenuItem
      Me.mnuNewRecargo = New System.Windows.Forms.MenuItem
      Me.mnuEditRecargo = New System.Windows.Forms.MenuItem
      Me.mnuDeleteRecargo = New System.Windows.Forms.MenuItem
      Me.mnuDescuento = New System.Windows.Forms.ContextMenu
      Me.mnuShowDescuento = New System.Windows.Forms.MenuItem
      Me.mnuNewDescuento = New System.Windows.Forms.MenuItem
      Me.mnuEditDescuento = New System.Windows.Forms.MenuItem
      Me.mnuDeleteDescuento = New System.Windows.Forms.MenuItem
      Me.mnuOtroCosto = New System.Windows.Forms.ContextMenu
      Me.mnuShowOtroCosto = New System.Windows.Forms.MenuItem
      Me.mnuNewOtroCosto = New System.Windows.Forms.MenuItem
      Me.mnuEditOtroCosto = New System.Windows.Forms.MenuItem
      Me.mnuDeleteOtroCosto = New System.Windows.Forms.MenuItem
      Me.MenuItem1 = New System.Windows.Forms.MenuItem
      Me.mnuFacturaOtroCosto = New System.Windows.Forms.MenuItem
      Me.mnuShowFacturaOtroCosto = New System.Windows.Forms.MenuItem
      Me.mnuNewFacturaOtroCosto = New System.Windows.Forms.MenuItem
      Me.mnuEditFacturaOtroCosto = New System.Windows.Forms.MenuItem
      Me.mnuDeleteFacturaOtroCosto = New System.Windows.Forms.MenuItem
      Me.mnuFactura = New System.Windows.Forms.ContextMenu
      Me.mnuShowFactura = New System.Windows.Forms.MenuItem
      Me.mnuNewFactura = New System.Windows.Forms.MenuItem
      Me.mnuEditFactura = New System.Windows.Forms.MenuItem
      Me.mnuDeleteFactura = New System.Windows.Forms.MenuItem
      Me.mnuPoliza = New System.Windows.Forms.ContextMenu
      Me.mnuShowPoliza = New System.Windows.Forms.MenuItem
      Me.mnuNewPoliza = New System.Windows.Forms.MenuItem
      Me.mnuEditPoliza = New System.Windows.Forms.MenuItem
      Me.mnuDeletePoliza = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdProrrateo, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl1.SuspendLayout()
      CType(Me.grdAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl2.SuspendLayout()
      CType(Me.grdCompraRecargo, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl3.SuspendLayout()
      CType(Me.grdCompraDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl5.SuspendLayout()
      CType(Me.grdCompraOtroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl6.SuspendLayout()
      CType(Me.grdFactura, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl7.SuspendLayout()
      CType(Me.grdPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
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
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox4.SuspendLayout()
      Me.tabAnticipo.SuspendLayout()
      CType(Me.ebrAnticipos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrAnticipos.SuspendLayout()
      Me.tabCompraRecargo.SuspendLayout()
      CType(Me.ebrRecargos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrRecargos.SuspendLayout()
      Me.tabCompraDescuento.SuspendLayout()
      CType(Me.ebrDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrDescuentos.SuspendLayout()
      Me.tabOtroCosto.SuspendLayout()
      CType(Me.ebrOtrosCostos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrOtrosCostos.SuspendLayout()
      Me.tabFactura.SuspendLayout()
      CType(Me.grpRetenciones, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpRetenciones.SuspendLayout()
      CType(Me.ebrFactura, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrFactura.SuspendLayout()
      CType(Me.grpFactDiferida, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpFactDiferida.SuspendLayout()
      Me.tabPoliza.SuspendLayout()
      CType(Me.ebrPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrPoliza.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdProrrateo)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(700, 175)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdProrrateo
      '
      Me.grdProrrateo.AllowCardSizing = False
      Me.grdProrrateo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdProrrateo.AlternatingColors = True
      Me.grdProrrateo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdProrrateo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdProrrateo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdProrrateo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdProrrateo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdProrrateo.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdProrrateo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdProrrateo.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdProrrateo.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdProrrateo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdProrrateo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdProrrateo.GroupByBoxVisible = False
      Me.grdProrrateo.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdProrrateo.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdProrrateo.Location = New System.Drawing.Point(0, 0)
      Me.grdProrrateo.Name = "grdProrrateo"
      Me.grdProrrateo.RecordNavigator = True
      Me.grdProrrateo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdProrrateo.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdProrrateo.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdProrrateo.Size = New System.Drawing.Size(700, 175)
      Me.grdProrrateo.TabIndex = 14
      Me.grdProrrateo.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdProrrateo.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdProrrateo.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdProrrateo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl1
      '
      Me.ExplorerBarContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl1.Controls.Add(Me.grdAnticipo)
      Me.ExplorerBarContainerControl1.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl1.Name = "ExplorerBarContainerControl1"
      Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(708, 343)
      Me.ExplorerBarContainerControl1.TabIndex = 1
      '
      'grdAnticipo
      '
      Me.grdAnticipo.AllowCardSizing = False
      Me.grdAnticipo.AlternatingColors = True
      Me.grdAnticipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdAnticipo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdAnticipo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdAnticipo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdAnticipo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdAnticipo.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdAnticipo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdAnticipo.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdAnticipo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdAnticipo.GroupByBoxVisible = False
      Me.grdAnticipo.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdAnticipo.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdAnticipo.Location = New System.Drawing.Point(0, 0)
      Me.grdAnticipo.Name = "grdAnticipo"
      Me.grdAnticipo.RecordNavigator = True
      Me.grdAnticipo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdAnticipo.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdAnticipo.Size = New System.Drawing.Size(708, 343)
      Me.grdAnticipo.TabIndex = 18
      Me.grdAnticipo.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdAnticipo.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdAnticipo.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdAnticipo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl2
      '
      Me.ExplorerBarContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl2.Controls.Add(Me.grdCompraRecargo)
      Me.ExplorerBarContainerControl2.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl2.Name = "ExplorerBarContainerControl2"
      Me.ExplorerBarContainerControl2.Size = New System.Drawing.Size(708, 343)
      Me.ExplorerBarContainerControl2.TabIndex = 1
      '
      'grdCompraRecargo
      '
      Me.grdCompraRecargo.AllowCardSizing = False
      Me.grdCompraRecargo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdCompraRecargo.AlternatingColors = True
      Me.grdCompraRecargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdCompraRecargo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdCompraRecargo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdCompraRecargo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdCompraRecargo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdCompraRecargo.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdCompraRecargo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdCompraRecargo.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdCompraRecargo.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdCompraRecargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdCompraRecargo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdCompraRecargo.GroupByBoxVisible = False
      Me.grdCompraRecargo.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdCompraRecargo.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdCompraRecargo.Location = New System.Drawing.Point(0, 0)
      Me.grdCompraRecargo.Name = "grdCompraRecargo"
      Me.grdCompraRecargo.RecordNavigator = True
      Me.grdCompraRecargo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdCompraRecargo.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdCompraRecargo.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdCompraRecargo.Size = New System.Drawing.Size(708, 343)
      Me.grdCompraRecargo.TabIndex = 20
      Me.grdCompraRecargo.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdCompraRecargo.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCompraRecargo.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCompraRecargo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl3
      '
      Me.ExplorerBarContainerControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl3.Controls.Add(Me.grdCompraDescuento)
      Me.ExplorerBarContainerControl3.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl3.Name = "ExplorerBarContainerControl3"
      Me.ExplorerBarContainerControl3.Size = New System.Drawing.Size(708, 343)
      Me.ExplorerBarContainerControl3.TabIndex = 1
      '
      'grdCompraDescuento
      '
      Me.grdCompraDescuento.AllowCardSizing = False
      Me.grdCompraDescuento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdCompraDescuento.AlternatingColors = True
      Me.grdCompraDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdCompraDescuento.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdCompraDescuento.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdCompraDescuento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdCompraDescuento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdCompraDescuento.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdCompraDescuento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdCompraDescuento.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdCompraDescuento.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdCompraDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdCompraDescuento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdCompraDescuento.GroupByBoxVisible = False
      Me.grdCompraDescuento.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdCompraDescuento.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdCompraDescuento.Location = New System.Drawing.Point(0, 0)
      Me.grdCompraDescuento.Name = "grdCompraDescuento"
      Me.grdCompraDescuento.RecordNavigator = True
      Me.grdCompraDescuento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdCompraDescuento.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdCompraDescuento.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdCompraDescuento.Size = New System.Drawing.Size(708, 343)
      Me.grdCompraDescuento.TabIndex = 22
      Me.grdCompraDescuento.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdCompraDescuento.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCompraDescuento.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCompraDescuento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl5
      '
      Me.ExplorerBarContainerControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl5.Controls.Add(Me.grdCompraOtroCosto)
      Me.ExplorerBarContainerControl5.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl5.Name = "ExplorerBarContainerControl5"
      Me.ExplorerBarContainerControl5.Size = New System.Drawing.Size(708, 343)
      Me.ExplorerBarContainerControl5.TabIndex = 1
      '
      'grdCompraOtroCosto
      '
      Me.grdCompraOtroCosto.AllowCardSizing = False
      Me.grdCompraOtroCosto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdCompraOtroCosto.AlternatingColors = True
      Me.grdCompraOtroCosto.AutomaticSort = False
      Me.grdCompraOtroCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdCompraOtroCosto.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdCompraOtroCosto.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdCompraOtroCosto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdCompraOtroCosto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdCompraOtroCosto.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdCompraOtroCosto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdCompraOtroCosto.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdCompraOtroCosto.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdCompraOtroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdCompraOtroCosto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdCompraOtroCosto.GroupByBoxVisible = False
      Me.grdCompraOtroCosto.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdCompraOtroCosto.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdCompraOtroCosto.Location = New System.Drawing.Point(0, 0)
      Me.grdCompraOtroCosto.Name = "grdCompraOtroCosto"
      Me.grdCompraOtroCosto.RecordNavigator = True
      Me.grdCompraOtroCosto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdCompraOtroCosto.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdCompraOtroCosto.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdCompraOtroCosto.Size = New System.Drawing.Size(708, 343)
      Me.grdCompraOtroCosto.TabIndex = 24
      Me.grdCompraOtroCosto.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdCompraOtroCosto.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCompraOtroCosto.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCompraOtroCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl6
      '
      Me.ExplorerBarContainerControl6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl6.Controls.Add(Me.grdFactura)
      Me.ExplorerBarContainerControl6.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl6.Name = "ExplorerBarContainerControl6"
      Me.ExplorerBarContainerControl6.Size = New System.Drawing.Size(708, 235)
      Me.ExplorerBarContainerControl6.TabIndex = 1
      '
      'grdFactura
      '
      Me.grdFactura.AllowCardSizing = False
      Me.grdFactura.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdFactura.AlternatingColors = True
      Me.grdFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdFactura.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdFactura.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdFactura.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdFactura.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdFactura.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdFactura.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdFactura.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdFactura.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdFactura.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdFactura.GroupByBoxVisible = False
      Me.grdFactura.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdFactura.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdFactura.Location = New System.Drawing.Point(0, 0)
      Me.grdFactura.Name = "grdFactura"
      Me.grdFactura.RecordNavigator = True
      Me.grdFactura.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdFactura.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdFactura.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdFactura.Size = New System.Drawing.Size(708, 235)
      Me.grdFactura.TabIndex = 26
      Me.grdFactura.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdFactura.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdFactura.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdFactura.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl7
      '
      Me.ExplorerBarContainerControl7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl7.Controls.Add(Me.grdPoliza)
      Me.ExplorerBarContainerControl7.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl7.Name = "ExplorerBarContainerControl7"
      Me.ExplorerBarContainerControl7.Size = New System.Drawing.Size(708, 343)
      Me.ExplorerBarContainerControl7.TabIndex = 1
      '
      'grdPoliza
      '
      Me.grdPoliza.AllowCardSizing = False
      Me.grdPoliza.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdPoliza.AlternatingColors = True
      Me.grdPoliza.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdPoliza.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdPoliza.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdPoliza.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdPoliza.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdPoliza.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdPoliza.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdPoliza.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdPoliza.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdPoliza.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdPoliza.GroupByBoxVisible = False
      Me.grdPoliza.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdPoliza.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdPoliza.Location = New System.Drawing.Point(0, 0)
      Me.grdPoliza.Name = "grdPoliza"
      Me.grdPoliza.RecordNavigator = True
      Me.grdPoliza.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdPoliza.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdPoliza.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdPoliza.Size = New System.Drawing.Size(708, 343)
      Me.grdPoliza.TabIndex = 28
      Me.grdPoliza.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdPoliza.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdPoliza.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdPoliza.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(230, 28)
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
      Me.Print.ImageIndex = 4
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
      Me.ilsMain.Images.SetKeyName(4, "")
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
      Me.TopRebar1.Size = New System.Drawing.Size(754, 28)
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.tabMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(754, 424)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(8, 8)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(736, 406)
      Me.tabMain.TabIndex = 0
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabGeneral, Me.tabAnticipo, Me.tabCompraRecargo, Me.tabCompraDescuento, Me.tabOtroCosto, Me.tabFactura, Me.tabPoliza})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabGeneral
      '
      Me.tabGeneral.Controls.Add(Me.ebrMain)
      Me.tabGeneral.Controls.Add(Me.UiGroupBox4)
      Me.tabGeneral.Key = "General"
      Me.tabGeneral.Location = New System.Drawing.Point(1, 21)
      Me.tabGeneral.Name = "tabGeneral"
      Me.tabGeneral.Size = New System.Drawing.Size(734, 384)
      Me.tabGeneral.TabStop = True
      Me.tabGeneral.Text = "General"
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
      ExplorerBarGroup1.ContainerHeight = 176
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(8, 168)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(716, 208)
      Me.ebrMain.TabIndex = 13
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox4
      '
      Me.UiGroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox4.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox4.Controls.Add(Me.txtExentoIVA)
      Me.UiGroupBox4.Controls.Add(Me.lblExentoIVA)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoRetencion)
      Me.UiGroupBox4.Controls.Add(Me.Label14)
      Me.UiGroupBox4.Controls.Add(Me.Label13)
      Me.UiGroupBox4.Controls.Add(Me.Label11)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoDes)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoRec)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoOrg)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoFac)
      Me.UiGroupBox4.Controls.Add(Me.Label17)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoCos)
      Me.UiGroupBox4.Controls.Add(Me.Label16)
      Me.UiGroupBox4.Controls.Add(Me.Label15)
      Me.UiGroupBox4.Controls.Add(Me.txtPolizaIVA)
      Me.UiGroupBox4.Controls.Add(Me.Label10)
      Me.UiGroupBox4.Controls.Add(Me.txtFacturaIVA)
      Me.UiGroupBox4.Controls.Add(Me.Label9)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoOtroSinIva)
      Me.UiGroupBox4.Controls.Add(Me.Label8)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoNet)
      Me.UiGroupBox4.Controls.Add(Me.Label7)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoLiq)
      Me.UiGroupBox4.Controls.Add(Me.Label4)
      Me.UiGroupBox4.Controls.Add(Me.Label5)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoOtroConIva)
      Me.UiGroupBox4.Controls.Add(Me.Label6)
      Me.UiGroupBox4.Controls.Add(Me.txtMontoAnt)
      Me.UiGroupBox4.Controls.Add(Me.Label3)
      Me.UiGroupBox4.Controls.Add(Me.Label2)
      Me.UiGroupBox4.Controls.Add(Me.Label1)
      Me.UiGroupBox4.Location = New System.Drawing.Point(8, 0)
      Me.UiGroupBox4.Name = "UiGroupBox4"
      Me.UiGroupBox4.Size = New System.Drawing.Size(716, 164)
      Me.UiGroupBox4.TabIndex = 0
      Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'txtExentoIVA
      '
      Me.txtExentoIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtExentoIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExentoIVA.FormatString = "##,##0.000"
      Me.txtExentoIVA.Location = New System.Drawing.Point(344, 40)
      Me.txtExentoIVA.Name = "txtExentoIVA"
      Me.txtExentoIVA.ReadOnly = True
      Me.txtExentoIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtExentoIVA.TabIndex = 280
      Me.txtExentoIVA.TabStop = False
      Me.txtExentoIVA.Text = "0,000"
      Me.txtExentoIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExentoIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExentoIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblExentoIVA
      '
      Me.lblExentoIVA.BackColor = System.Drawing.Color.Transparent
      Me.lblExentoIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblExentoIVA.Location = New System.Drawing.Point(280, 44)
      Me.lblExentoIVA.Name = "lblExentoIVA"
      Me.lblExentoIVA.Size = New System.Drawing.Size(68, 16)
      Me.lblExentoIVA.TabIndex = 281
      Me.lblExentoIVA.Text = "ExentoIVA"
      '
      'txtMontoRetencion
      '
      Me.txtMontoRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoRetencion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoRetencion.FormatString = "##,##0.000"
      Me.txtMontoRetencion.Location = New System.Drawing.Point(344, 16)
      Me.txtMontoRetencion.Name = "txtMontoRetencion"
      Me.txtMontoRetencion.ReadOnly = True
      Me.txtMontoRetencion.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoRetencion.TabIndex = 278
      Me.txtMontoRetencion.Text = "0,000"
      Me.txtMontoRetencion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoRetencion.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoRetencion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(280, 20)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(68, 16)
      Me.Label14.TabIndex = 279
      Me.Label14.Text = "Retención"
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(92, 68)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(68, 16)
      Me.Label13.TabIndex = 277
      Me.Label13.Text = "No Aplica."
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(92, 44)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(68, 16)
      Me.Label11.TabIndex = 275
      Me.Label11.Text = "No Aplica."
      '
      'txtMontoDes
      '
      Me.txtMontoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoDes.FormatString = "##,##0.000"
      Me.txtMontoDes.Location = New System.Drawing.Point(160, 64)
      Me.txtMontoDes.Name = "txtMontoDes"
      Me.txtMontoDes.ReadOnly = True
      Me.txtMontoDes.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoDes.TabIndex = 3
      Me.txtMontoDes.Text = "0,000"
      Me.txtMontoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoDes.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMontoRec
      '
      Me.txtMontoRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoRec.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoRec.FormatString = "##,##0.000"
      Me.txtMontoRec.Location = New System.Drawing.Point(160, 40)
      Me.txtMontoRec.Name = "txtMontoRec"
      Me.txtMontoRec.ReadOnly = True
      Me.txtMontoRec.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoRec.TabIndex = 2
      Me.txtMontoRec.Text = "0,000"
      Me.txtMontoRec.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoRec.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoRec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMontoOrg
      '
      Me.txtMontoOrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoOrg.FormatString = "##,##0.000"
      Me.txtMontoOrg.Location = New System.Drawing.Point(600, 16)
      Me.txtMontoOrg.Name = "txtMontoOrg"
      Me.txtMontoOrg.ReadOnly = True
      Me.txtMontoOrg.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoOrg.TabIndex = 7
      Me.txtMontoOrg.Text = "0,000"
      Me.txtMontoOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMontoFac
      '
      Me.txtMontoFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoFac.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoFac.FormatString = "##,##0.000"
      Me.txtMontoFac.Location = New System.Drawing.Point(600, 64)
      Me.txtMontoFac.Name = "txtMontoFac"
      Me.txtMontoFac.ReadOnly = True
      Me.txtMontoFac.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoFac.TabIndex = 9
      Me.txtMontoFac.Text = "0,000"
      Me.txtMontoFac.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoFac.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoFac.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label17
      '
      Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(480, 68)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(104, 16)
      Me.Label17.TabIndex = 263
      Me.Label17.Text = "Total a Facturar"
      '
      'txtMontoCos
      '
      Me.txtMontoCos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoCos.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoCos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoCos.FormatString = "##,##0.000"
      Me.txtMontoCos.Location = New System.Drawing.Point(600, 40)
      Me.txtMontoCos.Name = "txtMontoCos"
      Me.txtMontoCos.ReadOnly = True
      Me.txtMontoCos.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoCos.TabIndex = 8
      Me.txtMontoCos.Text = "0,000"
      Me.txtMontoCos.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoCos.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoCos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(480, 44)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 261
      Me.Label16.Text = "Total Costo"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(92, 92)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(68, 16)
      Me.Label15.TabIndex = 259
      Me.Label15.Text = "Con IVA"
      '
      'txtPolizaIVA
      '
      Me.txtPolizaIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPolizaIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPolizaIVA.FormatString = "##,##0.000"
      Me.txtPolizaIVA.Location = New System.Drawing.Point(160, 136)
      Me.txtPolizaIVA.Name = "txtPolizaIVA"
      Me.txtPolizaIVA.ReadOnly = True
      Me.txtPolizaIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtPolizaIVA.TabIndex = 6
      Me.txtPolizaIVA.Text = "0,000"
      Me.txtPolizaIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPolizaIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPolizaIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 140)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(156, 16)
      Me.Label10.TabIndex = 252
      Me.Label10.Text = "Póliza IVA"
      '
      'txtFacturaIVA
      '
      Me.txtFacturaIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtFacturaIVA.BackColor = System.Drawing.SystemColors.Info
      Me.txtFacturaIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFacturaIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaIVA.FormatString = "##,##0.000"
      Me.txtFacturaIVA.Location = New System.Drawing.Point(600, 88)
      Me.txtFacturaIVA.Name = "txtFacturaIVA"
      Me.txtFacturaIVA.ReadOnly = True
      Me.txtFacturaIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaIVA.TabIndex = 10
      Me.txtFacturaIVA.Text = "0,000"
      Me.txtFacturaIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtFacturaIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtFacturaIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(480, 92)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(124, 16)
      Me.Label9.TabIndex = 250
      Me.Label9.Text = "Factura IVA /Reten."
      '
      'txtMontoOtroSinIva
      '
      Me.txtMontoOtroSinIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoOtroSinIva.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoOtroSinIva.FormatString = "##,##0.000"
      Me.txtMontoOtroSinIva.Location = New System.Drawing.Point(160, 112)
      Me.txtMontoOtroSinIva.Name = "txtMontoOtroSinIva"
      Me.txtMontoOtroSinIva.ReadOnly = True
      Me.txtMontoOtroSinIva.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoOtroSinIva.TabIndex = 5
      Me.txtMontoOtroSinIva.Text = "0,000"
      Me.txtMontoOtroSinIva.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoOtroSinIva.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoOtroSinIva.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(92, 116)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(68, 16)
      Me.Label8.TabIndex = 248
      Me.Label8.Text = "Sin IVA"
      '
      'txtMontoNet
      '
      Me.txtMontoNet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoNet.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoNet.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoNet.FormatString = "##,##0.000"
      Me.txtMontoNet.Location = New System.Drawing.Point(600, 112)
      Me.txtMontoNet.Name = "txtMontoNet"
      Me.txtMontoNet.ReadOnly = True
      Me.txtMontoNet.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoNet.TabIndex = 11
      Me.txtMontoNet.Text = "0,000"
      Me.txtMontoNet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoNet.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoNet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(480, 116)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 246
      Me.Label7.Text = "Total Neto"
      '
      'txtMontoLiq
      '
      Me.txtMontoLiq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMontoLiq.BackColor = System.Drawing.SystemColors.Info
      Me.txtMontoLiq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoLiq.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoLiq.FormatString = "##,##0.000"
      Me.txtMontoLiq.Location = New System.Drawing.Point(600, 136)
      Me.txtMontoLiq.Name = "txtMontoLiq"
      Me.txtMontoLiq.ReadOnly = True
      Me.txtMontoLiq.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoLiq.TabIndex = 12
      Me.txtMontoLiq.Text = "0,000"
      Me.txtMontoLiq.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoLiq.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoLiq.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(480, 140)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 244
      Me.Label4.Text = "Líquido Pagable"
      '
      'Label5
      '
      Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(480, 20)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 242
      Me.Label5.Text = "Total Nota"
      '
      'txtMontoOtroConIva
      '
      Me.txtMontoOtroConIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoOtroConIva.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoOtroConIva.FormatString = "##,##0.000"
      Me.txtMontoOtroConIva.Location = New System.Drawing.Point(160, 88)
      Me.txtMontoOtroConIva.Name = "txtMontoOtroConIva"
      Me.txtMontoOtroConIva.ReadOnly = True
      Me.txtMontoOtroConIva.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoOtroConIva.TabIndex = 4
      Me.txtMontoOtroConIva.Text = "0,000"
      Me.txtMontoOtroConIva.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoOtroConIva.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoOtroConIva.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 92)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(88, 16)
      Me.Label6.TabIndex = 239
      Me.Label6.Text = "Otros Costos"
      '
      'txtMontoAnt
      '
      Me.txtMontoAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoAnt.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoAnt.FormatString = "##,##0.000"
      Me.txtMontoAnt.Location = New System.Drawing.Point(160, 16)
      Me.txtMontoAnt.Name = "txtMontoAnt"
      Me.txtMontoAnt.ReadOnly = True
      Me.txtMontoAnt.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoAnt.TabIndex = 1
      Me.txtMontoAnt.Text = "0,000"
      Me.txtMontoAnt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoAnt.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoAnt.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(152, 16)
      Me.Label3.TabIndex = 237
      Me.Label3.Text = "Anticipos"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 68)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(88, 16)
      Me.Label2.TabIndex = 235
      Me.Label2.Text = "Descuentos"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(88, 16)
      Me.Label1.TabIndex = 233
      Me.Label1.Text = "Recargos"
      '
      'tabAnticipo
      '
      Me.tabAnticipo.Controls.Add(Me.ebrAnticipos)
      Me.tabAnticipo.Key = "Anticipo"
      Me.tabAnticipo.Location = New System.Drawing.Point(1, 21)
      Me.tabAnticipo.Name = "tabAnticipo"
      Me.tabAnticipo.Size = New System.Drawing.Size(734, 384)
      Me.tabAnticipo.TabStop = True
      Me.tabAnticipo.Text = "Anticipos"
      '
      'ebrAnticipos
      '
      Me.ebrAnticipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrAnticipos.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrAnticipos.Controls.Add(Me.ExplorerBarContainerControl1)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl1
      ExplorerBarGroup2.ContainerHeight = 344
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ebrAnticipos.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ebrAnticipos.GroupSeparation = 4
      Me.ebrAnticipos.Location = New System.Drawing.Point(4, 4)
      Me.ebrAnticipos.Name = "ebrAnticipos"
      Me.ebrAnticipos.Size = New System.Drawing.Size(724, 376)
      Me.ebrAnticipos.TabIndex = 17
      Me.ebrAnticipos.Text = "ExplorerBar2"
      Me.ebrAnticipos.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrAnticipos.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrAnticipos.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrAnticipos.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabCompraRecargo
      '
      Me.tabCompraRecargo.Controls.Add(Me.ebrRecargos)
      Me.tabCompraRecargo.Key = "CompraRecargo"
      Me.tabCompraRecargo.Location = New System.Drawing.Point(1, 21)
      Me.tabCompraRecargo.Name = "tabCompraRecargo"
      Me.tabCompraRecargo.Size = New System.Drawing.Size(734, 384)
      Me.tabCompraRecargo.TabStop = True
      Me.tabCompraRecargo.TabVisible = False
      Me.tabCompraRecargo.Text = "Recargos"
      Me.tabCompraRecargo.Visible = False
      '
      'ebrRecargos
      '
      Me.ebrRecargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrRecargos.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrRecargos.Controls.Add(Me.ExplorerBarContainerControl2)
      ExplorerBarGroup3.Container = True
      ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl2
      ExplorerBarGroup3.ContainerHeight = 344
      ExplorerBarGroup3.Expandable = False
      ExplorerBarGroup3.Key = "Group1"
      Me.ebrRecargos.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
      Me.ebrRecargos.GroupSeparation = 4
      Me.ebrRecargos.Location = New System.Drawing.Point(5, 4)
      Me.ebrRecargos.Name = "ebrRecargos"
      Me.ebrRecargos.Size = New System.Drawing.Size(724, 376)
      Me.ebrRecargos.TabIndex = 19
      Me.ebrRecargos.Text = "ExplorerBar2"
      Me.ebrRecargos.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrRecargos.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrRecargos.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrRecargos.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabCompraDescuento
      '
      Me.tabCompraDescuento.Controls.Add(Me.ebrDescuentos)
      Me.tabCompraDescuento.Key = "CompraDescuento"
      Me.tabCompraDescuento.Location = New System.Drawing.Point(1, 21)
      Me.tabCompraDescuento.Name = "tabCompraDescuento"
      Me.tabCompraDescuento.Size = New System.Drawing.Size(734, 384)
      Me.tabCompraDescuento.TabStop = True
      Me.tabCompraDescuento.TabVisible = False
      Me.tabCompraDescuento.Text = "Descuentos"
      '
      'ebrDescuentos
      '
      Me.ebrDescuentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrDescuentos.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrDescuentos.Controls.Add(Me.ExplorerBarContainerControl3)
      ExplorerBarGroup4.Container = True
      ExplorerBarGroup4.ContainerControl = Me.ExplorerBarContainerControl3
      ExplorerBarGroup4.ContainerHeight = 344
      ExplorerBarGroup4.Expandable = False
      ExplorerBarGroup4.Key = "Group1"
      Me.ebrDescuentos.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup4})
      Me.ebrDescuentos.GroupSeparation = 4
      Me.ebrDescuentos.Location = New System.Drawing.Point(5, 4)
      Me.ebrDescuentos.Name = "ebrDescuentos"
      Me.ebrDescuentos.Size = New System.Drawing.Size(724, 376)
      Me.ebrDescuentos.TabIndex = 21
      Me.ebrDescuentos.Text = "ExplorerBar2"
      Me.ebrDescuentos.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrDescuentos.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDescuentos.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDescuentos.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabOtroCosto
      '
      Me.tabOtroCosto.Controls.Add(Me.ebrOtrosCostos)
      Me.tabOtroCosto.Key = "OtroCosto"
      Me.tabOtroCosto.Location = New System.Drawing.Point(1, 21)
      Me.tabOtroCosto.Name = "tabOtroCosto"
      Me.tabOtroCosto.Size = New System.Drawing.Size(734, 384)
      Me.tabOtroCosto.TabStop = True
      Me.tabOtroCosto.Text = "Otros Costos"
      '
      'ebrOtrosCostos
      '
      Me.ebrOtrosCostos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrOtrosCostos.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrOtrosCostos.Controls.Add(Me.ExplorerBarContainerControl5)
      ExplorerBarGroup5.Container = True
      ExplorerBarGroup5.ContainerControl = Me.ExplorerBarContainerControl5
      ExplorerBarGroup5.ContainerHeight = 344
      ExplorerBarGroup5.Expandable = False
      ExplorerBarGroup5.Key = "Group1"
      Me.ebrOtrosCostos.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup5})
      Me.ebrOtrosCostos.GroupSeparation = 4
      Me.ebrOtrosCostos.Location = New System.Drawing.Point(5, 4)
      Me.ebrOtrosCostos.Name = "ebrOtrosCostos"
      Me.ebrOtrosCostos.Size = New System.Drawing.Size(724, 376)
      Me.ebrOtrosCostos.TabIndex = 23
      Me.ebrOtrosCostos.Text = "ExplorerBar2"
      Me.ebrOtrosCostos.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrOtrosCostos.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrOtrosCostos.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrOtrosCostos.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabFactura
      '
      Me.tabFactura.Controls.Add(Me.grpRetenciones)
      Me.tabFactura.Controls.Add(Me.ebrFactura)
      Me.tabFactura.Controls.Add(Me.grpFactDiferida)
      Me.tabFactura.Key = "Factura"
      Me.tabFactura.Location = New System.Drawing.Point(1, 21)
      Me.tabFactura.Name = "tabFactura"
      Me.tabFactura.Size = New System.Drawing.Size(734, 384)
      Me.tabFactura.TabStop = True
      Me.tabFactura.Text = "Factura - Retención"
      '
      'grpRetenciones
      '
      Me.grpRetenciones.BackColor = System.Drawing.Color.Transparent
      Me.grpRetenciones.Controls.Add(Me.Label12)
      Me.grpRetenciones.Controls.Add(Me.cboTipoRetencion)
      Me.grpRetenciones.Location = New System.Drawing.Point(4, 0)
      Me.grpRetenciones.Name = "grpRetenciones"
      Me.grpRetenciones.Size = New System.Drawing.Size(728, 56)
      Me.grpRetenciones.TabIndex = 25
      Me.grpRetenciones.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 24)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 246
      Me.Label12.Text = "Tipo Retención"
      '
      'cboTipoRetencion
      '
      Me.cboTipoRetencion.FlatBorderColor = System.Drawing.SystemColors.AppWorkspace
      Me.cboTipoRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoRetencion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoRetencion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoRetencion.Location = New System.Drawing.Point(112, 20)
      Me.cboTipoRetencion.Name = "cboTipoRetencion"
      Me.cboTipoRetencion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoRetencion.Size = New System.Drawing.Size(272, 20)
      Me.cboTipoRetencion.TabIndex = 26
      Me.cboTipoRetencion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'ebrFactura
      '
      Me.ebrFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrFactura.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrFactura.Controls.Add(Me.ExplorerBarContainerControl6)
      ExplorerBarGroup6.Container = True
      ExplorerBarGroup6.ContainerControl = Me.ExplorerBarContainerControl6
      ExplorerBarGroup6.ContainerHeight = 236
      ExplorerBarGroup6.Expandable = False
      ExplorerBarGroup6.Key = "Group1"
      Me.ebrFactura.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup6})
      Me.ebrFactura.GroupSeparation = 4
      Me.ebrFactura.Location = New System.Drawing.Point(5, 112)
      Me.ebrFactura.Name = "ebrFactura"
      Me.ebrFactura.Size = New System.Drawing.Size(724, 268)
      Me.ebrFactura.TabIndex = 27
      Me.ebrFactura.Text = "ExplorerBar2"
      Me.ebrFactura.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrFactura.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrFactura.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrFactura.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'grpFactDiferida
      '
      Me.grpFactDiferida.BackColor = System.Drawing.Color.Transparent
      Me.grpFactDiferida.Controls.Add(Me.chkFacturaDif)
      Me.grpFactDiferida.Controls.Add(Me.txtFactDifExento)
      Me.grpFactDiferida.Controls.Add(Me.Label18)
      Me.grpFactDiferida.Location = New System.Drawing.Point(3, 55)
      Me.grpFactDiferida.Name = "grpFactDiferida"
      Me.grpFactDiferida.Size = New System.Drawing.Size(728, 52)
      Me.grpFactDiferida.TabIndex = 28
      Me.grpFactDiferida.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkFacturaDif
      '
      Me.chkFacturaDif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkFacturaDif.BackColor = System.Drawing.Color.Transparent
      Me.chkFacturaDif.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFacturaDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFacturaDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFacturaDif.Location = New System.Drawing.Point(12, 21)
      Me.chkFacturaDif.Name = "chkFacturaDif"
      Me.chkFacturaDif.Size = New System.Drawing.Size(112, 16)
      Me.chkFacturaDif.TabIndex = 280
      Me.chkFacturaDif.TabStop = False
      Me.chkFacturaDif.Text = "Factura Diferida"
      Me.chkFacturaDif.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtFactDifExento
      '
      Me.txtFactDifExento.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtFactDifExento.Enabled = False
      Me.txtFactDifExento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFactDifExento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFactDifExento.FormatString = "##,##0.000"
      Me.txtFactDifExento.Location = New System.Drawing.Point(232, 18)
      Me.txtFactDifExento.Name = "txtFactDifExento"
      Me.txtFactDifExento.ReadOnly = True
      Me.txtFactDifExento.Size = New System.Drawing.Size(104, 20)
      Me.txtFactDifExento.TabIndex = 213
      Me.txtFactDifExento.Text = "0,000"
      Me.txtFactDifExento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtFactDifExento.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtFactDifExento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(140, 22)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(92, 16)
      Me.Label18.TabIndex = 214
      Me.Label18.Text = "Monto Exento"
      '
      'tabPoliza
      '
      Me.tabPoliza.Controls.Add(Me.ebrPoliza)
      Me.tabPoliza.Key = "Poliza"
      Me.tabPoliza.Location = New System.Drawing.Point(1, 21)
      Me.tabPoliza.Name = "tabPoliza"
      Me.tabPoliza.Size = New System.Drawing.Size(734, 384)
      Me.tabPoliza.TabStop = True
      Me.tabPoliza.Text = "Póliza"
      '
      'ebrPoliza
      '
      Me.ebrPoliza.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrPoliza.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrPoliza.Controls.Add(Me.ExplorerBarContainerControl7)
      ExplorerBarGroup7.Container = True
      ExplorerBarGroup7.ContainerControl = Me.ExplorerBarContainerControl7
      ExplorerBarGroup7.ContainerHeight = 344
      ExplorerBarGroup7.Expandable = False
      ExplorerBarGroup7.Key = "Group1"
      Me.ebrPoliza.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup7})
      Me.ebrPoliza.GroupSeparation = 4
      Me.ebrPoliza.Location = New System.Drawing.Point(5, 4)
      Me.ebrPoliza.Name = "ebrPoliza"
      Me.ebrPoliza.Size = New System.Drawing.Size(724, 376)
      Me.ebrPoliza.TabIndex = 28
      Me.ebrPoliza.Text = "ExplorerBar2"
      Me.ebrPoliza.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrPoliza.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrPoliza.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrPoliza.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'mnuProrrateo
      '
      Me.mnuProrrateo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowProrrateo, Me.mnuEditProrrateo})
      '
      'mnuShowProrrateo
      '
      Me.mnuShowProrrateo.Index = 0
      Me.mnuShowProrrateo.Text = "Consultar"
      '
      'mnuEditProrrateo
      '
      Me.mnuEditProrrateo.Index = 1
      Me.mnuEditProrrateo.Text = "Editar"
      '
      'mnuAnticipo
      '
      Me.mnuAnticipo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowAnticipo})
      '
      'mnuShowAnticipo
      '
      Me.mnuShowAnticipo.Index = 0
      Me.mnuShowAnticipo.Text = "Consultar"
      '
      'mnuRecargo
      '
      Me.mnuRecargo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowRecargo, Me.mnuNewRecargo, Me.mnuEditRecargo, Me.mnuDeleteRecargo})
      '
      'mnuShowRecargo
      '
      Me.mnuShowRecargo.Index = 0
      Me.mnuShowRecargo.Text = "Consultar"
      '
      'mnuNewRecargo
      '
      Me.mnuNewRecargo.Index = 1
      Me.mnuNewRecargo.Text = "Nuevo"
      '
      'mnuEditRecargo
      '
      Me.mnuEditRecargo.Index = 2
      Me.mnuEditRecargo.Text = "Editar"
      '
      'mnuDeleteRecargo
      '
      Me.mnuDeleteRecargo.Index = 3
      Me.mnuDeleteRecargo.Text = "Eliminar"
      '
      'mnuDescuento
      '
      Me.mnuDescuento.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowDescuento, Me.mnuNewDescuento, Me.mnuEditDescuento, Me.mnuDeleteDescuento})
      '
      'mnuShowDescuento
      '
      Me.mnuShowDescuento.Index = 0
      Me.mnuShowDescuento.Text = "Consultar"
      '
      'mnuNewDescuento
      '
      Me.mnuNewDescuento.Index = 1
      Me.mnuNewDescuento.Text = "Nuevo"
      '
      'mnuEditDescuento
      '
      Me.mnuEditDescuento.Index = 2
      Me.mnuEditDescuento.Text = "Editar"
      '
      'mnuDeleteDescuento
      '
      Me.mnuDeleteDescuento.Index = 3
      Me.mnuDeleteDescuento.Text = "Eliminar"
      '
      'mnuOtroCosto
      '
      Me.mnuOtroCosto.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowOtroCosto, Me.mnuNewOtroCosto, Me.mnuEditOtroCosto, Me.mnuDeleteOtroCosto, Me.MenuItem1, Me.mnuFacturaOtroCosto})
      '
      'mnuShowOtroCosto
      '
      Me.mnuShowOtroCosto.Index = 0
      Me.mnuShowOtroCosto.Text = "Consultar"
      '
      'mnuNewOtroCosto
      '
      Me.mnuNewOtroCosto.Index = 1
      Me.mnuNewOtroCosto.Text = "Nuevo"
      '
      'mnuEditOtroCosto
      '
      Me.mnuEditOtroCosto.Index = 2
      Me.mnuEditOtroCosto.Text = "Editar"
      '
      'mnuDeleteOtroCosto
      '
      Me.mnuDeleteOtroCosto.Index = 3
      Me.mnuDeleteOtroCosto.Text = "Eliminar"
      '
      'MenuItem1
      '
      Me.MenuItem1.Index = 4
      Me.MenuItem1.Text = "-"
      '
      'mnuFacturaOtroCosto
      '
      Me.mnuFacturaOtroCosto.Index = 5
      Me.mnuFacturaOtroCosto.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowFacturaOtroCosto, Me.mnuNewFacturaOtroCosto, Me.mnuEditFacturaOtroCosto, Me.mnuDeleteFacturaOtroCosto})
      Me.mnuFacturaOtroCosto.Text = "Factura"
      '
      'mnuShowFacturaOtroCosto
      '
      Me.mnuShowFacturaOtroCosto.Index = 0
      Me.mnuShowFacturaOtroCosto.Text = "Consultar"
      '
      'mnuNewFacturaOtroCosto
      '
      Me.mnuNewFacturaOtroCosto.Index = 1
      Me.mnuNewFacturaOtroCosto.Text = "Nueva"
      '
      'mnuEditFacturaOtroCosto
      '
      Me.mnuEditFacturaOtroCosto.Index = 2
      Me.mnuEditFacturaOtroCosto.Text = "Editar"
      '
      'mnuDeleteFacturaOtroCosto
      '
      Me.mnuDeleteFacturaOtroCosto.Index = 3
      Me.mnuDeleteFacturaOtroCosto.Text = "Eliminar"
      '
      'mnuFactura
      '
      Me.mnuFactura.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowFactura, Me.mnuNewFactura, Me.mnuEditFactura, Me.mnuDeleteFactura})
      '
      'mnuShowFactura
      '
      Me.mnuShowFactura.Index = 0
      Me.mnuShowFactura.Text = "Consultar"
      '
      'mnuNewFactura
      '
      Me.mnuNewFactura.Index = 1
      Me.mnuNewFactura.Text = "Nuevo"
      '
      'mnuEditFactura
      '
      Me.mnuEditFactura.Index = 2
      Me.mnuEditFactura.Text = "Editar"
      '
      'mnuDeleteFactura
      '
      Me.mnuDeleteFactura.Index = 3
      Me.mnuDeleteFactura.Text = "Eliminar"
      '
      'mnuPoliza
      '
      Me.mnuPoliza.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowPoliza, Me.mnuNewPoliza, Me.mnuEditPoliza, Me.mnuDeletePoliza})
      '
      'mnuShowPoliza
      '
      Me.mnuShowPoliza.Index = 0
      Me.mnuShowPoliza.Text = "Consultar"
      '
      'mnuNewPoliza
      '
      Me.mnuNewPoliza.Index = 1
      Me.mnuNewPoliza.Text = "Nuevo"
      '
      'mnuEditPoliza
      '
      Me.mnuEditPoliza.Index = 2
      Me.mnuEditPoliza.Text = "Editar"
      '
      'mnuDeletePoliza
      '
      Me.mnuDeletePoliza.Index = 3
      Me.mnuDeletePoliza.Text = "Eliminar"
      '
      'frmCompraNext
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(754, 452)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MinimizeBox = False
      Me.Name = "frmCompraNext"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompraNext Edit"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdProrrateo, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl1.ResumeLayout(False)
      CType(Me.grdAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl2.ResumeLayout(False)
      CType(Me.grdCompraRecargo, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl3.ResumeLayout(False)
      CType(Me.grdCompraDescuento, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl5.ResumeLayout(False)
      CType(Me.grdCompraOtroCosto, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl6.ResumeLayout(False)
      CType(Me.grdFactura, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl7.ResumeLayout(False)
      CType(Me.grdPoliza, System.ComponentModel.ISupportInitialize).EndInit()
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
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox4.ResumeLayout(False)
      Me.UiGroupBox4.PerformLayout()
      Me.tabAnticipo.ResumeLayout(False)
      CType(Me.ebrAnticipos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrAnticipos.ResumeLayout(False)
      Me.tabCompraRecargo.ResumeLayout(False)
      CType(Me.ebrRecargos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrRecargos.ResumeLayout(False)
      Me.tabCompraDescuento.ResumeLayout(False)
      CType(Me.ebrDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrDescuentos.ResumeLayout(False)
      Me.tabOtroCosto.ResumeLayout(False)
      CType(Me.ebrOtrosCostos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrOtrosCostos.ResumeLayout(False)
      Me.tabFactura.ResumeLayout(False)
      CType(Me.grpRetenciones, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpRetenciones.ResumeLayout(False)
      CType(Me.ebrFactura, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrFactura.ResumeLayout(False)
      CType(Me.grpFactDiferida, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpFactDiferida.ResumeLayout(False)
      Me.grpFactDiferida.PerformLayout()
      Me.tabPoliza.ResumeLayout(False)
      CType(Me.ebrPoliza, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrPoliza.ResumeLayout(False)
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
               mlngID = moCompra.CompraId
               mboolChanged = True
               Me.Close()
            End If

         Case "Print"
            ''Call PrintReport()
            Call PrintReportAdicional()

         Case "Exit"
            If mboolAdding Then
               mlngID = moCompra.CompraId
               moCompra.Update()
            End If

            Me.Close()
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
            Me.Text = "Consulta Compra (Información Adicional)"
         Else
            Me.Text = "Editar Compra (Información Adicional)"
         End If
      Else
         Me.Text = "Nueva Compra (Información Adicional)"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      CostoIdNro = 0

      'Call grdCompraRecargoLoad()
      'Call grdCompraDescuentoLoad()
      Call grdAnticipoLoad()
      Call grdFacturaLoad()
      Call grdPolizaLoad()
      Call grdCompraOtroCostoLoad()

      mlngCompIdOtrosCosto = CompraOtroCostoCompIdLoad()

      With moCompra

         chkFacturaDif.Checked = .FacturaDif

         txtMontoDes.Text = decCompraDescuentoNoApli(.CompraId)
         txtMontoRec.Text = decCompraRecargoNoApli(.CompraId)

         txtMontoOrg.Text = ToDecimal(.MontoBru)

         txtMontoFac.Text = ToDecimal(.MontoBru + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text))
         txtMontoNet.Text = ToDecimal(ToDouble(txtMontoFac.Text))
         txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text))
         txtMontoLiq.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtMontoAnt.Text))

         chkFacturaDif.Checked = .FacturaDif
         txtFactDifExento.Text = ToDecimal(.FactDifExento)

         cboTipoRetencion.SelectedIndex = ListFindItem(cboTipoRetencion, .TipoRetencionId)
         mlngTipoRetencionId = .TipoRetencionId

         If (.FacturaId > 0) Then
            txtMontoNet.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtFacturaIVA.Text))
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text) - ToDouble(txtExentoIVA.Text))
            txtMontoLiq.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtMontoAnt.Text))

            chkFacturaDif.Enabled = False
            txtFactDifExento.Enabled = False
            cboTipoRetencion.Enabled = False

         ElseIf (chkFacturaDif.Checked) Then

            If clsAppInfo.SepararExento Then
               txtExentoIVA.Text = ToDecimal(.FactDifExento * clsAppInfo.IVA)
            End If

            txtFacturaIVA.Text = ToDecimal((.MontoBru - .FactDifExento) * clsAppInfo.IVA)
            txtMontoNet.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtFacturaIVA.Text))
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text) - ToDouble(txtExentoIVA.Text))
            txtMontoLiq.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtMontoAnt.Text))

            cboTipoRetencion.Enabled = False
            txtFactDifExento.Enabled = True
            txtFactDifExento.ReadOnly = False

            If CompraFacturasDifFind(.CompraId) Or (.MontoFac = .MontoBru) Then
               chkFacturaDif.Enabled = False
               txtFactDifExento.Enabled = False
            End If

         ElseIf (mlngTipoRetencionId > 0) And (mlngTipoRetencionId < 4) Then   '' Asume Empresa
            txtFacturaIVA.Text = RetencionCalcEmpresa(mlngTipoRetencionId)
            txtMontoNet.Text = ToDecimal(txtMontoFac.Text)
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) + ToDouble(txtFacturaIVA.Text))
            txtMontoLiq.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtMontoAnt.Text))

            chkFacturaDif.Enabled = False
            txtFactDifExento.Enabled = False

         ElseIf (mlngTipoRetencionId > 3) And (mlngTipoRetencionId < 7) Then   '' Asume Empresa
            txtMontoRetencion.Text = RetencionCalcProveedor(mlngTipoRetencionId)
            txtMontoNet.Text = ToDecimal(txtMontoFac.Text)
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text))
            txtMontoLiq.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtMontoAnt.Text) - ToDouble(txtMontoRetencion.Text))

            chkFacturaDif.Enabled = False
            txtFactDifExento.Enabled = False

         ElseIf .PolizaId > 0 Then

            chkFacturaDif.Enabled = False
            txtFactDifExento.Enabled = False
            cboTipoRetencion.Enabled = False

         End If

         Call FacturaOrgLoad()
         Call PolizaOrgLoad()
         Call grdProrrateoLoad(mboolEditing)

      End With

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      CostoIdNro = 0

      'Call grdCompraRecargoLoad()
      'Call grdCompraDescuentoLoad()
      Call grdAnticipoLoad()
      Call grdFacturaLoad()
      Call grdPolizaLoad()
      Call grdCompraOtroCostoLoad()

      With moCompra

         chkFacturaDif.Checked = False

         txtMontoOtroConIva.Text = "0"
         txtMontoOtroSinIva.Text = "0"
         txtMontoOrg.Text = .MontoBru
         txtMontoCos.Text = .MontoBru
         txtMontoFac.Text = .MontoBru
         txtMontoNet.Text = .MontoBru
         txtMontoLiq.Text = .MontoBru - ToDouble(txtMontoAnt.Text)

         cboTipoRetencion.SelectedIndex = ListFindItem(cboTipoRetencion, 0)
         chkFacturaDif.Checked = False
         txtFactDifExento.Text = 0

         If (.FacturaId > 0) Or (.PolizaId > 0) Then
            txtMontoNet.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtFacturaIVA.Text))
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text))
            txtMontoLiq.Text = ToDecimal(ToDouble(txtMontoFac.Text) - ToDouble(txtMontoAnt.Text))

            chkFacturaDif.Enabled = False
            txtFactDifExento.Enabled = False
            cboTipoRetencion.Enabled = False

         End If

         Call grdProrrateoLoad(True)
      End With

      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cboTipoRetencion.ReadOnly = True
      chkFacturaDif.Enabled = False
      txtFactDifExento.ReadOnly = True
   End Sub

   Private Sub DataMove()
      With moCompra
         .MontoRec += ToDecimal(txtMontoRec.Text)
         .MontoDes += ToDecimal(txtMontoDes.Text)
         .MontoAnt = ToDecimal(txtMontoAnt.Text)
         .MontoOtro = ToDecimal(txtMontoOtroConIva.Text) + ToDecimal(txtMontoOtroSinIva.Text)
         .MontoCos = ToDecimal(txtMontoCos.Text)
         .MontoNet = ToDecimal(txtMontoNet.Text)
         .MontoLiq = ToDecimal(txtMontoLiq.Text)

         .FacturaDif = ToBoolean(chkFacturaDif.Checked)
         .TipoRetencionId = ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex)
         .FactDifExento = ToDecimal(txtFactDifExento.Text)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()
   End Sub

   Private Function DataSave() As Boolean
      Try
         txtMontoLiq.Select()

         Call DataMove()

         If FormCheck() Then
            If AnticipoCheck() Then
               'If MessageBox.Show("¿Realmente Quiere Guardar la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

               If mofrmCompraEdit.FormCheck Then
                  If mofrmCompraEdit.ItemSaldoCheck Then
                     If mofrmCompraEdit.ItemLoteCheckEliminados Then
                        If mofrmCompraEdit.ItemSaldoLoteCheck Then

                           If mboolAdding Then
                              If MessageBox.Show("¿Realmente Quiere Guardar la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                 DataSave = DataAdd()
                              End If
                           Else
                              If MessageBox.Show("La Edicion de la Compra modificará los costos en Inventario" & vbCrLf & "¿Realmente Quiere Guardar la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                 DataSave = DataUpdate()
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
               'End If
            Else
               If MessageBox.Show("Existen Anticipos Pendientes de Descargo Para este Proveedor" & vbCrLf & "¿Quiere Revisar los Mismos Antes de Guardar la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                  If mofrmCompraEdit.FormCheck Then
                     If mofrmCompraEdit.ItemSaldoCheck Then
                        If mofrmCompraEdit.ItemLoteCheckEliminados Then
                           If mofrmCompraEdit.ItemSaldoLoteCheck Then

                              If mboolAdding Then
                                 If MessageBox.Show("¿Realmente Quiere Guardar la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    DataSave = DataAdd()
                                 End If
                              Else
                                 If MessageBox.Show("La Edicion de la Compra modificará los costos en Inventario" & vbCrLf & "¿Realmente Quiere Guardar la Compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    DataSave = DataUpdate()
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If
               Else
                  tabMain.TabPages.Item("Anticipo").Selected = True
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim lngCompId As Long = 0

      Try
         DataAdd = False

         moCompra.CompraNro = CompraNroNext(2, moCompra.GestionId, moCompra.SucursalId)

         If moCompra.Update() Then 'Para Actualizar los Totales

            Call FacturaSave()
            Call PolizaSave()

            Call grdCompraOtroCostoSave()
            Call grdProrrateoSave()

            If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad
               If CompNewOtroCosto(lngTipoCompId, lngCompNro, lngCompId) Then 'Otros Costos Aplicables                  

                  'If PedCompraUpdate(moCompra.PedCompraId, moCompra.CompraId, getPedidoEstadoId(moCompra.PedCompraId)) Then 'Pedido de Compra a Estado Realizado
                  If AnticipoUpdate(moCompra.CompraId, 14) Then
                     DataAdd = True
                  End If
                  'End If

                  Call dtFacturaCompraOtroCosCompIdUpdate(lngTipoCompId, lngCompId)
               End If
            Else
               'If PedCompraUpdate(moCompra.PedCompraId, moCompra.CompraId, 14) Then 'Pedido de Compra a Estado Realizado
               If AnticipoUpdate(moCompra.CompraId, 14) Then
                  DataAdd = True
               End If
               'End If
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim lngCompId As Long

      Try
         DataUpdate = False

         If moCompra.Update() Then 'Para Actualizar los Totales

            Call FacturaSave()
            Call PolizaSave()

            Call grdCompraOtroCostoSave()
            Call grdProrrateoSave()

            If clsAppInfo.Inventario Then 'Adicion Integrado a Contabilidad

               lngCompId = CompraOtroCostoCompIdLoad()

               If lngCompId > 0 Then
                  Call CompEditOtroCosto(lngCompId, lngTipoCompId)
               Else
                  Call CompNewOtroCosto(lngTipoCompId, lngCompNro, lngCompId)
               End If

               Call dtFacturaCompraOtroCosCompIdUpdate(lngTipoCompId, lngCompId)

               If AnticipoUpdate(moCompra.CompraId, 14) Then
                  DataUpdate = True
               End If

            Else

               If AnticipoUpdate(moCompra.CompraId, 14) Then
                  DataUpdate = True
               End If
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim boolFac As Boolean
      Dim lngTipoRetencion As Long = ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex)

      ''If moCompra.MontoLiq < 0 Then
      ''   strMsg &= "Líquido Pagable Inválido" + vbCrLf
      ''End If

      If mboolAdding Or mboolEditing Then

         If ToDecimal(txtMontoLiq.Text) < 0 Then
            strMsg &= "Líquido Pagable Inválido" + vbCrLf
         End If

         If (ToDecimal(txtMontoAnt.Text) > 0) And (ToDecimal(txtMontoRetencion.Text) > 0) Then
            strMsg &= "No puede haber Retención Asume Proveedor con Descargos de Anticipo" + vbCrLf
         End If

         If moCompra.FacturaId <> 0 Then
            Dim decFacturaMonto, decFactDes As Decimal
            decFactDes = 0
            decFacturaMonto = FacturaMontoFind(moCompra.FacturaId, decFactDes)
            If moCompra.MonedaId = clsMoneda.BOLIVIANOS Then
               If (Math.Abs(moCompra.MontoOrg - decFacturaMonto) > 0.1) Then
                  strMsg &= "El Monto de la Compra es Diferente al Monto de la Factura" & vbCrLf
               End If

               If (Math.Abs(moCompra.MontoDes - decFactDes) > 0.1) Then
                  strMsg &= "El Monto Descuento de la Compra es Diferente al Descuento de la Factura" & vbCrLf
               End If

            ElseIf moCompra.MonedaId = clsMoneda.DOLARES Then
               If (Math.Abs((moCompra.MontoOrg * moCompra.TipoCambio) - decFacturaMonto) > 0.1) Then
                  strMsg &= "El Monto de la Compra es Diferente al Monto de la Factura" & vbCrLf
               End If

               If (Math.Abs((moCompra.MontoDes * moCompra.TipoCambio) - decFactDes) > 0.1) Then
                  strMsg &= "El Monto Descuento de la Compra es Diferente al Descuento de la Factura" & vbCrLf
               End If
            End If

            Dim lngFacturaDup As Long = DuplicateFacturaIdFind(moFactura.FacturaId, moFactura.FacturaNro, moFactura.NroAutorizacion)
            If (lngFacturaDup <> moFacturaOrg.FacturaId) And (lngFacturaDup > 0) Then
               strMsg &= "Factura Duplicada" & vbCrLf
            End If
         End If

         If moCompra.PolizaId <> 0 Then
            Dim lngPolizaDup As Long = DuplicatePolizaIdFind(moPoliza.PolizaId, moPoliza.PolizaNro)
            If (lngPolizaDup <> moPolizaOrg.PolizaId) And (lngPolizaDup > 0) Then
               strMsg &= "Poliza Duplicada" & vbCrLf
            End If
         End If

         If chkFacturaDif.Checked Then
            If (moCompra.MontoBru < ToDecimal(txtFactDifExento.Text)) Then  '' Si no es Difrerido y exigir Factura manual.
               strMsg &= "Monto Exento no debe ser mayor que la Compra" + vbCrLf
            End If

            If (moCompra.MontoBru < moCompra.MontoFac) Then  '' Si no es Difrerido y exigir Factura manual.
               strMsg &= "El Monto de la Compra es menor al Monto Facturado por Diferido " + vbCrLf
            End If

         End If

      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub CheckFormShow()
      If (Not mboolAdding) Then
         Dim strMsg As String = String.Empty

         If mboolErrorFacturaOtroCosto Then
            strMsg = "Error de Factura con Otros Costos" & vbCrLf
            tabMain.TabPages.Item("OtroCosto").Selected = True
         End If

         If (strMsg.Trim <> String.Empty) Then
            MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      End If

   End Sub

   Private Function AnticipoCheck() As Boolean
      Dim intCount As Integer

      AnticipoCheck = False

      ''If mboolAdding Or mboolEditing Then
      If mboolAdding And (ToDecimal(txtMontoRetencion.Text) = 0) Then '' Si hay retencion asume Proveedor no obligar a descargar anticipo
         If grdAnticipo.RowCount > 0 Then
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetCheckedRows
               If oRow.Cells("Sel").Value Then

                  intCount += 1

                  If (ToBoolean(oRow.Cells("SinFac").Value) <> moCompra.SinFac) Or (ToBoolean(oRow.Cells("ConFac").Value) <> moCompra.ConFac) Then
                     AnticipoCheck = False
                     Throw New Exception("No puede ser diferente (I y F) de la Compra con los Anticipos")
                  End If

               End If
            Next
         Else
            intCount = 1
         End If
      Else
         intCount = 1
      End If

      If intCount = 0 Then
         AnticipoCheck = False
      Else
         AnticipoCheck = True
      End If
   End Function

   Private Function AnticipoUpdate(ByVal lngCompraId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim lngProveedorMovId As Long

      AnticipoUpdate = True

      Try
         Call isCompFind(moCompra.CompId, lngTipoCompId, lngCompNro)
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetCheckedRows
            Dim lngAnticipoDetId As Long

            With oAnticipo
               .AnticipoId = ToLong(oRow.Cells("AnticipoId").Value)

               If .FindByPK Then
                  .Fecha = ToDate(.Fecha)
                  .MontoDes += ToDecimal(oRow.Cells("Monto").Value)

                  If .MontoAnt <= .MontoDes Then
                     .EstadoId = lngEstadoId 'Realizado
                  Else
                     .EstadoId = 13 'Pendiente
                  End If

                  If .Update() Then
                     If AnticipoDetAdd(.AnticipoId, 2, moCompra.CompraId, "Compra Nro. " & moCompra.CompraNro, .MonedaId, ToDecimal(oRow.Cells("Monto").Value), lngTipoCompId, lngCompNro, moCompra.PlanId, 11, lngAnticipoDetId) Then
                        ''If ProveedorMovAdd(lngProveedorMovId, 9, lngAnticipoDetId, 2, "Compra Nro. " & moCompra.CompraNro, ToDecimal(oRow.Cells("Monto").Value), 2, moCompra.TipoCompId, moCompra.CompNro, moCompra.PlanId) Then
                        If ProveedorMovAdd(lngProveedorMovId, 9, lngAnticipoDetId, 2, "Compra Nro. " & moCompra.CompraNro & "; " & moCompra.CompraDes, .MonedaId, ToDecimal(oRow.Cells("Monto").Value), 2, lngTipoCompId, lngCompNro, moCompra.PlanId) Then
                           AnticipoUpdate = True
                        End If
                     End If
                  End If
               End If
            End With
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipo.Dispose()

      End Try
   End Function

   Private Function AnticipoDetAdd(ByVal lngAnticipoId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal strDes As String, ByVal lngMonedaId As Long, ByVal decMonto As Decimal, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long, ByVal lngEstadoId As Long, _
                                    ByRef lngAnticipoDetId As Long) As Boolean

      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetAdd = False

      Try
         With oAnticipoDet
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .AnticipoId = lngAnticipoId
            .ProveedorId = moCompra.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .Fecha = moCompra.Fecha
            .AnticipoDetDes = strDes
            .MonedaId = lngMonedaId
            .TipoCambio = moCompra.TipoCambio
            .Monto = decMonto
            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .PlanId = lngPlanId
            .EstadoId = lngEstadoId

            If .Insert() Then
               AnticipoDetAdd = True
               lngAnticipoDetId = .AnticipoDetId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function AnticipoRestoreUpdate(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      Try
         AnticipoRestoreUpdate = True

         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId

            If .Open() Then
               Do While .Read()
                  With oAnticipo
                     .AnticipoId = oAnticipoDet.AnticipoId

                     If .FindByPK Then
                        .Fecha = ToDate(.Fecha)
                        .MontoDes -= oAnticipoDet.Monto
                        .EstadoId = 13 'Pendiente

                        If .Update() Then
                           If ProveedorMovDelete(9, oAnticipoDet.AnticipoDetId) Then
                              AnticipoRestoreUpdate = True
                           End If
                        End If
                     End If
                  End With

                  .MoveNext()
               Loop

               If AnticipoDetDelete(lngTipoCompraId, lngDocumentoId, 12) Then
                  AnticipoRestoreUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function AnticipoDetUpdate(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetUpdate = False

      Try
         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId

            If .Find Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = lngEstadoId

               If .Update Then
                  AnticipoDetUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function AnticipoDetDelete(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      AnticipoDetDelete = False

      Try
         With oAnticipoDet
            .SelectFilter = clsAnticipoDet.SelectFilters.All
            .WhereFilter = clsAnticipoDet.WhereFilters.DocumentoId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId

            If .Delete Then
               AnticipoDetDelete = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAnticipoDet.Dispose()

      End Try
   End Function

   Private Function ProveedorMovAdd(ByRef lngProveedorMovId As Long, ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, _
                                    ByVal lngTipoPagoId As Long, ByVal strDes As String, ByVal lngMonedaId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, _
                                    ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, ByVal lngPlanId As Long) As Boolean

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovAdd = False

      Try
         With oProveedorMov
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .ProveedorId = moCompra.ProveedorId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .TipoPagoId = lngTipoPagoId
            .Fecha = moCompra.Fecha
            .ProveedorMovDes = strDes
            .MonedaId = lngMonedaId
            .TipoCambio = moCompra.TipoCambio
            .CentroCostoId = moCompra.CentroCostoId
            .SucursalId = moCompra.SucursalId
            .EstadoId = 11 'Abierto

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeBs = decValor
                  .DebeUs = ToDecimal(decValor / .TipoCambio)

                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberBs = decValor
                  .HaberUs = ToDecimal(decValor / .TipoCambio)

                  .DebeBs = 0
                  .DebeUs = 0
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeBs = ToDecimal(decValor * .TipoCambio)
                  .DebeUs = decValor

                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberBs = ToDecimal(decValor * .TipoCambio)
                  .HaberUs = decValor

                  .DebeUs = 0
                  .DebeBs = 0
               End If
            End If

            .TipoCompId = lngTipoCompId
            .CompNro = lngCompNro
            .PlanId = lngPlanId

            If .Insert() Then
               lngProveedorMovId = .ProveedorMovId
               ProveedorMovAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function ProveedorMovDelete(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovDelete = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .EstadoId = 11 'Abierto

            If .Delete Then
               ProveedorMovDelete = True
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function ProveedorMovUpdate(ByVal lngTipoCompraId As Long, ByVal lngDocumentoId As Long, ByVal lngCol As Long, ByVal decValor As Decimal) As Boolean
      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)

      ProveedorMovUpdate = False

      Try
         With oProveedorMov
            .SelectFilter = clsProveedorMov.SelectFilters.All
            .WhereFilter = clsProveedorMov.WhereFilters.DocumentoId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .DocumentoId = lngDocumentoId
            .EstadoId = 11 'Abierto

            If .Find Then
               .Fecha = ToDate(.Fecha)

               If .MonedaId = 1 Then
                  If lngCol = 1 Then
                     .DebeBs = decValor
                     .DebeUs = ToDecimal(decValor / .TipoCambio)

                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberBs = decValor
                     .HaberUs = ToDecimal(decValor / .TipoCambio)

                     .DebeBs = 0
                     .DebeUs = 0
                  End If

               ElseIf .MonedaId = 2 Then
                  If lngCol = 1 Then
                     .DebeBs = ToDecimal(decValor * .TipoCambio)
                     .DebeUs = decValor

                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberBs = ToDecimal(decValor * .TipoCambio)
                     .HaberUs = decValor

                     .DebeUs = 0
                     .DebeBs = 0
                  End If
               End If

               If .Update() Then
                  ProveedorMovUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProveedorMov.Dispose()

      End Try
   End Function

   Private Function FacturaSave() As Boolean
      FacturaSave = False

      Try

         ''Eliminando la Anterior Factura eliminada
         If moFacturaOrg.FacturaId > 0 And (moFactura.FacturaId <> moFacturaOrg.FacturaId) Then
            moFacturaOrg.WhereFilter = clsFactura.WhereFilters.PrimaryKey

            If moFacturaOrg.Delete() Then
               FacturaDetDelete(moFacturaOrg.FacturaId)
            End If

         End If

         ''Guardando la Nueva o Editando la Factura
         If moCompra.FacturaId <> 0 Then
            If moFactura.FacturaId = 0 Then
               moFactura.FacturaFecha = ToDate(moFactura.FacturaFecha)
               moFactura.EstadoId = 11

               moFactura.SucursalIdOrg = moCompra.SucursalId
               moFactura.AppId = clsAppInfo.AppId
               moFactura.TipoDocumentoId = clsTipoCompra.COMPRA
               moFactura.DocumentoId = moCompra.CompraId

               If moFactura.Insert() Then
                  moCompra.FacturaId = moFactura.FacturaId
                  FacturaSave = True
               End If

            ElseIf (moFactura.FacturaId > 0) And (moFactura.EstadoId = 13) Then
               moFactura.FacturaFecha = ToDate(moFactura.FacturaFecha)
               moFactura.EstadoId = 11

               If moFactura.Update() Then
                  FacturaSave = True
               End If
            End If

         Else
            FacturaSave = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Function

   Private Function PolizaSave() As Boolean
      PolizaSave = False

      Try

         If moPolizaOrg.PolizaId > 0 And (moPoliza.PolizaId <> moPolizaOrg.PolizaId) Then
            moPolizaOrg.WhereFilter = clsPoliza.WhereFilters.PrimaryKey
            If moPolizaOrg.Delete() Then
               PolizaSave = True
            End If
         End If

         If moCompra.PolizaId <> 0 Then
            If moPoliza.PolizaId = 0 Then
               moPoliza.PolizaFecha = ToDate(moPoliza.PolizaFecha)
               moPoliza.EstadoId = 11
               If moPoliza.Insert() Then
                  moCompra.PolizaId = moPoliza.PolizaId
                  PolizaSave = True
               End If

            ElseIf (moPoliza.PolizaId > 0) And (moPoliza.EstadoId = 13) Then
               moPoliza.PolizaFecha = ToDate(moPoliza.PolizaFecha)
               moPoliza.EstadoId = 11
               If moPoliza.Update() Then
                  PolizaSave = True
               End If
            End If

         Else
            PolizaSave = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Function

   Private Function CompraNroNext(ByVal lngTipoCompraId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompraPara As New clsCompraPara(clsAppInfo.ConnectString)

      Try
         CompraNroNext = 0

         With oCompraPara
            .SelectFilter = clsCompraPara.SelectFilters.All
            .WhereFilter = clsCompraPara.WhereFilters.TipoCompraId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompraId = lngTipoCompraId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               .UpdateFilter = clsCompraPara.UpdateFilters.NroActual
               .NroActual = ToLong(.NroActual) + 1

               If .Update Then
                  CompraNroNext = .NroActual
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraPara.Dispose()

      End Try
   End Function

   Private Function grdCompraOtroCostoCount(ByRef strDes As String, ByVal boolFactura As Boolean) As Long
      Dim i As Long = 0

      For Each oRow As DataRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         If boolFactura Then
            If oRow("FacturaId") <> 0 Then
               i += 1
               strDes &= ToStr(oRow("PlanOtroCostoDes")) + "; "
            End If
         Else
            If oRow("FacturaId") = 0 Then
               i += 1
               strDes &= ToStr(oRow("PlanOtroCostoDes")) + "; "
            End If
         End If
      Next

      Return i
   End Function

   Private Function TipoPlanIdFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TipoPlanIdFind = 0

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               TipoPlanIdFind = .TipoPlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function TipoCompIdFind() As Long
      Dim lngTipoPlanId As Long

      For Each oRow As DataRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows

         lngTipoPlanId = TipoPlanIdFind(oRow("PlanId"))

         If (lngTipoPlanId = 2) Or (lngTipoPlanId = 3) Then
            Return 2 'Egreso
         End If
      Next
      Return 3 'Traspaso
   End Function

   Private Function CompraOtroCostoCompIdUpdate(ByVal lngCompraOtroCostoId As Long, ByVal lngCompId As Long) As Boolean
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)

      CompraOtroCostoCompIdUpdate = False

      Try
         With oCompraOtroCosto
            .CompraOtroCostoId = lngCompraOtroCostoId

            If .FindByPK Then
               .CompId = lngCompId
               .Fecha = ToDate(.Fecha)

               Return .Update()
            End If
         End With

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FacturaUpdate(ByVal lngFacturaId As Long, ByVal lngTipoCompId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      FacturaUpdate = False

      Try
         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               .TipoCompId = lngTipoCompId
               .CompId = lngCompId
               .CompDetId = lngCompDetId
               .FacturaFecha = ToDate(.FacturaFecha)

               Return .Update()
            End If
         End With

      Catch exp As Exception
         Throw exp


      Finally
         oFactura.Dispose()

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

   Private Function CompNewOtroCosto(ByRef lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long) As Boolean
      Dim oRow As DataRow
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal
      Dim decMontoIvaBs As Decimal
      Dim decMontoIvaUs As Decimal
      Dim decMontoIvaOrg As Decimal
      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0
      'Dim lngCompId As Long
      Dim lngCompDetId As Long

      Dim strDesConFac As String = ""
      Dim strDesSinFac As String = ""
      Dim lngCountConFac As Long = 0
      Dim lngCountSinFac As Long = 0

      Dim decTotalMontoBs As Decimal = 0
      Dim decTotalMontoUs As Decimal = 0
      Dim decTotalMontoOrg As Decimal = 0

      Dim lngPlanIdAct As Long

      Dim hstlista As New Hashtable

      CompNewOtroCosto = True

      Try
         lngCountConFac = grdCompraOtroCostoCount(strDesConFac, True)
         lngCountSinFac = grdCompraOtroCostoCount(strDesSinFac, False)

         If (lngCountConFac + lngCountSinFac) > 0 Then

            lngTipoCompId = TipoCompIdFind()

            If CompAdd(lngTipoCompId, lngCompNro, lngCompId, strDesSinFac + strDesConFac) Then 'Cabecera Comprobante

               'Otros Costos
               If lngCountSinFac > 0 Then 'Sin Facturas

                  For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
                     If oRow("FacturaId") = 0 Then
                        If moCompra.MonedaId = 1 Then
                           decMontoBs = ToDecimal(oRow("Monto"))
                           decMontoUs = ToDecimal(ToDecimal(oRow("Monto") / moCompra.TipoCambio))
                           decMontoOrg = decMontoBs
                           decTotalMontoBs += decMontoBs
                           decTotalMontoUs += decMontoUs
                           decTotalMontoOrg += decMontoOrg

                        ElseIf moCompra.MonedaId = 2 Then
                           decMontoBs = ToDecimal(ToDecimal(oRow("Monto") * moCompra.TipoCambio))
                           decMontoUs = ToDecimal(oRow("Monto"))
                           decMontoOrg = decMontoUs
                           decTotalMontoBs += decMontoBs
                           decTotalMontoUs += decMontoUs
                           decTotalMontoOrg += decMontoOrg
                        End If

                        If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdOtroCosto"), "; " & oRow("PlanOtroCostoDes") & ": " & oRow("CompraOtroCostoDes"), decMontoBs, decMontoUs, decMontoOrg, 1, moCompra.SucursalId, moCompra.CentroCostoId) Then
                           'Contra Cuenta
                           If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanId"), "; " & oRow("PlanOtroCostoDes") & ": " & oRow("CompraOtroCostoDes"), decMontoBs, decMontoUs, decMontoOrg, 2, oRow("SucursalId"), oRow("CentroCostoId"), lngCompDetId) Then 'Ponerle CompId

                              If oRow("PlanAddId") <> 0 Then  'Analitico Adicional
                                 If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanId"), oRow("PlanAddId"), decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                    CompNewOtroCosto = True
                                 End If
                              End If

                              If oRow("CentroCostoDetId") <> 0 Then  'Actividad
                                 If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanId"), oRow("CentroCostoId"), oRow("CentroCostoDetId"), decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                    CompNewOtroCosto = True
                                 End If
                              End If

                           End If

                           If CompraOtroCostoCompIdUpdate(oRow("CompraOtroCostoId"), lngCompId) Then
                              oRow("CompraOtroCostoId") = lngCompId
                              CompNewOtroCosto = True
                           End If
                        End If

                     End If
                  Next

               End If

               If lngCountConFac > 0 Then 'Con Facturas

                  For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
                     If oRow("FacturaId") <> 0 Then
                        If moCompra.MonedaId = 1 Then
                           decMontoBs = ToDecimal(oRow("Monto"))
                           decMontoUs = ToDecimal(ToDecimal(oRow("Monto") / moCompra.TipoCambio))
                           decMontoOrg = decMontoBs
                           ''decMontoIvaBs = decMontoBs - ToDecimal(decMontoBs * clsAppInfo.IVA)
                           ''decMontoIvaUs = decMontoUs - ToDecimal(decMontoUs * clsAppInfo.IVA)
                           ''decIvaBs += ToDecimal(decMontoBs * clsAppInfo.IVA)
                           ''decIvaUs += ToDecimal(decMontoUs * clsAppInfo.IVA)

                           decMontoIvaBs = FacturaOtroCostoIvaBsFind(oRow("CostoIdNro"), decMontoIvaUs, 0)
                           decIvaBs += decMontoIvaBs
                           decIvaUs += decMontoIvaUs
                           decIvaOrg = decIvaBs

                           decMontoIvaBs = decMontoBs - decMontoIvaBs
                           decMontoIvaUs = decMontoUs - decMontoIvaUs

                           decIvaOrg = decIvaBs
                           decTotalMontoBs += decMontoBs
                           decTotalMontoUs += decMontoUs
                           decTotalMontoOrg += decMontoOrg

                        ElseIf moCompra.MonedaId = 2 Then
                           decMontoBs = ToDecimal(ToDecimal(oRow("Monto") * moCompra.TipoCambio))
                           decMontoUs = ToDecimal(oRow("Monto"))
                           decMontoOrg = decMontoUs

                           decMontoIvaBs = FacturaOtroCostoIvaBsFind(oRow("CostoIdNro"), decMontoIvaUs, 0)
                           decIvaBs += decMontoIvaBs
                           decIvaUs += decMontoIvaUs
                           decIvaOrg = decIvaUs

                           decMontoIvaBs = decMontoBs - decMontoIvaBs
                           decMontoIvaUs = decMontoUs - decMontoIvaUs

                           decTotalMontoBs += decMontoBs
                           decTotalMontoUs += decMontoUs
                           decTotalMontoOrg += decMontoOrg
                        End If

                        If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdOtroCosto"), "; " & oRow("PlanOtroCostoDes") & ": " & oRow("CompraOtroCostoDes"), decMontoIvaBs, decMontoIvaUs, decMontoOrg, 1, moCompra.SucursalId, moCompra.CentroCostoId, lngCompDetId) Then

                           If FacturaUpdate(oRow("FacturaId"), lngTipoCompId, lngCompId, lngCompDetId) Then 'Ponerle CompId y CompDetId
                              CompNewOtroCosto = True
                           End If

                           If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanId"), oRow("PlanOtroCostoDes") & "; " & oRow("CompraOtroCostoDes"), decMontoBs, decMontoUs, decMontoOrg, 2, oRow("SucursalId"), oRow("CentroCostoId"), lngCompDetId) Then
                              CompNewOtroCosto = True

                              If oRow("PlanAddId") <> 0 Then  'Analitico Adicional
                                 If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanId"), oRow("PlanAddId"), decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                    CompNewOtroCosto = True
                                 End If
                              End If

                              If oRow("CentroCostoDetId") <> 0 Then  'Actividad
                                 If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanId"), oRow("CentroCostoId"), oRow("CentroCostoDetId"), decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                    CompNewOtroCosto = True
                                 End If
                              End If

                           End If

                           If CompraOtroCostoCompIdUpdate(oRow("CompraOtroCostoId"), lngCompId) Then 'Ponerle CompId
                              oRow("CompraOtroCostoId") = lngCompId
                              CompNewOtroCosto = True
                           End If

                        End If

                     End If
                  Next

                  If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "; " & oRow("PlanOtroCostoDes") & ": " & oRow("CompraOtroCostoDes"), decIvaBs, decIvaUs, decIvaOrg, 1, moCompra.SucursalId, moCompra.CentroCostoId, , 1) Then 'Cuenta de Credito Fiscal
                     CompNewOtroCosto = True
                  End If

               End If

               hstlista.Clear()

               'Balanceo de Otros Costos
               For Each oRow In moDataSet.Tables(moCompra.TableName).Rows
                  If oRow("ItemId") > 0 Then 'Para pasar la fila de totales
                     If moCompra.MonedaId = 1 Then
                        decMontoBs = ToDecimal(oRow("Costo"))
                        decMontoUs = ToDecimal(ToDecimal(oRow("Costo") / moCompra.TipoCambio))
                        decMontoOrg = decMontoBs
                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg

                     ElseIf moCompra.MonedaId = 2 Then
                        decMontoBs = ToDecimal(ToDecimal(oRow("Costo") * moCompra.TipoCambio))
                        decMontoUs = ToDecimal(oRow("Costo"))
                        decMontoOrg = decMontoUs
                        decTotalMontoBs += decMontoBs
                        decTotalMontoUs += decMontoUs
                        decTotalMontoOrg += decMontoOrg
                     End If

                     lngPlanIdAct = PlanIdActFind(oRow("ItemId"))

                     If Not hstlista.Contains(lngPlanIdAct) Then
                        If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 1, moCompra.SucursalId, moCompra.CentroCostoId, lngCompDetId) Then
                           hstlista.Add(lngPlanIdAct, lngCompDetId)
                           CompNewOtroCosto = True
                        End If
                     Else
                        lngCompDetId = hstlista.Item(lngPlanIdAct)

                        If CompDetIdFind(lngCompDetId, 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
                           If CompDetUpdate(lngCompDetId, "", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then
                              CompNewOtroCosto = True
                           End If
                        End If
                     End If

                  End If
               Next

               hstlista.Clear()

               If lngCountSinFac > 0 Then 'Sin Factura Contra cuentas

                  For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
                     If oRow("FacturaId") = 0 Then
                        If moCompra.MonedaId = 1 Then
                           decMontoBs = ToDecimal(oRow("Monto"))
                           decMontoUs = ToDecimal(ToDecimal(oRow("Monto") / moCompra.TipoCambio))
                           decMontoOrg = decMontoBs

                        ElseIf moCompra.MonedaId = 2 Then
                           decMontoBs = ToDecimal(ToDecimal(oRow("Monto") * moCompra.TipoCambio))
                           decMontoUs = ToDecimal(oRow("Monto"))
                           decMontoOrg = decMontoUs
                        End If

                        If Not hstlista.Contains(oRow("PlanIdOtroCosto")) Then
                           If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdOtroCosto"), oRow("PlanOtroCostoDes") & "; ", decMontoBs, decMontoUs, decMontoOrg, 2, moCompra.SucursalId, moCompra.CentroCostoId, lngCompDetId) Then
                              hstlista.Add(oRow("PlanIdOtroCosto"), lngCompDetId)
                              CompNewOtroCosto = True
                           End If
                        Else
                           lngCompDetId = hstlista.Item(oRow("PlanIdOtroCosto"))

                           If CompDetIdFind(lngCompDetId, 2, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
                              If CompDetUpdate(lngCompDetId, oRow("PlanOtroCostoDes") & "; ", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 2) Then
                                 CompNewOtroCosto = True
                              End If
                           End If
                        End If

                     End If
                  Next
               End If

               If lngCountConFac > 0 Then 'Con Factura Contra cuentas

                  For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
                     If oRow("FacturaId") <> 0 Then
                        If moCompra.MonedaId = 1 Then
                           decMontoBs = ToDecimal(oRow("Monto"))
                           decMontoUs = ToDecimal(ToDecimal(oRow("Monto") / moCompra.TipoCambio))
                           decMontoOrg = decMontoBs

                           decMontoIvaBs = FacturaOtroCostoIvaBsFind(oRow("CostoIdNro"), decMontoIvaUs, 0)
                           decIvaBs += decMontoIvaBs
                           decIvaUs += decMontoIvaUs
                           decIvaOrg = decIvaBs

                           decMontoIvaBs = decMontoBs - decMontoIvaBs
                           decMontoIvaUs = decMontoUs - decMontoIvaUs
                           decMontoIvaOrg = decMontoIvaBs

                        ElseIf moCompra.MonedaId = 2 Then
                           decMontoBs = ToDecimal(ToDecimal(oRow("Monto") * moCompra.TipoCambio))
                           decMontoUs = ToDecimal(oRow("Monto"))
                           decMontoOrg = decMontoUs

                           decMontoIvaBs = FacturaOtroCostoIvaBsFind(oRow("CostoIdNro"), decMontoIvaUs, 0)
                           decIvaBs += decMontoIvaBs
                           decIvaUs += decMontoIvaUs
                           decIvaOrg = decIvaUs

                           decMontoIvaBs = decMontoBs - decMontoIvaBs
                           decMontoIvaUs = decMontoUs - decMontoIvaUs
                           decMontoIvaOrg = decMontoIvaUs
                        End If


                        If Not hstlista.Contains(oRow("PlanIdOtroCosto")) Then
                           If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdOtroCosto"), oRow("PlanOtroCostoDes") & "; ", decMontoIvaBs, decMontoIvaUs, decMontoIvaOrg, 2, moCompra.SucursalId, moCompra.CentroCostoId, lngCompDetId) Then
                              hstlista.Add(oRow("PlanIdOtroCosto"), lngCompDetId)
                              CompNewOtroCosto = True
                           End If
                        Else
                           lngCompDetId = hstlista.Item(oRow("PlanIdOtroCosto"))

                           If CompDetIdFind(lngCompDetId, 2, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
                              If CompDetUpdate(lngCompDetId, oRow("PlanOtroCostoDes") & "; ", decMontoIvaBs + decMontoBsOld, decMontoIvaUs + decMontoUsOld, decMontoIvaOrg + decMontoOrgOld, 2) Then
                                 CompNewOtroCosto = True
                              End If
                           End If
                        End If

                     End If
                  Next
               End If

               If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then 'Totales del Comp
                  If CompUpdate(lngCompId, decTotalMontoBs, decTotalMontoUs, strDesSinFac + strDesConFac) Then
                     CompNewOtroCosto = True
                  End If
               End If

            End If
         Else
            If mlngCompIdOtrosCosto > 0 Then
               If CompAnular(mlngCompIdOtrosCosto) Then 'Anular  Comprobante
                  If CompDetDeleteAll(mlngCompIdOtrosCosto) Then 'Elimina el detalle del Comprobante
                     CompNewOtroCosto = True
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompEditOtroCosto(ByVal lngCompId As Long, ByRef lngTipoCompId As Long) As Boolean
      Dim oRow As DataRow
      Dim decMontoBs As Decimal
      Dim decMontoUs As Decimal
      Dim decMontoOrg As Decimal
      Dim decMontoIvaBs As Decimal
      Dim decMontoIvaUs As Decimal
      Dim decMontoIvaOrg As Decimal
      Dim decIvaBs As Decimal = 0
      Dim decIvaUs As Decimal = 0
      Dim decIvaOrg As Decimal = 0
      Dim decMontoBsOld As Decimal = 0
      Dim decMontoUsOld As Decimal = 0
      Dim decMontoOrgOld As Decimal = 0
      Dim lngCompDetId As Long
      ''Dim lngTipoCompId As Long
      Dim lngCompNro As Long
      Dim strDesConFac As String = ""
      Dim strDesSinFac As String = ""
      Dim lngCountConFac As Long = 0
      Dim lngCountSinFac As Long = 0

      Dim decTotalMontoBs As Decimal = 0
      Dim decTotalMontoUs As Decimal = 0
      Dim decTotalMontoOrg As Decimal = 0

      Dim lngPlanIdAct As Long

      Dim hstlista As New Hashtable

      CompEditOtroCosto = True

      Try

         lngCountConFac = grdCompraOtroCostoCount(strDesConFac, True)
         lngCountSinFac = grdCompraOtroCostoCount(strDesSinFac, False)

         If CompFind(lngCompId, lngTipoCompId, lngCompNro) Then 'Cargando Datos del Comprobante
            If (lngCountConFac + lngCountSinFac) > 0 Then
               If CompDetDeleteAll(lngCompId) Then 'Elimina el detalle del Comprobante
                  'Otros Costos
                  If lngCountSinFac > 0 Then 'Sin Facturas

                     For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
                        If oRow("FacturaId") = 0 Then
                           If moCompra.MonedaId = 1 Then
                              decMontoBs = ToDecimal(oRow("Monto"))
                              decMontoUs = ToDecimal(ToDecimal(oRow("Monto") / moCompra.TipoCambio))
                              decMontoOrg = decMontoBs
                              decTotalMontoBs += decMontoBs
                              decTotalMontoUs += decMontoUs
                              decTotalMontoOrg += decMontoOrg

                           ElseIf moCompra.MonedaId = 2 Then
                              decMontoBs = ToDecimal(ToDecimal(oRow("Monto") * moCompra.TipoCambio))
                              decMontoUs = ToDecimal(oRow("Monto"))
                              decMontoOrg = decMontoUs
                              decTotalMontoBs += decMontoBs
                              decTotalMontoUs += decMontoUs
                              decTotalMontoOrg += decMontoOrg
                           End If

                           If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdOtroCosto"), "; " & oRow("PlanOtroCostoDes") & ": " & oRow("CompraOtroCostoDes"), decMontoBs, decMontoUs, decMontoOrg, 1, moCompra.SucursalId, moCompra.CentroCostoId) Then
                              If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanId"), "; " & oRow("PlanOtroCostoDes") & ": " & oRow("CompraOtroCostoDes"), decMontoBs, decMontoUs, decMontoOrg, 2, oRow("SucursalId"), oRow("CentroCostoId"), lngCompDetId) Then 'Ponerle CompId
                                 CompEditOtroCosto = True

                                 If oRow("PlanAddId") <> 0 Then  'Analitico Adicional
                                    If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanId"), oRow("PlanAddId"), decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                       CompEditOtroCosto = True
                                    End If
                                 End If

                                 If oRow("CentroCostoDetId") <> 0 Then  'Actividad
                                    If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanId"), oRow("CentroCostoId"), oRow("CentroCostoDetId"), decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                       CompEditOtroCosto = True
                                    End If
                                 End If

                              End If

                              If CompraOtroCostoCompIdUpdate(oRow("CompraOtroCostoId"), lngCompId) Then
                                 oRow("CompraOtroCostoId") = lngCompId
                                 CompEditOtroCosto = True
                              End If
                           End If
                        End If
                     Next
                  End If

                  If lngCountConFac > 0 Then 'Con Facturas

                     For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
                        If oRow("FacturaId") <> 0 Then
                           If moCompra.MonedaId = 1 Then
                              decMontoBs = ToDecimal(oRow("Monto"))
                              decMontoUs = ToDecimal(ToDecimal(oRow("Monto") / moCompra.TipoCambio))
                              decMontoOrg = decMontoBs
                              ''decMontoIvaBs = decMontoBs - ToDecimal(decMontoBs * clsAppInfo.IVA)
                              ''decMontoIvaUs = decMontoUs - ToDecimal(decMontoUs * clsAppInfo.IVA)
                              ''decIvaBs += ToDecimal(decMontoBs * clsAppInfo.IVA)
                              ''decIvaUs += ToDecimal(decMontoUs * clsAppInfo.IVA)
                              ''decIvaOrg = decIvaBs

                              decMontoIvaBs = FacturaOtroCostoIvaBsFind(oRow("CostoIdNro"), decMontoIvaUs, 0)
                              decIvaBs += decMontoIvaBs
                              decIvaUs += decMontoIvaUs
                              decIvaOrg = decIvaBs

                              decMontoIvaBs = decMontoBs - decMontoIvaBs
                              decMontoIvaUs = decMontoUs - decMontoIvaUs

                              decTotalMontoBs += decMontoBs
                              decTotalMontoUs += decMontoUs
                              decTotalMontoOrg += decMontoOrg

                           ElseIf moCompra.MonedaId = 2 Then
                              decMontoBs = ToDecimal(ToDecimal(oRow("Monto") * moCompra.TipoCambio))
                              decMontoUs = ToDecimal(oRow("Monto"))
                              decMontoOrg = decMontoUs


                              decMontoIvaBs = FacturaOtroCostoIvaBsFind(oRow("CostoIdNro"), decMontoIvaUs, 0)
                              decIvaBs += decMontoIvaBs
                              decIvaUs += decMontoIvaUs
                              decIvaOrg = decIvaUs

                              decMontoIvaBs = decMontoBs - decMontoIvaBs
                              decMontoIvaUs = decMontoUs - decMontoIvaUs

                              decTotalMontoBs += decMontoBs
                              decTotalMontoUs += decMontoUs
                              decTotalMontoOrg += decMontoOrg
                           End If

                           If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdOtroCosto"), "; " & oRow("PlanOtroCostoDes") & ": " & oRow("CompraOtroCostoDes"), decMontoIvaBs, decMontoIvaUs, decMontoOrg, 1, moCompra.SucursalId, moCompra.CentroCostoId, lngCompDetId) Then

                              If FacturaUpdate(oRow("FacturaId"), lngTipoCompId, lngCompId, lngCompDetId) Then 'Ponerle CompId y CompDetId
                                 CompEditOtroCosto = True
                              End If

                              If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanId"), oRow("PlanOtroCostoDes") & "; " & oRow("CompraOtroCostoDes"), decMontoBs, decMontoUs, decMontoOrg, 2, oRow("SucursalId"), oRow("CentroCostoId"), lngCompDetId) Then
                                 CompEditOtroCosto = True
                                 If oRow("PlanAddId") <> 0 Then  'Analitico Adicional
                                    If CompPlanAddAdd(lngCompId, lngCompDetId, oRow("PlanId"), oRow("PlanAddId"), decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                       CompEditOtroCosto = True
                                    End If
                                 End If

                                 If oRow("CentroCostoDetId") <> 0 Then  'Actividad
                                    If CompCentroCostoDetAdd(lngCompId, lngCompDetId, oRow("PlanId"), oRow("CentroCostoId"), oRow("CentroCostoDetId"), decMontoBs, decMontoUs, 2, moCompra.SucursalId) Then
                                       CompEditOtroCosto = True
                                    End If
                                 End If

                              End If

                              If CompraOtroCostoCompIdUpdate(oRow("CompraOtroCostoId"), lngCompId) Then 'Ponerle CompId
                                 oRow("CompraOtroCostoId") = lngCompId
                                 CompEditOtroCosto = True
                              End If

                           End If
                        End If
                     Next

                     If CompDetAdd(lngTipoCompId, lngCompId, clsAppInfo.PlanCreId, "; " & oRow("PlanOtroCostoDes") & ": " & oRow("CompraOtroCostoDes"), decIvaBs, decIvaUs, decIvaOrg, 1, moCompra.SucursalId, moCompra.CentroCostoId, , 1) Then 'Cuenta de Credito Fiscal
                        CompEditOtroCosto = True
                     End If
                  End If

                  hstlista.Clear()

                  'Balanceo de Otros Costos
                  For Each oRow In moDataSet.Tables(moCompra.TableName).Rows
                     If oRow("ItemId") > 0 Then 'Para pasar la fila de totales
                        If moCompra.MonedaId = 1 Then
                           decMontoBs = ToDecimal(oRow("Costo"))
                           decMontoUs = ToDecimal(ToDecimal(oRow("Costo") / moCompra.TipoCambio))
                           decMontoOrg = decMontoBs
                           decTotalMontoBs += decMontoBs
                           decTotalMontoUs += decMontoUs
                           decTotalMontoOrg += decMontoOrg

                        ElseIf moCompra.MonedaId = 2 Then
                           decMontoBs = ToDecimal(ToDecimal(oRow("Costo") * moCompra.TipoCambio))
                           decMontoUs = ToDecimal(oRow("Costo"))
                           decMontoOrg = decMontoUs
                           decTotalMontoBs += decMontoBs
                           decTotalMontoUs += decMontoUs
                           decTotalMontoOrg += decMontoOrg
                        End If

                        lngPlanIdAct = PlanIdActFind(oRow("ItemId"))

                        If Not hstlista.Contains(lngPlanIdAct) Then
                           If CompDetAdd(lngTipoCompId, lngCompId, lngPlanIdAct, "", decMontoBs, decMontoUs, decMontoOrg, 1, moCompra.SucursalId, moCompra.CentroCostoId, lngCompDetId) Then
                              hstlista.Add(lngPlanIdAct, lngCompDetId)
                              CompEditOtroCosto = True
                           End If
                        Else
                           lngCompDetId = hstlista.Item(lngPlanIdAct)

                           If CompDetIdFind(lngCompDetId, 1, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
                              If CompDetUpdate(lngCompDetId, "", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 1) Then
                                 CompEditOtroCosto = True
                              End If
                           End If
                        End If

                     End If
                  Next

                  hstlista.Clear()

                  If lngCountSinFac > 0 Then 'Sin Factura Contra cuentas
                     For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
                        If oRow("FacturaId") = 0 Then
                           If moCompra.MonedaId = 1 Then
                              decMontoBs = ToDecimal(oRow("Monto"))
                              decMontoUs = ToDecimal(ToDecimal(oRow("Monto") / moCompra.TipoCambio))
                              decMontoOrg = decMontoBs

                           ElseIf moCompra.MonedaId = 2 Then
                              decMontoBs = ToDecimal(ToDecimal(oRow("Monto") * moCompra.TipoCambio))
                              decMontoUs = ToDecimal(oRow("Monto"))
                              decMontoOrg = decMontoUs
                           End If

                           If Not hstlista.Contains(oRow("PlanIdOtroCosto")) Then
                              If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdOtroCosto"), oRow("PlanOtroCostoDes") & "; ", decMontoBs, decMontoUs, decMontoOrg, 2, moCompra.SucursalId, moCompra.CentroCostoId, lngCompDetId) Then
                                 hstlista.Add(oRow("PlanIdOtroCosto"), lngCompDetId)
                                 CompEditOtroCosto = True
                              End If
                           Else
                              lngCompDetId = hstlista.Item(oRow("PlanIdOtroCosto"))

                              If CompDetIdFind(lngCompDetId, 2, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
                                 If CompDetUpdate(lngCompDetId, oRow("PlanOtroCostoDes") & "; ", decMontoBs + decMontoBsOld, decMontoUs + decMontoUsOld, decMontoOrg + decMontoOrgOld, 2) Then
                                    CompEditOtroCosto = True
                                 End If
                              End If
                           End If

                        End If
                     Next
                  End If

                  If lngCountConFac > 0 Then 'Con Factura Contra cuentas
                     For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
                        If oRow("FacturaId") <> 0 Then
                           If moCompra.MonedaId = 1 Then
                              decMontoBs = ToDecimal(oRow("Monto"))
                              decMontoUs = ToDecimal(ToDecimal(oRow("Monto") / moCompra.TipoCambio))
                              decMontoOrg = decMontoBs

                              decMontoIvaBs = FacturaOtroCostoIvaBsFind(oRow("CostoIdNro"), decMontoIvaUs, 0)

                              decIvaBs += decMontoIvaBs
                              decIvaUs += decMontoIvaUs
                              decIvaOrg = decIvaBs

                              decMontoIvaBs = decMontoBs - decMontoIvaBs
                              decMontoIvaUs = decMontoUs - decMontoIvaUs
                              decMontoIvaOrg = decMontoIvaBs

                           ElseIf moCompra.MonedaId = 2 Then
                              decMontoBs = ToDecimal(ToDecimal(oRow("Monto") * moCompra.TipoCambio))
                              decMontoUs = ToDecimal(oRow("Monto"))
                              decMontoOrg = decMontoUs

                              decMontoIvaBs = FacturaOtroCostoIvaBsFind(oRow("CostoIdNro"), decMontoIvaUs, 0)
                              decIvaBs += decMontoIvaBs
                              decIvaUs += decMontoIvaUs
                              decIvaOrg = decIvaUs

                              decMontoIvaBs = decMontoBs - decMontoIvaBs
                              decMontoIvaUs = decMontoUs - decMontoIvaUs
                              decMontoIvaOrg = decMontoIvaUs

                           End If

                           If Not hstlista.Contains(oRow("PlanIdOtroCosto")) Then
                              If CompDetAdd(lngTipoCompId, lngCompId, oRow("PlanIdOtroCosto"), oRow("PlanOtroCostoDes") & "; ", decMontoIvaBs, decMontoIvaUs, decMontoIvaOrg, 2, moCompra.SucursalId, moCompra.CentroCostoId, lngCompDetId) Then
                                 hstlista.Add(oRow("PlanIdOtroCosto"), lngCompDetId)
                                 CompEditOtroCosto = True
                              End If
                           Else
                              lngCompDetId = hstlista.Item(oRow("PlanIdOtroCosto"))

                              If CompDetIdFind(lngCompDetId, 2, decMontoBsOld, decMontoUsOld, decMontoOrgOld) Then
                                 If CompDetUpdate(lngCompDetId, oRow("PlanOtroCostoDes") & "; ", decMontoIvaBs + decMontoBsOld, decMontoIvaUs + decMontoUsOld, decMontoIvaOrg + decMontoOrgOld, 2) Then
                                    CompEditOtroCosto = True
                                 End If
                              End If
                           End If

                        End If
                     Next
                  End If

                  If (decTotalMontoBs > 0) And (decTotalMontoUs > 0) Then 'Totales del Comp
                     If CompUpdate(lngCompId, decTotalMontoBs, decTotalMontoUs, strDesSinFac + strDesConFac) Then
                        CompEditOtroCosto = True
                     End If
                  End If

               End If
            End If
         Else
            If mlngCompIdOtrosCosto > 0 Then
               If CompAnular(mlngCompIdOtrosCosto) Then 'Anular  Comprobante
                  If CompDetDeleteAll(mlngCompIdOtrosCosto) Then 'Elimina el detalle del Comprobante
                     CompEditOtroCosto = True
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function CompAdd(ByVal lngTipoCompId As Long, ByRef lngCompNro As Long, ByRef lngCompId As Long, ByVal strDes As String) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoCompId = lngTipoCompId
            .CompNro = CompNroNext(.TipoCompId, moCompra.GestionId, moCompra.SucursalId)
            .Fecha = moCompra.Fecha
            .MonedaId = moCompra.MonedaId
            .TipoCambio = moCompra.TipoCambio
            .EntregadoA = "Otros Costos : " + strDes
            .PorConcepto = "Nota de Compra Nro. " + ToStr(moCompra.CompraNro)
            .DebeBs = 0
            .HaberBs = 0
            .DebeUs = 0
            .HaberUs = 0
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF
            .Automatico = 0
            .Glosa = ""
            .TipoAsientoId = 0
            .EstadoId = 10
            .ConFac = moCompra.ConFac
            .SinFac = moCompra.SinFac

            .SucursalId = moCompra.SucursalId
            .NotaId = moCompra.NotaId
            .AppId = clsAppInfo.AppId
            .TipoDocumentoId = clsTipoCompra.COMPRA
            .DocumentoId = moCompra.CompraId


            If .Insert() Then
               lngCompId = .CompId
               lngCompNro = .CompNro

               CompAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompUpdate(ByVal lngCompId As Long, ByVal decTotalBs As Decimal, ByVal decTotalUs As Decimal, ByVal strDes As String) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompUpdate = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               .DebeBs = decTotalBs
               .HaberBs = decTotalBs
               .DebeUs = decTotalUs
               .HaberUs = decTotalUs
               .Fecha = ToDate(.Fecha)
               .EntregadoA = "Otros Costos : " + strDes
               .EstadoId = 10

               If .Update Then
                  CompUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompAnular(ByVal lngCompId As Long) As Boolean

      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAnular = False

      Try
         With oComp

            .CompId = lngCompId
            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = 12 'Anulado

               If .Update Then
                  CompAnular = True
               End If
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetAdd(ByVal lngTipoCompId As Long, ByVal lngCompId As Long, ByVal lngPlanId As Long, _
                              ByVal strDes As String, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, _
                              ByVal decValorOrg As Decimal, ByVal lngCol As Long, Optional ByVal lngSucursalId As Long = 0, _
                              Optional ByVal lngCentroCostoId As Long = 0, Optional ByRef lngCompDetId As Long = 0, _
                              Optional ByVal bytAutomatico As Byte = 0) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .TipoCompId = lngTipoCompId
            .Fecha = moCompra.Fecha
            .PlanId = lngPlanId
            .CompDetDes = ToStr("Nota de Compra Nro. " + ToStr(moCompra.CompraNro) + " " + strDes)
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .MonedaId = moCompra.MonedaId
            .EstadoId = 10

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorOrg
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorOrg
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeBs = 0
                  .DebeUs = 0
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorOrg
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorOrg
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeUs = 0
                  .DebeBs = 0
               End If
            End If

            .Orden = 0
            .Automatico = bytAutomatico
            .TipoRetencionId = 0
            .EstadoId = 10

            If .Insert() Then
               lngCompDetId = .CompDetId
               CompDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompDetUpdate(ByVal lngCompDetId As Long, ByVal strDes As String, ByVal decValorBs As Decimal, _
                                 ByVal decValorUs As Decimal, ByVal decValorOrg As Decimal, ByVal lngCol As Long) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetUpdate = False

      Try
         With oCompDet
            .CompDetId = lngCompDetId

            If .FindByPK Then
               If .MonedaId = 1 Then
                  If lngCol = 1 Then
                     .DebeOrg = decValorOrg
                     .DebeBs = decValorBs
                     .DebeUs = decValorUs

                     .HaberOrg = 0
                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberOrg = decValorOrg
                     .HaberBs = decValorBs
                     .HaberUs = decValorUs

                     .DebeOrg = 0
                     .DebeBs = 0
                     .DebeUs = 0
                  End If

               ElseIf .MonedaId = 2 Then
                  If lngCol = 1 Then
                     .DebeOrg = decValorOrg
                     .DebeBs = decValorBs
                     .DebeUs = decValorUs

                     .HaberOrg = 0
                     .HaberBs = 0
                     .HaberUs = 0

                  ElseIf lngCol = 2 Then
                     .HaberOrg = decValorOrg
                     .HaberBs = decValorBs
                     .HaberUs = decValorUs

                     .DebeOrg = 0
                     .DebeUs = 0
                     .DebeBs = 0
                  End If
               End If

               .CompDetDes = ToStr(.CompDetDes + " " + strDes)
               .Fecha = ToDate(.Fecha)

               If .Update() Then
                  CompDetUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompDetDeleteAll(ByVal lngCompId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompDetDeleteAll = False

      Try
         With oCompDet
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .CompId = lngCompId
            .EmpresaId = moCompra.EmpresaId

            If .Delete Then    'Del Detalle Comprobante
               With oCompPlanAdd
                  .WhereFilter = clsCompPlanAdd.WhereFilters.CompId
                  .CompId = lngCompId
                  .EmpresaId = moCompra.EmpresaId

                  Call .Delete()   'Del Analitico Adicional
               End With


               With oCompCentroCostoDet  'Delete Actividades

                  .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
                  .CompId = lngCompId
                  .EmpresaId = moCompra.EmpresaId

                  Call .Delete()   'Delete Actividad
               End With


            End If
         End With

         CompDetDeleteAll = True

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()
         oCompPlanAdd.Dispose()
      End Try
   End Function

   Private Function CompFind(ByVal lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)



      CompFind = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               lngTipoCompId = .TipoCompId
               lngCompNro = .CompNro
               CompFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function isCompFind(ByVal lngCompId As Long, ByRef lngTipoCompId As Long, ByRef lngCompNro As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      isCompFind = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               lngTipoCompId = .TipoCompId
               lngCompNro = .CompNro

               isCompFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetFind(ByVal lngCompId As Long, ByRef lngCompDetId As Long, ByVal lngPlanId As Long, _
                               ByVal lngCol As Long, ByRef decValorBs As Decimal, ByRef decValorUs As Decimal, _
                               ByRef decValorOrg As Decimal) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetFind = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompId = lngCompId
            .PlanId = lngPlanId

            If .Find Then
               If lngCol = 1 Then
                  If .DebeOrg = 0 Then
                     Return False
                  End If

               ElseIf lngCol = 2 Then
                  If .HaberOrg = 0 Then
                     Return False
                  End If
               End If

               lngCompDetId = .CompDetId

               If lngCol = 1 Then
                  decValorOrg = .DebeOrg
                  decValorBs = .DebeBs
                  decValorUs = .DebeUs

               ElseIf lngCol = 2 Then
                  decValorOrg = .HaberOrg
                  decValorBs = .HaberBs
                  decValorUs = .HaberUs
               End If

               CompDetFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            .SucursalId = lngSucursalId

            If .Find Then
               If ToBoolean(.NroAuto) Then
                  If ToBoolean(.NroAutoGestion) Then
                     .UpdateFilter = clsCompPara.UpdateFilters.NroActual

                     If Not clsAppInfo.MultipleNro Then
                        .NroActual = .NroActual + 1

                        If .Update Then
                           CompNroNext = .NroActual
                        End If

                     Else
                        If mboolConFac Then
                           .NroActualFis = .NroActualFis + 1

                           If .Update Then
                              CompNroNext = .NroActualFis
                           End If

                        Else
                           .NroActual = .NroActual + 1

                           If .Update Then
                              CompNroNext = .NroActual
                           End If
                        End If
                     End If
                  Else
                     CompNroNext = CompNroMesNext(lngTipoCompId, lngGestionId, lngSucursalId, mdatFecha.Month)
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function

   Private Function CompNroMesNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal lngSucursalId As Long, ByVal intMesId As Integer) As Long
      Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)

      Try
         CompNroMesNext = 0

         With oCompParaMes
            .SelectFilter = clsCompParaMes.SelectFilters.All
            .WhereFilter = clsCompParaMes.WhereFilters.MesId
            .EmpresaId = moCompra.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            .MesId = intMesId
            .SucursalId = lngSucursalId

            If .Find Then
               .UpdateFilter = clsCompParaMes.UpdateFilters.NroActual

               If Not clsAppInfo.MultipleNro Then
                  .NroActual = .NroActual + 1

                  If .Update Then
                     CompNroMesNext = .NroActual
                  End If

               Else
                  If mboolConFac Then
                     .NroActualFis = .NroActualFis + 1

                     If .Update Then
                        CompNroMesNext = .NroActualFis
                     End If

                  Else
                     .NroActual = .NroActual + 1

                     If .Update Then
                        CompNroMesNext = .NroActual
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompParaMes.Dispose()

      End Try
   End Function

   Private Function CompDetIdFind(ByVal lngCompDetId As Long, ByVal lngCol As Long, ByRef decValorBs As Decimal, ByRef decValorUs As Decimal, _
                            ByRef decValorOrg As Decimal) As Boolean

      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetIdFind = False

      Try
         With oCompDet

            .CompDetId = lngCompDetId

            If .FindByPK Then
               If lngCol = 1 Then
                  If .DebeOrg = 0 Then
                     Return False
                  End If

               ElseIf lngCol = 2 Then
                  If .HaberOrg = 0 Then
                     Return False
                  End If
               End If

               If lngCol = 1 Then
                  decValorOrg = .DebeOrg
                  decValorBs = .DebeBs
                  decValorUs = .DebeUs

               ElseIf lngCol = 2 Then
                  decValorOrg = .HaberOrg
                  decValorBs = .HaberBs
                  decValorUs = .HaberUs
               End If

               CompDetIdFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                                ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAdd = False

      Try
         With oCompPlanAdd
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moCompra.Fecha
            .PlanId = lngPlanId
            .MonedaId = moCompra.MonedaId
            .PlanAddId = lngPlanAddId
            .SucursalId = lngSucursalId
            .EstadoId = 10

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorBs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorUs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If
            End If

            .EstadoId = 10

            If .Insert() Then
               CompPlanAddAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, _
                               ByVal lngCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, _
                                 ByVal lngSucursalId As Long) As Boolean

      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetAdd = False

      Try
         With oCompCentroCostoDet
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = moCompra.Fecha
            .PlanId = lngPlanId
            .MonedaId = moCompra.MonedaId
            .CentroCostoId = lngCentroCostoId
            .CentroCostoDetId = lngCentroCostoDetId
            .SucursalId = lngSucursalId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorBs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorUs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If
            End If

            .EstadoId = 10

            If .Insert() Then
               CompCentroCostoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompraFacturasDifFind(ByVal lngCompraId As Long) As Boolean
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)

      Try
         With oCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.All
            .WhereFilter = clsCompraFac.WhereFilters.CompraId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = lngCompraId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraFac.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtMontoAnt.FormatString = DecimalMask()
      txtMontoOtroConIva.FormatString = DecimalMask()
      txtMontoOtroSinIva.FormatString = DecimalMask()
      txtFacturaIVA.FormatString = DecimalMask()
      txtPolizaIVA.FormatString = DecimalMask()

      txtMontoRec.FormatString = DecimalMask()
      txtMontoDes.FormatString = DecimalMask()

      txtMontoLiq.FormatString = DecimalMask()
      txtMontoOrg.FormatString = DecimalMask()
      txtMontoCos.FormatString = DecimalMask()
      txtMontoFac.FormatString = DecimalMask()
      txtMontoNet.FormatString = DecimalMask()
      txtMontoLiq.FormatString = DecimalMask()
      txtMontoRetencion.FormatString = DecimalMask()
      txtFactDifExento.FormatString = DecimalMask()
      txtExentoIVA.FormatString = DecimalMask()

      moCompraRecargo = New clsCompraRecargo(clsAppInfo.ConnectString)
      moCompraDescuento = New clsCompraDescuento(clsAppInfo.ConnectString)
      moAnticipo = New clsAnticipo(clsAppInfo.ConnectString)
      moFactura = New clsFactura(clsAppInfo.ConnectString)
      moPoliza = New clsPoliza(clsAppInfo.ConnectString)
      moCompraOtroCosto = New clsCompraOtroCosto(clsAppInfo.ConnectString)
      moCompraFac = New clsCompraFac(clsAppInfo.ConnectString)
      moFacturaOrg = New clsFactura(clsAppInfo.ConnectString)
      moPolizaOrg = New clsPoliza(clsAppInfo.ConnectString)

      lblExentoIVA.Visible = clsAppInfo.SepararExento
      txtExentoIVA.Visible = clsAppInfo.SepararExento

   End Sub

   Private Sub ComboLoad()
      Call cboTipoRetencionLoad()
   End Sub

   Private Sub cboTipoRetencionLoad()
      Dim oTipoRetencion As New clsTipoRetencion(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoRetencion.Items.Clear()

      Try
         With oTipoRetencion
            .SelectFilter = clsTipoRetencion.SelectFilters.ListBox
            .OrderByFilter = clsTipoRetencion.OrderByFilters.TipoRetencionDes

            If .Open() Then

               oItem = New clsListItem(0, "")
               cboTipoRetencion.Items.Add(oItem)

               Do While .Read()
                  oItem = New clsListItem(.TipoRetencionId, .TipoRetencionDes)

                  cboTipoRetencion.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoRetencion.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub FacturaOrgLoad()
      Try
         If moCompra.FacturaId > 0 Then

            With moFacturaOrg
               .FacturaId = moCompra.FacturaId

               If .FindByPK() Then
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub PolizaOrgLoad()
      Try

         If moCompra.PolizaId > 0 Then

            With moPolizaOrg
               .PolizaId = moCompra.PolizaId

               If .FindByPK() Then
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub cboTipoRetencion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoRetencion.SelectedIndexChanged
      If Not mboolShow Then
         mlngTipoRetencionId = ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex)
         If mlngTipoRetencionId <> 0 Then
            chkFacturaDif.Checked = False
            chkFacturaDif.Enabled = False
            ''txtFactDifExcento.Enabled = False
            If (mlngTipoRetencionId = 1) Or (mlngTipoRetencionId = 2) Or (mlngTipoRetencionId = 3) Then  'Asume Empresa
               txtFacturaIVA.Text = RetencionCalcEmpresa(mlngTipoRetencionId)
               txtMontoLiq.Text = ToDouble(txtMontoFac.Text) - ToDouble(txtMontoAnt.Text)
               txtMontoRetencion.Text = 0
               Call grdProrrateoLoad(True)
            Else
               txtExentoIVA.Text = 0
               txtFacturaIVA.Text = 0
               txtMontoRetencion.Text = RetencionCalcProveedor(mlngTipoRetencionId)
               txtMontoLiq.Text = ToDouble(txtMontoFac.Text) - ToDouble(txtMontoAnt.Text) - ToDouble(txtMontoRetencion.Text) 'Siempre en Bolvianos
               Call grdProrrateoLoad(True)
            End If

         Else

            txtExentoIVA.Text = 0
            txtFacturaIVA.Text = 0
            Call grdProrrateoLoad(True)
            chkFacturaDif.CheckState = False
            chkFacturaDif.Enabled = True
            txtMontoRetencion.Text = 0
            txtMontoLiq.Text = ToDecimal(txtMontoFac.Text) - ToDecimal(txtMontoAnt.Text) - ToDecimal(txtMontoRetencion.Text)

         End If
      End If

   End Sub

   Private Function RetencionCalcEmpresa(ByRef lngTipoRetencionId As Long) As Decimal

      Dim decRetencionIUE_ITBs As Decimal = 0
      Dim decRetencionIUE_ITUs As Decimal = 0

      Dim decPorcentajeRet As Decimal

      If lngTipoRetencionId = 1 Then
         'Por Servicios Asume Empresa
         decPorcentajeRet = 1 - clsAppInfo.IUE_Servicios - clsAppInfo.IT '' 0.845

         If moCompra.MonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) / decPorcentajeRet)

            RetencionCalcEmpresa = decRetencionIUE_ITBs - moCompra.MontoBru

         ElseIf moCompra.MonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)

            RetencionCalcEmpresa = decRetencionIUE_ITUs - moCompra.MontoBru
         End If

      ElseIf lngTipoRetencionId = 2 Then
         'Por Bienes Asume Empresa

         decPorcentajeRet = 1 - clsAppInfo.IUE_Bienes - clsAppInfo.IT '' 0.92

         If moCompra.MonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) / decPorcentajeRet)

            RetencionCalcEmpresa = decRetencionIUE_ITBs - moCompra.MontoBru

         ElseIf moCompra.MonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)

            RetencionCalcEmpresa = decRetencionIUE_ITUs - moCompra.MontoBru
         End If

      ElseIf lngTipoRetencionId = 3 Then
         'Por Alquiler Asume Empresa

         decPorcentajeRet = 1 - clsAppInfo.IT - clsAppInfo.IVA '' 0.84

         If moCompra.MonedaId = 1 Then
            decRetencionIUE_ITBs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) / decPorcentajeRet)

            RetencionCalcEmpresa = decRetencionIUE_ITBs - moCompra.MontoBru

         ElseIf moCompra.MonedaId = 2 Then
            decRetencionIUE_ITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) / decPorcentajeRet)
            decRetencionIUE_ITUs = ToDecimal(moCompra.MontoBru / decPorcentajeRet)

            RetencionCalcEmpresa = decRetencionIUE_ITUs - moCompra.MontoBru
         End If

      Else '' Son Retenciones q Asume Proveedor 
         decRetencionIUE_ITBs = moCompra.MontoBru '
      End If

      ''RetencionCalcEmpresa = decRetencionIUE_ITBs - moCompra.MontoBru

   End Function

   Private Function RetencionCalcProveedor(ByRef lngTipoRetencionId As Long) As Decimal


      Dim decIUEBs As Decimal = 0
      Dim decIUEUs As Decimal = 0
      Dim decIUEOrg As Decimal = 0

      Dim decITBs As Decimal = 0
      Dim decITUs As Decimal = 0
      Dim decITOrg As Decimal = 0

      If lngTipoRetencionId = 4 Then
         'Por Servicios Asume Provedor
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Servicios)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IUE_Servicios)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            RetencionCalcProveedor = decIUEBs + decITBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IUE_Servicios)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Servicios)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            RetencionCalcProveedor = decIUEUs + decITUs
         End If

      ElseIf lngTipoRetencionId = 5 Then
         'Por Bienes Asume Provedor
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Bienes)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IUE_Bienes)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            RetencionCalcProveedor = decIUEBs + decITBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IUE_Bienes)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IUE_Bienes)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            RetencionCalcProveedor = decIUEUs + decITUs
         End If

      ElseIf lngTipoRetencionId = 6 Then
         'Por Bienes Asume Provedor
         If moCompra.MonedaId = 1 Then

            decIUEBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IVA)
            decIUEUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IVA)
            decIUEOrg = decIUEBs

            decITBs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITUs = ToDecimal((moCompra.MontoBru / moCompra.TipoCambio) * clsAppInfo.IT)
            decITOrg = decITBs

            RetencionCalcProveedor = decIUEBs + decITBs

         ElseIf moCompra.MonedaId = 2 Then

            decIUEBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IVA)
            decIUEUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IVA)
            decIUEOrg = decIUEUs

            decITBs = ToDecimal((moCompra.MontoBru * moCompra.TipoCambio) * clsAppInfo.IT)
            decITUs = ToDecimal(moCompra.MontoBru * clsAppInfo.IT)
            decITOrg = decITUs

            RetencionCalcProveedor = decIUEUs + decITUs
         End If

      Else
         RetencionCalcProveedor = 0
      End If

   End Function

   Private Sub txtMontoRec_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
      If Not mboolShow Then
         txtMontoFac.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text))
      End If
   End Sub

   Private Sub txtMontoDes_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
      If Not mboolShow Then
         ''txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text))
         txtMontoFac.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text))
      End If
   End Sub

   Private Sub txtMontoOtroConIva_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoOtroConIva.ValueChanged
      If Not mboolShow Then
         ''txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text))

         If mlngTipoRetencionId = 0 Then    '' Con Factura o Difere
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text) - ToDouble(txtExentoIVA.Text))
         Else
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) + ToDouble(txtFacturaIVA.Text))
         End If
      End If
   End Sub

   Private Sub txtMontoOtroSinIva_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoOtroSinIva.ValueChanged
      If Not mboolShow Then
         ''txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text))

         If mlngTipoRetencionId = 0 Then    '' Con Factura o Difere
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text) - ToDouble(txtExentoIVA.Text))
         Else
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) + ToDouble(txtFacturaIVA.Text))
         End If
      End If
   End Sub

   Private Sub txtFacturaIva_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacturaIVA.ValueChanged
      If Not mboolShow Then

         ''Preguntar a donJoel sobre Costos
         If mlngTipoRetencionId = 0 Then    '' Que tiene Factura o diferida
            txtMontoNet.Text = ToDecimal(txtMontoFac.Text) - ToDecimal(txtFacturaIVA.Text)
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) - ToDouble(txtFacturaIVA.Text) - ToDouble(txtExentoIVA.Text))

         Else '' Que tiene  retencion
            txtMontoNet.Text = ToDecimal(txtMontoFac.Text)
            txtMontoCos.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoOtroConIva.Text) + ToDouble(txtMontoOtroSinIva.Text) + ToDouble(txtFacturaIVA.Text))

         End If

      End If
   End Sub

   Private Sub txtMontoAnt_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoAnt.ValueChanged
      If Not mboolShow Then
         txtMontoLiq.Text = ToDecimal(txtMontoFac.Text) - ToDecimal(txtMontoAnt.Text) - ToDecimal(txtMontoRetencion.Text)
      End If
   End Sub

   Private Sub txtMontoFac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoFac.ValueChanged
      If Not mboolShow Then
         txtMontoLiq.Text = ToDecimal(txtMontoFac.Text) - ToDecimal(txtMontoAnt.Text) - ToDecimal(txtMontoRetencion.Text)

         If mlngTipoRetencionId = 0 Then  '' Con Factura o Diferida
            txtMontoNet.Text = ToDecimal(txtMontoFac.Text) - ToDecimal(txtFacturaIVA.Text)
            txtMontoLiq.Text = ToDecimal(txtMontoFac.Text) - ToDecimal(txtMontoAnt.Text)

         Else
            txtMontoNet.Text = ToDecimal(txtMontoFac.Text)  '' Que tiene  retencion Empresa 
            txtMontoLiq.Text = ToDecimal(txtMontoFac.Text) - ToDecimal(txtMontoAnt.Text) - ToDecimal(txtMontoRetencion.Text)
         End If

      End If
   End Sub

   Private Sub chkFacturaDif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturaDif.CheckedChanged
      If Not mboolShow Then
         If chkFacturaDif.Checked Then
            txtFactDifExento.ReadOnly = False
            txtFactDifExento.Enabled = True
            cboTipoRetencion.Enabled = False
            cboTipoRetencion.ReadOnly = True
            cboTipoRetencion.SelectedIndex = ListFindItem(cboTipoRetencion, 0)

            If clsAppInfo.SepararExento Then
               txtExentoIVA.Text = ToDecimal(ToDecimal(txtFactDifExento.Text) * clsAppInfo.IVA)
            End If
            txtFacturaIVA.Text = ToDecimal(ToDecimal(moCompra.MontoBru - ToDecimal(txtFactDifExento.Text)) * clsAppInfo.IVA)

            Call grdProrrateoLoad(True)
         Else
            txtFactDifExento.ReadOnly = True
            txtFactDifExento.Enabled = False
            cboTipoRetencion.Enabled = True
            cboTipoRetencion.ReadOnly = False
            cboTipoRetencion.SelectedIndex = ListFindItem(cboTipoRetencion, 0)
            txtFactDifExento.Text = 0

            txtExentoIVA.Text = 0
            txtFacturaIVA.Text = 0
            Call grdProrrateoLoad(True)
         End If

      End If
   End Sub

   Private Sub txtFactDifExento_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFactDifExento.KeyUp
      If clsAppInfo.SepararExento Then
         txtExentoIVA.Text = ToDecimal(ToDecimal(txtFactDifExento.Text) * clsAppInfo.IVA)
      End If

      txtFacturaIVA.Text = ToDecimal(ToDecimal(moCompra.MontoBru - ToDecimal(txtFactDifExento.Text)) * clsAppInfo.IVA)
      Call grdProrrateoLoad(True)
   End Sub

#Region " CompraRecargo "

   Private Function decCompraRecargoNoApli(ByVal lngCompraId As Long) As Decimal
      Dim oCompraRecargo As New clsCompraRecargo(clsAppInfo.ConnectString)

      decCompraRecargoNoApli = 0

      Try
         With oCompraRecargo
            .SelectFilter = clsCompraRecargo.SelectFilters.Grid
            .WhereFilter = clsCompraRecargo.WhereFilters.Grid
            .OrderByFilter = clsCompraRecargo.OrderByFilters.Grid
            .EmpresaId = moCompra.EmpresaId
            .CompraId = lngCompraId

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If Not CBool(oRow("AplicarCosto")) Then
                     decCompraRecargoNoApli += oRow("Monto")
                  End If
               Next
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompraRecargo.Dispose()
      End Try

   End Function

   'Private Sub grdCompraRecargoLoad()
   '   Try
   '      With moCompraRecargo
   '         .SelectFilter = clsCompraRecargo.SelectFilters.Grid
   '         .WhereFilter = clsCompraRecargo.WhereFilters.Grid
   '         .OrderByFilter = clsCompraRecargo.OrderByFilters.Grid
   '         .EmpresaId = moCompra.EmpresaId
   '         .CompraId = moCompra.CompraId

   '         If .Open() Then
   '            grdCompraRecargo.DataSource = .DataSet.Tables(.TableName).DefaultView
   '            grdCompraRecargo.RetrieveStructure()
   '            Call grdCompraRecargoInit()
   '            txtMontoRec.Text = grdCompraRecargoNoApliTotal()
   '            txtMontoFac.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text))
   '         End If
   '        .Closeconection()
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   End Try
   'End Sub

   'Private Sub CompraRecargoDataShow()
   '   Dim oCompraRecargo As New clsCompraRecargo(clsAppInfo.ConnectString)

   '   Try
   '      If grdCompraRecargo.RowCount > 0 Then
   '         With oCompraRecargo
   '            .CompraRecargoId = ToLong(grdCompraRecargo.GetValue("CompraRecargoId"))

   '            If .FindByPK Then
   '               Dim frm As New frmCompraRecargoEdit

   '               frm.NewRecord = False
   '               frm.Editing = False
   '               frm.DataObject = oCompraRecargo

   '               frm.ShowDialog()
   '              frm.Dispose()
   '            End If
   '         End With
   '      Else
   '         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompraRecargo = Nothing

   '   End Try
   'End Sub

   'Private Sub CompraRecargoFormNew()
   '   Dim frm As New frmCompraRecargoEdit
   '   Dim oCompraRecargo As New clsCompraRecargo(clsAppInfo.ConnectString)

   '   Try
   '      If mboolAdding Or mboolEditing Then
   '         With frm
   '            .NewRecord = True
   '            .Editing = False

   '            oCompraRecargo.EmpresaId = moCompra.EmpresaId
   '            oCompraRecargo.GestionId = moCompra.GestionId
   '            oCompraRecargo.CompraId = moCompra.CompraId
   '            oCompraRecargo.MonedaId = moCompra.MonedaId
   '            oCompraRecargo.EstadoId = moCompra.EstadoId

   '            .DataObject = oCompraRecargo
   '            .ShowDialog()

   '            If .Changed Then
   '               Call grdCompraRecargoLoad()
   '               Call grdCompraRecargoFindRow(frm.ID)
   '               Call grdProrrateoLoad(True)
   '         
   '            End If
   '           frm.Dispose()
   '         End With
   '      Else
   '         MessageBox.Show("Imposible Adicionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   End Try
   'End Sub

   'Private Sub CompraRecargoDataEdit()
   '   Dim oCompraRecargo As New clsCompraRecargo(clsAppInfo.ConnectString)

   '   Try
   '      If grdCompraRecargo.RowCount > 0 Then
   '         If mboolAdding Or mboolEditing Then
   '            With oCompraRecargo
   '               .CompraRecargoId = ToLong(grdCompraRecargo.GetValue("CompraRecargoId"))

   '               If .FindByPK Then
   '                  Dim frm As New frmCompraRecargoEdit

   '                  frm.NewRecord = False
   '                  frm.Editing = True
   '                  frm.DataObject = oCompraRecargo
   '                  frm.ShowDialog()

   '                  If frm.Changed Then
   '                     Call grdCompraRecargoLoad()
   '                     Call grdCompraDescuentoFindRow(frm.ID)
   '                     Call grdProrrateoLoad(True)

   '                  End If
   '                 frm.Dispose()
   '               End If
   '            End With
   '         Else
   '            MessageBox.Show("Imposible Editar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '         End If
   '      Else
   '         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompraRecargo = Nothing

   '   End Try
   'End Sub

   'Private Sub CompraRecargoDataDelete()
   '   Dim oCompraRecargo As New clsCompraRecargo(clsAppInfo.ConnectString)

   '   Try
   '      If grdCompraRecargo.RowCount > 0 Then
   '         If mboolAdding Or mboolEditing Then
   '            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
   '               With oCompraRecargo
   '                  .WhereFilter = clsCompraRecargo.WhereFilters.PrimaryKey
   '                  .CompraRecargoId = ToLong(grdCompraRecargo.GetValue("CompraRecargoId"))

   '                  If .Delete Then
   '                     Call grdCompraRecargoLoad()
   '                     Call grdProrrateoLoad(True)
   '                  End If
   '               End With
   '            End If
   '         Else
   '            MessageBox.Show("Imposible Eliminar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '         End If
   '      Else
   '         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompraRecargo = Nothing

   '   End Try
   'End Sub

   'Private Sub grdCompraRecargoFindRow(ByVal lngID As Long)
   '   Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

   '   oCol = grdCompraRecargo.RootTable.Columns("CompraRecargoId")

   '   grdCompraRecargo.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   'End Sub

   'Private Function grdCompraRecargoNoApliTotal() As Decimal
   '   Dim decTotal As Decimal = 0

   '   With moCompraRecargo
   '      For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
   '         If Not CBool(oRow("AplicarCosto")) Then
   '            decTotal += oRow("Monto")
   '         End If
   '      Next
   '   End With

   '   Return decTotal
   'End Function

   'Private Sub grdCompraRecargoInit()
   '   With grdCompraRecargo
   '      ebrRecargos.Groups(0).Text = "Recargos No Aplicables"

   '      .ContextMenu = mnuRecargo

   '      .RootTable.Columns("CompraRecargoId").Visible = False

   '      .RootTable.Columns("PlanRecargoId").Visible = False

   '      .RootTable.Columns("PlanRecargoDes").Caption = "Recargo"
   '      .RootTable.Columns("PlanRecargoDes").Width = 150
   '      .RootTable.Columns("PlanRecargoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
   '      .RootTable.Columns("PlanRecargoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   '      .RootTable.Columns("MonedaId").Visible = False

   '      .RootTable.Columns("MonedaDes").Caption = "Moneda"
   '      .RootTable.Columns("MonedaDes").Width = 100
   '      .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
   '      .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   '      .RootTable.Columns("Monto").Caption = "Monto"
   '      .RootTable.Columns("Monto").FormatString = DecimalMask()
   '      .RootTable.Columns("Monto").Width = 100
   '      .RootTable.Columns("Monto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
   '      .RootTable.Columns("Monto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   '      .RootTable.Columns("AplicarCosto").Visible = False

   '   End With
   'End Sub

   'Private Sub grdCompraRecargo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdCompraRecargo.KeyDown
   '   If e.Control And e.KeyCode = Keys.C Then
   '      If Not grdCompraRecargo.CurrentColumn Is Nothing Then
   '         Clipboard.SetDataObject(grdCompraRecargo.GetRow.Cells(grdCompraRecargo.CurrentColumn).Text)
   '      End If
   '   End If
   'End Sub

   'Private Sub mnuShowRecargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowRecargo.Click
   '   Call CompraRecargoDataShow()
   'End Sub

   'Private Sub mnuNewRecargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewRecargo.Click
   '   Call CompraRecargoFormNew()
   'End Sub

   'Private Sub mnuEditRecargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditRecargo.Click
   '   Call CompraRecargoDataEdit()
   'End Sub

   'Private Sub mnuDeleteRecargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteRecargo.Click
   '   Call CompraRecargoDataDelete()
   'End Sub

#End Region

#Region " CompraDescuento "

   Private Function decCompraDescuentoNoApli(ByVal lngCompraId As Long) As Decimal
      Dim oCompraDescuento As New clsCompraDescuento(clsAppInfo.ConnectString)

      decCompraDescuentoNoApli = 0

      Try
         With oCompraDescuento
            .SelectFilter = clsCompraDescuento.SelectFilters.Grid
            .WhereFilter = clsCompraDescuento.WhereFilters.Grid
            .OrderByFilter = clsCompraDescuento.OrderByFilters.Grid
            .EmpresaId = moCompra.EmpresaId
            .CompraId = lngCompraId

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If Not CBool(oRow("AplicarCosto")) Then
                     decCompraDescuentoNoApli += oRow("Monto")
                  End If
               Next
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompraDescuento.Dispose()
      End Try

   End Function

   'Private Sub grdCompraDescuentoLoad()
   '   Try
   '      With moCompraDescuento
   '         .SelectFilter = clsCompraDescuento.SelectFilters.Grid
   '         .WhereFilter = clsCompraDescuento.WhereFilters.Grid
   '         .OrderByFilter = clsCompraDescuento.OrderByFilters.Grid
   '         .EmpresaId = moCompra.EmpresaId
   '         .CompraId = moCompra.CompraId

   '         If .Open() Then
   '            grdCompraDescuento.DataSource = .DataSet.Tables(.TableName).DefaultView
   '            grdCompraDescuento.RetrieveStructure()
   '            Call grdCompraDescuentoInit()
   '            txtMontoDes.Text = grdCompraDescuentoNoApliTotal()
   '            txtMontoFac.Text = ToDecimal(moCompra.MontoBru + ToDouble(txtMontoRec.Text) - ToDouble(txtMontoDes.Text))
   '         End If
   '        .CloseConection()
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   End Try
   'End Sub

   'Private Sub CompraDescuentoDataShow()
   '   Dim oCompraDescuento As New clsCompraDescuento(clsAppInfo.ConnectString)

   '   Try
   '      If grdCompraDescuento.RowCount > 0 Then
   '         With oCompraDescuento
   '            .CompraDescuentoId = ToLong(grdCompraDescuento.GetValue("CompraDescuentoId"))

   '            If .FindByPK Then
   '               Dim frm As New frmCompraDescuentoEdit

   '               frm.NewRecord = False
   '               frm.Editing = False
   '               frm.DataObject = oCompraDescuento

   '               frm.ShowDialog()
   '                 frm.Dispose()
   '            End If
   '         End With
   '      Else
   '         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompraDescuento = Nothing

   '   End Try
   'End Sub

   'Private Sub CompraDescuentoFormNew()
   '   Dim frm As New frmCompraDescuentoEdit
   '   Dim oCompraDescuento As New clsCompraDescuento(clsAppInfo.ConnectString)

   '   Try
   '      If mboolAdding Or mboolEditing Then
   '         With frm
   '            .NewRecord = True
   '            .Editing = False

   '            oCompraDescuento.EmpresaId = moCompra.EmpresaId
   '            oCompraDescuento.GestionId = moCompra.GestionId
   '            oCompraDescuento.CompraId = moCompra.CompraId
   '            oCompraDescuento.MonedaId = moCompra.MonedaId
   '            oCompraDescuento.EstadoId = moCompra.EstadoId

   '            .DataObject = oCompraDescuento
   '            .ShowDialog()

   '            If .Changed Then
   '               Call grdCompraDescuentoLoad()
   '               Call grdCompraDescuentoFindRow(frm.ID)
   '               Call grdProrrateoLoad(True)

   '            End If
   '           frm.Dispose()
   '         End With
   '      Else
   '         MessageBox.Show("Imposible Adicionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   End Try
   'End Sub

   'Private Sub CompraDescuentoDataEdit()
   '   Dim oCompraDescuento As New clsCompraDescuento(clsAppInfo.ConnectString)

   '   Try
   '      If grdCompraDescuento.RowCount > 0 Then
   '         If mboolAdding Or mboolEditing Then
   '            With oCompraDescuento
   '               .CompraDescuentoId = ToLong(grdCompraDescuento.GetValue("CompraDescuentoId"))

   '               If .FindByPK Then
   '                  Dim frm As New frmCompraDescuentoEdit

   '                  frm.NewRecord = False
   '                  frm.Editing = True
   '                  frm.DataObject = oCompraDescuento
   '                  frm.ShowDialog()

   '                  If frm.Changed Then
   '                     Call grdCompraDescuentoLoad()
   '                     Call grdCompraDescuentoFindRow(frm.ID)
   '                     Call grdProrrateoLoad(True)
   '     
   '                  End If
   '              frm.Dispose()
   '               End If
   '            End With
   '         Else
   '            MessageBox.Show("Imposible Editar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '         End If
   '      Else
   '         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompraDescuento = Nothing

   '   End Try
   'End Sub

   'Private Sub CompraDescuentoDataDelete()
   '   Dim oCompraDescuento As New clsCompraDescuento(clsAppInfo.ConnectString)

   '   Try
   '      If grdCompraDescuento.RowCount > 0 Then
   '         If mboolAdding Or mboolEditing Then
   '            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
   '               With oCompraDescuento
   '                  .WhereFilter = clsCompraDescuento.WhereFilters.PrimaryKey
   '                  .CompraDescuentoId = ToLong(grdCompraDescuento.GetValue("CompraDescuentoId"))

   '                  If .Delete Then
   '                     Call grdCompraDescuentoLoad()
   '                     Call grdProrrateoLoad(True)
   '                  End If
   '               End With
   '            End If
   '         Else
   '            MessageBox.Show("Imposible Eliminar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '         End If
   '      Else
   '         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompraDescuento = Nothing

   '   End Try
   'End Sub

   'Private Sub grdCompraDescuentoFindRow(ByVal lngID As Long)
   '   Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

   '   oCol = grdCompraDescuento.RootTable.Columns("CompraDescuentoId")

   '   grdCompraDescuento.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   'End Sub

   'Private Function grdCompraDescuentoNoApliTotal() As Decimal
   '   Dim decTotal As Decimal = 0

   '   With moCompraDescuento
   '      For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
   '         If Not CBool(oRow("AplicarCosto")) Then
   '            decTotal += oRow("Monto")
   '         End If
   '      Next
   '   End With

   '   Return decTotal
   'End Function

   'Private Sub grdCompraDescuentoInit()
   '   With grdCompraDescuento
   '      ebrDescuentos.Groups(0).Text = "Descuentos No Aplicables"
   '      .ContextMenu = mnuDescuento

   '      .RootTable.Columns("CompraDescuentoId").Visible = False

   '      .RootTable.Columns("PlanDescuentoId").Visible = False

   '      .RootTable.Columns("PlanDescuentoDes").Caption = "Descuento"
   '      .RootTable.Columns("PlanDescuentoDes").Width = 150
   '      .RootTable.Columns("PlanDescuentoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
   '      .RootTable.Columns("PlanDescuentoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   '      .RootTable.Columns("MonedaId").Visible = False

   '      .RootTable.Columns("MonedaDes").Caption = "Moneda"
   '      .RootTable.Columns("MonedaDes").Width = 100
   '      .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
   '      .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   '      .RootTable.Columns("Monto").Caption = "Monto"
   '      .RootTable.Columns("Monto").FormatString = DecimalMask()
   '      .RootTable.Columns("Monto").Width = 100
   '      .RootTable.Columns("Monto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
   '      .RootTable.Columns("Monto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

   '      .RootTable.Columns("AplicarCosto").Visible = False

   '   End With
   'End Sub

   'Private Sub grdCompraDescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdCompraDescuento.KeyDown
   '   If e.Control And e.KeyCode = Keys.C Then
   '      If Not grdCompraDescuento.CurrentColumn Is Nothing Then
   '         Clipboard.SetDataObject(grdCompraDescuento.GetRow.Cells(grdCompraDescuento.CurrentColumn).Text)
   '      End If
   '   End If
   'End Sub

   'Private Sub mnuShowDescuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowDescuento.Click
   '   Call CompraDescuentoDataShow()
   'End Sub

   'Private Sub mnuNewDescuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewDescuento.Click
   '   Call CompraDescuentoFormNew()
   'End Sub

   'Private Sub mnuEditDescuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditDescuento.Click
   '   Call CompraDescuentoDataEdit()
   'End Sub

   'Private Sub mnuDeleteDescuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteDescuento.Click
   '   Call CompraDescuentoDataDelete()
   'End Sub

#End Region

#Region " Anticipo "

   Private Sub grdAnticipoLoad()
      Try
         With moAnticipo
            If mboolAdding Then
               .SelectFilter = clsAnticipo.SelectFilters.GridCompraNew
               .WhereFilter = clsAnticipo.WhereFilters.GridCompraNew
               .OrderByFilter = clsAnticipo.OrderByFilters.AnticipoNro
               .EmpresaId = moCompra.EmpresaId
               .GestionId = moCompra.GestionId
               .ProveedorId = moCompra.ProveedorId
               .TipoAnticipoId = 2 'Solo Anticipos
               .AnticipoDes = PedCompraIdListaLoad() 'Listado de PedVentaId
               .CentroCostoId = moCompra.CentroCostoId
               .EstadoId = 13
            Else
               .SelectFilter = clsAnticipo.SelectFilters.GridCompraShow
               .WhereFilter = clsAnticipo.WhereFilters.GridCompraShow
               .OrderByFilter = clsAnticipo.OrderByFilters.AnticipoNro
               .EmpresaId = moCompra.EmpresaId
               .TipoAnticipoId = 2 '.TipoVentaId = 2 
               .PedCompraId = moCompra.CompraId '.VentaId 
            End If

            If .Open() Then
               grdAnticipo.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdAnticipo.RetrieveStructure()
               Call grdAnticipoInit()
               Call grdAnticipoPedCompra()
               txtMontoAnt.Text = grdAnticipoTotal()
            End If
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function PedCompraIdListaLoad() As String
      Dim boolFirst As Boolean = True
      Dim strPedVentaId As String = String.Empty

      strPedVentaId = "0"

      For Each lngPedVentaId As Long In mlstPedCompra
         strPedVentaId &= ", " & ToStr(lngPedVentaId)
      Next

      Return strPedVentaId
   End Function

   Private Sub grdAnticipoPedCompra()
      For Each lngPedCompraId As Long In mlstPedCompra
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetRows
            If oRow.Cells("PedCompraId").Value = lngPedCompraId Then
               'oRow.CheckState = Janus.Windows.GridEX.RowCheckState.Checked
               oRow.IsChecked = True

               oRow.BeginEdit()
               ''oRow.Cells("Monto").Value = oRow.Cells("MontoAnt").Value
               oRow.Cells("Monto").Value = oRow.Cells("MontoPen").Value
               oRow.EndEdit()
            End If
         Next
      Next
   End Sub

   Private Sub moDataSetAnticipoInit()
      moDataSetAnticipo = New DataSet("Tablas")
      moDataTableAnticipo = moDataSetAnticipo.Tables.Add(moAnticipo.TableName)

      moDataTableAnticipo.Columns.Add("Sel", Type.GetType("System.Boolean"))
      moDataTableAnticipo.Columns.Add("AnticipoId", Type.GetType("System.Int32"))
      moDataTableAnticipo.Columns.Add("TipoAnticipoId", Type.GetType("System.Int32"))
      moDataTableAnticipo.Columns.Add("AnticipoNro", Type.GetType("System.Int32"))
      moDataTableAnticipo.Columns.Add("PedCompraId", Type.GetType("System.Int32"))
      moDataTableAnticipo.Columns.Add("PedCompraNro", Type.GetType("System.Int32"))
      moDataTableAnticipo.Columns.Add("MonedaId", Type.GetType("System.Int32"))
      moDataTableAnticipo.Columns.Add("MonedaDes", Type.GetType("System.String"))
      moDataTableAnticipo.Columns.Add("SinFac", Type.GetType("System.Boolean"))
      moDataTableAnticipo.Columns.Add("ConFac", Type.GetType("System.Boolean"))
      moDataTableAnticipo.Columns.Add("MontoAnt", Type.GetType("System.Decimal"))

      If mboolAdding Or mboolEditing Then
         moDataTableAnticipo.Columns.Add("MontoPen", Type.GetType("System.Decimal"))
      Else
         moDataTableAnticipo.Columns.Add("MontoDes", Type.GetType("System.Decimal"))
      End If

      moDataTableAnticipo.Columns.Add("Monto", Type.GetType("System.Decimal"))

   End Sub

   Private Function GetRowAnticipoShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTableAnticipo.NewRow

      oRow("Sel") = CBool(oDataRow("Sel"))
      oRow("AnticipoId") = oDataRow("AnticipoId")
      oRow("TipoAnticipoId") = oDataRow("TipoAnticipoId")
      oRow("AnticipoNro") = oDataRow("AnticipoNro")
      oRow("PedCompraId") = oDataRow("PedCompraId")
      oRow("PedCompraNro") = oDataRow("PedCompraNro")
      oRow("MonedaId") = oDataRow("MonedaId")
      oRow("MonedaDes") = oDataRow("MonedaDes")
      oRow("MontoAnt") = oDataRow("MontoAnt")
      oRow("SinFac") = oDataRow("SinFac")
      oRow("ConFac") = oDataRow("ConFac")

      If mboolAdding Or mboolEditing Then
         oRow("MontoPen") = oDataRow("MontoPen")
      Else
         oRow("MontoDes") = oDataRow("MontoDes")
      End If

      oRow("Monto") = oDataRow("Monto")

      Return oRow
   End Function

   Private Sub AnticipoDataShow()
      Dim oAnticipo As New clsAnticipo(clsAppInfo.ConnectString)

      Try
         If grdAnticipo.RowCount > 0 Then
            With oAnticipo
               .AnticipoId = ToLong(grdAnticipo.GetValue("AnticipoId"))

               If .FindByPK Then
                  Dim frm As New frmAnticipoEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oAnticipo

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
         oAnticipo = Nothing

      End Try
   End Sub

   Private Sub grdAnticipoFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdAnticipo.RootTable.Columns("AnticipoId")

      grdAnticipo.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Function grdAnticipoTotal() As Decimal
      Dim decMontoAnt As Decimal = 0
      Dim lngMonedaId As Long = moCompra.MonedaId

      ''If mboolAdding Or mboolEditing Then
      If mboolAdding Then

         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetCheckedRows
            If lngMonedaId = 1 Then 'Moneda del Nuevo Anticipo
               If oRow.Cells("MonedaId").Value = lngMonedaId Then
                  decMontoAnt += oRow.Cells("Monto").Value
               Else
                  decMontoAnt += ToDecimal(oRow.Cells("Monto").Value * moCompra.TipoCambio)
               End If

            ElseIf lngMonedaId = 2 Then
               If oRow.Cells("MonedaId").Value = lngMonedaId Then
                  decMontoAnt += oRow.Cells("Monto").Value
               Else
                  decMontoAnt += ToDecimal(oRow.Cells("Monto").Value / moCompra.TipoCambio)
               End If
            End If
         Next

      Else
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdAnticipo.GetRows
            If lngMonedaId = 1 Then 'Moneda del Nuevo Anticipo
               If oRow.Cells("MonedaId").Value = lngMonedaId Then
                  decMontoAnt += oRow.Cells("Monto").Value
               Else
                  decMontoAnt += ToDecimal(oRow.Cells("Monto").Value * moCompra.TipoCambio)
               End If

            ElseIf lngMonedaId = 2 Then
               If oRow.Cells("MonedaId").Value = lngMonedaId Then
                  decMontoAnt += oRow.Cells("Monto").Value
               Else
                  decMontoAnt += ToDecimal(oRow.Cells("Monto").Value / moCompra.TipoCambio)
               End If
            End If
         Next
      End If

      Return decMontoAnt
   End Function

   Private Sub grdAnticipoInit()
      With grdAnticipo
         ebrAnticipos.Groups(0).Text = "Anticipos"
         .ContextMenu = mnuAnticipo

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

         ''If mboolAdding Or mboolEditing Then
         If mboolAdding Then

            .RootTable.Columns("Sel").Width = 40
            .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Sel").ActAsSelector = True

            .RootTable.Columns("MontoPen").Caption = "Pendiente"
            .RootTable.Columns("MontoPen").FormatString = DecimalMask()
            .RootTable.Columns("MontoPen").Width = 100
            .RootTable.Columns("MontoPen").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoPen").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("MontoPen").EditType = Janus.Windows.GridEX.EditType.NoEdit
            .RootTable.Columns("MontoPen").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         Else
            .RootTable.Columns("Sel").Visible = False

            .RootTable.Columns("Monto").EditType = Janus.Windows.GridEX.EditType.NoEdit
            .RootTable.Columns("Monto").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

            .RootTable.Columns("MontoDes").Caption = "Descargo Total"
            .RootTable.Columns("MontoDes").FormatString = DecimalMask()
            .RootTable.Columns("MontoDes").Width = 100
            .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("MontoDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
            .RootTable.Columns("MontoDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         End If

         .RootTable.Columns("AnticipoId").Visible = False

         .RootTable.Columns("TipoAnticipoId").Visible = False

         .RootTable.Columns("AnticipoNro").Caption = "Número"
         .RootTable.Columns("AnticipoNro").Width = 100
         .RootTable.Columns("AnticipoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("AnticipoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("AnticipoNro").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("AnticipoNro").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("PedCompraId").Visible = False

         .RootTable.Columns("PedCompraNro").Caption = "Nro Pedido"
         .RootTable.Columns("PedCompraNro").Width = 100
         .RootTable.Columns("PedCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraNro").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("PedCompraNro").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("SinFac").Caption = "I"
         .RootTable.Columns("SinFac").Width = 50
         .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("SinFac").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("ConFac").Caption = "F"
         .RootTable.Columns("ConFac").Width = 50
         .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("ConFac").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         If clsAppInfo.CentroCostoApli Then
            .RootTable.Columns("CentroCostoId").Visible = False
            .RootTable.Columns("CentroCostoDes").Caption = "Centro Costo"
            .RootTable.Columns("CentroCostoDes").Width = 150
            .RootTable.Columns("CentroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("CentroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("CentroCostoDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         Else
            .RootTable.Columns("CentroCostoId").Visible = False
            .RootTable.Columns("CentroCostoDes").Visible = False
         End If

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MonedaDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MonedaDes").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("MontoAnt").Caption = "Anticipo"
         .RootTable.Columns("MontoAnt").FormatString = DecimalMask()
         .RootTable.Columns("MontoAnt").Width = 100
         .RootTable.Columns("MontoAnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoAnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MontoAnt").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("MontoAnt").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox

         .RootTable.Columns("Monto").Caption = "Descargo Compra"
         .RootTable.Columns("Monto").FormatString = DecimalMask()
         .RootTable.Columns("Monto").Width = 100
         .RootTable.Columns("Monto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Monto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdAnticipo_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdAnticipo.UpdatingCell
      If ToStr(e.Column.DataMember) = "Monto" Then
         If ToDecimal(e.Value) = 0 Then
            e.Value = 0
            grdAnticipo.SetValue("Sel", False)

         ElseIf ToDecimal(e.Value) < 0 Then
            e.Cancel = True
            grdAnticipo.SetValue("Sel", False)
            MessageBox.Show("Monto Negativo Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         ElseIf ToDecimal(e.Value) > ToDecimal(grdAnticipo.GetValue("MontoPen")) Then
            e.Cancel = True
            grdAnticipo.SetValue("Sel", False)
            MessageBox.Show("Monto Superior al Importe Pendiente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'ElseIf ToLong(grdAnticipo.GetValue("PedCompraId")) = 1 Then
            '   e.Cancel = True
            '   grdAnticipo.SetValue("Sel", True)
            '   MessageBox.Show("El Anticipo esta Asociado al Pedido de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Else
            grdAnticipo.SetValue("Sel", True)
         End If
      End If
   End Sub

   Private Sub grdAnticipo_RowCheckStateChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs) Handles grdAnticipo.RowCheckStateChanging
      If (ToLong(grdAnticipo.GetValue("PedCompraId")) <> 0) And (e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked) Then
         e.Cancel = True
         MessageBox.Show("El Anticipo esta Asociado al Pedido de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
         grdAnticipo.SetValue("Monto", grdAnticipo.GetValue("MontoPen"))

      Else
         grdAnticipo.SetValue("Monto", 0)
      End If
   End Sub

   Private Sub grdAnticipo_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAnticipo.CellUpdated
      txtMontoAnt.Text = grdAnticipoTotal()
   End Sub

   Private Sub grdAnticipo_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdAnticipo.RowCheckStateChanged
      txtMontoAnt.Text = grdAnticipoTotal()
   End Sub

   Private Sub grdAnticipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdAnticipo.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdAnticipo.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdAnticipo.GetRow.Cells(grdAnticipo.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub mnuShowAnticipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowAnticipo.Click
      Call AnticipoDataShow()
   End Sub

   Private Sub grdAnticipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdAnticipo.KeyPress
      If Not grdAnticipo.CurrentColumn Is Nothing Then

         ''If (ToLong(grdAnticipo.GetValue("PedCompraId")) <> 0) And CBool(grdAnticipo.GetValue("Sel")) Then
         ''   e.Handled = True
         ''   SendKeys.Send("")
         ''Else
         If ToStr(grdAnticipo.RootTable.Columns(grdAnticipo.Col).DataMember) = "Monto" Then
            If mstrSepDecimal = "," Then
               If e.KeyChar = "." Then
                  e.Handled = True
                  SendKeys.Send(",")
               End If
            End If
         End If
      End If
      ''End If
   End Sub

#End Region

#Region " Factura "

   Private Function FacturaMontoFind(ByVal lngFacturaId As Long, ByRef decDescuento As Decimal) As Decimal

      FacturaMontoFind = 0

      Try
         With moFactura
            decDescuento = .Descuento
            FacturaMontoFind = .FacturaMonto
         End With

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub grdFacturaLoad()
      Try

         With moFactura
            .FacturaId = moCompra.FacturaId
            .FindByPK()

            .SelectFilter = clsFactura.SelectFilters.GridCompra
            .WhereFilter = clsFactura.WhereFilters.GridCompra
            .OrderByFilter = clsFactura.OrderByFilters.Grid
            If .Open() Then
            End If
            .CloseConection()
         End With

         ''Facturas Diferidas
         With moCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.GridCompra
            .WhereFilter = clsCompraFac.WhereFilters.GridCompra
            .OrderByFilter = clsCompraFac.OrderByFilters.GridCompra
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = moCompra.CompraId

            If .Open() Then
            End If
            .CloseConection()
         End With

         If moCompra.FacturaId <> 0 Then
            grdFactura.DataSource = moFactura.DataSet.Tables(moFactura.TableName).DefaultView
            grdFactura.RetrieveStructure()
            Call grdFacturaInit()
            txtFacturaIVA.Text = grdFacturaTotalIVA()

         Else
            grdFactura.DataSource = moCompraFac.DataSet.Tables(moCompraFac.TableName).DefaultView
            grdFactura.RetrieveStructure()
            Call grdFacturaInit()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdFacturaNewEditLoad(ByVal boolNew As Boolean, ByVal oFacturaNew As clsFactura)
      Dim oRow As DataRow
      Dim oDataTable As DataTable

      Try
         With moFactura

            oDataTable = .DataSet.Tables(.TableName)

            If boolNew Then
               oRow = oDataTable.NewRow
               RowNewEditFactura(oRow, oFacturaNew)
               oDataTable.Rows.Add(oRow)

            Else
               oRow = oDataTable.Rows(grdFacturaFindRowId(oFacturaNew.FacturaId))
               RowNewEditFactura(oRow, oFacturaNew)

            End If

            grdFactura.DataSource = .DataSet.Tables(.TableName).DefaultView
            grdFactura.RetrieveStructure()
            Call grdFacturaInit()

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub RowNewEditFactura(ByRef oRow As DataRow, ByVal oFactura As clsFactura)

      ''Para guardar en la BD
      moFactura.FacturaId = oFactura.FacturaId
      moFactura.GestionId = oFactura.GestionId
      moFactura.EmpresaId = oFactura.EmpresaId
      moFactura.SucursalId = oFactura.SucursalId
      moFactura.TipoFacturaId = 2
      moFactura.MesId = oFactura.MesId
      moFactura.FacturaFecha = oFactura.FacturaFecha
      moFactura.FacturaNro = oFactura.FacturaNro
      moFactura.FacturaMonto = oFactura.FacturaMonto
      moFactura.RegRUCId = oFactura.RegRUCId
      moFactura.RegRUCDes = oFactura.RegRUCDes
      moFactura.NroRUC = oFactura.NroRUC
      moFactura.NroAutorizacion = oFactura.NroAutorizacion
      moFactura.IVA = oFactura.IVA
      moFactura.IceIehd = oFactura.IceIehd
      moFactura.Exento = oFactura.Exento
      moFactura.Descuento = oFactura.Descuento
      moFactura.FacturaObs = oFactura.FacturaObs
      moFactura.Bancarizar = oFactura.Bancarizar
      moFactura.EstadoId = 13 ''Estado en Memoria q Indica que ha sido Editado
      moFactura.CodControl = oFactura.CodControl
      moFactura.TipoFacCompraId = oFactura.TipoFacCompraId

      ''Para mostrar en la Grilla
      oRow("FacturaId") = oFactura.FacturaId
      oRow("TipoFacturaId") = oFactura.TipoFacturaId
      oRow("FacturaNro") = oFactura.FacturaNro
      oRow("FacturaFecha") = ToStr(oFactura.FacturaFecha)
      ''oRow("RegRUCId") = oFactura.RegRUCId
      oRow("NroRUC") = oFactura.NroRUC
      oRow("RegRUCDes") = oFactura.RegRUCDes
      oRow("NroAutorizacion") = oFactura.NroAutorizacion
      oRow("CodControl") = oFactura.CodControl
      oRow("FacturaMonto") = oFactura.FacturaMonto
      oRow("Exento") = oFactura.Exento
      oRow("IceIehd") = oFactura.IceIehd

      oRow("Subtotal") = oFactura.FacturaMonto - (oFactura.Exento + oFactura.IceIehd)
      oRow("Descuento") = oFactura.Descuento
      oRow("Neto") = oFactura.FacturaMonto - (oFactura.Exento + oFactura.IceIehd + oFactura.Descuento)
      oRow("IVA") = oFactura.IVA
      oRow("ImporteIva") = ((oFactura.FacturaMonto - (oFactura.Exento + oFactura.IceIehd + oFactura.Descuento)) - oFactura.IVA)


   End Sub

   Private Sub FacturaDataShow()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         If grdFactura.RowCount > 0 Then

            If moCompra.FacturaId <> 0 Then
               With oFactura
                  Dim frm As New frmFacturaEdit

                  frm.NewRecord = False
                  frm.Editing = False

                  oFactura.FacturaId = moFactura.FacturaId
                  oFactura.MesId = moFactura.MesId
                  oFactura.FacturaFecha = moFactura.FacturaFecha
                  oFactura.FacturaNro = moFactura.FacturaNro
                  oFactura.RegRUCId = moFactura.RegRUCId
                  oFactura.RegRUCDes = moFactura.RegRUCDes
                  oFactura.NroRUC = moFactura.NroRUC
                  oFactura.NroAutorizacion = moFactura.NroAutorizacion
                  oFactura.FacturaMonto = moFactura.FacturaMonto
                  oFactura.IVA = moFactura.IVA
                  oFactura.IceIehd = moFactura.IceIehd
                  oFactura.Exento = moFactura.Exento
                  oFactura.Descuento = moFactura.Descuento
                  oFactura.FacturaObs = moFactura.FacturaObs
                  oFactura.Bancarizar = moFactura.Bancarizar
                  oFactura.CodControl = moFactura.CodControl
                  oFactura.TipoFacCompraId = moFactura.TipoFacCompraId

                  oFactura.EmpresaId = moFactura.EmpresaId
                  oFactura.GestionId = moFactura.GestionId
                  oFactura.SucursalId = moFactura.SucursalId
                  oFactura.TipoFacturaId = moFactura.TipoFacturaId
                  oFactura.EstadoId = 11

                  frm.DataObject = oFactura

                  frm.ShowDialog()
                  frm.Dispose()

               End With

            Else ''Muestra las Facturas Diferidas
               With oFactura
                  .FacturaId = ToLong(grdFactura.GetValue("FacturaId"))

                  If .FindByPK Then
                     Dim frm As New frmFacturaEdit

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oFactura

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            End If

         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Sub

   Private Sub FacturaFormNew()
      Dim frm As New frmFacturaEdit
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         If mboolAdding Or mboolEditing Then
            If moCompra.FacturaId = 0 Then
               If moCompra.PolizaId = 0 Then
                  If Not chkFacturaDif.Checked Then
                     If ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex) = 0 Then ''moCompra.TipoRetencionId = 0 Then 

                        With frm
                           .NewRecord = True
                           .Editing = False

                           oFactura.EmpresaId = moCompra.EmpresaId
                           oFactura.GestionId = moCompra.GestionId
                           oFactura.SucursalId = AlmacenSucursalIdFind(moCompra.AlmacenId)
                           oFactura.TipoFacturaId = 2
                           oFactura.FacturaFecha = ConvertDMY(moCompra.Fecha)
                           oFactura.EstadoId = 11

                           ''If moCompra.MonedaId = 1 Then
                           ''   oFactura.FacturaMonto = ToDecimal(txtMontoFac.Text)
                           ''Else
                           ''   oFactura.FacturaMonto = (ToDecimal(txtMontoFac.Text)) * moCompra.TipoCambio
                           ''End If

                           If moCompra.MonedaId = 1 Then
                              oFactura.FacturaMonto = moCompra.MontoOrg
                              oFactura.Descuento = moCompra.MontoDes
                           Else
                              oFactura.FacturaMonto = ToDecimal(moCompra.MontoOrg * moCompra.TipoCambio)
                              oFactura.Descuento = ToDecimal(moCompra.MontoDes * moCompra.TipoCambio)
                           End If



                           .FacturaIdOrg = moFacturaOrg.FacturaId
                           .DataObject = oFactura
                           .ShowDialog()

                           If .Changed Then
                              moCompra.FacturaId = -1

                              Call grdFacturaNewEditLoad(True, frm.DataObject)
                              Call grdFacturaFindRow(frm.ID)
                              txtFacturaIVA.Text = grdFacturaTotalIVA()

                              Call grdProrrateoLoad(True)
                              cboTipoRetencion.ReadOnly = True
                              cboTipoRetencion.Enabled = False
                              chkFacturaDif.Enabled = False

                           End If
                           frm.Dispose()
                        End With

                     Else
                        MessageBox.Show("Imposible Ingresar una Factura ya que Existe Retencion para esta Compra ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("Imposible Ingresar una Factura ya que la Opción de Factura Diferida esta Habilitada ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Ya Existe una Poliza de Importación Para la Nota de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Ya Existe una Factura Para la Nota de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Imposible Adicionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try

   End Sub

   Private Sub FacturaDataEdit()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         If grdFactura.RowCount > 0 Then
            If mboolAdding Or mboolEditing Then
               With oFactura

                  Dim frm As New frmFacturaEdit

                  frm.NewRecord = False
                  frm.Editing = True

                  oFactura.FacturaId = moFactura.FacturaId
                  oFactura.MesId = moFactura.MesId
                  oFactura.FacturaNro = moFactura.FacturaNro
                  oFactura.RegRUCId = moFactura.RegRUCId
                  oFactura.RegRUCDes = moFactura.RegRUCDes
                  oFactura.NroRUC = moFactura.NroRUC
                  oFactura.NroAutorizacion = moFactura.NroAutorizacion
                  oFactura.IVA = moFactura.IVA
                  oFactura.IceIehd = moFactura.IceIehd
                  oFactura.Exento = moFactura.Exento
                  oFactura.FacturaObs = moFactura.FacturaObs
                  oFactura.Bancarizar = moFactura.Bancarizar
                  oFactura.CodControl = moFactura.CodControl
                  oFactura.TipoFacCompraId = moFactura.TipoFacCompraId

                  oFactura.EmpresaId = moCompra.EmpresaId
                  oFactura.GestionId = moCompra.GestionId
                  oFactura.SucursalId = AlmacenSucursalIdFind(moCompra.AlmacenId)
                  oFactura.TipoFacturaId = 2
                  oFactura.FacturaFecha = ConvertDMY(moCompra.Fecha)
                  oFactura.EstadoId = 11

                  ''If moCompra.MonedaId = 1 Then
                  ''   oFactura.FacturaMonto = ToDecimal(txtMontoFac.Text)
                  ''Else
                  ''   oFactura.FacturaMonto = (ToDecimal(txtMontoFac.Text)) * moCompra.TipoCambio
                  ''End If

                  If moCompra.MonedaId = 1 Then
                     oFactura.FacturaMonto = ToDecimal(moCompra.MontoOrg)
                     oFactura.Descuento = ToDecimal(moCompra.MontoDes)
                  Else
                     oFactura.FacturaMonto = ToDecimal(moCompra.MontoOrg * moCompra.TipoCambio)
                     oFactura.Descuento = ToDecimal(moCompra.MontoDes * moCompra.TipoCambio)
                  End If

                  frm.FacturaIdOrg = moFacturaOrg.FacturaId
                  frm.DataObject = oFactura
                  frm.ShowDialog()

                  If frm.Changed Then

                     grdFacturaNewEditLoad(False, frm.DataObject)
                     Call grdFacturaFindRow(frm.ID)

                     txtFacturaIVA.Text = grdFacturaTotalIVA()
                     Call grdProrrateoLoad(True)
                  End If
                  frm.Dispose()
               End With

            Else
               MessageBox.Show("Imposible Editar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Sub

   Private Sub FacturaDataDelete()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         If grdFactura.RowCount > 0 Then
            If mboolAdding Or mboolEditing Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                  ''' Si las factura es el original   no se elimina

                  moCompra.FacturaId = 0
                  Call grdFacturaLoad()
                  txtFacturaIVA.Text = grdFacturaTotalIVA()
                  Call grdProrrateoLoad(True)
                  cboTipoRetencion.ReadOnly = False
                  cboTipoRetencion.Enabled = True
                  chkFacturaDif.Enabled = True

               End If
            Else
               MessageBox.Show("Imposible Eliminar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Sub

   Private Sub FacturaDifDataDelete()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         If grdFactura.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oFactura
                  .WhereFilter = clsFactura.WhereFilters.PrimaryKey
                  .FacturaId = ToLong(grdFactura.GetValue("FacturaId"))

                  If FacturaDifAnular(.FacturaId, 12) Then
                     '' Anular el comprobante de la Factura y eliminar el VentaFac y restaurar el tipo el MOnto de la Factura
                     Call grdFacturaLoad()
                     Call grdProrrateoLoad(True)
                  End If

               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Sub

   Private Function FacturaDifAnular(ByVal lngFacturaId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)
      Dim decTipoCambio As Decimal
      Dim decMontoFactura As Decimal = 0

      Try
         FacturaDifAnular = False

         With oFactura
            .FacturaId = lngFacturaId

            If .FindByPK Then
               .EstadoId = lngEstadoId
               .FacturaFecha = ToDate(.FacturaFecha)
               decMontoFactura = .FacturaMonto

               'Anulando el comprobante
               If .CompId <> 0 Then

                  If .Update() Then  'Anulando la Factura

                     If CompAnular(.CompId, lngEstadoId, decTipoCambio) Then

                        If CompraFacDelete(lngFacturaId, decTipoCambio) Then

                           If moCompra.MonedaId = clsMoneda.DOLARES Then
                              decMontoFactura = decMontoFactura / decTipoCambio
                           End If

                           If CompraUpdateMontoFac(moCompra.CompraId, -decMontoFactura) Then  'Actualizando el monto de la Compra facturado
                              FacturaDifAnular = True
                           End If

                        End If

                     End If

                  End If

               ElseIf .CompId = 0 Then  ''Si es una factura con exento igual al de la Factura

                  .WhereFilter = clsFactura.WhereFilters.PrimaryKey
                  If .Delete() Then

                     If CompraFacDelete(lngFacturaId, decTipoCambio) Then

                        If moCompra.MonedaId = clsMoneda.DOLARES Then
                           decMontoFactura = decMontoFactura / decTipoCambio
                        End If

                        If CompraUpdateMontoFac(moCompra.CompraId, -decMontoFactura) Then  'Actualizando el monto de la Compra facturado
                           FacturaDifAnular = True
                        End If

                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()
         oCompraFac.Dispose()
      End Try
   End Function

   Private Function FacturaDetDelete(ByVal lngFacturaId As Long) As Boolean
      Dim oFacturaDet As New clsFacturaDet(clsAppInfo.ConnectString)

      Try
         With oFacturaDet
            .WhereFilter = clsFacturaDet.WhereFilters.FacturaId
            .FacturaId = lngFacturaId

            FacturaDetDelete = .Delete

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaDet = Nothing

      End Try
   End Function

   Private Function CompraUpdateMontoFac(ByVal lngCompraId As Long, ByVal decMontoFac As Decimal) As Boolean
      Dim oVenta As New clsCompra(clsAppInfo.ConnectString)

      CompraUpdateMontoFac = False

      Try
         With oVenta
            .CompraId = lngCompraId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .MontoFac = decMontoFac

               .UpdateFilter = clsCompra.UpdateFilters.MontoFac

               If .Update() Then
                  moCompra.MontoFac += decMontoFac ''Sumamos por q esta decMontofac en Negativo  
                  CompraUpdateMontoFac = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oVenta.Dispose()

      End Try
   End Function

   Private Function CompAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long, ByRef decTipoCambio As Decimal) As Boolean
      If lngCompId = 0 Then
         Return True
      End If

      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Try
         CompAnular = False

         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               .EstadoId = lngEstadoId
               .Fecha = ToDate(.Fecha)
               .PorConcepto = .PorConcepto + " - Anulado por Nro. de Factura "
               decTipoCambio = .TipoCambio

               If .Update Then
                  If CompDetAnular(lngCompId, lngEstadoId) Then
                     CompAnular = True
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompraFacDelete(ByVal lngFacturaId As Long, ByRef decTipoCambio As Decimal) As Boolean

      Dim oCompraFac As New clsCompraFac(clsAppInfo.ConnectString)
      Try

         CompraFacDelete = False

         With oCompraFac
            .SelectFilter = clsCompraFac.SelectFilters.All
            .WhereFilter = clsCompraFac.WhereFilters.FacturaId
            .FacturaId = lngFacturaId

            If .Find Then
               decTipoCambio = .TipoCambio

               If .Delete Then
                  CompraFacDelete = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraFac.Dispose()

      End Try
   End Function

   Private Function CompDetAnular(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         CompDetAnular = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moCompra.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  .EstadoId = lngEstadoId
                  .Fecha = ToDate(.Fecha)

                  If .Update Then
                     CompDetAnular = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function AlmacenSucursalIdFind(ByVal lngAlmacenId As Long) As Long
      Dim oAlmacen As New clsAlmacen(clsAppInfo.ConnectString)

      AlmacenSucursalIdFind = 0

      Try
         With oAlmacen
            .AlmacenId = lngAlmacenId

            If .FindByPK Then
               Return .SucursalId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAlmacen.Dispose()

      End Try
   End Function

   Private Sub grdFacturaFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdFactura.RootTable.Columns("FacturaId")

      grdFactura.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Function grdFacturaFindRowId(ByVal lngID As Long) As Long
      Dim intRow As Long = 0

      For Each oRow As DataRow In moFactura.DataSet.Tables(moFactura.TableName).Rows
         If oRow("FacturaId") = lngID Then
            Return intRow
         End If

         intRow += 1
      Next

      Return 0
   End Function

   Private Function grdFacturaTotalIVA() As Decimal
      Dim decTotal As Decimal = 0
      Dim decExento As Decimal = 0

      If moCompra.FacturaId <> 0 Then
         For Each oRow As DataRow In moFactura.DataSet.Tables(moFactura.TableName).Rows
            decTotal += oRow("IVA")
            decExento += oRow("Exento")
         Next
      Else
         For Each oRow As DataRow In moCompraFac.DataSet.Tables(moCompraFac.TableName).Rows
            decTotal += oRow("IVA")
         Next
      End If

      If clsAppInfo.SepararExento Then
         If moCompra.MonedaId = 1 Then
            decExento = ToDecimal(decExento * clsAppInfo.IVA)
         Else
            decExento = ToDecimal((decExento / moCompra.TipoCambio) * clsAppInfo.IVA)
         End If
      Else
         decExento = 0
      End If
      txtExentoIVA.Text = decExento

      If decTotal > 0 Then
         If moCompra.MonedaId = 1 Then
            Return decTotal
         Else
            Return ToDecimal(decTotal / moCompra.TipoCambio)
         End If
      Else
         Return decTotal
      End If
   End Function

   Private Sub grdFacturaInit()
      With grdFactura
         ebrFactura.Groups(0).Text = "Facturas"
         .ContextMenu = mnuFactura

         .RootTable.Columns("FacturaId").Visible = False

         .RootTable.Columns("TipoFacturaId").Visible = False

         .RootTable.Columns("FacturaNro").Caption = "Nro Factura"
         .RootTable.Columns("FacturaNro").Width = 100
         .RootTable.Columns("FacturaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FacturaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaFecha").Caption = "Fecha"
         .RootTable.Columns("FacturaFecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FacturaFecha").Width = 100
         .RootTable.Columns("FacturaFecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FacturaFecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RegRUCId").Visible = False

         .RootTable.Columns("NroRUC").Caption = "NIT"
         .RootTable.Columns("NroRUC").Width = 100
         .RootTable.Columns("NroRUC").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroRUC").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RegRUCDes").Caption = "Razón Social"
         .RootTable.Columns("RegRUCDes").Width = 150
         .RootTable.Columns("RegRUCDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("RegRUCDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroAutorizacion").Caption = "Nro Autorización"
         .RootTable.Columns("NroAutorizacion").Width = 100
         .RootTable.Columns("NroAutorizacion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroAutorizacion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CodControl").Caption = "Código Control"
         .RootTable.Columns("CodControl").Width = 100
         .RootTable.Columns("CodControl").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CodControl").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaMonto").Caption = "Importe"
         .RootTable.Columns("FacturaMonto").FormatString = DecimalMask()
         .RootTable.Columns("FacturaMonto").Width = 100
         .RootTable.Columns("FacturaMonto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("FacturaMonto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IceIehd").Caption = "ICE/IEHD"
         .RootTable.Columns("IceIehd").FormatString = DecimalMask()
         .RootTable.Columns("IceIehd").Width = 100
         .RootTable.Columns("IceIehd").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IceIehd").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Exento").Caption = "Exento"
         .RootTable.Columns("Exento").FormatString = DecimalMask()
         .RootTable.Columns("Exento").Width = 100
         .RootTable.Columns("Exento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Exento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SubTotal").Caption = "Sub-Total"
         .RootTable.Columns("SubTotal").FormatString = DecimalMask()
         .RootTable.Columns("SubTotal").Width = 100
         .RootTable.Columns("SubTotal").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SubTotal").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Descuento").Caption = "Descuento"
         .RootTable.Columns("Descuento").FormatString = DecimalMask()
         .RootTable.Columns("Descuento").Width = 100
         .RootTable.Columns("Descuento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Descuento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Neto").Caption = "Neto"
         .RootTable.Columns("Neto").FormatString = DecimalMask()
         .RootTable.Columns("Neto").Width = 100
         .RootTable.Columns("Neto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Neto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IVA").Caption = "IVA"
         .RootTable.Columns("IVA").FormatString = DecimalMask()
         .RootTable.Columns("IVA").Width = 100
         .RootTable.Columns("IVA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IVA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteIVA").Caption = "Importe - IVA"
         .RootTable.Columns("ImporteIVA").FormatString = DecimalMask()
         .RootTable.Columns("ImporteIVA").Width = 100
         .RootTable.Columns("ImporteIVA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteIVA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With
   End Sub

   Private Sub grdFactura_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdFactura.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdFactura.RowCount > 0 Then

               '' If Not mboolFacturaDif Then
               If (Not chkFacturaDif.Checked) And (ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex) = 0) Then
                  mnuShowFactura.Enabled = True
                  mnuNewFactura.Enabled = True
                  mnuEditFactura.Enabled = True
                  mnuDeleteFactura.Enabled = True
               Else  'Si Tiene Facturas Diferidas
                  mnuShowFactura.Enabled = True
                  mnuNewFactura.Enabled = False
                  mnuEditFactura.Enabled = False
                  mnuDeleteFactura.Enabled = False
               End If

            Else

               If chkFacturaDif.Checked Or (ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex) <> 0) Then
                  mnuShowFactura.Enabled = False
                  mnuNewFactura.Enabled = False
                  mnuEditFactura.Enabled = False
                  mnuDeleteFactura.Enabled = False
               Else
                  mnuShowFactura.Enabled = False
                  mnuNewFactura.Enabled = True
                  mnuEditFactura.Enabled = False
                  mnuDeleteFactura.Enabled = False
               End If
            End If
         Else
            mnuShowFactura.Enabled = True
            mnuNewFactura.Enabled = False
            mnuEditFactura.Enabled = False
            mnuDeleteFactura.Enabled = False
            ''If mboolFacturaDif And (grdFactura.RowCount > 0) Then '' Solo para compras con facturas Diferidas
            ''   mnuDeleteFactura.Enabled = True
            ''End If
         End If
      End If
   End Sub

   Private Sub grdFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdFactura.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdFactura.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdFactura.GetRow.Cells(grdFactura.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub mnuShowFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowFactura.Click
      Call FacturaDataShow()
   End Sub

   Private Sub mnuNewFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewFactura.Click
      Call FacturaFormNew()
   End Sub

   Private Sub mnuEditFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditFactura.Click
      Call FacturaDataEdit()
   End Sub

   Private Sub mnuDeleteFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteFactura.Click
      ''Call FacturaDataDelete()
      ''If Not mboolFacturaDif And moCompra.FacturaId <> 0 Then  
      If Not chkFacturaDif.Checked And moCompra.FacturaId <> 0 Then
         Call FacturaDataDelete()
      Else
         Call FacturaDifDataDelete()
      End If
   End Sub

   Private Function DuplicateFacturaIdFind(ByVal lngFacturaId As Long, ByVal lngFacturaNro As Long, ByVal strNroAutorzacion As String) As Long
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      DuplicateFacturaIdFind = 0

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaDuplicada
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoFacturaId = 2
            .NroAutorizacion = strNroAutorzacion
            .FacturaNro = lngFacturaNro
            .FacturaId = lngFacturaId

            If .Find Then
               DuplicateFacturaIdFind = .FacturaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

#End Region

#Region " Poliza "

   Private Sub grdPolizaLoad()
      Try
         With moPoliza

            .PolizaId = moCompra.PolizaId
            .FindByPK()

            ''Cargando a la Grilla
            .SelectFilter = clsPoliza.SelectFilters.GridCompra
            .WhereFilter = clsPoliza.WhereFilters.GridCompra
            .OrderByFilter = clsPoliza.OrderByFilters.Grid
            ''.PolizaId = moCompra.PolizaId

            If .Open() Then
               grdPoliza.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdPoliza.RetrieveStructure()
               Call grdPolizaInit()
               txtPolizaIVA.Text = grdPolizaTotal()
            End If
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdPolizaNewEditLoad(ByVal boolNew As Boolean, ByVal oPolizaNew As clsPoliza)
      Dim oRow As DataRow
      Dim oDataTable As DataTable

      Try
         With moPoliza

            oDataTable = .DataSet.Tables(.TableName)

            If boolNew Then
               oRow = oDataTable.NewRow
               RowNewEditPoliza(oRow, oPolizaNew)
               oDataTable.Rows.Add(oRow)

            Else
               oRow = oDataTable.Rows(grdPolizaFindRowId(oPolizaNew.PolizaId))
               RowNewEditPoliza(oRow, oPolizaNew)

            End If

            grdPoliza.DataSource = .DataSet.Tables(.TableName).DefaultView
            grdPoliza.RetrieveStructure()
            Call grdPolizaInit()

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub RowNewEditPoliza(ByRef oRow As DataRow, ByVal oPoliza As clsPoliza)

      ''Para guardar en la BD
      moPoliza.PolizaId = oPoliza.PolizaId
      moPoliza.GestionId = oPoliza.GestionId
      moPoliza.EmpresaId = oPoliza.EmpresaId
      moPoliza.CompId = oPoliza.CompId
      moPoliza.MesId = oPoliza.MesId
      moPoliza.PolizaFecha = oPoliza.PolizaFecha
      moPoliza.PolizaNro = oPoliza.PolizaNro
      moPoliza.AduanaId = oPoliza.AduanaId
      moPoliza.AduanaNIT = oPoliza.AduanaNIT
      moPoliza.AduanaDes = oPoliza.AduanaDes
      moPoliza.PolizaMonto = oPoliza.PolizaMonto
      moPoliza.IVA = oPoliza.IVA
      moPoliza.IceIehd = oPoliza.IceIehd
      moPoliza.PlanId = oPoliza.PlanId
      moPoliza.PlanAddId = oPoliza.PlanAddId
      moPoliza.CentroCostoId = oPoliza.CentroCostoId
      moPoliza.CentroCostoDetId = oPoliza.CentroCostoDetId
      moPoliza.SucursalId = oPoliza.SucursalId
      moPoliza.Bancarizar = oPoliza.Bancarizar
      moPoliza.TipoFacCompraId = oPoliza.TipoFacCompraId
      moPoliza.EstadoId = 13 ''Estado en Memoria q Indica que ha sido Editado

      ''Para mostrar en la Grilla
      oRow("PolizaId") = oPoliza.PolizaId
      oRow("CompId") = oPoliza.CompId
      oRow("PolizaNro") = oPoliza.PolizaNro
      oRow("PolizaFecha") = ToStr(oPoliza.PolizaFecha)
      oRow("AduanaId") = oPoliza.AduanaId
      oRow("AduanaNIT") = oPoliza.AduanaNIT
      oRow("AduanaDes") = oPoliza.AduanaDes
      oRow("PolizaMonto") = oPoliza.PolizaMonto
      oRow("IVA") = oPoliza.IVA
      oRow("IceIehd") = oPoliza.IceIehd
      oRow("PlanId") = oPoliza.PlanId

   End Sub

   Private Sub PolizaDataShow()
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      Try
         If grdPoliza.RowCount > 0 Then
            With oPoliza
               ''.PolizaId = ToLong(grdPoliza.GetValue("PolizaId"))

               ''If .FindByPK Then
               Dim frm As New frmPolizaEdit

               oPoliza.PolizaId = moPoliza.PolizaId
               oPoliza.GestionId = moPoliza.GestionId
               oPoliza.EmpresaId = moPoliza.EmpresaId

               oPoliza.CompId = moPoliza.CompId
               oPoliza.MesId = moPoliza.MesId
               oPoliza.PolizaFecha = moPoliza.PolizaFecha
               oPoliza.PolizaNro = moPoliza.PolizaNro
               oPoliza.AduanaId = moPoliza.AduanaId
               oPoliza.AduanaNIT = moPoliza.AduanaNIT
               oPoliza.AduanaDes = moPoliza.AduanaDes
               oPoliza.PolizaMonto = moPoliza.PolizaMonto
               oPoliza.IVA = moPoliza.IVA
               oPoliza.IceIehd = moPoliza.IceIehd
               oPoliza.PlanId = moPoliza.PlanId
               oPoliza.PlanAddId = moPoliza.PlanAddId
               oPoliza.CentroCostoId = moPoliza.CentroCostoId
               oPoliza.CentroCostoDetId = moPoliza.CentroCostoDetId
               oPoliza.SucursalId = moPoliza.SucursalId
               oPoliza.Bancarizar = moPoliza.Bancarizar
               oPoliza.TipoFacCompraId = moPoliza.TipoFacCompraId
               oPoliza.EstadoId = 11

               frm.NewRecord = False
               frm.Editing = False
               frm.DataObject = oPoliza

               frm.ShowDialog()
               frm.Dispose()
               ''End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza = Nothing

      End Try
   End Sub

   Private Sub PolizaFormNew()
      Dim frm As New frmPolizaEdit
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      Try
         If mboolAdding Or mboolEditing Then
            If moCompra.PolizaId = 0 Then
               If moCompra.FacturaId = 0 Then
                  ''If Not mboolFacturaDif Then
                  If Not chkFacturaDif.Checked Then
                     If ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex) = 0 Then ''moCompra.TipoRetencionId = 0 Then 
                        With frm
                           .NewRecord = True
                           .Editing = False

                           oPoliza.EmpresaId = moCompra.EmpresaId
                           oPoliza.GestionId = moCompra.GestionId
                           oPoliza.PolizaFecha = ConvertDMY(moCompra.Fecha)
                           oPoliza.EstadoId = 11

                           If clsAppInfo.SucursalId Then
                              oPoliza.SucursalId = moCompra.SucursalId
                           Else
                              oPoliza.SucursalId = AlmacenSucursalIdFind(moCompra.AlmacenId)
                           End If
                           oPoliza.CentroCostoId = moCompra.CentroCostoId

                           .CompFecha = ConvertDMY(moCompra.Fecha)
                           .PolizaIdOrg = moPolizaOrg.PolizaId
                           .DataObject = oPoliza
                           .ShowDialog()

                           If .Changed Then
                              moCompra.PolizaId = -1
                              Call grdPolizaNewEditLoad(True, frm.DataObject)
                              Call grdPolizaFindRow(frm.ID)
                              cboTipoRetencion.ReadOnly = True
                              cboTipoRetencion.Enabled = False
                              chkFacturaDif.Enabled = False
                           End If
                           frm.Dispose()
                        End With

                     Else
                        MessageBox.Show("Imposible Ingresar una Poliza ya que Existe Retencion para esta Compra ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("Imposible Ingresar una Poliza de Importación ya que la Opción de Factura Diferida esta Habilitada ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Ya Existe una Factura Para la Nota de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Ya Existe una Poliza de Importación Para la Nota de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Imposible Adicionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub PolizaDataEdit()
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      Try
         If grdPoliza.RowCount > 0 Then
            If mboolAdding Or mboolEditing Then
               With oPoliza
                  ''.PolizaId = ToLong(grdPoliza.GetValue("PolizaId"))

                  ''If .FindByPK Then
                  Dim frm As New frmPolizaEdit

                  oPoliza.PolizaId = moPoliza.PolizaId
                  oPoliza.GestionId = moPoliza.GestionId
                  oPoliza.EmpresaId = moPoliza.EmpresaId

                  oPoliza.CompId = moPoliza.CompId
                  oPoliza.MesId = moPoliza.MesId
                  oPoliza.PolizaFecha = moPoliza.PolizaFecha
                  oPoliza.PolizaNro = moPoliza.PolizaNro
                  oPoliza.AduanaId = moPoliza.AduanaId
                  oPoliza.AduanaNIT = moPoliza.AduanaNIT
                  oPoliza.AduanaDes = moPoliza.AduanaDes
                  oPoliza.PolizaMonto = moPoliza.PolizaMonto
                  oPoliza.IVA = moPoliza.IVA
                  oPoliza.IceIehd = moPoliza.IceIehd
                  oPoliza.PlanId = moPoliza.PlanId
                  oPoliza.PlanAddId = moPoliza.PlanAddId
                  oPoliza.CentroCostoId = moPoliza.CentroCostoId
                  oPoliza.CentroCostoDetId = moPoliza.CentroCostoDetId
                  oPoliza.SucursalId = moPoliza.SucursalId
                  oPoliza.Bancarizar = moPoliza.Bancarizar
                  oPoliza.TipoFacCompraId = moPoliza.TipoFacCompraId
                  oPoliza.EstadoId = 11

                  frm.CompFecha = ConvertDMY(moCompra.Fecha)
                  frm.PolizaIdOrg = moPolizaOrg.PolizaId
                  frm.NewRecord = False
                  frm.Editing = True
                  frm.DataObject = oPoliza
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdPolizaNewEditLoad(False, frm.DataObject)
                     Call grdPolizaFindRow(frm.ID)

                  End If
                  frm.Dispose()

                  ''End If
               End With
            Else
               MessageBox.Show("Imposible Editar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza = Nothing

      End Try
   End Sub

   Private Sub PolizaDataDelete()
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)
      Dim lngCompId As Long

      Try
         If grdPoliza.RowCount > 0 Then
            If mboolAdding Or mboolEditing Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                  moCompra.PolizaId = 0
                  Call grdPolizaLoad()
                  cboTipoRetencion.ReadOnly = False
                  cboTipoRetencion.Enabled = True
                  chkFacturaDif.Enabled = True

               End If
            Else
               MessageBox.Show("Imposible Eliminar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza = Nothing

      End Try
   End Sub

   Private Function PolizaCompIdFind(ByVal lngPolizaId As Long, ByRef lngCompId As Long) As Boolean
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      PolizaCompIdFind = False

      Try
         With oPoliza
            .PolizaId = lngPolizaId

            If .FindByPK Then
               .CompId = lngCompId
               PolizaCompIdFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza.Dispose()

      End Try
   End Function

   Private Function PolizaDelete(ByVal lngPolizaId As Integer) As Boolean
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      PolizaDelete = True

      Try

         With oPoliza
            .WhereFilter = clsPoliza.WhereFilters.PrimaryKey
            .PolizaId = lngPolizaId

            If .Delete Then
               PolizaDelete = True
            End If
         End With


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza.Dispose()

      End Try
   End Function

   Private Sub grdPolizaFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdPoliza.RootTable.Columns("PolizaId")

      grdPoliza.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Function grdPolizaFindRowId(ByVal lngID As Long) As Long
      Dim intRow As Long = 0

      For Each oRow As DataRow In moPoliza.DataSet.Tables(moPoliza.TableName).Rows
         If oRow("PolizaId") = lngID Then
            Return intRow
         End If

         intRow += 1
      Next

      Return 0
   End Function

   Private Function grdPolizaTotal() As Decimal
      Dim decTotal As Decimal = 0

      With moPoliza
         For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
            decTotal += oRow("Iva")
         Next
      End With

      Return decTotal
   End Function

   Private Sub grdPolizaInit()
      With grdPoliza
         ebrPoliza.Groups(0).Text = "Polizas"
         .ContextMenu = mnuPoliza

         .RootTable.Columns("PolizaId").Visible = False

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("PolizaNro").Caption = "Nro Poliza"
         .RootTable.Columns("PolizaNro").Width = 100
         .RootTable.Columns("PolizaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PolizaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PolizaFecha").Caption = "Fecha"
         .RootTable.Columns("PolizaFecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("PolizaFecha").Width = 100
         .RootTable.Columns("PolizaFecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PolizaFecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AduanaId").Visible = False

         .RootTable.Columns("AduanaNIT").Caption = "NIT"
         .RootTable.Columns("AduanaNIT").Width = 100
         .RootTable.Columns("AduanaNIT").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AduanaNIT").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AduanaDes").Caption = "Agencia Aduanera"
         .RootTable.Columns("AduanaDes").Width = 100
         .RootTable.Columns("AduanaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AduanaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IVA").Caption = "IVA"
         .RootTable.Columns("IVA").FormatString = DecimalMask()
         .RootTable.Columns("IVA").Width = 100
         .RootTable.Columns("IVA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IVA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PolizaMonto").Caption = "Monto"
         .RootTable.Columns("PolizaMonto").FormatString = DecimalMask()
         .RootTable.Columns("PolizaMonto").Width = 100
         .RootTable.Columns("PolizaMonto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PolizaMonto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IceIehd").Caption = "ICE"
         .RootTable.Columns("IceIehd").FormatString = DecimalMask()
         .RootTable.Columns("IceIehd").Width = 100
         .RootTable.Columns("IceIehd").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IceIehd").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanId").Visible = False
      End With
   End Sub

   Private Sub grdPoliza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdPoliza.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdPoliza.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdPoliza.GetRow.Cells(grdPoliza.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub grdPoliza_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdPoliza.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdPoliza.RowCount > 0 Then
               mnuShowPoliza.Enabled = True
               mnuNewPoliza.Enabled = True
               mnuEditPoliza.Enabled = True
               mnuDeletePoliza.Enabled = True
            Else
               mnuShowPoliza.Enabled = False
               mnuNewPoliza.Enabled = True
               mnuEditPoliza.Enabled = False
               mnuDeletePoliza.Enabled = False
            End If
         Else
            mnuShowPoliza.Enabled = True
            mnuNewPoliza.Enabled = False
            mnuEditPoliza.Enabled = False
            mnuDeletePoliza.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuShowPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowPoliza.Click
      Call PolizaDataShow()
   End Sub

   Private Sub mnuNewPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewPoliza.Click
      Call PolizaFormNew()
   End Sub

   Private Sub mnuEditPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditPoliza.Click
      Call PolizaDataEdit()
   End Sub

   Private Sub mnuDeletePoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeletePoliza.Click
      Call PolizaDataDelete()
   End Sub

   Private Function DuplicatePolizaIdFind(ByVal lngPolizaId As Long, ByVal strPolizaNro As String) As Long
      Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

      DuplicatePolizaIdFind = 0

      Try
         With oPoliza
            .SelectFilter = clsPoliza.SelectFilters.All
            .WhereFilter = clsPoliza.WhereFilters.PolizaDuplicada
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .PolizaNro = strPolizaNro
            .PolizaId = lngPolizaId

            If .Find Then
               DuplicatePolizaIdFind = .PolizaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPoliza.Dispose()

      End Try
   End Function

#End Region

#Region " CompraOtroCosto "

   Private Sub moDataSetInitCompraOtroCosto()

      moDataSet = New DataSet("Tablas")
      moDataTableCompOtroCosto = moDataSet.Tables.Add(moCompraOtroCosto.TableName)
      moDataTableCompOtroCosto.Columns.Add("CompraOtroCostoId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("CompraId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("Fecha", Type.GetType("System.String"))
      moDataTableCompOtroCosto.Columns.Add("PlanOtroCostoId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("PlanOtroCostoDes", Type.GetType("System.String"))
      moDataTableCompOtroCosto.Columns.Add("PlanIdOtroCosto", Type.GetType("System.Int32"))  'PlanId
      moDataTableCompOtroCosto.Columns.Add("CompraOtroCostoDes", Type.GetType("System.String"))
      moDataTableCompOtroCosto.Columns.Add("MonedaId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("MonedaDes", Type.GetType("System.String"))
      moDataTableCompOtroCosto.Columns.Add("Monto", Type.GetType("System.Decimal"))
      moDataTableCompOtroCosto.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("FacturaId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("FacturaNro", Type.GetType("System.String"))
      moDataTableCompOtroCosto.Columns.Add("FacturaIdOrg", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("PlanAddId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("CentroCostoId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("CentroCostoDetId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("SucursalId", Type.GetType("System.Int32"))
      moDataTableCompOtroCosto.Columns.Add("Estado", Type.GetType("System.String"))
      moDataTableCompOtroCosto.Columns.Add("CostoIdNro", Type.GetType("System.Int32")) 'es para saber poder editarlo


      modtDeleteCompraOtroCosto = moDataSet.Tables.Add("DataDeleteCompraOtroCosto")

      modtDeleteCompraOtroCosto.Columns.Add("CompraOtroCostoId", Type.GetType("System.Int32"))
      modtDeleteCompraOtroCosto.Columns.Add("CompraId", Type.GetType("System.Int32"))
      modtDeleteCompraOtroCosto.Columns.Add("PlanOtroCostoId", Type.GetType("System.Int32"))
      modtDeleteCompraOtroCosto.Columns.Add("PlanIdOtroCosto", Type.GetType("System.Int32"))
      modtDeleteCompraOtroCosto.Columns.Add("Monto", Type.GetType("System.Decimal"))
      modtDeleteCompraOtroCosto.Columns.Add("FacturaId", Type.GetType("System.Int32"))
      modtDeleteCompraOtroCosto.Columns.Add("Estado", Type.GetType("System.String"))


      '----Facturas de Otros Cotos
      modtFacturaOtroCosto = moDataSet.Tables.Add("FacturaOtroCosto")
      modtFacturaOtroCosto.Columns.Add("FacturaId", Type.GetType("System.Int32"))
      modtFacturaOtroCosto.Columns.Add("Mes", Type.GetType("System.Int32"))
      modtFacturaOtroCosto.Columns.Add("SucursalId", Type.GetType("System.Int32"))
      ''modtFacturaOtroCosto.Columns.Add("DosificaId", Type.GetType("System.Int32"))
      ''modtFacturaOtroCosto.Columns.Add("TipoCompId", Type.GetType("System.Int32"))
      ''modtFacturaOtroCosto.Columns.Add("CompId", Type.GetType("System.Int32"))
      ''modtFacturaOtroCosto.Columns.Add("CompDetId", Type.GetType("System.Int32"))
      modtFacturaOtroCosto.Columns.Add("TipoFacturaId", Type.GetType("System.Int32"))
      modtFacturaOtroCosto.Columns.Add("FacturaFecha", Type.GetType("System.String"))
      modtFacturaOtroCosto.Columns.Add("FacturaNro", Type.GetType("System.Int32"))
      modtFacturaOtroCosto.Columns.Add("FacturaMonto", Type.GetType("System.Decimal"))
      modtFacturaOtroCosto.Columns.Add("RegRUCId", Type.GetType("System.Int32"))
      modtFacturaOtroCosto.Columns.Add("NroRUC", Type.GetType("System.String"))
      modtFacturaOtroCosto.Columns.Add("RegRUCDes", Type.GetType("System.String"))
      modtFacturaOtroCosto.Columns.Add("NroAutorizacion", Type.GetType("System.String"))
      modtFacturaOtroCosto.Columns.Add("CodControl", Type.GetType("System.String"))
      modtFacturaOtroCosto.Columns.Add("IVA", Type.GetType("System.Decimal"))
      modtFacturaOtroCosto.Columns.Add("IceIehd", Type.GetType("System.Decimal"))
      modtFacturaOtroCosto.Columns.Add("Exento", Type.GetType("System.Decimal"))
      modtFacturaOtroCosto.Columns.Add("Descuento", Type.GetType("System.Decimal"))
      modtFacturaOtroCosto.Columns.Add("TipoFacCompraId", Type.GetType("System.Int32"))
      modtFacturaOtroCosto.Columns.Add("FacturaObs", Type.GetType("System.String"))
      modtFacturaOtroCosto.Columns.Add("Bancarizar", Type.GetType("System.Int32"))
      modtFacturaOtroCosto.Columns.Add("Estado", Type.GetType("System.String"))
      modtFacturaOtroCosto.Columns.Add("CostoIdNro", Type.GetType("System.Int32")) 'es para saber poder editarlo

      modtDeleteFacturaOtroCosto = moDataSet.Tables.Add("DataDeleteFacturaOtroCosto")
      modtDeleteFacturaOtroCosto.Columns.Add("FacturaId", Type.GetType("System.Int32"))
      modtDeleteFacturaOtroCosto.Columns.Add("FacturaFecha", Type.GetType("System.String"))
      modtDeleteFacturaOtroCosto.Columns.Add("FacturaMonto", Type.GetType("System.Decimal"))
      modtDeleteFacturaOtroCosto.Columns.Add("Estado", Type.GetType("System.String"))

   End Sub

   Private Function GetRowCompraOtroCostoShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTableCompOtroCosto.NewRow

      oRow("CostoIdNro") = CostoIdNro
      oRow("CompraOtroCostoId") = oDataRow("CompraOtroCostoId")
      oRow("CompraId") = oDataRow("CompraId")
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
      oRow("PlanOtroCostoId") = oDataRow("PlanOtroCostoId")
      oRow("PlanOtroCostoDes") = oDataRow("PlanOtroCostoDes")
      oRow("PlanIdOtroCosto") = oDataRow("PlanIdOtroCosto")
      oRow("CompraOtroCostoDes") = oDataRow("CompraOtroCostoDes")
      oRow("MonedaId") = oDataRow("MonedaId")
      oRow("MonedaDes") = oDataRow("MonedaDes")
      oRow("Monto") = oDataRow("Monto")
      oRow("CompId") = oDataRow("CompId")
      oRow("PlanId") = oDataRow("PlanId")
      oRow("FacturaId") = oDataRow("FacturaId")
      oRow("FacturaNro") = ""
      oRow("FacturaIdOrg") = oDataRow("FacturaId")
      oRow("PlanAddId") = oDataRow("PlanAddId")
      oRow("CentroCostoId") = oDataRow("CentroCostoId")
      oRow("CentroCostoDetId") = oDataRow("CentroCostoDetId")
      oRow("SucursalId") = oDataRow("SucursalId")

      oRow("Estado") = "Show"

      Return oRow
   End Function

   Private Function GetRowCompraOtroCostoNew(ByVal oCompraOtroCosto As clsCompraOtroCosto) As DataRow
      Dim oRow As DataRow
      oRow = moDataTableCompOtroCosto.NewRow

      oRow("CostoIdNro") = CostoIdNro
      oRow("CompraOtroCostoId") = 0
      oRow("CompraId") = oCompraOtroCosto.CompraId
      oRow("Fecha") = ToStr(oCompraOtroCosto.Fecha)
      oRow("PlanOtroCostoId") = oCompraOtroCosto.PlanOtroCostoId
      oRow("PlanOtroCostoDes") = PlanOtroCostoDesFind(oCompraOtroCosto.PlanOtroCostoId)
      oRow("PlanIdOtroCosto") = PlanOtroCosto_PlanIdFind(oCompraOtroCosto.PlanOtroCostoId)
      oRow("CompraOtroCostoDes") = oCompraOtroCosto.CompraOtroCostoDes
      oRow("MonedaId") = oCompraOtroCosto.MonedaId
      oRow("MonedaDes") = MonedaDesFind(oCompraOtroCosto.MonedaId)
      oRow("Monto") = oCompraOtroCosto.Monto
      oRow("CompId") = oCompraOtroCosto.CompId
      oRow("PlanId") = oCompraOtroCosto.PlanId
      oRow("FacturaId") = oCompraOtroCosto.FacturaId
      oRow("FacturaNro") = 0
      oRow("FacturaIdOrg") = 0
      oRow("PlanAddId") = oCompraOtroCosto.PlanAddId
      oRow("CentroCostoId") = oCompraOtroCosto.CentroCostoId
      oRow("CentroCostoDetId") = oCompraOtroCosto.CentroCostoDetId
      oRow("SucursalId") = oCompraOtroCosto.SucursalId

      oRow("Estado") = "New"

      Return oRow
   End Function

   Private Sub RowCompraOtroCostoNewEdit(ByRef oRow As DataRow, ByVal oCompraOtroCosto As clsCompraOtroCosto, ByVal strEstado As String)

      oRow("CompraId") = oCompraOtroCosto.CompraId
      oRow("Fecha") = ToStr(oCompraOtroCosto.Fecha)
      oRow("PlanOtroCostoId") = oCompraOtroCosto.PlanOtroCostoId
      oRow("PlanOtroCostoDes") = PlanOtroCostoDesFind(oCompraOtroCosto.PlanOtroCostoId)
      oRow("PlanIdOtroCosto") = PlanOtroCosto_PlanIdFind(oCompraOtroCosto.PlanOtroCostoId)
      oRow("CompraOtroCostoDes") = oCompraOtroCosto.CompraOtroCostoDes
      oRow("MonedaId") = oCompraOtroCosto.MonedaId
      oRow("MonedaDes") = MonedaDesFind(oCompraOtroCosto.MonedaId)
      oRow("Monto") = oCompraOtroCosto.Monto
      oRow("CompId") = oCompraOtroCosto.CompId
      oRow("PlanId") = oCompraOtroCosto.PlanId
      oRow("FacturaId") = oCompraOtroCosto.FacturaId
      'oRow("FacturaNro") = oCompraOtroCosto.FacturaId
      'oRow("FacturaIdOrg") = oCompraOtroCosto.FacturaId
      oRow("PlanAddId") = oCompraOtroCosto.PlanAddId
      oRow("CentroCostoId") = oCompraOtroCosto.CentroCostoId
      oRow("CentroCostoDetId") = oCompraOtroCosto.CentroCostoDetId
      oRow("SucursalId") = oCompraOtroCosto.SucursalId

      oRow("Estado") = strEstado
   End Sub

   Private Function CompraOtroCostoCompIdLoad() As Long
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)

      Try

         CompraOtroCostoCompIdLoad = 0

         With oCompraOtroCosto
            .SelectFilter = clsCompraOtroCosto.SelectFilters.All
            .WhereFilter = clsCompraOtroCosto.WhereFilters.CompraId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = moCompra.CompraId
            CompraOtroCostoCompIdLoad = 0

            If .Open Then

               While .Read
                  If .CompId <> 0 Then
                     CompraOtroCostoCompIdLoad = .CompId
                     Exit While
                  End If
                  .MoveNext()
               End While

            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompraOtroCosto.Dispose()
      End Try
   End Function

   'Private Sub grdCompraOtroCostoLoad()

   '   Try
   '      With moCompraOtroCosto
   '         .SelectFilter = clsCompraOtroCosto.SelectFilters.Grid
   '         .WhereFilter = clsCompraOtroCosto.WhereFilters.Grid
   '         .OrderByFilter = clsCompraOtroCosto.OrderByFilters.Grid
   '         .EmpresaId = moCompra.EmpresaId
   '         .CompraId = moCompra.CompraId

   '         If .Open() Then
   '            moDataSetInitCompraOtroCosto()

   '            For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
   '               CostoIdNro += 1
   '               moDataTableCompOtroCosto.Rows.Add(GetRowCompraOtroCostoShow(oRow))

   '               If oRow("FacturaId") > 0 Then ' Si tiene Factura el Costo
   '                  FacturaOtroCostoRowShow(ToLong(oRow("FacturaId")), CostoIdNro)
   '               End If
   '            Next

   '            grdCompraOtroCosto.DataSource = moDataSet.Tables(.TableName).DefaultView
   '            grdCompraOtroCosto.RetrieveStructure()
   '            Call grdCompraOtroCostoInit()

   '            txtMontoOtroConIva.Text = grdCompraOtroCostoTotal(True)
   '            txtMontoOtroSinIva.Text = grdCompraOtroCostoTotal(False)
   '         End If

   '         .CloseConection()
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   End Try
   'End Sub

   Private Sub grdCompraOtroCostoLoad()
      Dim oRowShow As DataRow
      Dim oRowFactura As DataRow

      Try
         With moCompraOtroCosto
            .SelectFilter = clsCompraOtroCosto.SelectFilters.Grid
            .WhereFilter = clsCompraOtroCosto.WhereFilters.Grid
            .OrderByFilter = clsCompraOtroCosto.OrderByFilters.Grid
            .EmpresaId = moCompra.EmpresaId
            .CompraId = moCompra.CompraId

            If .Open() Then
               moDataSetInitCompraOtroCosto()

               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  CostoIdNro += 1
                  'moDataTableCompOtroCosto.Rows.Add(GetRowCompraOtroCostoShow(oRow))
                  oRowShow = GetRowCompraOtroCostoShow(oRow)
                  moDataTableCompOtroCosto.Rows.Add(oRowShow)

                  If oRow("FacturaId") > 0 Then ' Si tiene Factura el Costo
                     'FacturaOtroCostoRowShow(ToLong(oRow("FacturaId")), CostoIdNro)
                     oRowFactura = FacturaOtroCostoRowShow(ToLong(oRow("FacturaId")), CostoIdNro)
                     If Not (oRowFactura Is Nothing) Then
                        oRowShow("FacturaNro") = oRowFactura("FacturaNro")
                     Else
                        oRowShow("FacturaNro") = "Error"
                        mboolErrorFacturaOtroCosto = True
                     End If
                  End If
               Next

               grdCompraOtroCosto.DataSource = moDataSet.Tables(.TableName).DefaultView
               grdCompraOtroCosto.RetrieveStructure()
               Call grdCompraOtroCostoInit()

               txtMontoOtroConIva.Text = grdCompraOtroCostoTotal(True)
               txtMontoOtroSinIva.Text = grdCompraOtroCostoTotal(False)
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub CompraOtroCostoDataShow()
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)
      Dim frm As New frmCompraOtroCostoEdit

      Try
         If grdCompraOtroCosto.RowCount > 0 Then

            If ToStr(grdCompraOtroCosto.GetValue("Estado")) = "Show" Then
               With oCompraOtroCosto
                  .CompraOtroCostoId = ToLong(grdCompraOtroCosto.GetValue("CompraOtroCostoId"))

                  If .FindByPK Then

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oCompraOtroCosto

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            ElseIf ToStr(grdCompraOtroCosto.GetValue("Estado")) = "New" Or ToStr(grdCompraOtroCosto.GetValue("Estado")) = "Edit" Then
               With frm

                  .NewRecord = False
                  .Editing = False

                  oCompraOtroCosto.EmpresaId = moCompra.EmpresaId
                  oCompraOtroCosto.GestionId = moCompra.GestionId
                  oCompraOtroCosto.CompraId = moCompra.CompraId
                  oCompraOtroCosto.Fecha = ToStr(grdCompraOtroCosto.GetValue("Fecha"))
                  oCompraOtroCosto.MonedaId = moCompra.MonedaId
                  oCompraOtroCosto.EstadoId = moCompra.EstadoId

                  oCompraOtroCosto.CompraOtroCostoId = ToLong(grdCompraOtroCosto.GetValue("CompraOtroCostoId"))
                  oCompraOtroCosto.PlanOtroCostoId = ToLong(grdCompraOtroCosto.GetValue("PlanOtroCostoId"))
                  oCompraOtroCosto.CompraOtroCostoDes = ToStr(grdCompraOtroCosto.GetValue("CompraOtroCostoDes"))
                  oCompraOtroCosto.Monto = ToDecimal(grdCompraOtroCosto.GetValue("Monto"))
                  oCompraOtroCosto.CompId = ToLong(grdCompraOtroCosto.GetValue("CompId"))
                  oCompraOtroCosto.PlanId = ToLong(grdCompraOtroCosto.GetValue("PlanId"))
                  oCompraOtroCosto.FacturaId = ToLong(grdCompraOtroCosto.GetValue("FacturaId"))
                  oCompraOtroCosto.PlanAddId = ToLong(grdCompraOtroCosto.GetValue("PlanAddId"))
                  oCompraOtroCosto.CentroCostoId = ToLong(grdCompraOtroCosto.GetValue("CentroCostoId"))
                  oCompraOtroCosto.CentroCostoDetId = ToLong(grdCompraOtroCosto.GetValue("CentroCostoDetId"))
                  oCompraOtroCosto.SucursalId = ToLong(grdCompraOtroCosto.GetValue("SucursalId"))

                  .DataObject = oCompraOtroCosto

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
         oCompraOtroCosto = Nothing

      End Try
   End Sub

   Private Sub CompraOtroCostoFormNew()
      Dim frm As New frmCompraOtroCostoEdit
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)

      Try
         If mboolAdding Or mboolEditing Then
            With frm
               .NewRecord = True
               .Editing = False

               oCompraOtroCosto.EmpresaId = moCompra.EmpresaId
               oCompraOtroCosto.GestionId = moCompra.GestionId
               oCompraOtroCosto.CompraId = moCompra.CompraId
               oCompraOtroCosto.Fecha = ConvertDMY(moCompra.Fecha)
               oCompraOtroCosto.MonedaId = moCompra.MonedaId
               oCompraOtroCosto.EstadoId = moCompra.EstadoId

               oCompraOtroCosto.SucursalId = AlmacenSucursalIdFind(moCompra.AlmacenId)
               oCompraOtroCosto.CentroCostoId = moCompra.CentroCostoId

               .DataObject = oCompraOtroCosto
               .ShowDialog()

               If .Changed Then
                  CostoIdNro += 1
                  Call DataViewAll()

                  moDataTableCompOtroCosto.Rows.Add(GetRowCompraOtroCostoNew(frm.DataObject))
                  frm.ID = CostoIdNro

                  Call grdCompraOtroCostoFindRow(frm.ID)
                  Call grdProrrateoLoad(True)
                  Call TotalOtrosCostos()

               End If
               frm.Dispose()
            End With
         Else
            MessageBox.Show("Imposible Adicionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub CompraOtroCostoDataEdit()
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)
      Dim frm As New frmCompraOtroCostoEdit

      Try
         If grdCompraOtroCosto.RowCount > 0 Then
            If mboolAdding Or mboolEditing Then
               If ToStr(grdCompraOtroCosto.GetValue("Estado")) = "Show" Then

                  With oCompraOtroCosto
                     .CompraOtroCostoId = ToLong(grdCompraOtroCosto.GetValue("CompraOtroCostoId"))

                     If .FindByPK Then

                        frm.NewRecord = False
                        frm.Editing = True
                        frm.DataObject = oCompraOtroCosto

                        frm.ID = ToLong(grdCompraOtroCosto.GetValue("CostoIdNro"))

                        frm.ShowDialog()

                        If frm.Changed Then

                           Call DataViewAll()
                           Call RowCompraOtroCostoNewEdit(moDataTableCompOtroCosto.Rows(grdCompraOtroCostoFindRowId(frm.ID)), frm.DataObject, "Edit")

                           If (ToLong(grdCompraOtroCosto.GetValue("FacturaId")) > 0) Then
                              FacturaUpdateMonto(ToLong(grdCompraOtroCosto.GetValue("CostoIdNro")), frm.DataObject.Monto)

                           End If

                           Call grdProrrateoLoad(True)
                           Call TotalOtrosCostos()

                        End If
                        frm.Dispose()
                     End If
                  End With
               ElseIf ToStr(grdCompraOtroCosto.GetValue("Estado")) = "New" Or ToStr(grdCompraOtroCosto.GetValue("Estado")) = "Edit" Then
                  With frm
                     .NewRecord = False
                     .Editing = True

                     oCompraOtroCosto.EmpresaId = moCompra.EmpresaId
                     oCompraOtroCosto.GestionId = moCompra.GestionId
                     oCompraOtroCosto.CompraId = moCompra.CompraId
                     oCompraOtroCosto.MonedaId = moCompra.MonedaId
                     oCompraOtroCosto.EstadoId = moCompra.EstadoId


                     oCompraOtroCosto.Fecha = ToStr(grdCompraOtroCosto.GetValue("Fecha")) 'Propio del COsto
                     oCompraOtroCosto.CompraOtroCostoId = ToLong(grdCompraOtroCosto.GetValue("CompraOtroCostoId"))
                     oCompraOtroCosto.PlanOtroCostoId = ToLong(grdCompraOtroCosto.GetValue("PlanOtroCostoId"))
                     oCompraOtroCosto.CompraOtroCostoDes = ToStr(grdCompraOtroCosto.GetValue("CompraOtroCostoDes"))
                     oCompraOtroCosto.Monto = ToDecimal(grdCompraOtroCosto.GetValue("Monto"))
                     oCompraOtroCosto.CompId = ToLong(grdCompraOtroCosto.GetValue("CompId"))
                     oCompraOtroCosto.PlanId = ToLong(grdCompraOtroCosto.GetValue("PlanId"))
                     oCompraOtroCosto.FacturaId = ToLong(grdCompraOtroCosto.GetValue("FacturaId"))
                     oCompraOtroCosto.PlanAddId = ToLong(grdCompraOtroCosto.GetValue("PlanAddId"))
                     oCompraOtroCosto.CentroCostoId = ToLong(grdCompraOtroCosto.GetValue("CentroCostoId"))
                     oCompraOtroCosto.CentroCostoDetId = ToLong(grdCompraOtroCosto.GetValue("CentroCostoDetId"))
                     oCompraOtroCosto.SucursalId = ToLong(grdCompraOtroCosto.GetValue("SucursalId"))

                     .DataObject = oCompraOtroCosto
                     .ID = ToLong(grdCompraOtroCosto.GetValue("CostoIdNro"))
                     .ShowDialog()

                     If .Changed Then

                        Call DataViewAll()

                        If ToStr(grdCompraOtroCosto.GetValue("Estado")) = "Edit" Then
                           Call RowCompraOtroCostoNewEdit(moDataTableCompOtroCosto.Rows(grdCompraOtroCostoFindRowId(frm.ID)), frm.DataObject, "Edit")
                        Else
                           Call RowCompraOtroCostoNewEdit(moDataTableCompOtroCosto.Rows(grdCompraOtroCostoFindRowId(frm.ID)), frm.DataObject, "New")
                        End If

                        If (ToLong(grdCompraOtroCosto.GetValue("FacturaId")) > 0) Then
                           FacturaUpdateMonto(ToLong(grdCompraOtroCosto.GetValue("CostoIdNro")), frm.DataObject.Monto)
                        End If

                        Call grdProrrateoLoad(True)
                        Call TotalOtrosCostos()

                     End If
                     frm.Dispose()
                  End With
               End If

            Else
               MessageBox.Show("Imposible Editar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraOtroCosto = Nothing

      End Try
   End Sub

   Private Sub CompraOtroCostoDataDelete()
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)

      Try
         If grdCompraOtroCosto.RowCount > 0 Then
            If mboolAdding Or mboolEditing Then
               If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                  If ToStr(grdCompraOtroCosto.GetValue("Estado")) <> "New" Then
                     modtDeleteCompraOtroCosto.Rows.Add(GetRowDeleteOtroCosto(moDataTableCompOtroCosto.Rows.Item(grdCompraOtroCosto.Row)))
                  End If

                  If ToLong(grdCompraOtroCosto.GetValue("FacturaId")) > 0 Then
                     FacturaDeleteMemoria(grdCompraOtroCosto.GetValue("CostoIdNro"))
                  End If

                  moDataTableCompOtroCosto.Rows.RemoveAt(grdCompraOtroCosto.Row)

                  Call grdProrrateoLoad(True)
                  Call TotalOtrosCostos()

               End If
            Else
               MessageBox.Show("Imposible Eliminar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraOtroCosto = Nothing

      End Try
   End Sub

   Private Function GetRowDeleteOtroCosto(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = modtDeleteCompraOtroCosto.NewRow

      oRow("CompraOtroCostoId") = oDataRow("CompraOtroCostoId")
      oRow("CompraId") = oDataRow("CompraId")
      oRow("PlanOtroCostoId") = oDataRow("PlanOtroCostoId")
      oRow("PlanIdOtroCosto") = oDataRow("PlanIdOtroCosto")
      oRow("Monto") = oDataRow("Monto")
      oRow("FacturaId") = oDataRow("FacturaId")

      oRow("Estado") = "Delete"

      Return oRow
   End Function

   Private Function ProrrateoDelete(ByVal lngCompraOtroCostoId As Long) As Boolean
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      ProrrateoDelete = False

      Try
         With oProrrateo
            .WhereFilter = clsProrrateo.WhereFilters.CompraOtroCostoIdDelete
            .EmpresaId = moCompra.EmpresaId
            .CompraId = moCompra.CompraId
            .CompraOtroCostoId = lngCompraOtroCostoId

            If .Delete Then
               Return True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo.Dispose()

      End Try
   End Function

   Private Sub grdCompraOtroCostoFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      ''oCol = grdCompraOtroCosto.RootTable.Columns("CompraOtroCostoId")
      oCol = grdCompraOtroCosto.RootTable.Columns("CostoIdNro")

      grdCompraOtroCosto.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Function grdCompraOtroCostoTotal(ByVal boolFactura As Boolean) As Decimal
      Dim decTotal As Decimal = 0

      With moCompraOtroCosto
         For Each oRow As DataRow In moDataSet.Tables(.TableName).Rows
            If boolFactura Then
               If oRow("FacturaId") <> 0 Then
                  decTotal += ToDecimal(oRow("Monto") - ((oRow("Monto") * clsAppInfo.IVA)))
               End If
            Else
               If oRow("FacturaId") = 0 Then
                  decTotal += oRow("Monto")
               End If
            End If
         Next
      End With

      Return decTotal
   End Function

   Private Sub TotalOtrosCostos()

      Dim MontoOtroConIva As Decimal = 0
      Dim MontoOtroSinIva As Decimal = 0

      For Each oRow As DataRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         If oRow("FacturaId") <> 0 Then
            MontoOtroConIva += ToDecimal(oRow("Monto") - ((oRow("Monto") * clsAppInfo.IVA)))
         ElseIf oRow("FacturaId") = 0 Then
            MontoOtroSinIva += oRow("Monto")
         End If
      Next

      txtMontoOtroConIva.Text = MontoOtroConIva
      txtMontoOtroSinIva.Text = MontoOtroSinIva
   End Sub

   Private Sub grdCompraOtroCostoInit()
      With grdCompraOtroCosto
         ebrOtrosCostos.Groups(0).Text = "Otros Costos Aplicables"
         .ContextMenu = mnuOtroCosto

         .RootTable.Columns("CostoIdNro").Visible = False
         .RootTable.Columns("CompraOtroCostoId").Visible = False

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 100
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanOtroCostoId").Visible = False

         .RootTable.Columns("PlanOtroCostoDes").Caption = "Otro Costo"
         .RootTable.Columns("PlanOtroCostoDes").Width = 150
         .RootTable.Columns("PlanOtroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanOtroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanIdOtroCosto").Visible = False

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("CompraOtroCostoDes").Caption = "Descripción"
         .RootTable.Columns("CompraOtroCostoDes").Width = 100
         .RootTable.Columns("CompraOtroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompraOtroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Monto").Caption = "Monto"
         .RootTable.Columns("Monto").FormatString = DecimalMask()
         .RootTable.Columns("Monto").Width = 100
         .RootTable.Columns("Monto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Monto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("FacturaId").Visible = False

         .RootTable.Columns("FacturaNro").Caption = "Nro Factura"
         .RootTable.Columns("FacturaNro").Width = 80
         .RootTable.Columns("FacturaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FacturaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaIdOrg").Visible = False

         .RootTable.Columns("PlanAddId").Visible = False
         .RootTable.Columns("CentroCostoId").Visible = False
         .RootTable.Columns("CentroCostoDetId").Visible = False
         .RootTable.Columns("SucursalId").Visible = False

         .RootTable.Columns("Estado").Visible = False
      End With
   End Sub

   Private Sub DataViewAll()
      grdCompraOtroCosto.RemoveFilters()
   End Sub

   Private Function CompraOtroCostoDelete(ByVal lngCompraOtroCostoId As Long) As Boolean
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)

      Try
         CompraOtroCostoDelete = False

         With oCompraOtroCosto
            .WhereFilter = clsCompraOtroCosto.WhereFilters.PrimaryKey
            .CompraOtroCostoId = lngCompraOtroCostoId

            If .Delete Then
               CompraOtroCostoDelete = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompraOtroCosto.Dispose()

      End Try
   End Function

   Private Function MonedaDesFind(ByVal lngMonedaId As Long) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      MonedaDesFind = ""

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

   Private Function PlanOtroCosto_PlanIdFind(ByVal lngPlanOtroCostoId As Long) As Long
      Dim oPlanOtroCosto As New clsPlanOtroCosto(clsAppInfo.ConnectString)

      PlanOtroCosto_PlanIdFind = 0

      Try
         With oPlanOtroCosto
            .PlanOtroCostoId = lngPlanOtroCostoId

            If .FindByPK Then
               PlanOtroCosto_PlanIdFind = .PlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanOtroCosto.Dispose()

      End Try
   End Function

   Private Function PlanOtroCostoDesFind(ByVal lngPlanOtroCostoId As Long) As String
      Dim oPlanOtroCosto As New clsPlanOtroCosto(clsAppInfo.ConnectString)

      PlanOtroCostoDesFind = ""

      Try
         With oPlanOtroCosto
            .PlanOtroCostoId = lngPlanOtroCostoId

            If .FindByPK Then
               PlanOtroCostoDesFind = .PlanOtroCostoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanOtroCosto.Dispose()

      End Try
   End Function

   Private Function grdCompraOtroCostoFindRowId(ByVal lngID As Long) As Integer
      Dim intRow As Long = 0

      For Each oRow As DataRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         If oRow("CostoIdNro") = lngID Then
            Return intRow
         End If

         intRow += 1
      Next

      Return 0
   End Function

   Private Function grdCompraOtroCostoSave() As Boolean
      Dim oRow As DataRow
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      grdCompraOtroCostoSave = True

      Try

         For Each oRow In modtDeleteCompraOtroCosto.Rows
            If ToStr(oRow("Estado")) = "Delete" Then
               If ProrrateoDelete(ToLong(oRow("CompraOtroCostoId"))) Then
                  CompraOtroCostoDelete(ToLong(oRow("CompraOtroCostoId")))
               End If
            End If
         Next

         'Guardando las facturas de Otros Costos 
         dtFacturaCompraOtroCostoSave()

         For Each oRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
            If ToStr(oRow("Estado")) = "New" Then
               Call grdCompraOtroCostoMove(oRow)
               If moCompraOtroCosto.Insert() Then
                  oRow("CompraOtroCostoId") = moCompraOtroCosto.CompraOtroCostoId
               End If

            ElseIf (ToStr(oRow("Estado")) = "Edit") Or (ToStr(oRow("Estado")) = "Show") Then
               Call grdCompraOtroCostoMove(oRow)
               If moCompraOtroCosto.Update() Then

               End If

            End If
         Next

         Call grdProrrateoLoad(True)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      Finally
         oFactura.Dispose()
      End Try
   End Function

   Private Sub grdCompraOtroCostoMove(ByRef oRow As DataRow)
      With moCompraOtroCosto

         .CompraOtroCostoId = ToLong(oRow("CompraOtroCostoId"))
         .EmpresaId = moCompra.EmpresaId
         .GestionId = moCompra.GestionId
         .CompraId = moCompra.CompraId
         .Fecha = ToDate(oRow("Fecha"))
         .PlanOtroCostoId = ToLong(oRow("PlanOtroCostoId"))
         .CompraOtroCostoDes = ToStr(oRow("CompraOtroCostoDes"))
         .MonedaId = moCompra.MonedaId
         .Monto = ToDecimal(oRow("Monto"))
         .CompId = ToLong(oRow("CompId"))
         .PlanId = ToLong(oRow("PlanId"))
         '.FacturaId = ToLong(oRow("FacturaId"))
         .FacturaId = IIf(ToLong(oRow("FacturaIdOrg")) > 0, ToLong(oRow("FacturaId")), 0)
         .PlanAddId = ToLong(oRow("PlanAddId"))
         .CentroCostoId = ToLong(oRow("CentroCostoId"))
         .CentroCostoDetId = ToLong(oRow("CentroCostoDetId"))
         .SucursalId = ToLong(oRow("SucursalId"))
         .EstadoId = moCompra.EstadoId

      End With
   End Sub

   Private Function FacturaOtroCostoRowShow(ByVal lngFacturaId As Long, ByVal lngCostoIdNro As Long) As DataRow
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim oDataTable As DataTable
      Dim oRow As DataRow

      With oFactura
         .FacturaId = lngFacturaId

         If .FindByPK Then
            oDataTable = moDataSet.Tables("FacturaOtroCosto")

            oRow = oDataTable.NewRow

            oRow("FacturaId") = .FacturaId
            oRow("Mes") = .MesId
            ''oRow("SucursalId") = .SucursalId
            ''oRow("DosificaId") = .DosificaId
            ''oRow("TipoCompId") = .TipoCompId
            ''oRow("CompId") = .CompId
            ''oRow("CompDetId") = .CompDetId
            oRow("TipoFacturaId") = .TipoFacturaId
            oRow("FacturaFecha") = .FacturaFecha
            oRow("FacturaNro") = .FacturaNro
            oRow("FacturaMonto") = .FacturaMonto
            oRow("RegRUCId") = .RegRUCId
            oRow("NroRUC") = .NroRUC
            oRow("RegRUCDes") = .RegRUCDes
            oRow("NroAutorizacion") = .NroAutorizacion
            oRow("CodControl") = .CodControl
            oRow("IVA") = .IVA
            oRow("IceIehd") = .IceIehd
            oRow("Exento") = .Exento
            oRow("Descuento") = .Descuento
            oRow("TipoFacCompraId") = .TipoFacCompraId
            oRow("FacturaObs") = .FacturaObs
            oRow("CostoIdNro") = lngCostoIdNro
            oRow("Bancarizar") = .Bancarizar
            oRow("Estado") = "Show"

            oDataTable.Rows.Add(oRow)
         End If

         Return oRow

      End With

   End Function

   Private Function FacturaOtroCostoRowNew(ByVal oFactura As clsFactura, ByVal lngCostoIdNro As Long) As DataRow

      Dim oRow As DataRow
      oRow = modtFacturaOtroCosto.NewRow

      oRow("FacturaId") = oFactura.FacturaId
      oRow("Mes") = oFactura.MesId
      oRow("SucursalId") = oFactura.SucursalId
      ''oRow("DosificaId") = oFactura.DosificaId
      ''oRow("TipoCompId") = oFactura.TipoCompId
      ''oRow("CompId") = oFactura.CompId
      ''oRow("CompDetId") = oFactura.CompDetId
      oRow("TipoFacturaId") = oFactura.TipoFacturaId
      oRow("FacturaFecha") = ToStr(oFactura.FacturaFecha)
      oRow("FacturaNro") = oFactura.FacturaNro
      oRow("FacturaMonto") = oFactura.FacturaMonto
      oRow("RegRUCId") = oFactura.RegRUCId
      oRow("NroRUC") = oFactura.NroRUC
      oRow("RegRUCDes") = oFactura.RegRUCDes
      oRow("NroAutorizacion") = oFactura.NroAutorizacion
      oRow("CodControl") = oFactura.CodControl
      oRow("IVA") = oFactura.IVA
      oRow("IceIehd") = oFactura.IceIehd
      oRow("Exento") = oFactura.Exento
      oRow("Descuento") = oFactura.Descuento
      oRow("TipoFacCompraId") = oFactura.TipoFacCompraId
      oRow("FacturaObs") = oFactura.FacturaObs
      oRow("CostoIdNro") = lngCostoIdNro
      oRow("Bancarizar") = oFactura.Bancarizar
      oRow("Estado") = "New"

      Return oRow

   End Function

   Private Function RowFacturaOtroCostoNewEdit(ByRef oRow As DataRow, ByVal oFactura As clsFactura, ByVal strEstado As String) As DataRow

      oRow("FacturaId") = oFactura.FacturaId
      oRow("Mes") = oFactura.MesId
      oRow("SucursalId") = oFactura.SucursalId
      ''oRow("DosificaId") = oFactura.DosificaId
      ''oRow("TipoCompId") = oFactura.TipoCompId
      ''oRow("CompId") = oFactura.CompId
      ''oRow("CompDetId") = oFactura.CompDetId
      oRow("TipoFacturaId") = oFactura.TipoFacturaId
      oRow("FacturaFecha") = ToStr(oFactura.FacturaFecha)
      oRow("FacturaNro") = oFactura.FacturaNro
      oRow("FacturaMonto") = oFactura.FacturaMonto
      oRow("RegRUCId") = oFactura.RegRUCId
      oRow("NroRUC") = oFactura.NroRUC
      oRow("RegRUCDes") = oFactura.RegRUCDes
      oRow("NroAutorizacion") = oFactura.NroAutorizacion
      oRow("CodControl") = oFactura.CodControl
      oRow("IVA") = oFactura.IVA
      oRow("IceIehd") = oFactura.IceIehd
      oRow("Exento") = oFactura.Exento
      oRow("Descuento") = oFactura.Descuento
      oRow("TipoFacCompraId") = oFactura.TipoFacCompraId
      oRow("FacturaObs") = oFactura.FacturaObs
      oRow("Bancarizar") = oFactura.Bancarizar
      oRow("Estado") = strEstado

      Return oRow

   End Function

   Private Function GetRowDeleteFacturaOtroCosto(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = modtDeleteFacturaOtroCosto.NewRow

      oRow("FacturaId") = oDataRow("FacturaId")
      oRow("FacturaFecha") = oDataRow("FacturaFecha")
      oRow("FacturaMonto") = oDataRow("FacturaMonto")
      oRow("FacturaId") = oDataRow("FacturaId")
      oRow("Estado") = "Delete"

      Return oRow
   End Function

   Private Sub FacturaOtroCostoDataShow()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim frm As New frmFacturaOtroCostoEdit
      Dim oRow As DataRow

      Try
         If grdCompraOtroCosto.RowCount > 0 Then
            If ToLong(grdCompraOtroCosto.GetValue("FacturaId")) > 0 Then

               With frm
                  .NewRecord = False
                  .Editing = False

                  oRow = dtFacturaOtroCostoFindRow(ToLong(grdCompraOtroCosto.GetValue("CostoIdNro")))

                  If Not IsNothing(oRow) Then
                     oFactura.EmpresaId = moCompra.EmpresaId
                     oFactura.GestionId = moCompra.GestionId
                     ''oFactura.EstadoId = moCompra.EstadoId
                     oFactura.EstadoId = 11

                     oFactura.FacturaId = ToLong(oRow("FacturaId"))
                     oFactura.MesId = ToLong(oRow("Mes"))
                     ''oFactura.SucursalId = ToLong(oRow("SucursalId"))
                     ''oFactura.DosificaId = ToLong(oRow("DosificaId"))
                     ''oFactura.TipoCompId = ToLong(oRow("TipoCompId"))
                     ''oFactura.CompId = ToLong(oRow("CompId"))
                     ''oFactura.CompDetId = ToLong(oRow("CompDetId"))
                     oFactura.TipoFacturaId = ToLong(oRow("TipoFacturaId"))
                     oFactura.FacturaFecha = ToStr(ToStr(oRow("FacturaFecha")))
                     oFactura.FacturaNro = ToLong(oRow("FacturaNro"))
                     oFactura.FacturaMonto = oRow("FacturaMonto")
                     oFactura.RegRUCId = ToLong(oRow("RegRUCId"))
                     oFactura.NroRUC = oRow("NroRUC")
                     oFactura.RegRUCDes = oRow("RegRUCDes")
                     oFactura.NroAutorizacion = oRow("NroAutorizacion")
                     oFactura.CodControl = oRow("CodControl")
                     oFactura.IVA = oRow("IVA")
                     oFactura.IceIehd = oRow("IceIehd")
                     oFactura.Exento = oRow("Exento")
                     oFactura.Descuento = oRow("Descuento")
                     oFactura.TipoFacCompraId = oRow("TipoFacCompraId")
                     oFactura.FacturaObs = oRow("FacturaObs")
                     oFactura.Bancarizar = oRow("Bancarizar")

                     .DataObject = oFactura

                     .ShowDialog()

                  End If

                  frm.Dispose()
               End With

            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura = Nothing

      End Try
   End Sub

   Private Sub FacturaOtroCostoFormNew()
      Dim frm As New frmFacturaOtroCostoEdit
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         If mboolAdding Or mboolEditing Then
            If grdCompraOtroCosto.RowCount > 0 Then
               If ToLong(grdCompraOtroCosto.GetValue("FacturaId")) = 0 Then
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oFactura.EmpresaId = moCompra.EmpresaId
                     oFactura.TipoFacturaId = 2
                     oFactura.GestionId = moCompra.GestionId
                     oFactura.FacturaFecha = ConvertDMY(moCompra.Fecha)

                     oFactura.SucursalId = AlmacenSucursalIdFind(moCompra.AlmacenId)

                     oFactura.EstadoId = 11

                     If moCompra.MonedaId = 1 Then
                        oFactura.FacturaMonto = ToDecimal(grdCompraOtroCosto.GetValue("Monto"))
                     Else
                        oFactura.FacturaMonto = ToDecimal(grdCompraOtroCosto.GetValue("Monto") * moCompra.TipoCambio)
                     End If

                     .DataObject = oFactura
                     .CostoIdNro = grdCompraOtroCosto.GetValue("CostoIdNro")
                     .dtFacturas = queFacturaLoad()

                     .ShowDialog()

                     If .Changed Then

                        modtFacturaOtroCosto.Rows.Add(FacturaOtroCostoRowNew(frm.DataObject, frm.CostoIdNro))
                        'If CompraOtroCostoFacturaIdUpdate(frm.CostoIdNro, frm.DataObject.FacturaNro) Then
                        If CompraOtroCostoFacturaIdUpdate(frm.CostoIdNro, frm.DataObject.FacturaNro, frm.DataObject.FacturaNro, 0) Then
                           Call grdProrrateoLoad(True)
                           Call TotalOtrosCostos()
                        End If

                     End If

                     frm.Dispose()
                  End With
               Else
                  MessageBox.Show("El Registro ya Tiene una Factura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Else
               MessageBox.Show("Imposible Adicionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub FacturaOtroCostoDataEdit()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim frm As New frmFacturaOtroCostoEdit
      Dim oRow As DataRow

      Try
         If grdCompraOtroCosto.RowCount > 0 Then
            If mboolAdding Or mboolEditing Then
               If ToLong(grdCompraOtroCosto.GetValue("FacturaId")) > 0 Then

                  With frm
                     .NewRecord = False
                     .Editing = True

                     oRow = dtFacturaOtroCostoFindRow(ToLong(grdCompraOtroCosto.GetValue("CostoIdNro")))

                     If Not IsNothing(oRow) Then
                        oFactura.EmpresaId = moCompra.EmpresaId
                        oFactura.GestionId = moCompra.GestionId
                        oFactura.EstadoId = 11

                        oFactura.FacturaId = ToLong(oRow("FacturaId"))
                        oFactura.MesId = ToLong(oRow("Mes"))
                        oFactura.SucursalId = ToLong(oRow("SucursalId"))
                        ''oFactura.DosificaId = ToLong(oRow("DosificaId"))
                        ''oFactura.TipoCompId = ToLong(oRow("TipoCompId"))
                        ''oFactura.CompId = ToLong(oRow("CompId"))
                        ''oFactura.CompDetId = ToLong(oRow("CompDetId"))
                        oFactura.TipoFacturaId = ToLong(oRow("TipoFacturaId"))
                        oFactura.FacturaFecha = ToStr(ToStr(oRow("FacturaFecha")))
                        oFactura.FacturaNro = ToLong(oRow("FacturaNro"))
                        oFactura.FacturaMonto = oRow("FacturaMonto")
                        oFactura.RegRUCId = ToLong(oRow("RegRUCId"))
                        oFactura.NroRUC = oRow("NroRUC")
                        oFactura.RegRUCDes = oRow("RegRUCDes")
                        oFactura.NroAutorizacion = oRow("NroAutorizacion")
                        oFactura.CodControl = oRow("CodControl")
                        oFactura.IVA = oRow("IVA")
                        oFactura.IceIehd = oRow("IceIehd")
                        oFactura.Exento = oRow("Exento")
                        oFactura.Descuento = oRow("Descuento")
                        oFactura.TipoFacCompraId = oRow("TipoFacCompraId")
                        oFactura.FacturaObs = oRow("FacturaObs")
                        oFactura.Bancarizar = ToByte(oRow("Bancarizar"))

                        .DataObject = oFactura

                        .CostoIdNro = grdCompraOtroCosto.GetValue("CostoIdNro")
                        .dtFacturas = queFacturaLoad(grdCompraOtroCosto.GetValue("CostoIdNro"))

                        frm.ShowDialog()

                        If .Changed Then

                           If ToStr(oRow("Estado")) <> "New" Then
                              Call RowFacturaOtroCostoNewEdit(oRow, frm.DataObject, "Edit")
                              CompraOtroCostoFacturaNroUpdate(frm.CostoIdNro, 0, frm.DataObject.FacturaNro)
                           Else
                              Call RowFacturaOtroCostoNewEdit(oRow, frm.DataObject, "New")
                              CompraOtroCostoFacturaNroUpdate(frm.CostoIdNro, frm.DataObject.FacturaNro, frm.DataObject.FacturaNro)
                           End If

                           Call grdProrrateoLoad(True)
                           Call TotalOtrosCostos()

                        End If
                     Else
                        MessageBox.Show("El Registro tiene Factura Eliminada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If

                     frm.Dispose()

                  End With

               End If
            Else
               MessageBox.Show("Imposible Editar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Sub

   Private Sub FacturaOtroCostoDataDelete()
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim oDataRow As DataRow
      Dim lngCostoIdNro As Long
      Dim lngFinRowId As Long

      Try
         If grdCompraOtroCosto.RowCount > 0 Then
            If mboolAdding Or mboolEditing Then
               If ToLong(grdCompraOtroCosto.GetValue("FacturaId")) > 0 Then
                  If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                     lngCostoIdNro = ToLong(grdCompraOtroCosto.GetValue("CostoIdNro"))
                     oDataRow = dtFacturaOtroCostoFindRow(lngCostoIdNro)

                     If Not IsNothing(oDataRow) Then
                        If ToStr(oDataRow("Estado")) <> "New" Then
                           modtDeleteFacturaOtroCosto.Rows.Add(GetRowDeleteFacturaOtroCosto(oDataRow))
                        End If

                        'If CompraOtroCostoFacturaIdUpdate(lngCostoIdNro, 0) Then
                        'End If
                        If CompraOtroCostoFacturaIdUpdate(lngCostoIdNro, 0, "", 0) Then
                        End If

                        modtFacturaOtroCosto.Rows.RemoveAt(dtFacturaOtroCostoFindRowId(lngCostoIdNro))

                        'lngFinRowId = dtFacturaOtroCostoFindRowId(lngCostoIdNro)
                        'If lngFinRowId >= 0 Then
                        '   modtFacturaOtroCosto.Rows.RemoveAt(lngFinRowId)
                        'End If
                     Else
                        If CompraOtroCostoFacturaIdUpdate(lngCostoIdNro, 0, "", 0) Then
                        End If
                     End If

                     Call grdProrrateoLoad(True)
                     Call TotalOtrosCostos()
                  End If
               Else
                  MessageBox.Show("El Registro NO tiene Factura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Imposible Eliminar el Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura = Nothing

      End Try
   End Sub

   Private Function dtFacturaCompraOtroCostoSave() As Boolean
      Dim oRow As DataRow
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      dtFacturaCompraOtroCostoSave = True

      Try

         For Each oRow In modtDeleteFacturaOtroCosto.Rows
            If ToStr(oRow("Estado")) = "Delete" Then
               FacturaDelete(oRow("FacturaId"))
            End If
         Next

         'Guardando las facturas de Otros Costos 
         For Each oRow In moDataSet.Tables("FacturaOtroCosto").Rows
            If ToStr(oRow("Estado")) = "New" Then
               Call dtFacturaCompraOtroCostoMove(oRow, oFactura)
               If oFactura.Insert() Then
                  oRow("FacturaId") = oFactura.FacturaId
                  'CompraOtroCostoFacturaIdUpdate(oRow("CostoIdNro"), oFactura.FacturaId)
                  CompraOtroCostoFacturaIdUpdate(oRow("CostoIdNro"), oFactura.FacturaId, oFactura.FacturaNro, oFactura.FacturaId)
               End If

            ElseIf (ToStr(oRow("Estado")) = "Edit") Then
               Call dtFacturaCompraOtroCostoMove(oRow, oFactura)
               If oFactura.Update() Then
                  oRow("FacturaId") = oFactura.FacturaId
                  'CompraOtroCostoFacturaIdUpdate(oRow("CostoIdNro"), oFactura.FacturaId)
                  CompraOtroCostoFacturaIdUpdate(oRow("CostoIdNro"), oFactura.FacturaId, oFactura.FacturaNro, oFactura.FacturaId)
               End If
            End If

         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      Finally
         oFactura.Dispose()
      End Try
   End Function

   Private Function dtFacturaCompraOtroCosCompIdUpdate(ByVal lngTipoCompId As Long, ByVal lngCompId As Long) As Boolean
      Dim oRow As DataRow
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      dtFacturaCompraOtroCosCompIdUpdate = False

      Try

         'Actualizando el Comprobante de la Factura de Otros Costos 
         For Each oRow In moDataSet.Tables("FacturaOtroCosto").Rows
            If oRow("FacturaId") <> 0 Then

               oFactura.FacturaId = oRow("FacturaId")
               oFactura.EmpresaId = moCompra.EmpresaId
               oFactura.GestionId = moCompra.GestionId

               oFactura.TipoCompId = lngTipoCompId
               oFactura.CompId = lngCompId
               oFactura.SucursalIdOrg = moCompra.SucursalId
               oFactura.AppId = clsAppInfo.AppId
               oFactura.TipoDocumentoId = clsTipoCompra.COMPRA
               oFactura.DocumentoId = moCompra.CompraId
               ''oFactura.CompDetId = lngCompDetId

               oFactura.UpdateFilter = clsFactura.UpdateFilters.CompId
               If oFactura.UpdateOnly() Then
                  dtFacturaCompraOtroCosCompIdUpdate = True
               End If
            End If

         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      Finally
         oFactura.Dispose()
      End Try
   End Function

   Private Sub dtFacturaCompraOtroCostoMove(ByRef oRow As DataRow, ByRef oFactura As clsFactura)
      With oFactura

         oFactura.FacturaId = oRow("FacturaId")
         .EmpresaId = moCompra.EmpresaId
         .GestionId = moCompra.GestionId

         oFactura.MesId = oRow("Mes")
         oFactura.SucursalId = oRow("SucursalId")
         ''oFactura.DosificaId = oRow("DosificaId")
         ''oFactura.TipoCompId = oRow("TipoCompId")
         ''oFactura.CompId = oRow("CompId")
         ''oFactura.CompDetId = oRow("CompDetId")
         oFactura.TipoFacturaId = oRow("TipoFacturaId")
         oFactura.FacturaFecha = ToDate(oRow("FacturaFecha"))
         oFactura.FacturaNro = oRow("FacturaNro")
         oFactura.FacturaMonto = oRow("FacturaMonto")
         oFactura.RegRUCId = oRow("RegRUCId")
         oFactura.NroRUC = oRow("NroRUC")
         oFactura.RegRUCDes = oRow("RegRUCDes")
         oFactura.NroAutorizacion = oRow("NroAutorizacion")
         oFactura.CodControl = oRow("CodControl")
         oFactura.IVA = oRow("IVA")
         oFactura.IceIehd = oRow("IceIehd")
         oFactura.Exento = oRow("Exento")
         oFactura.Descuento = oRow("Descuento")
         oFactura.TipoFacCompraId = oRow("TipoFacCompraId")
         oFactura.FacturaObs = oRow("FacturaObs")
         oFactura.Bancarizar = ToByte(oRow("Bancarizar"))
         oFactura.EstadoId = 11
         oFactura.SucursalIdOrg = moCompra.SucursalId
         oFactura.AppId = clsAppInfo.AppId
         oFactura.TipoDocumentoId = clsTipoCompra.COMPRA
         oFactura.DocumentoId = moCompra.CompraId

      End With
   End Sub

   Private Function CompraOtroCostoFacturaIdUpdate(ByVal lngCompraOtroCostoId As Long, ByVal lngFacturaId As Long, ByVal strFacturaNro As String, ByVal lngFacturaIdOrg As Long) As Boolean

      CompraOtroCostoFacturaIdUpdate = False
      Dim FinRowId As Long
      FinRowId = grdCompraOtroCostoFindRowId(lngCompraOtroCostoId)

      If FinRowId >= 0 Then
         If moDataTableCompOtroCosto.Rows(FinRowId)("Estado") <> "New" Then
            moDataTableCompOtroCosto.Rows(FinRowId)("Estado") = "Edit"
         End If

         moDataTableCompOtroCosto.Rows(FinRowId)("FacturaId") = lngFacturaId
         moDataTableCompOtroCosto.Rows(FinRowId)("FacturaNro") = strFacturaNro
         moDataTableCompOtroCosto.Rows(FinRowId)("FacturaIdOrg") = lngFacturaIdOrg

         CompraOtroCostoFacturaIdUpdate = True
      End If

   End Function

   Private Function CompraOtroCostoFacturaNroUpdate(ByVal lngCompraOtroCostoId As Long, ByVal lngFacturaId As Long, ByVal strFacturaNro As String) As Boolean

      CompraOtroCostoFacturaNroUpdate = False
      Dim FinRowId As Long
      FinRowId = grdCompraOtroCostoFindRowId(lngCompraOtroCostoId)

      If FinRowId >= 0 Then
         'If moDataTableCompOtroCosto.Rows(FinRowId)("Estado") <> "New" Then
         '   moDataTableCompOtroCosto.Rows(FinRowId)("Estado") = "Edit"
         'End If

         If lngFacturaId > 0 Then
            moDataTableCompOtroCosto.Rows(FinRowId)("FacturaId") = lngFacturaId
         End If

         moDataTableCompOtroCosto.Rows(FinRowId)("FacturaNro") = strFacturaNro

         CompraOtroCostoFacturaNroUpdate = True
      End If

   End Function

   Private Function FacturaDelete(ByVal lngFacturaId As Integer) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      FacturaDelete = True

      Try

         With oFactura
            .WhereFilter = clsFactura.WhereFilters.PrimaryKey
            .FacturaId = lngFacturaId

            If .Delete Then
               FacturaDelete = True
            End If
         End With


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function FacturaDeleteMemoria(ByVal lngCostoIdNro As Long) As Boolean

      Dim oDataRow As DataRow
      oDataRow = dtFacturaOtroCostoFindRow(lngCostoIdNro)
      If Not IsNothing(oDataRow) Then
         If ToStr(oDataRow("Estado")) <> "New" Then
            modtDeleteFacturaOtroCosto.Rows.Add(GetRowDeleteFacturaOtroCosto(oDataRow))
         End If

         modtFacturaOtroCosto.Rows.RemoveAt(dtFacturaOtroCostoFindRowId(lngCostoIdNro))

         FacturaDeleteMemoria = True
      End If

   End Function

   Private Function FacturaUpdateMonto(ByVal lngFacturaId As Long, ByVal decMonto As Decimal) As Boolean

      Dim decNeto As Decimal
      Dim decIVA As Decimal
      Dim decImporteIVA As Decimal

      Dim decExento As Decimal
      Dim decIceIehd As Decimal
      Dim decDescuento As Decimal
      Dim decFacturaMonto As Decimal

      FacturaUpdateMonto = False
      Dim FinRowId As Long
      FinRowId = dtFacturaOtroCostoFindRowId(lngFacturaId)

      If FinRowId >= 0 Then
         If modtFacturaOtroCosto.Rows(FinRowId)("Estado") <> "New" Then
            modtFacturaOtroCosto.Rows(FinRowId)("Estado") = "Edit"
         End If

         If moCompra.MonedaId = clsMoneda.DOLARES Then
            decMonto = ToDecimal(decMonto * moCompra.TipoCambio)
         End If

         modtFacturaOtroCosto.Rows(FinRowId)("SucursalId") = AlmacenSucursalIdFind(moCompra.AlmacenId)
         modtFacturaOtroCosto.Rows(FinRowId)("FacturaMonto") = decMonto

         'Falta hacer calculos??

         decExento = modtFacturaOtroCosto.Rows(FinRowId)("Exento")
         decIceIehd = modtFacturaOtroCosto.Rows(FinRowId)("IceIehd")
         decDescuento = modtFacturaOtroCosto.Rows(FinRowId)("Descuento")

         'decNeto = ToDecimal(decMonto - (decIceIehd + decExento))
         'decIVA = ToDecimal(decNeto * clsAppInfo.IVA)
         'decImporteIVA = ToDecimal(decMonto - decIVA)

         decNeto = ToDecimal(decMonto - (decIceIehd + decExento + decDescuento))
         decIVA = ToDecimal(decNeto * clsAppInfo.IVA)
         decImporteIVA = ToDecimal(decNeto - decIVA)

         modtFacturaOtroCosto.Rows(FinRowId)("IVA") = decIVA

         FacturaUpdateMonto = True
      End If
   End Function

   Private Function FacturaOtroCostoIvaBsFind(ByVal lngFacturaId As Long, ByRef decFacturaIvaUs As Decimal, ByRef decFacturaIvaOrg As Decimal) As Decimal

      Dim FinRowId As Long
      FinRowId = dtFacturaOtroCostoFindRowId(lngFacturaId)
      FacturaOtroCostoIvaBsFind = 0

      If FinRowId >= 0 Then
         FacturaOtroCostoIvaBsFind = modtFacturaOtroCosto.Rows(FinRowId)("IVA")
         decFacturaIvaUs = ToDecimal(modtFacturaOtroCosto.Rows(FinRowId)("IVA") / moCompra.TipoCambio)

         If moCompra.MonedaId = 1 Then
            decFacturaIvaOrg = FacturaOtroCostoIvaBsFind
         Else
            decFacturaIvaOrg = decFacturaIvaUs
         End If

      End If
   End Function

   Private Function queFacturaLoad(Optional ByVal lngNroFactura As Long = 0) As DataTable
      Dim oRow As DataRow
      Dim oDataRow As DataRow
      Dim oDataTable As New DataTable

      oDataTable.Columns.Add("FacturaId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("TipoFacturaId", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("FacturaNro", Type.GetType("System.Int32"))
      oDataTable.Columns.Add("NroAutorizacion", Type.GetType("System.String"))

      For Each oRow In moDataSet.Tables("FacturaOtroCosto").Rows
         If ToLong(oRow("CostoIdNro")) <> lngNroFactura Then

            oDataRow = oDataTable.NewRow

            oDataRow("FacturaId") = oRow("FacturaId")
            oDataRow("TipoFacturaId") = oRow("TipoFacturaId")
            oDataRow("FacturaNro") = oRow("FacturaNro")
            oDataRow("NroAutorizacion") = oRow("NroAutorizacion")

            oDataTable.Rows.Add(oDataRow)
         End If
      Next

      Return oDataTable
   End Function

   Private Function dtFacturaOtroCostoFindRowId(ByVal lngID As Long) As Long
      Dim intRow As Long = 0.0F
      For Each oRow As DataRow In moDataSet.Tables("FacturaOtroCosto").Rows

         If oRow("CostoIdNro") = lngID Then
            Return intRow
         End If

         intRow += 1
      Next

      Return -1

   End Function

   Private Function dtFacturaOtroCostoFindRow(ByVal lngID As Long) As DataRow
      ''Dim intRow As Long = 0.0F
      ''Dim intRow As Long = 0
      For Each oRow As DataRow In moDataSet.Tables("FacturaOtroCosto").Rows
         If oRow("CostoIdNro") = lngID Then
            Return oRow
         End If

      Next

   End Function

   Private Sub grdCompraOtroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdCompraOtroCosto.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdCompraOtroCosto.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdCompraOtroCosto.GetRow.Cells(grdCompraOtroCosto.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub grdCompraOtroCosto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdCompraOtroCosto.DoubleClick
      Call CompraOtroCostoDataShow()
   End Sub

   Private Sub mnuShowOtroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowOtroCosto.Click
      Call CompraOtroCostoDataShow()
   End Sub

   Private Sub mnuNewOtroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewOtroCosto.Click
      Call CompraOtroCostoFormNew()
   End Sub

   Private Sub mnuEditOtroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditOtroCosto.Click
      Call CompraOtroCostoDataEdit()
   End Sub

   Private Sub mnuDeleteOtroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteOtroCosto.Click
      Call CompraOtroCostoDataDelete()
   End Sub

   Private Sub mnuShowFacturaOtroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowFacturaOtroCosto.Click
      Call FacturaOtroCostoDataShow()
   End Sub

   Private Sub mnuNewFacturaOtroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewFacturaOtroCosto.Click
      Call FacturaOtroCostoFormNew()
   End Sub

   Private Sub mnuEditFacturaOtroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditFacturaOtroCosto.Click
      Call FacturaOtroCostoDataEdit()
   End Sub

   Private Sub mnuDeleteFacturaOtroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteFacturaOtroCosto.Click
      Call FacturaOtroCostoDataDelete()
   End Sub

#End Region

#Region " Prorrateo "

   'Private Sub grdProrrateoLoad(ByVal boolNew As Boolean)
   '   Dim oRow As DataRow

   '   Try
   '      Call moDataSetInit()

   '      If boolNew Then
   '         For Each oRow In mdsCompraDet.Tables("comCompraDet").Rows
   '            moDataTable.Rows.Add(GetRowNew(oRow))
   '         Next

   '      Else
   '         For Each oRow In mdsCompraDet.Tables("comCompraDet").Rows
   '            moDataTable.Rows.Add(GetRowShow(oRow))
   '         Next
   '      End If

   '      moDataTable.Rows.Add(GetRowTotal())

   '      grdProrrateo.DataSource = moDataSet.Tables(moCompra.TableName).DefaultView
   '      grdProrrateo.RetrieveStructure()
   '      Call grdProrrateoInit()

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   End Try
   'End Sub

   Private Sub grdProrrateoLoad(ByVal boolNew As Boolean)
      Dim oRow As DataRow
      Dim oRowOtroCos As DataRow
      Dim decMontoCos, decMontoCosSum, decFactor As Decimal
      Dim lngCantItem, lngCount As Long

      Try
         Call moDataSetInit()

         decMontoCos = TotalCostoCompra(lngCantItem, decFactor)
         lngCount = 0

         If boolNew Then
            For Each oRow In mdsCompraDet.Tables("comCompraDet").Rows
               lngCount += 1
               oRowOtroCos = GetRowNew(oRow, decFactor)
               decMontoCosSum += oRowOtroCos("ImporteCif")

               If lngCantItem = lngCount Then
                  decMontoCosSum = decMontoCos - decMontoCosSum
                  oRowOtroCos("ImporteCif") += decMontoCosSum
                  oRowOtroCos("PrecioCif") = ToDecimal(oRowOtroCos("ImporteCif") / oRow("Cantidad"))
                  'oRowOtroCos("ImporteCif") = ToDecimal(oRowOtroCos("PrecioCif") * oRow("Cantidad"))
               End If
               moDataTable.Rows.Add(oRowOtroCos)
            Next

         Else
            For Each oRow In mdsCompraDet.Tables("comCompraDet").Rows
               moDataTable.Rows.Add(GetRowShow(oRow))
            Next
         End If

         moDataTable.Rows.Add(GetRowTotal())

         grdProrrateo.DataSource = moDataSet.Tables(moCompra.TableName).DefaultView
         grdProrrateo.RetrieveStructure()
         Call grdProrrateoInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub moDataSetInit()

      If moDataSet.Tables.Contains(moCompra.TableName) Then
         moDataSet.Tables.Remove(moCompra.TableName)
      End If

      moDataTable = moDataSet.Tables.Add(moCompra.TableName)

      moDataTable.Columns.Add("ItemId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ItemCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("ItemDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("MedidaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MedidaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Cantidad", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Recargo", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Descuento", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Importe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Iva", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteIva", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Porcentaje", Type.GetType("System.Decimal"))

      For Each oRow As DataRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         moDataTable.Columns.Add(oRow("PlanOtroCostoDes") & " Id" & oRow("CostoIdNro"), Type.GetType("System.Int32"))
         moDataTable.Columns.Add(oRow("PlanOtroCostoDes") & oRow("CostoIdNro"), Type.GetType("System.Decimal"))
      Next

      moDataTable.Columns.Add("Costo", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PrecioCif", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("ImporteCif", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim oRowCosto As DataRow
      Dim decTotal As Decimal = 0
      Dim decParticipa As Decimal = 0
      Dim decFacIvaOtCos As Decimal = 0

      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemCod") = oDataRow("ItemCod")
      oRow("ItemDes") = oDataRow("ItemDes")
      oRow("MedidaId") = oDataRow("MedidaId")
      oRow("MedidaDes") = oDataRow("MedidaDes")
      oRow("Cantidad") = oDataRow("Cantidad")
      oRow("PrecioOrg") = oDataRow("PrecioOrg")
      oRow("Importe") = oDataRow("Importe")
      oRow("Porcentaje") = oRow("Importe") / moCompra.MontoOrg
      oRow("Recargo") = oDataRow("MontoRec")
      oRow("Descuento") = oDataRow("MontoDes")

      oRow("Importe") = oDataRow("Importe") + (oRow("Recargo") - oRow("Descuento"))

      If ToDecimal(txtFacturaIVA.Text) > 0 Then
         ''oRow("Iva") = ToDecimal(oRow("Importe") * clsAppInfo.IVA)
         oRow("Iva") = ToDecimal(txtFacturaIVA.Text * oRow("Porcentaje"))
      Else
         oRow("Iva") = 0
      End If

      If ToDecimal(txtExentoIVA.Text) > 0 Then
         oRow("Iva") = oRow("Iva") + ToDecimal(txtExentoIVA.Text * oRow("Porcentaje"))
      End If

      If mlngTipoRetencionId >= 1 And mlngTipoRetencionId <= 3 Then   ''Para Retenciones Asume Empresa
         oRow("ImporteIva") = oRow("Importe") + oRow("Iva")
      Else
         oRow("ImporteIva") = oRow("Importe") - oRow("Iva")
      End If

      mlngRowCosto = 0

      For Each oRowCosto In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         oRow(oRowCosto("PlanOtroCostoDes") & " Id" & oRowCosto("CostoIdNro")) = oRowCosto("CompraOtroCostoId")

         If oRowCosto("FacturaId") = 0 Then
            oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal(oRowCosto("Monto") * oRow("Porcentaje"))
         Else
            ''oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal((oRowCosto("Monto") - (oRowCosto("Monto") * clsAppInfo.IVA)) * oRow("Porcentaje"))

            FacturaOtroCostoIvaBsFind(oRowCosto("CostoIdNro"), 0, decFacIvaOtCos)
            oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal((oRowCosto("Monto") - decFacIvaOtCos) * oRow("Porcentaje"))

         End If

         mlngRowCosto += 2
      Next


      For Each oRowCosto In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         decTotal += ToDecimal(oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")))
      Next
      oRow("Costo") = decTotal

      oRow("PrecioCif") = ToDecimal((oRow("ImporteIva") + oRow("Costo")) / oRow("Cantidad"))
      oRow("ImporteCif") = ToDecimal(oRow("ImporteIva") + oRow("Costo"))

      Return oRow
   End Function

   'Private Function GetRowNew(ByVal oDataRow As DataRow) As DataRow
   '   Dim oRow As DataRow
   '   oRow = moDataTable.NewRow
   '   Dim oRowCosto As DataRow
   '   Dim decTotal As Decimal = 0
   '   Dim lngProrrateoId As Long
   '   Dim decParticipa As Decimal = 0
   '   Dim decFacIvaOtCos As Decimal = 0

   '   oRow("ItemId") = oDataRow("ItemId")
   '   oRow("ItemCod") = oDataRow("ItemCod")
   '   oRow("ItemDes") = oDataRow("ItemDes")
   '   oRow("MedidaId") = oDataRow("MedidaId")
   '   oRow("MedidaDes") = oDataRow("MedidaDes")
   '   oRow("Cantidad") = oDataRow("Cantidad")
   '   oRow("PrecioOrg") = oDataRow("PrecioOrg")
   '   oRow("Importe") = oDataRow("Importe")
   '   oRow("Porcentaje") = oRow("Importe") / moCompra.MontoOrg
   '   oRow("Recargo") = oDataRow("MontoRec")
   '   oRow("Descuento") = oDataRow("MontoDes")
   '   oRow("Importe") = oDataRow("Importe") + (oRow("Recargo") - oRow("Descuento"))

   '   If ToDecimal(txtFacturaIVA.Text) > 0 Then
   '      ''oRow("Iva") = ToDecimal(oRow("Importe") * clsAppInfo.IVA)
   '      oRow("Iva") = ToDecimal(txtFacturaIVA.Text * oRow("Porcentaje"))
   '   Else
   '      oRow("Iva") = 0
   '   End If

   '   If ToDecimal(txtExentoIVA.Text) > 0 Then
   '      oRow("Iva") = oRow("Iva") + ToDecimal(txtExentoIVA.Text * oRow("Porcentaje"))
   '   End If

   '   If mlngTipoRetencionId >= 1 And mlngTipoRetencionId <= 3 Then   ''Para Retenciones Asume Empresa
   '      oRow("ImporteIva") = oRow("Importe") + oRow("Iva")
   '   Else

   '      oRow("ImporteIva") = oRow("Importe") - oRow("Iva")
   '   End If

   '   mlngRowCosto = 0

   '   For Each oRowCosto In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
   '      oRow(oRowCosto("PlanOtroCostoDes") & " Id" & oRowCosto("CostoIdNro")) = oRowCosto("CompraOtroCostoId")

   '      If oRowCosto("FacturaId") = 0 Then
   '         oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal(oRowCosto("Monto") * oRow("Porcentaje"))
   '      Else
   '         ''oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal((oRowCosto("Monto") - (oRowCosto("Monto") * clsAppInfo.IVA)) * oRow("Porcentaje"))

   '         FacturaOtroCostoIvaBsFind(oRowCosto("CostoIdNro"), 0, decFacIvaOtCos)
   '         oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal((oRowCosto("Monto") - decFacIvaOtCos) * oRow("Porcentaje"))

   '      End If

   '      mlngRowCosto += 2
   '   Next

   '   For Each oRowCosto In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
   '      decTotal += ToDecimal(oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")))
   '   Next
   '   oRow("Costo") = decTotal

   '   oRow("PrecioCif") = ToDecimal((oRow("ImporteIva") + oRow("Costo")) / oRow("Cantidad"))
   '   oRow("ImporteCif") = ToDecimal(oRow("ImporteIva") + oRow("Costo"))

   '   Return oRow
   'End Function

   Private Function GetRowNew(ByVal oDataRow As DataRow, ByVal decFactor As Decimal) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim oRowCosto As DataRow
      Dim decTotal As Decimal = 0
      Dim lngProrrateoId As Long
      Dim decParticipa As Decimal = 0
      Dim decFacIvaOtCos As Decimal = 0
      Dim decImporte As Decimal = 0

      oRow("ItemId") = oDataRow("ItemId")
      oRow("ItemCod") = oDataRow("ItemCod")
      oRow("ItemDes") = oDataRow("ItemDes")
      oRow("MedidaId") = oDataRow("MedidaId")
      oRow("MedidaDes") = oDataRow("MedidaDes")
      oRow("Cantidad") = oDataRow("Cantidad")
      oRow("PrecioOrg") = oDataRow("PrecioOrg")
      oRow("Importe") = oDataRow("Importe")
      oRow("Porcentaje") = oRow("Importe") / moCompra.MontoOrg
      oRow("Recargo") = oDataRow("MontoRec")
      oRow("Descuento") = oDataRow("MontoDes")
      oRow("Importe") = oDataRow("Importe") + (oRow("Recargo") - oRow("Descuento"))

      If ToDecimal(txtFacturaIVA.Text) > 0 Then
         ''oRow("Iva") = ToDecimal(oRow("Importe") * clsAppInfo.IVA)
         oRow("Iva") = ToDecimal(txtFacturaIVA.Text * oRow("Porcentaje"))
      Else
         oRow("Iva") = 0
      End If

      If ToDecimal(txtExentoIVA.Text) > 0 Then
         oRow("Iva") = oRow("Iva") + ToDecimal(txtExentoIVA.Text * oRow("Porcentaje"))
      End If

      If mlngTipoRetencionId >= 1 And mlngTipoRetencionId <= 3 Then   ''Para Retenciones Asume Empresa
         oRow("ImporteIva") = oRow("Importe") + oRow("Iva")
      Else

         oRow("ImporteIva") = oRow("Importe") - oRow("Iva")
      End If

      mlngRowCosto = 0

      For Each oRowCosto In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         oRow(oRowCosto("PlanOtroCostoDes") & " Id" & oRowCosto("CostoIdNro")) = oRowCosto("CompraOtroCostoId")

         If oRowCosto("FacturaId") = 0 Then
            oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal(oRowCosto("Monto") * oRow("Porcentaje"))
         Else
            ''oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal((oRowCosto("Monto") - (oRowCosto("Monto") * clsAppInfo.IVA)) * oRow("Porcentaje"))

            FacturaOtroCostoIvaBsFind(oRowCosto("CostoIdNro"), 0, decFacIvaOtCos)
            oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = ToDecimal((oRowCosto("Monto") - decFacIvaOtCos) * oRow("Porcentaje"))

         End If

         mlngRowCosto += 2
      Next

      For Each oRowCosto In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         decTotal += ToDecimal(oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")))
      Next
      oRow("Costo") = decTotal

      'oRow("PrecioCif") = ToDecimal((oRow("ImporteIva") + oRow("Costo")) / oRow("Cantidad"))
      'oRow("ImporteCif") = ToDecimal(oRow("ImporteIva") + oRow("Costo"))

      '1
      'decImporte = ToDecimal((oRow("ImporteIva") * decFactor)) + oRow("ImporteIva")
      'oRow("PrecioCif") = ToDecimal(decImporte / oRow("Cantidad"))
      'oRow("ImporteCif") = ToDecimal(oRow("PrecioCif") * oRow("Cantidad"))

      oRow("PrecioCif") = ToDecimal((oRow("ImporteIva") + oRow("Costo")) / oRow("Cantidad"))
      'oRow("ImporteCif") = ToDecimal(oRow("ImporteIva") + oRow("Costo"))
      oRow("ImporteCif") = ToDecimal(oRow("PrecioCif") * oRow("Cantidad"))

      Return oRow
   End Function

   Private Function GetRowTotal() As DataRow
      Dim oRow As DataRow
      Dim oRowCosto As DataRow
      Dim oRowTotal As DataRow
      oRowTotal = moDataTable.NewRow
      Dim decMonto As Decimal

      oRowTotal("ItemId") = 0
      oRowTotal("ItemDes") = "Totales"

      oRowTotal("Recargo") = ToDecimal(txtMontoRec.Text)
      oRowTotal("Descuento") = ToDecimal(txtMontoDes.Text)

      oRowTotal("Importe") = 0
      oRowTotal("Iva") = 0
      oRowTotal("ImporteIva") = 0
      oRowTotal("Costo") = 0
      oRowTotal("ImporteCif") = 0

      For Each oRow In moDataSet.Tables(moCompra.TableName).Rows
         oRowTotal("Importe") += oRow("Importe")
         oRowTotal("Iva") += oRow("Iva")
         oRowTotal("ImporteIva") += oRow("ImporteIva")
         oRowTotal("Costo") += oRow("Costo")
         oRowTotal("ImporteCif") += oRow("ImporteCif")
      Next

      For Each oRowCosto In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
         decMonto = 0

         For Each oRow In moDataSet.Tables(moCompra.TableName).Rows
            decMonto += oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro"))
            oRowTotal(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")) = decMonto
         Next
      Next

      Return oRowTotal
   End Function

   Private Function grdProrrateoSave() As Boolean
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim oRowCosto As DataRow
      Dim lngProrrateoId As Long

      grdProrrateoSave = False


      If moDataSet.Tables(moCompraOtroCosto.TableName).Rows.Count > 0 Then

         Call ProrrateoCompraIdDelete(moCompra.CompraId)

         For Each oRow In moDataSet.Tables(moCompra.TableName).Rows
            For Each oRowCosto In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
               If ToLong(oRow("ItemId")) > 0 Then
                  If ProrrateoIdFind(moCompra.CompraId, oRow("ItemId"), oRowCosto("CompraOtroCostoId"), lngProrrateoId) Then

                     If ProrrateoUpdate(lngProrrateoId, oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")), oRow("PrecioCif"), oRow("ImporteCif")) Then
                        grdProrrateoSave = True
                     End If
                  Else

                     If ProrrateoAdd(oRow("ItemId"), oRowCosto("CompraOtroCostoId"), oRow(oRowCosto("PlanOtroCostoDes") & oRowCosto("CostoIdNro")), oRow("PrecioCif"), oRow("ImporteCif")) Then
                        grdProrrateoSave = True
                     End If
                  End If
               End If
            Next
         Next

      Else
         Call ProrrateoCompraIdDelete(moCompra.CompraId)

         For Each oRow In moDataSet.Tables(moCompra.TableName).Rows
            If ToLong(oRow("ItemId")) > 0 Then
               If ProrrateoAdd(oRow("ItemId"), 0, 0, oRow("PrecioCif"), oRow("ImporteCif")) Then
                  grdProrrateoSave = True
               End If
            End If
         Next
      End If
   End Function

   Private Function ProrrateoIdFind(ByVal lngCompraId As Long, ByVal lngItemId As Long, ByVal lngCompraOtroCostoId As Long, ByRef lngProrrateoId As Long) As Boolean
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      Try
         ProrrateoIdFind = False

         With oProrrateo
            .SelectFilter = clsProrrateo.SelectFilters.All
            .WhereFilter = clsProrrateo.WhereFilters.CompraOtroCostoId
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = lngCompraId
            .ItemId = lngItemId
            .CompraOtroCostoId = lngCompraOtroCostoId

            If .Find Then
               lngProrrateoId = .ProrrateoId
               ProrrateoIdFind = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo.Dispose()

      End Try
   End Function

   Private Function TotalCostoCompra(ByRef lngCant As Long, ByRef decFactor As Decimal) As Decimal
      Dim decCostoSinIva, decCostoConIva, decOtroCostoTotal As Decimal
      Dim decMontoCos As Decimal

      decCostoConIva = grdCompraOtroCostoTotal(True)
      decCostoSinIva = grdCompraOtroCostoTotal(False)
      decOtroCostoTotal = decCostoConIva + decCostoSinIva

      If mlngTipoRetencionId = 0 Then    '' Con Factura o Difere
         decMontoCos = ToDecimal(moCompra.MontoBru + ToDouble(decCostoConIva) + ToDouble(decCostoSinIva) - ToDouble(txtFacturaIVA.Text) - ToDouble(txtExentoIVA.Text))
      Else
         decMontoCos = ToDecimal(moCompra.MontoBru + ToDouble(decCostoConIva) + ToDouble(decCostoSinIva) + ToDouble(txtFacturaIVA.Text))
      End If

      decFactor = ToDecimalCinco(decOtroCostoTotal / (decMontoCos - decOtroCostoTotal))

      lngCant = mdsCompraDet.Tables("comCompraDet").Rows.Count
      TotalCostoCompra = decMontoCos

   End Function

   Private Function ProrrateoAdd(ByVal lngItemId As Long, ByVal lngCompraOtroCostoId As Long, ByVal decMontoCos As Decimal, ByVal decPrecioCif As Decimal, ByVal decImporteCif As Decimal) As Boolean
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      ProrrateoAdd = False

      Try
         With oProrrateo
            .EmpresaId = moCompra.EmpresaId
            .GestionId = moCompra.GestionId
            .CompraId = moCompra.CompraId
            .ItemId = lngItemId
            .CompraOtroCostoId = lngCompraOtroCostoId
            .MontoCos = decMontoCos
            .PrecioCif = decPrecioCif
            .ImporteCif = decImporteCif

            If .Insert() Then
               ProrrateoAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo.Dispose()

      End Try
   End Function

   Private Function ProrrateoUpdate(ByVal lngProrrateoId As Long, ByVal decMontoCos As Decimal, ByVal decPrecioCif As Decimal, ByVal decImporteCif As Decimal) As Boolean
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      ProrrateoUpdate = False

      Try
         With oProrrateo
            .ProrrateoId = lngProrrateoId

            If .FindByPK Then
               .MontoCos = decMontoCos
               .PrecioCif = decPrecioCif
               .ImporteCif = decImporteCif

               If .Update Then
                  ProrrateoUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo.Dispose()

      End Try
   End Function

   Private Function ProrrateoCompraIdDelete(ByVal lngCompraId As Long) As Boolean
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      ProrrateoCompraIdDelete = False

      Try
         With oProrrateo
            .WhereFilter = clsProrrateo.WhereFilters.CompraId
            .EmpresaId = moCompra.EmpresaId
            .CompraId = lngCompraId

            If .Delete Then
               Return True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo.Dispose()

      End Try
   End Function

   Private Sub ProrrateoDataShow()
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      Try
         If grdProrrateo.RowCount > 0 Then

            If (grdProrrateo.Col >= 13) And (grdProrrateo.Col <= 12 + mlngRowCosto) Then
               With oProrrateo
                  .SelectFilter = clsProrrateo.SelectFilters.All
                  .WhereFilter = clsProrrateo.WhereFilters.CompraOtroCostoId
                  .EmpresaId = moCompra.EmpresaId
                  .GestionId = moCompra.GestionId
                  .CompraId = moCompra.CompraId
                  .ItemId = ToLong(grdProrrateo.GetValue("ItemId"))
                  .CompraOtroCostoId = ToLong(grdProrrateo.GetValue(grdProrrateo.Col - 1))

                  If .Find Then
                     Dim frm As New frmProrrateoEdit

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oProrrateo

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo = Nothing

      End Try
   End Sub

   Private Sub ProrrateoDataEdit()
      Dim oProrrateo As New clsProrrateo(clsAppInfo.ConnectString)

      Try
         If grdProrrateo.RowCount > 0 Then
            'If (grdProrrateo.Col > 1) And (grdProrrateo.Col - mlngRowCosto + 3 <= 13) Then
            If (grdProrrateo.Col > 13) And (grdProrrateo.Col <= 12 + mlngRowCosto) Then
               With oProrrateo
                  .SelectFilter = clsProrrateo.SelectFilters.All
                  .WhereFilter = clsProrrateo.WhereFilters.CompraOtroCostoId
                  .EmpresaId = moCompra.EmpresaId
                  .GestionId = moCompra.GestionId
                  .CompraId = moCompra.CompraId
                  .ItemId = ToLong(grdProrrateo.GetValue("ItemId"))
                  .CompraOtroCostoId = ToLong(grdProrrateo.GetValue(grdProrrateo.Col - 1))

                  If .Find Then
                     Dim frm As New frmProrrateoEdit

                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oProrrateo
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdProrrateoLoad(False)
                        Call grdProrrateoFindRow(.ItemId)

                     End If
                     frm.Dispose()
                  End If
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProrrateo = Nothing

      End Try
   End Sub

   Private Sub grdProrrateoFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdProrrateo.RootTable.Columns("ItemId")

      grdProrrateo.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdProrrateoViewAll()
      grdProrrateo.RemoveFilters()
   End Sub

   Private Sub grdProrrateoInit()
      With grdProrrateo
         ebrMain.Groups(0).Text = "Prorrateo de Items"
         .ContextMenu = mnuProrrateo

         .RootTable.Columns("ItemId").Visible = False

         .RootTable.Columns("ItemCod").Caption = "Código"
         .RootTable.Columns("ItemCod").Width = 100
         .RootTable.Columns("ItemCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ItemDes").Caption = "Descripción"
         .RootTable.Columns("ItemDes").Width = 150
         .RootTable.Columns("ItemDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ItemDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MedidaId").Visible = False

         .RootTable.Columns("MedidaDes").Caption = "Medida"
         .RootTable.Columns("MedidaDes").Width = 60
         .RootTable.Columns("MedidaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MedidaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Cantidad").Caption = "Cantidad"
         .RootTable.Columns("Cantidad").FormatString = DecimalMask()
         .RootTable.Columns("Cantidad").Width = 100
         .RootTable.Columns("Cantidad").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Cantidad").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioOrg").Caption = "Precio FOB"
         .RootTable.Columns("PrecioOrg").FormatString = DecimalMask()
         .RootTable.Columns("PrecioOrg").Width = 100
         .RootTable.Columns("PrecioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Importe").Caption = "Importe FOB"
         .RootTable.Columns("Importe").FormatString = DecimalMask()
         .RootTable.Columns("Importe").Width = 100
         .RootTable.Columns("Importe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Importe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center


         .RootTable.Columns("Iva").Caption = "IVA /Retens."
         .RootTable.Columns("Iva").FormatString = DecimalMask()
         .RootTable.Columns("Iva").Width = 100
         .RootTable.Columns("Iva").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Iva").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteIva").Caption = "Importe - IVA"
         .RootTable.Columns("ImporteIva").FormatString = DecimalMask()
         .RootTable.Columns("ImporteIva").Width = 100
         .RootTable.Columns("ImporteIva").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteIva").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mlngTipoRetencionId <> 0 Then  '' Solo en caso de que tenga Retenciones
            .RootTable.Columns("Iva").Caption = "Retención"
            .RootTable.Columns("ImporteIva").Caption = "Importe + Retención"
         End If

         .RootTable.Columns("Porcentaje").Caption = "Participación"
         .RootTable.Columns("Porcentaje").FormatString = "##,##0.00000"
         .RootTable.Columns("Porcentaje").Width = 100
         .RootTable.Columns("Porcentaje").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Porcentaje").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Recargo").Caption = "Recargos"
         .RootTable.Columns("Recargo").FormatString = DecimalMask()
         .RootTable.Columns("Recargo").Width = 100
         .RootTable.Columns("Recargo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Recargo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Descuento").Caption = "Descuentos"
         .RootTable.Columns("Descuento").FormatString = DecimalMask()
         .RootTable.Columns("Descuento").Width = 100
         .RootTable.Columns("Descuento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Descuento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         For Each oRow As DataRow In moDataSet.Tables(moCompraOtroCosto.TableName).Rows
            .RootTable.Columns(oRow("PlanOtroCostoDes") & " Id" & oRow("CostoIdNro")).Visible = False

            .RootTable.Columns(oRow("PlanOtroCostoDes") & oRow("CostoIdNro")).Caption = oRow("PlanOtroCostoDes")
            .RootTable.Columns(oRow("PlanOtroCostoDes") & oRow("CostoIdNro")).FormatString = DecimalMask()
            .RootTable.Columns(oRow("PlanOtroCostoDes") & oRow("CostoIdNro")).Width = 100
            .RootTable.Columns(oRow("PlanOtroCostoDes") & oRow("CostoIdNro")).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns(oRow("PlanOtroCostoDes") & oRow("CostoIdNro")).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Next

         .RootTable.Columns("Costo").Caption = "Importe Costo"
         .RootTable.Columns("Costo").FormatString = DecimalMask()
         .RootTable.Columns("Costo").Width = 100
         .RootTable.Columns("Costo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Costo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PrecioCif").Caption = "Precio CIF"
         .RootTable.Columns("PrecioCif").FormatString = DecimalMask()
         .RootTable.Columns("PrecioCif").Width = 100
         .RootTable.Columns("PrecioCif").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("PrecioCif").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteCif").Caption = "Importe CIF"
         .RootTable.Columns("ImporteCif").FormatString = DecimalMask()
         .RootTable.Columns("ImporteCif").Width = 100
         .RootTable.Columns("ImporteCif").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteCif").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdProrrateo.RootTable.Columns("ItemId"), Janus.Windows.GridEX.ConditionOperator.Equal, 0)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdProrrateo.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdProrrateo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdProrrateo.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdProrrateo.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdProrrateo.GetRow.Cells(grdProrrateo.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub mnuShowProrrateo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowProrrateo.Click
      Call ProrrateoDataShow()
   End Sub

   Private Sub mnuEditProrrateo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditProrrateo.Click
      Call ProrrateoDataEdit()
   End Sub

#End Region

   Private Sub PrintReportAdicional()
      If mboolEditing Then
         If MessageBox.Show("La impresión se realizará de la ultima Información Guardada. ¿Desea Continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call PrintReport()
         End If

      ElseIf Not mboolAdding Then
         Call PrintReport()
      End If

   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptCompraNext
      Dim srptCompraOtroCosto As New rptCompraOtroCosto
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim oCompraOtroCosto As New clsCompraOtroCosto(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim strTitulo As String

      Try
         oCompra.SelectFilter = clsCompra.SelectFilters.Report
         oCompra.WhereFilter = clsCompra.WhereFilters.Report
         oCompra.OrderByFilter = clsCompra.OrderByFilters.Report
         oCompra.EmpresaId = moCompra.EmpresaId
         oCompra.CompraId = moCompra.CompraId

         If oCompra.Find Then
            rpt.DataSource = oCompra.DataSet.Tables(oCompra.TableName).DefaultView

            rpt.lblFirma.Text = CompraParaFirma(2, moCompra.GestionId, moCompra.SucursalId, strTitulo, lngTipoHojaId)
            rpt.lblTitle.Text = "Hoja de Importación"
            rpt.Document.Name = "Hoja de Importación"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            'rpt.GroupHeader1.DataField = "ItemId"

            With oCompraOtroCosto
               .SelectFilter = clsCompraOtroCosto.SelectFilters.Grid
               .WhereFilter = clsCompraOtroCosto.WhereFilters.Grid
               .OrderByFilter = clsCompraOtroCosto.OrderByFilters.Grid
               .EmpresaId = moCompra.EmpresaId
               .CompraId = moCompra.CompraId

               If .Open() Then
                  srptCompraOtroCosto.DataSource = oCompraOtroCosto.DataSet.Tables(oCompraOtroCosto.TableName).DefaultView
                  rpt.srptCompraOtroCosto.Report = srptCompraOtroCosto

               End If
            End With

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As frmReportPreview
               frm = New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As frmReportPreviewMultiple
               frm = New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
               'frm.PrintReport()
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompra.Dispose()

      End Try
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

   Private Sub tabMainPanel(ByVal strKey As String, ByVal strAction As String)
      Select Case strKey
         Case "CompraRecargo"
            Select Case strAction
               'Case "Show"
               '   Call CompraRecargoDataShow()

               'Case "New"
               '   Call CompraRecargoFormNew()

               'Case "Edit"
               '   Call CompraRecargoDataEdit()

               'Case "Delete"
               '   Call CompraRecargoDataDelete()
            End Select

         Case "CompraDescuento"
            Select Case strAction
               'Case "Show"
               '   Call CompraDescuentoDataShow()

               'Case "New"
               '   Call CompraDescuentoFormNew()

               'Case "Edit"
               '   Call CompraDescuentoDataEdit()

               'Case "Delete"
               '   Call CompraDescuentoDataDelete()
            End Select

         Case "Anticipo"
            Select Case strAction
               Case "Show"
                  Call AnticipoDataShow()

            End Select

         Case "Factura"
            Select Case strAction
               Case "Show"
                  Call FacturaDataShow()

               Case "New"
                  Call FacturaFormNew()

               Case "Edit"
                  Call FacturaDataEdit()

               Case "Delete"
                  Call FacturaDataDelete()
            End Select

         Case "Poliza"
            Select Case strAction
               Case "Show"
                  Call PolizaDataShow()

               Case "New"
                  Call PolizaFormNew()

               Case "Edit"
                  Call PolizaDataEdit()

               Case "Delete"
                  Call PolizaDataDelete()
            End Select

         Case "OtroCosto"
            Select Case strAction
               Case "Show"
                  Call CompraOtroCostoDataShow()

               Case "New"
                  Call CompraOtroCostoFormNew()

               Case "Edit"
                  Call CompraOtroCostoDataEdit()

               Case "Delete"
                  Call CompraOtroCostoDataDelete()
            End Select

      End Select
   End Sub

   Private Sub frmCompraNext_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then

         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moCompra.CompraId
                  mboolChanged = True

                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            If mboolAdding Then
               mlngID = moCompra.CompraId
               moCompra.Update()
            End If

            Me.Close()

         ElseIf (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            Call tabMainPanel(tabMain.SelectedTab.Key(), "New")

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            Call tabMainPanel(tabMain.SelectedTab.Key(), "Edit")

         ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            Call tabMainPanel(tabMain.SelectedTab.Key(), "Delete")

         End If
      End If
   End Sub

   Private Sub frmCompraNext_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

      If mboolAdding Then
         mlngID = moCompra.CompraId
         moCompra.Update()
      End If

      moCompra.Dispose()
      moCompraRecargo.Dispose()
      moCompraDescuento.Dispose()
      moAnticipo.Dispose()
      moFactura.Dispose()
      moPoliza.Dispose()
      moCompraOtroCosto.Dispose()
      moCompraFac.Dispose()
      moFacturaOrg.Dispose()
      moPolizaOrg.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub frmCompraNext_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
      Call CheckFormShow()
   End Sub

End Class
