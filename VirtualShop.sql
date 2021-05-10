create database virtualshop;
use virtualshop;

create table product(
id int unsigned auto_increment primary key,
name varchar(30) not null ,
description varchar(50) not null,
value double not null,
providerID int not null,
categoryID int not null,
photo varchar(30) not null,
quantityStok int  not null
)ENGINE=INNODB;

create table categtory(
id int unsigned auto_increment not null primary key,
name varchar(80) not null,
description varchar(150) not null
)ENGINE=INNODB;

create table provider(
id int unsigned auto_increment not null primary key,
name varchar(30) not null,
cnpj char(14) not null,
email varchar(80) not null,
phone varchar(15) not null,
nameAgent varchar (30) not null,
numberAgent int unsigned not null
)ENGINE=INNODB;

create table client(
id int unsigned auto_increment not null primary key,
name varchar(30) not null,
phone char(15) not null,
cpf char(14) not null,
email varchar(80),
password varchar(80) not null
)ENGINE=INNODB;

create table aderess(
idclient int unsigned not null primary key,
street varchar(80) not null,
cep char(10) not null
)ENGINE=INNODB;
