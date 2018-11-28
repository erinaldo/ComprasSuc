Imports System.Data
Imports System.Data.OleDb

Public Class clsCreditoDet
   Implements IDisposable

   Private mlngCreditoDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngCompraId As Long
   Private mlngTipoCreditoId As Long
   Private mlngCreditoId As Long
   Private mstrFecha As String
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mlngCuotaNro As Long
   Private mdecCapital As Decimal
   Private mdecInteres As Decimal
   Private mdecImporte As Decimal
   Private mdecCapitalAmo As Decimal
   Private mdecInteresAmo As Decimal
   Private mstrFechaAmo As String
   Private mdecInteresPen As Decimal
   Private mlngCentroCostoId As Long
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

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CreditoDetId() As Long
      Get
         Return mlngCreditoDetId
      End Get

      Set(ByVal Value As Long)
         mlngCreditoDetId = Value
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

   Property CreditoId() As Long
      Get
         Return mlngCreditoId
      End Get

      Set(ByVal Value As Long)
         mlngCreditoId = Value
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

   Property ProveedorId() As Long
      Get
         Return mlngProveedorId
      End Get

      Set(ByVal Value As Long)
         mlngProveedorId = Value
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

   Property CuotaNro() As Long
      Get
         Return mlngCuotaNro
      End Get

      Set(ByVal Value As Long)
         mlngCuotaNro = Value
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

   Property Importe() As Decimal
      Get
         Return mdecImporte
      End Get

      Set(ByVal Value As Decimal)
         mdecImporte = Value
      End Set
   End Property

   Property CapitalAmo() As Decimal
      Get
         Return mdecCapitalAmo
      End Get

      Set(ByVal Value As Decimal)
         mdecCapitalAmo = Value
      End Set
   End Property

   Property InteresAmo() As Decimal
      Get
         Return mdecInteresAmo
      End Get

      Set(ByVal Value As Decimal)
         mdecInteresAmo = Value
      End Set
   End Property

   Property FechaAmo() As String
      Get
         Return mstrFechaAmo
      End Get

      Set(ByVal Value As String)
         mstrFechaAmo = Value
      End Set
   End Property

   Property InteresPen() As Decimal
      Get
         Return mdecInteresPen
      End Get

      Set(ByVal Value As Decimal)
         mdecInteresPen = Value
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

   '******************************************************
   '* The following enumerations will change for each
   '* data access class
   '******************************************************
   Public Enum SelectFilters As Byte
      All = 0
      ListBox = 1
      Grid = 2
      Report = 3
      GridPago = 4
      CreditoIdDistinct = 5

      CREDITOID = 6

      ProveedorPorPagarFecha = 7
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      CompraId = 6
      GestionId = 7
      GridPago = 8
      CreditoIdSinPago = 9
      CuotaNro = 10
      CreditoId = 11
      TieneMovimiento = 12
      TieneMovimientoFecha = 13
      CuotaVencida = 14
      CuotaVencidaFecha = 15
      EstadoId = 16
      CUOTA_NRO = 17
      CREDITO_DETALLE_FECHA = 18
      CREDITO_DETALLE = 19
      ProveedorPorPagarFecha = 20
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CreditoDetId = 1
      Grid = 3
      Report = 4
      GarantiaObs = 5
      GridPago = 6
      CREDITO_FECHA = 7
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
      mstrTableName = "comCreditoDet"
      mstrClassName = "clsCreditoDet"

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
      mlngCreditoDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngCompraId = 0
      mlngTipoCreditoId = 0
      mlngCreditoId = 0
      mstrFecha = ""
      mlngProveedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mlngCuotaNro = 0
      mdecCapital = 0
      mdecInteres = 0
      mdecImporte = 0
      mdecCapitalAmo = 0
      mdecInteresAmo = 0
      mstrFechaAmo = ""
      mdecInteresPen = 0
      mlngCentroCostoId = 0
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
            strSQL = " SELECT  "
            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCreditoDet.EmpresaId,  "
            strSQL &= "    comCreditoDet.GestionId,  "
            strSQL &= "    comCreditoDet.CompraId,  "
            strSQL &= "    comCreditoDet.TipoCreditoId,  "
            strSQL &= "    comCreditoDet.CreditoId,  "
            strSQL &= "    comCreditoDet.Fecha,  "
            strSQL &= "    comCreditoDet.ProveedorId,  "
            strSQL &= "    comCreditoDet.MonedaId,  "
            strSQL &= "    comCreditoDet.TipoCambio,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comCreditoDet.Capital,  "
            strSQL &= "    comCreditoDet.Interes,  "
            strSQL &= "    comCreditoDet.Importe,  "
            strSQL &= "    comCreditoDet.CapitalAmo,  "
            strSQL &= "    comCreditoDet.InteresAmo,  "
            strSQL &= "    comCreditoDet.FechaAmo,  "
            strSQL &= "    comCreditoDet.InteresPen,  "
            strSQL &= "    comCreditoDet.CentroCostoId,  "
            strSQL &= "    comCreditoDet.SucursalId,  "
            strSQL &= "    comCreditoDet.EstadoId,  "
            strSQL &= "    comCreditoDet.sLastUpdate_id,  "
            strSQL &= "    comCreditoDet.dtLastUpdate_dt,  "
            strSQL &= "    comCreditoDet.iConcurrency_id  "
            strSQL &= " FROM comCreditoDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comCreditoDet.CreditoDetId  "
            strSQL &= " FROM comCreditoDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comCreditoDet.Fecha,  "
            strSQL &= "    comCreditoDet.Capital,  "
            strSQL &= "    comCreditoDet.Interes,  "
            strSQL &= "    comCreditoDet.Importe,  "
            strSQL &= "    comCreditoDet.CapitalAmo,  "
            strSQL &= "    comCreditoDet.InteresAmo,  "
            strSQL &= "    comCreditoDet.FechaAmo,  "
            strSQL &= "    comCreditoDet.InteresPen,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comCreditoDet, tblEstado "

         Case SelectFilters.GridPago
            strSQL = " SELECT  "
            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comCompra.PedCompraId,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comCompra.SinFac As SinFacC,  "
            strSQL &= "    comCompra.ConFac As ConFacC,  "
            strSQL &= "    comTipoCredito.TipoCreditoId,  "
            strSQL &= "    comTipoCredito.TipoCreditoDes,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    comCredito.FechaIni,  "
            strSQL &= "    comCredito.InteresAnual,  "
            strSQL &= "    comCredito.SinFac,  "
            strSQL &= "    comCredito.ConFac,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comCreditoDet.Fecha,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comCreditoDet.Capital,  "
            strSQL &= "    comCreditoDet.Interes,  "
            strSQL &= "    comCreditoDet.Importe,  "
            strSQL &= "    comCreditoDet.CapitalAmo,  "
            strSQL &= "    comCreditoDet.InteresAmo,  "
            strSQL &= "    comCreditoDet.FechaAmo,  "
            strSQL &= "    comCreditoDet.InteresPen  "
            strSQL &= " FROM comCreditoDet, comCompra, invAlmacen, comTipoCredito, comCredito, tblMoneda, tblCentroCosto, tblSucursal "

         Case SelectFilters.Report

         Case SelectFilters.CreditoIdDistinct
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    comCreditoDet.CreditoId  "
            strSQL &= " FROM comCreditoDet "

         Case SelectFilters.CREDITOID
            strSQL = " SELECT "
            strSQL &= "    comCredito.CreditoId  "
            strSQL &= " FROM comCredito, comProveedor "

         Case SelectFilters.ProveedorPorPagarFecha
            strSQL = " SELECT  "
            strSQL &= "    comCreditoDet.CreditoDetId,  "
            strSQL &= "    comCreditoDet.TipoCreditoId,  "
            strSQL &= "    comCreditoDet.CreditoId,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comCreditoDet.MonedaId,  "
            strSQL &= "    comCreditoDet.TipoCambio,  "
            strSQL &= "    comCreditoDet.CuotaNro,  "
            strSQL &= "    comCreditoDet.Fecha,  "
            strSQL &= "    comCreditoDet.Capital,  "
            strSQL &= "    comCreditoDet.Interes,  "
            strSQL &= "    comCreditoDet.Importe,  "
            strSQL &= "    comCreditoDet.CapitalAmo,  "
            strSQL &= "    comCreditoDet.InteresAmo,  "
            strSQL &= "    comCreditoDet.FechaAmo,  "
            strSQL &= "    comCreditoDet.EstadoId  "
            strSQL &= " FROM comCreditoDet, comProveedor "


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
            strSQL = " WHERE  comCreditoDet.CreditoDetId = " & NumberToField(mlngCreditoDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comCreditoDet.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report

         Case WhereFilters.CompraId
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.CompraId = " & NumberToField(mlngCompraId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.GridPago
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCreditoDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  comCreditoDet.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comCreditoDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comCredito.TipoCreditoId = comTipoCredito.TipoCreditoId "
            strSQL &= " AND  comCreditoDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCredito.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comCredito.SucursalId = tblSucursal.SucursalId "

            If mstrFecha.Length <> 0 Then
               strSQL &= " AND  comCredito.FechaIni <= " & DateToField(mstrFecha)
            End If

         Case WhereFilters.CreditoIdSinPago
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.CuotaNro
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comCreditoDet.CuotaNro = " & NumberToField(mlngCuotaNro)

         Case WhereFilters.CreditoId
            strSQL = " WHERE  comCreditoDet.CreditoId = " & NumberToField(mlngCreditoId)

         Case WhereFilters.TieneMovimiento
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCreditoDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCreditoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCreditoDet.SucursalId = " & NumberToField(mlngSucursalId)
            End If

         Case WhereFilters.TieneMovimientoFecha
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCreditoDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  comCreditoDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCreditoDet.Fecha <= " & DateToField(mstrFechaAmo)

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCreditoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCreditoDet.SucursalId = " & NumberToField(mlngSucursalId)
            End If

         Case WhereFilters.CuotaVencida
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCreditoDet.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  ( comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " OR comCreditoDet.EstadoId = " & NumberToField(mlngCreditoDetId) & " ) "

         Case WhereFilters.CuotaVencidaFecha
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCreditoDet.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  ( comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " OR comCreditoDet.EstadoId = " & NumberToField(mlngCreditoDetId) & " ) "
            'strSQL &= " AND  comCreditoDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCreditoDet.Fecha <= " & DateToField(mstrFechaAmo)

         Case WhereFilters.EstadoId
            strSQL = " WHERE  comCreditoDet.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.CUOTA_NRO
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCreditoDet.CreditoId = " & NumberToField(mlngCreditoId)
            strSQL &= " AND  comCreditoDet.CuotaNro = " & NumberToField(mlngCuotaNro)

         Case WhereFilters.CREDITO_DETALLE
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCredito.ProveedorId = comProveedor.ProveedorId "

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCredito.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCreditoDet.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comCredito.CreditoId IN (SELECT comCreditoDet.CreditoId "
            strSQL &= " FROM  comCreditoDet "
            strSQL &= " WHERE ( comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " OR comCreditoDet.EstadoId = " & NumberToField(mlngCreditoDetId) & " ) "
            strSQL &= " AND  (comCreditoDet.Capital -  comCreditoDet.CapitalAmo) > 0 "
            strSQL &= " ) "

         Case WhereFilters.CREDITO_DETALLE_FECHA
            strSQL = " WHERE  comCredito.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCredito.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCredito.ProveedorId = comProveedor.ProveedorId "

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCredito.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCreditoDet.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comCredito.CreditoId IN (SELECT comCreditoDet.CreditoId "
            strSQL &= " FROM  comCreditoDet "
            strSQL &= " WHERE ( comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " OR comCreditoDet.EstadoId = " & NumberToField(mlngCreditoDetId) & " ) "
            strSQL &= " AND  (comCreditoDet.Capital -  comCreditoDet.CapitalAmo) > 0 "
            'strSQL &= " AND  comCreditoDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCreditoDet.Fecha <= " & DateToField(mstrFechaAmo)
            strSQL &= " ) "

         Case WhereFilters.ProveedorPorPagarFecha
            strSQL = " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCreditoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCreditoDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCreditoDet.ProveedorId = comProveedor.ProveedorId "

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comCreditoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comCreditoDet.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  ( comCreditoDet.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " OR comCreditoDet.EstadoId = " & NumberToField(mlngCreditoDetId) & " ) "
            strSQL &= " AND  comCreditoDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= "AND  (comCreditoDet.Capital -  comCreditoDet.CapitalAmo) > 0"

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CreditoDetId
            strSQL = " ORDER BY comCreditoDet.CreditoDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comCreditoDet.CuotaNro "

         Case OrderByFilters.GarantiaObs
            strSQL = " ORDER BY comCreditoDet.GarantiaObs "

         Case OrderByFilters.Report

         Case OrderByFilters.GridPago
            strSQL = " ORDER BY comCredito.CreditoNro, comCreditoDet.CuotaNro "

         Case OrderByFilters.CREDITO_FECHA
            strSQL = " ORDER BY comCredito.FechaIni ASC"

         Case OrderByFilters.FechaDesc
            strSQL = " ORDER BY comCreditoDet.Fecha DESC"

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
            strSQL = "INSERT INTO comCreditoDet ("
            strSQL &= "CreditoDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "CompraId, "
            strSQL &= "TipoCreditoId, "
            strSQL &= "CreditoId, "
            strSQL &= "Fecha, "
            strSQL &= "ProveedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "CuotaNro, "
            strSQL &= "Capital, "
            strSQL &= "Interes, "
            strSQL &= "Importe, "
            strSQL &= "CapitalAmo, "
            strSQL &= "InteresAmo, "
            strSQL &= "FechaAmo, "
            strSQL &= "InteresPen, "
            strSQL &= "CentroCostoId, "
            strSQL &= "SucursalId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCreditoDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngTipoCreditoId) & ", "
            strSQL &= NumberToField(mlngCreditoId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= NumberToField(mlngCuotaNro) & ", "
            strSQL &= DecimalToField(mdecCapital) & ", "
            strSQL &= DecimalToField(mdecInteres) & ", "
            strSQL &= DecimalToField(mdecImporte) & ", "
            strSQL &= DecimalToField(mdecCapitalAmo) & ", "
            strSQL &= DecimalToField(mdecInteresAmo) & ", "
            strSQL &= DateToField(mstrFechaAmo) & ", "
            strSQL &= DecimalToField(mdecInteresPen) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
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
            strSQL = "UPDATE comCreditoDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "TipoCreditoId = " & NumberToField(mlngTipoCreditoId) & ", "
            strSQL &= "CreditoId = " & NumberToField(mlngCreditoId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "CuotaNro = " & NumberToField(mlngCuotaNro) & ", "
            strSQL &= "Capital = " & DecimalToField(mdecCapital) & ", "
            strSQL &= "Interes = " & DecimalToField(mdecInteres) & ", "
            strSQL &= "Importe = " & DecimalToField(mdecImporte) & ", "
            strSQL &= "CapitalAmo = " & DecimalToField(mdecCapitalAmo) & ", "
            strSQL &= "InteresAmo = " & DecimalToField(mdecInteresAmo) & ", "
            strSQL &= "FechaAmo = " & DateToField(mstrFechaAmo) & ", "
            strSQL &= "InteresPen = " & DecimalToField(mdecInteresPen) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CreditoDetId = " & NumberToField(mlngCreditoDetId) & " "

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
               mlngCreditoDetId = ToLong(oDataRow("CreditoDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngTipoCreditoId = ToLong(oDataRow("TipoCreditoId"))
               mlngCreditoId = ToLong(oDataRow("CreditoId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngCuotaNro = ToLong(oDataRow("CuotaNro"))
               mdecCapital = ToDecimal(oDataRow("Capital"))
               mdecInteres = ToDecimal(oDataRow("Interes"))
               mdecImporte = ToDecimal(oDataRow("Importe"))
               mdecCapitalAmo = ToDecimal(oDataRow("CapitalAmo"))
               mdecInteresAmo = ToDecimal(oDataRow("InteresAmo"))
               mstrFechaAmo = ToDateDMY(oDataRow("FechaAmo"))
               mdecInteresPen = ToDecimal(oDataRow("InteresPen"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCreditoDetId = ToLong(oDataRow("CreditoDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCreditoDetId = TableIDGet(mstrTableName, "CreditoDetId", moConnection)

         If mlngCreditoDetId = -1 Then
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

      If mlngCreditoId = 0 Then
         strMsg &= "Credito Inválido" & vbCrLf
      End If

      If mlngTipoCreditoId = 0 Then
         strMsg &= "Tipo Credito Inválido" & vbCrLf
      End If

      If (mstrFecha.Trim() <> String.Empty) And (mstrFecha.Trim() <> "01/01/1990") Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
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

      If mlngCuotaNro = 0 Then
         strMsg &= "Número de Cuota Inválido" & vbCrLf
      End If

      If mdecCapital = 0 Then
         strMsg &= "Capital Inválido" & vbCrLf
      End If

      If mdecImporte = 0 Then
         strMsg &= "Importe Inválido" & vbCrLf
      End If

      If (mstrFechaAmo.Trim() <> String.Empty) And (mstrFechaAmo.Trim() <> "01/01/1990") Then
         If Not IsDate(ToDateDMY(mstrFechaAmo)) Then
            strMsg &= "Fecha Amortización no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha Amortización no puede ser nula" & vbCrLf
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
         'strSQL &= " FROM comCreditoDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCreditoDet.TipoCreditoId = " & NumberToField(mlngTipoCreditoId)
         'Else
         '   strSQL &= " WHERE  comCreditoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCreditoDet.TipoCreditoId = " & NumberToField(mlngTipoCreditoId)
         '   strSQL &= " AND  comCreditoDet.CreditoDetId <> " & NumberToField(mlngCreditoDetId)
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
