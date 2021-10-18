create database NH_CARS
default character set utf8
default collate utf8_general_ci;

show databases;

use NH_CARS;



create table Funcionario(
id_Funcionario int not null auto_increment,
Nome varchar(50) not null,
Genero enum('M','F') not null,
BI nvarchar(50) not null unique,
id_Cargo int not null,
primary key (id_Funcionario)
)default charset = utf8 ;

create table Cargo(
id_Cargo int not null auto_increment,
Cargo nvarchar(50) not null,
Salario Decimal(10,5),
primary key (id_Cargo)
)default charset = utf8 ;

alter table Funcionario add foreign key (id_Cargo) references  Cargo (id_Cargo);

create table Clientes (
id_Cliente int primary key auto_increment,
Nome varchar(50) not null,
Genero enum('M','F') not null,
BI  nvarchar(50) not null unique
)default charset = utf8;

create table Acesso(
id_Acesso int primary key auto_increment,
Acesso nvarchar(50) not null
)default charset = utf8;

create table Usuario(
id_Usuario int not null auto_increment,
id_Funcionario int not null,
Usuario varchar(50) not null,
Senha nvarchar(20) not null,
id_Acesso int not null,
primary key(id_usuario)
)default charset = utf8;

alter table Usuario add foreign key (id_Funcionario) references  Funcionario (id_Funcionario);
alter table Usuario add foreign key      (id_Acesso) references  Acesso           (id_Acesso);


create table Marca(
id_Marca int primary key auto_increment,
Marca nvarchar(30) not null
)default charset = utf8;

create table Modelos(
id_Modelo int primary key auto_increment,
id_Marca int not null,
Modelo nvarchar(30) not null,
foreign key(id_Marca) references  Marca(id_Marca)
)default charset = utf8;

create table Estados(
id_Estado int primary key auto_increment,
Estado enum('Vendido','Disponível') not  null 
)default charset = utf8;

create table Cor(
id_Cor int primary key auto_increment,
Cor nvarchar(30) not null
)default charset = utf8;


create table Carro(
id_Carro int not null auto_increment,
Id_Cor int not null,
id_Usuario_Logado int ,
id_Modelo int not null,
id_Estado int not null,
N_Serie nvarchar(50) not null unique,
Tamanho_Pneu nvarchar(50) not null ,
Data_de_Fabrico nvarchar(50) not null ,
Preco float not null,
primary key (id_Carro)
)default charset = utf8;

alter table Carro add  foreign key(id_Usuario_Logado) references  Usuario_Logado(id_logado);
alter table Carro add foreign key (id_Modelo) references  Modelos  (id_Modelo);
alter table Carro add foreign key (id_Estado) references  Estados  (id_Estado);


create table Telefone(
id_Telefone int primary key auto_increment,
id_Funcionario int not null,
Telefone int not null 
)default charset = utf8;


alter table Telefone add foreign key(id_Funcionario) references  Funcionario (id_Funcionario);

create table Vendas(
id_Venda int primary key auto_increment,
id_Usuario_Logado int not null,
id_Cliente int not null,
id_Carro int not null,
Data_Venda nvarchar(50) not null ,
Valor_a_Pagar float not null,
Troco float 
)default charset = utf8;

alter table Vendas add  foreign key(id_Cliente) references  Clientes(id_Cliente);
alter table Vendas add foreign key(id_Carro) references Carro(id_Carro);

create table Usuario_Logado
(
id_logado int primary key auto_increment,
id_Usuario int not null,
data_Entrada nvarchar(50) not null,
hora_Saida nvarchar(20)
)default charset = utf8;

alter table Vendas add  foreign key(id_Usuario_Logado) references  Usuario_Logado(id_logado);
alter table usuario_logado add foreign key(id_usuario) references usuario(id_usuario);
alter table Carro add  foreign key(id_Usuario_Logado) references  Usuario_Logado(id_logado);

create table Usuario_Eventos
(
id_Evento int primary key auto_increment,
id_Usuario_Logado int not null,
Evento nvarchar(50)
)default charset = utf8;

alter table Usuario_Eventos add foreign key(id_usuario_Logado) references usuario_Logado(id_Logado);


