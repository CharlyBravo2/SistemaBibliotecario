using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public class Profesor : Usuario
    {
        public string Departamento { get; set; }
        public int AñosExperiencia { get; set; }
        public string EsTitular { get; set; }
        public int Edad { get; set; }
        public string EstadoCivil { get; set; }
        public string GradoAcademico { get; set; }
        public List<string> CursosImpartidos { get; set; } = new List<string>();

        [JsonConstructor]
        public Profesor() { }

        public Profesor(string nombre, string apellido, string identificacion, string correo, string telefono, string departamento, int añosExperiencia = 0, string esTitular = "", int edad = 0, string estadoCivil = "", string gradoAcademico = "")
            : base(nombre, apellido, identificacion, correo, telefono)
        {
            Departamento = departamento;
            AñosExperiencia = añosExperiencia;
            EsTitular = esTitular;
            Edad = edad;
            EstadoCivil = estadoCivil;
            GradoAcademico = gradoAcademico;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            WriteLine($"Departamento: {Departamento}, Años de Experiencia: {AñosExperiencia}");
            WriteLine($"Edad: {Edad}, Estado Civil: {EstadoCivil}");
            WriteLine($"Grado Académico: {GradoAcademico}, Titular: {EsTitular}");

            if (CursosImpartidos.Count > 0)
            {
                WriteLine("Cursos que imparte:");
                foreach (var curso in CursosImpartidos)
                {
                    WriteLine($"- {curso}");
                }
            }
        }

        public void AumentarExperiencia(int años)
        {
            AñosExperiencia += años;
            WriteLine($"Años de experiencia actualizados a: {AñosExperiencia}");
        }

        public void CambiarTitularidad(string esTitular)
        {
            EsTitular = esTitular;
            WriteLine($"Titularidad actualizada a: {EsTitular}");
        }

        public bool EsProfesorSenior()
        {
            return AñosExperiencia >= 10;
        }

        public void AgregarCurso(string curso)
        {
            CursosImpartidos.Add(curso);
            WriteLine($"Curso '{curso}' agregado.");
        }
    }
}
