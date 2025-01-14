

using SVContenedor.Entidades;
using SVContenedor.Interfaces;
using SVServicios.Interfaces;

namespace SVServicios.Implementacion
{
 public class ProductoServicios : IProductoServicios
 {
  private readonly IProductoContenedor _ProductoContenedor;

  public ProductoServicios(IProductoContenedor ProductoContenedor)
  {
   _ProductoContenedor = ProductoContenedor;
  }
  public async Task<List<Producto>> Listar(string buscar = "")
  {
   return await _ProductoContenedor.Listar(buscar);
  }
  public async Task<string> Crear(Producto objeto)
  {
   return await _ProductoContenedor.Crear(objeto);

  }
  public async Task<string> Editar(Producto objeto)
  {
   return await _ProductoContenedor.Editar(objeto);
  }


 }
}
