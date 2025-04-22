using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BibliotecaBackEnd.Objetos;
using Newtonsoft.Json;

namespace BibliotecaFrontEnd.Servicios
{
    public static class BibliotecaService
    {
        private const string IP_SERVIDOR = "127.0.0.1";
        private const int PUERTO = 5000;

        public static void EnviarGenerico<T>(T objeto, string tipo)
        {
            var mensaje = new Mensaje
            {
                Tipo = tipo,
                Datos = JsonConvert.SerializeObject(objeto)
            };

            string json = JsonConvert.SerializeObject(mensaje);

            using (TcpClient cliente = new TcpClient(IP_SERVIDOR, PUERTO))
            using (NetworkStream stream = cliente.GetStream())
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true })
            {
                writer.Write(json);
            }
        }

            public static List<Libro> ObtenerLibros()
        {
            string respuesta = EnviarYRecibir("GetLibros");
            return JsonConvert.DeserializeObject<List<Libro>>(respuesta);
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            string respuesta = EnviarYRecibir("GetUsuarios");
            return JsonConvert.DeserializeObject<List<Usuario>>(respuesta);
        }

        public static List<Prestamo> ObtenerPrestamos()
        {
            string respuesta = EnviarYRecibir("GetPrestamos");
            return JsonConvert.DeserializeObject<List<Prestamo>>(respuesta);
        }

        
        private static string EnviarYRecibir(string tipo)
        {
            var mensaje = new Mensaje
            {
                Tipo = tipo,
                RequiereRespuesta = true,
                Datos = "" 
            };

            string json = JsonConvert.SerializeObject(mensaje);

            using (TcpClient cliente = new TcpClient(IP_SERVIDOR, PUERTO))
            using (NetworkStream stream = cliente.GetStream())
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true })
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                writer.Write(json);
                string respuesta = reader.ReadToEnd();
                return respuesta;
            }
        }
    
    }
}
