
Print 'Creating table dbo.comProveedor'
CREATE TABLE dbo.comProveedor
(
   ProveedorId int NOT NULL,
   EmpresaId int NOT NULL,
   ProveedorDes varchar(255) NOT NULL,
   ProveedorCod varchar(50) NULL,
   ProveedorNIT varchar(50) NULL,
   Direccion varchar(200) NULL,
   CiudadId int NOT NULL,
   Telefono1 varchar(100) NULL,
   Telefono2 varchar(100) NULL,
   Movil varchar(100) NULL,
   Fax varchar(100) NULL,
   Email varchar(200) NULL,
   Web varchar(200) NULL,
   MonedaId int NOT NULL,
   ContactoDes varchar(255) NULL,
   ContactoCI varchar(50) NULL,
   ContactoCargo varchar(50) NULL,
   PlanIdPas int NOT NULL,
   PlanAddIdPas int NOT NULL,
   PlanIdAct int NOT NULL,
   PlanAddIdAct int NOT NULL,
   PlanIdInt int NOT NULL,
   PlanAddIdInt int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT ProveedorPK 
   PRIMARY KEY NONCLUSTERED(ProveedorId)
)

Print 'Creating table dbo.comItemProveedor'
CREATE TABLE dbo.comItemProveedor
(
   ItemProveedorId int NOT NULL,
   EmpresaId int NOT NULL,
   ProveedorId int NOT NULL,
   ItemId int NOT NULL,
   PrecioUPC decimal(18, 5) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT ItemProveedorPK 
   PRIMARY KEY NONCLUSTERED(ItemProveedorId)
)

Print 'Creating table dbo.comPlanDescuento'
CREATE TABLE dbo.comPlanDescuento
(
   PlanDescuentoId int NOT NULL,
   EmpresaId int NOT NULL,
   PlanDescuentoDes varchar(255) NOT NULL,
   PlanId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PlanDescuentoPK 
   PRIMARY KEY NONCLUSTERED(PlanDescuentoId)
)

Print 'Creating table dbo.comPlanRecargo'
CREATE TABLE dbo.comPlanRecargo
(
   PlanRecargoId int NOT NULL,
   EmpresaId int NOT NULL,
   PlanRecargoDes varchar(255) NOT NULL,
   PlanId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PlanRecargoPK 
   PRIMARY KEY NONCLUSTERED(PlanRecargoId)
)

Print 'Creating table dbo.comPedCompra'
CREATE TABLE dbo.comPedCompra
(
   PedCompraId int NOT NULL,
   EmpresaId int NOT NULL,
   PedCompraNro int NOT NULL,
   Fecha datetime NOT NULL,
   AlmacenId int NOT NULL,
   ProveedorId int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   PedCompraOrden varchar(50) NULL,
   PedCompraDes varchar(255) NOT NULL,
   PedCompraObs text NULL,
   PedCompraMonto decimal(18, 5) NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PedCompraPK 
   PRIMARY KEY NONCLUSTERED(PedCompraId)
)

Print 'Creating table dbo.comPedCompraDet'
CREATE TABLE dbo.comPedCompraDet
(
   PedCompraDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   PedCompraId int NOT NULL,
   Fecha datetime NOT NULL,
   AlmacenId int NOT NULL,
   ProveedorId int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   ItemId int NOT NULL,
   MedidaId int NOT NULL,
   Cantidad decimal(18, 5) NOT NULL,
   Precio decimal(18, 5) NOT NULL,
   Importe decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PedCompraDetPK 
   PRIMARY KEY NONCLUSTERED(PedCompraDetId)
)

Print 'Creating table dbo.comTipoCompra'
CREATE TABLE dbo.comTipoCompra
(
   TipoCompraId int NOT NULL,
   TipoCompraDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoCompraPK 
   PRIMARY KEY NONCLUSTERED(TipoCompraId)
)

Print 'Creating table dbo.comCompraPara'
CREATE TABLE dbo.comCompraPara
(
   CompraParaId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   TipoCompraId int NOT NULL,
   NroIni int NOT NULL,
   NroActual int NOT NULL,
   Firma varchar(1000) NULL,
   ConFac bit NOT NULL,
   TipoHojaId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompraParaPK 
   PRIMARY KEY NONCLUSTERED(CompraParaId)
)

Print 'Creating table dbo.comTipoAnticipo'
CREATE TABLE dbo.comTipoAnticipo
(
   TipoAnticipoId int NOT NULL,
   TipoAnticipoDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoAnticipoPK 
   PRIMARY KEY NONCLUSTERED(TipoAnticipoId)
)

