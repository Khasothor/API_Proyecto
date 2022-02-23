using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Infra
{
    public class EntiOrgFact
    {
        [Key]
        public Guid EntiOrgId { get; set; }

        [Required]
        [StringLength(80)]
        public string RazonSocial { get; set; }//facturacion

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }//facturacion

        public string CodigoSAT { get; set; }//facturacion

        public string Regimen { get; set; }

        public Guid EntiOrgContId { get; set; }
        [JsonIgnore]
        public EntiOrgCont EntiOrgCont { get; set; }

    }
}
