CREATE TABLE Marca (
    idMarca INT PRIMARY KEY,
    Nome VARCHAR (100),
    MarcaNacional BIT
);

INSERT INTO Marca (idMarca, Nome, MarcaNacional) Values (0301, 'Lubrax', 0), (0302, 'Motul', 1), (0303, 'Petronas', 0), (0304, 'Valvoline', 1), (0305, 'ProHonda', 0), (0306, 'Ipiranga', 0), (0307, 'MobilSuper', 1), (0308, 'Shell', 0), (0309, 'Imperium', 0), (0310, 'Wega', 0), (0311, 'Seineca', 1), (0312, 'FleetGuard', 1), (0313, 'Inca', 0), (0314, 'Daily', 0), (0315, 'Vox', 1), (0316, 'Wurth', 1), (0317, 'MotRio', 0), (0318, 'Mann', 1);

CREATE TABLE TipoProduto (
    idTipoProduto INT PRIMARY KEY,
    descricao TEXT
);

INSERT INTO TipoProduto (idTipoProduto, Descricao) Values (0100, 'Sem Defininição'), (0101, 'Oleo Sintético'), (0102, 'Oleo Semissintético'), (0103, 'Oleo Mineral'), (0104, 'Filtro de ar'), (0105, 'Filtro do combustível'), (0106, 'Liquido de arrefecimento'), (0107, 'Filtro de Oleo');

CREATE TABLE Viscosidade (
    idViscosidade INT PRIMARY KEY,
    SiglaViscosidade VARCHAR (100)
);


INSERT INTO Viscosidade (idViscosidade, SiglaViscosidade) Values (0201, 'Sem Definição'), (0202, '5w30'), (0203, '10w40'), (0204, '0w20'), (0205, '10w30'), (0206, '15w40'), (0207, '5W40'), (0208, '13w40'), (0209, '20w50'), (0210, '25w60');

CREATE TABLE Produto (
    idProduto INT PRIMARY KEY,
    TipoProduto INT,
    NomeProduto VARCHAR (100),
    Marca INT,
    Viscosidade INT,
    descricao TEXT,
    preco DECIMAL(10,2),
FOREIGN KEY (TipoProduto) REFERENCES TipoProduto(idTipoProduto),
FOREIGN KEY (Marca) REFERENCES Marca(idMarca),
FOREIGN KEY (Viscosidade) REFERENCES Viscosidade(idViscosidade)
);


INSERT INTO Produto (idProduto, TipoProduto, NomeProduto, Marca, Viscosidade, descricao, preco) 
Values
(5501, 0101, 'Óleo de Motor', 0301, 0202, 'Óleo lubrificante sintético multiviscoso de última tecnologia API SN Plus para a adequada proteção dos componentes do motor, redução no consumo de combustível e proteção contra pré-ignições nas câmaras de combustão durante o funcionamento em baixas rotações (LSPI)', 39.55),
(5502, 0101, 'Óleo de Motor', 0302, 0203, 'Óleo Motul Transoil 10w-30 Off road e On road especialmente formulado para caixas de marchas, cambio e transmissão com embreagem úmida que usam óleo diferente do óleo motor: caixa de marchas separada do bloco do motor', 75.62), 
(5503, 0101, 'Óleo de Motor', 0303, 0202, 'PETRONAS Selenia Perform SN plus é um lubrificante 100% sintético de alta performance, que proporciona uma perfeita lubrificação dos mais modernos motores movidos à gasolina, diesel, etanol, flex e GNV. PETRONAS Selenia Perfom SN+ foi feito para o seu carro, atendendo satisfatoriamente às especificações dos principais fabricantes de veículos', 34.00), 
(5504, 0101, 'Óleo de Motor', 0304, 0204, 'Lubrificante totalmente sintético desenvolvido exclusivamente para a frota brasileira, com tecnologia avançada de aditivos e qualidade superior aos lubrificantes convencionais. Projetado para atender e ou exceder as exigências dos motores modernos e com sistema de Start Stop', 49.26), 
(5505, 0101, 'Óleo de Motor', 0305, 0204, 'Produto ORIGINAL HONDA produzido pela marca para uso na linha de montagem e nas concessionárias como produto original. Trata-se, portanto de peça de altíssima qualidade fabricado e vendido diretamente pela HONDA', 99.79), 

