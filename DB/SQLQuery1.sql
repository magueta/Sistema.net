

create table Medida(
Id int primary key identity(1,1),
Nombre varchar(50) not null,
Abreviatura varchar(4) not null,--und - kg
Equivalente varchar(4) not null,--und - g
Valor int not null --1, 1000
)

go

create table Categoria(
Id int primary key identity(1,1),
Nombre varchar(50) not null,
IdMedida int references Medida(Id),
Activo bit default 1
)
go

create table Producto(
Id int primary key identity(1,1),
IdCategoria int references Categoria(Id),
Codigo varchar(50) not null,
Descripcion varchar(150) not null,
PrecioCompra decimal(10,2) not null,
PrecioVenta decimal(10,2) not null,
Cantidad int not null,
Activo bit default 1
)
go

create table Rol(
Id int primary key identity(1,1),
Nombre varchar(50) not null,
)
go
create table Usuario(
Id  int primary key identity(1,1),
IdRol int references Rol(Id),
NombreCompleto varchar(50) not null,
Correo varchar(50) not null,
NombreUsuario varchar(50) not null unique,
Clave varchar(100) not null,
ResetearClave bit default 1,
Activo bit default 1
)
go
create table CorrelativoVenta(
Serie varchar(3) not null, --001
Numero int not null, --1,2,3 --- 000001
Activo bit default 1,
primary key(Serie,Numero)
)
go
create table Venta(
Id int primary key identity(1,1),
NumeroVenta varchar(10), --001-000005
IdUsuarioRegistro int references Usuario(Id),
NombreCliente varchar(60),
PrecioTotal decimal(10,2) not null,
PagoCon decimal(10,2),
Cambio decimal(10,2),
FechaRegistro datetime default getdate(),
Activo bit default 1
)

go
create table DetalleVenta(
Id int primary key identity(1,1),
IdVenta int references Venta(Id),
IdProducto int references Producto(Id),
Cantidad int,
PrecioVenta decimal(10,2),
PrecioTotal decimal(10,2)
)
go
create table Negocio(
Id int primary key identity(1,1),
RazonSocial varchar(100),
RUC varchar(20),
Direccion varchar(100),
Celular varchar(10),
Correo varchar(30),
SimboloMoneda varchar(5),
NombreLogo varchar(100),
UrlLogo varchar(200)
)

go

create table Menu(
Id int primary key identity(1,1),
NombreMenu varchar(50) not null,
IdMenuPadre int default 0 not null
)
go
create table MenuRol(
Id int primary key identity(1,1),
IdMenu int references Menu(Id),
IdRol int references Rol(Id),
Activo bit default 1
)