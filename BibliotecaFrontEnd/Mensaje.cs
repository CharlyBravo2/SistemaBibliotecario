using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaFrontEnd.GUI;
namespace BibliotecaFrontEnd
{
    public class Mensaje
    {
        public string Tipo { get; set; }
        public string Datos { get; set; }

        public bool RequiereRespuesta { get; set; } = false; // NUEVO
    }
}
