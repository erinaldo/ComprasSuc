Imports System.Data
Imports System.Data.OleDb

Public Class clsDevCompraDet
   Implements IDisposable

   Private mlngDevCompraDetId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngCompraId As Long
   Private mlngDevCompraId As Long
   Private mstrFecha As String
   Private mlngAlmacenId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mlngItemId As Long
   Private mlngMedidaId As Long
   Private mdecCantidadOrg As Decimal
   Private mdecCantidadDev As Decimal
   Private mdecPrecioOrg As Decimal
   Private mdecPrecioCos As Decimal
   Private mdecPrecioNet As Decimal
   Private mdecImporte As Decimal
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
   Property DevCompraDetId() As Long
      Get
         Return mlngDevCompraDetId
      End Get

      Set(ByVal Value As Long)
         mlngDevCompraDetId = Value
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

   Property DevCompraId() As Long
      Get
         Return mlngDevCompraId
      End Get

      Set(ByVal Value As Long)
         mlngDevCompraId = Value
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

   Property CantidadOrg() As Decimal
      Get
         Return mdecCantidadOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecCantidadOrg = Value
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

   Property PrecioNet() As Decimal
      Get
         Return mdecPrecioNet
      End Get

      Set(ByVal Value As Decimal)
         mdecPrecioNet = Value
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
      DEVCOMPRAID_ITEM = 4
      MEDIDA_DISTINCT = 5
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      CompraId = 6
      ITEMID = 7
      DEVCOMPRAID_ITEM = 8
      DEVCOMPRAID = 9
      MEDIDA_DISTINCT = 10

      CompraItemId = 11
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      DevCompraDetId = 1
      Grid = 3
      Report = 4
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
      CantidadOrg = 1
      CantidadOrgSal = 2
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
      mstrTableName = "comDevCompraDet"
      mstrClassName = "clsDevCompraDet"

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
      mlngDevCompraDetId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngCompraId = 0
      mlngDevCompraId = 0
      mstrFecha = ""
      mlngAlmacenId = 0
      mlngProveedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mlngItemId = 0
      mlngMedidaId = 0
      mdecCantidadOrg = 0
      mdecCantidadDev = 0
      mdecPrecioOrg = 0
      mdecPrecioCos = 0
      mdecPrecioNet = 0
      mdecImporte = 0
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
            strSQL &= "    comDevCompraDet.DevCompraDetId,  "
            strSQL &= "    comDevCompraDet.EmpresaId,  "
            strSQL &= "    comDevCompraDet.GestionId,  "
            strSQL &= "    comDevCompraDet.CompraId,  "
            strSQL &= "    comDevCompraDet.DevCompraId,  "
            strSQL &= "    comDevCompraDet.Fecha,  "
            strSQL &= "    comDevCompraDet.AlmacenId,  "
            strSQL &= "    comDevCompraDet.ProveedorId,  "
            strSQL &= "    comDevCompraDet.MonedaId,  "
            strSQL &= "    comDevCompraDet.TipoCambio,  "
            strSQL &= "    comDevCompraDet.ItemId,  "
            strSQL &= "    comDevCompraDet.MedidaId,  "
            strSQL &= "    comDevCompraDet.CantidadOrg,  "
            strSQL &= "    comDevCompraDet.CantidadDev,  "
            strSQL &= "    comDevCompraDet.PrecioOrg,  "
            strSQL &= "    comDevCompraDet.PrecioCos,  "
            strSQL &= "    comDevCompraDet.PrecioNet,  "
            strSQL &= "    comDevCompraDet.Importe,  "
            strSQL &= "    comDevCompraDet.CentroCostoId,  "
            strSQL &= "    comDevCompraDet.SucursalId,  "
            strSQL &= "    comDevCompraDet.EstadoId,  "
            strSQL &= "    comDevCompraDet.sLastUpdate_id,  "
            strSQL &= "    comDevCompraDet.dtLastUpdate_dt,  "
            strSQL &= "    comDevCompraDet.iConcurrency_id  "
            strSQL &= " FROM comDevCompraDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comDevCompraDet.DevCompraDetId  "
            strSQL &= " FROM comDevCompraDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comDevCompraDet.DevCompraDetId,  "
            strSQL &= "    comDevCompraDet.EmpresaId,  "
            strSQL &= "    comDevCompraDet.CompraId,  "
            strSQL &= "    comDevCompraDet.DevCompraId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invItem.TipoItemId,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comDevCompraDet.CantidadOrg,  "
            strSQL &= "    comDevCompraDet.CantidadDev,  "
            strSQL &= "    comDevCompraDet.PrecioOrg,  "
            strSQL &= "    comDevCompraDet.PrecioCos,  "
            strSQL &= "    comDevCompraDet.PrecioNet,  "
            strSQL &= "    comDevCompraDet.Importe  "
            strSQL &= " FROM comDevCompraDet, invItem, invMedida "

         Case SelectFilters.DEVCOMPRAID_ITEM
            strSQL = " SELECT  "
            strSQL &= "    comDevCompraDet.DevCompraDetId,  "
            strSQL &= "    comDevCompraDet.DevCompraId,  "
            strSQL &= "    comDevCompraDet.ItemId As DevCompraDetItemId,  "
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
            strSQL &= " FROM comDevCompraDet LEFT OUTER JOIN invItem ON comDevCompraDet.ItemId = invItem.ItemId "

         Case SelectFilters.Report

         Case SelectFilters.MEDIDA_DISTINCT
            strSQL = " SELECT DISTINCT "
            strSQL &= "    comDevCompraDet.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes  "
            strSQL &= " FROM comDevCompraDet, invMedida "

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
            strSQL = " WHERE  comDevCompraDet.DevCompraDetId = " & NumberToField(mlngDevCompraDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompraDet.DevCompraId = " & NumberToField(mlngDevCompraId)
            strSQL &= " AND  comDevCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comDevCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.Report

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.CompraId
            strSQL = " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompraDet.CompraId = " & NumberToField(mlngCompraId)

         Case WhereFilters.ITEMID
            strSQL = " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompraDet.ItemId = " & NumberToField(mlngItemId)

         Case WhereFilters.DEVCOMPRAID_ITEM
            strSQL = " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompraDet.DevCompraId = " & NumberToField(mlngDevCompraId)

         Case WhereFilters.DEVCOMPRAID
            strSQL = " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompraDet.DevCompraId = " & NumberToField(mlngDevCompraId)

         Case WhereFilters.MEDIDA_DISTINCT
            strSQL = " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompraDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comDevCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.CompraItemId
            strSQL = " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompraDet.CompraId = " & NumberToField(mlngCompraId)
            strSQL &= " AND  comDevCompraDet.ItemId = " & NumberToField(mlngItemId)
            strSQL &= " AND  comDevCompraDet.EstadoId = 14  "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.DevCompraDetId
            strSQL = " ORDER BY comDevCompraDet.DevCompraDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comDevCompraDet.DevCompraDetId "

         Case OrderByFilters.Report

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
         Case RowSumFilters.CantidadOrg
            strSQL = "SELECT Sum(CantidadOrg) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowSumFilters.CantidadOrgSal
            strSQL = "SELECT Sum(CantidadOrgSal) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO comDevCompraDet ("
            strSQL &= "DevCompraDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "CompraId, "
            strSQL &= "DevCompraId, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenId, "
            strSQL &= "ProveedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "ItemId, "
            strSQL &= "MedidaId, "
            strSQL &= "CantidadOrg, "
            strSQL &= "CantidadDev, "
            strSQL &= "PrecioOrg, "
            strSQL &= "PrecioCos, "
            strSQL &= "PrecioNet, "
            strSQL &= "Importe, "
            strSQL &= "CentroCostoId, "
            strSQL &= "SucursalId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngDevCompraDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngDevCompraId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= NumberToField(mlngItemId) & ", "
            strSQL &= NumberToField(mlngMedidaId) & ", "
            strSQL &= DecimalToField(mdecCantidadOrg) & ", "
            strSQL &= DecimalToField(mdecCantidadDev) & ", "
            strSQL &= DecimalToField(mdecPrecioOrg) & ", "
            strSQL &= DecimalToField(mdecPrecioCos) & ", "
            strSQL &= DecimalToField(mdecPrecioNet) & ", "
            strSQL &= DecimalToField(mdecImporte) & ", "
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
            strSQL = "UPDATE comDevCompraDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "DevCompraId = " & NumberToField(mlngDevCompraId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "ItemId = " & NumberToField(mlngItemId) & ", "
            strSQL &= "MedidaId = " & NumberToField(mlngMedidaId) & ", "
            strSQL &= "CantidadOrg = " & DecimalToField(mdecCantidadOrg) & ", "
            strSQL &= "CantidadDev = " & DecimalToField(mdecCantidadDev) & ", "
            strSQL &= "PrecioOrg = " & DecimalToField(mdecPrecioOrg) & ", "
            strSQL &= "PrecioCos = " & DecimalToField(mdecPrecioCos) & ", "
            strSQL &= "PrecioNet = " & DecimalToField(mdecPrecioNet) & ", "
            strSQL &= "Importe = " & DecimalToField(mdecImporte) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " DevCompraDetId = " & NumberToField(mlngDevCompraDetId) & " "

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
               mlngDevCompraDetId = ToLong(oDataRow("DevCompraDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngDevCompraId = ToLong(oDataRow("DevCompraId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngItemId = ToLong(oDataRow("ItemId"))
               mlngMedidaId = ToLong(oDataRow("MedidaId"))
               mdecCantidadOrg = ToDecimal(oDataRow("CantidadOrg"))
               mdecCantidadDev = ToDecimal(oDataRow("CantidadDev"))
               mdecPrecioOrg = ToDecimal(oDataRow("PrecioOrg"))
               mdecPrecioCos = ToDecimal(oDataRow("PrecioCos"))
               mdecPrecioNet = ToDecimal(oDataRow("PrecioNet"))
               mdecImporte = ToDecimal(oDataRow("Importe"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngDevCompraDetId = ToLong(oDataRow("DevCompraDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngDevCompraDetId = TableIDGet(mstrTableName, "DevCompraDetId", moConnection)

         If mlngDevCompraDetId = -1 Then
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
         strMsg &= "Gestion Inválida" & vbCrLf
      End If

      If mlngCompraId = 0 Then
         strMsg &= "Compra Inválida" & vbCrLf
      End If

      If mlngDevCompraId = 0 Then
         strMsg &= "Devolución Inválida" & vbCrLf
      End If

      If mlngAlmacenId = 0 Then
         strMsg &= "Almacen Inválido" & vbCrLf
      End If

      If mlngProveedorId = 0 Then
         strMsg &= "Proveedor Inválido" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Seleccione la Moneda" & vbCrLf
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
         'strSQL &= " FROM comDevCompraDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comDevCompraDet.TipoCompraId = " & NumberToField(mlngTipoCompraId)
         'Else
         '   strSQL &= " WHERE  comDevCompraDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comDevCompraDet.TipoCompraId = " & NumberToField(mlngTipoCompraId)
         '   strSQL &= " AND  comDevCompraDet.DevCompraDetId <> " & NumberToField(mlngDevCompraDetId)
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
