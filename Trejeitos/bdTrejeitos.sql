create database bdTrejeitos
go

use bdTrejeitos
go

create table Clientes
(
	clienteid int not null primary key identity,
	nome varchar(50) not null,
	email varchar(50) not null,
	senha varchar(12) not null,
	rg varchar(9) not null,
	cpf varchar(11) not null,
	data_nascimento varchar(10) not null,
	endereco varchar(50) not null,
	cidade varchar(20) not null,
	estado varchar(2) not null,
	telefone varchar(11) not null
)
alter table Produtos
 alter column colecao varchar(50) not null
create table Produtos
(
	codigo int not null primary key identity,
	nome varchar(100) not null,
	imagem varchar(255) not null,
	descricao varchar(50) not null,
	colecao varchar(10) not null,
	tamanho varchar(3) not null,
	cor varchar(10) not null,
	preco varchar(20) not null
)

select * from produtos
create table Pedidos
(
	numero int not null primary key identity,
	clienteid int not null references Clientes,
	total int not null,
	desconto int not null,
	frete int not null,
)

create table Carrinho
(
	numero_pedido int not null References Pedidos,
	codigo_produto int not null references Produtos,

	qtd int not null,

	primary key(numero_pedido,codigo_produto)
)

select * from Clientes