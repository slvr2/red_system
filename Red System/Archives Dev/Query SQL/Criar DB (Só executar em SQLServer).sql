Drop database if exists red_system
Create database red_system;
use red_system;
create table tb_clientes (
	id_clientes int not null primary key,
	nome varchar(60),
	cpf varchar(14),
	cnpj varchar(18),
	celular varchar(16),
	email varchar(60),
	cep varchar(10),
	endereco varchar(60),
	cidade varchar(30),
	estado varchar(19),
	complem varchar(60),
	foto varbinary(MAX),
);


create table tb_produtos (
	id_produtos int not null primary key,
	nome varchar(60),
	data_criacao varchar(16),
	descricao varchar(75),
	preco_venda varchar(18),
	preco_custo varchar(16),
	altura varchar(10),
	largura varchar(10),
	comp varchar(10),
	peso varchar(10),
	material varchar(30),
	fornecedor varchar(30),
	foto1 varbinary(MAX),
	foto2 varbinary(MAX),
);


create table tb_pedidos (
	id_pedidos int identity(1,1) not null primary key,
	cod_cliente varchar(5),
	cliente varchar(60),
	cnpj varchar (18),
	cpf varchar(14),
	itens_json NVARCHAR(MAX),
	obs varchar(75),
	valor_ped varchar(18),
	data_ped varchar(16),
);


create table tb_user (
	id_usuario int identity(1,1) not null primary key,
	usuario varchar(60),
	senha varchar(60),
	acesso varchar(20),
);


Insert into tb_user (usuario, senha, acesso) values ('Clodovil','123','Administrador')






'TESTES'
select * from tb_clientes
select * from tb_produtos
select * from tb_pedidos
select * from tb_user