Insert into Cargo (Cargo,Salario) values 
('Caixa',10.000),
('Mecanico',15.000),
('Gestor De Vendas',20.000),
('Administrador',40.000),
('Tecnico De Ar',25.000),
('Segurança',10.000),
('PCA',50.000),
('Gestor De Finaças',35.000);

select *from cargo;

Insert into Funcionario (Nome,Genero,BI,Id_Cargo) values 
('Irene Teresa',                  'F','002616011UE032',8), 
('Emilio Manuel',                 'M','005686291EE009',4),
('Wilson Maiagani Kiangana',      'M','003046021WK085',7),
('Sebastião Mendes',              'M','006610415SM044',5),
('Balbina Antonio Andre',         'F','007110415BA824',1),
('Angelo Teodoro Bumba Chivemba', 'M','002151415AA233',3),
('Salvador De Almeida',           'M','006400378SA833',2),
('Ricardo Reis',                  'M','002300378SA852',6);

select *from Funcionario;

Insert into Telefone (id_Funcionario,Telefone) values 
(1, '985641235'), 
(2, '963210654'),
(3, '932050338'),
(4, '987456201'),
(5, '985400326'),
(6, '946236587'),
(7, '989231456'),
(8, '996582314');

select *from telefone;

select Funcionario.Id_Funcionario,Funcionario.Nome,Funcionario.Genero,Funcionario.BI,Cargo.Cargo,Cargo.Salario from Funcionario inner join Cargo on Funcionario.Id_Cargo= Cargo.Id_Cargo where Genero='M';

select Funcionario.Id_Funcionario,Funcionario.Nome,Funcionario.Genero,Funcionario.BI,Cargo.Cargo,Cargo.Salario from Cargo inner join Funcionario on Cargo.Id_Cargo= Funcionario.Id_Cargo where Genero='F';

select Funcionario.Id_Funcionario,Funcionario.Nome,Funcionario.Genero,Funcionario.BI,Cargo.Cargo,Cargo.Salario from Cargo inner join Funcionario on Cargo.Id_Cargo= Funcionario.Id_Cargo where nome='Irene Teresa';

select Funcionario.Id_Funcionario,Funcionario.Nome,Funcionario.Genero,Funcionario.BI,Cargo.Cargo,Cargo.Salario from Funcionario inner join Cargo on Funcionario.Id_Cargo= Cargo.Id_Cargo;

Insert into Acesso values 
(Default ,' Muito Auto'),
(Default ,' Alto'),
(Default ,' Médio'),
(Default ,' Baixo');

select *from Acesso;
desc Usuario;
Insert into Usuario (id_Funcionario,Usuario,Senha,Id_Acesso) values 
(3,'Ali Fattah',   'Fattah',1), 
(2,'Emilio',       'Manuel',2),
(1,'Teresa',       'Teresa',3),
(4,'Sebinha',      'Mendes',3),
(6,'Preto Fino',  'Chivemba',3),
(5,'Balbina',       'Andre',4);

select *from Usuario;

select Usuario.Id_Usuario,Funcionario.Nome,Usuario.Usuario,Usuario.Senha, Acesso.Acesso from Acesso inner join (Funcionario inner join Usuario on Funcionario.Id_Funcionario=Usuario.Id_Funcionario) on Acesso.Id_Acesso=Usuario.Id_Acesso;

Insert into Marca values 
(Default ,     'TOYOTA'),
(Default ,    'HYUNDAI'),
(Default ,   'MERCEDES'),
(Default ,  'ANGOCARRO');

select *from Marca;

Insert into Modelos (id_Marca,Modelo) values 
(1,           'CR02'), 
(1,          'Hiace'),
(2,           'T200'),
(2,             'Md'),
(2,          'VT4f8'), 
(2,         'Br6000'),
(2,            'Ws5'),
(3,            'AMG'),
(4,            'Ax7');

select *from Modelos;

Select Modelos.Id_Modelo,Marca.Marca,Modelos.Modelo from Marca inner join Modelos on Marca.Id_Marca=Modelos.Id_Marca;

Insert into Estados values 
(Default ,     'Vendido'),
(Default ,    'Disponível');

