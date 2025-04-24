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
    public partial class frmPrestarLibros : Form
    {
        private List<Libro> librosSeleccionados = new List<Libro>();

        public frmPrestarLibros()
        {
            InitializeComponent();
        }

        public void frmPrestarLibros_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarLibrosDisponibles();
            dtpFechaDevolucion.MinDate = DateTime.Today.AddDays(1);
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(15);
        }

        private void CargarUsuarios()
        {
            try
            {
                var usuarios = BibliotecaService.ObtenerUsuarios(); // ✅ Esto hace la llamada al servidor

                cbUsuarios.DataSource = usuarios;
                cbUsuarios.DisplayMember = "NombreCompleto"; // Asegúrate de tener esta propiedad en la clase Usuario
                cbUsuarios.ValueMember = "Identificacion";   // Si necesitás usarla internamente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLibrosDisponibles()
        {
            try
            {
                lvLibrosDisponibles.Items.Clear();

                var librosDisponibles = BibliotecaService.ObtenerLibros()
                 .Where(l => l.EjemplaresDisponibles > 0)
                 .OrderBy(l => l.Titulo)
                 .ToList();

                foreach (var libro in librosDisponibles)
                {
                    var item = new ListViewItem(libro.Titulo);
                    item.SubItems.Add(libro.AutorLibro.ObtenerNombreCompleto());
                    item.SubItems.Add(libro.ISBN);
                    item.SubItems.Add(libro.EjemplaresDisponibles.ToString());
                    item.Tag = libro;

                    lvLibrosDisponibles.Items.Add(item);
                }

                lblLibrosDisponibles.Text = $"Libros disponibles: {librosDisponibles.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar libros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lvLibrosDisponibles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para agregar al préstamo.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var libro = (Libro)lvLibrosDisponibles.SelectedItems[0].Tag;

            if (librosSeleccionados.Contains(libro))
            {
                MessageBox.Show("Este libro ya está seleccionado para préstamo.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            librosSeleccionados.Add(libro);
            ActualizarListaSeleccionados();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvLibrosSeleccionados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para quitar del préstamo.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var libro = (Libro)lvLibrosSeleccionados.SelectedItems[0].Tag;
            librosSeleccionados.Remove(libro);
            ActualizarListaSeleccionados();
        }

        private void ActualizarListaSeleccionados()
        {
            lvLibrosSeleccionados.Items.Clear();

            foreach (var libro in librosSeleccionados)
            {
                var item = new ListViewItem(libro.Titulo);
                item.SubItems.Add(libro.AutorLibro.ObtenerNombreCompleto());
                item.SubItems.Add(libro.ISBN);
                item.Tag = libro;

                lvLibrosSeleccionados.Items.Add(item);
            }

            lblLibrosSeleccionados.Text = $"Libros a prestar: {librosSeleccionados.Count}";
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            try
            {
                var usuario = (Usuario)cbUsuarios.SelectedItem;
                int diasPrestamo = (dtpFechaDevolucion.Value - DateTime.Today).Days;

                foreach (var libro in librosSeleccionados)
                {
                    var prestamo = new Prestamo
                    {
                        LibroPrestado = libro,
                        Usuario = usuario,
                        FechaPrestamo = DateTime.Today,
                        FechaDevolucion = dtpFechaDevolucion.Value,
                        Devuelto = false,
                        DiasPrestamo = (dtpFechaDevolucion.Value - DateTime.Today).Days,
                        CantidadLibrosPrestados = 1
                    };

                    BibliotecaService.RegistrarPrestamo(prestamo);
                }

                MessageBox.Show("Préstamo registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar préstamo: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (cbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUsuarios.Focus();
                return false;
            }

            if (librosSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un libro para prestar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpFechaDevolucion.Value <= DateTime.Today)
            {
                MessageBox.Show("La fecha de devolución debe ser futura.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDevolucion.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            librosSeleccionados.Clear();
            ActualizarListaSeleccionados();
            CargarLibrosDisponibles();
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(15);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsuarios.SelectedItem is Usuario usuario)
            {
                lblInfoUsuario.Text = $"Usuario: {usuario.Nombre} {usuario.Apellido}";

                if (usuario is Estudiante estudiante)
                {
                    lblInfoUsuario.Text += $"\nTipo: Estudiante - {estudiante.Carrera}";
                }
                else if (usuario is Profesor profesor)
                {
                    lblInfoUsuario.Text += $"\nTipo: Profesor - {profesor.Departamento}";
                }
            }
            else
            {
                lblInfoUsuario.Text = "Seleccione un usuario";
            }
        }

        private void gbFechas_Enter(object sender, EventArgs e)
        {

        }

        private void gbLibrosSeleccionados_Enter(object sender, EventArgs e)
        {

        }

        private void lvLibrosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
