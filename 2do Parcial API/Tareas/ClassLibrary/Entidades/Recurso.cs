using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Recurso
    {
        [Key]
        public int IdRecursos { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [DisplayName("Nombre Recursos")]
        public string Nombre { get; set; }
        public Usuario Usuario { get; set; }
        public int idUsuario { get; set; }
    }
}
