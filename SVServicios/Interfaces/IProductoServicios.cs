using SVContenedor.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVServicios.Interfaces
{
 public interface IProductoServicios
 {
  Task<List<Producto>> Listar(string buscar = "");
  Task<string> Crear(Producto objeto);
  Task<string> Editar(Producto objeto);
 }
}
