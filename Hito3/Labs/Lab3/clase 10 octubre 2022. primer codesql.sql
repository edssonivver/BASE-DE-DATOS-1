Create Database Universidad5;

use Universidad5;

Create table nombres_dba_i(
id_est varchar (90) primary key not null,
nombres varchar (100) not null
);

insert into nombres_dba_i (id_est,nombres)
values ('SIS-112233','William');
insert into nombres_dba_i (id_est,nombres)
values ('SIS-445566','Victor');
insert into nombres_dba_i (id_est,nombres)
values ('SIS-778899','Mijail');
insert into nombres_dba_i ( id_est,nombres)
values ('SIS-001122','Karen');
insert into nombres_dba_i ( id_est,nombres)
values ('SIS-002233','Brayan');
insert into nombres_dba_i ( id_est,nombres)
values ('SIS-003344','Ariel');

select * from nombres_dba_i;


Create table nombres_dba_ii(
id_est varchar (90) primary key not null,
nombres varchar (100) not null
);

insert into nombres_dba_ii ( id_est,nombres)
values ('SIS-445566','Victor');
insert into nombres_dba_ii ( id_est,nombres)
values ('SIS-002233','Brayan');
insert into nombres_dba_ii (id_est, nombres)
values('SIS-123456','Samuel');
insert into nombres_dba_ii ( id_est,nombres)
values ('SIS-456789','Ana');

select * from nombres_dba_ii;

/*Select nom_bda_i.id_est, nom_bda_i.nombres , nom_bda_ii.id_est, nom_bda_ii.nombres 
 FROM nombres_dba_i AS nom_bda_i
	INNER JOIN nombres_dba_ii AS nom_bda_ii On  nom_bda_i.id_est =  nom_bda_ii.id_est and  nom_bda_i.nombres =  nom_bda_ii.nombres
*/ 

   select nom1.nombres,nom2.nombres
   from nombres_dba_i as nom1 
   inner join nombres_dba_ii as nom2 on nom1.id_est = nom2.id_est; 

   --select nom_i.nombres,nom_2.nombres
   --from nombres_dba_i as nom_i
   --inner join nombres_dba_ii as nom_2 on nom_i.id_est = nom_2.id_est;