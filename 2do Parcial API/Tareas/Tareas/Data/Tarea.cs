using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tareas.Data
{
    public class Tarea
    {
        [Key]
        public int IdTareas { get; set; }

        [Required(ErrorMessage = "El Titulo es obligatorio.")]
        [DisplayName("Nombre Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El Vencimiento es obligatorio.")]
        public string Vencimiento { get; set; }

        [Required(ErrorMessage = "La Estimacion es obligatorio.")]
        public string Estimacion { get; set; }

        public Recurso Responsable { get; set; }
        public int IdResponsable { get; set; }

        [Required(ErrorMessage = "El Estado es obligatorio.")]
        public bool Estado { get; set; }

        public List<Detalle> Detalles { get; set; }
    }
}
