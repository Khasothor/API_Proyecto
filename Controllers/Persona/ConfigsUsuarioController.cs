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
    public class ConfigsUsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConfigsUsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<ConfigUsuario>> GetConfigUsuario(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);

            var y = await _context.ConfiguracionUsuario.Where(x => x.ConfigUsuarioId == id && x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (y == null)
            {
                return NotFound();
            }

            return y;
        }


        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutConfigUsuario(int id, ConfigUsuario x, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (id != x.ConfigUsuarioId && guid != x.EntiOrgContId)
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
                if (!ConfigUsuarioExists(id, guid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ConfigUsuario>> PostConfigUsuario(ConfigUsuario x)
        {
            _context.ConfiguracionUsuario.Add(x);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<ConfigUsuario>> DeleteConfigUsuario(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var x = await _context.ConfiguracionUsuario.FirstOrDefaultAsync(x => x.ConfigUsuarioId.Equals(id) && x.EntiOrgContId.Equals(guid));

            if (x == null)
            {
                return NotFound();
            }

            _context.ConfiguracionUsuario.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConfigUsuarioExists(int id, Guid guid)
        {
            return _context.ConfiguracionUsuario.Any(e => e.ConfigUsuarioId == id && e.EntiOrgContId == guid);
        }
    }
}
