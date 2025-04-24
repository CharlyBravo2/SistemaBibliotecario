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

        public static RespuestaServidor EnviarConRespuesta<T>(T objeto, string tipo)
        {
            var mensaje = new Mensaje
            {
                Tipo = tipo,
                Datos = JsonConvert.SerializeObject(objeto),
                RequiereRespuesta = true
            };

            string json = JsonConvert.SerializeObject(mensaje);

            
            using (TcpClient cliente = new TcpClient())
            {
                cliente.Connect(IP_SERVIDOR, PUERTO);

                using (NetworkStream stream = cliente.GetStream())
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true })
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    writer.Write(json);
                    writer.Flush();
                    cliente.Client.Shutdown(SocketShutdown.Send); 

                    string respJson = reader.ReadToEnd(); 
                    return JsonConvert.DeserializeObject<RespuestaServidor>(respJson);
                }
            }
        }
        private static RespuestaServidor EnviarYRecibir(string tipo)
              => EnviarConRespuesta(new { }, tipo);
        public static List<Libro> ObtenerLibros()
        {
            var resp = EnviarYRecibir("GetLibros");
            if (!resp.Exito) throw new Exception(resp.Mensaje);
            return JsonConvert.DeserializeObject<List<Libro>>(resp.Datos);

        }

        public static List<Usuario> ObtenerUsuarios()
        {
            var resp = EnviarYRecibir("GetUsuarios");
            if (!resp.Exito) throw new Exception(resp.Mensaje);
            return JsonConvert.DeserializeObject<List<Usuario>>(resp.Datos);

        }

        public static List<Prestamo> ObtenerPrestamos()
        {
            var resp = EnviarYRecibir("GetPrestamos");
            if (!resp.Exito) throw new Exception(resp.Mensaje);
            return JsonConvert.DeserializeObject<List<Prestamo>>(resp.Datos);

        }

        public static void AgregarLibro(Libro libro)
        {
            var resp = EnviarConRespuesta(libro, "Libro");
            if (!resp.Exito) throw new Exception(resp.Mensaje);
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            var resp = EnviarConRespuesta(usuario, "Usuario");
            if (!resp.Exito) throw new Exception(resp.Mensaje);
        }

        public static void AgregarPrestamo(Prestamo prestamo)
        {
            var resp = EnviarConRespuesta(prestamo, "Prestamo");
            if (!resp.Exito) throw new Exception(resp.Mensaje);
        }

        public static void RegistrarPrestamo(Prestamo p)
        {
            var resp = EnviarConRespuesta(p, "Prestamo");
            if (!resp.Exito) throw new Exception(resp.Mensaje);
        }

        public static void DevolverPrestamo(Prestamo prestamo)
        {
            var resp = EnviarConRespuesta(prestamo, "DevolverPrestamo");
            if (!resp.Exito) throw new Exception(resp.Mensaje);
        }
    }
}
