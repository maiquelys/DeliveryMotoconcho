using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Delivery.Datos;

namespace Delivery.UI
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarRanking();
            CargarPromedio();
        }

        private void CargarRanking()
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_RankingEntregas ORDER BY TotalEntregas DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRanking.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ranking: " + ex.Message);
            }
        }

        private void CargarPromedio()
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_PromedioEntregas", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPromedio.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promedio: " + ex.Message);
            }
        }
    }
}