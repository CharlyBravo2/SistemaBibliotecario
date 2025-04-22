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
        private DataGridView dataGridViewLibros; // Add this declaration  

        public frmListarLibros()
        {
            InitializeComponent();
            InitializeCustomComponents(); // Initialize the DataGridView  
        }

        private void InitializeCustomComponents()
        {
            // Initialize the DataGridView  
            dataGridViewLibros = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true
            };

            // Add the DataGridView to the form's controls  
            Controls.Add(dataGridViewLibros);
        }

        private void frmListarLibros_Load(object sender, EventArgs e)
        {
            try
            {
                // Llama al backend por sockets y obtén la lista  
                var listaLibros = BibliotecaService.ObtenerLibros();
                dataGridViewLibros.DataSource = listaLibros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener libros: {ex.Message}",
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
