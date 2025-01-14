

using Microsoft.Extensions.DependencyInjection;
using SVContenedor.Implementacion;
using SVContenedor.Interfaces;
using SVServicios.Implementacion;
using SVServicios.Interfaces;

namespace SVServicios
{
 public static class InyeccionDependencias
 {
  public static void RegistroServiciosDependencias(this IServiceCollection servicios)
  {
   servicios.AddTransient<IMedidaServicios, MedidaServicios>();
   servicios.AddTransient<ICategoriaServicios, CategoriaServicios>();
   servicios.AddTransient<IProductoServicios, ProductoServicios>();
  }

 }
}
