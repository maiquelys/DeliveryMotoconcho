namespace Delivery.UI
{
    partial class FrmRepartidor
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvRepartidores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            this.labelTitulo.Location = new System.Drawing.Point(20, 15);
            this.labelTitulo.Text = "👤 Gestión de Repartidores";
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.labelTitulo.Size = new System.Drawing.Size(350, 30);
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;

            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Text = "Nombre:";
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.txtNombre.Location = new System.Drawing.Point(100, 63);
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Text = "Teléfono:";
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.BackColor = System.Drawing.Color.Transparent;

            this.txtTelefono.Location = new System.Drawing.Point(100, 98);
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Text = "Zona:";
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9);
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.BackColor = System.Drawing.Color.Transparent;

            this.cmbZona.Location = new System.Drawing.Point(100, 133);
            this.cmbZona.Size = new System.Drawing.Size(200, 20);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.cmbZona.ForeColor = System.Drawing.Color.White;
            this.cmbZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.chkDisponible.Location = new System.Drawing.Point(100, 168);
            this.chkDisponible.Text = "Disponible";
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(100, 20);
            this.chkDisponible.ForeColor = System.Drawing.Color.White;
            this.chkDisponible.BackColor = System.Drawing.Color.Transparent;

            this.btnGuardar.Location = new System.Drawing.Point(100, 205);
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

            this.btnLimpiar.Location = new System.Drawing.Point(235, 205);
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

            this.dgvRepartidores.Location = new System.Drawing.Point(20, 260);
            this.dgvRepartidores.Size = new System.Drawing.Size(560, 200);
            this.dgvRepartidores.Name = "dgvRepartidores";
            this.dgvRepartidores.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvRepartidores.ForeColor = System.Drawing.Color.White;
            this.dgvRepartidores.GridColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvRepartidores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRepartidores.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvRepartidores.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRepartidores.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvRepartidores.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRepartidores.EnableHeadersVisualStyles = false;

            this.ClientSize = new System.Drawing.Size(620, 490);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvRepartidores);
            this.Text = "Gestión de Repartidores";
            this.Name = "FrmRepartidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvRepartidores;
    }
}