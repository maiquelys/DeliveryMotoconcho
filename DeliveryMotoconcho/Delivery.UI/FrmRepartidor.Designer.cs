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
            this.SuspendLayout();

            // label1 - Nombre
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "Nombre:";
            this.label1.Size = new System.Drawing.Size(70, 20);

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(100, 18);
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.Name = "txtNombre";

            // label2 - Telefono
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Text = "Teléfono:";
            this.label2.Size = new System.Drawing.Size(70, 20);

            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(100, 53);
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.Name = "txtTelefono";

            // label3 - Zona
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Text = "Zona:";
            this.label3.Size = new System.Drawing.Size(70, 20);

            // cmbZona
            this.cmbZona.Location = new System.Drawing.Point(100, 88);
            this.cmbZona.Size = new System.Drawing.Size(200, 20);
            this.cmbZona.Name = "cmbZona";

            // chkDisponible
            this.chkDisponible.Location = new System.Drawing.Point(100, 125);
            this.chkDisponible.Text = "Disponible";
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(100, 20);

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(100, 160);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(210, 160);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // dgvRepartidores
            this.dgvRepartidores.Location = new System.Drawing.Point(20, 210);
            this.dgvRepartidores.Size = new System.Drawing.Size(560, 200);
            this.dgvRepartidores.Name = "dgvRepartidores";

            // Form
            this.ClientSize = new System.Drawing.Size(620, 450);
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
            this.ResumeLayout(false);
        }

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