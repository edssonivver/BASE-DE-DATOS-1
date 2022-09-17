--Creamos la base de datos--
Create Database Defensa_H2;

USE Defensa_H2;

-- PREGUNTA 1
--Crear una tabla cualquiera de nombre CELULAR identifiquese 3 columnas
/*Create Table Celular(

Imei varchar (80) primary key not null,
modelo varchar (30),
marca varchar (20),
color varchar (30),
);
insert into Celular (Imei, modelo, marca, color )
values ('PLKJ10109966556688','POCO X3 PRO','XIAOMI','AZUL');

insert into Celular (Imei, modelo, marca, color )
values ('ABCD1237894560011','POCO X3 PRO','XIAOMI','NEGRO');

insert into Celular (Imei, modelo, marca, color )
values ('ZXCASD55544488833300011','J7','SAMSUNG','AZUL');

select * from Celular;*/

-- Pregunta 2
--
/*Create table Factura(
id_factura varchar (30) primary key not null,
Nombre_empresa varchar (40) not null,
Nro_Factura integer not null,
Nro_Cliente varchar (50) not null,
productos varchar (100) not null,
precio_total integer not null

);


insert into Factura (id_factura, Nombre_empresa, Nro_Factura, Nro_Cliente, productos, precio_total)
values ('fac- 552211','farmacop',0555,'Juan','1099885533-LP','Aspirina 10 Uds', 6);

insert into Factura (id_factura, Nombre_empresa, Nro_Factura, Nro_Cliente, productos, precio_total)
values ('fac- 553366','CopaCabana',1233,'Pedro','1099885533-LP','Ibuprofeno 6 uds', 6);

Select * From Factura;
Drop table Factura;*/

-- Pregunta 3

/*
Create table Redes_sociales(
id_app integer PRIMARY KEY not null,
nombre_app varchar (30) not null,
Fecha_Publicacion integer not null,
Soporte varchar (30) not null
);


Insert into Redes_sociales  
values (001,'Spotify',2000,'ios - android');

select * from Redes_sociales; */


-- Pregunta 4


Create Table Cliente(
id_cliente VARCHAR (30) Primary key not null,
nombre VARCHAR (30) not null,
apellido VARCHAR (30) not null,
ci_cliente VARCHAR (30) not null,
edad INTEGER  not null,
Domicilio VARCHAR (50) not null,
Fono Varchar (50) not null
);


insert into Cliente (id_cliente,nombre,apellido,ci_cliente,edad,Domicilio,Fono)
values ('Client-001','Pancho','Rivera','102233-LP',22,'Villa Dolores / Nro. 320','5522116');

insert into Cliente (id_cliente,nombre,apellido,ci_cliente,edad,Domicilio,Fono)
values ('Client-002','Marco','Gomez','12345678-LP',25,'Rio Seco / Nro. 590','4555665');

Create Table Pedido(
id_pedido VARCHAR (30) Primary key not null,
Producto VARCHAR (30) not null,
Costo INTEGER not null,
fecha VARCHAR (30) not null
);

insert into Pedido(id_pedido,Producto,Costo,fecha)
values ('Pedido-001','Combo Fiesta',30,'12/05/22');

insert into Pedido(id_pedido,Producto,Costo,fecha)
values ('Pedido-002','Hamburguesa de pollo',40,'25/08/22');


Create table Detalle_pedido(
id_detalle_pedido varchar  (40) Primary key not null,
id_cliente VARCHAR (30) not null,
id_pedido VARCHAR (30) not null,

Foreign key (id_cliente) References cliente (id_cliente),
Foreign key (id_pedido) References Pedido (id_pedido),
);

insert into Detalle_pedido(id_detalle_pedido,id_cliente,id_pedido)
values ('Det_Ped-001','Client-001','Pedido-001');

insert into Detalle_pedido(id_detalle_pedido,id_cliente,id_pedido)
values ('Det_Ped-002','Client-002','Pedido-002');

select nombre,apellido,edad from  Cliente where edad>18;

