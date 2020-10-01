using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tarea 1
            Tareas Tarea1 = new Tareas();
            Tarea1.Titulo = "Desayunar";
            Tarea1.Vencimiento = "03/09/2020";
            Tarea1.Responsable.Nombre = "Cristian";
            Tarea1.Responsable.Usuarios.Usuario = "Cristian";
            Tarea1.Responsable.Usuarios.Clave = "Cristian1234";
            Tarea1.Estimacion = "Nose";
            Tarea1.Estado = true;

            // Tarea 2
            Tareas Tarea2 = new Tareas();
            Tarea2.Titulo = "Estudiar";
            Tarea2.Vencimiento = "23/07/2020";
            Tarea2.Responsable.Usuarios.Usuario = "Cristian";
            Tarea2.Responsable.Usuarios.Clave = "Cristian1234";
            Tarea2.Estimacion = "Nose";
            Tarea2.Estado = false;

            // Tarea 3
            Tareas Tarea3 = new Tareas();
            Tarea3.Titulo = "Reunion";
            Tarea3.Vencimiento = "05/09/2020";
            Tarea3.Responsable.Usuarios.Usuario = "Cristian";
            Tarea3.Responsable.Usuarios.Clave = "Cristian1234";
            Tarea3.Estimacion = "Nose";
            Tarea3.Estado = true;

            // Tarea 4
            Tareas Tarea4 = new Tareas();
            Tarea4.Titulo = "Reunion";
            Tarea4.Vencimiento = "06/09/2020";
            Tarea4.Responsable.Usuarios.Usuario = "Cristian";
            Tarea4.Responsable.Usuarios.Clave = "Cristian1234";
            Tarea4.Estimacion = "Nose";
            Tarea4.Estado = true;

            // Tarea 5
            Tareas Tarea5 = new Tareas();
            Tarea5.Titulo = "Cumpleaños";
            Tarea5.Vencimiento = "15/09/2020";
            Tarea5.Responsable.Usuarios.Usuario = "Cristian";
            Tarea5.Responsable.Usuarios.Clave = "Cristian1234";
            Tarea5.Estimacion = "Nose";
            Tarea5.Estado = true;

            List<Tareas> Tarea = new List<Tareas>();

            Tarea.Add(Tarea1);
            Tarea.Add(Tarea2);
            Tarea.Add(Tarea3);
            Tarea.Add(Tarea4);
            Tarea.Add(Tarea5);

        }
    }
}
