namespace Delivery.UI
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnRepartidores = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnLiquidacion = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Size = new System.Drawing.Size(200, 500);
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.panelLateral.Controls.Add(this.labelLogo);
            this.panelLateral.Controls.Add(this.labelSub);
            this.panelLateral.Controls.Add(this.btnRepartidores);
            this.panelLateral.Controls.Add(this.btnPedidos);
            this.panelLateral.Controls.Add(this.btnLiquidacion);

            this.labelLogo.Text = "🛵";
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 36);
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.labelLogo.Size = new System.Drawing.Size(180, 70);
            this.labelLogo.Location = new System.Drawing.Point(10, 20);
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;

            this.labelSub.Text = "Delivery\nMotoconcho";
            this.labelSub.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.labelSub.ForeColor = System.Drawing.Color.White;
            this.labelSub.Size = new System.Drawing.Size(180, 50);
            this.labelSub.Location = new System.Drawing.Point(10, 95);
            this.labelSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSub.BackColor = System.Drawing.Color.Transparent;

            this.btnRepartidores.Text = "👤  Repartidores";
            this.btnRepartidores.Name = "btnRepartidores";
            this.btnRepartidores.Size = new System.Drawing.Size(200, 50);
            this.btnRepartidores.Location = new System.Drawing.Point(0, 180);
            this.btnRepartidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepartidores.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnRepartidores.ForeColor = System.Drawing.Color.White;
            this.btnRepartidores.Font = new System.Drawing.Font("Segoe UI", 10);
            this.btnRepartidores.FlatAppearance.BorderSize = 0;
            this.btnRepartidores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepartidores.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRepartidores.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnPedidos.Text = "📦  Pedidos";
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(200, 50);
            this.btnPedidos.Location = new System.Drawing.Point(0, 235);
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 10);
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnLiquidacion.Text = "💰  Liquidación";
            this.btnLiquidacion.Name = "btnLiquidacion";
            this.btnLiquidacion.Size = new System.Drawing.Size(200, 50);
            this.btnLiquidacion.Location = new System.Drawing.Point(0, 290);
            this.btnLiquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquidacion.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnLiquidacion.ForeColor = System.Drawing.Color.White;
            this.btnLiquidacion.Font = new System.Drawing.Font("Segoe UI", 10);
            this.btnLiquidacion.FlatAppearance.BorderSize = 0;
            this.btnLiquidacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiquidacion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLiquidacion.Cursor = System.Windows.Forms.Cursors.Hand;

            this.panelContenido.Location = new System.Drawing.Point(200, 0);
            this.panelContenido.Size = new System.Drawing.Size(600, 500);
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.panelContenido.Controls.Add(this.labelBienvenida);

            this.labelBienvenida.Text = "🛵 Bienvenida al Sistema\nde Delivery Motoconcho\n\nSelecciona una opción del menú.";
            this.labelBienvenida.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.labelBienvenida.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.labelBienvenida.Size = new System.Drawing.Size(560, 200);
            this.labelBienvenida.Location = new System.Drawing.Point(20, 150);
            this.labelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBienvenida.BackColor = System.Drawing.Color.Transparent;

            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelContenido);
            this.Text = "Sistema Delivery Motoconcho";
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnRepartidores;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnLiquidacion;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelBienvenida;
    }
}