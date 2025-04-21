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
using static BibliotecaBackEnd.Objetos.JsonDataManager;
using System.IO;
using Newtonsoft.Json;
namespace BibliotecaFrontEnd.GUI
{
    public partial class frmGestionBackup : Form
    {
        private const string EXTENSION_ARCHIVO = ".json";
        private const string FILTRO_ARCHIVOS = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*";

        public frmGestionBackup()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Configurar el TextBox para mostrar la ruta actual
            txtRutaActual.Text = Program.ARCHIVO_DATOS;
            txtRutaActual.ReadOnly = true;

            // Configurar el formato de fecha para los backups
            dtpFechaBackup.Format = DateTimePickerFormat.Custom;
            dtpFechaBackup.CustomFormat = "yyyyMMdd_HHmmss";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = FILTRO_ARCHIVOS;
                    sfd.Title = "Exportar copia de seguridad";
                    sfd.FileName = $"backup_biblioteca_{DateTime.Now:yyyyMMdd_HHmmss}{EXTENSION_ARCHIVO}";
                    sfd.DefaultExt = EXTENSION_ARCHIVO;
                    sfd.AddExtension = true;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        JsonDataManager.GuardarDatos(sfd.FileName, Program.Datos);
                        MessageBox.Show("Copia de seguridad exportada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar copia de seguridad: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = FILTRO_ARCHIVOS;
                    ofd.Title = "Importar copia de seguridad";
                    ofd.CheckFileExists = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        // Confirmar con el usuario antes de sobrescribir datos
                        var confirmacion = MessageBox.Show(
                            "¿Está seguro que desea importar esta copia de seguridad? Todos los datos actuales serán reemplazados.",
                            "Confirmar Importación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (confirmacion == DialogResult.Yes)
                        {
                            var datosImportados = JsonDataManager.CargarDatos<DatosBiblioteca>(ofd.FileName);

                            if (datosImportados != null)
                            {
                                Program.Datos = datosImportados;
                                Program.GuardarDatos();
                                MessageBox.Show("Copia de seguridad importada correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron cargar los datos del archivo seleccionado.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al importar copia de seguridad: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurarSistema_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirmar con el usuario antes de restaurar el sistema
                var confirmacion = MessageBox.Show(
                    "¿Está seguro que desea restaurar el sistema a los valores predeterminados? Todos los datos actuales se perderán.",
                    "Confirmar Restauración",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    Program.Datos = new DatosBiblioteca();
                    Program.GuardarDatos();
                    MessageBox.Show("Sistema restaurado a valores predeterminados.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restaurar sistema: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbAcciones_Enter(object sender, EventArgs e)
        {

        }

        private void frmGestionBackup_Load(object sender, EventArgs e)
        {

        }
    }
}
