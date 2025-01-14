


create procedure sp_listaRol
as
begin
	select Id,Nombre from Rol 
end


go

  
create procedure sp_listaUsuario
(  
@Buscar varchar(50) = ''  
)  
as  
begin  
 
 select
 u.Id,
 u.IdRol,
 r.Nombre[NombreRol],
 u.NombreCompleto,
 u.Correo,
 u.NombreUsuario,
 u.Activo
 from 
 Usuario u
 inner join Rol r on r.Id = u.IdRol
 where concat(r.Nombre,u.NombreCompleto,u.Correo,u.NombreUsuario,iif(u.activo =1 ,'SI','NO'))   
 like '%' + @Buscar + '%'  
end  

go
  
CREATE PROCEDURE sp_crearUsuario(  
@IdRol int,
@NombreCompleto varchar(50),
@Correo varchar(50),
@NombreUsuario varchar(50),
@Clave varchar(100),
@MsjError varchar(100) output  
)  
as  
begin  
 set @MsjError = ''  
  
 if(exists(select * from Usuario where Correo = @Correo))  
 begin  
  set @MsjError = 'El correo ya existe'  
  return  
 end  

  if(exists(select * from Usuario where NombreUsuario = @NombreUsuario))  
 begin  
  set @MsjError = 'El nombre de usuario ya existe'  
  return  
 end  
  
 insert into Usuario(IdRol,NombreCompleto,Correo,NombreUsuario,Clave)  
 values(@IdRol,@NombreCompleto,@Correo,@NombreUsuario,@Clave)  
  
end

go

CREATE PROCEDURE sp_editarUsuario(
@IdUsuario int,
@IdRol int,
@NombreCompleto varchar(50),
@Correo varchar(50),
@NombreUsuario varchar(50),
@Activo int,
@MsjError varchar(100) output  
)  
as  
begin  
 set @MsjError = ''  
  
 if(exists(select * from Usuario where Correo = @Correo
 and Id != @IdUsuario
 ))  
 begin  
  set @MsjError = 'El correo ya existe'  
  return  
 end  

  if(exists(select * from Usuario where NombreUsuario = @NombreUsuario
  and Id != @IdUsuario
  ))  
 begin  
  set @MsjError = 'El nombre de usuario ya existe'  
  return  
 end  
  
  update Usuario set
  IdRol = @IdRol,
  NombreCompleto = @NombreCompleto,
  Correo = @Correo,
  NombreUsuario = @NombreUsuario,
  Activo = @Activo
  where Id = @IdUsuario

end