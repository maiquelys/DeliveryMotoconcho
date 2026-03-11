using System.Collections.Generic;
using System.Data.SqlClient;

namespace Delivery.Datos
{
    public class ZonaDAO
    {
        public List<Zona> ObtenerTodos()
        {
            List<Zona> lista = new List<Zona>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Zona", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Zona
                    {
                        ZonaID = (int)dr["ZonaID"],
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}