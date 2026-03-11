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

            // Fondo del formulario
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            // Título
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Text = "🛵 Sistema de Delivery";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.label1.Size = new System.Drawing.Size(340, 40);
            this.label1.Name = "label1";
            this.label1.BackColor = System.Drawing.Color.Transparent;

            // Botón Repartidores
            this.btnRepartidores.Location = new System.Drawing.Point(100, 100);
            this.btnRepartidores.Text = "👤  Gestión de Repartidores";
            this.btnRepartidores.Name = "btnRepartidores";
            this.btnRepartidores.Size = new System.Drawing.Size(250, 50);
            this.btnRepartidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepartidores.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnRepartidores.ForeColor = System.Drawing.Color.White;
            this.btnRepartidores.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnRepartidores.FlatAppearance.BorderSize = 0;
            this.btnRepartidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepartidores.Click += new System.EventHandler(this.btnRepartidores_Click);

            // Botón Pedidos
            this.btnPedidos.Location = new System.Drawing.Point(100, 170);
            this.btnPedidos.Text = "📦  Gestión de Pedidos";
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(250, 50);
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnPedidos.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnPedidos.FlatAppearance.BorderSize = 1;
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);

            // Botón Liquidación
            this.btnLiquidacion.Location = new System.Drawing.Point(100, 240);
            this.btnLiquidacion.Text = "💰  Liquidación Diaria";
            this.btnLiquidacion.Name = "btnLiquidacion";
            this.btnLiquidacion.Size = new System.Drawing.Size(250, 50);
            this.btnLiquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquidacion.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnLiquidacion.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnLiquidacion.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnLiquidacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnLiquidacion.FlatAppearance.BorderSize = 1;
            this.btnLiquidacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiquidacion.Click += new System.EventHandler(this.btnLiquidacion_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(450, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRepartidores);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnLiquidacion);
            this.Text = "Delivery Motoconcho";
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