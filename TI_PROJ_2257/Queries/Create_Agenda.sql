use Agenda;
create table utilizador (
	id int primary key,
	username varchar(30),
	pass varchar(30)
);

create table tarefa(
	id int primary key,
	titulo varchar(50),
	descricao varchar(500),
	importancia int,
	utilizador int,
	constraint tarefa_utilizador foreign key (utilizador) references utilizador(id)
);