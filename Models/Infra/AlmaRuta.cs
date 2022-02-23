using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models.Infra
{
    public class AlmaRuta
    {
        public AlmaRuta()
        {
            FechaAlta = DateTime.UtcNow;
        }

        [Key]
        public int AlmaRutaId { get; set; }

        [Required]
        [StringLength(30)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [StringLength(200)]
        public string Observ { get; set; }

        [Required]
        public bool Status { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }//almacen o ruta

        [Required]
        [StringLength(50)]
        public string Catego { get; set; }//categiria del almacen, generales, repuestos, mat prim, seguridad, etc

        [Required]
        public Guid EntiOrgId { get; set; }

        [Required]
        public int Sucursales { get; set; }
    }
}
