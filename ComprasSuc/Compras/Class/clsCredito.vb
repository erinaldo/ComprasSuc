Imports System.Data
Imports System.Data.OleDb

Public Class clsCredito
   Implements IDisposable

   Private mlngCreditoId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngCompraId As Long
   Private mlngTipoCreditoId As Long
   Private mlngCreditoNro As Long
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mlngProveedorId As Long
   Private mstrCreditoDes As String
   Private mlngFrecuenciaId As Long
   Private mlngFrecuenciaNro As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mstrCreditoOrden As String
   Private mdecMontoLiq As Decimal
   Private mdecMontoAmo As Decimal
   Private mlngCantidadCuota As Long
   Private mdecMontoCuota As Decimal
   Private mdecInteresAnual As Decimal
   Private mbytSaldoIni As Byte
   Private mbytConFac As Byte
   Private mbytSinFac As Byte
   Private mlngCentroCostoId As Long
   Private mlngCreditoIdOrg As Long
   Private mlngSucursalId As Long
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
   Property CreditoId() As Long
      Get
         Return mlngCreditoId
      End Get

      Set(ByVal Value As Long)
         mlngCreditoId = Value
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

   Property CompraId() As Long
      Get
         Return mlngCompraId
      End Get

      Set(ByVal Value As Long)
         mlngCompraId = Value
      End Set
   End Property

   Property TipoCreditoId() As Long
      Get
         Return mlngTipoCreditoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCreditoId = Value
      End Set
   End Property

   Property CreditoNro() As Long
      Get
         Return mlngCreditoNro
      End Get

      Set(ByVal Value As Long)
         mlngCreditoNro = Value
      End Set
   End Property

   Property FechaIni() As String
      Get
         Return mstrFechaIni
      End Get

      Set(ByVal Value As String)
         mstrFechaIni = Value
      End Set
   End Property

   Property FechaFin() As String
      Get
         Return mstrFechaFin
      End Get

      Set(ByVal Value As String)
         mstrFechaFin = Value
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

   Property CreditoDes() As String
      Get
         Return mstrCreditoDes
      End Get

      Set(ByVal Value As String)
         mstrCreditoDes = Value
      End Set
   End Property

   Property FrecuenciaId() As Long
      Get
         Return mlngFrecuenciaId
      End Get

      Set(ByVal Value As Long)
         mlngFrecuenciaId = Value
      End Set
   End Property

   Property FrecuenciaNro() As Long
      Get
         Return mlngFrecuenciaNro
      End Get

      Set(ByVal Value As Long)
         mlngFrecuenciaNro = Value
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

   Property CreditoOrden() As String
      Get
         Return mstrCreditoOrden
      End Get

      Set(ByVal Value As String)
         mstrCreditoOrden = Value
      End Set
   End Property

   Property MontoLiq() As Decimal
      Get
         Return mdecMontoLiq
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoLiq = Value
      End Set
   End Property

   Property MontoAmo() As Decimal
      Get
         Return mdecMontoAmo
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoAmo = Value
      End Set
   End Property

   Property CantidadCuota() As Long
      Get
         Return mlngCantidadCuota
      End Get

      Set(ByVal Value As Long)
         mlngCantidadCuota = Value
      End Set
   End Property

   Property MontoCuota() As Decimal
      Get
         Return mdecMontoCuota
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoCuota = Value
      End Set
   End Property

   Property InteresAnual() As Decimal
      Get
         Return mdecInteresAnual
      End Get

      Set(ByVal Value As Decimal)
         mdecInteresAnual = Value
      End Set
   End Property

   Property SaldoIni() As Byte
      Get
         Return mbytSaldoIni
      End Get

      Set(ByVal Value As Byte)
         mbytSaldoIni = Value
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

   Property SinFac() As Byte
      Get
         Return mbytSinFac
      End Get

      Set(ByVal Value As Byte)
         mbytSinFac = Value
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

   Property CreditoIdOrg() As Long
      Get
         Return mlngCreditoIdOrg
      End Get

      Set(ByVal Value As Long)
         mlngCreditoIdOrg = Value
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
      Grid = 1
      GridIni = 2
      Report = 3
      GRID_IMPORT = 4
      Flujocaja = 5
      SucursalDistinct = 6
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      GridIni = 4
      Report = 5
      EmpresaId = 6
      CompraId = 7
      GestionId = 8
      EstadoId = 9
      GestionMov = 10
      ProveedorId = 11
      CREDITO_NRO = 12
      GRID_IMPORT = 13
      FlujoCaja = 14
      FlujoCajaFecha = 15
      FlujoCajaSaldoIniAnt_Fecha = 16
      SucursalDistinct = 17
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CreditoId = 1
      Grid = 3
      Report = 4
      GRID_FECHA = 5
      CREDITO_NRO = 6
      ProveedorId = 7
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
      mstrTableName = "comCredito"
      mstrClassName = "clsCredito"

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
      mlngCreditoId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngCompraId = 0
      mlngTipoCreditoId = 0
      mlngCreditoNro = 0
      mstrFechaIni = ""
      mstrFechaFin = ""
      mlngProveedorId = 0
      mstrCreditoDes = ""
      mlngFrecuenciaId = 0
      mlngFrecuenciaNro = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mstrCreditoOrden = ""
      mdecMontoLiq = 0
      mdecMontoAmo = 0
      mlngCantidadCuota = 0
      mdecMontoCuota = 0
      mdecInteresAnual = 0
      mbytSaldoIni = 0
      mbytSinFac = 0
      mbytConFac = 0
      mlngCentroCostoId = 0
      mlngCreditoIdOrg = 0
      mlngSucursalId = 0
      mlngEstadoId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT "
            strSQL &= " comCredito.CreditoId, "
            strSQL &= " comCredito.EmpresaId, "
            strSQL &= " comCredito.GestionId, "
            strSQL &= " comCredito.CompraId, "
            strSQL &= " comCredito.TipoCreditoId, "
            strSQL &= " comCredito.CreditoNro, "
            strSQL &= " comCredito.FechaIni, "
            strSQL &= " comCredito.FechaFin, "
            strSQL &= " comCredito.ProveedorId, "
            strSQL &= " comCredito.CreditoDes, "
            strSQL &= " comCredito.FrecuenciaId, "
            strSQL &= " comCredito.FrecuenciaNro, "
            strSQL &= " comCredito.MonedaId, "
            strSQL &= " comCredito.TipoCambio, "
            strSQL &= " comCredito.CreditoOrden, "
            strSQL &= " comCredito.MontoLiq, "
            strSQL &= " comCredito.MontoAmo, "
            strSQL &= " comCredito.CantidadCuota, "
            strSQL &= " comCredito.MontoCuota, "
            strSQL &= " comCredito.InteresAnual, "
            strSQL &= " comCredito.SaldoIni, "
            strSQL &= " comCredito.SinFac, "
            strSQL &= " comCredito.ConFac, "
            strSQL &= " comCredito.CentroCostoId, "
            strSQL &= " comCredito.CreditoIdOrg, "
            strSQL &= " comCredito.SucursalId, "
            strSQL &= " comCredito.EstadoId, "
            strSQL &= " comCredito.sLastUpdate_id, "
            strSQL &= " comCredito.dtLastUpdate_dt, "
            strSQL &= " comCredito.iConcurrency_id "
            strSQL &= " FROM comCredito "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            If mintRowsMax > 0 Then strSQL &= " TOP " & NumberToField(mintRowsMax) & "  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.EmpresaId,  "
            strSQL &= "    comCredito.CompraId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCredito.FechaIni,  "
            strSQL &= "    comTipoCredito.TipoCreditoId,  "
            strSQL &= "    comTipoCredito.TipoCreditoDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCredito.CreditoDes,  "
            strSQL &= "    comFrecuencia.FrecuenciaId,  "
            strSQL &= "    comFrecuencia.FrecuenciaDes,  "
            strSQL &= "    comCredito.FrecuenciaNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCredito.TipoCambio,  "
            strSQL &= "    comCredito.MontoLiq,  "
            strSQL &= "    comCredito.MontoAmo,  "
            strSQL &= "    comCredito.CantidadCuota,  "
            strSQL &= "    comCredito.MontoCuota,  "
            strSQL &= "    comCredito.InteresAnual,  "
            strSQL &= "    comCredito.FechaFin,  "
            strSQL &= "    comCredito.SinFac,  "
            strSQL &= "    comCredito.ConFac,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comCredito, comTipoCredito, comProveedor, comCompra, comFrecuencia, tblMoneda, tblEstado, tblCentroCosto, tblSucursal "

         Case SelectFilters.GridIni
            strSQL = " SELECT  "
            If mintRowsMax > 0 Then strSQL &= " TOP " & NumberToField(mintRowsMax) & "  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCredito.FechaIni,  "
            strSQL &= "    comTipoCredito.TipoCreditoId,  "
            strSQL &= "    comTipoCredito.TipoCreditoDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comCredito.CreditoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCredito.TipoCambio,  "
            strSQL &= "    comCredito.MontoLiq,  "
            strSQL &= "    comCredito.MontoAmo,  "
            strSQL &= "    comCredito.CantidadCuota,  "
            strSQL &= "    comCredito.InteresAnual,  "
            strSQL &= "    comCredito.MontoCuota,  "
            strSQL &= "    comCredito.FechaFin,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comCredito, comTipoCredito, comProveedor, tblMoneda, tblEstado, tblCentroCosto, tblSucursal "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.EmpresaId,  "
            strSQL &= "    comCredito.CompraId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCredito.FechaIni,  "
            strSQL &= "    comTipoCredito.TipoCreditoId,  "
            strSQL &= "    comTipoCredito.TipoCreditoDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comCredito.CreditoDes,  "
            strSQL &= "    comFrecuencia.FrecuenciaId,  "
            strSQL &= "    comFrecuencia.FrecuenciaDes,  "
            strSQL &= "    comCredito.FrecuenciaNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCredito.TipoCambio,  "
            strSQL &= "    comCredito.MontoLiq,  "
            strSQL &= "    comCredito.MontoAmo,  "
            strSQL &= "    comCredito.CantidadCuota,  "
            strSQL &= "    comCredito.MontoCuota,  "
            strSQL &= "    comCredito.InteresAnual,  "
            strSQL &= "    comCredito.FechaFin,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "

            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comCreditoDet.Fecha,  "
            strSQL &= "    comCreditoDet.Capital,  "
            strSQL &= "    comCreditoDet.Interes,  "
            strSQL &= "    comCreditoDet.Importe,  "
            strSQL &= "    comCreditoDet.CapitalAmo,  "
            strSQL &= "    comCreditoDet.InteresAmo,  "
            strSQL &= "    tblEstadoDet.EstadoId As EstadoIdDet,  "
            strSQL &= "    tblEstadoDet.EstadoDes As EstadoDesDet  "

            strSQL &= " FROM comCredito, comTipoCredito, comProveedor, comFrecuencia, tblMoneda, tblEstado, comCreditoDet, tblEstado As tblEstadoDet, tblSucursal "

         Case SelectFilters.GRID_IMPORT
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCredito.FechaIni,  "
            strSQL &= "    comTipoCredito.TipoCreditoId,  "
            strSQL &= "    comTipoCredito.TipoCreditoDes,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comFrecuencia.FrecuenciaId,  "
            strSQL &= "    comFrecuencia.FrecuenciaDes,  "
            strSQL &= "    comCredito.FrecuenciaNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCredito.TipoCambio,  "
            strSQL &= "    comCredito.MontoLiq,  "
            strSQL &= "    comCredito.MontoAmo,  "
            strSQL &= "    comCredito.CantidadCuota,  "
            strSQL &= "    comCredito.MontoCuota,  "
            strSQL &= "    comCredito.InteresAnual,  "
            strSQL &= "    comCredito.FechaFin,  "
            strSQL &= "    comCredito.SinFac,  "
            strSQL &= "    comCredito.ConFac,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    CONVERT(bit, 0) As RowImport  "
            strSQL &= " FROM comCredito, comTipoCredito, comProveedor, comFrecuencia, tblMoneda, tblEstado, comCompra, tblSucursal "

         Case SelectFilters.Flujocaja
            strSQL = " SELECT  "
            strSQL &= "    comCredito.ProveedorId,  "
            strSQL &= "    comCredito.MonedaId,  "
            strSQL &= "    comCredito.TipoCreditoId,  "
            strSQL &= "    comCredito.TipoCambio,  "
            strSQL &= "    comCredito.MontoLiq,  "
            strSQL &= "    comCredito.MontoAmo  "
            strSQL &= " FROM comCredito "

         Case SelectFilters.SucursalDistinct
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comCompra.SucursalId  "
            strSQL &= " FROM comCompra "

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
            strSQL = " WHERE  comCredito.CreditoId = " & NumberToField(mlngCreditoId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.SaldoIni = " & NumberToField(mbytSaldoIni)
            strSQL &= " AND  comCredito.TipoCreditoId = comTipoCredito.TipoCreditoId "
            strSQL &= " AND  comCredito.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCredito.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCredito.FrecuenciaId = comFrecuencia.FrecuenciaId "
            strSQL &= " AND  comCredito.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCredito.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comCredito.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCredito.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GridIni
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.SaldoIni = " & NumberToField(mbytSaldoIni)
            strSQL &= " AND  comCredito.TipoCreditoId = comTipoCredito.TipoCreditoId "
            strSQL &= " AND  comCredito.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCredito.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCredito.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comCredito.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCredito.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comCredito.TipoCreditoId = comTipoCredito.TipoCreditoId "
            strSQL &= " AND  comCredito.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCredito.FrecuenciaId = comFrecuencia.FrecuenciaId "
            strSQL &= " AND  comCredito.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCredito.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comCredito.CreditoId = comCreditoDet.CreditoId "
            strSQL &= " AND  comCredito.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCreditoDet.EstadoId = tblEstadoDet.EstadoId "

         Case WhereFilters.CompraId
            'strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  (comCredito.CompraId = " & NumberToField(mlngCompraId)
            'strSQL &= " OR  comCredito.ProveedorId = " & NumberToField(mlngProveedorId) & ") "

         Case WhereFilters.GestionId
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.EstadoId
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCredito.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.GestionMov
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.SaldoIni = " & NumberToField(mbytSaldoIni)
            strSQL &= " AND  (comCredito.EstadoId = 14 "
            strSQL &= " OR  comCredito.EstadoId = 15) "

         Case WhereFilters.ProveedorId
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.ProveedorId = " & NumberToField(mlngProveedorId)

         Case WhereFilters.CREDITO_NRO
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.CreditoNro = " & NumberToField(mlngCreditoNro)

         Case WhereFilters.GRID_IMPORT
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.SaldoIni = " & NumberToField(mbytSaldoIni)
            strSQL &= " AND  comCredito.TipoCreditoId = comTipoCredito.TipoCreditoId "
            strSQL &= " AND  comCredito.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCredito.FrecuenciaId = comFrecuencia.FrecuenciaId "
            strSQL &= " AND  comCredito.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comCredito.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comCredito.CompraId = comCompra.CompraId "

         Case WhereFilters.CREDITO_NRO
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.CreditoNro = " & NumberToField(mlngCreditoNro)

         Case WhereFilters.FlujoCaja
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.SaldoIni = " & NumberToField(mbytSaldoIni)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCredito.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCredito.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCredito.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comCredito.EstadoId <> 12 "
            strSQL &= " AND  comCredito.EstadoId <> 0 "

         Case WhereFilters.FlujoCajaFecha
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.SaldoIni = " & NumberToField(mbytSaldoIni)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCredito.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCredito.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCredito.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comCredito.FechaIni >= " & DateToField(mstrFechaIni)
            strSQL &= " AND  comCredito.FechaIni <= " & DateToField(mstrLastUpdateDate)

            strSQL &= " AND  comCredito.EstadoId <> 12 "
            strSQL &= " AND  comCredito.EstadoId <> 0 "

         Case WhereFilters.FlujoCajaSaldoIniAnt_Fecha
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.SaldoIni = " & NumberToField(mbytSaldoIni)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCredito.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCredito.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCredito.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comCredito.FechaIni <= " & DateToField(mstrFechaIni)

            strSQL &= " AND  comCredito.EstadoId <> 12 "
            strSQL &= " AND  comCredito.EstadoId <> 0 "

         Case WhereFilters.SucursalDistinct
            strSQL = " WHERE  comCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngGestionId)
            If mlngEstadoId <> 0 Then
               strSQL &= " AND  comCompra.EstadoId = " & NumberToField(mlngEstadoId)
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CreditoId
            strSQL = " ORDER BY comCredito.CreditoId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comCredito.CreditoId DESC"

         Case OrderByFilters.Report

         Case OrderByFilters.GRID_FECHA
            strSQL = " ORDER BY comCredito.FechaIni, comCredito.CreditoId "

         Case OrderByFilters.ProveedorId
            strSQL = " ORDER BY comCredito.ProveedorId "

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
            strSQL = "INSERT INTO comCredito ("
            strSQL &= "CreditoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "CompraId, "
            strSQL &= "TipoCreditoId, "
            strSQL &= "CreditoNro, "
            strSQL &= "FechaIni, "
            strSQL &= "FechaFin, "
            strSQL &= "ProveedorId, "
            strSQL &= "CreditoDes, "
            strSQL &= "FrecuenciaId, "
            strSQL &= "FrecuenciaNro, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "CreditoOrden, "
            strSQL &= "MontoLiq, "
            strSQL &= "MontoAmo, "
            strSQL &= "CantidadCuota, "
            strSQL &= "MontoCuota, "
            strSQL &= "InteresAnual, "
            strSQL &= "SaldoIni, "
            strSQL &= "SinFac, "
            strSQL &= "ConFac, "
            strSQL &= "CentroCostoId, "
            strSQL &= "CreditoIdOrg, "
            strSQL &= "SucursalId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCreditoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngTipoCreditoId) & ", "
            strSQL &= NumberToField(mlngCreditoNro) & ", "
            strSQL &= DateToField(mstrFechaIni) & ", "
            strSQL &= DateToField(mstrFechaFin) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= StringToField(mstrCreditoDes, 1000) & ", "
            strSQL &= NumberToField(mlngFrecuenciaId) & ", "
            strSQL &= NumberToField(mlngFrecuenciaNro) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= StringToField(mstrCreditoOrden) & ", "
            strSQL &= DecimalToField(mdecMontoLiq) & ", "
            strSQL &= DecimalToField(mdecMontoAmo) & ", "
            strSQL &= NumberToField(mlngCantidadCuota) & ", "
            strSQL &= DecimalToField(mdecMontoCuota) & ", "
            strSQL &= DecimalToField(mdecInteresAnual) & ", "
            strSQL &= NumberToField(mbytSaldoIni) & ", "
            strSQL &= NumberToField(mbytSinFac) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngCreditoIdOrg) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comCredito SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "TipoCreditoId = " & NumberToField(mlngTipoCreditoId) & ", "
            strSQL &= "CreditoNro = " & NumberToField(mlngCreditoNro) & ", "
            strSQL &= "FechaIni = " & DateToField(mstrFechaIni) & ", "
            strSQL &= "FechaFin = " & DateToField(mstrFechaFin) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "CreditoDes = " & StringToField(mstrCreditoDes, 1000) & ", "
            strSQL &= "FrecuenciaId = " & NumberToField(mlngFrecuenciaId) & ", "
            strSQL &= "FrecuenciaNro = " & NumberToField(mlngFrecuenciaNro) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "CreditoOrden = " & StringToField(mstrCreditoOrden) & ", "
            strSQL &= "MontoLiq = " & DecimalToField(mdecMontoLiq) & ", "
            strSQL &= "MontoAmo = " & DecimalToField(mdecMontoAmo) & ", "
            strSQL &= "CantidadCuota = " & NumberToField(mlngCantidadCuota) & ", "
            strSQL &= "MontoCuota = " & DecimalToField(mdecMontoCuota) & ", "
            strSQL &= "InteresAnual = " & DecimalToField(mdecInteresAnual) & ", "
            strSQL &= "SaldoIni = " & NumberToField(mbytSaldoIni) & ", "
            strSQL &= "SinFac = " & NumberToField(mbytSinFac) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "CreditoIdOrg = " & NumberToField(mlngCreditoIdOrg) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CreditoId = " & NumberToField(mlngCreditoId) & " "

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
               mlngCreditoId = ToLong(oDataRow("CreditoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngTipoCreditoId = ToLong(oDataRow("TipoCreditoId"))
               mlngCreditoNro = ToLong(oDataRow("CreditoNro"))
               mstrFechaIni = ToDateDMY(oDataRow("FechaIni"))
               mstrFechaFin = ToDateDMY(oDataRow("FechaFin"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mstrCreditoDes = ToStr(oDataRow("CreditoDes"))
               mlngFrecuenciaId = ToLong(oDataRow("FrecuenciaId"))
               mlngFrecuenciaNro = ToLong(oDataRow("FrecuenciaNro"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mstrCreditoOrden = ToStr(oDataRow("CreditoOrden"))
               mdecMontoLiq = ToDecimal(oDataRow("MontoLiq"))
               mdecMontoAmo = ToDecimal(oDataRow("MontoAmo"))
               mlngCantidadCuota = ToLong(oDataRow("CantidadCuota"))
               mdecMontoCuota = ToDecimal(oDataRow("MontoCuota"))
               mdecInteresAnual = ToDecimal(oDataRow("InteresAnual"))
               mbytSaldoIni = ToByte(oDataRow("SaldoIni"))
               mbytSinFac = ToByte(oDataRow("SinFac"))
               mbytConFac = ToByte(oDataRow("ConFac"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngCreditoIdOrg = ToLong(oDataRow("CreditoIdOrg"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.Flujocaja
               mlngProveedorId = ToDecimal(oDataRow("ProveedorId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecMontoLiq = ToDecimal(oDataRow("MontoLiq"))
               mdecMontoAmo = ToDecimal(oDataRow("MontoAmo"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCreditoId = TableIDGet(mstrTableName, "CreditoId", moConnection)

         If mlngCreditoId = -1 Then
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

      If mlngTipoCreditoId = 0 Then
         strMsg &= "Tipo de Credito Inválido" & vbCrLf
      End If

      If mlngSucursalId = 0 Then
         strMsg &= "Sucursal Inválido" & vbCrLf
      End If

      If (mstrFechaIni.Trim() <> String.Empty) And (mstrFechaIni.Trim() <> "01/01/1990") Then
         If Not IsDate(ToDateDMY(mstrFechaIni)) Then
            strMsg &= "Fecha Inicial no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha Inicial no puede ser nula" & vbCrLf
      End If

      If mlngProveedorId = 0 Then
         strMsg &= "Proveedor Inválido" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If mdecTipoCambio = 0 Then
         strMsg &= "Tipo de Cambio Inválido" & vbCrLf
      End If

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
         'strSQL &= " FROM comCredito "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCredito.TipoCreditoId = " & NumberToField(mlngTipoCreditoId)
         'Else
         '   strSQL &= " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCredito.TipoCreditoId = " & NumberToField(mlngTipoCreditoId)
         '   strSQL &= " AND  comCredito.CreditoId <> " & NumberToField(mlngCreditoId)
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
