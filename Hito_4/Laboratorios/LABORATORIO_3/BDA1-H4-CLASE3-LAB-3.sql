-- 31/10/2022 
-- FUNCIONES
-- ¿Que Funcion de Agregacion?
-- Cuando se quiera utilizar la funcion de agregacion se deve de usar 
-- dentro de la clausula SELECT que es aplicado en grupos de registro 
-- (una columna de una tabla), este SIEMPRE retorna un unico valor (una fila).

-- Funciones de agregacion:
-- AVG = calcula el promedio de los valorres de un campo determinado.
-- COUNT = Devuelve el numero de registros de la seleccion.
-- SUM = debuelve la suma de todos los valores de un campo determinado.
-- MAX = devolver el valor mas alto de un campo determinado. 
-- MIN = devolver el valor mas bajo de un campo determinado. 

CREATE DATABASE Funciones_Hito4_Base_De_DatosI_Clase_2;
Use Funciones_Hito4_Base_De_DatosI_Clase_2;

/*

create table estudiantes 
(
id_estudiante int primary key identity not null,
nombres varchar (25) not null,
apellidos varchar (30) not null,
edad integer not null,
fono integer not null,
email varchar (100) not null,
direccion varchar (200) not null,
genero varchar (50) not null,
);

INSERT INTO estudiantes (nombres, apellidos, edad, fono, email, direccion, genero)
  VALUES ('Miguel' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino')
  ,('Sandra' ,'Mavir Uria', 25, 2832116, 'sandra@gmail.com', 'Av. 6 de Agosto', 'femenino')
  ,('Joel' ,'Adubiri Mondar', 30, 2832117, 'joel@gmail.com', 'Av. 6 de Agosto', 'masculino')
  ,('Andrea' ,'Arias Ballesteros', 21, 2832118, 'andrea@gmail.com', 'Av. 6 de Agosto', 'femenino')
  ,('Santos' ,'Montes Valenzuela', 24, 2832119, 'santos@gmail.com', 'Av. 6 de Agosto', 'masculino');

--EJERCICIO 1
--------------------------------------------------------------------------------------
-- Cuantos Estudiantes registrados hay
select count (*) numero_estudiantes  -- usando funcion de agregacion COUNT
from estudiantes AS est;

-- segunda forma
select COUNT (est.id_estudiante)
from estudiantes as est;
--------------------------------------------------------------------------------------

--EJRECICIO 2
-------------------------------------------------------------
--DETERMINAR LA MINIMA EDAD DE ESTUDIANTES
select MIN (edad) 
from estudiantes;

--segnda forma
select MIN (est.edad) Edad_Minima
from estudiantes as est;
------------------------------------------------------------

--EJERCICIO 3
------------------------------------------------------------
--Determinar la contidad de estudiantes de sexo fenemino
select count (genero)
from estudiantes
where genero = 'femenino';

-- segunda forma
select count (est.genero) Numero_de_cantidad_femenino
from estudiantes as est
where est.genero = 'femenino';
------------------------------------------------------------

-- INSERTAAMOS UN NUEVO CAMPO A LA TABLA DE ESTUDIANTES
ALTER TABLE estudiantes ADD licencia_conducir BIT;
select * from estudiantes;
-- INSERTAMOS DATOS CON EL NUEVO CAMPOCREADO
INSERT INTO estudiantes (nombres, apellidos, edad, fono, email, direccion, genero, licencia_conducir)
  VALUES ('Ana' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino',1)
  ,('Pepito' ,'Gonzales Veliz', 20, 2832115, 'pepito@gmail.com', 'Av. 6 de Agosto', 'masculino',0);

------------------------------------------------------------
-- determinar la cantidad de estudiantes y estudiantes con licencia
select count (est.licencia_conducir) Estudiante_con_Licencia
from estudiantes as est; 

select count (est.id_estudiante) Cantidad_de_Estudiantes
from estudiantes AS est;
------------------------------------------------------------

-- 10 Determinar cuantos estudiantes hay con apellidos donde haya "el" y que el genero sea masculino 
select count (est.id_estudiante) Estudiantes_que_Tienen_el_en_apellido
FROM estudiantes as est
where est.apellidos like '%el%' and est.genero = 'masculino';
-------------------------------------------------------------

-------------------------------------------------------------
-- 11 Determinar cuantps estidantes hay mayor a 20 y menor a 30 de los estudiantes con licencia
select count (est.id_estudiante) Estudiantes_entre_20_a_30_con_Licencia
from estudiantes as est 
where est.edad < 30 and est.edad > 20 and est.licencia_conducir = 1; 

-- usando BETWEEN
select COUNT (est.id_estudiante)  Estudiantes_entre_20_a_30_con_Licencia
from estudiantes as est
where est.edad between 29 and 30 and est.licencia_conducir = 1;
--------------------------------------------------------------

--Manejo de ER con funciones de agregación
-- CREAMOS UNA TABLA NUEVA
CREATE TABLE escuela(
Id_esc INT IDENTITY PRIMARY KEY NOT NULL,
nombre VARCHAR(25) NOT NULL,
direccion VARCHAR(50) NOT NULL,
turno VARCHAR(25) NOT NULL
);
-- INGRESAMOS DATOS A LA TALBA
INSERT INTO escuela(nombre,direccion,turno)
VALUES('HOLANDA','6 DE AGOSTO/AV.SAVEDRA ','MAÑANA')
,('SAN MIGUEL','6 DE MARZO/AV.JUAN PABLO II ','TARDE');

-- CREAMOS NUESTRA SEGUNDA TABLA (AQUI RELACIONAREMOS LA PRIMERA TABLA)
create table estudiante 
(
id_estudiante int primary key identity not null,
nombres varchar (25) not null,
apellidos varchar (30) not null,
edad integer not null,
fono integer not null,
email varchar (100) not null,
direccion varchar (200) not null,
genero varchar (50) not null,
id_esc int not null,
Foreign key (id_esc) references escuela (id_esc) -- RELACIONANDO LA TABLA
);

-- INGRESAMOS DATOS A LA TABLA
INSERT INTO estudiante (nombres, apellidos, edad, fono, email, direccion, genero,id_esc)
  VALUES ('Miguel' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino',1)
  ,('Sandra' ,'Mavir Uria', 25, 2832116, 'sandra@gmail.com', 'Av. 6 de Agosto', 'femenino',2)
  ,('Joel' ,'Adubiri Mondar', 30, 2832117, 'joel@gmail.com', 'Av. 6 de Agosto', 'masculino',1)
  ,('Andrea' ,'Arias Ballesteros', 21, 2832118, 'andrea@gmail.com', 'Av. 6 de Agosto', 'femenino',2)
  ,('Santos' ,'Montes Valenzuela', 24, 2832119, 'santos@gmail.com', 'Av. 6 de Agosto', 'masculino',1);


  -- AÑADIMOS UN NUEVO CAMPO A LA TABLA ESTUDIANTE
  ALTER TABLE estudiante ADD licencia_conducir BIT;
select * from estudiante;
-- INSERTAMOS DATOS CON EL NUEVO CAMPOCREADO
INSERT INTO estudiante (nombres, apellidos, edad, fono, email, direccion, genero,id_esc,licencia_conducir)
  VALUES ('Ana' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino',1,1)
  ,('Pepito' ,'Gonzales Veliz', 20, 2832115, 'pepito@gmail.com', 'Av. 6 de Agosto', 'masculino',2,0);


  -- REALIZANDO LA CONSULTA 
  --CUANTOS ESTUDIANTES ESTAN INSCRITOS EN EL COLEGIO SAN MIGUEL
SELECT COUNT(est.id_estudiante) ESTUDIANTES_DEL_COLEGIO_SAN_MIGUEL
FROM escuela AS esc
INNER JOIN estudiante AS est ON esc.Id_esc= est.id_esc  -- RELACION ENTRE LAS DOS TABLAS
WHERE esc.nombre ='SAN MIGUEL';   

*/



