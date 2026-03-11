using System;
using System.Windows.Forms;
using Delivery.Datos;
using Delivery.Negocios;

namespace Delivery.UI
{
    public partial class FrmLiquidacion : Form
    {
        LiquidacionNegocio negocio = new LiquidacionNegocio();
        RepartidorNegocio repartidorNegocio = new RepartidorNegocio();

        public FrmLiquidacion()
        {
            InitializeComponent();
            CargarRepartidores();
            CargarLiquidaciones();
        }

        private void CargarRepartidores()
        {
            cmbRepartidor.DataSource = repartidorNegocio.ObtenerTodos();
            cmbRepartidor.DisplayMember = "Nombre";
            cmbRepartidor.ValueMember = "RepartidorID";
        }

        private void CargarLiquidaciones()
        {
            dgvLiquidaciones.DataSource = negocio.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbRepartidor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un repartidor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTotalEntregas.Text))
            {
                MessageBox.Show("Ingrese el total de entregas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LiquidacionDiaria l = new LiquidacionDiaria
            {
                RepartidorID = (int)cmbRepartidor.SelectedValue,
                Fecha = DateTime.Now,
                TotalEntregas = int.Parse(txtTotalEntregas.Text),
                TotalGanado = decimal.Parse(txtTotalGanado.Text),
                Cerrada = false
            };

            negocio.Registrar(l);
            MessageBox.Show("Liquidación registrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarLiquidaciones();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (dgvLiquidaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una liquidación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvLiquidaciones.SelectedRows[0].Cells["LiquidacionID"].Value;
            string resultado = negocio.CerrarLiquidacion(id);
            MessageBox.Show(resultado, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarLiquidaciones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtTotalEntregas.Text = "";
            txtTotalGanado.Text = "";
            cmbRepartidor.SelectedIndex = 0;
        }
    }
}