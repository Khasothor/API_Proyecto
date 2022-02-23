using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Inve
{
    public class Caracteristica
    {
        public Caracteristica()
        {
            CaracteristicaId = Guid.NewGuid();
        }

        [Key]
        public Guid CaracteristicaId { get; set; }

        public string CaracteristicaJson { get; set; }
        
        public Guid CaractFK { get; set; }
        [JsonIgnore]
        public virtual Inventario Inv { get; set; }

        public Guid EntiOrgContId { get; set; }
    }
}
