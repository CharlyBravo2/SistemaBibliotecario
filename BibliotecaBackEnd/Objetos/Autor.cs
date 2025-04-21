using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public class Autor : IMostrarInformacion, IValidable
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public int AñoNacimiento { get; set; }
        public int CantidadLibrosPublicados { get; set; }
        public string Pseudonimo { get; set; }
        public bool EsBestSeller { get; set; }

        [JsonConstructor]
        public Autor() { }

        public Autor(string nombre, string apellido, string nacionalidad, int añoNacimiento, int cantidadLibrosPublicados, string pseudonimo = "", bool esBestSeller = false)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
            AñoNacimiento = añoNacimiento;
            CantidadLibrosPublicados = cantidadLibrosPublicados;
            Pseudonimo = pseudonimo;
            EsBestSeller = esBestSeller;
        }

        public void MostrarInformacion()
        {
            WriteLine($"Autor: {Nombre} {Apellido}, Nacionalidad: {Nacionalidad}, Año de Nacimiento: {AñoNacimiento}, Libros Publicados: {CantidadLibrosPublicados}");
            if (!string.IsNullOrEmpty(Pseudonimo))
                WriteLine($"Pseudónimo: {Pseudonimo}");
            if (EsBestSeller)
                WriteLine("Es autor best-seller");
        }

        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Apellido) &&
                   !string.IsNullOrWhiteSpace(Nacionalidad) &&
                   AñoNacimiento > 0 &&
                   CantidadLibrosPublicados >= 0;
        }

        public string ObtenerNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public bool EsAutorJoven()
        {
            return (DateTime.Now.Year - AñoNacimiento) < 40;
        }

        public void ActualizarPseudonimo(string nuevoPseudonimo)
        {
            Pseudonimo = nuevoPseudonimo;
            WriteLine($"Pseudónimo actualizado a: {Pseudonimo}");
        }
    }
}
