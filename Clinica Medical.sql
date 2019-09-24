CREATE DATABASE CLINICA_TOLOZA
GO
USE CLINICA_TOLOZA
GO
CREATE TABLE PROVINCIA(
IDPROVINCIA INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL
)
GO
CREATE TABLE LOCALIDAD(
IDLOCALIDAD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL,
IDPROVINCIA INT FOREIGN KEY REFERENCES PROVINCIA(IDPROVINCIA)
)
GO
CREATE TABLE ALERGIA(
ID_ALERGIA INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL
) 
GO
CREATE TABLE MEDICAMENTO(
ID_MEDICAMENTO INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL
)
GO

CREATE TABLE ESTADO(
ID_ESTADO INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL
)
GO
CREATE TABLE ESPECIALIDAD(
ID_ESPECIALIDAD INT IDENTITY(1,1)NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL
)
GO
CREATE TABLE CATEGORIA(
ID_CATEGORIA INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL
)
GO
CREATE TABLE GRUPO_SANGUINEO(
ID_GRUPO_SANGUINEO INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(5)
)
GO
CREATE TABLE EMPLEADO(
ID_EMPLEADO INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_CATEGORIA INT FOREIGN KEY REFERENCES CATEGORIA(ID_CATEGORIA),
NOMBRE VARCHAR(50) NOT NULL,
APELLIDO VARCHAR(50) NOT NULL,
DNI VARCHAR(20) NOT NULL,
FECHA_NAC DATE NOT NULL,
DIRECCION VARCHAR(50) NOT NULL,
IDLOCALIDAD INT FOREIGN KEY REFERENCES LOCALIDAD(IDLOCALIDAD),
TELEFONO VARCHAR(20)NOT NULL,
EMAIL VARCHAR(30) NULL,
SEXO BIT NOT NULL,
ELIMINADO BIT NOT NULL
)
GO
CREATE TABLE HORA_IE(
ID_HORARIO INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_EMPLEADO INT FOREIGN KEY REFERENCES EMPLEADO(ID_EMPLEADO),
HORA_DESDE TIME NOT NULL,
HORA_HASTA TIME NOT NULL,
DIAS VARCHAR(10) NOT NULL
)
GO
CREATE TABLE PACIENTE(
ID_PACIENTE INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL,
APELLIDO VARCHAR(50) NOT NULL,
DNI VARCHAR(20) NOT NULL,
FECHA_NAC DATE NOT NULL,
DIRECCION VARCHAR(50) NOT NULL,
IDLOCALIDAD INT FOREIGN KEY REFERENCES LOCALIDAD(IDLOCALIDAD),
TELEFONO VARCHAR(20)NOT NULL,
EMAIL VARCHAR(30) NULL,
SEXO BIT NOT NULL,
OBS VARCHAR(160) NULL,
ID_EMPLEADO INT FOREIGN KEY REFERENCES EMPLEADO(ID_EMPLEADO),
ELIMINADO BIT NOT NULL
)
GO
CREATE TABLE USUARIO(
ID_USUARIO INT IDENTITY(1,1)NOT NULL PRIMARY KEY,
NOMBRE_USUARIO VARCHAR(50) NOT NULL,
CONTRASE�A VARCHAR(50) NOT NULL,
ID_EMPLEADO INT FOREIGN KEY REFERENCES EMPLEADO(ID_EMPLEADO),
ELIMINADO BIT NOT NULL
)
GO
CREATE TABLE TURNO(
ID_TURNO INT IDENTITY(1,1)NOT NULL PRIMARY KEY,
ID_PACIENTE INT FOREIGN KEY REFERENCES PACIENTE(ID_PACIENTE),
FECHA DATE NOT NULL,
HORA TIME NOT NULL,
ID_EMPLEADO INT FOREIGN KEY REFERENCES EMPLEADO(ID_EMPLEADO),
ID_MEDICO INT NOT NULL,
ID_ESTADO INT FOREIGN KEY REFERENCES ESTADO(ID_ESTADO),
OBSERVACION VARCHAR(200) NOT NULL,
ELIMINADO BIT NOT NULL
)
GO

CREATE TABLE ANTECEDENTE(
ID_ANTECEDENTE INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_PACIENTE INT NOT NULL FOREIGN KEY REFERENCES PACIENTE(ID_PACIENTE),
ID_GRUPO_S INT FOREIGN KEY REFERENCES GRUPO_SANGUINEO(ID_GRUPO_SANGUINEO),
PESO DECIMAL NULL,
ALTURA DECIMAL NULL
)

