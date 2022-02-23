using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models.Persona;

namespace WebApi2.Controllers.Persona
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClieProvsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClieProvsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<ClieProv>>> GetClieProvs(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.ClieProvs.Where(clieprov => clieprov.EntiOrgId.Equals(entiorg_)).ToListAsync();
            }
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<ClieProv>> GetClieProv(string EntiOrgId, int id)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var almaruta = await _context.ClieProvs.Where(x => x.ClieprovId == id && x.EntiOrgId.Equals(guid)).FirstAsync();

            if (almaruta == null)
            {
                return NotFound();
            }

            return almaruta;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutClieProv(int id, ClieProv clieProv, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (id != clieProv.ClieprovId && guid != clieProv.EntiOrgId)
            {
                return BadRequest();
            }

            _context.Entry(clieProv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClieProvExists(id, guid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<ClieProv>> PostClieProv(ClieProv clieProv)
        {
            bool existe = _context.ClieProvs.Any(x => x.Codigo.Equals(clieProv.Codigo) && x.EntiOrgId.Equals(clieProv.EntiOrgId));

            if (existe)
            {
                return StatusCode(304);
            }

            _context.ClieProvs.Add(clieProv);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<ClieProv>> DeleteClieProv(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var clieProv = await _context.ClieProvs.FirstOrDefaultAsync(x => x.ClieprovId.Equals(id) && x.EntiOrgId.Equals(guid));

            if (clieProv == null)
            {
                return NotFound();
            }

            _context.ClieProvs.Remove(clieProv);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool ClieProvExists(int id, Guid guid)
        {
            return _context.ClieProvs.Any(e => e.ClieprovId == id && e.EntiOrgId == guid);
        }
    }
}
