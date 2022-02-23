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
    public class EntiOrgFactsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntiOrgFactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EntiOrgFacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntiOrgFact>>> GetEntiOrgsFact()
        {
            return await _context.EntiOrgsFact.ToListAsync();
        }

        // GET: api/EntiOrgFacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntiOrgFact>> GetEntiOrgFact(Guid id)
        {
            var entiOrgFact = await _context.EntiOrgsFact.FindAsync(id);

            if (entiOrgFact == null)
            {
                return NotFound();
            }

            return entiOrgFact;
        }

        // PUT: api/EntiOrgFacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntiOrgFact(Guid id, EntiOrgFact entiOrgFact)
        {
            if (id != entiOrgFact.EntiOrgId)
            {
                return BadRequest();
            }

            _context.Entry(entiOrgFact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntiOrgFactExists(id))
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

        // POST: api/EntiOrgFacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EntiOrgFact>> PostEntiOrgFact(EntiOrgFact entiOrgFact)
        {
            _context.EntiOrgsFact.Add(entiOrgFact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/EntiOrgFacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntiOrgFact(Guid id)
        {
            var entiOrgFact = await _context.EntiOrgsFact.FindAsync(id);
            if (entiOrgFact == null)
            {
                return NotFound();
            }

            _context.EntiOrgsFact.Remove(entiOrgFact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntiOrgFactExists(Guid id)
        {
            return _context.EntiOrgsFact.Any(e => e.EntiOrgId == id);
        }
    }
}
