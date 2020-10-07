using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Table("Usuario")] //Tabla Usuario
    public class Usuario
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(25)]
        [MinLength(10)]
        public string Nombre { get; set; }

        [MinLength(6)]
        [Required] //Requerido

        public string Clave { get; set; }

        //[NotMapped] Imagen -> no lo graba en la base de dato
    }
}
