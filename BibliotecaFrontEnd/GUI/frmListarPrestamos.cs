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
    public partial class frmListarPrestamos : Form
    {
        public frmListarPrestamos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarFiltros();
        }

        private void ConfigurarDataGridView()
        {
            dgvPrestamos.AutoGenerateColumns = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
        }

        private void CargarFiltros()
        {
            // Cargar tipos de filtro
            cmbTipoFiltro.Items.AddRange(new string[] {
                "Todos",
                "Activos",
                "Vencidos",
                "Por Usuario",
                "Por Libro"
            });
            cmbTipoFiltro.SelectedIndex = 0;

            // Cargar usuarios para el filtro
            cmbUsuario.DataSource = BibliotecaService.ObtenerUsuarios()
                .OrderBy(u => u.Apellido)
                .ThenBy(u => u.Nombre)
                .ToList();
            cmbUsuario.DisplayMember = "NombreCompleto";
            cmbUsuario.ValueMember = "Identificacion";
            cmbUsuario.SelectedIndex = -1;

            // Cargar libros para el filtro
            cmbLibro.DataSource = BibliotecaService.ObtenerLibros()
                .OrderBy(l => l.Titulo)
                .ToList();
            cmbLibro.DisplayMember = "Titulo";
            cmbLibro.ValueMember = "ISBN";
            cmbLibro.SelectedIndex = -1;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPrestamos()
        {
            IEnumerable<Prestamo> prestamos = BibliotecaService.ObtenerPrestamos();

            switch (cmbTipoFiltro.SelectedIndex)
            {
                case 0: // Todos
                    break;
                case 1: // Activos
                    prestamos = prestamos.Where(p => !p.Devuelto);
                    break;
                case 2: // Vencidos
                    prestamos = prestamos.Where(p => p.EstaVencido() && !p.Devuelto);
                    break;
                case 3: // Por Usuario
                    if (cmbUsuario.SelectedValue == null)
                    {
                        MessageBox.Show("Seleccione un usuario para filtrar.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    prestamos = prestamos.Where(p =>
                        p.Usuario.Identificacion == cmbUsuario.SelectedValue.ToString());
                    break;
                case 4: // Por Libro
                    if (cmbLibro.SelectedValue == null)
                    {
                        MessageBox.Show("Seleccione un libro para filtrar.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    prestamos = prestamos.Where(p =>
                        p.LibroPrestado.ISBN == cmbLibro.SelectedValue.ToString());
                    break;
            }

            // Aplicar filtro de fechas si están seleccionadas
            if (dtpDesde.Checked && dtpHasta.Checked)
            {
                prestamos = prestamos.Where(p =>
                    p.FechaPrestamo >= dtpDesde.Value &&
                    p.FechaPrestamo <= dtpHasta.Value);
            }
            else if (dtpDesde.Checked)
            {
                prestamos = prestamos.Where(p => p.FechaPrestamo >= dtpDesde.Value);
            }
            else if (dtpHasta.Checked)
            {
                prestamos = prestamos.Where(p => p.FechaPrestamo <= dtpHasta.Value);
            }

            // Ordenar por fecha de préstamo descendente
            prestamos = prestamos.OrderByDescending(p => p.FechaPrestamo);

            dgvPrestamos.DataSource = prestamos.ToList();
            lblTotal.Text = $"Total préstamos: {prestamos.Count()}";
        }

        private void cmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar/ocultar controles según el tipo de filtro seleccionado
            pnlUsuario.Visible = cmbTipoFiltro.SelectedIndex == 3;
            pnlLibro.Visible = cmbTipoFiltro.SelectedIndex == 4;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo CSV|*.csv";
                    sfd.Title = "Exportar préstamos a CSV";
                    sfd.FileName = $"Prestamos_{DateTime.Now:yyyyMMdd}.csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportarACSV(sfd.FileName);
                        MessageBox.Show("Datos exportados correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarACSV(string filePath)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath))
            {
                // Escribir encabezados
                sw.WriteLine("Título Libro,ISBN,Autor,Usuario,Identificación Usuario,Fecha Préstamo,Fecha Devolución,Días Préstamo,Estado,Cantidad");

                // Escribir datos
                foreach (DataGridViewRow row in dgvPrestamos.Rows)
                {
                    if (row.DataBoundItem is Prestamo prestamo)
                    {
                        sw.WriteLine($"\"{prestamo.LibroPrestado.Titulo}\"," +
                            $"\"{prestamo.LibroPrestado.ISBN}\"," +
                            $"\"{prestamo.LibroPrestado.AutorLibro.ObtenerNombreCompleto()}\"," +
                            $"\"{prestamo.Usuario.Nombre} {prestamo.Usuario.Apellido}\"," +
                            $"\"{prestamo.Usuario.Identificacion}\"," +
                            $"\"{prestamo.FechaPrestamo:yyyy-MM-dd}\"," +
                            $"\"{prestamo.FechaDevolucion:yyyy-MM-dd}\"," +
                            $"\"{prestamo.DiasPrestamo}\"," +
                            $"\"{(prestamo.Devuelto ? "Devuelto" : prestamo.EstaVencido() ? "Vencido" : "Activo")}\"," +
                            $"\"{prestamo.CantidadLibrosPrestados}\"");
                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de impresión no implementada.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbFiltros_Enter(object sender, EventArgs e)
        {

        }
    }
}
