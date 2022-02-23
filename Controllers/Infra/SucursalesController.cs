using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public class SucursalesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SucursalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<Sucursal>>> GetSucursales(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.Sucursales.Where(suc => suc.EntiOrgId.Equals(entiorg_)).ToListAsync();
            }
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Sucursal>> GetSucursal(string EntiOrgId, int id)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var sucursal = await _context.Sucursales.Where(x => x.SucursalId == id && x.EntiOrgId.Equals(guid)).FirstAsync();

            if (sucursal == null)
            {
                return NotFound();
            }

            return sucursal;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutSucursal(int id, Sucursal sucursal, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (id != sucursal.SucursalId && guid != sucursal.EntiOrgId)
            {
                return BadRequest();
            }

            _context.Entry(sucursal).State = EntityState.Modified;
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SucursalExists(id, guid))
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
        public async Task<ActionResult<Sucursal>> PostSucursal(Sucursal sucursal)
        {
            bool existe = _context.Sucursales.Any(x => x.Codigo.Equals(sucursal.Codigo) && x.EntiOrgId.Equals(sucursal.EntiOrgId));

            if (existe)
            {
                return StatusCode(304);
            }

            _context.Sucursales.Add(sucursal);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Sucursal>> DeleteSucursal(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var sucursal = await _context.Sucursales.FirstOrDefaultAsync(x => x.SucursalId.Equals(id) && x.EntiOrgId.Equals(guid));

            if (sucursal == null)
            {
                return NotFound();
            }

            _context.Sucursales.Remove(sucursal);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool SucursalExists(int id, Guid guid)
        {
            return _context.Sucursales.Any(e => e.SucursalId == id && e.EntiOrgId == guid);
        }
    }
}