(5506, 0102, 'Óleo de Motor', 0301, 0206, 'Óleo 15W40 para motores Álcool Gasolina Etanol GNV Lubrax Tecno é um óleo lubrificante multiviscoso semissintético para uso nos modernos motores a gasolina, etanol, flex e GNV (injeção eletronica, multiválvulas e turboalimentados). Aprovado no nível de desempenho API SM. Disponível no grau de viscosidade SAE 15W /40', 104.99),
(5507, 0102, 'Óleo de Motor', 0306, 0205, 'Garante a performance ideal dos motores, ajudando a manter por mais tempo as suas características originais de limpeza e desempenho, mesmo sob os mais diversos regimes de uso aos quais os veículos são submetidos no dia a dia', 27.00), 
(5508, 0102, 'Óleo de Motor', 0307, 0202, 'Óleo semissintético especialmente formulado para maior economia de combustível. Proporciona melhor desempenho em motores de última geração que operam em condições severas. Possibilita redução de atrito mantendo o motor mais limpo e mais resistente à formação de depósitos no motor.', 32.99), 
(5509, 0102, 'Óleo de Motor', 0306, 0207, 'Garante a performance ideal dos motores, ajudando a manter por mais tempo as suas características originais de limpeza e desempenho, mesmo sob os mais diversos regimes de uso aos quais os veículos são submetidos no dia a dia.', 35.00), 

(5510, 0103, 'Óleo de Motor', 0307, 0209, 'Mobil Super 1000 20W-50 pode ser utilizado em motores a gasolina, etanol, GNV e tipo FLEX desde que de acordo com as especificações determinadas pelo fabricante do veículo. Verifique sempre o manual do proprietário de seu veículo', 99.99),
(5511, 0103, 'Óleo de Motor', 0301, 0209, 'Lubrificante mineral recomendado para uso em motores a gasolina, etanol, flex e GNV de veículos nacionais ou importados com injeção eletrônica e multiválvulas, compatível com os conversores catalíticos. Possui poder de limpeza e controle na formação de depósitos nos componentes internos do motor. Recomendado para diversos modelos de veículos de passeio nas mais variadas condições de operação.', 15.97), 
(5512, 0103, 'Óleo de Motor', 0309, 0205, 'Graças aos seus óleos de base minerais e sintéticos estáveis e ao pacote de aditivos avançados, este óleo de motor para motociclos de quatro tempos garante uma condução suave e estável. A fórmula equilibrada foi especificamente desenvolvida para se adequar às necessidades dos entusiastas do motociclismo que procuram um conforto de condução ideal', 25.99), 
(5513, 0103, 'Óleo de Motor', 0308, 0208, 'A responsabilidade da compatibilidade do produto com a sua aplicação é do comprador. Não nos responsabilizamos por qualquer tipo de prejuízo vindo da aplicação incorreta do produto. Sempre consulte o fabricante do seu equipamento e confirme a compatibilidade com o instalador', 51.00), 
(5514, 0103, 'Óleo de Motor', 0308, 0210, 'A responsabilidade da compatibilidade do produto com a sua aplicação é do comprador. Não nos responsabilizamos por qualquer tipo de prejuízo vindo da aplicação incorreta do produto. Sempre consulte o fabricante do seu equipamento e confirme a compatibilidade com o instalador', 36.28), 


