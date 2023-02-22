USE DB_SistemaDeVentas;

CREATE DATABASE DB_SistemaDeVentas;

DROP DATABASE DB_SistemaDeVentas_v2;

DROP DATABASE DB_SistemaDeVentas3;

DROP TABLE [dbo].[Personal];
DROP TABLE [dbo].[Inventario];
DROP TABLE [dbo].[LoginPersonal];
DROP TABLE [dbo].[Inventario];
DROP TABLE [dbo].[Productos];
DROP TABLE [dbo].[Rembolsos];
DROP TABLE [dbo].[Ventas];
DROP TABLE [dbo].[Clientes];



CREATE TABLE LoginPersonal
(
	Id_Login_Personal  VARCHAR(100)  PRIMARY KEY,
	Contraseña VARCHAR(100),
	Usuario VARCHAR(100)

	FOREIGN KEY (Id_Login_Personal) REFERENCES Personal(Id_Personal)
);

INSERT INTO LoginPersonal(Id_Login_Personal,Contraseña,Usuario)
	VALUES('P-1','1020','Edson')

INSERT INTO LoginPersonal(Id_Login_Personal,Contraseña,Usuario)
	VALUES('P-2','2030','Jhonatan'),
	('P-3','3040','Mijail')


		--Relacion on la tabla:


		CREATE TABLE Personal
		(
			Id_Personal VARCHAR(100)  PRIMARY KEY,
			Nombre VARCHAR(100),
			Apellido VARCHAR(100),
			Roll VARCHAR (100),
			Sueldo FLOAT,
			Tipo_Moenda VARCHAR(100),
			Turno VARCHAR(100)
		);

		INSERT INTO Personal(Id_Personal,Nombre,Apellido,Roll,Sueldo,Tipo_Moenda,Turno)
		VALUES('P-1','Edson','Condori','Gerente',5200.25,'Blovianos','Mañana-Tarde-Noche')
		INSERT INTO Personal(Id_Personal,Nombre,Apellido,Roll,Sueldo,Tipo_Moenda,Turno)
		VALUES('P-2','Mijail','Choque','Gerente',5200.25,'Blovianos','Mañana-Tarde-Noche'),
		('P-3','Jhonatan','Alanoca','Gerente',5200.25,'Blovianos','Mañana-Tarde-Noche')


				--Relacion on la tabla:


				CREATE TABLE Ventas
				(
					Id_Ventas VARCHAR(100)  PRIMARY KEY,
					Id_Cliente VARCHAR(100),
					Id_Productos VARCHAR(100),
					Cuenta_a_Pagar FLOAT,
					Cuenta_Pagada FLOAT,
					Total_a_Pagar FLOAT,
					Tipo_Moneda_De_Pago VARCHAR(100),

					FOREIGN KEY (Id_Cliente) REFERENCES Clientes(Id_Cliente)
				);

	
				-- C-5    
				--C-4


				CREATE TABLE Rembolsos 
				(
					Id_Rembolsos VARCHAR(100)  PRIMARY KEY,
					Id_Cliente VARCHAR (100),
					Id_Productos_Rembolsados VARCHAR(100),
					Monto_Rembolsado FLOAT,
					Tipo_Moneda VARCHAR(100),
					Motivo VARCHAR (200),
	
					FOREIGN KEY (Id_Cliente) REFERENCES Clientes(Id_Cliente)
				);

				
-------------------------------------------------------------------------------
-------------------------------------------------------------------------------

CREATE TABLE Clientes  
(
	Id_Cliente VARCHAR(100)  PRIMARY KEY,
	Id_Vendedor VARCHAR(100),
	CI INTEGER,
	Nombre_Clientes VARCHAR(100),
	Apellido_Clientes VARCHAR(100),

	FOREIGN KEY (Id_Vendedor) REFERENCES Personal(Id_Personal)
);

		--Relacion con las tablas:


		CREATE TABLE Productos 
		(
			Id_Producto VARCHAR(100)  PRIMARY KEY,
			Nombre VARCHAR(100),
			Precio FLOAT,
			Tipo_Moenda VARCHAR(100),
			Marca VARCHAR(100),  
			Stock VARCHAR(100),
			Ubicacion_del_Producto VARCHAR(100),

			FOREIGN KEY (Ubicacion_del_Producto) REFERENCES Inventario(Id_Inventario)

		);