/*
---------------------------------------------------------------------------------
---------------------------------------------------------------------------------


					-- CLASE 2 HITO 4 - 07/11/2022

--CREAMOS LA TABLA ESCUELA
CREATE TABLE escuela
(
id_esc integer identity Primary key Not null,
nombre Varchar (50) not null,
direccion varchar (50) not null,
turno varchar (50) not null  --mañana, tarde , noche
);

-- creamos LA TABLA ESCUELA
create table estudiante 
(
id_estudiante int primary key identity not null,
nombres varchar (25) not null,
apellidos varchar (30) not null,
edad integer not null,
fono integer not null,
email varchar (100) not null,
direccion varchar (200) not null,
genero varchar (50) not null,
id_esc int not null,
licencia_conducir BIT not null,
Foreign key (id_esc) references escuela (id_esc) -- RELACIONANDO LA TABLA
);

drop table estudiante;

INSERT INTO escuela (nombre,direccion,turno)
values ('San Simon','Cochabamba','Mañana')
,('Andres Bello','El Alto','Mañana-Tarde')
,('Amor de Dios Fe y Alegria','El Alto','Mañana-Tarde')
,('Don Bosco','La Paz','Mañana-Tarde-Noche')


INSERT INTO estudiante (nombres, apellidos, edad, fono, email, direccion, genero,id_esc,licencia_conducir)
  VALUES ('Miguel' ,'Gonzales Veliz', 20, 2832115, 'miguel@gmail.com', 'Av. 6 de Agosto', 'masculino',1,0)
  ,('Sandra' ,'Mavir Uria', 25, 2832116, 'sandra@gmail.com', 'Av. 6 de Agosto', 'femenino',2,0)
  ,('Joel' ,'Adubiri Mondar', 30, 2832117, 'joel@gmail.com', 'Av. 6 de Agosto', 'masculino',3,0)
  ,('Andrea' ,'Arias Ballesteros', 21, 2832118, 'andrea@gmail.com', 'Av. 6 de Agosto', 'femenino',4,0)
  ,('Santos' ,'Montes Valenzuela', 24, 2832119, 'santos@gmail.com', 'Av. 6 de Agosto', 'masculino',1,0);


  INSERT INTO estudiante (nombres, apellidos, edad, fono, email, direccion, genero,id_esc, licencia_conducir)
  VALUES ('Ana' ,'Gonzales Veliz', 20, 2832115, 'ana@gmail.com', 'Av. 6 de Agosto', 'femenino',2,1)
  ,('Pepito' ,'Gonzales Veliz', 20, 2832115, 'pepito@gmail.com', 'Av. 6 de Agosto', 'masculino',3,0);



  SELECT est.* 
  FROM estudiante AS est;

-- determinar cuantos estuidiantes tiene licencia de conducir 
select count (est.licencia_conducir) Estudiante_con_Licencia
from estudiante as est
where est.licencia_conducir=1; 

-- determinar cuantos estuidiantes no tiene licencia de conducir y son menores de 20 

select count (est.licencia_conducir) Estudiantes_sin_Licencia
from estudiante as est
where est.edad < 20 and est.licencia_conducir = 0;

-- determinar cuantos estudianates son de la escuela amorde Dios 
select COUNT (est.id_esc) Estudiantes_en_el_colegio_Amor_de_Dios_Fe_y_Alegria
from escuela as esc
inner join estudiante as est on est.id_esc = esc.id_esc
where esc.nombre = 'Amor de Dios Fe y Alegria';

--Determinar cuantos estudainte estan en la escuela con turnos mañana tarde
select COUNT (est.id_esc) Estudiantes_en_el_colegio_con_turno_mañana_tarde
from escuela as esc
inner join estudiante as est on est.id_esc = esc.id_esc
where esc.turno = 'Mañana-Tarde';

-- detereminar cauntos estudiantes mayores a 25 años estan en escuelas que tiene solo el turno de la tarde
select COUNT (est.id_esc) Estudiantes_en_el_colegio_Amor_de_Dios_Fe_y_Alegria
from escuela as esc
inner join estudiante as est on est.id_esc = esc.id_esc
where esc.turno like ('%Tarde%') and est.edad > 25;


------------------ CREACION DE FUNCIONES "PROPIAS" ---------------

              ----------- ESTRUCTURA DE CREACION DE FUNCIONES---------

CREATE FUNCTION -- con este comando creamos una funcion propia  
RETURNS    /*tipo de dato*/      AS
BEGIN  -- INICIO DE FUNCION
return  -- Retorna
END;  -- FINALIZAMOS LA FUNCION


