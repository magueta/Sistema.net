﻿using SVContenedor.Entidades;

namespace SVServicios.Interfaces
{
 public interface ICategoriaServicios
 {
  Task<List<Categoria>> Listar(string buscar = "");
  Task<string> Crear(Categoria objeto);
  Task<string> Editar(Categoria objeto);

 }
}
