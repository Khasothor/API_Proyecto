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
    public class ExistenciasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExistenciasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<Existencia>>> GetExistencias(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.Existencias.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }
        //// GET: api/Existencias/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Existencia>> GetExistencia(string id)
        //{
        //    Guid guid = Guid.Parse(id);

        //    var y = await _context.Existencias.Where(x => x.ExistFK == guid).FirstAsync();

        //    if (y == null)
        //    {
        //        return NotFound();
        //    }

        //    return y;
        //}

        [HttpPut("{id}")]
        public async Task<IActionResult> PutExistencia(string id, Existencia x)
        {
            Guid guidid = Guid.Parse(id);
            if (guidid != x.ExistFK)
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
                if (!ExistenciaExists(guidid))
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
        public async Task<ActionResult<Existencia>> PostExistencia(Existencia x)
        {
            _context.Existencias.Add(x);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExistencia", new { id = x.ExistenciaId }, x);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExistencia(string id)
        {
            Guid guidid = Guid.Parse(id);
            var x = await _context.Existencias.FirstOrDefaultAsync(x => x.ExistFK.Equals(guidid));

            if (x == null)
            {
                return NotFound();
            }

            _context.Existencias.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExistenciaExists(Guid guidid)
        {
            
            return _context.Existencias.Any(e => e.ExistFK == guidid);
        }
    }
}
