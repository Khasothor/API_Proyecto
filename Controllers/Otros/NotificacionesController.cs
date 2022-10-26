using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models.Otros;

namespace WebApi2.Controllers.Otros
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificacionesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NotificacionesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("[action]/{entiOrg}/{usuarioId}")]
        public async Task<ActionResult<IEnumerable<Notificacion>>> GetNotificaciones(string entiOrg, int usuarioId)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                //_ = BorrarAntiguos(entiorg_);
                return await _context.Notificaciones.Where(x => x.EntiOrgContId.Equals(entiorg_) && 
                x.UsuarioId.Equals(usuarioId)).OrderByDescending(x => x.FechaHora).Take(50).ToListAsync();
            }
            
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<Notificacion>>> GetHistorial(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                //_ = BorrarAntiguos(entiorg_);
                return await _context.Notificaciones.Where(x => x.EntiOrgContId.Equals(entiorg_)).OrderByDescending(x => x.FechaHora).ToListAsync();
            }

        }

        // POST: api/Notificaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Notificacion>> PostNotificacion(Notificacion notificacion)
        {
            _context.Notificaciones.Add(notificacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Notificaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotificacion(Guid id)
        {
            var notificacion = await _context.Notificaciones.FindAsync(id);
            if (notificacion == null)
            {
                return NotFound();
            }

            _context.Notificaciones.Remove(notificacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [Route("[action]/{entiOrgId}")]
        public async Task<IActionResult> BorrarAntiguos(string EntiOrgId, string[] notifId_list)
        {

            if (notifId_list.Length > 0)
            {
                List<Guid> lista_guid = new();

                foreach (string item in notifId_list)
                {
                    lista_guid.Add(Guid.Parse(item));
                }

                List<Notificacion> lista = await _context.Notificaciones.Where(x => lista_guid.Contains(x.NotificacionId)).ToListAsync();
                
                if (lista_guid != null)
                {
                    Guid entiorg_ = Guid.Parse(EntiOrgId);
                    _context.Notificaciones.RemoveRange(lista);
                    await _context.SaveChangesAsync();
                }
            }

            return NoContent();

        }
    }
}
