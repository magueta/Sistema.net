

using Microsoft.Data.SqlClient;
using SVContenedor.DB;
using SVContenedor.Entidades;
using SVContenedor.Interfaces;
using System.Data;
using System.Text.RegularExpressions;

namespace SVContenedor.Implementacion
{

 public class ProductoContenedor : IProductoContenedor
 {

  private readonly Conexion _conexcion;
  public ProductoContenedor(Conexion conexion)
  {
   _conexcion = conexion;
  }
  public async Task<List<Producto>> Listar(string buscar = "")
  {
   List<Producto> lista = new List<Producto>();
   using (var con = _conexcion.ObtenerSQLConexion())
   {
    con.Open();
    var cmd = new SqlCommand("sp_listaProducto", con);
    cmd.Parameters.AddWithValue("@Buscar", buscar);
    cmd.CommandType = CommandType.StoredProcedure;
    using (var dr = await cmd.ExecuteReaderAsync())
    {
     while (await dr.ReadAsync())
     {
      lista.Add(new Producto
      {
       Id = Convert.ToInt32(dr["Id"]),
       Descripcion = dr["Descripcion"].ToString()!,
       Activo = Convert.ToInt32(dr["Activo"]),
       RefCategoria = new Categoria
       {
        Id = Convert.ToInt32(dr["IdCategoria"]),
        Nombre = dr["NombreCategoria"].ToString()!,
       },
       Codigo = dr["Codigo"].ToString()!,
       PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
       PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
       Cantidad = Convert.ToInt32(dr["Cantidad"]),
      });

     }
    }
   }
   return lista;
  }

  public async Task<string> Crear(Producto objeto)
  {
   string respuesta = "";
   using (var con = _conexcion.ObtenerSQLConexion())
   {
    con.Open();
    var cmd = new SqlCommand("sp_crearProducto", con);
    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
    cmd.Parameters.AddWithValue("@IdCategoria", objeto.RefCategoria.Id);
    cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
    cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
    cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
    cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);



    cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
    cmd.CommandType = CommandType.StoredProcedure;
    try
    {
     await cmd.ExecuteNonQueryAsync();
     respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
    }
    catch
    {
     respuesta = "Error(rp): no se pudo procesar";
    }
   }
   return respuesta!;
  }

  public async Task<string> Editar(Producto objeto)
  {
   string respuesta = "";
   using (var con = _conexcion.ObtenerSQLConexion())
   {
    con.Open();
    var cmd = new SqlCommand("sp_editarProducto", con);
    cmd.Parameters.AddWithValue("@IdProducto", objeto.Id);
    cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
    cmd.Parameters.AddWithValue("@IdCategoria", objeto.RefCategoria.Id);
    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
    cmd.Parameters.AddWithValue("@PrecioCompra", objeto.PrecioCompra);
    cmd.Parameters.AddWithValue("@PrecioVenta", objeto.PrecioVenta);
    cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
    cmd.Parameters.AddWithValue("@Activo", objeto.Activo);
    cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
    cmd.CommandType = CommandType.StoredProcedure;


    try
    {
     await cmd.ExecuteNonQueryAsync();
     respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
    }
    catch
    {
     respuesta = "Error(rp): no se pudo procesar";
    }
   }
   return respuesta;
  }


 }
}
