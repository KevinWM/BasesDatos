--DROP DATABASE sisV
create database sisV

use sisV

-- VALOR POR DEFECTO DE SEXO
CREATE DEFAULT DSexo AS 'F'
GO

--CREACIÓN DE REGLAS 
go 
create rule RCedula as @cedula like  '[0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'

go
create rule RTelefono as @telefono like '[0-9][0-9]-[0-9][0-9]-[0-9][0-9]-[0-9][0-9]'
go

CREATE RULE REmail AS @email LIKE '[a-Z]%@[a-Z]%.[A-Z]%'
GO  

CREATE RULE RSexo AS @sexo   IN ('F','M')
GO

--CREACIÓN DE TIPOS

EXECUTE sp_addtype TCedula, 'char(11)','not null'
GO

EXECUTE sp_addtype TSexo, 'char(1)','not null'
GO

EXECUTE sp_addtype TTelefono, 'char(11)','not null'
GO

EXEC sp_addtype TEmail, 'varchar(30)', 'not null'
GO 


--VINCULAR LAS REGLAS CON LOS TIPOS

EXEC sp_bindrule 'RCedula', 'TCedula' 
GO 
EXEC sp_bindrule 'RTelefono', 'TTelefono' 
GO 
EXEC sp_bindrule 'REmail', 'TEmail' 
GO
EXEC sp_bindrule 'RSexo', 'TSexo' 
GO  
EXEC sp_bindefault	'DSexo',		'TSexo'
GO


--TABLA PROVINCIAS
create table Provincia(
	idProvincia tinyint not null,
	nombreP varchar(30) not null DEFAULT'Alajuela'
	CONSTRAINT CHK_Provincia CHECK (nombreP IN ('San José','Alajuela','Cartago','Heredia','Guanacaste','Puntarenas','Limón'))
	CONSTRAINT PK_Provincia	primary key	(idProvincia),
	CONSTRAINT	UNQ_nombrep	UNIQUE	(nombreP)

)

--TABLA CANTONES
create table Canton(
	idCanton tinyint identity(0,1),
	nombreCanton varchar(30) not null DEFAULT'San Carlos',--VALOR POR DEFECTO DE CANTON
	idProvincia tinyint not  null
	CONSTRAINT PK_Canton primary key (idCanton),
	CONSTRAINT FK_Provincia_Canton foreign key (idProvincia) references Provincia on delete cascade,
	CONSTRAINT	UNQ_nombreC	UNIQUE	(nombreCanton)
)

--TABLA DE DISTRITOS
create table distrito(
	idDistrito tinyint identity(0,1),
	nombreD varchar(30) not null,
	idCanton tinyint not null
	CONSTRAINT PK_Distrito primary key (idDistrito),
	CONSTRAINT FK_Canton_Distrito foreign key (idCanton) references Canton on delete cascade,
	CONSTRAINT	UNQ_nombreD	UNIQUE	(nombreD)
)

--TABLA PERSONAS
--drop table persona
create table persona(
	cedula TCedula ,
	Nombre varchar(30) not null,
	apellido1 varchar(30) not null,
	apellido2 varchar(30) not null,
	sexo	TSexo,
	idDistrito tinyint not null,
	otrasSeñas varchar(200) 
	CONSTRAINT PK_persona primary key(cedula),
	CONSTRAINT FK_Distrito_Persona foreign key (idDistrito) references Distrito

)

--TABLA TELEFONOS PERSONA
create table TelefonoPersona(
	cedula char(11),
	telefono TTelefono 
	CONSTRAINT PK_TelefonoPersona primary key (cedula,telefono),
	CONSTRAINT FK_TelefonoPersona_Persona foreign key (cedula) references Persona on delete cascade
)


--TABLA CORREOS PERSONA
--drop table CorreosProveedor
create table CorreosPersona(
	cedula char(11) ,
	correo TEmail 
	CONSTRAINT PK_CorreosPersona primary key (cedula,correo),
	CONSTRAINT FK_CorreosPersonar_Persona foreign key (cedula) references Persona  on delete cascade
)

--TABLA CLIENTE
--drop table cliente
create table cliente(
	cedula TCedula,
	numCliente smallint not null,
	tipoCliente varchar(10) not null DEFAULT'NoDeudor',
	CONSTRAINT PK_Cliente primary key(cedula),
	CONSTRAINT CHK_tipoCliente CHECK (tipoCliente IN ('Deudor','NoDeudor')),
	CONSTRAINT FK_CLIENTE_PERSONA foreign key(cedula) references Persona

)

--TABLA VENDEDOR 
create table vendedor(
	cedula TCedula,
	NombreUsuario varchar(30) not null,
	contraseña varchar(20) not null,
	tipoVendedor varchar(20) not null DEFAULT 'Vendedor',
	CONSTRAINT PK_Vendedor primary key(cedula),
	CONSTRAINT CHK_tipoVendedor CHECK (tipoVendedor IN ('Administrador','Vendedor')),
	CONSTRAINT FK_Vendedor_PERSONA foreign key(cedula) references Persona,
	CONSTRAINT	UNQ_usuarioVendedor	UNIQUE	(NombreUsuario)
)

--TABLA FACTURA

