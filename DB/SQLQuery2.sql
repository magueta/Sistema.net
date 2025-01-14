



create procedure sp_listaMedida
as
begin
	select Id,Nombre,Abreviatura,Equivalente,Valor from Medida
end
go

create procedure sp_listaCategoria
(
@Buscar varchar(50) = ''
)
as
begin
	select
	c.Id,
	c.Nombre,
	m.Id[IdMedida],
	m.Nombre[NombreMedida],
	c.Activo
	from
	Categoria c
	inner join Medida m on m.Id = c.IdMedida
	where concat(c.Nombre,m.Nombre,iif(c.activo =1 ,'SI','NO')) 
	like '%' + @Buscar + '%'
end
go

sp_help Categoria

go

CREATE PROCEDURE sp_crearCategoria(
@Nombre varchar(50),
@IdMedida int,
@MsjError varchar(100) output
)
as
begin
	set @MsjError = ''

	if(exists(select * from Categoria where Nombre = @Nombre))
	begin
		set @MsjError = 'El nombre de categoria ya existe'
		return
	end

	insert into Categoria(Nombre,IdMedida)
	values(@Nombre,@IdMedida)

end

go


CREATE PROCEDURE sp_editarCategoria(
@IdCategoria int,
@Nombre varchar(50),
@IdMedida int,
@Activo int,
@MsjError varchar(100) output
)
as
begin
	set @MsjError = ''

	if(exists(select * from Categoria where Nombre = @Nombre
	and Id != @IdCategoria
	))
	begin
		set @MsjError = 'El nombre de categoria ya existe'
		return
	end

	update Categoria set
	Nombre = @Nombre,
	IdMedida = @IdMedida,
	Activo = @Activo
	where Id = @IdCategoria

end