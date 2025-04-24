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
                        RespuestaServidor respuesta = new RespuestaServidor();

                        try
                        {
                            switch (mensaje.Tipo)
                            {
                                case "Libro":
                                    var libro = JsonConvert.DeserializeObject<Libro>(mensaje.Datos);
                                    Program.datos.Libros.Add(libro);
                                    Program.GuardarDatos();
                                    respuesta.Exito = true;
                                    respuesta.Mensaje = "Libro agregado correctamente.";
                                    break;

                                case "Usuario":
                                    var usuario = JsonConvert.DeserializeObject<Usuario>(mensaje.Datos);
                                    Program.datos.Usuarios.Add(usuario);
                                    Program.GuardarDatos();
                                    respuesta.Exito = true;
                                    respuesta.Mensaje = "Usuario agregado correctamente.";
                                    break;

                                case "Prestamo":
                                    var prestamo = JsonConvert.DeserializeObject<Prestamo>(mensaje.Datos);
                                    
                                    Program.AgregarPrestamoGlobal(prestamo);
                                    
                                    var libroP = Program.libros.First(l => l.ISBN == prestamo.LibroPrestado.ISBN);
                                    var usuarioP = Program.usuarios.First(u => u.Identificacion == prestamo.Usuario.Identificacion);
                                    libroP.EjemplaresDisponibles -= prestamo.CantidadLibrosPrestados;
                                    libroP.Prestamos.Add(prestamo);
                                    usuarioP.Prestamos.Add(prestamo);
                                    Program.GuardarDatos();
                                    respuesta.Exito = true;
                                    respuesta.Mensaje = "Préstamo registrado correctamente.";
                                    break;

                                case "GetLibros":
                                    if (mensaje.RequiereRespuesta)
                                    {
                                        respuesta.Exito = true;
                                        respuesta.Mensaje = "Libros enviados correctamente.";
                                        respuesta.Datos = JsonConvert.SerializeObject(Program.datos.Libros);
                                    }
                                    break;

                                case "GetUsuarios":
                                    if (mensaje.RequiereRespuesta)
                                    {
                                        respuesta.Exito = true;
                                        respuesta.Mensaje = "Usuarios enviados correctamente.";
                                        respuesta.Datos = JsonConvert.SerializeObject(Program.datos.Usuarios);

                                    }
                                    break;

                                case "GetPrestamos":
                                    if (mensaje.RequiereRespuesta)
                                    {
                                        respuesta.Exito = true;
                                        respuesta.Mensaje = "Todos los préstamos enviados correctamente.";
                                        respuesta.Datos = JsonConvert.SerializeObject(Program.datos.Prestamos);

                                    }
                                    break;

                                case "DevolverPrestamo":
                                    var prestamoDev = JsonConvert.DeserializeObject<Prestamo>(mensaje.Datos);

                                    var original = Program.datos.Prestamos.FirstOrDefault(p =>
                                        p.Usuario.Identificacion == prestamoDev.Usuario.Identificacion &&
                                        p.LibroPrestado.ISBN == prestamoDev.LibroPrestado.ISBN &&
                                        !p.Devuelto);

                                    if (original != null)
                                    {
                                        original.Devuelto = true;
                                        original.LibroPrestado.EjemplaresDisponibles += original.CantidadLibrosPrestados;
                                        Program.GuardarDatos();

                                        respuesta.Exito = true;
                                        respuesta.Mensaje = "Libro devuelto correctamente.";
                                    }
                                    else
                                    {
                                        respuesta.Exito = false;
                                        respuesta.Mensaje = "No se encontró un préstamo activo para ese libro y usuario.";
                                    }
                                    break;

                                default:
                                    respuesta.Exito = false;
                                    respuesta.Mensaje = $"Tipo de mensaje '{mensaje.Tipo}' no reconocido.";
                                    break;

                            }
                        }

                        catch (Exception ex)
                        {
                            respuesta.Exito = false;
                            respuesta.Mensaje = ex.Message;
                        }

                        
                        
                            writer.Write(JsonConvert.SerializeObject(respuesta));
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al procesar la conexión: {ex.Message}");
                }
            }
        }
    }
}
                
 
        
         

    
