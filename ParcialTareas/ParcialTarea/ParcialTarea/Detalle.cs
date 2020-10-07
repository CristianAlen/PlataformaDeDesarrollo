using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParcialTarea
{
    [Table("Detalles")]
    public class Detalle
    {
        [Key]
        public int IdDetalles { get; set; }

        [MaxLength(8)]
        [MinLength(8)]
        [Required]
        public string Fecha { get; set; }

        [MaxLength(4)]
        [MinLength(4)]
        [Required]
        public string Tiempo { get; set; }

        public Recurso Recurso { get; set; }
        public int IdRecurso { get; set; }
    }
}
