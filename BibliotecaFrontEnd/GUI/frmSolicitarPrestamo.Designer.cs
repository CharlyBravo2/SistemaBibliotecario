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
            this.cmbUsuarios = new ComboBox();
            this.clbLibros = new CheckedListBox();
            this.numDias = new NumericUpDown();
            this.lblUsuario = new Label();
            this.lblLibros = new Label();
            this.lblDias = new Label();
            this.btnSolicitar = new Button();
            this.btnCancelar = new Button();
            ((ISupportInitialize)(this.numDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Location = new Point(20, 20);
            // 
            // cmbUsuarios
            this.cmbUsuarios.Location = new Point(100, 16);
            this.cmbUsuarios.Width = 250;
            // 
            // lblLibros
            this.lblLibros.AutoSize = true;
            this.lblLibros.Text = "Libros:";
            this.lblLibros.Location = new Point(20, 60);
            // 
            // clbLibros
            this.clbLibros.Location = new Point(100, 60);
            this.clbLibros.Size = new Size(250, 150);
            // 
            // lblDias
            this.lblDias.AutoSize = true;
            this.lblDias.Text = "Días préstamo:";
            this.lblDias.Location = new Point(20, 230);
            // 
            // numDias
            this.numDias.Location = new Point(120, 228);
            this.numDias.Minimum = 1;
            this.numDias.Maximum = 365;
            this.numDias.Value = 15;
            // 
            // btnSolicitar
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.Location = new Point(100, 270);
            this.btnSolicitar.Click += btnSolicitar_Click;
            // 
            // btnCancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new Point(200, 270);
            this.btnCancelar.Click += (s, e) => this.Close();
            // 
            // frmSolicitarPrestamo
            this.ClientSize = new Size(380, 320);
            this.Controls.AddRange(new Control[]{
                lblUsuario, cmbUsuarios,
                lblLibros, clbLibros,
                lblDias, numDias,
                btnSolicitar, btnCancelar
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Solicitar Préstamo";
            ((ISupportInitialize)(this.numDias)).EndInit();
            this.ResumeLayout(false);
        }
    }
}