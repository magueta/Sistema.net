
using SVContenedor.Entidades;
using SVContenedor.Interfaces;
using SVServicios.Interfaces;

namespace SVServicios.Implementacion
{
 public class MedidaServicios : IMedidaServicios
 {

  private readonly IMedidaContenedor _MedidaContenedor;


  public MedidaServicios(IMedidaContenedor MedidaContenedor) 
  {
   _MedidaContenedor = MedidaContenedor;

  }

  public async Task<List<Medida>> Listar()
  {
   return await _MedidaContenedor.Listar();
  }
 }
}
