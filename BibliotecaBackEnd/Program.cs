using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaBackEnd.Objetos;
using static System.Console;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
namespace BibliotecaBackEnd

{
    public class Program
    {
        public const string ARCHIVO_DATOS = "datos_biblioteca.json";
        public static DatosBiblioteca datos = new DatosBiblioteca();
        public static List<Libro> libros = new List<Libro>();
        public static List<Autor> autores = new List<Autor>();
        public static List<Editorial> editoriales = new List<Editorial>();
        public static List<GeneroLiterario> generos = new List<GeneroLiterario>();
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Prestamo> prestamos = new List<Prestamo>();
        static void Main(string[] args)
        {
            Task.Run(() => SocketServer.IniciarServidor());
            CargarDatosIniciales();


            while (true)
            {
                try
                {
                    MostrarMenuPrincipal();
                    string opcion = ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            AgregarLibro();
                            break;
                        case "2":
                            AgregarUsuario();
                            break;
                        case "3":
                            ListarLibros();
                            break;
                        case "4":
                            PrestarLibros();
                            break;
                        case "5":
                            DevolverLibro();
                            break;
                        case "6":
                            BuscarLibro();
                            break;
                        case "7":
                            ActualizarLibro();
                            break;
                        case "8":
                            EliminarLibro();
                            break;
                        case "9":
                            ListarPrestamos();
                            break;
                        case "10":
                            GestionarBackup();
                            break;
                        case "11":
                            WriteLine("¡Gracias por usar el sistema!");
                            return;
                        default:
                            WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (EntradaNoValidaException ex)
                {
                    WriteLine($"Error: {ex.Message}");
                    WriteLine("\nPresione cualquier tecla para continuar...");
                    ReadKey();
                    Clear();
                }
                catch (Exception ex)
                {
                    WriteLine($"Error inesperado: {ex.Message}");
                    WriteLine("\nPresione cualquier tecla para continuar...");
                    ReadKey();
                    Clear();
                }
                finally
                {
                    GuardarDatos();
                }
            }
        }

        private static void MostrarMenuPrincipal()
        {
            Clear();
            WriteLine("╔══════════════════════════════════╗");
            WriteLine("║ SISTEMA DE GESTIÓN BIBLIOTECARIA ║");
            WriteLine("╠══════════════════════════════════╣");
            WriteLine("║ 1. Agregar Libro                 ║");
            WriteLine("║ 2. Agregar Usuario               ║");
            WriteLine("║ 3. Listar Libros                 ║");
            WriteLine("║ 4. Prestar Libros                ║");
            WriteLine("║ 5. Devolver Libro                ║");
            WriteLine("║ 6. Buscar Libro                  ║");
            WriteLine("║ 7. Actualizar Libro              ║");
            WriteLine("║ 8. Eliminar Libro                ║");
            WriteLine("║ 9. Listar Préstamos              ║");
            WriteLine("║ 10. Gestionar backup             ║");
            WriteLine("║ 11. Salir                        ║");
            WriteLine("╚══════════════════════════════════╝");
            Write("Seleccione una opción: ");
        }

        public static void CargarDatosIniciales()
        {
            datos = JsonDataManager.CargarDatos<DatosBiblioteca>(ARCHIVO_DATOS) ?? new DatosBiblioteca();

            libros = datos.Libros ?? new List<Libro>();
            autores = datos.Autores ?? new List<Autor>();
            editoriales = datos.Editoriales ?? new List<Editorial>();
            generos = datos.Generos ?? new List<GeneroLiterario>();
            usuarios = datos.Usuarios ?? new List<Usuario>();
            prestamos = datos.Prestamos ?? new List<Prestamo>();


            ReconstruirRelaciones();
        }

        public static void ReconstruirRelaciones()
        {

            foreach (var prestamo in prestamos)
            {
                if (prestamo.LibroPrestado != null)
                {
                    var libro = libros.FirstOrDefault(l => l.ISBN == prestamo.LibroPrestado.ISBN);
                    if (libro != null)
                    {
                        prestamo.LibroPrestado = libro;
                        libro.Prestamos.Add(prestamo);
                    }
                }

                if (prestamo.Usuario != null)
                {
                    var usuario = usuarios.FirstOrDefault(u => u.Identificacion == prestamo.Usuario.Identificacion);
                    if (usuario != null)
                    {
                        prestamo.Usuario = usuario;
                        usuario.Prestamos.Add(prestamo);
                    }
                }
            }
        }

        public static void GuardarDatos()
        {
            datos.Libros = libros;
            datos.Autores = autores;
            datos.Editoriales = editoriales;
            datos.Generos = generos;
            datos.Usuarios = usuarios;
            datos.Prestamos = prestamos;

            JsonDataManager.GuardarDatos(ARCHIVO_DATOS, datos);
        }

        public static void AgregarPrestamoGlobal(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
            datos.Prestamos = prestamos;
        }

        static void GestionarBackup()
        {
            Clear();
            WriteLine("\n════════ GESTIÓN DE BACKUP ════════");
            WriteLine("1. Exportar todos los datos");
            WriteLine("2. Importar datos desde archivo");
            WriteLine("3. Volver al menú principal");
            Write("Seleccione una opción: ");

            string opcion = ReadLine();

            switch (opcion)
            {
                case "1":
                    ExportarDatos();
                    break;
                case "2":
                    ImportarDatos();
                    break;
                case "3":
                    return;
                default:
                    WriteLine("Opción no válida.");
                    break;
            }
        }

        static void ExportarDatos()
        {
            Clear();
            Write("Ingrese la ruta del archivo para exportar (ej: C:\\backup_biblioteca.json): ");
            string ruta = ReadLine();

            try
            {
                JsonDataManager.GuardarDatos(ruta, datos);
                WriteLine(" Datos exportados correctamente.");
            }
            catch (Exception ex)
            {
                WriteLine($" Error al exportar: {ex.Message}");
            }

            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
        }

        static void ImportarDatos()
        {
            Clear();
            Write("Ingrese la ruta del archivo para importar (ej: C:\\backup_biblioteca.json): ");
            string ruta = ReadLine();

            try
            {
                var datosImportados = JsonDataManager.CargarDatos<DatosBiblioteca>(ruta);
                if (datosImportados != null)
                {
                    datos = datosImportados;
                    ActualizarListasEstaticas();
                    ReconstruirRelaciones();
                    WriteLine(" Datos importados correctamente.");
                }
                else
                {
                    WriteLine(" No se pudieron cargar los datos del archivo.");
                }
            }
            catch (Exception ex)
            {
                WriteLine($" Error al importar: {ex.Message}");
            }

            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
        }

        static void ActualizarListasEstaticas()
        {
            libros = datos.Libros ?? new List<Libro>();
            autores = datos.Autores ?? new List<Autor>();
            editoriales = datos.Editoriales ?? new List<Editorial>();
            generos = datos.Generos ?? new List<GeneroLiterario>();
            usuarios = datos.Usuarios ?? new List<Usuario>();
            prestamos = datos.Prestamos ?? new List<Prestamo>();
        }
        static void AgregarLibro()
        {
            WriteLine("\n════════ AGREGAR NUEVO LIBRO ════════");

            Write("Título (1-50 caracteres): ");
            string titulo = Validaciones.ValidarEntradaTexto(1, 50);

            Write("ISBN (10-13 caracteres): ");
            string isbn = Validaciones.ValidarEntradaTexto(10, 13);

            if (!Validaciones.ValidarLibroUnico(libros, titulo, isbn))
            {
                throw new EntradaNoValidaException("El libro ya existe (título o ISBN duplicado).");
            }

            Write("Año de Publicación (hasta {0}): ", DateTime.Now.Year);
            int añoPublicacion = Validaciones.ValidarEntero(1000, DateTime.Now.Year);

            Write("Cantidad de Ejemplares disponibles en biblioteca: ");
            int cantidadEjemplares = Validaciones.ValidarEntero(1, int.MaxValue);

            WriteLine("\n── INFORMACIÓN DEL AUTOR ──");
            Write("Nombre del Autor (1-50 caracteres): ");
            string nombreAutor = Validaciones.ValidarEntradaTexto(1, 50);
            Write("Apellido del Autor (1-50 caracteres): ");
            string apellidoAutor = Validaciones.ValidarEntradaTexto(1, 50);

            Autor autor = autores.FirstOrDefault(a => a.Nombre == nombreAutor && a.Apellido == apellidoAutor);
            if (autor == null)
            {
                Write("Nacionalidad del Autor (1-50 caracteres): ");
                string nacionalidad = Validaciones.ValidarEntradaTexto(1, 50);

                Write("Año de Nacimiento del Autor (hasta {0}): ", DateTime.Now.Year);
                int añoNacimiento = Validaciones.ValidarEntero(1000, DateTime.Now.Year);

                Write("Cantidad de libros publicados: ");
                int cantidadLibrosPublicados = Validaciones.ValidarEntero(0, int.MaxValue);

                Write("¿Tiene pseudónimo? (S/N): ");
                string tienePseudonimo = Validaciones.ValidarSiNo();
                string pseudonimo = "";
                if (tienePseudonimo == "S")
                {
                    Write("Pseudónimo: ");
                    pseudonimo = Validaciones.ValidarEntradaTexto(1, 50);
                }

                Write("¿Es autor best-seller? (S/N): ");
                bool esBestSeller = Validaciones.ValidarSiNo() == "S";

                autor = new Autor(nombreAutor, apellidoAutor, nacionalidad, añoNacimiento, cantidadLibrosPublicados, pseudonimo, esBestSeller);
                autores.Add(autor);
            }

            WriteLine("\n── INFORMACIÓN DE LA EDITORIAL ──");
            Write("Nombre de la Editorial (1-50 caracteres): ");
            string nombreEditorial = Validaciones.ValidarEntradaTexto(1, 50);

            Editorial editorial = editoriales.FirstOrDefault(e => e.Nombre == nombreEditorial);
            if (editorial == null)
            {
                Write("País de la Editorial (1-50 caracteres): ");
                string pais = Validaciones.ValidarEntradaTexto(1, 50);

                Write("Dirección de la Editorial (1-100 caracteres): ");
                string direccion = Validaciones.ValidarEntradaTexto(1, 100);

                Write("Teléfono de la Editorial: ");
                string telefono = Validaciones.ValidarTelefono();

                Write("Correo Electrónico de la Editorial: ");
                string correoElectronico = Validaciones.ValidarCorreoElectronico();

                Write("Año de Fundación de la Editorial: ");
                int añoFundacion = Validaciones.ValidarEntero(1000, DateTime.Now.Year);

                Write("Sitio Web de la Editorial: ");
                string sitioWeb = Validaciones.ValidarEntradaTexto(1, 100);

                editorial = new Editorial(nombreEditorial, pais, direccion, telefono, correoElectronico, añoFundacion, sitioWeb);
                editoriales.Add(editorial);
            }

            WriteLine("\n── INFORMACIÓN DEL GÉNERO LITERARIO ──");
            Write("Nombre del Género Literario (1-50 caracteres): ");
            string nombreGenero = Validaciones.ValidarEntradaTexto(1, 50);

            GeneroLiterario genero = generos.FirstOrDefault(g => g.Nombre == nombreGenero);
            if (genero == null)
            {
                Write("Tema del Género Literario (1-50 caracteres): ");
                string tema = Validaciones.ValidarEntradaTexto(1, 50);

                Write("Subgénero (opcional, 1-50 caracteres): ");
                string subgenero = ReadLine();

                Write("Popularidad (Alta/Media/Baja): ");
                string popularidad = Validaciones.ValidarEntradaTexto(1, 50);

                Write("Año de Origen: ");
                int añoOrigen = Validaciones.ValidarEntero(0, DateTime.Now.Year);

                Write("Descripción (opcional): ");
                string descripcion = ReadLine();

                genero = new GeneroLiterario(nombreGenero, tema, subgenero, popularidad, añoOrigen, descripcion);

                Write("¿Desea agregar autores representativos? (S/N): ");
                if (Validaciones.ValidarSiNo() == "S")
                {
                    while (true)
                    {
                        Write("Nombre del autor (o 'fin' para terminar): ");
                        string autorRep = ReadLine();
                        if (autorRep.ToLower() == "fin") break;
                        genero.AgregarAutorRepresentativo(autorRep);
                    }
                }

                generos.Add(genero);
            }

            libros.Add(new Libro(titulo, autor, editorial, genero, isbn, añoPublicacion, cantidadEjemplares));
            WriteLine("\n Libro agregado correctamente.");
            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }

        static void BuscarLibro()
        {
            WriteLine("\n════════ BUSCAR LIBRO ════════");
            Write("Ingrese el título o ISBN del libro a buscar: ");
            string busqueda = ReadLine();

            var libro = libros.FirstOrDefault(l => l.Titulo.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
                       l.ISBN.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

            if (libro != null)
            {
                WriteLine("\n════════ INFORMACIÓN DEL LIBRO ════════");
                libro.MostrarInformacion();
                WriteLine($"Disponibilidad: {(libro.EstaDisponible() ? "Disponible" : "No disponible")}");
            }
            else
            {
                throw new EntradaNoValidaException("Libro no encontrado.");
            }

            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }

        static void ListarLibros()
        {
            WriteLine("\n════════ LISTADO DE LIBROS ════════");

            if (libros.Count == 0)
            {
                throw new EntradaNoValidaException("No hay libros registrados.");
            }

            foreach (var libro in libros)
            {
                WriteLine($"\n {libro.Titulo} ({libro.AñoPublicacion})");
                WriteLine($"Autor: {libro.AutorLibro.ObtenerNombreCompleto()}");
                WriteLine($"Editorial: {libro.EditorialLibro.Nombre}");
                WriteLine($"Género: {libro.Genero.Nombre}");
                WriteLine($"ISBN: {libro.ISBN}");
                WriteLine($"Ejemplares: {libro.EjemplaresDisponibles}/{libro.CantidadEjemplares} disponibles");
                WriteLine("────────────────────────────────");
            }

            WriteLine($"\nTotal de libros registrados: {libros.Count}");
            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }

        static void PrestarLibros()
        {
            WriteLine("\n════════ PRESTAR LIBROS ════════");
            Write("Ingrese la identificación del usuario: ");
            string identificacion = ReadLine();

            var usuario = usuarios.FirstOrDefault(u => u.Identificacion.Equals(identificacion, StringComparison.OrdinalIgnoreCase));
            if (usuario == null)
            {
                throw new EntradaNoValidaException("Usuario no encontrado.");
            }

            List<Libro> librosAPrestar = new List<Libro>();
            bool continuar = true;

            while (continuar)
            {
                Write("\nIngrese el título o ISBN del libro a prestar (o 'fin' para terminar): ");
                string busqueda = ReadLine();

                if (busqueda.ToLower() == "fin")
                {
                    continuar = false;
                    continue;
                }

                var libro = libros.FirstOrDefault(l => l.Titulo.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
                           l.ISBN.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

                if (libro == null)
                {
                    WriteLine("Libro no encontrado. Intente nuevamente.");
                    continue;
                }

                if (!libro.EstaDisponible())
                {
                    WriteLine("No hay ejemplares disponibles de este libro.");
                    continue;
                }

                librosAPrestar.Add(libro);
                WriteLine($"Libro '{libro.Titulo}' agregado a la lista de préstamo.");
            }

            if (librosAPrestar.Count > 0)
            {
                usuario.PrestarLibros(librosAPrestar);
            }
            else
            {
                WriteLine("No se seleccionaron libros para prestar.");
            }

            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }

        static void DevolverLibro()
        {
            WriteLine("\n════════ DEVOLVER LIBRO ════════");
            Write("Ingrese el título o ISBN del libro a devolver: ");
            string busqueda = ReadLine();

            var libro = libros.FirstOrDefault(l => l.Titulo.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
                       l.ISBN.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

            if (libro == null)
            {
                throw new EntradaNoValidaException("Libro no encontrado.");
            }

            Write("Ingrese la identificación del usuario: ");
            string identificacion = ReadLine();

            var usuario = usuarios.FirstOrDefault(u => u.Identificacion.Equals(identificacion, StringComparison.OrdinalIgnoreCase));
            if (usuario == null)
            {
                throw new EntradaNoValidaException("Usuario no encontrado.");
            }

            usuario.DevolverLibro(libro);
            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }

        static void AgregarUsuario()
        {
            WriteLine("\n════════ AGREGAR USUARIO ════════");
            Write("Nombre del usuario (1-50 caracteres): ");
            string nombre = Validaciones.ValidarEntradaTexto(1, 50);

            Write("Apellido del usuario (1-50 caracteres): ");
            string apellido = Validaciones.ValidarEntradaTexto(1, 50);

            Write("Identificación del usuario (1-20 caracteres): ");
            string identificacion = Validaciones.ValidarEntradaTexto(1, 20);

            if (!Validaciones.ValidarUsuarioUnico(usuarios, identificacion))
            {
                throw new EntradaNoValidaException("El usuario ya existe (identificación duplicada).");
            }

            Write("Correo electrónico del usuario: ");
            string correo = Validaciones.ValidarCorreoElectronico();

            Write("Teléfono del usuario: ");
            string telefono = Validaciones.ValidarTelefono();

            Write("¿Es un profesor o un estudiante? (P/E): ");
            string tipoUsuario = ReadLine().ToUpper();

            if (tipoUsuario == "P")
            {
                Write("Departamento del profesor (1-50 caracteres): ");
                string departamento = Validaciones.ValidarEntradaTexto(1, 50);

                Write("Años de experiencia del profesor: ");
                int añosExperiencia = Validaciones.ValidarEntero(0, int.MaxValue);

                Write("¿Es titular? (S/N): ");
                string esTitular = Validaciones.ValidarSiNo();

                Write("Edad del profesor: ");
                int edad = Validaciones.ValidarEntero(18, 100);

                Write("Estado civil del profesor: ");
                string estadoCivil = Validaciones.ValidarEntradaTexto(1, 50);

                Write("Grado académico del profesor: ");
                string gradoAcademico = Validaciones.ValidarEntradaTexto(1, 50);

                Profesor profesor = new Profesor(nombre, apellido, identificacion, correo, telefono, departamento, añosExperiencia, esTitular, edad, estadoCivil, gradoAcademico);

                Write("¿Desea agregar cursos que imparte? (S/N): ");
                if (Validaciones.ValidarSiNo() == "S")
                {
                    while (true)
                    {
                        Write("Nombre del curso (o 'fin' para terminar): ");
                        string curso = ReadLine();
                        if (curso.ToLower() == "fin") break;
                        profesor.AgregarCurso(curso);
                    }
                }

                usuarios.Add(profesor);
                WriteLine("\n Profesor agregado correctamente.");
            }
            else if (tipoUsuario == "E")
            {
                Write("Carrera del estudiante (1-50 caracteres): ");
                string carrera = Validaciones.ValidarEntradaTexto(1, 50);

                Write("Semestre del estudiante: ");
                int semestre = Validaciones.ValidarEntero(1, 12);

                Write("Promedio de calificaciones del estudiante (0-100): ");
                double promedioCalificaciones = Validaciones.ValidarDouble(0, 100);

                Write("Edad del estudiante: ");
                int edad = Validaciones.ValidarEntero(15, 100);

                Write("Estado civil del estudiante: ");
                string estadoCivil = Validaciones.ValidarEntradaTexto(1, 50);

                Write("Tipo de beca (Completa/Parcial/Ninguna): ");
                string tipoBeca = Validaciones.ValidarEntradaTexto(1, 50);

                Write("¿Es estudiante regular? (S/N): ");
                bool esRegular = Validaciones.ValidarSiNo() == "S";

                Estudiante estudiante = new Estudiante(nombre, apellido, identificacion, correo, telefono, carrera, semestre, promedioCalificaciones, edad, estadoCivil, tipoBeca, esRegular);
                usuarios.Add(estudiante);
                WriteLine("\n Estudiante agregado correctamente.");
            }
            else
            {
                throw new EntradaNoValidaException("Opción no válida. Debe ser 'P' para profesor o 'E' para estudiante.");
            }

            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }

        static void ActualizarLibro()
        {
            WriteLine("\n════════ ACTUALIZAR LIBRO ════════");
            Write("Ingrese el título o ISBN del libro a actualizar: ");
            string busqueda = ReadLine();

            var libro = libros.FirstOrDefault(l => l.Titulo.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
                       l.ISBN.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

            if (libro == null)
            {
                throw new EntradaNoValidaException("Libro no encontrado.");
            }

            WriteLine("\nSeleccione qué desea actualizar:");
            WriteLine("1. Título");
            WriteLine("2. Cantidad de ejemplares");
            WriteLine("3. Año de publicación");
            WriteLine("4. Información del autor");
            WriteLine("5. Información de la editorial");
            WriteLine("6. Información del género");
            Write("Opción: ");
            string opcion = ReadLine();

            switch (opcion)
            {
                case "1":
                    Write("Nuevo título (1-50 caracteres): ");
                    libro.Titulo = Validaciones.ValidarEntradaTexto(1, 50);
                    break;
                case "2":
                    Write("Nueva cantidad de ejemplares: ");
                    int nuevaCantidad = Validaciones.ValidarEntero(1, int.MaxValue);
                    libro.ActualizarEjemplares(nuevaCantidad);
                    break;
                case "3":
                    Write($"Nuevo año de publicación (hasta {DateTime.Now.Year}): ");
                    libro.AñoPublicacion = Validaciones.ValidarEntero(1000, DateTime.Now.Year);
                    break;
                case "4":
                    ActualizarAutor(libro.AutorLibro);
                    break;
                case "5":
                    ActualizarEditorial(libro.EditorialLibro);
                    break;
                case "6":
                    ActualizarGenero(libro.Genero);
                    break;
                default:
                    throw new EntradaNoValidaException("Opción no válida.");
            }

            WriteLine("\n Libro actualizado correctamente.");
            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }

        static void ActualizarAutor(Autor autor)
        {
            WriteLine("\n── ACTUALIZAR AUTOR ──");
            WriteLine("1. Actualizar pseudónimo");
            WriteLine("2. Actualizar información de best-seller");
            Write("Opción: ");
            string opcion = ReadLine();

            switch (opcion)
            {
                case "1":
                    Write("Nuevo pseudónimo (deje vacío para eliminar): ");
                    string nuevoPseudonimo = ReadLine();
                    autor.ActualizarPseudonimo(nuevoPseudonimo);
                    break;
                case "2":
                    Write("¿Es autor best-seller? (S/N): ");
                    autor.EsBestSeller = Validaciones.ValidarSiNo() == "S";
                    WriteLine("Información de best-seller actualizada.");
                    break;
                default:
                    throw new EntradaNoValidaException("Opción no válida.");
            }
        }

        static void ActualizarEditorial(Editorial editorial)
        {
            WriteLine("\n── ACTUALIZAR EDITORIAL ──");
            Write("Nuevo sitio web: ");
            string nuevoSitioWeb = Validaciones.ValidarEntradaTexto(1, 100);
            editorial.ActualizarSitioWeb(nuevoSitioWeb);
        }

        static void ActualizarGenero(GeneroLiterario genero)
        {
            WriteLine("\n── ACTUALIZAR GÉNERO LITERARIO ──");
            Write("Nueva popularidad (Alta/Media/Baja): ");
            string nuevaPopularidad = Validaciones.ValidarEntradaTexto(1, 50);
            genero.ActualizarPopularidad(nuevaPopularidad);
        }

        static void EliminarLibro()
        {
            WriteLine("\n════════ ELIMINAR LIBRO ════════");
            Write("Ingrese el título o ISBN del libro a eliminar: ");
            string busqueda = ReadLine();

            var libro = libros.FirstOrDefault(l => l.Titulo.Equals(busqueda, StringComparison.OrdinalIgnoreCase) ||
                       l.ISBN.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

            if (libro == null)
            {
                throw new EntradaNoValidaException("Libro no encontrado.");
            }

            if (libro.Prestamos.Any(p => !p.Devuelto))
            {
                throw new EntradaNoValidaException("No se puede eliminar el libro porque tiene préstamos activos.");
            }

            WriteLine("\n════════ INFORMACIÓN DEL LIBRO ════════");
            libro.MostrarInformacion();

            Write($"\n¿Está seguro que desea eliminar este libro? (S/N): ");
            string confirmacion = Validaciones.ValidarSiNo();

            if (confirmacion == "S")
            {
                libros.Remove(libro);
                WriteLine("\n Libro eliminado correctamente.");
            }
            else
            {
                WriteLine("\nOperación cancelada.");
            }

            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }

        static void ListarPrestamos()
        {
            WriteLine("\n════════ LISTADO DE PRÉSTAMOS ════════");
            WriteLine("1. Préstamos activos");
            WriteLine("2. Préstamos vencidos");
            WriteLine("3. Todos los préstamos");
            Write("Seleccione una opción: ");
            string opcion = ReadLine();

            IEnumerable<Prestamo> prestamosMostrar;

            switch (opcion)
            {
                case "1":
                    prestamosMostrar = prestamos.Where(p => !p.Devuelto);
                    WriteLine("\n════════ PRÉSTAMOS ACTIVOS ════════");
                    break;
                case "2":
                    prestamosMostrar = prestamos.Where(p => p.EstaVencido() && !p.Devuelto);
                    WriteLine("\n════════ PRÉSTAMOS VENCIDOS ════════");
                    break;
                case "3":
                    prestamosMostrar = prestamos;
                    WriteLine("\n════════ TODOS LOS PRÉSTAMOS ════════");
                    break;
                default:
                    throw new EntradaNoValidaException("Opción no válida.");
            }

            var listaPrestamos = prestamosMostrar.ToList();

            if (listaPrestamos.Count == 0)
            {
                WriteLine("No hay préstamos que mostrar con los criterios seleccionados.");
            }
            else
            {
                foreach (var prestamo in listaPrestamos)
                {
                    prestamo.MostrarInformacion();
                }
                WriteLine($"\nTotal de préstamos: {listaPrestamos.Count}");
            }

            WriteLine("\nPresione cualquier tecla para continuar...");
            ReadKey();
            Clear();
        }


    }
    
}
