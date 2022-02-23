using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebApi2.Models.Infra;

namespace WebApi2.Models.Inve
{
    public class EntradaSalida
    {
        public EntradaSalida()
        {
            EntradaSalidaId = Guid.NewGuid();
            Fecha = DateTime.UtcNow;
        }
        [Key]
        public Guid EntradaSalidaId { get; set; }

        public string Folio { get; set; }

        public DateTime Fecha { get; set; }

        public string TipoDocInv { get; set; }

        public string EntradaSalidaJson { get; set; }

        public int UsuarioId { get; set; }

        public int ClieProvId { get; set; }

        public int AlmaRutaId { get; set; }

        public int SucursalId { get; set; }

        [Required]
        public Guid EntiOrgContId { get; set; }

        [JsonIgnore]
        public EntiOrgCont EntiOrgCont { get; set; }
    }
}
