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
    public class HorariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HorariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrg}")]
        public async Task<ActionResult<IEnumerable<Horario>>> GetHorarios(string entiOrg)
        {
            if (entiOrg == null || entiOrg == "")
            {
                return NotFound();
            }
            else
            {
                Guid entiorg_ = Guid.Parse(entiOrg);
                return await _context.Horarios.Where(x => x.EntiOrgContId.Equals(entiorg_)).ToListAsync();
            }
        }

        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Horario>> GetHorario(string EntiOrgId, int id)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var horario = await _context.Horarios.Where(x => x.HorarioId == id && x.EntiOrgContId.Equals(guid)).FirstAsync();

            if (horario == null)
            {
                return NotFound();
            }

            return horario;
        }

        [HttpPut("[action]/{entiOrgId}/{id}")]
        public async Task<IActionResult> PutHorario(int id, Horario horario, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            if (id != horario.HorarioId && guid != horario.EntiOrgContId)
            {
                return BadRequest();
            }

            _context.Entry(horario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HorarioExists(id, guid))
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
        public async Task<ActionResult<Horario>> PostHorario(Horario horario)
        {
            bool existe = _context.Horarios.Any(x => x.Codigo.Equals(horario.Codigo) && x.EntiOrgContId.Equals(horario.EntiOrgContId));

            if (existe)
            {
                return StatusCode(304);
            }
            _context.Horarios.Add(horario);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Horario>> DeleteHorario(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);
            var horario = await _context.Horarios.FirstOrDefaultAsync(x => x.HorarioId.Equals(id) && x.EntiOrgContId.Equals(guid));

            if (horario == null)
            {
                return NotFound();
            }

            _context.Horarios.Remove(horario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HorarioExists(int id, Guid guid)
        {
            return _context.Horarios.Any(e => e.HorarioId == id && e.EntiOrgContId == guid);
        }
    }
}
