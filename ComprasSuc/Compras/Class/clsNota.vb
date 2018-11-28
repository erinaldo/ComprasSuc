Imports System.Data
Imports System.Data.OleDb

Public Class clsNota
   Implements IDisposable

   Private mlngNotaId As Long
   Private mlngEmpresaId As Long
   Private mlngTipoNotaId As Long
   Private mlngNotaNro As Long
   Private mstrFecha As String
   Private mlngAlmacenIdOrg As Long
   Private mlngCajaMovIdOrg As Long
   Private mlngAlmacenIdDes As Long
   Private mlngCajaMovIdDes As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mstrNotaDes As String
   Private mstrNotaObs As String
   Private mdecNotaMonto As Decimal
   Private mlngGestionId As Long
   Private mlngPlanId As Long
   Private mbytConFac As Byte
   Private mbytSinFac As Byte
   Private mlngEstadoId As Long
   Private mstrNotaOrden As String
   Private mlngCentroCostoIdOrg As Long
   Private mlngCentroCostoIdDes As Long
   Private mlngSucursalId As Long
   Private mlngCompId As Long
   Private mlngAppId As Long
   Private mlngTipoDocumentoId As Long
   Private mlngDocumentoId As Long

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
   Property NotaId() As Long
      Get
         Return mlngNotaId
      End Get

      Set(ByVal Value As Long)
         mlngNotaId = Value
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

   Property TipoNotaId() As Long
      Get
         Return mlngTipoNotaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoNotaId = Value
      End Set
   End Property

   Property NotaNro() As Long
      Get
         Return mlngNotaNro
      End Get

      Set(ByVal Value As Long)
         mlngNotaNro = Value
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

   Property AlmacenIdOrg() As Long
      Get
         Return mlngAlmacenIdOrg
      End Get

      Set(ByVal Value As Long)
         mlngAlmacenIdOrg = Value
      End Set
   End Property

   Property CajaMovIdOrg() As Long
      Get
         Return mlngCajaMovIdOrg
      End Get

      Set(ByVal Value As Long)
         mlngCajaMovIdOrg = Value
      End Set
   End Property

   Property AlmacenIdDes() As Long
      Get
         Return mlngAlmacenIdDes
      End Get

      Set(ByVal Value As Long)
         mlngAlmacenIdDes = Value
      End Set
   End Property

   Property CajaMovIdDes() As Long
      Get
         Return mlngCajaMovIdDes
      End Get

      Set(ByVal Value As Long)
         mlngCajaMovIdDes = Value
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

   Property NotaDes() As String
      Get
         Return mstrNotaDes
      End Get

      Set(ByVal Value As String)
         mstrNotaDes = Value
      End Set
   End Property

   Property NotaObs() As String
      Get
         Return mstrNotaObs
      End Get

      Set(ByVal Value As String)
         mstrNotaObs = Value
      End Set
   End Property

   Property NotaMonto() As Decimal
      Get
         Return mdecNotaMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecNotaMonto = Value
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

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
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

   Property EstadoId() As Long
      Get
         Return mlngEstadoId
      End Get

      Set(ByVal Value As Long)
         mlngEstadoId = Value
      End Set
   End Property

   Property NotaOrden() As String
      Get
         Return mstrNotaOrden
      End Get

      Set(ByVal Value As String)
         mstrNotaOrden = Value
      End Set
   End Property

   Property CentroCostoIdOrg() As Long
      Get
         Return mlngCentroCostoIdOrg
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoIdOrg = Value
      End Set
   End Property

   Property CentroCostoIdDes() As Long
      Get
         Return mlngCentroCostoIdDes
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoIdDes = Value
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

   Property CompId() As Long
      Get
         Return mlngCompId
      End Get

      Set(ByVal Value As Long)
         mlngCompId = Value
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
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      ReportTraspaso = 6
      AlmacenId = 7
      GestionId = 8
      GestionMov = 9
      NotaNro = 10
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      NotaId = 1
      Grid = 3
      Report = 4
      NotaDes = 5
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
      mstrTableName = "invNota"
      mstrClassName = "clsNota"

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
      mlngNotaId = 0
      mlngEmpresaId = 0
      mlngTipoNotaId = 0
      mlngNotaNro = 0
      mstrFecha = ""
      mlngAlmacenIdOrg = 0
      mlngCajaMovIdOrg = 0
      mlngAlmacenIdDes = 0
      mlngCajaMovIdDes = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mstrNotaDes = ""
      mstrNotaObs = ""
      mdecNotaMonto = 0
      mlngGestionId = 0
      mlngPlanId = 0
      mbytConFac = 0
      mbytSinFac = 0
      mlngEstadoId = 0
      mstrNotaOrden = ""
      mlngCentroCostoIdOrg = 0
      mlngCentroCostoIdDes = 0
      mlngSucursalId = 0
      mlngCompId = 0
      mlngAppId = 0
      mlngTipoDocumentoId = 0
      mlngDocumentoId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0

   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.EmpresaId,  "
            strSQL &= "    invNota.TipoNotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    invNota.Fecha,  "
            strSQL &= "    invNota.AlmacenIdOrg,  "
            strSQL &= "    invNota.CajaMovIdOrg,  "
            strSQL &= "    invNota.AlmacenIdDes,  "
            strSQL &= "    invNota.CajaMovIdDes,  "
            strSQL &= "    invNota.MonedaId,  "
            strSQL &= "    invNota.TipoCambio,  "
            strSQL &= "    invNota.NotaDes,  "
            strSQL &= "    invNota.NotaObs,  "
            strSQL &= "    invNota.NotaMonto,  "
            strSQL &= "    invNota.GestionId,  "
            strSQL &= "    invNota.PlanId,  "
            strSQL &= "    invNota.SinFac,  "
            strSQL &= "    invNota.ConFac,  "
            strSQL &= "    invNota.EstadoId,  "
            strSQL &= "    invNota.NotaOrden,  "
            strSQL &= "    invNota.CentroCostoIdOrg,  "
            strSQL &= "    invNota.CentroCostoIdDes,  "
            strSQL &= "    invNota.SucursalId,  "
            strSQL &= "    invNota.CompId,  "
            strSQL &= "    invNota.AppId,  "
            strSQL &= "    invNota.TipoDocumentoId,  "
            strSQL &= "    invNota.DocumentoId,  "
            strSQL &= "    invNota.sLastUpdate_id,  "
            strSQL &= "    invNota.dtLastUpdate_dt,  "
            strSQL &= "    invNota.iConcurrency_id  "
            strSQL &= " FROM invNota "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaDes  "
            strSQL &= " FROM invNota "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    invNota.Fecha,  "
            strSQL &= "    invAlmacenOrg.AlmacenId As AlmacenIdOrg,  "
            strSQL &= "    invAlmacenOrg.AlmacenDes As AlmacenDesOrg,  "
            strSQL &= "    invAlmacenDes.AlmacenId As AlmacenIdDes,  "
            strSQL &= "    invAlmacenDes.AlmacenDes As AlmacenDesDes,  "
            strSQL &= "    invNota.NotaDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invNota.TipoCambio,  "
            strSQL &= "    invNota.NotaMonto,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    invNota.SinFac,  "
            strSQL &= "    invNota.ConFac,  "
            strSQL &= "    secApp.AppId,  "
            strSQL &= "    secApp.AppDes,  "
            strSQL &= "    invNota.TipoDocumentoId,  "
            strSQL &= "    invNota.DocumentoId,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    invNota.NotaOrden  "
            strSQL &= " FROM invNota, invTipoNota, invAlmacen As invAlmacenOrg, invAlmacen As invAlmacenDes, tblMoneda, tblComp, tblTipoComp, tblEstado, "
            strSQL &= "      tblSucursal, secApp "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.EmpresaId,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    invNota.Fecha,  "
            strSQL &= "    invAlmacenOrg.AlmacenId As AlmacenIdOrg,  "
            strSQL &= "    invAlmacenOrg.AlmacenDes As AlmacenDesOrg,  "
            strSQL &= "    invAlmacenDes.AlmacenId As AlmacenIdDes,  "
            strSQL &= "    invAlmacenDes.AlmacenDes As AlmacenDesDes,  "
            strSQL &= "    invNota.NotaDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    invNota.TipoCambio,  "
            strSQL &= "    invNota.NotaMonto,  "
            strSQL &= "    invNota.NotaObs,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "

            strSQL &= "    invNotaDet.NotaDetId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    invNotaDet.CantidadEnt,  "
            strSQL &= "    invNotaDet.CantidadSal,  "
            strSQL &= "    invNotaDet.PrecioCos,  "
            strSQL &= "    invNotaDet.Importe  "

            strSQL &= " FROM invNota, invTipoNota, invAlmacen invAlmacenOrg, invAlmacen invAlmacenDes, tblMoneda, tblComp, tblTipoComp, tblEstado, invNotaDet, invItem, invMedida  "

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
            strSQL = " WHERE  invNota.NotaId = " & NumberToField(mlngNotaId)

         Case WhereFilters.Grid
            strSQL = " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNota.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNota.AlmacenIdOrg = invAlmacenOrg.AlmacenId "
            strSQL &= " AND  invNota.AlmacenIdDes = invAlmacenDes.AlmacenId "
            strSQL &= " AND  invNota.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  invNota.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  invNota.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  invNota.AppId = secApp.AppId "
            strSQL &= " AND  invNota.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report
            strSQL = " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNota.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNota.AlmacenIdOrg = invAlmacenOrg.AlmacenId "
            strSQL &= " AND  invNota.AlmacenIdDes = invAlmacenDes.AlmacenId "
            strSQL &= " AND  invNota.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  invNota.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  invNota.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  invNota.NotaId = invNotaDet.NotaId "
            strSQL &= " AND  invNotaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.ReportTraspaso
            strSQL = " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNota.NotaId = " & NumberToField(mlngNotaId)
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  invNota.AlmacenIdOrg = invAlmacenOrg.AlmacenId "
            strSQL &= " AND  invNota.AlmacenIdDes = invAlmacenDes.AlmacenId "
            strSQL &= " AND  invNota.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  invNota.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  invNota.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  invNota.NotaId = invNotaDet.NotaId "
            strSQL &= " AND  invNotaDet.ItemId = invItem.ItemId "
            strSQL &= " AND  invNotaDet.MedidaId = invMedida.MedidaId "
            strSQL &= " AND  invNotaDet.TipoMovId = 2 "

         Case WhereFilters.AlmacenId
            strSQL = " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  (invNota.AlmacenIdOrg = " & NumberToField(mlngAlmacenIdOrg)
            strSQL &= " OR  invNota.AlmacenIdDes = " & NumberToField(mlngAlmacenIdDes) & ") "

         Case WhereFilters.GestionId
            strSQL = " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNota.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.GestionMov
            strSQL = " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNota.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invNota.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " AND  (invNota.EstadoId = 10 "
            strSQL &= " OR  invNota.EstadoId = 11) "

         Case WhereFilters.NotaNro
            strSQL = " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  invNota.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  invNota.TipoNotaId = " & NumberToField(mlngTipoNotaId)
            strSQL &= " AND  invNota.NotaNro = " & NumberToField(mlngNotaNro)
            strSQL &= " AND  invNota.SucursalId = " & NumberToField(mlngSucursalId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.NotaId
            strSQL = " ORDER BY invNota.NotaId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY invNota.NotaId DESC"

         Case OrderByFilters.NotaDes
            strSQL = " ORDER BY invNota.NotaDes "

         Case OrderByFilters.Report
            strSQL = " ORDER BY invNotaDet.NotaDetId "

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
            strSQL = "INSERT INTO invNota ("
            strSQL &= "NotaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "TipoNotaId, "
            strSQL &= "NotaNro, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenIdOrg, "
            strSQL &= "CajaMovIdOrg,  "
            strSQL &= "AlmacenIdDes, "
            strSQL &= "CajaMovIdDes,  "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "NotaDes, "
            strSQL &= "NotaObs, "
            strSQL &= "NotaMonto, "
            strSQL &= "GestionId, "
            strSQL &= "PlanId, "
            strSQL &= "ConFac, "
            strSQL &= "SinFac, "
            strSQL &= "EstadoId, "
            strSQL &= "NotaOrden, "
            strSQL &= "CentroCostoIdOrg, "
            strSQL &= "CentroCostoIdDes, "
            strSQL &= "SucursalId, "
            strSQL &= "CompId, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngNotaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngTipoNotaId) & ", "
            strSQL &= NumberToField(mlngNotaNro) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenIdOrg) & ", "
            strSQL &= NumberToField(mlngCajaMovIdOrg) & ", "
            strSQL &= NumberToField(mlngAlmacenIdDes) & ", "
            strSQL &= NumberToField(mlngCajaMovIdDes) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= StringToField(mstrNotaDes) & ", "
            strSQL &= StringToField(mstrNotaObs) & ", "
            strSQL &= DecimalToField(mdecNotaMonto) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= NumberToField(mbytSinFac) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= StringToField(mstrNotaOrden) & ", "
            strSQL &= NumberToField(mlngCentroCostoIdOrg) & ", "
            strSQL &= NumberToField(mlngCentroCostoIdDes) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= NumberToField(mlngDocumentoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE invNota SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "TipoNotaId = " & NumberToField(mlngTipoNotaId) & ", "
            strSQL &= "NotaNro = " & NumberToField(mlngNotaNro) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenIdOrg = " & NumberToField(mlngAlmacenIdOrg) & ", "
            strSQL &= "CajaMovIdOrg = " & NumberToField(mlngCajaMovIdOrg) & ", "
            strSQL &= "AlmacenIdDes = " & NumberToField(mlngAlmacenIdDes) & ", "
            strSQL &= "CajaMovIdDes = " & NumberToField(mlngCajaMovIdDes) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "NotaDes = " & StringToField(mstrNotaDes) & ", "
            strSQL &= "NotaObs = " & StringToField(mstrNotaObs) & ", "
            strSQL &= "NotaMonto = " & DecimalToField(mdecNotaMonto) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "SinFac = " & NumberToField(mbytSinFac) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "NotaOrden = " & StringToField(mstrNotaOrden) & ", "
            strSQL &= "CentroCostoIdOrg = " & NumberToField(mlngCentroCostoIdOrg) & ", "
            strSQL &= "CentroCostoIdDes = " & NumberToField(mlngCentroCostoIdDes) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " NotaId = " & NumberToField(mlngNotaId) & " "

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
               mlngNotaId = ToLong(oDataRow("NotaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngTipoNotaId = ToLong(oDataRow("TipoNotaId"))
               mlngNotaNro = ToLong(oDataRow("NotaNro"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenIdOrg = ToLong(oDataRow("AlmacenIdOrg"))
               mlngCajaMovIdOrg = ToLong(oDataRow("CajaMovIdOrg"))
               mlngAlmacenIdDes = ToLong(oDataRow("AlmacenIdDes"))
               mlngCajaMovIdDes = ToLong(oDataRow("CajaMovIdDes"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mstrNotaDes = ToStr(oDataRow("NotaDes"))
               mstrNotaObs = ToStr(oDataRow("NotaObs"))
               mdecNotaMonto = ToDecimal(oDataRow("NotaMonto"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mbytConFac = ToByte(oDataRow("ConFac"))
               mbytSinFac = ToByte(oDataRow("SinFac"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrNotaOrden = ToStr(oDataRow("NotaOrden"))
               mlngCentroCostoIdOrg = ToLong(oDataRow("CentroCostoIdOrg"))
               mlngCentroCostoIdDes = ToLong(oDataRow("CentroCostoIdDes"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngNotaId = ToLong(oDataRow("NotaId"))
               mstrNotaDes = ToStr(oDataRow("NotaDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngNotaId = TableIDGet(mstrTableName, "NotaId", moConnection)

         If mlngNotaId = -1 Then
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

      If mlngSucursalId = 0 Then
         strMsg &= "Sucursal Inválido" & vbCrLf
      End If

      If mlngTipoNotaId = 0 Then
         strMsg &= "Tipo de Nota Inválida" & vbCrLf
      End If

      If (mstrFecha.Trim() <> String.Empty) And (mstrFecha.Trim() <> "01/01/1990") Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha Inválida" & vbCrLf
         End If
      Else
         strMsg &= "Fecha Inválida" & vbCrLf
      End If

      If mlngAlmacenIdOrg = 0 Then
         strMsg &= "Almacen Inválido" & vbCrLf
      End If

      If (mlngAlmacenIdOrg <> 0) And (mlngTipoNotaId = 4) Then
         If mlngAlmacenIdDes = 0 Then
            strMsg &= "Almacen Destino Inválido" & vbCrLf

         ElseIf mlngAlmacenIdOrg = mlngAlmacenIdDes Then
            strMsg &= "Almacenes Iguales" & vbCrLf
         End If
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
         'strSQL &= " FROM invNota "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  invNota.TipoNotaId = " & NumberToField(mlngTipoNotaId)
         'Else
         '   strSQL &= " WHERE  invNota.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  invNota.TipoNotaId = " & NumberToField(mlngTipoNotaId)
         '   strSQL &= " AND  invNota.NotaId <> " & NumberToField(mlngNotaId)
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
