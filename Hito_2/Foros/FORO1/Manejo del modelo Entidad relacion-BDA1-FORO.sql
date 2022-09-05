Create database Compra_Vehiculo;

USE Compra_Vehiculo;

CREATE TABLE Cliente(
	CI_Client Varchar(50)Primary key,
	Name_Client Varchar (50),
	Last_Name_Client Varchar (50),
	Phone_Number Varchar (50)
);

Create Table Vehiculo (
	Num_Chasis varchar (50) Primary Key,
	Marca Varchar (50),
	Tipo_Vehiculo varchar (50),
	Modelo varchar (50),
	Color varchar (50),
	Num_Placa varchar (50)
);

Create table Compra_Factura(
	Codigo_Compra varchar (50) Primary Key,
	CI_Client Varchar(50),
	Num_Chasis varchar (50),
	Nombre_del_Consecionario varchar (50),
	Monto_Total varchar (50),
	Nombre_Producto_Final varchar (50),
	
	FOREIGN KEY (CI_Client) References Cliente (CI_Client),
	FOREIGN KEY (Num_Chasis) References Vehiculo (Num_Chasis)

);

Select * from Compra_Factura;

Drop table Compra_Factura;
Drop table Vehiculo;

