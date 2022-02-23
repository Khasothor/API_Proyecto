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
    public class ClavesProdServController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClavesProdServController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrgId}")]
        public async Task<ActionResult<ClaveProdServ>> GetClaveProdServ(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var cps = await _context.ClavesProdServ.Where(x => x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (cps == null)
            {
                return NotFound();
            }

            return cps;
        }

        [HttpPut("[action]/{entiOrgId}")]
        public async Task<IActionResult> PutClaveProdServ(ClaveProdServ cps, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (guid != cps.EntiOrgContId)
            {
                return BadRequest();
            }

            _context.Entry(cps).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaveProdServExists(guid))
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
        public async Task<ActionResult<ClaveProdServ>> PostClaveProdServ(ClaveProdServ cps)
        {
            _context.ClavesProdServ.Add(cps);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}")]
        public async Task<ActionResult<ClaveProdServ>> DeleteClaveProdServ(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var cps = await _context.ClavesProdServ.FirstOrDefaultAsync(x => x.EntiOrgContId.Equals(guid));

            if (cps == null)
            {
                return NotFound();
            }

            _context.ClavesProdServ.Remove(cps);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClaveProdServExists(Guid guid)
        {
            return _context.UnidadesMedida.Any(e => e.EntiOrgContId == guid);
        }
    }
}
