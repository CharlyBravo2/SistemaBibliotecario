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
            btnFiltrar.Click += btnFiltrar_Click;
            this.cmbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFiltro_SelectedIndexChanged);
            ConfigurarDataGridView();
            CargarFiltros();
        }

       

        private void CargarFiltros()
        {
            
            cmbTipoFiltro.Items.AddRange(new string[] {
                "Todos",
                "Activos",
                "Vencidos",
                "Por Usuario",
                "Por Libro"
            });
            cmbTipoFiltro.SelectedIndex = 0;

            
            cmbUsuario.DataSource = BibliotecaService.ObtenerUsuarios()
                .OrderBy(u => u.Apellido)
                .ThenBy(u => u.Nombre)
                .ToList();
            cmbUsuario.DisplayMember = "NombreCompleto";
            cmbUsuario.ValueMember = "Identificacion";
            cmbUsuario.SelectedIndex = -1;

            
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

        private async void CargarPrestamos()
        {
            try
            {
                var prestamos = await Task.Run(() => BibliotecaService.ObtenerPrestamos());

                
                switch (cmbTipoFiltro.SelectedIndex)
                {
                    case 1: 
                        prestamos = prestamos.Where(p => !p.Devuelto).ToList();
                        break;
                    case 2: 
                        prestamos = prestamos.Where(p => p.EstaVencido() && !p.Devuelto).ToList();
                        break;
                    case 3: 
                        if (cmbUsuario.SelectedValue == null)
                        {
                            MessageBox.Show("Seleccione un usuario para filtrar.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        prestamos = prestamos.Where(p => p.Usuario.Identificacion == cmbUsuario.SelectedValue.ToString()).ToList();
                        break;
                    case 4: 
                        if (cmbLibro.SelectedValue == null)
                        {
                            MessageBox.Show("Seleccione un libro para filtrar.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        prestamos = prestamos.Where(p => p.LibroPrestado.ISBN == cmbLibro.SelectedValue.ToString()).ToList();
                        break;
                }

                
                if (dtpDesde.Checked && dtpHasta.Checked)
                {
                    prestamos = prestamos.Where(p =>
                        p.FechaPrestamo >= dtpDesde.Value &&
                        p.FechaPrestamo <= dtpHasta.Value).ToList();
                }
                else if (dtpDesde.Checked)
                {
                    prestamos = prestamos.Where(p => p.FechaPrestamo >= dtpDesde.Value).ToList();
                }
                else if (dtpHasta.Checked)
                {
                    prestamos = prestamos.Where(p => p.FechaPrestamo <= dtpHasta.Value).ToList();
                }

                dgvPrestamos.DataSource = prestamos.OrderByDescending(p => p.FechaPrestamo).ToList();
                lblTotal.Text = $"Total préstamos: {prestamos.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                
                sw.WriteLine("Título Libro,ISBN,Autor,Usuario,Identificación Usuario,Fecha Préstamo,Fecha Devolución,Días Préstamo,Estado,Cantidad");

                
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

        private void ConfigurarDataGridView()
        {
            dgvPrestamos.Columns.Clear(); 

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Titulo",
                HeaderText = "Título",
                DataPropertyName = "TituloLibro"
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ISBN",
                HeaderText = "ISBN",
                DataPropertyName = "ISBNLibro"
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Usuario",
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario"
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Identificacion",
                HeaderText = "Identificación",
                DataPropertyName = "IdentificacionUsuario"
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaPrestamo",
                HeaderText = "Fecha Préstamo",
                DataPropertyName = "FechaPrestamo",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaDevolucion",
                HeaderText = "Fecha Devolución",
                DataPropertyName = "FechaDevolucion",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado"
            });

            dgvPrestamos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "CantidadLibrosPrestados"
            });
        }
    }
}
