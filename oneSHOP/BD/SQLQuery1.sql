--Criando o Banco de dados.
CREATE DATABASE BD_OneShop
USE BD_OneShop


--Criando as tabelas.
CREATE TABLE Empresa(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	CNPJ VARCHAR(20) NOT NULL,
	Endereco VARCHAR(150) NOT NULL,
	Numero VARCHAR(10) NOT NULL,
	Bairro VARCHAR(100) NOT NULL,
	CEP INT NOT NULL,
	Cidade VARCHAR(50) NOT NULL,
	Estado VARCHAR(2) NOT NULL,
	ID_Usuario INT NULL,
)
CREATE TABLE Usuario(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	_Login VARCHAR(50) NOT NULL,
	Senha VARCHAR(50) NOT NULL,
)
CREATE TABLE Produto(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Referencia VARCHAR(20) NOT NULL,
	Preco_Custo FLOAT NOT NULL,
	Preco_Venda FLOAT NOT NULL,
	Codigo VARCHAR(30) NOT NULL,
	Tipo_Codigo VARCHAR(100) NOT NULL,
	ID_Fiscal INT NULL,
	ID_Usuario INT NULL,
	ID_Grupo INT NULL,
	Foto VARCHAR(300) NULL,
	Qt_Estoque INT NULL,
	Qt_Rua INT NULL,
	Inf_Adicionais VARCHAR(500) NULL,
	ID_Tamanho INT NULL,
	ID_Linha INT NULL,
	ID_Fornecedor INT NULL,
)
CREATE TABLE Pedido(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Valor FLOAT NOT NULL,
	Valor_de_Venda FLOAT NOT NULL,
	Valor_de_Comissao FLOAT NOT NULL,
	Valor_Recebimento FLOAT NOT NULL,
	_Status VARCHAR(50) NOT NULL,
	ID_Usuario INT NULL,
	ID_Pessoa INT NULL,
	Observacoes VARCHAR(500) NULL,
)
CREATE TABLE Pedido_Produto(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Valor_Produto FLOAT NOT NULL,
	Quantidade INT NOT NULL,
	ID_Pedido INT NULL,
	ID_Produto INT NULL,
)
CREATE TABLE Movimento(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Valor_Bruto FLOAT NOT NULL,
	Valor_Liquido FLOAT NOT NULL,
	Data_de_Emissao SMALLDATETIME NOT NULL,
	Tipo VARCHAR(50) NOT NULL,
	ID_Usuario INT NULL,
	ID_Pessoa INT NULL,
)
CREATE TABLE Movimento_Produto(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Valor_Produto FLOAT NOT NULL,
	Quantidade INT NOT NULL,
	ID_Movimento INT NULL,
	ID_Produto INT NULL
)
CREATE TABLE Lancamento(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Valor FLOAT NOT NULL,
	Desconto_Comissao FLOAT NULL,
	Emissao SMALLDATETIME NOT NULL,
	Vencimento SMALLDATETIME NOT NULL,
	_Status VARCHAR(100) NOT NULL,
	Venda BIT NOT NULL,
	ID_Usuario INT NULL,
	ID_Natureza INT NULL,
	ID_Conta INT NULL,
	ID_Forma_de_Pagamento INT NULL,
	Baixa SMALLDATETIME NULL,
	Descricao VARCHAR(500) NULL,
)
CREATE TABLE Lancamento_Produto(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Valor_Produto FLOAT NOT NULL,
	Quantidade INT NOT NULL,
	ID_Lancamento INT NULL,
	ID_Produto INT NULL,
)
CREATE TABLE Pessoa(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	CPF VARCHAR(25) NOT NULL,
	Funcao VARCHAR(50) NOT NULL,
	Verifica_Comissao BIT NOT NULL,
	CEP VARCHAR(20) NOT NULL,
	Endereco VARCHAR(200) NOT NULL,
	Bairro VARCHAR(200) NOT NULL,
	Cidade VARCHAR(200) NOT NULL,
	UF VARCHAR(3) NOT NULL,
	ID_Usuario INT NULL,
	ID_Praca INT NULL,
	Comissao FLOAT NULL,
	Fator_de_limite INT NULL,
	Foto VARCHAR(200) NULL,
	Nascimento SMALLDATETIME NULL,
	Email VARCHAR(50) NULL,
	Telefone VARCHAR(20) NULL,
)
CREATE TABLE Fornecedor(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	CNPJ VARCHAR(25) NULL,
	Endereco VARCHAR(200) NULL,
	Telefone VARCHAR(20) NULL,
	ID_Usuario INT NULL,
)
CREATE TABLE Tamanho(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(10) NOT NULL,
)
CREATE TABLE Grupo(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Estoque_min INT NULL,
	Estoque_max INT NULL,
)
CREATE TABLE Linha(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
)
CREATE TABLE Forma_de_Pagamento(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Taxa1 FLOAT NULL,
	Taxa2 FLOAT NULL,
	Taxa3 FLOAT NULL,
	Taxa4 FLOAT NULL,
	Taxa5 FLOAT NULL,
	Taxa6 FLOAT NULL,
	Taxa7 FLOAT NULL,
	Taxa8 FLOAT NULL,
	Taxa9 FLOAT NULL,
	Taxa10 FLOAT NULL,
	Taxa11 FLOAT NULL,
	Taxa12 FLOAT NULL,
)
CREATE TABLE Praca(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
)
CREATE TABLE Conta(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	ID_Carteira INT NULL,
)
CREATE TABLE Carteira(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
)
CREATE TABLE Natureza(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	ID_Grupo_Natureza INT NULL,
)
CREATE TABLE Grupo_Natureza(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
)
CREATE TABLE Fiscal(
	ID INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	ncm VARCHAR(50) NOT NULL,
	unidade VARCHAR(3) NOT NULL,
	origem INT NOT NULL,
	classe_imposto VARCHAR(20) NOT NULL,
	ID_Usuario INT NULL,
)
--Inserindo as chaves estrangeiras

