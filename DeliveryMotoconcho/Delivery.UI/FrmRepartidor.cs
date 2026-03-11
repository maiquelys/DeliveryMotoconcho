using System;
using System.Windows.Forms;
using Delivery.Datos;
using Delivery.Negocios;

namespace Delivery.UI
{
    public partial class FrmRepartidor : Form
    {
        RepartidorNegocio negocio = new RepartidorNegocio();
        ZonaDAO zonaDAO = new ZonaDAO();

        public FrmRepartidor()
        {
            InitializeComponent();
            CargarZonas();
            CargarRepartidores();
        }

        private void CargarZonas()
        {
            cmbZona.DataSource = zonaDAO.ObtenerTodos();
            cmbZona.DisplayMember = "Nombre";
            cmbZona.ValueMember = "ZonaID";
        }

        private void CargarRepartidores()
        {
            dgvRepartidores.DataSource = negocio.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Repartidor r = new Repartidor
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                ZonaID = (int)cmbZona.SelectedValue,
                Disponible = chkDisponible.Checked
            };

            negocio.Registrar(r);
            MessageBox.Show("Repartidor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            CargarRepartidores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            chkDisponible.Checked = false;
            cmbZona.SelectedIndex = 0;
        }
    }
}