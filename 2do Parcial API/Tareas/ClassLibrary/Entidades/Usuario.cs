using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El Usuario es obligatorio.")]
        [MaxLength(10)]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "La Clave es obligatorio.")]
        [MinLength(5)]
        [MaxLength(10)]
        public string Clave { get; set; }
    }
}