ALTER TABLE Empresa ADD FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID)

ALTER TABLE Produto ADD FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID)
ALTER TABLE Produto ADD FOREIGN KEY (ID_Tamanho) REFERENCES Tamanho(ID)
ALTER TABLE Produto ADD FOREIGN KEY (ID_Grupo) REFERENCES Grupo(ID)
ALTER TABLE Produto ADD FOREIGN KEY (ID_Linha) REFERENCES Linha(ID)
ALTER TABLE Produto ADD FOREIGN KEY (ID_Fornecedor) REFERENCES Fornecedor(ID)
ALTER TABLE Produto ADD FOREIGN KEY (ID_Fiscal) REFERENCES Fiscal(ID)

ALTER TABLE Pedido ADD FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID)
ALTER TABLE Pedido ADD FOREIGN KEY (ID_Pessoa) REFERENCES Pessoa(ID)

ALTER TABLE Pedido_Produto ADD FOREIGN KEY (ID_Pedido) REFERENCES Pedido(ID)
ALTER TABLE Pedido_Produto ADD FOREIGN KEY (ID_Produto) REFERENCES Produto(ID)

ALTER TABLE Movimento ADD FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID)
ALTER TABLE Movimento ADD FOREIGN KEY (ID_Pessoa) REFERENCES Pessoa(ID)

ALTER TABLE Movimento_Produto ADD FOREIGN KEY (ID_Movimento) REFERENCES Movimento(ID)
ALTER TABLE Movimento_Produto ADD FOREIGN KEY (ID_Produto) REFERENCES Produto(ID)

ALTER TABLE Lancamento ADD FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID)
ALTER TABLE Lancamento ADD FOREIGN KEY (ID_Natureza) REFERENCES Natureza(ID)
ALTER TABLE Lancamento ADD FOREIGN KEY (ID_Conta) REFERENCES Conta(ID)
ALTER TABLE Lancamento ADD FOREIGN KEY (ID_Forma_de_Pagamento) REFERENCES Forma_de_Pagamento(ID)

ALTER TABLE Lancamento_Produto ADD FOREIGN KEY (ID_Lancamento) REFERENCES Lancamento(ID)
ALTER TABLE Lancamento_Produto ADD FOREIGN KEY (ID_Produto) REFERENCES Produto(ID)

ALTER TABLE Pessoa ADD FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID)
ALTER TABLE Pessoa ADD FOREIGN KEY (ID_Praca) REFERENCES Praca(ID)

ALTER TABLE Fornecedor ADD FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID)

ALTER TABLE Conta ADD FOREIGN KEY (ID_Carteira) REFERENCES Carteira(ID)

ALTER TABLE Natureza ADD FOREIGN KEY (ID_Grupo_Natureza) REFERENCES Grupo_Natureza(ID)

ALTER TABLE Fiscal ADD FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID)

--Procedures

