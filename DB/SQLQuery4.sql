create procedure sp_listaProducto
(  
@Buscar varchar(50) = ''  
)  
as  
begin  
 
 select
 p.Id,
 c.Id[IdCategoria],
 c.Nombre[NombreCategoria],
 p.Codigo,
 p.Descripcion,
 p.PrecioCompra,
 p.PrecioVenta,
 p.Cantidad,
 p.Activo
 from Producto p
 inner join Categoria c on c.Id = p.IdCategoria
 where 
 CONCAT(p.Codigo,p.Descripcion,c.Nombre,iif(p.activo =1,'SI','NO'))
 like '%' + @Buscar + '%'  
end 
go

CREATE PROCEDURE sp_crearProducto(  
@IdCategoria int,
@Codigo varchar(50),
@Descripcion varchar(150),
@PrecioCompra decimal(10,2),
@PrecioVenta decimal(10,2),
@Cantidad int,
@MsjError varchar(100) output  
)  
as  
begin  
 set @MsjError = ''  
  
 if(exists(select * from Producto where Descripcion = @Descripcion))  
 begin  
  set @MsjError = 'La descripcion del producto ya existe'  
  return  
 end  
  
 insert into Producto(IdCategoria,Codigo,Descripcion,PrecioCompra,PrecioVenta,Cantidad)  
 values(@IdCategoria,@Codigo,@Descripcion,@PrecioCompra,@PrecioVenta,@Cantidad)  
  
end
go

CREATE PROCEDURE sp_editarProducto(  
@IdProducto int,  
@IdCategoria int,
@Codigo varchar(50),
@Descripcion varchar(150),
@PrecioCompra decimal(10,2),
@PrecioVenta decimal(10,2),
@Cantidad int,  
@Activo int,  
@MsjError varchar(100) output  
)  
as  
begin  
 set @MsjError = ''  
  
 if(exists(select * from Producto where Descripcion = @Descripcion  
 and Id != @IdProducto  
 ))  
 begin  
  set @MsjError = 'La descripcion del producto ya existe'  
  return  
 end  
  
 update Producto set  
 IdCategoria = @IdCategoria,
 Codigo= @Codigo,
 Descripcion = @Descripcion,
 PrecioCompra = @PrecioCompra,
 PrecioVenta = @PrecioVenta,
 Cantidad = @Cantidad,
 Activo = @Activo  
 where Id = @IdProducto  
  
end