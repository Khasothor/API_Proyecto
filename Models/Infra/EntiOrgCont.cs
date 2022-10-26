using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApi2.Models.Inve;
using WebApi2.Models.Otros;
using WebApi2.Models.Persona;

namespace WebApi2.Models.Infra
{
    public class EntiOrgCont
    {
        public EntiOrgCont()
        {
            EntiOrgContId = Guid.NewGuid();
        }
        [Key]
        public Guid EntiOrgContId { get; set; } //identificdador

        [Required]
        [StringLength(80)]
        public string Nombre { get; set; } //nombre de la entiorg

        public string DatosCont { get; set; } //datos de contacto

        [JsonIgnore]
        public EntiOrgFact DatosFactura { get; set; } //datos factura

        //-----------------------Uno a muchos-----------------------------------------------------
        [JsonIgnore]
        public ICollection<Sucursal> Sucursales { get; set; } //sucursales

        [JsonIgnore]
        public ICollection<AlmaRuta> AlmaRutas { get; set; } //almacenes y rutas

        [JsonIgnore]
        public ICollection<Horario> Horarios { get; set; } //horarios

        [JsonIgnore]
        public ICollection<Inventario> Inventarios { get; set; } //inventario

        [JsonIgnore]
        public ICollection<Shortcut> Shortcuts { get; set; } // atajos

        [JsonIgnore]
        public ICollection<TipoDocInv> TipoDocsInve { get; set; } // tipo documentos de inventario

        [JsonIgnore]
        public ICollection<ClaveProdServ> ClaveProdServs { get; set; } // tipo documentos de inventario

        [JsonIgnore]
        public ICollection<Usuario> Usuarios { get; set; } // usuarios del sistema

        //----------Uno a uno
        [JsonIgnore]
        public ConfigGen ConfigsGen { get; set; } // Configuraciones generales
        //public ICollection<ConfigGen> ConfigsGen { get; set; } // Configuraciones generales

        [JsonIgnore]
        public UniMed UniMeds { get; set; } // Configuraciones generales
        //public ICollection<UniMed> UniMeds { get; set; } //unidades de medida
    }
}
