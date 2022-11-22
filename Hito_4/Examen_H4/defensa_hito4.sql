CREATE DATABASE defensa_hito4;
USE defensa_hito4;

--CREACION TABLA Campeonato
create table Campeonato(
id_Campeonato VARCHAR(100) PRIMARY KEY NOT NULL,
nombre_campeonato VARCHAR(100) NOT NULL,
sede VARCHAR(50) NOT NULL
);

--Insertamos datos al la tabla Campeonato
INSERT INTO Campeonato(id_Campeonato,nombre_campeonato,sede)
VALUES('camp-111','Campeonato Unifranz','El Alto'), ('camp-222','Campeonato Unifranz','Cochabamba');

--CREACION TABLA EQUIPO
create table Equipo(
id_equipo VARCHAR(100)PRIMARY KEY NOT NULL,
nombre_equipo VARCHAR(100) NOT NULL,
categoria VARCHAR(50) NOT NULL,
id_campeonato VARCHAR(100) NOT NULL,
FOREIGN KEY (id_campeonato) REFERENCES Campeonato (id_campeonato),
);

--Insertamos datos al la tabla equipo
INSERT INTO Equipo(id_equipo,nombre_equipo,categoria,id_campeonato)
VALUES('equ-111','Google','VARONES','camp-111'),('equ-222','404 Not found','VARONES','camp-111'),
('equ-333','girls unifranz','MUJERES','camp-111');

--CREACION TABLA Jugador
CREATE TABLE Jugador(
id_jugador VARCHAR(100) PRIMARY KEY NOT NULL,
nombres VARCHAR(100) not null,
apellidos VARCHAR(100) not null,
ci   varchar(100) not null,
edad INTEGER not null,
id_equipo VARCHAR(100) not null,
FOREIGN KEY (id_equipo) REFERENCES Equipo (id_equipo)
);
--Insertamos datos al la tabla equipo
INSERT INTO JUGADOR (id_jugador,nombres,apellidos,ci,edad,id_equipo)
VALUES('jug-111','Carlos','Villa','8997811LP',19,'equ-222'),
('jug-222','Pedro','Salas','8997822LP',20,'equ-222'),
('jug-333','Saul','Araj','8997833LP',21,'equ-222'),
('jug-444','Sandra','Solis','8997844LP',20,'equ-333'),
('jug-555','Ana','Mica','8997855LP',23,'equ-333');


select * from Campeonato;
select * from Equipo;
select * from Jugador;



--------------------------------------------------------------------------

					-----  PREGUNTAS DEL EXAMEN  -----

--------------------------------------------------------------------------
-- PREGUNTA 1

-- MOSTRAR TODOS LOS JUGDORES DEL GENERO FEMENINO QUE JUEGAN 
-- EN EL CAMPEONATO UNIFRANZ QUE SEAN DELA SEDE DEL ALTO
-- CAMPOS A MOSTRAR JUGADOR(NOMBRE, PELLIDO, )
-- equpio (CATEGORIA)
-- ombre sede 

SELECT camp.nombre_campeonato, camp.sede ,jug.nombres, jug.apellidos , eq.categoria
FROM Campeonato as camp
INNER JOIN Equipo as eq on camp.id_Campeonato = eq.id_campeonato 
INNER JOIN Jugador AS jug on jug.id_equipo = eq.id_equipo
WHERE eq.categoria = 'MUJERES' and camp.nombre_campeonato ='Campeonato Unifranz' AND camp.sede = 'El Alto'


--DETERNIMAR CUANTOS JUGADORES ESTAN INSCRITOS EN EL EQUIPO GOOGLE Y 
--QUE SEAN VAROINES DONDE EL APELLIDO DEL JUGADOR EMPIEZA CON LA LETRA N

SELECT  COUNT (JUG.id_equipo) 
FROM Equipo as eq  
INNER JOIN Jugador AS jug on eq.id_equipo = jug.id_equipo
WHERE eq.nombre_equipo = 'Google' and eq.categoria = 'VARONES'  AND JUG.apellidos LIKE '%M'


--------------------------------------------------------------------------
-- PREGUNTA 2
-- CREAR UNA FUNCION (type_client)
--  RECIBE UNSOLO PARAMETRO DE TIPO INT
-- DEBE RETORNAR UN TEXTO
-- NOMBRE DE LA VARIABLR (CREDID NUMBRE)
-- SI CREDID NUMBRE ES >50000 ES PLATINIUM
-- SI ES MAYOR O IGUAL A 10000 Y MENOR O IGUAL A 50000 ES GOLD
-- SI ES MENOR A 10000 ES SILVER


ALTER function type_client(@credit_number INTEGER)
returns varchar(20) as
begin
declare @resultado varchar (20);
if @credit_number > 50000
set @resultado = 'PLATINIUM'
if @credit_number <=50000  
set @resultado = 'GOLD'
if @credit_number <10000
set @resultado =  'SILVER';
return (@resultado);  
end;

select dbo.type_client(50001) 'CLIENTE DE TIPO';
select dbo.type_client(50000) 'CLIENTE DE TIPO';
select dbo.type_client(1000) 'CLIENTE DE TIPO';
select dbo.type_client(0) 'CLIENTE DE TIPO';


----------------------------------------------------------------------------
--PREGUNTA 3


--REALIZANDO LA CONSULTA
SELECT COUNT (jug.nombres)
FROM Campeonato AS cam 
inner join Equipo as eq on cam.id_Campeonato = eq.id_campeonato
INNER JOIN Jugador as jug on eq.id_equipo = jug.id_equipo
WHERE jug.nombres like '&S' and jug.apellidos like '%M' and cam.sede = 'El Alto'

--  APLICANDO A UNAFUNCION
ALTER FUNCTION jugadores(@SEDE Varchar(20))
RETURNS INTEGER AS
BEGIN
DECLARE @response INTEGER =0;
 
SELECT @response = COUNT (jug.nombres)
FROM Campeonato AS cam 
inner join Equipo as eq on cam.id_Campeonato = eq.id_campeonato
INNER JOIN Jugador as jug on eq.id_equipo = jug.id_equipo
WHERE jug.nombres like '&S' and jug.apellidos like '%M' and cam.sede = @SEDE

RETURN @response;
END;

-------------------------------------------------
Select dbo.jugadores('El Alto');


						--  INCISO B  --

-- CREANDO LA CONSULTA
SELECT COUNT (eq.categoria)
FROM Equipo as eq 
WHERE eq.nombre_equipo = 'Google' and eq.categoria = 'MUJERES';

-- APLICANDO LA FUNCION
CREATE FUNCTION jugador_v2(@EQUIPO Varchar(20),@CATEGORIA VARCHAR (20))
RETURNS INTEGER AS
BEGIN
 DECLARE @response INTEGER =0;
 
 SELECT @response = COUNT (eq.categoria)
FROM Equipo as eq 
WHERE eq.nombre_equipo = @EQUIPO and eq.categoria = @CATEGORIA

RETURN @response;
END;

------------------------------------------------------
Select dbo.jugador_v2('Google','MUJERES');

--------------------------------------------------------------------------

