using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABC.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario{get; set; }


        public string Nombre { get; set; }

        [Required(ErrorMessage ="Debe escribir un correo")]
        public string Correo { get; set; }

        [Required(ErrorMessage ="Debe escribir una contrasena")]
        public string Contrasena { get; set; }

        public string Telefono { get; set; }
        public int IdRol { get; set; }
        public int IdEstado { get; set; }
    }
}
