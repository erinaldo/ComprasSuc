Imports System.Data
Imports System.Data.OleDb

Public Class clsFactura
   Implements IDisposable

   Private mlngFacturaId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMesId As Long
   Private mlngSucursalId As Long
   Private mlngDosificaId As Long
   Private mlngTipoCompId As Long
   Private mlngCompId As Long
   Private mlngCompDetId As Long
   Private mlngTipoFacturaId As Long
   Private mstrFacturaFecha As String
   Private mlngFacturaNro As Long
   Private mdecFacturaMonto As Decimal
   Private mlngRegRUCId As Long
   Private mstrNroRUC As String
   Private mstrRegRUCDes As String
   Private mstrNroAutorizacion As String
   Private mstrCodControl As String
   Private mdecIVA As Decimal
   Private mdecIceIehd As Decimal
   Private mdecExento As Decimal
   Private mdecDescuento As Decimal
   Private mstrFacturaObs As String
   Private mbytBancarizar As Byte
   Private mlngTipoFacCompraId As Long
   Private mlngFacturaIdOrg As Long
   Private mlngSucursalIdOrg As Long
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

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property FacturaId() As Long
      Get
         Return mlngFacturaId
      End Get

      Set(ByVal Value As Long)
         mlngFacturaId = Value
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

   Property MesId() As Long
      Get
         Return mlngMesId
      End Get

      Set(ByVal Value As Long)
         mlngMesId = Value
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

   Property DosificaId() As Long
      Get
         Return mlngDosificaId
      End Get

      Set(ByVal Value As Long)
         mlngDosificaId = Value
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

   Property CompId() As Long
      Get
         Return mlngCompId
      End Get

      Set(ByVal Value As Long)
         mlngCompId = Value
      End Set
   End Property

   Property CompDetId() As Long
      Get
         Return mlngCompDetId
      End Get

      Set(ByVal Value As Long)
         mlngCompDetId = Value
      End Set
   End Property

   Property TipoFacturaId() As Long
      Get
         Return mlngTipoFacturaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoFacturaId = Value
      End Set
   End Property

   Property FacturaFecha() As String
      Get
         Return mstrFacturaFecha
      End Get

      Set(ByVal Value As String)
         mstrFacturaFecha = Value
      End Set
   End Property

   Property FacturaNro() As Long
      Get
         Return mlngFacturaNro
      End Get

      Set(ByVal Value As Long)
         mlngFacturaNro = Value
      End Set
   End Property

   Property FacturaMonto() As Decimal
      Get
         Return mdecFacturaMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecFacturaMonto = Value
      End Set
   End Property

   Property RegRUCId() As Long
      Get
         Return mlngRegRUCId
      End Get

      Set(ByVal Value As Long)
         mlngRegRUCId = Value
      End Set
   End Property

   Property NroRUC() As String
      Get
         Return mstrNroRUC
      End Get

      Set(ByVal Value As String)
         mstrNroRUC = Value
      End Set
   End Property

   Property RegRUCDes() As String
      Get
         Return mstrRegRUCDes
      End Get

      Set(ByVal Value As String)
         mstrRegRUCDes = Value
      End Set
   End Property

   Property NroAutorizacion() As String
      Get
         Return mstrNroAutorizacion
      End Get

      Set(ByVal Value As String)
         mstrNroAutorizacion = Value
      End Set
   End Property

   Property CodControl() As String
      Get
         Return mstrCodControl
      End Get

      Set(ByVal Value As String)
         mstrCodControl = Value
      End Set
   End Property

   Property IVA() As Decimal
      Get
         Return mdecIVA
      End Get

      Set(ByVal Value As Decimal)
         mdecIVA = Value
      End Set
   End Property

   Property IceIehd() As Decimal
      Get
         Return mdecIceIehd
      End Get

      Set(ByVal Value As Decimal)
         mdecIceIehd = Value
      End Set
   End Property

   Property Exento() As Decimal
      Get
         Return mdecExento
      End Get

      Set(ByVal Value As Decimal)
         mdecExento = Value
      End Set
   End Property

   Property FacturaObs() As String
      Get
         Return mstrFacturaObs
      End Get

      Set(ByVal Value As String)
         mstrFacturaObs = Value
      End Set
   End Property

   Property Descuento() As Decimal
      Get
         Return mdecDescuento
      End Get

      Set(ByVal Value As Decimal)
         mdecDescuento = Value
      End Set
   End Property

   Property Bancarizar() As Byte
      Get
         Return mbytBancarizar
      End Get

      Set(ByVal Value As Byte)
         mbytBancarizar = Value
      End Set
   End Property

   Property TipoFacCompraId() As Long
      Get
         Return mlngTipoFacCompraId
      End Get

      Set(ByVal Value As Long)
         mlngTipoFacCompraId = Value
      End Set
   End Property

   Property FacturaIdOrg() As Long
      Get
         Return mlngFacturaIdOrg
      End Get

      Set(ByVal Value As Long)
         mlngFacturaIdOrg = Value
      End Set
   End Property

   Property SucursalIdOrg() As Long
      Get
         Return mlngSucursalIdOrg
      End Get

      Set(ByVal Value As Long)
         mlngSucursalIdOrg = Value
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

   '******************************************************
   '* The following enumerations will change for each
   '* data access class
   '******************************************************
   Public Enum SelectFilters As Byte
      All = 0
      ListBox = 1
      Grid = 2
      LibroIVA = 3
      GridComp = 4
      GridCheck = 5
      LibroIVASC = 6
      GridCompra = 7
      GridVenta = 8
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      CompId = 4
      CompDetId = 5
      FacturaIndi = 6
      FacturaGral = 7
      LibroIVA = 8
      GridComp = 9
      MesId = 10
      GridLista = 11
      GridListaFecha = 12
      GridCheck = 13
      DosificaId = 14
      LibroIVASC = 15
      GridCompra = 16
      GridVenta = 17
      FacturaNroDuplicada = 18
      FacturaDuplicada = 19
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      FacturaId = 1
      Grid = 3
      LibroIVA = 4
      GridComp = 5
      FacturaNro = 6
      Fecha = 7
      LibroIVASC = 8
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      CompId = 1
      FacturaId = 2
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
      mstrTableName = "tblFactura"
      mstrClassName = "clsFactura"

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
      mlngFacturaId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngMesId = 0
      mlngSucursalId = 0
      mlngDosificaId = 0
      mlngTipoCompId = 0
      mlngCompId = 0
      mlngCompDetId = 0
      mlngTipoFacturaId = 0
      mstrFacturaFecha = ""
      mlngFacturaNro = 0
      mdecFacturaMonto = 0
      mlngRegRUCId = 0
      mstrNroRUC = ""
      mstrRegRUCDes = ""
      mstrNroAutorizacion = ""
      mstrCodControl = ""
      mdecIVA = 0
      mdecIceIehd = 0
      mdecExento = 0
      mdecDescuento = 0
      mstrFacturaObs = ""
      mbytBancarizar = 0
      mlngTipoFacCompraId = 0
      mlngFacturaIdOrg = 0
      mlngSucursalIdOrg = 0
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
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.EmpresaId,  "
            strSQL &= "    tblFactura.GestionId,  "
            strSQL &= "    tblFactura.MesId,  "
            strSQL &= "    tblFactura.SucursalId,  "
            strSQL &= "    tblFactura.DosificaId,  "
            strSQL &= "    tblFactura.TipoCompId,  "
            strSQL &= "    tblFactura.CompId,  "
            strSQL &= "    tblFactura.CompDetId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.FacturaMonto,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.CodControl,  "
            strSQL &= "    tblFactura.IVA,  "
            strSQL &= "    tblFactura.IceIehd,  "
            strSQL &= "    tblFactura.Exento,  "
            strSQL &= "    tblFactura.Descuento,  "
            strSQL &= "    tblFactura.FacturaObs,  "
            strSQL &= "    tblFactura.Bancarizar,  "
            strSQL &= "    tblFactura.TipoFacCompraId,  "
            strSQL &= "    tblFactura.FacturaIdOrg,  "
            strSQL &= "    tblFactura.SucursalIdOrg,  "
            strSQL &= "    tblFactura.AppId,  "
            strSQL &= "    tblFactura.TipoDocumentoId,  "
            strSQL &= "    tblFactura.DocumentoId,  "
            strSQL &= "    tblFactura.EstadoId,  "
            strSQL &= "    tblFactura.sLastUpdate_id,  "
            strSQL &= "    tblFactura.dtLastUpdate_dt,  "
            strSQL &= "    tblFactura.iConcurrency_id  "
            strSQL &= " FROM tblFactura "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblFactura.FacturaId  "
            strSQL &= " FROM tblFactura "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.EmpresaId,  "
            strSQL &= "    tblFactura.GestionId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.CodControl,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.FacturaMonto,  "
            strSQL &= "    tblFactura.IceIehd,  "
            strSQL &= "    tblFactura.Exento,  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As Neto,  "
            strSQL &= "    tblFactura.IVA,  "
            strSQL &= "    (tblFactura.FacturaMonto - tblFactura.IVA) As ImporteIva,  "
            strSQL &= "    tblFactura.TipoCompId,  "
            strSQL &= "    tblFactura.CompId,  "
            strSQL &= "    tblFactura.FacturaObs,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblFactura, tblEstado "

         Case SelectFilters.GridComp
            strSQL = " SELECT  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.EmpresaId,  "
            strSQL &= "    tblFactura.CompId,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblFactura.GestionId,  "
            strSQL &= "    tblFactura.TipoCompId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.CodControl,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.FacturaMonto,  "
            strSQL &= "    tblFactura.IceIehd,  "
            strSQL &= "    tblFactura.Exento,  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As Neto,  "
            strSQL &= "    tblFactura.IVA,  "
            strSQL &= "    (tblFactura.FacturaMonto - tblFactura.IVA) As ImporteIva,  "
            strSQL &= "    tblFactura.FacturaObs,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblFactura, tblEstado, tblCompDet, tblPlan "

         Case SelectFilters.LibroIVA
            strSQL = " SELECT  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.CodControl,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.FacturaMonto,  "
            strSQL &= "    tblFactura.IceIehd,  "
            strSQL &= "    tblFactura.Exento,  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As Neto,  "
            strSQL &= "    tblFactura.IVA,  "
            strSQL &= "    tblFactura.FacturaObs,  "
            strSQL &= "    tblFactura.EstadoId  "
            strSQL &= " FROM tblFactura, tblTipoComp, tblComp, tblSucursal "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.EmpresaId,  "
            strSQL &= "    tblFactura.GestionId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.CodControl,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.FacturaMonto,  "
            strSQL &= "    tblFactura.IceIehd,  "
            strSQL &= "    tblFactura.Exento,  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As Neto,  "
            strSQL &= "    tblFactura.IVA,  "
            strSQL &= "    (tblFactura.FacturaMonto - tblFactura.IVA) As ImporteIva,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblFactura.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblFactura.FacturaObs,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblFactura, tblTipoComp, tblComp, tblPlan, tblRegRUC, tblEstado "

         Case SelectFilters.LibroIVASC
            strSQL = " SELECT  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.FacturaObs,  "
            strSQL &= "    tblFactura.EstadoId,  "

            strSQL &= "    tblFacturaDet.ItemId,  "
            strSQL &= "    tblFacturaDet.MedidaId,  "
            strSQL &= "    tblFacturaDet.Cantidad,  "
            strSQL &= "    tblFacturaDet.Precio,  "
            strSQL &= "    tblFacturaDet.Importe  "
            strSQL &= " FROM tblFactura, tblFacturaDet, tblTipoComp, tblComp, tblSucursal "

         Case SelectFilters.GridCompra
            strSQL = " SELECT  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.CodControl,  "
            strSQL &= "    tblFactura.FacturaMonto,  "
            strSQL &= "    tblFactura.Exento,  "
            strSQL &= "    tblFactura.IceIehd,  "
            ''strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As Neto,  "
            ''strSQL &= "    tblFactura.IVA,  "
            ''strSQL &= "    (tblFactura.FacturaMonto - tblFactura.IVA) As ImporteIva  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As SubTotal,  "
            strSQL &= "    tblFactura.Descuento,  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd + tblFactura.Descuento)) As Neto,  "
            strSQL &= "    tblFactura.IVA,  "
            strSQL &= "    ((tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd + tblFactura.Descuento)) - tblFactura.IVA) As ImporteIva  "

            strSQL &= " FROM tblFactura "

         Case SelectFilters.GridVenta
            strSQL = " SELECT  "
            strSQL &= "    tblFactura.FacturaId,  "
            strSQL &= "    tblFactura.TipoFacturaId,  "
            strSQL &= "    tblFactura.FacturaNro,  "
            strSQL &= "    tblFactura.FacturaFecha,  "
            strSQL &= "    tblFactura.RegRUCId,  "
            strSQL &= "    tblFactura.NroRUC,  "
            strSQL &= "    tblFactura.RegRUCDes,  "
            strSQL &= "    tblFactura.NroAutorizacion,  "
            strSQL &= "    tblFactura.CodControl,  "
            strSQL &= "    tblFactura.FacturaMonto,  "
            strSQL &= "    tblFactura.Exento,  "
            strSQL &= "    tblFactura.IceIehd,  "
            ''strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As Neto,  "
            ''strSQL &= "    tblFactura.IVA,  "
            ''strSQL &= "    (tblFactura.FacturaMonto - tblFactura.IVA) As ImporteIva  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd)) As SubTotal,  "
            strSQL &= "    tblFactura.Descuento,  "
            strSQL &= "    (tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd + tblFactura.Descuento)) As Neto,  "
            strSQL &= "    tblFactura.IVA,  "
            strSQL &= "    ((tblFactura.FacturaMonto - (tblFactura.Exento + tblFactura.IceIehd + tblFactura.Descuento)) - tblFactura.IVA) As ImporteIva  "

            strSQL &= " FROM tblFactura "

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
            strSQL = " WHERE  tblFactura.FacturaId = " & NumberToField(mlngFacturaId)
            strSQL &= " AND  tblFactura.FacturaId <> 0 "

         Case WhereFilters.Grid
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  tblFactura.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngTipoFacturaId = 1 Then 'Solo en Ventas
               strSQL &= " AND  tblFactura.DosificaId = " & NumberToField(mlngDosificaId)
            End If
            strSQL &= " AND  tblFactura.MesId = " & NumberToField(mlngMesId)
            strSQL &= " AND  tblFactura.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.CompDetId
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblFactura.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.FacturaIndi
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblFactura.CompDetId <> " & NumberToField(mlngCompDetId)

         Case WhereFilters.FacturaGral
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblFactura.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.LibroIVA
            strSQL = " WHERE  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  tblFactura.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            If mlngMesId <> 0 Then
               strSQL &= " AND  tblFactura.MesId = " & NumberToField(mlngMesId)
            End If
            strSQL &= " AND  tblFactura.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  tblFactura.CompId = tblComp.CompId "
            strSQL &= " AND  tblFactura.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblFactura.EstadoId = 10 "
            strSQL &= " OR  tblFactura.EstadoId = 11) "

         Case WhereFilters.GridComp
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  tblFactura.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblFactura.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.MesId
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  tblFactura.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngTipoFacturaId = 1 Then 'Solo en Ventas
               strSQL &= " AND  tblFactura.DosificaId = " & NumberToField(mlngDosificaId)
            End If
            strSQL &= " AND  tblFactura.MesId = " & NumberToField(mlngMesId)

         Case WhereFilters.GridLista
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  tblFactura.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngTipoFacturaId = 1 Then 'Solo en Ventas
               strSQL &= " AND  tblFactura.DosificaId = " & NumberToField(mlngDosificaId)
            End If
            If mlngGestionId <> 0 Then
               strSQL &= " AND  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            End If
            If mlngMesId <> 0 Then
               strSQL &= " AND  tblFactura.MesId = " & NumberToField(mlngMesId)
            End If
            If (mlngTipoCompId > 0) And (mlngCompId > 0) Then 'Intervalo de Facturas
               strSQL &= " AND  tblFactura.FacturaNro >= " & NumberToField(mlngTipoCompId)
               strSQL &= " AND  tblFactura.FacturaNro <= " & NumberToField(mlngCompId)
            End If
            If mstrFacturaObs <> "" Then
               strSQL &= " AND  tblFactura.FacturaObs LIKE " & StringToField(mstrFacturaObs & LikeOperator)
            End If
            strSQL &= " AND  tblFactura.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GridListaFecha
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  tblFactura.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngTipoFacturaId = 1 Then 'Solo en Ventas
               strSQL &= " AND  tblFactura.DosificaId = " & NumberToField(mlngDosificaId)
            End If
            If mlngGestionId <> 0 Then
               strSQL &= " AND  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            End If
            If mlngMesId <> 0 Then
               strSQL &= " AND  tblFactura.MesId = " & NumberToField(mlngMesId)
            End If
            If (mlngTipoCompId > 0) And (mlngCompId > 0) Then 'Intervalo de Facturas
               strSQL &= " AND  tblFactura.FacturaNro >= " & NumberToField(mlngTipoCompId)
               strSQL &= " AND  tblFactura.FacturaNro <= " & NumberToField(mlngCompId)
            End If
            If mstrFacturaObs <> "" Then
               strSQL &= " AND  tblFactura.FacturaObs LIKE " & StringToField(mstrFacturaObs & LikeOperator)
            End If
            strSQL &= " AND  tblFactura.FacturaFecha >= " & DateToField(mstrFacturaFecha) 'FechaIni
            strSQL &= " AND  tblFactura.FacturaFecha <= " & DateToField(mstrRegRUCDes) 'FechaFin
            strSQL &= " AND  tblFactura.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.GridCheck
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  tblFactura.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngTipoFacturaId = 1 Then 'Solo en Ventas
               strSQL &= " AND  tblFactura.DosificaId = " & NumberToField(mlngDosificaId)
            End If
            strSQL &= " AND  tblFactura.MesId = " & NumberToField(mlngMesId)
            strSQL &= " AND  tblFactura.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblFactura.CompId = tblComp.CompId "
            strSQL &= " AND  tblFactura.RegRUCId = tblRegRUC.RegRUCId "
            strSQL &= " AND  tblRegRUC.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblFactura.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.DosificaId
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.DosificaId = " & NumberToField(mlngDosificaId)

         Case WhereFilters.LibroIVASC
            strSQL = " WHERE  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  tblFactura.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            If mlngMesId <> 0 Then
               strSQL &= " AND  tblFactura.MesId = " & NumberToField(mlngMesId)
            End If
            strSQL &= " AND  tblFactura.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  tblFactura.CompId = tblComp.CompId "
            strSQL &= " AND  tblFactura.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblFactura.EstadoId = 10 "
            strSQL &= " OR  tblFactura.EstadoId = 11) "
            strSQL &= " AND  tblFactura.FacturaId = tblFacturaDet.FacturaId "
            strSQL &= " AND  tblFacturaDet.ItemId = " & NumberToField(mlngRegRUCId) 'ItemId

         Case WhereFilters.GridCompra
            strSQL = " WHERE  tblFactura.FacturaId = " & NumberToField(mlngFacturaId)
            strSQL &= " AND  tblFactura.FacturaId <> 0 "

         Case WhereFilters.GridVenta
            strSQL = " WHERE  tblFactura.FacturaId = " & NumberToField(mlngFacturaId)
            strSQL &= " AND  tblFactura.FacturaId <> 0 "

         Case WhereFilters.FacturaNroDuplicada
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblFactura.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
            strSQL &= " AND  tblFactura.FacturaNro = " & NumberToField(mlngFacturaNro)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  (tblFactura.EstadoId = 10 "
            strSQL &= " OR  tblFactura.EstadoId = 11) "

         Case WhereFilters.FacturaDuplicada
            strSQL = " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  tblFactura.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblFactura.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
            strSQL &= " AND  tblFactura.FacturaNro = " & NumberToField(mlngFacturaNro)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  (tblFactura.EstadoId = 10 "
            strSQL &= " OR  tblFactura.EstadoId = 11) "
            If mlngFacturaId <> 0 Then
               strSQL &= " AND  tblFactura.FacturaId <> " & NumberToField(mlngFacturaId)
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.FacturaId
            strSQL = " ORDER BY tblFactura.FacturaId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblFactura.FacturaId "

         Case OrderByFilters.LibroIVA
            strSQL = " ORDER BY tblSucursal.SucursalDes, tblFactura.NroAutorizacion, tblFactura.FacturaNro "

         Case OrderByFilters.GridComp
            strSQL = " ORDER BY tblCompDet.CompDetId, tblFactura.FacturaFecha "

         Case OrderByFilters.FacturaNro
            strSQL = " ORDER BY tblFactura.DosificaId, tblFactura.FacturaNro "

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY tblFactura.DosificaId, tblFactura.FacturaFecha, tblFactura.FacturaNro "

         Case OrderByFilters.LibroIVASC
            strSQL = " ORDER BY tblFactura.FacturaFecha, tblFactura.TipoFacturaId DESC "

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
            strSQL = "INSERT INTO tblFactura ("
            strSQL &= "FacturaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "MesId, "
            strSQL &= "SucursalId, "
            strSQL &= "DosificaId, "
            strSQL &= "TipoCompId, "
            strSQL &= "CompId, "
            strSQL &= "CompDetId, "
            strSQL &= "TipoFacturaId, "
            strSQL &= "FacturaFecha, "
            strSQL &= "FacturaNro, "
            strSQL &= "FacturaMonto, "
            strSQL &= "RegRUCId, "
            strSQL &= "NroRUC, "
            strSQL &= "RegRUCDes, "
            strSQL &= "NroAutorizacion, "
            strSQL &= "CodControl, "
            strSQL &= "IVA, "
            strSQL &= "IceIehd, "
            strSQL &= "Exento, "
            strSQL &= "Descuento, "
            strSQL &= "FacturaObs, "
            strSQL &= "Bancarizar, "
            strSQL &= "TipoFacCompraId, "
            strSQL &= "FacturaIdOrg, "
            strSQL &= "SucursalIdOrg, "
            strSQL &= "AppId, "
            strSQL &= "TipoDocumentoId, "
            strSQL &= "DocumentoId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngFacturaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngMesId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngDosificaId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngCompDetId) & ", "
            strSQL &= NumberToField(mlngTipoFacturaId) & ", "
            strSQL &= DateToField(mstrFacturaFecha) & ", "
            strSQL &= NumberToField(mlngFacturaNro) & ", "
            strSQL &= DecimalToField(mdecFacturaMonto) & ", "
            strSQL &= NumberToField(mlngRegRUCId) & ", "
            strSQL &= StringToField(mstrNroRUC) & ", "
            strSQL &= StringToField(mstrRegRUCDes) & ", "
            strSQL &= StringToField(mstrNroAutorizacion) & ", "
            strSQL &= StringToField(mstrCodControl) & ", "
            strSQL &= DecimalToField(mdecIVA) & ", "
            strSQL &= DecimalToField(mdecIceIehd) & ", "
            strSQL &= DecimalToField(mdecExento) & ", "
            strSQL &= DecimalToField(mdecDescuento) & ", "
            strSQL &= StringToField(mstrFacturaObs) & ", "
            strSQL &= NumberToField(mbytBancarizar) & ", "
            strSQL &= NumberToField(mlngTipoFacCompraId) & ", "
            strSQL &= NumberToField(mlngFacturaIdOrg) & ", "
            strSQL &= NumberToField(mlngSucursalIdOrg) & ", "
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
            strSQL = "UPDATE tblFactura SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "MesId = " & NumberToField(mlngMesId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "DosificaId = " & NumberToField(mlngDosificaId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "CompDetId = " & NumberToField(mlngCompDetId) & ", "
            strSQL &= "TipoFacturaId = " & NumberToField(mlngTipoFacturaId) & ", "
            strSQL &= "FacturaFecha = " & DateToField(mstrFacturaFecha) & ", "
            strSQL &= "FacturaNro = " & NumberToField(mlngFacturaNro) & ", "
            strSQL &= "FacturaMonto = " & DecimalToField(mdecFacturaMonto) & ", "
            strSQL &= "RegRUCId = " & NumberToField(mlngRegRUCId) & ", "
            strSQL &= "NroRUC = " & StringToField(mstrNroRUC) & ", "
            strSQL &= "RegRUCDes = " & StringToField(mstrRegRUCDes) & ", "
            strSQL &= "NroAutorizacion = " & StringToField(mstrNroAutorizacion) & ", "
            strSQL &= "CodControl = " & StringToField(mstrCodControl) & ", "
            strSQL &= "IVA = " & DecimalToField(mdecIVA) & ", "
            strSQL &= "IceIehd = " & DecimalToField(mdecIceIehd) & ", "
            strSQL &= "Exento = " & DecimalToField(mdecExento) & ", "
            strSQL &= "Descuento = " & DecimalToField(mdecDescuento) & ", "
            strSQL &= "FacturaObs = " & StringToField(mstrFacturaObs) & ", "
            strSQL &= "Bancarizar = " & NumberToField(mbytBancarizar) & ", "
            strSQL &= "TipoFacCompraId = " & NumberToField(mlngTipoFacCompraId) & ", "
            strSQL &= "FacturaIdOrg = " & NumberToField(mlngFacturaIdOrg) & ", "
            strSQL &= "SucursalIdOrg = " & NumberToField(mlngSucursalIdOrg) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " FacturaId = " & NumberToField(mlngFacturaId) & " "

         Case UpdateFilters.CompId
            strSQL = "UPDATE tblFactura SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & " "
            ''strSQL &= "CompDetId = " & NumberToField(mlngCompDetId) & " "
            strSQL &= " WHERE "
            strSQL &= " FacturaId = " & NumberToField(mlngFacturaId) & " "

         Case UpdateFilters.FacturaId
            strSQL = "UPDATE tblFactura SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "MesId = " & NumberToField(mlngMesId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "DosificaId = " & NumberToField(mlngDosificaId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "CompDetId = " & NumberToField(mlngCompDetId) & ", "
            strSQL &= "TipoFacturaId = " & NumberToField(mlngTipoFacturaId) & ", "
            strSQL &= "FacturaFecha = " & DateToField(mstrFacturaFecha) & ", "
            strSQL &= "FacturaNro = " & NumberToField(mlngFacturaNro) & ", "
            strSQL &= "FacturaMonto = " & DecimalToField(mdecFacturaMonto) & ", "
            strSQL &= "RegRUCId = " & NumberToField(mlngRegRUCId) & ", "
            strSQL &= "NroRUC = " & StringToField(mstrNroRUC) & ", "
            strSQL &= "RegRUCDes = " & StringToField(mstrRegRUCDes) & ", "
            strSQL &= "NroAutorizacion = " & StringToField(mstrNroAutorizacion) & ", "
            strSQL &= "CodControl = " & StringToField(mstrCodControl) & ", "
            strSQL &= "IVA = " & DecimalToField(mdecIVA) & ", "
            strSQL &= "IceIehd = " & DecimalToField(mdecIceIehd) & ", "
            strSQL &= "Exento = " & DecimalToField(mdecExento) & ", "
            strSQL &= "Descuento = " & DecimalToField(mdecDescuento) & ", "
            strSQL &= "FacturaObs = " & StringToField(mstrFacturaObs) & ", "
            strSQL &= "Bancarizar = " & NumberToField(mbytBancarizar) & ", "
            strSQL &= "TipoFacCompraId = " & NumberToField(mlngTipoFacCompraId) & ", "
            strSQL &= "FacturaIdOrg = " & NumberToField(mlngFacturaIdOrg) & ", "
            strSQL &= "SucursalIdOrg = " & NumberToField(mlngSucursalIdOrg) & ", "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "TipoDocumentoId = " & NumberToField(mlngTipoDocumentoId) & ", "
            strSQL &= "DocumentoId = " & NumberToField(mlngDocumentoId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & " "
            strSQL &= " WHERE "
            strSQL &= " FacturaId = " & NumberToField(mlngFacturaId) & " "

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
               mlngFacturaId = ToLong(oDataRow("FacturaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngMesId = ToLong(oDataRow("MesId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngDosificaId = ToLong(oDataRow("DosificaId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngCompDetId = ToLong(oDataRow("CompDetId"))
               mlngTipoFacturaId = ToLong(oDataRow("TipoFacturaId"))
               mstrFacturaFecha = ToDateDMY(oDataRow("FacturaFecha"))
               mlngFacturaNro = ToLong(oDataRow("FacturaNro"))
               mdecFacturaMonto = ToDecimal(oDataRow("FacturaMonto"))
               mlngRegRUCId = ToLong(oDataRow("RegRUCId"))
               mstrNroRUC = ToStr(oDataRow("NroRUC"))
               mstrRegRUCDes = ToStr(oDataRow("RegRUCDes"))
               mstrNroAutorizacion = ToStr(oDataRow("NroAutorizacion"))
               mstrCodControl = ToStr(oDataRow("CodControl"))
               mdecIVA = ToDecimal(oDataRow("IVA"))
               mdecIceIehd = ToDecimal(oDataRow("IceIehd"))
               mdecExento = ToDecimal(oDataRow("Exento"))
               mdecDescuento = ToDecimal(oDataRow("Descuento"))
               mstrFacturaObs = ToStr(oDataRow("FacturaObs"))
               mbytBancarizar = ToByte(oDataRow("Bancarizar"))
               mlngTipoFacCompraId = ToLong(oDataRow("TipoFacCompraId"))
               mlngFacturaIdOrg = ToLong(oDataRow("FacturaIdOrg"))
               mlngSucursalIdOrg = ToLong(oDataRow("SucursalIdOrg"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngTipoDocumentoId = ToLong(oDataRow("TipoDocumentoId"))
               mlngDocumentoId = ToLong(oDataRow("DocumentoId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngFacturaId = ToLong(oDataRow("FacturaId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngFacturaId = TableIDGet(mstrTableName, "FacturaId", moConnection)

         If mlngFacturaId = -1 Then
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

      If mstrFacturaFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFacturaFecha)) Then
            strMsg &= "Fecha de Factura no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La FacturaFecha no puede ser nula" & vbCrLf
      End If

      If mstrNroRUC.Trim() = String.Empty Then
         strMsg &= "Número de NIT Inválido" & vbCrLf
      End If

      If mstrRegRUCDes.Trim() = String.Empty Then
         strMsg &= "Ingrese la Razón Social" & vbCrLf
      End If

      If mstrNroAutorizacion.Trim() = String.Empty Then
         strMsg &= "Número de Autorización Inválido" & vbCrLf
      End If

      If mlngFacturaNro = 0 Then
         strMsg &= "Ingrese el Número de Factura" & vbCrLf
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
         strSQL &= " FROM tblFactura "

         If Not boolReplace Then
            strSQL &= " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
            strSQL &= " AND  tblFactura.FacturaNro = " & NumberToField(mlngFacturaNro)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  (tblFactura.EstadoId = 10 "
            strSQL &= " OR  tblFactura.EstadoId = 11) "
         Else
            strSQL &= " WHERE  tblFactura.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFactura.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
            strSQL &= " AND  tblFactura.FacturaNro = " & NumberToField(mlngFacturaNro)
            strSQL &= " AND  tblFactura.TipoFacturaId = " & NumberToField(mlngTipoFacturaId)
            strSQL &= " AND  (tblFactura.EstadoId = 10 "
            strSQL &= " OR  tblFactura.EstadoId = 11) "
            strSQL &= " AND  tblFactura.FacturaId <> " & NumberToField(mlngFacturaId)
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
               Throw New Exception("Factura Duplicada")
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
         If Validate() Then
            ''If NoDuplicates(False) Then
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
            ''Else
            ''   Throw New Exception("Factura Duplicada")
            ''   Return False
            ''End If
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
         ''If Validate() Then
         ''   If NoDuplicates(True) Then
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
               Throw New Exception("Factura Duplicada")
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
