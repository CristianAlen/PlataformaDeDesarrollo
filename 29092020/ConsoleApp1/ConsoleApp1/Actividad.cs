﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IActividad
    {
        string Nombre { get; set; }
    }
    public class Actividad : IActividad
    {
        public int id { get; set; }
        public string Lugar { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

    }

    public class Tarea : IActividad
    {
        public int Nota { get; set; }
        public string Nombre { get; set; }
    }

    public class ActividadDto
    {
        public string Lugar { get; set; }
        public string Nombre { get; set; }

    }
}