(5515, 0104, 'Filtro', 0310, 0201, 'A Wega é uma empresa Argentina especializada na produção de filtros e velas para o mercado de Reposição automotiva nas linhas leve e pesada', 9.41), 
(5516, 0104, 'Filtro', 0311, 0201, 'Filtro de Ar Cilíndrico para Motor de Carro Chevrolet SAF8077. O filtro de ar é responsável por melhorar o desempenho do seu motor e também impedir que resíduos ou impurezas entrem em contato com as peças e causem um possível desgaste', 15.50), 
(5517, 0104, 'Filtro', 0312, 0201, 'FILTRO DE AR MERCEDES BENZ TEGO 1726/36 7.2L 18V', 176.90), 

(5518, 0105, 'Filtro', 0314, 0201, 'FILTRO COMBUSTÍVEL IVECO DAILY 3.0 2020/ - WEGA - FCD0806 - PEÇA', 202.00), 
(5519, 0105, 'Filtro', 0313, 0201, 'O Filtro de Combustível é responsável por eliminar as impurezas da gasolina ou do álcool antes do combustível queimar. Fica entre o motor e o tanque para evitar que partículas acumuladas durante o transporte e armazenamento, como ferrugem, pó, sujeira e água no tanque do veículo cheguem ao bico de injeção e à bomba de combustível', 44.99), 
(5520, 0105, 'Filtro', 0315, 0201, 'Compatível com diversos veículos', 15.00), 

(5521, 0106, 'Líquido', 0316, 0201, 'Produto Pronto Uso. A Solução Arrefecedora foi desenvolvida para uso em radiadores de motores à combustão interna, protegendo todo o sistema de arrefecimento contra a corrosão', 29.90), 
(5522, 0106, 'Líquido', 0302, 0201, 'Fluido de arrefecimento MOTUL MOTOCOOL EXPERT -37°C 1L', 42.00), 
(5523, 0106, 'Líquido', 0317, 0201, 'Marca: Renault, Modelo: Duster, Do ano: 2017 Até Ano: 2022, Motorização: 1.6 16V Flex - 120cv', 26.00), 

(5524, 0107, 'Filtro', 0310, 0201, 'Com a finalidade de remover os resíduos indesejáveis que podem estar contidos no óleo do motor, o Filtro de Óleo é feito com um papel especial, que está contido dentro da carcaça do filtro', 18.50), 
(5525, 0107, 'Filtro', 0310, 0201, 'Com a finalidade de remover os resíduos indesejáveis que podem estar contidos no óleo do motor, o Filtro de Óleo é feito com um papel especial, que está contido dentro da carcaça do filtro', 64.50), 
(5526, 0107, 'Filtro', 0318, 0201, 'Filtro de Óleo Tecfil PSL129 Muito conhecido no mercado da filtração automotiva, o filtro de óleo do motor é um item de alta importância para o perfeito funcionamento do veículo. Sua principal função é impedir a passagem de partículas indesejáveis (proveniente da fricção das peças) para dentro do motor evitando assim desgastes excessivos dos componentes internos durante seu funcionamento', 70.00);


CREATE TABLE TipoServico (
    idTipoServico INT PRIMARY KEY,
    Nome VARCHAR (50)
);

INSERT INTO TipoServico (idTipoServico, Nome) Values (6601, 'Troca de Óleo'), (6602, 'Troca de Filtro'), (6603, 'Troca líquido de arrefecimento');

CREATE TABLE Servico (
    idServico INT PRIMARY KEY, 
    TipoServico INT, 
    descricao TEXT,
    preco DECIMAL(10, 2)
FOREIGN KEY (TipoServico) REFERENCES TipoServico (idTipoServico)
);

INSERT INTO Servico (idServico, TipoServico, descricao, preco) Values (8001, 6601, 'Valor Correspondente ao produto', 00.00), (8002, 6602, 'Valor Correspondente ao produto', 00.00), (8003, 6603, 'Valor Correspondente ao produto', 00.00), (8004, 6602, 'Valor Correspondente ao produto', 00.00), (8005, 6603, 'Valor Correspondente ao produto', 00.00);