select *from Estados;

Insert into Cor values 
(Default ,' Preto'),
(Default ,' Vermelho'),
(Default ,' Azul & Branco'),
(Default ,' Amarelo'),
(Default ,' Cizento'),
(Default ,' Branco'),
(Default ,' Laranja');

select *from Cor;

select *from Carro;
 
insert into Usuario_Logado (Id_Usuario , Data_Entrada , Hora_Saida) Values
(1 , '23/07/2018' , '18:30'),
(2 , '23/07/2018' , '19:50');

select *from Usuario_Logado; 

Insert into Carro (Id_cor,Id_Usuario_Logado , Id_Modelo , Id_Estado , N_Serie , Tamanho_Pneu , Data_De_Fabrico , Preço) values 
(1,1, 2,'02EF','225/66R17', '05-04-2014', 15.0000),
(1,1, 2,'07HF','245/67R09', '11-09-2011', 25.0000),
(1,3, 2,'06LO','345/66R17', '20-11-2012', 36.0000),
(2,2, 2,'09AG','985/66R17', '09-07-2015', 59.0000),
(2,4, 2,'01Vd','765/66R17', '03-06-2016', 70.0000); 
 
desc carro;
 
 Alter table Carro change column Preço Preco decimal (10,2) not null;
 
 select Carro.Id_carro ,Marca.Marca,Modelos.Modelo,Cor.Cor,Carro.N_serie,Carro.Tamanho_Pneu ,Carro.Data_De_Fabrico, Carro.Preco,Estados.Estado from Cor inner join (Marca inner join ( Modelos inner join Carro on Modelos.Id_Modelo=carro.Id_Modelo) on Marca.Id_Marca=Modelos.Id_Marca  inner join Estados on Estados.Id_Estado=Carro.Id_Estado) on Cor.Id_Cor=Carro.Id_Cor;
 
 select Carro.Id_carro, Usuario.Usuario ,Marca.Marca,Modelos.Modelo,Cor.Cor,Carro.N_serie,Carro.Tamanho_Pneu ,Carro.Data_De_Fabrico , Carro.Preço, Estados.Estado from Cor inner join (Marca inner join ( Modelos inner join Carro on Modelos.Id_Modelo=carro.Id_Modelo) on Marca.Id_Marca=Modelos.Id_Marca inner join Usuario on (Usuario.Id_Usuario=Carro.Id_Usuario_Logado) inner join Estados on Estados.Id_Estado=Carro.Id_Estado) on Cor.Id_Cor=Carro.Id_Cor; 
 
 
select Carro.Id_Carro,Modelos.modelo,Marca.Marca,Cor.cor,Estados.Estado,Usuario.Usuario from Cor inner join (Modelos inner join (Estados inner join Carro on Estados.Id_Estado=Carro.Id_Estado) on Modelos.Id_Modelo=Carro.Id_Modelo inner join Usuario on (Usuario.Id_Usuario=Carro.Id_Usuario_Logado) inner join Marca on Marca.Id_Marca=Modelos.Id_Marca)  on Cor.Id_Cor=Carro.Id_Cor;
 
select Carro.Id_Carro,Modelos.modelo,Modelos.Id_Marca,Cor.cor,Estados.Estado,Usuario.Usuario from Cor inner join (Modelos inner join (Estados inner join Carro on Estados.Id_Estado=Carro.Id_Estado) on Modelos.Id_Modelo=Carro.Id_Modelo inner join Usuario on (Usuario.Id_Usuario=Carro.Id_Usuario_Logado))  on Cor.Id_Cor=Carro.Id_Cor;
 
select Carro.Id_Carro,usuario.Nome ,Marca.Marca,Modelos.Modelo,Carro.N_Serie,Carro.Tamanho_Pneu,Carro.Quantidade,Carro.Data_de_Fabrico,Carro.Preço, Estados.Estado from Marca inner join (Estados inner join (Modelos inner join Carro on Modelos.Id_Modelo=Carro.Id_Modelo)   on  Estados.Id_Estado=Carro.Id_Estado inner join usuario on (Usuario.Id_Usuario=Carro.Id_Usuario)) on Marca.Id_Marca=Carro.Id_Marca;

