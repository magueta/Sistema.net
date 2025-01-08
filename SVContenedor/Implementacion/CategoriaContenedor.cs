

using Microsoft.Data.SqlClient;
using SVContenedor.DB;
using SVContenedor.Entidades;
using SVContenedor.Interfaces;
using System.Data;

namespace SVContenedor.Implementacion
{
 public class CategoriaContenedor : ICategoriaContenedor
 {
  private readonly Conexion _conexion;
  public CategoriaContenedor(Conexion conexion)
  {
   _conexion = conexion;
  }
  public async Task<List<Categoria>> Listar(string buscar = "")
  {
   List<Categoria> lista = new List<Categoria>();
   using (var con = _conexion.ObtenerSQLConexion())
   {
    con.Open();
    var cmd = new SqlCommand("sp_listaCategoria", con);
    cmd.Parameters.AddWithValue("@Buscar",buscar);
    cmd.CommandType = CommandType.StoredProcedure;
    using (var dr = await cmd.ExecuteReaderAsync())
    {
     while (await dr.ReadAsync())
     {
      lista.Add(new Categoria
      {
       Id = Convert.ToInt32(dr["Id"]),
       Nombre = dr["Nombre"].ToString()!,
       Activo = Convert.ToInt32(dr["Activo"]),
       RefMedida= new Medida
       {
         Id= Convert.ToInt32(dr["IdMedida"]),
         Nombre= dr["NombreMedida"].ToString()!
       }
      });
     }
    }
   }
   return lista;
  }

  public async Task<string> Crear(Categoria oCategoria)
  {
   string respuesta = "";
   using (var con = _conexion.ObtenerSQLConexion())
   {
    con.Open();
    var cmd = new SqlCommand("sp_editarCategoria", con);
    cmd.Parameters.AddWithValue("@Nombre", oCategoria.Nombre);
    cmd.Parameters.AddWithValue("@idMedida", oCategoria.RefMedida.Id);
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

  public async Task<string> Editar(Categoria oCategoria)
  {
   string respuesta = "";
   using (var con = _conexion.ObtenerSQLConexion())
   {
    con.Open();
    var cmd = new SqlCommand("sp_crearCategoria", con);
    cmd.Parameters.AddWithValue("@idCategoria", oCategoria.Id);
    cmd.Parameters.AddWithValue("@Nombre", oCategoria.Nombre);
    cmd.Parameters.AddWithValue("@idMedida", oCategoria.RefMedida.Id);
    cmd.Parameters.AddWithValue("@Activo", oCategoria.Activo);
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
