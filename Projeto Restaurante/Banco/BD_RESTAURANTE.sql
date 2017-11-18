CREATE DATABASE BD_RESTAURANTE
GO

USE BD_RESTAURANTE
GO

CREATE TABLE FORMA_PAGAMENTO (
id_formaPagamento			int		PRIMARY KEY		IDENTITY,
tipo_pagamento				varchar(50),
apagado						bit,
)
go

CREATE TABLE BANDEIRA_CARTAO (
id_bandeiras				int		PRIMARY KEY		IDENTITY,
nome_bandeiras				varchar(50),
taxa						decimal (9,2),
apagado						bit,
id_formaPagamento			int
)
go

CREATE TABLE PAGAMENTO (
id_pagamento				int		PRIMARY KEY		IDENTITY,
Valor						decimal(9,2),
data						date,
apagado						bit,
troco						decimal(9,2), 
id_venda					int,
id_formaPagamento			int,
id_bandeiras				int,
id_caixa					int
)
go

CREATE TABLE GARCOM (
id_garcom					int		PRIMARY KEY		IDENTITY,
codigo						int,
taxa_servico				decimal(9,2),
nome_garcom					varchar(50),
apagado						bit
)
go

CREATE TABLE CATEGORIAPRODUTO (
id_categoriaproduto			int		PRIMARY KEY		IDENTITY,
descricao					varchar(50),
apagado						bit
)
go

CREATE TABLE CATEGORIACARDAPIO (
id_categoriacardapio		int		PRIMARY KEY		IDENTITY,
descricao					varchar(50),
apagado						bit
)
go

CREATE TABLE PRODUTO (
id_produto					int		PRIMARY KEY		IDENTITY,
preco_custo					decimal(9,2),
nome_produto				varchar(50),
estoque_atual				int,
estoque_minimo				int,
apagado						bit,
id_categoriaproduto			int
)
go

CREATE TABLE CARDAPIO (
id_cardapio					int		PRIMARY KEY		IDENTITY,
nome_item					varchar(100),
preco_item					decimal(9,2),
apagado						bit,
id_categoriacardapio		int
)
go

CREATE TABLE MESA (
id_mesa						int		PRIMARY KEY		IDENTITY,
Numero_mesas				int,
Status						tinyint
)
go

CREATE TABLE CONSUMO (
id_consumo					int		PRIMARY KEY		IDENTITY,
quantidade					int,
Subtotal	 				decimal(9,2),
Valor_total 				decimal(9,2),
apagado						bit,
id_cardapio					int,
id_venda					int
)
go

CREATE TABLE VENDA (
id_venda					int		PRIMARY KEY		IDENTITY,
Numero_pessoa				int,
Desconto					decimal(9,2),
Status_venda				tinyint,
Data_entrada				datetime,
Data_saida					datetime,
Couvert_artistico			decimal(9,2),
id_garcom					int,
id_mesa						int
)
go

CREATE TABLE LOGIN (
id_login					int		PRIMARY KEY		IDENTITY,
Usuario						varchar(50),
Senha						varchar(128)
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

CREATE TABLE RESTAURANTE (
id_restaurante				int		PRIMARY KEY		IDENTITY,
Nome_restaurante			varchar(50),
IE							varchar(9),
CNPJ						varchar(14),
Nome_fantasia				varchar(50),
email						varchar(50),
Telefone					int,
Endereco					varchar(50),
numero						int,
Cidade						varchar(50),
Estado						varchar(5),
cep							int
)
go


--chaves estrangeiras 
ALTER TABLE BANDEIRA_CARTAO	 ADD FOREIGN KEY(id_formaPagamento)		REFERENCES FORMA_PAGAMENTO (id_formaPagamento)
ALTER TABLE PAGAMENTO		 ADD FOREIGN KEY(id_venda)				REFERENCES VENDA (id_venda)
ALTER TABLE PAGAMENTO		 ADD FOREIGN KEY(id_caixa)				REFERENCES CAIXA (id_caixa)
ALTER TABLE PAGAMENTO		 ADD FOREIGN KEY(id_formaPagamento)		REFERENCES FORMA_PAGAMENTO (id_formaPagamento)
ALTER TABLE PAGAMENTO		 ADD FOREIGN KEY(id_bandeiras)			REFERENCES BANDEIRA_CARTAO (id_bandeiras)
ALTER TABLE PRODUTO			 ADD FOREIGN KEY(id_categoriaproduto)	REFERENCES CATEGORIAPRODUTO (id_categoriaproduto)
ALTER TABLE CONSUMO			 ADD FOREIGN KEY(id_venda)				REFERENCES VENDA (id_venda)
ALTER TABLE CONSUMO			 ADD FOREIGN KEY(id_cardapio)			REFERENCES CARDAPIO (id_cardapio)
ALTER TABLE CARDAPIO		 ADD FOREIGN KEY(id_categoriacardapio)	REFERENCES CATEGORIACARDAPIO (id_categoriacardapio)
ALTER TABLE VENDA			 ADD FOREIGN KEY(id_mesa)	            REFERENCES MESA (id_mesa)
ALTER TABLE VENDA			 ADD FOREIGN KEY(id_garcom)				REFERENCES GARCOM (id_garcom)




INSERT INTO Login
	(Usuario,Senha)
 VALUES
	('admin','202cb962ac59075b964b07152d234b70')
go



declare @i as int = 1

while(@i <= 100)
begin
	INSERT INTO MESA (Numero_mesas,Status)  VALUES 
	(@i,0)
	set @i = @i+1
end

INSERT INTO CAIXA (valor_inicial, StatusCaixa)
VALUES
	(0,1)

GO

--update mesa set Status = 0
--go

SELECT * from VENDA
go