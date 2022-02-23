using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Inve
{
    public class Ubicacion
    {
        public Ubicacion()
        {
            UbicacionId = Guid.NewGuid();
        }

        [Key]
        public Guid UbicacionId { get; set; }

        public string UbicacionJson { get; set; }
        
        public Guid UbiFK { get; set; }
        [JsonIgnore]
        public virtual Inventario Inv { get; set; }
        
        public Guid EntiOrgContId { get; set; }
    }
}
