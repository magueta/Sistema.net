﻿

using SVContenedor.Entidades;
using SVContenedor.Interfaces;
using SVServicios.Interfaces;

namespace SVServicios.Implementacion
{
 public class CategoriaServicios : ICategoriaServicios
 {
  private readonly ICategoriaContenedor _CategoriaContenedor;

  public CategoriaServicios(ICategoriaContenedor CategoriaContenedor)
  {
   _CategoriaContenedor = CategoriaContenedor;
  }

  public async Task<List<Categoria>> Listar(string buscar = "")
  {
   return await _CategoriaContenedor.Listar(buscar);
  }

  public async Task<string> Crear(Categoria oCategoria)
  {
   return await _CategoriaContenedor.Crear(oCategoria);
  }

  public async Task<string> Editar(Categoria oCategoria)
  {
   return await _CategoriaContenedor.Editar(oCategoria);

  }

  
 }
}