--drop table factura
create table factura(
	numFactura smallint not null,
	Tipo_Fac varchar (10) not null default 'Contado',
	hora time,
	fecha date,
	cedulaC char(11),
	cedulaV char(11),
	montoCredito int,
	CONSTRAINT PK_factura primary key (numFactura),
	CONSTRAINT FK_Cliente_Factura foreign key (cedulaC) references cliente,
	CONSTRAINT FK_Vendedor_Factura foreign key (cedulaV) references vendedor,
	CONSTRAINT CHK_tipoFactura CHECK (Tipo_Fac IN ('Contado','Crédito')),
	CONSTRAINT CHK_CEDULAV CHECK (cedulaV like  '[0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
	CONSTRAINT CHK_CEDULAC CHECK (cedulaC like  '[0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
)
--TABLA PAGOS
create table pago(
	numero tinyint   identity(0,1),
	numFactura smallint not null,
	monto int not null,
	fechaPago date not null,
	CONSTRAINT PK_Pago primary key (numFactura,numero),
	CONSTRAINT FK_Pago_Factura foreign key (numFactura) references factura  on delete cascade
)

--TABLA PROVEEDORES

--drop table Proveedor
create table Proveedor(
	idProveedor smallint not null,
	nombreEmpresa varchar(30) not null,
	descripcion varchar(200),
	idDistrito tinyint not null,
	otrasSeñas varchar(200),
	CONSTRAINT PK_Proveedor primary key (idProveedor),
	CONSTRAINT FK_Distrito_Proveedor foreign key (idDistrito) references Distrito
)

--TABLA TELEFONOS DE PROVEEDOR

--drop table TelefonoProveedor
create table TelefonoProveedor(
	idProveedor smallint not null,
	telefono TTelefono 
	CONSTRAINT PK_TelefonoProveedor primary key (idProveedor,telefono),
	CONSTRAINT FK_TelefonoProveedor_Proveedor foreign key (idProveedor) references Proveedor  on delete cascade
)

--TABLA DE CORREOS PERSONA

--drop table CorreosProveedor
create table CorreosProveedor(
	idProveedor smallint not null,
	correo TEmail
	CONSTRAINT PK_CorreosProveedor primary key (idProveedor,correo),
	CONSTRAINT FK_CorreosProveedor_Proveedor foreign key (idProveedor) references Proveedor  on delete cascade
)

--TABLA PRODUCTO
create table Producto(
	codigo int not null,
	tipoImpuesto varchar(7) not null,
	categoria varchar (30) not null,
	nombre varchar(30) not null,
	marca varchar(30) not null,
	precioVenta int not null,
	stock smallint not null,
	familiaProductos varchar(30),
	idProveedor smallint not null,
	CONSTRAINT PK_Producto primary key (codigo),
	CONSTRAINT CHK_tipoImpuesto  CHECK (tipoImpuesto IN ('Excento','Grabado')),
	CONSTRAINT FK_Producto_Proveedor foreign key (idProveedor) references Proveedor  on delete cascade
)
--TABLA FACTURA PRODUCTO

create table Factura_Producto(
	numFactura smallint not null,
	codigo int not null,
	monto int not null,
	cantidad tinyint not null,
	CONSTRAINT PK_Factura_Producto primary key (codigo,numFactura),
	CONSTRAINT FK_Factura_Producto_Producto foreign key (codigo) references Producto on delete cascade,
	CONSTRAINT FK_Factura_Producto_Factura foreign key (numFactura) references factura on delete cascade,
)


--drop table EstudiantesGrupo


/*												**************************************************
------------------------------------------------* INSERCIÓN ELIMINACIÓN Y MODIFICACIÓN  DE DATOS *-----------------------------------------------------------------------------------
												**************************************************
*/

--                      ______________________________________
--_____________________ //   PROVINCIAS CANTONES Y DISTRITOS \\   ____________________
--                      _______________________________________


--*********************PROCEDIMIENTO PARA INSERTAR PROVINCIAS*************************
/*
Resibe el id de provincia, y el nombre de la provincia y luego lo inserta en la base de datos
*/

--DROP PROCEDURE INSprovincia
CREATE PROCEDURE INSprovincia (@idProvincia tinyint, @nombre varchar(30))
AS
BEGIN 
	BEGIN TRY
		insert into Provincia VALUES (@idProvincia,@nombre)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END


--*********************PROCEDIMIENTO PARA MODIFICAR PROVINCIAS*************************

--drop procedure UPDProvincia
create procedure UPDProvincia (@idProvincia tinyint, @nombreP varchar(30)) 
as
begin
 begin try
  update Provincia set @nombreP = @nombreP where idProvincia = @idProvincia
 end try
 begin catch
  raiserror (N'No se puede modificar el registro', 1, -1)
 end catch
end




--*********************PROCEDIMIENTO PARA ELIMINAR PROVINCIAS*************************


--DROP PROCEDURE DELProvincia
CREATE PROCEDURE DELProvincia (@idProvincia tinyint) 
AS
BEGIN 
	BEGIN TRY
		delete Provincia where idProvincia= @idProvincia
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 



--*********************PROCEDIMIENTO PARA INSERTAR CANTONES*************************


--DROP PROCEDURE INScanton
CREATE PROCEDURE INScanton (@idProvincia tinyint, @nombre varchar(30))
AS
BEGIN 
	BEGIN TRY
		insert into Canton VALUES (@nombre,@idProvincia)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END

--*********************PROCEDIMIENTO PARA MODIFICAR CANTONES*************************

--drop procedure UPDCanton
create procedure UPDCanton (@idCanton tinyint, @nombreCanton varchar(30)) 
as
begin
 begin try
  update Canton set nombreCanton = @nombreCanton where idCanton = @idCanton
 end try
 begin catch
  raiserror (N'No se puede modificar el registro', 1, -1)
 end catch
end






--*********************PROCEDIMIENTO PARA ELIMINAR CANTONES*************************


--DROP PROCEDURE DELCanton
CREATE PROCEDURE DELCanton (@idCanton tinyint) 
AS
BEGIN 
	BEGIN TRY
		delete Canton where idCanton= @idCanton
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 




--*********************PROCEDIMIENTO PARA INSERTAR DISTRITOS*************************


--DROP PROCEDURE INSdistrito
CREATE PROCEDURE INSdistrito (@idCanton tinyint, @nombre varchar(30))
AS
BEGIN 
	BEGIN TRY
		insert into distrito VALUES (@nombre,@idCanton)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END



--*********************PROCEDIMIENTO PARA MODIFICAR DISTRITOS*************************


--drop procedure UPDDistrito
create procedure UPDDistrito (@idDistrito  tinyint, @nombreD  varchar(30)) 
as
begin
 begin try
  update distrito set nombreD = @nombreD where idDistrito = @idDistrito
 end try
 begin catch
  raiserror (N'No se puede modificar el registro', 1, -1)
 end catch
end






--*********************PROCEDIMIENTO PARA ELIMINAR DISTRITOS*************************


--DROP PROCEDURE DELdistrito
CREATE PROCEDURE DELdistrito (@idDistrito tinyint) 
AS
BEGIN 
	BEGIN TRY
		delete distrito where idDistrito= @idDistrito
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 





--                      ___________________
--_____________________ //   VENDEDORES\\   ____________________
--                      ___________________




--*********************PROCEDIMIENTO PARA INSERTAR VENDEDORES*************************



--DROP PROCEDURE INSvendedor

--DROP PROCEDURE INSvendedor
CREATE PROCEDURE INSvendedor(@Cedula char(11), @nombre varchar(30)
	,@apellido1 varchar(30),@apellido2 varchar(30),@sexo char(1),@idDistrito tinyint,@otrasSeñas varchar
	 (200), @nombreUsuario varchar(30), @constraseña varchar(20),@tipoVendedor varchar(20))
AS
BEGIN 
	DECLARE
    @ERROR INT
SET @ERROR=0
BEGIN TRAN tran1
	BEGIN TRY
   		insert into persona VALUES (@Cedula,@nombre,@apellido1,@apellido2,@sexo,@idDistrito,@otrasSeñas) 
    if @@ERROR>0
        SET @ERROR = 1
	END TRY
	 
	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH

    SAVE TRAN PERSONAS
	BEGIN TRY
		insert into vendedor VALUES (@Cedula, @nombreUsuario, @constraseña,@tipoVendedor)
    if @@ERROR>0
        SET @ERROR=2
	END TRY

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH

    if @error = 2
    BEGIN
        print ('No se pudo modificar sobre la tabla vendedores')
        ROLLBACK TRAN
    END
    ELSE
        COMMIT TRAN tran1
END





--drop procedure VISVendedores
CREATE PROCEDURE VISVendedores (@cedula char(11)) 
AS
BEGIN 
	BEGIN TRY
		select* from vendedor  v
		inner join 
		persona as p on v.cedula = p.cedula 
		where @cedula = v.cedula

	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 


--drop procedure UPDvendedor
create procedure UPDvendedor (@cedula char(11), @nombre  varchar(30), @apellido1 varchar(30), @apellido2 varchar(30), @sexo TSexo,@idDistrito tinyint, @otrasSeñas varchar(200), @NombreUsuario varchar(30), @contraseña varchar(20), @tipoVendedor varchar(20)) 
as
begin
DECLARE 
	@ERROR INT
SET @ERROR=0
begin tran tran1 
		update persona set nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2, sexo = @sexo,idDistrito= @idDistrito, otrasSeñas = @otrasSeñas    where cedula = @cedula
	if @@ERROR>0 
		SET @ERROR=1
	SAVE TRAN PERSONAS
		update vendedor set NombreUsuario = @NombreUsuario, contraseña = @contraseña, tipoVendedor = @tipoVendedor where cedula = @cedula
	if @@ERROR>0 
		SET @ERROR=2
	if @error=1
	BEGIN
		print ('No se pudo insertar sobre la tabla personas')
		ROLLBACK TRAN PERSONAS
	END
	else if @error=2
	BEGIN
		print ('No se pudo insertar sobre la tabla email')
		ROLLBACK TRAN 
	END
	else
		commit tran tran1
end



--*********************PROCEDIMIENTO PARA ELIMINAR VENDEDORES*************************



--DROP PROCEDURE DELvendedor
CREATE PROCEDURE DELvendedor (@Cedula char(11)) 
as
begin
DECLARE 
	@ERROR INT
SET @ERROR=0
BEGIN TRAN tran1 
	BEGIN TRY
		delete vendedor where cedula= @Cedula
	if @@ERROR > 0
		SET @ERROR = 1
	END TRY
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH

	SAVE TRAN VENDEDOR
	BEGIN TRY
		delete persona where cedula= @Cedula
	if @@ERROR > 0 
		SET @ERROR = 2
	END TRY
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH

	 if @error = 1
		BEGIN
			print ('No se pudo eliminar sobre la tabla venddor')
			ROLLBACK TRAN 
		END
	ELSE
		COMMIT TRAN tran1
END










--                      ___________________
--_____________________ //   CLIENTES    \\   ____________________
--                      ___________________





--*********************PROCEDIMIENTO PARA INSERTAR CLIENTES*************************

--DROP PROCEDURE INScliente
CREATE PROCEDURE INScliente (@Cedula char(11), @nombre varchar(30)
	,@apellido1 varchar(30),@apellido2 varchar(30),@sexo char(1),@idDistrito tinyint,@otrasSeñas varchar, @numCliente smallint, @tipoCliente varchar(10))
AS

BEGIN 
	DECLARE
    @ERROR INT
SET @ERROR=0
begin tran tran1
	BEGIN TRY
   		insert into persona VALUES (@Cedula,@nombre,@apellido1,@apellido2,@sexo,@idDistrito,@otrasSeñas) 
    if @@ERROR>0
        SET @ERROR=1
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede modificar el registro',1,-1)
	END CATCH
	
    SAVE TRAN PERSONAS

	BEGIN TRY
  insert into cliente VALUES (@Cedula, @numCliente, @tipoCliente)
    if @@ERROR>0
        SET @ERROR=2
	END TRY

	BEGIN CATCH
		RAISERROR(N'No se puede modificar el registro',1,-1)
	END CATCH

    if @error=1
    BEGIN
        print ('No se pudo modificar sobre la tabla personas')
        ROLLBACK TRAN PERSONAS
    END

    else if @error=2
    BEGIN
        print ('No se pudo modificar sobre la tabla vendedores')
        ROLLBACK TRAN
    END
    else
        commit tran tran1
	
END


--**********************VISTA DE CLIENTES**************************************

CREATE PROCEDURE VISClientess (@cedula char(11)) 
AS
BEGIN 
	BEGIN TRY
		select* from cliente  c 
		inner join 
		persona as p on c.cedula = p.cedula 
		where @cedula = c.cedula

	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 




--*********************PROCEDIMIENTO PARA MODIFICAR CLIENTES*************************


--drop procedure UPDcliente
create procedure UPDcliente( @cedula tinyint, @nombre  varchar(30), @apellido1 varchar(30), @apellido2 varchar(30), @sexo TSexo, @otrasSeñas varchar(200), @numCliente smallint, @tipoCliente varchar(10), @cedulaNueva TCedula) 

as
begin
DECLARE 
	@ERROR INT
SET @ERROR=0
begin tran tran1 
		update persona set nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2, sexo = @sexo, otrasSeñas = @otrasSeñas    where cedula = @cedula
	if @@ERROR>0 
		SET @ERROR=1
	SAVE TRAN PERSONAS
			update cliente set numCliente = @numCliente, tipoCliente = @tipoCliente, cedula = @cedulaNueva where cedula = @cedula
	if @@ERROR>0 
		SET @ERROR=2
	if @error=1
	BEGIN
		print ('No se pudo insertar sobre la tabla personas')
		ROLLBACK TRAN PERSONAS
	END
	else if @error=2
	BEGIN
		print ('No se pudo insertar sobre la tabla email')
		ROLLBACK TRAN 
	END
	else
		commit tran tran1
end





--*********************PROCEDIMIENTO PARA ELIMINAR CLIENTES*************************



--DROP PROCEDURE DELcliente
CREATE PROCEDURE DELcliente (@Cedula char(11)) 
as
begin
DECLARE 
	@ERROR INT
SET @ERROR=0
begin tran tran1 
	BEGIN TRY
		delete cliente where cedula= @Cedula
		if @@ERROR>0 
			SET @ERROR=1
	END TRY 
	
	BEGIN CATCH
		RAISERROR(N'No se puede modificar el registro',1,-1)
	END CATCH

	SAVE TRAN PERSONAS

	BEGIN TRY
		 delete persona where cedula= @Cedula
		if @@ERROR>0 
			SET @ERROR=2
	END TRY

	BEGIN CATCH
		RAISERROR(N'No se puede modificar el registro',1,-1)
	END CATCH

	 if @error=1
	BEGIN
		print ('No se pudo eliminar sobre la tabla venddor')
		ROLLBACK TRAN 
	END
	else
		commit tran tran1
end




--                      __________________________________________
--_____________________ //   TELEFONOS Y CORREOS DE PERSONAS    \\   ____________________
--                      __________________________________________





--*********************PROCEDIMIENTO PARA INSERTAR TELEFONOS DE PERSONAS*************************



--DROP PROCEDURE INStelPersona
CREATE PROCEDURE INStelPersona (@Cedula char(11), @telefono char(11))
AS
BEGIN 
	BEGIN TRY
		insert into TelefonoPersona VALUES (@Cedula,@telefono)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END



--*********************PROCEDIMIENTO PARA MODIFICAR TELEFONOS DE PERSONAS*************************


--drop procedure UPDTelefonoPersona
create procedure UPDTelefonoPersona (@cedula char(11), @telefono TTelefono, @nuevoTelefono TTelefono) 
as
begin
 begin try
  update TelefonoPersona set telefono = @nuevoTelefono where cedula =  @cedula and telefono = @telefono 
 end try
 begin catch
  raiserror (N'No se puede modificar el registro', 1, -1)
 end catch
end



--*********************PROCEDIMIENTO PARA ELIMINAR TELEFONOS DE PERSONAS*************************


--DROP PROCEDURE DELtelPersona
CREATE PROCEDURE DELtelPersona (@Cedula char(11),@telefono char(11)) 
AS
BEGIN 
	BEGIN TRY
		delete TelefonoPersona where cedula= @Cedula and telefono = @telefono
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 




--*********************PROCEDIMIENTO PARA INSERTAR CORREOS DE PERSONAS*************************



--DROP PROCEDURE INScorreoPersona
CREATE PROCEDURE INScorreoPersona (@Cedula char(11), @correo varchar(30))
AS
BEGIN 
	BEGIN TRY
		insert into CorreosPersona VALUES (@Cedula,@correo)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END




--*********************PROCEDIMIENTO PARA MODIFICAR CORREOS DE PERSONAS*************************


--drop procedure UPDcorreosPersona
create procedure UPDcorreosPersona (@cedula varchar(11), @correo TEmail, @correoNuevo TEmail) 
as
begin
	begin try
		update correosPersona set correo = @correoNuevo where cedula = @cedula and correo = @correo
	end try
	begin catch
		raiserror (N'No se puede modificar el registro', 1, -1)
	end catch
end




--*********************PROCEDIMIENTO PARA ELIMINAR CORREOS DE PERSONAS*************************



--DROP PROCEDURE DELcorreoPersona
CREATE PROCEDURE DELcorreoPersona (@Cedula char(11),@correo varchar(30)) 
AS
BEGIN 
	BEGIN TRY
		delete CorreosPersona where cedula= @Cedula and correo = @correo
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 







--                      _________________
--_____________________ //   FACTURAS     \\   ____________________
--                      _________________


 
--drop view VISProductosParaFactura
CREATE VIEW VISProductosParaFactura
as
	select p.codigo,p.nombre,p.precioVenta,p.stock	
	from	Producto p 
				


-- Utilizar este método para mostrar los datos del producto en caso de ser necesario
--CREATE PROCEDURE VISCodigo (@codigo int) 


--*********************PROCEDIMIENTO PARA INSERTAR FACTURAS*************************



--DROP PROCEDURE INSfactura
CREATE PROCEDURE INSfactura (@numFactura smallint,@Tipo_Fac varchar(10),@hora time,
	@fecha date,@cedulaC char(11),@cedula char(11),@montoCredito int ,@codigo tinyint , @cantidad tinyint)

as
begin
DECLARE 
	@ERROR INT,
	@monto int,
	@tipoCliente VARCHAR(10)
SET @ERROR=0
begin tran tran1 
	BEGIN TRY 
			insert into factura VALUES (@numFactura, @Tipo_Fac, @hora,@fecha,@cedulaC,@cedula,@montoCredito)
		 if @@ERROR>0 
			SET @ERROR=1
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede modificar el registro',1,-1)
	END CATCH

	SAVE TRAN PERSONAS
	
	BEGIN TRY
			set @monto = (select p.precioVenta from Producto p Where p.codigo = @codigo)*
			(@cantidad)
			set @tipoCliente = 'Deudor'

			insert Factura_Producto VALUES (@numFactura, @codigo, @monto, @cantidad)
			update Producto set stock = stock-@cantidad where @codigo = codigo
			update factura set montoCredito = montoCredito +@monto where @numFactura = numFactura

			if  @cedulaC != null
				 update cliente  set tipoCliente = @tipoCliente where @cedulaC = cedula
			

	if @@ERROR>0 
		SET @ERROR=2
	END TRY

	BEGIN CATCH
		RAISERROR(N'No se puede modificar el registro',1,-1)
	END CATCH
	
	 if @error=2
	BEGIN
		print ('No se pudo insertar sobre la tabla facturaProducto')
		ROLLBACK TRAN 
	END
	else
		commit tran tran1
end






--*********************PROCEDIMIENTO PARA MODIFICAR FACTURA*************************

--PARA MODIFICAR SE DEBE MOSTRAR TODOS LOS ELEMENTOS DE LA FACTURA
--LUEGO DESDE ESRA MISMA VENTANA SE PUEDE ELIMINAR UN PRODUCTO O AGREGAR UN PRODUCTO


--PROCEDIMIENTO PARA CAMBIAR LOS DATOS DE UNA FACTURA

--drop procedure UPDfactura
create procedure UPDfactura (@numFactura smallint, @Tipo_Fac varchar(10), @hora time, @fecha date, @cedulaC TCedula, @cedulaV TCedula ) 
as
begin
	begin try
		update factura set Tipo_Fac = @Tipo_Fac, hora = @hora, fecha = @fecha, cedulaC = @cedulaC, cedulaV = @cedulaV,montoCredito = montoCredito where numFactura = @numFactura
	end try
	begin catch
		raiserror (N'No se puede modificar el registro', 1, -1)
	end catch
end

select * from factura

--ELIMINAR PRODUCRTOS DE UNA FACTURA

--drop procedure DELFacturaProducto
create Procedure DELFacturaProducto(@numFactura smallint ,@codigo tinyint)
as
begin
DECLARE 
	@ERROR INT
SET @ERROR=0
begin tran tran1 
			update Producto set stock = stock+(select cantidad from Factura_Producto fp where  @numFactura= numFactura and @codigo = codigo) 
			update factura set montoCredito = montoCredito - (select monto from Factura_Producto fp where  @numFactura= numFactura and @codigo = codigo)
		 if @@ERROR>0 
			SET @ERROR=1

	SAVE TRAN PERSONAS
	
			delete Factura_Producto  where  @numFactura= numFactura and @codigo = codigo
	if @@ERROR>0 
		SET @ERROR=2
	
	
	 if @error=1
	BEGIN
		print ('No se pudo modificar el  el monto total de la factura y el stock del producto')
		ROLLBACK TRAN 
	END
	 if @error=2
	BEGIN
		print ('No se pudo eliminar el producto')
		ROLLBACK TRAN 
	END
	else
		commit tran tran1
end






--INSERTAR PRODUCTOS EN UNA FACTURA
--drop procedure INSERTFacturaProducto
create Procedure INSERTFacturaProducto(@numFactura smallint ,@codigo tinyint,@cantidad tinyint )
as
begin
DECLARE 
	@ERROR INT
SET @ERROR=0
begin tran tran1 
			insert Factura_Producto VALUES (@numFactura, @codigo, (select p.precioVenta from Producto p Where p.codigo = @codigo)*(@cantidad), @cantidad)
		 if @@ERROR>0 
			SET @ERROR=1

	SAVE TRAN PERSONAS
	
			update Producto set stock = stock-@cantidad where @codigo = codigo
			update factura set montoCredito = montoCredito + (select monto from Factura_Producto fp where  @numFactura= numFactura and @codigo = codigo)

	if @@ERROR>0 
		SET @ERROR=2
	
	
	 if @error=1
	BEGIN
		print ('No se pudo insertar el producto')
		ROLLBACK TRAN 
	END
	 if @error=2
	BEGIN
		print ('No se pudo modificar el monto y el stock')
		ROLLBACK TRAN 
	END
	else
		commit tran tran1
end










--*********************PROCEDIMIENTO PARA INSERTAR PAGOS*************************


--drop procedure INSpago
CREATE PROCEDURE INSpago( @numFactura smallint, @monto int, @fechaPago date)
as
begin
DECLARE 
	@ERROR INT,
	@montoCredito int 
SET @ERROR=0
begin tran tran1 
			insert into pago VALUES ( @numFactura, @monto, @fechaPago)
		 if @@ERROR>0 
			SET @ERROR=1

	SAVE TRAN PERSONAS
	
			update factura set montoCredito = montoCredito - @monto where numFactura = @numFactura

	if @@ERROR>0 
		SET @ERROR=2
	
	
	 if @error=1
	BEGIN
		print ('No se pudo insertar el pago')
		ROLLBACK TRAN 
	END
	 if @error=2
	BEGIN
		print ('No se pudo modificar la factura')
		ROLLBACK TRAN 
	END
	else
		commit tran tran1
end



--drop procedure DELpago
CREATE PROCEDURE DELfactura ( @numFactura smallint) 
AS
BEGIN 
	BEGIN TRY
		delete factura where numFactura = @numFactura 
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 

exec DELfactura 13
select * from factura

--*********************PROCEDIMIENTO PARA MODIFICAR PAGOS*************************



--drop procedure UPDpago
create procedure UPDpago (@numero tinyint, @numFactura smallint, @monto int, @fechaPago date, @numeroNuevo tinyint) 
as
begin
	begin try
		update pago set monto = @monto, fechaPago = @fechaPago where numFactura = @numFactura and numero = @numero
	end try
	begin catch
		raiserror (N'No se puede modificar el registro', 1, -1)
	end catch
end



--*********************PROCEDIMIENTO PARA ELIMINAR PAGOS*************************


--drop procedure DELpago
CREATE PROCEDURE DELpago (@numero tinyint, @numFactura smallint) 
AS
BEGIN 
	BEGIN TRY
		delete pago where numero = @numero and numFactura = @numFactura 
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 



 
--                      _________________
--_____________________ //   Proveedores     \\   ____________________
--                      _________________


--*********************PROCEDIMIENTO PARA INSERTAR PROVEEDORES*************************


--drop procedure INSproveedor
CREATE PROCEDURE INSproveedor	(@idProvedor smallint, @nombreEmpresa varchar(30), @descripcion varchar(200), @idDistrito tinyint, @otrasSeñas varchar(200))
AS
BEGIN 
	BEGIN TRY
		insert into proveedor VALUES (@idProvedor, @nombreEmpresa, @descripcion, @idDistrito, @otrasSeñas)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END


--*********************PROCEDIMIENTO PARA MODIFICAR PROVEEDORES*************************



--drop PROCEDURE UPDPProveedor
CREATE PROCEDURE UPDPProveedor (@idProveedor smallint,@nuevoidProveedor smallint, @nombreEmpresa varchar(30),@descripcion varchar(200),@idDistrito tinyint,@otrasSeñas varchar(200)) 
AS
BEGIN 
	BEGIN TRY
		 update Proveedor set idProveedor = @idProveedor,nombreEmpresa=@nombreEmpresa,descripcion=@descripcion,idDistrito=@idDistrito,otrasSeñas=@otrasSeñas
		 where idProveedor =@idProveedor
		
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede actualizar el registro',1,-1)
	END CATCH
END 





--*********************PROCEDIMIENTO PARA ELIMINAR PROVEEDORES*************************


--drop procedure DELproveedor
CREATE PROCEDURE DELproveedor (@idProvedor smallint) 
AS
BEGIN 
	BEGIN TRY
		delete Proveedor where idProveedor = @idProvedor
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 




--*********************PROCEDIMIENTO PARA INSERTAR TELEFONOS DE PROVEEDORES*************************



--drop procedure INStelefonoProveedor
CREATE PROCEDURE INStelefonoProveedor	(@idProvedor smallint, @telefono TTelefono)
AS
BEGIN 
	BEGIN TRY
		insert into TelefonoProveedor VALUES (@idProvedor, @telefono)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END


--*********************PROCEDIMIENTO PARA MODIFICAR TELEFONOS DE PROVEEDORES*************************


--drop PROCEDURE UPDtelefonoProveedor
CREATE PROCEDURE UPDtelefonoProveedor	(@idProveedor smallint, @telefono TTelefono,@nuevoTel TTelefono)
AS
BEGIN 
	BEGIN TRY
		update telefonoProveedor set telefono = @nuevoTel
		 where idProveedor =@idProveedor and telefono = @telefono
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END



--*********************PROCEDIMIENTO PARA ELIMINAR TELEFONOS DE PROVEEDORES*************************



--drop procedure DELtelefonoProveedor
CREATE PROCEDURE DELtelefonoProveedor (@idProvedor smallint, @telefono TTelefono) 
AS
BEGIN 
	BEGIN TRY
		delete TelefonoProveedor where idProveedor = @idProvedor and telefono = @telefono
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 

 
--*********************PROCEDIMIENTO PARA INSERTAR CORREOS DE PROVEEDORES*************************



--drop procedure INScorreosProveedor
CREATE PROCEDURE INScorreosProveedor	(@idProvedor smallint, @correo TEmail)
AS
BEGIN 
	BEGIN TRY
		insert into CorreosProveedor VALUES (@idProvedor, @correo)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
END



--*********************PROCEDIMIENTO PARA MODIFICAR PROVINCIAS*************************


--drop PROCEDURE UPDcorreosProveedor
CREATE PROCEDURE UPDcorreosProveedor(@idProveedor smallint, @correo TEmail ,@nuevocorreo TEmail )
AS
BEGIN 
	BEGIN TRY
		update correosProveedor set correo = @nuevocorreo 
		 where idProveedor =@idProveedor and correo  = @correo 
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END





--*********************PROCEDIMIENTO PARA ELIMINAR  CORREOS DE PROVEEDORES*************************



--drop procedure DELcorreosProveedor
CREATE PROCEDURE DELcorreosProveedor (@idProvedor smallint, @correos TEmail) 
AS
BEGIN 
	BEGIN TRY
		delete CorreosProveedor where idProveedor = @idProvedor and correo = @correos
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END 






--*********************PROCEDIMIENTO PARA INSERTAR PRODUCTOS*************************



--drop procedure INSproducto
CREATE PROCEDURE INSproducto (@codigo int, @tipoImpuesto varchar(7), @categoria varchar(30), @nombre varchar(30), @marca varchar(30),
							  @precioVenta int, @stock smallint, @familiaProducto varchar(30),@idProveedor smallint)
AS
BEGIN 
	BEGIN TRY
		insert Producto VALUES (@codigo, @tipoImpuesto, @categoria, @nombre, @marca, @precioVenta, @stock, @familiaProducto,@idProveedor)
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
END






--*********************PROCEDIMIENTO PARA MODIFICAR PRODUCTOS*************************


--drop PROCEDURE UPDProducto
CREATE PROCEDURE UPDProducto (@codigo int,@codigoNuevo int,@tipoImpuesto varchar(7), @categoria varchar(30), @nombre varchar(30), @marca varchar(30),
 @precioVenta int, @stock smallint, @familiaProducto varchar(30))
AS
BEGIN 
	BEGIN TRY
		update Producto set codigo = @codigoNuevo,tipoImpuesto =@tipoImpuesto,categoria= @categoria ,nombre= @nombre,marca= @marca,
precioVenta =  @precioVenta ,stock = @stock ,familiaProductos = @familiaProducto 
		 where codigo =@codigo
	END TRY 

	BEGIN CATCH
		RAISERROR(N'No se puede insertar el registro',1,-1)
	END CATCH
	
END


--*********************PROCEDIMIENTO PARA ELIMINAR PRODUCTOS*************************



--drop procedure DELproducto
CREATE PROCEDURE DELproducto (@codigo int) 
AS
BEGIN 
	BEGIN TRY
		delete Producto where codigo = @codigo 
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END


CREATE PROCEDURE UPDATEProductoStock (@codigo int ,@cant int) 
AS
BEGIN 
	BEGIN TRY
		update Producto  set stock = stock +@cant  where @codigo = codigo
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede eliminar el registro',1,-1)
	END CATCH
END




---------------------------------  CONSULTAS -------------------------------------------

/*_________________________________________________________________________________________
_______________________ CONSULTA DE PRODUCTOS ----> VENDEDOR_______________________________*
___________________________________________________________________________________________*
*/




 --****************************************************
 --MUESTRA TODOS LOS PRODUCTOS DE ACUERDO A UN NOMBRE *
 --****************************************************
 
CREATE PROCEDURE VISProductosNombre (@nombreProducto varchar(30)) 
AS
BEGIN 
	BEGIN TRY
		select *from  Producto p  where @nombreProducto = p.nombre 

	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 

 --***********************************************************
 --MUESTRA TODOS LOS PRODUCTOS DE ACUERDO A UN NOMBRE Y MARCA*
 --***********************************************************

CREATE PROCEDURE VISProductosNombreMarca (@nombreProducto varchar(30),@marca varchar(30)) 
AS
BEGIN 
	BEGIN TRY
		select *from  Producto p  where @nombreProducto = p.nombre and @marca = p.marca

	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 

 --****************************************************************
 --MUESTRA TODOS LOS PRODUCTOS DE ACUERDO A LA FAMILA DE PRODUCTOS*
 --****************************************************************

CREATE PROCEDURE VISProductosFamilia (@Familia varchar(30)) 
AS
BEGIN 
	BEGIN TRY
		select *from  Producto p  where @Familia = p.familiaProductos 

	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 


 --***********************************************************
 --MUESTRA UN PRODUCTO ESPECÍFICO DE ACUERDO A UN CÓDIGO     *
 --***********************************************************


CREATE PROCEDURE VISCodigo (@codigo int) 
AS
BEGIN 
	BEGIN TRY
		select *from  Producto p  where @codigo = p.codigo

	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 


 --*******************************************************
 --MUESTRA TODOS LOS PRODUCTOS DE ACUERDO A UN PROVEEDOR *
 --*******************************************************


CREATE PROCEDURE VISProductoProveedor (@idProoveedor int) 
AS
BEGIN 
	BEGIN TRY
		select pro.nombreEmpresa,p.marca,p.nombre,p.stock  from Proveedor pro
		inner join Producto p
		on pro.idProveedor = @idProoveedor
		group by pro.nombreEmpresa,p.marca,p.nombre,p.stock
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 

exec  VISProductoProveedor 13



/*_________________________________________________________________________________________
_______________________ INFORMES DE VENTAS ----> ADMINISTRADOR ____________________________*
___________________________________________________________________________________________*
*/

 --************************************************************************************
 --MUESTRA UN INFORME DE LOS PRODUCTOS VENDIDOS POR DIA DE ACUERDO A LA FORMA DE PAGO *
 --************************************************************************************


 --DROP PROCEDURE VISProVendidosDiaFormaDePago
CREATE PROCEDURE VISProVendidosDiaFormaDePago (@dia date,@formaDePago varchar(10)) 
AS
BEGIN 
	BEGIN TRY
		select f.fecha,p.nombre,p.codigo,fp.cantidad,p.marca,p.stock from factura f 
		inner join Factura_Producto fp on f.numFactura = fp.numFactura and f.fecha = @dia and @formaDePago= f.Tipo_Fac
		and f.fecha = @dia
		inner join Producto p on p.codigo = fp.codigo  
		group by  f.fecha,p.nombre,p.codigo,fp.cantidad,p.marca,p.stock
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 




 --************************************************************************************
 --MUESTRA UN INFORME DE LOS PRODUCTOS VENDIDOS POR DIA DE ACUERDO AL VENDEDOR        *
 --************************************************************************************


--DROP PROCEDURE VISProVendidosDiaVendedor
CREATE PROCEDURE VISProVendidosDiaVendedor (@dia date,@idVendedor char(11)) 
AS
BEGIN 
	BEGIN TRY
		select f.fecha,per.Nombre +' '+per.apellido1+' '+per.apellido2 as [Nombre completo],p.nombre,p.codigo,fp.cantidad ,p.marca,p.stock  from factura f 
		inner join Factura_Producto fp on f.numFactura = fp.numFactura and f.fecha = @dia 
		and f.cedulaV = @idVendedor
		inner join Producto p on p.codigo = fp.codigo  
		inner join vendedor ven on ven.cedula = f.cedulaV
		inner join persona per on ven.cedula = per.cedula
		group by  f.fecha,per.Nombre,per.apellido1,per.apellido2,p.nombre,fp.cantidad,p.codigo,p.marca,p.stock
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 



 --********************************************************************************************
 --MUESTRA UN INFORME DE LOS PRODUCTOS VENDIDOS POR DIA DE ACUERDO LA FAMILIA DE PRODUCTOS    *
 --********************************************************************************************


--Drop PROCEDURE VISProVendidosDiaFamiliaProductos
CREATE PROCEDURE VISProVendidosDiaFamiliaProductos (@dia date,@familiaPro varchar(10)) 
AS
BEGIN 
	BEGIN TRY
		select f.fecha,p.nombre,p.codigo,fp.cantidad,p.familiaProductos,p.stock  from factura f 
		inner join Factura_Producto fp on f.numFactura = fp.numFactura and f.fecha = @dia 
		inner join Producto p on p.codigo = fp.codigo and p.familiaProductos = @familiaPro
		group by  f.fecha,p.nombre,p.codigo,fp.cantidad,p.familiaProductos,p.stock 
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 




--------------------------- OTRAS CONSULTAS ----------------------------------------------------


--Drop  PROCEDURE VISPagosCreditoporClientec
CREATE PROCEDURE VISPagosCreditoporClientec (@cedula char(11)) 
AS
BEGIN 
	BEGIN TRY
		select per.cedula, per.Nombre +' '+per.apellido1+' '+per.apellido2 as [Nombre completo],p.numFactura,p.numero,p.monto,
		f.montoCredito as [Saldo],sum(fp.monto) as [Monto total de la compra] from cliente c 
		inner join persona per on per.cedula = c.cedula
		inner join factura f on c.cedula = f.cedulaC
		inner join pago p on f.numFactura = p.numFactura
		inner join Factura_Producto fp on fp.numFactura = f.numFactura
		group by  per.cedula, per.Nombre,per.apellido1,per.apellido2,p.numFactura,p.numero,p.monto,f.montoCredito
	END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 


--************************PROCEDIMIENTO PARA VER LAS GANANCIAS POR DIA************************************

CREATE PROCEDURE VISGananciaPorDia(@dia date)
AS
BEGIN 
	BEGIN TRY
	 select SUM(fp.monto) from factura f 
	 inner join Factura_Producto fp on f.numFactura =fp.numFactura and f.fecha = @dia

	 END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 

--************************ PROCEDIMIENTO PARA VER LAS GANANCIAS POR DIA Y FORMA DE PAGO ************************************

CREATE PROCEDURE VISGananciaPorDiaYTipoFac(@dia date,@TipoPago varchar(10))
AS
BEGIN 
	BEGIN TRY
	 select SUM(fp.monto) from factura f 
	 inner join Factura_Producto fp on f.numFactura =fp.numFactura 
	 and f.fecha = @dia and f.Tipo_Fac = @TipoPago

	 END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 

--************************PROCEDIMIENTO PARA VER LOS PAGOS REALIZADOS EN UN DIA************************************

CREATE PROCEDURE VISPagosRealizadosDia(@dia date)
AS
BEGIN 
	BEGIN TRY
	 select p.numFactura,p.numero,p.monto,p.numero,per.Nombre+' '+per.apellido1,+' '+per.apellido2  from factura f 
	 inner join pago p on p.numFactura = f.numFactura and @dia= f.fecha
	 inner join cliente c on f.cedulaC = c.cedula
	 inner join persona per on per.cedula = c.cedula

	 END TRY 
	BEGIN CATCH
		RAISERROR(N'No se puede ver el registro',1,-1)
	END CATCH
END 



----------------------------------------- Vistas ----------------------------------------------------

--drop view ViewTodasLasFacturas

create view ViewTodasLasFacturas 
as
	select f.numFactura,f.Tipo_Fac,f.fecha,f.hora, sum(fp.monto)as[Monto total],SUM(fp.cantidad) as [Cantidad de productos] from factura f inner join 
	 Factura_Producto fp  on f.numFactura = fp.numFactura 
	inner join Producto pro on pro.codigo = fp.codigo 
	group by f.numFactura,f.Tipo_Fac,f.fecha,f.hora
			




create view ViewFacturasCredito 
as
	select f.numFactura,f.Tipo_Fac,f.fecha,f.hora,f.cedulaC,per.Nombre+' '+per.apellido1+' '+per.apellido2 as [Nombre cliente],sum(fp.monto)as[Monto total],f.montoCredito as [Monto por pagar],SUM(fp.cantidad) as [Cantidad de productos] from factura f inner join 
	 Factura_Producto fp  on f.numFactura = fp.numFactura and f.Tipo_Fac ='Crédito'
	inner join Producto pro on pro.codigo = fp.codigo 
	inner join cliente c on c.cedula = f.cedulaC
	inner join persona per on per.cedula = c.cedula
	group by f.numFactura,f.Tipo_Fac,f.fecha,f.hora,f.cedulaC,per.Nombre,per.apellido1,per.apellido2,f.montoCredito



create view ViewFacturasContado 
as
	select f.numFactura,f.Tipo_Fac,f.fecha,f.hora, sum(fp.monto)as[Monto total],SUM(fp.cantidad) as [Cantidad de productos] from factura f inner join 
	 Factura_Producto fp  on f.numFactura = fp.numFactura and f.Tipo_Fac ='Contado'
	inner join Producto pro on pro.codigo = fp.codigo 
	group by f.numFactura,f.Tipo_Fac,f.fecha,f.hora


create view ViewFacturaPagos
	as
	select f.cedulaC,per.Nombre+' '+per.apellido1+' '+per.apellido2 as [Nombre cliente],f.numFactura,pa.numero,pa.monto,fechaPago as [Fecha de pago] from factura f inner join 
	 Factura_Producto fp  on f.numFactura = fp.numFactura and f.Tipo_Fac ='Crédito'
	inner join Producto pro on pro.codigo = fp.codigo 
	inner join cliente c on c.cedula = f.cedulaC
	inner join persona per on per.cedula = c.cedula
	inner join pago pa on pa.numFactura = f.numFactura 
	group by f.cedulaC,per.Nombre, per.apellido1,per.apellido2,f.numFactura,pa.numero,pa.monto,fechaPago


create view ViewStock
	as
	select codigo,nombre,marca,categoria,precioVenta,stock,stock*precioVenta as [Ganancia total] from Producto 

create view ViewInfoProveedores 
	as
			select  pv.idProveedor,pv.nombreEmpresa,corr.correo,tel.telefono,d.nombreD,can.nombreCanton,pro.nombreP from
		Proveedor pv  
			left join (select top 1 cp.correo,cp.idProveedor from CorreosProveedor cp 
			) as corr on corr.idProveedor = pv.idProveedor
			left join (select top 1 tel.telefono,tel.idProveedor from TelefonoProveedor tel
			) as tel on tel.idProveedor = pv.idProveedor
		inner join distrito d on d.idDistrito = pv.idDistrito
		inner join Canton can on can.idCanton = d.idCanton
		inner join Provincia pro on pro.idProvincia = can.idProvincia 
			

--__________________________________ TRIGERS _____________________________________

--drop trigger MaxProvincias
go
create trigger MaxProvincias
on provincia
for insert
as
    declare
        @cantProv    FLOAT,
        @idProvincia    tinyint
    select @idProvincia=idProvincia from inserted
    SELECT @cantProv = COUNT (idProvincia) from provincia 
    if @cantProv>7
    begin
        Print ('No se permiten más de 7 provincias')
        rollback tran
    end



go
create trigger verficarPagos
on pago
for insert as
if(select  monto from  inserted i
        inner join factura f on i.numFactura= f.numFactura ) >(
		select  montoCredito from  inserted i
        inner join factura f on i.numFactura= f.numFactura )
begin
    Print 'La capacidad por pagar es menor'
    rollback tran
end


go
create trigger verificarFacturaProducto
on Factura_Producto
for insert as
if(select cantidad from inserted i
	inner join Producto p on p.codigo = i.codigo)>
	(select stock from inserted i
	inner join Producto p on p.codigo = i.codigo)
begin
    Print 'No hay productos suficientes'
    rollback tran
end



--CURSORES


go
create function recortaCompleta(@cadena varchar(100), @largo int) 
returns varchar (100)
as
begin
	SET @cadena = ISNULL(@cadena,'');
	SET @cadena=SUBSTRING(@cadena,0,@largo+1);
	SET @cadena=@cadena+SPACE(@largo-LEN(@cadena));
	return(@cadena);
end;

go
set nocount on --para quitar cosas de la consola
DECLARE 
	@Numfactura		SMALLINT, 
	@Tipo_Fact		VARCHAR(10), 
    @fecha			DATE ,
	@MontoCre		int,
	@CedulaC		VARCHAR(11),
	@NombreCompleto VARCHAR(50),
	@Mensaje		VARCHAR(200);
	

PRINT '---------------------------REPORTE  DE DEUDORES-----------------------------------';
PRINT '------------------------------------------------------------------------------------';
DECLARE Facturas_cursor CURSOR 
FOR 
	SELECT f.numFactura,f.Tipo_Fac,f.fecha,f.montoCredito,f.cedulaC 
	FROM factura f where f.Tipo_Fac = 'Crédito' and f.montoCredito >0


OPEN Facturas_cursor
FETCH NEXT FROM Facturas_cursor INTO @Numfactura, @Tipo_Fact, @fecha,@MontoCre,@CedulaC

Print '#FACTURA  F.PAGO        FECHA      MONTO     CEDULA    NOMBRE COMPLETO ';
Print '--------  ----------  --------     ------    --------  ----------------';
WHILE @@FETCH_STATUS = 0
BEGIN
	

	SELECT @NombreCompleto=p.Nombre+' '+p.apellido1+' '+p.apellido2 FROM persona p 
	inner join factura f on p.cedula = @CedulaC  

	set @NombreCompleto=(select dbo.recortaCompleta(@NombreCompleto, 25));
	SET @Mensaje = '   '+CAST(@Numfactura AS VARCHAR)+'     '+@Tipo_Fact+'    '+ CAST(@fecha AS VARCHAR)+'   '+ CAST(@MontoCre  AS VARCHAR)+'    '+@CedulaC+'   '+@NombreCompleto;
	PRINT @Mensaje;
	FETCH NEXT FROM Facturas_cursor 
	INTO @Numfactura, @Tipo_Fact, @fecha,@MontoCre,@CedulaC
END

CLOSE Facturas_cursor;
DEALLOCATE Facturas_cursor;






go
DECLARE 
	@Cedula char(11),
	@NombreCompleto varchar(30),
	@Sexo char(1),
	@Distrito varchar(30),
	@Canton varchar(30),
	@Provincia varchar (30),
	@email varchar(30),
	@telefono char(11),
	@Mensaje varchar(400)

PRINT '---------------------------REPORTE  DE CLIENTES-------------------------------------';
PRINT '------------------------------------------------------------------------------------';
DECLARE InformeClientes CURSOR 
FOR 
	SELECT p.cedula,p.Nombre+' '+p.apellido1+' '+p.apellido2 as [Nombre completo],p.sexo,d.nombreD,ca.nombreCanton,pro.nombreP
	FROM cliente c inner join persona p on c.cedula = p.cedula
	inner join distrito d on p.idDistrito = d.idDistrito
	inner join Canton ca on ca.idCanton = d.idCanton
	inner join Provincia pro on pro.idProvincia = ca.idProvincia


OPEN InformeClientes
FETCH NEXT FROM InformeClientes INTO @Cedula, @NombreCompleto, @Sexo,@Distrito,@Canton,@Provincia

Print '#CEDULA     NOMBRE COMPLETO       SEXO      DISTRITO     CANTON    PROVINCIA   TELEFONO        CORREO';
Print '--------  ------------------      ------    --------    --------    --------   --------        -------';
WHILE @@FETCH_STATUS = 0
BEGIN
	SET @email='';
	SET @telefono='';

	SELECT top 1 @email= correo FROM CorreosPersona cp where cp.cedula=@Cedula
	SELECT top 1 @telefono=telefono FROM TelefonoPersona tp where tp.cedula=@Cedula
	
	set @cedula=(select dbo.recortaCompleta(@Cedula, 11));
	set @NombreCompleto=(select dbo.recortaCompleta(@NombreCompleto, 20));
	set @telefono=(select dbo.recortaCompleta(@telefono, 11));
	set @Distrito=(select dbo.recortaCompleta(@Distrito, 11));
	set @Canton=(select dbo.recortaCompleta(@Canton, 11));
	set @Provincia=(select dbo.recortaCompleta(@Provincia, 11));
	set @email=(select dbo.recortaCompleta(@email, 30));

	SET @Mensaje = @Cedula+'  '+ @NombreCompleto+'  '+@Sexo+'      '+@Distrito+'  '+@Canton+'  '+@Provincia+'  '+@telefono+'  '+@email;

	PRINT @Mensaje;

	FETCH NEXT FROM InformeClientes 
	INTO @Cedula, @NombreCompleto, @Sexo,@Distrito,@Canton,@Provincia

END

CLOSE InformeClientes;
DEALLOCATE InformeClientes;










	-----DATOS DE PRUEBA

--  PROVINCIAS CANTONES Y DISTRITOS

EXEC INSprovincia 1,'San José'
EXEC INSprovincia 2,'Alajuela'
EXEC INSprovincia 3,'Cartago'
EXEC INSprovincia 4,'Heredia'
EXEC INSprovincia 5,'Guanacaste'
EXEC INSprovincia 6,'Puntarenas'
EXEC INSprovincia 7,'Limón'

EXEC INScanton 1,'Moravia'
EXEC INScanton 2,'	San Carlos'
EXEC INScanton 2,'	San Ramón'

delete distrito
EXEC INSdistrito 1,'Cruz Azul'
EXEC INSdistrito 2,'Peñas Blancas'
EXEC INSdistrito 1,'Florencia'
EXEC INSdistrito 2,'San Clara'


select * from  Provincia
select * from  Canton
select * from  distrito


-- VENDEDORES

EXEC INSvendedor '2-0740-0727','Hellen','Rojas','Rojas','F', 8,'bla bla vlkdgjoi', 'hellen', '1234', 'Vendedor'  
EXEC INSvendedor '2-0840-0727','Hellen','Rojas','Rojas','F', 8,'bla bla vlkdgjoi', 'edsaf', '1234', 'Vendedor'  
EXEC INSvendedor '2-0640-0727','Hellen','Rojas','Rojas','F', 8,'bla bla vlkdgjoi', 'HDRIKR', '1234', 'Vendedor'  
EXEC INSvendedor '2-0642-0727','Mari','Rojas','Rojas','F', 8,'bla bla vlkdgjoi', 'KIUHER', '1234', 'Vendedor'  
EXEC INSvendedor '2-0623-0727','Pablo','Rojas','Rojas','F',8,'bla bla vlkdgjoi', 'IJRT', '1234', 'Vendedor'  
EXEC INSvendedor '2-0624-0727','Manuel','Rojas','Rojas','M',8,'bla bla vlkdgjoi', 'DIRHG', '1234', 'Vendedor'  


select * from vendedor v inner join persona p on p.cedula = v.cedula
select * from cliente v  inner join persona p on p.cedula = v.cedula

--CORREOS Y TELEFONOS DE VENDEDORES

EXEC INScorreoPersona '2-0740-0727','Gabriel@gmail.com'
EXEC INScorreoPersona '2-0624-0727','karisi@gmail.com'


EXEC INStelPersona '2-0740-0727','45-62-65-67'
EXEC INStelPersona '2-0624-0727','12-32-45-67'


--exec DELvendedor '2-0624-0727'

select * from CorreosPersona
select * from TelefonoPersona

-- CLIENTES

EXEC INScliente '2-0624-0727','Manuel','Rojas','Rojas','M',8,'bla bla vlkdgjoi',230,'NoDeudor'
EXEC INScliente '2-0443-0727','Marí','Lopez','Rojas','M',8,'bla bla vlkdgjoi',230,'NoDeudor'
EXEC INScliente '2-0623-0727','Nano','Rojas','Rojas','M',8,'bla bla vlkdgjoi',230,'NoDeudor'


select * from cliente c inner join persona p on p.cedula = c.cedula

-- PROVEEDORES

EXEC INSproveedor 13, 'Lunas', 'Bla bla bla',8,'bla bla bla'
EXEC INSproveedor 14, 'Soles', 'Bla bla bla',8,'bla bla bla'
EXEC INSproveedor 15, 'Luisiana', 'Bla bla bla',8,'bla bla bla'

--CORREOS Y TELEFONOS PROVEEDOR

EXEC INStelefonoProveedor 13,'12-32-25-67'
EXEC INStelefonoProveedor 14,'12-36-35-67'
EXEC INStelefonoProveedor 15,'11-33-27-87'


EXEC INScorreosProveedor 13,'erf@gmail.com'
EXEC INScorreosProveedor 14,'we@gmail.com'
EXEC INScorreosProveedor 15,'rw@gmail.com'

delete CorreosProveedor

select * from Proveedor
select * from CorreosProveedor
select * from TelefonoProveedor

--EXEC DELproveedor 15

-- PRODUCTOS

EXEC INSproducto 12, 'Grabado','bla bla bla', 'arroz','Tio pelón',1200,34,'dfc',13
EXEC INSproducto 13, 'Grabado','bla bla bla', 'frijles','Tio pelón',1000,34,'dfc',13
EXEC INSproducto 14, 'Grabado','bla bla bla', 'azucar','MM',600,34,'dfc',13
EXEC INSproducto 15, 'Grabado','bla bla bla', 'sal','Tio pelón',12000,34,'dfc',13
EXEC INSproducto 16, 'Grabado','bla bla bla', 'aceite','MM',12000,34,'dfc',13

--FACTURAS
delete factura
EXEC INSfactura 13,'Crédito','23:59:59', '2013-10-13','2-0623-0727','2-0740-0727',0,15,2
EXEC INSfactura 13,'Crédito','23:59:59', '2013-10-13','2-0623-0727','2-0740-0727',0,16,2
EXEC INSfactura 13,'Crédito','23:59:59', '2013-10-13','2-0623-0727','2-0740-0727',0,12,2
EXEC INSfactura 13,'Crédito','23:59:59', '2013-10-13','2-0623-0727','2-0740-0727',0,13,2
EXEC INSfactura 13,'Crédito','23:59:59', '2013-10-13','2-0623-0727','2-0740-0727',0,14,2

EXEC INSfactura 14,'Contado','23:59:59', '2013-10-13',null,'2-0740-0727',0,15,2
EXEC INSfactura 15,'Contado','23:59:59', '2013-10-13',null,'2-0740-0727',0,14,2

EXEC INSfactura 17,'Crédito','23:59:59', '2013-10-13','2-0443-0727','2-0740-0727',0,14,2

select * FROM factura

delete Producto

--PAGOS

EXEC INSpago 15,200,'2013-10-12'
EXEC INSpago 13,800,'2013-10-12'

EXEC INSpago 17,800,'2013-10-12'
EXEC INSpago 17,200,'2013-10-12'

select * from factura
select * from Factura_Producto
select * from factura f inner join persona p on p.cedula = f.cedulaC
select * from factura f inner join pago p on p.numFactura = f.numFactura


--CONSULTAS

exec  VISProVendidosDiaFormaDePago '2013-10-13','Contado'
EXEC  VISProVendidosDiaVendedor '2013-10-13','2-0740-0727'
exec VISPagosCreditoporClientec '2-0623-0727'
EXEC VISGananciaPorDia '2013-10-12'

exec VISInfoProveedoresIdProveedor 12

select * from Provincia
select * from Canton
select * from distrito
select * from persona
select * from TelefonoPersona
select * from CorreosPersona
select * from cliente
select * from vendedor
select * from factura
select * from pago
select * from Proveedor
select * from TelefonoProveedor
select * from CorreosProveedor
select * from Producto
select * from Factura_Producto



