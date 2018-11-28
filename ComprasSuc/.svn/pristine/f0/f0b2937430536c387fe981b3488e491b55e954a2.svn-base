Imports System.Data
Imports System.Data.OleDb

Public Class clsPedCompraDet
   Implements IDisposable

   Private mlngPedCompraDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngPedCompraId As Long
   Private mstrFecha As String
   Private mlngAlmacenId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mlngItemId As Long
   Private mlngMedidaId As Long
   Private mdecCantidad As Decimal
   Private mdecPrecio As Decimal
   Private mdecImporte As Decimal
   Private mdecPrecioRec As Decimal
   Private mdecPrecioDes As Decimal
   Private mdecImporteBru As Decimal
   Private mstrPedCompraDetDes As String
   Private mdecCantidadEnt As Decimal
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mstrFechaEnt As String
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
   Property PedCompraDetId() As Long
      Get
         Return mlngPedCompraDetId
      End Get

      Set(ByVal Value As Long)
         mlngPedCompraDetId = Value
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

   Property PedCompraId() As Long
      Get
         Return mlngPedCompraId
      End Get

      Set(ByVal Value As Long)
         mlngPedCompraId = Value
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

   Property Precio() As Decimal
      Get
         Return mdecPrecio
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecio = Value
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

   Property PedCompraDetDes() As String
      Get
         Return mstrPedCompraDetDes
      End Get

      Set(ByVal Value As String)
         mstrPedCompraDetDes = Value
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

   Property FechaEnt() As String
      Get
         Return mstrFechaEnt
      End Get

      Set(ByVal Value As String)
         mstrFechaEnt = Value
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
      Kardex = 4
      PedCompraIdItem = 5
      AlmacenDistinct = 6
      ProveedorDistinct = 7
      MedidaDistinct = 8
      GridPedCompraId = 9
      ProveedorUPP = 10
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      PedCompraId = 6
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
      PedCompraIdItem = 20
      AlmacenDistinct = 21
      ProveedorDistinct = 22
      MedidaDistinct = 23
      PedCompraItemId = 24
      EntregaPend = 25
      EntregaPendFecha = 26
      GridPedCompraId = 27
      GridPedCompraIdPend = 28
      ProveedorUPP = 29

   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PedCompraDetId = 1
      Grid = 3
      Report = 4
      Kardex = 6
      FechaDESC = 7
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      CantidadEnt = 1
      EstadoIdPK = 2
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
   End Enum

   Public Enum RowSumFilters As Byte
      Cantidad = 1
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
      mstrTableName = "comPedCompraDet"
      mstrClassName = "clsPedCompraDet"

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
      mlngPedCompraDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngPedCompraId = 0
      mstrFecha = ""
      mlngAlmacenId = 0
      mlngProveedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mlngItemId = 0
      mlngMedidaId = 0
      mdecCantidad = 0
      mdecPrecio = 0
      mdecPrecioRec = 0
      mdecPrecioDes = 0
      mdecImporte = 0
      mdecImporteBru = 0
      mstrPedCompraDetDes = ""
      mdecCantidadEnt = 0
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mstrFechaEnt = ""
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
            strSQL &= "    comPedCompraDet.PedCompraDetId,  "
            strSQL &= "    comPedCompraDet.EmpresaId,  "
            strSQL &= "    comPedCompraDet.GestionId,  "
            strSQL &= "    comPedCompraDet.PedCompraId,  "
            strSQL &= "    comPedCompraDet.Fecha,  "
            strSQL &= "    comPedCompraDet.AlmacenId,  "
            strSQL &= "    comPedCompraDet.ProveedorId,  "
            strSQL &= "    comPedCompraDet.MonedaId,  "
            strSQL &= "    comPedCompraDet.TipoCambio,  "
            strSQL &= "    comPedCompraDet.ItemId,  "
            strSQL &= "    comPedCompraDet.MedidaId,  "
            strSQL &= "    comPedCompraDet.Cantidad,  "
            strSQL &= "    comPedCompraDet.Precio,  "
            strSQL &= "    comPedCompraDet.PrecioRec,  "
            strSQL &= "    comPedCompraDet.PrecioDes,  "
            strSQL &= "    comPedCompraDet.Importe,  "
            strSQL &= "    comPedCompraDet.ImporteBru,  "
            strSQL &= "    comPedCompraDet.PedCompraDetDes,  "
            strSQL &= "    comPedCompraDet.CantidadEnt,  "
            strSQL &= "    comPedCompraDet.CentroCostoId,  "
            strSQL &= "    comPedCompraDet.CentroCostoDetId,  "
            strSQL &= "    comPedCompraDet.FechaEnt,  "
            strSQL &= "    comPedCompraDet.SucursalId,  "
            strSQL &= "    comPedCompraDet.EstadoId,  "
            strSQL &= "    comPedCompraDet.sLastUpdate_id,  "
            strSQL &= "    comPedCompraDet.dtLastUpdate_dt,  "
            strSQL &= "    comPedCompraDet.iConcurrency_id  "
            strSQL &= " FROM comPedCompraDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comPedCompraDet.PedCompraDetId  "
            strSQL &= " FROM comPedCompraDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comPedCompraDet.PedCompraDetId,  "
            strSQL &= "    comPedCompraDet.EmpresaId,  "
            strSQL &= "    comPedCompraDet.PedCompraId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comPedCompraDet.Cantidad,  "
            strSQL &= "    comPedCompraDet.CantidadEnt,  "
            strSQL &= "    comPedCompraDet.Precio,  "
            strSQL &= "    comPedCompraDet.Importe,  "
            strSQL &= "    comPedCompraDet.PrecioRec,  "
            strSQL &= "    comPedCompraDet.PrecioDes,  "
            strSQL &= "    comPedCompraDet.ImporteBru,  "
            strSQL &= "    comPedCompraDet.PedCompraDetDes,  "
            strSQL &= "    comPedCompraDet.CentroCostoDetId,  "
            strSQL &= "    comPedCompraDet.FechaEnt  "
            strSQL &= " FROM comPedCompraDet, invItem, invMedida "

         Case SelectFilters.Report

         Case SelectFilters.Kardex
            strSQL = " SELECT  "
            strSQL &= "    comPedCompraDet.PedCompraDetId,  "
            strSQL &= "    comPedCompraDet.PedCompraId,  "
            strSQL &= "    comPedCompraDet.Fecha,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invNota.NotaDes,  "
            strSQL &= "    comPedCompraDet.ItemId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comPedCompraDet.Cantidad,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comPedCompraDet.TipoCambio,  "
            strSQL &= "    comPedCompraDet.Precio,  "
            strSQL &= "    comPedCompraDet.Importe,  "
            strSQL &= "    comPedCompraDet.PrecioRec,  "
            strSQL &= "    comPedCompraDet.PrecioDes,  "
            strSQL &= "    comPedCompraDet.ImporteBru  "
            strSQL &= " FROM comPedCompraDet, invTipoNota, invNota, invAlmacen, invMedida, tblMoneda "

         Case SelectFilters.PedCompraIdItem
            strSQL = " SELECT  "
            strSQL &= "    comPedCompraDet.PedCompraDetId,  "
            strSQL &= "    comPedCompraDet.PedCompraId,  "
            strSQL &= "    comPedCompraDet.ItemId As PedCompraDetItemId,  "
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
            strSQL &= " FROM comPedCompraDet LEFT OUTER JOIN invItem ON comPedCompraDet.ItemId = invItem.ItemId "

         Case SelectFilters.MedidaDistinct
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comPedCompraDet.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes  "
            strSQL &= " FROM comPedCompraDet, invMedida "

         Case SelectFilters.GridPedCompraId
            strSQL = " SELECT  "
            strSQL &= "    comPedCompraDet.PedCompraDetId,  "
            strSQL &= "    comPedCompraDet.PedCompraId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comPedCompraDet.Cantidad,  "
            strSQL &= "    comPedCompraDet.CantidadEnt,  "
            strSQL &= "    comPedCompraDet.Precio,  "
            strSQL &= "    comPedCompraDet.PrecioRec,  "
            strSQL &= "    comPedCompraDet.PrecioDes,  "
            strSQL &= "    comPedCompraDet.PedCompraDetDes  "
            strSQL &= " FROM comPedCompraDet, invItem, invMedida "

         Case SelectFilters.ProveedorUPP
            strSQL = " SELECT  TOP 5 "
            strSQL &= "    comPedCompra.PedCompraId,  "
            strSQL &= "    comPedCompraDet.Fecha,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comPedCompraDet.Cantidad,  "
            strSQL &= "    comPedCompraDet.Precio  "
            strSQL &= " FROM comPedCompraDet, comPedCompra, tblMoneda, invMedida "

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
            strSQL = " WHERE  comPedCompraDet.PedCompraDetId = " & NumberToField(mlngPedCompraDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comPedCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comPedCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.Report

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.PedCompraId
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.PedCompraId = " & NumberToField(mlngPedCompraId)

         Case WhereFilters.ItemId
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comPedCompraDet.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.PedCompraIdItem
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.PedCompraId = " & NumberToField(mlngPedCompraId)

         Case WhereFilters.MedidaDistinct
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.PedCompraItemId
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            ''strSQL &= " AND  comPedCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  comPedCompraDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  comPedCompraDet.PedCompraId = " & NumberToField(mlngPedCompraId)

         Case WhereFilters.EntregaPend
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comPedCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  comPedCompraDet.ItemId = " & NumberToField(mlngItemId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPedCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPedCompraDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompraDet.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  (comPedCompraDet.EstadoId = " & NumberToField(clsEstado.APROBADO)
            strSQL &= " OR  comPedCompraDet.EstadoId = " & NumberToField(clsEstado.PARCIAL) & ")"

            If mstrPedCompraDetDes <> String.Empty Then
               strSQL &= " AND  " & mstrPedCompraDetDes ''Cadena de Varios Almacenes
            End If

         Case WhereFilters.EntregaPendFecha
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.GestionId = " & NumberToField(mlngGestionId)

            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  comPedCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  comPedCompraDet.ItemId = " & NumberToField(mlngItemId)
            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comPedCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            End If
            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comPedCompraDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comPedCompraDet.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comPedCompraDet.FechaEnt >= " & DateToField(mstrFechaEnt)
            strSQL &= " AND  comPedCompraDet.FechaEnt <= " & DateToField(mstrLastUpdateDate)
            'strSQL &= " AND  (comPedCompraDet.EstadoId = 13 "
            'strSQL &= " OR  comPedCompraDet.EstadoId = 7) "

            strSQL &= " AND  (comPedCompraDet.EstadoId = " & NumberToField(clsEstado.APROBADO)
            strSQL &= " OR  comPedCompraDet.EstadoId = " & NumberToField(clsEstado.PARCIAL) & ")"

            If mstrPedCompraDetDes <> String.Empty Then
               strSQL &= " AND  " & mstrPedCompraDetDes ''Cadena de Varios Almacenes
            End If

         Case WhereFilters.GridPedCompraId
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comPedCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comPedCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.GridPedCompraIdPend
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.PedCompraId = " & NumberToField(mlngPedCompraId)
            strSQL &= " AND  comPedCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comPedCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  comPedCompraDet.Cantidad - comPedCompraDet.CantidadEnt > 0 "

         Case WhereFilters.ProveedorUPP
            strSQL = " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comPedCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comPedCompraDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  comPedCompraDet.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  comPedCompraDet.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  comPedCompraDet.PedCompraId = comPedCompra.PedCompraId "
            strSQL &= " AND  comPedCompraDet.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comPedCompraDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  ( comPedCompra.EstadoId = " & NumberToField(clsEstado.APROBADO)
            strSQL &= "  OR   comPedCompra.EstadoId = " & NumberToField(clsEstado.PARCIAL)
            strSQL &= "  OR   comPedCompra.EstadoId = " & NumberToField(clsEstado.PENDIENTE)
            strSQL &= "  OR   comPedCompra.EstadoId = " & NumberToField(clsEstado.REALIZADO)
            strSQL &= "  ) "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PedCompraDetId
            strSQL = " ORDER BY comPedCompraDet.PedCompraDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comPedCompraDet.PedCompraDetId "

         Case OrderByFilters.Report

         Case OrderByFilters.Kardex
            strSQL = " ORDER BY comPedCompraDet.PedCompraId "

         Case OrderByFilters.FechaDESC
            strSQL = " ORDER BY comPedCompraDet.Fecha DESC "

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

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO comPedCompraDet ("
            strSQL &= "PedCompraDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "PedCompraId, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenId, "
            strSQL &= "ProveedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "ItemId, "
            strSQL &= "MedidaId, "
            strSQL &= "Cantidad, "
            strSQL &= "Precio, "
            strSQL &= "Importe, "
            strSQL &= "PrecioRec,  "
            strSQL &= "PrecioDes,  "
            strSQL &= "ImporteBru,  "
            strSQL &= "PedCompraDetDes,  "
            strSQL &= "CantidadEnt, "
            strSQL &= "CentroCostoId, "
            strSQL &= "CentroCostoDetId, "
            strSQL &= "FechaEnt,  "
            strSQL &= "SucursalId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPedCompraDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngPedCompraId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= NumberToField(mlngMedidaId) & ", "
            strSQL &= DecimalToField(mdecCantidad) & ", "
            strSQL &= DecimalToField(mdecPrecio) & ", "
            strSQL &= DecimalToField(mdecImporte) & ", "
            strSQL &= DecimalToField(mdecPrecioRec) & ", "
            strSQL &= DecimalToField(mdecPrecioDes) & ", "
            strSQL &= DecimalToField(mdecImporteBru) & ", "
            strSQL &= StringToField(mstrPedCompraDetDes) & ", "
            strSQL &= DecimalToField(mdecCantidadEnt) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= DateToField(mstrFechaEnt) & ", "
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
            strSQL = "UPDATE comPedCompraDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "PedCompraId = " & NumberToField(mlngPedCompraId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "MedidaId = " & NumberToField(mlngMedidaId) & ", "
            strSQL &= "Cantidad = " & DecimalToField(mdecCantidad) & ", "
            strSQL &= "Precio = " & DecimalToField(mdecPrecio) & ", "
            strSQL &= "Importe = " & DecimalToField(mdecImporte) & ", "
            strSQL &= "PrecioRec = " & DecimalToField(mdecPrecioRec) & ", "
            strSQL &= "PrecioDes = " & DecimalToField(mdecPrecioDes) & ", "
            strSQL &= "ImporteBru = " & DecimalToField(mdecImporteBru) & ", "
            strSQL &= "PedCompraDetDes = " & StringToField(mstrPedCompraDetDes) & ", "
            strSQL &= "CantidadEnt = " & DecimalToField(mdecCantidadEnt) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= "FechaEnt = " & DateToField(mstrFechaEnt) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PedCompraDetId = " & NumberToField(mlngPedCompraDetId) & " "

         Case UpdateFilters.CantidadEnt
            strSQL = " UPDATE comPedCompraDet "
            strSQL &= " SET CantidadEnt = " & DecimalToField(mdecCantidadEnt)
            strSQL &= " WHERE PedCompraDetId = " & NumberToField(mlngPedCompraDetId) & " "

         Case UpdateFilters.EstadoIdPK
            strSQL = " UPDATE comPedCompraDet "
            strSQL &= " SET EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " WHERE PedCompraDetId = " & NumberToField(mlngPedCompraDetId) & " "

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
               mlngPedCompraDetId = ToLong(oDataRow("PedCompraDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngPedCompraId = ToLong(oDataRow("PedCompraId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngMedidaId = ToLong(oDataRow("MedidaId"))
               mdecCantidad = ToDecimal(oDataRow("Cantidad"))
               mdecPrecio = ToDecimal(oDataRow("Precio"))
               mdecImporte = ToDecimal(oDataRow("Importe"))
               mdecPrecioRec = ToDouble(oDataRow("PrecioRec"))
               mdecPrecioDes = ToDouble(oDataRow("PrecioDes"))
               mdecImporteBru = ToDecimal(oDataRow("ImporteBru"))
               mstrPedCompraDetDes = ToStr(oDataRow("PedCompraDetDes"))
               mdecCantidadEnt = ToDecimal(oDataRow("CantidadEnt"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngCentroCostoDetId = ToLong(oDataRow("CentroCostoDetId"))
               mstrFechaEnt = ToDateDMY(oDataRow("FechaEnt"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPedCompraDetId = ToLong(oDataRow("PedCompraDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPedCompraDetId = TableIDGet(mstrTableName, "PedCompraDetId", moConnection)

         If mlngPedCompraDetId = -1 Then
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


      'If mlngPedCompraId = 0 Then
      '   strMsg &= "Seleccione el Tipo de PedCompraDetrobante" & vbCrLf
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
         'strSQL &= " FROM comPedCompraDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comPedCompraDet.TipoPedCompraId = " & NumberToField(mlngTipoPedCompraId)
         'Else
         '   strSQL &= " WHERE  comPedCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comPedCompraDet.TipoPedCompraId = " & NumberToField(mlngTipoPedCompraId)
         '   strSQL &= " AND  comPedCompraDet.PedCompraDetId <> " & NumberToField(mlngPedCompraDetId)
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
