Imports System.Diagnostics

Public Class frmMain
   Inherits System.Windows.Forms.Form
   Dim ctlMDI As MdiClient

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
   Friend WithEvents mnuEmpresa2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents frmLibroDiario As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents frmLibroDiario1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReporte As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReporte1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultado2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultado1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametro2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametro1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnEmpresa As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents tbrEmpresa1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnComp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnComp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnBalance As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnBalance1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnLibroIVA As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnLibroIVA1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnTipoCambio As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnTipoCambio1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLinea As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLinea1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSubGrupo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSubGrupo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFabrica As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFabrica1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanGrupo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuNotaPara As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuItem As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuItem1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReporte2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReporte3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStock As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStock1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTransaccion As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTransaccion1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuHelp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuHelp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuNotaPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanGrupo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoDatoTecnico As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoDatoTecnico1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuKardexCentroCosto As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuKardexCentroCosto1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnEmpresa2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents btnEmpresa1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnKardex As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator10 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator11 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnKardex1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator12 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnNotaPara As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnNotaPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator13 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator14 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator15 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnUserPass As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnUserPass1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator16 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnExit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator17 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnExit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator18 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStockMinMax As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStockMinMax1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Menu1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents mnuCatalogo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCatalogo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents mnuPlanDescuento As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanRecargo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPedCompra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompraPara As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAnticipo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCredito As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCreditoIni As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPago As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCreditoPago As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuContadoPago As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedorMov As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTransaccion2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTransaccion3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPedCompra2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAnticipo2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompra2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCreditoMain As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCreditoMain1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCreditoIni2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCredito2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPagoMain As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPagoMain1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuContadoPago2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCreditoPago2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPago2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReporte4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReporte5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedorMov2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametro As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametro3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuView As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuView1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuHelp2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuHelp3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ToolBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents btnEmpresa3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnEmpresa4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator19 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnCompra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnCompra1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator20 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnProveedor As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnProveedor1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator21 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuItem2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuItem3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnItem As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnItem1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator22 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanGrupo2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanGrupo3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnCompraPara As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnCompraPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator23 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnTipoCambio2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnTipoCambio3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator24 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnUserPass2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnUserPass3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnHelp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnHelp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator25 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnHelpVideo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator26 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnHelpVideo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnExit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator27 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnExit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedor1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedor As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanOtroCosto As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanOtroCosto1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana1 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents mnuAjuste As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAjuste1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDevCompra1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDevCompra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompraMov As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompraMov1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator28 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator29 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompraPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompraMovDiario As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompraMovDiario1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCreditoMov As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCreditoMov1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnCalculadora As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnCalculadora1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator30 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator31 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPedCompraMov As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ToolSet1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents btnExcel1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator32 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnFilter1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator33 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnSort1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnExcel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnFilter As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnSort As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter
   Friend WithEvents mnuPlanDescuento1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanRecargo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFlujoCaja1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator34 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFlujoCaja As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator35 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataBaseBackup1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataBaseImport1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataBaseImport As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataBaseBackup As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuActualizarProveedorMov As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator36 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataSecurityImport1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataSecurityImport As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFacturaDIf1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator37 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFacturaDif As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFactDifProveedor As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator38 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFactDifProveedor1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProcedencia As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRubro As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator39 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuUltPrecioCompra1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuUltPrecioCompra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator40 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedorPorPagar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedorPorPagar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuItemProveedorMov As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedorItemMov As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuItemProveedorMov1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedorItemMov1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedorExtra1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProveedorExtra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPedCompraTransito1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPedCompraTransito As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator41 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAbonoProveedor1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAbonoProveedor As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents sbrMain As Janus.Windows.UI.StatusBar.UIStatusBar
   Friend WithEvents mnuPedCompraItemPend1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPedCompraItemPend As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFacturaDifMultiple1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuFacturaDifMultiple As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuResumenCompraProv1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents mnuResumenCompraProv As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPedCompraMov1 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim UiStatusBarPanel1 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
        Dim UiStatusBarPanel2 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
        Dim UiStatusBarPanel3 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
        Dim UiStatusBarPanel4 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
        Dim UiStatusBarPanel5 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
        Me.mnuReporte1 = New Janus.Windows.UI.CommandBars.UICommand("mnuReporte")
        Me.mnuParametro1 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametro")
        Me.tbrEmpresa1 = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresa")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnComp1 = New Janus.Windows.UI.CommandBars.UICommand("btnComp")
        Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnBalance1 = New Janus.Windows.UI.CommandBars.UICommand("btnBalance")
        Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnLibroIVA1 = New Janus.Windows.UI.CommandBars.UICommand("btnLibroIVA")
        Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnTipoCambio1 = New Janus.Windows.UI.CommandBars.UICommand("btnTipoCambio")
        Me.mnuEmpresa1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
        Me.mnuPlanAdd1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
        Me.mnuSucursal1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
        Me.mnuBanco1 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
        Me.mnuCiudad1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
        Me.mnuEmpresa2 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
        Me.mnuPlanAdd2 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
        Me.mnuSucursal2 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
        Me.mnuBanco2 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
        Me.mnuCiudad2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
        Me.mnuComp1 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
        Me.frmLibroDiario1 = New Janus.Windows.UI.CommandBars.UICommand("frmLibroDiario")
        Me.mnuCierreCuenta1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
        Me.mnuComp2 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
        Me.frmLibroDiario = New Janus.Windows.UI.CommandBars.UICommand("frmLibroDiario")
        Me.mnuCierreCuenta2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
        Me.mnuReporte = New Janus.Windows.UI.CommandBars.UICommand("mnuReporte")
        Me.mnuEstadoResultado1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultado")
        Me.mnuLibroIVA1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
        Me.mnuLibroITF1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
        Me.mnuLibroSucursal1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
        Me.mnuEstadoResultado2 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultado")
        Me.mnuLibroIVA2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
        Me.mnuLibroITF2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
        Me.mnuLibroSucursal2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
        Me.mnuParametro2 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametro")
        Me.mnuGestion1 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
        Me.mnuTipoCambio1 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
        Me.mnuGestion2 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
        Me.mnuTipoCambio2 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
        Me.mnuAyudaDinamica1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
        Me.mnuAyudaDinamica = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
        Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
        Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
        Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
        Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
        Me.mnuToolBar1 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
        Me.mnuToolBar = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
        Me.btnEmpresa = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresa")
        Me.btnComp = New Janus.Windows.UI.CommandBars.UICommand("btnComp")
        Me.btnBalance = New Janus.Windows.UI.CommandBars.UICommand("btnBalance")
        Me.btnLibroIVA = New Janus.Windows.UI.CommandBars.UICommand("btnLibroIVA")
        Me.btnTipoCambio = New Janus.Windows.UI.CommandBars.UICommand("btnTipoCambio")
        Me.mnuTransaccion1 = New Janus.Windows.UI.CommandBars.UICommand("mnuTransaccion")
        Me.mnuReporte3 = New Janus.Windows.UI.CommandBars.UICommand("mnuReporte")
        Me.mnuHelp1 = New Janus.Windows.UI.CommandBars.UICommand("mnuHelp")
        Me.btnEmpresa1 = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresa")
        Me.Separator10 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator11 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnKardex1 = New Janus.Windows.UI.CommandBars.UICommand("btnKardex")
        Me.Separator12 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator13 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnNotaPara1 = New Janus.Windows.UI.CommandBars.UICommand("btnNotaPara")
        Me.Separator14 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator15 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnUserPass1 = New Janus.Windows.UI.CommandBars.UICommand("btnUserPass")
        Me.Separator16 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator17 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Separator18 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnExit1 = New Janus.Windows.UI.CommandBars.UICommand("btnExit")
        Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
        Me.mnuEmpresa3 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
        Me.mnuLinea1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLinea")
        Me.mnuSubGrupo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSubGrupo")
        Me.mnuFabrica1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFabrica")
        Me.mnuTipoDatoTecnico1 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoDatoTecnico")
        Me.mnuItem1 = New Janus.Windows.UI.CommandBars.UICommand("mnuItem")
        Me.mnuLinea = New Janus.Windows.UI.CommandBars.UICommand("mnuLinea")
        Me.mnuSubGrupo = New Janus.Windows.UI.CommandBars.UICommand("mnuSubGrupo")
        Me.mnuFabrica = New Janus.Windows.UI.CommandBars.UICommand("mnuFabrica")
        Me.mnuPlanGrupo = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanGrupo")
        Me.mnuNotaPara = New Janus.Windows.UI.CommandBars.UICommand("mnuNotaPara")
        Me.mnuItem = New Janus.Windows.UI.CommandBars.UICommand("mnuItem")
        Me.mnuReporte2 = New Janus.Windows.UI.CommandBars.UICommand("mnuReporte")
        Me.mnuStock1 = New Janus.Windows.UI.CommandBars.UICommand("mnuStock")
        Me.mnuStockMinMax1 = New Janus.Windows.UI.CommandBars.UICommand("mnuStockMinMax")
        Me.mnuKardexCentroCosto1 = New Janus.Windows.UI.CommandBars.UICommand("mnuKardexCentroCosto")
        Me.mnuStock = New Janus.Windows.UI.CommandBars.UICommand("mnuStock")
        Me.mnuNotaPara1 = New Janus.Windows.UI.CommandBars.UICommand("mnuNotaPara")
        Me.mnuPlanGrupo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanGrupo")
        Me.mnuTransaccion = New Janus.Windows.UI.CommandBars.UICommand("mnuTransaccion")
        Me.mnuStatusBar1 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
        Me.mnuHelp = New Janus.Windows.UI.CommandBars.UICommand("mnuHelp")
        Me.mnuAboutBox1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
        Me.mnuStatusBar = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
        Me.mnuAboutBox = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
        Me.mnuTipoDatoTecnico = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoDatoTecnico")
        Me.mnuEmpresa = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
        Me.mnuKardexCentroCosto = New Janus.Windows.UI.CommandBars.UICommand("mnuKardexCentroCosto")
        Me.btnEmpresa2 = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresa")
        Me.btnKardex = New Janus.Windows.UI.CommandBars.UICommand("btnKardex")
        Me.btnNotaPara = New Janus.Windows.UI.CommandBars.UICommand("btnNotaPara")
        Me.btnUserPass = New Janus.Windows.UI.CommandBars.UICommand("btnUserPass")
        Me.btnExit = New Janus.Windows.UI.CommandBars.UICommand("btnExit")
        Me.mnuStockMinMax = New Janus.Windows.UI.CommandBars.UICommand("mnuStockMinMax")
        Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Menu1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.mnuCatalogo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCatalogo")
        Me.mnuTransaccion3 = New Janus.Windows.UI.CommandBars.UICommand("mnuTransaccion")
        Me.mnuCreditoMain1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCreditoMain")
        Me.mnuPagoMain1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPagoMain")
        Me.mnuReporte5 = New Janus.Windows.UI.CommandBars.UICommand("mnuReporte")
        Me.mnuParametro3 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametro")
        Me.mnuView1 = New Janus.Windows.UI.CommandBars.UICommand("mnuView")
        Me.mnuHelp3 = New Janus.Windows.UI.CommandBars.UICommand("mnuHelp")
        Me.ToolBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.btnEmpresa4 = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresa")
        Me.Separator19 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnProveedor1 = New Janus.Windows.UI.CommandBars.UICommand("btnProveedor")
        Me.Separator20 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnItem1 = New Janus.Windows.UI.CommandBars.UICommand("btnItem")
        Me.Separator21 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnCompra1 = New Janus.Windows.UI.CommandBars.UICommand("btnCompra")
        Me.Separator22 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnCompraPara1 = New Janus.Windows.UI.CommandBars.UICommand("btnCompraPara")
        Me.Separator23 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnTipoCambio3 = New Janus.Windows.UI.CommandBars.UICommand("btnTipoCambio")
        Me.Separator24 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnUserPass3 = New Janus.Windows.UI.CommandBars.UICommand("btnUserPass")
        Me.Separator25 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnCalculadora1 = New Janus.Windows.UI.CommandBars.UICommand("btnCalculadora")
        Me.Separator30 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnHelp1 = New Janus.Windows.UI.CommandBars.UICommand("btnHelp")
        Me.Separator26 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnHelpVideo1 = New Janus.Windows.UI.CommandBars.UICommand("btnHelpVideo")
        Me.Separator27 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnExit3 = New Janus.Windows.UI.CommandBars.UICommand("btnExit")
        Me.ToolSet1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.btnExcel1 = New Janus.Windows.UI.CommandBars.UICommand("btnExcel")
        Me.Separator32 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnFilter1 = New Janus.Windows.UI.CommandBars.UICommand("btnFilter")
        Me.Separator33 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.btnSort1 = New Janus.Windows.UI.CommandBars.UICommand("btnSort")
        Me.mnuCatalogo = New Janus.Windows.UI.CommandBars.UICommand("mnuCatalogo")
        Me.mnuEmpresa5 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
        Me.mnuProveedor1 = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedor")
        Me.mnuItem3 = New Janus.Windows.UI.CommandBars.UICommand("mnuItem")
        Me.mnuPlanRecargo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanRecargo")
        Me.mnuPlanDescuento1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanDescuento")
        Me.mnuPlanOtroCosto1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanOtroCosto")
        Me.mnuAduana1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
        Me.mnuBanco3 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
        Me.mnuProveedor = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedor")
        Me.mnuPlanDescuento = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanDescuento")
        Me.mnuPlanRecargo = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanRecargo")
        Me.mnuPedCompra = New Janus.Windows.UI.CommandBars.UICommand("mnuPedCompra")
        Me.mnuCompraPara = New Janus.Windows.UI.CommandBars.UICommand("mnuCompraPara")
        Me.mnuAnticipo = New Janus.Windows.UI.CommandBars.UICommand("mnuAnticipo")
        Me.mnuCompra = New Janus.Windows.UI.CommandBars.UICommand("mnuCompra")
        Me.mnuCredito = New Janus.Windows.UI.CommandBars.UICommand("mnuCredito")
        Me.mnuCreditoIni = New Janus.Windows.UI.CommandBars.UICommand("mnuCreditoIni")
        Me.mnuPago = New Janus.Windows.UI.CommandBars.UICommand("mnuPago")
        Me.mnuCreditoPago = New Janus.Windows.UI.CommandBars.UICommand("mnuCreditoPago")
        Me.mnuContadoPago = New Janus.Windows.UI.CommandBars.UICommand("mnuContadoPago")
        Me.mnuProveedorMov = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedorMov")
        Me.mnuTransaccion2 = New Janus.Windows.UI.CommandBars.UICommand("mnuTransaccion")
        Me.mnuPedCompra2 = New Janus.Windows.UI.CommandBars.UICommand("mnuPedCompra")
        Me.mnuAnticipo2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAnticipo")
        Me.mnuCompra2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompra")
        Me.mnuDevCompra1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDevCompra")
        Me.Separator29 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuFacturaDIf1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturaDif")
        Me.mnuFacturaDifMultiple1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturaDifMultiple")
        Me.Separator37 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuCierreGestion1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
        Me.mnuDevCompra = New Janus.Windows.UI.CommandBars.UICommand("mnuDevCompra")
        Me.mnuCreditoMain = New Janus.Windows.UI.CommandBars.UICommand("mnuCreditoMain")
        Me.mnuCredito2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCredito")
        Me.mnuCreditoIni2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCreditoIni")
        Me.mnuPagoMain = New Janus.Windows.UI.CommandBars.UICommand("mnuPagoMain")
        Me.mnuContadoPago2 = New Janus.Windows.UI.CommandBars.UICommand("mnuContadoPago")
        Me.mnuCreditoPago2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCreditoPago")
        Me.Separator28 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuPago2 = New Janus.Windows.UI.CommandBars.UICommand("mnuPago")
        Me.mnuAjuste1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
        Me.mnuReporte4 = New Janus.Windows.UI.CommandBars.UICommand("mnuReporte")
        Me.mnuProveedorMov2 = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedorMov")
        Me.mnuProveedorExtra1 = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedorExtra")
        Me.mnuCompraMov1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompraMov")
        Me.mnuCompraMovDiario1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompraMovDiario")
        Me.mnuCreditoMov1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCreditoMov")
        Me.Separator31 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuFlujoCaja1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFlujoCaja")
        Me.mnuAbonoProveedor1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAbonoProveedor")
        Me.Separator34 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuPedCompraMov1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPedCompraMov")
        Me.mnuPedCompraTransito1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPedCompraTransito")
        Me.mnuPedCompraItemPend1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPedCompraItemPend")
        Me.Separator38 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuFactDifProveedor1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFactDifProveedor")
        Me.Separator39 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuUltPrecioCompra1 = New Janus.Windows.UI.CommandBars.UICommand("mnuUltPrecioCompra")
        Me.Separator40 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuProveedorPorPagar1 = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedorPorPagar")
        Me.mnuProveedorItemMov1 = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedorItemMov")
        Me.mnuItemProveedorMov1 = New Janus.Windows.UI.CommandBars.UICommand("mnuItemProveedorMov")
        Me.Separator41 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuParametro = New Janus.Windows.UI.CommandBars.UICommand("mnuParametro")
        Me.mnuGestion3 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
        Me.mnuParametroSub1 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
        Me.mnuPlanGrupo3 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanGrupo")
        Me.mnuTipoCambio3 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
        Me.Separator35 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuDataBaseBackup1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDataBaseBackup")
        Me.mnuDataBaseImport1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDataBaseImport")
        Me.Separator36 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.mnuDataSecurityImport1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDataSecurityImport")
        Me.mnuView = New Janus.Windows.UI.CommandBars.UICommand("mnuView")
        Me.mnuToolBar3 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
        Me.mnuStatusBar3 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
        Me.mnuToolBar2 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
        Me.mnuStatusBar2 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
        Me.mnuHelp2 = New Janus.Windows.UI.CommandBars.UICommand("mnuHelp")
        Me.mnuAyudaDinamica3 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
        Me.mnuAboutBox3 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
        Me.mnuAyudaDinamica2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
        Me.mnuAboutBox2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
        Me.mnuEmpresa4 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
        Me.mnuGestion = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
        Me.mnuTipoCambio = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
        Me.btnEmpresa3 = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresa")
        Me.btnCompra = New Janus.Windows.UI.CommandBars.UICommand("btnCompra")
        Me.btnProveedor = New Janus.Windows.UI.CommandBars.UICommand("btnProveedor")
        Me.mnuItem2 = New Janus.Windows.UI.CommandBars.UICommand("mnuItem")
        Me.btnItem = New Janus.Windows.UI.CommandBars.UICommand("btnItem")
        Me.mnuPlanGrupo2 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanGrupo")
        Me.btnCompraPara = New Janus.Windows.UI.CommandBars.UICommand("btnCompraPara")
        Me.btnTipoCambio2 = New Janus.Windows.UI.CommandBars.UICommand("btnTipoCambio")
        Me.btnUserPass2 = New Janus.Windows.UI.CommandBars.UICommand("btnUserPass")
        Me.btnHelp = New Janus.Windows.UI.CommandBars.UICommand("btnHelp")
        Me.btnHelpVideo = New Janus.Windows.UI.CommandBars.UICommand("btnHelpVideo")
        Me.btnExit2 = New Janus.Windows.UI.CommandBars.UICommand("btnExit")
        Me.mnuPlanOtroCosto = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanOtroCosto")
        Me.mnuAduana = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
        Me.mnuAjuste = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
        Me.mnuCompraMov = New Janus.Windows.UI.CommandBars.UICommand("mnuCompraMov")
        Me.mnuCierreGestion = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
        Me.mnuParametroSub = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
        Me.mnuEmpresaPara1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
        Me.mnuCompraPara1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompraPara")
        Me.mnuEmpresaPara = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
        Me.mnuCompraMovDiario = New Janus.Windows.UI.CommandBars.UICommand("mnuCompraMovDiario")
        Me.mnuCreditoMov = New Janus.Windows.UI.CommandBars.UICommand("mnuCreditoMov")
        Me.btnCalculadora = New Janus.Windows.UI.CommandBars.UICommand("btnCalculadora")
        Me.mnuPedCompraMov = New Janus.Windows.UI.CommandBars.UICommand("mnuPedCompraMov")
        Me.btnExcel = New Janus.Windows.UI.CommandBars.UICommand("btnExcel")
        Me.btnFilter = New Janus.Windows.UI.CommandBars.UICommand("btnFilter")
        Me.btnSort = New Janus.Windows.UI.CommandBars.UICommand("btnSort")
        Me.mnuFlujoCaja = New Janus.Windows.UI.CommandBars.UICommand("mnuFlujoCaja")
        Me.mnuDataBaseImport = New Janus.Windows.UI.CommandBars.UICommand("mnuDataBaseImport")
        Me.mnuDataBaseBackup = New Janus.Windows.UI.CommandBars.UICommand("mnuDataBaseBackup")
        Me.mnuActualizarProveedorMov = New Janus.Windows.UI.CommandBars.UICommand("mnuActualizarProveedorMov")
        Me.mnuDataSecurityImport = New Janus.Windows.UI.CommandBars.UICommand("mnuDataSecurityImport")
        Me.mnuFacturaDif = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturaDif")
        Me.mnuFactDifProveedor = New Janus.Windows.UI.CommandBars.UICommand("mnuFactDifProveedor")
        Me.mnuProcedencia = New Janus.Windows.UI.CommandBars.UICommand("mnuProcedencia")
        Me.mnuRubro = New Janus.Windows.UI.CommandBars.UICommand("mnuRubro")
        Me.mnuUltPrecioCompra = New Janus.Windows.UI.CommandBars.UICommand("mnuUltPrecioCompra")
        Me.mnuProveedorPorPagar = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedorPorPagar")
        Me.mnuItemProveedorMov = New Janus.Windows.UI.CommandBars.UICommand("mnuItemProveedorMov")
        Me.mnuProveedorItemMov = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedorItemMov")
        Me.mnuProveedorExtra = New Janus.Windows.UI.CommandBars.UICommand("mnuProveedorExtra")
        Me.mnuPedCompraTransito = New Janus.Windows.UI.CommandBars.UICommand("mnuPedCompraTransito")
        Me.mnuBanco = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
        Me.mnuAbonoProveedor = New Janus.Windows.UI.CommandBars.UICommand("mnuAbonoProveedor")
        Me.mnuPedCompraItemPend = New Janus.Windows.UI.CommandBars.UICommand("mnuPedCompraItemPend")
        Me.mnuFacturaDifMultiple = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturaDifMultiple")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.gexMain = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
        Me.sbrMain = New Janus.Windows.UI.StatusBar.UIStatusBar
        Me.mnuResumenCompraProv = New Janus.Windows.UI.CommandBars.UICommand("mnuResumenCompraProv")
        Me.mnuResumenCompraProv1 = New Janus.Windows.UI.CommandBars.UICommand("mnuResumenCompraProv")
        CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopRebar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuReporte1
        '
        Me.mnuReporte1.Key = "mnuReporte"
        Me.mnuReporte1.Name = "mnuReporte1"
        '
        'mnuParametro1
        '
        Me.mnuParametro1.Key = "mnuParametro"
        Me.mnuParametro1.Name = "mnuParametro1"
        '
        'tbrEmpresa1
        '
        Me.tbrEmpresa1.ImageIndex = 0
        Me.tbrEmpresa1.Key = "btnEmpresa"
        Me.tbrEmpresa1.Name = "tbrEmpresa1"
        Me.tbrEmpresa1.ToolTipText = "Empresas"
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'Separator2
        '
        Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator2.Key = "Separator"
        Me.Separator2.Name = "Separator2"
        '
        'btnComp1
        '
        Me.btnComp1.Key = "btnComp"
        Me.btnComp1.Name = "btnComp1"
        '
        'Separator3
        '
        Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator3.Key = "Separator"
        Me.Separator3.Name = "Separator3"
        '
        'Separator4
        '
        Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator4.Key = "Separator"
        Me.Separator4.Name = "Separator4"
        '
        'btnBalance1
        '
        Me.btnBalance1.Key = "btnBalance"
        Me.btnBalance1.Name = "btnBalance1"
        '
        'Separator5
        '
        Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator5.Key = "Separator"
        Me.Separator5.Name = "Separator5"
        '
        'Separator6
        '
        Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator6.Key = "Separator"
        Me.Separator6.Name = "Separator6"
        '
        'btnLibroIVA1
        '
        Me.btnLibroIVA1.Key = "btnLibroIVA"
        Me.btnLibroIVA1.Name = "btnLibroIVA1"
        '
        'Separator7
        '
        Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator7.Key = "Separator"
        Me.Separator7.Name = "Separator7"
        '
        'Separator8
        '
        Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator8.Key = "Separator"
        Me.Separator8.Name = "Separator8"
        '
        'btnTipoCambio1
        '
        Me.btnTipoCambio1.Key = "btnTipoCambio"
        Me.btnTipoCambio1.Name = "btnTipoCambio1"
        '
        'mnuEmpresa1
        '
        Me.mnuEmpresa1.Key = "mnuEmpresa"
        Me.mnuEmpresa1.Name = "mnuEmpresa1"
        '
        'mnuPlanAdd1
        '
        Me.mnuPlanAdd1.Key = "mnuPlanAdd"
        Me.mnuPlanAdd1.Name = "mnuPlanAdd1"
        '
        'mnuSucursal1
        '
        Me.mnuSucursal1.Key = "mnuSucursal"
        Me.mnuSucursal1.Name = "mnuSucursal1"
        '
        'mnuBanco1
        '
        Me.mnuBanco1.Key = "mnuBanco"
        Me.mnuBanco1.Name = "mnuBanco1"
        '
        'mnuCiudad1
        '
        Me.mnuCiudad1.Key = "mnuCiudad"
        Me.mnuCiudad1.Name = "mnuCiudad1"
        '
        'mnuEmpresa2
        '
        Me.mnuEmpresa2.Key = "mnuEmpresa"
        Me.mnuEmpresa2.Name = "mnuEmpresa2"
        Me.mnuEmpresa2.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.mnuEmpresa2.Tag = "mnuEmpresa"
        Me.mnuEmpresa2.Text = "Empresas"
        '
        'mnuPlanAdd2
        '
        Me.mnuPlanAdd2.Key = "mnuPlanAdd"
        Me.mnuPlanAdd2.Name = "mnuPlanAdd2"
        Me.mnuPlanAdd2.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.mnuPlanAdd2.Text = "Analíticos Adicionales"
        '
        'mnuSucursal2
        '
        Me.mnuSucursal2.Key = "mnuSucursal"
        Me.mnuSucursal2.Name = "mnuSucursal2"
        Me.mnuSucursal2.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mnuSucursal2.Text = "Sucursales"
        '
        'mnuBanco2
        '
        Me.mnuBanco2.Key = "mnuBanco"
        Me.mnuBanco2.Name = "mnuBanco2"
        Me.mnuBanco2.Text = "Bancos"
        '
        'mnuCiudad2
        '
        Me.mnuCiudad2.Key = "mnuCiudad"
        Me.mnuCiudad2.Name = "mnuCiudad2"
        Me.mnuCiudad2.Text = "Ciudades"
        '
        'mnuComp1
        '
        Me.mnuComp1.Key = "mnuComp"
        Me.mnuComp1.Name = "mnuComp1"
        '
        'frmLibroDiario1
        '
        Me.frmLibroDiario1.Key = "frmLibroDiario"
        Me.frmLibroDiario1.Name = "frmLibroDiario1"
        '
        'mnuCierreCuenta1
        '
        Me.mnuCierreCuenta1.Key = "mnuCierreCuenta"
        Me.mnuCierreCuenta1.Name = "mnuCierreCuenta1"
        '
        'mnuComp2
        '
        Me.mnuComp2.Key = "mnuComp"
        Me.mnuComp2.Name = "mnuComp2"
        Me.mnuComp2.Text = "Registro de Comprobantes"
        '
        'frmLibroDiario
        '
        Me.frmLibroDiario.Key = "frmLibroDiario"
        Me.frmLibroDiario.Name = "frmLibroDiario"
        Me.frmLibroDiario.Text = "Libro Diario"
        '
        'mnuCierreCuenta2
        '
        Me.mnuCierreCuenta2.Key = "mnuCierreCuenta"
        Me.mnuCierreCuenta2.Name = "mnuCierreCuenta2"
        Me.mnuCierreCuenta2.Text = "Cierre Cuentas de Resultado"
        '
        'mnuReporte
        '
        Me.mnuReporte.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuEstadoResultado1, Me.mnuLibroIVA1, Me.mnuLibroITF1, Me.mnuLibroSucursal1})
        Me.mnuReporte.Key = "mnuReporte"
        Me.mnuReporte.Name = "mnuReporte"
        Me.mnuReporte.Text = "&Reportes"
        '
        'mnuEstadoResultado1
        '
        Me.mnuEstadoResultado1.Key = "mnuEstadoResultado"
        Me.mnuEstadoResultado1.Name = "mnuEstadoResultado1"
        '
        'mnuLibroIVA1
        '
        Me.mnuLibroIVA1.Key = "mnuLibroIVA"
        Me.mnuLibroIVA1.Name = "mnuLibroIVA1"
        '
        'mnuLibroITF1
        '
        Me.mnuLibroITF1.Key = "mnuLibroITF"
        Me.mnuLibroITF1.Name = "mnuLibroITF1"
        '
        'mnuLibroSucursal1
        '
        Me.mnuLibroSucursal1.Key = "mnuLibroSucursal"
        Me.mnuLibroSucursal1.Name = "mnuLibroSucursal1"
        '
        'mnuEstadoResultado2
        '
        Me.mnuEstadoResultado2.Key = "mnuEstadoResultado"
        Me.mnuEstadoResultado2.Name = "mnuEstadoResultado2"
        Me.mnuEstadoResultado2.Text = "Estado de Resultados"
        '
        'mnuLibroIVA2
        '
        Me.mnuLibroIVA2.Key = "mnuLibroIVA"
        Me.mnuLibroIVA2.Name = "mnuLibroIVA2"
        Me.mnuLibroIVA2.Text = "Libros IVA"
        '
        'mnuLibroITF2
        '
        Me.mnuLibroITF2.Key = "mnuLibroITF"
        Me.mnuLibroITF2.Name = "mnuLibroITF2"
        Me.mnuLibroITF2.Text = "Movimiento de ITF"
        '
        'mnuLibroSucursal2
        '
        Me.mnuLibroSucursal2.Key = "mnuLibroSucursal"
        Me.mnuLibroSucursal2.Name = "mnuLibroSucursal2"
        Me.mnuLibroSucursal2.Text = "Movimiento de Sucursales"
        '
        'mnuParametro2
        '
        Me.mnuParametro2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuGestion1, Me.mnuTipoCambio1})
        Me.mnuParametro2.Key = "mnuParametro"
        Me.mnuParametro2.Name = "mnuParametro2"
        Me.mnuParametro2.Text = "&Parámetros"
        '
        'mnuGestion1
        '
        Me.mnuGestion1.Key = "mnuGestion"
        Me.mnuGestion1.Name = "mnuGestion1"
        '
        'mnuTipoCambio1
        '
        Me.mnuTipoCambio1.Key = "mnuTipoCambio"
        Me.mnuTipoCambio1.Name = "mnuTipoCambio1"
        '
        'mnuGestion2
        '
        Me.mnuGestion2.Key = "mnuGestion"
        Me.mnuGestion2.Name = "mnuGestion2"
        Me.mnuGestion2.Text = "Gestiones"
        '
        'mnuTipoCambio2
        '
        Me.mnuTipoCambio2.Key = "mnuTipoCambio"
        Me.mnuTipoCambio2.Name = "mnuTipoCambio2"
        Me.mnuTipoCambio2.Text = "Tipos de Cambio"
        '
        'mnuAyudaDinamica1
        '
        Me.mnuAyudaDinamica1.Key = "mnuAyudaDinamica"
        Me.mnuAyudaDinamica1.Name = "mnuAyudaDinamica1"
        '
        'mnuAyudaDinamica
        '
        Me.mnuAyudaDinamica.Key = "mnuAyudaDinamica"
        Me.mnuAyudaDinamica.Name = "mnuAyudaDinamica"
        Me.mnuAyudaDinamica.Text = "Ayuda Dinámica"
        '
        'New2
        '
        Me.New2.ImageIndex = 4
        Me.New2.Key = "New"
        Me.New2.Name = "New2"
        Me.New2.Text = "Nuevo"
        '
        'Edit
        '
        Me.Edit.ImageIndex = 2
        Me.Edit.Key = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Text = "Editar"
        '
        'ViewAll
        '
        Me.ViewAll.ImageIndex = 1
        Me.ViewAll.Key = "ViewAll"
        Me.ViewAll.Name = "ViewAll"
        Me.ViewAll.Text = "Ver Todos"
        '
        'Exit2
        '
        Me.Exit2.ImageIndex = 5
        Me.Exit2.Key = "Exit"
        Me.Exit2.Name = "Exit2"
        Me.Exit2.Text = "Salir"
        '
        'mnuToolBar1
        '
        Me.mnuToolBar1.Checked = Janus.Windows.UI.InheritableBoolean.[True]
        Me.mnuToolBar1.Key = "mnuToolBar"
        Me.mnuToolBar1.Name = "mnuToolBar1"
        '
        'mnuToolBar
        '
        Me.mnuToolBar.Key = "mnuToolBar"
        Me.mnuToolBar.Name = "mnuToolBar"
        Me.mnuToolBar.Text = "Barra de Herramientas"
        '
        'btnEmpresa
        '
        Me.btnEmpresa.ImageIndex = 0
        Me.btnEmpresa.Key = "btnEmpresa"
        Me.btnEmpresa.Name = "btnEmpresa"
        Me.btnEmpresa.ToolTipText = "Empresas"
        '
        'btnComp
        '
        Me.btnComp.ImageIndex = 2
        Me.btnComp.Key = "btnComp"
        Me.btnComp.Name = "btnComp"
        Me.btnComp.ToolTipText = "Registro de Comprobantes"
        '
        'btnBalance
        '
        Me.btnBalance.ImageIndex = 4
        Me.btnBalance.Key = "btnBalance"
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.ToolTipText = "Balance General"
        '
        'btnLibroIVA
        '
        Me.btnLibroIVA.ImageIndex = 6
        Me.btnLibroIVA.Key = "btnLibroIVA"
        Me.btnLibroIVA.Name = "btnLibroIVA"
        Me.btnLibroIVA.ToolTipText = "Libros IVA"
        '
        'btnTipoCambio
        '
        Me.btnTipoCambio.ImageIndex = 8
        Me.btnTipoCambio.Key = "btnTipoCambio"
        Me.btnTipoCambio.Name = "btnTipoCambio"
        Me.btnTipoCambio.ToolTipText = "Tipos de Cambio"
        '
        'mnuTransaccion1
        '
        Me.mnuTransaccion1.Key = "mnuTransaccion"
        Me.mnuTransaccion1.Name = "mnuTransaccion1"
        '
        'mnuReporte3
        '
        Me.mnuReporte3.Key = "mnuReporte"
        Me.mnuReporte3.Name = "mnuReporte3"
        '
        'mnuHelp1
        '
        Me.mnuHelp1.Key = "mnuHelp"
        Me.mnuHelp1.Name = "mnuHelp1"
        '
        'btnEmpresa1
        '
        Me.btnEmpresa1.Key = "btnEmpresa"
        Me.btnEmpresa1.Name = "btnEmpresa1"
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
        'btnKardex1
        '
        Me.btnKardex1.Key = "btnKardex"
        Me.btnKardex1.Name = "btnKardex1"
        '
        'Separator12
        '
        Me.Separator12.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator12.Key = "Separator"
        Me.Separator12.Name = "Separator12"
        '
        'Separator13
        '
        Me.Separator13.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator13.Key = "Separator"
        Me.Separator13.Name = "Separator13"
        '
        'btnNotaPara1
        '
        Me.btnNotaPara1.Key = "btnNotaPara"
        Me.btnNotaPara1.Name = "btnNotaPara1"
        '
        'Separator14
        '
        Me.Separator14.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator14.Key = "Separator"
        Me.Separator14.Name = "Separator14"
        '
        'Separator15
        '
        Me.Separator15.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator15.Key = "Separator"
        Me.Separator15.Name = "Separator15"
        '
        'btnUserPass1
        '
        Me.btnUserPass1.Key = "btnUserPass"
        Me.btnUserPass1.Name = "btnUserPass1"
        '
        'Separator16
        '
        Me.Separator16.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator16.Key = "Separator"
        Me.Separator16.Name = "Separator16"
        '
        'Separator17
        '
        Me.Separator17.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator17.Key = "Separator"
        Me.Separator17.Name = "Separator17"
        '
        'Separator18
        '
        Me.Separator18.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator18.Key = "Separator"
        Me.Separator18.Name = "Separator18"
        '
        'btnExit1
        '
        Me.btnExit1.Key = "btnExit"
        Me.btnExit1.Name = "btnExit1"
        Me.btnExit1.ToolTipText = "Salir del Sistema"
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
        Me.ilsMain.Images.SetKeyName(9, "")
        Me.ilsMain.Images.SetKeyName(10, "")
        Me.ilsMain.Images.SetKeyName(11, "")
        Me.ilsMain.Images.SetKeyName(12, "calculator.png")
        Me.ilsMain.Images.SetKeyName(13, "Excel.png")
        Me.ilsMain.Images.SetKeyName(14, "Filter.ico")
        Me.ilsMain.Images.SetKeyName(15, "Sort.png")
        '
        'mnuEmpresa3
        '
        Me.mnuEmpresa3.Key = "mnuEmpresa"
        Me.mnuEmpresa3.Name = "mnuEmpresa3"
        '
        'mnuLinea1
        '
        Me.mnuLinea1.Key = "mnuLinea"
        Me.mnuLinea1.Name = "mnuLinea1"
        '
        'mnuSubGrupo1
        '
        Me.mnuSubGrupo1.Key = "mnuSubGrupo"
        Me.mnuSubGrupo1.Name = "mnuSubGrupo1"
        '
        'mnuFabrica1
        '
        Me.mnuFabrica1.Key = "mnuFabrica"
        Me.mnuFabrica1.Name = "mnuFabrica1"
        '
        'mnuTipoDatoTecnico1
        '
        Me.mnuTipoDatoTecnico1.Key = "mnuTipoDatoTecnico"
        Me.mnuTipoDatoTecnico1.Name = "mnuTipoDatoTecnico1"
        '
        'mnuItem1
        '
        Me.mnuItem1.Key = "mnuItem"
        Me.mnuItem1.Name = "mnuItem1"
        '
        'mnuLinea
        '
        Me.mnuLinea.Key = "mnuLinea"
        Me.mnuLinea.Name = "mnuLinea"
        Me.mnuLinea.Text = "Lineas"
        '
        'mnuSubGrupo
        '
        Me.mnuSubGrupo.Key = "mnuSubGrupo"
        Me.mnuSubGrupo.Name = "mnuSubGrupo"
        Me.mnuSubGrupo.Text = "SubGrupos"
        '
        'mnuFabrica
        '
        Me.mnuFabrica.Key = "mnuFabrica"
        Me.mnuFabrica.Name = "mnuFabrica"
        Me.mnuFabrica.Text = "Fabricantes"
        '
        'mnuPlanGrupo
        '
        Me.mnuPlanGrupo.Key = "mnuPlanGrupo"
        Me.mnuPlanGrupo.Name = "mnuPlanGrupo"
        Me.mnuPlanGrupo.Text = "Grupos de Cuentas"
        '
        'mnuNotaPara
        '
        Me.mnuNotaPara.Key = "mnuNotaPara"
        Me.mnuNotaPara.Name = "mnuNotaPara"
        Me.mnuNotaPara.Text = "Parámetros de Notas"
        '
        'mnuItem
        '
        Me.mnuItem.Key = "mnuItem"
        Me.mnuItem.Name = "mnuItem"
        Me.mnuItem.Text = "Items"
        '
        'mnuReporte2
        '
        Me.mnuReporte2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuStock1, Me.mnuStockMinMax1, Me.mnuKardexCentroCosto1})
        Me.mnuReporte2.Key = "mnuReporte"
        Me.mnuReporte2.Name = "mnuReporte2"
        Me.mnuReporte2.Text = "&Reportes"
        '
        'mnuStock1
        '
        Me.mnuStock1.Key = "mnuStock"
        Me.mnuStock1.Name = "mnuStock1"
        '
        'mnuStockMinMax1
        '
        Me.mnuStockMinMax1.Key = "mnuStockMinMax"
        Me.mnuStockMinMax1.Name = "mnuStockMinMax1"
        '
        'mnuKardexCentroCosto1
        '
        Me.mnuKardexCentroCosto1.Key = "mnuKardexCentroCosto"
        Me.mnuKardexCentroCosto1.Name = "mnuKardexCentroCosto1"
        '
        'mnuStock
        '
        Me.mnuStock.Key = "mnuStock"
        Me.mnuStock.Name = "mnuStock"
        Me.mnuStock.Text = "Cantidades en Stock"
        '
        'mnuNotaPara1
        '
        Me.mnuNotaPara1.Key = "mnuNotaPara"
        Me.mnuNotaPara1.Name = "mnuNotaPara1"
        '
        'mnuPlanGrupo1
        '
        Me.mnuPlanGrupo1.Key = "mnuPlanGrupo"
        Me.mnuPlanGrupo1.Name = "mnuPlanGrupo1"
        '
        'mnuTransaccion
        '
        Me.mnuTransaccion.Key = "mnuTransaccion"
        Me.mnuTransaccion.Name = "mnuTransaccion"
        Me.mnuTransaccion.Text = "&Transacciones"
        '
        'mnuStatusBar1
        '
        Me.mnuStatusBar1.Checked = Janus.Windows.UI.InheritableBoolean.[True]
        Me.mnuStatusBar1.Key = "mnuStatusBar"
        Me.mnuStatusBar1.Name = "mnuStatusBar1"
        '
        'mnuHelp
        '
        Me.mnuHelp.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuAboutBox1})
        Me.mnuHelp.Key = "mnuHelp"
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Text = "&Ayuda"
        '
        'mnuAboutBox1
        '
        Me.mnuAboutBox1.Key = "mnuAboutBox"
        Me.mnuAboutBox1.Name = "mnuAboutBox1"
        '
        'mnuStatusBar
        '
        Me.mnuStatusBar.Key = "mnuStatusBar"
        Me.mnuStatusBar.Name = "mnuStatusBar"
        Me.mnuStatusBar.Text = "Barra de Estado"
        '
        'mnuAboutBox
        '
        Me.mnuAboutBox.Key = "mnuAboutBox"
        Me.mnuAboutBox.Name = "mnuAboutBox"
        Me.mnuAboutBox.Text = "Acerca de Modulo de Compras..."
        '
        'mnuTipoDatoTecnico
        '
        Me.mnuTipoDatoTecnico.Key = "mnuTipoDatoTecnico"
        Me.mnuTipoDatoTecnico.Name = "mnuTipoDatoTecnico"
        Me.mnuTipoDatoTecnico.Text = "Tipos de Datos Técnicos"
        '
        'mnuEmpresa
        '
        Me.mnuEmpresa.Key = "mnuEmpresa"
        Me.mnuEmpresa.Name = "mnuEmpresa"
        Me.mnuEmpresa.Text = "Empresas"
        '
        'mnuKardexCentroCosto
        '
        Me.mnuKardexCentroCosto.Key = "mnuKardexCentroCosto"
        Me.mnuKardexCentroCosto.Name = "mnuKardexCentroCosto"
        Me.mnuKardexCentroCosto.Text = "Movimiento de Items por Centros de Costo"
        '
        'btnEmpresa2
        '
        Me.btnEmpresa2.ImageIndex = 0
        Me.btnEmpresa2.Key = "btnEmpresa"
        Me.btnEmpresa2.Name = "btnEmpresa2"
        Me.btnEmpresa2.ToolTipText = "Empresas"
        '
        'btnKardex
        '
        Me.btnKardex.ImageIndex = 2
        Me.btnKardex.Key = "btnKardex"
        Me.btnKardex.Name = "btnKardex"
        Me.btnKardex.ToolTipText = "Kardex de Items"
        '
        'btnNotaPara
        '
        Me.btnNotaPara.ImageIndex = 4
        Me.btnNotaPara.Key = "btnNotaPara"
        Me.btnNotaPara.Name = "btnNotaPara"
        Me.btnNotaPara.ToolTipText = "Parámetros de Notas"
        '
        'btnUserPass
        '
        Me.btnUserPass.ImageIndex = 7
        Me.btnUserPass.Key = "btnUserPass"
        Me.btnUserPass.Name = "btnUserPass"
        Me.btnUserPass.ToolTipText = "Contraseña de Usuario"
        '
        'btnExit
        '
        Me.btnExit.ImageIndex = 6
        Me.btnExit.Key = "btnExit"
        Me.btnExit.Name = "btnExit"
        Me.btnExit.ToolTipText = "Salir de la Aplicación"
        '
        'mnuStockMinMax
        '
        Me.mnuStockMinMax.Key = "mnuStockMinMax"
        Me.mnuStockMinMax.Name = "mnuStockMinMax"
        Me.mnuStockMinMax.Text = "Control de Mínimos y Máximos"
        '
        'Separator9
        '
        Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator9.Key = "Separator"
        Me.Separator9.Name = "Separator9"
        '
        'cdmMain
        '
        Me.cdmMain.BottomRebar = Me.BottomRebar1
        Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.Menu1, Me.ToolBar1, Me.ToolSet1})
        Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuCatalogo, Me.mnuProveedor, Me.mnuPlanDescuento, Me.mnuPlanRecargo, Me.mnuPedCompra, Me.mnuCompraPara, Me.mnuAnticipo, Me.mnuCompra, Me.mnuCredito, Me.mnuCreditoIni, Me.mnuPago, Me.mnuCreditoPago, Me.mnuContadoPago, Me.mnuProveedorMov, Me.mnuTransaccion2, Me.mnuDevCompra, Me.mnuCreditoMain, Me.mnuPagoMain, Me.mnuReporte4, Me.mnuParametro, Me.mnuView, Me.mnuToolBar2, Me.mnuStatusBar2, Me.mnuHelp2, Me.mnuAyudaDinamica2, Me.mnuAboutBox2, Me.mnuEmpresa4, Me.mnuGestion, Me.mnuTipoCambio, Me.btnEmpresa3, Me.btnCompra, Me.btnProveedor, Me.mnuItem2, Me.btnItem, Me.mnuPlanGrupo2, Me.btnCompraPara, Me.btnTipoCambio2, Me.btnUserPass2, Me.btnHelp, Me.btnHelpVideo, Me.btnExit2, Me.mnuPlanOtroCosto, Me.mnuAduana, Me.mnuAjuste, Me.mnuCompraMov, Me.mnuCierreGestion, Me.mnuParametroSub, Me.mnuEmpresaPara, Me.mnuCompraMovDiario, Me.mnuCreditoMov, Me.btnCalculadora, Me.mnuPedCompraMov, Me.btnExcel, Me.btnFilter, Me.btnSort, Me.mnuFlujoCaja, Me.mnuDataBaseImport, Me.mnuDataBaseBackup, Me.mnuActualizarProveedorMov, Me.mnuDataSecurityImport, Me.mnuFacturaDif, Me.mnuFactDifProveedor, Me.mnuProcedencia, Me.mnuRubro, Me.mnuUltPrecioCompra, Me.mnuProveedorPorPagar, Me.mnuItemProveedorMov, Me.mnuProveedorItemMov, Me.mnuProveedorExtra, Me.mnuPedCompraTransito, Me.mnuBanco, Me.mnuAbonoProveedor, Me.mnuPedCompraItemPend, Me.mnuFacturaDifMultiple, Me.mnuResumenCompraProv})
        Me.cdmMain.ContainerControl = Me
        Me.cdmMain.Id = New System.Guid("c62f8454-516e-43c7-830c-05470a54b9a3")
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
        'Menu1
        '
        Me.Menu1.CommandBarType = Janus.Windows.UI.CommandBars.CommandBarType.Menu
        Me.Menu1.CommandManager = Me.cdmMain
        Me.Menu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuCatalogo1, Me.mnuTransaccion3, Me.mnuCreditoMain1, Me.mnuPagoMain1, Me.mnuReporte5, Me.mnuParametro3, Me.mnuView1, Me.mnuHelp3})
        Me.Menu1.Key = "Menu"
        Me.Menu1.Location = New System.Drawing.Point(0, 0)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.RowIndex = 0
        Me.Menu1.Size = New System.Drawing.Size(720, 26)
        Me.Menu1.Text = "Menu"
        '
        'mnuCatalogo1
        '
        Me.mnuCatalogo1.Key = "mnuCatalogo"
        Me.mnuCatalogo1.Name = "mnuCatalogo1"
        Me.mnuCatalogo1.Text = "&Catálogos"
        '
        'mnuTransaccion3
        '
        Me.mnuTransaccion3.Key = "mnuTransaccion"
        Me.mnuTransaccion3.Name = "mnuTransaccion3"
        '
        'mnuCreditoMain1
        '
        Me.mnuCreditoMain1.Key = "mnuCreditoMain"
        Me.mnuCreditoMain1.Name = "mnuCreditoMain1"
        '
        'mnuPagoMain1
        '
        Me.mnuPagoMain1.Key = "mnuPagoMain"
        Me.mnuPagoMain1.Name = "mnuPagoMain1"
        '
        'mnuReporte5
        '
        Me.mnuReporte5.Key = "mnuReporte"
        Me.mnuReporte5.Name = "mnuReporte5"
        '
        'mnuParametro3
        '
        Me.mnuParametro3.Key = "mnuParametro"
        Me.mnuParametro3.Name = "mnuParametro3"
        '
        'mnuView1
        '
        Me.mnuView1.Key = "mnuView"
        Me.mnuView1.Name = "mnuView1"
        '
        'mnuHelp3
        '
        Me.mnuHelp3.Key = "mnuHelp"
        Me.mnuHelp3.Name = "mnuHelp3"
        '
        'ToolBar1
        '
        Me.ToolBar1.CommandManager = Me.cdmMain
        Me.ToolBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.btnEmpresa4, Me.Separator19, Me.btnProveedor1, Me.Separator20, Me.btnItem1, Me.Separator21, Me.btnCompra1, Me.Separator22, Me.btnCompraPara1, Me.Separator23, Me.btnTipoCambio3, Me.Separator24, Me.btnUserPass3, Me.Separator25, Me.btnCalculadora1, Me.Separator30, Me.btnHelp1, Me.Separator26, Me.btnHelpVideo1, Me.Separator27, Me.btnExit3})
        Me.ToolBar1.Key = "ToolBar"
        Me.ToolBar1.Location = New System.Drawing.Point(104, 26)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.RowIndex = 1
        Me.ToolBar1.Size = New System.Drawing.Size(336, 28)
        Me.ToolBar1.Text = "ToolBar"
        '
        'btnEmpresa4
        '
        Me.btnEmpresa4.Key = "btnEmpresa"
        Me.btnEmpresa4.Name = "btnEmpresa4"
        '
        'Separator19
        '
        Me.Separator19.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator19.Key = "Separator"
        Me.Separator19.Name = "Separator19"
        '
        'btnProveedor1
        '
        Me.btnProveedor1.Key = "btnProveedor"
        Me.btnProveedor1.Name = "btnProveedor1"
        '
        'Separator20
        '
        Me.Separator20.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator20.Key = "Separator"
        Me.Separator20.Name = "Separator20"
        '
        'btnItem1
        '
        Me.btnItem1.Key = "btnItem"
        Me.btnItem1.Name = "btnItem1"
        '
        'Separator21
        '
        Me.Separator21.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator21.Key = "Separator"
        Me.Separator21.Name = "Separator21"
        '
        'btnCompra1
        '
        Me.btnCompra1.Key = "btnCompra"
        Me.btnCompra1.Name = "btnCompra1"
        '
        'Separator22
        '
        Me.Separator22.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator22.Key = "Separator"
        Me.Separator22.Name = "Separator22"
        '
        'btnCompraPara1
        '
        Me.btnCompraPara1.Key = "btnCompraPara"
        Me.btnCompraPara1.Name = "btnCompraPara1"
        '
        'Separator23
        '
        Me.Separator23.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator23.Key = "Separator"
        Me.Separator23.Name = "Separator23"
        '
        'btnTipoCambio3
        '
        Me.btnTipoCambio3.Key = "btnTipoCambio"
        Me.btnTipoCambio3.Name = "btnTipoCambio3"
        '
        'Separator24
        '
        Me.Separator24.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator24.Key = "Separator"
        Me.Separator24.Name = "Separator24"
        '
        'btnUserPass3
        '
        Me.btnUserPass3.Key = "btnUserPass"
        Me.btnUserPass3.Name = "btnUserPass3"
        '
        'Separator25
        '
        Me.Separator25.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator25.Key = "Separator"
        Me.Separator25.Name = "Separator25"
        '
        'btnCalculadora1
        '
        Me.btnCalculadora1.Key = "btnCalculadora"
        Me.btnCalculadora1.Name = "btnCalculadora1"
        '
        'Separator30
        '
        Me.Separator30.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator30.Key = "Separator"
        Me.Separator30.Name = "Separator30"
        '
        'btnHelp1
        '
        Me.btnHelp1.Key = "btnHelp"
        Me.btnHelp1.Name = "btnHelp1"
        '
        'Separator26
        '
        Me.Separator26.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator26.Key = "Separator"
        Me.Separator26.Name = "Separator26"
        '
        'btnHelpVideo1
        '
        Me.btnHelpVideo1.Key = "btnHelpVideo"
        Me.btnHelpVideo1.Name = "btnHelpVideo1"
        '
        'Separator27
        '
        Me.Separator27.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator27.Key = "Separator"
        Me.Separator27.Name = "Separator27"
        '
        'btnExit3
        '
        Me.btnExit3.Key = "btnExit"
        Me.btnExit3.Name = "btnExit3"
        '
        'ToolSet1
        '
        Me.ToolSet1.CommandManager = Me.cdmMain
        Me.ToolSet1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.btnExcel1, Me.Separator32, Me.btnFilter1, Me.Separator33, Me.btnSort1})
        Me.ToolSet1.Key = "ToolSet"
        Me.ToolSet1.Location = New System.Drawing.Point(0, 26)
        Me.ToolSet1.Name = "ToolSet1"
        Me.ToolSet1.RowIndex = 1
        Me.ToolSet1.Size = New System.Drawing.Size(104, 28)
        Me.ToolSet1.Text = "ToolSet"
        '
        'btnExcel1
        '
        Me.btnExcel1.Key = "btnExcel"
        Me.btnExcel1.Name = "btnExcel1"
        '
        'Separator32
        '
        Me.Separator32.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator32.Key = "Separator"
        Me.Separator32.Name = "Separator32"
        '
        'btnFilter1
        '
        Me.btnFilter1.Key = "btnFilter"
        Me.btnFilter1.Name = "btnFilter1"
        '
        'Separator33
        '
        Me.Separator33.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator33.Key = "Separator"
        Me.Separator33.Name = "Separator33"
        '
        'btnSort1
        '
        Me.btnSort1.Key = "btnSort"
        Me.btnSort1.Name = "btnSort1"
        '
        'mnuCatalogo
        '
        Me.mnuCatalogo.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuEmpresa5, Me.mnuProveedor1, Me.mnuItem3, Me.mnuPlanRecargo1, Me.mnuPlanDescuento1, Me.mnuPlanOtroCosto1, Me.mnuAduana1, Me.mnuBanco3})
        Me.mnuCatalogo.Key = "mnuCatalogo"
        Me.mnuCatalogo.Name = "mnuCatalogo"
        Me.mnuCatalogo.Text = "Catálogos"
        '
        'mnuEmpresa5
        '
        Me.mnuEmpresa5.Key = "mnuEmpresa"
        Me.mnuEmpresa5.Name = "mnuEmpresa5"
        '
        'mnuProveedor1
        '
        Me.mnuProveedor1.Key = "mnuProveedor"
        Me.mnuProveedor1.Name = "mnuProveedor1"
        '
        'mnuItem3
        '
        Me.mnuItem3.Key = "mnuItem"
        Me.mnuItem3.Name = "mnuItem3"
        '
        'mnuPlanRecargo1
        '
        Me.mnuPlanRecargo1.Key = "mnuPlanRecargo"
        Me.mnuPlanRecargo1.Name = "mnuPlanRecargo1"
        '
        'mnuPlanDescuento1
        '
        Me.mnuPlanDescuento1.Key = "mnuPlanDescuento"
        Me.mnuPlanDescuento1.Name = "mnuPlanDescuento1"
        '
        'mnuPlanOtroCosto1
        '
        Me.mnuPlanOtroCosto1.Key = "mnuPlanOtroCosto"
        Me.mnuPlanOtroCosto1.Name = "mnuPlanOtroCosto1"
        '
        'mnuAduana1
        '
        Me.mnuAduana1.Key = "mnuAduana"
        Me.mnuAduana1.Name = "mnuAduana1"
        '
        'mnuBanco3
        '
        Me.mnuBanco3.Key = "mnuBanco"
        Me.mnuBanco3.Name = "mnuBanco3"
        '
        'mnuProveedor
        '
        Me.mnuProveedor.Key = "mnuProveedor"
        Me.mnuProveedor.Name = "mnuProveedor"
        Me.mnuProveedor.Text = "Proveedores"
        '
        'mnuPlanDescuento
        '
        Me.mnuPlanDescuento.Key = "mnuPlanDescuento"
        Me.mnuPlanDescuento.Name = "mnuPlanDescuento"
        Me.mnuPlanDescuento.Text = "Tipos de Descuento"
        '
        'mnuPlanRecargo
        '
        Me.mnuPlanRecargo.Key = "mnuPlanRecargo"
        Me.mnuPlanRecargo.Name = "mnuPlanRecargo"
        Me.mnuPlanRecargo.Text = "Tipos de Recargo"
        '
        'mnuPedCompra
        '
        Me.mnuPedCompra.Key = "mnuPedCompra"
        Me.mnuPedCompra.Name = "mnuPedCompra"
        Me.mnuPedCompra.Text = "Pedidos de Compra"
        '
        'mnuCompraPara
        '
        Me.mnuCompraPara.Key = "mnuCompraPara"
        Me.mnuCompraPara.Name = "mnuCompraPara"
        Me.mnuCompraPara.Text = "Documentos"
        '
        'mnuAnticipo
        '
        Me.mnuAnticipo.Key = "mnuAnticipo"
        Me.mnuAnticipo.Name = "mnuAnticipo"
        Me.mnuAnticipo.Text = "Anticipos y Devoluciones de Anticipos"
        '
        'mnuCompra
        '
        Me.mnuCompra.Key = "mnuCompra"
        Me.mnuCompra.Name = "mnuCompra"
        Me.mnuCompra.Text = "Notas de Compra"
        '
        'mnuCredito
        '
        Me.mnuCredito.Key = "mnuCredito"
        Me.mnuCredito.Name = "mnuCredito"
        Me.mnuCredito.Text = "Programación de Planes de Pago"
        '
        'mnuCreditoIni
        '
        Me.mnuCreditoIni.Key = "mnuCreditoIni"
        Me.mnuCreditoIni.Name = "mnuCreditoIni"
        Me.mnuCreditoIni.Text = "Saldos Iniciales"
        '
        'mnuPago
        '
        Me.mnuPago.Key = "mnuPago"
        Me.mnuPago.Name = "mnuPago"
        Me.mnuPago.Text = "Historial de Pagos"
        '
        'mnuCreditoPago
        '
        Me.mnuCreditoPago.Key = "mnuCreditoPago"
        Me.mnuCreditoPago.Name = "mnuCreditoPago"
        Me.mnuCreditoPago.Text = "Notas al Crédito"
        '
        'mnuContadoPago
        '
        Me.mnuContadoPago.Key = "mnuContadoPago"
        Me.mnuContadoPago.Name = "mnuContadoPago"
        Me.mnuContadoPago.Text = "Notas al Contado"
        '
        'mnuProveedorMov
        '
        Me.mnuProveedorMov.Key = "mnuProveedorMov"
        Me.mnuProveedorMov.Name = "mnuProveedorMov"
        Me.mnuProveedorMov.Text = "Movimiento de Proveedores"
        '
        'mnuTransaccion2
        '
        Me.mnuTransaccion2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuPedCompra2, Me.mnuAnticipo2, Me.mnuCompra2, Me.mnuDevCompra1, Me.Separator29, Me.mnuFacturaDIf1, Me.mnuFacturaDifMultiple1, Me.Separator37, Me.mnuCierreGestion1})
        Me.mnuTransaccion2.Key = "mnuTransaccion"
        Me.mnuTransaccion2.Name = "mnuTransaccion2"
        Me.mnuTransaccion2.Text = "&Transacciones"
        '
        'mnuPedCompra2
        '
        Me.mnuPedCompra2.Key = "mnuPedCompra"
        Me.mnuPedCompra2.Name = "mnuPedCompra2"
        '
        'mnuAnticipo2
        '
        Me.mnuAnticipo2.Key = "mnuAnticipo"
        Me.mnuAnticipo2.Name = "mnuAnticipo2"
        '
        'mnuCompra2
        '
        Me.mnuCompra2.Key = "mnuCompra"
        Me.mnuCompra2.Name = "mnuCompra2"
        '
        'mnuDevCompra1
        '
        Me.mnuDevCompra1.Key = "mnuDevCompra"
        Me.mnuDevCompra1.Name = "mnuDevCompra1"
        '
        'Separator29
        '
        Me.Separator29.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator29.Key = "Separator"
        Me.Separator29.Name = "Separator29"
        '
        'mnuFacturaDIf1
        '
        Me.mnuFacturaDIf1.Key = "mnuFacturaDif"
        Me.mnuFacturaDIf1.Name = "mnuFacturaDIf1"
        '
        'mnuFacturaDifMultiple1
        '
        Me.mnuFacturaDifMultiple1.Key = "mnuFacturaDifMultiple"
        Me.mnuFacturaDifMultiple1.Name = "mnuFacturaDifMultiple1"
        '
        'Separator37
        '
        Me.Separator37.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator37.Key = "Separator"
        Me.Separator37.Name = "Separator37"
        '
        'mnuCierreGestion1
        '
        Me.mnuCierreGestion1.Key = "mnuCierreGestion"
        Me.mnuCierreGestion1.Name = "mnuCierreGestion1"
        '
        'mnuDevCompra
        '
        Me.mnuDevCompra.Key = "mnuDevCompra"
        Me.mnuDevCompra.Name = "mnuDevCompra"
        Me.mnuDevCompra.Text = "Devoluciones Sobre Compras"
        '
        'mnuCreditoMain
        '
        Me.mnuCreditoMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuCredito2, Me.mnuCreditoIni2})
        Me.mnuCreditoMain.Key = "mnuCreditoMain"
        Me.mnuCreditoMain.Name = "mnuCreditoMain"
        Me.mnuCreditoMain.Text = "Cr&éditos"
        '
        'mnuCredito2
        '
        Me.mnuCredito2.Key = "mnuCredito"
        Me.mnuCredito2.Name = "mnuCredito2"
        Me.mnuCredito2.Text = "Programación de Notas al Credito"
        '
        'mnuCreditoIni2
        '
        Me.mnuCreditoIni2.Key = "mnuCreditoIni"
        Me.mnuCreditoIni2.Name = "mnuCreditoIni2"
        '
        'mnuPagoMain
        '
        Me.mnuPagoMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuContadoPago2, Me.mnuCreditoPago2, Me.Separator28, Me.mnuPago2, Me.mnuAjuste1})
        Me.mnuPagoMain.Key = "mnuPagoMain"
        Me.mnuPagoMain.Name = "mnuPagoMain"
        Me.mnuPagoMain.Text = "Pa&gos"
        '
        'mnuContadoPago2
        '
        Me.mnuContadoPago2.Key = "mnuContadoPago"
        Me.mnuContadoPago2.Name = "mnuContadoPago2"
        '
        'mnuCreditoPago2
        '
        Me.mnuCreditoPago2.Key = "mnuCreditoPago"
        Me.mnuCreditoPago2.Name = "mnuCreditoPago2"
        '
        'Separator28
        '
        Me.Separator28.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator28.Key = "Separator"
        Me.Separator28.Name = "Separator28"
        '
        'mnuPago2
        '
        Me.mnuPago2.Key = "mnuPago"
        Me.mnuPago2.Name = "mnuPago2"
        '
        'mnuAjuste1
        '
        Me.mnuAjuste1.Key = "mnuAjuste"
        Me.mnuAjuste1.Name = "mnuAjuste1"
        '
        'mnuReporte4
        '
        Me.mnuReporte4.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuProveedorMov2, Me.mnuProveedorExtra1, Me.mnuCompraMov1, Me.mnuCompraMovDiario1, Me.mnuResumenCompraProv1, Me.mnuCreditoMov1, Me.Separator31, Me.mnuFlujoCaja1, Me.mnuAbonoProveedor1, Me.Separator34, Me.mnuPedCompraMov1, Me.mnuPedCompraTransito1, Me.mnuPedCompraItemPend1, Me.Separator38, Me.mnuFactDifProveedor1, Me.Separator39, Me.mnuUltPrecioCompra1, Me.Separator40, Me.mnuProveedorPorPagar1, Me.mnuProveedorItemMov1, Me.mnuItemProveedorMov1, Me.Separator41})
        Me.mnuReporte4.Key = "mnuReporte"
        Me.mnuReporte4.Name = "mnuReporte4"
        Me.mnuReporte4.Text = "&Reportes"
        '
        'mnuProveedorMov2
        '
        Me.mnuProveedorMov2.Key = "mnuProveedorMov"
        Me.mnuProveedorMov2.Name = "mnuProveedorMov2"
        '
        'mnuProveedorExtra1
        '
        Me.mnuProveedorExtra1.Key = "mnuProveedorExtra"
        Me.mnuProveedorExtra1.Name = "mnuProveedorExtra1"
        '
        'mnuCompraMov1
        '
        Me.mnuCompraMov1.Key = "mnuCompraMov"
        Me.mnuCompraMov1.Name = "mnuCompraMov1"
        '
        'mnuCompraMovDiario1
        '
        Me.mnuCompraMovDiario1.Key = "mnuCompraMovDiario"
        Me.mnuCompraMovDiario1.Name = "mnuCompraMovDiario1"
        '
        'mnuCreditoMov1
        '
        Me.mnuCreditoMov1.Key = "mnuCreditoMov"
        Me.mnuCreditoMov1.Name = "mnuCreditoMov1"
        '
        'Separator31
        '
        Me.Separator31.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator31.Key = "Separator"
        Me.Separator31.Name = "Separator31"
        '
        'mnuFlujoCaja1
        '
        Me.mnuFlujoCaja1.Key = "mnuFlujoCaja"
        Me.mnuFlujoCaja1.Name = "mnuFlujoCaja1"
        '
        'mnuAbonoProveedor1
        '
        Me.mnuAbonoProveedor1.Key = "mnuAbonoProveedor"
        Me.mnuAbonoProveedor1.Name = "mnuAbonoProveedor1"
        '
        'Separator34
        '
        Me.Separator34.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator34.Key = "Separator"
        Me.Separator34.Name = "Separator34"
        '
        'mnuPedCompraMov1
        '
        Me.mnuPedCompraMov1.Key = "mnuPedCompraMov"
        Me.mnuPedCompraMov1.Name = "mnuPedCompraMov1"
        '
        'mnuPedCompraTransito1
        '
        Me.mnuPedCompraTransito1.Key = "mnuPedCompraTransito"
        Me.mnuPedCompraTransito1.Name = "mnuPedCompraTransito1"
        '
        'mnuPedCompraItemPend1
        '
        Me.mnuPedCompraItemPend1.Key = "mnuPedCompraItemPend"
        Me.mnuPedCompraItemPend1.Name = "mnuPedCompraItemPend1"
        '
        'Separator38
        '
        Me.Separator38.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator38.Key = "Separator"
        Me.Separator38.Name = "Separator38"
        '
        'mnuFactDifProveedor1
        '
        Me.mnuFactDifProveedor1.Key = "mnuFactDifProveedor"
        Me.mnuFactDifProveedor1.Name = "mnuFactDifProveedor1"
        '
        'Separator39
        '
        Me.Separator39.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator39.Key = "Separator"
        Me.Separator39.Name = "Separator39"
        '
        'mnuUltPrecioCompra1
        '
        Me.mnuUltPrecioCompra1.Key = "mnuUltPrecioCompra"
        Me.mnuUltPrecioCompra1.Name = "mnuUltPrecioCompra1"
        '
        'Separator40
        '
        Me.Separator40.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator40.Key = "Separator"
        Me.Separator40.Name = "Separator40"
        '
        'mnuProveedorPorPagar1
        '
        Me.mnuProveedorPorPagar1.Key = "mnuProveedorPorPagar"
        Me.mnuProveedorPorPagar1.Name = "mnuProveedorPorPagar1"
        '
        'mnuProveedorItemMov1
        '
        Me.mnuProveedorItemMov1.Key = "mnuProveedorItemMov"
        Me.mnuProveedorItemMov1.Name = "mnuProveedorItemMov1"
        '
        'mnuItemProveedorMov1
        '
        Me.mnuItemProveedorMov1.Key = "mnuItemProveedorMov"
        Me.mnuItemProveedorMov1.Name = "mnuItemProveedorMov1"
        '
        'Separator41
        '
        Me.Separator41.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator41.Key = "Separator"
        Me.Separator41.Name = "Separator41"
        '
        'mnuParametro
        '
        Me.mnuParametro.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuGestion3, Me.mnuParametroSub1, Me.mnuPlanGrupo3, Me.mnuTipoCambio3, Me.Separator35, Me.mnuDataBaseBackup1, Me.mnuDataBaseImport1, Me.Separator36, Me.mnuDataSecurityImport1})
        Me.mnuParametro.Key = "mnuParametro"
        Me.mnuParametro.Name = "mnuParametro"
        Me.mnuParametro.Text = "&Parámetros"
        '
        'mnuGestion3
        '
        Me.mnuGestion3.Key = "mnuGestion"
        Me.mnuGestion3.Name = "mnuGestion3"
        '
        'mnuParametroSub1
        '
        Me.mnuParametroSub1.Key = "mnuParametroSub"
        Me.mnuParametroSub1.Name = "mnuParametroSub1"
        '
        'mnuPlanGrupo3
        '
        Me.mnuPlanGrupo3.Key = "mnuPlanGrupo"
        Me.mnuPlanGrupo3.Name = "mnuPlanGrupo3"
        '
        'mnuTipoCambio3
        '
        Me.mnuTipoCambio3.Key = "mnuTipoCambio"
        Me.mnuTipoCambio3.Name = "mnuTipoCambio3"
        '
        'Separator35
        '
        Me.Separator35.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator35.Key = "Separator"
        Me.Separator35.Name = "Separator35"
        '
        'mnuDataBaseBackup1
        '
        Me.mnuDataBaseBackup1.Key = "mnuDataBaseBackup"
        Me.mnuDataBaseBackup1.Name = "mnuDataBaseBackup1"
        '
        'mnuDataBaseImport1
        '
        Me.mnuDataBaseImport1.Key = "mnuDataBaseImport"
        Me.mnuDataBaseImport1.Name = "mnuDataBaseImport1"
        '
        'Separator36
        '
        Me.Separator36.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator36.Key = "Separator"
        Me.Separator36.Name = "Separator36"
        '
        'mnuDataSecurityImport1
        '
        Me.mnuDataSecurityImport1.Key = "mnuDataSecurityImport"
        Me.mnuDataSecurityImport1.Name = "mnuDataSecurityImport1"
        '
        'mnuView
        '
        Me.mnuView.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuToolBar3, Me.mnuStatusBar3})
        Me.mnuView.Key = "mnuView"
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Text = "&Ver"
        '
        'mnuToolBar3
        '
        Me.mnuToolBar3.Checked = Janus.Windows.UI.InheritableBoolean.[True]
        Me.mnuToolBar3.Key = "mnuToolBar"
        Me.mnuToolBar3.Name = "mnuToolBar3"
        '
        'mnuStatusBar3
        '
        Me.mnuStatusBar3.Checked = Janus.Windows.UI.InheritableBoolean.[True]
        Me.mnuStatusBar3.Key = "mnuStatusBar"
        Me.mnuStatusBar3.Name = "mnuStatusBar3"
        '
        'mnuToolBar2
        '
        Me.mnuToolBar2.Key = "mnuToolBar"
        Me.mnuToolBar2.Name = "mnuToolBar2"
        Me.mnuToolBar2.Text = "Barra de Herramientas"
        '
        'mnuStatusBar2
        '
        Me.mnuStatusBar2.Key = "mnuStatusBar"
        Me.mnuStatusBar2.Name = "mnuStatusBar2"
        Me.mnuStatusBar2.Text = "Barra de Estado"
        '
        'mnuHelp2
        '
        Me.mnuHelp2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuAyudaDinamica3, Me.mnuAboutBox3})
        Me.mnuHelp2.Key = "mnuHelp"
        Me.mnuHelp2.Name = "mnuHelp2"
        Me.mnuHelp2.Text = "&Ayuda"
        '
        'mnuAyudaDinamica3
        '
        Me.mnuAyudaDinamica3.Key = "mnuAyudaDinamica"
        Me.mnuAyudaDinamica3.Name = "mnuAyudaDinamica3"
        '
        'mnuAboutBox3
        '
        Me.mnuAboutBox3.Key = "mnuAboutBox"
        Me.mnuAboutBox3.Name = "mnuAboutBox3"
        '
        'mnuAyudaDinamica2
        '
        Me.mnuAyudaDinamica2.Key = "mnuAyudaDinamica"
        Me.mnuAyudaDinamica2.Name = "mnuAyudaDinamica2"
        Me.mnuAyudaDinamica2.Text = "Ayuda Dinámica"
        '
        'mnuAboutBox2
        '
        Me.mnuAboutBox2.Key = "mnuAboutBox"
        Me.mnuAboutBox2.Name = "mnuAboutBox2"
        Me.mnuAboutBox2.Text = "Acerca de Módulo de Compras..."
        '
        'mnuEmpresa4
        '
        Me.mnuEmpresa4.Key = "mnuEmpresa"
        Me.mnuEmpresa4.Name = "mnuEmpresa4"
        Me.mnuEmpresa4.Text = "Empresas"
        '
        'mnuGestion
        '
        Me.mnuGestion.Key = "mnuGestion"
        Me.mnuGestion.Name = "mnuGestion"
        Me.mnuGestion.Text = "Gestiones"
        '
        'mnuTipoCambio
        '
        Me.mnuTipoCambio.Key = "mnuTipoCambio"
        Me.mnuTipoCambio.Name = "mnuTipoCambio"
        Me.mnuTipoCambio.Text = "Tipos de Cambio"
        '
        'btnEmpresa3
        '
        Me.btnEmpresa3.ImageIndex = 0
        Me.btnEmpresa3.Key = "btnEmpresa"
        Me.btnEmpresa3.Name = "btnEmpresa3"
        '
        'btnCompra
        '
        Me.btnCompra.ImageIndex = 1
        Me.btnCompra.Key = "btnCompra"
        Me.btnCompra.Name = "btnCompra"
        '
        'btnProveedor
        '
        Me.btnProveedor.ImageIndex = 10
        Me.btnProveedor.Key = "btnProveedor"
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.ToolTipText = "Proveedores"
        '
        'mnuItem2
        '
        Me.mnuItem2.Key = "mnuItem"
        Me.mnuItem2.Name = "mnuItem2"
        Me.mnuItem2.Text = "Ítems"
        '
        'btnItem
        '
        Me.btnItem.ImageIndex = 11
        Me.btnItem.Key = "btnItem"
        Me.btnItem.Name = "btnItem"
        Me.btnItem.TextImageRelation = Janus.Windows.UI.CommandBars.TextImageRelation.TextBeforeImage
        Me.btnItem.ToolTipText = "Ítems"
        '
        'mnuPlanGrupo2
        '
        Me.mnuPlanGrupo2.Key = "mnuPlanGrupo"
        Me.mnuPlanGrupo2.Name = "mnuPlanGrupo2"
        Me.mnuPlanGrupo2.Text = "Grupos de Cuentas"
        '
        'btnCompraPara
        '
        Me.btnCompraPara.ImageIndex = 4
        Me.btnCompraPara.Key = "btnCompraPara"
        Me.btnCompraPara.Name = "btnCompraPara"
        Me.btnCompraPara.ToolTipText = "Parámetros de Documentos"
        '
        'btnTipoCambio2
        '
        Me.btnTipoCambio2.ImageIndex = 5
        Me.btnTipoCambio2.Key = "btnTipoCambio"
        Me.btnTipoCambio2.Name = "btnTipoCambio2"
        Me.btnTipoCambio2.ToolTipText = "Tipos de Cambio"
        '
        'btnUserPass2
        '
        Me.btnUserPass2.ImageIndex = 7
        Me.btnUserPass2.Key = "btnUserPass"
        Me.btnUserPass2.Name = "btnUserPass2"
        Me.btnUserPass2.ToolTipText = "Contraseña de Usuario"
        '
        'btnHelp
        '
        Me.btnHelp.ImageIndex = 8
        Me.btnHelp.Key = "btnHelp"
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.ToolTipText = "Ayuda Dinámica"
        '
        'btnHelpVideo
        '
        Me.btnHelpVideo.ImageIndex = 9
        Me.btnHelpVideo.Key = "btnHelpVideo"
        Me.btnHelpVideo.Name = "btnHelpVideo"
        Me.btnHelpVideo.ToolTipText = "Video"
        '
        'btnExit2
        '
        Me.btnExit2.ImageIndex = 6
        Me.btnExit2.Key = "btnExit"
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.ToolTipText = "Salir del Sistema"
        '
        'mnuPlanOtroCosto
        '
        Me.mnuPlanOtroCosto.Key = "mnuPlanOtroCosto"
        Me.mnuPlanOtroCosto.Name = "mnuPlanOtroCosto"
        Me.mnuPlanOtroCosto.Text = "Otros Costos Aplicables"
        '
        'mnuAduana
        '
        Me.mnuAduana.Key = "mnuAduana"
        Me.mnuAduana.Name = "mnuAduana"
        Me.mnuAduana.Text = "Agencias Aduaneras"
        '
        'mnuAjuste
        '
        Me.mnuAjuste.Key = "mnuAjuste"
        Me.mnuAjuste.Name = "mnuAjuste"
        Me.mnuAjuste.Text = "Historial de Ajustes"
        '
        'mnuCompraMov
        '
        Me.mnuCompraMov.Key = "mnuCompraMov"
        Me.mnuCompraMov.Name = "mnuCompraMov"
        Me.mnuCompraMov.Text = "Movimiento de Compras por Ítems"
        '
        'mnuCierreGestion
        '
        Me.mnuCierreGestion.Key = "mnuCierreGestion"
        Me.mnuCierreGestion.Name = "mnuCierreGestion"
        Me.mnuCierreGestion.Text = "Cierre de Gestión"
        '
        'mnuParametroSub
        '
        Me.mnuParametroSub.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuEmpresaPara1, Me.mnuCompraPara1})
        Me.mnuParametroSub.Key = "mnuParametroSub"
        Me.mnuParametroSub.Name = "mnuParametroSub"
        Me.mnuParametroSub.Text = "Parámetros de"
        '
        'mnuEmpresaPara1
        '
        Me.mnuEmpresaPara1.Key = "mnuEmpresaPara"
        Me.mnuEmpresaPara1.Name = "mnuEmpresaPara1"
        '
        'mnuCompraPara1
        '
        Me.mnuCompraPara1.Key = "mnuCompraPara"
        Me.mnuCompraPara1.Name = "mnuCompraPara1"
        '
        'mnuEmpresaPara
        '
        Me.mnuEmpresaPara.Key = "mnuEmpresaPara"
        Me.mnuEmpresaPara.Name = "mnuEmpresaPara"
        Me.mnuEmpresaPara.Text = "Empresas"
        '
        'mnuCompraMovDiario
        '
        Me.mnuCompraMovDiario.Key = "mnuCompraMovDiario"
        Me.mnuCompraMovDiario.Name = "mnuCompraMovDiario"
        Me.mnuCompraMovDiario.Text = "Resumen Diario de Compras"
        '
        'mnuCreditoMov
        '
        Me.mnuCreditoMov.Key = "mnuCreditoMov"
        Me.mnuCreditoMov.Name = "mnuCreditoMov"
        Me.mnuCreditoMov.Text = "Estado de Créditos"
        '
        'btnCalculadora
        '
        Me.btnCalculadora.ImageIndex = 12
        Me.btnCalculadora.Key = "btnCalculadora"
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.ToolTipText = "Calculadora de Windows"
        '
        'mnuPedCompraMov
        '
        Me.mnuPedCompraMov.Key = "mnuPedCompraMov"
        Me.mnuPedCompraMov.Name = "mnuPedCompraMov"
        Me.mnuPedCompraMov.Text = "Listado de Pedidos de Compra"
        '
        'btnExcel
        '
        Me.btnExcel.ImageIndex = 13
        Me.btnExcel.Key = "btnExcel"
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.ToolTipText = "Exportar Grilla a Excel"
        '
        'btnFilter
        '
        Me.btnFilter.ImageIndex = 14
        Me.btnFilter.Key = "btnFilter"
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.ToolTipText = "Filtrar Grilla"
        '
        'btnSort
        '
        Me.btnSort.ImageIndex = 15
        Me.btnSort.Key = "btnSort"
        Me.btnSort.Name = "btnSort"
        Me.btnSort.ToolTipText = "Ordenar Grilla"
        '
        'mnuFlujoCaja
        '
        Me.mnuFlujoCaja.Key = "mnuFlujoCaja"
        Me.mnuFlujoCaja.Name = "mnuFlujoCaja"
        Me.mnuFlujoCaja.Text = "Flujo de Caja de Compras"
        '
        'mnuDataBaseImport
        '
        Me.mnuDataBaseImport.Key = "mnuDataBaseImport"
        Me.mnuDataBaseImport.Name = "mnuDataBaseImport"
        Me.mnuDataBaseImport.Text = "Importar Información Desde Otra Base de datos"
        '
        'mnuDataBaseBackup
        '
        Me.mnuDataBaseBackup.Key = "mnuDataBaseBackup"
        Me.mnuDataBaseBackup.Name = "mnuDataBaseBackup"
        Me.mnuDataBaseBackup.Text = "Copia de Respaldo de la Base de Datos"
        '
        'mnuActualizarProveedorMov
        '
        Me.mnuActualizarProveedorMov.Key = "mnuActualizarProveedorMov"
        Me.mnuActualizarProveedorMov.Name = "mnuActualizarProveedorMov"
        Me.mnuActualizarProveedorMov.Text = "Actualizar Descargos en Mov. de Proveedor"
        '
        'mnuDataSecurityImport
        '
        Me.mnuDataSecurityImport.Key = "mnuDataSecurityImport"
        Me.mnuDataSecurityImport.Name = "mnuDataSecurityImport"
        Me.mnuDataSecurityImport.Text = "Listado de Formularios y Controles"
        '
        'mnuFacturaDif
        '
        Me.mnuFacturaDif.Key = "mnuFacturaDif"
        Me.mnuFacturaDif.Name = "mnuFacturaDif"
        Me.mnuFacturaDif.Text = "Facturación Diferida"
        '
        'mnuFactDifProveedor
        '
        Me.mnuFactDifProveedor.Key = "mnuFactDifProveedor"
        Me.mnuFactDifProveedor.Name = "mnuFactDifProveedor"
        Me.mnuFactDifProveedor.Text = "Facturas Diferidas de Proveedores"
        '
        'mnuProcedencia
        '
        Me.mnuProcedencia.Key = "mnuProcedencia"
        Me.mnuProcedencia.Name = "mnuProcedencia"
        Me.mnuProcedencia.Text = "Procedencias"
        '
        'mnuRubro
        '
        Me.mnuRubro.Key = "mnuRubro"
        Me.mnuRubro.Name = "mnuRubro"
        Me.mnuRubro.Text = "Rubros"
        '
        'mnuUltPrecioCompra
        '
        Me.mnuUltPrecioCompra.Key = "mnuUltPrecioCompra"
        Me.mnuUltPrecioCompra.Name = "mnuUltPrecioCompra"
        Me.mnuUltPrecioCompra.Text = "Últimos Precios de Compra"
        '
        'mnuProveedorPorPagar
        '
        Me.mnuProveedorPorPagar.Key = "mnuProveedorPorPagar"
        Me.mnuProveedorPorPagar.Name = "mnuProveedorPorPagar"
        Me.mnuProveedorPorPagar.Text = "Proveedores Por Pagar"
        '
        'mnuItemProveedorMov
        '
        Me.mnuItemProveedorMov.Key = "mnuItemProveedorMov"
        Me.mnuItemProveedorMov.Name = "mnuItemProveedorMov"
        Me.mnuItemProveedorMov.Text = "Ítems Comprados a un Proveedor"
        '
        'mnuProveedorItemMov
        '
        Me.mnuProveedorItemMov.Key = "mnuProveedorItemMov"
        Me.mnuProveedorItemMov.Name = "mnuProveedorItemMov"
        Me.mnuProveedorItemMov.Text = "Proveedores a los que se Compró un Ítem"
        '
        'mnuProveedorExtra
        '
        Me.mnuProveedorExtra.Key = "mnuProveedorExtra"
        Me.mnuProveedorExtra.Name = "mnuProveedorExtra"
        Me.mnuProveedorExtra.Text = "Extracto de Proveedores"
        '
        'mnuPedCompraTransito
        '
        Me.mnuPedCompraTransito.Key = "mnuPedCompraTransito"
        Me.mnuPedCompraTransito.Name = "mnuPedCompraTransito"
        Me.mnuPedCompraTransito.Text = "Pedidos de compra en tránsito"
        '
        'mnuBanco
        '
        Me.mnuBanco.Key = "mnuBanco"
        Me.mnuBanco.Name = "mnuBanco"
        Me.mnuBanco.Text = "Bancos"
        '
        'mnuAbonoProveedor
        '
        Me.mnuAbonoProveedor.Key = "mnuAbonoProveedor"
        Me.mnuAbonoProveedor.Name = "mnuAbonoProveedor"
        Me.mnuAbonoProveedor.Text = "Abono a Proveedores"
        '
        'mnuPedCompraItemPend
        '
        Me.mnuPedCompraItemPend.Key = "mnuPedCompraItemPend"
        Me.mnuPedCompraItemPend.Name = "mnuPedCompraItemPend"
        Me.mnuPedCompraItemPend.Text = "Ítems de Pedidos Pendientes de Compra"
        '
        'mnuFacturaDifMultiple
        '
        Me.mnuFacturaDifMultiple.Key = "mnuFacturaDifMultiple"
        Me.mnuFacturaDifMultiple.Name = "mnuFacturaDifMultiple"
        Me.mnuFacturaDifMultiple.Text = "Facturación Diferida de Varias Compras"
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
        Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.Menu1, Me.ToolBar1, Me.ToolSet1})
        Me.TopRebar1.CommandManager = Me.cdmMain
        Me.TopRebar1.Controls.Add(Me.Menu1)
        Me.TopRebar1.Controls.Add(Me.ToolBar1)
        Me.TopRebar1.Controls.Add(Me.ToolSet1)
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(720, 54)
        '
        'gexMain
        '
        Me.gexMain.SheetName = "Hoja1"
        '
        'sbrMain
        '
        Me.sbrMain.Location = New System.Drawing.Point(0, 390)
        Me.sbrMain.Name = "sbrMain"
        UiStatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        UiStatusBarPanel1.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel1.Icon = CType(resources.GetObject("UiStatusBarPanel1.Icon"), System.Drawing.Icon)
        UiStatusBarPanel1.Key = "sbrDataBase"
        UiStatusBarPanel1.ProgressBarValue = 0
        UiStatusBarPanel1.Text = "Base de Datos"
        UiStatusBarPanel1.Width = 139
        UiStatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        UiStatusBarPanel2.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel2.Icon = CType(resources.GetObject("UiStatusBarPanel2.Icon"), System.Drawing.Icon)
        UiStatusBarPanel2.Key = "sbrEnterprice"
        UiStatusBarPanel2.ProgressBarValue = 0
        UiStatusBarPanel2.Text = "Empresa"
        UiStatusBarPanel2.Width = 138
        UiStatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        UiStatusBarPanel3.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel3.Icon = CType(resources.GetObject("UiStatusBarPanel3.Icon"), System.Drawing.Icon)
        UiStatusBarPanel3.Key = "sbrGestion"
        UiStatusBarPanel3.ProgressBarValue = 0
        UiStatusBarPanel3.Text = "Gestion"
        UiStatusBarPanel3.Width = 138
        UiStatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        UiStatusBarPanel4.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel4.Icon = CType(resources.GetObject("UiStatusBarPanel4.Icon"), System.Drawing.Icon)
        UiStatusBarPanel4.Key = "sbrLogin"
        UiStatusBarPanel4.ProgressBarValue = 0
        UiStatusBarPanel4.Text = "Login"
        UiStatusBarPanel4.Width = 138
        UiStatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        UiStatusBarPanel5.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel5.Icon = CType(resources.GetObject("UiStatusBarPanel5.Icon"), System.Drawing.Icon)
        UiStatusBarPanel5.Key = "sbrForm"
        UiStatusBarPanel5.ProgressBarValue = 0
        UiStatusBarPanel5.Text = "sbrForm"
        UiStatusBarPanel5.Width = 138
        Me.sbrMain.Panels.AddRange(New Janus.Windows.UI.StatusBar.UIStatusBarPanel() {UiStatusBarPanel1, UiStatusBarPanel2, UiStatusBarPanel3, UiStatusBarPanel4, UiStatusBarPanel5})
        Me.sbrMain.PanelsBorderColor = System.Drawing.SystemColors.ControlDark
        Me.sbrMain.Size = New System.Drawing.Size(720, 23)
        Me.sbrMain.TabIndex = 33
        Me.sbrMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'mnuResumenCompraProv
        '
        Me.mnuResumenCompraProv.Key = "mnuResumenCompraProv"
        Me.mnuResumenCompraProv.Name = "mnuResumenCompraProv"
        Me.mnuResumenCompraProv.Text = "Resumen de Compras por Proveedores"
        '
        'mnuResumenCompraProv1
        '
        Me.mnuResumenCompraProv1.Key = "mnuResumenCompraProv"
        Me.mnuResumenCompraProv1.Name = "mnuResumenCompraProv1"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 413)
        Me.Controls.Add(Me.sbrMain)
        Me.Controls.Add(Me.TopRebar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DelfinNet - Módulo de Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopRebar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

   Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Call FormBackgroundImage()
      Call StatusDataBaseDisplay(clsAppInfo.DataBaseSource & "." & clsAppInfo.DataBaseName)

      Dim frm As New frmLogin
      frm.ShowDialog()

      Call PreferenceLoad(clsAppInfo.AppId, clsAppInfo.UserId)
      Call StatusGestionDisplay(ToStr(clsAppInfo.Gestion))
      Call EmpresaParaLoad(clsAppInfo.EmpresaId)
      Call StatusEnterpriseDisplay(clsAppInfo.EmpresaDes)
      Call ImpuestoLoad()
      Call SecuritySet(Me, AppExeName)

      Call TipoCambioCheck()
      Call ClearMemory()
   End Sub

   Private Sub TipoCambioCheck()
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = ToDate(Now.Date)

            If Not .Find Then
               If MessageBox.Show("No Existe Tipo de Cambio para Hoy, ¿Desea Insertarlo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Dim frm As New frmTipoCambioEdit

                  With frm
                     .NewRecord = True
                     .Editing = False

                     oTipoCambio.Fecha = ToDateDMY(Now.Date)

                     .DataObject = oTipoCambio
                     .ShowDialog()

                     If .Changed Then

                     End If
                  End With
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Sub FormBackgroundImage()
      Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
      Dim decDesktopScala As Decimal = Math.Truncate(desktopSize.Width / desktopSize.Height * 100) / 100
      Dim strDesktopSize As String

      Select Case decDesktopScala
         Case 1.33 '4x3
            strDesktopSize = "PC4x3.jpg"

         Case 1.77 '16x9
            strDesktopSize = "PC16x9.jpg"

         Case 1.6 '16x10
            strDesktopSize = "PC16x10.jpg"

         Case Else
            strDesktopSize = "Nothing.jpg"
      End Select

      Try
         If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() & strDesktopSize) Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & strDesktopSize)

         Else
            Call FormBackgroundImageStretch(desktopSize.Width, desktopSize.Height)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub FormBackgroundImageStretch(ByVal intWidth As Integer, ByVal intHeight As Integer)
      Dim strDirectory As String = Application.StartupPath
      Dim strDirFiles() As String = System.IO.Directory.GetFiles(strDirectory, "*.jpg")
      Dim intImageWidth As Long = 0
      Dim intImageHeight As Long = 0
      Dim strImage As String = ""
      Dim i As Integer

      For i = 0 To strDirFiles.Length - 1
         strImage = strDirFiles(i).Substring(strDirectory.Length + 1, strDirFiles(i).Length - strDirectory.Length - 5)
         intImageWidth = ToImageWidth(strImage)

         If intWidth = intImageWidth Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & strImage & ".jpg")

            Exit Sub
         End If
      Next

      For i = 0 To strDirFiles.Length - 1
         strImage = strDirFiles(i).Substring(strDirectory.Length + 1, strDirFiles(i).Length - strDirectory.Length - 5)
         intImageHeight = ToImageHeight(strImage)

         If intHeight = intImageHeight Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & strImage & ".jpg")

            Exit Sub
         End If
      Next

      If intImageWidth > 0 Then
         Me.BackgroundImage = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & strImage & ".jpg")

      Else
         Call FormBackColor()
      End If
   End Sub

   Function ToImageWidth(ByVal strValue As String) As Integer
      If Len(strValue) > 0 Then
         Dim strAux As String = ""

         For i As Integer = 3 To strValue.Length
            If IsNumeric(Mid$(strValue, i, 1)) Then
               strAux &= Mid$(strValue, i, 1)
            Else
               Exit For
            End If
         Next

         If Len(strAux) > 0 Then
            Return ToInteger(strAux)
         Else
            Return 0
         End If

      Else
         Return strValue
      End If
   End Function

   Function ToImageHeight(ByVal strValue As String) As Integer
      If Len(strValue) > 0 Then
         Dim strAux As String = ""

         For i = strValue.Length To 1 Step -1
            If IsNumeric(Mid$(strValue, i, 1)) Then
               strAux = Mid$(strValue, i, 1) & strAux
            Else
               Exit For
            End If
         Next

         If Len(strAux) > 0 Then
            Return ToInteger(strAux)
         Else
            Return 0
         End If

      Else
         Return strValue
      End If
   End Function

   Private Sub FormBackColor()
      Dim ctl As Control

      For Each ctl In Me.Controls
         Try
            ctlMDI = CType(ctl, MdiClient)
            ctlMDI.BackColor = Color.AntiqueWhite

            AddHandler ctlMDI.Paint, AddressOf PintarFondo

         Catch ex As InvalidCastException

         End Try
      Next
   End Sub

   Private Sub PintarFondo(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
      If (ctlMDI.Width > 0) And (ctlMDI.Height > 0) Then
         Dim GradientePanel As New System.Drawing.Drawing2D.LinearGradientBrush(New RectangleF(0, 0, ctlMDI.Width, ctlMDI.Height), Color.MediumBlue, Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
         e.Graphics.FillRectangle(GradientePanel, New RectangleF(0, 0, ctlMDI.Width, ctlMDI.Height))
      End If
   End Sub

   Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
      If Not (Me.ctlMDI Is Nothing) Then
         Me.PintarFondo(Me.ctlMDI, New PaintEventArgs(Me.ctlMDI.CreateGraphics, New Rectangle(Me.ctlMDI.Location, Me.ctlMDI.Size)))
      End If
   End Sub

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Select Case e.Command.Key
         Case "mnuProveedor"
            Dim frm As New frmProveedor
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPlanDescuento"
            Dim frm As New frmPlanDescuento
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPlanRecargo"
            Dim frm As New frmPlanRecargo
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPlanOtroCosto"
            Dim frm As New frmPlanOtroCosto
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuAduana"
            Dim frm As New frmAduana
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuBanco"
            Dim frm As New frmBanco
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With


            ''''''''''''''''''''''''''''

         Case "mnuPedCompra"
            Dim frm As New frmPedCompra
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuAnticipo"
            Dim frm As New frmAnticipo
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCompra"
            Dim frm As New frmCompra
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuDevCompra"
            Dim frm As New frmDevCompra
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuFacturaDif"
            Dim frm As New frmFacturaDif
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuFacturaDifMultiple"
            Dim frm As New frmFacturaDifMultiple
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCierreGestion"
            Dim frm As New frmCierreGestion
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCredito"
            Dim frm As New frmCredito
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCreditoIni"
            Dim frm As New frmCreditoIni
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCreditoPago"
            Dim frm As New frmCreditoPago
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuContadoPago"
            Dim frm As New frmContadoPago
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPago"
            Dim frm As New frmPago
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuAjuste"
            Dim frm As New frmAjuste
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuProveedorMov"
            Dim frm As New frmProveedorMovFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuProveedorExtra"
            Dim frm As New frmProveedorExtraFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCompraMov"
            Dim frm As New frmCompraMovFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCompraMovDiario"
            Dim frm As New frmCompraMovDiarioFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCreditoMov"
            Dim frm As New frmCreditoMovFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPedCompraMov"
            Dim frm As New frmPedCompraMovFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuUltPrecioCompra"
            Dim frm As New frmUltimoPrecioCompraFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPedCompraTransito"
            Dim frm As New frmPedCompraTransitoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPedCompraItemPend"
            Dim frm As New frmPedCompraItemPendFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

            Case "mnuResumenCompraProv"
                Dim frm As New frmCostosMovFind
                With frm
                    .MdiParent = Me
                    .Show()
                End With

         Case "mnuAbonoProveedor"
            Dim frm As New frmAbonoProveedorFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With


            '''''

         Case "mnuEmpresa"
            Dim frm As New frmEmpresa
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuItem"
            Dim frm As New frmItem
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuEmpresaPara"
            Dim frm As New frmEmpresaPara
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCompraPara"
            Dim frm As New frmCompraPara
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuTipoCambio"
            Dim frm As New frmTipoCambio
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuGestion"
            Dim frm As New frmGestion
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPlanGrupo"
            Dim frm As New frmPlanGrupo
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuDataBaseBackup"
            Dim frm As New frmDataBaseBackup
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuDataBaseImport"
            Dim frm As New frmDataBaseImport
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuDataSecurityImport"
            Dim frm As New frmDataSecurityImport
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuToolBar"
            'mnuToolBar1.IsChecked = Not mnuToolBar1.IsChecked
            'ToolBar1.Visible = mnuToolBar1.IsChecked

         Case "mnuStatusBar"
            mnuStatusBar3.IsChecked = Not mnuStatusBar3.IsChecked
            sbrMain.Visible = mnuStatusBar3.IsChecked

         Case "mnuAyudaDinamica"

         Case "mnuAboutBox"
            Dim frm As New frmAboutBox

            With frm
               .MdiParent = Me
               .Show()
            End With


            'ToolSet 
         Case "btnExcel"
            Call ExportToExcelActiveMdiChild()

         Case "btnFilter"
            Call FilterConditionActiveMdiChild()

         Case "btnSort"
            Call SortKeysActiveMdiChild()


            'ToolBar 
         Case "btnEmpresa"
            Dim frm As New frmEmpresa
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "btnProveedor"
            Dim frm As New frmProveedor
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnItem"
            Dim frm As New frmItem
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnCompraPara"
            Dim frm As New frmCompraPara
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnTipoCambio"
            Dim frm As New frmTipoCambio
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "btnCalculadora"
            Dim oProcess As New Process
            oProcess.StartInfo.FileName = "calc.exe"
            oProcess.StartInfo.Arguments = ""
            oProcess.Start()

         Case "btnUserPass"
            Dim frm As New frmUserPass
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuFlujoCaja"
            Dim frm As New frmFlujoCajaFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnHelp"
            If Dir(clsAppInfo.HelpIndex) <> "" Then
               Dim proc As New Process
               proc.StartInfo.FileName = clsAppInfo.HelpIndex
               proc.StartInfo.Arguments = ""
               proc.Start()
            Else
               MessageBox.Show("Documento No Encontrado en la Ruta Especificada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "btnHelpVideo"
            If Dir(clsAppInfo.HelpVideo) <> "" Then
               Dim proc As New Process
               proc.StartInfo.FileName = clsAppInfo.HelpVideo
               proc.StartInfo.Arguments = ""
               proc.Start()
            Else
               MessageBox.Show("Documento No Encontrado en la Ruta Especificada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case mnuActualizarProveedorMov.Key
            Call ActualizarInfoAnterior()

         Case "mnuFactDifProveedor"
            Dim frm As New frmFactDifProveedorFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuProveedorPorPagar"
            Dim frm As New frmProveedorPorPagarFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuProveedorItemMov"
            Dim frm As New frmProveedorItemMovFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuItemProveedorMov"
            Dim frm As New frmItemProveedorMovFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnExit"
            Me.Close()

      End Select
   End Sub

   'Actualiza los descargos de anticipos q se han realizados mal desde compra y pagos
   'los cuales an enviado a movimientos de cliente el id del anticipo los cuales crean conflicto 
   'al verficar tal movimiento ¿a que descargo pertenece? se ha solucionado enviando el id del anticipoDet
   Private Sub ActualizarInfoAnterior()
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Dim oProveedorMov As New clsProveedorMov(clsAppInfo.ConnectString)
      Dim oPago As New clsPago(clsAppInfo.ConnectString)
      Dim oCompra As New clsCompra(clsAppInfo.ConnectString)
      Dim oAnticipoDet As New clsAnticipoDet(clsAppInfo.ConnectString)

      With oProveedorMov
         .SelectFilter = clsProveedorMov.SelectFilters.All
         .WhereFilter = clsProveedorMov.WhereFilters.TIPO_COMPRA
         .EmpresaId = clsAppInfo.EmpresaId
         .GestionId = clsAppInfo.GestionId
         .TipoCompraId = clsTipoCompra.DESCARGO_ANTICIPO
         If (.Open) Then
            While .Read

               If (.ProveedorMovDes.Contains("Pago") Or .ProveedorMovDes.Contains("Cobro")) Then
                  With oPago
                     .SelectFilter = clsPago.SelectFilters.All
                     .WhereFilter = clsPago.WhereFilters.PAGO_NRO
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .PagoNro = ToLong(getNro(oProveedorMov.ProveedorMovDes))

                     If (.Find) Then
                        With oAnticipoDet
                           .SelectFilter = clsAnticipoDet.SelectFilters.All
                           .WhereFilter = clsAnticipoDet.WhereFilters.DOCUMENTO_FECHA
                           .EmpresaId = clsAppInfo.EmpresaId
                           .GestionId = clsAppInfo.GestionId
                           .TipoCompraId = clsTipoCompra.PAGO_CREDITO
                           .DocumentoId = oPago.PagoId
                           .Fecha = ToDate(oProveedorMov.Fecha)
                           If (.Open) Then
                              While (.Read)
                                 If (.MonedaId = clsMoneda.BOLIVIANOS) Then
                                    If (.Monto = oProveedorMov.HaberBs) Then
                                       .UpdateFilter = clsAnticipoDet.UpdateFilters.All
                                       oProveedorMov.DocumentoId = .AnticipoDetId
                                       oProveedorMov.Fecha = ToDate(oProveedorMov.Fecha)
                                       oProveedorMov.Update()
                                    End If
                                 Else
                                    If (.Monto = oProveedorMov.HaberUs) Then
                                       .UpdateFilter = clsAnticipoDet.UpdateFilters.All
                                       oProveedorMov.DocumentoId = .AnticipoDetId
                                       oProveedorMov.Fecha = ToDate(oProveedorMov.Fecha)
                                       oProveedorMov.Update()
                                    End If
                                 End If
                                 .MoveNext()
                              End While
                           End If
                        End With
                     End If
                  End With

               ElseIf (.ProveedorMovDes.Contains("Venta")) Then
                  With oCompra
                     .SelectFilter = clsCompra.SelectFilters.All
                     .WhereFilter = clsCompra.WhereFilters.COMPRA_NRO
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .CompraNro = ToLong(getNro(oProveedorMov.ProveedorMovDes))

                     If (.Find) Then
                        With oAnticipoDet
                           .SelectFilter = clsAnticipoDet.SelectFilters.All
                           .WhereFilter = clsAnticipoDet.WhereFilters.DOCUMENTO_FECHA
                           .EmpresaId = clsAppInfo.EmpresaId
                           .GestionId = clsAppInfo.GestionId
                           .TipoCompraId = clsTipoCompra.COMPRA
                           .DocumentoId = oPago.PagoId
                           .Fecha = ToDate(oProveedorMov.Fecha)

                           If (.Open) Then
                              While (.Read)
                                 If (.MonedaId = clsMoneda.BOLIVIANOS) Then
                                    If (.Monto = oProveedorMov.HaberBs) Then
                                       .UpdateFilter = clsAnticipoDet.UpdateFilters.All
                                       oProveedorMov.DocumentoId = .AnticipoDetId
                                       oProveedorMov.Fecha = ToDate(oProveedorMov.Fecha)
                                       oProveedorMov.Update()
                                    End If
                                 Else
                                    If (.Monto = oProveedorMov.HaberUs) Then
                                       .UpdateFilter = clsAnticipoDet.UpdateFilters.All
                                       oProveedorMov.DocumentoId = .AnticipoDetId
                                       oProveedorMov.Fecha = ToDate(oProveedorMov.Fecha)
                                       oProveedorMov.Update()
                                    End If
                                 End If
                                 .MoveNext()
                              End While
                           End If
                        End With
                     End If
                  End With
               End If

               .MoveNext()
            End While

         End If

      End With

      Me.Cursor = oCursor
   End Sub

   Private Function getNro(ByVal strProveedorMovDes As String) As String
      Dim index As Integer = strProveedorMovDes.IndexOf(".")
      Return strProveedorMovDes.Substring(index + 1).Trim
   End Function


   Private Sub ExportToExcelActiveMdiChild()
      Try
         If Not Me.ActiveMdiChild Is Nothing Then
            For Each oControl01 In Me.ActiveMdiChild.Controls
               For Each oControl02 In oControl01.Controls
                  For Each oControl03 In oControl02.Controls
                     For Each oControl04 In oControl03.Controls
                        For Each oControl05 In oControl04.Controls
                           Call ExportToExcelActiveMdiChild(oControl05)
                        Next

                        Call ExportToExcelActiveMdiChild(oControl04)
                     Next

                     Call ExportToExcelActiveMdiChild(oControl03)
                  Next

                  Call ExportToExcelActiveMdiChild(oControl02)
               Next

               Call ExportToExcelActiveMdiChild(oControl01)
            Next
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub FilterConditionActiveMdiChild()
      Try
         If Not Me.ActiveMdiChild Is Nothing Then
            For Each oControl01 In Me.ActiveMdiChild.Controls
               For Each oControl02 In oControl01.Controls
                  For Each oControl03 In oControl02.Controls
                     For Each oControl04 In oControl03.Controls
                        For Each oControl05 In oControl04.Controls
                           Call FilterConditionActiveMdiChild(oControl05)
                        Next

                        Call FilterConditionActiveMdiChild(oControl04)
                     Next

                     Call FilterConditionActiveMdiChild(oControl03)
                  Next

                  Call FilterConditionActiveMdiChild(oControl02)
               Next

               Call FilterConditionActiveMdiChild(oControl01)
            Next
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub SortKeysActiveMdiChild()
      Try
         If Not Me.ActiveMdiChild Is Nothing Then
            For Each oControl01 In Me.ActiveMdiChild.Controls
               For Each oControl02 In oControl01.Controls
                  For Each oControl03 In oControl02.Controls
                     For Each oControl04 In oControl03.Controls
                        For Each oControl05 In oControl04.Controls
                           Call SortKeysActiveMdiChild(oControl05)
                        Next

                        Call SortKeysActiveMdiChild(oControl04)
                     Next

                     Call SortKeysActiveMdiChild(oControl03)
                  Next

                  Call SortKeysActiveMdiChild(oControl02)
               Next

               Call SortKeysActiveMdiChild(oControl01)
            Next
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub ExportToExcelActiveMdiChild(ByRef oControl As Control)
      If TypeOf oControl Is Janus.Windows.GridEX.GridEX Then
         Dim sfd As New SaveFileDialog
         sfd.Title = "Export Report Document"
         sfd.AddExtension = True
         sfd.DefaultExt = "xls"
         sfd.Filter = "Microsoft Excel Files (*.xls)|*.xls"

         If sfd.ShowDialog() = DialogResult.OK Then
            Dim fs As New System.IO.FileStream(sfd.FileName, IO.FileMode.Create, IO.FileAccess.ReadWrite)
            Dim oGrid As Janus.Windows.GridEX.GridEX = CType(oControl, Janus.Windows.GridEX.GridEX)

            gexMain.GridEX = oGrid
            gexMain.Export(fs)

            fs.Close()
         End If
      End If
   End Sub

   Private Sub FilterConditionActiveMdiChild(ByRef oControl As Control)
      If TypeOf oControl Is Janus.Windows.GridEX.GridEX Then
         Dim oGrid As Janus.Windows.GridEX.GridEX = CType(oControl, Janus.Windows.GridEX.GridEX)
         Dim frm As New frmFilter

         frm.oGrid = oGrid
         frm.ShowDialog()

         If frm.Changed Then
            CType(oControl, Janus.Windows.GridEX.GridEX).RootTable.FilterCondition = frm.oFilterCondition
         End If

         frm.Dispose()
      End If
   End Sub

   Private Sub SortKeysActiveMdiChild(ByRef oControl As Control)
      If TypeOf oControl Is Janus.Windows.GridEX.GridEX Then
         Dim oGrid As Janus.Windows.GridEX.GridEX = CType(oControl, Janus.Windows.GridEX.GridEX)
         Dim frm As New frmSort

         frm.oGrid = oGrid
         frm.ShowDialog()

         If frm.Changed Then
            CType(oControl, Janus.Windows.GridEX.GridEX).RootTable.SortKeys.Clear()
            CType(oControl, Janus.Windows.GridEX.GridEX).RootTable.SortKeys.AddRange(frm.oSortKeys)
         End If

         frm.Dispose()
      End If
   End Sub

   Public Sub CloseAllMdiChild()
      For Each frm As Form In Me.MdiChildren
         frm.Close()
      Next
   End Sub

   Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
      If MessageBox.Show("¿Realmente Quiere Salir del Sistema?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
         e.Cancel = True
      End If
   End Sub

End Class
