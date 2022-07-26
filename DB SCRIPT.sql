--CREATE DATABASE FSREBOOT
--GO
USE FSREBOOT
GO
--Crear Clave maestra
CREATE MASTER KEY ENCRYPTION BY   
PASSWORD = 'Iklsj268444dn"(Fansj@@#';
GO
--Crear Certificado UP
 CREATE CERTIFICATE UserPasswords  
   WITH SUBJECT = 'Claves de acceso de usuarios';  
GO  
--Crear clave simetrica SK01
CREATE SYMMETRIC KEY SSN_Key_01  
    WITH ALGORITHM = AES_256  
    ENCRYPTION BY CERTIFICATE UserPasswords;  
GO  
--Crear table Usuarios
create table Usuarios(
Id int identity(1,1) not null primary key,
Nombre_Usuario nvarchar(25) not null unique,
Nombres nvarchar(35) not null,
Apellidos nvarchar(35) not null,
Contraseña varbinary(128) not null,
Correo nvarchar(50) not null unique,
Fecha_Registro datetime not null default GETDATE(),
Recuerdame bit not null default 0
)

OPEN SYMMETRIC KEY SSN_Key_01  
   DECRYPTION BY CERTIFICATE UserPasswords;  
GO
--Usuario de Prueba
insert into Usuarios(
					Nombre_Usuario, 
					Nombres, 
					Apellidos, 
					Contraseña, 
					Correo) 
values('Veroyman', 
	   'Alam Alexis', 
	   'De La Rosa', 
	   EncryptByKey(Key_GUID('SSN_Key_01'), Convert(nvarchar, '1234')), 
	   'elbosy89@gmail.com')

OPEN SYMMETRIC KEY SSN_Key_01  
   DECRYPTION BY CERTIFICATE UserPasswords;  
GO 
--Mostrar claves cifradas
SELECT Contraseña AS 'Clave Cifrada',  
    CONVERT(nvarchar, DecryptByKey(Contraseña))   
    AS 'Clave Descifrada'  
    FROM Usuarios;  
GO  
delete from usuarios
--CREAR PROCEDIMIENTO ALMACENADO PARA ABRIR LA CLAVE SIMETRICA
CREATE PROCEDURE OSK
AS
BEGIN
OPEN SYMMETRIC KEY SSN_Key_01  
   DECRYPTION BY CERTIFICATE UserPasswords;
END

--CREAR PROCEDIMIENTO ALMACENADO PARA REGISTRAR USUARIOS
CREATE PROCEDURE REGISTRAR_USUARIO
@Nombre_Usuario nvarchar(25),
@Nombres nvarchar(35),
@Apellidos nvarchar(35),
@Contraseña nvarchar(55),
@Correo nvarchar(50)
AS
BEGIN
OPEN SYMMETRIC KEY SSN_Key_01  
   DECRYPTION BY CERTIFICATE UserPasswords;
insert into Usuarios(
					Nombre_Usuario, 
					Nombres, 
					Apellidos, 
					Contraseña, 
					Correo) 
values(@Nombre_Usuario, 
	   @Nombres, 
	   @Apellidos, 
	   EncryptByKey(Key_GUID('SSN_Key_01'), Convert(nvarchar, @Contraseña)), 
	   @Correo)
END

--CREAR PROCEDIMIENTO ALMACENADO PARA INICIAR SESION
CREATE PROCEDURE INICIAR_SESION
@Nombre_Usuario NVARCHAR(25),
@Contraseña nvarchar(55)
AS
BEGIN
OPEN SYMMETRIC KEY SSN_Key_01  
   DECRYPTION BY CERTIFICATE UserPasswords;
SELECT count(*)
FROM USUARIOS
WHERE Nombre_Usuario=@Nombre_Usuario AND CONVERT(NVARCHAR, DECRYPTBYKEY(Contraseña))=@Contraseña;
END