-- EJEMPLO
CREATE FUNCTION retorna_nombre_materia () -- creacion de la funcion seguido del nombre que nosotros queramos 
returns varchar (20) as  -- Devemos poner el RETURS seguido del tipo de dato y AS  
BEGIN  -- Iniciamos la Funcion
RETURN 'Base de Datos I'  -- Retorna 
END; -- Finalizamos la Funcion

Select dbo.retorna_nombre_materia ();  --Con SELECT dbo.NOMBRE_DE_LA_FUNCION
                                       --podemos ver los valores de la funcion




CREATE FUNCTION retorna_nombre_materia_v3()
RETURNS VARCHAR(25) AS 
BEGIN  -- INICIAMOS EL PROCESO O ENTRADA DE DATOS
   DECLARE @nombre VARCHAR(25);  -- DECLARAMOS EL NOMBRE DE NUESTRA FUNCION DEBEMOS POINER SI O SI EL @
   SET @nombre = 'Base de Datos I'   -- ENTRADA
   RETURN @nombre;  --RETORMANOS 
END;  --FINALIZAMOS EL PROCESO O ENTRADA DE DATOS

Select dbo.retorna_nombre_materia_v3();

						-- ALTERAR UNA FUNCION--
ALTER FUNCTION retorna_nombre_materia_v3()  -- con ALTER estamos alterando la funcion 
RETURNS VARCHAR(25) AS 
BEGIN  -- INICIAMOS EL PROCESO O ENTRADA DE DATOS
   DECLARE @nombre VARCHAR(25);  -- DECLARAMOS EL NOMBRE DE NUESTRA FUNCION
   SET @nombre = 'Base de Datos II'   -- ENTRADA 
   RETURN @nombre;  --RETORMANOS 
