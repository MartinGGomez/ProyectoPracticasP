drop database SistemaGenerico;
create database SistemaGenerico;
use SistemaGenerico;

create table Clientes(
idCliente int auto_increment,
DNI varchar(20),
Nombre varchar(100),
Apellido varchar(100),
TEL varchar(20),
Direccion varchar(100),
Localidad varchar(100),
Mail varchar(100),
Estado varchar(20),
constraint PK_Clientes primary key (idCliente)
)ENGINE=InnoDB;

create table TipoTrabajo(
idTipo int auto_increment, 
Nombre varchar(100),
constraint PK_TipoTrabajo primary key (idTipo)
)ENGINE=InnoDB;

insert into TipoTrabajo values('',"Administrador");

create table Empleados(
idEmpleado int auto_increment, 
DNI varchar(20),
Nombre varchar(100),
Apellido varchar(100),
Mail varchar(100),
idTipo int,
Estado varchar(20),
constraint PK_Empleados primary key (idEmpleado),
constraint FK_Empleados foreign key (idTipo) references TipoTrabajo (idTipo)
)ENGINE=InnoDB;

insert into Empleados values ('',"","Admin","","",1,"Disponible");

create table Usuarios(
idUsuario int auto_increment, 
idEmpleado int,
Usuario varchar(100),
Contraseña varchar(50),
Administrador boolean,
constraint PK_Usuarios primary key (idUsuario),
constraint FK_Usuarios foreign key (idEmpleado) references Empleados (idEmpleado)
)ENGINE=InnoDB;

insert into Usuarios values ('',1,"admin","admin1234",true);



create table Productos(
idProducto int auto_increment, 
Descripcion varchar(100),
Stock int,
PuntoPedido int,
Precio float,
Estado varchar(20),
constraint PK_Productos primary key (idProducto)
)ENGINE=InnoDB;

create table Proveedores (
idProveedor int auto_increment,
Nombre varchar(100),
Telefono varchar(15),
Mail varchar(100),
Direccion varchar(100),
Estado varchar(20),
constraint PK_Proveedores primary key (idProveedor)
)ENGINE=InnoDB;

create table ProductoProveedor (
idProducto int,
idProveedor int,
constraint PK_ProductoProveedor primary key (idProducto, idProveedor),
constraint FK_ProductoProveedor foreign key (idProducto) references Productos (idProducto),
constraint FK_ProductoProveedor1 foreign key (idProveedor) references Proveedores (idProveedor)
)ENGINE=InnoDB;

create table Compras (
idCompra int auto_increment,
idProveedor int, 
descripcion varchar(100),
fecha date,
montoTotal int,
estado varchar(20),
constraint PK_Compras primary key (idCompra),
constraint FK_Compras foreign key (idProveedor) references Proveedores (idProveedor)
)ENGINE=InnoDB;

create table DetalleCompras (
idDetalleCompra int auto_increment,
idCompra int, 
idProducto int,
cantidad int,
constraint PK_DetalleCompras primary key (idDetalleCompra),
constraint FK_DetalleCompras foreign key (idCompra) references Compras (idCompra),
constraint FK_DetalleCompras1 foreign key (idProducto) references Productos (idProducto)
)ENGINE=InnoDB;

create table Ventas (
idVenta int auto_increment,
idCliente int,
descripcion varchar(100),
fecha date,
montoTotal int, 
constraint PK_Ventas primary key (idVenta),
constraint FK_Ventas foreign key (idCliente) references Clientes (idCliente)
)ENGINE=InnoDB;

create table DetalleVentas (
idDetalleVenta int auto_increment,
idVenta int ,
idProducto int,
cantidad int,
constraint PK_DetalleVentas primary key (idDetalleVenta),
constraint FK_DetalleVentas foreign key (idVenta) references Ventas (idVenta),
constraint FK_DetalleVentas1 foreign key (idProducto) references Productos (idProducto)
)ENGINE=InnoDB;

create table Gastos (
idGasto int auto_increment,
descripcion varchar(100),
tipo varchar(50),
monto int,
fecha date,
constraint PK_Gastos primary key (idGasto)
)ENGINE=InnoDB;


