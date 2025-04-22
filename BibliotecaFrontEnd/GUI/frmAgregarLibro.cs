using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaBackEnd.Objetos;
using BibliotecaFrontEnd.Servicios;

namespace BibliotecaFrontEnd.GUI
{
    public partial class frmAgregarLibro : Form
    {
        public frmAgregarLibro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("El título no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear nuevo libro
                Libro nuevoLibro = new Libro(
                    txtTitulo.Text,
                    new Autor(txtAutorNombre.Text, txtAutorApellido.Text, txtAutorNacionalidad.Text,
                             (int)numAutorAnioNacimiento.Value, (int)numAutorLibrosPublicados.Value),
                    new Editorial(txtEditorialNombre.Text, txtEditorialPais.Text, txtEditorialDireccion.Text,
                                txtEditorialTelefono.Text, txtEditorialCorreo.Text,
                                (int)numEditorialAnioFundacion.Value, txtEditorialSitioWeb.Text),
                    new GeneroLiterario(txtGeneroNombre.Text, txtGeneroTema.Text),
                    txtISBN.Text,
                    (int)numAnioPublicacion.Value,
                    (int)numEjemplares.Value
                );

                // Agregar a la lista
                BibliotecaService.EnviarGenerico(nuevoLibro, "Libro");

                MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
