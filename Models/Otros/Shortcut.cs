using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApi2.Models.Infra;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models.Otros
{
    public class Shortcut
    {
        [Key]
        public int ShortcutId { get; set; }

        [Required]
        [StringLength(30)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Descrip { get; set; }

        [Required]
        [StringLength(50)]
        public string Link { get; set; }

        public Guid EntiOrgContId { get; set; }
        [JsonIgnore]
        public EntiOrgCont EntiOrgCont { get; set; }
    }
}
