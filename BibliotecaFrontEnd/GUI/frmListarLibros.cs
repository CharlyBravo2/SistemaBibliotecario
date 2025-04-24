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
    public partial class frmListarLibros : Form
    {
        public frmListarLibros()
        {
            InitializeComponent();
        }

        private void frmListarLibros_Load(object sender, EventArgs e)
        {
            CargarLibros();
            ConfigurarColumnas();
        }

        private void CargarLibros()
        {
            try
            {
                lvLibros.Items.Clear();

                // 🔄 Obtener libros directamente del servidor
                var libros = BibliotecaService.ObtenerLibros()
                    .OrderBy(l => l.Titulo)
                    .ToList();

                foreach (var libro in libros)
                {
                    var item = new ListViewItem(libro.Titulo);
                    item.SubItems.Add(libro.AutorLibro.ObtenerNombreCompleto());
                    item.SubItems.Add(libro.ISBN);
                    item.SubItems.Add(libro.AñoPublicacion.ToString());
                    item.SubItems.Add($"{libro.EjemplaresDisponibles}/{libro.CantidadEjemplares}");

                    if (libro.EjemplaresDisponibles == 0)
                    {
                        item.ForeColor = System.Drawing.Color.Red;
                    }

                    item.Tag = libro;
                    lvLibros.Items.Add(item);
                }

                lblTotalLibros.Text = $"Total de libros: {libros.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            foreach (ColumnHeader col in lvLibros.Columns)
            {
                col.Width = -2; // Autoajustar al contenido
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (lvLibros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para ver sus detalles.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var libroSeleccionado = (Libro)lvLibros.SelectedItems[0].Tag;
            MostrarDetallesLibro(libroSeleccionado);
        }

        private void MostrarDetallesLibro(Libro libro)
        {
            var detalles = $"Título: {libro.Titulo}\n" +
                          $"ISBN: {libro.ISBN}\n" +
                          $"Año de publicación: {libro.AñoPublicacion}\n" +
                          $"Ejemplares: {libro.EjemplaresDisponibles}/{libro.CantidadEjemplares} disponibles\n\n" +
                          $"Autor: {libro.AutorLibro.ObtenerNombreCompleto()}\n" +
                          $"Nacionalidad: {libro.AutorLibro.Nacionalidad}\n" +
                          $"Año nacimiento: {libro.AutorLibro.AñoNacimiento}\n\n" +
                          $"Editorial: {libro.EditorialLibro.Nombre}\n" +
                          $"País: {libro.EditorialLibro.Pais}\n" +
                          $"Teléfono: {libro.EditorialLibro.Telefono}\n\n" +
                          $"Género: {libro.Genero.Nombre}\n" +
                          $"Tema: {libro.Genero.Tema}";

            MessageBox.Show(detalles, "Detalles del Libro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarLibros();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarLibros();
                e.Handled = true;
            }
        }

        private void BuscarLibros()
        {
            if (Program.Datos == null || Program.Datos.Libros == null)
            {
                MessageBox.Show("Error: Datos or Libros is not initialized.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                CargarLibros();
                return;
            }

            var termino = txtBusqueda.Text.ToLower();

            var librosFiltrados = Program.Datos.Libros
                .Where(l => l.Titulo.ToLower().Contains(termino) ||
                           l.ISBN.ToLower().Contains(termino) ||
                           l.AutorLibro.ObtenerNombreCompleto().ToLower().Contains(termino))
                .OrderBy(l => l.Titulo)
                .ToList();

            lvLibros.Items.Clear();

            foreach (var libro in librosFiltrados)
            {
                var item = new ListViewItem(libro.Titulo);
                item.SubItems.Add(libro.AutorLibro.ObtenerNombreCompleto());
                item.SubItems.Add(libro.ISBN);
                item.SubItems.Add(libro.AñoPublicacion.ToString());
                item.SubItems.Add($"{libro.EjemplaresDisponibles}/{libro.CantidadEjemplares}");

                if (libro.EjemplaresDisponibles == 0)
                {
                    item.ForeColor = System.Drawing.Color.Red;
                }

                item.Tag = libro;
                lvLibros.Items.Add(item);
            }

            lblTotalLibros.Text = $"Libros encontrados: {librosFiltrados.Count}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
