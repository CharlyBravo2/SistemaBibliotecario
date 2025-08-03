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
    public partial class frmDevolverLibros : Form
    {
        private Usuario usuarioActual; 
        public frmDevolverLibros()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            try
            {
                var libros = BibliotecaService.ObtenerLibros();
                var usuarios = BibliotecaService.ObtenerUsuarios();

                var librosSource = new AutoCompleteStringCollection();
                librosSource.AddRange(libros.Select(l => l.Titulo).ToArray());
                librosSource.AddRange(libros.Select(l => l.ISBN).ToArray());
                txtBusquedaLibro.AutoCompleteCustomSource = librosSource;

                var usuariosSource = new AutoCompleteStringCollection();
                usuariosSource.AddRange(usuarios.Select(u => u.Identificacion).ToArray());
                txtIdentificacionUsuario.AutoCompleteCustomSource = usuariosSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos para autocompletado: {ex.Message}");
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

                var usuarios = BibliotecaService.ObtenerUsuarios();
                var usuario = usuarios.FirstOrDefault(u =>
                                    u.Identificacion.Equals(txtIdentificacionUsuario.Text, StringComparison.OrdinalIgnoreCase));
                
                if (usuario == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                usuarioActual = usuario; 
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

            var todosPrestamos = BibliotecaService.ObtenerPrestamos(); // ✅ Llama al servidor
            var prestamosActivos = todosPrestamos
                .Where(p => !p.Devuelto && p.Usuario.Identificacion == usuario.Identificacion)
                .OrderBy(p => p.FechaDevolucion);

            foreach (var prestamo in prestamosActivos)
            {
                int rowIndex = dgvPrestamos.Rows.Add(
                prestamo.LibroPrestado?.Titulo,
                prestamo.LibroPrestado?.ISBN,
                prestamo.FechaPrestamo.ToShortDateString(),
                prestamo.FechaDevolucion.ToShortDateString(),
                prestamo.EstaVencido() ? "Vencido" : "Activo",
                prestamo.CantidadLibrosPrestados
            );

                dgvPrestamos.Rows[rowIndex].Tag = prestamo; 
            }

            lblTotalPrestamos.Text = $"Total préstamos activos: {prestamosActivos.Count()}";
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un préstamo para devolver.");
                return;
            }

            var prestamo = (Prestamo)dgvPrestamos.SelectedRows[0].Tag;

            try
            {
                BibliotecaService.DevolverPrestamo(prestamo);
                MessageBox.Show("Libro devuelto correctamente.");
                CargarPrestamosUsuario(usuarioActual); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al devolver libro: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                string isbn = dgvPrestamos.SelectedRows[0].Cells["ISBN"].Value.ToString();

                try
                {
                    var libros = await Task.Run(() => BibliotecaService.ObtenerLibros());
                    var libro = libros.FirstOrDefault(l => l.ISBN == isbn);

                    if (libro != null)
                    {
                        txtBusquedaLibro.Text = libro.Titulo;
                        MostrarInformacionLibro(libro);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener libro desde servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gbUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void frmDevolverLibros_Load(object sender, EventArgs e)
        {

        }
    }
}
