using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models.Otros
{
    public class Ayuda
    {
        [Key]
        public int AyudaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Conceptos { get; set; }
    }
}
