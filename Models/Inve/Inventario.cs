using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebApi2.Models.Infra;

namespace WebApi2.Models.Inve
{
    public class Inventario
    {
        public Inventario()
        {
            InventarioId = Guid.NewGuid();
            FechaAlta = DateTime.UtcNow;
        }
        [Key]
        public Guid InventarioId { get; set; }

        [Required]
        [StringLength(30)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string NombreCor { get; set; }

        [Required]
        [StringLength(200)]
        public string Descrip { get; set; }

        public string Status { get; set; }

        [StringLength(50)]
        public string NumSerie { get; set; }

        [StringLength(50)]
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string UME { get; set; }

        public string UMS { get; set; }

        public float Factor { get; set; }

        public string ClaveProdServ { get; set; }

        public bool Lote { get; set; }

        public bool Fraccionable { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        public Guid EntiOrgContId { get; set; }

        public EntiOrgCont EntiOrgCont { get; set; }

        public Existencia ExistenciaInv { get; set; }

        //public CodAltInv CodAlt { get; set; }

        public Ubicacion UbicacionInv { get; set; }

        public Caracteristica Caracteristicas { get; set; }

        public InveProv InveProvs { get; set; }
    }
}
