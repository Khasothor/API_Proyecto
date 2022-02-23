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
    public class CaracteristicasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CaracteristicasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<Caracteristica>>> GetCaracteristicas(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.Caracteristicas.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }
        // GET: api/Caracteristicas/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Caracteristica>> GetCaracteristica(string id)
        //{
        //    Guid guid = Guid.Parse(id);

        //    var y = await _context.Caracteristicas.Where(x => x.CaractFK == guid).FirstAsync();

        //    if (y == null)
        //    {
        //        return NotFound();
        //    }

        //    return y;
        //}

        // PUT: api/Caracteristicas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaracteristica(string id, Caracteristica x)
        {
            Guid guidid = Guid.Parse(id);
            if (guidid != x.CaractFK)
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
                if (!CaracteristicaExists(guidid))
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

        // POST: api/Caracteristicas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Caracteristica>> PostCaracteristica(Caracteristica x)
        {
            _context.Caracteristicas.Add(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Caracteristicas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaracteristica(string id)
        {
            Guid guidid = Guid.Parse(id);
            var x = await _context.Caracteristicas.FirstOrDefaultAsync(x => x.CaractFK.Equals(guidid));

            if (x == null)
            {
                return NotFound();
            }

            _context.Caracteristicas.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CaracteristicaExists(Guid id)
        {
            return _context.Caracteristicas.Any(e => e.CaractFK == id);
        }
    }
}
