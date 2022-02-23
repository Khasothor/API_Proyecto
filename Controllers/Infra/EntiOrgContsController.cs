using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models.Infra;

namespace WebApi2.Controllers.Infra
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntiOrgContsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntiOrgContsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EntiOrgConts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntiOrgCont>>> GetEntiOrgsCont()
        {
            return await _context.EntiOrgsCont.ToListAsync();
        }

        // GET: api/EntiOrgConts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntiOrgCont>> GetEntiOrgCont(Guid id)
        {
            var entiOrgCont = await _context.EntiOrgsCont.FindAsync(id);

            if (entiOrgCont == null)
            {
                return NotFound();
            }

            return entiOrgCont;
        }

        // PUT: api/EntiOrgConts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntiOrgCont(Guid id, EntiOrgCont entiOrgCont)
        {
            if (id != entiOrgCont.EntiOrgContId)
            {
                return BadRequest();
            }

            _context.Entry(entiOrgCont).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntiOrgContExists(id))
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

        // POST: api/EntiOrgConts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EntiOrgCont>> PostEntiOrgCont(EntiOrgCont entiOrgCont)
        {
            _context.EntiOrgsCont.Add(entiOrgCont);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/EntiOrgConts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EntiOrgCont>> DeleteEntiOrgCont(Guid id)
        {
            var entiOrgCont = await _context.EntiOrgsCont.FindAsync(id);
            if (entiOrgCont == null)
            {
                return NotFound();
            }

            _context.EntiOrgsCont.Remove(entiOrgCont);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntiOrgContExists(Guid id)
        {
            return _context.EntiOrgsCont.Any(e => e.EntiOrgContId == id);
        }
    }
}
