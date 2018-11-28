Imports System.Data
Imports System.Data.OleDb

Public Class clsItemNroSerie
   Implements IDisposable

   Private mlngItemNroSerieId As Long
   Private mstrItemNroSerieCod As String
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngAlmacenId As Long
   Private mlngTipoNotaIdEnt As Long
   Private mlngNotaIdEnt As Long
   Private mlngTipoNotaIdSal As Long
   Private mlngNotaIdSal As Long
   Private mlngItemId As Long
   Private mlngItemLoteId As Long
   Private mlngItemLoteIdSal As Long
   Private mlngItemNroSerieIdDev As Long
   Private mlngAppId As Long
   Private mlngTipoDocumentoId As Long
   Private mlngDocumentoId As Long
   Private mlngDocumentoDetId As Long
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

   Public Const TABLE_NAME As String = "invItemNroSerie"
   Public Const CLASS_NAME As String = "clsItemNroSerie"

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property ItemNroSerieId() As Long
      Get
         Return mlngItemNroSerieId
      End Get

      Set(ByVal Value As Long)
         mlngItemNroSerieId = Value
      End Set
   End Property

   Property ItemNroSerieCod() As String
      Get
         Return mstrItemNroSerieCod
      End Get

      Set(ByVal Value As String)
         mstrItemNroSerieCod = Value
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

   Property AlmacenId() As Long
      Get
         Return mlngAlmacenId
      End Get

      Set(ByVal Value As Long)
         mlngAlmacenId = Value
      End Set
   End Property

   Property TipoNotaIdEnt() As Long
      Get
         Return mlngTipoNotaIdEnt
      End Get

      Set(ByVal Value As Long)
         mlngTipoNotaIdEnt = Value
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

   Property NotaIdEnt() As Long
      Get
         Return mlngNotaIdEnt
      End Get

      Set(ByVal Value As Long)
         mlngNotaIdEnt = Value
      End Set
   End Property

   Property NotaIdSal() As Long
      Get
         Return mlngNotaIdSal
      End Get

      Set(ByVal Value As Long)
         mlngNotaIdSal = Value
      End Set
   End Property

   Property ItemLoteId() As Long
      Get
         Return mlngItemLoteId
      End Get

      Set(ByVal Value As Long)
         mlngItemLoteId = Value
      End Set
   End Property

   Property ItemLoteIdSal() As Long
      Get
         Return mlngItemLoteIdSal
      End Get

      Set(ByVal Value As Long)
         mlngItemLoteIdSal = Value
      End Set
   End Property

   Property TipoNotaIdSal() As Long
      Get
         Return mlngTipoNotaIdSal
      End Get

      Set(ByVal Value As Long)
         mlngTipoNotaIdSal = Value
      End Set
   End Property

   Property ItemNroSerieIdDev() As Long
      Get
         Return mlngItemNroSerieIdDev
      End Get

      Set(ByVal Value As Long)
         mlngItemNroSerieIdDev = Value
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

   Property DocumentoDetId() As Long
      Get
         Return mlngDocumentoDetId
      End Get

      Set(ByVal Value As Long)
         mlngDocumentoDetId = Value
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
      GridFind = 4
      GridDevSalida = 5
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      NotaIdSal = 6
      NotaIdEnt = 7
      ItemId = 8
      ItemSerie = 9
      TieneMovimiento = 10
      DeleteNotaIdEnt = 11
      ItemSerie_DevSal = 12
      ItemSerie_DevEnt = 13

      NotaIdSal_DocId = 14
      NotaIdSal_DocDetId = 15
      DocumentoDetId = 16

      GridFind = 17
      GridSalida = 18
      GridDevSalida = 19
      GridDevEntrada = 20
      NotaItemIdEnt = 21
      NotaItemIdSal = 22
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ItemNroSerieId = 1
      Grid = 2
      Report = 3
      ItemId = 6
      GridFind = 7
      GridDevSalida = 8
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      ConSerieIdDev = 1
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
      mstrTableName = TABLE_NAME
      mstrClassName = CLASS_NAME

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
      mlngItemNroSerieId = 0
      mstrItemNroSerieCod = ""
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngAlmacenId = 0
      mlngTipoNotaIdEnt = 0
      mlngNotaIdEnt = 0
      mlngTipoNotaIdSal = 0
      mlngNotaIdSal = 0
      mlngItemId = 0
      mlngItemLoteId = 0
      mlngItemLoteIdSal = 0
      mlngItemNroSerieIdDev = 0
      mlngAppId = 0
      mlngTipoDocumentoId = 0
      mlngDocumentoId = 0
      mlngDocumentoDetId = 0
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
            strSQL &= "    invItemNroSerie.ItemNroSerieId,  "
            strSQL &= "    invItemNroSerie.ItemNroSerieCod,  "
            strSQL &= "    invItemNroSerie.EmpresaId,  "
            strSQL &= "    invItemNroSerie.GestionId,  "
            strSQL &= "    invItemNroSerie.AlmacenId,  "
            strSQL &= "    invItemNroSerie.TipoNotaIdEnt,  "
            strSQL &= "    invItemNroSerie.NotaIdEnt,  "
            strSQL &= "    invItemNroSerie.TipoNotaIdSal,  "
            strSQL &= "    invItemNroSerie.NotaIdSal,  "
            strSQL &= "    invItemNroSerie.ItemId,  "
            strSQL &= "    invItemNroSerie.ItemLoteId,  "
            strSQL &= "    invItemNroSerie.ItemLoteIdSal,  "
            strSQL &= "    invItemNroSerie.ItemNroSerieIdDev,  "
            strSQL &= "    invItemNroSerie.AppId,  "
            strSQL &= "    invItemNroSerie.TipoDocumentoId,  "
            strSQL &= "    invItemNroSerie.DocumentoId,  "
            strSQL &= "    invItemNroSerie.DocumentoDetId,  "
            strSQL &= "    invItemNroSerie.EstadoId,  "
            strSQL &= "    invItemNroSerie.sLastUpdate_id,  "
            strSQL &= "    invItemNroSerie.dtLastUpdate_dt,  "
            strSQL &= "    invItemNroSerie.iConcurrency_id  "
            strSQL &= " FROM invItemNroSerie "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invItemNroSerie.ItemNroSerieId,  "
            strSQL &= "    invItemNroSerie.ItemNroSerieCod  "
            strSQL &= " FROM invItemNroSerie "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invItemNroSerie.ItemNroSerieId,  "
            strSQL &= "    invItemNroSerie.ItemNroSerieCod,  "
            strSQL &= "    invItemNroSerie.EmpresaId,  "
            strSQL &= "    invItemNroSerie.GestionId,  "
            strSQL &= "    invItemNroSerie.AlmacenId,  "
            strSQL &= "    invItemNroSerie.TipoNotaIdEnt,  "
            strSQL &= "    invItemNroSerie.NotaIdEnt,  "
            strSQL &= "    invItemNroSerie.TipoNotaIdSal,  "
            strSQL &= "    invItemNroSerie.NotaIdSal  "
            strSQL &= "    invItemNroSerie.ItemId,  "
            strSQL &= "    invItemNroSerie.ItemLoteId,  "
            strSQL &= "    invItemNroSerie.ItemLoteIdSal,  "
            strSQL &= "    invItemNroSerie.EstadoId,  "
            strSQL &= " FROM invItemNroSerie "

         Case SelectFilters.Report

         Case SelectFilters.GridFind
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    invItemNroSerie.ItemNroSerieId,  "
            strSQL &= "    invItemNroSerie.EmpresaId,  "
            strSQL &= "    invItemNroSerie.GestionId,  "
            strSQL &= "    invItemNroSerie.AlmacenId,  "
            strSQL &= "    invItemNroSerie.TipoNotaIdEnt,  "
            strSQL &= "    invItemNroSerie.NotaIdEnt,  "
            strSQL &= "    invItemNroSerie.TipoNotaIdSal,  "
            strSQL &= "    invItemNroSerie.NotaIdSal,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItemLote.ItemLoteId,  "
            strSQL &= "    invItemLote.ItemLoteDes,  "
            strSQL &= "    invItemNroSerie.ItemNroSerieCod,  "
            strSQL &= "    invItemNroSerie.ItemLoteIdSal,  "
            strSQL &= "    invItemNroSerie.AppId,  "
            strSQL &= "    invItemNroSerie.TipoDocumentoId,  "
            strSQL &= "    invItemNroSerie.DocumentoId,  "
            strSQL &= "    invItemNroSerie.DocumentoDetId,  "
            strSQL &= "    CAST('0' AS bit) as isDocumentoDetId,  "
            strSQL &= "    invItemNroSerie.EstadoId  "
            strSQL &= " FROM invItemNroSerie, invItem, invItemLote "

         Case SelectFilters.GridDevSalida
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    invItemNroSerie.ItemNroSerieId,  "
            strSQL &= "    invItemNroSerie.EmpresaId,  "
            strSQL &= "    invItemNroSerie.GestionId,  "
            strSQL &= "    invItemNroSerie.AlmacenId,  "
            strSQL &= "    invItemNroSerie.TipoNotaIdEnt,  "
            strSQL &= "    invItemNroSerie.NotaIdEnt,  "
            strSQL &= "    invItemNroSerie.TipoNotaIdSal,  "
            strSQL &= "    invItemNroSerie.NotaIdSal,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItemLoteEnt.ItemLoteId,  "
            strSQL &= "    invItemLoteEnt.ItemLoteDes,  "
            strSQL &= "    invItemLoteSal.ItemLoteId ItemLoteIdSal,  "
            strSQL &= "    invItemLoteSal.ItemLoteDes ItemLoteDesSal,  "
            strSQL &= "    invItemNroSerie.ItemNroSerieCod,  "
            strSQL &= "    invItemNroSerie.AppId,  "
            strSQL &= "    invItemNroSerie.TipoDocumentoId,  "
            strSQL &= "    invItemNroSerie.DocumentoId,  "
            strSQL &= "    invItemNroSerie.DocumentoDetId,  "
            strSQL &= "    CAST('0' AS bit) as isDocumentoDetId,  "
            strSQL &= "    invItemNroSerie.EstadoId  "
            strSQL &= " FROM invItemNroSerie, invItem, invItemLote invItemLoteEnt, invItemLote invItemLoteSal "

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
            strSQL = " WHERE  invItemNroSerie.ItemNroSerieId = " & NumberToField(mlngItemNroSerieId)

         Case WhereFilters.Grid
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId,  "
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.Report

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.NotaIdEnt
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdEnt = " & NumberToField(mlngNotaIdEnt)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.ItemSerie
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.ItemNroSerieCod = " & StringToField(mstrItemNroSerieCod)
            strSQL &= " AND  invItemNroSerie.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = 0 "
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "

         Case WhereFilters.NotaIdSal
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = " & NumberToField(mlngNotaIdSal)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.ItemId
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.TieneMovimiento
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdEnt = " & NumberToField(mlngNotaIdEnt)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal <> 0 "
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "

         Case WhereFilters.DeleteNotaIdEnt
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdEnt = " & NumberToField(mlngNotaIdEnt)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "

         Case WhereFilters.ItemSerie_DevSal
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.ItemNroSerieCod = " & StringToField(mstrItemNroSerieCod)
            strSQL &= " AND  invItemNroSerie.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = " & NumberToField(mlngNotaIdSal)
            strSQL &= " AND  invItemNroSerie.NotaIdSal <> 0 "
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "

            If mlngItemLoteIdSal <> 0 Then
               strSQL &= " AND  invItemNroSerie.ItemLoteIdSal = " & NumberToField(mlngItemLoteIdSal)
            End If

            strSQL &= " AND  invItemNroSerie.ItemNroSerieId NOT IN (SELECT ItemNroSerieIdDev "
            strSQL &= "                                              FROM  invItemNroSerie "
            strSQL &= "                                              WHERE invItemNroSerie.EstadoId <> 12 ) "

         Case WhereFilters.ItemSerie_DevEnt
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.ItemNroSerieCod = " & StringToField(mstrItemNroSerieCod)
            strSQL &= " AND  invItemNroSerie.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemNroSerie.NotaIdEnt = " & NumberToField(mlngNotaIdEnt)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = 0 "
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "

         Case WhereFilters.NotaIdSal_DocId
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = " & NumberToField(mlngNotaIdSal)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND ( invItemNroSerie.AppId = " & NumberToField(mlngAppId)
            strSQL &= "  OR  invItemNroSerie.AppId = 0 )"
            strSQL &= " AND ( invItemNroSerie.TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId)
            strSQL &= "  OR  invItemNroSerie.TipoDocumentoId = 0 ) "
            strSQL &= " AND ( invItemNroSerie.DocumentoId = " & NumberToField(mlngDocumentoId)
            strSQL &= "  OR  invItemNroSerie.DocumentoId = 0) "
            strSQL &= " AND ( invItemNroSerie.DocumentoDetId = " & NumberToField(mlngDocumentoDetId)
            strSQL &= "  OR  invItemNroSerie.DocumentoDetId = 0 ) "
            If mlngItemLoteIdSal <> 0 Then
               strSQL &= " AND  invItemNroSerie.ItemLoteIdSal = " & NumberToField(mlngItemLoteIdSal)
            End If

         Case WhereFilters.NotaIdSal_DocDetId
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = " & NumberToField(mlngNotaIdSal)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.AppId = " & NumberToField(mlngAppId)
            strSQL &= " AND  invItemNroSerie.TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId)
            strSQL &= " AND  invItemNroSerie.DocumentoId = " & NumberToField(mlngDocumentoId)
            strSQL &= " AND  invItemNroSerie.DocumentoDetId = " & NumberToField(mlngDocumentoDetId)
            If mlngItemLoteIdSal <> 0 Then
               strSQL &= " AND  invItemNroSerie.ItemLoteIdSal = " & NumberToField(mlngItemLoteIdSal)
            End If

         Case WhereFilters.DocumentoDetId
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = " & NumberToField(mlngNotaIdSal)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.DocumentoId = " & NumberToField(mlngDocumentoId)
            strSQL &= " AND  invItemNroSerie.DocumentoDetId = " & NumberToField(mlngDocumentoDetId)

         Case WhereFilters.GridFind
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemNroSerie.ItemId = invItem.ItemId "
            strSQL &= " AND  invItemNroSerie.ItemLoteId = invItemLote.ItemLoteId "
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "

         Case WhereFilters.GridSalida
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemNroSerie.ItemId = invItem.ItemId "
            strSQL &= " AND  invItemNroSerie.ItemLoteId = invItemLote.ItemLoteId "
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "

            If mlngItemLoteId <> 0 Then
               strSQL &= " AND  invItemNroSerie.ItemLoteId = " & NumberToField(mlngItemLoteId)
            End If

            If mlngNotaIdSal <> 0 Then
               strSQL &= " AND ( invItemNroSerie.NotaIdSal = 0 "
               strSQL &= "   OR  invItemNroSerie.NotaIdSal = " & NumberToField(NotaIdSal) & " )"
            Else
               strSQL &= " AND  invItemNroSerie.NotaIdSal = 0 "
            End If

         Case WhereFilters.GridDevSalida
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemNroSerie.ItemId = invItem.ItemId "
            strSQL &= " AND  invItemNroSerie.ItemLoteId = invItemLoteEnt.ItemLoteId "
            strSQL &= " AND  invItemNroSerie.ItemLoteIdSal = invItemLoteSal.ItemLoteId "
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal <> 0 "
            strSQL &= " AND  invItemNroSerie.NotaIdSal = " & NumberToField(mlngNotaIdSal)
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "

            If mlngItemLoteIdSal <> 0 Then
               strSQL &= " AND  invItemNroSerie.ItemLoteIdSal = " & NumberToField(mlngItemLoteIdSal)
            End If

            strSQL &= " AND  invItemNroSerie.ItemNroSerieId NOT IN (SELECT ItemNroSerieIdDev "
            strSQL &= "                                              FROM  invItemNroSerie "
            strSQL &= "                                              WHERE invItemNroSerie.EstadoId <> 12 ) "
        

         Case WhereFilters.GridDevEntrada
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.ItemId = invItem.ItemId "
            strSQL &= " AND  invItemNroSerie.ItemLoteId = invItemLote.ItemLoteId "
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemNroSerie.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemNroSerie.NotaIdEnt = " & NumberToField(mlngNotaIdEnt)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = 0 "
            strSQL &= " AND  invItemNroSerie.EstadoId <> 12 "
            If mlngItemLoteId <> 0 Then
               strSQL &= " AND  invItemNroSerie.ItemLoteId = " & NumberToField(mlngItemLoteId)
            End If

         Case WhereFilters.NotaItemIdEnt
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdEnt = " & NumberToField(mlngNotaIdEnt)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)

            If mlngItemLoteId <> 0 Then
               strSQL &= " AND  invItemNroSerie.ItemLoteId = " & NumberToField(mlngItemLoteId)
            End If

         Case WhereFilters.NotaItemIdSal
            strSQL = " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemNroSerie.NotaIdSal = " & NumberToField(mlngNotaIdSal)
            strSQL &= " AND  invItemNroSerie.ItemId = " & NumberToField(mlngItemId)

            If mlngItemLoteIdSal <> 0 Then
               strSQL &= " AND  invItemNroSerie.ItemLoteIdSal = " & NumberToField(mlngItemLoteIdSal)
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ItemNroSerieId
            strSQL = " ORDER BY invItemNroSerie.ItemNroSerieId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invItemNroSerie.ItemNroSerieCod "

         Case OrderByFilters.Report

         Case OrderByFilters.ItemId
            strSQL = " ORDER BY invItemNroSerie.ItemId "

         Case OrderByFilters.GridFind
            strSQL = " ORDER BY invItemNroSerie.ItemId, invItemNroSerie.ItemLoteId, invItemNroSerie.ItemNroSerieId "

         Case OrderByFilters.GridDevSalida
            strSQL = " ORDER BY invItemNroSerie.ItemId, invItemNroSerie.ItemLoteIdSal, invItemNroSerie.ItemNroSerieId "

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
            strSQL = "INSERT INTO invItemNroSerie ("
            strSQL &= "ItemNroSerieId, "
            strSQL &= "ItemNroSerieCod, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "AlmacenId, "
            strSQL &= "TipoNotaIdEnt, "
            strSQL &= "NotaIdEnt, "
            strSQL &= "TipoNotaIdSal, "
            strSQL &= "NotaIdSal, "
            strSQL &= "ItemId, "
            strSQL &= "ItemLoteId, "
            strSQL &= "ItemLoteIdSal, "
            strSQL &= "ItemNroSerieIdDev, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= "DocumentoDetId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngItemNroSerieId) & ", "
            strSQL &= StringToField(mstrItemNroSerieCod) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngTipoNotaIdEnt) & ", "
            strSQL &= NumberToField(mlngNotaIdEnt) & ", "
            strSQL &= NumberToField(mlngTipoNotaIdSal) & ", "
            strSQL &= NumberToField(mlngNotaIdSal) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= NumberToField(mlngItemLoteId) & ", "
            strSQL &= NumberToField(mlngItemLoteIdSal) & ", "
            strSQL &= NumberToField(mlngItemNroSerieIdDev) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= NumberToField(mlngDocumentoId) & ", "
            strSQL &= NumberToField(mlngDocumentoDetId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "

            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invItemNroSerie SET "
            strSQL &= "ItemNroSerieCod = " & StringToField(mstrItemNroSerieCod) & ", "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "TipoNotaIdEnt = " & NumberToField(mlngTipoNotaIdEnt) & ", "
            strSQL &= "NotaIdEnt = " & NumberToField(mlngNotaIdEnt) & ", "
            strSQL &= "TipoNotaIdSal = " & NumberToField(mlngTipoNotaIdSal) & ", "
            strSQL &= "NotaIdSal = " & NumberToField(mlngNotaIdSal) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "ItemLoteId = " & NumberToField(mlngItemLoteId) & ", "
            strSQL &= "ItemLoteIdSal = " & NumberToField(mlngItemLoteIdSal) & ", "
            strSQL &= "ItemNroSerieIdDev = " & NumberToField(mlngItemNroSerieIdDev) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "DocumentoDetId = " & NumberToField(mlngDocumentoDetId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ItemNroSerieId = " & NumberToField(mlngItemNroSerieId) & " "

         Case UpdateFilters.ConSerieIdDev
            strSQL = "UPDATE invItemNroSerie SET "
            strSQL &= "ItemNroSerieIdDev = " & NumberToField(mlngItemNroSerieId) & " "
            strSQL &= " WHERE "
            strSQL &= " EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND ItemNroSerieIdDev = " & NumberToField(mlngItemNroSerieIdDev)

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
               mlngItemNroSerieId = ToLong(oDataRow("ItemNroSerieId"))
               mstrItemNroSerieCod = ToStr(oDataRow("ItemNroSerieCod"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngTipoNotaIdEnt = ToLong(oDataRow("TipoNotaIdEnt"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngNotaIdEnt = ToLong(oDataRow("NotaIdEnt"))
               mlngNotaIdSal = ToLong(oDataRow("NotaIdSal"))
               mlngItemLoteId = ToLong(oDataRow("ItemLoteId"))
               mlngItemLoteIdSal = ToLong(oDataRow("ItemLoteIdSal"))
               mlngTipoNotaIdSal = ToLong(oDataRow("TipoNotaIdSal"))
               mlngItemNroSerieIdDev = ToLong(oDataRow("ItemNroSerieIdDev"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mlngDocumentoDetId = ToLong(oDataRow("DocumentoDetId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngItemNroSerieId = ToLong(oDataRow("ItemNroSerieId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngItemNroSerieId = TableIDGet(mstrTableName, "ItemNroSerieId", moConnection)

         If mlngItemNroSerieId = -1 Then
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

      If mlngGestionId = 0 Then
         strMsg &= "Gestión Inválida" & vbCrLf
      End If

      If mlngAlmacenId = 0 Then
         strMsg &= "Almacén Inválido" & vbCrLf
      End If

      If mlngTipoNotaIdEnt = 0 Then
         strMsg &= "Tipo de Nota Inválido" & vbCrLf
      End If

      If mlngNotaIdEnt = 0 Then
         strMsg &= "Nota Inválido" & vbCrLf
      End If

      If mlngItemId = 0 Then
         strMsg &= "Item Inválido" & vbCrLf
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
         'strSQL &= " FROM invItemNroSerie "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  invItemNroSerie.TipoNotaIdSal = " & NumberToField(mlngTipoNotaIdSal)
         'Else
         '   strSQL &= " WHERE  invItemNroSerie.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  invItemNroSerie.TipoNotaIdSal = " & NumberToField(mlngTipoNotaIdSal)
         '   strSQL &= " AND  invItemNroSerie.ItemNroSerieId <> " & NumberToField(mlngItemNroSerieId)
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

   Public Function InsertOnly() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      InsertOnly = False

      Try
         If GetNewPrimaryKey() Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = InsertSQL()
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteNonQuery()

            If intRecordsAffected > 0 Then
               InsertOnly = True
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

   Public Function UpdateOnly() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      UpdateOnly = False

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = UpdateSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = oCommand.ExecuteNonQuery()

         If intRecordsAffected > 0 Then
            UpdateOnly = True
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