GO
CREATE TABLE HISTORIAL(
ID_HISTORIAL INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_PACIENTE INT FOREIGN KEY REFERENCES PACIENTE(ID_PACIENTE),
ID_EMPLEADO INT FOREIGN KEY REFERENCES EMPLEADO(ID_EMPLEADO),
MOTIVO VARCHAR (200) NULL,
DIAGNOSTICO VARCHAR (200) NOT NULL,
)
GO
CREATE TABLE ALERGIA_X_PACIENTE(
ID_ALERGIA_X_PACIENTE INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_PACIENTE INT FOREIGN KEY REFERENCES PACIENTE(ID_PACIENTE),
ID_ALERGIA INT FOREIGN KEY REFERENCES ALERGIA(ID_ALERGIA),
ElIMINADO BIT
)
GO
CREATE TABLE MEDICAMENTO_X_PACIENTE(
ID_MEDICAMENTO_X_PACIENTE INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_PACIENTE INT FOREIGN KEY REFERENCES PACIENTE(ID_PACIENTE),
ID_MEDICAMENTO INT FOREIGN KEY REFERENCES MEDICAMENTO(ID_MEDICAMENTO),
ElIMINADO BIT
)
GO

CREATE TABLE ESPECIALIDAD_X_M(
ID_ESPECIALIDAD_X_M INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_EMPLEADO INT FOREIGN KEY REFERENCES EMPLEADO(ID_EMPLEADO),
ID_ESPECIALIDAD INT FOREIGN KEY REFERENCES ESPECIALIDAD(ID_ESPECIALIDAD),
ElIMINADO BIT
)
GO
CREATE TABLE HISTORIAL_X_PACIENTE(
ID_HISTORIAL_X_P INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
ID_HISTORIAL INT FOREIGN KEY REFERENCES HISTORIAL(ID_HISTORIAL),
ID_TURNO INT FOREIGN KEY REFERENCES TURNO(ID_TURNO),
FECHA_DE_CONSULTA DATE NOT NULL, 
)


--PROVINCIAS
INSERT INTO PROVINCIA (NOMBRE) VALUES ('-Seleccione-')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('BUENOS AIRES')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('CATAMARCA')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('CHACO')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('CHUBUT')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('CORDOBA')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('CORRIENTES')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('ENTRE RIOS')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('FORMOSA')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('JUJUY')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('LA PAMPA')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('LA RIOJA')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('MENDOZA')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('MISIONES')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('NEUQUEN')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('RIO NEGRO')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('SALTA')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('SAN JUAN')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('SAN LUIS')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('SANTA CRUZ')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('SANTA FE')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('SANTIAGO DEL ESTERO')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('TIERRA DEL FUEGO')
INSERT INTO PROVINCIA (NOMBRE) VALUES ('TUCUMAN')

INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('-Seleccione-',1)

