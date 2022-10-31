-- 31/10/2022 
-- FUNCIONES
-- ¿Que Funcion de Agregacion?
-- Cuando se quiera utilizar la funcion de agregacion se deve de usar 
-- dentro de la clausula SELECT que es aplicado en grupos de registro 
-- (una columna de una tabla), este SIEMPRE retorna un unico valor (una fila).

-- Funciones de agregacion:
-- AVG = calcula el promedio de los valorres de un campo determinado.
-- COUNT = Devuelve el numero de registrosde la seleccion.
-- SUM = debuelve la suma de todos los valores de un campo determinado.
-- MAX = devolver el valor mas alto de un campo determinado. 
-- MIN = devolver el valor mas bajo de un campo determinado. 

CREATE DATABASE Funciones_Hito4_Base_De_DatosI;
Use Funciones_Hito4_Base_De_DatosI;

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