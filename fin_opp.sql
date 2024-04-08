create table if not exists Users
(
	id serial not null,
	primary key(id),
	name varchar(128) not null,
	dateBorn date not null,
	cpf varchar(12) unique not null,
	username varchar(128) unique not null,
	email varchar(255) unique,
	passwd varchar(512) not null,
	active boolean not null default true,
	createAt timestamp not null,
	updateAt timestamp
);

create table if not exists FinOpp
(
	id serial not null,
	primary key(id),
	userId int not null,
	foreign key (userId) references Users(id),
	description varchar(255) not null,
	category varchar(64) not null,
	typeOpp varchar(10) not null,
	finMoney decimal(10, 2) not null,
	active boolean not null default true,
	createAt timestamp not null,
	updateAt timestamp
);