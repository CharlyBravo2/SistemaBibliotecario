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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                btnAgregar.Enabled = false;

                
                var librosExistentes = await Task.Run(() => BibliotecaService.ObtenerLibros());

                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("El título no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitulo.Focus();
                    return;
                }
                if (librosExistentes.Any(l => l.Titulo.Equals(txtTitulo.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Ya existe un libro con ese título.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitulo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtISBN.Text) || !txtISBN.Text.All(char.IsDigit) ||
                   txtISBN.Text.Length < 10 || txtISBN.Text.Length > 13)
                {
                    MessageBox.Show("El ISBN debe contener entre 10 y 13 números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtISBN.Focus();
                    return;
                }
                if (librosExistentes.Any(l => l.ISBN == txtISBN.Text.Trim()))
                {
                    MessageBox.Show("Ya existe un libro con ese ISBN.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtISBN.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAutorNombre.Text) || string.IsNullOrWhiteSpace(txtAutorApellido.Text))
                {
                    MessageBox.Show("El nombre y apellido del autor son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAutorNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEditorialNombre.Text))
                {
                    MessageBox.Show("El nombre de la editorial es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEditorialNombre.Focus();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtEditorialTelefono.Text) && !txtEditorialTelefono.Text.All(char.IsDigit))
                {
                    MessageBox.Show("El teléfono de la editorial debe contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEditorialTelefono.Focus();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtEditorialCorreo.Text) && !txtEditorialCorreo.Text.Contains("@"))
                {
                    MessageBox.Show("El correo de la editorial debe contener '@'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEditorialCorreo.Focus();
                    return;
                }

                if (numEjemplares.Value <= 0)
                {
                    MessageBox.Show("Debe indicar al menos un ejemplar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numEjemplares.Focus();
                    return;
                }

                if (numAnioPublicacion.Value < 1500 || numAnioPublicacion.Value > DateTime.Now.Year)
                {
                    MessageBox.Show("El año de publicación no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numAnioPublicacion.Focus();
                    return;
                }

                
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

                btnAgregar.Enabled = false;

                RespuestaServidor respuesta = await Task.Run(() =>
                    BibliotecaService.EnviarConRespuesta(nuevoLibro, "Libro")
                );

                if (!respuesta.Exito)
                {
                    MessageBox.Show($"Error: {respuesta.Mensaje}", "Error del servidor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAgregar.Enabled = true;
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
