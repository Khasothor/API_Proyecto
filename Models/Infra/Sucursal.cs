using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Infra
{
    public class Sucursal
    {
        public Sucursal()
        {
            FechaAlta = DateTime.UtcNow;
        }

        [Key]
        public int SucursalId { get; set; }

        [Required]
        [StringLength(30)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Observ { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(40)]
        public string Mail { get; set; }

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }

        [Required]
        [StringLength(50)]
        public string RazonSoc { get; set; }

        [Required]
        public bool IVA { get; set; }

        [Required]
        public Guid EntiOrgId { get; set; }

        [JsonIgnore]
        public ICollection<AlmaRuta> AlmaRutas { get; set; }
    }
}
