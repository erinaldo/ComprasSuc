Imports System.Data
Imports System.Data.OleDb

Public Class clsComp
   Implements IDisposable

   Private mlngCompId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   Private mlngCompNro As Long
   Private mstrFecha As String
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mstrEntregadoA As String
   Private mstrPorConcepto As String
   Private mdecDebeBs As Decimal
   Private mdecHaberBs As Decimal
   Private mdecDebeUs As Decimal
   Private mdecHaberUs As Decimal
   Private mdecPorIVA As Decimal
   Private mdecPorIT As Decimal
   Private mdecPorITF As Decimal
   Private mbytConFac As Byte
   Private mbytSinFac As Byte
   Private mbytAutomatico As Byte
   Private mlngTipoAsientoId As Long
   Private mstrGlosa As String
   Private mlngSucursalId As Long
   Private mlngNotaId As Long
   Private mlngAppId As Long
   Private mlngTipoDocumentoId As Long
   Private mlngDocumentoId As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Private moConnection As OleDbConnection
   Private moDataAdapter As OleDbDataAdapter
   Private moDataSet As DataSet
   Private mintRow As Integer
   Private mintRowsCount As Integer
   Private mintRowsMax As Integer

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompId() As Long
      Get
         Return mlngCompId
      End Get

      Set(ByVal Value As Long)
         mlngCompId = Value
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

   Property TipoCompId() As Long
      Get
         Return mlngTipoCompId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompId = Value
      End Set
   End Property

   Property CompNro() As Long
      Get
         Return mlngCompNro
      End Get

      Set(ByVal Value As Long)
         mlngCompNro = Value
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

   Property EntregadoA() As String
      Get
         Return mstrEntregadoA
      End Get

      Set(ByVal Value As String)
         mstrEntregadoA = Value
      End Set
   End Property

   Property PorConcepto() As String
      Get
         Return mstrPorConcepto
      End Get

      Set(ByVal Value As String)
         mstrPorConcepto = Value
      End Set
   End Property

   Property DebeBs() As Decimal
      Get
         Return mdecDebeBs
      End Get

      Set(ByVal Value As Decimal)
         mdecDebeBs = Value
      End Set
   End Property

   Property HaberBs() As Decimal
      Get
         Return mdecHaberBs
      End Get

      Set(ByVal Value As Decimal)
         mdecHaberBs = Value
      End Set
   End Property

   Property DebeUs() As Decimal
      Get
         Return mdecDebeUs
      End Get

      Set(ByVal Value As Decimal)
         mdecDebeUs = Value
      End Set
   End Property

   Property HaberUs() As Decimal
      Get
         Return mdecHaberUs
      End Get

      Set(ByVal Value As Decimal)
         mdecHaberUs = Value
      End Set
   End Property

   Property PorIVA() As Decimal
      Get
         Return mdecPorIVA
      End Get

      Set(ByVal Value As Decimal)
         mdecPorIVA = Value
      End Set
   End Property

   Property PorIT() As Decimal
      Get
         Return mdecPorIT
      End Get

      Set(ByVal Value As Decimal)
         mdecPorIT = Value
      End Set
   End Property

   Property PorITF() As Decimal
      Get
         Return mdecPorITF
      End Get

      Set(ByVal Value As Decimal)
         mdecPorITF = Value
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

   Property Automatico() As Byte
      Get
         Return mbytAutomatico
      End Get

      Set(ByVal Value As Byte)
         mbytAutomatico = Value
      End Set
   End Property

   Property TipoAsientoId() As Long
      Get
         Return mlngTipoAsientoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoAsientoId = Value
      End Set
   End Property

   Property Glosa() As String
      Get
         Return mstrGlosa
      End Get

      Set(ByVal Value As String)
         mstrGlosa = Value
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

   Property NotaId() As Long
      Get
         Return mlngNotaId
      End Get

      Set(ByVal Value As Long)
         mlngNotaId = Value
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

   Property RowsMax() As Integer
      Get
         Return mintRowsMax
      End Get

      Set(ByVal Value As Integer)
         mintRowsMax = Value
      End Set
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
      LibroDiario = 4
      GridCheck = 5
      GridImport = 6
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      LibroDiario = 5
      LibroDiarioAnulado = 6
      GestionId = 7
      CompNro = 8
      EmpresaId = 9
      GridFecha = 10
      GridFechaEstado = 11
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompId = 1
      Grid = 3
      Report = 4
      LibroDiario = 5
      GridFecha = 6
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      Saldo = 1
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
      mstrTableName = "tblComp"
      mstrClassName = "clsComp"

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
      mlngCompId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoCompId = 0
      mlngCompNro = 0
      mstrFecha = ""
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mstrEntregadoA = ""
      mstrPorConcepto = ""
      mdecDebeBs = 0
      mdecHaberBs = 0
      mdecDebeUs = 0
      mdecHaberUs = 0
      mdecPorIVA = 0
      mdecPorIT = 0
      mdecPorITF = 0
      mbytConFac = 0
      mbytSinFac = 0
      mbytAutomatico = 0
      mlngTipoAsientoId = 0
      mstrGlosa = ""
      mlngSucursalId = 0
      mlngNotaId = 0
      mlngAppId = 0
      mlngTipoDocumentoId = 0
      mlngDocumentoId = 0
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
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.EmpresaId,  "
            strSQL &= "    tblComp.GestionId,  "
            strSQL &= "    tblComp.TipoCompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.Fecha,  "
            strSQL &= "    tblComp.MonedaId,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.EntregadoA,  "
            strSQL &= "    tblComp.PorConcepto,  "
            strSQL &= "    tblComp.DebeBs,  "
            strSQL &= "    tblComp.HaberBs,  "
            strSQL &= "    tblComp.DebeUs,  "
            strSQL &= "    tblComp.HaberUs,  "
            strSQL &= "    tblComp.PorIVA,  "
            strSQL &= "    tblComp.PorIT,  "
            strSQL &= "    tblComp.PorITF,  "
            strSQL &= "    tblComp.ConFac,  "
            strSQL &= "    tblComp.SinFac,  "
            strSQL &= "    tblComp.Automatico,  "
            strSQL &= "    tblComp.TipoAsientoId,  "
            strSQL &= "    tblComp.Glosa,  "
            strSQL &= "    tblComp.SucursalId,  "
            strSQL &= "    tblComp.NotaId,  "
            strSQL &= "    tblComp.AppId,  "
            strSQL &= "    tblComp.TipoDocumentoId,  "
            strSQL &= "    tblComp.DocumentoId,  "
            strSQL &= "    tblComp.EstadoId,  "
            strSQL &= "    tblComp.sLastUpdate_id,  "
            strSQL &= "    tblComp.dtLastUpdate_dt,  "
            strSQL &= "    tblComp.iConcurrency_id  "
            strSQL &= " FROM tblComp "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblComp.CompId  "
            strSQL &= " FROM tblComp "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            If mintRowsMax > 0 Then strSQL &= " TOP " & NumberToField(mintRowsMax) & "  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.EmpresaId,  "
            strSQL &= "    tblComp.GestionId,  "
            strSQL &= "    tblComp.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.DebeBs,  "
            strSQL &= "    tblComp.DebeUs,  "
            strSQL &= "    tblComp.EntregadoA,  "
            strSQL &= "    tblComp.PorConcepto,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblComp.SinFac,  "
            strSQL &= "    tblComp.ConFac,  "
            strSQL &= "    tblTipoAsiento.TipoAsientoId,  "
            strSQL &= "    tblTipoAsiento.TipoAsientoDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblComp, tblTipoComp, tblMoneda, invNota, invTipoNota, tblTipoAsiento, tblEstado "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.EmpresaId,  "
            strSQL &= "    tblComp.GestionId,  "
            strSQL &= "    tblComp.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.DebeBs,  "
            strSQL &= "    tblComp.HaberBs,  "
            strSQL &= "    tblComp.DebeUs,  "
            strSQL &= "    tblComp.HaberUs,  "
            strSQL &= "    tblComp.EntregadoA,  "
            strSQL &= "    tblComp.PorConcepto,  "
            strSQL &= "    tblComp.Glosa,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.DebeBs As DetDebeBs,  "
            strSQL &= "    tblCompDet.HaberBs As DetHaberBs,  "
            strSQL &= "    tblCompDet.DebeUs As DetDebeUs,  "
            strSQL &= "    tblCompDet.HaberUs As DetHaberUs  "
            strSQL &= " FROM tblComp, tblTipoComp, tblMoneda, tblEstado, tblCompDet, tblPlan, tblSucursal, tblCentroCosto "

         Case SelectFilters.LibroDiario
            strSQL = " SELECT  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.EmpresaId,  "
            strSQL &= "    tblComp.GestionId,  "
            strSQL &= "    tblComp.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.DebeBs,  "
            strSQL &= "    tblComp.HaberBs,  "
            strSQL &= "    tblComp.DebeUs,  "
            strSQL &= "    tblComp.HaberUs,  "
            strSQL &= "    tblComp.EntregadoA,  "
            strSQL &= "    tblComp.PorConcepto,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblComp, tblTipoComp, tblEstado "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.EmpresaId,  "
            strSQL &= "    tblComp.GestionId,  "
            strSQL &= "    tblComp.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.DebeBs,  "
            strSQL &= "    tblComp.DebeUs,  "
            strSQL &= "    tblComp.EntregadoA,  "
            strSQL &= "    tblComp.PorConcepto,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblComp, tblTipoComp, tblMoneda, invNota, invTipoNota, tblEstado "

         Case SelectFilters.GridImport
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.EmpresaId,  "
            strSQL &= "    tblComp.GestionId,  "
            strSQL &= "    tblComp.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.DebeBs,  "
            strSQL &= "    tblComp.DebeUs,  "
            strSQL &= "    tblComp.EntregadoA,  "
            strSQL &= "    tblComp.PorConcepto,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblTipoAsiento.TipoAsientoId,  "
            strSQL &= "    tblTipoAsiento.TipoAsientoDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    CONVERT(bit, 0) As RowImport  "
            strSQL &= " FROM tblComp, tblTipoComp, tblMoneda, invNota, invTipoNota, tblTipoAsiento, tblEstado "

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
            strSQL = " WHERE  tblComp.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblComp.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblComp.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  tblComp.TipoAsientoId = tblTipoAsiento.TipoAsientoId "
            strSQL &= " AND  tblComp.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.Report
            strSQL = " WHERE  tblComp.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblComp.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblComp.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  tblCompDet.CentroCostoId = tblCentroCosto.CentroCostoId "

         Case WhereFilters.LibroDiario
            strSQL = " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblComp.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblComp.Fecha <= " & DateToField(mstrEntregadoA)
            strSQL &= " AND  tblComp.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  (tblComp.EstadoId = 10 "
            strSQL &= " OR  tblComp.EstadoId = 11) "
            If mbytSinFac = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mbytSinFac)
            If mbytConFac = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytConFac)

         Case WhereFilters.LibroDiarioAnulado
            strSQL = " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblComp.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblComp.Fecha <= " & DateToField(mstrEntregadoA)
            strSQL &= " AND  tblComp.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  (tblComp.EstadoId = 10 "
            strSQL &= " OR  tblComp.EstadoId = 11 "
            strSQL &= " OR  tblComp.EstadoId = 12) "
            If mbytSinFac = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mbytSinFac)
            If mbytConFac = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytConFac)

         Case WhereFilters.GestionId
            strSQL = " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  (tblComp.EstadoId = 10 "
            strSQL &= " OR  tblComp.EstadoId = 11) "

         Case WhereFilters.CompNro
            strSQL = " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblComp.TipoCompId = " & NumberToField(mlngTipoCompId)
            strSQL &= " AND  tblComp.CompNro = " & NumberToField(mlngCompNro)
            strSQL &= " AND  tblComp.SucursalId = " & NumberToField(mlngSucursalId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.GridFecha
            strSQL = " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            If mlngTipoCompId <> 0 Then
               strSQL &= " AND  tblComp.TipoCompId = " & NumberToField(mlngTipoCompId)
            End If
            strSQL &= " AND  tblComp.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblComp.Fecha <= " & DateToField(mstrEntregadoA)
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblComp.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblComp.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  tblComp.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GridFechaEstado
            strSQL = " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            If mlngTipoCompId <> 0 Then
               strSQL &= " AND  tblComp.TipoCompId = " & NumberToField(mlngTipoCompId)
            End If
            strSQL &= " AND  tblComp.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblComp.Fecha <= " & DateToField(mstrEntregadoA)
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblComp.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblComp.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  (tblComp.EstadoId = 10 "
            strSQL &= " OR  tblComp.EstadoId = 11) "
            strSQL &= " AND  tblComp.EstadoId = tblEstado.EstadoId "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompId
            strSQL = " ORDER BY tblComp.CompId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblComp.CompId DESC "

         Case OrderByFilters.Report
            strSQL = " ORDER BY tblCompDet.CompDetId "

         Case OrderByFilters.LibroDiario
            strSQL = " ORDER BY tblComp.Fecha, tblComp.CompId "

         Case OrderByFilters.GridFecha
            strSQL = " ORDER BY tblComp.Fecha, tblComp.CompId "

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
            strSQL = "INSERT INTO tblComp ("
            strSQL &= "CompId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoCompId, "
            strSQL &= "CompNro, "
            strSQL &= "Fecha, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "EntregadoA, "
            strSQL &= "PorConcepto, "
            strSQL &= "DebeBs, "
            strSQL &= "HaberBs, "
            strSQL &= "DebeUs, "
            strSQL &= "HaberUs, "
            strSQL &= "PorIVA, "
            strSQL &= "PorIT, "
            strSQL &= "PorITF, "
            strSQL &= "ConFac, "
            strSQL &= "SinFac, "
            strSQL &= "Automatico, "
            strSQL &= "TipoAsientoId, "
            strSQL &= "Glosa, "
            strSQL &= "SucursalId, "
            strSQL &= "NotaId, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= NumberToField(mlngCompNro) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= StringToField(mstrEntregadoA, 1000) & ", "
            strSQL &= StringToField(mstrPorConcepto, 1000) & ", "
            strSQL &= DecimalToField(mdecDebeBs) & ", "
            strSQL &= DecimalToField(mdecHaberBs) & ", "
            strSQL &= DecimalToField(mdecDebeUs) & ", "
            strSQL &= DecimalToField(mdecHaberUs) & ", "
            strSQL &= DecimalToField(mdecPorIVA) & ", "
            strSQL &= DecimalToField(mdecPorIT) & ", "
            strSQL &= DecimalToField(mdecPorITF) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= NumberToField(mbytSinFac) & ", "
            strSQL &= NumberToField(mbytAutomatico) & ", "
            strSQL &= NumberToField(mlngTipoAsientoId) & ", "
            strSQL &= StringToField(mstrGlosa) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngNotaId) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= NumberToField(mlngDocumentoId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblComp SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "CompNro = " & NumberToField(mlngCompNro) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "EntregadoA = " & StringToField(mstrEntregadoA, 1000) & ", "
            strSQL &= "PorConcepto = " & StringToField(mstrPorConcepto, 1000) & ", "
            strSQL &= "DebeBs = " & DecimalToField(mdecDebeBs) & ", "
            strSQL &= "HaberBs = " & DecimalToField(mdecHaberBs) & ", "
            strSQL &= "DebeUs = " & DecimalToField(mdecDebeUs) & ", "
            strSQL &= "HaberUs = " & DecimalToField(mdecHaberUs) & ", "
            strSQL &= "PorIVA = " & DecimalToField(mdecPorIVA) & ", "
            strSQL &= "PorIT = " & DecimalToField(mdecPorIT) & ", "
            strSQL &= "PorITF = " & DecimalToField(mdecPorITF) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "SinFac = " & NumberToField(mbytSinFac) & ", "
            strSQL &= "Automatico = " & NumberToField(mbytAutomatico) & ", "
            strSQL &= "TipoAsientoId = " & NumberToField(mlngTipoAsientoId) & ", "
            strSQL &= "Glosa = " & StringToField(mstrGlosa) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "NotaId = " & NumberToField(mlngNotaId) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompId = " & NumberToField(mlngCompId) & " "

         Case UpdateFilters.Saldo
            strSQL = "UPDATE tblComp SET "
            strSQL &= "DebeBs = " & DecimalToField(mdecDebeBs) & ", "
            strSQL &= "HaberBs = " & DecimalToField(mdecHaberBs) & ", "
            strSQL &= "DebeUs = " & DecimalToField(mdecDebeUs) & ", "
            strSQL &= "HaberUs = " & DecimalToField(mdecHaberUs) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompId = " & NumberToField(mlngCompId) & " "

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
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mlngCompNro = ToLong(oDataRow("CompNro"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mstrEntregadoA = ToStr(oDataRow("EntregadoA"))
               mstrPorConcepto = ToStr(oDataRow("PorConcepto"))
               mdecDebeBs = ToDecimal(oDataRow("DebeBs"))
               mdecHaberBs = ToDecimal(oDataRow("HaberBs"))
               mdecDebeUs = ToDecimal(oDataRow("DebeUs"))
               mdecHaberUs = ToDecimal(oDataRow("HaberUs"))
               mdecPorIVA = ToDecimal(oDataRow("PorIVA"))
               mdecPorIT = ToDecimal(oDataRow("PorIT"))
               mdecPorITF = ToDecimal(oDataRow("PorITF"))
               mbytConFac = ToByte(oDataRow("ConFac"))
               mbytSinFac = ToByte(oDataRow("SinFac"))
               mbytAutomatico = ToByte(oDataRow("Automatico"))
               mlngTipoAsientoId = ToLong(oDataRow("TipoAsientoId"))
               mstrGlosa = ToStr(oDataRow("Glosa"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngNotaId = ToLong(oDataRow("NotaId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompId = ToLong(oDataRow("CompId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompId = TableIDGet(mstrTableName, "CompId", moConnection)

         If mlngCompId = -1 Then
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

      If mlngSucursalId = 0 Then
         strMsg &= "Sucursal Inválido" & vbCrLf
      End If

      If mlngTipoCompId = 0 Then
         strMsg &= "Seleccione el Tipo de Comprobante" & vbCrLf
      End If

      If mstrFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
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
         strSQL = " SELECT  "
         strSQL &= " Count(*) As NumRecs  "
         strSQL &= " FROM tblComp "

         If Not boolReplace Then
            strSQL &= " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblComp.TipoCompId = " & NumberToField(mlngTipoCompId)
            strSQL &= " AND  tblComp.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblComp.CompNro = " & NumberToField(mlngCompNro)
            strSQL &= " AND  tblComp.CompNro <> 0 "
         Else
            strSQL &= " WHERE  tblComp.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblComp.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblComp.TipoCompId = " & NumberToField(mlngTipoCompId)
            strSQL &= " AND  tblComp.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblComp.CompNro = " & NumberToField(mlngCompNro)
            strSQL &= " AND  tblComp.CompNro <> 0 "
            strSQL &= " AND  tblComp.CompId <> " & NumberToField(mlngCompId)
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
               Throw New Exception("Número de Comprobante Duplicado")
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
               Throw New Exception("Número de Comprobante Duplicado")
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
