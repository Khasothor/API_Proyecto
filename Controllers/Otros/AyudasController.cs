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
    public class AyudasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AyudasController(ApplicationDbContext context)
        {
            _context = context;
        }

        //// GET: api/Ayudas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ayuda>>> GetAyudas()
        {
            return await _context.Ayudas.ToListAsync();
        }

        // GET: api/Ayudas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ayuda>> GetAyuda(int id)
        {
            var ayuda = await _context.Ayudas.FindAsync(id);

            if (ayuda == null)
            {
                return NotFound();
            }

            return ayuda;
        }

        // PUT: api/Ayudas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAyuda(int id, Ayuda ayuda)
        //{
        //    if (id != ayuda.AyudaId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(ayuda).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AyudaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Ayudas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Ayuda>> PostAyuda(Ayuda ayuda)
        //{
        //    _context.Ayudas.Add(ayuda);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAyuda", new { id = ayuda.AyudaId }, ayuda);
        //}

        // DELETE: api/Ayudas/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAyuda(int id)
        //{
        //    var ayuda = await _context.Ayudas.FindAsync(id);
        //    if (ayuda == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Ayudas.Remove(ayuda);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AyudaExists(int id)
        //{
        //    return _context.Ayudas.Any(e => e.AyudaId == id);
        //}
    }
}
