namespace Delivery.UI
{
    partial class FrmReportes
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelRanking = new System.Windows.Forms.Label();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.dgvRanking = new System.Windows.Forms.DataGridView();
            this.dgvPromedio = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            this.labelTitulo.Text = "📊 Reportes";
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.labelTitulo.Size = new System.Drawing.Size(300, 30);
            this.labelTitulo.Location = new System.Drawing.Point(20, 15);
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;

            this.btnCargar.Text = "🔄 Cargar Reportes";
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 35);
            this.btnCargar.Location = new System.Drawing.Point(420, 10);
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);

            this.labelRanking.Text = "🏆 Ranking de Entregas";
            this.labelRanking.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.labelRanking.ForeColor = System.Drawing.Color.White;
            this.labelRanking.Size = new System.Drawing.Size(200, 25);
            this.labelRanking.Location = new System.Drawing.Point(20, 60);
            this.labelRanking.BackColor = System.Drawing.Color.Transparent;

            this.dgvRanking.Location = new System.Drawing.Point(20, 90);
            this.dgvRanking.Size = new System.Drawing.Size(560, 180);
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvRanking.ForeColor = System.Drawing.Color.White;
            this.dgvRanking.GridColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRanking.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvRanking.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRanking.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvRanking.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRanking.EnableHeadersVisualStyles = false;
            this.dgvRanking.ReadOnly = true;

            this.labelPromedio.Text = "📈 Promedio de Entregas";
            this.labelPromedio.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.labelPromedio.ForeColor = System.Drawing.Color.White;
            this.labelPromedio.Size = new System.Drawing.Size(200, 25);
            this.labelPromedio.Location = new System.Drawing.Point(20, 290);
            this.labelPromedio.BackColor = System.Drawing.Color.Transparent;

            this.dgvPromedio.Location = new System.Drawing.Point(20, 320);
            this.dgvPromedio.Size = new System.Drawing.Size(560, 180);
            this.dgvPromedio.Name = "dgvPromedio";
            this.dgvPromedio.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvPromedio.ForeColor = System.Drawing.Color.White;
            this.dgvPromedio.GridColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvPromedio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPromedio.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.dgvPromedio.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPromedio.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvPromedio.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPromedio.EnableHeadersVisualStyles = false;
            this.dgvPromedio.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(620, 530);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.labelRanking);
            this.Controls.Add(this.dgvRanking);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.dgvPromedio);
            this.Text = "Reportes";
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelRanking;
        private System.Windows.Forms.Label labelPromedio;
        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.DataGridView dgvPromedio;
        private System.Windows.Forms.Button btnCargar;
    }
}