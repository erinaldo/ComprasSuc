Imports System.Data
Imports System.Data.OleDb

Public Class clsProveedor
   Implements IDisposable

   Private mlngProveedorId As Long
   Private mlngEmpresaId As Long
   Private mstrProveedorDes As String
   Private mstrProveedorCod As String
   Private mstrProveedorNIT As String
   Private mstrDireccion As String
   Private mlngCiudadId As Long
   Private mstrTelefono1 As String
   Private mstrTelefono2 As String
   Private mstrMovil As String
   Private mstrFax As String
   Private mstrEmail As String
   Private mstrWeb As String
   Private mlngMonedaId As Long
   Private mstrContactoDes As String
   Private mstrContactoCI As String
   Private mstrContactoCargo As String
   Private mlngPlanIdPas As Long
   Private mlngPlanAddIdPas As Long
   Private mlngPlanIdAct As Long
   Private mlngPlanAddIdAct As Long
   Private mlngPlanIdInt As Long
   Private mlngPlanAddIdInt As Long
   Private mdecCreditoLimite As Decimal
   Private mdecInteresAnual As Decimal
   Private mbytCreditoAuto As Byte
   Private mlngCreditoDias As Long
   Private mlngProcedenciaId As Long
   Private mlngRubroId As Long
   Private mlngBancoId As Long
   Private mstrNroCuenta As String
   Private mlngMonedaIdCuenta As Long
   Private mlngTipoDocIdentidadId As Long
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
   Property ProveedorId() As Long
      Get
         Return mlngProveedorId
      End Get

      Set(ByVal Value As Long)
         mlngProveedorId = Value
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

   Property ProveedorDes() As String
      Get
         Return mstrProveedorDes
      End Get

      Set(ByVal Value As String)
         mstrProveedorDes = Value
      End Set
   End Property

   Property ProveedorCod() As String
      Get
         Return mstrProveedorCod
      End Get

      Set(ByVal Value As String)
         mstrProveedorCod = Value
      End Set
   End Property

   Property ProveedorNIT() As String
      Get
         Return mstrProveedorNIT
      End Get

      Set(ByVal Value As String)
         mstrProveedorNIT = Value
      End Set
   End Property

   Property Direccion() As String
      Get
         Return mstrDireccion
      End Get

      Set(ByVal Value As String)
         mstrDireccion = Value
      End Set
   End Property

   Property CiudadId() As Long
      Get
         Return mlngCiudadId
      End Get

      Set(ByVal Value As Long)
         mlngCiudadId = Value
      End Set
   End Property

   Property Telefono1() As String
      Get
         Return mstrTelefono1
      End Get

      Set(ByVal Value As String)
         mstrTelefono1 = Value
      End Set
   End Property

   Property Telefono2() As String
      Get
         Return mstrTelefono2
      End Get

      Set(ByVal Value As String)
         mstrTelefono2 = Value
      End Set
   End Property

   Property Movil() As String
      Get
         Return mstrMovil
      End Get

      Set(ByVal Value As String)
         mstrMovil = Value
      End Set
   End Property

   Property Fax() As String
      Get
         Return mstrFax
      End Get

      Set(ByVal Value As String)
         mstrFax = Value
      End Set
   End Property

   Property Email() As String
      Get
         Return mstrEmail
      End Get

      Set(ByVal Value As String)
         mstrEmail = Value
      End Set
   End Property

   Property Web() As String
      Get
         Return mstrWeb
      End Get

      Set(ByVal Value As String)
         mstrWeb = Value
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

   Property ContactoDes() As String
      Get
         Return mstrContactoDes
      End Get

      Set(ByVal Value As String)
         mstrContactoDes = Value
      End Set
   End Property

   Property ContactoCI() As String
      Get
         Return mstrContactoCI
      End Get

      Set(ByVal Value As String)
         mstrContactoCI = Value
      End Set
   End Property

   Property ContactoCargo() As String
      Get
         Return mstrContactoCargo
      End Get

      Set(ByVal Value As String)
         mstrContactoCargo = Value
      End Set
   End Property

   Property PlanIdPas() As Long
      Get
         Return mlngPlanIdPas
      End Get

      Set(ByVal Value As Long)
         mlngPlanIdPas = Value
      End Set
   End Property

   Property PlanAddIdPas() As Long
      Get
         Return mlngPlanAddIdPas
      End Get

      Set(ByVal Value As Long)
         mlngPlanAddIdPas = Value
      End Set
   End Property

   Property PlanIdAct() As Long
      Get
         Return mlngPlanIdAct
      End Get

      Set(ByVal Value As Long)
         mlngPlanIdAct = Value
      End Set
   End Property

   Property PlanAddIdAct() As Long
      Get
         Return mlngPlanAddIdAct
      End Get

      Set(ByVal Value As Long)
         mlngPlanAddIdAct = Value
      End Set
   End Property

   Property PlanIdInt() As Long
      Get
         Return mlngPlanIdInt
      End Get

      Set(ByVal Value As Long)
         mlngPlanIdInt = Value
      End Set
   End Property

   Property PlanAddIdInt() As Long
      Get
         Return mlngPlanAddIdInt
      End Get

      Set(ByVal Value As Long)
         mlngPlanAddIdInt = Value
      End Set
   End Property

   Property CreditoLimite() As Decimal
      Get
         Return mdecCreditoLimite
      End Get

      Set(ByVal Value As Decimal)
         mdecCreditoLimite = Value
      End Set
   End Property

   Property InteresAnual() As Decimal
      Get
         Return mdecInteresAnual
      End Get

      Set(ByVal Value As Decimal)
         mdecInteresAnual = Value
      End Set
   End Property

   Property CreditoAuto() As Byte
      Get
         Return mbytCreditoAuto
      End Get

      Set(ByVal Value As Byte)
         mbytCreditoAuto = Value
      End Set
   End Property

   Property CreditoDias() As Long
      Get
         Return mlngCreditoDias
      End Get

      Set(ByVal Value As Long)
         mlngCreditoDias = Value
      End Set
   End Property

   Property ProcedenciaId() As Long
      Get
         Return mlngProcedenciaId
      End Get

      Set(ByVal Value As Long)
         mlngProcedenciaId = Value
      End Set
   End Property

   Property RubroId() As Long
      Get
         Return mlngRubroId
      End Get

      Set(ByVal Value As Long)
         mlngRubroId = Value
      End Set
   End Property

   Property BancoId() As Long
      Get
         Return mlngBancoId
      End Get

      Set(ByVal Value As Long)
         mlngBancoId = Value
      End Set
   End Property

   Property NroCuenta() As String
      Get
         Return mstrNroCuenta
      End Get

      Set(ByVal Value As String)
         mstrNroCuenta = Value
      End Set
   End Property

   Property MonedaIdCuenta() As Long
      Get
         Return mlngMonedaIdCuenta
      End Get

      Set(ByVal Value As Long)
         mlngMonedaIdCuenta = Value
      End Set
   End Property

   Property TipoDocIdentidadId() As Long
      Get
         Return mlngTipoDocIdentidadId
      End Get

      Set(ByVal Value As Long)
         mlngTipoDocIdentidadId = Value
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
      GridPagoContado = 4
      GridPagoCredito = 5
      GridCheck = 6
      ProveedorDistinct = 7
      GridFactura = 8
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      ProveedorDes = 2
      LIKEProveedorDes = 3
      Grid = 4
      Report = 5
      EmpresaId = 6
      GridPagoContado = 7
      GridPagoCredito = 8
      GridCheck = 9
      EstadoId = 10
      ProveedorCod = 11
      GridFactura = 12
      GridFacturaMultiple = 13
      ProveedorIdTieneMov = 14
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ProveedorId = 1
      ProveedorDes = 2
      Grid = 3
      Report = 4
      GridCheck = 5
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
      mstrTableName = "comProveedor"
      mstrClassName = "clsProveedor"

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
      mlngProveedorId = 0
      mlngEmpresaId = 0
      mstrProveedorDes = ""
      mstrProveedorCod = ""
      mstrProveedorNIT = ""
      mstrDireccion = ""
      mlngCiudadId = 0
      mstrTelefono1 = ""
      mstrTelefono2 = ""
      mstrMovil = ""
      mstrFax = ""
      mstrEmail = ""
      mstrWeb = ""
      mlngMonedaId = 0
      mstrContactoDes = ""
      mstrContactoCI = ""
      mstrContactoCargo = ""
      mlngPlanIdPas = 0
      mlngPlanAddIdPas = 0
      mlngPlanIdAct = 0
      mlngPlanAddIdAct = 0
      mlngPlanIdInt = 0
      mlngPlanAddIdInt = 0
      mdecCreditoLimite = 0
      mdecInteresAnual = 0
      mbytCreditoAuto = 0
      mlngCreditoDias = 0
      mlngProcedenciaId = 0
      mlngRubroId = 0
      mlngBancoId = 0
      mstrNroCuenta = ""
      mlngMonedaIdCuenta = 0
      mlngTipoDocIdentidadId = 0
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
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.EmpresaId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorNIT,  "
            strSQL &= "    comProveedor.Direccion,  "
            strSQL &= "    comProveedor.CiudadId,  "
            strSQL &= "    comProveedor.Telefono1,  "
            strSQL &= "    comProveedor.Telefono2,  "
            strSQL &= "    comProveedor.Movil,  "
            strSQL &= "    comProveedor.Fax,  "
            strSQL &= "    comProveedor.Email,  "
            strSQL &= "    comProveedor.Web,  "
            strSQL &= "    comProveedor.MonedaId,  "
            strSQL &= "    comProveedor.ContactoDes,  "
            strSQL &= "    comProveedor.ContactoCI,  "
            strSQL &= "    comProveedor.ContactoCargo,  "
            strSQL &= "    comProveedor.PlanIdPas,  "
            strSQL &= "    comProveedor.PlanAddIdPas,  "
            strSQL &= "    comProveedor.PlanIdAct,  "
            strSQL &= "    comProveedor.PlanAddIdAct,  "
            strSQL &= "    comProveedor.PlanIdInt,  "
            strSQL &= "    comProveedor.PlanAddIdInt,  "
            strSQL &= "    comProveedor.CreditoLimite,  "
            strSQL &= "    comProveedor.InteresAnual,  "
            strSQL &= "    comProveedor.CreditoAuto,  "
            strSQL &= "    comProveedor.CreditoDias,  "
            strSQL &= "    comProveedor.ProcedenciaId,  "
            strSQL &= "    comProveedor.RubroId,  "
            strSQL &= "    comProveedor.BancoId,  "
            strSQL &= "    comProveedor.NroCuenta,  "
            strSQL &= "    comProveedor.MonedaIdCuenta,  "
            strSQL &= "    comProveedor.TipoDocIdentidadId,  "
            strSQL &= "    comProveedor.EstadoId,  "
            strSQL &= "    comProveedor.sLastUpdate_id,  "
            strSQL &= "    comProveedor.dtLastUpdate_dt,  "
            strSQL &= "    comProveedor.iConcurrency_id  "
            strSQL &= " FROM comProveedor "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.ProveedorCod  "
            strSQL &= " FROM comProveedor "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.EmpresaId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.ProveedorNIT,  "
            strSQL &= "    comProveedor.ContactoDes,  "
            strSQL &= "    comProveedor.ContactoCI,  "
            strSQL &= "    comProveedor.ContactoCargo,  "
            strSQL &= "    comProveedor.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    comProveedor.Telefono1,  "
            strSQL &= "    comProveedor.Telefono2,  "
            strSQL &= "    comProveedor.Movil,  "
            strSQL &= "    comProveedor.Fax,  "
            strSQL &= "    comProveedor.Email,  "
            strSQL &= "    comProveedor.Web,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "

            strSQL &= "    tblPlanPas.PlanId As PlanIdPas,  "
            strSQL &= "    tblPlanPas.PlanDes As PlanDesPas,  "
            strSQL &= "    tblPlanAddPas.PlanAddId As PlanAddIdPas,  "
            strSQL &= "    tblPlanAddPas.PlanAddDes As PlanAddDesPas,  "

            strSQL &= "    tblPlanAct.PlanId As PlanIdAct,  "
            strSQL &= "    tblPlanAct.PlanDes As PlanDesAct,  "
            strSQL &= "    tblPlanAddAct.PlanAddId As PlanAddIdAct,  "
            strSQL &= "    tblPlanAddAct.PlanAddDes As PlanAddDesAct,  "

            strSQL &= "    tblPlanInt.PlanId As PlanIdInt,  "
            strSQL &= "    tblPlanInt.PlanDes As PlanDesInt,  "
            strSQL &= "    tblPlanAddInt.PlanAddId As PlanAddIdInt,  "
            strSQL &= "    tblPlanAddInt.PlanAddDes As PlanAddDesInt,  "

            strSQL &= "    comProveedor.CreditoLimite,  "
            strSQL &= "    comProveedor.CreditoAuto,  "
            strSQL &= "    comProveedor.CreditoDias,  "
            strSQL &= "    comProveedor.InteresAnual,  "

            strSQL &= "    comProcedencia.ProcedenciaId,  "
            strSQL &= "    comProcedencia.ProcedenciaDes,  "
            strSQL &= "    comRubro.RubroId,  "
            strSQL &= "    comRubro.RubroDes,  "
            strSQL &= "    tblBanco.BancoId,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    comProveedor.NroCuenta,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comProveedor, tblCiudad, tblMoneda, tblPlan As tblPlanPas, tblPlanAdd As tblPlanAddPas,  tblPlan As tblPlanAct, "
            strSQL &= "         tblPlanAdd As tblPlanAddAct, tblPlan As tblPlanInt, tblPlanAdd As tblPlanAddInt, tblEstado, comProcedencia, comRubro, tblBanco "

         Case SelectFilters.GridPagoCredito
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.EmpresaId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.ProveedorNIT,  "
            strSQL &= "    comProveedor.ContactoDes,  "
            strSQL &= "    comProveedor.ContactoCI,  "
            strSQL &= "    comProveedor.ContactoCargo,  "
            strSQL &= "    comProveedor.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    comProveedor.Telefono1,  "
            strSQL &= "    comProveedor.Telefono2,  "
            strSQL &= "    comProveedor.Movil,  "
            strSQL &= "    comProveedor.Fax,  "
            strSQL &= "    comProveedor.Email,  "
            strSQL &= "    comProveedor.Web,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comProveedor, tblCiudad, tblMoneda, tblEstado, comCredito "

         Case SelectFilters.GridPagoContado
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.EmpresaId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.ProveedorNIT,  "
            strSQL &= "    comProveedor.ContactoDes,  "
            strSQL &= "    comProveedor.ContactoCI,  "
            strSQL &= "    comProveedor.ContactoCargo,  "
            strSQL &= "    comProveedor.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    comProveedor.Telefono1,  "
            strSQL &= "    comProveedor.Telefono2,  "
            strSQL &= "    comProveedor.Movil,  "
            strSQL &= "    comProveedor.Fax,  "
            strSQL &= "    comProveedor.Email,  "
            strSQL &= "    comProveedor.Web,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comProveedor, tblCiudad, tblMoneda, tblEstado, comCompra "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.EmpresaId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.ProveedorNIT,  "
            strSQL &= "    comProveedor.ContactoDes,  "
            strSQL &= "    comProveedor.ContactoCI,  "
            strSQL &= "    comProveedor.ContactoCargo,  "
            strSQL &= "    comProveedor.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    comProveedor.Telefono1,  "
            strSQL &= "    comProveedor.Telefono2,  "
            strSQL &= "    comProveedor.Movil,  "
            strSQL &= "    comProveedor.Fax,  "
            strSQL &= "    comProveedor.Email,  "
            strSQL &= "    comProveedor.Web,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comProcedencia.ProcedenciaId,  "
            strSQL &= "    comProcedencia.ProcedenciaDes,  "
            strSQL &= "    comRubro.RubroId,  "
            strSQL &= "    comRubro.RubroDes,  "
            strSQL &= "    tblBanco.BancoId,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    comProveedor.NroCuenta,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comProveedor, tblCiudad, tblMoneda, tblEstado, comProcedencia, comRubro, tblBanco "

         Case SelectFilters.GridFactura
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.EmpresaId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comProveedor.ProveedorNIT,  "
            strSQL &= "    comProveedor.ContactoDes,  "
            strSQL &= "    comProveedor.ContactoCI,  "
            strSQL &= "    comProveedor.ContactoCargo,  "
            strSQL &= "    comProveedor.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    comProveedor.Telefono1,  "
            strSQL &= "    comProveedor.Movil,  "
            strSQL &= "    comProveedor.Fax,  "
            strSQL &= "    comProveedor.Email,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comProveedor, tblCiudad, tblMoneda, tblEstado, comCompra "

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
            strSQL = " WHERE  comProveedor.ProveedorId = " & NumberToField(mlngProveedorId)

         Case WhereFilters.ProveedorDes
            strSQL = " WHERE  comProveedor.ProveedorDes = " & StringToField(mstrProveedorDes)

         Case WhereFilters.LIKEProveedorDes
            strSQL = " WHERE  comProveedor.ProveedorDes LIKE " & StringToField(mstrProveedorDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comProveedor.CiudadId = tblCiudad.CiudadId "
            strSQL &= " AND  comProveedor.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comProveedor.PlanIdPas = tblPlanPas.PlanId "
            strSQL &= " AND  comProveedor.PlanAddIdPas = tblPlanAddPas.PlanAddId "
            strSQL &= " AND  comProveedor.PlanIdAct = tblPlanAct.PlanId "
            strSQL &= " AND  comProveedor.PlanAddIdAct = tblPlanAddAct.PlanAddId "
            strSQL &= " AND  comProveedor.PlanIdInt = tblPlanInt.PlanId "
            strSQL &= " AND  comProveedor.PlanAddIdInt = tblPlanAddInt.PlanAddId "
            strSQL &= " AND  comProveedor.ProcedenciaId = comProcedencia.ProcedenciaId "
            strSQL &= " AND  comProveedor.RubroId = comRubro.RubroId "
            strSQL &= " AND  comProveedor.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comProveedor.BancoId = tblBanco.BancoId "

         Case WhereFilters.GridPagoCredito
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comProveedor.CiudadId = tblCiudad.CiudadId "
            strSQL &= " AND  comProveedor.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comProveedor.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comProveedor.ProveedorId = comCredito.ProveedorId "
            strSQL &= " AND  comCredito.GestionId = " & NumberToField(mlngCiudadId)
            strSQL &= " AND  comCredito.EstadoId = 15 "

         Case WhereFilters.GridPagoContado
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comProveedor.CiudadId = tblCiudad.CiudadId "
            strSQL &= " AND  comProveedor.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comProveedor.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comProveedor.ProveedorId = comCompra.ProveedorId "
            strSQL &= " AND  comCompra.GestionId = " & NumberToField(mlngCiudadId)
            strSQL &= " AND  comCompra.TipoPagoId = 1 "
            strSQL &= " AND  comCompra.EstadoId = 13 "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.GridCheck
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comProveedor.CiudadId = tblCiudad.CiudadId "
            strSQL &= " AND  comProveedor.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comProveedor.ProcedenciaId = comProcedencia.ProcedenciaId "
            strSQL &= " AND  comProveedor.RubroId = comRubro.RubroId "
            strSQL &= " AND  comProveedor.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comProveedor.BancoId = tblBanco.BancoId "

         Case WhereFilters.EstadoId
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)

            If mlngProveedorId = 0 Then
               strSQL &= " AND  comProveedor.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (comProveedor.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  comProveedor.ProveedorId = " & NumberToField(mlngProveedorId) & ") "
            End If

         Case WhereFilters.ProveedorCod
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comProveedor.ProveedorCod = " & StringToField(mstrProveedorCod)

         Case WhereFilters.GridFactura
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comProveedor.CiudadId = tblCiudad.CiudadId "
            strSQL &= " AND  comProveedor.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comProveedor.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comProveedor.ProveedorId = comCompra.ProveedorId "
            strSQL &= " AND  comCompra.GestionId <= " & NumberToField(mlngCiudadId) ''Por don Alejandro AMC
            'strSQL &= " AND  venVenta.FacturaId = 0 "
            strSQL &= " AND  comCompra.EstadoId <> 12 "
            strSQL &= " AND  comCompra.EstadoId <> 0 "
            strSQL &= " AND  comCompra.FacturaDif = 1 "
            strSQL &= " AND  comCompra.MontoBru - comCompra.MontoFac > 0 "

            strSQL &= " AND  ( comCompra.MontoFac =  0 "
            strSQL &= " OR  comCompra.CompraId Not IN (SELECT tblCompraFac.CompraId FROM tblCompraFac "
            strSQL &= "                           WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "                            AND  tblCompraFac.MontoCompra > 0 )"
            strSQL &= " ) "

         Case WhereFilters.GridFacturaMultiple
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comProveedor.CiudadId = tblCiudad.CiudadId "
            strSQL &= " AND  comProveedor.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comProveedor.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comProveedor.ProveedorId = comCompra.ProveedorId "
            strSQL &= " AND  comCompra.GestionId <= " & NumberToField(mlngCiudadId) ''Por don Alejandro AMC
            'strSQL &= " AND  venVenta.FacturaId = 0 "
            strSQL &= " AND  comCompra.EstadoId <> 12 "
            strSQL &= " AND  comCompra.EstadoId <> 0 "
            strSQL &= " AND  comCompra.FacturaDif = 1 "
            strSQL &= " AND  comCompra.MontoBru - comCompra.MontoFac > 0 "

            strSQL &= " AND  ( comCompra.MontoFac =  0 "
            strSQL &= " OR  comCompra.CompraId IN (SELECT tblCompraFac.CompraId FROM tblCompraFac "
            strSQL &= "                           WHERE  tblCompraFac.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "                            AND  tblCompraFac.MontoCompra > 0 )"
            strSQL &= " ) "

         Case WhereFilters.ProveedorIdTieneMov
            strSQL = " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comProveedor.ProveedorId = " & NumberToField(mlngProveedorId)
            strSQL &= " AND  ( comProveedor.ProveedorId  IN (SELECT ProveedorId "
            strSQL &= "                                     FROM  comCompra "
            strSQL &= "                                     WHERE comCompra.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR comProveedor.ProveedorId  IN (SELECT ProveedorId "
            strSQL &= "                                     FROM  comPedCompra "
            strSQL &= "                                     WHERE comPedCompra.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR comProveedor.ProveedorId  IN (SELECT ProveedorId "
            strSQL &= "                                     FROM  comDevCompra "
            strSQL &= "                                     WHERE comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            strSQL &= "     OR comProveedor.ProveedorId  IN (SELECT ProveedorId "
            strSQL &= "                                     FROM  comAnticipo "
            strSQL &= "                                     WHERE comAnticipo.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"

            If TableExits(clsAppInfo.ConnectString, "comCredito") Then
               strSQL &= "     OR comProveedor.ProveedorId  IN (SELECT ProveedorId "
               strSQL &= "                                     FROM  comCredito "
               strSQL &= "                                     WHERE comCredito.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
            End If

            strSQL &= " ) "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ProveedorId
            strSQL = " ORDER BY comProveedor.ProveedorId "

         Case OrderByFilters.ProveedorDes
            strSQL = " ORDER BY comProveedor.ProveedorDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comProveedor.ProveedorDes "

         Case OrderByFilters.GridCheck
            strSQL = " ORDER BY comProveedor.ProveedorDes "

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
            strSQL = "INSERT INTO comProveedor ("
            strSQL &= "ProveedorId, "
            strSQL &= "EmpresaId, "
            strSQL &= "ProveedorDes, "
            strSQL &= "ProveedorCod, "
            strSQL &= "ProveedorNIT, "
            strSQL &= "Direccion, "
            strSQL &= "CiudadId, "
            strSQL &= "Telefono1, "
            strSQL &= "Telefono2, "
            strSQL &= "Movil, "
            strSQL &= "Fax, "
            strSQL &= "Email, "
            strSQL &= "Web, "
            strSQL &= "MonedaId, "
            strSQL &= "ContactoDes, "
            strSQL &= "ContactoCI, "
            strSQL &= "ContactoCargo, "
            strSQL &= "PlanIdPas, "
            strSQL &= "PlanAddIdPas, "
            strSQL &= "PlanIdAct, "
            strSQL &= "PlanAddIdAct, "
            strSQL &= "PlanIdInt, "
            strSQL &= "PlanAddIdInt, "
            strSQL &= "CreditoLimite, "
            strSQL &= "InteresAnual, "
            strSQL &= "CreditoAuto, "
            strSQL &= "CreditoDias, "
            strSQL &= "ProcedenciaId, "
            strSQL &= "RubroId, "
            strSQL &= "BancoId, "
            strSQL &= "NroCuenta, "
            strSQL &= "MonedaIdCuenta, "
            strSQL &= "TipoDocIdentidadId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrProveedorDes) & ", "
            strSQL &= StringToField(mstrProveedorCod) & ", "
            strSQL &= StringToField(mstrProveedorNIT) & ", "
            strSQL &= StringToField(mstrDireccion) & ", "
            strSQL &= NumberToField(mlngCiudadId) & ", "
            strSQL &= StringToField(mstrTelefono1) & ", "
            strSQL &= StringToField(mstrTelefono2) & ", "
            strSQL &= StringToField(mstrMovil) & ", "
            strSQL &= StringToField(mstrFax) & ", "
            strSQL &= StringToField(mstrEmail) & ", "
            strSQL &= StringToField(mstrWeb) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= StringToField(mstrContactoDes) & ", "
            strSQL &= StringToField(mstrContactoCI) & ", "
            strSQL &= StringToField(mstrContactoCargo) & ", "
            strSQL &= NumberToField(mlngPlanIdPas) & ", "
            strSQL &= NumberToField(mlngPlanAddIdPas) & ", "
            strSQL &= NumberToField(mlngPlanIdAct) & ", "
            strSQL &= NumberToField(mlngPlanAddIdAct) & ", "
            strSQL &= NumberToField(mlngPlanIdInt) & ", "
            strSQL &= NumberToField(mlngPlanAddIdInt) & ", "
            strSQL &= DecimalToField(mdecCreditoLimite) & ", "
            strSQL &= DecimalToField(mdecInteresAnual) & ", "
            strSQL &= NumberToField(mbytCreditoAuto) & ", "
            strSQL &= NumberToField(mlngCreditoDias) & ", "
            strSQL &= NumberToField(mlngProcedenciaId) & ", "
            strSQL &= NumberToField(mlngRubroId) & ", "
            strSQL &= NumberToField(mlngBancoId) & ", "
            strSQL &= StringToField(mstrNroCuenta) & ", "
            strSQL &= NumberToField(mlngMonedaIdCuenta) & ", "
            strSQL &= NumberToField(mlngTipoDocIdentidadId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comProveedor SET "
            strSQL &= "ProveedorDes = " & StringToField(mstrProveedorDes) & ", "
            strSQL &= "ProveedorCod = " & StringToField(mstrProveedorCod) & ", "
            strSQL &= "ProveedorNIT = " & StringToField(mstrProveedorNIT) & ", "
            strSQL &= "Direccion = " & StringToField(mstrDireccion) & ", "
            strSQL &= "CiudadId = " & NumberToField(mlngCiudadId) & ", "
            strSQL &= "Telefono1 = " & StringToField(mstrTelefono1) & ", "
            strSQL &= "Telefono2 = " & StringToField(mstrTelefono2) & ", "
            strSQL &= "Movil = " & StringToField(mstrMovil) & ", "
            strSQL &= "Fax = " & StringToField(mstrFax) & ", "
            strSQL &= "Email = " & StringToField(mstrEmail) & ", "
            strSQL &= "Web = " & StringToField(mstrWeb) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "ContactoDes = " & StringToField(mstrContactoDes) & ", "
            strSQL &= "ContactoCI = " & StringToField(mstrContactoCI) & ", "
            strSQL &= "ContactoCargo = " & StringToField(mstrContactoCargo) & ", "
            strSQL &= "PlanIdPas = " & NumberToField(mlngPlanIdPas) & ", "
            strSQL &= "PlanAddIdPas = " & NumberToField(mlngPlanAddIdPas) & ", "
            strSQL &= "PlanIdAct = " & NumberToField(mlngPlanIdAct) & ", "
            strSQL &= "PlanAddIdAct = " & NumberToField(mlngPlanAddIdAct) & ", "
            strSQL &= "PlanIdInt = " & NumberToField(mlngPlanIdInt) & ", "
            strSQL &= "PlanAddIdInt = " & NumberToField(mlngPlanAddIdInt) & ", "
            strSQL &= "CreditoLimite = " & DecimalToField(mdecCreditoLimite) & ", "
            strSQL &= "InteresAnual = " & DecimalToField(mdecInteresAnual) & ", "
            strSQL &= "CreditoAuto = " & NumberToField(mbytCreditoAuto) & ", "
            strSQL &= "CreditoDias = " & NumberToField(mlngCreditoDias) & ", "
            strSQL &= "ProcedenciaId = " & NumberToField(mlngProcedenciaId) & ", "
            strSQL &= "RubroId = " & NumberToField(mlngRubroId) & ", "
            strSQL &= "BancoId = " & NumberToField(mlngBancoId) & ", "
            strSQL &= "NroCuenta = " & StringToField(mstrNroCuenta) & ", "
            strSQL &= "MonedaIdCuenta = " & NumberToField(mlngMonedaIdCuenta) & ", "
            strSQL &= "TipoDocIdentidadId = " & NumberToField(mlngTipoDocIdentidadId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ProveedorId = " & NumberToField(mlngProveedorId) & " "

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
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrProveedorDes = ToStr(oDataRow("ProveedorDes"))
               mstrProveedorCod = ToStr(oDataRow("ProveedorCod"))
               mstrProveedorNIT = ToStr(oDataRow("ProveedorNIT"))
               mstrDireccion = ToStr(oDataRow("Direccion"))
               mlngCiudadId = ToLong(oDataRow("CiudadId"))
               mstrTelefono1 = ToStr(oDataRow("Telefono1"))
               mstrTelefono2 = ToStr(oDataRow("Telefono2"))
               mstrMovil = ToStr(oDataRow("Movil"))
               mstrFax = ToStr(oDataRow("Fax"))
               mstrEmail = ToStr(oDataRow("Email"))
               mstrWeb = ToStr(oDataRow("Web"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mstrContactoDes = ToStr(oDataRow("ContactoDes"))
               mstrContactoCI = ToStr(oDataRow("ContactoCI"))
               mstrContactoCargo = ToStr(oDataRow("ContactoCargo"))
               mlngPlanIdPas = ToLong(oDataRow("PlanIdPas"))
               mlngPlanAddIdPas = ToLong(oDataRow("PlanAddIdPas"))
               mlngPlanIdAct = ToLong(oDataRow("PlanIdAct"))
               mlngPlanAddIdAct = ToLong(oDataRow("PlanAddIdAct"))
               mlngPlanIdInt = ToLong(oDataRow("PlanIdInt"))
               mlngPlanAddIdInt = ToLong(oDataRow("PlanAddIdInt"))
               mdecCreditoLimite = ToDecimal(oDataRow("CreditoLimite"))
               mdecInteresAnual = ToDecimal(oDataRow("InteresAnual"))
               mbytCreditoAuto = ToByte(oDataRow("CreditoAuto"))
               mlngCreditoDias = ToLong(oDataRow("CreditoDias"))
               mlngProcedenciaId = ToLong(oDataRow("ProcedenciaId"))
               mlngRubroId = ToLong(oDataRow("RubroId"))
               mlngBancoId = ToLong(oDataRow("BancoId"))
               mstrNroCuenta = ToStr(oDataRow("NroCuenta"))
               mlngMonedaIdCuenta = ToLong(oDataRow("MonedaIdCuenta"))
               mlngTipoDocIdentidadId = ToLong(oDataRow("TipoDocIdentidadId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mstrProveedorDes = ToStr(oDataRow("ProveedorDes"))
               mstrProveedorCod = ToStr(oDataRow("ProveedorCod"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngProveedorId = TableIDGet(mstrTableName, "ProveedorId", moConnection)

         If mlngProveedorId = -1 Then
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

      If mstrProveedorDes.Length() = 0 Then
         strMsg &= "Ingrese el Proveedor" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Seleccione la Moneda" & vbCrLf
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
         ''strSQL = " SELECT  "
         ''strSQL &= " Count(*) As NumRecs  "
         ''strSQL &= " FROM comProveedor "

         ''If Not boolReplace Then
         ''   strSQL &= " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
         ''   strSQL &= "   AND  comProveedor.ProveedorCod = " & StringToField(mstrProveedorCod)
         ''   strSQL &= "    OR  comProveedor.ProveedorNIT = " & StringToField(mstrProveedorNIT)
         ''   strSQL &= "   AND  comProveedor.ProveedorNIT <> ''  "
         ''Else
         ''   strSQL &= " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
         ''   strSQL &= "   AND ( comProveedor.ProveedorCod = " & StringToField(mstrProveedorCod)
         ''   strSQL &= "    OR  comProveedor.ProveedorNIT = " & StringToField(mstrProveedorNIT)
         ''   strSQL &= "   AND  comProveedor.ProveedorNIT <> ''  )"
         ''   strSQL &= "   AND  comProveedor.ProveedorId <> " & NumberToField(mlngProveedorId)
         ''End If

         strSQL = " SELECT  "
         strSQL &= " Count(*) As NumRecs  "
         strSQL &= " FROM comProveedor "

         If Not boolReplace Then
            strSQL &= " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "   AND  comProveedor.ProveedorCod = " & StringToField(mstrProveedorCod)
            strSQL &= "   AND  comProveedor.ProveedorCod <>  '' "
         Else
            strSQL &= " WHERE  comProveedor.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= "   AND  comProveedor.ProveedorCod = " & StringToField(mstrProveedorCod)
            strSQL &= "   AND  comProveedor.ProveedorCod <>  '' "
            strSQL &= "   AND  comProveedor.ProveedorId <> " & NumberToField(mlngProveedorId)
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
