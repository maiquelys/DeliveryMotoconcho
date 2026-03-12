using System;
using System.Drawing;
using System.Windows.Forms;

namespace Delivery.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            btnRepartidores.Click += btnRepartidores_Click;
            btnPedidos.Click += btnPedidos_Click;
            btnLiquidacion.Click += btnLiquidacion_Click;
        }

        private void ActivarBoton(Button btn)
        {
            btnRepartidores.BackColor = Color.FromArgb(20, 20, 20);
            btnRepartidores.ForeColor = Color.White;
            btnPedidos.BackColor = Color.FromArgb(20, 20, 20);
            btnPedidos.ForeColor = Color.White;
            btnLiquidacion.BackColor = Color.FromArgb(20, 20, 20);
            btnLiquidacion.ForeColor = Color.White;

            btn.BackColor = Color.FromArgb(255, 105, 180);
            btn.ForeColor = Color.White;
        }

        private void AbrirFormulario(Form frm)
        {
            panelContenido.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(frm);
            frm.Show();
        }

        private void btnRepartidores_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnRepartidores);
            AbrirFormulario(new FrmRepartidor());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnPedidos);
            AbrirFormulario(new FrmPedido());
        }

        private void btnLiquidacion_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnLiquidacion);
            AbrirFormulario(new FrmLiquidacion());
        }
    }
}