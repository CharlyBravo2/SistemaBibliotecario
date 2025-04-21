using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBackEnd.Objetos
{
    public class DatosBiblioteca
    {
        public List<Libro> Libros { get; set; } = new List<Libro>();
        public List<Autor> Autores { get; set; } = new List<Autor>();
        public List<Editorial> Editoriales { get; set; } = new List<Editorial>();
        public List<GeneroLiterario> Generos { get; set; } = new List<GeneroLiterario>();
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    }
}
