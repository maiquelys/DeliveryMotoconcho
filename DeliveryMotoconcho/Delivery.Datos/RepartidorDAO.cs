using System.Collections.Generic;
using System.Data.SqlClient;

namespace Delivery.Datos
{
    public class RepartidorDAO
    {
        public List<Repartidor> ObtenerTodos()
        {
            List<Repartidor> lista = new List<Repartidor>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Repartidor", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Repartidor
                    {
                        RepartidorID = (int)dr["RepartidorID"],
                        Nombre = dr["Nombre"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        ZonaID = (int)dr["ZonaID"],
                        Disponible = (bool)dr["Disponible"]
                    });
                }
            }
            return lista;
        }

        public void Insertar(Repartidor r)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Repartidor (Nombre, Telefono, ZonaID, Disponible) VALUES (@Nombre, @Telefono, @ZonaID, @Disponible)", con);
                cmd.Parameters.AddWithValue("@Nombre", r.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", r.Telefono);
                cmd.Parameters.AddWithValue("@ZonaID", r.ZonaID);
                cmd.Parameters.AddWithValue("@Disponible", r.Disponible);
                cmd.ExecuteNonQuery();
            }
        }
    }
}