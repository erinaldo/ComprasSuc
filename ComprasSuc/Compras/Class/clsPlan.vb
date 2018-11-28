Imports System.Data
Imports System.Data.OleDb

Public Class clsPlan
   Implements IDisposable

   Private mlngPlanId As Long
   Private mlngEmpresaId As Long
   Private mstrPlanDes As String
   Private mstrPlanCta As String
   Private mbytEsAna As Byte
   Private mlngPlanPadreId As Long
   Private mlngOrden As Long
   Private mlngNivel As Long
   Private mlngTipoPlanId As Long
   Private mlngTipoGrupoId As Long
   Private mlngMonedaId As Long
   Private mbytTieneAnaAdd As Byte
   Private mlngSucCCOId As Long
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

   Public Const SIN_ITF As Byte = 1
   Public Const CAJA As Byte = 2
   Public Const CUENTA_CORRIENTE As Byte = 3

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
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

   Property PlanDes() As String
      Get
         Return mstrPlanDes
      End Get

      Set(ByVal Value As String)
         mstrPlanDes = Value
      End Set
   End Property

   Property PlanCta() As String
      Get
         Return mstrPlanCta
      End Get

      Set(ByVal Value As String)
         mstrPlanCta = Value
      End Set
   End Property

   Property EsAna() As Byte
      Get
         Return mbytEsAna
      End Get

      Set(ByVal Value As Byte)
         mbytEsAna = Value
      End Set
   End Property

   Property PlanPadreId() As Long
      Get
         Return mlngPlanPadreId
      End Get

      Set(ByVal Value As Long)
         mlngPlanPadreId = Value
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

   Property Nivel() As Long
      Get
         Return mlngNivel
      End Get

      Set(ByVal Value As Long)
         mlngNivel = Value
      End Set
   End Property

   Property TipoPlanId() As Long
      Get
         Return mlngTipoPlanId
      End Get

      Set(ByVal Value As Long)
         mlngTipoPlanId = Value
      End Set
   End Property

   Property TipoGrupoId() As Long
      Get
         Return mlngTipoGrupoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoGrupoId = Value
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

   Property TieneAnaAdd() As Byte
      Get
         Return mbytTieneAnaAdd
      End Get

      Set(ByVal Value As Byte)
         mbytTieneAnaAdd = Value
      End Set
   End Property

   Property SucCCOId() As Long
      Get
         Return mlngSucCCOId
      End Get

      Set(ByVal Value As Long)
         mlngSucCCOId = Value
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
      GridCheck = 3
      MultiComboBox = 4
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      PlanDes = 2
      LIKEPlanDes = 3
      Grid = 4
      GridEsAna = 5
      PlanPadreId = 6
      Orden = 7
      TieneAnaAdd = 8
      EsAna = 9
      TipoPlanId = 10
      MonedaId = 11
      GridEstadoResultado = 12
      GridBalance = 13
      EstadoResultado = 14
      OrdenDeudora = 15
      OrdenAcreedora = 16
      GridTipoPlanId = 17
      GridTieneAnaAdd = 18
      EmpresaId = 19
      CajaBanco = 20
      PlanCta = 21
      EstadoId = 22
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PlanId = 1
      PlanDes = 2
      PlanCta = 3
      Grid = 4
      Orden = 5
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

   Public Enum RowMaxFilters As Byte
      Orden = 1
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
   Private mintRowMaxFilter As RowMaxFilters

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

   Property RowMaxFilter() As RowMaxFilters
      Get
         Return mintRowMaxFilter
      End Get

      Set(ByVal Value As RowMaxFilters)
         mintRowMaxFilter = Value
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
      mstrTableName = "tblPlan"
      mstrClassName = "clsPlan"

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
      mlngPlanId = 0
      mlngEmpresaId = 0
      mstrPlanDes = ""
      mstrPlanCta = ""
      mbytEsAna = 0
      mlngPlanPadreId = 0
      mlngOrden = 0
      mlngNivel = 0
      mlngTipoPlanId = 0
      mlngTipoGrupoId = 0
      mlngMonedaId = 0
      mbytTieneAnaAdd = 0
      mlngSucCCOId = 0
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
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblPlan.TipoPlanId,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblPlan.MonedaId,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblPlan.SucCCOId,  "
            strSQL &= "    tblPlan.EstadoId,  "
            strSQL &= "    tblPlan.sLastUpdate_id,  "
            strSQL &= "    tblPlan.dtLastUpdate_dt,  "
            strSQL &= "    tblPlan.iConcurrency_id  "
            strSQL &= " FROM tblPlan "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanDes  "
            strSQL &= " FROM tblPlan "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblTipoPlan.TipoPlanId,  "
            strSQL &= "    tblTipoPlan.TipoPlanDes,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblSucCCO.SucCCOId,  "
            strSQL &= "    tblSucCCO.SucCCODes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlan, tblTipoPlan, tblMoneda, tblSucCCO, tblEstado "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblTipoPlan.TipoPlanId,  "
            strSQL &= "    tblTipoPlan.TipoPlanDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblSucCCO.SucCCOId,  "
            strSQL &= "    tblSucCCO.SucCCODes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlan, tblTipoPlan, tblMoneda, tblSucCCO, tblEstado "

         Case SelectFilters.MultiComboBox
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    (tblPlan.PlanDes + ' - ' + tblPlan.PlanCta) As PlanDes  "
            strSQL &= " FROM tblPlan "

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
            strSQL = " WHERE  tblPlan.PlanId = " & NumberToField(mlngPlanId)

         Case WhereFilters.PlanDes
            strSQL = " WHERE  tblPlan.PlanDes = " & StringToField(mstrPlanDes)

         Case WhereFilters.LIKEPlanDes
            strSQL = " WHERE  tblPlan.PlanDes LIKE " & StringToField(mstrPlanDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)

         Case WhereFilters.GridEsAna
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)

         Case WhereFilters.GridTipoPlanId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.TipoPlanId = " & NumberToField(mlngTipoPlanId)

         Case WhereFilters.PlanPadreId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)

         Case WhereFilters.Orden
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)
            strSQL &= " AND  tblPlan.Orden = " & NumberToField(mlngOrden)

         Case WhereFilters.TieneAnaAdd
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TieneAnaAdd = " & NumberToField(mbytTieneAnaAdd)

         Case WhereFilters.EsAna
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)

            If mlngEstadoId <> 0 Then
               If mlngPlanId = 0 Then
                  strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
               Else
                  strSQL &= " AND  (tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
                  strSQL &= " OR  tblPlan.PlanId = " & NumberToField(mlngPlanId) & ") "
               End If
            End If

         Case WhereFilters.TipoPlanId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = " & NumberToField(mlngTipoPlanId)

         Case WhereFilters.MonedaId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  tblPlan.MonedaId = " & NumberToField(mlngMonedaId)

         Case WhereFilters.GridEstadoResultado
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)
            strSQL &= " AND  (tblPlan.PlanCTA = '4' "
            strSQL &= " OR  tblPlan.PlanCTA = '5' "
            strSQL &= " OR  tblPlan.PlanCTA = '6') "

         Case WhereFilters.GridBalance
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)
            strSQL &= " AND  (tblPlan.PlanCTA = '1' "
            strSQL &= " OR  tblPlan.PlanCTA = '2' "
            strSQL &= " OR  tblPlan.PlanCTA = '3') "

         Case WhereFilters.EstadoResultado
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = 1 "
            strSQL &= " AND  (tblPlan.PlanCTA LIKE " & StringToField("4" & LikeOperator)
            strSQL &= " OR  tblPlan.PlanCTA LIKE " & StringToField("5" & LikeOperator)
            strSQL &= " OR  tblPlan.PlanCTA LIKE " & StringToField("6" & LikeOperator) & ") "

         Case WhereFilters.OrdenDeudora
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = 1 "
            strSQL &= " AND  tblPlan.PlanCTA LIKE " & StringToField("7" & LikeOperator)

         Case WhereFilters.OrdenAcreedora
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = 1 "
            strSQL &= " AND  tblPlan.PlanCTA LIKE " & StringToField("8" & LikeOperator)

         Case WhereFilters.GridTieneAnaAdd
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.TieneAnaAdd = " & NumberToField(mbytTieneAnaAdd)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.CajaBanco
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  (tblPlan.TipoPlanId = 2 "
            strSQL &= " OR  tblPlan.TipoPlanId = 3) "

            If mlngPlanId = 0 Then
               strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  tblPlan.PlanId = " & NumberToField(mlngPlanId) & ") "
            End If

         Case WhereFilters.PlanCta
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = " & NumberToField(mlngTipoPlanId)
            strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)

         Case WhereFilters.EstadoId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)

            If mlngPlanId = 0 Then
               strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  tblPlan.PlanId = " & NumberToField(mlngPlanId) & ") "
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PlanId
            strSQL = " ORDER BY tblPlan.PlanId "

         Case OrderByFilters.PlanDes
            strSQL = " ORDER BY tblPlan.PlanDes "

         Case OrderByFilters.PlanCta
            strSQL = " ORDER BY tblPlan.PlanCta "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPlan.PlanDes "

         Case OrderByFilters.Orden
            strSQL = " ORDER BY tblPlan.Orden "

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

   Private Function RowMaxSQL() As String
      Dim strSQL As String

      Select Case mintRowMaxFilter
         Case RowMaxFilters.Orden
            strSQL = "SELECT Max(Orden) FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO tblPlan ("
            strSQL &= "PlanId, "
            strSQL &= "EmpresaId, "
            strSQL &= "PlanDes, "
            strSQL &= "PlanCta, "
            strSQL &= "EsAna, "
            strSQL &= "PlanPadreId, "
            strSQL &= "Orden, "
            strSQL &= "Nivel, "
            strSQL &= "TipoPlanId, "
            strSQL &= "TipoGrupoId, "
            strSQL &= "MonedaId, "
            strSQL &= "TieneAnaAdd, "
            strSQL &= "SucCCOId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrPlanDes) & ", "
            strSQL &= StringToField(mstrPlanCta) & ", "
            strSQL &= NumberToField(mbytEsAna) & ", "
            strSQL &= NumberToField(mlngPlanPadreId) & ", "
            strSQL &= NumberToField(mlngOrden) & ", "
            strSQL &= NumberToField(mlngNivel) & ", "
            strSQL &= NumberToField(mlngTipoPlanId) & ", "
            strSQL &= NumberToField(mlngTipoGrupoId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= NumberToField(mbytTieneAnaAdd) & ", "
            strSQL &= NumberToField(mlngSucCCOId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblPlan SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "PlanDes = " & StringToField(mstrPlanDes) & ", "
            strSQL &= "PlanCta = " & StringToField(mstrPlanCta) & ", "
            strSQL &= "EsAna = " & NumberToField(mbytEsAna) & ", "
            strSQL &= "PlanPadreId = " & NumberToField(mlngPlanPadreId) & ", "
            strSQL &= "Orden = " & NumberToField(mlngOrden) & ", "
            strSQL &= "Nivel = " & NumberToField(mlngNivel) & ", "
            strSQL &= "TipoPlanId = " & NumberToField(mlngTipoPlanId) & ", "
            strSQL &= "TipoGrupoId = " & NumberToField(mlngTipoGrupoId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TieneAnaAdd = " & NumberToField(mbytTieneAnaAdd) & ", "
            strSQL &= "SucCCOId = " & NumberToField(mlngSucCCOId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PlanId = " & NumberToField(mlngPlanId) & " "

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
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrPlanDes = ToStr(oDataRow("PlanDes"))
               mstrPlanCta = ToStr(oDataRow("PlanCta"))
               mbytEsAna = ToByte(oDataRow("EsAna"))
               mlngPlanPadreId = ToLong(oDataRow("PlanPadreId"))
               mlngOrden = ToLong(oDataRow("Orden"))
               mlngNivel = ToLong(oDataRow("Nivel"))
               mlngTipoPlanId = ToLong(oDataRow("TipoPlanId"))
               mlngTipoGrupoId = ToLong(oDataRow("TipoGrupoId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mbytTieneAnaAdd = ToByte(oDataRow("TieneAnaAdd"))
               mlngSucCCOId = ToLong(oDataRow("SucCCOId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mstrPlanDes = ToStr(oDataRow("PlanDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPlanId = TableIDGet(mstrTableName, "PlanId", moConnection)

         If mlngPlanId = -1 Then
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

      If mstrPlanDes.Length() = 0 Then
         strMsg &= "Descripción de Cuenta Inválida" & vbCrLf
      End If

      If mstrPlanCta.Length() = 0 Then
         strMsg &= "Código de Cuenta Inválido" & vbCrLf
      End If

      'If mlngPlanPadreId = 0 Then
      '   strMsg &= "Cuenta Padre Inválida" & vbCrLf
      'End If

      If mlngTipoGrupoId = 0 Then
         strMsg &= "Grupo de Cuenta Inválido" & vbCrLf
      End If

      If mlngOrden = 0 Then
         strMsg &= "Orden Inválido" & vbCrLf
      End If

      If mlngNivel = 0 Then
         strMsg &= "Nivel Inválido" & vbCrLf
      End If

      If mbytEsAna Then
         If mlngMonedaId = 0 Then
            strMsg &= "Moneda Inválida" & vbCrLf
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
         strSQL &= " FROM tblPlan "

         If Not boolReplace Then
            strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
            strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
         Else
            strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
            strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblPlan.PlanId <> " & NumberToField(mlngPlanId)
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
               Throw New Exception("Registro Duplicado, Ya Existe una Cuenta con ese Código y o Descripción")
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
               Throw New Exception("Registro Duplicado, Ya Existe una Cuenta con ese Código y o Descripción")
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

   Public Function RowMax() As Integer
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowMaxSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = ToInteger(oCommand.ExecuteScalar)

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
