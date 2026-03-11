using System.Data.SqlClient;

namespace Delivery.Datos
{
    public class Conexion
    {
        private static string cadena = "Server=localhost;Database=DeliveryMotoconcho;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}