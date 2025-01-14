

using Microsoft.Data.SqlClient;
using SVContenedor.DB;
using SVContenedor.Entidades;
using SVContenedor.Interfaces;
using System.Data;

namespace SVContenedor.Implementacion
{
 public class CategoriaContenedor : ICategoriaContenedor
 {
  private readonly Conexion _conexcion;
  public CategoriaContenedor(Conexion conexcion)
  {
   _conexcion = conexcion;
  }
  public async Task<List<Categoria>> Listar(string buscar = "")
  {
   List<Categoria> lista = new List<Categoria>();
   using (var con = _conexcion.ObtenerSQLConexion())
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
       RefMedida = new Medida
       {
        Id = Convert.ToInt32(dr["IdMedida"]),
        Nombre = dr["NombreMedida"].ToString()!,
        Abreviatura = dr["Abreviatura"].ToString()!,
        Equivalente = dr["Equivalente"].ToString()!,
        Valor = Convert.ToInt32(dr["Valor"]),
       }
      });
     }
    }
   }
   return lista;
  }

  public async Task<string> Crear(Categoria objeto)
  {
   string respuesta = "";
   using (var con = _conexcion.ObtenerSQLConexion())
   {
    con.Open();
    var cmd = new SqlCommand("sp_crearCategoria", con);
    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
    cmd.Parameters.AddWithValue("@idMedida", objeto.RefMedida.Id);
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

  public async Task<string> Editar(Categoria objeto)
  {
   string respuesta = "";
   using (var con = _conexcion.ObtenerSQLConexion())
   {
    con.Open();
    var cmd = new SqlCommand("sp_editarCategoria", con);
    cmd.Parameters.AddWithValue("@idCategoria", objeto.Id);
    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
    cmd.Parameters.AddWithValue("@idMedida", objeto.RefMedida.Id);
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
