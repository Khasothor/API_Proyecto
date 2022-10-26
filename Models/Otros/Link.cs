using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models.Otros
{
    public class Link
    {
        [Key]
        public int LinkId { get; set; }

        public string Nombre { get; set; } //nombre de la pagina

        public string NomPer { get; set; } //nombre del permiso

        public string Enlace { get; set; } //link a la pagina

        public string Clasif { get; set; } //clasificacion de la aplicacion (almacenes, finanzas, mantenimiento, etc)

        public string EstaEnJson { get; set; } //el json del menu principal

        public int AyudaId { get; set; } //identificador de la ayuda
    }
}
