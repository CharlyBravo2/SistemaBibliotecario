using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBackEnd.Objetos
{
    public class JsonSerializerOptions
    {
        public bool WriteIndented { get; set; }
        public object ReferenceHandler { get; set; }
        public object DefaultIgnoreCondition { get; set; }
        public bool PropertyNameCaseInsensitive { get; set; }
    }
}