--Sem parametros
GO
CREATE PROCEDURE BuscaEmpresa AS SELECT * FROM Empresa
GO
CREATE PROCEDURE BuscaUsuario AS SELECT * FROM Usuario
GO
CREATE PROCEDURE BuscaProduto AS SELECT * FROM Produto
GO
CREATE PROCEDURE BuscaPedido AS SELECT * FROM Pedido
GO
CREATE PROCEDURE BuscaPedido_Produto AS SELECT * FROM Pedido_Produto
GO
CREATE PROCEDURE BuscaMovimento AS SELECT * FROM Movimento
GO
CREATE PROCEDURE BuscaMovimento_Produto AS SELECT * FROM Movimento_Produto
GO
CREATE PROCEDURE BuscaLancamento AS SELECT * FROM Lancamento
GO
CREATE PROCEDURE BuscaLancamento_Produto AS SELECT * FROM Lancamento_Produto
GO
CREATE PROCEDURE BuscaPessoa AS SELECT * FROM Pessoa
GO
CREATE PROCEDURE BuscaFornecedor AS SELECT * FROM Fornecedor
GO
CREATE PROCEDURE BuscaTamanho AS SELECT * FROM Tamanho
GO
CREATE PROCEDURE BuscaGrupo AS SELECT * FROM Grupo
GO
CREATE PROCEDURE BuscaLinha AS SELECT * FROM Linha
GO
CREATE PROCEDURE BuscaForma_de_Pagamento AS SELECT * FROM Forma_de_Pagamento
GO
CREATE PROCEDURE BuscaPraca AS SELECT * FROM Praca
GO
CREATE PROCEDURE BuscaConta AS SELECT * FROM Conta
GO
CREATE PROCEDURE BuscaCarteira AS SELECT * FROM Carteira
GO
CREATE PROCEDURE BuscaNatureza AS SELECT * FROM Natureza
GO
CREATE PROCEDURE BuscaGrupo_Natureza AS SELECT * FROM Grupo_Natureza
GO
CREATE PROCEDURE BuscaFiscal AS SELECT * FROM Fiscal

--Com parametro de ID
GO
CREATE PROCEDURE BuscaEmpresaID @Valor1	INT AS SELECT * FROM Empresa WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaUsuarioID @Valor1	INT AS SELECT * FROM Usuario WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaProdutoID @Valor1	INT AS SELECT * FROM Produto WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaPedidoID @Valor1	INT AS SELECT * FROM Pedido WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaPedido_ProdutoID @Valor1 INT AS SELECT * FROM Pedido_Produto WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaMovimentoID @Valor1 INT AS SELECT * FROM Movimento WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaMovimento_ProdutoID @Valor1 INT AS SELECT * FROM Movimento_Produto WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaLancamentoID @Valor1 INT AS SELECT * FROM Lancamento WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaLancamento_ProdutoID @Valor1 INT AS SELECT * FROM Lancamento_Produto WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaPessoaID @Valor1 INT AS SELECT * FROM Pessoa WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaFornecedorID @Valor1 INT AS SELECT * FROM Fornecedor WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaTamanhoID @Valor1	INT AS SELECT * FROM Tamanho WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaGrupoID @Valor1 INT AS SELECT * FROM Grupo WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaLinhaID @Valor1 INT AS SELECT * FROM Linha WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaForma_de_PagamentoID @Valor1 INT AS SELECT * FROM Forma_de_Pagamento WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaPracaID @Valor1 INT AS SELECT * FROM Praca WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaContaID @Valor1 INT AS SELECT * FROM Conta WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaCarteiraID @Valor1 INT AS SELECT * FROM Carteira WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaNaturezaID @Valor1 INT AS SELECT * FROM Natureza WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaGrupo_NaturezaID @Valor1 INT AS SELECT * FROM Grupo_Natureza WHERE ID = @Valor1
GO
CREATE PROCEDURE BuscaFiscalID @Valor1 INT AS SELECT * FROM Fiscal WHERE ID = @Valor1
GO
--Com outros parametros
GO
CREATE PROCEDURE BuscaProdutoNome @Nome VARCHAR(100) AS SELECT * FROM Produto WHERE Nome LIKE CONCAT('%',@Nome,'%')
GO
CREATE PROCEDURE BuscaPedidoNome @Nome VARCHAR(100) AS SELECT * FROM Pedido WHERE Nome LIKE CONCAT('%',@Nome,'%')
GO
CREATE PROCEDURE BuscaMovimentoNome @Nome VARCHAR(100) AS SELECT * FROM Movimento WHERE Nome LIKE CONCAT('%',@Nome,'%')
GO
CREATE PROCEDURE BuscaLancamentoNome @Nome VARCHAR(100) AS SELECT * FROM Lancamento WHERE Nome LIKE CONCAT('%',@Nome,'%')
GO
CREATE PROCEDURE BuscaPessoaNome @Nome VARCHAR(100) AS SELECT * FROM Pessoa WHERE Nome LIKE CONCAT('%', @Nome, '%')
GO
CREATE PROCEDURE BuscaProdutoCodigo @Codigo VARCHAR(30) AS SELECT * FROM Produto WHERE Codigo = @Codigo
GO
CREATE PROCEDURE BuscaPessoaNome2 @Nome VARCHAR(100) AS SELECT A.ID AS Código, A.Nome,A.CPF AS CPF, B.Nome AS Praca FROM Pessoa A, Praca B WHERE A.Nome LIKE CONCAT('%',@Nome,'%') AND A.ID_Praca = B.ID
GO
CREATE PROCEDURE BuscaPedido2 AS SELECT _Status AS Situação,ID AS Código, Nome AS Descrição, FORMAT(Valor, 'C', 'pt-br') FROM Pedido
GO
execute BuscaProduto
--Inserção
GO
CREATE PROCEDURE InserirEmpresa 
	@Nome VARCHAR(50),
	@CNPJ VARCHAR(20),
	@Endereco VARCHAR(150),
	@Numero VARCHAR(10),
	@Bairro VARCHAR(100),
	@CEP INT,
	@Cidade VARCHAR(50),
	@Estado VARCHAR(2),
	@ID_Empresa INT
	AS INSERT INTO Empresa VALUES(@Nome, @CNPJ, @Endereco, @Numero, @Bairro, @CEP, @Cidade, @Estado, @ID_Empresa)
