using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models.Persona
{
    public class ConfigUsuario
    {
        [Key]
        public int ConfigUsuarioId { get; set; }

        public bool PuntoComa { get; set; } // Determina el formato de separador de listas y cantidades. True=Punto False=Coma

        public string Temas { get; set; } //combinacion de colores de la aplicacion

        public string FormatoFecha { get; set; } //esteblece el formato de la fecha: dd/mm/aa, mm/dd/aa, aa/mm/dd

        public Guid EntiOrgContId { get; set; }
    }
}
