

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SVContenedor.DB
{
    public class conexion
    {
        private IConfiguration _configuracion;
        private string _cadenaSql=null!;

        public conexion(IConfiguration configuracion)
        {
            _configuracion = configuracion;
            _cadenaSql = _configuracion.GetConnectionString("CadenaSql")!;
        }

      public SqlConnection Obtener()
        {
            return new SqlConnection(_cadenaSql);
        }

    }
}
