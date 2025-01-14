
using Microsoft.Extensions.DependencyInjection;
using SVContenedor.DB;
using SVContenedor.Implementacion;
using SVContenedor.Interfaces;

namespace SVContenedor
{
 public static class InyeccionDependencias
 {
  public static void RegistroContenedorDependencias(this IServiceCollection servicios)
  {
   servicios.AddSingleton<Conexion>();
   servicios.AddTransient<IMedidaContenedor, MedidaContenedor>();
   servicios.AddTransient<ICategoriaContenedor, CategoriaContenedor>();
   servicios.AddTransient<IProductoContenedor, ProductoContenedor>();

  }

 }
}