Print 'Creating table dbo.comAnticipo'
CREATE TABLE dbo.comAnticipo
(
   AnticipoId int NOT NULL,
   EmpresaId int NOT NULL,
   TipoAnticipoId int NOT NULL,
   AnticipoNro int NOT NULL,
   Fecha datetime NOT NULL,
   PedCompraId int NOT NULL,
   ProveedorId int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   AnticipoDes varchar(255) NOT NULL,
   AnticipoObs text NULL,
   MontoAnt decimal(18, 5) NOT NULL,
   MontoDes decimal(18, 5) NOT NULL,
   GestionId int NOT NULL,
   TipoCompId int NOT NULL,
   CompNro int NOT NULL,
   PlanId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT AnticipoPK 
   PRIMARY KEY NONCLUSTERED(AnticipoId)
)

Print 'Creating table dbo.comAnticipoDet'
CREATE TABLE dbo.comAnticipoDet
(
   AnticipoDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   AnticipoId int NOT NULL,
   ProveedorId int NOT NULL,
   TipoCompraId int NOT NULL,
   DocumentoId int NOT NULL,
   Fecha datetime NOT NULL,
   AnticipoDetDes varchar(255) NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   Monto decimal(18, 5) NOT NULL,
   TipoCompId int NOT NULL,
   CompNro int NOT NULL,
   PlanId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT AnticipoDetPK 
   PRIMARY KEY NONCLUSTERED(AnticipoDetId)
)

Print 'Creating table dbo.comTipoPago'
CREATE TABLE dbo.comTipoPago
(
   TipoPagoId int NOT NULL,
   TipoPagoDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoPagoPK 
   PRIMARY KEY NONCLUSTERED(TipoPagoId)
)

Print 'Creating table dbo.comTipoEfectivo'
CREATE TABLE dbo.comTipoEfectivo
(
   TipoEfectivoId int NOT NULL,
   TipoEfectivoDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoEfectivoPK 
   PRIMARY KEY NONCLUSTERED(TipoEfectivoId)
)

Print 'Creating table dbo.comTipoCredito'
CREATE TABLE dbo.comTipoCredito
(
   TipoCreditoId int NOT NULL,
   TipoCreditoDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoCreditoPK 
   PRIMARY KEY NONCLUSTERED(TipoCreditoId)
)

Print 'Creating table dbo.comCompra'
CREATE TABLE dbo.comCompra
(
   CompraId int NOT NULL,
   EmpresaId int NOT NULL,
   CompraNro int NOT NULL,
   Fecha datetime NOT NULL,
   AlmacenId int NOT NULL,
   ProveedorId int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   CompraOrden varchar(50) NULL,
   CompraDes varchar(255) NULL,
   CompraObs text NULL,
   TipoPagoId int NOT NULL,
   MontoOrg decimal(18, 5) NOT NULL,
   MontoCos decimal(18, 5) NOT NULL,
   MontoAnt decimal(18, 5) NOT NULL,
   MontoDes decimal(18, 5) NOT NULL,
   MontoRec decimal(18, 5) NOT NULL,
   MontoOtro decimal(18, 5) NOT NULL,
   MontoNet decimal(18, 5) NOT NULL,
   MontoLiq decimal(18, 5) NOT NULL,
   FacturaId int NOT NULL,
   PolizaId int NOT NULL,
   PorIVA decimal(18, 5) NOT NULL,
   PorPoliza decimal(18, 5) NOT NULL,
   GestionId int NOT NULL,
   TipoNotaId int NOT NULL,
   NotaNro int NOT NULL,
   TipoCompId int NOT NULL,
   CompNro int NOT NULL,
   PlanId int NOT NULL,
   PedCompraId int NOT NULL,
   CreditoId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompraPK 
   PRIMARY KEY NONCLUSTERED(CompraId)
)

Print 'Creating table dbo.comCompraDet'
CREATE TABLE dbo.comCompraDet
(
   CompraDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   Fecha datetime NOT NULL,
   AlmacenId int NOT NULL,
   ProveedorId int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   ItemId int NOT NULL,
   MedidaId int NOT NULL,
   Cantidad decimal(18, 5) NOT NULL,
   PrecioOrg decimal(18, 5) NOT NULL,
   PrecioCos decimal(18, 5) NOT NULL,
   Importe decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompraDetPK 
   PRIMARY KEY NONCLUSTERED(CompraDetId)
)

Print 'Creating table dbo.comCompraRecargo'
CREATE TABLE dbo.comCompraRecargo
(
   CompraRecargoId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   PlanRecargoId int NOT NULL,
   MonedaId int NOT NULL,
   Monto decimal(18, 5) NOT NULL,
   AplicarCosto bit NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompraRecargoPK 
   PRIMARY KEY NONCLUSTERED(CompraRecargoId)
)

