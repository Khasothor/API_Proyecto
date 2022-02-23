using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Inve
{
    public class InveProv
    {
        public InveProv()
        {
            InveProvId = Guid.NewGuid();
        }

        [Key]
        public Guid InveProvId { get; set; }

        public string InveProvJson { get; set; }
        
        public Guid ProvFK { get; set; }
        [JsonIgnore]
        public virtual Inventario Inv { get; set; }

        public Guid EntiOrgContId { get; set; }
    }
}
