using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaFrontEnd.GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            // Configurar eventos de los items del menú
            itemAgregarLibro.Click += (sender, e) => AbrirFormulario(new frmAgregarLibro());
            itemListarLibros.Click += (sender, e) => AbrirFormulario(new frmListarLibros());
            itemAgregarUsuario.Click += (sender, e) => AbrirFormulario(new frmAgregarUsuario());
            itemPrestarLibros.Click += (sender, e) => AbrirFormulario(new frmPrestarLibros());
            itemDevolverLibros.Click += (sender, e) => AbrirFormulario(new frmDevolverLibros());
            itemListarPrestamos.Click += (sender, e) => AbrirFormulario(new frmListarPrestamos());
            itemBackup.Click += (sender, e) => AbrirFormulario(new frmGestionBackup());
            itemSalir.Click += (sender, e) => Application.Exit();
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Configuración adicional al cargar el formulario
            this.WindowState = FormWindowState.Maximized;
            lblBienvenida.Text = "Bienvenido al Sistema de Gestión Bibliotecaria";
        }

        private void menuPrestamos_Click(object sender, EventArgs e)
        {

        }
    }
}