END;  --FINALIZAMOS EL PROCESO O ENTRADA DE DATOS



CREATE FUNCTION retorna_nombre_materia_v5(@nombreMateria VARCHAR (25))
RETURNS VARCHAR (25) AS
BEGIN
DECLARE @nombre VARCHAR (25);
SET @nombre = @nombreMateria ;
RETURN @nombre;
END;

select dbo.retorna_nombre_materia_v5('DBA I');


-- CREAR UNA FUNCION QUENO RECIBE PARAMETROS LAS FUNCION DEBE SUMAR DOS NUMEROS CUALQUIERA LA FUNCION RETORNA ESA SUMA 

CREATE FUNCTION suma_dos_numeros()
RETURNS INTEGER AS
BEGIN
RETURN (5+5);
END;

select dbo.suma_dos_numeros();

-- SEGUNDA FORAMA DE RESOLVER

ALTER FUNCTION suma_dos_numeros_v1()
RETURNS INTEGER AS
BEGIN
DECLARE @resultado Integer
SET @resultado = 2+5;
RETURN @resultado;
END;

select dbo.suma_dos_numeros_v1();


--crear una funcion que recibe tres parametros enteros la funciondebe sumar esos tres parametros la fuynciondebe retornar la suma 


CREATE FUNCTION sumav2(@num1 INTEGER, @Num2 Integer , @Num3 Integer)
Returns INTEGER  AS 
BEGIN
DECLARE @resultado INTEGER;
SET @resultado =@Num1 + @Num2 + @Num3;
RETURN @resultado;
END

select dbo.sumav2(5,5,3);


					---  TAREA  ----

--@accion es sumar: RETORNAR LA SUMA DE LOS 2 NUMEROS
--@accion es restar : RETORNAR LA RESTA DE LOS 2 NUMEROS

Alter function suma_y_resta_de_dos_numeros_con_accion(@numero1 integer, @numero2 integer, @accion varchar(20))
returns integer as
begin
declare @resultado integer = 0;
if @accion = 'Sumar' 
set @resultado = @numero1 + @numero2; 
if @accion = 'Restar'
set @resultado = @numero1 - @numero2;
if @accion = 'Multiplicar'
set @resultado = @numero1 * @numero2;
if @accion = 'Dividir' 
set @resultado = @numero1/@numero2;
return (@resultado);  
end;

select dbo.suma_y_resta_de_dos_numeros_con_accion(4,8,'Sumar') Suma;
select dbo.suma_y_resta_de_dos_numeros_con_accion(8,2,'Restar') Resta;
select dbo.suma_y_resta_de_dos_numeros_con_accion(3,5,'Multiplicar') Multiplicacion;
select dbo.suma_y_resta_de_dos_numeros_con_accion(10,2,'Dividir') Division;

*/

------------------------------------------------------------------------------------
------------------------------------------------------------------------------------

				--- CLASE-3----HITO-4 ---
				    -- 14/11/2022 --

Use Funciones_Hito4_Base_De_DatosI;

ALTER Function Operaciones (@num1 integer ,@num2 integer ,@action varchar(20))  --creacion de la funcion (lo altere por eso el ater)
returns integer AS 
BEGIN 
DECLARE @response integer = 0;

IF (@action = 'suma')
BEGIN
SET @response = @num1 + @num2;
END;

IF (@action = 'resta')
BEGIN
SET @response =  @num1 - @num2;
END;

