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
        public ICollection<HistoriaEntradaSalida> HistoriaEntradaSalidas { get; set; } // historial de entradas y salidas

        [JsonIgnore]
        public ICollection<EntradaSalida> EntradasSalidas { get; set; } // historial de entradas y salidas

        [JsonIgnore]
        public ICollection<Shortcut> Shortcuts { get; set; } // atajos

        //----------Uno a uno
        [JsonIgnore]
        public TipoDocInv TipoDocsInv { get; set; } //tipo de documentos de inventario
        //public ICollection<TipoDocInv> TipoDocsInv { get; set; } // tipo de documentos de inventario

        [JsonIgnore]
        public ConfigGen ConfigsGen { get; set; } // Configuraciones generales
        //public ICollection<ConfigGen> ConfigsGen { get; set; } // Configuraciones generales

        [JsonIgnore]
        public UniMed UniMeds { get; set; } // Configuraciones generales
        //public ICollection<UniMed> UniMeds { get; set; } //unidades de medida
    }
}
