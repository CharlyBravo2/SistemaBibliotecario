using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public class Prestamo : IMostrarInformacion
    {
        public Libro LibroPrestado { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }
        public int DiasPrestamo { get; set; }
        public int CantidadLibrosPrestados { get; set; }

        [JsonConstructor]
        public Prestamo() { }

        public Prestamo(Libro libro, Usuario usuario, DateTime fechaPrestamo, int diasPrestamo, int cantidadLibros)
        {
            LibroPrestado = libro;
            Usuario = usuario;
            FechaPrestamo = fechaPrestamo;
            DiasPrestamo = diasPrestamo;
            FechaDevolucion = fechaPrestamo.AddDays(diasPrestamo);
            Devuelto = false;
            CantidadLibrosPrestados = cantidadLibros;
        }

        public void MostrarInformacion()
        {
            WriteLine($" Libro: {LibroPrestado?.Titulo} (ISBN: {LibroPrestado?.ISBN})");
            WriteLine($" Usuario: {Usuario?.Nombre} {Usuario?.Apellido} (ID: {Usuario?.Identificacion})");
            WriteLine($" Fecha préstamo: {FechaPrestamo.ToShortDateString()}");
            WriteLine($" Fecha devolución: {FechaDevolucion.ToShortDateString()}");
            WriteLine($" Días préstamo: {DiasPrestamo}");
            WriteLine($" Cantidad prestada: {CantidadLibrosPrestados}");
            WriteLine($" Estado: {ObtenerEstadoDetallado()}");
            WriteLine("────────────────────────────────");
        }

        public bool EstaVencido()
        {
            return DateTime.Now > FechaDevolucion && !Devuelto;
        }

        public string ObtenerEstadoDetallado()
        {
            if (Devuelto)
            {
                return "Devuelto";
            }
            else if (EstaVencido())
            {
                int diasVencido = (DateTime.Now - FechaDevolucion).Days;
                return $"Vencido hace {diasVencido} días";
            }
            else
            {
                int diasRestantes = (FechaDevolucion - DateTime.Now).Days;
                return $"Activo ({diasRestantes} días restantes)";
            }
        }
    }
}