IF (@action = 'multiplicacion')
BEGIN
SET @response = @num1 * @num2;
END;

IF (@action = 'division')
BEGIN
SET @response =  @num1 / @num2;
END
RETURN @response ;
END;

-- REALIZANDO LA CONSULTA

select dbo.Operaciones(4,8,'suma') Suma;
select dbo.Operaciones(8,2,'resta') Resta;
select dbo.Operaciones(3,5,'multiplicacion') Multiplicacion;
select dbo.Operaciones(0,0,'dividision') Division;

-------------------------------------------------------------------------------------

-- OTRA FORMA DE CREACION DE FUNCIONES PROPIAS (DEL EJERCICIO ANTERIOR )

ALTER Function Operaciones (@num1 integer ,@num2 integer ,@action varchar(20))
returns integer AS 
BEGIN 

IF (@action = 'suma')
return @num1 + @num2;

IF (@action = 'resta')
RETURN  @num1 - @num2;

IF (@action = 'multiplicacion')
RETURN @num1 * @num2;

IF (@action = 'division')
RETURN  @num1 / @num2;

RETURN 0 ;
END;

-- CONSULTAS REALIZADAS
select dbo.Operaciones(4,8,'suma') Suma;
select dbo.Operaciones(8,2,'resta') Resta;
select dbo.Operaciones(3,5,'multiplicacion') Multiplicacion;
select dbo.Operaciones(0,0,'dividision') Division;


-------------------------------------------------------
				--- EJERCICIOS ---

-- DETERNIMAR CUANTOS ESTUDIANTES SON MAYORES A 25 AÑOS 

select count (est.id_estudiante) Est_Mayores_de_25
from estudiante as est
where est.edad > 25;

--EJERCICIO 2  (Implementacion de la consulta a una funcion)
-- CREAR UNA FUINCION QUE PERMITA SABER LA CANTIDAD
-- DE ESTUDIANTES MAYORES A CIERTA EDAD 

CREATE FUNCTION mayores_a_cierta_edad(@edad integer)
RETURNS INTEGER AS
BEGIN
 DECLARE @response INTEGER =0;

select @response =  count (est.id_estudiante) Estudiantes_mayores_a    -- como asignar la respuesta de una consulta a una variable
from estudiante as est
where est.edad > @edad;

RETURN @response;
END;

-- Realixzando la consulta 
Select dbo.mayores_a_cierta_edad(25);


-------------------------------------------------------------------------------------
------------------------------------------------------------------------------------

-- CREAR UNA FUINCION QUE PERMITA SABER LA CANTIDAD
-- DE ESTUDIANTES MAYORES A CIERTA EDAD del genero femenino 
-- que forma parte del colegio Andres Bello
-- la funcion rtecibe dos parametros
-- EDAD Y GENERO


Select count (est.edad)
from escuela as esc
inner join estudiante as est on esc.id_esc = est.id_esc
where esc.nombre = 'Andres Bello' and est.genero = 'femenino' and est.edad >= 25; 


CREATE FUNCTION Andres_Bello(@edad integer,@genero varchar (50))
RETURNS INTEGER AS
BEGIN
 DECLARE @response INTEGER =0;
 
Select @response = count (est.edad)
from escuela as esc
inner join estudiante as est on esc.id_esc = est.id_esc
where esc.nombre = 'Andres Bello'	
	  and est.genero = @genero 
	  and est.edad >= @edad; 

RETURN @response;
END;

Select dbo.Andres_Bello(25,'femenino');


-- Mostrar el ultimo resgistro del un estudiante

SELECT  est.*
FROM estudiante as est
WHERE est.id_estudiante = 7;

select * from escuela;
select * from estudiante;

select MAX (est.id_estudiante)
fROM estudiante as est

-- CREACION DE LA FUNCION PONIENDO LA CONSULTA CREADA 
CREATE FUNCTION Maximo()   -- CREACION DE LA FUNCION
RETURNS INTEGER AS
BEGIN
DECLARE @response integer =0; -- DECLARANDO LA FUNCION

select @response = MAX (est.id_estudiante)  --  ASIGNANDO EL VALOR DE LA VARIABLE Y REALIZANDO LA CONSULTA
fROM estudiante as est;

RETURN @response;  -- RESTORNANDO LA RESPUESTA DE LA VARIABLE
END;  -- FIN DE LA FUNCION

Select dbo.Maximo()  -- REALIZANDO LA CONSULTA 