alter table usuario_logado modify column hora_Saida nvarchar (20);

Select Usuario_Logado.Id_Logado,Usuario.Nome , Usuario_Logado.Data_Entrada , Usuario_Logado.Hora_saida from Usuario inner join Usuario_Logado on Usuario.Id_Usuario=Usuario_Logado.Id_Usuario;

Select Usuario_Logado.Id_Logado , Usuario.Nome , Usuario_Logado.Data_Entrada , Usuario_Logado.Hora_Saida from Usuario_Logado inner join Usuario on Usuario_Logado.Id_Usuario=Usuario.Id_Usuario;

Select Modelos.Id_Modelo,Marca.Marca,Modelos.Modelo from Marca inner join Modelos on Marca.Id_Marca=Modelos.Id_Marca;




select * from vendas;

 select Carro.Id_carro, Usuario.Usuario ,Marca.Marca,Modelos.Modelo,Cor.Cor,Carro.N_serie,Carro.Tamanho_Pneu ,Carro.Data_De_Fabrico , Carro.Preço, Estados.Estado from Cor inner join (Marca inner join ( Modelos inner join Carro on Modelos.Id_Modelo=carro.Id_Modelo) on Marca.Id_Marca=Modelos.Id_Marca inner join Usuario on (Usuario.Id_Usuario=Carro.Id_Usuario_Logado) inner join Estados on Estados.Id_Estado=Carro.Id_Estado) on Cor.Id_Cor=Carro.Id_Cor; 

select vendas.id_venda,Usuario.usuario, Marca.Marca , Modelos.Modelo , Carro.N_Serie,Cor.cor, vendas.Valor_a_Pagar,vendas.Troco,vendas.Data_Venda from vendas  
inner join usuario_logado on vendas.id_usuario_logado = usuario_logado.id_logado
inner join usuario on usuario_logado.id_logado = usuario.id_usuario
inner join funcionario on funcionario.id_funcionario = usuario.id_funcionario
inner join carro on vendas.id_carro = carro.id_carro 
inner join Cor on Carro.Id_Cor=cor.Id_cor
inner join modelos on carro.id_modelo = modelos.id_modelo
inner join marca on modelos.id_marca = marca.id_marca ;

desc vendas;

select *from vendas;
select *from Usuario_Logado;

Desc Carro;

Select Vendas.Id_Venda, Usuario.Usuario,Clientes.nome,Marca.Marca,Modelos.Modelo,Carro.N_serie,Cor.Cor , Vendas.Valor_A_Pagar,Vendas.Troco,Vendas.Data_Venda  from Vendas inner join Usuario_Logado on Vendas.Id_Usuario_Logado = Usuario_Logado.Id_Logado inner Join Usuario on Usuario_Logado.Id_Usuario=Usuario.Id_Usuario inner join Clientes on Vendas.Id_Cliente=Clientes.Id_Cliente inner join Carro on Vendas.Id_Carro=Carro.Id_Carro inner join Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_cor=Cor.Id_Cor;

select Modelos.Modelo,Marca.Marca,cor.cor,clientes.nome from Vendas  inner join Carro on Vendas.Id_Carro=Carro.Id_Carro inner join Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_cor=Cor.Id_Cor inner join Clientes on Vendas.Id_Cliente=Clientes.Id_cliente where Vendas.Id_Venda=12;

select Usuario.Usuario from vendas inner join usuario_logado on vendas.id_usuario_logado = usuario_logado.id_logado inner join usuario on usuario_logado.id_usuario = usuario.id_usuario;




