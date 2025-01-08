

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SVContenedor.DB
{
    public class Conexion
    {
        private IConfiguration _configuracion;
        private string _cadenaSql=null!;

        public Conexion(IConfiguration configuracion)
        {
            _configuracion = configuracion;
            _cadenaSql = _configuracion.GetConnectionString("CadenaSql")!;
        }

      public SqlConnection ObtenerSQLConexion()
        {
            return new SqlConnection(_cadenaSql);
        }

    }
}
