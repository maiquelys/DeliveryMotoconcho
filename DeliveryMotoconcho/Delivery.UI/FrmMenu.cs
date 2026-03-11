using System;
using System.Windows.Forms;

namespace Delivery.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnRepartidores_Click(object sender, EventArgs e)
        {
            FrmRepartidor frm = new FrmRepartidor();
            frm.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedido frm = new FrmPedido();
            frm.ShowDialog();
        }

        private void btnLiquidacion_Click(object sender, EventArgs e)
        {
            FrmLiquidacion frm = new FrmLiquidacion();
            frm.ShowDialog();
        }
    }
}