using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public class Estudiante : Usuario
    {
        public string Carrera { get; set; }
        public int Semestre { get; set; }
        public double PromedioCalificaciones { get; set; }
        public int Edad { get; set; }
        public string EstadoCivil { get; set; }
        public string TipoBeca { get; set; }
        public bool EsRegular { get; set; }

        [JsonConstructor]
        public Estudiante() { }

        public Estudiante(string nombre, string apellido, string identificacion, string correo, string telefono, string carrera, int semestre = 1, double promedioCalificaciones = 0.0, int edad = 0, string estadoCivil = "", string tipoBeca = "Ninguna", bool esRegular = true)
            : base(nombre, apellido, identificacion, correo, telefono)
        {
            Carrera = carrera;
            Semestre = semestre;
            PromedioCalificaciones = promedioCalificaciones;
            Edad = edad;
            EstadoCivil = estadoCivil;
            TipoBeca = tipoBeca;
            EsRegular = esRegular;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            WriteLine($"Carrera: {Carrera}, Semestre: {Semestre}, Promedio: {PromedioCalificaciones}");
            WriteLine($"Edad: {Edad}, Estado Civil: {EstadoCivil}");
            WriteLine($"Tipo de Beca: {TipoBeca}, Regular: {(EsRegular ? "Sí" : "No")}");
        }

        public void ActualizarSemestre(int nuevoSemestre)
        {
            Semestre = nuevoSemestre;
            WriteLine($"Semestre actualizado a: {Semestre}");
        }

        public void ActualizarPromedio(double nuevoPromedio)
        {
            PromedioCalificaciones = nuevoPromedio;
            WriteLine($"Promedio actualizado a: {PromedioCalificaciones}");
        }

        public bool EsBecado()
        {
            return PromedioCalificaciones >= 90;
        }

        public void ActualizarBeca(string nuevaBeca)
        {
            TipoBeca = nuevaBeca;
            WriteLine($"Tipo de beca actualizado a: {TipoBeca}");
        }
    }
}
