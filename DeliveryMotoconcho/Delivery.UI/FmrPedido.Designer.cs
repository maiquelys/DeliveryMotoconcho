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
            this.SuspendLayout();

            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "Repartidor:";
            this.label1.Size = new System.Drawing.Size(80, 20);

            this.cmbRepartidor.Location = new System.Drawing.Point(110, 18);
            this.cmbRepartidor.Size = new System.Drawing.Size(200, 20);
            this.cmbRepartidor.Name = "cmbRepartidor";

            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Text = "Zona:";
            this.label2.Size = new System.Drawing.Size(80, 20);

            this.cmbZona.Location = new System.Drawing.Point(110, 53);
            this.cmbZona.Size = new System.Drawing.Size(200, 20);
            this.cmbZona.Name = "cmbZona";

            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Text = "Dirección:";
            this.label3.Size = new System.Drawing.Size(80, 20);

            this.txtDireccion.Location = new System.Drawing.Point(110, 88);
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.Name = "txtDireccion";

            this.btnGuardar.Location = new System.Drawing.Point(110, 130);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(220, 130);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.dgvPedidos.Location = new System.Drawing.Point(20, 180);
            this.dgvPedidos.Size = new System.Drawing.Size(560, 200);
            this.dgvPedidos.Name = "dgvPedidos";

            this.ClientSize = new System.Drawing.Size(620, 420);
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
            this.ResumeLayout(false);
        }

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