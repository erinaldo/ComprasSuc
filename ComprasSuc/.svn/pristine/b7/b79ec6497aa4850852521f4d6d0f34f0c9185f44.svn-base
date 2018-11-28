Imports System.Data
Imports System.Data.OleDb

Public Class clsPago
   Implements IDisposable

   Private mlngPagoId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoPagoId As Long
   Private mlngPagoNro As Long
   Private mlngProveedorId As Long
   Private mstrFecha As String
   Private mstrPagoDes As String
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mdecCapital As Decimal
   Private mdecInteres As Decimal
   Private mdecMontoPag As Decimal
   Private mlngPlanRecargoId As Long
   Private mdecMontoRec As Decimal
   Private mlngPlanDescuentoId As Long
   Private mdecMontoDes As Decimal
   Private mlngPlanId As Long
   Private mbytSinFac As Byte
   Private mbytConFac As Byte
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mlngCompId As Long
   Private mlngAppId As Long
   Private mlngTipoDocumentoId As Long
   Private mlngDocumentoId As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Private moConnection As OleDbConnection
   Private moDataAdapter As OleDbDataAdapter
   Private moDataSet As DataSet
   Private mintRow As Integer
   Private mintRowsCount As Integer
   Private mintRowsMax As Integer

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property PagoId() As Long
      Get
         Return mlngPagoId
      End Get

      Set(ByVal Value As Long)
         mlngPagoId = Value
      End Set
   End Property

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get

      Set(ByVal Value As Long)
         mlngGestionId = Value
      End Set
   End Property

   Property TipoPagoId() As Long
      Get
         Return mlngTipoPagoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoPagoId = Value
      End Set
   End Property

   Property PagoNro() As Long
      Get
         Return mlngPagoNro
      End Get

      Set(ByVal Value As Long)
         mlngPagoNro = Value
      End Set
   End Property

   Property ProveedorId() As Long
      Get
         Return mlngProveedorId
      End Get

      Set(ByVal Value As Long)
         mlngProveedorId = Value
      End Set
   End Property

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
      End Set
   End Property

   Property PagoDes() As String
      Get
         Return mstrPagoDes
      End Get

      Set(ByVal Value As String)
         mstrPagoDes = Value
      End Set
   End Property

   Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
      End Set
   End Property

   Property TipoCambio() As Decimal
      Get
         Return mdecTipoCambio
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   Property Capital() As Decimal
      Get
         Return mdecCapital
      End Get

      Set(ByVal Value As Decimal)
         mdecCapital = Value
      End Set
   End Property

   Property Interes() As Decimal
      Get
         Return mdecInteres
      End Get

      Set(ByVal Value As Decimal)
         mdecInteres = Value
      End Set
   End Property

   Property MontoPag() As Decimal
      Get
         Return mdecMontoPag
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoPag = Value
      End Set
   End Property

   Property PlanRecargoId() As Long
      Get
         Return mlngPlanRecargoId
      End Get

      Set(ByVal Value As Long)
         mlngPlanRecargoId = Value
      End Set
   End Property

   Property MontoRec() As Decimal
      Get
         Return mdecMontoRec
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoRec = Value
      End Set
   End Property

   Property PlanDescuentoId() As Long
      Get
         Return mlngPlanDescuentoId
      End Get

      Set(ByVal Value As Long)
         mlngPlanDescuentoId = Value
      End Set
   End Property

   Property MontoDes() As Decimal
      Get
         Return mdecMontoDes
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoDes = Value
      End Set
   End Property

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
      End Set
   End Property

   Property SinFac() As Byte
      Get
         Return mbytSinFac
      End Get

      Set(ByVal Value As Byte)
         mbytSinFac = Value
      End Set
   End Property

   Property ConFac() As Byte
      Get
         Return mbytConFac
      End Get

      Set(ByVal Value As Byte)
         mbytConFac = Value
      End Set
   End Property

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

   Property CompId() As Long
      Get
         Return mlngCompId
      End Get

      Set(ByVal Value As Long)
         mlngCompId = Value
      End Set
   End Property

   Property AppId() As Long
      Get
         Return mlngAppId
      End Get

      Set(ByVal Value As Long)
         mlngAppId = Value
      End Set
   End Property

   Property TipoDocumentoId() As Long
      Get
         Return mlngTipoDocumentoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoDocumentoId = Value
      End Set
   End Property

   Property DocumentoId() As Long
      Get
         Return mlngDocumentoId
      End Get

      Set(ByVal Value As Long)
         mlngDocumentoId = Value
      End Set
   End Property

   Property EstadoId() As Long
      Get
         Return mlngEstadoId
      End Get

      Set(ByVal Value As Long)
         mlngEstadoId = Value
      End Set
   End Property

   '******************************************************
   ' Private Data To Concurrency Table Definition
   '******************************************************
   Property LastUpdateId() As String
      Get
         Return mstrLastUpdateId
      End Get

      Set(ByVal Value As String)
         mstrLastUpdateId = Value
      End Set
   End Property

   Property LastUpdateDate() As String
      Get
         Return mstrLastUpdateDate
      End Get

      Set(ByVal Value As String)
         mstrLastUpdateDate = Value
      End Set
   End Property

   Property ConcurrencyId() As Integer
      Get
         Return mintConcurrencyId
      End Get

      Set(ByVal Value As Integer)
         mintConcurrencyId = Value
      End Set
   End Property

   Property ConnectionString() As String
      Get
         Return mstrConnectionString
      End Get

      Set(ByVal Value As String)
         mstrConnectionString = Value
      End Set
   End Property

   Property DataSet() As DataSet
      Get
         Return moDataSet
      End Get

      Set(ByVal Value As DataSet)
         moDataSet = Value
      End Set
   End Property

   ReadOnly Property TableName() As String
      Get
         Return mstrTableName
      End Get
   End Property

   ReadOnly Property ClassName() As String
      Get
         Return mstrClassName
      End Get
   End Property

   ReadOnly Property SQL() As String
      Get
         Return mstrSQL
      End Get
   End Property

   Property RowsMax() As Integer
      Get
         Return mintRowsMax
      End Get

      Set(ByVal Value As Integer)
         mintRowsMax = Value
      End Set
   End Property

   '******************************************************
   '* The following enumerations will change for each
   '* data access class
   '******************************************************
   Public Enum SelectFilters As Byte
      All = 0
      ListBox = 1
      Grid = 2
      Report = 3
      PagoNro = 4
      FlujoCaja = 5
      GRID_IMPORT = 10
      ReportContado = 11
      AbonoProveedor = 12
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      AlmacenId = 6
      GestionId = 7
      FlujoCaja = 8
      FlujoCajaFecha = 9
      GRID_IMPORT = 10
      PAGO_NRO = 11
      AbonoProveedor = 12
      AbonoProveedorFecha = 13
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PagoId = 1
      Grid = 3
      Report = 4
      PagoDes = 5
      GRID_FECHA = 6
      ProveedorId = 7
      FechaDesc = 8
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
   End Enum

   '*********************************************************
   '* The following filters will change for each
   '* data access class
   '*********************************************************
   Private mintSelectFilter As SelectFilters
   Private mintWhereFilter As WhereFilters
   Private mintOrderByFilter As OrderByFilters
   Private mintInsertFilter As InsertFilters
   Private mintUpdateFilter As UpdateFilters
   Private mintDeleteFilter As DeleteFilters
   Private mintRowCountFilter As RowCountFilters

   Property SelectFilter() As SelectFilters
      Get
         Return mintSelectFilter
      End Get

      Set(ByVal Value As SelectFilters)
         mintSelectFilter = Value
      End Set
   End Property

   Property WhereFilter() As WhereFilters
      Get
         Return mintWhereFilter
      End Get

      Set(ByVal Value As WhereFilters)
         mintWhereFilter = Value
      End Set
   End Property

   Property OrderByFilter() As OrderByFilters
      Get
         Return mintOrderByFilter
      End Get

      Set(ByVal Value As OrderByFilters)
         mintOrderByFilter = Value
      End Set
   End Property

   Property InsertFilter() As InsertFilters
      Get
         Return mintInsertFilter
      End Get

      Set(ByVal Value As InsertFilters)
         mintInsertFilter = Value
      End Set
   End Property

   Property UpdateFilter() As UpdateFilters
      Get
         Return mintUpdateFilter
      End Get

      Set(ByVal Value As UpdateFilters)
         mintUpdateFilter = Value
      End Set
   End Property

   Property DeleteFilter() As DeleteFilters
      Get
         Return mintDeleteFilter
      End Get

      Set(ByVal Value As DeleteFilters)
         mintDeleteFilter = Value
      End Set
   End Property

   Property RowCountFilter() As RowCountFilters
      Get
         Return mintRowCountFilter
      End Get

      Set(ByVal Value As RowCountFilters)
         mintRowCountFilter = Value
      End Set
   End Property

   '************************************************************
   '* Method Name  : New()
   '* Syntax       : Constructor
   '* Parameters   : None
   '*
   '* Description  : This event is called when the object is created.
   '* It can be used to initialize private data variables.
   '*
   '************************************************************
   Public Sub New()
      mstrTableName = "comPago"
      mstrClassName = "clsPago"

      moConnection = New OleDbConnection

      Call PropertyInit()
      Call FilterInit()
   End Sub

   Public Sub New(ByVal ConnectString As String)
      Me.New()

      mstrConnectionString = ConnectString
   End Sub

   Public Sub New(ByVal ConnectString As String, ByVal bytSelectFilter As SelectFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
   End Sub

   Public Sub New(ByVal ConnectString As String, _
                  ByVal bytSelectFilter As SelectFilters, _
                  ByVal bytWhereFilter As WhereFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
      mintWhereFilter = bytWhereFilter
   End Sub

   Public Sub New(ByVal ConnectString As String, _
                  ByVal bytSelectFilter As SelectFilters, _
                  ByVal bytWhereFilter As WhereFilters, _
                  ByVal bytOrderByFilter As OrderByFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
      mintWhereFilter = bytWhereFilter
      mintOrderByFilter = bytOrderByFilter
   End Sub

   Public Sub PropertyInit()
      mlngPagoId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoPagoId = 0
      mlngPagoNro = 0
      mlngProveedorId = 0
      mstrFecha = ""
      mstrPagoDes = ""
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mdecCapital = 0
      mdecInteres = 0
      mdecMontoPag = 0
      mlngPlanRecargoId = 0
      mdecMontoRec = 0
      mlngPlanDescuentoId = 0
      mdecMontoDes = 0
      mlngPlanId = 0
      mbytSinFac = 0
      mbytConFac = 0
      mlngCentroCostoId = 0
      mlngSucursalId = 0
      mlngCompId = 0
      mlngAppId = 0
      mlngTipoDocumentoId = 0
      mlngDocumentoId = 0
      mlngEstadoId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    comPago.PagoId,  "
            strSQL &= "    comPago.EmpresaId,  "
            strSQL &= "    comPago.GestionId,  "
            strSQL &= "    comPago.TipoPagoId,  "
            strSQL &= "    comPago.PagoNro,  "
            strSQL &= "    comPago.ProveedorId,  "
            strSQL &= "    comPago.Fecha,  "
            strSQL &= "    comPago.PagoDes,  "
            strSQL &= "    comPago.MonedaId,  "
            strSQL &= "    comPago.TipoCambio,  "
            strSQL &= "    comPago.Capital,  "
            strSQL &= "    comPago.Interes,  "
            strSQL &= "    comPago.MontoPag,  "
            strSQL &= "    comPago.PlanRecargoId,  "
            strSQL &= "    comPago.MontoRec,  "
            strSQL &= "    comPago.PlanDescuentoId,  "
            strSQL &= "    comPago.MontoDes,  "
            strSQL &= "    comPago.PlanId,  "
            strSQL &= "    comPago.SinFac,  "
            strSQL &= "    comPago.ConFac,  "
            strSQL &= "    comPago.CentroCostoId,  "
            strSQL &= "    comPago.SucursalId,  "
            strSQL &= "    comPago.CompId,  "
            strSQL &= "    comPago.AppId,  "
            strSQL &= "    comPago.TipoDocumentoId,  "
            strSQL &= "    comPago.DocumentoId,  "
            strSQL &= "    comPago.EstadoId,  "
            strSQL &= "    comPago.sLastUpdate_id,  "
            strSQL &= "    comPago.dtLastUpdate_dt,  "
            strSQL &= "    comPago.iConcurrency_id  "
            strSQL &= " FROM comPago "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comPago.PagoId  "
            strSQL &= " FROM comPago "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            If mintRowsMax > 0 Then strSQL &= " TOP " & NumberToField(mintRowsMax) & "  "
            strSQL &= "    comPago.PagoId,  "
            strSQL &= "    comPago.EmpresaId,  "
            strSQL &= "    comPago.GestionId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comPago.PagoNro,  "
            strSQL &= "    comPago.Fecha,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    ' ' As CompraNro,  "
            strSQL &= "    ' ' As CreditoNro,  "
            strSQL &= "    comPago.PagoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPago.TipoCambio,  "
            strSQL &= "    comPago.Capital,  "
            strSQL &= "    comPago.Interes,  "
            strSQL &= "    comPago.MontoPag,  "
            strSQL &= "    comPlanRecargo.PlanRecargoId,  "
            strSQL &= "    comPlanRecargo.PlanRecargoDes,  "
            strSQL &= "    comPago.MontoRec,  "
            strSQL &= "    comPlanDescuento.PlanDescuentoId,  "
            strSQL &= "    comPlanDescuento.PlanDescuentoDes,  "
            strSQL &= "    comPago.MontoDes,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    comPago.SinFac,  "
            strSQL &= "    comPago.ConFac,  "
            strSQL &= "    secUser.UserId,  "
            strSQL &= "    (secUser.FirstName+' '+secUser.LastName) As UserDes,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    secApp.AppId,  "
            strSQL &= "    secApp.AppDes,  "
            strSQL &= "    comPago.TipoDocumentoId,  "
            strSQL &= "    comPago.DocumentoId,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comPago, comTipoPago, secUser, comProveedor, tblMoneda, comPlanRecargo, comPlanDescuento, tblComp, tblTipoComp, tblEstado, tblCentroCosto, tblSucursal, secApp "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    comPago.PagoId,  "
            strSQL &= "    comPago.EmpresaId,  "
            strSQL &= "    comPago.GestionId,  "
            strSQL &= "    comPago.PagoNro,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    comPago.PagoDes,  "
            strSQL &= "    comPago.Fecha,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
                strSQL &= "    comPago.TipoCambio,  "
                strSQL &= " comPago.PlanId, "
            strSQL &= "    comPago.Capital,  "
            strSQL &= "    comPago.Interes,  "
            strSQL &= "    comPago.MontoPag,  "
            strSQL &= "    comPlanRecargo.PlanRecargoId,  "
            strSQL &= "    comPlanRecargo.PlanRecargoDes,  "
            strSQL &= "    comPago.MontoRec,  "
            strSQL &= "    comPlanDescuento.PlanDescuentoId,  "
            strSQL &= "    comPlanDescuento.PlanDescuentoDes,  "
            strSQL &= "    comPago.MontoDes,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "

            strSQL &= "    comPagoDet.PagoDetId,  "
            strSQL &= "    (comCreditoDet.Fecha) As FechaDet,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comPagoDet.CapitalOrg,  "
            strSQL &= "    comPagoDet.InteresOrg,  "
            strSQL &= "    comPagoDet.CapitalAmo,  "
            strSQL &= "    comPagoDet.InteresAmo,  "
            strSQL &= "    (comPagoDet.CapitalAmo + comPagoDet.InteresAmo) As Importe, "
            strSQL &= "    (comPagoDet.CapitalOrg - comPagoDet.CapitalAmo) As Saldo "
            strSQL &= " FROM comPago, comTipoPago, comProveedor, tblMoneda, comPlanRecargo, comPlanDescuento, tblComp, tblTipoComp, tblEstado, comPagoDet, comCompra, comCredito, comCreditoDet, tblSucursal "

         Case SelectFilters.PagoNro
            strSQL = " SELECT  "
            strSQL &= "    comPago.PagoId,  "
            strSQL &= "    comPago.PagoNro  "
            strSQL &= " FROM comPago "

         Case SelectFilters.FlujoCaja
            strSQL = " SELECT  "
            strSQL &= "    comPago.ProveedorId,  "
            strSQL &= "    comPago.MonedaId,  "
            strSQL &= "    comPago.TipoPagoId,  "
            strSQL &= "    comPago.TipoCambio,  "
            strSQL &= "    comPago.Capital,  "
            strSQL &= "    comPago.Interes,  "
            strSQL &= "    comPago.MontoPag "
            strSQL &= " FROM comPago "

         Case SelectFilters.GRID_IMPORT
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comPago.PagoId,  "
            strSQL &= "    comPago.EmpresaId,  "
            strSQL &= "    comPago.GestionId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comPago.PagoNro,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    comPago.PagoDes,  "
            strSQL &= "    comPago.Fecha,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPago.TipoCambio,  "
            strSQL &= "    comPago.Capital,  "
            strSQL &= "    comPago.Interes,  "
            strSQL &= "    comPago.MontoPag,  "
            strSQL &= "    comPlanRecargo.PlanRecargoId,  "
            strSQL &= "    comPlanRecargo.PlanRecargoDes,  "
            strSQL &= "    comPago.MontoRec,  "
            strSQL &= "    comPlanDescuento.PlanDescuentoId,  "
            strSQL &= "    comPlanDescuento.PlanDescuentoDes,  "
            strSQL &= "    comPago.MontoDes,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.TipoPlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    comPago.SinFac,  "
            strSQL &= "    comPago.ConFac,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    CONVERT(bit, 0) As RowImport  "
            strSQL &= " FROM comPago, comTipoPago, comProveedor, tblMoneda, comPlanRecargo, comPlanDescuento, tblComp, tblTipoComp, tblEstado, tblPlan, tblSucursal "

         Case SelectFilters.ReportContado
            strSQL = " SELECT  "
            strSQL &= "    comPago.PagoId,  "
            strSQL &= "    comPago.EmpresaId,  "
            strSQL &= "    comPago.GestionId,  "
            strSQL &= "    comPago.PagoNro,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    comPago.PagoDes,  "
            strSQL &= "    comPago.Fecha,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPago.TipoCambio,  "
            strSQL &= "    comPago.Capital,  "
            strSQL &= "    comPago.Interes,  "
                strSQL &= "    comPago.MontoPag,  "
                strSQL &= "    comPago.PlanId,  "
            strSQL &= "    comPlanRecargo.PlanRecargoId,  "
            strSQL &= "    comPlanRecargo.PlanRecargoDes,  "
            strSQL &= "    comPago.MontoRec,  "
            strSQL &= "    comPlanDescuento.PlanDescuentoId,  "
            strSQL &= "    comPlanDescuento.PlanDescuentoDes,  "
            strSQL &= "    comPago.MontoDes,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "

            strSQL &= "    comPagoDet.PagoDetId,  "
            strSQL &= "    (comCompra.Fecha) As FechaDet,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comPagoDet.CapitalOrg,  "
            strSQL &= "    comPagoDet.InteresOrg,  "
            strSQL &= "    comPagoDet.CapitalAmo,  "
            strSQL &= "    comPagoDet.InteresAmo,  "
            strSQL &= "    (comPagoDet.CapitalAmo + comPagoDet.InteresAmo) As Importe, "
            strSQL &= "    (comPagoDet.CapitalOrg - comPagoDet.CapitalAmo) As Saldo "
            strSQL &= " FROM comPago, comTipoPago, comProveedor, tblMoneda, comPlanRecargo, comPlanDescuento, tblComp, tblTipoComp, tblEstado, comPagoDet, comCompra, comCredito, comCreditoDet, tblSucursal "

         Case SelectFilters.AbonoProveedor
            strSQL = " SELECT  "
            strSQL &= "    comPago.PagoId,  "
            strSQL &= "    comPago.EmpresaId,  "
            strSQL &= "    comPago.GestionId,  "
            strSQL &= "    comPago.PagoNro,  "
            strSQL &= "    comPago.Fecha,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.ProveedorNIT,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    comPago.PagoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPago.TipoCambio,  "
            strSQL &= "    comPago.Capital,  "
            strSQL &= "    comPago.Interes,  "
            strSQL &= "    comPago.MontoPag,  "
            strSQL &= "    comPago.MontoRec,  "
            strSQL &= "    comPago.MontoDes,  "
            strSQL &= "    comPago.CompId,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    comProveedor.BancoId,  "
            strSQL &= "    comProveedor.NroCuenta,  "
            strSQL &= "    comProveedor.MonedaIdCuenta,  "
            strSQL &= "    comProveedor.TipoDocIdentidadId  "
            strSQL &= " FROM comPago, comTipoPago, comProveedor, tblCentroCosto, tblMoneda "

      End Select

      strSQL &= WhereFilterGet()

      strSQL &= OrderByFilterGet()

      mstrSQL = strSQL

      Return strSQL
   End Function

   Private Function WhereFilterGet() As String
      Dim strSQL As String

      Select Case mintWhereFilter
         Case WhereFilters.PrimaryKey
            strSQL = " WHERE  comPago.PagoId = " & NumberToField(mlngPagoId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPago.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comPago.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comPago.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPago.PlanRecargoId = comPlanRecargo.PlanRecargoId "
            strSQL &= " AND  comPago.PlanDescuentoId = comPlanDescuento.PlanDescuentoId "
            strSQL &= " AND  comPago.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comPago.sLastUpdate_id = secUser.LoginId "
            strSQL &= " AND  secUser.AppId = " & NumberToField(clsAppInfo.AppId)
            strSQL &= " AND  comPago.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comPago.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comPago.AppId = secApp.AppId "
            strSQL &= " AND  comPago.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GRID_IMPORT
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPago.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comPago.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comPago.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPago.PlanRecargoId = comPlanRecargo.PlanRecargoId "
            strSQL &= " AND  comPago.PlanDescuentoId = comPlanDescuento.PlanDescuentoId "
            strSQL &= " AND  comPago.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comPago.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comPago.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comPago.PlanId = tblPlan.PlanId  "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.PagoId = " & NumberToField(mlngPagoId)
            strSQL &= " AND  comPago.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comPago.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comPago.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPago.PlanRecargoId = comPlanRecargo.PlanRecargoId "
            strSQL &= " AND  comPago.PlanDescuentoId = comPlanDescuento.PlanDescuentoId "
            strSQL &= " AND  comPago.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comPago.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comPago.PagoId = comPagoDet.PagoId "
            strSQL &= " AND  comPagoDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comPagoDet.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comPagoDet.CreditoDetId = comCreditoDet.CreditoDetId "
            strSQL &= " AND  comPago.SucursalId = tblSucursal.SucursalId "

         Case WhereFilters.AlmacenId

         Case WhereFilters.GestionId
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.FlujoCaja
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPago.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoPagoId <> 0 Then
               strSQL &= " AND  comPago.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPago.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPago.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comPago.EstadoId <> 12 "
            strSQL &= " AND  comPago.EstadoId <> 0 "

         Case WhereFilters.FlujoCajaFecha
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPago.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoPagoId <> 0 Then
               strSQL &= " AND  comPago.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPago.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPago.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comPago.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comPago.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  comPago.EstadoId <> 12 "
            strSQL &= " AND  comPago.EstadoId <> 0 "

         Case WhereFilters.PAGO_NRO
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPago.PagoNro = " & NumberToField(mlngPagoNro)

         Case WhereFilters.AbonoProveedor
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPago.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoPagoId <> 0 Then
               strSQL &= " AND  comPago.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPago.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPago.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            If mlngPlanRecargoId <> 0 Then
               If mlngPlanRecargoId = 1 Then ''Mismo Banco
                  strSQL &= " AND  comProveedor.BancoId = " & NumberToField(mlngPagoNro) 'BancoId
               Else ''Otros Bancos
                  strSQL &= " AND  comProveedor.BancoId <> " & NumberToField(mlngPagoNro) 'BancoId
               End If
            End If

            strSQL &= " AND  comProveedor.BancoId <> 0"

            If mlngPlanDescuentoId <> 0 Then
               strSQL &= " AND  comProveedor.MonedaIdCuenta = " & NumberToField(mlngPlanDescuentoId) 'BancoId
            End If

            strSQL &= " AND  comPago.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comPago.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comPago.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPago.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comPago.EstadoId <> 12 "
            strSQL &= " AND  comPago.EstadoId <> 0 "

         Case WhereFilters.AbonoProveedorFecha
            strSQL = " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPago.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoPagoId <> 0 Then
               strSQL &= " AND  comPago.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPago.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPago.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            If mlngPlanRecargoId <> 0 Then
               If mlngPlanRecargoId = 1 Then ''Mismo Banco
                  strSQL &= " AND  comProveedor.BancoId = " & NumberToField(mlngPagoNro) 'BancoId
               Else ''Otros Bancos
                  strSQL &= " AND  comProveedor.BancoId <> " & NumberToField(mlngPagoNro) 'BancoId
               End If
            End If

            strSQL &= " AND  comProveedor.BancoId <> 0"

            If mlngPlanDescuentoId <> 0 Then
               strSQL &= " AND  comProveedor.MonedaIdCuenta = " & NumberToField(mlngPlanDescuentoId) 'BancoId
            End If

            strSQL &= " AND  comPago.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comPago.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comPago.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPago.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comPago.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comPago.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  comPago.EstadoId <> 12 "
            strSQL &= " AND  comPago.EstadoId <> 0 "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PagoId
            strSQL = " ORDER BY comPago.PagoId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comPago.PagoId DESC "

         Case OrderByFilters.PagoDes
            strSQL = " ORDER BY comPago.PagoDes "

         Case OrderByFilters.Report

         Case OrderByFilters.GRID_FECHA
            strSQL = " ORDER BY comPago.Fecha, comPago.PagoId "

         Case OrderByFilters.ProveedorId
            strSQL = " ORDER BY comPago.ProveedorId "

         Case OrderByFilters.FechaDesc
            strSQL = " ORDER BY comPago.Fecha Desc "

      End Select

      Return strSQL
   End Function

   Private Function RowCountSQL() As String
      Dim strSQL As String

      Select Case mintRowCountFilter
         Case RowCountFilters.All
            strSQL = "SELECT Count(*) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO comPago ("
            strSQL &= "PagoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoPagoId, "
            strSQL &= "PagoNro, "
            strSQL &= "ProveedorId, "
            strSQL &= "Fecha, "
            strSQL &= "PagoDes, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "Capital, "
            strSQL &= "Interes, "
            strSQL &= "MontoPag, "
            strSQL &= "PlanRecargoId, "
            strSQL &= "MontoRec, "
            strSQL &= "PlanDescuentoId, "
            strSQL &= "MontoDes, "
            strSQL &= "PlanId, "
            strSQL &= "SinFac, "
            strSQL &= "ConFac, "
            strSQL &= "CentroCostoId, "
            strSQL &= "SucursalId, "
            strSQL &= "CompId, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPagoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoPagoId) & ", "
            strSQL &= NumberToField(mlngPagoNro) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= StringToField(mstrPagoDes, 1000) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= DecimalToField(mdecCapital) & ", "
            strSQL &= DecimalToField(mdecInteres) & ", "
            strSQL &= DecimalToField(mdecMontoPag) & ", "
            strSQL &= NumberToField(mlngPlanRecargoId) & ", "
            strSQL &= DecimalToField(mdecMontoRec) & ", "
            strSQL &= NumberToField(mlngPlanDescuentoId) & ", "
            strSQL &= DecimalToField(mdecMontoDes) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mbytSinFac) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= NumberToField(mlngDocumentoId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comPago SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoPagoId = " & NumberToField(mlngTipoPagoId) & ", "
            strSQL &= "PagoNro = " & NumberToField(mlngPagoNro) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "PagoDes = " & StringToField(mstrPagoDes, 1000) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "Capital = " & DecimalToField(mdecCapital) & ", "
            strSQL &= "Interes = " & DecimalToField(mdecInteres) & ", "
            strSQL &= "MontoPag = " & DecimalToField(mdecMontoPag) & ", "
            strSQL &= "PlanRecargoId = " & NumberToField(mlngPlanRecargoId) & ", "
            strSQL &= "MontoRec = " & DecimalToField(mdecMontoRec) & ", "
            strSQL &= "PlanDescuentoId = " & NumberToField(mlngPlanDescuentoId) & ", "
            strSQL &= "MontoDes= " & DecimalToField(mdecMontoDes) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "SinFac = " & NumberToField(mbytSinFac) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PagoId = " & NumberToField(mlngPagoId) & " "

      End Select

      Return strSQL
   End Function

   Private Function DeleteSQL() As String
      Dim strSQL As String

      Select Case mintDeleteFilter
         Case DeleteFilters.All
            strSQL = "DELETE FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Sub Retrieve(ByVal oDataRow As DataRow)
      Try
         Call PropertyInit()

         Select Case mintSelectFilter
            Case SelectFilters.All
               mlngPagoId = ToLong(oDataRow("PagoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoPagoId = ToLong(oDataRow("TipoPagoId"))
               mlngPagoNro = ToLong(oDataRow("PagoNro"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mstrPagoDes = ToStr(oDataRow("PagoDes"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mdecCapital = ToDecimal(oDataRow("Capital"))
               mdecInteres = ToDecimal(oDataRow("Interes"))
               mdecMontoPag = ToDecimal(oDataRow("MontoPag"))
               mlngPlanRecargoId = ToLong(oDataRow("PlanRecargoId"))
               mdecMontoRec = ToDecimal(oDataRow("MontoRec"))
               mlngPlanDescuentoId = ToLong(oDataRow("PlanDescuentoId"))
               mdecMontoDes = ToDecimal(oDataRow("MontoDes"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mbytSinFac = ToBoolean(oDataRow("SinFac"))
               mbytConFac = ToBoolean(oDataRow("ConFac"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPagoId = ToLong(oDataRow("PagoId"))

            Case SelectFilters.PagoNro
               mlngPagoId = ToLong(oDataRow("PagoId"))
               mlngPagoNro = ToLong(oDataRow("PagoNro"))

            Case SelectFilters.FlujoCaja
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngTipoPagoId = ToLong(oDataRow("TipoPagoId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mdecCapital = ToDecimal(oDataRow("Capital"))
               mdecInteres = ToDecimal(oDataRow("Interes"))
               mdecMontoPag = ToDecimal(oDataRow("MontoPag"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPagoId = TableIDGet(mstrTableName, "PagoId", moConnection)

         If mlngPagoId = -1 Then
            Throw New Exception("No se puede generar un identificador unico para esta tabla: " & mstrTableName)
         Else
            GetNewPrimaryKey = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Validate() As Boolean
      Dim strMsg As String = String.Empty

      If mlngEmpresaId = 0 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      If mlngSucursalId <= 0 Then
         strMsg &= "Sucursal Inválido" & vbCrLf
      End If

      If mlngProveedorId = 0 Then
         strMsg &= "Proveedor Inválido" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If mdecTipoCambio <= 0 Then
         strMsg &= "Tipo Cambio Inválido" & vbCrLf
      End If

      If mdecCapital <= 0 Then
         strMsg &= "Capital Inválido" & vbCrLf
      End If

      'If mdecMontoPag <= 0 Then
      '   strMsg &= "Monto Pagado Inválido" & vbCrLf
      'End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         Validate = False
      Else
         Validate = True
      End If
   End Function

   Public Function NoDuplicates(ByVal boolReplace As Boolean) As Boolean
      Dim strSQL As String
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM comPago "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)
         'Else
         '   strSQL &= " WHERE  comPago.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comPago.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  comPago.PagoId <> " & NumberToField(mlngPagoId)
         'End If

         If strSQL <> "" Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = strSQL
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteScalar

            If intRecordsAffected = 0 Then
               NoDuplicates = True
            Else
               NoDuplicates = False
            End If
         Else
            NoDuplicates = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Open() As Boolean
      Try
         Open = False

         Call OpenConection()

         moDataSet = New DataSet

         moDataAdapter = New OleDbDataAdapter(SelectSQL, moConnection)

         moDataAdapter.Fill(moDataSet, mstrTableName)

         moDataAdapter.Dispose()

         mintRow = 0
         mintRowsCount = moDataSet.Tables(mstrTableName).Rows.Count()

         Open = True

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Read() As Boolean
      Dim oDataRow As Data.DataRow

      Read = False

      Try
         If mintRowsCount > 0 Then
            If mintRow <= mintRowsCount - 1 Then
               oDataRow = moDataSet.Tables(mstrTableName).Rows(mintRow)

               Call Retrieve(oDataRow)
               Read = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Find() As Boolean
      Find = False

      Try
         If Open() Then
            If Read() Then
               Find = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function FindByPK() As Boolean
      FindByPK = False

      Try
         mintSelectFilter = SelectFilters.All
         mintWhereFilter = WhereFilters.PrimaryKey
         mintOrderByFilter = OrderByFilters.None

         If Open() Then
            If Read() Then
               FindByPK = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Sub MoveNext()
      If mintRowsCount > 0 Then
         If mintRow < mintRowsCount Then
            mintRow += 1
         End If
      End If
   End Sub

   Public Sub MovePrevious()
      If mintRowsCount > 0 Then
         If mintRow > 0 Then
            mintRow -= 1
         End If
      End If
   End Sub

   Public Sub MoveFirst()
      If mintRowsCount > 0 Then
         mintRow = 0
      End If
   End Sub

   Public Sub MoveLast()
      If mintRowsCount > 0 Then
         mintRow = mintRowsCount - 1
      End If
   End Sub

   Public Function Insert() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Insert = False

      Try
         If Validate() Then
            If NoDuplicates(False) Then
               If GetNewPrimaryKey() Then
                  Call OpenConection()

                  oCommand = New OleDbCommand
                  oCommand.CommandText = InsertSQL()
                  oCommand.Connection = moConnection

                  intRecordsAffected = oCommand.ExecuteNonQuery()

                  If intRecordsAffected > 0 Then
                     Insert = True
                  End If
               End If
            Else
               Throw New Exception("Registro Duplicado")
               Return False
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Update() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Update = False

      Try
         If Validate() Then
            If NoDuplicates(True) Then
               Call OpenConection()

               oCommand = New OleDbCommand
               oCommand.CommandText = UpdateSQL()
               oCommand.Connection = moConnection

               intRecordsAffected = oCommand.ExecuteNonQuery()

               If intRecordsAffected > 0 Then
                  Update = True
               End If
            Else
               Throw New Exception("Registro Duplicado")
               Return False
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Delete() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Delete = False

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = DeleteSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = oCommand.ExecuteNonQuery()

         If intRecordsAffected > 0 Then
            Delete = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function RowCount() As Integer
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowCountSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = CInt(oCommand.ExecuteScalar)

         Return intRecordsAffected

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Sub FilterInit()
      mintWhereFilter = 0
      mintOrderByFilter = 0
      mintSelectFilter = 0
      mintInsertFilter = 0
      mintUpdateFilter = 0
      mintDeleteFilter = 0
      mintRowCountFilter = 0
   End Sub

   Private Sub OpenConection()
      If moConnection.State = ConnectionState.Closed Then
         moConnection = New OleDbConnection(mstrConnectionString)
         moConnection.Open()
      End If
   End Sub

   Public Sub CloseConection()
      If moConnection.State = ConnectionState.Open Then
         moConnection.Close()
      End If
   End Sub

   Overridable Sub Dispose() Implements IDisposable.Dispose
      Call CloseConection()
   End Sub

End Class
