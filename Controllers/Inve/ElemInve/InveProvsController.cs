using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models.Inve;

namespace WebApi2.Controllers.Inve.ElemInve
{
    [Route("api/[controller]")]
    [ApiController]
    public class InveProvsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InveProvsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<InveProv>>> GetInveProvs(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.InveProvs.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }
        // GET: api/InveProvs/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<InveProv>> GetInveProv(string id)
        //{
        //    Guid guid = Guid.Parse(id);

        //    var y = await _context.InveProvs.Where(x => x.ProvFK == guid).FirstAsync();

        //    if (y == null)
        //    {
        //        return NotFound();
        //    }

        //    return y;
        //}

        // PUT: api/InveProvs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInveProv(string id, InveProv x)
        {
            Guid guidid = Guid.Parse(id);
            if (guidid != x.ProvFK)
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
                if (!InveProvExists(guidid))
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

        // POST: api/InveProvs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<InveProv>> PostInveProv(InveProv x)
        //{
        //    _context.InveProvs.Add(x);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetInveProv", new { id = x.InveProvId }, x);
        //}

        // DELETE: api/InveProvs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteInveProv(string id)
        //{
        //    Guid guidid = Guid.Parse(id);
        //    var x = await _context.InveProvs.FirstOrDefaultAsync(x => x.ProvFK.Equals(guidid));

        //    if (x == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.InveProvs.Remove(x);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool InveProvExists(Guid id)
        {
            return _context.InveProvs.Any(e => e.ProvFK == id);
        }
    }
}
