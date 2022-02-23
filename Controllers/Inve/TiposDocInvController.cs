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
    public class TiposDocInvController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TiposDocInvController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrgId}")]
        public async Task<ActionResult<TipoDocInv>> GetTipoDocInv(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var tdi = await _context.TipoDocsInv.Where(x => x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (tdi == null)
            {
                return NotFound();
            }

            return tdi;
        }

        [HttpPut("[action]/{entiOrgId}")]
        public async Task<IActionResult> PutTipoDocInv(TipoDocInv tipoDocInv, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (guid != tipoDocInv.EntiOrgContId)
            {
                return BadRequest();
            }

            _context.Entry(tipoDocInv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDocInvExists(guid))
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
        public async Task<ActionResult<TipoDocInv>> PostTipoDocInv(TipoDocInv tdi)
        {
            _context.TipoDocsInv.Add(tdi);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}")]
        public async Task<ActionResult<TipoDocInv>> DeleteTipoDocInv(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var tdi = await _context.TipoDocsInv.FirstOrDefaultAsync(x => x.EntiOrgContId.Equals(guid));

            if (tdi == null)
            {
                return NotFound();
            }

            _context.TipoDocsInv.Remove(tdi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoDocInvExists(Guid guid)
        {
            return _context.TipoDocsInv.Any(e => e.EntiOrgContId == guid);
        }
    }
}