GO
CREATE PROCEDURE InserirUsuario
	@_Login VARCHAR(50),
	@Senha VARCHAR(50)
	AS INSERT INTO Usuario VALUES(@_Login, @Senha)
GO
CREATE PROCEDURE InserirProduto
	@Nome VARCHAR(50),
	@Referencia VARCHAR(20),
	@Preco_Custo FLOAT,
	@Preco_Venda FLOAT,
	@Codigo VARCHAR(30),
	@Tipo_Codigo VARCHAR(100),
	@ID_Fiscal INT,
	@ID_Usuario INT,
	@ID_Grupo INT,
	@Foto VARCHAR(300),
	@Qt_Estoque INT,
	@Qt_Rua INT,
	@Inf_Adicionais VARCHAR(500),
	@ID_Tamanho INT,
	@ID_Linha INT,
	@ID_Fornecedor INT
	AS INSERT INTO Produto VALUES(@Nome, @Referencia, @Preco_Custo, @Preco_Venda, @Codigo, @Tipo_Codigo, @ID_Fiscal, @ID_Usuario, @ID_Grupo, @Foto, @Qt_Estoque, @Qt_Rua, @Inf_Adicionais, @ID_Tamanho, @ID_Linha, @ID_Fornecedor)
GO
CREATE PROCEDURE InserirPedido
	@Nome VARCHAR(100),
	@Valor FLOAT,
	@Valor_de_Venda FLOAT,
	@Valor_de_Comissao FLOAT,
	@Valor_Recebimento FLOAT,
	@_Status VARCHAR(50),
	@ID_Usuario INT,
	@ID_Pessoa INT,
	@Observacoes VARCHAR(500)
	AS INSERT INTO Pedido VALUES(@Nome, @Valor,@Valor_de_Venda, @Valor_de_Comissao, @Valor_Recebimento, @_Status, @ID_Usuario, @ID_Pessoa, @Observacoes)
GO
CREATE PROCEDURE InserirPedido_Produto
	@Valor_Produto FLOAT,
	@Quantidade INT,
	@ID_Pedido INT,
	@ID_Produto INT
	AS INSERT INTO Pedido_Produto VALUES(@Valor_Produto, @Quantidade, @ID_Pedido, @ID_Produto)
GO
CREATE PROCEDURE InserirMovimento
	@Nome VARCHAR(100),
	@Valor_Bruto FLOAT,
	@Valor_Liquido FLOAT,
	@Data_de_Emissao SMALLDATETIME,
	@Tipo VARCHAR(50),
	@ID_Usuario INT,
	@ID_Pessoa INT
	AS INSERT INTO Movimento VALUES(@Nome,@Valor_Bruto, @Valor_Liquido, @Data_de_Emissao, @Tipo, @ID_Usuario, @ID_Pessoa)
GO
CREATE PROCEDURE InserirMovimento_Produto
	@Valor_Produto FLOAT,
	@Quantidade INT,
	@ID_Movimento INT,
	@ID_Produto INT
	AS INSERT INTO Movimento_Produto VALUES(@Valor_Produto, @Quantidade, @ID_Movimento, @ID_Produto)
GO
CREATE PROCEDURE InserirLancamento
	@Nome VARCHAR(50),
	@Valor FLOAT,
	@Desconto_Comissao FLOAT,
	@Emissao SMALLDATETIME,
	@Vencimento SMALLDATETIME,
	@_Status VARCHAR(100),
	@Venda BIT,
	@ID_Usuario INT,
	@ID_Natureza INT,
	@ID_Conta INT,
	@ID_Forma_de_Pagamento INT,
	@Baixa SMALLDATETIME,
	@Descricao VARCHAR(500)
	AS INSERT INTO Lancamento VALUES(@Nome, @Valor, @Desconto_Comissao, @Emissao, @Vencimento, @_Status, @Venda, @ID_Usuario, @ID_Natureza, @ID_Conta, @ID_Forma_de_Pagamento, @Baixa, @Descricao)
