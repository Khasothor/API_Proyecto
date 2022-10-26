using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models.Inve;

namespace WebApi2.Controllers.Inve
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InventariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<Inventario>>> GetInventarios(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.Inventarios.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Inventario>> GetInventario(string EntiOrgId, string id)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            Guid guidId = Guid.Parse(id);
            var y = await _context.Inventarios.Where(x => x.InventarioId == guidId && x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (y == null)
            {
                return NotFound();
            }

            return y;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutInventario(string id, Inventario x, string EntiOrgId)
        {

            Guid guid = Guid.Parse(EntiOrgId);
            Guid guidid = Guid.Parse(id);

            if (guidid != x.InventarioId && guid != x.EntiOrgContId)
            {

                return BadRequest();
            }

            Caracteristica caracteristica = _context.Caracteristicas.FirstOrDefault(car => car.EntiOrgContId == x.Caracteristicas.EntiOrgContId && car.CaractFK == x.InventarioId);

            if (caracteristica == null)
            {
                return BadRequest();
            }

            _context.Entry(caracteristica).Entity.CaracteristicaJson = x.Caracteristicas.CaracteristicaJson;

            _context.Entry(x).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventarioExists(id, EntiOrgId))
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
        public async Task<ActionResult<Inventario>> PostInventario(Inventario x)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool inv = _context.Inventarios.Any(xy => xy.Codigo.Equals(x.Codigo) && xy.EntiOrgContId.Equals(x.EntiOrgContId));

            if (inv == false)
            {
                _context.Inventarios.Add(x);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Inventario>> DeleteInventario(string id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            Guid guidid = Guid.Parse(id);
            var x = await _context.Inventarios.FirstOrDefaultAsync(x => x.InventarioId.Equals(guidid) && x.EntiOrgContId.Equals(guid));

            if (x == null)
            {
                return NotFound();
            }

            _context.Inventarios.Remove(x);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventarioExists(string id, string x)
        {
            Guid guid = Guid.Parse(x);
            Guid guidid = Guid.Parse(id);
            return _context.Inventarios.Any(e => e.InventarioId == guidid && e.EntiOrgContId == guid);
        }
    }
}
