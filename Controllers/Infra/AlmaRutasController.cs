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
    public class AlmaRutasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AlmaRutasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<AlmaRuta>>> GetAlmaRutas(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.AlmaRutas.Where(suc => suc.EntiOrgId.Equals(entiorg_)).ToListAsync();
            }
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<AlmaRuta>> GetAlmaRuta(string EntiOrgId, int id)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var almaruta = await _context.AlmaRutas.Where(x => x.AlmaRutaId == id && x.EntiOrgId.Equals(guid)).FirstAsync();

            if (almaruta == null)
            {
                return NotFound();
            }

            return almaruta;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutAlmaRuta(int id, AlmaRuta almaRuta, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (id != almaRuta.AlmaRutaId && guid != almaRuta.EntiOrgId)
            {
                return BadRequest();
            }

            _context.Entry(almaRuta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlmaRutaExists(id, guid))
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
        public async Task<ActionResult<AlmaRuta>> PostAlmaRuta(AlmaRuta almaRuta)
        {
            bool existe = _context.AlmaRutas.Any(x => x.Codigo.Equals(almaRuta.Codigo) && x.EntiOrgId.Equals(almaRuta.EntiOrgId));

            if (existe)
            {
                return StatusCode(304);
            }
            _context.AlmaRutas.Add(almaRuta);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<AlmaRuta>> DeleteAlmaRuta(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var almaRuta = await _context.AlmaRutas.FirstOrDefaultAsync(x => x.AlmaRutaId.Equals(id) && x.EntiOrgId.Equals(guid));

            if (almaRuta == null)
            {
                return NotFound();
            }

            _context.AlmaRutas.Remove(almaRuta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlmaRutaExists(int id, Guid guid)
        {
            return _context.AlmaRutas.Any(e => e.AlmaRutaId == id && e.EntiOrgId == guid);
        }
    }
}
