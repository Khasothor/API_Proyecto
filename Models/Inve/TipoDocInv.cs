using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Inve
{
    public class TipoDocInv
    {
        [Key]
        public int TipoDocInvId { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public int Tipo { get; set; } // (1)Entrada, (2)Salida, (3)Bloqueo, (4)Ajuste

        [Required]
        public bool AfectaA { get; set; } //(True)Almacen, (False)Linea de Transporte

        [Required]
        public Guid EntiOrgContId { get; set; }

        [JsonIgnore]
        public Guid EntiOrgCont { get; set; }
    }
}