Print 'Creating table dbo.comCompraDescuento'
CREATE TABLE dbo.comCompraDescuento
(
   CompraDescuentoId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   PlanDescuentoId int NOT NULL,
   MonedaId int NOT NULL,
   Monto decimal(18, 5) NOT NULL,
   AplicarCosto bit NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompraDescuentoPK 
   PRIMARY KEY NONCLUSTERED(CompraDescuentoId)
)

Print 'Creating table dbo.comPlanOtroCosto'
CREATE TABLE dbo.comPlanOtroCosto
(
   PlanOtroCostoId int NOT NULL,
   EmpresaId int NOT NULL,
   PlanOtroCostoDes varchar(255) NOT NULL,
   PlanId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PlanOtroCostoPK 
   PRIMARY KEY NONCLUSTERED(PlanOtroCostoId)
)

Print 'Creating table dbo.comCompraOtroCosto'
CREATE TABLE dbo.comCompraOtroCosto
(
   CompraOtroCostoId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   PlanOtroCostoId int NOT NULL,
   Fecha datetime NOT NULL,
   CompraOtroCostoDes varchar(255) NULL,
   MonedaId int NOT NULL,
   Monto decimal(18, 5) NOT NULL,
   CompId int NOT NULL,
   PlanId int NOT NULL,
   FacturaId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompraOtroCostoPK 
   PRIMARY KEY NONCLUSTERED(CompraOtroCostoId)
)

Print 'Creating table dbo.comProrrateo'
CREATE TABLE dbo.comProrrateo
(
   ProrrateoId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   ItemId int NOT NULL,
   CompraOtroCostoId int NOT NULL,
   MontoCos decimal(18, 5) NOT NULL,
   PrecioCif decimal(18, 5) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT ProrrateoPK 
   PRIMARY KEY NONCLUSTERED(ProrrateoId)
)

Print 'Creating table dbo.comFrecuencia'
CREATE TABLE dbo.comFrecuencia
(
   FrecuenciaId int NOT NULL,
   FrecuenciaDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT FrecuenciaPK 
   PRIMARY KEY NONCLUSTERED(FrecuenciaId)
)

Print 'Creating table dbo.comCredito'
CREATE TABLE dbo.comCredito
(
   CreditoId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   TipoCreditoId int NOT NULL,
   CreditoNro int NOT NULL,
   FechaIni datetime NOT NULL,
   FechaFin datetime NOT NULL,
   ProveedorId int NOT NULL,
   FrecuenciaId int NOT NULL,
   FrecuenciaNro int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   MontoLiq decimal(18, 5) NOT NULL,
   MontoAmo decimal(18, 5) NOT NULL,
   CantidadCuota int NOT NULL,
   MontoCuota decimal(18, 5) NOT NULL,
   InteresAnual decimal(18, 5) NOT NULL,
   GarantiaId int NOT NULL,
   GarantiaObs varchar(255) NULL,
   SaldoIni bit NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CreditoPK 
   PRIMARY KEY NONCLUSTERED(CreditoId)
)

Print 'Creating table dbo.comCreditoDet'
CREATE TABLE dbo.comCreditoDet
(
   CreditoDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   TipoCreditoId int NOT NULL,
   CreditoId int NOT NULL,
   Fecha datetime NOT NULL,
   ProveedorId int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   CuotaNro int NOT NULL,
   Capital decimal(18, 5) NOT NULL,
   Interes decimal(18, 5) NOT NULL,
   Importe decimal(18, 5) NOT NULL,
   CapitalAmo decimal(18, 5) NOT NULL,
   InteresAmo decimal(18, 5) NOT NULL,
   FechaAmo datetime NOT NULL,
   InteresPen decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CreditoDetPK 
   PRIMARY KEY NONCLUSTERED(CreditoDetId)
)

Print 'Creating table dbo.comGarantia'
CREATE TABLE dbo.comGarantia
(
   GarantiaId int NOT NULL,
   GarantiaDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT GarantiaPK 
   PRIMARY KEY NONCLUSTERED(GarantiaId)
)

Print 'Creating table dbo.comProveedorMov'
CREATE TABLE dbo.comProveedorMov
(
   ProveedorMovId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   ProveedorId int NOT NULL,
   TipoCompraId int NOT NULL,
   DocumentoId int NOT NULL,
   TipoPagoId int NOT NULL,
   Fecha datetime NOT NULL,
   ProveedorMovDes varchar(255) NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   DebeBs decimal(18, 5) NOT NULL,
   HaberBs decimal(18, 5) NOT NULL,
   DebeUs decimal(18, 5) NOT NULL,
   HaberUs decimal(18, 5) NOT NULL,
   TipoCompId int NOT NULL,
   CompNro int NOT NULL,
   PlanId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT ProveedorMovPK 
   PRIMARY KEY NONCLUSTERED(ProveedorMovId)
)

