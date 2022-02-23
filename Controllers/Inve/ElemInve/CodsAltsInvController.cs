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
    public class CodsAltsInvController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CodsAltsInvController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<CodAltInv>>> GetCodsAltInv(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.CodsAltInv.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }
        // GET: api/CodsAltsInv/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CodAltInv>> GetCodAltInv(string id)
        //{
        //    Guid guid = Guid.Parse(id);

        //    var y = await _context.CodsAltInv.Where(x => x.CodAltFK == guid).FirstAsync();

        //    if (y == null)
        //    {
        //        return NotFound();
        //    }

        //    return y;
        //}

        // PUT: api/CodsAltsInv/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCodAltInv(string id, CodAltInv x)
        {
            Guid guidid = Guid.Parse(id);
            if (guidid != x.CodAltFK)
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
                if (!CodAltInvExists(guidid))
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

        // POST: api/CodsAltsInv
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CodAltInv>> PostCodAltInv(CodAltInv x)
        {
            _context.CodsAltInv.Add(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/CodsAltsInv/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCodAltInv(string id)
        {
            Guid guidid = Guid.Parse(id);
            var x = await _context.CodsAltInv.FirstOrDefaultAsync(x => x.CodAltFK.Equals(guidid));

            if (x == null)
            {
                return NotFound();
            }

            _context.CodsAltInv.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CodAltInvExists(Guid id)
        {
            return _context.CodsAltInv.Any(e => e.CodAltFK == id);
        }
    }
}
