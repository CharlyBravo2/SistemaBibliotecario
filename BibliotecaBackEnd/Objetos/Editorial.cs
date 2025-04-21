using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public class Editorial : IMostrarInformacion, IValidable
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int AñoFundacion { get; set; }
        public string SitioWeb { get; set; }

        [JsonConstructor]
        public Editorial() { }

        public Editorial(string nombre, string pais, string direccion, string telefono, string correoElectronico, int añoFundacion, string sitioWeb)
        {
            Nombre = nombre;
            Pais = pais;
            Direccion = direccion;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            AñoFundacion = añoFundacion;
            SitioWeb = sitioWeb;
        }

        public void MostrarInformacion()
        {
            WriteLine($"Editorial: {Nombre}, País: {Pais}, Dirección: {Direccion}");
            WriteLine($"Teléfono: {Telefono}, Correo Electrónico: {CorreoElectronico}");
            WriteLine($"Año de Fundación: {AñoFundacion}, Sitio Web: {SitioWeb}");
        }

        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
            !string.IsNullOrWhiteSpace(Pais) &&
            !string.IsNullOrWhiteSpace(Direccion) &&
            Validaciones.ValidarTelefono(Telefono) &&
            AñoFundacion > 0 &&
            !string.IsNullOrWhiteSpace(SitioWeb);
        }

        public int ObtenerAntiguedad()
        {
            return DateTime.Now.Year - AñoFundacion;
        }

        public void ActualizarSitioWeb(string nuevoSitioWeb)
        {
            SitioWeb = nuevoSitioWeb;
            WriteLine($"Sitio web actualizado a: {SitioWeb}");
        }
    }
}
