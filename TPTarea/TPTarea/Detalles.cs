using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPTarea
{
    public class Detalles
    {
        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public string Estimacion { get; set; }
        public Recursos Responsable { get; set; }
        public bool Estado { get; set; }

    }
}
