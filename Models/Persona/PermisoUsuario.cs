using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApi2.Models.Persona
{
    public class PermisoUsuario
    {
        [Key]
        public int PermisoUsuarioId { get; set; }
        public int TiempoAcceso { get; set; }//se queda
        public string TiempoExtra { get; set; }//se queda
        public string Estado { get; set; }//se queda
        //Infra
        public string Sucursal { get; set; }
        public string Almacen { get; set; }
        public string Ruta { get; set; }
        public string EntiOrgCont { get; set; }
        public string EntiOrgFact { get; set; }
        //persona
        public string Clientes { get; set; }
        public string Proveedores { get; set; }
        public string Horario { get; set; }
        public string Usuario { get; set; }
        public string Permiso { get; set; }
        //Inve
        public string InveProv { get; set; }
        //public string Entrada { get; set; }
        //public string Salida { get; set; }
        public string Ubicacion { get; set; }
        public string Existencia { get; set; }
        public string Inventario { get; set; }
        public string TipoDocInv { get; set; }
        //otros
        public string ClaveProd { get; set; }
        public string ClaveServ { get; set; }
        public string ConfigGen { get; set; }
        public string Shortcut { get; set; }
        public string UniMedFact { get; set; }
        public string UniMedDesc { get; set; }
        public string Historial { get; set; }
        public string HistorialAct { get; set; }

        public Guid EntiOrgContId { get; set; }

        public int PermisoUsuarioFK { get; set; }

        [JsonIgnore]
        public virtual Usuario Usuario_Permiso { get; set; }
    }
}
