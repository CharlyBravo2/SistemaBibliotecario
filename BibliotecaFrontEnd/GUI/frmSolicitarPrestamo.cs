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
    public partial class frmSolicitarPrestamo : Form
    {
        private List<Usuario> usuarios;
        private List<Libro> libros;

        public frmSolicitarPrestamo()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                usuarios = BibliotecaService.ObtenerUsuarios();
                libros = BibliotecaService.ObtenerLibros()
                          .Where(l => l.EstaDisponible()).ToList();

                cmbUsuarios.DataSource = usuarios;
                cmbUsuarios.DisplayMember = "Identificacion";
                clbLibros.Items.AddRange(libros.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var seleccionado = usuarios[cmbUsuarios.SelectedIndex];
            var librosSel = clbLibros.CheckedItems.Cast<Libro>().ToList();
            if (!librosSel.Any())
            {
                MessageBox.Show("Seleccione al menos un libro.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var libro in librosSel)
            {
                var prestamo = new Prestamo(
                    libro,
                    seleccionado,
                    DateTime.Now,
                    (int)numDias.Value,
                    1
                );
                try
                {
                    BibliotecaService.RegistrarPrestamo(prestamo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fallo al registrar préstamo de '{libro.Titulo}': {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Préstamo(s) registrado(s) con éxito.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
