using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models.Inve;

namespace WebApi2.Controllers.Inve
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasSalidasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntradasSalidasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<EntradaSalida>>> GetEntradasSalidas(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.EntradasSalidas.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<EntradaSalida>> GetEntradaSalida(string EntiOrgId, string id)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            Guid guidid = Guid.Parse(id);
            var y = await _context.EntradasSalidas.Where(x => x.EntradaSalidaId == guidid && x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (y == null)
            {
                return NotFound();
            }

            return y;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutEntradaSalida(string id, EntradaSalida x, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            Guid guidid = Guid.Parse(id);
            if (guidid != x.EntradaSalidaId && guid != x.EntiOrgContId)
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
                if (!EntradaSalidaExists(id, EntiOrgId))
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
        public async Task<ActionResult<EntradaSalida>> PostEntradaSalida(EntradaSalida x)
        {
            bool existe = _context.EntradasSalidas.Any(x => x.Folio.Equals(x.Folio) && x.EntiOrgContId.Equals(x.EntiOrgContId));

            if (existe)
            {
                return StatusCode(304);
            }

            _context.EntradasSalidas.Add(x);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<EntradaSalida>> DeleteEntradaSalida(string id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            Guid guidid = Guid.Parse(id);
            var x = await _context.EntradasSalidas.FirstOrDefaultAsync(x => x.EntradaSalidaId.Equals(guidid) && x.EntiOrgContId.Equals(guid));

            if (x == null)
            {
                return NotFound();
            }

            _context.EntradasSalidas.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntradaSalidaExists(string id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            Guid guidid = Guid.Parse(id);
            return _context.EntradasSalidas.Any(e => e.EntradaSalidaId == guidid && e.EntiOrgContId == guid);
        }
    }
}
