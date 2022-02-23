using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi2.Models.Inve
{
    public class HistoriaEntradaSalida
    {
        [Key]
        public int HistoriaEntradaSalidaId { get; set; }

        public string HistoriaEntradaSalidaJson { get; set; }

        [Required]
        public Guid EntiOrgContId { get; set; }

        [JsonIgnore]
        public Guid EntiOrgCont { get; set; }
    }
}