GO
CREATE PROCEDURE InserirLancamento_Produto
	@Valor_Produto FLOAT,
	@Quantidade INT,
	@ID_Lancamento INT,
	@ID_Produto INT
	AS INSERT INTO Lancamento_Produto VALUES(@Valor_Produto, @Quantidade, @ID_Lancamento, @ID_Produto)
GO
CREATE PROCEDURE InserirPessoa
	@Nome VARCHAR(100),
	@CPF VARCHAR(25),
	@Funcao VARCHAR(50),
	@Verifica_Comissao BIT,
	@CEP VARCHAR(20),
	@Endereco VARCHAR(200),
	@Bairro VARCHAR(200),
	@Cidade VARCHAR(200),
	@UF VARCHAR(3),
	@ID_Usuario INT,
	@ID_Praca INT,
	@Comissao FLOAT,
	@Fator_de_limite INT,
	@Foto VARCHAR(200),
	@Nascimento SMALLDATETIME,
	@Email VARCHAR(50),
	@Telefone VARCHAR(20)
	AS INSERT INTO Pessoa VALUES(@Nome, @CPF, @Funcao, @Verifica_Comissao, @CEP, @Endereco, @Bairro, @Cidade, @UF, @ID_Usuario, @ID_Praca, @Comissao, @Fator_de_limite, @Foto, @Nascimento, @Email, @Telefone)
GO
CREATE PROCEDURE InserirFornecedor
	@Nome VARCHAR(100),
	@CNPJ VARCHAR(25),
	@Endereco VARCHAR(200),
	@Telefone VARCHAR(20),
	@ID_Usuario INT
	AS INSERT INTO Fornecedor VALUES(@Nome, @CNPJ, @Endereco, @Telefone, @ID_Usuario)
GO
CREATE PROCEDURE InserirTamanho
	@Nome VARCHAR(10)
	AS INSERT INTO Tamanho VALUES(@Nome)
GO
CREATE PROCEDURE InserirGrupo
	@Nome VARCHAR(100),
	@Estoque_min INT,
	@Estoque_max INT
	AS INSERT INTO Grupo VALUES(@Nome, @Estoque_min, @Estoque_max)
GO
CREATE PROCEDURE InserirLinha
	@Nome VARCHAR(100)
	AS INSERT INTO Linha VALUES(@Nome)
GO
CREATE PROCEDURE InserirForma_de_Pagamento
	@Nome VARCHAR(50),
	@Taxa1 FLOAT,
	@Taxa2 FLOAT,
	@Taxa3 FLOAT,
	@Taxa4 FLOAT,
	@Taxa5 FLOAT,
	@Taxa6 FLOAT,
	@Taxa7 FLOAT,
	@Taxa8 FLOAT,
	@Taxa9 FLOAT,
	@Taxa10 FLOAT,
	@Taxa11 FLOAT,
	@Taxa12 FLOAT
	AS INSERT INTO Forma_de_Pagamento VALUES(@Nome, @Taxa1, @Taxa2, @Taxa3, @Taxa4, @Taxa5, @Taxa6, @Taxa7, @Taxa8, @Taxa9, @Taxa10, @Taxa11, @Taxa12)
GO
CREATE PROCEDURE InserirPraca
	@Nome VARCHAR(100)
	AS INSERT INTO Praca VALUES(@Nome)
GO
CREATE PROCEDURE InserirConta
	@Nome VARCHAR(100),
	@ID_Carteira INT
	AS INSERT INTO Conta VALUES(@Nome, @ID_Carteira)
GO
CREATE PROCEDURE InserirCarteira
	@Nome VARCHAR(100)
	AS INSERT INTO Carteira VALUES(@Nome)
GO
CREATE PROCEDURE InserirNatureza
	@Nome VARCHAR(100),
	@ID_Grupo_Natureza INT
	AS INSERT INTO Natureza VALUES(@Nome, @ID_Grupo_Natureza)
GO
CREATE PROCEDURE InserirGrupo_Natureza
	@Nome VARCHAR(100)
	AS INSERT INTO Grupo_Natureza VALUES(@Nome)
GO
CREATE PROCEDURE InserirFiscal
	@Nome VARCHAR(100),
	@ncm VARCHAR(50),
	@unidade VARCHAR(3),
	@origem INT,
	@classe_imposto VARCHAR(20),
	@ID_Usuario INT
	AS INSERT INTO Fiscal VALUES(@Nome , @ncm, @unidade, @origem, @classe_imposto, @ID_Usuario)

