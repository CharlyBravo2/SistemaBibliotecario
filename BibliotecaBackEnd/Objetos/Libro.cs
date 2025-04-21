using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public class Libro : IMostrarInformacion, IValidable
    {
        public string Titulo { get; set; }
        public Autor AutorLibro { get; set; }
        public Editorial EditorialLibro { get; set; }
        public GeneroLiterario Genero { get; set; }
        public string ISBN { get; set; }
        public int AñoPublicacion { get; set; }
        public int CantidadEjemplares { get; set; }
        public int EjemplaresDisponibles { get; set; }

        [JsonIgnore]
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        [JsonConstructor]
        public Libro() { }

        public Libro(string titulo, Autor autorLibro, Editorial editorialLibro, GeneroLiterario genero, string isbn, int añoPublicacion, int cantidadEjemplares)
        {
            Titulo = titulo;
            AutorLibro = autorLibro;
            EditorialLibro = editorialLibro;
            Genero = genero;
            ISBN = isbn;
            AñoPublicacion = añoPublicacion;
            CantidadEjemplares = cantidadEjemplares;
            EjemplaresDisponibles = cantidadEjemplares;
        }

        public void MostrarInformacion()
        {
            WriteLine($"Título: {Titulo}");
            AutorLibro?.MostrarInformacion();
            EditorialLibro?.MostrarInformacion();
            Genero?.MostrarInformacion();
            WriteLine($"ISBN: {ISBN}, Año de Publicación: {AñoPublicacion}");
            WriteLine($"Ejemplares: {EjemplaresDisponibles}/{CantidadEjemplares} disponibles");

            if (Prestamos.Count > 0)
            {
                WriteLine("Préstamos activos:");
                foreach (var prestamo in Prestamos.Where(p => !p.Devuelto))
                {
                    prestamo.MostrarInformacion();
                }
            }
        }

        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Titulo) &&
                   !string.IsNullOrWhiteSpace(ISBN) &&
                   AñoPublicacion > 0 &&
                   AutorLibro != null &&
                   EditorialLibro != null &&
                   Genero != null &&
                   CantidadEjemplares > 0;
        }

        public bool EstaDisponible()
        {
            return EjemplaresDisponibles > 0;
        }

        public void ActualizarEjemplares(int nuevaCantidad)
        {
            if (nuevaCantidad < CantidadEjemplares - EjemplaresDisponibles)
            {
                throw new EntradaNoValidaException("No se puede reducir la cantidad porque hay libros prestados.");
            }

            EjemplaresDisponibles += (nuevaCantidad - CantidadEjemplares);
            CantidadEjemplares = nuevaCantidad;
            WriteLine($"Cantidad de ejemplares actualizada a: {CantidadEjemplares}");
        }
        public void PrestarEjemplar(Usuario usuario, int diasPrestamo)
        {
            if (EjemplaresDisponibles < 1)
            {
                throw new EntradaNoValidaException($"No hay ejemplares disponibles. Solo quedan {EjemplaresDisponibles}.");
            }

            var prestamo = new Prestamo(this, usuario, DateTime.Now, diasPrestamo, 1);
            Prestamos.Add(prestamo);
            EjemplaresDisponibles -= 1;
            usuario.Prestamos.Add(prestamo);
            Program.AgregarPrestamoGlobal(prestamo);
        }

        public void PrestarEjemplares(int cantidad, Usuario usuario, int diasPrestamo)
        {
            for (int i = 0; i < cantidad; i++)
            {
                PrestarEjemplar(usuario, diasPrestamo);
            }
        }

        public void RegistrarDevolucion(Prestamo prestamo)
        {
            prestamo.Devuelto = true;
            EjemplaresDisponibles += prestamo.CantidadLibrosPrestados;
        }
    }
}
