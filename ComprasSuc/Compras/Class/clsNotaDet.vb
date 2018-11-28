Imports System.Data
Imports System.Data.OleDb

Public Class clsNotaDet
   Implements IDisposable

   Private mlngNotaDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoNotaId As Long
   Private mlngTipoMovId As Long
   Private mlngNotaId As Long
   Private mstrFecha As String
   Private mlngAlmacenId As Long
   Private mlngCajaMovId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mlngItemId As Long
   Private mlngMedidaId As Long
   Private mdecCantidadEnt As Decimal
   Private mdecCantidadSal As Decimal
   Private mdecPrecioOrg As Decimal
   Private mdecPrecioCos As Decimal
   Private mdecImporte As Decimal
   Private mstrNotaDetDes As String
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
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
   Property NotaDetId() As Long
      Get
         Return mlngNotaDetId
      End Get

      Set(ByVal Value As Long)
         mlngNotaDetId = Value
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

   Property TipoNotaId() As Long
      Get
         Return mlngTipoNotaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoNotaId = Value
      End Set
   End Property

   Property TipoMovId() As Long
      Get
         Return mlngTipoMovId
      End Get

      Set(ByVal Value As Long)
         mlngTipoMovId = Value
      End Set
   End Property

   Property NotaId() As Long
      Get
         Return mlngNotaId
      End Get

      Set(ByVal Value As Long)
         mlngNotaId = Value
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

   Property CajaMovId() As Long
      Get
         Return mlngCajaMovId
      End Get

      Set(ByVal Value As Long)
         mlngCajaMovId = Value
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

   Property CantidadEnt() As Decimal
      Get
         Return mdecCantidadEnt
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidadEnt = Value
      End Set
   End Property

   Property CantidadSal() As Decimal
      Get
         Return mdecCantidadSal
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidadSal = Value
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

   Property Importe() As Decimal
      Get
         Return mdecImporte
      End Get

      Set(ByVal Value As Decimal)
         mdecImporte = Value
      End Set
   End Property

   Property NotaDetDes() As String
      Get
         Return mstrNotaDetDes
      End Get

      Set(ByVal Value As String)
         mstrNotaDetDes = Value
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

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property CentroCostoDetId() As Long
      Get
         Return mlngCentroCostoDetId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoDetId = Value
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
      Kardex = 4
      FechaDistinta = 5
      AllPlanGrupoId = 6
      ItemRotacion = 7
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      NotaId = 6
      GridTraspaso = 7
      Kardex = 8
      KardexFecha = 9
      TieneMovimiento = 10
      TieneMovimientoFecha = 11
      SaldoAnterior = 12
      SaldoActual = 13
      SaldoFecha = 14
      KardexCentroCosto = 15
      KardexCentroCostoFecha = 16
      TieneMovimientoCentroCosto = 17
      TieneMovimientoCentroCostoFecha = 18
      ItemId = 19
      SaldoFechaIntervalo = 20
      TipoMovId = 21
      ImporteActualPlanGrupoId = 22
      ImporteFechaPlanGrupoId = 23
      FechaPlanGrupoId = 24
      SaldoFechaTipoNota = 25
      KardexCentroCostoDet = 26
      KardexCentroCostoDetFecha = 27
      TieneMovimientoCentroCostoDet = 28
      TieneMovimientoCentroCostoDetFecha = 29
      NotaDetItemId = 30
      ItemRotacion = 31
      ItemRotacionFecha = 32
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      NotaDetId = 1
      Grid = 3
      Report = 4
      NotaId = 5
      Fecha = 6
      FechaPlanGrupoId = 7
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

   Public Enum RowSumFilters As Byte
      CantidadEnt = 1
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
      mstrTableName = "invNotaDet"
      mstrClassName = "clsNotaDet"

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
      mlngNotaDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoNotaId = 0
      mlngTipoMovId = 0
      mlngNotaId = 0
      mstrFecha = ""
      mlngAlmacenId = 0
      mlngCajaMovId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mlngItemId = 0
      mlngMedidaId = 0
      mdecCantidadEnt = 0
      mdecCantidadSal = 0
      mdecPrecioOrg = 0
      mdecPrecioCos = 0
      mdecImporte = 0
      NotaDetDes = ""
      mlngSucursalId = 0
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
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
            strSQL &= "    invNotaDet.NotaDetId,  "
            strSQL &= "    invNotaDet.EmpresaId,  "
            strSQL &= "    invNotaDet.GestionId,  "
            strSQL &= "    invNotaDet.TipoNotaId,  "
            strSQL &= "    invNotaDet.TipoMovId,  "
            strSQL &= "    invNotaDet.NotaId,  "
            strSQL &= "    invNotaDet.Fecha,  "
            strSQL &= "    invNotaDet.AlmacenId,  "
            strSQL &= "    invNotaDet.CajaMovId,  "
            strSQL &= "    invNotaDet.MonedaId,  "
            strSQL &= "    invNotaDet.TipoCambio,  "
            strSQL &= "    invNotaDet.ItemId,  "
            strSQL &= "    invNotaDet.MedidaId,  "
            strSQL &= "    invNotaDet.CantidadEnt,  "
            strSQL &= "    invNotaDet.CantidadSal,  "
            strSQL &= "    invNotaDet.PrecioOrg,  "
            strSQL &= "    invNotaDet.PrecioCos,  "
            strSQL &= "    invNotaDet.Importe,  "
            strSQL &= "    invNotaDet.NotaDetDes,  "
            strSQL &= "    invNotaDet.SucursalId,  "
            strSQL &= "    invNotaDet.CentroCostoId,  "
            strSQL &= "    invNotaDet.CentroCostoDetId,  "
            strSQL &= "    invNotaDet.EstadoId,  "
            strSQL &= "    invNotaDet.sLastUpdate_id,  "
            strSQL &= "    invNotaDet.dtLastUpdate_dt,  "
            strSQL &= "    invNotaDet.iConcurrency_id  "
            strSQL &= " FROM invNotaDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invNotaDet.NotaDetId  "
            strSQL &= " FROM invNotaDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invNotaDet.NotaDetId,  "
            strSQL &= "    invNotaDet.EmpresaId,  "
            strSQL &= "    invNotaDet.NotaId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invNotaDet.CantidadEnt,  "
            strSQL &= "    invNotaDet.CantidadSal,  "
            strSQL &= "    invNotaDet.PrecioCos,  "
            strSQL &= "    invNotaDet.PrecioOrg,  "
            strSQL &= "    invNotaDet.Importe,  "
            strSQL &= "    invNotaDet.NotaDetDes,  "
            strSQL &= "    invNotaDet.SucursalId,  "
            strSQL &= "    invNotaDet.CentroCostoId,  "
            strSQL &= "    invNotaDet.CentroCostoDetId  "
            strSQL &= " FROM invNotaDet, invItem, invMedida "

         Case SelectFilters.Report

         Case SelectFilters.Kardex
            strSQL = " SELECT  "
            strSQL &= "    invNotaDet.NotaDetId,  "
            strSQL &= "    invNotaDet.NotaId,  "
            strSQL &= "    invNotaDet.Fecha,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    invNota.NotaDes,  "
            strSQL &= "    invNotaDet.ItemId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invNotaDet.CantidadEnt,  "
            strSQL &= "    invNotaDet.CantidadSal,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invNotaDet.TipoCambio,  "
            strSQL &= "    invNotaDet.PrecioOrg,  "
            strSQL &= "    invNotaDet.Importe,  "
            strSQL &= "    invNotaDet.PrecioCos  "
            strSQL &= " FROM invNotaDet, invTipoNota, invNota, invAlmacen, tblCentroCosto, invMedida, tblMoneda "

         Case SelectFilters.FechaDistinta
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    invNotaDet.Fecha  "
            strSQL &= " FROM invNotaDet, invItem "

         Case SelectFilters.AllPlanGrupoId
            strSQL = " SELECT  "
            strSQL &= "    invNotaDet.NotaDetId,  "
            strSQL &= "    invNotaDet.EmpresaId,  "
            strSQL &= "    invNotaDet.GestionId,  "
            strSQL &= "    invNotaDet.TipoNotaId,  "
            strSQL &= "    invNotaDet.TipoMovId,  "
            strSQL &= "    invNotaDet.NotaId,  "
            strSQL &= "    invNotaDet.Fecha,  "
            strSQL &= "    invNotaDet.AlmacenId,  "
            strSQL &= "    invNotaDet.MonedaId,  "
            strSQL &= "    invNotaDet.TipoCambio,  "
            strSQL &= "    invNotaDet.ItemId,  "
            strSQL &= "    invNotaDet.MedidaId,  "
            strSQL &= "    invNotaDet.CantidadEnt,  "
            strSQL &= "    invNotaDet.CantidadSal,  "
            strSQL &= "    invNotaDet.PrecioOrg,  "
            strSQL &= "    invNotaDet.PrecioCos,  "
            strSQL &= "    invNotaDet.Importe,  "
            strSQL &= "    invNotaDet.SucursalId,  "
            strSQL &= "    invNotaDet.CentroCostoId,  "
            strSQL &= "    invNotaDet.EstadoId,  "
            strSQL &= "    invNotaDet.sLastUpdate_id,  "
            strSQL &= "    invNotaDet.dtLastUpdate_dt,  "
            strSQL &= "    invNotaDet.iConcurrency_id  "
            strSQL &= " FROM invNotaDet, invItem  "

         Case SelectFilters.ItemRotacion
            strSQL = " SELECT  "
            strSQL &= "    invNotaDet.Fecha,  "
            strSQL &= "    invNotaDet.ItemId,  "
            strSQL &= "    invNotaDet.MedidaId,  "
            strSQL &= "    invNotaDet.CantidadEnt,  "
            strSQL &= "    invNotaDet.CantidadSal  "
            strSQL &= " FROM invNotaDet  "

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
            strSQL = " WHERE  invNotaDet.NotaDetId = " & NumberToField(mlngNotaDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invNotaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.Report

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.NotaId
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.NotaId = " & NumberToField(mlngNotaId)

         Case WhereFilters.GridTraspaso
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invNotaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invNotaDet.TipoMovId = 2 "

         Case WhereFilters.Kardex
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNotaDet.NotaId = invNota.NotaId "
            strSQL &= " AND  invNotaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invNotaDet.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invNotaDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.KardexFecha
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNotaDet.NotaId = invNota.NotaId "
            strSQL &= " AND  invNotaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invNotaDet.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invNotaDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.TieneMovimiento
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.TieneMovimientoFecha
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.SaldoAnterior
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.Fecha < " & DateToField(mstrFecha)
            strSQL &= " AND  (invNotaDet.EstadoId = " & NumberToField(clsEstado.CERRADO)
            strSQL &= " OR  invNotaDet.EstadoId = " & NumberToField(clsEstado.ABIERTO)
            strSQL &= " ) "

         Case WhereFilters.SaldoActual
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  (invNotaDet.EstadoId = " & NumberToField(clsEstado.CERRADO)
            strSQL &= " OR  invNotaDet.EstadoId = " & NumberToField(clsEstado.ABIERTO)
            strSQL &= " ) "

         Case WhereFilters.SaldoFecha
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrFecha)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.SaldoFechaIntervalo
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.KardexCentroCosto
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " Or  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoMovId) & ")"
            strSQL &= " AND  invNotaDet.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNotaDet.NotaId = invNota.NotaId "
            strSQL &= " AND  invNotaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invNotaDet.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invNotaDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.KardexCentroCostoFecha
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " Or  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoMovId) & ")"
            strSQL &= " AND  invNotaDet.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNotaDet.NotaId = invNota.NotaId "
            strSQL &= " AND  invNotaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invNotaDet.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invNotaDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.TieneMovimientoCentroCosto
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)

            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If

            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " Or  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoMovId) & ")"
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.TieneMovimientoCentroCostoFecha
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  invNotaDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " Or  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoMovId) & ")"
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.ItemId
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.TipoMovId
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.TipoMovId = " & NumberToField(mlngTipoMovId)

         Case WhereFilters.ImporteActualPlanGrupoId
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invNotaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  invItem.PlanGrupoId = " & NumberToField(mlngTipoNotaId) 'PlanGrupoId
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.ImporteFechaPlanGrupoId
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invNotaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  invItem.PlanGrupoId = " & NumberToField(mlngTipoNotaId) 'PlanGrupoId
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrFecha)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.FechaPlanGrupoId
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invNotaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  invItem.PlanGrupoId = " & NumberToField(mlngTipoNotaId) 'PlanGrupoId
            strSQL &= " AND  invNotaDet.Fecha = " & DateToField(mstrFecha)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.SaldoFechaTipoNota
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " AND  invNotaDet.TipoMovId = " & NumberToField(mlngTipoMovId)
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "


         Case WhereFilters.KardexCentroCostoDet
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)

            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If

            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  invNotaDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
            strSQL &= " AND  (invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " Or  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoMovId) & ")"
            strSQL &= " AND  invNotaDet.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNotaDet.NotaId = invNota.NotaId "
            strSQL &= " AND  invNotaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invNotaDet.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invNotaDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.KardexCentroCostoDetFecha
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)

            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If

            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)

            strSQL &= " AND  invNotaDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  invNotaDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)            
            strSQL &= " AND  (invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " Or  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoMovId) & ")"
            strSQL &= " AND  invNotaDet.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNotaDet.NotaId = invNota.NotaId "
            strSQL &= " AND  invNotaDet.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invNotaDet.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invNotaDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.TieneMovimientoCentroCostoDet
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)

            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If

            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  invNotaDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
            strSQL &= " AND  (invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " Or  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoMovId) & ")"
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.TieneMovimientoCentroCostoDetFecha
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)

            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If

            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  invNotaDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  invNotaDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
            strSQL &= " AND  (invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " Or  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoMovId) & ")"
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.NotaDetItemId
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.ItemRotacion
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

         Case WhereFilters.ItemRotacionFecha
            strSQL = " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNotaDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invNotaDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " AND  invNotaDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invNotaDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  invNotaDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (invNotaDet.EstadoId = 10 "
            strSQL &= " OR  invNotaDet.EstadoId = 11) "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.NotaDetId
            strSQL = " ORDER BY invNotaDet.NotaDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invNotaDet.NotaDetId "

         Case OrderByFilters.Report

         Case OrderByFilters.NotaId
            strSQL = " ORDER BY invNotaDet.NotaId "

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY invNotaDet.Fecha, invNotaDet.NotaId "

         Case OrderByFilters.FechaPlanGrupoId
            strSQL = " ORDER BY invNotaDet.Fecha "

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
         Case RowSumFilters.CantidadEnt
            strSQL = "SELECT Sum(CantidadEnt) As NumRecs FROM " & mstrTableName
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
            strSQL = "INSERT INTO invNotaDet ("
            strSQL &= "NotaDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoNotaId, "
            strSQL &= "TipoMovId, "
            strSQL &= "NotaId, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenId, "
            strSQL &= "CajaMovId,  "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "ItemId, "
            strSQL &= "MedidaId, "
            strSQL &= "CantidadEnt, "
            strSQL &= "CantidadSal, "
            strSQL &= "PrecioOrg, "
            strSQL &= "PrecioCos, "
            strSQL &= "Importe, "
            strSQL &= "NotaDetDes, "
            strSQL &= "SucursalId, "
            strSQL &= "CentroCostoId, "
            strSQL &= "CentroCostoDetId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngNotaDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoNotaId) & ", "
            strSQL &= NumberToField(mlngTipoMovId) & ", "
            strSQL &= NumberToField(mlngNotaId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngCajaMovId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= NumberToField(mlngMedidaId) & ", "
            strSQL &= DecimalToField(mdecCantidadEnt) & ", "
            strSQL &= DecimalToField(mdecCantidadSal) & ", "
            strSQL &= DecimalToField(mdecPrecioOrg) & ", "
            strSQL &= DecimalToField(mdecPrecioCos) & ", "
            strSQL &= DecimalToField(mdecImporte) & ", "
            strSQL &= StringToField(mstrNotaDetDes) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invNotaDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoNotaId = " & NumberToField(mlngTipoNotaId) & ", "
            strSQL &= "TipoMovId = " & NumberToField(mlngTipoMovId) & ", "
            strSQL &= "NotaId = " & NumberToField(mlngNotaId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "CajaMovId = " & NumberToField(mlngCajaMovId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "MedidaId = " & NumberToField(mlngMedidaId) & ", "
            strSQL &= "CantidadEnt = " & DecimalToField(mdecCantidadEnt) & ", "
            strSQL &= "CantidadSal = " & DecimalToField(mdecCantidadSal) & ", "
            strSQL &= "PrecioOrg = " & DecimalToField(mdecPrecioOrg) & ", "
            strSQL &= "PrecioCos = " & DecimalToField(mdecPrecioCos) & ", "
            strSQL &= "Importe = " & DecimalToField(mdecImporte) & ", "
            strSQL &= "NotaDetDes = " & StringToField(mstrNotaDetDes) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " NotaDetId = " & NumberToField(mlngNotaDetId) & " "

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
               mlngNotaDetId = ToLong(oDataRow("NotaDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoNotaId = ToLong(oDataRow("TipoNotaId"))
               mlngTipoMovId = ToLong(oDataRow("TipoMovId"))
               mlngNotaId = ToLong(oDataRow("NotaId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngCajaMovId = ToLong(oDataRow("CajaMovId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngMedidaId = ToLong(oDataRow("MedidaId"))
               mdecCantidadEnt = ToDecimal(oDataRow("CantidadEnt"))
               mdecCantidadSal = ToDecimal(oDataRow("CantidadSal"))
               mdecPrecioOrg = ToDecimal(oDataRow("PrecioOrg"))
               mdecPrecioCos = ToDecimal(oDataRow("PrecioCos"))
               mdecImporte = ToDecimal(oDataRow("Importe"))
               mstrNotaDetDes = ToStr(oDataRow("NotaDetDes"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngCentroCostoDetId = ToLong(oDataRow("CentroCostoDetId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngNotaDetId = ToLong(oDataRow("NotaDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngNotaDetId = TableIDGet(mstrTableName, "NotaDetId", moConnection)

         If mlngNotaDetId = -1 Then
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

      'If mlngTipoNotaId = 0 Then
      '   strMsg &= "Gestión Inválida" & vbCrLf
      'End If

      'If mlngNotaId = 0 Then
      '   strMsg &= "Seleccione el Tipo de NotaDetrobante" & vbCrLf
      'End If

      'If mstrPrecioFecha.Trim() <> String.Empty Then
      '   If Not IsDate(ToDateDMY(mstrPrecioFecha)) Then
      '      strMsg &= "PrecioFecha no Válida" & vbCrLf
      '   End If
      'Else
      '   strMsg &= "La PrecioFecha no puede ser nula" & vbCrLf
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
         'strSQL &= " FROM invNotaDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
         'Else
         '   strSQL &= " WHERE  invNotaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  invNotaDet.TipoNotaId = " & NumberToField(mlngTipoNotaId)
         '   strSQL &= " AND  invNotaDet.NotaDetId <> " & NumberToField(mlngNotaDetId)
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
