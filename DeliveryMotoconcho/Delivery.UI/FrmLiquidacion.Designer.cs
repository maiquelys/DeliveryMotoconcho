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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            this.labelTitulo.Location = new System.Drawing.Point(20, 15);
            this.labelTitulo.Text = "💰 Liquidación Diaria";
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.labelTitulo.Size = new System.Drawing.Size(350, 30);
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;

            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Text = "Repartidor:";
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.cmbRepartidor.Location = new System.Drawing.Point(120, 63);
            this.cmbRepartidor.Size = new System.Drawing.Size(200, 20);
            this.cmbRepartidor.Name = "cmbRepartidor";
            this.cmbRepartidor.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.cmbRepartidor.ForeColor = System.Drawing.Color.White;
            this.cmbRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Text = "Total Entregas:";
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.BackColor = System.Drawing.Color.Transparent;

            this.txtTotalEntregas.Location = new System.Drawing.Point(120, 98);
            this.txtTotalEntregas.Size = new System.Drawing.Size(200, 20);
            this.txtTotalEntregas.Name = "txtTotalEntregas";
            this.txtTotalEntregas.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtTotalEntregas.ForeColor = System.Drawing.Color.White;
            this.txtTotalEntregas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Text = "Total Ganado:";
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.BackColor = System.Drawing.Color.Transparent;

            this.txtTotalGanado.Location = new System.Drawing.Point(120, 133);
            this.txtTotalGanado.Size = new System.Drawing.Size(200, 20);
            this.txtTotalGanado.Name = "txtTotalGanado";
            this.txtTotalGanado.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtTotalGanado.ForeColor = System.Drawing.Color.White;
            this.txtTotalGanado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnGuardar.Location = new System.Drawing.Point(50, 175);
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 35);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnCerrar.Location = new System.Drawing.Point(185, 175);
            this.btnCerrar.Text = "🔒 Cerrar Liquidación";
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 35);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnCerrar.FlatAppearance.BorderSize = 1;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(350, 175);
            this.btnLimpiar.Text = "🗑️ Limpiar";
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 35);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnLimpiar.FlatAppearance.BorderSize = 1;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.dgvLiquidaciones.Location = new System.Drawing.Point(20, 230);
            this.dgvLiquidaciones.Size = new System.Drawing.Size(560, 200);
            this.dgvLiquidaciones.Name = "dgvLiquidaciones";
            this.dgvLiquidaciones.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvLiquidaciones.ForeColor = System.Drawing.Color.White;
            this.dgvLiquidaciones.GridColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvLiquidaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLiquidaciones.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvLiquidaciones.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLiquidaciones.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvLiquidaciones.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLiquidaciones.EnableHeadersVisualStyles = false;

            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.labelTitulo);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelTitulo;
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