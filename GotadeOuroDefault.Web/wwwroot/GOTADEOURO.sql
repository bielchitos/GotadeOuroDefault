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

INSERT INTO TipoProduto (idTipoProduto, Descricao) Values (0100, 'Sem Definini��o'), (0101, 'Oleo Sint�tico'), (0102, 'Oleo Semissint�tico'), (0103, 'Oleo Mineral'), (0104, 'Filtro de ar'), (0105, 'Filtro do combust�vel'), (0106, 'Liquido de arrefecimento'), (0107, 'Filtro de Oleo');

CREATE TABLE Viscosidade (
    idViscosidade INT PRIMARY KEY,
    SiglaViscosidade VARCHAR (100)
);


INSERT INTO Viscosidade (idViscosidade, SiglaViscosidade) Values (0201, 'Sem Defini��o'), (0202, '5w30'), (0203, '10w40'), (0204, '0w20'), (0205, '10w30'), (0206, '15w40'), (0207, '5W40'), (0208, '13w40'), (0209, '20w50'), (0210, '25w60');

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
(5501, 0101, '�leo de Motor', 0301, 0202, '�leo lubrificante sint�tico multiviscoso de �ltima tecnologia API SN Plus para a adequada prote��o dos componentes do motor, redu��o no consumo de combust�vel e prote��o contra pr�-igni��es nas c�maras de combust�o durante o funcionamento em baixas rota��es (LSPI)', 39.55),
(5502, 0101, '�leo de Motor', 0302, 0203, '�leo Motul Transoil 10w-30 Off road e On road especialmente formulado para caixas de marchas, cambio e transmiss�o com embreagem �mida que usam �leo diferente do �leo motor: caixa de marchas separada do bloco do motor', 75.62), 
(5503, 0101, '�leo de Motor', 0303, 0202, 'PETRONAS Selenia Perform SN plus � um lubrificante 100% sint�tico de alta performance, que proporciona uma perfeita lubrifica��o dos mais modernos motores movidos � gasolina, diesel, etanol, flex e GNV. PETRONAS Selenia Perfom SN+ foi feito para o seu carro, atendendo satisfatoriamente �s especifica��es dos principais fabricantes de ve�culos', 34.00), 
(5504, 0101, '�leo de Motor', 0304, 0204, 'Lubrificante totalmente sint�tico desenvolvido exclusivamente para a frota brasileira, com tecnologia avan�ada de aditivos e qualidade superior aos lubrificantes convencionais. Projetado para atender e ou exceder as exig�ncias dos motores modernos e com sistema de Start Stop', 49.26), 
(5505, 0101, '�leo de Motor', 0305, 0204, 'Produto ORIGINAL HONDA produzido pela marca para uso na linha de montagem e nas concession�rias como produto original. Trata-se, portanto de pe�a de alt�ssima qualidade fabricado e vendido diretamente pela HONDA', 99.79), 

(5506, 0102, '�leo de Motor', 0301, 0206, '�leo 15W40 para motores �lcool Gasolina Etanol GNV Lubrax Tecno � um �leo lubrificante multiviscoso semissint�tico para uso nos modernos motores a gasolina, etanol, flex e GNV (inje��o eletronica, multiv�lvulas e turboalimentados). Aprovado no n�vel de desempenho API SM. Dispon�vel no grau de viscosidade SAE 15W /40', 104.99),
(5507, 0102, '�leo de Motor', 0306, 0205, 'Garante a performance ideal dos motores, ajudando a manter por mais tempo as suas caracter�sticas originais de limpeza e desempenho, mesmo sob os mais diversos regimes de uso aos quais os ve�culos s�o submetidos no dia a dia', 27.00), 
(5508, 0102, '�leo de Motor', 0307, 0202, '�leo semissint�tico especialmente formulado para maior economia de combust�vel. Proporciona melhor desempenho em motores de �ltima gera��o que operam em condi��es severas. Possibilita redu��o de atrito mantendo o motor mais limpo e mais resistente � forma��o de dep�sitos no motor.', 32.99), 
(5509, 0102, '�leo de Motor', 0306, 0207, 'Garante a performance ideal dos motores, ajudando a manter por mais tempo as suas caracter�sticas originais de limpeza e desempenho, mesmo sob os mais diversos regimes de uso aos quais os ve�culos s�o submetidos no dia a dia.', 35.00), 

