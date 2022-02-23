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
    public class UbicacionesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UbicacionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<Ubicacion>>> GetUbicaciones(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.Ubicaciones.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }
        // GET: api/Ubicaciones/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Ubicacion>> GetUbicacion(string id)
        //{
        //    Guid guid = Guid.Parse(id);

        //    var y = await _context.Ubicaciones.Where(x => x.UbiFK == guid).FirstAsync();

        //    if (y == null)
        //    {
        //        return NotFound();
        //    }

        //    return y;
        //}

        // PUT: api/Ubicaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUbicacion(string id, Ubicacion x)
        {
            Guid guidid = Guid.Parse(id);
            if (guidid != x.UbiFK)
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
                if (!UbicacionExists(guidid))
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

        // POST: api/Ubicaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ubicacion>> PostUbicacion(Ubicacion x)
        {
            _context.Ubicaciones.Add(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Ubicaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUbicacion(string id)
        {
            Guid guidid = Guid.Parse(id);
            var x = await _context.Ubicaciones.FirstOrDefaultAsync(x => x.UbiFK.Equals(guidid));

            if (x == null)
            {
                return NotFound();
            }

            _context.Ubicaciones.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UbicacionExists(Guid id)
        {
            return _context.Ubicaciones.Any(e => e.UbiFK == id);
        }
    }
}
