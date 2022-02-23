using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApi2.Models.Infra;

namespace WebApi2.Models.Otros
{
    public class ConfigGen
    {
        [Key]
        public int GonfigGenId { get; set; }

        public int InicioFolMovInve { get; set; } // De donde comienza el contador de movimientos al inventario

        public string FormFolMovInve { get; set; } // Formato del folio de movimientos al inventario

        public string ZonasHorarias { get; set; } //Zonas horarias de las sucursales

        ///public string FactorConv { get; set; } // Configuracion para el factor de conversion

        //public bool PuntoComa { get; set; } // Determina el formato de valores en las listas. True=Punto False=Coma

        [Required]
        public Guid EntiOrgContId { get; set; }

        [JsonIgnore]
        public EntiOrgCont EntiOrgCont { get; set; }
    }
}
