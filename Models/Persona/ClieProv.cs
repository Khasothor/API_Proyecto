using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Infra;

namespace WebApi2.Models.Persona
{
    public class ClieProv
    {
        public ClieProv()
        {
            FechaAlta = DateTime.UtcNow;
        }

        [Key]
        public int ClieprovId { get; set; }

        [Required]
        [StringLength(30)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }

        [Required]
        [StringLength(200)]
        public string Observ { get; set; }

        [Required]
        [StringLength(50)]
        public string RazonSoc { get; set; }

        public int Rating { get; set; }

        [Required]
        [StringLength(50)]
        public string Giro { get; set; }

        public string DatosCont { get; set; }

        public bool Status { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }

        public Guid EntiOrgId { get; set; }
    }
}
