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
    public class UniMedsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UniMedsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrgId}")]
        public async Task<ActionResult<UniMed>> GetUniMed(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var unimed = await _context.UnidadesMedida.Where(x => x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (unimed == null)
            {
                return NotFound();
            }

            return unimed;
        }

        [HttpPut("[action]/{entiOrgId}")]
        public async Task<IActionResult> PutUniMed(UniMed unimed, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (guid != unimed.EntiOrgContId)
            {
                return BadRequest();
            }

            _context.Entry(unimed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnimedExists(guid))
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
        public async Task<ActionResult<UniMed>> PostUnimed(UniMed unimed)
        {
            _context.UnidadesMedida.Add(unimed);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}")]
        public async Task<ActionResult<UniMed>> DeleteUnimed(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var unimed = await _context.UnidadesMedida.FirstOrDefaultAsync(x => x.EntiOrgContId.Equals(guid));

            if (unimed == null)
            {
                return NotFound();
            }

            _context.UnidadesMedida.Remove(unimed);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UnimedExists(Guid guid)
        {
            return _context.UnidadesMedida.Any(e => e.EntiOrgContId == guid);
        }
    }
}
