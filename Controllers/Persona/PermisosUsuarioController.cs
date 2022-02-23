using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models.Persona;

namespace WebApi2.Controllers.Persona
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisosUsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PermisosUsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<PermisoUsuario>> GetPermisoUsuario(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            //Guid guidId = Guid.Parse(id);
            var y = await _context.PermisosUsuario.Where(x => x.DatoUsuarioId == id && x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (y == null)
            {
                return NotFound();
            }

            return y;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutPermisoUsuario(int id, PermisoUsuario x, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (id != x.PermisoUsuarioId && guid != x.EntiOrgContId)
            {
                return BadRequest();
            }

            _context.Entry(x).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PermisoUsuarioExists(id, guid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<PermisoUsuario>> PostPermisoUsuario(PermisoUsuario x)
        {
            _context.PermisosUsuario.Add(x);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<PermisoUsuario>> DeletePermisoUsuario(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var x = await _context.PermisosUsuario.FirstOrDefaultAsync(x => x.PermisoUsuarioId.Equals(id) && x.EntiOrgContId.Equals(guid));

            if (x == null)
            {
                return NotFound();
            }

            _context.PermisosUsuario.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PermisoUsuarioExists(int id, Guid guid)
        {
            return _context.PermisosUsuario.Any(e => e.PermisoUsuarioId == id && e.EntiOrgContId == guid);
        }
    }
}
