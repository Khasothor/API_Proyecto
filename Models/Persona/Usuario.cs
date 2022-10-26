using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApi2.Models.Infra;

namespace WebApi2.Models.Persona
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(6)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string CorreoE { get; set; }

        [StringLength(100)]
        public string Observacion { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefono { get; set; }

        public DateTime UltSesionIni { get; set; }

        public DateTime UltSesionFin { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(20)]
        public string Cargo { get; set; }

        [Required]
        public Guid EntiOrgContId { get; set; }

        [JsonIgnore]
        public EntiOrgCont EntiOrgCont { get; set; }

        [JsonIgnore]
        public PermisoUsuario PermisoUsuario_ { get; set; }

        [JsonIgnore]
        public ConfigUsuario ConfigUsuario_ { get; set; }
    }
}
