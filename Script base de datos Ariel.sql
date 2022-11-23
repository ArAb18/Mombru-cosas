
CREATE SCHEMA `` ;
use libro;
create table libro (
 id_libro int auto_increment,
 genero_libro varchar(15),
 nombre varchar(20),
 editorial varchar(15),
 autor varchar(15),
 PRIMARY KEY (id_libro)
);

select* from libro;
select
genero_libro,
editorial
from libro where editorial="JoJO" and genero_libro = 'terror' or genero_libro='suspenso';

select 
genero_libro, 
editorial,
autor
from libro where genero_libro= 'suspenso' or genero_libro='terror'
group by editorial = 'PANINI'
having autor='Junji Ito';

select count(id_libro) from libro where genero_libro='ciencia ficcion';
select sum(editorial) from libro where autor='Edgar Alan Poe';

create database gimnasio;
use gimnasio;

create table datos(
id_dato int auto_increment,
tipo_ejercicio varchar(15),
repeticiones int,
peso_repeticiones int,
semana int,
PRIMARY KEY(id_dato)
);
create table usuario(
nombre varchar(20),
contraseña varchar(20),
mail varchar(20),
id_usuario int auto_increment,
primary key(id_usuario)
);

 select * from datos;
