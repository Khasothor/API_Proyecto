using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebApi2.Models.Infra;

namespace WebApi2.Models.Otros
{
    public class ClaveProdServ
    {
        [Key]
        public int ClaveProdServId { get; set; }

        public string ClaveProdJson { get; set; }

        public string ClaveServJson { get; set; }

        [Required]
        public Guid EntiOrgContId { get; set; }

        [JsonIgnore]
        public EntiOrgCont EntiOrgCont { get; set; }
    }
}
