using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaFrontEnd.GUI
{
    partial class frmRegistrarDevolucion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnDevolver, btnCancelar;

        private void InitializeComponent()
        {
            this.dgvPrestamos = new DataGridView();
            this.btnDevolver = new Button();
            this.btnCancelar = new Button();
            ((ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            this.dgvPrestamos.Location = new Point(20, 20);
            this.dgvPrestamos.Size = new Size(500, 300);
            this.dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.ReadOnly = true;
            // 
            // btnDevolver
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.Location = new Point(150, 340);
            this.btnDevolver.Click += btnDevolver_Click;
            // 
            // btnCancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new Point(300, 340);
            this.btnCancelar.Click += (s, e) => this.Close();
            // 
            // frmRegistrarDevolucion
            this.ClientSize = new Size(540, 380);
            this.Controls.AddRange(new Control[] { dgvPrestamos, btnDevolver, btnCancelar });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Registrar Devolución";
            ((ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}