--LOCALIDADES BUENOS AIRES
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('AGUAS VERDES',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('ARENAS VERDES',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('ARRECIFES',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('AYACUCHO',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('AZUL',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BAHIA BLANCA',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BAHIA SAN BLAS',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BALCARCE',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BARADERO',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BELGRANO',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BENITO JUAREZ',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BERISSO',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BOLIVAR',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BRAGADO',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('BRANDSEN',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('CAMPANA',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('CA�UELAS',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('CAPILLA DEL SE�OR',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('CAPITAN SARMIENTO',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('CARHUE',2)
INSERT INTO LOCALIDAD (NOMBRE,IDPROVINCIA)VALUES ('TIGRE',2)

--CATEGORIA
INSERT INTO CATEGORIA(NOMBRE)VALUES('-Seleccione-')
INSERT INTO CATEGORIA(NOMBRE)VALUES('Administrador')
INSERT INTO CATEGORIA(NOMBRE)VALUES('Recepcionista')
INSERT INTO CATEGORIA(NOMBRE)VALUES('Medico')

--ESPECIALIDAD
INSERT INTO ESPECIALIDAD(NOMBRE)VALUES('-Seleccione-')
INSERT INTO ESPECIALIDAD(NOMBRE)VALUES('GINECOLOGO')
INSERT INTO ESPECIALIDAD(NOMBRE)VALUES('UROLOGO')
INSERT INTO ESPECIALIDAD(NOMBRE)VALUES('PEDIATRIA')

--GRUPO SANGUINEO
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('---')
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('A+')
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('A-')
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('B+')
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('B-')
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('AB+')
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('AB-')
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('O+')
INSERT INTO GRUPO_SANGUINEO(NOMBRE)VALUES('O-')
--ALERGIA
INSERT INTO ALERGIA(NOMBRE)VALUES('-Seleccione-')
--MEDICAMENTO
INSERT INTO MEDICAMENTO(NOMBRE)VALUES('-Seleccione-')
--ESTADO
INSERT INTO ESTADO(NOMBRE)VALUES('ALTA')
--EMPLEADO
INSERT INTO EMPLEADO(ID_CATEGORIA,NOMBRE,APELLIDO,DNI,FECHA_NAC,DIRECCION,IDLOCALIDAD,TELEFONO,EMAIL,SEXO,ELIMINADO)VALUES(2,'Julio','Toloza','18889417','10/06/1991','Derqui 418',22,'1568603345','jtoloza@hotmail.com',1,0)
INSERT INTO EMPLEADO(ID_CATEGORIA,NOMBRE,APELLIDO,DNI,FECHA_NAC,DIRECCION,IDLOCALIDAD,TELEFONO,EMAIL,SEXO,ELIMINADO)VALUES(4,'Rafael','Toloza','43423423','09/06/1981','Cazon 3233',22,'153242343','gfgdrds@hotmail.com',1,0)
INSERT INTO EMPLEADO(ID_CATEGORIA,NOMBRE,APELLIDO,DNI,FECHA_NAC,DIRECCION,IDLOCALIDAD,TELEFONO,EMAIL,SEXO,ELIMINADO)VALUES(3,'Marilina','Perez','2131231','10/08/1990','calle 333',22,'33333333','',0,0)
--USUARIO

INSERT INTO USUARIO(NOMBRE_USUARIO,CONTRASE�A,ID_EMPLEADO,ELIMINADO)VALUES('ADMIN','ADMIN',1,0)
INSERT INTO USUARIO(NOMBRE_USUARIO,CONTRASE�A,ID_EMPLEADO,ELIMINADO)VALUES('ADMIN2','ADMIN2',2,0)
--PACIENTE
INSERT INTO PACIENTE(NOMBRE,APELLIDO,DNI,FECHA_NAC,DIRECCION,IDLOCALIDAD,TELEFONO,EMAIL,SEXO,OBS,ID_EMPLEADO,ELIMINADO)VALUES('Homero','Simpson','19.545.343','23/02/1987','Calle Falsa 123',22,'(15)-3423-2343','',1,'',1,0)
--AGREGAR_PACIENTE
insert into ESPECIALIDAD_X_M (ID_EMPLEADO,ID_ESPECIALIDAD)values(2,4)

insert into HORA_IE(ID_EMPLEADO,HORA_DESDE,HORA_HASTA,DIAS)values(2,'9:00','12:00','Lunes')
insert into HORA_IE(ID_EMPLEADO,HORA_DESDE,HORA_HASTA,DIAS)values(2,'9:00','12:00','Miercoles')
insert into HORA_IE(ID_EMPLEADO,HORA_DESDE,HORA_HASTA,DIAS)values(2,'9:00','12:00','viernes')

go

create PROCEDURE SP_AGREGAR_PACIENTE
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@DNI VARCHAR(20),
@FECHA_NAC DATE,
@DIRECCION VARCHAR(50),
@IDLOCALIDAD INT,
@TELEFONO VARCHAR(20),
@EMAIL VARCHAR(30),
@SEXO BIT,
@OBS VARCHAR(160),
@ID_EMPLEADO INT,
@ELIMINADO BIT
AS
BEGIN
INSERT INTO PACIENTE(NOMBRE,APELLIDO,DNI,FECHA_NAC,DIRECCION,IDLOCALIDAD,TELEFONO,EMAIL,SEXO,OBS,ID_EMPLEADO,ELIMINADO)VALUES(@NOMBRE,@APELLIDO,@DNI,@FECHA_NAC,@DIRECCION,@IDLOCALIDAD,@TELEFONO,@EMAIL,@SEXO,@OBS,@ID_EMPLEADO,@ELIMINADO)
select * from PACIENTE where DNI=@DNI
END
--MODIFICAR
GO
CREATE PROCEDURE SP_MODIFICAR_PACIENTE
@ID_PACIENTE INT,
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@DNI VARCHAR(20),
@FECHA_NAC DATE,
@DIRECCION VARCHAR(50),
@IDLOCALIDAD INT,
@TELEFONO VARCHAR(20),
@EMAIL VARCHAR(30),
@SEXO BIT,
@OBS VARCHAR(160),
@ID_EMPLEADO INT,
@ELIMINADO BIT
AS
BEGIN
update PACIENTE set NOMBRE=@NOMBRE,APELLIDO=@APELLIDO,DNI=@DNI,FECHA_NAC=@FECHA_NAC,DIRECCION=@DIRECCION,IDLOCALIDAD=@IDLOCALIDAD,TELEFONO=@TELEFONO,EMAIL=@EMAIL,SEXO=@SEXO,OBS=@OBS,ID_EMPLEADO=@ID_EMPLEADO,ELIMINADO=@ELIMINADO where ID_PACIENTE = @ID_PACIENTE
END
--AGREGAR EMPLEADO
GO
CREATE PROCEDURE SP_AGREGAR_EMPLEADO
@ID_CATEGORIA INT,
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@DNI VARCHAR(20),
@FECHA_NAC DATE,
@DIRECCION VARCHAR(50),
@IDLOCALIDAD INT,
@TELEFONO VARCHAR(20),
@EMAIL VARCHAR(30),
@SEXO BIT,
@ELIMINADO BIT
AS
BEGIN
INSERT INTO EMPLEADO(ID_CATEGORIA,NOMBRE,APELLIDO,DNI,FECHA_NAC,DIRECCION,IDLOCALIDAD,TELEFONO,EMAIL,SEXO,ELIMINADO)VALUES(@ID_CATEGORIA,@NOMBRE,@APELLIDO,@DNI,@FECHA_NAC,@DIRECCION,@IDLOCALIDAD,@TELEFONO,@EMAIL,@SEXO,@ELIMINADO)
SELECT * FROM EMPLEADO WHERE DNI LIKE'%'+@DNI+'%'
END
GO
CREATE PROCEDURE SP_AGREGAR_ANTECEDENTE
@ID_PACIENTE INT,
@ID_GRUPO_S INT,
@PESO DECIMAL,
@ALTURA DECIMAL 
AS
BEGIN
INSERT INTO ANTECEDENTE(ID_PACIENTE,ID_GRUPO_S,PESO,ALTURA)VALUES(@ID_PACIENTE,@ID_GRUPO_S,@PESO,@ALTURA) 
END
GO
CREATE PROCEDURE SP_MODIFICAR_ANTECEDENTE
@ID_PACIENTE INT,
@ID_GRUPO_S INT,
@PESO DECIMAL,
@ALTURA DECIMAL
AS
BEGIN
UPDATE ANTECEDENTE SET ID_PACIENTE=@ID_PACIENTE,ID_GRUPO_S=@ID_GRUPO_S,PESO=@PESO,ALTURA=@ALTURA where ID_PACIENTE= @ID_PACIENTE
END
GO

CREATE PROCEDURE SP_CARGAR_ALERGIA
@NOMBRE VARCHAR(50)
AS
BEGIN	
INSERT INTO ALERGIA(NOMBRE)VALUES(@NOMBRE)
END
GO
CREATE PROCEDURE SP_CARGAR_MEDICAMENTO
@NOMBRE VARCHAR(50)
AS
BEGIN	
INSERT INTO MEDICAMENTO(NOMBRE)VALUES(@NOMBRE)
END

GO
CREATE PROCEDURE SP_CARGAR_ALERGIAS_X
@ID_PACIENTE INT,
@ID_ALERGIA INT,
@ELIMINADO BIT
AS
BEGIN
INSERT INTO ALERGIA_X_PACIENTE(ID_PACIENTE,ID_ALERGIA,ElIMINADO)VALUES(@ID_PACIENTE,@ID_ALERGIA,@ELIMINADO)
END
go

CREATE PROCEDURE SP_CARGAR_MEDICAMENTO_X
@ID_PACIENTE INT,
@ID_MEDICAMENTO INT,
@ELIMINADO BIT
AS
BEGIN
INSERT INTO MEDICAMENTO_X_PACIENTE(ID_PACIENTE,ID_MEDICAMENTO,ElIMINADO)VALUES(@ID_PACIENTE,@ID_MEDICAMENTO,@ELIMINADO)
END
go

CREATE PROCEDURE SP_MODIFICAR_MEDICAMENTO_X
@ID_MEDICAMNTO_X_PACIENTE INT,
@ID_PACIENTE INT,
@ID_MEDICAMENTO INT,
@ELIMINADO BIT
AS
BEGIN
UPDATE MEDICAMENTO_X_PACIENTE SET ID_PACIENTE=@ID_PACIENTE,ID_MEDICAMENTO=@ID_MEDICAMENTO,ElIMINADO=@ELIMINADO where ID_PACIENTE=@ID_PACIENTE and ID_MEDICAMENTO=@ID_MEDICAMENTO
END

GO
CREATE PROCEDURE SP_AGREGAR_ESPECIALIDADxMEDICO
@ID_EMPLEADO INT,
@ID_ESPECIALIDAD INT,
@ELIMINADO BIT
AS
BEGIN
INSERT INTO ESPECIALIDAD_X_M(ID_EMPLEADO,ID_ESPECIALIDAD,ElIMINADO)VALUES(@ID_EMPLEADO,@ID_ESPECIALIDAD,@ELIMINADO)
END

GO
CREATE PROCEDURE SP_HORARIO_MEDICO
@ID_EMPLEADO INT,
@HORA_D TIME,
@HORA_H TIME,
@DIAS VARCHAR(10)
AS
BEGIN
insert into HORA_IE(ID_EMPLEADO,HORA_DESDE,HORA_HASTA,DIAS)values(@ID_EMPLEADO,@HORA_D,@HORA_H,@DIAS)
END

GO
CREATE PROCEDURE SP_AGREGAR_TURNO
@ID_PACIENTE INT,
@FECHA DATE,
@HORA TIME,
@ID_EMPLEADO INT,
@ID_MEDICO INT,
@ID_ESTADO INT,
@OBSERVACION VARCHAR(200),
@ELIMINADO BIT
AS
BEGIN
insert into TURNO(ID_PACIENTE,FECHA,HORA,ID_EMPLEADO,ID_MEDICO,ID_ESTADO,OBSERVACION,ELIMINADO)values(@ID_PACIENTE,@FECHA,@HORA,@ID_EMPLEADO,@ID_MEDICO,@ID_ESTADO,@OBSERVACION,@ELIMINADO)
END

go

CREATE PROCEDURE SP_AGREGAR_USUARIO
@NOMBRE VARCHAR(50),
@CONTRASE�A VARCHAR(50),
@ID_EMPLEADO INT,
@ELIMINADO BIT 
AS
BEGIN
insert into USUARIO(NOMBRE_USUARIO,CONTRASE�A,ID_EMPLEADO,ELIMINADO)VALUES(@NOMBRE,@CONTRASE�A,@ID_EMPLEADO,@ELIMINADO)
END
go
CREATE PROCEDURE SP_CANCELAR_TURNO(
 @ID_EMPLEADO INT,
 @ID_TURNO INT,
 @MOTIVO VARCHAR(200),
 @ID_PACIENTE INT
)
AS
BEGIN 
 BEGIN TRY
 BEGIN TRANSACTION
 UPDATE TURNO SET ELIMINADO=1,OBSERVACION=@MOTIVO WHERE ID_TURNO=@ID_TURNO
   INSERT INTO HISTORIAL(ID_PACIENTE,ID_EMPLEADO,MOTIVO,DIAGNOSTICO)VALUES(@ID_PACIENTE,@ID_EMPLEADO,@MOTIVO,'CANCELADO')
   COMMIT TRANSACTION
 END TRY
 BEGIN CATCH
	ROLLBACK TRANSACTION
 END CATCH
END
go

CREATE PROCEDURE SP_eliminar(
 @ID_EMPLEADO INT
)
AS
BEGIN 
 BEGIN TRY
 BEGIN TRANSACTION
 UPDATE EMPLEADO SET ELIMINADO=1 WHERE ID_EMPLEADO=@ID_EMPLEADO
   COMMIT TRANSACTION
 END TRY
 BEGIN CATCH
	ROLLBACK TRANSACTION
 END CATCH
END
GO

--CREATE TRIGGER VERIFICAR_CARGA ON ALERGIA
--INSTEAD OF INSERT 
--AS
--	BEGIN
--		BEGIN TRY
--			BEGIN TRANSACTION 
--			DECLARE @@NOMBRE VARCHAR(50)
--			DECLARE @@ID INT
--			SELECT @@NOMBRE=NOMBRE FROM inserted 
--            SELECT @@ID=ID_ALERGIA FROM ALERGIA WHERE NOMBRE LIKE '%'+@@NOMBRE+'%'
						   
--			COMMIT TRANSACTION
--		END TRY
--	BEGIN CATCH
--		ROLLBACK TRANSACTION
--	END CATCH
--END
--GO
--CREATE TRIGGER TR_VERIFICARPACIENTE ON PACIENTE 
--AFTER INSERT
--AS 