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
    public class ShortcutsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShortcutsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<Shortcut>>> GetShortCuts(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.Shortcuts.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Shortcut>> GetShortcut(string EntiOrgId, int id)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            //Guid guidId = Guid.Parse(id);
            var y = await _context.Shortcuts.Where(x => x.ShortcutId == id && x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (y == null)
            {
                return NotFound();
            }

            return y;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutShortcut(int id, Shortcut x, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            //Guid guidid = Guid.Parse(id);
            if (id != x.ShortcutId && guid != x.EntiOrgContId)
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
                if (!ShortcutExists(id, EntiOrgId))
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
        public async Task<ActionResult<Shortcut>> PostShortcut(Shortcut x)
        {
            _context.Shortcuts.Add(x);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Shortcut>> DeleteShortcut(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            //Guid guidid = Guid.Parse(id);
            var x = await _context.Shortcuts.FirstOrDefaultAsync(x => x.ShortcutId.Equals(id) && x.EntiOrgContId.Equals(guid));

            if (x == null)
            {
                return NotFound();
            }

            _context.Shortcuts.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShortcutExists(int id, string x)
        {
            Guid guid = Guid.Parse(x);
            //Guid guidid = Guid.Parse(id);
            return _context.Shortcuts.Any(e => e.ShortcutId == id && e.EntiOrgContId == guid);
        }
    }
}
