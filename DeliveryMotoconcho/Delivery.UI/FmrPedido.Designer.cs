namespace Delivery.UI
{
    partial class FrmPedido
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
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            this.labelTitulo.Location = new System.Drawing.Point(20, 15);
            this.labelTitulo.Text = "📦 Gestión de Pedidos";
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.labelTitulo.Size = new System.Drawing.Size(350, 30);
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;

            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Text = "Repartidor:";
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.cmbRepartidor.Location = new System.Drawing.Point(110, 63);
            this.cmbRepartidor.Size = new System.Drawing.Size(200, 20);
            this.cmbRepartidor.Name = "cmbRepartidor";
            this.cmbRepartidor.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.cmbRepartidor.ForeColor = System.Drawing.Color.White;
            this.cmbRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Text = "Zona:";
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.BackColor = System.Drawing.Color.Transparent;

            this.cmbZona.Location = new System.Drawing.Point(110, 98);
            this.cmbZona.Size = new System.Drawing.Size(200, 20);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.cmbZona.ForeColor = System.Drawing.Color.White;
            this.cmbZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Text = "Dirección:";
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.BackColor = System.Drawing.Color.Transparent;

            this.txtDireccion.Location = new System.Drawing.Point(110, 133);
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnGuardar.Location = new System.Drawing.Point(110, 175);
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

            this.btnLimpiar.Location = new System.Drawing.Point(245, 175);
            this.btnLimpiar.Text = "🗑️ Limpiar";
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 35);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnLimpiar.FlatAppearance.BorderSize = 1;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.dgvPedidos.Location = new System.Drawing.Point(20, 230);
            this.dgvPedidos.Size = new System.Drawing.Size(560, 200);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvPedidos.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvPedidos.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.EnableHeadersVisualStyles = false;

            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRepartidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvPedidos);
            this.Text = "Gestión de Pedidos";
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRepartidor;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvPedidos;
    }
}