CREATE DATABASE BD_RESTAURANTE
GO

USE BD_RESTAURANTE
GO


CREATE TABLE RESTAURANTE (
id_restaurante				int		PRIMARY KEY		IDENTITY,
Nome_restaurante			varchar(250),
IE							varchar(220),
CNPJ						varchar(220),
Nome_fantasia				varchar(250),
email						varchar(250),
Telefone					varchar(250),
Endereco					varchar(50),
numero						int,
Cidade						varchar(250),
Estado						varchar(220),
cep							varchar(250)
)
go

CREATE TABLE PAGAMENTO (
id_pagamento		int		PRIMARY KEY		IDENTITY,
Valor_total			decimal(9,2),
Valor_recebido		decimal(9,2),
data				date,
troco				decimal(9,2),
id_caixa			int,
id_venda			int,
id_bandeira			int,
id_formapagamento	int
)
go

CREATE TABLE CAIXA (
id_caixa					int		PRIMARY KEY		IDENTITY,
data_fechamento				datetime,
valor_inicial				decimal(9,2),
valor_final					decimal(9,2),
data_abertura				datetime,
diferença					decimal(9,2),
StatusCaixa					tinyint
)
go

CREATE TABLE FORMA_PAGAMENTO (
id_formapagamento	int		PRIMARY KEY		IDENTITY,
tipo_pagamento		varchar(200),
apagado				bit
)
go

CREATE TABLE BANDEIRA_CARTAO (
id_bandeira			int		PRIMARY KEY		IDENTITY,
nome_bandeira		varchar(200),
apagado				bit,
id_formaPagamento	int
)
go

CREATE TABLE MESA (
id_mesa				int		PRIMARY KEY		IDENTITY,
Status				int,
Numero_mesas		int
)
go

CREATE TABLE CATEGORIACARDAPIO (
id_categoriacardapio		int		PRIMARY KEY		IDENTITY,
descricao					varchar(50),
apagado						bit
)
go

CREATE TABLE CONSUMO (
id_consumo			int		PRIMARY KEY		IDENTITY,
quantidade			int,
Subtotal	 		decimal(9,2),
Valor_total 		decimal(9,2),
apagado				bit,
id_venda			int,
id_cardapio			int
)
go

CREATE TABLE CARDAPIO (
id_cardapio			int		PRIMARY KEY		IDENTITY,
nome_item			varchar(200),
preco_item			decimal(9,2),
apagado				bit,
id_categoriacardapio int
)
go

CREATE TABLE CATEGORIAPRODUTO (
id_categoriaproduto			int		PRIMARY KEY		IDENTITY,
descricao					varchar(200),
apagado						bit
)
go

CREATE TABLE PRODUTO (
id_produto			int		PRIMARY KEY		IDENTITY,
nome_produto		varchar(200),
preco_custo			decimal(9,2),
estoque_minimo		int,
estoque_atual		int,
apagado				bit,
id_categoriaproduto int
)
go

CREATE TABLE USUARIO (
id_usuario			int		PRIMARY KEY		IDENTITY,
nome				varchar(200),
login				varchar(200),
senha				varchar(200),
apagado				bit,
id_cargo			int
)
go

CREATE TABLE CARGO (
id_cargo			int		PRIMARY KEY		IDENTITY,
descricao			varchar(200)	
)
GO

CREATE TABLE VENDA (
id_venda			int		PRIMARY KEY		IDENTITY,
Desconto			varchar(200),
Numero_pessoa		int,
Data_entrada		datetime,
Data_saida			datetime,
Status_venda		int,
taxa_servico		decimal(9,2),
couvert				decimal(9,2),
id_usuario			int,
id_mesa				int
)
go


CREATE TABLE COUVERT_ARTISTICO (
id_couvert			int		PRIMARY KEY		IDENTITY,
Data				date,
valor				decimal(9,2),
id_venda			int
)
go

CREATE TABLE TAXA_SERVICO (
id_taxaservico		int		PRIMARY KEY		IDENTITY,
valor				decimal(9,2),
data				date,
id_usuario			int,
id_venda			int
)
go

CREATE TABLE ESTOQUE (
id_estoque			int		PRIMARY KEY		IDENTITY,
Data_entrada		date,
quantidade_entrada	int,
id_produto			int
)
go


--chaves estrangeiras
ALTER TABLE USUARIO ADD FOREIGN KEY (id_cargo) REFERENCES CARGO (id_cargo)
ALTER TABLE VENDA ADD FOREIGN KEY(id_usuario) REFERENCES USUARIO (id_usuario)
ALTER TABLE VENDA ADD FOREIGN KEY(id_mesa) REFERENCES MESA (id_mesa)
ALTER TABLE TAXA_SERVICO ADD FOREIGN KEY(id_usuario) REFERENCES USUARIO (id_usuario)
ALTER TABLE ESTOQUE ADD FOREIGN KEY(id_produto) REFERENCES PRODUTO (id_produto)
ALTER TABLE PAGAMENTO ADD FOREIGN KEY(id_caixa) REFERENCES CAIXA (id_caixa)
ALTER TABLE PAGAMENTO ADD FOREIGN KEY(id_venda) REFERENCES VENDA (id_venda)
ALTER TABLE PAGAMENTO ADD FOREIGN KEY(id_bandeira) REFERENCES BANDEIRA_CARTAO (id_bandeira)
ALTER TABLE PAGAMENTO ADD FOREIGN KEY(id_formapagamento) REFERENCES FORMA_PAGAMENTO (id_formapagamento)
ALTER TABLE BANDEIRA_CARTAO	 ADD FOREIGN KEY(id_formaPagamento)	REFERENCES FORMA_PAGAMENTO (id_formaPagamento)
ALTER TABLE CONSUMO ADD FOREIGN KEY(id_venda) REFERENCES VENDA (id_venda)
ALTER TABLE CONSUMO ADD FOREIGN KEY(id_cardapio) REFERENCES CARDAPIO (id_cardapio)
ALTER TABLE TAXA_SERVICO ADD FOREIGN KEY(id_venda) REFERENCES VENDA (id_venda)
ALTER TABLE COUVERT_ARTISTICO ADD FOREIGN KEY(id_venda) REFERENCES VENDA (id_venda)
ALTER TABLE PRODUTO ADD FOREIGN KEY(id_categoriaproduto) REFERENCES CATEGORIAPRODUTO (id_categoriaproduto)
ALTER TABLE CARDAPIO ADD FOREIGN KEY(id_categoriacardapio) REFERENCES CATEGORIACARDAPIO (id_categoriacardapio)


declare @i as int = 1

while(@i <= 100)
begin
	INSERT INTO MESA (Numero_mesas,Status)  VALUES 
	(@i,0)
	set @i = @i+1
end


INSERT INTO CARGO
	(descricao)
VALUES
	('Proprietario'),
	('Gerente'),
	('Maitre'),
	('Garçom')
GO