--Atualizar tabelas
GO
CREATE PROCEDURE AtualizarEmpresa 
    @ID INT,
	@Nome VARCHAR(50),
	@CNPJ VARCHAR(20),
	@Endereco VARCHAR(150),
	@Numero VARCHAR(10),
	@Bairro VARCHAR(100),
	@CEP INT,
	@Cidade VARCHAR(50),
	@Estado VARCHAR(2),
	@ID_Usuario INT
	AS UPDATE Empresa SET Nome = @Nome, CNPJ = @CNPJ, Endereco = @Endereco, Numero = @Numero,  Bairro = @Bairro, CEP = @CEP, Cidade = @Cidade, Estado = @Estado, ID_Usuario = @ID_Usuario
    WHERE ID = @ID
GO  
CREATE PROCEDURE AtualizarUsuario
    @ID INT,
	@_Login VARCHAR(50),
	@Senha VARCHAR(50)
	AS UPDATE Usuario SET _Login = @_Login, Senha = @Senha
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarProduto
    @ID INT,
	@Nome VARCHAR(50),
	@Referencia VARCHAR(20),
	@Preco_Custo FLOAT,
	@Preco_Venda FLOAT,
	@Codigo VARCHAR(30),
	@Tipo_Codigo VARCHAR(100),
	@ID_Fiscal INT,
	@ID_Usuario INT,
	@ID_Grupo INT,
	@Foto VARCHAR(300),
	@Qt_Estoque INT,
	@Qt_Rua INT,
	@Inf_Adicionais VARCHAR(500),
	@ID_Tamanho INT,
	@ID_Linha INT,
	@ID_Fornecedor INT
	AS UPDATE Produto SET Nome = @Nome, Referencia = @Referencia, Preco_Custo = @Preco_Custo, Preco_Venda = @Preco_Venda, Codigo = @Codigo, Tipo_Codigo = @Tipo_Codigo, ID_Fiscal = @ID_Fiscal, ID_Usuario = @ID_Usuario, ID_Grupo = @ID_Grupo, Foto = @Foto, Qt_Estoque = @Qt_Estoque, Qt_Rua = @Qt_Rua, Inf_Adicionais = @Inf_Adicionais, ID_Tamanho = @ID_Tamanho, ID_Linha = @ID_Linha, ID_Fornecedor = @ID_Fornecedor
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarProduto2
    @ID INT,
	@Qt_Estoque INT,
	@Qt_Rua INT
	AS UPDATE Produto SET Qt_Estoque = @Qt_Estoque, Qt_Rua = @Qt_Rua
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarPedido
    @ID INT,
	@Nome VARCHAR(100),
	@Valor FLOAT,
	@Valor_de_Venda FLOAT,
	@Valor_de_Comissao FLOAT,
	@Valor_Recebimento FLOAT,
	@_Status VARCHAR(50),
	@ID_Usuario INT,
	@ID_Pessoa INT,
	@Observacoes VARCHAR(500)
	AS UPDATE Pedido SET Nome = @Nome, Valor = @Valor, Valor_de_Venda = @Valor_de_Venda, Valor_de_Comissao = @Valor_de_Comissao, Valor_Recebimento = @Valor_Recebimento, _Status = @_Status, ID_Usuario = @ID_Usuario, ID_Pessoa = @ID_Pessoa, Observacoes = @Observacoes
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarPedido_Produto
    @ID INT,
	@Valor_Produto FLOAT,
	@Quantidade INT,
	@ID_Pedido INT,
	@ID_Produto INT
	AS UPDATE Pedido_Produto SET Valor_Produto = @Valor_Produto, Quantidade = @Quantidade, ID_Pedido = @ID_Pedido, ID_Produto = @ID_Produto
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarMovimento
    @ID INT,
	@Nome VARCHAR(100),
	@Valor_Bruto FLOAT,
	@Valor_Liquido FLOAT,
	@Data_de_Emissao SMALLDATETIME,
	@Tipo VARCHAR(50),
	@ID_Usuario INT,
	@ID_Pessoa INT
	AS UPDATE Movimento SET Nome = @Nome, Valor_Bruto = @Valor_Bruto, Valor_Liquido = @Valor_Liquido, Data_de_Emissao = @Data_de_Emissao, Tipo = @Tipo, ID_Usuario = @ID_Usuario, ID_Pessoa = @ID_Pessoa
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarMovimento_Produto
    @ID INT,
	@Valor_Produto FLOAT,
	@Quantidade INT,
	@ID_Movimento INT,
	@ID_Produto INT
	AS UPDATE Movimento_Produto SET Valor_Produto = @Valor_Produto, Quantidade = @Quantidade, ID_Movimento = @ID_Movimento, ID_Produto = @ID_Produto
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarLancamento
    @ID INT,
	@Nome VARCHAR(50),
	@Valor FLOAT,
	@Desconto_Comissao FLOAT,
	@Emissao SMALLDATETIME,
	@Vencimento SMALLDATETIME,
	@_Status VARCHAR(100),
	@Venda BIT,
	@ID_Usuario INT,
	@ID_Natureza INT,
	@ID_Conta INT,
	@ID_Forma_de_Pagamento INT,
	@Baixa SMALLDATETIME,
	@Descricao VARCHAR(500)
	AS UPDATE Lancamento SET Nome = @Nome, Valor = @Valor, Desconto_Comissao = @Desconto_Comissao, Emissao = @Emissao, Vencimento = @Vencimento, _Status = @_Status, Venda = @Venda, ID_Usuario = @ID_Usuario, ID_Natureza = @ID_Natureza, ID_Conta = @ID_Conta, ID_Forma_de_Pagamento = @ID_Forma_de_Pagamento, Baixa = @Baixa, Descricao = @Descricao
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarLancamento_Produto
    @ID INT,
	@Valor_Produto FLOAT,
	@Quantidade INT,
	@ID_Lancamento INT,
	@ID_Produto INT
	AS UPDATE Lancamento_Produto SET Valor_Produto = @Valor_Produto, Quantidade = @Quantidade, ID_Lancamento = @ID_Lancamento, ID_Produto = @ID_Produto
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarPessoa
    @ID INT,
	@Nome VARCHAR(100),
	@CPF VARCHAR(25),
	@Funcao VARCHAR(50),
	@Verifica_Comissao BIT,
	@CEP VARCHAR(20),
	@Endereco VARCHAR(200),
	@Bairro VARCHAR(200),
	@Cidade VARCHAR(200),
	@UF VARCHAR(3),
	@ID_Usuario INT,
	@ID_Praca INT,
	@Comissao FLOAT,
	@Fator_de_limite INT,
	@Foto VARCHAR(200),
	@Nascimento SMALLDATETIME,
	@Email VARCHAR(50),
	@Telefone VARCHAR(20)
	AS UPDATE Pessoa SET Nome = @Nome, CPF = @CPF, Funcao = @Funcao, Verifica_Comissao = @Verifica_Comissao, CEP = @CEP, Endereco = @Endereco, Bairro = @Bairro, Cidade = @Cidade, UF = @UF, ID_Usuario = @ID_Usuario, ID_Praca = @ID_Praca, Comissao = @Comissao, Fator_de_limite = @Fator_de_limite, Foto = @Foto, Nascimento = @Nascimento, Email = @Email, Telefone = @Telefone
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarFornecedor
    @ID INT,
	@Nome VARCHAR(100),
	@CNPJ VARCHAR(25),
	@Endereco VARCHAR(200),
	@Telefone VARCHAR(20),
	@ID_Usuario INT
	AS UPDATE Fornecedor SET Nome = @Nome, CNPJ = @CNPJ, Endereco = @Endereco, Telefone = @Telefone, ID_Usuario = @ID_Usuario
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarTamanho
    @ID INT,
	@Nome VARCHAR(10)
	AS UPDATE Tamanho SET Nome = @Nome
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarGrupo
    @ID INT,
	@Nome VARCHAR(100),
	@Estoque_min INT,
	@Estoque_max INT
	AS UPDATE Grupo SET Nome = @Nome, Estoque_min = @Estoque_min, Estoque_max = @Estoque_max
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarLinha
    @ID INT,
	@Nome VARCHAR(100)
	AS UPDATE Linha SET Nome = @Nome
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarForma_de_Pagamento
    @ID INT,
	@Nome VARCHAR(50),
	@Taxa1 FLOAT,
	@Taxa2 FLOAT,
	@Taxa3 FLOAT,
	@Taxa4 FLOAT,
	@Taxa5 FLOAT,
	@Taxa6 FLOAT,
	@Taxa7 FLOAT,
	@Taxa8 FLOAT,
	@Taxa9 FLOAT,
	@Taxa10 FLOAT,
	@Taxa11 FLOAT,
	@Taxa12 FLOAT
	AS UPDATE Forma_de_Pagamento SET Nome = @Nome, Taxa1 = @Taxa1, Taxa2 = @Taxa2, Taxa3 = @Taxa3, Taxa4 = @Taxa4, Taxa5 = @Taxa5, Taxa6 = @Taxa6, Taxa7 = @Taxa7, Taxa8 = @Taxa8, Taxa9 = @Taxa9, Taxa10 = @Taxa10, Taxa11 = @Taxa11, Taxa12 = @Taxa12
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarPraca
    @ID INT,
	@Nome VARCHAR(100)
	AS UPDATE Praca SET Nome = @Nome
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarConta
    @ID INT,
	@Nome VARCHAR(100),
	@ID_Carteira INT
	AS UPDATE Conta SET Nome = @Nome, ID_Carteira = @ID_Carteira
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarCarteira
    @ID INT,
	@Nome VARCHAR(100)
	AS UPDATE Carteira SET Nome = @Nome
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarNatureza
    @ID INT,
	@Nome VARCHAR(100),
	@ID_Grupo_Natureza INT
	AS UPDATE Natureza SET Nome = @Nome, ID_Grupo_Natureza = @ID_Grupo_Natureza
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarGrupo_Natureza
    @ID INT,
	@Nome VARCHAR(100)
	AS UPDATE Grupo_Natureza SET Nome = @Nome
    WHERE ID = @ID
