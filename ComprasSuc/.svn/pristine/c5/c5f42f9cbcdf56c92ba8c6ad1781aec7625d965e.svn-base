Imports System.Data
Imports System.Data.OleDb

Public Class clsItem
   Implements IDisposable

   Private mlngItemId As Long
   Private mlngEmpresaId As Long
   Private mlngLineaId As Long
   Private mlngGrupoId As Long
   Private mlngSubGrupoId As Long
   Private mlngMarcaId As Long
   Private mlngFabricaId As Long
   Private mlngPlanGrupoId As Long
   Private mstrItemCod As String
   Private mstrItemDes As String
   Private mstrItemDesAbr As String
   Private mstrUbicacion As String
   Private mstrImagen As String
   Private mlngMedidaId As Long
   Private mlngMedidaIdEqui As Long
   Private mdecMedidaCantEqui As Decimal
   Private mlngTipoItemId As Long
   Private mbytControlLote As Byte
   Private mbytControlSerie As Byte
   Private mdecCantidadMin As Decimal
   Private mdecCantidadMax As Decimal
   Private mlngMonedaIdCos As Long
   Private mlngMonedaIdVen As Long
   Private mlngTipoCosteoId As Long
   Private mlngTipoTasaId As Long
   Private mdecTipoTasaMonto As Decimal
   Private mlngPrecioCalculoId As Long
   Private mdecComision As Decimal
   Private mdecUtilidad As Decimal
   Private mstrObs As String
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
   Property ItemId() As Long
      Get
         Return mlngItemId
      End Get

      Set(ByVal Value As Long)
         mlngItemId = Value
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

   Property LineaId() As Long
      Get
         Return mlngLineaId
      End Get

      Set(ByVal Value As Long)
         mlngLineaId = Value
      End Set
   End Property

   Property GrupoId() As Long
      Get
         Return mlngGrupoId
      End Get

      Set(ByVal Value As Long)
         mlngGrupoId = Value
      End Set
   End Property

   Property SubGrupoId() As Long
      Get
         Return mlngSubGrupoId
      End Get

      Set(ByVal Value As Long)
         mlngSubGrupoId = Value
      End Set
   End Property

   Property MarcaId() As Long
      Get
         Return mlngMarcaId
      End Get

      Set(ByVal Value As Long)
         mlngMarcaId = Value
      End Set
   End Property

   Property FabricaId() As Long
      Get
         Return mlngFabricaId
      End Get

      Set(ByVal Value As Long)
         mlngFabricaId = Value
      End Set
   End Property

   Property PlanGrupoId() As Long
      Get
         Return mlngPlanGrupoId
      End Get

      Set(ByVal Value As Long)
         mlngPlanGrupoId = Value
      End Set
   End Property

   Property ItemCod() As String
      Get
         Return mstrItemCod
      End Get

      Set(ByVal Value As String)
         mstrItemCod = Value
      End Set
   End Property

   Property ItemDes() As String
      Get
         Return mstrItemDes
      End Get

      Set(ByVal Value As String)
         mstrItemDes = Value
      End Set
   End Property

   Property ItemDesAbr() As String
      Get
         Return mstrItemDesAbr
      End Get

      Set(ByVal Value As String)
         mstrItemDesAbr = Value
      End Set
   End Property

   Property Ubicacion() As String
      Get
         Return mstrUbicacion
      End Get

      Set(ByVal Value As String)
         mstrUbicacion = Value
      End Set
   End Property

   Property Imagen() As String
      Get
         Return mstrImagen
      End Get

      Set(ByVal Value As String)
         mstrImagen = Value
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

   Property MedidaIdEqui() As Long
      Get
         Return mlngMedidaIdEqui
      End Get

      Set(ByVal Value As Long)
         mlngMedidaIdEqui = Value
      End Set
   End Property

   Property MedidaCantEqui() As Decimal
      Get
         Return mdecMedidaCantEqui
      End Get

      Set(ByVal Value As Decimal)
         mdecMedidaCantEqui = Value
      End Set
   End Property

   Property TipoItemId() As Long
      Get
         Return mlngTipoItemId
      End Get

      Set(ByVal Value As Long)
         mlngTipoItemId = Value
      End Set
   End Property

   Property ControlLote() As Byte
      Get
         Return mbytControlLote
      End Get

      Set(ByVal Value As Byte)
         mbytControlLote = Value
      End Set
   End Property

   Property ControlSerie() As Byte
      Get
         Return mbytControlSerie
      End Get

      Set(ByVal Value As Byte)
         mbytControlSerie = Value
      End Set
   End Property

   Property CantidadMin() As Decimal
      Get
         Return mdecCantidadMin
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidadMin = Value
      End Set
   End Property

   Property CantidadMax() As Decimal
      Get
         Return mdecCantidadMax
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidadMax = Value
      End Set
   End Property

   Property MonedaIdCos() As Long
      Get
         Return mlngMonedaIdCos
      End Get

      Set(ByVal Value As Long)
         mlngMonedaIdCos = Value
      End Set
   End Property

   Property MonedaIdVen() As Long
      Get
         Return mlngMonedaIdVen
      End Get

      Set(ByVal Value As Long)
         mlngMonedaIdVen = Value
      End Set
   End Property

   Property TipoCosteoId() As Long
      Get
         Return mlngTipoCosteoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCosteoId = Value
      End Set
   End Property

   Property TipoTasaId() As Long
      Get
         Return mlngTipoTasaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoTasaId = Value
      End Set
   End Property

   Property TipoTasaMonto() As Decimal
      Get
         Return mdecTipoTasaMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoTasaMonto = Value
      End Set
   End Property

   Property PrecioCalculoId() As Long
      Get
         Return mlngPrecioCalculoId
      End Get

      Set(ByVal Value As Long)
         mlngPrecioCalculoId = Value
      End Set
   End Property

   Property Comision() As Decimal
      Get
         Return mdecComision
      End Get

      Set(ByVal Value As Decimal)
         mdecComision = Value
      End Set
   End Property

   Property Utilidad() As Decimal
      Get
         Return mdecUtilidad
      End Get

      Set(ByVal Value As Decimal)
         mdecUtilidad = Value
      End Set
   End Property

   Property Obs() As String
      Get
         Return mstrObs
      End Get

      Set(ByVal Value As String)
         mstrObs = Value
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
      GridCheck = 4
      GridFind = 5
      ItemIdMedidas = 6
      ItemCodNext = 7
      GridFindDT = 8
      GridFindSustituto = 9
      GridItemTouch = 10 ''AppMovil
      ListBoxSaldo = 11

   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      GridCheck = 6
      PlanGrupoId = 7
      SubGrupoId = 8
      MarcaId = 9
      FabricaId = 10
      MedidaId = 11
      GridLoteCheck = 12
      GridFind = 13
      ItemCod = 14
      TipoItemId = 15
      TipoItemIdNot = 16
      EstadoId = 17
      ItemIdMedidas = 18
      GridCheckItemInventario = 19
      GridFindDT = 20
      GridFindSustituto = 22
      ItemIdTieneMov = 23
      GridItemTouch = 24 ''AppMovil
      Saldo = 25

   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ItemId = 1
      Grid = 3
      Report = 4
      ItemDes = 5
      GridCheck = 6
      GridFind = 7
      LineaDes = 8
      GrupoDes = 9
      SubGrupoDes = 10
      ItemCod = 11
      GridItemTouch = 12 ''AppMovil
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
      mstrTableName = "invItem"
      mstrClassName = "clsItem"

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
      mlngItemId = 0
      mlngEmpresaId = 0
      mlngLineaId = 0
      mlngGrupoId = 0
      mlngSubGrupoId = 0
      mlngMarcaId = 0
      mlngFabricaId = 0
      mlngPlanGrupoId = 0
      mstrItemCod = ""
      mstrItemDes = ""
      mstrItemDesAbr = ""
      mstrUbicacion = ""
      mstrImagen = ""
      mlngMedidaId = 0
      mlngMedidaIdEqui = 0
      mdecMedidaCantEqui = 0
      mlngTipoItemId = 0
      mbytControlLote = 0
      mbytControlSerie = 0
      mdecCantidadMin = 0
      mdecCantidadMax = 0
      mlngMonedaIdCos = 0
      mlngMonedaIdVen = 0
      mlngTipoCosteoId = 0
      mlngTipoTasaId = 0
      mdecTipoTasaMonto = 0
      mlngPrecioCalculoId = 0
      mdecComision = 0
      mdecUtilidad = 0
      mstrObs = ""
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
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.EmpresaId,  "
            strSQL &= "    invItem.LineaId,  "
            strSQL &= "    invItem.GrupoId,  "
            strSQL &= "    invItem.SubGrupoId,  "
            strSQL &= "    invItem.MarcaId,  "
            strSQL &= "    invItem.FabricaId,  "
            strSQL &= "    invItem.PlanGrupoId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ItemDesAbr,  "
            strSQL &= "    invItem.Ubicacion,  "
            strSQL &= "    invItem.Imagen,  "
            strSQL &= "    invItem.MedidaId,  "
            strSQL &= "    invItem.MedidaIdEqui,  "
            strSQL &= "    invItem.MedidaCantEqui,  "
            strSQL &= "    invItem.TipoItemId,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invItem.CantidadMin,  "
            strSQL &= "    invItem.CantidadMax,  "
            strSQL &= "    invItem.MonedaIdCos,  "
            strSQL &= "    invItem.MonedaIdVen,  "
            strSQL &= "    invItem.TipoCosteoId,  "
            strSQL &= "    invItem.TipoTasaId,  "
            strSQL &= "    invItem.TipoTasaMonto,  "
            strSQL &= "    invItem.PrecioCalculoId,  "
            strSQL &= "    invItem.Comision,  "
            strSQL &= "    invItem.Utilidad,  "
            strSQL &= "    invItem.Obs,  "
            strSQL &= "    invItem.EstadoId,  "
            strSQL &= "    invItem.sLastUpdate_id,  "
            strSQL &= "    invItem.dtLastUpdate_dt,  "
            strSQL &= "    invItem.iConcurrency_id  "
            strSQL &= " FROM invItem "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.TipoItemId,  "
            strSQL &= "    invItem.ItemDes  "
            strSQL &= " FROM invItem "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.EmpresaId,  "
            strSQL &= "    invLinea.LineaId,  "
            strSQL &= "    invLinea.LineaDes,  "
            strSQL &= "    invGrupo.GrupoId,  "
            strSQL &= "    invGrupo.GrupoDes,  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.SubGrupoDes,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ItemDesAbr,  "
            strSQL &= "    invItem.Ubicacion,  "
            strSQL &= "    invItem.Imagen,  "
            strSQL &= "    invMarca.MarcaId,  "
            strSQL &= "    invMarca.MarcaDes,  "
            strSQL &= "    invFabrica.FabricaId,  "
            strSQL &= "    invFabrica.FabricaDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invMedidaEqui.MedidaId As MedidaIdEqui,  "
            strSQL &= "    invMedidaEqui.MedidaDes As MedidaDesEqui,  "
            strSQL &= "    invItem.MedidaCantEqui,  "
            strSQL &= "    invTipoItem.TipoItemId,  "
            strSQL &= "    invTipoItem.TipoItemDes,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invItem.CantidadMin,  "
            strSQL &= "    invItem.CantidadMax,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invTipoCosteo.TipoCosteoId,  "
            strSQL &= "    invTipoCosteo.TipoCosteoDes,  "
            strSQL &= "    invTipoTasa.TipoTasaId,  "
            strSQL &= "    invTipoTasa.TipoTasaDes,  "
            strSQL &= "    invItem.TipoTasaMonto,  "
            strSQL &= "    invPlanGrupo.PlanGrupoId,  "
            strSQL &= "    invPlanGrupo.PlanGrupoDes,  "
            strSQL &= "    invItem.Comision,  "
            strSQL &= "    invItem.Utilidad,  "
            strSQL &= "    invItem.Obs,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM invItem, invLinea, invGrupo, invSubGrupo, invMarca, invFabrica, "
            strSQL &= " invMedida, invTipoItem, tblMoneda, "
            strSQL &= " invTipoCosteo, invMedida As invMedidaEqui, invTipoTasa, invPlanGrupo, tblEstado "

         Case SelectFilters.Report

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.EmpresaId,  "
            strSQL &= "    invLinea.LineaId,  "
            strSQL &= "    invLinea.LineaDes,  "
            strSQL &= "    invGrupo.GrupoId,  "
            strSQL &= "    invGrupo.GrupoDes,  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.SubGrupoDes,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ItemDesAbr,  "
            strSQL &= "    invItem.Ubicacion,  "
            strSQL &= "    invMarca.MarcaId,  "
            strSQL &= "    invMarca.MarcaDes,  "
            strSQL &= "    invFabrica.FabricaId,  "
            strSQL &= "    invFabrica.FabricaDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invMedidaEqui.MedidaId As MedidaIdEqui,  "
            strSQL &= "    invMedidaEqui.MedidaDes As MedidaDesEqui,  "
            strSQL &= "    invTipoItem.TipoItemId,  "
            strSQL &= "    invTipoItem.TipoItemDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invTipoCosteo.TipoCosteoId,  "
            strSQL &= "    invTipoCosteo.TipoCosteoDes,  "
            strSQL &= "    invPlanGrupo.PlanGrupoId,  "
            strSQL &= "    invPlanGrupo.PlanGrupoDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM invItem, invLinea, invGrupo, invSubGrupo, invMarca, invFabrica, "
            strSQL &= " invMedida, invTipoItem, tblMoneda, invTipoCosteo, invMedida As invMedidaEqui, invPlanGrupo, tblEstado "

         Case SelectFilters.GridFind
            strSQL = " SELECT  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invMedidaEqui.MedidaId As MedidaIdEqui,  "
            strSQL &= "    invMedidaEqui.MedidaDes As MedidaDesEqui,  "
            strSQL &= "    invItem.MedidaCantEqui,  "
            strSQL &= "    0.0 As Saldo,  "
            strSQL &= "    0.0 As Precio,  "
            strSQL &= "    0.0 As PrecioEqui,  "
            strSQL &= "    invLinea.LineaId,  "
            strSQL &= "    invLinea.LineaDes,  "
            strSQL &= "    invGrupo.GrupoId,  "
            strSQL &= "    invGrupo.GrupoDes,  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.SubGrupoDes,  "
            strSQL &= "    invTipoItem.TipoItemId,  "
            strSQL &= "    invTipoItem.TipoItemDes,  "
            strSQL &= "    invMarca.MarcaId,  "
            strSQL &= "    invMarca.MarcaDes,  "
            strSQL &= "    invFabrica.FabricaId,  "
            strSQL &= "    invFabrica.FabricaDes  "
            strSQL &= " FROM invItem, invLinea, invGrupo, invSubGrupo, invTipoItem, "
            strSQL &= " invMarca, invFabrica, invMedida, invMedida As invMedidaEqui "

         Case SelectFilters.ItemIdMedidas
            strSQL = " SELECT  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invMedidaEqui.MedidaId As MedidaIdEqui,  "
            strSQL &= "    invMedidaEqui.MedidaDes As MedidaDesEqui,  "
            strSQL &= "    invItem.MedidaCantEqui  "
            strSQL &= " FROM invItem, invMedida, invMedida As invMedidaEqui "

         Case SelectFilters.ItemCodNext
            strSQL = " SELECT MAX "
            strSQL &= "    ( Case "
            strSQL &= "         WHEN ItemCod LIKE '%[^0-9]%' THEN 0 "
            strSQL &= "         ELSE CAST(ItemCod AS bigint) "
            strSQL &= "      END) AS ItemCod "
            strSQL &= " FROM invItem "

         Case SelectFilters.GridFindDT
            strSQL = " SELECT  "
            strSQL &= "    DISTINCT (invItem.ItemId),  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invMedidaEqui.MedidaId As MedidaIdEqui,  "
            strSQL &= "    invMedidaEqui.MedidaDes As MedidaDesEqui,  "
            strSQL &= "    invItem.MedidaCantEqui,  "
            strSQL &= "    0.0 As Saldo,  "
            strSQL &= "    0.0 As Precio,  "
            strSQL &= "    0.0 As PrecioEqui,  "
            strSQL &= "    invLinea.LineaId,  "
            strSQL &= "    invLinea.LineaDes,  "
            strSQL &= "    invGrupo.GrupoId,  "
            strSQL &= "    invGrupo.GrupoDes,  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.SubGrupoDes,  "
            strSQL &= "    invTipoItem.TipoItemId,  "
            strSQL &= "    invTipoItem.TipoItemDes,  "
            strSQL &= "    invMarca.MarcaId,  "
            strSQL &= "    invMarca.MarcaDes,  "
            strSQL &= "    invFabrica.FabricaId,  "
            strSQL &= "    invFabrica.FabricaDes  "
            strSQL &= " FROM invItem, invLinea, invGrupo, invSubGrupo, invTipoItem, "
            strSQL &= " invMarca, invFabrica, invMedida, invMedida As invMedidaEqui, "
            strSQL &= " invDatoTecnico "

         Case SelectFilters.GridFindSustituto
            strSQL = " SELECT  "
            strSQL &= "    DISTINCT (invItem.ItemId),  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invMedidaEqui.MedidaId As MedidaIdEqui,  "
            strSQL &= "    invMedidaEqui.MedidaDes As MedidaDesEqui,  "
            strSQL &= "    invItem.MedidaCantEqui,  "
            strSQL &= "    0.0 As Saldo,  "
            strSQL &= "    0.0 As Precio,  "
            strSQL &= "    0.0 As PrecioEqui,  "
            strSQL &= "    invLinea.LineaId,  "
            strSQL &= "    invLinea.LineaDes,  "
            strSQL &= "    invGrupo.GrupoId,  "
            strSQL &= "    invGrupo.GrupoDes,  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.SubGrupoDes,  "
            strSQL &= "    invTipoItem.TipoItemId,  "
            strSQL &= "    invTipoItem.TipoItemDes,  "
            strSQL &= "    invMarca.MarcaId,  "
            strSQL &= "    invMarca.MarcaDes,  "
            strSQL &= "    invFabrica.FabricaId,  "
            strSQL &= "    invFabrica.FabricaDes  "
            strSQL &= " FROM invItem, invLinea, invGrupo, invSubGrupo, invTipoItem, "
            strSQL &= " invMarca, invFabrica, invMedida, invMedida As invMedidaEqui, "
            strSQL &= " invSustituto "

         Case SelectFilters.GridItemTouch ''AppMovil
            strSQL = " SELECT  "
            strSQL &= "    CAST(0 AS bit) As Sel,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.EmpresaId,  "
            strSQL &= "    invLinea.LineaId,  "
            strSQL &= "    invLinea.LineaDes,  "
            strSQL &= "    invGrupo.GrupoId,  "
            strSQL &= "    invGrupo.GrupoDes,  "
            strSQL &= "    invSubGrupo.SubGrupoId,  "
            strSQL &= "    invSubGrupo.SubGrupoDes,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ItemDesAbr,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invMedidaEqui.MedidaId As MedidaIdEqui,  "
            strSQL &= "    invMedidaEqui.MedidaDes As MedidaDesEqui,  "
            strSQL &= "    invTipoItem.TipoItemId,  "
            strSQL &= "    invTipoItem.TipoItemDes,  "
            strSQL &= "    CAST(0 AS int) AS Orden,  "
            strSQL &= "    CAST(NULL AS image) AS Imagen,  "
            strSQL &= "    'Empty' As Estado  "
            strSQL &= " FROM invItem, invLinea, invGrupo, invSubGrupo, invMedida, invTipoItem, invMedida As invMedidaEqui "

         Case SelectFilters.ListBoxSaldo
            strSQL = " SELECT  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.TipoItemId,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItemSaldo.Saldo "
            strSQL &= " FROM invItem,invItemSaldo "

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
            strSQL = " WHERE  invItem.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.Grid
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.LineaId = invLinea.LineaId "
            strSQL &= " AND  invItem.GrupoId = invGrupo.GrupoId "
            strSQL &= " AND  invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND  invItem.MarcaId = invMarca.MarcaId "
            strSQL &= " AND  invItem.FabricaId = invFabrica.FabricaId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "
            strSQL &= " AND  invItem.TipoItemId = invTipoItem.TipoItemId "
            strSQL &= " AND  invItem.MonedaIdCos = tblMoneda.MonedaId "
            strSQL &= " AND  invItem.TipoCosteoId = invTipoCosteo.TipoCosteoId "
            strSQL &= " AND  invItem.TipoTasaId = invTipoTasa.TipoTasaId "
            strSQL &= " AND  invItem.PlanGrupoId = invPlanGrupo.PlanGrupoId "
            strSQL &= " AND  invItem.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report

         Case WhereFilters.GridCheck
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.LineaId = invLinea.LineaId "
            strSQL &= " AND  invItem.GrupoId = invGrupo.GrupoId "
            strSQL &= " AND  invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND  invItem.MarcaId = invMarca.MarcaId "
            strSQL &= " AND  invItem.FabricaId = invFabrica.FabricaId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "
            strSQL &= " AND  invItem.TipoItemId = invTipoItem.TipoItemId "
            strSQL &= " AND  invItem.MonedaIdCos = tblMoneda.MonedaId "
            strSQL &= " AND  invItem.TipoCosteoId = invTipoCosteo.TipoCosteoId "
            strSQL &= " AND  invItem.PlanGrupoId = invPlanGrupo.PlanGrupoId "
            strSQL &= " AND  invItem.EstadoId = tblEstado.EstadoId "

            If mlngTipoItemId <> 0 Then
               If mlngTipoTasaId <> 0 Then ''Item Distinct
                  strSQL &= " AND  invItem.TipoItemId <> " & NumberToField(mlngTipoItemId)
               Else
                  strSQL &= " AND  invItem.TipoItemId = " & NumberToField(mlngTipoItemId)
               End If
            End If

         Case WhereFilters.PlanGrupoId
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.PlanGrupoId = " & NumberToField(mlngPlanGrupoId)

         Case WhereFilters.SubGrupoId
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.SubGrupoId = " & NumberToField(mlngSubGrupoId)

         Case WhereFilters.MarcaId
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.MarcaId = " & NumberToField(mlngMarcaId)

         Case WhereFilters.FabricaId
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.FabricaId = " & NumberToField(mlngFabricaId)

         Case WhereFilters.MedidaId
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  (invItem.MedidaId = " & NumberToField(mlngMedidaId)
            strSQL &= " OR  invItem.MedidaIdEqui = " & NumberToField(mlngMedidaId) & ") "

         Case WhereFilters.GridLoteCheck
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.ControlLote = " & NumberToField(mbytControlLote)
            strSQL &= " AND  invItem.LineaId = invLinea.LineaId "
            strSQL &= " AND  invItem.GrupoId = invGrupo.GrupoId "
            strSQL &= " AND  invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND  invItem.MarcaId = invMarca.MarcaId "
            strSQL &= " AND  invItem.FabricaId = invFabrica.FabricaId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "
            strSQL &= " AND  invItem.TipoItemId = invTipoItem.TipoItemId "
            strSQL &= " AND  invItem.MonedaIdCos = tblMoneda.MonedaId "
            strSQL &= " AND  invItem.TipoCosteoId = invTipoCosteo.TipoCosteoId "
            strSQL &= " AND  invItem.PlanGrupoId = invPlanGrupo.PlanGrupoId "

         Case WhereFilters.GridFind
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  invItem.LineaId = invLinea.LineaId "
            strSQL &= " AND  invItem.GrupoId = invGrupo.GrupoId "
            strSQL &= " AND  invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND  invItem.TipoItemId = invTipoItem.TipoItemId "
            strSQL &= " AND  invItem.MarcaId = invMarca.MarcaId "
            strSQL &= " AND  invItem.FabricaId = invFabrica.FabricaId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "
            strSQL &= " AND  invItem.TipoItemId <> 3 " 'Inventario y Servicio 

         Case WhereFilters.ItemCod
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.ItemCod = " & StringToField(mstrItemCod)

         Case WhereFilters.TipoItemId
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  invItem.TipoItemId = " & NumberToField(mlngTipoItemId)

         Case WhereFilters.TipoItemIdNot
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.TipoItemId <> " & NumberToField(mlngTipoItemId)
            If mlngItemId = 0 Then
               strSQL &= " AND  invItem.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (invItem.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  invItem.ItemId = " & NumberToField(mlngItemId) & ") "
            End If

         Case WhereFilters.EstadoId
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngItemId = 0 Then
               strSQL &= " AND  invItem.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (invItem.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  invItem.ItemId = " & NumberToField(mlngItemId) & ") "
            End If

         Case WhereFilters.ItemIdMedidas
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "

         Case WhereFilters.GridCheckItemInventario  'TipoServicio
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.LineaId = invLinea.LineaId "
            strSQL &= " AND  invItem.GrupoId = invGrupo.GrupoId "
            strSQL &= " AND  invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND  invItem.MarcaId = invMarca.MarcaId "
            strSQL &= " AND  invItem.FabricaId = invFabrica.FabricaId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "
            strSQL &= " AND  invItem.TipoItemId = invTipoItem.TipoItemId "
            strSQL &= " AND  invItem.MonedaIdCos = tblMoneda.MonedaId "
            strSQL &= " AND  invItem.TipoCosteoId = invTipoCosteo.TipoCosteoId "
            strSQL &= " AND  invItem.PlanGrupoId = invPlanGrupo.PlanGrupoId "
            strSQL &= " AND  invItem.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  invItem.TipoItemId = " & NumberToField(clsTipoItem.INVENTARIO)

         Case WhereFilters.GridFindDT
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  invItem.LineaId = invLinea.LineaId "
            strSQL &= " AND  invItem.GrupoId = invGrupo.GrupoId "
            strSQL &= " AND  invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND  invItem.TipoItemId = invTipoItem.TipoItemId "
            strSQL &= " AND  invItem.MarcaId = invMarca.MarcaId "
            strSQL &= " AND  invItem.FabricaId = invFabrica.FabricaId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "
            strSQL &= " AND  invItem.TipoItemId <> 3 " 'Inventario y Servicio 
            strSQL &= " AND  invItem.ItemId = invDatoTecnico.ItemId "

            If mlngLineaId <> 0 Then
               strSQL &= " AND  invItem.LineaId = " & NumberToField(mlngLineaId)
            End If

            If mstrItemDes <> String.Empty Then
               strSQL &= "  " & mstrItemDes ''Cadena de Varios Datos Tecinos
            End If

         Case WhereFilters.GridFindSustituto
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  invItem.LineaId = invLinea.LineaId "
            strSQL &= " AND  invItem.GrupoId = invGrupo.GrupoId "
            strSQL &= " AND  invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND  invItem.TipoItemId = invTipoItem.TipoItemId "
            strSQL &= " AND  invItem.MarcaId = invMarca.MarcaId "
            strSQL &= " AND  invItem.FabricaId = invFabrica.FabricaId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "
            strSQL &= " AND  invItem.TipoItemId <> 3 " 'Inventario y Servicio 
            strSQL &= " AND  invItem.ItemId = invSustituto.ItemIdSus "
            strSQL &= " AND  invSustituto.ItemId  = " & NumberToField(mlngItemId)

         Case WhereFilters.ItemIdTieneMov
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  ( invItem.ItemId IN (SELECT ItemId "
            strSQL &= "                            FROM  invNotaDet "
            strSQL &= "                            WHERE invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR invItem.ItemId IN (SELECT ItemId "
            strSQL &= "                            FROM  comCompraDet "
            strSQL &= "                            WHERE comCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR invItem.ItemId IN (SELECT ItemId "
            strSQL &= "                            FROM  venVentaDet "
            strSQL &= "                            WHERE venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR invItem.ItemId IN (SELECT ItemId "
            strSQL &= "                            FROM  venPedVentaDet "
            strSQL &= "                            WHERE venPedVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR invItem.ItemId IN (SELECT ItemId "
            strSQL &= "                            FROM  comPedCompraDet "
            strSQL &= "                            WHERE comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"

            If TableExits(clsAppInfo.ConnectString, "pdvPtoVentaDet") Then
               strSQL &= "     OR invItem.ItemId IN (SELECT ItemId "
               strSQL &= "                            FROM  pdvPtoVentaDet "
               strSQL &= "                            WHERE pdvPtoVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            End If

            If TableExits(clsAppInfo.ConnectString, "csmPedMovEquipoDet") Then
               strSQL &= "     OR invItem.ItemId IN (SELECT ItemId "
               strSQL &= "                            FROM  csmPedMovEquipoDet "
               strSQL &= "                            WHERE csmPedMovEquipoDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            End If

            If TableExits(clsAppInfo.ConnectString, "csmMovEquipoDet") Then
               strSQL &= "     OR invItem.ItemId IN (SELECT ItemId "
               strSQL &= "                            FROM  csmMovEquipoDet "
               strSQL &= "                            WHERE csmMovEquipoDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            End If

            If TableExits(clsAppInfo.ConnectString, "proProduccionDet") Then
               strSQL &= "     OR invItem.ItemId IN (SELECT Det.ItemId "
               strSQL &= "                            FROM  proProduccionDet Det, proProduccion pro "
               strSQL &= "                            WHERE pro.EmpresaId = " & NumberToField(mlngEmpresaId)
               strSQL &= "                              AND pro.ProduccionId = Det.ProduccionId )"
            End If

            strSQL &= " ) "

         Case WhereFilters.GridItemTouch ''AppMovil
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mstrObs <> "" Then strSQL &= " AND  invItem.LineaId IN (" & mstrObs & ") "
            strSQL &= " AND  invItem.LineaId = invLinea.LineaId "
            strSQL &= " AND  invItem.GrupoId = invGrupo.GrupoId "
            strSQL &= " AND  invItem.SubGrupoId = invSubGrupo.SubGrupoId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MedidaIdEqui = invMedidaEqui.MedidaId "
            strSQL &= " AND  invItem.TipoItemId = invTipoItem.TipoItemId "

         Case WhereFilters.Saldo
            strSQL = " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.ItemId = invItemSaldo.ItemId "
            strSQL &= " AND  invItemSaldo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemSaldo.GestionId = " & NumberToField(mlngGrupoId)
            strSQL &= " AND  invItemSaldo.AlmacenId = " & NumberToField(mlngLineaId)
            If mlngItemId = 0 Then
               strSQL &= " AND  invItem.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (invItem.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  invItem.ItemId = " & NumberToField(mlngItemId) & ") "
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ItemId
            strSQL = " ORDER BY invItem.ItemId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invItem.ItemDes "

         Case OrderByFilters.ItemDes
            strSQL = " ORDER BY invItem.ItemDes "

         Case OrderByFilters.Report

         Case OrderByFilters.GridCheck
            strSQL = " ORDER BY invItem.ItemDes "

         Case OrderByFilters.GridFind
            strSQL = " ORDER BY invItem.ItemDes "

         Case OrderByFilters.LineaDes
            strSQL = " ORDER BY invLinea.LineaDes, invGrupo.GrupoDes, invSubGrupo.SubGrupoDes, invItem.ItemDes "

         Case OrderByFilters.GrupoDes
            strSQL = " ORDER BY invGrupo.GrupoDes, invLinea.LineaDes, invSubGrupo.SubGrupoDes, invItem.ItemDes "

         Case OrderByFilters.SubGrupoDes
            strSQL = " ORDER BY invSubGrupo.SubGrupoDes, invLinea.LineaDes, invGrupo.GrupoDes, invItem.ItemDes "

         Case OrderByFilters.ItemCod
            strSQL = " ORDER BY invItem.ItemCod "

         Case OrderByFilters.GridItemTouch ''AppMovil
            strSQL = " ORDER BY invLinea.LineaDes, invGrupo.GrupoDes, invSubGrupo.SubGrupoDes, invItem.ItemDes "

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
            strSQL = "INSERT INTO invItem ("
            strSQL &= "ItemId, "
            strSQL &= "EmpresaId, "
            strSQL &= "LineaId, "
            strSQL &= "GrupoId, "
            strSQL &= "SubGrupoId, "
            strSQL &= "MarcaId, "
            strSQL &= "FabricaId, "
            strSQL &= "PlanGrupoId, "
            strSQL &= "ItemCod, "
            strSQL &= "ItemDes, "
            strSQL &= "ItemDesAbr, "
            strSQL &= "Ubicacion, "
            strSQL &= "Imagen, "
            strSQL &= "MedidaId, "
            strSQL &= "MedidaIdEqui, "
            strSQL &= "MedidaCantEqui, "
            strSQL &= "TipoItemId, "
            strSQL &= "ControlLote, "
            strSQL &= "ControlSerie, "
            strSQL &= "CantidadMin, "
            strSQL &= "CantidadMax, "
            strSQL &= "MonedaIdCos, "
            strSQL &= "MonedaIdVen, "
            strSQL &= "TipoCosteoId, "
            strSQL &= "TipoTasaId, "
            strSQL &= "TipoTasaMonto, "
            strSQL &= "PrecioCalculoId, "
            strSQL &= "Comision, "
            strSQL &= "Utilidad, "
            strSQL &= "Obs, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngLineaId) & ", "
            strSQL &= NumberToField(mlngGrupoId) & ", "
            strSQL &= NumberToField(mlngSubGrupoId) & ", "
            strSQL &= NumberToField(mlngMarcaId) & ", "
            strSQL &= NumberToField(mlngFabricaId) & ", "
            strSQL &= NumberToField(mlngPlanGrupoId) & ", "
            strSQL &= StringToField(mstrItemCod) & ", "
            strSQL &= StringToField(mstrItemDes) & ", "
            strSQL &= StringToField(mstrItemDesAbr) & ", "
            strSQL &= StringToField(mstrUbicacion) & ", "
            strSQL &= StringToField(mstrImagen) & ", "
            strSQL &= NumberToField(mlngMedidaId) & ", "
            strSQL &= NumberToField(mlngMedidaIdEqui) & ", "
            strSQL &= DecimalToField(mdecMedidaCantEqui) & ", "
            strSQL &= NumberToField(mlngTipoItemId) & ", "
            strSQL &= NumberToField(mbytControlLote) & ", "
            strSQL &= NumberToField(mbytControlSerie) & ", "
            strSQL &= DecimalToField(mdecCantidadMin) & ", "
            strSQL &= DecimalToField(mdecCantidadMax) & ", "
            strSQL &= NumberToField(mlngMonedaIdCos) & ", "
            strSQL &= NumberToField(mlngMonedaIdVen) & ", "
            strSQL &= NumberToField(mlngTipoCosteoId) & ", "
            strSQL &= NumberToField(mlngTipoTasaId) & ", "
            strSQL &= DecimalToField(mdecTipoTasaMonto) & ", "
            strSQL &= NumberToField(mlngPrecioCalculoId) & ", "
            strSQL &= DecimalToField(mdecComision) & ", "
            strSQL &= DecimalToField(mdecUtilidad) & ", "
            strSQL &= StringToField(mstrObs) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invItem SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "LineaId = " & NumberToField(mlngLineaId) & ", "
            strSQL &= "GrupoId = " & NumberToField(mlngGrupoId) & ", "
            strSQL &= "SubGrupoId = " & NumberToField(mlngSubGrupoId) & ", "
            strSQL &= "MarcaId = " & NumberToField(mlngMarcaId) & ", "
            strSQL &= "FabricaId = " & NumberToField(mlngFabricaId) & ", "
            strSQL &= "PlanGrupoId = " & NumberToField(mlngPlanGrupoId) & ", "
            strSQL &= "ItemCod = " & StringToField(mstrItemCod) & ", "
            strSQL &= "ItemDes = " & StringToField(mstrItemDes) & ", "
            strSQL &= "ItemDesAbr = " & StringToField(mstrItemDesAbr) & ", "
            strSQL &= "Ubicacion = " & StringToField(mstrUbicacion) & ", "
            strSQL &= "Imagen = " & StringToField(mstrImagen) & ", "
            strSQL &= "MedidaId = " & NumberToField(mlngMedidaId) & ", "
            strSQL &= "MedidaIdEqui = " & NumberToField(mlngMedidaIdEqui) & ", "
            strSQL &= "MedidaCantEqui = " & DecimalToField(mdecMedidaCantEqui) & ", "
            strSQL &= "TipoItemId = " & NumberToField(mlngTipoItemId) & ", "
            strSQL &= "ControlLote = " & NumberToField(mbytControlLote) & ", "
            strSQL &= "ControlSerie = " & NumberToField(mbytControlSerie) & ", "
            strSQL &= "CantidadMin = " & DecimalToField(mdecCantidadMin) & ", "
            strSQL &= "CantidadMax = " & DecimalToField(mdecCantidadMax) & ", "
            strSQL &= "MonedaIdCos = " & NumberToField(mlngMonedaIdCos) & ", "
            strSQL &= "MonedaIdVen = " & NumberToField(mlngMonedaIdVen) & ", "
            strSQL &= "TipoCosteoId = " & NumberToField(mlngTipoCosteoId) & ", "
            strSQL &= "TipoTasaId = " & NumberToField(mlngTipoTasaId) & ", "
            strSQL &= "TipoTasaMonto = " & DecimalToField(mdecTipoTasaMonto) & ", "
            strSQL &= "PrecioCalculoId = " & NumberToField(mlngPrecioCalculoId) & ", "
            strSQL &= "Comision = " & DecimalToField(mdecComision) & ", "
            strSQL &= "Utilidad = " & DecimalToField(mdecUtilidad) & ", "
            strSQL &= "Obs = " & StringToField(mstrObs) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ItemId = " & NumberToField(mlngItemId) & " "

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
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngLineaId = ToLong(oDataRow("LineaId"))
               mlngGrupoId = ToLong(oDataRow("GrupoId"))
               mlngSubGrupoId = ToLong(oDataRow("SubGrupoId"))
               mlngMarcaId = ToLong(oDataRow("MarcaId"))
               mlngFabricaId = ToLong(oDataRow("FabricaId"))
               mlngPlanGrupoId = ToLong(oDataRow("PlanGrupoId"))
               mstrItemCod = ToStr(oDataRow("ItemCod"))
               mstrItemDes = ToStr(oDataRow("ItemDes"))
               mstrItemDesAbr = ToStr(oDataRow("ItemDesAbr"))
               mstrUbicacion = ToStr(oDataRow("Ubicacion"))
               mstrImagen = ToStr(oDataRow("Imagen"))
               mlngMedidaId = ToLong(oDataRow("MedidaId"))
               mlngMedidaIdEqui = ToLong(oDataRow("MedidaIdEqui"))
               mdecMedidaCantEqui = ToDecimal(oDataRow("MedidaCantEqui"))
               mlngTipoItemId = ToLong(oDataRow("TipoItemId"))
               mbytControlLote = ToByte(oDataRow("ControlLote"))
               mbytControlSerie = ToByte(oDataRow("ControlSerie"))
               mdecCantidadMin = ToDecimal(oDataRow("CantidadMin"))
               mdecCantidadMax = ToDecimal(oDataRow("CantidadMax"))
               mlngMonedaIdCos = ToLong(oDataRow("MonedaIdCos"))
               mlngMonedaIdVen = ToLong(oDataRow("MonedaIdVen"))
               mlngTipoCosteoId = ToLong(oDataRow("TipoCosteoId"))
               mlngTipoTasaId = ToLong(oDataRow("TipoTasaId"))
               mdecTipoTasaMonto = ToDecimal(oDataRow("TipoTasaMonto"))
               mlngPrecioCalculoId = ToLong(oDataRow("PrecioCalculoId"))
               mdecComision = ToDecimal(oDataRow("Comision"))
               mdecUtilidad = ToDecimal(oDataRow("Utilidad"))
               mstrObs = ToStr(oDataRow("Obs"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngItemId = ToLong(oDataRow("ItemId"))
               mstrItemCod = ToStr(oDataRow("ItemCod"))
               mstrItemDes = ToStr(oDataRow("ItemDes"))
               mlngTipoItemId = ToLong(oDataRow("TipoItemId"))

            Case SelectFilters.ItemCodNext
               mstrItemCod = ToStr(oDataRow("ItemCod"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngItemId = TableIDGet(mstrTableName, "ItemId", moConnection)

         If mlngItemId = -1 Then
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

      If mlngLineaId = 0 Then
         strMsg &= "Linea Inválida" & vbCrLf
      End If

      If mlngGrupoId = 0 Then
         strMsg &= "Grupo Inválido" & vbCrLf
      End If

      If mlngSubGrupoId = 0 Then
         strMsg &= "SubGrupo Inválido" & vbCrLf
      End If

      If mstrItemCod.Trim() = String.Empty Then
         strMsg &= "Codigo de Item Inválido" & vbCrLf
      End If

      If mstrItemDes.Trim() = String.Empty Then
         strMsg &= "Descripción de Item Inválida" & vbCrLf
      End If

      If mlngTipoItemId = 0 Then
         strMsg &= "Tipo de Item Inválido" & vbCrLf
      End If

      If mlngTipoItemId <> 2 Then
         If mlngTipoCosteoId = 0 Then
            strMsg &= "Tipo de Costeo Inválido" & vbCrLf
         End If
      End If

      If mlngMedidaId = 0 Then
         strMsg &= "Medida Inválida" & vbCrLf
      End If

      If mlngMedidaIdEqui = 0 Then
         strMsg &= "Medida Equivalente Inválida" & vbCrLf
      End If

      If mdecMedidaCantEqui <= 0 Then
         strMsg &= "Cantidad Equivalente Inválida" & vbCrLf
      End If

      If mlngMonedaIdCos = 0 Then
         strMsg &= "Moneda de Costo Inválida" & vbCrLf
      End If

      If mlngMonedaIdVen = 0 Then
         strMsg &= "Moneda de Venta Inválida" & vbCrLf
      End If

      If (mdecComision < 0) Or (mdecComision > 100) Then
         strMsg &= "Comisión Inválida" & vbCrLf
      End If

      If (mdecUtilidad < 0) Or (mdecUtilidad > 100) Then
         strMsg &= "Utilidad Inválida" & vbCrLf
      End If

      If clsAppInfo.Inventario Then
         If mlngPlanGrupoId = 0 Then
            strMsg &= "Grupo de Cuentas Inválida" & vbCrLf
         End If
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
         strSQL = " SELECT  "
         strSQL &= " Count(*) As NumRecs  "
         strSQL &= " FROM invItem "

         If Not boolReplace Then
            strSQL &= " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.ItemCod = " & StringToField(mstrItemCod)
         Else
            strSQL &= " WHERE  invItem.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItem.ItemCod = " & StringToField(mstrItemCod)
            strSQL &= " AND  invItem.ItemId <> " & NumberToField(mlngItemId)
         End If

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
               Throw New Exception("Código de Item Duplicado")
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
               Throw New Exception("Código de Item Duplicado")
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
