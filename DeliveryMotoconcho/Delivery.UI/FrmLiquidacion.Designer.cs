namespace Delivery.UI
{
    partial class FrmLiquidacion
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
            this.cmbRepartidor = new System.Windows.Forms.ComboBox();
            this.txtTotalEntregas = new System.Windows.Forms.TextBox();
            this.txtTotalGanado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvLiquidaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "Repartidor:";
            this.label1.Size = new System.Drawing.Size(80, 20);

            this.cmbRepartidor.Location = new System.Drawing.Point(110, 18);
            this.cmbRepartidor.Size = new System.Drawing.Size(200, 20);
            this.cmbRepartidor.Name = "cmbRepartidor";

            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Text = "Total Entregas:";
            this.label2.Size = new System.Drawing.Size(90, 20);

            this.txtTotalEntregas.Location = new System.Drawing.Point(110, 53);
            this.txtTotalEntregas.Size = new System.Drawing.Size(200, 20);
            this.txtTotalEntregas.Name = "txtTotalEntregas";

            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Text = "Total Ganado:";
            this.label3.Size = new System.Drawing.Size(90, 20);

            this.txtTotalGanado.Location = new System.Drawing.Point(110, 88);
            this.txtTotalGanado.Size = new System.Drawing.Size(200, 20);
            this.txtTotalGanado.Name = "txtTotalGanado";

            this.btnGuardar.Location = new System.Drawing.Point(50, 130);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnCerrar.Location = new System.Drawing.Point(160, 130);
            this.btnCerrar.Text = "Cerrar Liquidación";
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 30);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(295, 130);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.dgvLiquidaciones.Location = new System.Drawing.Point(20, 180);
            this.dgvLiquidaciones.Size = new System.Drawing.Size(560, 200);
            this.dgvLiquidaciones.Name = "dgvLiquidaciones";

            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRepartidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalEntregas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalGanado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvLiquidaciones);
            this.Text = "Liquidación Diaria";
            this.Name = "FrmLiquidacion";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRepartidor;
        private System.Windows.Forms.TextBox txtTotalEntregas;
        private System.Windows.Forms.TextBox txtTotalGanado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvLiquidaciones;
    }
}