using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Inve
{
    public class Existencia
    {
        public Existencia()
        {
            ExistenciaId = Guid.NewGuid();
        }

        [Key]
        public Guid ExistenciaId { get; set; }

        public string ExistenciaJson { get; set; }
        
        public Guid ExistFK { get; set; }
        [JsonIgnore]
        public virtual Inventario Inv { get; set; }

        public Guid EntiOrgContId { get; set; }
    }
}
