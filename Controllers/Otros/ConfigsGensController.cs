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
    public class ConfigsGensController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConfigsGensController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrgId}")]
        public async Task<ActionResult<ConfigGen>> GetConfigGen(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var configGen = await _context.ConfigsGen.Where(x => x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (configGen == null)
            {
                return NotFound();
            }

            return configGen;
        }

        [HttpPut("[action]/{entiOrgId}")]
        public async Task<IActionResult> PutConfigGen(ConfigGen cg, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (guid != cg.EntiOrgContId)
            {
                return BadRequest();
            }

            _context.Entry(cg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfigGenExists(guid))
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
        public async Task<ActionResult<ConfigGen>> PostConfigGen(ConfigGen cg)
        {
            _context.ConfigsGen.Add(cg);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}")]
        public async Task<ActionResult<ConfigGen>> DeleteConfigGen(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var cg = await _context.ConfigsGen.FirstOrDefaultAsync(x => x.EntiOrgContId.Equals(guid));

            if (cg == null)
            {
                return NotFound();
            }

            _context.ConfigsGen.Remove(cg);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConfigGenExists(Guid guid)
        {
            return _context.ConfigsGen.Any(e => e.EntiOrgContId == guid);
        }


    }
}