(5510, 0103, '�leo de Motor', 0307, 0209, 'Mobil Super 1000 20W-50 pode ser utilizado em motores a gasolina, etanol, GNV e tipo FLEX desde que de acordo com as especifica��es determinadas pelo fabricante do ve�culo. Verifique sempre o manual do propriet�rio de seu ve�culo', 99.99),
(5511, 0103, '�leo de Motor', 0301, 0209, 'Lubrificante mineral recomendado para uso em motores a gasolina, etanol, flex e GNV de ve�culos nacionais ou importados com inje��o eletr�nica e multiv�lvulas, compat�vel com os conversores catal�ticos. Possui poder de limpeza e controle na forma��o de dep�sitos nos componentes internos do motor. Recomendado para diversos modelos de ve�culos de passeio nas mais variadas condi��es de opera��o.', 15.97), 
(5512, 0103, '�leo de Motor', 0309, 0205, 'Gra�as aos seus �leos de base minerais e sint�ticos est�veis e ao pacote de aditivos avan�ados, este �leo de motor para motociclos de quatro tempos garante uma condu��o suave e est�vel. A f�rmula equilibrada foi especificamente desenvolvida para se adequar �s necessidades dos entusiastas do motociclismo que procuram um conforto de condu��o ideal', 25.99), 
(5513, 0103, '�leo de Motor', 0308, 0208, 'A responsabilidade da compatibilidade do produto com a sua aplica��o � do comprador. N�o nos responsabilizamos por qualquer tipo de preju�zo vindo da aplica��o incorreta do produto. Sempre consulte o fabricante do seu equipamento e confirme a compatibilidade com o instalador', 51.00), 
(5514, 0103, '�leo de Motor', 0308, 0210, 'A responsabilidade da compatibilidade do produto com a sua aplica��o � do comprador. N�o nos responsabilizamos por qualquer tipo de preju�zo vindo da aplica��o incorreta do produto. Sempre consulte o fabricante do seu equipamento e confirme a compatibilidade com o instalador', 36.28), 


(5515, 0104, 'Filtro', 0310, 0201, 'A Wega � uma empresa Argentina especializada na produ��o de filtros e velas para o mercado de Reposi��o automotiva nas linhas leve e pesada', 9.41), 
(5516, 0104, 'Filtro', 0311, 0201, 'Filtro de Ar Cil�ndrico para Motor de Carro Chevrolet SAF8077. O filtro de ar � respons�vel por melhorar o desempenho do seu motor e tamb�m impedir que res�duos ou impurezas entrem em contato com as pe�as e causem um poss�vel desgaste', 15.50), 
(5517, 0104, 'Filtro', 0312, 0201, 'FILTRO DE AR MERCEDES BENZ TEGO 1726/36 7.2L 18V', 176.90), 

(5518, 0105, 'Filtro', 0314, 0201, 'FILTRO COMBUST�VEL IVECO DAILY 3.0 2020/ - WEGA - FCD0806 - PE�A', 202.00), 
(5519, 0105, 'Filtro', 0313, 0201, 'O Filtro de Combust�vel � respons�vel por eliminar as impurezas da gasolina ou do �lcool antes do combust�vel queimar. Fica entre o motor e o tanque para evitar que part�culas acumuladas durante o transporte e armazenamento, como ferrugem, p�, sujeira e �gua no tanque do ve�culo cheguem ao bico de inje��o e � bomba de combust�vel', 44.99), 
(5520, 0105, 'Filtro', 0315, 0201, 'Compat�vel com diversos ve�culos', 15.00), 

(5521, 0106, 'L�quido', 0316, 0201, 'Produto Pronto Uso. A Solu��o Arrefecedora foi desenvolvida para uso em radiadores de motores � combust�o interna, protegendo todo o sistema de arrefecimento contra a corros�o', 29.90), 
(5522, 0106, 'L�quido', 0302, 0201, 'Fluido de arrefecimento MOTUL MOTOCOOL EXPERT -37�C 1L', 42.00), 
(5523, 0106, 'L�quido', 0317, 0201, 'Marca: Renault, Modelo: Duster, Do ano: 2017 At� Ano: 2022, Motoriza��o: 1.6 16V Flex - 120cv', 26.00), 

(5524, 0107, 'Filtro', 0310, 0201, 'Com a finalidade de remover os res�duos indesej�veis que podem estar contidos no �leo do motor, o Filtro de �leo � feito com um papel especial, que est� contido dentro da carca�a do filtro', 18.50), 
(5525, 0107, 'Filtro', 0310, 0201, 'Com a finalidade de remover os res�duos indesej�veis que podem estar contidos no �leo do motor, o Filtro de �leo � feito com um papel especial, que est� contido dentro da carca�a do filtro', 64.50), 
(5526, 0107, 'Filtro', 0318, 0201, 'Filtro de �leo Tecfil PSL129 Muito conhecido no mercado da filtra��o automotiva, o filtro de �leo do motor � um item de alta import�ncia para o perfeito funcionamento do ve�culo. Sua principal fun��o � impedir a passagem de part�culas indesej�veis (proveniente da fric��o das pe�as) para dentro do motor evitando assim desgastes excessivos dos componentes internos durante seu funcionamento', 70.00);


CREATE TABLE TipoServico (
    idTipoServico INT PRIMARY KEY,
    Nome VARCHAR (50)
);

INSERT INTO TipoServico (idTipoServico, Nome) Values (6601, 'Troca de �leo'), (6602, 'Troca de Filtro'), (6603, 'Troca l�quido de arrefecimento');

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

INSERT INTO Cliente (idCliente, nome, rg, cpf, cnh, orgaoEmissor, telefone, estado) Values (6561, 'Alex Dos Santos Feitosa' , '321954-8', '42201536469', '2143657942', 'SSP', '113648-2439', 'S�o Paulo'), (6562, 'Eduardo Murakami Da Silva' , '347954-8', '66719936469', '214322292', 'SSP', '135648-2239', 'Praia Grande'),(6563, 'Karina Galv�o Baruel' , '778954-8', '98401535769', '2195487642', 'SSP', '112704-2439', 'Santo Andr�'),(6564, 'Octacilio Carlos Dias Filho' , '852369-8', '98701565469', '2332145642', 'Detran', '112605-3189', 'Osasco');

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
