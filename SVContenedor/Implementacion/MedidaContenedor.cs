

using Microsoft.Data.SqlClient;
using SVContenedor.DB;
using SVContenedor.Entidades;
using SVContenedor.Interfaces;
using System.Data;

namespace SVContenedor.Implementacion
{
    public class MedidaContenedor : IMedidaContenedor
    {
     private readonly Conexion _conexion;
     public MedidaContenedor(Conexion conexion)
     {
      _conexion = conexion;
     }
     public async Task<List<Medida>> Listar()
     {
      List<Medida> lista = new List<Medida>();
      using (var con = _conexion.ObtenerSQLConexion())
      {
       con.Open();
       var cmd = new SqlCommand("sp_listaMedida",con);
       cmd.CommandType=CommandType.StoredProcedure;
       using (var dr = await cmd.ExecuteReaderAsync())
       {
        while (await dr.ReadAsync()) 
        {
         lista.Add(new Medida
         {
          Id = Convert.ToInt32(dr["Id"]),
          Nombre = dr["Nombre"].ToString(),
          Abreviatura= dr["Abreviatura"].ToString(),
          Valor = Convert.ToInt32(dr["Valor"]),
         });
        }
       }
      } 
      return lista;
     }
    }
}
