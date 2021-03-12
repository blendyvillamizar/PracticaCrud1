using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaCrud.Models.Entities
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }

        [Column("Nombre Empleado", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage ="El nombre es requerido")]
        public string Nombre { get; set; }
       
        public int Documento { get; set; }
        public int CargoId { get; set; }
        public string Telefono { get; set; }
    }
}
