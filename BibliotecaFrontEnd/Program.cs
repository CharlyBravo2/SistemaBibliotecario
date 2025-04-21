using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaBackEnd.Objetos;
using BibliotecaFrontEnd.GUI;
using Newtonsoft.Json;
namespace BibliotecaFrontEnd
{
    static class Program
    {
        public static DatosBiblioteca Datos { get; set; }
        public const string ARCHIVO_DATOS = "datos_biblioteca.json";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI.frmPrincipal());

            // Cargar datos al iniciar
            CargarDatos();

            Application.Run(new frmPrincipal());
        }
        private static void CargarDatos()
        {
            try
            {
                Datos = JsonDataManager.CargarDatos<DatosBiblioteca>(ARCHIVO_DATOS) ?? new DatosBiblioteca();

                // Inicializar listas si son null
                Datos.Libros = Datos.Libros ?? new List<Libro>();
                Datos.Autores = Datos.Autores ?? new List<Autor>();
                Datos.Editoriales = Datos.Editoriales ?? new List<Editorial>();
                Datos.Generos = Datos.Generos ?? new List<GeneroLiterario>();
                Datos.Usuarios = Datos.Usuarios ?? new List<Usuario>();
                Datos.Prestamos = Datos.Prestamos ?? new List<Prestamo>();

                ReconstruirRelaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Datos = new DatosBiblioteca();
            }
        }

        private static void ReconstruirRelaciones()
        {
            foreach (var prestamo in Datos.Prestamos)
            {
                if (prestamo.LibroPrestado != null)
                {
                    var libro = Datos.Libros.FirstOrDefault(l => l.ISBN == prestamo.LibroPrestado.ISBN);
                    if (libro != null)
                    {
                        prestamo.LibroPrestado = libro;
                        libro.Prestamos.Add(prestamo);
                    }
                }

                if (prestamo.Usuario != null)
                {
                    var usuario = Datos.Usuarios.FirstOrDefault(u => u.Identificacion == prestamo.Usuario.Identificacion);
                    if (usuario != null)
                    {
                        prestamo.Usuario = usuario;
                        usuario.Prestamos.Add(prestamo);
                    }
                }
            }
        }

        public static void GuardarDatos()
        {
            try
            {
                JsonDataManager.GuardarDatos(ARCHIVO_DATOS, Datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AgregarPrestamoGlobal(Prestamo prestamo)
        {
            Datos.Prestamos.Add(prestamo);
            GuardarDatos();
        }
    }
}
