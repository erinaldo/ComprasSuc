Imports System.Data
Imports System.Data.OleDb

Public Class clsItemLote
   Implements IDisposable

   Private mlngItemLoteId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngAlmacenId As Long
   Private mlngTipoNotaId As Long
   Private mlngNotaId As Long
   Private mlngNotaDetId As Long
   Private mlngItemId As Long
   Private mstrItemLoteDes As String
   Private mlngMedidaId As Long
   Private mdecSaldoOrg As Decimal
   Private mdecSaldoAct As Decimal
   Private mstrFechaVen As String
   Private mlngItemLoteIdOrg As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Private mlngItemLoteIdDev As Long

   Private moConnection As OleDbConnection
   Private moDataAdapter As OleDbDataAdapter
   Private moDataSet As DataSet
   Private mintRow As Integer
   Private mintRowsCount As Integer

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   Public Const TABLE_NAME As String = "invItemLote"
   Public Const CLASS_NAME As String = "clsItemLote"

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property ItemLoteId() As Long
      Get
         Return mlngItemLoteId
      End Get

      Set(ByVal Value As Long)
         mlngItemLoteId = Value
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

   Property TipoNotaId() As Long
      Get
         Return mlngTipoNotaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoNotaId = Value
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

   Property NotaDetId() As Long
      Get
         Return mlngNotaDetId
      End Get

      Set(ByVal Value As Long)
         mlngNotaDetId = Value
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

   Property ItemLoteDes() As String
      Get
         Return mstrItemLoteDes
      End Get

      Set(ByVal Value As String)
         mstrItemLoteDes = Value
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

   Property SaldoOrg() As Decimal
      Get
         Return mdecSaldoOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecSaldoOrg = Value
      End Set
   End Property

   Property SaldoAct() As Decimal
      Get
         Return mdecSaldoAct
      End Get

      Set(ByVal Value As Decimal)
         mdecSaldoAct = Value
      End Set
   End Property

   Property FechaVen() As String
      Get
         Return mstrFechaVen
      End Get

      Set(ByVal Value As String)
         mstrFechaVen = Value
      End Set
   End Property

   Property ItemLoteIdOrg() As Long
      Get
         Return mlngItemLoteIdOrg
      End Get

      Set(ByVal Value As Long)
         mlngItemLoteIdOrg = Value
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

   Property ItemLoteIdDev() As Long
      Get
         Return mlngItemLoteIdDev
      End Get
      Set(ByVal Value As Long)
         mlngItemLoteIdDev = Value
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
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      ItemId = 6
      FechaVen = 7
      NotaDetId = 8
      NotaItemId = 9
      Saldo = 10
      Kardex = 11
      KardexFecha = 12
      KardexSalida = 13
      ItemLoteIdOrg = 14
      SaldoItemLoteId = 15


      TieneItemLoteIdOrg = 16
      TieneItemLoteIdDev = 17
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ItemLoteId = 1
      Grid = 3
      Report = 4
      Kardex = 5
      FechaVen = 6
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      SaldoOrg = 1
      LoteDesConIdOrg = 2
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
      PrimaryKey = 1
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
      mlngItemLoteId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngAlmacenId = 0
      mlngTipoNotaId = 0
      mlngNotaId = 0
      mlngNotaDetId = 0
      mlngItemId = 0
      mstrItemLoteDes = ""
      mlngMedidaId = 0
      mdecSaldoOrg = 0
      mdecSaldoAct = 0
      mstrFechaVen = ""
      mlngItemLoteIdOrg = 0
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
            strSQL &= "    invItemLote.ItemLoteId,  "
            strSQL &= "    invItemLote.EmpresaId,  "
            strSQL &= "    invItemLote.GestionId,  "
            strSQL &= "    invItemLote.AlmacenId,  "
            strSQL &= "    invItemLote.TipoNotaId,  "
            strSQL &= "    invItemLote.NotaId,  "
            strSQL &= "    invItemLote.NotaDetId,  "
            strSQL &= "    invItemLote.ItemId,  "
            strSQL &= "    invItemLote.ItemLoteDes,  "
            strSQL &= "    invItemLote.MedidaId,  "
            strSQL &= "    invItemLote.SaldoOrg,  "
            strSQL &= "    invItemLote.SaldoAct,  "
            strSQL &= "    invItemLote.FechaVen,  "
            strSQL &= "    invItemLote.ItemLoteIdOrg,  "
            strSQL &= "    invItemLote.EstadoId,  "
            strSQL &= "    invItemLote.sLastUpdate_id,  "
            strSQL &= "    invItemLote.dtLastUpdate_dt,  "
            strSQL &= "    invItemLote.iConcurrency_id,  "
            strSQL &= "    invItemLote.ItemLoteIdDev  "
            strSQL &= " FROM invItemLote "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invItemLote.ItemLoteId,  "
            strSQL &= "    invItemLote.ItemLoteDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    (invItemLote.SaldoOrg - invItemLote.SaldoAct) As 'Saldo',  "
            strSQL &= "    invItemLote.FechaVen  "
            strSQL &= " FROM invItemLote, invMedida "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invItemLote.ItemLoteId,  "
            strSQL &= "    invItemLote.TipoNotaId,  "
            strSQL &= "    invItemLote.NotaId,  "
            strSQL &= "    invItemLote.NotaDetId,  "
            strSQL &= "    invItemLote.ItemId,  "
            strSQL &= "    invItemLote.ItemLoteDes,  "
            strSQL &= "    invItemLote.MedidaId,  "
            strSQL &= "    invItemLote.SaldoOrg,  "
            strSQL &= "    invItemLote.SaldoAct,  "
            strSQL &= "    invItemLote.FechaVen,  "
            strSQL &= "    invItemLote.ItemLoteIdOrg,  "
            strSQL &= "    invItemLote.EstadoId  "
            strSQL &= " FROM invItemLote "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    invItemLote.ItemLoteId,  "
            strSQL &= "    invItemLote.EmpresaId,  "
            strSQL &= "    invItemLote.GestionId,  "
            strSQL &= "    invItemLote.AlmacenId,  "
            strSQL &= "    invItemLote.TipoNotaId,  "
            strSQL &= "    invItemLote.NotaId,  "
            strSQL &= "    invItemLote.NotaDetId,  "
            strSQL &= "    invItemLote.ItemId,  "
            strSQL &= "    invItemLote.ItemLoteDes,  "
            strSQL &= "    invItemLote.MedidaId,  "
            strSQL &= "    invItemLote.SaldoOrg,  "
            strSQL &= "    invItemLote.SaldoAct,  "
            strSQL &= "    invItemLote.FechaVen,  "
            strSQL &= "    invItemLote.ItemLoteIdOrg,  "
            strSQL &= "    invItemLote.ItemLoteIdDev,  "
            strSQL &= "    invItemLote.AppId,  "
            strSQL &= "    invItemLote.TipoDocumentoId,  "
            strSQL &= "    invItemLote.DocumentoId,  "
            strSQL &= "    invItemLote.DocumentoDetId,  "
            strSQL &= "    invItemLote.EstadoId,  "
            strSQL &= "    '' AS ItemNroSerieLote  "
            strSQL &= " FROM invItemLote "

         Case SelectFilters.Kardex
            strSQL = " SELECT  "
            strSQL &= "    invItemLote.ItemLoteId,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    invItemLote.NotaDetId,  "
            strSQL &= "    invItemLote.ItemId,  "
            strSQL &= "    invItemLote.ItemLoteDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invItemLote.SaldoOrg,  "
            strSQL &= "    invItemLote.SaldoAct,  "
            strSQL &= "    (invItemLote.SaldoOrg - invItemLote.SaldoAct) As Saldo,  "
            strSQL &= "    invItemLote.FechaVen,  "
            strSQL &= "    invItemLote.ItemLoteIdOrg  "
            strSQL &= " FROM invItemLote, invAlmacen, invTipoNota, invNota, invMedida "

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
            strSQL = " WHERE  invItemLote.ItemLoteId = " & NumberToField(mlngItemLoteId)

         Case WhereFilters.Grid
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invItemLote.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.Report

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.ItemId
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemLote.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemLote.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemLote.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.FechaVen
            'strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  invItemLote.GestionId = " & NumberToField(mlngGestionId)
            'strSQL &= " AND  invItemLote.AlmacenId = " & NumberToField(mlngAlmacenId)
            'strSQL &= " AND  invItemLote.ItemId = " & NumberToField(mlngItemId)
            'strSQL &= " AND  invItemLote.FechaVen <= " & DateToField(mstrFechaVen)

         Case WhereFilters.NotaDetId
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invItemLote.NotaDetId = " & NumberToField(mlngNotaDetId)

         Case WhereFilters.NotaItemId
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invItemLote.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.Saldo
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invItemLote.AlmacenId = " & NumberToField(mlngAlmacenId)
            strSQL &= " AND  invItemLote.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemLote.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  invItemLote.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (invItemLote.TipoNotaId = 1 "
            strSQL &= " OR  invItemLote.TipoNotaId = 2 "
            strSQL &= " OR  invItemLote.TipoNotaId = 4) "
            strSQL &= " AND  invItemLote.ItemLoteIdOrg = 0 "

         Case WhereFilters.Kardex
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invItemLote.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invItemLote.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemLote.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invItemLote.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invItemLote.NotaId = invNota.NotaId "
            strSQL &= " AND  invItemLote.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (invItemLote.TipoNotaId = 1 "
            strSQL &= " OR  invItemLote.TipoNotaId = 2 "
            strSQL &= " OR  invItemLote.TipoNotaId = 4) "
            strSQL &= " AND  invItemLote.ItemLoteIdOrg = 0 "

         Case WhereFilters.KardexFecha
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.GestionId = " & NumberToField(mlngGestionId)
            If mlngAlmacenId <> 0 Then
               strSQL &= " AND  invItemLote.AlmacenId = " & NumberToField(mlngAlmacenId)
            End If
            strSQL &= " AND  invItemLote.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  invItemLote.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invItemLote.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invItemLote.NotaId = invNota.NotaId "
            strSQL &= " AND  invItemLote.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invItemLote.FechaVen >= " & DateToField(mstrFechaVen)
            strSQL &= " AND  invItemLote.FechaVen <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  (invItemLote.TipoNotaId = 1 "
            strSQL &= " OR  invItemLote.TipoNotaId = 2 "
            strSQL &= " OR  invItemLote.TipoNotaId = 4) "
            strSQL &= " AND  invItemLote.ItemLoteIdOrg = 0 "

         Case WhereFilters.KardexSalida
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.ItemLoteIdOrg = " & NumberToField(mlngItemLoteId)
            strSQL &= " AND  invItemLote.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  invItemLote.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invItemLote.NotaId = invNota.NotaId "
            strSQL &= " AND  invItemLote.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  (invItemLote.TipoNotaId = 3 "
            strSQL &= " OR  invItemLote.TipoNotaId = 4) "

         Case WhereFilters.ItemLoteIdOrg
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.ItemLoteIdOrg = " & NumberToField(mlngItemLoteId)
            strSQL &= " AND  (invItemLote.TipoNotaId = 3 "
            strSQL &= " OR  invItemLote.TipoNotaId = 4) "

         Case WhereFilters.SaldoItemLoteId
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.ItemLoteId = " & NumberToField(mlngItemLoteId)
            strSQL &= " AND  invItemLote.MedidaId = invMedida.MedidaId "

         Case WhereFilters.TieneItemLoteIdOrg
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.ItemLoteIdOrg = " & NumberToField(mlngItemLoteIdOrg)
            strSQL &= " AND  (invItemLote.TipoNotaId = 3 "
            strSQL &= " OR  invItemLote.TipoNotaId = 4 "
            strSQL &= " OR  invItemLote.TipoNotaId = 6) "
            strSQL &= " AND  (invItemLote.EstadoId = 10 "
            strSQL &= " OR  invItemLote.EstadoId = 11 "
            strSQL &= " OR  invItemLote.EstadoId = 12 "
            strSQL &= " OR  invItemLote.EstadoId = 13) "

         Case WhereFilters.TieneItemLoteIdDev
            strSQL = " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invItemLote.ItemLoteIdDev = " & NumberToField(mlngItemLoteIdDev)
            strSQL &= " AND  (invItemLote.EstadoId <> 12 ) "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ItemLoteId
            strSQL = " ORDER BY invItemLote.ItemLoteId "

         Case OrderByFilters.Grid

         Case OrderByFilters.Report

         Case OrderByFilters.Kardex
            strSQL = " ORDER BY invItemLote.FechaVen "

         Case OrderByFilters.FechaVen
            strSQL = " ORDER BY invItemLote.FechaVen "

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
            strSQL = "INSERT INTO invItemLote ("
            strSQL &= "ItemLoteId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "AlmacenId, "
            strSQL &= "TipoNotaId, "
            strSQL &= "NotaId, "
            strSQL &= "NotaDetId, "
            strSQL &= "ItemId, "
            strSQL &= "ItemLoteDes, "
            strSQL &= "MedidaId, "
            strSQL &= "SaldoOrg, "
            strSQL &= "SaldoAct, "
            strSQL &= "FechaVen, "
            strSQL &= "ItemLoteIdOrg, "
            strSQL &= "EstadoId, "
            strSQL &= "ItemLoteIdDev, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngItemLoteId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngTipoNotaId) & ", "
            strSQL &= NumberToField(mlngNotaId) & ", "
            strSQL &= NumberToField(mlngNotaDetId) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= StringToField(mstrItemLoteDes) & ", "
            strSQL &= NumberToField(mlngMedidaId) & ", "
            strSQL &= DecimalToField(mdecSaldoOrg) & ", "
            strSQL &= DecimalToField(mdecSaldoAct) & ", "
            strSQL &= DateToField(mstrFechaVen) & ", "
            strSQL &= NumberToField(mlngItemLoteIdOrg) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= NumberToField(mlngItemLoteIdDev) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invItemLote SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "TipoNotaId = " & NumberToField(mlngTipoNotaId) & ", "
            strSQL &= "NotaId = " & NumberToField(mlngNotaId) & ", "
            strSQL &= "NotaDetId = " & NumberToField(mlngNotaDetId) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "ItemLoteDes = " & StringToField(mstrItemLoteDes) & ", "
            strSQL &= "MedidaId = " & NumberToField(mlngMedidaId) & ", "
            strSQL &= "SaldoOrg = " & DecimalToField(mdecSaldoOrg) & ", "
            strSQL &= "SaldoAct = " & DecimalToField(mdecSaldoAct) & ", "
            strSQL &= "FechaVen = " & DateToField(mstrFechaVen) & ", "
            strSQL &= "ItemLoteIdOrg = " & NumberToField(mlngItemLoteIdOrg) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ItemLoteId = " & NumberToField(mlngItemLoteId) & " "

         Case UpdateFilters.SaldoOrg
            strSQL = "UPDATE invItemLote SET "
            strSQL &= "SaldoOrg = " & DecimalToField(mdecSaldoOrg) & " "
            strSQL &= " WHERE "
            strSQL &= " ItemLoteId = " & NumberToField(mlngItemLoteId) & " "

         Case UpdateFilters.LoteDesConIdOrg
            strSQL = "UPDATE invItemLote SET "
            strSQL &= "ItemLoteDes = " & StringToField(mstrItemLoteDes) & " "
            strSQL &= " WHERE "
            strSQL &= " ItemLoteIdOrg = " & NumberToField(mlngItemLoteIdOrg) & " "

      End Select

      Return strSQL
   End Function

   Private Function DeleteSQL() As String
      Dim strSQL As String

      Select Case mintDeleteFilter
         Case DeleteFilters.All
            strSQL = "DELETE FROM " & mstrTableName
            strSQL &= WhereFilterGet()

         Case DeleteFilters.PrimaryKey
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
               mlngItemLoteId = ToLong(oDataRow("ItemLoteId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngTipoNotaId = ToLong(oDataRow("TipoNotaId"))
               mlngNotaId = ToLong(oDataRow("NotaId"))
               mlngNotaDetId = ToLong(oDataRow("NotaDetId"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mstrItemLoteDes = ToStr(oDataRow("ItemLoteDes"))
               mlngMedidaId = ToLong(oDataRow("MedidaId"))
               mdecSaldoOrg = ToDecimal(oDataRow("SaldoOrg"))
               mdecSaldoAct = ToDecimal(oDataRow("SaldoAct"))
               mstrFechaVen = ToDateDMY(oDataRow("FechaVen"))
               mlngItemLoteIdOrg = ToLong(oDataRow("ItemLoteIdOrg"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))
               mlngItemLoteIdDev = ToLong(oDataRow("ItemLoteIdDev"))

            Case SelectFilters.ListBox

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngItemLoteId = TableIDGet(mstrTableName, "ItemLoteId", moConnection)

         If mlngItemLoteId = -1 Then
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

      If mlngNotaId = 0 Then
         strMsg &= "Nota Inválido" & vbCrLf
      End If

      If mlngNotaId = 0 Then
         strMsg &= "NotaDet Inválido" & vbCrLf
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
         'strSQL &= " FROM invItemLote "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  invItemLote.TipoNotaId = " & NumberToField(mlngTipoNotaId)
         'Else
         '   strSQL &= " WHERE  invItemLote.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  invItemLote.TipoNotaId = " & NumberToField(mlngTipoNotaId)
         '   strSQL &= " AND  invItemLote.ItemLoteId <> " & NumberToField(mlngItemLoteId)
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
