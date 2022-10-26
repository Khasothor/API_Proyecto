using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data;
using WebApi2.Models.Persona;

namespace WebApi2.Controllers.Persona
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [Route("[action]/{entiOrgId}")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios(string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);

            var x = await _context.Usuarios.Where(x => x.EntiOrgContId.Equals(guid)).ToListAsync();

            if (x == null)
            {
                return NotFound();
            }

            return x;
        }

        // GET: api/Usuarios/5
        [Route("[action]/{entiOrgId}/{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id, string EntiOrgId)
        {
            Guid guid = Guid.Parse(EntiOrgId);

            var x = await _context.Usuarios.Where(x => x.EntiOrgContId.Equals(guid)).FirstOrDefaultAsync();

            if (x == null)
            {
                return NotFound();
            }

            return x;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.UsuarioId)
            {
                return BadRequest();
            }

            PermisoUsuario pu = _context.PermisosUsuario.FirstOrDefault(x => x.PermisoUsuarioFK.Equals(id));

            if (pu == null)
            {
                return BadRequest();
            }

            _context.Entry(pu).Entity.Permiso = usuario.PermisoUsuario_.Permiso;

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.UsuarioId }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.UsuarioId == id);
        }
    }
}
