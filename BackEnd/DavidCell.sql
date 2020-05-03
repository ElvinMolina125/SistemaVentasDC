Create database DavidCell;
use DavidCell;

create table Servicio(
IdServicio int primary key identity,
Servicio nvarchar(30)
);

create table TipoUsuario(
IdTipoUsuario int primary key identity,
TipoUsuario nvarchar(30)
);

create table Usuario(
IdUsuario int primary key identity,
NombreUsuario nvarchar(80),
Usuario nvarchar(20),
Contraseña nvarchar(10),
IdTipoUsuario int,
constraint fk_Usuario_TipoUsuario foreign key (IdTipoUsuario) references TipoUsuario(IdTipoUsuario)
);

create table Reevendedor(
IdReevendedor int primary key identity,
Nombre nvarchar(30),
Correo nvarchar (30),
Contraseña nvarchar(30),
Pagos nvarchar(30),
);

create table CuentasCompradas(
IdCuentasCompradas int primary key identity,
Correo nvarchar(50),
Nombre nvarchar(30),
fechapago date
);

create table Socio(
IdSocio int primary key identity,
NumCuenta varchar(10),
Nombre nvarchar(100),
Correo nvarchar(50),
Contraseña nvarchar(50),
Perfil nvarchar(50),
FechaPago date,
comision nvarchar(50),
IdServicio int,

constraint fk_Socio_Servicio foreign key (IdServicio) references Servicio(IdServicio),

);
create table Cliente(
IdCliente int primary key identity,
NumCuenta varchar(10),
Nombre nvarchar(100),
Correo nvarchar(50),
Contraseña nvarchar(50),
Perfil nvarchar(50),
Telefono nvarchar (15),
FechaPago date,
MesPagados nvarchar,
IdServicio int,
IdSocio int,

constraint fk_Cliente_Servicio foreign key (IdServicio) references Servicio(IdServicio),
constraint fk_Cliente_Socio foreign key (IdSocio) references Socio(IdSocio)
);

insert into TipoUsuario(TipoUsuario) values ('Admin');
insert into Usuario values ('Elvin','elvin','elvin','1');