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
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
            ConfigurarControlesEspecificos();
        }

        private void ConfigurarControlesEspecificos()
        {
            // Configurar controles específicos según el tipo de usuario
            rbEstudiante.CheckedChanged += (s, e) => {
                pnlEstudiante.Visible = rbEstudiante.Checked;
                pnlProfesor.Visible = !rbEstudiante.Checked;
            };

            rbProfesor.CheckedChanged += (s, e) => {
                pnlProfesor.Visible = rbProfesor.Checked;
                pnlEstudiante.Visible = !rbProfesor.Checked;
            };

            // Establecer estudiante como opción predeterminada
            rbEstudiante.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos())
                    return;

                Usuario nuevoUsuario = CrearUsuario();

                BibliotecaService.EnviarGenerico(nuevoUsuario, "Usuario");

                MessageBox.Show("Usuario agregado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar usuario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                MessageBox.Show("La identificación es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificacion.Focus();
                return false;
            }

           

            if (rbEstudiante.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCarrera.Text))
                {
                    MessageBox.Show("La carrera es obligatoria para estudiantes.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCarrera.Focus();
                    return false;
                }
            }
            else if (rbProfesor.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDepartamento.Text))
                {
                    MessageBox.Show("El departamento es obligatorio para profesores.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDepartamento.Focus();
                    return false;
                }
            }

            return true;
        }

        private Usuario CrearUsuario()
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string identificacion = txtIdentificacion.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (rbEstudiante.Checked)
            {
                return new Estudiante(
                    nombre,
                    apellido,
                    identificacion,
                    correo,
                    telefono,
                    txtCarrera.Text.Trim(),
                    (int)numSemestre.Value,
                    (double)numPromedio.Value,
                    (int)numEdadEstudiante.Value,
                    txtEstadoCivilEstudiante.Text.Trim(),
                    txtTipoBeca.Text.Trim(),
                    chkRegular.Checked
                );
            }
            else
            {
                var profesor = new Profesor(
                    nombre,
                    apellido,
                    identificacion,
                    correo,
                    telefono,
                    txtDepartamento.Text.Trim(),
                    (int)numExperiencia.Value,
                    chkTitular.Checked ? "Sí" : "No",
                    (int)numEdadProfesor.Value,
                    txtEstadoCivilProfesor.Text.Trim(),
                    txtGradoAcademico.Text.Trim()
                );

                // Agregar cursos si existen
                string[] cursos = txtCursos.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var curso in cursos)
                {
                    profesor.CursosImpartidos.Add(curso.Trim());
                }

                return profesor;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
