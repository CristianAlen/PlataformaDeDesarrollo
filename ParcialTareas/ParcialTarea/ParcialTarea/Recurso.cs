using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParcialTarea
{
    [Table("Recurso")]
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