GO
CREATE PROCEDURE AtualizarFiscal
    @ID INT,
	@Nome VARCHAR(100),
	@ncm VARCHAR(50),
	@unidade VARCHAR(3),
	@origem INT,
	@classe_imposto VARCHAR(20),
	@ID_Usuario INT
	AS UPDATE Fiscal SET Nome = @Nome , ncm = @ncm, unidade = @unidade, origem = @origem, classe_imposto = @classe_imposto, ID_Usuario = @ID_Usuario
    WHERE ID = @ID

--Deletar Tabelas
GO
CREATE PROCEDURE DeletarEmpresaID @Valor1 INT AS DELETE FROM Empresa WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarUsuarioID @Valor1 INT AS DELETE FROM Usuario WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarProdutoID @Valor1 INT AS DELETE FROM Produto WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarPedidoID @Valor1 INT AS DELETE FROM Pedido WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarPedido_ProdutoID @Valor1 INT AS DELETE FROM Pedido_Produto WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarMovimentoID @Valor1 INT AS DELETE FROM Movimento WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarMovimento_ProdutoID @Valor1 INT AS DELETE FROM Movimento_Produto WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarLancamentoID @Valor1 INT AS DELETE FROM Lancamento WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarLancamento_ProdutoID @Valor1 INT AS DELETE FROM Lancamento_Produto WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarPessoaID @Valor1 INT AS DELETE FROM Pessoa WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarFornecedorID @Valor1 INT AS DELETE FROM Fornecedor WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarTamanhoID @Valor1 INT AS DELETE FROM Tamanho WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarGrupoID @Valor1 INT AS DELETE FROM Grupo WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarLinhaID @Valor1 INT AS DELETE FROM Linha WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarForma_de_PagamentoID @Valor1 INT AS DELETE FROM Forma_de_Pagamento WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarPracaID @Valor1 INT AS DELETE FROM Praca WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarContaID @Valor1 INT AS DELETE FROM Conta WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarCarteiraID @Valor1 INT AS DELETE FROM Carteira WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarNaturezaID @Valor1 INT AS DELETE FROM Natureza WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarGrupo_NaturezaID @Valor1 INT AS DELETE FROM Grupo_Natureza WHERE ID = @Valor1
GO
CREATE PROCEDURE DeletarFiscalID @Valor1 INT AS DELETE FROM Fiscal WHERE ID = @Valor1
GO

