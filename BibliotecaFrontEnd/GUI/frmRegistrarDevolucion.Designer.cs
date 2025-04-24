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
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.Location = new System.Drawing.Point(20, 20);
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(500, 300);
            this.dgvPrestamos.TabIndex = 0;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(150, 340);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "Devolver";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            // 
            // frmRegistrarDevolucion
            // 
            this.ClientSize = new System.Drawing.Size(540, 380);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRegistrarDevolucion";
            this.Text = "Registrar Devolución";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);

        }
    }
}