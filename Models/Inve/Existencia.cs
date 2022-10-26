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

        public string ExisAlmaJson { get; set; } //json de existencia en almacenes

        public string ExisLineJson { get; set; } //json de existencia en lineas de transporte

        public string UbicacionJson { get; set; } //json de las ubicaciones

        public string LoteJson { get; set; } //json de ubicaciones

        public string Restriccion { get; set; } //json de las restricciones

        public Guid ExistFK { get; set; }
        [JsonIgnore]
        public virtual Inventario Inv { get; set; }

        public Guid EntiOrgContId { get; set; }
    }
}
