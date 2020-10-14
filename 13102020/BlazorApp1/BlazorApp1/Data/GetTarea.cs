using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class GetTarea
    {
        private static readonly string[] Tareas = new[]
{
            "Hacer Tarea", "Practicar C#", "Jugar LOL", "Tomar la chocolatada", "Jugar LOL", "Ver Netflix", "A mimir"
        };

        public TareaModel[] GetTareasAsync()
        {
            TareaModel[] resultado = new TareaModel[5];

            resultado[0] = new TareaModel();
            resultado[0].Titulo = "Titulo 1";
            resultado[0].Estado = "Titulo 1";
            resultado[1] = new TareaModel();
            resultado[0].Titulo = "Titulo 2";
            resultado[0].Estado = "Titulo 2";
            resultado[2] = new TareaModel();
            resultado[0].Titulo = "Titulo 3";
            resultado[0].Estado = "Titulo 3";
            resultado[3] = new TareaModel();
            resultado[0].Titulo = "Titulo 4";
            resultado[0].Estado = "Titulo 4";
            resultado[4] = new TareaModel();
            resultado[0].Titulo = "Titulo 5";
            resultado[0].Estado = "Titulo 5";
            resultado[5] = new TareaModel();
            resultado[0].Titulo = "Titulo 6";
            resultado[0].Estado = "Titulo 6";

            return resultado;
        }
    }
}
