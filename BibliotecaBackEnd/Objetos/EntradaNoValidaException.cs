using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBackEnd.Objetos
{
    public class EntradaNoValidaException : Exception
    {
        public EntradaNoValidaException(string mensaje) : base(mensaje) { }
    }
    public interface IMostrarInformacion
    {
        void MostrarInformacion();
    }

    public interface IPrestable
    {
        void PrestarLibros(List<Libro> libros);
        void DevolverLibro(Libro libro);
    }

    public interface IValidable
    {
        bool Validar();
    }
}
