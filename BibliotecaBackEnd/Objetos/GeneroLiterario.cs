using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public class GeneroLiterario : IMostrarInformacion, IValidable
    {
        public string Nombre { get; set; }
        public string Tema { get; set; }
        public string Subgenero { get; set; }
        public string EsPopular { get; set; }
        public int AñoOrigen { get; set; }
        public string Descripcion { get; set; }
        public List<string> AutoresRepresentativos { get; set; } = new List<string>();

        [JsonConstructor]
        public GeneroLiterario() { }

        public GeneroLiterario(string nombre, string tema, string subgenero = "", string esPopular = "", int añoOrigen = 0, string descripcion = "")
        {
            Nombre = nombre;
            Tema = tema;
            Subgenero = subgenero;
            EsPopular = esPopular;
            AñoOrigen = añoOrigen;
            Descripcion = descripcion;
        }

        public void MostrarInformacion()
        {
            WriteLine($"Género Literario: {Nombre}, Tema: {Tema}");
            if (!string.IsNullOrEmpty(Subgenero))
                WriteLine($"Subgénero: {Subgenero}");
            if (!string.IsNullOrEmpty(EsPopular))
                WriteLine($"Popularidad: {EsPopular}");
            if (AñoOrigen > 0)
                WriteLine($"Año de Origen: {AñoOrigen}");
            if (!string.IsNullOrEmpty(Descripcion))
                WriteLine($"Descripción: {Descripcion}");

            if (AutoresRepresentativos.Count > 0)
            {
                WriteLine("Autores Representativos:");
                foreach (var autor in AutoresRepresentativos)
                {
                    WriteLine($"- {autor}");
                }
            }
        }

        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Tema);
        }

        public void AgregarAutorRepresentativo(string autor)
        {
            AutoresRepresentativos.Add(autor);
            WriteLine($"Autor representativo '{autor}' agregado.");
        }

        public bool EsGeneroAntiguo()
        {
            return (DateTime.Now.Year - AñoOrigen) > 100;
        }

        public void ActualizarPopularidad(string nuevaPopularidad)
        {
            EsPopular = nuevaPopularidad;
            WriteLine($"Popularidad actualizada a: {EsPopular}");
        }
    }
}
