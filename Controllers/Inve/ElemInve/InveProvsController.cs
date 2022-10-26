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
            if (guidid != x.InveProvId)
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


        private bool InveProvExists(Guid id)
        {
            return _context.InveProvs.Any(e => e.ProvFK == id);
        }
    }
}