Print 'Creating table dbo.comPago'
CREATE TABLE dbo.comPago
(
   PagoId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   TipoPagoId int NOT NULL,
   PagoNro int NOT NULL,
   ProveedorId int NOT NULL,
   Fecha datetime NOT NULL,
   PagoDes varchar(255) NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   Capital decimal(18, 5) NOT NULL,
   Interes decimal(18, 5) NOT NULL,
   MontoPag decimal(18, 5) NOT NULL,
   PlanRecargoId int NOT NULL,
   MontoRec decimal(18, 5) NOT NULL,
   PlanDescuentoId int NOT NULL,
   MontoDes decimal(18, 5) NOT NULL,
   TipoCompId int NOT NULL,
   CompNro int NOT NULL,
   PlanId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PagoPK 
   PRIMARY KEY NONCLUSTERED(PagoId)
)

Print 'Creating table dbo.comPagoDet'
CREATE TABLE dbo.comPagoDet
(
   PagoDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   TipoPagoId int NOT NULL,
   PagoId int NOT NULL,
   CompraId int NOT NULL,
   CreditoId int NOT NULL,
   CreditoDetId int NOT NULL,
   ProveedorId int NOT NULL,
   Fecha datetime NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   CapitalOrg decimal(18, 5) NOT NULL,
   InteresOrg decimal(18, 5) NOT NULL,
   CapitalAmo decimal(18, 5) NOT NULL,
   InteresAmo decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PagoDetPK 
   PRIMARY KEY NONCLUSTERED(PagoDetId)
)

Print 'Creating table dbo.comAjuste'
CREATE TABLE dbo.comAjuste
(
   AjusteId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   AjusteNro int NOT NULL,
   ProveedorId int NOT NULL,
   Fecha datetime NOT NULL,
   AjusteDes varchar(255) NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   Capital decimal(18, 5) NOT NULL,
   Interes decimal(18, 5) NOT NULL,
   MontoPag decimal(18, 5) NOT NULL,
   TipoCompId int NOT NULL,
   CompNro int NOT NULL,
   PlanId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT comAjustePK 
   PRIMARY KEY NONCLUSTERED(AjusteId)
)

Print 'Creating table dbo.comAjusteDet'
CREATE TABLE dbo.comAjusteDet
(
   AjusteDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   AjusteId int NOT NULL,
   CompraId int NOT NULL,
   CreditoId int NOT NULL,
   CreditoDetId int NOT NULL,
   ProveedorId int NOT NULL,
   Fecha datetime NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   CapitalOrg decimal(18, 5) NOT NULL,
   InteresOrg decimal(18, 5) NOT NULL,
   ImporteOrg decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT comAjusteDetPK 
   PRIMARY KEY NONCLUSTERED(AjusteDetId)
)

Print 'Creating table dbo.comDevCompra'
CREATE TABLE dbo.comDevCompra
(
   DevCompraId int NOT NULL,
   EmpresaId int NOT NULL,
   DevCompraNro int NOT NULL,
   Fecha datetime NOT NULL,
   AlmacenId int NOT NULL,
   ProveedorId int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   DevCompraDes varchar(255) NOT NULL,
   DevCompraObs text NULL,
   TipoPagoId int NOT NULL,
   MontoOrg decimal(18, 5) NOT NULL,
   MontoCos decimal(18, 5) NOT NULL,
   MontoNet decimal(18, 5) NOT NULL,
   GestionId int NOT NULL,
   TipoNotaId int NOT NULL,
   NotaNro int NOT NULL,
   TipoCompId int NOT NULL,
   CompNro int NOT NULL,
   PlanId int NOT NULL,
   CompraId int NOT NULL,
   CreditoId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT DevCompraPK 
   PRIMARY KEY NONCLUSTERED(DevCompraId)
)

Print 'Creating table dbo.comDevCompraDet'
CREATE TABLE dbo.comDevCompraDet
(
   DevCompraDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompraId int NOT NULL,
   DevCompraId int NOT NULL,
   Fecha datetime NOT NULL,
   AlmacenId int NOT NULL,
   ProveedorId int NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   ItemId int NOT NULL,
   MedidaId int NOT NULL,
   CantidadOrg decimal(18, 5) NOT NULL,
   CantidadDev decimal(18, 5) NOT NULL,
   PrecioOrg decimal(18, 5) NOT NULL,
   PrecioCos decimal(18, 5) NOT NULL,
   PrecioNet decimal(18, 5) NOT NULL,
   Importe decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT DevCompraDetPK 
   PRIMARY KEY NONCLUSTERED(DevCompraDetId)
)








