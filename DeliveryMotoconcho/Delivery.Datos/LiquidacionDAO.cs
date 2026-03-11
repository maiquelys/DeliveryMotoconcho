using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Delivery.Datos
{
    public class LiquidacionDAO
    {
        public List<LiquidacionDiaria> ObtenerTodos()
        {
            List<LiquidacionDiaria> lista = new List<LiquidacionDiaria>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LiquidacionDiaria", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new LiquidacionDiaria
                    {
                        LiquidacionID = (int)dr["LiquidacionID"],
                        RepartidorID = (int)dr["RepartidorID"],
                        Fecha = (DateTime)dr["Fecha"],
                        TotalEntregas = (int)dr["TotalEntregas"],
                        TotalGanado = (decimal)dr["TotalGanado"],
                        Cerrada = (bool)dr["Cerrada"]
                    });
                }
            }
            return lista;
        }

        public void Insertar(LiquidacionDiaria l)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO LiquidacionDiaria (RepartidorID, Fecha, TotalEntregas, TotalGanado, Cerrada) VALUES (@RepartidorID, @Fecha, @TotalEntregas, @TotalGanado, @Cerrada)", con);
                cmd.Parameters.AddWithValue("@RepartidorID", l.RepartidorID);
                cmd.Parameters.AddWithValue("@Fecha", l.Fecha);
                cmd.Parameters.AddWithValue("@TotalEntregas", l.TotalEntregas);
                cmd.Parameters.AddWithValue("@TotalGanado", l.TotalGanado);
                cmd.Parameters.AddWithValue("@Cerrada", l.Cerrada);
                cmd.ExecuteNonQuery();
            }
        }

        public void CerrarLiquidacion(int liquidacionID)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE LiquidacionDiaria SET Cerrada = 1 WHERE LiquidacionID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", liquidacionID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}