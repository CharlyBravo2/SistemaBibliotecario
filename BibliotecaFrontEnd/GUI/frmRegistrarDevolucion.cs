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
    public partial class frmRegistrarDevolucion : Form
    {
        private BindingSource bs = new BindingSource();

        public frmRegistrarDevolucion()
        {
            InitializeComponent();
            this.btnCancelar.Click += (s, e) => this.Close();
            CargarPrestamos();
        }

        private void CargarPrestamos()
        {
            try
            {
                var prestamos = BibliotecaService.ObtenerPrestamos()
                                   .Where(p => !p.Devuelto).ToList();
                bs.DataSource = prestamos;
                dgvPrestamos.DataSource = bs;
                dgvPrestamos.Columns["LibroPrestado"].HeaderText = "Título";
                dgvPrestamos.Columns["Usuario"].HeaderText = "Usuario";
                dgvPrestamos.Columns["FechaPrestamo"].HeaderText = "Fecha";
                dgvPrestamos.Columns["FechaDevolucion"].HeaderText = "Vencimiento";
                // Oculta propiedades innecesarias
                foreach (var c in new[] { "DiasPrestamo", "CantidadLibrosPrestados", "Prestamos", "Devuelto" })
                    dgvPrestamos.Columns[c].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener préstamos: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Seleccione un préstamo.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var prestamo = (Prestamo)bs.Current;
            try
            {
                // Lógica local para marcar como devuelto
                prestamo.LibroPrestado.RegistrarDevolucion(prestamo);
                prestamo.Devuelto = true;
                // Enviar actualización al backend
                BibliotecaService.RegistrarPrestamo(prestamo); // reenvía con campo Devuelto=true
                MessageBox.Show("Devolución registrada.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al devolver: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