CREATE TABLE Veiculo (
    idVeiculo INT PRIMARY KEY,
    placa VARCHAR(10),
    modelo VARCHAR(255),
    marca VARCHAR (60),
    ano INT
);

INSERT INTO Veiculo (idVeiculo, placa, modelo, marca, ano) Values (9001, 'KMF0001', 'Jetta', 'Volkswagen', 2010), (9002, 'LV-5501', 'Cross', 'Volkswagen', 2011), (9003, 'NAH6901', 'Corolla', 'Toyota', 2012), (9004, 'KMF0001', 'SW4', 'Toyota', 2013), (9005, 'NTW9399', 'Captur', 'Renault Nissan', 2014), (9006, 'NTW2324', 'Duster', 'Renault Nissan', 2015), (9007, 'KMF3331', 'HB20', 'Hyundai-Kia', 2016);	

CREATE TABLE Cliente (
    idCliente INT PRIMARY KEY,
    nome VARCHAR(255),
    rg VARCHAR (20),
    cpf VARCHAR (11),
    cnh VARCHAR (10),
    orgaoEmissor VARCHAR (10),
    telefone VARCHAR(20),
    estado VARCHAR (20)
);

INSERT INTO Cliente (idCliente, nome, rg, cpf, cnh, orgaoEmissor, telefone, estado) Values (6561, 'Alex Dos Santos Feitosa' , '321954-8', '42201536469', '2143657942', 'SSP', '113648-2439', 'São Paulo'), (6562, 'Eduardo Murakami Da Silva' , '347954-8', '66719936469', '214322292', 'SSP', '135648-2239', 'Praia Grande'),(6563, 'Karina Galvão Baruel' , '778954-8', '98401535769', '2195487642', 'SSP', '112704-2439', 'Santo André'),(6564, 'Octacilio Carlos Dias Filho' , '852369-8', '98701565469', '2332145642', 'Detran', '112605-3189', 'Osasco');

CREATE TABLE Funcionario (
    idFuncionario INT PRIMARY KEY,
    nome VARCHAR(255),
    cargo VARCHAR(100)
    
);

INSERT INTO Funcionario 
(idFuncionario, nome, cargo) 
Values (60, 'Maria', 'Mecanica Jr.'), (61, 'Diego', 'Mecanico Sr.'), (62, 'Pedro', 'Mecanico Pl.'), (63, 'Matheus', 'Mecanico Jr.'), (64, 'Cristian', 'Financeiro');

CREATE TABLE Agendamento (
    idAgendamento INT PRIMARY KEY,
    cliente_id INT,
    veiculo_id INT,
    servico_id INT,
    data_agendamento DATE,
    hora_agendamento TIME,
    idFuncionario INT,
    FOREIGN KEY (cliente_id) REFERENCES Cliente(idCliente),
    FOREIGN KEY (veiculo_id) REFERENCES Veiculo(idVeiculo),
    FOREIGN KEY (servico_id) REFERENCES Servico(idServico),
    FOREIGN KEY (idFuncionario) REFERENCES Funcionario(idFuncionario)
);

INSERT INTO Agendamento (idAgendamento, cliente_id, veiculo_id, servico_id, data_agendamento, hora_agendamento, idFuncionario) Values (1, 6561, 9001, 8001, '2024-02-02', '14:00', 64), (2, 6562, 9002, 8002, '2024-02-02', '14:30', 63), (3, 6563, 9003, 8003, '2024-02-02', '15:00', 62), (4, 6564, 9004, 8004, '2024-02-02', '15:30', 61), (5, 6561, 9007, 8005, '2024-02-02', '16:00', 60);

SELECT * FROM Servico

ALTER TABLE Servico ALTER COLUMN descricao VARCHAR (4000);
ALTER TABLE Servico ALTER COLUMN preco NUMERIC (10, 5);
ALTER TABLE TipoProduto ALTER COLUMN descricao VARCHAR (4000);
