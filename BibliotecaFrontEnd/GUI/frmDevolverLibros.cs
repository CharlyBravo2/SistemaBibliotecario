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

namespace BibliotecaFrontEnd.GUI
{
    public partial class frmDevolverLibros : Form
    {
        public frmDevolverLibros()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Configurar el autocompletado para la búsqueda de libros
            txtBusquedaLibro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBusquedaLibro.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var librosSource = new AutoCompleteStringCollection();

            Program.Datos.Libros = new List<Libro>();
            librosSource.AddRange(Program.Datos.Libros.Select(l => l.Titulo).ToArray());

            if (Program.Datos?.Libros != null)
            {
                librosSource.AddRange(Program.Datos.Libros.Where(l => l != null).Select(l => l.Titulo).ToArray());

                Program.Datos.Libros = new List<Libro>();
                librosSource.AddRange(Program.Datos.Libros.Select(l => l.ISBN).ToArray());
                txtBusquedaLibro.AutoCompleteCustomSource = librosSource;

                // Configurar el autocompletado para la búsqueda de usuarios
                txtIdentificacionUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtIdentificacionUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
                var usuariosSource = new AutoCompleteStringCollection();
                usuariosSource.AddRange(Program.Datos.Usuarios.Select(u => u.Identificacion).ToArray());
                txtIdentificacionUsuario.AutoCompleteCustomSource = usuariosSource;
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBusquedaLibro.Text))
                {
                    MessageBox.Show("Ingrese el título o ISBN del libro a buscar.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBusquedaLibro.Focus();
                    return;
                }

                var libro = Program.Datos.Libros.FirstOrDefault(l =>
                    l.Titulo.Equals(txtBusquedaLibro.Text, StringComparison.OrdinalIgnoreCase) ||
                    l.ISBN.Equals(txtBusquedaLibro.Text, StringComparison.OrdinalIgnoreCase));

                if (libro == null)
                {
                    MessageBox.Show("Libro no encontrado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MostrarInformacionLibro(libro);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar libro: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarInformacionLibro(Libro libro)
        {
            txtTitulo.Text = libro.Titulo;
            txtISBN.Text = libro.ISBN;
            txtAutor.Text = libro.AutorLibro?.ObtenerNombreCompleto();
            txtEditorial.Text = libro.EditorialLibro?.Nombre;
            txtDisponibilidad.Text = libro.EstaDisponible() ? "Disponible" : "No disponible";
            txtEjemplares.Text = $"{libro.EjemplaresDisponibles}/{libro.CantidadEjemplares}";

            // Mostrar imagen según disponibilidad
            picEstado.Image = libro.EstaDisponible() ?
                Properties.Resources.disponible :
                Properties.Resources.no_disponible;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentificacionUsuario.Text))
                {
                    MessageBox.Show("Ingrese la identificación del usuario.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdentificacionUsuario.Focus();
                    return;
                }

                var usuario = Program.Datos.Usuarios.FirstOrDefault(u =>
                    u.Identificacion.Equals(txtIdentificacionUsuario.Text, StringComparison.OrdinalIgnoreCase));

                if (usuario == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MostrarInformacionUsuario(usuario);
                CargarPrestamosUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarInformacionUsuario(Usuario usuario)
        {
            txtNombreUsuario.Text = $"{usuario.Nombre} {usuario.Apellido}";
            txtCorreoUsuario.Text = usuario.Correo;
            txtTelefonoUsuario.Text = usuario.Telefono;
            txtEstadoUsuario.Text = usuario.EsActivo ? "Activo" : "Inactivo";
        }

        private void CargarPrestamosUsuario(Usuario usuario)
        {
            dgvPrestamos.Rows.Clear();

            var prestamosActivos = usuario.Prestamos
                .Where(p => !p.Devuelto)
                .OrderBy(p => p.FechaDevolucion);

            foreach (var prestamo in prestamosActivos)
            {
                dgvPrestamos.Rows.Add(
                    prestamo.LibroPrestado?.Titulo,
                    prestamo.LibroPrestado?.ISBN,
                    prestamo.FechaPrestamo.ToShortDateString(),
                    prestamo.FechaDevolucion.ToShortDateString(),
                    prestamo.EstaVencido() ? "Vencido" : "Activo",
                    prestamo.CantidadLibrosPrestados
                );
            }

            lblTotalPrestamos.Text = $"Total préstamos activos: {prestamosActivos.Count()}";
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBusquedaLibro.Text))
                {
                    MessageBox.Show("Debe buscar un libro primero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBusquedaLibro.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdentificacionUsuario.Text))
                {
                    MessageBox.Show("Debe buscar un usuario primero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdentificacionUsuario.Focus();
                    return;
                }

                var libro = Program.Datos.Libros.FirstOrDefault(l =>
                    l.Titulo.Equals(txtBusquedaLibro.Text, StringComparison.OrdinalIgnoreCase) ||
                    l.ISBN.Equals(txtBusquedaLibro.Text, StringComparison.OrdinalIgnoreCase));

                var usuario = Program.Datos.Usuarios.FirstOrDefault(u =>
                    u.Identificacion.Equals(txtIdentificacionUsuario.Text, StringComparison.OrdinalIgnoreCase));

                if (libro == null || usuario == null)
                {
                    MessageBox.Show("Libro o usuario no encontrado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si el usuario tiene este libro prestado
                var prestamo = usuario.Prestamos.FirstOrDefault(p =>
                    p.LibroPrestado == libro && !p.Devuelto);

                if (prestamo == null)
                {
                    MessageBox.Show("Este usuario no tiene prestado este libro.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar la devolución
                var confirmacion = MessageBox.Show(
                    $"¿Confirmar devolución del libro '{libro.Titulo}' por {usuario.Nombre} {usuario.Apellido}?",
                    "Confirmar Devolución",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    usuario.DevolverLibro(libro);
                    Program.GuardarDatos();

                    MessageBox.Show("Libro devuelto correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar la información mostrada
                    MostrarInformacionLibro(libro);
                    CargarPrestamosUsuario(usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al devolver libro: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                string isbn = dgvPrestamos.SelectedRows[0].Cells["ISBN"].Value.ToString();
                var libro = Program.Datos.Libros.FirstOrDefault(l => l.ISBN == isbn);

                if (libro != null)
                {
                    txtBusquedaLibro.Text = libro.Titulo;
                    MostrarInformacionLibro(libro);
                }
            }
        }

        private void gbUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
