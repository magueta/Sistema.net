

using SVContenedor.Entidades;

namespace SVContenedor.Interfaces
{
 public interface IProductoContenedor
 {
  Task<List<Producto>> Listar(string buscar = "");
  Task<string> Crear(Producto objeto);
  Task<string> Editar(Producto objeto);
 }
}