-------------------------------------------------------------------------------
-------------------------------------------------------------------------------

				--relacion con la tabla:


				CREATE TABLE Inventario
				(
					Id_Inventario VARCHAR(100)  PRIMARY KEY,
					Id_Productos VARCHAR(100),
					Id_Gerente_Del_Inventario VARCHAR(100),
					Productos VARCHAR(100),
					Marcas VARCHAR(100), 

					FOREIGN KEY (Id_Gerente_Del_Inventario) REFERENCES Personal(Id_Personal)
				);
				
        -------------------------------------------------------------------------------
        -------------------------------------------------------------------------------






--INNER JOIN


SELECT LP.*  
FROM Personal AS P
INNER JOIN LoginPersonal AS LP ON P.Id_Personal = LP.Id_Login_Personal
WHERE P.Roll LIKE '%Gerente%'


SELECT R.*  
FROM Clientes AS C
INNER JOIN Rembolsos AS R ON C.Id_Cliente = R.Id_Cliente
WHERE C.Id_Vendedor BETWEEN 'P-4' AND 'P-10'  


SELECT COUNT(C.Id_Vendedor)  
FROM Clientes AS C
INNER JOIN Rembolsos AS R ON C.Id_Cliente = R.Id_Cliente
INNER JOIN Personal AS P ON P.Id_Personal = C.Id_Vendedor
WHERE P.Roll = '%Gerente%'


SELECT PR.*  
FROM Inventario AS	I
INNER JOIN Productos AS PR ON I.Id_Inventario = PR.Ubicacion_del_Producto
INNER JOIN Personal AS P ON I.Id_Gerente_Del_Inventario = P.Id_Personal
WHERE P.Roll = 'Gerente' AND I.Id_Inventario = 'Inv-5' AND P.Id_Personal = 'P-1'



CREATE FUNCTION Sueldo_maximo(@roll VARCHAR(100))
	RETURNS FLOAT AS
	BEGIN
		DECLARE @R FLOAT

		SELECT @R = MAX(P.Sueldo) 
		FROM Personal AS P
		WHERE P.Roll LIKE '%' + @roll + '%'

		RETURN @R
	END

SELECT dbo.Sueldo_maximo('Empleado') AS 'Sueldo Maximo Segun el Roll'



CREATE FUNCTION Cantidad_Personal(@roll VARCHAR(100))
	RETURNS FLOAT AS
	BEGIN
		DECLARE @R FLOAT

		SELECT @R = COUNT(P.Id_Personal) 
		FROM Personal AS P
		WHERE P.Roll LIKE '%' + @roll + '%'

		RETURN @R
	END

SELECT dbo.Cantidad_Personal('Gerente') AS 'Cantidad del Personal Segun su Roll'


CREATE FUNCTION Cantidad_Productos_Precio_May(@precio FLOAT)
	RETURNS FLOAT AS
	BEGIN
		DECLARE @R FLOAT

		SELECT @R = COUNT(PR.Id_Producto) 
		FROM Productos AS PR
		WHERE PR.Precio > @precio

		RETURN @R
	END

SELECT dbo.Cantidad_Productos_Precio_May(1100) AS 'Cantidad de Productos Mayores a cierta cantidad'

DELETE FROM Inventario
WHERE Id_Productos = 'Vacio'

CREATE FUNCTION Cantidad_Productos_Precio_Men(@precio FLOAT)
	RETURNS FLOAT AS
	BEGIN
		DECLARE @R FLOAT

		SELECT @R = COUNT(PR.Id_Producto) 
		FROM Productos AS PR
		WHERE PR.Precio < @precio

		RETURN @R
	END

SELECT dbo.Cantidad_Productos_Precio_May(1100.1) AS 'Cantidad de Productos Menores a cierta cantidad'