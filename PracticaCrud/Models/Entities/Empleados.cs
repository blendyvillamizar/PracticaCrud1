using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaCrud.Models.Entities
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }

        public string Nombre { get; set; }

        public string Nombre { get; set; }
    }
}
