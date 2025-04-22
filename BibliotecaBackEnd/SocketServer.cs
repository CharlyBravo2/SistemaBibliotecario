using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BibliotecaBackEnd.Objetos;
using Newtonsoft.Json;

namespace BibliotecaBackEnd
{
    internal class SocketServer
    {
        public static void IniciarServidor()
        {

            TcpListener servidor = new TcpListener(IPAddress.Any, 5000);
            servidor.Start();
            Console.WriteLine("Servidor esperando conexiones...");

            while (true)
            {
                try
                {
                    TcpClient cliente = servidor.AcceptTcpClient();
                    using (NetworkStream stream = cliente.GetStream())
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true })
                    {
                        string jsonMensaje = reader.ReadToEnd();
                        Mensaje mensaje = JsonConvert.DeserializeObject<Mensaje>(jsonMensaje);

                        switch (mensaje.Tipo)
                        {
                            case "Libro":
                                var libro = JsonConvert.DeserializeObject<Libro>(mensaje.Datos);
                                Program.datos.Libros.Add(libro);
                                Console.WriteLine("📘 Libro agregado.");
                                break;

                            case "Usuario":
                                var usuario = JsonConvert.DeserializeObject<Usuario>(mensaje.Datos);
                                Program.datos.Usuarios.Add(usuario);
                                Console.WriteLine("👤 Usuario agregado.");
                                break;

                            case "Prestamo":
                                var prestamo = JsonConvert.DeserializeObject<Prestamo>(mensaje.Datos);
                                Program.datos.Prestamos.Add(prestamo);
                                Console.WriteLine("📄 Préstamo registrado.");
                                break;

                            case "Backup":
                                File.WriteAllText("backup.json", mensaje.Datos);
                                Console.WriteLine("🗂️ Backup guardado.");
                                break;

                            // 🔁 PETICIONES CON RESPUESTA
                            case "GetLibros":
                                if (mensaje.RequiereRespuesta)
                                {
                                    var librosJson = JsonConvert.SerializeObject(Program.datos.Libros);
                                    writer.Write(librosJson);
                                }
                                break;

                            case "GetUsuarios":
                                if (mensaje.RequiereRespuesta)
                                {
                                    var usuariosJson = JsonConvert.SerializeObject(Program.datos.Usuarios);
                                    writer.Write(usuariosJson);
                                }
                                break;

                            case "GetPrestamos":
                                if (mensaje.RequiereRespuesta)
                                {
                                    var prestamosJson = JsonConvert.SerializeObject(Program.datos.Prestamos);
                                    writer.Write(prestamosJson);
                                }
                                break;

                            default:
                                Console.WriteLine(" Tipo de mensaje no reconocido.");
                                break;
                        }

                        Program.GuardarDatos();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Error: " + ex.Message);
                }
        }   }
    }
}
