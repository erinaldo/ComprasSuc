Imports System.Data
Imports System.Data.OleDb

Public Class clsDevCompra
   Implements IDisposable

   Private mlngDevCompraId As Long
   Private mlngEmpresaId As Long
   Private mlngDevCompraNro As Long
   Private mstrFecha As String
   Private mlngAlmacenId As Long
   Private mlngProveedorId As Long
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mstrDevCompraDes As String
   Private mstrDevCompraObs As String
   Private mlngTipoPagoId As Long
   Private mdecMontoOrg As Decimal
   Private mdecMontoCos As Decimal
   Private mdecMontoNet As Decimal
   Private mlngGestionId As Long
   Private mlngPlanId As Long
   Private mlngCompraId As Long
   Private mlngCreditoId As Long
   Private mbytSinFac As Byte
   Private mbytConFac As Byte
   Private mlngAnticipoId As Long
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mlngNotaId As Long
   Private mlngCompId As Long
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
   Property DevCompraId() As Long
      Get
         Return mlngDevCompraId
      End Get

      Set(ByVal Value As Long)
         mlngDevCompraId = Value
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

   Property DevCompraNro() As Long
      Get
         Return mlngDevCompraNro
      End Get

      Set(ByVal Value As Long)
         mlngDevCompraNro = Value
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

   Property DevCompraDes() As String
      Get
         Return mstrDevCompraDes
      End Get

      Set(ByVal Value As String)
         mstrDevCompraDes = Value
      End Set
   End Property

   Property DevCompraObs() As String
      Get
         Return mstrDevCompraObs
      End Get

      Set(ByVal Value As String)
         mstrDevCompraObs = Value
      End Set
   End Property

   Property TipoPagoId() As Long
      Get
         Return mlngTipoPagoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoPagoId = Value
      End Set
   End Property

   Property MontoOrg() As Decimal
      Get
         Return mdecMontoOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoOrg = Value
      End Set
   End Property

   Property MontoCos() As Decimal
      Get
         Return mdecMontoCos
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoCos = Value
      End Set
   End Property

   Property MontoNet() As Decimal
      Get
         Return mdecMontoNet
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoNet = Value
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

   Property CompraId() As Long
      Get
         Return mlngCompraId
      End Get

      Set(ByVal Value As Long)
         mlngCompraId = Value
      End Set
   End Property

   Property CreditoId() As Long
      Get
         Return mlngCreditoId
      End Get

      Set(ByVal Value As Long)
         mlngCreditoId = Value
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

   Property NotaId() As Long
      Get
         Return mlngNotaId
      End Get

      Set(ByVal Value As Long)
         mlngNotaId = Value
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

   Property EstadoId() As Long
      Get
         Return mlngEstadoId
      End Get

      Set(ByVal Value As Long)
         mlngEstadoId = Value
      End Set
   End Property

   Property AnticipoId() As Long
      Get
         Return mlngAnticipoId
      End Get

      Set(ByVal Value As Long)
         mlngAnticipoId = Value
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
      FlujoCaja = 4
      GRID_IMPORT = 5
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
      EmpresaId = 5
      AlmacenId = 6
      GestionId = 7
      ProveedorId = 8
      FlujoCaja = 9
      FlujoCajaFecha = 10
      GRID_IMPORT = 11
      DEVCOMPRANRO = 12
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      DevCompraId = 1
      Grid = 3
      Report = 4
      GRID_FECHA = 5
      ProveedorId = 6
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      CREDITOID = 1
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
      mstrTableName = "comDevCompra"
      mstrClassName = "clsDevCompra"

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
      mlngDevCompraId = 0
      mlngEmpresaId = 0
      mlngDevCompraNro = 0
      mstrFecha = ""
      mlngAlmacenId = 0
      mlngProveedorId = 0
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mstrDevCompraDes = ""
      mstrDevCompraObs = ""
      mlngTipoPagoId = 0
      mdecMontoOrg = 0
      mdecMontoCos = 0
      mdecMontoNet = 0
      mlngGestionId = 0
      mlngPlanId = 0
      mlngCompraId = 0
      mlngCreditoId = 0
      mbytConFac = 0
      mbytSinFac = 0
      mlngCentroCostoId = 0
      mlngSucursalId = 0
      mlngNotaId = 0
      mlngCompId = 0
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
            strSQL &= "    comDevCompra.DevCompraId,  "
            strSQL &= "    comDevCompra.EmpresaId,  "
            strSQL &= "    comDevCompra.DevCompraNro,  "
            strSQL &= "    comDevCompra.Fecha,  "
            strSQL &= "    comDevCompra.AlmacenId,  "
            strSQL &= "    comDevCompra.ProveedorId,  "
            strSQL &= "    comDevCompra.MonedaId,  "
            strSQL &= "    comDevCompra.TipoCambio,  "
            strSQL &= "    comDevCompra.DevCompraDes,  "
            strSQL &= "    comDevCompra.DevCompraObs,  "
            strSQL &= "    comDevCompra.TipoPagoId,  "
            strSQL &= "    comDevCompra.MontoOrg,  "
            strSQL &= "    comDevCompra.MontoCos,  "
            strSQL &= "    comDevCompra.MontoNet,  "
            strSQL &= "    comDevCompra.GestionId,  "
            strSQL &= "    comDevCompra.PlanId,  "
            strSQL &= "    comDevCompra.CompraId,  "
            strSQL &= "    comDevCompra.CreditoId,  "
            strSQL &= "    comDevCompra.SinFac,  "
            strSQL &= "    comDevCompra.ConFac,  "
            strSQL &= "    comDevCompra.CentroCostoId,  "
            strSQL &= "    comDevCompra.SucursalId,  "
            strSQL &= "    comDevCompra.NotaId,  "
            strSQL &= "    comDevCompra.CompId,  "
            strSQL &= "    comDevCompra.AppId,  "
            strSQL &= "    comDevCompra.TipoDocumentoId,  "
            strSQL &= "    comDevCompra.DocumentoId,  "
            strSQL &= "    comDevCompra.EstadoId,  "
            strSQL &= "    comDevCompra.AnticipoId,  "
            strSQL &= "    comDevCompra.sLastUpdate_id,  "
            strSQL &= "    comDevCompra.dtLastUpdate_dt,  "
            strSQL &= "    comDevCompra.iConcurrency_id  "
            strSQL &= " FROM comDevCompra "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comDevCompra.DevCompraId,  "
            strSQL &= "    comDevCompra.DevCompraDes  "
            strSQL &= " FROM comDevCompra "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            If mintRowsMax > 0 Then strSQL &= " TOP " & NumberToField(mintRowsMax) & "  "
            strSQL &= "    comDevCompra.DevCompraId,  "
            strSQL &= "    comDevCompra.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comDevCompra.DevCompraNro,  "
            strSQL &= "    comDevCompra.Fecha,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comDevCompra.DevCompraDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comDevCompra.TipoCambio,  "
            strSQL &= "    comDevCompra.MontoOrg,  "
            strSQL &= "    comDevCompra.MontoCos,  "
            strSQL &= "    comDevCompra.MontoNet,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    comDevCompra.SinFac,  "
            strSQL &= "    comDevCompra.ConFac,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    secApp.AppId,  "
            strSQL &= "    secApp.AppDes,  "
            strSQL &= "    comDevCompra.TipoDocumentoId,  "
            strSQL &= "    comDevCompra.DocumentoId,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comDevCompra, invAlmacen, comProveedor, comTipoPago, tblMoneda, comCompra, comCredito, invNota, invTipoNota, tblComp, tblTipoComp, tblEstado, tblCentroCosto  "
            strSQL &= "      , tblSucursal, secApp  "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    comDevCompra.DevCompraId,  "
            strSQL &= "    comDevCompra.EmpresaId,  "
            strSQL &= "    comDevCompra.DevCompraNro,  "
            strSQL &= "    comDevCompra.Fecha,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comDevCompra.DevCompraDes,  "
            strSQL &= "    comDevCompra.DevCompraObs,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comDevCompra.TipoCambio,  "
            strSQL &= "    comDevCompra.MontoOrg,  "
            strSQL &= "    comDevCompra.MontoCos,  "
            strSQL &= "    comDevCompra.MontoNet,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    comDevCompra.SucursalId,  "

            strSQL &= "    comDevCompraDet.DevCompraDetId,  "
            strSQL &= "    invItem.ItemId,  "
            strSQL &= "    invItem.ItemCod,  "
            strSQL &= "    invItem.ItemDes,  "
            strSQL &= "    invItem.ControlLote,  "
            strSQL &= "    invItem.ControlSerie,  "
            strSQL &= "    invMedida.MedidaId,  "
            strSQL &= "    invMedida.MedidaDes,  "
            strSQL &= "    comDevCompraDet.CantidadOrg,  "
            strSQL &= "    comDevCompraDet.CantidadDev,  "
            strSQL &= "    comDevCompraDet.PrecioOrg,  "
            strSQL &= "    comDevCompraDet.PrecioNet,  "
            strSQL &= "    comDevCompraDet.PrecioCos,  "
            'strSQL &= "    comDevCompraDet.Importe  "
            strSQL &= "    (comDevCompraDet.CantidadDev * comDevCompraDet.PrecioOrg) As  Importe  "
            strSQL &= " FROM comDevCompra, invAlmacen, comProveedor, tblMoneda, comCompra, invNota, invTipoNota, tblComp, tblTipoComp, tblEstado, comDevCompraDet, invItem, invMedida "


         Case SelectFilters.FlujoCaja
            strSQL = " SELECT  "
            strSQL &= "    comDevCompra.ProveedorId,  "
            strSQL &= "    comDevCompra.MonedaId,  "
            strSQL &= "    comDevCompra.TipoPagoId,  "
            strSQL &= "    comDevCompra.TipoCambio,  "
            strSQL &= "    comDevCompra.MontoOrg,  "
            strSQL &= "    comDevCompra.MontoCos,  "
            strSQL &= "    comDevCompra.MontoNet  "
            strSQL &= " FROM comDevCompra  "

         Case SelectFilters.GRID_IMPORT
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    comDevCompra.DevCompraId,  "
            strSQL &= "    comDevCompra.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    comDevCompra.DevCompraNro,  "
            strSQL &= "    comDevCompra.Fecha,  "
            strSQL &= "    invAlmacen.AlmacenId,  "
            strSQL &= "    invAlmacen.AlmacenCod,  "
            strSQL &= "    invAlmacen.AlmacenDes,  "
            strSQL &= "    comProveedor.ProveedorId,  "
            strSQL &= "    comProveedor.ProveedorCod,  "
            strSQL &= "    comProveedor.ProveedorDes,  "
            strSQL &= "    comDevCompra.DevCompraDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    comDevCompra.TipoCambio,  "
            strSQL &= "    comDevCompra.MontoOrg,  "
            strSQL &= "    comDevCompra.MontoCos,  "
            strSQL &= "    comDevCompra.MontoNet,  "
            strSQL &= "    comCompra.CompraId,  "
            strSQL &= "    comCompra.CompraNro,  "
            strSQL &= "    comCredito.CreditoId,  "
            strSQL &= "    comCredito.CreditoNro,  "
            strSQL &= "    invTipoNota.TipoNotaId,  "
            strSQL &= "    invTipoNota.TipoNotaDes,  "
            strSQL &= "    invNota.NotaId,  "
            strSQL &= "    invNota.NotaNro,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.TipoPlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    comDevCompra.SinFac,  "
            strSQL &= "    comDevCompra.ConFac,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes,  "
            strSQL &= "    CONVERT(bit, 0) As RowImport  "
            strSQL &= " FROM comDevCompra, invAlmacen, comProveedor, comTipoPago, tblMoneda, comCompra, comCredito, invNota, invTipoNota, tblComp, tblTipoComp, tblEstado, tblPlan "
            strSQL &= "      , tblSucursal  "

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
            strSQL = " WHERE  comDevCompra.DevCompraId = " & NumberToField(mlngDevCompraId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comDevCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comDevCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comDevCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comDevCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comDevCompra.CompraId = comCompra.CompraId "
            strSQL &= " AND  comDevCompra.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comDevCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comDevCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comDevCompra.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  comDevCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comDevCompra.AppId = secApp.AppId "
            strSQL &= " AND  comDevCompra.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GRID_IMPORT
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comDevCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comDevCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comDevCompra.TipoPagoId = comTipoPago.TipoPagoId "
            strSQL &= " AND  comDevCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comDevCompra.CompraId = comCompra.CompraId "
            strSQL &= " AND  comDevCompra.CreditoId = comCredito.CreditoId "
            strSQL &= " AND  comDevCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comDevCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comDevCompra.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  comDevCompra.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  comCompra.PlanId = tblPlan.PlanId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Report
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompra.DevCompraId = " & NumberToField(mlngDevCompraId)
            strSQL &= " AND  comDevCompra.AlmacenId = invAlmacen.AlmacenId "
            strSQL &= " AND  comDevCompra.ProveedorId = comProveedor.ProveedorId "
            strSQL &= " AND  comDevCompra.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  comDevCompra.CompraId = comCompra.CompraId "
            strSQL &= " AND  comDevCompra.NotaId = invNota.NotaId "
            strSQL &= " AND  invNota.TipoNotaId = invTipoNota.TipoNotaId "
            strSQL &= " AND  comDevCompra.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  comDevCompra.EstadoId = tblEstado.EstadoId "

            strSQL &= " AND  comDevCompra.DevCompraId = comDevCompraDet.DevCompraId "
            strSQL &= " AND  comDevCompraDet.ItemId = invItem.ItemId "
            strSQL &= " AND  comDevCompraDet.MedidaId = invMedida.MedidaId "

         Case WhereFilters.AlmacenId
            'strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  (comDevCompra.AlmacenId = " & NumberToField(mlngAlmacenId)
            'strSQL &= " OR  comDevCompra.ProveedorId = " & NumberToField(mlngProveedorId) & ") "

         Case WhereFilters.GestionId
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompra.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.ProveedorId
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompra.ProveedorId = " & NumberToField(mlngProveedorId)

         Case WhereFilters.FlujoCaja
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompra.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comDevCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoPagoId <> 0 Then
               strSQL &= " AND  comDevCompra.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comDevCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comDevCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comDevCompra.EstadoId <> 12 "
            strSQL &= " AND  comDevCompra.EstadoId <> 0 "

         Case WhereFilters.FlujoCajaFecha
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompra.GestionId = " & NumberToField(mlngGestionId)

            If mlngProveedorId <> 0 Then
               strSQL &= " AND  comDevCompra.ProveedorId = " & NumberToField(mlngProveedorId)
            End If

            If mlngTipoPagoId <> 0 Then
               strSQL &= " AND  comDevCompra.TipoPagoId = " & NumberToField(mlngTipoPagoId)
            End If

            If mlngCentroCostoId <> 0 Then
               strSQL &= " AND  comDevCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  comDevCompra.SucursalId = " & NumberToField(mlngSucursalId)
            End If

            strSQL &= " AND  comDevCompra.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  comDevCompra.Fecha <= " & DateToField(mstrLastUpdateDate)
            strSQL &= " AND  comDevCompra.EstadoId <> 12 "
            strSQL &= " AND  comDevCompra.EstadoId <> 0 "

         Case WhereFilters.DEVCOMPRANRO
            strSQL = " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comDevCompra.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comDevCompra.DevCompraNro = " & NumberToField(mlngDevCompraNro)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.DevCompraId
            strSQL = " ORDER BY comDevCompra.DevCompraId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY comDevCompra.DevCompraId DESC"

         Case OrderByFilters.Report

         Case OrderByFilters.GRID_FECHA
            strSQL = " ORDER BY comDevCompra.Fecha, comDevCompra.DevCompraId "

         Case OrderByFilters.ProveedorId
            strSQL = " ORDER BY comDevCompra.ProveedorId "

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
            strSQL = "INSERT INTO comDevCompra ("
            strSQL &= "DevCompraId, "
            strSQL &= "EmpresaId, "
            strSQL &= "DevCompraNro, "
            strSQL &= "Fecha, "
            strSQL &= "AlmacenId, "
            strSQL &= "ProveedorId, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "DevCompraDes, "
            strSQL &= "DevCompraObs, "
            strSQL &= "TipoPagoId, "
            strSQL &= "MontoOrg, "
            strSQL &= "MontoCos, "
            strSQL &= "MontoNet, "
            strSQL &= "GestionId, "
            strSQL &= "PlanId, "
            strSQL &= "CompraId, "
            strSQL &= "CreditoId, "
            strSQL &= "SinFac, "
            strSQL &= "ConFac, "
            strSQL &= "CentroCostoId, "
            strSQL &= "SucursalId, "
            strSQL &= "NotaId, "
            strSQL &= "CompId, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= "EstadoId, "
            strSQL &= "AnticipoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngDevCompraId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngDevCompraNro) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngAlmacenId) & ", "
            strSQL &= NumberToField(mlngProveedorId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= StringToField(mstrDevCompraDes) & ", "
            strSQL &= StringToField(mstrDevCompraObs) & ", "
            strSQL &= NumberToField(mlngTipoPagoId) & ", "
            strSQL &= DecimalToField(mdecMontoOrg) & ", "
            strSQL &= DecimalToField(mdecMontoCos) & ", "
            strSQL &= DecimalToField(mdecMontoNet) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngCompraId) & ", "
            strSQL &= NumberToField(mlngCreditoId) & ", "
            strSQL &= NumberToField(mbytSinFac) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngNotaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= NumberToField(mlngDocumentoId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= NumberToField(mlngAnticipoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comDevCompra SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "DevCompraNro = " & NumberToField(mlngDevCompraNro) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "AlmacenId = " & NumberToField(mlngAlmacenId) & ", "
            strSQL &= "ProveedorId = " & NumberToField(mlngProveedorId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "DevCompraDes = " & StringToField(mstrDevCompraDes) & ", "
            strSQL &= "DevCompraObs = " & StringToField(mstrDevCompraObs) & ", "
            strSQL &= "TipoPagoId = " & NumberToField(mlngTipoPagoId) & ", "
            strSQL &= "MontoOrg = " & DecimalToField(mdecMontoOrg) & ", "
            strSQL &= "MontoCos = " & DecimalToField(mdecMontoCos) & ", "
            strSQL &= "MontoNet = " & DecimalToField(mdecMontoNet) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "CompraId = " & NumberToField(mlngCompraId) & ", "
            strSQL &= "CreditoId = " & NumberToField(mlngCreditoId) & ", "
            strSQL &= "SinFac = " & NumberToField(mbytSinFac) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "NotaId = " & NumberToField(mlngNotaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "AnticipoId = " & NumberToField(mlngAnticipoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " DevCompraId = " & NumberToField(mlngDevCompraId) & " "

         Case UpdateFilters.CREDITOID
            strSQL = "UPDATE comDevCompra SET "
            strSQL &= "CreditoId = " & NumberToField(mlngCreditoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraId = " & NumberToField(mlngCompraId) & " "

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
               mlngDevCompraId = ToLong(oDataRow("DevCompraId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngDevCompraNro = ToLong(oDataRow("DevCompraNro"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngAlmacenId = ToLong(oDataRow("AlmacenId"))
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mstrDevCompraDes = ToStr(oDataRow("DevCompraDes"))
               mstrDevCompraObs = ToStr(oDataRow("DevCompraObs"))
               mlngTipoPagoId = ToLong(oDataRow("TipoPagoId"))
               mdecMontoOrg = ToDecimal(oDataRow("MontoOrg"))
               mdecMontoCos = ToDecimal(oDataRow("MontoCos"))
               mdecMontoNet = ToDecimal(oDataRow("MontoNet"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngCompraId = ToLong(oDataRow("CompraId"))
               mlngCreditoId = ToLong(oDataRow("CreditoId"))
               mbytSinFac = ToBoolean(oDataRow("SinFac"))
               mbytConFac = ToBoolean(oDataRow("ConFac"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngNotaId = ToLong(oDataRow("NotaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mlngAnticipoId = ToLong(oDataRow("AnticipoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngDevCompraId = ToLong(oDataRow("DevCompraId"))
               mstrDevCompraDes = ToStr(oDataRow("DevCompraDes"))

            Case SelectFilters.FlujoCaja
               mlngProveedorId = ToLong(oDataRow("ProveedorId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mlngTipoPagoId = ToLong(oDataRow("TipoPagoId"))
               mdecMontoOrg = ToDecimal(oDataRow("MontoOrg"))
               mdecMontoCos = ToDecimal(oDataRow("MontoCos"))
               mdecMontoNet = ToDecimal(oDataRow("MontoNet"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngDevCompraId = TableIDGet(mstrTableName, "DevCompraId", moConnection)

         If mlngDevCompraId = -1 Then
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

      If mlngSucursalId <= 0 Then
         strMsg &= "Sucursal Inválida" & vbCrLf
      End If

      If (mstrFecha.Trim() <> String.Empty) And (mstrFecha.Trim() <> "01/01/1990") Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
      End If

      If mlngTipoPagoId = 0 Then
         strMsg &= "Tipo de Pago Inválido" & vbCrLf
      End If

      If mlngAlmacenId = 0 Then
         strMsg &= "Almacen Inválido" & vbCrLf
      End If

      If mlngProveedorId = 0 Then
         strMsg &= "Proveedor Inválido" & vbCrLf
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
         'strSQL &= " FROM comDevCompra "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comDevCompra.TipoDevCompraId = " & NumberToField(mlngTipoDevCompraId)
         'Else
         '   strSQL &= " WHERE  comDevCompra.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comDevCompra.TipoDevCompraId = " & NumberToField(mlngTipoDevCompraId)
         '   strSQL &= " AND  comDevCompra.DevCompraId <> " & NumberToField(mlngDevCompraId)
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

   Public Function UpdateOnly() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      UpdateOnly = False

      Try
         If NoDuplicates(True) Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = UpdateSQL()
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteNonQuery()

            If intRecordsAffected > 0 Then
               UpdateOnly = True
            End If
         Else
            Throw New Exception("Registro Duplicado")
            Return False
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
