using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace BibliotecaBackEnd.Objetos
{
    public static class Validaciones
    {
        public static string ValidarEntradaTexto(int min, int max, string mensaje = "")
        {
            string entrada;
            while (true)
            {
                if (!string.IsNullOrEmpty(mensaje))
                    Write(mensaje);
                entrada = ReadLine();
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    WriteLine($"La entrada no puede estar vacía. Ingrese entre {min} y {max} caracteres.");
                }
                else if (entrada.Length < min || entrada.Length > max)
                {
                    WriteLine($"La entrada debe tener entre {min} y {max} caracteres.");
                }
                else
                {
                    break;
                }
            }
            return entrada;
        }

        public static int ValidarEntero(int min, int max, string mensaje = "")
        {
            int resultado;
            while (true)
            {
                if (!string.IsNullOrEmpty(mensaje))
                    Write(mensaje);
                string input = ReadLine();
                if (!int.TryParse(input, out resultado))
                {
                    WriteLine("Entrada no válida. Ingrese un número.");
                }
                else if (resultado < min || resultado > max)
                {
                    WriteLine($"El número debe estar entre {min} y {max}.");
                }
                else
                {
                    break;
                }
            }
            return resultado;
        }

        public static bool ValidarTelefono(string telefono)
        {
            return !string.IsNullOrWhiteSpace(telefono) && telefono.All(char.IsDigit);
        }

        public static string ValidarTelefono()
        {
            string telefono;
            while (true)
            {
                telefono = ReadLine();
                if (telefono.All(char.IsDigit))
                {
                    break;
                }
                else
                {
                    WriteLine("El teléfono solo puede contener números. Intente nuevamente.");
                }
            }
            return telefono;
        }

        public static string ValidarCorreoElectronico()
        {
            string correo;
            while (true)
            {
                correo = ReadLine();
                if (correo.Contains("@"))
                {
                    break;
                }
                else
                {
                    WriteLine("El correo electrónico debe contener el carácter '@'. Intente nuevamente.");
                }
            }
            return correo;
        }

        public static bool ValidarLibroUnico(List<Libro> libros, string titulo, string isbn)
        {
            return !libros.Any(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase) ||
                                   l.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
        }

        public static bool ValidarUsuarioUnico(List<Usuario> usuarios, string identificacion)
        {
            return !usuarios.Any(u => u.Identificacion.Equals(identificacion, StringComparison.OrdinalIgnoreCase));
        }

        public static string ValidarSiNo(string mensaje = "")
        {
            string sino;
            while (true)
            {
                if (!string.IsNullOrEmpty(mensaje))
                    Write(mensaje);
                sino = ReadLine().ToUpper();
                if (sino == "S" || sino == "N")
                {
                    return sino;
                }
                else
                {
                    WriteLine("Entrada no válida. Debe ser 'S' (Sí) o 'N' (No).");
                }
            }
        }

        public static double ValidarDouble(double min, double max, string mensaje = "")
        {
            double resultado;
            while (true)
            {
                if (!string.IsNullOrEmpty(mensaje))
                    Write(mensaje);
                string input = ReadLine();
                if (!double.TryParse(input, out resultado))
                {
                    WriteLine("Entrada no válida. Ingrese un número decimal.");
                }
                else if (resultado < min || resultado > max)
                {
                    WriteLine($"El número debe estar entre {min} y {max}.");
                }
                else
                {
                    break;
                }
            }
            return resultado;
        }
    }
}
