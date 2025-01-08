
using Microsoft.Extensions.DependencyInjection;
using SVContenedor.Implementacion;
using SVContenedor.Interfaces;

namespace SVContenedor
{
 public static class InyeccionDependencias
 {
  public static void RegistroContenedorDependencias(this IServiceCollection servicios)
  {
   servicios.AddTransient<IMedidaContenedor, MedidaContenedor>();
   servicios.AddTransient<ICategoriaContenedor, CategoriaContenedor>();

  }

 }
}