--Criação de registros de teste
execute InserirUsuario 'jorge', '2584'
execute InserirPraca 'Sorocaba'
execute InserirPessoa 'Pessoa teste', '4756895482', 'Consultor', 1, '18071445', 'R. Jorge romão', 'Bairro', 'Sorocaba', 'SP', 1, 1, 30, NULL, NULL, '19900528', 'teste1234@teste.com', '15997011849'
execute InserirPessoa 'Pessoa teste2', '4756895482', 'Consultor', 0, '18071445', 'R. Jorge romão', 'Bairro', 'Sorocaba', 'SP', 1, 1, NULL, NULL, NULL, '19900528', 'teste4321@teste.com', '15997011849'
execute InserirPessoa 'Pessoa teste3', '4756895482', 'Cliente', 1, '18071445', 'R. Jorge romão', 'Bairro', 'Sorocaba', 'SP', 1, 1, 45, NULL, NULL, '19900528', 'teste1245@teste.com', '1599701184'
execute InserirProduto 'Produto teste', '1178', 15.54, 30, '7890237489654', 'EAN13', NULL, 1, NULL, NULL, 0, 0, NULL, NULL, NULL, NULL
execute InserirProduto 'Produto teste2', '1179', 15.54, 35, '7890237489655', 'EAN13', NULL, 1, NULL, NULL, 0, 0, NULL, NULL, NULL, NULL
