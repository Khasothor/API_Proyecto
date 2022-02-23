using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Inve
{
    public class CodAltInv
    {
        public CodAltInv()
        {
            CodAltInvId = Guid.NewGuid();
        }

        [Key]
        public Guid CodAltInvId { get; set; }

        public string CodAltInvJson { get; set; }
        
        public Guid CodAltFK { get; set; }
        [JsonIgnore]
        public virtual Inventario Inv { get; set; }

        public Guid EntiOrgContId { get; set; }
    }
}
