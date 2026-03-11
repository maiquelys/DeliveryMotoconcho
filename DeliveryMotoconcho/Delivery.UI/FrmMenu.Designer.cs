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
            this.btnRepartidores = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnLiquidacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Text = "Sistema de Delivery";
            this.label1.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            this.label1.Size = new System.Drawing.Size(280, 35);
            this.label1.Name = "label1";

            this.btnRepartidores.Location = new System.Drawing.Point(100, 80);
            this.btnRepartidores.Text = "Gestión de Repartidores";
            this.btnRepartidores.Name = "btnRepartidores";
            this.btnRepartidores.Size = new System.Drawing.Size(200, 45);
            this.btnRepartidores.Click += new System.EventHandler(this.btnRepartidores_Click);

            this.btnPedidos.Location = new System.Drawing.Point(100, 145);
            this.btnPedidos.Text = "Gestión de Pedidos";
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(200, 45);
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);

            this.btnLiquidacion.Location = new System.Drawing.Point(100, 210);
            this.btnLiquidacion.Text = "Liquidación Diaria";
            this.btnLiquidacion.Name = "btnLiquidacion";
            this.btnLiquidacion.Size = new System.Drawing.Size(200, 45);
            this.btnLiquidacion.Click += new System.EventHandler(this.btnLiquidacion_Click);

            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRepartidores);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnLiquidacion);
            this.Text = "Menú Principal - Delivery";
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRepartidores;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnLiquidacion;
    }
}