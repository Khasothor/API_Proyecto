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
        public async Task<ActionResult<IEnumerable<TipoDocInv>>> GetTipoDocs(string EntiOrgId)
        {
            if (EntiOrgId == null || EntiOrgId == "")
            {
                return NotFound();
            }
            else
            {
                Guid guid = Guid.Parse(EntiOrgId);
                return await _context.TipoDocsInv.Where(x => x.EntiOrgContId.Equals(guid)).ToListAsync();
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutTipoDocInv(TipoDocInv tipoDocInv, int? id)
        {
            _context.Entry(tipoDocInv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDocInvExists(id))
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

        [Route("[action]/{id}")]
        public async Task<ActionResult<TipoDocInv>> DeleteTipoDocInv(int id)
        {
            var tdi = await _context.TipoDocsInv.FirstOrDefaultAsync(x => x.TipoDocInvId.Equals(id));

            if (tdi == null)
            {
                return NotFound();
            }

            _context.TipoDocsInv.Remove(tdi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoDocInvExists(int? id)
        {
            return _context.TipoDocsInv.Any(e => e.TipoDocInvId == id);
        }
    }
}
