using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaFrontEnd.GUI
{
    partial class frmSolicitarPrestamo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.CheckedListBox clbLibros;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.Label lblUsuario, lblLibros, lblDias;
        private System.Windows.Forms.Button btnSolicitar, btnCancelar;

        private void InitializeComponent()
        {
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.clbLibros = new System.Windows.Forms.CheckedListBox();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLibros = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Location = new System.Drawing.Point(100, 16);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(250, 21);
            this.cmbUsuarios.TabIndex = 1;
            // 
            // clbLibros
            // 
            this.clbLibros.Location = new System.Drawing.Point(100, 60);
            this.clbLibros.Name = "clbLibros";
            this.clbLibros.Size = new System.Drawing.Size(250, 139);
            this.clbLibros.TabIndex = 3;
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(120, 228);
            this.numDias.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(120, 20);
            this.numDias.TabIndex = 5;
            this.numDias.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(20, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblLibros
            // 
            this.lblLibros.AutoSize = true;
            this.lblLibros.Location = new System.Drawing.Point(20, 60);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(38, 13);
            this.lblLibros.TabIndex = 2;
            this.lblLibros.Text = "Libros:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(20, 230);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(79, 13);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Días préstamo:";
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(100, 270);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitar.TabIndex = 6;
            this.btnSolicitar.Text = "Solicitar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(200, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            // 
            // frmSolicitarPrestamo
            // 
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.lblLibros);
            this.Controls.Add(this.clbLibros);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.numDias);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSolicitarPrestamo";
            this.Text = "Solicitar Préstamo";
            this.Load += new System.EventHandler(this.frmSolicitarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}