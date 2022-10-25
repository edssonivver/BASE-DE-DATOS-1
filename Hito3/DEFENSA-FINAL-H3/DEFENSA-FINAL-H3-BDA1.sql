create database Unifranzitos;
use Unifranzitos;

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



--3. MANEJO DE CONSULTAS 
-- 3.1 Mostrar que jugadores que son del equipo equ-222Select jug.nombres , jug.apellidos, equi.id_equipo
from Jugador as jug 
inner join Equipo as equi on  equi.id_equipo = jug.id_equipo
where equi.id_equipo = 'equ-222';

-- 3.2 Mostrar que jugadores(nombres, apellidos) que juegan en la sede de El Alto.Select jug.nombres, jug.apellidos , camp.sede From Campeonato as campinner join Equipo as equi on camp.id_Campeonato = equi.id_campeonatoinner join Jugador as jug on jug.id_equipo = equi.id_equipowhere camp.sede= 'El Alto';
-- 3.3. Mostrar aquellos jugadores mayores o igual a 21 años que sean de la categoría VARONES
select jug.nombres ,jug.apellidos, jug.edad, equi.categoria
from Equipo as equi
inner join Jugador as jug  on jug.id_equipo = equi.id_equipo 
where  equi.categoria = 'VARONES' and jug.edad >= 21; 

-- 3.4. Mostrar a todos los estudiantes en donde su apellido empiece con la letra S.
select jug.apellidos, jug.nombres, jug.id_equipo, jug.id_jugador
from Jugador as jug
where jug.apellidos like '%s';  

-- 3.5. Mostrar que equipos forman parte del campeonato camp-111 y además sean de la categoría MUJERES.select equi.nombre_equipo, camp.id_Campeonato, equi.categoria
from Campeonato as camp
inner join Equipo as equi on equi.id_campeonato = camp.id_Campeonato 
where equi.categoria = 'MUJERES';

-- 3.6. Mostrar el nombre del equipo del jugador con id_jugador igual a jug-333select equi.nombre_equipo, jug.id_jugador
from Equipo as equi
inner join Jugador as jug on jug.id_equipo = equi.id_equipo
where jug.id_jugador = 'jug-333'
-- 3.7. Mostrar el nombre del campeonato del jugador con id_jugador igual a jug-333select camp.nombre_campeonato ,jug.id_jugador, jug.nombres, jug.apellidos 
from Campeonato as camp
inner join Equipo as equi on equi.id_campeonato = camp.id_Campeonato
inner join Jugador as jug on jug.id_equipo = equi.id_equipo
where jug.id_jugador = 'jug-333';

-- 3.8. Crear una consulta SQL que maneje las 3 tablas de la base de datos.select camp.sede, equi.nombre_equipo, jug.nombres, jug.apellidos , jug.edad
from Campeonato as camp
inner join Equipo as equi on equi.id_campeonato = camp.id_Campeonato
inner join Jugador as jug on jug.id_equipo = equi.id_equipo;

-- 3.9. ¿Qué estrategia utilizaría para determinar cuántos equipos inscritos hay?
-- Podría utilizar la función de agregación COUNT

-- Primera Forma
select count (*) Numero_de_Equipos_Inscritos
from Equipo
WHERE id_campeonato = 'camp-111' or id_campeonato = 'camp-222';

-- Segunda Forma
SELECT COUNT(*) Numero_de_Equipos_Inscritos
FROM Campeonato AS camp
INNER JOIN Equipo AS equi on camp.id_Campeonato = equi.id_campeonato
where equi.id_campeonato = 'camp-111' or equi.id_campeonato = 'camp-222';

-- 3.10. ¿Qué estrategia utilizaría para determinar cuántos jugadores 
   -- pertenecen a la categoría VARONES o Categoria MUJERES.
   --Para esto puede utilizar la función de agregación COUNT

-- PARA MUJERES 
select * from Equipo;
select * from Jugador;

SELECT COUNT(*) Numero_Jugadoras_Mujeres
FROM Equipo AS equi
INNER JOIN Jugador AS Jug on equi.id_equipo = jug.id_equipo
where equi.categoria = 'MUJERES';

-- PARA VARONES
select * from Equipo;
select * from Jugador;

SELECT COUNT(*) Numero_Jugadores_Varones
FROM Equipo AS equi
INNER JOIN Jugador AS Jug on equi.id_equipo = jug.id_equipo
where equi.categoria = 'VARONES';




