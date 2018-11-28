Imports System.Data
Imports System.Data.OleDb

Public Class clsCompraDet
   Implements IDisposable

   Private mlngCompraDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngCompraId As Long
   Private mstrFecha As String
   Private mlngAlmacenId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mlngItemId As Long
   Private mlngMedidaId As Long
   Private mdecCantidad As Decimal
   Private mdecPrecioOrg As Decimal
   Private mdecPrecioCos As Decimal
   Private mdecImporte As Decimal
   Private mdecPrecioRec As Decimal
   Private mdecPrecioDes As Decimal
   Private mdecImporteBru As Decimal
   Private mdecPrecioPorFac As Decimal
   Private mstrCompraDetDes As String
   Private mdecCantidadDev As Decimal
   Private mlngPlanIdAct As Long
   Private mlngPlanAddIdAct As Long
   Private mlngCentroCostoIdAct As Long
   Private mlngCentroCostoDetIdAct As Long
   Private mlngSucursalIdAct As Long
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
   Property CompraDetId() As Long
      Get
         Return mlngCompraDetId
      End Get

      Set(ByVal Value As Long)
         mlngCompraDetId = Value
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

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
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

   Property ItemId() As Long
      Get
         Return mlngItemId
      End Get

      Set(ByVal Value As Long)
         mlngItemId = Value
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

   Property Cantidad() As Decimal
      Get
         Return mdecCantidad
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidad = Value
      End Set
   End Property

   Property PrecioOrg() As Decimal
      Get
         Return mdecPrecioOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioOrg = Value
      End Set
   End Property

   Property PrecioCos() As Decimal
      Get
         Return mdecPrecioCos
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioCos = Value
      End Set
   End Property

   Property PrecioRec() As Decimal
      Get
         Return mdecPrecioRec
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioRec = Value
      End Set
   End Property

   Property PrecioDes() As Decimal
      Get
         Return mdecPrecioDes
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioDes = Value
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

   Property ImporteBru() As Decimal
      Get
         Return mdecImporteBru
      End Get

      Set(ByVal Value As Decimal)
         mdecImporteBru = Value
      End Set
   End Property

   Property PrecioPorFac() As Decimal
      Get
         Return mdecPrecioPorFac
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioPorFac = Value
      End Set
   End Property

   Property CompraDetDes() As String
      Get
         Return mstrCompraDetDes
      End Get

      Set(ByVal Value As String)
         mstrCompraDetDes = Value
      End Set
   End Property

   Property PlanIdAct() As Long
      Get
         Return mlngPlanIdAct
      End Get

      Set(ByVal Value As Long)
         mlngPlanIdAct = Value
      End Set
   End Property

   Property PlanAddIdAct() As Long
      Get
         Return mlngPlanAddIdAct
      End Get

      Set(ByVal Value As Long)
         mlngPlanAddIdAct = Value
      End Set
   End Property

   Property CentroCostoIdAct() As Long
      Get
         Return mlngCentroCostoIdAct
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoIdAct = Value
      End Set
   End Property

   Property CentroCostoDetIdAct() As Long
      Get
         Return mlngCentroCostoDetIdAct
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoDetIdAct = Value
      End Set
   End Property

   Property SucursalIdAct() As Long
      Get
         Return mlngSucursalIdAct
      End Get

      Set(ByVal Value As Long)
         mlngSucursalIdAct = Value
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

   Property CantidadDev() As Decimal
      Get
         Return mdecCantidadDev
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidadDev = Value
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
      CompraMov = 4
      FechaDistinta = 5
      CompraIdItem = 6
      AlmacenDistinct = 7
      ProveedorDistinct = 8
      MedidaDistinct = 9
      UltimaCompra = 10
      ProveedorItemMov = 11
      ItemProveedorMov = 12
      ProveedorUPC = 13
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      CompraId = 6
      ItemId = 7
      TieneMovimiento = 8
      TieneMovimientoFecha = 9
      CompraMov = 10
      CompraMovFecha = 11
      SaldoActual = 12
      SaldoFecha = 13
      SaldoFechaIgual = 14
      CompraIdItem = 15
      AlmacenDistinct = 16
      ProveedorDistinct = 17
      MedidaDistinct = 18
      UltimaCompra = 19
      UltimaCompraFecha = 20

      ProveedorItemMov = 21
      ProveedorItemMovFecha = 22
      ItemProveedorMov = 23
      ItemProveedorMovFecha = 24

      TieneMovimientoCC = 25
      TieneMovimientoCCFecha = 26
      SaldoCCActual = 27
      SaldoCCFecha = 28
      SaldoCCFechaIgual = 29
      ItemIdTieneMov = 30
      CompraConDevCompra = 31
      CompraConFacturaDif = 32
      ProveedorUPC = 33
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompraDetId = 1
      Grid = 3
      Report = 4
      CompraMov = 5
      Fecha = 6
      FechaDESC = 7
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      CantidadDev = 1
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
   End Enum

   Public Enum RowSumFilters As Byte
      Cantidad = 1
      CantidadSal = 2
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
   Private mintRowSumFilter As RowSumFilters

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

   Property RowSumFilter() As RowSumFilters
      Get
         Return mintRowSumFilter
      End Get

      Set(ByVal Value As RowSumFilters)
         mintRowSumFilter = Value
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
      mstrTableName = "comCompraDet"
      mstrClassName = "clsCompraDet"

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
      mlngCompraDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngCompraId = 0
      mstrFecha = ""
      mlngAlmacenId = 0
      mlngProveedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mlngItemId = 0
      mlngMedidaId = 0
      mdecCantidad = 0
      mdecPrecioOrg = 0
      mdecPrecioCos = 0
      mdecImporte = 0
      mdecPrecioRec = 0
      mdecPrecioDes = 0
      mdecImporteBru = 0
      mdecPrecioPorFac = 0
      mstrCompraDetDes = ""
      mdecCantidadDev = 0
      mlngPlanIdAct = 0
      mlngPlanAddIdAct = 0
      mlngCentroCostoIdAct = 0
      mlngCentroCostoDetIdAct = 0
      mlngSucursalIdAct = 0
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
            strSQL &= "    comCompraDet.CompraDetId,  "
            strSQL &= "    comCompraDet.EmpresaId,  "
            strSQL &= "    comCompraDet.GestionId,  "
            strSQL &= "    comCompraDet.CompraId,  "
            strSQL &= "    comCompraDet.Fecha,  "
            strSQL &= "    comCompraDet.AlmacenId,  "
            strSQL &= "    comCompraDet.ProveedorId,  "
            strSQL &= "    comCompraDet.MonedaId,  "
            strSQL &= "    comCompraDet.TipoCambio,  "
            strSQL &= "    comCompraDet.ItemId,  "
            strSQL &= "    comCompraDet.MedidaId,  "
            strSQL &= "    comCompraDet.Cantidad,  "
            strSQL &= "    comCompraDet.PrecioOrg,  "
            strSQL &= "    comCompraDet.PrecioCos,  "
            strSQL &= "    comCompraDet.Importe,  "
            strSQL &= "    comCompraDet.PrecioRec,  "
            strSQL &= "    comCompraDet.PrecioDes,  "
            strSQL &= "    comCompraDet.ImporteBru,  "
            strSQL &= "    comCompraDet.PrecioPorFac,  "
            strSQL &= "    comCompraDet.CompraDetDes,  "
            strSQL &= "    comCompraDet.EstadoId,  "
            strSQL &= "    comCompraDet.CantidadDev,  "
            strSQL &= "    comCompraDet.PlanIdAct,  "
            strSQL &= "    comCompraDet.PlanAddIdAct,  "
            strSQL &= "    comCompraDet.CentroCostoIdAct,  "
            strSQL &= "    comCompraDet.CentroCostoDetIdAct,  "
            strSQL &= "    comCompraDet.SucursalIdAct,  "
            strSQL &= "    comCompraDet.sLastUpdate_id,  "
            strSQL &= "    comCompraDet.dtLastUpdate_dt,  "
            strSQL &= "    comCompraDet.iConcurrency_id  "
            strSQL &= " FROM comCompraDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comCompraDet.CompraDetId  "
            strSQL &= " FROM comCompraDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comCompraDet.CompraDetId,  "
            strSQL &= "    comCompraDet.EmpresaId,  "
            strSQL &= "    comCompraDet.CompraId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invItem.TipoItemId,  "
            strSQL &= "    invItem.TipoCosteoId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comCompraDet.Cantidad,  "
            strSQL &= "    comCompraDet.PrecioOrg,  "
            strSQL &= "    comCompraDet.PrecioCos,  "
            strSQL &= "    comCompraDet.Importe,  "
            strSQL &= "    comCompraDet.PrecioRec,  "
            strSQL &= "    comCompraDet.PrecioDes,  "
            strSQL &= "    comCompraDet.ImporteBru,  "
            strSQL &= "    comCompraDet.PrecioPorFac,  "
            strSQL &= "    comCompraDet.CompraDetDes,  "
            strSQL &= "    comCompraDet.PlanIdAct,  "
            strSQL &= "    comCompraDet.PlanAddIdAct,  "
            strSQL &= "    comCompraDet.CentroCostoIdAct,  "
            strSQL &= "    comCompraDet.CentroCostoDetIdAct,  "
            strSQL &= "    comCompraDet.SucursalIdAct  "
            strSQL &= " FROM comCompraDet, invItem, invMedida "

         Case SelectFilters.Report

         Case SelectFilters.CompraMov
            strSQL = " SELECT "
            strSQL &= " comCompraDet.CompraDetId, "
            strSQL &= " comCompraDet.CompraId, "
            strSQL &= " comCompraDet.Fecha, "
            strSQL &= " comTipoPago.TipoPagoId, "
            strSQL &= " comTipoPago.TipoPagoDes, "
            strSQL &= " comCompra.CompraNro, "
            strSQL &= " invAlmacen.AlmacenId, "
            strSQL &= " invAlmacen.AlmacenDes, "
            strSQL &= " comProveedor.ProveedorId, "
            strSQL &= " comProveedor.ProveedorDes, "
            strSQL &= " comCompra.CompraDes, "
            strSQL &= " invItem.ItemId, "
            strSQL &= " invItem.ItemCod, "
            strSQL &= " invItem.ItemDes, "
            strSQL &= " invItem.MedidaId as MedidaItemId, "
            strSQL &= " invItem.MedidaIdEqui as MedidaItemEquiId, "
            strSQL &= " invItem.MedidaCantEqui as MedidaItemCantEqui, "
            strSQL &= " invMedida.MedidaId, "
            strSQL &= " invMedida.MedidaDes, "
            strSQL &= " comCompraDet.Cantidad, "
            strSQL &= " comCompraDet.MonedaId, "
            strSQL &= " comCompraDet.CentroCostoIdAct, "
            strSQL &= " comCompraDet.TipoCambio, "
            strSQL &= " comCompraDet.PrecioOrg, "
            strSQL &= " comCompraDet.PrecioCos, "
            strSQL &= " comCompraDet.ImporteCos, "
            strSQL &= " comCompraDet.Importe, "
            strSQL &= " comCompraDet.PrecioRec, "
            strSQL &= " comCompraDet.PrecioDes, "
            strSQL &= " comCompraDet.ImporteBru, "
            strSQL &= " comCompraDet.PrecioPorFac "
            strSQL &= " FROM comCompraDet, invItem, comCompra, comTipoPago, invAlmacen, comProveedor, invMedida "

         Case SelectFilters.FechaDistinta
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    comCompraDet.Fecha,  "
            strSQL &= "    comCompraDet.ItemId  "
            strSQL &= " FROM comCompraDet "

         Case SelectFilters.CompraIdItem
            strSQL = " SELECT  "
            strSQL &= "    comCompraDet.CompraDetId,  "
            strSQL &= "    comCompraDet.CompraId,  "
            strSQL &= "    comCompraDet.ItemId As CompraDetItemId,  "
            strSQL &= "    invItem.ItemId As ItemItemId,  "
            strSQL &= "    invItem.PlanGrupoId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.MedidaId,  "
            strSQL &= "    invItem.MedidaIdEqui,  "
            strSQL &= "    invItem.MedidaCantEqui,  "
            strSQL &= "    invItem.TipoItemId,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invItem.MonedaIdCos,  "
            strSQL &= "    invItem.MonedaIdVen,  "
            strSQL &= "    invItem.TipoCosteoId  "
            strSQL &= " FROM comCompraDet LEFT OUTER JOIN invItem ON comCompraDet.ItemId = invItem.ItemId "

         Case SelectFilters.UltimaCompra
            strSQL = " SELECT "
            strSQL &= " comCompraDet.CompraDetId, "
            strSQL &= " comCompraDet.CompraId, "
            strSQL &= " comCompraDet.Fecha, "
            strSQL &= " comCompraDet.TipoCambio, "
            strSQL &= " comCompraDet.MonedaId, "
            strSQL &= " tblMoneda.MonedaDes, "
            strSQL &= " comCompraDet.Cantidad, "
            strSQL &= " comCompraDet.PrecioOrg, "
            strSQL &= " comCompraDet.PrecioCos, "
            strSQL &= " comCompraDet.PrecioDes, "
            strSQL &= " comCompraDet.PrecioRec, "
            strSQL &= " invMedida.MedidaId, "
            strSQL &= " invMedida.MedidaDes, "
            strSQL &= " invItem.ItemId, "
            strSQL &= " invItem.ItemDes, "
            strSQL &= " invItem.LineaId, "
            strSQL &= " invItem.GrupoId, "
            strSQL &= " invSubGrupo.SubGrupoId, "
            strSQL &= " invSubGrupo.SubGrupoDes, "
            strSQL &= " invItem.MedidaId MedidaIdMin, "
            strSQL &= " invItem.MedidaIdEqui MedidaIdEqui,  "
            strSQL &= " invItem.MedidaCantEqui MedidaCantEqui  "
            strSQL &= " FROM comCompraDet, invItem, invMedida, tblMoneda, invSubGrupo "

         Case SelectFilters.ProveedorItemMov
            strSQL = " SELECT  "
            strSQL &= "    comCompraDet.CompraDetId,  "
            strSQL &= "    comCompraDet.CompraId,  "
            strSQL &= "    comCompraDet.Fecha,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comCompraDet.ItemId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comCompraDet.Cantidad,  "
            strSQL &= "    comCompraDet.MonedaId,  "
            strSQL &= "    comCompraDet.TipoCambio,  "
            strSQL &= "    comCompraDet.PrecioOrg,  "
            strSQL &= "    comCompraDet.Importe  "
            strSQL &= " FROM comCompraDet, comCompra, comProveedor, invMedida "

         Case SelectFilters.ItemProveedorMov
            strSQL = " SELECT  "
            strSQL &= "    comCompraDet.CompraDetId,  "
            strSQL &= "    comCompraDet.CompraId,  "
            strSQL &= "    comCompraDet.Fecha,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCompra.CompraOrden,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comCompraDet.Cantidad,  "
            strSQL &= "    comCompraDet.MonedaId,  "
            strSQL &= "    comCompraDet.TipoCambio,  "
            strSQL &= "    comCompraDet.PrecioOrg,  "
            strSQL &= "    comCompraDet.Importe  "
            strSQL &= " FROM comCompraDet, comCompra, invItem, invMedida "

         Case SelectFilters.ProveedorUPC
            strSQL = " SELECT  TOP 5 "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompraDet.Fecha,  "
            strSQL &= "    comTipoPago.TipoPagoId,  "
            strSQL &= "    comTipoPago.TipoPagoDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comCompraDet.Cantidad,  "
            strSQL &= "    comCompraDet.PrecioOrg  "
            strSQL &= " FROM comCompraDet, comCompra, tblMoneda, invMedida, comTipoPago "

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
            strSQL = " WHERE  comCompraDet.CompraDetId = " & NumberToField(mlngCompraDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  comCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.Report

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.CompraId
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.CompraId = " & NumberToField(mlngCompraId)

         Case WhereFilters.ItemId
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  comCompraDet.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)

         Case WhereFilters.TieneMovimiento
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If

            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.TieneMovimientoFecha
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  comCompraDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCompraDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.CompraMov
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If

            strSQL &= " AND  comCompraDet.CompraId = comCompra.CompraId "

            If mlngCompraId <> 0 Then
               strSQL &= " AND  comCompra.TipoPagoId = " & NumberToField(mlngCompraId)
            End If

            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comCompraDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comCompraDet.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.CompraMovFecha
            strSQL = " WHERE comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngCompraId <> 0 Then
               strSQL &= " AND comCompra.TipoPagoId = " & NumberToField(mlngCompraId)
            End If
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND comCompraDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND comCompraDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND comCompraDet.CompraId = comCompra.CompraId "
            strSQL &= " AND comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND comCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND comCompraDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND comCompraDet.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND (comCompraDet.EstadoId = 13 "
            strSQL &= " OR comCompraDet.EstadoId = 14 "
            strSQL &= " OR comCompraDet.EstadoId = 15) "

         Case WhereFilters.SaldoActual
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.SaldoFecha
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCompraDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.SaldoFechaIgual
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.Fecha = " & DateToField(mstrFecha)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.CompraIdItem
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.CompraId = " & NumberToField(mlngCompraId)

         Case WhereFilters.UltimaCompra
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
                If mlngAlmacenId <> 0 Then
                    strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
                End If

            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If

            strSQL &= " AND  comCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  comCompraDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompraDet.CompraDetId = (SELECT  TOP 1 com.CompraDetId "
            strSQL &= " 									       FROM comCompraDet com, invItem "
            strSQL &= " 									       WHERE com.ItemId = invItem.ItemId "
            strSQL &= " 									       AND com.ItemId = comCompraDet.ItemId"
            strSQL &= " 									       AND invItem.SubGrupoId = " & NumberToField(mlngCompraId)
                If mlngAlmacenId <> 0 Then
                    strSQL &= " 									       AND com.AlmacenId = " & NumberToField(mlngAlmacenId)
                End If
            strSQL &= " 									       AND com.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " 									       AND com.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " 									       ORDER by com.Fecha DESC )"
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.UltimaCompraFecha
            strSQL = " WHERE comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND comCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND comCompraDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND comCompraDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND comCompraDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND (comCompraDet.EstadoId = 13 "
            strSQL &= " OR comCompraDet.EstadoId = 14 "
            strSQL &= " OR comCompraDet.EstadoId = 15) "

         Case WhereFilters.ProveedorItemMov
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)

            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If

            strSQL &= " AND  comCompraDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompraDet.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.ProveedorItemMovFecha
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)

            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If

            strSQL &= " AND  comCompraDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompraDet.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  comCompraDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCompraDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.ItemProveedorMov
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.ItemProveedorMovFecha
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngCentroCostoIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  comCompraDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCompraDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.TieneMovimientoCC
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.CentroCostoIdAct IN ( " & mstrCompraDetDes & " ) " ''Cadena de Varios Centros de Costos
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.TieneMovimientoCCFecha
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.CentroCostoIdAct IN ( " & mstrCompraDetDes & " ) " ''Cadena de Varios Centros de Costos
            strSQL &= " AND  comCompraDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCompraDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.SaldoCCActual
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.CentroCostoIdAct IN ( " & mstrCompraDetDes & " ) " ''Cadena de Varios Centros de Costos
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.SaldoCCFecha
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.CentroCostoIdAct IN ( " & mstrCompraDetDes & " ) " ''Cadena de Varios Centros de Costos
            strSQL &= " AND  comCompraDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comCompraDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.SaldoCCFechaIgual
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngSucursalIdAct <> 0 Then
               strSQL &= " AND  comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalIdAct)
            End If
            strSQL &= " AND  comCompraDet.CentroCostoIdAct IN ( " & mstrCompraDetDes & " ) " ''Cadena de Varios Centros de Costos
            strSQL &= " AND  comCompraDet.Fecha = " & DateToField(mstrFecha)
            strSQL &= " AND  (comCompraDet.EstadoId = 13 "
            strSQL &= " OR  comCompraDet.EstadoId = 14 "
            strSQL &= " OR  comCompraDet.EstadoId = 15) "

         Case WhereFilters.ItemIdTieneMov
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.CompraConDevCompra
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  comCompraDet.CantidadDev > 0 "

         Case WhereFilters.ProveedorUPC
            strSQL = " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  comCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  comCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comCompraDet.CompraId = comCompra.CompraId "
            strSQL &= " AND  comCompraDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  comCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  ( comCompra.EstadoId = 13 "
            strSQL &= "  OR   comCompra.EstadoId = 14 "
            strSQL &= "  OR   comCompra.EstadoId = 15 "
            strSQL &= "  ) "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompraDetId
            strSQL = " ORDER BY comCompraDet.CompraDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comCompraDet.CompraDetId "

         Case OrderByFilters.Report
            strSQL = " ORDER BY comCompraDet.CompraDetId "

         Case OrderByFilters.CompraMov
            strSQL = " ORDER BY comCompraDet.CompraId "

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY comCompraDet.Fecha "

         Case OrderByFilters.FechaDESC
            strSQL = " ORDER BY comCompraDet.Fecha DESC "

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

   Private Function RowSumSQL() As String
      Dim strSQL As String

      Select Case mintRowSumFilter
         Case RowSumFilters.Cantidad
            strSQL = "SELECT Sum(Cantidad) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowSumFilters.CantidadSal
            strSQL = "SELECT Sum(CantidadSal) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO comCompraDet ("
            strSQL &= "CompraDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "CompraId, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenId, "
            strSQL &= "ProveedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "ItemId, "
            strSQL &= "MedidaId, "
            strSQL &= "Cantidad, "
            strSQL &= "PrecioOrg, "
            strSQL &= "PrecioCos, "
            strSQL &= "Importe, "
            strSQL &= "PrecioRec,  "
            strSQL &= "PrecioDes,  "
            strSQL &= "ImporteBru,  "
            strSQL &= "PrecioPorFac, "
            strSQL &= "CompraDetDes,  "
            strSQL &= "EstadoId, "
            strSQL &= "CantidadDev, "
            strSQL &= "PlanIdAct, "
            strSQL &= "PlanAddIdAct, "
            strSQL &= "CentroCostoIdAct, "
            strSQL &= "CentroCostoDetIdAct, "
            strSQL &= "SucursalIdAct, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompraDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= NumberToField(mlngMedidaId) & ", "
            strSQL &= DecimalToField(mdecCantidad) & ", "
            strSQL &= DecimalToField(mdecPrecioOrg) & ", "
            strSQL &= DecimalToField(mdecPrecioCos) & ", "
            strSQL &= DecimalToField(mdecImporte) & ", "
            strSQL &= DecimalToField(mdecPrecioRec) & ", "
            strSQL &= DecimalToField(mdecPrecioDes) & ", "
            strSQL &= DecimalToField(mdecImporteBru) & ", "
            strSQL &= DecimalToField(mdecPrecioPorFac) & ", "
            strSQL &= StringToField(mstrCompraDetDes) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= DecimalToField(mdecCantidadDev) & ", "
            strSQL &= NumberToField(mlngPlanIdAct) & ", "
            strSQL &= NumberToField(mlngPlanAddIdAct) & ", "
            strSQL &= NumberToField(mlngCentroCostoIdAct) & ", "
            strSQL &= NumberToField(mlngCentroCostoDetIdAct) & ", "
            strSQL &= NumberToField(mlngSucursalIdAct) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comCompraDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "MedidaId = " & NumberToField(mlngMedidaId) & ", "
            strSQL &= "Cantidad = " & DecimalToField(mdecCantidad) & ", "
            strSQL &= "PrecioOrg = " & DecimalToField(mdecPrecioOrg) & ", "
            strSQL &= "PrecioCos = " & DecimalToField(mdecPrecioCos) & ", "
            strSQL &= "PrecioRec = " & DecimalToField(mdecPrecioRec) & ", "
            strSQL &= "PrecioDes = " & DecimalToField(mdecPrecioDes) & ", "
            strSQL &= "Importe = " & DecimalToField(mdecImporte) & ", "
            strSQL &= "ImporteBru = " & DecimalToField(mdecImporteBru) & ", "
            strSQL &= "PrecioPorFac = " & DecimalToField(mdecPrecioPorFac) & ", "
            strSQL &= "CompraDetDes = " & StringToField(mstrCompraDetDes) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "CantidadDev = " & DecimalToField(mdecCantidadDev) & ", "
            strSQL &= "PlanIdAct = " & NumberToField(mlngPlanIdAct) & ", "
            strSQL &= "PlanAddIdAct = " & NumberToField(mlngPlanAddIdAct) & ", "
            strSQL &= "CentroCostoIdAct = " & NumberToField(mlngCentroCostoIdAct) & ", "
            strSQL &= "CentroCostoDetIdAct = " & NumberToField(mlngCentroCostoDetIdAct) & ", "
            strSQL &= "SucursalIdAct = " & NumberToField(mlngSucursalIdAct) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraDetId = " & NumberToField(mlngCompraDetId) & " "

         Case UpdateFilters.CantidadDev
            strSQL = " UPDATE comCompraDet "
            strSQL &= " SET CantidadDev = CantidadDev + " & DecimalToField(mdecCantidadDev) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND AlmacenId = " & NumberToField(mlngAlmacenId)

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
               mlngCompraDetId = ToLong(oDataRow("CompraDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngMedidaId = ToLong(oDataRow("MedidaId"))
               mdecCantidad = ToDecimal(oDataRow("Cantidad"))
               mdecPrecioOrg = ToDecimal(oDataRow("PrecioOrg"))
               mdecPrecioCos = ToDecimal(oDataRow("PrecioCos"))
               mdecPrecioRec = ToDouble(oDataRow("PrecioRec"))
               mdecPrecioDes = ToDouble(oDataRow("PrecioDes"))
               mdecImporte = ToDecimal(oDataRow("Importe"))
               mdecImporteBru = ToDecimal(oDataRow("ImporteBru"))
               mdecPrecioPorFac = ToDecimal(oDataRow("PrecioPorFac"))
               mstrCompraDetDes = ToStr(oDataRow("CompraDetDes"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mdecCantidadDev = ToDecimal(oDataRow("CantidadDev"))
               mlngPlanIdAct = ToLong(oDataRow("PlanIdAct"))
               mlngPlanAddIdAct = ToLong(oDataRow("PlanAddIdAct"))
               mlngCentroCostoIdAct = ToLong(oDataRow("CentroCostoIdAct"))
               mlngCentroCostoDetIdAct = ToLong(oDataRow("CentroCostoDetIdAct"))
               mlngSucursalIdAct = ToLong(oDataRow("SucursalIdAct"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompraDetId = ToLong(oDataRow("CompraDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompraDetId = TableIDGet(mstrTableName, "CompraDetId", moConnection)

         If mlngCompraDetId = -1 Then
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

      'If mlngEmpresaId = 0 Then
      '   strMsg &= "Empresa Inválida" & vbCrLf
      'End If

      'If mlngGestionId = 0 Then
      '   strMsg &= "Gestion Inválida" & vbCrLf
      'End If

      'If mlngCompraId = 0 Then
      '   strMsg &= "Seleccione el Tipo de CompraDetrobante" & vbCrLf
      'End If

      'If mlngMonedaId = 0 Then
      '   strMsg &= "Seleccione la Moneda" & vbCrLf
      'End If

      'If mdecTipoCambio = 0 Then
      '   strMsg &= "Tipo de Cambio Inválido" & vbCrLf
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
         'strSQL &= " FROM comCompraDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCompraDet.TipoCompraId = " & NumberToField(mlngTipoCompraId)
         'Else
         '   strSQL &= " WHERE  comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCompraDet.TipoCompraId = " & NumberToField(mlngTipoCompraId)
         '   strSQL &= " AND  comCompraDet.CompraDetId <> " & NumberToField(mlngCompraDetId)
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

   Public Function RowSum() As Decimal
      Dim oCommand As OleDbCommand
      Dim decRecordsAffected As Decimal

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowSumSQL()
         oCommand.Connection = moConnection

         decRecordsAffected = ToDecimal(oCommand.ExecuteScalar)

         Return decRecordsAffected

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
