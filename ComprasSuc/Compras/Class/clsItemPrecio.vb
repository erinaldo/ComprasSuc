Imports System.Data
Imports System.Data.OleDb

Public Class clsItemPrecio
   Implements IDisposable

   Private mlngItemPrecioId As Long
   Private mlngEmpresaId As Long
   Private mlngEncPrecioId As Long
   Private mlngAlmacenId As Long
   Private mlngItemId As Long
   Private mlngOrden As Long
   Private mstrItemPrecioDes As String
   Private mdecPorcentaje As Decimal
   Private mlngMonedaId As Long
   Private mdecPrecio As Decimal
   Private mdecPrecioEqui As Decimal
   Private mdecPrecioMinPor As Decimal
   Private mdecPrecioMaxPor As Decimal
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
   Property ItemPrecioId() As Long
      Get
         Return mlngItemPrecioId
      End Get

      Set(ByVal Value As Long)
         mlngItemPrecioId = Value
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

   Property EncPrecioId() As Long
      Get
         Return mlngEncPrecioId
      End Get

      Set(ByVal Value As Long)
         mlngEncPrecioId = Value
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

   Property ItemId() As Long
      Get
         Return mlngItemId
      End Get

      Set(ByVal Value As Long)
         mlngItemId = Value
      End Set
   End Property

   Property Orden() As Long
      Get
         Return mlngOrden
      End Get

      Set(ByVal Value As Long)
         mlngOrden = Value
      End Set
   End Property

   Property ItemPrecioDes() As String
      Get
         Return mstrItemPrecioDes
      End Get

      Set(ByVal Value As String)
         mstrItemPrecioDes = Value
      End Set
   End Property

   Property Porcentaje() As Decimal
      Get
         Return mdecPorcentaje
      End Get

      Set(ByVal Value As Decimal)
         mdecPorcentaje = Value
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

   Property Precio() As Decimal
      Get
         Return mdecPrecio
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecio = Value
      End Set
   End Property

   Property PrecioEqui() As Decimal
      Get
         Return mdecPrecioEqui
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioEqui = Value
      End Set
   End Property

   Property PrecioMinPor() As Decimal
      Get
         Return mdecPrecioMinPor
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioMinPor = Value
      End Set
   End Property

   Property PrecioMaxPor() As Decimal
      Get
         Return mdecPrecioMaxPor
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioMaxPor = Value
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
      Lista = 3
      GridMain = 4
      GridItem = 5
      ItemIdDistinct = 6
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      PrecioDes = 2
      LIKEPrecioDes = 3
      Grid = 4
      ItemId = 5
      ItemIdOrden = 6
      Lista = 7
      GridMain = 8

      Orden = 9
      PrecioDesItemId = 10
      ListBox_ItemIdOrden = 11
      ListBox_ItemIdAlmacen = 12
      GridItem = 13
      EncPrecioId = 14
      EncPrecioItemId = 15
      ItemPrecioIdTieneMov = 16
      AlmacenId = 17
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ItemPrecioId = 1
      PrecioDes = 2
      Grid = 3
      Orden = 4
      GridMain = 5
      GridItem = 6
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      Precio = 1
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
      ItemId = 1
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
      mstrTableName = "invItemPrecio"
      mstrClassName = "clsItemPrecio"

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
      mlngItemPrecioId = 0
      mlngEmpresaId = 0
      mlngEncPrecioId = 0
      mlngAlmacenId = 0
      mlngItemId = 0
      mlngOrden = 0
      mstrItemPrecioDes = ""
      mdecPorcentaje = 0
      mlngMonedaId = 0
      mdecPrecio = 0
      mdecPrecioEqui = 0
      mdecPrecioMinPor = 0
      mdecPrecioMaxPor = 0
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
            strSQL &= "    invItemPrecio.ItemPrecioId,  "
            strSQL &= "    invItemPrecio.EmpresaId,  "
            strSQL &= "    invItemPrecio.EncPrecioId,  "
            strSQL &= "    invItemPrecio.AlmacenId,  "
            strSQL &= "    invItemPrecio.ItemId,  "
            strSQL &= "    invItemPrecio.Orden,  "
            strSQL &= "    invItemPrecio.ItemPrecioDes,  "
            strSQL &= "    invItemPrecio.Porcentaje,  "
            strSQL &= "    invItemPrecio.MonedaId,  "
            strSQL &= "    invItemPrecio.Precio,  "
            strSQL &= "    invItemPrecio.PrecioEqui,  "
            strSQL &= "    invItemPrecio.PrecioMinPor,  "
            strSQL &= "    invItemPrecio.PrecioMaxPor,  "
            strSQL &= "    invItemPrecio.EstadoId,  "
            strSQL &= "    invItemPrecio.sLastUpdate_id,  "
            strSQL &= "    invItemPrecio.dtLastUpdate_dt,  "
            strSQL &= "    invItemPrecio.iConcurrency_id  "
            strSQL &= " FROM invItemPrecio "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invItemPrecio.ItemPrecioId,  "
            strSQL &= "    invItemPrecio.EncPrecioId,  "
            strSQL &= "    invEncPrecio.Orden,  "
            strSQL &= "    invEncPrecio.EncPrecioDesAbr,  "
            strSQL &= "    invItemPrecio.ItemPrecioDes,  "
            strSQL &= "    invItemPrecio.MonedaId,  "
            strSQL &= "    invItemPrecio.Precio,  "
            strSQL &= "    invItemPrecio.PrecioEqui,  "
            strSQL &= "    invItemPrecio.PrecioMinPor,  "
            strSQL &= "    invItemPrecio.PrecioMaxPor  "
            strSQL &= " FROM invItemPrecio, invEncPrecio "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invItemPrecio.ItemPrecioId,  "
            strSQL &= "    invItemPrecio.EmpresaId,  "
            strSQL &= "    invItemPrecio.EncPrecioId,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invItemPrecio.ItemId,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.TipoItemId,  "
            strSQL &= "    invItem.TipoCosteoId,  "
            strSQL &= "    invItemPrecio.Orden,  "
            strSQL &= "    invItemPrecio.ItemPrecioDes,  "
            strSQL &= "    invItemPrecio.Porcentaje,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invItem.MedidaIdEqui,  "
            strSQL &= "    invItem.MedidaCantEqui,  "
            strSQL &= "    invItemPrecio.Precio,  "
            strSQL &= "    invItemPrecio.PrecioEqui,  "
            strSQL &= "    invItemPrecio.Porcentaje,  "
            strSQL &= "    invItemPrecio.PrecioMinPor,  "
            strSQL &= "    invItemPrecio.PrecioMaxPor,  "
            strSQL &= "    invItemPrecio.EstadoId,  "
            strSQL &= "    0.0 As Saldo,  "
            strSQL &= "    0.0 As PrecioPPP,  "
            strSQL &= "    0.0 As PrecioUPC,  "
            strSQL &= "    tblMonedaCos.MonedaId As MonedaIdCos,  "
            strSQL &= "    tblMonedaCos.MonedaDes As MonedaDesCos  "
            strSQL &= " FROM invItemPrecio, invAlmacen, invItem, invMedida, tblMoneda As tblMonedaCos "

         Case SelectFilters.Lista
            strSQL = " SELECT  "
            strSQL &= "    invItemPrecio.ItemPrecioId,  "
            strSQL &= "    invItemPrecio.EmpresaId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "

            strSQL &= "    invItem.MedidaIdEqui,  "
            strSQL &= "    invItem.MedidaCantEqui,  "
            strSQL &= "    invItem.MonedaIdCos,  "
            strSQL &= "    invItem.MonedaIdVen,  "

            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    tblMonedaCos.MonedaId as MonedaIdCos,  "
            strSQL &= "    tblMonedaCos.MonedaDes as MonedaDesCos,  "
            strSQL &= "    invItemPrecio.Orden,  "
            strSQL &= "    invItemPrecio.ItemPrecioDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invItemPrecio.Porcentaje,  "
            strSQL &= "    invItemPrecio.Precio,  "
            strSQL &= "    invItemPrecio.PrecioEqui  "
            strSQL &= " FROM invItemPrecio, invItem, invMedida, tblMoneda as tblMonedaCos, tblMoneda"

         Case SelectFilters.GridMain
            strSQL = " SELECT  "
            strSQL &= "    invItemPrecio.ItemPrecioId,  "
            strSQL &= "    invItemPrecio.EmpresaId,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invItem.MedidaIdEqui,  "
            strSQL &= "    invItemPrecio.Orden,  "
            strSQL &= "    invItemPrecio.Precio,  "
            strSQL &= "    invItemPrecio.PrecioEqui,  "
            strSQL &= "    tblMonedaPrecio.MonedaId As MonedaId,  "
            strSQL &= "    tblMonedaPrecio.MonedaDes As MonedaDes,  "
            strSQL &= "    tblMonedaVen.MonedaId As MonedaIdVen,  "
            strSQL &= "    tblMonedaVen.MonedaDes As MonedaDesVen,  "
            strSQL &= "    invItemSaldo.PrecioPPP,  "
            strSQL &= "    invItemSaldo.PrecioUPC,  "
            strSQL &= "    tblMonedaCos.MonedaId As MonedaIdCos,  "
            strSQL &= "    tblMonedaCos.MonedaDes As MonedaDesCos,  "
            strSQL &= "    invItemPrecio.ItemPrecioDes,  "
            strSQL &= "    invItemPrecio.Porcentaje,  "
            strSQL &= "    'Show' As Estado,  "
            strSQL &= "    invItemSaldo.GestionId  "
            'strSQL &= " FROM invItemPrecio, invAlmacen, invItem, invMedida, tblMoneda As tblMonedaVen, invItemSaldo, tblMoneda As tblMonedaCos "
            strSQL &= " FROM invItemPrecio INNER JOIN "
            strSQL &= " invAlmacen ON invItemPrecio.AlmacenId = invAlmacen.AlmacenId INNER JOIN "
            strSQL &= " tblMoneda tblMonedaPrecio ON invItemPrecio.MonedaId = tblMonedaPrecio.MonedaId INNER JOIN "
            strSQL &= " invItem ON invItemPrecio.ItemId = invItem.ItemId INNER JOIN "
            strSQL &= " invMedida ON invItem.MedidaId = invMedida.MedidaId INNER JOIN "
            strSQL &= " tblMoneda tblMonedaVen ON invItem.MonedaIdVen = tblMonedaVen.MonedaId INNER JOIN "
            strSQL &= " tblMoneda tblMonedaCos ON invItem.MonedaIdCos = tblMonedaCos.MonedaId LEFT OUTER JOIN "
            strSQL &= " invItemSaldo ON invItemPrecio.ItemId = invItemSaldo.ItemId AND invItemPrecio.AlmacenId = invItemSaldo.AlmacenId "

         Case SelectFilters.GridItem
            strSQL = " SELECT  "
            strSQL &= "    invItemPrecio.ItemPrecioId,  "
            strSQL &= "    invItemPrecio.EmpresaId,  "
            strSQL &= "    invEncPrecio.EncPrecioId,  "
            strSQL &= "    invEncPrecio.EncPrecioDes,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invItemPrecio.ItemId,  "
            strSQL &= "    invItemPrecio.Orden,  "
            strSQL &= "    invItemPrecio.ItemPrecioDes,  "
            strSQL &= "    invItemPrecio.Porcentaje,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invItemPrecio.Precio,  "
            strSQL &= "    invItemPrecio.PrecioEqui,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM invItemPrecio, invEncPrecio, invAlmacen, invItem, invMedida, tblMoneda, tblEstado "

         Case SelectFilters.ItemIdDistinct
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    invItemPrecio.ItemId  "
            strSQL &= " FROM invItemPrecio "

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
            strSQL = " WHERE  invItemPrecio.ItemPrecioId = " & NumberToField(mlngItemPrecioId)

         Case WhereFilters.PrecioDes
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.ItemPrecioDes = " & StringToField(mlngItemId)

         Case WhereFilters.LIKEPrecioDes

         Case WhereFilters.Grid
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.EncPrecioId = " & NumberToField(mlngEncPrecioId)
            strSQL &= " AND  invItemPrecio.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invItemPrecio.ItemId = invItem.ItemId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MonedaIdCos = tblMonedaCos.MonedaId "

         Case WhereFilters.ItemId
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)

            If mlngEstadoId <> 0 Then
               strSQL &= " AND  invItemPrecio.EstadoId = " & NumberToField(mlngEstadoId)
            End If

         Case WhereFilters.ItemIdOrden
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemPrecio.Orden = " & NumberToField(mlngOrden)

            If mlngEstadoId <> 0 Then
               strSQL &= " AND  invItemPrecio.EstadoId = " & NumberToField(mlngEstadoId)
            End If

         Case WhereFilters.Lista
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemPrecio.ItemId = invItem.ItemId "
            strSQL &= " AND  invItemPrecio.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItem.MonedaIdCos = tblMonedaCos.MonedaId "

            If mstrItemPrecioDes.Length > 0 Then
               strSQL &= " AND  " & mstrItemPrecioDes ''Cadena de Varios Almacenes
            End If

         Case WhereFilters.GridMain
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  invItemSaldo.GestionId = " & NumberToField(mlngOrden) 'GestionId
            strSQL &= " AND  invItemPrecio.EstadoId <> 12 "

         Case WhereFilters.Orden
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemPrecio.Orden = " & NumberToField(mlngOrden)

         Case WhereFilters.PrecioDesItemId
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.ItemPrecioDes = " & StringToField(mstrItemPrecioDes)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)

         Case WhereFilters.ListBox_ItemIdOrden
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemPrecio.EncPrecioId = invEncPrecio.EncPrecioId "

            If mlngItemPrecioId = 0 Then
               strSQL &= " AND  invItemPrecio.Orden = " & NumberToField(mlngOrden)
               strSQL &= " AND  invItemPrecio.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  ((invItemPrecio.Orden = " & NumberToField(mlngOrden)
               strSQL &= " AND  invItemPrecio.EstadoId = " & NumberToField(mlngEstadoId) & ") "
               strSQL &= " OR  invItemPrecio.ItemPrecioId = " & NumberToField(mlngItemPrecioId) & ") "
            End If

         Case WhereFilters.ListBox_ItemIdAlmacen
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemPrecio.EncPrecioId = invEncPrecio.EncPrecioId "

            If mlngItemPrecioId = 0 Then
               strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
               strSQL &= " AND  invItemPrecio.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  ( (invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
               strSQL &= " AND  invItemPrecio.EstadoId = " & NumberToField(mlngEstadoId) & ") "
               strSQL &= " OR  invItemPrecio.ItemPrecioId = " & NumberToField(mlngItemPrecioId) & ") "
            End If

         Case WhereFilters.GridItem
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemPrecio.EncPrecioId = invEncPrecio.EncPrecioId "
            strSQL &= " AND  invItemPrecio.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invItemPrecio.ItemId = invItem.ItemId "
            strSQL &= " AND  invItem.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItemPrecio.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  invItemPrecio.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EncPrecioId
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.EncPrecioId = " & NumberToField(mlngEncPrecioId)

         Case WhereFilters.EncPrecioItemId
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.EncPrecioId = " & NumberToField(mlngEncPrecioId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.ItemPrecioIdTieneMov
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)

            If mlngEncPrecioId > 0 Then
               strSQL &= " AND  invItemPrecio.EncPrecioId = " & NumberToField(mlngEncPrecioId)
            End If

            If mlngItemPrecioId > 0 Then
               strSQL &= " AND  invItemPrecio.ItemPrecioId = " & NumberToField(mlngItemPrecioId)
            End If

            strSQL &= " AND  ( invItemPrecio.ItemPrecioId IN (SELECT ItemPrecioId "
            strSQL &= "                            FROM  venVentaDet "
            strSQL &= "                            WHERE venVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR invItemPrecio.ItemPrecioId IN (SELECT ItemPrecioId "
            strSQL &= "                            FROM  venPedVentaDet "
            strSQL &= "                            WHERE venPedVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR invItemPrecio.ItemPrecioId IN (SELECT ItemPrecioId "
            strSQL &= "                            FROM  venProformaDet "
            strSQL &= "                            WHERE venProformaDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR invItemPrecio.ItemPrecioId IN (SELECT ItemPrecioId "
            strSQL &= "                            FROM  venConsignacionDet "
            strSQL &= "                            WHERE venConsignacionDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"

            If TableExits(clsAppInfo.ConnectString, "pdvPtoVentaDet") Then
               strSQL &= "     OR invItemPrecio.ItemPrecioId IN (SELECT ItemPrecioId "
               strSQL &= "                            FROM  pdvPtoVentaDet "
               strSQL &= "                            WHERE pdvPtoVentaDet.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            End If

            strSQL &= " ) "

         Case WhereFilters.AlmacenId
            strSQL = " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)

            If mlngEstadoId <> 0 Then
               strSQL &= " AND  invItemPrecio.EstadoId = " & NumberToField(mlngEstadoId)
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ItemPrecioId
            strSQL = " ORDER BY invItemPrecio.ItemPrecioId "

         Case OrderByFilters.PrecioDes
            strSQL = " ORDER BY invItemPrecio.PrecioDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invItemPrecio.ItemPrecioId "

         Case OrderByFilters.Orden
            strSQL = " ORDER BY invItemPrecio.Orden "

         Case OrderByFilters.GridMain
            strSQL = " ORDER BY invAlmacen.AlmacenDes, invItem.ItemDes, invItemPrecio.Orden "

         Case OrderByFilters.GridItem
            strSQL = " ORDER BY invAlmacen.AlmacenDes, invItemPrecio.Orden "

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
            strSQL = "INSERT INTO invItemPrecio ("
            strSQL &= "ItemPrecioId, "
            strSQL &= "EmpresaId, "
            strSQL &= "EncPrecioId, "
            strSQL &= "AlmacenId, "
            strSQL &= "ItemId, "
            strSQL &= "Orden, "
            strSQL &= "ItemPrecioDes, "
            strSQL &= "Porcentaje, "
            strSQL &= "MonedaId, "
            strSQL &= "Precio, "
            strSQL &= "PrecioEqui, "
            strSQL &= "PrecioMinPor, "
            strSQL &= "PrecioMaxPor, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngItemPrecioId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngEncPrecioId) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= NumberToField(mlngOrden) & ", "
            strSQL &= StringToField(mstrItemPrecioDes) & ", "
            strSQL &= DecimalToField(mdecPorcentaje) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecPrecio) & ", "
            strSQL &= DecimalToField(mdecPrecioEqui) & ", "
            strSQL &= DecimalToField(mdecPrecioMinPor) & ", "
            strSQL &= DecimalToField(mdecPrecioMaxPor) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invItemPrecio SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "EncPrecioId = " & NumberToField(mlngEncPrecioId) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "Orden = " & NumberToField(mlngOrden) & ", "
            strSQL &= "ItemPrecioDes = " & StringToField(mstrItemPrecioDes) & ", "
            strSQL &= "Porcentaje = " & DecimalToField(mdecPorcentaje) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "Precio = " & DecimalToField(mdecPrecio) & ", "
            strSQL &= "PrecioEqui = " & DecimalToField(mdecPrecioEqui) & ", "
            strSQL &= "PrecioMinPor = " & DecimalToField(mdecPrecioMinPor) & ", "
            strSQL &= "PrecioMaxPor = " & DecimalToField(mdecPrecioMaxPor) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ItemPrecioId = " & NumberToField(mlngItemPrecioId) & " "

         Case UpdateFilters.Precio
            strSQL = "UPDATE invItemPrecio SET "
            strSQL &= "ItemPrecioDes = " & StringToField(mstrItemPrecioDes) & ", "
            strSQL &= "Precio = " & DecimalToField(mdecPrecio) & ", "
            strSQL &= "PrecioEqui = " & DecimalToField(mdecPrecioEqui) & ", "
            strSQL &= "Porcentaje = " & DecimalToField(mdecPorcentaje) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ItemPrecioId = " & NumberToField(mlngItemPrecioId) & " "

      End Select

      Return strSQL
   End Function

   Private Function DeleteSQL() As String
      Dim strSQL As String

      Select Case mintDeleteFilter
         Case DeleteFilters.All
            strSQL = "DELETE FROM " & mstrTableName
            strSQL &= WhereFilterGet()

         Case DeleteFilters.ItemId
            strSQL = "DELETE FROM " & mstrTableName
            strSQL &= " WHERE  EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "  AND  ItemId = " & NumberToField(mlngItemId)

      End Select

      Return strSQL
   End Function

   Private Sub Retrieve(ByVal oDataRow As DataRow)
      Try
         Call PropertyInit()

         Select Case mintSelectFilter
            Case SelectFilters.All
               mlngItemPrecioId = ToLong(oDataRow("ItemPrecioId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngEncPrecioId = ToLong(oDataRow("EncPrecioId"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngOrden = ToLong(oDataRow("Orden"))
               mstrItemPrecioDes = ToStr(oDataRow("ItemPrecioDes"))
               mdecPorcentaje = ToDecimal(oDataRow("Porcentaje"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecPrecio = ToDecimal(oDataRow("Precio"))
               mdecPrecioEqui = ToDecimal(oDataRow("PrecioEqui"))
               mdecPrecioMinPor = ToDecimal(oDataRow("PrecioMinPor"))
               mdecPrecioMaxPor = ToDecimal(oDataRow("PrecioMaxPor"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngItemPrecioId = ToLong(oDataRow("ItemPrecioId"))
               mlngOrden = ToLong(oDataRow("Orden"))
               mstrItemPrecioDes = ToStr(oDataRow("ItemPrecioDes"))
               mdecPrecio = ToDecimal(oDataRow("Precio"))
               mdecPrecioEqui = ToDecimal(oDataRow("PrecioEqui"))
         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngItemPrecioId = TableIDGet(mstrTableName, "ItemPrecioId", moConnection)

         If mlngItemPrecioId = -1 Then
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

      'If mlngEncPrecioId = 0 Then
      '   strMsg &= "Lista de Precio Inválido" & vbCrLf
      'End If

      If mlngAlmacenId = 0 Then
         strMsg &= "Almacén Inválido" & vbCrLf
      End If

      If mlngItemId = 0 Then
         strMsg &= "Seleccione la Item" & vbCrLf
      End If

      If mlngOrden = 0 Then
         strMsg &= "Nivel de Precio Inválido" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Moneda Inválido" & vbCrLf
      End If

      If mdecPrecio <= 0 Then
         strMsg &= "Precio de venta Inválido " & vbCrLf
      End If

      If mdecPrecioEqui <= 0 Then
         strMsg &= "Precio Equivalente de venta Inválido " & vbCrLf
      End If

      If (mdecPrecioMinPor > 100) Or (mdecPrecioMinPor < 0) Then
         strMsg &= "%  de Precio Mínimo Inválido " & vbCrLf
      End If

      If (mdecPrecioMaxPor < 0) Then
         strMsg &= "%  de Precio Máximo Inválido " & vbCrLf
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
         strSQL &= " FROM invItemPrecio "

         If Not boolReplace Then
            strSQL &= " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemPrecio.Orden = " & NumberToField(mlngOrden)
         Else
            strSQL &= " WHERE  invItemPrecio.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemPrecio.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemPrecio.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemPrecio.Orden = " & NumberToField(mlngOrden)
            strSQL &= " AND  invItemPrecio.ItemPrecioId <> " & NumberToField(mlngItemPrecioId)
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
