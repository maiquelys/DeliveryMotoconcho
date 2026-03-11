using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Delivery.Datos
{
    public class PedidoDAO
    {
        public List<Pedido> ObtenerTodos()
        {
            List<Pedido> lista = new List<Pedido>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pedido", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Pedido
                    {
                        PedidoID = (int)dr["PedidoID"],
                        RepartidorID = (int)dr["RepartidorID"],
                        ZonaID = (int)dr["ZonaID"],
                        FechaPedido = (DateTime)dr["FechaPedido"],
                        DireccionEntrega = dr["DireccionEntrega"].ToString(),
                        Estado = dr["Estado"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insertar(Pedido p)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Pedido (RepartidorID, ZonaID, DireccionEntrega, Estado) VALUES (@RepartidorID, @ZonaID, @DireccionEntrega, @Estado)", con);
                cmd.Parameters.AddWithValue("@RepartidorID", p.RepartidorID);
                cmd.Parameters.AddWithValue("@ZonaID", p.ZonaID);
                cmd.Parameters.AddWithValue("@DireccionEntrega", p.DireccionEntrega);
                cmd.Parameters.AddWithValue("@Estado", p.Estado);
                cmd.ExecuteNonQuery();
            }
        }
    }
}