select Marca.Marca,Modelos.Modelo,Carro.N_Serie,Cor.Cor,Carro.Tamanho_Pneu,Carro.Data_De_Fabrico,Carro.Preco,Estados.Estado from Carro inner join  Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado;
select Marca.Marca,Modelos.Modelo,Carro.N_Serie,Cor.Cor,Carro.Tamanho_Pneu,Carro.Data_De_Fabrico,Carro.Preco,Estados.Estado from Carro inner join  Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado where Estados.Estado='Vendido';
select Marca.Marca,Modelos.Modelo,Carro.N_Serie,Cor.Cor,Carro.Tamanho_Pneu,Carro.Data_De_Fabrico,Carro.Preco,Estados.Estado from Carro inner join  Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado where Estados.Estado='Disponível';
select Marca.Marca,Modelos.Modelo,Carro.N_Serie,Cor.Cor,Carro.Tamanho_Pneu,Carro.Data_De_Fabrico,Carro.Preco,Estados.Estado from Carro inner join  Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado where Marca.Marca='HYUNDAI';
select Marca.Marca,Modelos.Modelo,Carro.N_Serie,Cor.Cor,Carro.Tamanho_Pneu,Carro.Data_De_Fabrico,Carro.Preco,Estados.Estado from Carro inner join  Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado where Modelos.Modelo='T200';
select Modelos.Modelo from Modelos;

select Usuario.Id_Usuario,Funcionario.Nome,Usuario.Usuario,Usuario.Senha, Acesso.Acesso from Usuario inner join Funcionario on Usuario.Id_Funcionario=Funcionario.Id_Funcionario inner join Acesso on Usuario.Id_Acesso=Acesso.Id_Acesso;
select Usuario_Logado.Id_Logado, Usuario.Usuario ,Usuario_Logado.Data_Entrada,Usuario_Logado.Hora_Saida from Usuario_Logado inner join Usuario on Usuario_Logado.Id_Usuario=Usuario.Id_Usuario;

select *from Usuario;
select *from clientes;
Select *from vendas;

select Modelos.Modelo,     count(*)  from Carro  inner join  Modelos        on Carro.Id_Modelo          = Modelos.Id_Modelo        inner join Marca   on Modelos.Id_Marca          = Marca.Id_Marca     inner join Cor         on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado group by modelos.modelo order by count(*) desc;
select Funcionario.Genero, count(*)  from Vendas inner join  Usuario_Logado on Vendas.Id_Usuario_Logado = Usuario_Logado.Id_Logado inner Join Usuario on Usuario_Logado.Id_Usuario = Usuario.Id_Usuario inner join Funcionario on Usuario.Id_Funcionario=Funcionario.Id_Funcionario group by Funcionario.Genero order by count(*) desc;
select Funcionario.Nome,   count(*)  from Vendas inner join  Usuario_Logado on Vendas.Id_Usuario_Logado = Usuario_Logado.Id_Logado inner Join Usuario on Usuario_Logado.Id_Usuario = Usuario.Id_Usuario inner join Funcionario on Usuario.Id_Funcionario=Funcionario.Id_Funcionario group by Funcionario.Nome order by count(*) desc;
select Funcionario.Nome ,Funcionario.Genero,   count(*)  from Vendas inner join  Usuario_Logado on Vendas.Id_Usuario_Logado = Usuario_Logado.Id_Logado inner Join Usuario on Usuario_Logado.Id_Usuario = Usuario.Id_Usuario inner join Funcionario on Usuario.Id_Funcionario=Funcionario.Id_Funcionario where Genero='M' group by Funcionario.nome order by count(*);
select Funcionario.Nome ,Funcionario.Genero,   count(*)  from Vendas inner join  Usuario_Logado on Vendas.Id_Usuario_Logado = Usuario_Logado.Id_Logado inner Join Usuario on Usuario_Logado.Id_Usuario = Usuario.Id_Usuario inner join Funcionario on Usuario.Id_Funcionario=Funcionario.Id_Funcionario where Genero='F' group by Funcionario.nome order by count(*);

select funcionario.nome,funcionario.genero from vendas inner join Usuario_Logado on Vendas.Id_Usuario_Logado = Usuario_Logado.Id_Logado inner Join Usuario on Usuario_Logado.Id_Usuario = Usuario.Id_Usuario inner join Funcionario on Usuario.Id_Funcionario=Funcionario.Id_Funcionario where Genero='F' group by Funcionario.nome order by count(*);
desc vendas;

select *from Vendas;

select Modelos.Modelo from Vendas  inner join Carro on Vendas.Id_Carro=Carro.Id_Carro inner join Modelos on Modelos.Id_Modelo=Carro.Id_Carro;