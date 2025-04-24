using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public class Usuario : IMostrarInformacion, IPrestable, IValidable
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool EsActivo { get; set; }

        [JsonIgnore]
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        [JsonConstructor]
        public Usuario() { }

        public Usuario(string nombre, string apellido, string identificacion, string correo, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Correo = correo;
            Telefono = telefono;
            FechaRegistro = DateTime.Now;
            EsActivo = true;
        }

        public virtual void MostrarInformacion()
        {
            WriteLine($"Nombre: {Nombre} {Apellido}, Identificación: {Identificacion}");
            WriteLine($"Correo: {Correo}, Teléfono: {Telefono}");
            WriteLine($"Fecha de Registro: {FechaRegistro.ToShortDateString()}, Estado: {(EsActivo ? "Activo" : "Inactivo")}");

            if (Prestamos.Count > 0)
            {
                WriteLine("Préstamos activos:");
                foreach (var prestamo in Prestamos.Where(p => !p.Devuelto))
                {
                    prestamo.MostrarInformacion();
                }
            }
        }

        public void PrestarLibros(List<Libro> libros)
        {
            if (!EsActivo)
                throw new EntradaNoValidaException("El usuario está inactivo y no puede prestar libros.");

            foreach (var libro in libros)
            {
                libro.PrestarEjemplar(this, 15); 
            }
        }

        public void DevolverLibro(Libro libro)
        {
            var prestamo = Prestamos.FirstOrDefault(p => p.LibroPrestado == libro && !p.Devuelto);

            if (prestamo != null)
            {
                libro.RegistrarDevolucion(prestamo);
                WriteLine($"Libro '{libro.Titulo}' devuelto por {Nombre} {Apellido}.");

                if (prestamo.EstaVencido())
                {
                    WriteLine("¡ATENCIÓN! Este préstamo está vencido.");
                }
            }
            else
            {
                throw new EntradaNoValidaException($"El libro '{libro.Titulo}' no fue prestado a {Nombre} {Apellido} o ya fue devuelto.");
            }
        }

        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Apellido) &&
                   !string.IsNullOrWhiteSpace(Identificacion) &&
                   Validaciones.ValidarTelefono(Telefono);
        }

        public void CambiarEstado(bool nuevoEstado)
        {
            EsActivo = nuevoEstado;
            WriteLine($"Estado cambiado a: {(EsActivo ? "Activo" : "Inactivo")}");
        }

        public int CantidadLibrosPrestados()
        {
            return Prestamos.Where(p => !p.Devuelto).Sum(p => p.CantidadLibrosPrestados);
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
