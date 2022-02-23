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
    public class HistoriaEntradasSalidasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HistoriaEntradasSalidasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<HistoriaEntradaSalida>>> GetHess(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.HistoriaEntradaSalidas.Where(x => x.HistoriaEntradaSalidaId.Equals(entiorg_)).ToListAsync();
            }
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<HistoriaEntradaSalida>> GetHes(string EntiOrgId, int id)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            //Guid guidid = Guid.Parse(id);
            var y = await _context.HistoriaEntradaSalidas.Where(x => x.HistoriaEntradaSalidaId == id && x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (y == null)
            {
                return NotFound();
            }

            return y;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutHes(int id, HistoriaEntradaSalida x, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            //Guid guidid = Guid.Parse(id);
            if (id != x.HistoriaEntradaSalidaId && guid != x.EntiOrgContId)
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
                if (!HistoriaEntradaSalidaExists(id, EntiOrgId))
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
        public async Task<ActionResult<HistoriaEntradaSalida>> PostHes(HistoriaEntradaSalida x)
        {
            _context.HistoriaEntradaSalidas.Add(x);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<HistoriaEntradaSalida>> DeleteHes(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            //Guid guidid = Guid.Parse(id);
            var x = await _context.HistoriaEntradaSalidas.FirstOrDefaultAsync(x => x.HistoriaEntradaSalidaId.Equals(id) && x.EntiOrgContId.Equals(guid));

            if (x == null)
            {
                return NotFound();
            }

            _context.HistoriaEntradaSalidas.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HistoriaEntradaSalidaExists(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            //Guid guidid = Guid.Parse(id);
            return _context.HistoriaEntradaSalidas.Any(e => e.HistoriaEntradaSalidaId == id && e.EntiOrgContId == guid);
        }
    }
}
