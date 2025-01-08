using SVContenedor.Entidades;

namespace SVServicios.Interfaces
{
 public interface IMedidaServicios
 {
  Task<List<Medida>> Listar();

 }
}
