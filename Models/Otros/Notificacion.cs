using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi2.Models.Otros
{
    public class Notificacion
    {
        public Notificacion()
        {
            NotificacionId = Guid.NewGuid();
            FechaHora = DateTime.UtcNow;
        }
        [Key]
        public Guid NotificacionId { get; set; }

        public int Tipo { get; set; }

        public int Accion { get; set; }

        public DateTime FechaHora { get; set; }

        public int SucOrigen { get; set; }

        public int SucDestino { get; set; }

        public int ArOrigen { get; set; }

        public int ArDestino { get; set; }

        public string ObjetoJson { get; set; }

        public string Tabla { get; set; }

        public int UsuarioId { get; set; }

        public Guid EntiOrgContId { get; set; }
    }
}
