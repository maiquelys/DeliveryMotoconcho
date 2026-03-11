using System;
using System.Windows.Forms;
using Delivery.Datos;
using Delivery.Negocios;

namespace Delivery.UI
{
    public partial class FrmPedido : Form
    {
        PedidoNegocio negocio = new PedidoNegocio();
        RepartidorNegocio repartidorNegocio = new RepartidorNegocio();
        ZonaDAO zonaDAO = new ZonaDAO();

        public FrmPedido()
        {
            InitializeComponent();
            CargarRepartidores();
            CargarZonas();
            CargarPedidos();
        }

        private void CargarRepartidores()
        {
            cmbRepartidor.DataSource = repartidorNegocio.ObtenerDisponibles();
            cmbRepartidor.DisplayMember = "Nombre";
            cmbRepartidor.ValueMember = "RepartidorID";
        }

        private void CargarZonas()
        {
            cmbZona.DataSource = zonaDAO.ObtenerTodos();
            cmbZona.DisplayMember = "Nombre";
            cmbZona.ValueMember = "ZonaID";
        }

        private void CargarPedidos()
        {
            dgvPedidos.DataSource = negocio.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbRepartidor.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un repartidor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pedido p = new Pedido
            {
                RepartidorID = (int)cmbRepartidor.SelectedValue,
                ZonaID = (int)cmbZona.SelectedValue,
                DireccionEntrega = txtDireccion.Text,
                Estado = "Pendiente"
            };

            string resultado = negocio.RegistrarPedido(p);
            MessageBox.Show(resultado, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarPedidos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtDireccion.Text = "";
            cmbRepartidor.SelectedIndex = 0;
            cmbZona.SelectedIndex = 0;
        }
    }
}