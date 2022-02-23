using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebApi2.Models.Infra;

namespace WebApi2.Models.Otros
{
    public class UniMed
    {
        [Key]
        public int UniMedId { get; set; }
        public string UnidadMedida { get; set; }
        public string UnidadMedidaOf { get; set; }
        public Guid EntiOrgContId { get; set; }
        [JsonIgnore]
        public EntiOrgCont EntiOrgCont { get; set; }
    }
}
