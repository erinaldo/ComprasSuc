Public Class frmDataBaseImport
   Inherits System.Windows.Forms.Form

   'Inatncias de Clases
   Private moPedCompra As clsPedCompra
   Private moAnticipo As clsAnticipo
   Private moCompra As clsCompra
   Private moDevCompra As clsDevCompra
   Private moCredito As clsCredito
   Private moPago As clsPago

   Private moPedCompraImport As clsPedCompraImport
   Private moAnticipoImport As clsAnticipoImport
   Private moCompraImport As clsCompraImport
   Private moDevCompraImport As clsDevCompraImport
   Private moCreditoImport As clsCreditoImport
   Private moPagoImport As clsPagoImport

   'Variables Internos
   Friend mlngEmpresaIdOrg As Long
   Friend mlngGestionIdOrg As Long

   Private mstrServerOrg As String
   Private mstrUserOrg As String
   Private mstrPassOrg As String
   Private mstrDataBaseOrg As String

   Friend mstrConnectStringOrg As String

   Friend moDataSet As DataSet
   Friend moDataTable As DataTable
   Friend moDataTableItem As DataTable

   'Variables Constante
   Private Const PED_COMPRA As Byte = 1
   Private Const ANTICIPO As Byte = 2
   Private Const COMPRA As Byte = 3
   Private Const DEV_COMPRA As Byte = 4
   Private Const CREDITO As Byte = 5
   Private Const PAGO As Byte = 6

   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboGestion As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboEmpresa As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents DataBaseOrg As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents DataBaseOrg1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Import1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Import As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents pbrMain As Janus.Windows.EditControls.UIProgressBar
   Friend WithEvents txtDataBaseOrg As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents tabPedCompra As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabAnticipo As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents ExplorerBar1 As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdAnticipo As Janus.Windows.GridEX.GridEX
   Friend WithEvents tabCompras As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabDevCompra As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents ExplorerBar2 As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl2 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdCompra As Janus.Windows.GridEX.GridEX
   Friend WithEvents ExplorerBar3 As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl3 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdDevCompra As Janus.Windows.GridEX.GridEX
   Friend WithEvents tabProgCreditos As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents ExplorerBar4 As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl5 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdCredito As Janus.Windows.GridEX.GridEX
   Friend WithEvents tabPagos As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents ExplorerBar5 As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl6 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdPago As Janus.Windows.GridEX.GridEX
   Friend WithEvents grdPedCompra As Janus.Windows.GridEX.GridEX

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
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup4 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup5 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup6 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataBaseImport))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdPedCompra = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl1 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdAnticipo = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl2 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdCompra = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl3 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdDevCompra = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl5 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdCredito = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl6 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdPago = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.tabPedCompra = New Janus.Windows.UI.Tab.UITabPage
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabAnticipo = New Janus.Windows.UI.Tab.UITabPage
      Me.ExplorerBar1 = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabCompras = New Janus.Windows.UI.Tab.UITabPage
      Me.ExplorerBar2 = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabDevCompra = New Janus.Windows.UI.Tab.UITabPage
      Me.ExplorerBar3 = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabProgCreditos = New Janus.Windows.UI.Tab.UITabPage
      Me.ExplorerBar4 = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.tabPagos = New Janus.Windows.UI.Tab.UITabPage
      Me.ExplorerBar5 = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.pbrMain = New Janus.Windows.EditControls.UIProgressBar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtDataBaseOrg = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboGestion = New Janus.Windows.EditControls.UIComboBox
      Me.cboEmpresa = New Janus.Windows.EditControls.UIComboBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.DataBaseOrg1 = New Janus.Windows.UI.CommandBars.UICommand("DataBaseOrg")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Import1 = New Janus.Windows.UI.CommandBars.UICommand("Import")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.DataBaseOrg = New Janus.Windows.UI.CommandBars.UICommand("DataBaseOrg")
      Me.Import = New Janus.Windows.UI.CommandBars.UICommand("Import")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdPedCompra, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl1.SuspendLayout()
      CType(Me.grdAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl2.SuspendLayout()
      CType(Me.grdCompra, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl3.SuspendLayout()
      CType(Me.grdDevCompra, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl5.SuspendLayout()
      CType(Me.grdCredito, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl6.SuspendLayout()
      CType(Me.grdPago, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabMain.SuspendLayout()
      Me.tabPedCompra.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      Me.tabAnticipo.SuspendLayout()
      CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBar1.SuspendLayout()
      Me.tabCompras.SuspendLayout()
      CType(Me.ExplorerBar2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBar2.SuspendLayout()
      Me.tabDevCompra.SuspendLayout()
      CType(Me.ExplorerBar3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBar3.SuspendLayout()
      Me.tabProgCreditos.SuspendLayout()
      CType(Me.ExplorerBar4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBar4.SuspendLayout()
      Me.tabPagos.SuspendLayout()
      CType(Me.ExplorerBar5, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBar5.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdPedCompra)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(713, 272)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdPedCompra
      '
      Me.grdPedCompra.AllowCardSizing = False
      Me.grdPedCompra.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdPedCompra.AlternatingColors = True
      Me.grdPedCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdPedCompra.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdPedCompra.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdPedCompra.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdPedCompra.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdPedCompra.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdPedCompra.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdPedCompra.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdPedCompra.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdPedCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdPedCompra.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdPedCompra.GroupByBoxVisible = False
      Me.grdPedCompra.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdPedCompra.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdPedCompra.Location = New System.Drawing.Point(0, 0)
      Me.grdPedCompra.Name = "grdPedCompra"
      Me.grdPedCompra.RecordNavigator = True
      Me.grdPedCompra.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdPedCompra.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdPedCompra.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdPedCompra.Size = New System.Drawing.Size(713, 272)
      Me.grdPedCompra.TabIndex = 5
      Me.grdPedCompra.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdPedCompra.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdPedCompra.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdPedCompra.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl1
      '
      Me.ExplorerBarContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl1.Controls.Add(Me.grdAnticipo)
      Me.ExplorerBarContainerControl1.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl1.Name = "ExplorerBarContainerControl1"
      Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(716, 271)
      Me.ExplorerBarContainerControl1.TabIndex = 1
      '
      'grdAnticipo
      '
      Me.grdAnticipo.AllowCardSizing = False
      Me.grdAnticipo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdAnticipo.AlternatingColors = True
      Me.grdAnticipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdAnticipo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdAnticipo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdAnticipo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdAnticipo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdAnticipo.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdAnticipo.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
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
      Me.grdAnticipo.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdAnticipo.Size = New System.Drawing.Size(716, 271)
      Me.grdAnticipo.TabIndex = 3
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
      Me.ExplorerBarContainerControl2.Controls.Add(Me.grdCompra)
      Me.ExplorerBarContainerControl2.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl2.Name = "ExplorerBarContainerControl2"
      Me.ExplorerBarContainerControl2.Size = New System.Drawing.Size(716, 271)
      Me.ExplorerBarContainerControl2.TabIndex = 1
      '
      'grdCompra
      '
      Me.grdCompra.AllowCardSizing = False
      Me.grdCompra.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdCompra.AlternatingColors = True
      Me.grdCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdCompra.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdCompra.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdCompra.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdCompra.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdCompra.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdCompra.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdCompra.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdCompra.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdCompra.GroupByBoxVisible = False
      Me.grdCompra.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdCompra.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdCompra.Location = New System.Drawing.Point(0, 0)
      Me.grdCompra.Name = "grdCompra"
      Me.grdCompra.RecordNavigator = True
      Me.grdCompra.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdCompra.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdCompra.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdCompra.Size = New System.Drawing.Size(716, 271)
      Me.grdCompra.TabIndex = 3
      Me.grdCompra.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdCompra.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCompra.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCompra.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl3
      '
      Me.ExplorerBarContainerControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl3.Controls.Add(Me.grdDevCompra)
      Me.ExplorerBarContainerControl3.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl3.Name = "ExplorerBarContainerControl3"
      Me.ExplorerBarContainerControl3.Size = New System.Drawing.Size(716, 271)
      Me.ExplorerBarContainerControl3.TabIndex = 1
      '
      'grdDevCompra
      '
      Me.grdDevCompra.AllowCardSizing = False
      Me.grdDevCompra.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdDevCompra.AlternatingColors = True
      Me.grdDevCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdDevCompra.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdDevCompra.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdDevCompra.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdDevCompra.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdDevCompra.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdDevCompra.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdDevCompra.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdDevCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdDevCompra.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdDevCompra.GroupByBoxVisible = False
      Me.grdDevCompra.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdDevCompra.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdDevCompra.Location = New System.Drawing.Point(0, 0)
      Me.grdDevCompra.Name = "grdDevCompra"
      Me.grdDevCompra.RecordNavigator = True
      Me.grdDevCompra.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdDevCompra.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdDevCompra.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdDevCompra.Size = New System.Drawing.Size(716, 271)
      Me.grdDevCompra.TabIndex = 3
      Me.grdDevCompra.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdDevCompra.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDevCompra.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDevCompra.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl5
      '
      Me.ExplorerBarContainerControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl5.Controls.Add(Me.grdCredito)
      Me.ExplorerBarContainerControl5.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl5.Name = "ExplorerBarContainerControl5"
      Me.ExplorerBarContainerControl5.Size = New System.Drawing.Size(716, 271)
      Me.ExplorerBarContainerControl5.TabIndex = 1
      '
      'grdCredito
      '
      Me.grdCredito.AllowCardSizing = False
      Me.grdCredito.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdCredito.AlternatingColors = True
      Me.grdCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdCredito.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdCredito.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdCredito.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdCredito.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdCredito.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdCredito.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdCredito.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdCredito.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdCredito.GroupByBoxVisible = False
      Me.grdCredito.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdCredito.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdCredito.Location = New System.Drawing.Point(0, 0)
      Me.grdCredito.Name = "grdCredito"
      Me.grdCredito.RecordNavigator = True
      Me.grdCredito.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdCredito.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdCredito.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdCredito.Size = New System.Drawing.Size(716, 271)
      Me.grdCredito.TabIndex = 3
      Me.grdCredito.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdCredito.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCredito.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdCredito.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl6
      '
      Me.ExplorerBarContainerControl6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl6.Controls.Add(Me.grdPago)
      Me.ExplorerBarContainerControl6.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl6.Name = "ExplorerBarContainerControl6"
      Me.ExplorerBarContainerControl6.Size = New System.Drawing.Size(716, 271)
      Me.ExplorerBarContainerControl6.TabIndex = 1
      '
      'grdPago
      '
      Me.grdPago.AllowCardSizing = False
      Me.grdPago.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdPago.AlternatingColors = True
      Me.grdPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdPago.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdPago.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdPago.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdPago.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdPago.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdPago.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdPago.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdPago.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdPago.GroupByBoxVisible = False
      Me.grdPago.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdPago.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdPago.Location = New System.Drawing.Point(0, 0)
      Me.grdPago.Name = "grdPago"
      Me.grdPago.RecordNavigator = True
      Me.grdPago.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdPago.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdPago.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdPago.Size = New System.Drawing.Size(716, 271)
      Me.grdPago.TabIndex = 3
      Me.grdPago.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdPago.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdPago.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdPago.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.tabMain)
      Me.uiBackground.Controls.Add(Me.pbrMain)
      Me.uiBackground.Controls.Add(Me.grpMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 5
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(4, 48)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(744, 336)
      Me.tabMain.TabIndex = 7
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabPedCompra, Me.tabAnticipo, Me.tabCompras, Me.tabDevCompra, Me.tabProgCreditos, Me.tabPagos})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'tabPedCompra
      '
      Me.tabPedCompra.Controls.Add(Me.ebrMain)
      Me.tabPedCompra.Key = "tabPedCompra"
      Me.tabPedCompra.Location = New System.Drawing.Point(1, 21)
      Me.tabPedCompra.Name = "tabPedCompra"
      Me.tabPedCompra.Size = New System.Drawing.Size(742, 314)
      Me.tabPedCompra.TabStop = True
      Me.tabPedCompra.Text = "Pedido de Compras"
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
      ExplorerBarGroup1.ContainerHeight = 273
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(7, 3)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(729, 305)
      Me.ebrMain.TabIndex = 4
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabAnticipo
      '
      Me.tabAnticipo.Controls.Add(Me.ExplorerBar1)
      Me.tabAnticipo.Key = "tabAnticipo"
      Me.tabAnticipo.Location = New System.Drawing.Point(1, 21)
      Me.tabAnticipo.Name = "tabAnticipo"
      Me.tabAnticipo.Size = New System.Drawing.Size(742, 314)
      Me.tabAnticipo.TabStop = True
      Me.tabAnticipo.Text = "Anticipos"
      Me.tabAnticipo.Visible = False
      '
      'ExplorerBar1
      '
      Me.ExplorerBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBar1.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ExplorerBar1.Controls.Add(Me.ExplorerBarContainerControl1)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl1
      ExplorerBarGroup2.ContainerHeight = 272
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ExplorerBar1.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ExplorerBar1.GroupSeparation = 4
      Me.ExplorerBar1.Location = New System.Drawing.Point(4, 4)
      Me.ExplorerBar1.Name = "ExplorerBar1"
      Me.ExplorerBar1.Size = New System.Drawing.Size(732, 304)
      Me.ExplorerBar1.TabIndex = 3
      Me.ExplorerBar1.Text = "ExplorerBar2"
      Me.ExplorerBar1.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ExplorerBar1.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar1.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar1.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabCompras
      '
      Me.tabCompras.Controls.Add(Me.ExplorerBar2)
      Me.tabCompras.Key = "tabCompras"
      Me.tabCompras.Location = New System.Drawing.Point(1, 21)
      Me.tabCompras.Name = "tabCompras"
      Me.tabCompras.Size = New System.Drawing.Size(742, 314)
      Me.tabCompras.TabStop = True
      Me.tabCompras.Text = "Compras"
      '
      'ExplorerBar2
      '
      Me.ExplorerBar2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBar2.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ExplorerBar2.Controls.Add(Me.ExplorerBarContainerControl2)
      ExplorerBarGroup3.Container = True
      ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl2
      ExplorerBarGroup3.ContainerHeight = 272
      ExplorerBarGroup3.Expandable = False
      ExplorerBarGroup3.Key = "Group1"
      Me.ExplorerBar2.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
      Me.ExplorerBar2.GroupSeparation = 4
      Me.ExplorerBar2.Location = New System.Drawing.Point(5, 5)
      Me.ExplorerBar2.Name = "ExplorerBar2"
      Me.ExplorerBar2.Size = New System.Drawing.Size(732, 304)
      Me.ExplorerBar2.TabIndex = 4
      Me.ExplorerBar2.Text = "ExplorerBar2"
      Me.ExplorerBar2.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ExplorerBar2.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar2.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar2.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabDevCompra
      '
      Me.tabDevCompra.Controls.Add(Me.ExplorerBar3)
      Me.tabDevCompra.Key = "tabDevCompra"
      Me.tabDevCompra.Location = New System.Drawing.Point(1, 21)
      Me.tabDevCompra.Name = "tabDevCompra"
      Me.tabDevCompra.Size = New System.Drawing.Size(742, 314)
      Me.tabDevCompra.TabStop = True
      Me.tabDevCompra.Text = "Dev. Compras"
      '
      'ExplorerBar3
      '
      Me.ExplorerBar3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBar3.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ExplorerBar3.Controls.Add(Me.ExplorerBarContainerControl3)
      ExplorerBarGroup4.Container = True
      ExplorerBarGroup4.ContainerControl = Me.ExplorerBarContainerControl3
      ExplorerBarGroup4.ContainerHeight = 272
      ExplorerBarGroup4.Expandable = False
      ExplorerBarGroup4.Key = "Group1"
      Me.ExplorerBar3.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup4})
      Me.ExplorerBar3.GroupSeparation = 4
      Me.ExplorerBar3.Location = New System.Drawing.Point(5, 5)
      Me.ExplorerBar3.Name = "ExplorerBar3"
      Me.ExplorerBar3.Size = New System.Drawing.Size(732, 304)
      Me.ExplorerBar3.TabIndex = 4
      Me.ExplorerBar3.Text = "ExplorerBar2"
      Me.ExplorerBar3.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ExplorerBar3.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar3.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar3.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabProgCreditos
      '
      Me.tabProgCreditos.Controls.Add(Me.ExplorerBar4)
      Me.tabProgCreditos.Key = "tabProgCreditos"
      Me.tabProgCreditos.Location = New System.Drawing.Point(1, 21)
      Me.tabProgCreditos.Name = "tabProgCreditos"
      Me.tabProgCreditos.Size = New System.Drawing.Size(742, 314)
      Me.tabProgCreditos.TabStop = True
      Me.tabProgCreditos.Text = "Prog. Creditos"
      '
      'ExplorerBar4
      '
      Me.ExplorerBar4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBar4.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ExplorerBar4.Controls.Add(Me.ExplorerBarContainerControl5)
      ExplorerBarGroup5.Container = True
      ExplorerBarGroup5.ContainerControl = Me.ExplorerBarContainerControl5
      ExplorerBarGroup5.ContainerHeight = 272
      ExplorerBarGroup5.Expandable = False
      ExplorerBarGroup5.Key = "Group1"
      Me.ExplorerBar4.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup5})
      Me.ExplorerBar4.GroupSeparation = 4
      Me.ExplorerBar4.Location = New System.Drawing.Point(5, 5)
      Me.ExplorerBar4.Name = "ExplorerBar4"
      Me.ExplorerBar4.Size = New System.Drawing.Size(732, 304)
      Me.ExplorerBar4.TabIndex = 4
      Me.ExplorerBar4.Text = "ExplorerBar2"
      Me.ExplorerBar4.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ExplorerBar4.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar4.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar4.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'tabPagos
      '
      Me.tabPagos.Controls.Add(Me.ExplorerBar5)
      Me.tabPagos.Key = "tabPagos"
      Me.tabPagos.Location = New System.Drawing.Point(1, 21)
      Me.tabPagos.Name = "tabPagos"
      Me.tabPagos.Size = New System.Drawing.Size(742, 314)
      Me.tabPagos.TabStop = True
      Me.tabPagos.Text = "Pagos"
      '
      'ExplorerBar5
      '
      Me.ExplorerBar5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBar5.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ExplorerBar5.Controls.Add(Me.ExplorerBarContainerControl6)
      ExplorerBarGroup6.Container = True
      ExplorerBarGroup6.ContainerControl = Me.ExplorerBarContainerControl6
      ExplorerBarGroup6.ContainerHeight = 272
      ExplorerBarGroup6.Expandable = False
      ExplorerBarGroup6.Key = "Group1"
      Me.ExplorerBar5.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup6})
      Me.ExplorerBar5.GroupSeparation = 4
      Me.ExplorerBar5.Location = New System.Drawing.Point(5, 5)
      Me.ExplorerBar5.Name = "ExplorerBar5"
      Me.ExplorerBar5.Size = New System.Drawing.Size(732, 304)
      Me.ExplorerBar5.TabIndex = 4
      Me.ExplorerBar5.Text = "ExplorerBar2"
      Me.ExplorerBar5.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ExplorerBar5.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar5.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ExplorerBar5.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'pbrMain
      '
      Me.pbrMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.pbrMain.Location = New System.Drawing.Point(4, 388)
      Me.pbrMain.Name = "pbrMain"
      Me.pbrMain.ShowPercentage = True
      Me.pbrMain.Size = New System.Drawing.Size(744, 23)
      Me.pbrMain.TabIndex = 6
      Me.pbrMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtDataBaseOrg)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.cboGestion)
      Me.grpMain.Controls.Add(Me.cboEmpresa)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Location = New System.Drawing.Point(4, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(744, 44)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtDataBaseOrg
      '
      Me.txtDataBaseOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDataBaseOrg.Location = New System.Drawing.Point(80, 16)
      Me.txtDataBaseOrg.MaxLength = 255
      Me.txtDataBaseOrg.Name = "txtDataBaseOrg"
      Me.txtDataBaseOrg.ReadOnly = True
      Me.txtDataBaseOrg.Size = New System.Drawing.Size(176, 20)
      Me.txtDataBaseOrg.TabIndex = 1
      Me.txtDataBaseOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDataBaseOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label7.Location = New System.Drawing.Point(8, 20)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(68, 16)
      Me.Label7.TabIndex = 187
      Me.Label7.Text = "DB Origen"
      '
      'cboGestion
      '
      Me.cboGestion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.Location = New System.Drawing.Point(636, 16)
      Me.cboGestion.Name = "cboGestion"
      Me.cboGestion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboGestion.Size = New System.Drawing.Size(100, 20)
      Me.cboGestion.TabIndex = 3
      Me.cboGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboEmpresa
      '
      Me.cboEmpresa.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.Location = New System.Drawing.Point(328, 16)
      Me.cboEmpresa.Name = "cboEmpresa"
      Me.cboEmpresa.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEmpresa.Size = New System.Drawing.Size(240, 20)
      Me.cboEmpresa.TabIndex = 2
      Me.cboEmpresa.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label9.Location = New System.Drawing.Point(580, 20)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(52, 16)
      Me.Label9.TabIndex = 183
      Me.Label9.Text = "Gestión"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label5.Location = New System.Drawing.Point(268, 20)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(56, 16)
      Me.Label5.TabIndex = 175
      Me.Label5.Text = "Empresa"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "Database (Add).ico")
      Me.ilsMain.Images.SetKeyName(1, "70.ICO")
      Me.ilsMain.Images.SetKeyName(2, "")
      Me.ilsMain.Images.SetKeyName(3, "")
      Me.ilsMain.Images.SetKeyName(4, "")
      Me.ilsMain.Images.SetKeyName(5, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ViewAll, Me.Print, Me.Exit2, Me.Refrescar, Me.DataBaseOrg, Me.Import})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("14565a15-ea74-408e-b698-fb1d6c9d5b6b")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.DataBaseOrg1, Me.Separator1, Me.Refrescar1, Me.Separator3, Me.Import1, Me.Separator7, Me.ViewAll1, Me.Separator4, Me.Print1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(494, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'DataBaseOrg1
      '
      Me.DataBaseOrg1.Key = "DataBaseOrg"
      Me.DataBaseOrg1.Name = "DataBaseOrg1"
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
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Import1
      '
      Me.Import1.Key = "Import"
      Me.Import1.Name = "Import1"
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
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 2
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 3
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 4
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 5
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'DataBaseOrg
      '
      Me.DataBaseOrg.ImageIndex = 0
      Me.DataBaseOrg.Key = "DataBaseOrg"
      Me.DataBaseOrg.Name = "DataBaseOrg"
      Me.DataBaseOrg.Text = "BD Origen"
      Me.DataBaseOrg.ToolTipText = "Base de Datos Origen"
      '
      'Import
      '
      Me.Import.ImageIndex = 1
      Me.Import.Key = "Import"
      Me.Import.Name = "Import"
      Me.Import.Text = "Importar"
      Me.Import.ToolTipText = "Importar Información desde la Base de Datos Origen"
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
      'frmDataBaseImport
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmDataBaseImport"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Importar Información Desde Otra Base de Datos"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdPedCompra, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl1.ResumeLayout(False)
      CType(Me.grdAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl2.ResumeLayout(False)
      CType(Me.grdCompra, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl3.ResumeLayout(False)
      CType(Me.grdDevCompra, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl5.ResumeLayout(False)
      CType(Me.grdCredito, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl6.ResumeLayout(False)
      CType(Me.grdPago, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabMain.ResumeLayout(False)
      Me.tabPedCompra.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      Me.tabAnticipo.ResumeLayout(False)
      CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBar1.ResumeLayout(False)
      Me.tabCompras.ResumeLayout(False)
      CType(Me.ExplorerBar2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBar2.ResumeLayout(False)
      Me.tabDevCompra.ResumeLayout(False)
      CType(Me.ExplorerBar3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBar3.ResumeLayout(False)
      Me.tabProgCreditos.ResumeLayout(False)
      CType(Me.ExplorerBar4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBar4.ResumeLayout(False)
      Me.tabPagos.ResumeLayout(False)
      CType(Me.ExplorerBar5, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBar5.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
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
         Case "DataBaseOrg"
            Call frmDataBaseOrgLoad()

         Case "Refrescar"
            Call grdMainLoad()

         Case "Import"
            Dim intRowSel As Integer
            Dim intRowExport As Integer
            Dim oTimeSpan As TimeSpan

            If dataImport(intRowSel, intRowExport, oTimeSpan) Then
               MessageBox.Show(ToStr(intRowExport) & " de " & ToStr(intRowSel) & " Registros Importados Exitosamente" & vbCrLf & "Tiempo Estimado " & oTimeSpan.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDataBaseImport_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmDataBaseImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ClearMemory()

      'mstrConnectStringOrg = "Provider=sqloledb;Data Source=(local);Initial Catalog=DelfinNetOld;User ID=sa;Password=sa;Current Language=us_english"
      'txtDataBaseOrg.Text = "(local).DelfinNetOld"

      'Call ComboLoad()
      'cboEmpresa.SelectedIndex = ListFindItem(cboEmpresa, 1)
      'cboGestion.SelectedIndex = ListFindItem(cboGestion, 75)

      'Call grdMainLoad()

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDataBaseOrgLoad()
      Dim frm As New frmDataBaseOrg

      With frm
         .ShowDialog()

         If .Changed Then
            mstrConnectStringOrg = .ConnectStringOrg
            txtDataBaseOrg.Text = .DataBaseOrg
            Call ComboLoad()
            cboEmpresa.SelectedIndex = ListFindItem(cboEmpresa, clsAppInfo.EmpresaId)
            cboGestion.SelectedIndex = ListFindItem(cboGestion, clsAppInfo.GestionId)
            Call grdMainLoad()
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub grdMainLoad()
      Try
         mlngEmpresaIdOrg = ListPosition(cboEmpresa, cboEmpresa.SelectedIndex)
         mlngGestionIdOrg = ListPosition(cboGestion, cboGestion.SelectedIndex)

         If formCheck() Then
            Call grdPedCompraLoad()
            Call grdAnticipoLoad()
            Call grdCompraLoad()
            Call grdDevCompraLoad()
            Call grdCreditoLoad()
            Call grdPagoLoad()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   'Metodo que genera una grilla con registros de Pedidos de Compra
   Private Sub grdPedCompraLoad()
      Try
       
         moPedCompra = New clsPedCompra(mstrConnectStringOrg)

         With moPedCompra
            .SelectFilter = clsPedCompra.SelectFilters.GRID_IMPORT
            .WhereFilter = clsPedCompra.WhereFilters.Grid
            .OrderByFilter = clsPedCompra.OrderByFilters.GridFecha
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open() Then
               grdPedCompra.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdPedCompra.RetrieveStructure()
               Call grdPedCompraInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   'Metodo que genera una grilla con registros de Anticipos
   Private Sub grdAnticipoLoad()
      Try
        
         moAnticipo = New clsAnticipo(mstrConnectStringOrg)

         With moAnticipo
            .SelectFilter = clsAnticipo.SelectFilters.GRID_IMPORT
            .WhereFilter = clsAnticipo.WhereFilters.GRID_IMPORT
            .OrderByFilter = clsAnticipo.OrderByFilters.GridFecha
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open() Then
               grdAnticipo.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdAnticipo.RetrieveStructure()
               Call grdAnticipoInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   'Metodo que genera una grilla con registros de Compra
   Private Sub grdCompraLoad()
      Try
         moCompra = New clsCompra(mstrConnectStringOrg)

         With moCompra
            .SelectFilter = clsCompra.SelectFilters.GRID_IMPORT
            .WhereFilter = clsCompra.WhereFilters.GRID_IMPORT
            .OrderByFilter = clsCompra.OrderByFilters.GridFecha
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open() Then
               grdCompra.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdCompra.RetrieveStructure()
               Call grdCompraInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   'Metodo que genera una grilla con registros de devoluciones de Compra
   Private Sub grdDevCompraLoad()
      Try
         moDevCompra = New clsDevCompra(mstrConnectStringOrg)

         With moDevCompra
            .SelectFilter = clsDevCompra.SelectFilters.GRID_IMPORT
            .WhereFilter = clsDevCompra.WhereFilters.GRID_IMPORT
            .OrderByFilter = clsDevCompra.OrderByFilters.GRID_FECHA
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open() Then
               grdDevCompra.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdDevCompra.RetrieveStructure()
               Call grdDevCompraInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   'Metodo que genera una grilla con registros de Creditos de Compra
   Private Sub grdCreditoLoad()
      Try
         moCredito = New clsCredito(mstrConnectStringOrg)

         With moCredito
            .SelectFilter = clsCredito.SelectFilters.GRID_IMPORT
            .WhereFilter = clsCredito.WhereFilters.GRID_IMPORT
            .OrderByFilter = clsCredito.OrderByFilters.GRID_FECHA
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open() Then
               grdCredito.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdCredito.RetrieveStructure()
               Call grdCreditoInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   'Metodo que genera una grilla con registros de Creditos de Compra
   Private Sub grdPagoLoad()
      Try
         moPago = New clsPago(mstrConnectStringOrg)

         With moPago
            .SelectFilter = clsPago.SelectFilters.GRID_IMPORT
            .WhereFilter = clsPago.WhereFilters.GRID_IMPORT
            .OrderByFilter = clsPago.OrderByFilters.GRID_FECHA
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open() Then
               grdPago.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdPago.RetrieveStructure()
               Call grdPagoInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function formCheck() As Boolean
      Dim strMsg As String = String.Empty

      If mstrConnectStringOrg = "" Then
         strMsg &= "Cadena de Conexión de la Base de Datos Origen Inválida" & vbCrLf
      End If

      If mlngEmpresaIdOrg = 0 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      If mlngGestionIdOrg = 0 Then
         strMsg &= "Gestión Inválida" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function dataImport(ByRef intRowSel As Integer, ByRef intRowExport As Integer, ByRef oTimeSpan As TimeSpan) As Boolean
      Call moDataSetInit()
      Dim strNameTabPage As String = tabMain.SelectedTab.Name

      Select Case strNameTabPage
         Case tabPedCompra.Name
            moPedCompraImport = New clsPedCompraImport(Me)
            dataImport = moPedCompraImport.DataImport()
            intRowSel = moPedCompraImport.RowSel
            intRowExport = moPedCompraImport.RowExport
            oTimeSpan = moPedCompraImport.TimeSpan
         Case tabAnticipo.Name
            moAnticipoImport = New clsAnticipoImport(Me)
            dataImport = moAnticipoImport.DataImport()
            intRowSel = moAnticipoImport.RowSel
            intRowExport = moAnticipoImport.RowExport
            oTimeSpan = moAnticipoImport.TimeSpan
         Case tabCompras.Name
            moCompraImport = New clsCompraImport(Me)
            dataImport = moCompraImport.DataImport()
            intRowSel = moCompraImport.RowSel
            intRowExport = moCompraImport.RowExport
            oTimeSpan = moCompraImport.TimeSpan
         Case tabDevCompra.Name
            moDevCompraImport = New clsDevCompraImport(Me)
            dataImport = moDevCompraImport.DataImport()
            intRowSel = moDevCompraImport.RowSel
            intRowExport = moDevCompraImport.RowExport
            oTimeSpan = moDevCompraImport.TimeSpan
         Case tabProgCreditos.Name
            moCreditoImport = New clsCreditoImport(Me)
            dataImport = moCreditoImport.DataImport()
            intRowSel = moCreditoImport.RowSel
            intRowExport = moCreditoImport.RowExport
            oTimeSpan = moCreditoImport.TimeSpan
         Case tabPagos.Name
            moPagoImport = New clsPagoImport(Me)
            dataImport = moPagoImport.DataImport()
            intRowSel = moPagoImport.RowSel
            intRowExport = moPagoImport.RowExport
            oTimeSpan = moPagoImport.TimeSpan

      End Select
   End Function

   Private Sub ComboLoad()
      Call cboEmpresaLoad()
   End Sub

   Private Sub cboEmpresaLoad()
      Dim oEmpresa As New clsEmpresa(mstrConnectStringOrg)
      Dim oItem As clsListItem

      cboEmpresa.Items.Clear()
      cboEmpresa.Text = ""

      Try
         With oEmpresa
            .SelectFilter = clsEmpresa.SelectFilters.ListBox
            .OrderByFilter = clsEmpresa.OrderByFilters.EmpresaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.EmpresaId, .EmpresaDes)

                  cboEmpresa.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboGestionLoad(ByVal lngEmpresaId As Long)
      Dim oGestion As New clsGestion(mstrConnectStringOrg)
      Dim oItem As clsListItem

      cboGestion.Items.Clear()
      cboGestion.Text = ""

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.EmpresaId
            .OrderByFilter = clsGestion.OrderByFilters.Gestion

            .EmpresaId = lngEmpresaId
            .EstadoId = 11

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.GestionId, ToStr(.Gestion))

                  cboGestion.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add("Errores")
      moDataTableItem = moDataSet.Tables.Add("invItem")

      moDataTable.Columns.Add("TablaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TablaDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TablaNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TablaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("DocumentoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ErrorDes", Type.GetType("System.String"))

      moDataTableItem.Columns.Add("DocumentoIdDetOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("ItemIdOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("ItemCodOrg", Type.GetType("System.String"))
      moDataTableItem.Columns.Add("ItemDesOrg", Type.GetType("System.String"))
      moDataTableItem.Columns.Add("MedidaIdOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("MedidaIdEquiOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("MedidaCantEquiOrg", Type.GetType("System.Decimal"))
      moDataTableItem.Columns.Add("TipoItemIdOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("ControlLoteOrg", Type.GetType("System.Byte"))
      moDataTableItem.Columns.Add("ControlSerieOrg", Type.GetType("System.Byte"))
      moDataTableItem.Columns.Add("MonedaIdCosOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("MonedaIdVenOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("TipoCosteoIdOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("PlanGrupoIdOrg", Type.GetType("System.Int32"))
      moDataTableItem.Columns.Add("ItemIdDes", Type.GetType("System.Int32"))
   End Sub

   Private Function moDataTableItemCodFind(ByVal strItemCod As String) As Boolean
      moDataTableItemCodFind = False

      For Each oRow As DataRow In moDataTableItem.Rows
         If ToStr(oRow("ItemCodOrg")) = strItemCod Then
            Return True
         End If
      Next
   End Function

   Private Sub DataViewAll()
      grdPedCompra.RemoveFilters()
   End Sub

   Private Function GetDataView(ByVal oDataTableOrg As DataTable) As System.Data.DataView
      If grdPedCompra.RootTable.FilterApplied Is Nothing Then
         Return oDataTableOrg.DefaultView

      Else
         Dim oDataTable As DataTable
         Dim oRow As DataRow

         oDataTable = oDataTableOrg.Clone

         For Each oRowMain In grdPedCompra.GetRows()
            oRow = oDataTable.NewRow

            For i = 0 To oRowMain.Cells.Count - 1
               oRow(i) = oRowMain.Cells(i).Value
            Next

            oDataTable.Rows.Add(oRow)
         Next

         Return oDataTable.DefaultView
      End If
   End Function

   Private Sub PrintReport()
      'Dim rpt As New rptComp

      'rpt.DataSource = GetDataView(moComp.DataSet.Tables(moComp.TableName))

      'rpt.lblTitle.Text = "Listado de Comprobantes"
      'rpt.Document.Name = "Listado de Comprobantes"
      'rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      'rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      'rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      'rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      'Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      'rpt.Run(True)
      'Dim frm As New frmReportPreview(rpt.Document)
      'frm.Show()
   End Sub

   Private Sub grdPedCompraFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdPedCompra.RootTable.Columns("CompId")

      grdPedCompra.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)
   End Sub

   Private Sub grdPedCompraInit()
      With grdPedCompra

         ebrMain.Groups(0).Text = "PedCompras de Inventario"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

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

         .RootTable.Columns("AlmacenId").Visible = False

         .RootTable.Columns("AlmacenCod").Visible = False

         .RootTable.Columns("AlmacenDes").Caption = "Almacén"
         .RootTable.Columns("AlmacenDes").Width = 100
         .RootTable.Columns("AlmacenDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AlmacenDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PedCompraDes").Caption = "Descripción"
         .RootTable.Columns("PedCompraDes").Width = 100
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

         .RootTable.Columns("ProveedorId").Visible = False

         .RootTable.Columns("ProveedorCod").Visible = False

         .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
         .RootTable.Columns("ProveedorDes").Width = 200
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("CompraNro").Caption = "Nro Compra"
         .RootTable.Columns("CompraNro").Width = 100
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With

      Call addConditionalFormatting(PED_COMPRA, grdPedCompra)
   End Sub

   Private Sub grdAnticipoInit()
      With grdAnticipo

         ebrMain.Groups(0).Text = "Anticipos y Devoluciones de Anticipos"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("AnticipoId").Visible = False

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

         .RootTable.Columns("TipoAnticipoId").Visible = False

         .RootTable.Columns("TipoAnticipoDes").Caption = "Tipo"
         .RootTable.Columns("TipoAnticipoDes").Width = 100
         .RootTable.Columns("TipoAnticipoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoAnticipoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AnticipoNro").Caption = "Número"
         .RootTable.Columns("AnticipoNro").Width = 100
         .RootTable.Columns("AnticipoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("AnticipoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 100
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProveedorId").Visible = False
         .RootTable.Columns("ProveedorCod").Visible = False

         .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
         .RootTable.Columns("ProveedorDes").Width = 200
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AnticipoDes").Caption = "Descripción"
         .RootTable.Columns("AnticipoDes").Width = 100
         .RootTable.Columns("AnticipoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AnticipoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AnticipoObs").Caption = "Observación"
         .RootTable.Columns("AnticipoObs").Width = 100
         .RootTable.Columns("AnticipoObs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AnticipoObs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

         .RootTable.Columns("MontoAnt").Caption = "Monto"
         .RootTable.Columns("MontoAnt").FormatString = DecimalMask()
         .RootTable.Columns("MontoAnt").Width = 100
         .RootTable.Columns("MontoAnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoAnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoDes").Caption = "Descargo"
         .RootTable.Columns("MontoDes").FormatString = DecimalMask()
         .RootTable.Columns("MontoDes").Width = 100
         .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoPen").Caption = "Pendiente"
         .RootTable.Columns("MontoPen").FormatString = DecimalMask()
         .RootTable.Columns("MontoPen").Width = 100
         .RootTable.Columns("MontoPen").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoPen").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PedCompraId").Visible = False

         .RootTable.Columns("PedCompraNro").Caption = "Nro Pedido"
         .RootTable.Columns("PedCompraNro").Width = 100
         .RootTable.Columns("PedCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo Comp."
         .RootTable.Columns("TipoCompDes").Width = 100
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Nro Comp."
         .RootTable.Columns("CompNro").Width = 100
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanId").Visible = False
         .RootTable.Columns("TipoPlanId").Visible = False
         .RootTable.Columns("PlanCta").Visible = False

         .RootTable.Columns("SinFac").Caption = "I"
         .RootTable.Columns("SinFac").Width = 50
         .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ConFac").Caption = "F"
         .RootTable.Columns("ConFac").Width = 50
         .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call addConditionalFormatting(ANTICIPO, grdAnticipo)
   End Sub

   Private Sub grdCompraInit()
      With grdCompra
         ebrMain.Groups(0).Text = "Notas de Compra"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

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

         .RootTable.Columns("FacturaId").Visible = False
         .RootTable.Columns("NroAutorizacion").Visible = False
         .RootTable.Columns("FacturaNro").Visible = False
         .RootTable.Columns("TipoFacturaId").Visible = False

         .RootTable.Columns("PolizaId").Visible = False

         .RootTable.Columns("PlanId").Visible = False
         .RootTable.Columns("TipoPlanId").Visible = False
         .RootTable.Columns("PlanCta").Visible = False

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

         .RootTable.Columns("AlmacenCod").Visible = False

         .RootTable.Columns("AlmacenDes").Caption = "Almacén"
         .RootTable.Columns("AlmacenDes").Width = 100
         .RootTable.Columns("AlmacenDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AlmacenDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProveedorId").Visible = False

         .RootTable.Columns("ProveedorCod").Visible = False

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

         .RootTable.Columns("MontoNet").Caption = "Total Costo"
         .RootTable.Columns("MontoNet").FormatString = DecimalMask()
         .RootTable.Columns("MontoNet").Width = 100
         .RootTable.Columns("MontoNet").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoNet").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoLiq").Caption = "Liq. Pagable"
         .RootTable.Columns("MontoLiq").FormatString = DecimalMask()
         .RootTable.Columns("MontoLiq").Width = 100
         .RootTable.Columns("MontoLiq").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoLiq").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoBru").Caption = "Monto Bruto"
         .RootTable.Columns("MontoBru").FormatString = DecimalMask()
         .RootTable.Columns("MontoBru").Width = 100
         .RootTable.Columns("MontoBru").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoBru").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PedCompraId").Visible = False

         .RootTable.Columns("PedCompraNro").Caption = "Nro Pedido"
         .RootTable.Columns("PedCompraNro").Width = 100
         .RootTable.Columns("PedCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PedCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CreditoId").Visible = False

         .RootTable.Columns("CreditoNro").Caption = "Nro Credito"
         .RootTable.Columns("CreditoNro").Width = 100
         .RootTable.Columns("CreditoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CreditoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoNotaId").Visible = False

         .RootTable.Columns("TipoNotaDes").Caption = "Tipo Nota"
         .RootTable.Columns("TipoNotaDes").Width = 100
         .RootTable.Columns("TipoNotaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoNotaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NotaNro").Caption = "Nro Nota"
         .RootTable.Columns("NotaNro").Width = 100
         .RootTable.Columns("NotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo Comp."
         .RootTable.Columns("TipoCompDes").Width = 100
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Nro Comp."
         .RootTable.Columns("CompNro").Width = 100
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SinFac").Caption = "I"
         .RootTable.Columns("SinFac").Width = 50
         .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ConFac").Caption = "F"
         .RootTable.Columns("ConFac").Width = 50
         .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With

      Call addConditionalFormatting(COMPRA, grdCompra)
   End Sub

   Private Sub grdDevCompraInit()
      With grdDevCompra
         ebrMain.Groups(0).Text = "Devoluciones Sobre Compras"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("DevCompraId").Visible = False

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

         .RootTable.Columns("DevCompraNro").Caption = "Número"
         .RootTable.Columns("DevCompraNro").Width = 100
         .RootTable.Columns("DevCompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("DevCompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 100
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("AlmacenId").Visible = False

         .RootTable.Columns("AlmacenCod").Visible = False

         .RootTable.Columns("AlmacenDes").Caption = "Almacén"
         .RootTable.Columns("AlmacenDes").Width = 100
         .RootTable.Columns("AlmacenDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("AlmacenDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProveedorId").Visible = False

         .RootTable.Columns("ProveedorCod").Visible = False

         .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
         .RootTable.Columns("ProveedorDes").Width = 200
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("DevCompraDes").Caption = "Descripción"
         .RootTable.Columns("DevCompraDes").Width = 100
         .RootTable.Columns("DevCompraDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("DevCompraDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

         .RootTable.Columns("MontoOrg").Caption = "Monto Orig"
         .RootTable.Columns("MontoOrg").FormatString = DecimalMask()
         .RootTable.Columns("MontoOrg").Width = 100
         .RootTable.Columns("MontoOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoCos").Caption = "Monto Costo"
         .RootTable.Columns("MontoCos").FormatString = DecimalMask()
         .RootTable.Columns("MontoCos").Width = 100
         .RootTable.Columns("MontoCos").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoCos").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoNet").Caption = "Monto Neto"
         .RootTable.Columns("MontoNet").FormatString = DecimalMask()
         .RootTable.Columns("MontoNet").Width = 100
         .RootTable.Columns("MontoNet").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoNet").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraId").Visible = False

         .RootTable.Columns("CompraNro").Caption = "Compra Nro"
         .RootTable.Columns("CompraNro").Width = 100
         .RootTable.Columns("CompraNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompraNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CreditoId").Visible = False

         .RootTable.Columns("CreditoNro").Caption = "Credito Nro"
         .RootTable.Columns("CreditoNro").Width = 100
         .RootTable.Columns("CreditoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CreditoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoNotaId").Visible = False

         .RootTable.Columns("TipoNotaDes").Caption = "Nota"
         .RootTable.Columns("TipoNotaDes").Width = 100
         .RootTable.Columns("TipoNotaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoNotaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NotaNro").Caption = "Nota Nro"
         .RootTable.Columns("NotaNro").Width = 100
         .RootTable.Columns("NotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Comp."
         .RootTable.Columns("TipoCompDes").Width = 100
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Comp. Nro"
         .RootTable.Columns("CompNro").Width = 100
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanId").Visible = False
         .RootTable.Columns("PlanCta").Visible = False

         .RootTable.Columns("SinFac").Caption = "I"
         .RootTable.Columns("SinFac").Width = 50
         .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ConFac").Caption = "F"
         .RootTable.Columns("ConFac").Width = 50
         .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call addConditionalFormatting(DEV_COMPRA, grdDevCompra)
   End Sub

   Private Sub grdCreditoInit()
      With grdCredito
         ebrMain.Groups(0).Text = "Programación de Planes de Pago"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("CreditoId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("CompraId").Visible = False

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

         .RootTable.Columns("TipoCreditoId").Visible = False

         .RootTable.Columns("TipoCreditoDes").Caption = "Tipo Credito"
         .RootTable.Columns("TipoCreditoDes").Width = 100
         .RootTable.Columns("TipoCreditoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCreditoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CreditoNro").Caption = "Número"
         .RootTable.Columns("CreditoNro").Width = 100
         .RootTable.Columns("CreditoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CreditoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FechaIni").Caption = "Inicio"
         .RootTable.Columns("FechaIni").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FechaIni").Width = 100
         .RootTable.Columns("FechaIni").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FechaIni").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FechaFin").Caption = "Fin"
         .RootTable.Columns("FechaFin").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FechaFin").Width = 100
         .RootTable.Columns("FechaFin").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FechaFin").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompraId").Visible = False
         .RootTable.Columns("CompraNro").Visible = False

         .RootTable.Columns("ProveedorId").Visible = False
         .RootTable.Columns("ProveedorCod").Visible = False

         .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
         .RootTable.Columns("ProveedorDes").Width = 200
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FrecuenciaId").Visible = False

         .RootTable.Columns("FrecuenciaDes").Caption = "Frecuencia"
         .RootTable.Columns("FrecuenciaDes").Width = 100
         .RootTable.Columns("FrecuenciaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FrecuenciaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FrecuenciaNro").Caption = "Cant. Frecuen."
         .RootTable.Columns("FrecuenciaNro").Width = 100
         .RootTable.Columns("FrecuenciaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FrecuenciaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

         .RootTable.Columns("MontoLiq").Caption = "Monto Total"
         .RootTable.Columns("MontoLiq").FormatString = DecimalMask()
         .RootTable.Columns("MontoLiq").Width = 100
         .RootTable.Columns("MontoLiq").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoLiq").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoAmo").Caption = "Monto Amort."
         .RootTable.Columns("MontoAmo").FormatString = DecimalMask()
         .RootTable.Columns("MontoAmo").Width = 100
         .RootTable.Columns("MontoAmo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoAmo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CantidadCuota").Caption = "Cant. Cuotas"
         .RootTable.Columns("CantidadCuota").Width = 100
         .RootTable.Columns("CantidadCuota").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CantidadCuota").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoCuota").Caption = "Monto Cuota"
         .RootTable.Columns("MontoCuota").FormatString = DecimalMask()
         .RootTable.Columns("MontoCuota").Width = 100
         .RootTable.Columns("MontoCuota").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoCuota").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("InteresAnual").Caption = "Interes Anual"
         .RootTable.Columns("InteresAnual").FormatString = DecimalMask()
         .RootTable.Columns("InteresAnual").Width = 100
         .RootTable.Columns("InteresAnual").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("InteresAnual").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SinFac").Caption = "I"
         .RootTable.Columns("SinFac").Width = 50
         .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ConFac").Caption = "F"
         .RootTable.Columns("ConFac").Width = 50
         .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call addConditionalFormatting(CREDITO, grdCredito)
   End Sub

   Private Sub grdPagoInit()
      With grdPago
         ebrMain.Groups(0).Text = "Historial de Pagos"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("PagoId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("GestionId").Visible = False

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

         .RootTable.Columns("PagoNro").Caption = "Número"
         .RootTable.Columns("PagoNro").Width = 100
         .RootTable.Columns("PagoNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PagoNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ProveedorId").Visible = False
         .RootTable.Columns("ProveedorCod").Visible = False

         .RootTable.Columns("ProveedorDes").Caption = "Proveedor"
         .RootTable.Columns("ProveedorDes").Width = 200
         .RootTable.Columns("ProveedorDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ProveedorDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoPagoId").Visible = False

         .RootTable.Columns("TipoPagoDes").Caption = "Tipo Venta"
         .RootTable.Columns("TipoPagoDes").Width = 100
         .RootTable.Columns("TipoPagoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoPagoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PagoDes").Caption = "Descripción"
         .RootTable.Columns("PagoDes").Width = 100
         .RootTable.Columns("PagoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PagoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 100
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

         .RootTable.Columns("Capital").Caption = "Capital"
         .RootTable.Columns("Capital").FormatString = DecimalMask()
         .RootTable.Columns("Capital").Width = 100
         .RootTable.Columns("Capital").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Capital").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Interes").Caption = "Interes"
         .RootTable.Columns("Interes").FormatString = DecimalMask()
         .RootTable.Columns("Interes").Width = 100
         .RootTable.Columns("Interes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Interes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoPag").Caption = "Monto Pag."
         .RootTable.Columns("MontoPag").FormatString = DecimalMask()
         .RootTable.Columns("MontoPag").Width = 100
         .RootTable.Columns("MontoPag").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoPag").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanRecargoId").Visible = False

         .RootTable.Columns("PlanRecargoDes").Caption = "Recargo"
         .RootTable.Columns("PlanRecargoDes").Width = 100
         .RootTable.Columns("PlanRecargoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanRecargoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoRec").Caption = "Monto Recargo"
         .RootTable.Columns("MontoRec").FormatString = DecimalMask()
         .RootTable.Columns("MontoRec").Width = 100
         .RootTable.Columns("MontoRec").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoRec").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDescuentoId").Visible = False

         .RootTable.Columns("PlanDescuentoDes").Caption = "Descuento"
         .RootTable.Columns("PlanDescuentoDes").Width = 100
         .RootTable.Columns("PlanDescuentoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDescuentoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MontoDes").Caption = "Monto Descuento"
         .RootTable.Columns("MontoDes").FormatString = DecimalMask()
         .RootTable.Columns("MontoDes").Width = 100
         .RootTable.Columns("MontoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("MontoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo Comp."
         .RootTable.Columns("TipoCompDes").Width = 100
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Nro. Comp."
         .RootTable.Columns("CompNro").Width = 100
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanId").Visible = False
         .RootTable.Columns("TipoPlanId").Visible = False
         .RootTable.Columns("PlanCta").Visible = False

         .RootTable.Columns("SinFac").Caption = "I"
         .RootTable.Columns("SinFac").Width = 50
         .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ConFac").Caption = "F"
         .RootTable.Columns("ConFac").Width = 50
         .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call addConditionalFormatting(PAGO, grdPago)
   End Sub

   Private Sub addConditionalFormatting(ByVal byteTipo As Byte, ByVal grdMain As Janus.Windows.GridEX.GridEX)
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 12)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      Select Case byteTipo

         Case PED_COMPRA
            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
            fc.FormatStyle.ForeColor = Color.DarkOrange
            grdMain.RootTable.FormatConditions.Add(fc)

            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 14)
            fc.FormatStyle.ForeColor = Color.DarkGreen
            grdMain.RootTable.FormatConditions.Add(fc)

         Case ANTICIPO
            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
            fc.FormatStyle.ForeColor = Color.DarkOrange
            grdMain.RootTable.FormatConditions.Add(fc)

            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 14)
            fc.FormatStyle.ForeColor = Color.DarkGreen
            grdMain.RootTable.FormatConditions.Add(fc)

         Case COMPRA
            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
            fc.FormatStyle.ForeColor = Color.DarkOrange
            grdMain.RootTable.FormatConditions.Add(fc)

            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 15)
            fc.FormatStyle.ForeColor = Color.DarkGreen
            grdMain.RootTable.FormatConditions.Add(fc)

         Case DEV_COMPRA
            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
            fc.FormatStyle.ForeColor = Color.DarkOrange
            grdMain.RootTable.FormatConditions.Add(fc)

            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 14)
            fc.FormatStyle.ForeColor = Color.DarkGreen
            grdMain.RootTable.FormatConditions.Add(fc)

         Case CREDITO
            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 15)
            fc.FormatStyle.ForeColor = Color.DarkOrange
            grdMain.RootTable.FormatConditions.Add(fc)

            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 14)
            fc.FormatStyle.ForeColor = Color.DarkGreen
            grdMain.RootTable.FormatConditions.Add(fc)

         Case PAGO
            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 14)
            fc.FormatStyle.ForeColor = Color.DarkGreen
            grdMain.RootTable.FormatConditions.Add(fc)

      End Select

   End Sub

   Private Sub grdPedCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdPedCompra.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdPedCompra.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdPedCompra.GetRow.Cells(grdPedCompra.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub cboEmpresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEmpresa.SelectedIndexChanged
      If cboEmpresa.Tag <> cboEmpresa.Text Then
         cboEmpresa.Tag = cboEmpresa.Text

         Call cboGestionLoad(ListPosition(cboEmpresa, cboEmpresa.SelectedIndex))
      End If
   End Sub

   Private Sub frmDataBaseImport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmDataBaseImport_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

End Class
