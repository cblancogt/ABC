using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABC.Models
{
    public class Proyecto
    {
        [Key]
        public int IdProyecto { set; get; }

        [Required(ErrorMessage ="Ingrese nombre de Proyecto")]
        [StringLength(150)]
        public string Nombre { get; set; }
        [StringLength(150)]
        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        public int IdUsuario { get; set; }
        public int IdEstado { get; set; }
    }
}
