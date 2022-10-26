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
    public class TestsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]/{entiOrgContId}")]
        public async Task<ActionResult<IEnumerable<Test>>> ObtenerTest(string entiOrgContId)
        {
            Console.WriteLine("DATO: " + entiOrgContId + " !!!!!!!!");
            return await _context.Tests.Where(x => x.EntiOrgContId.Equals(entiOrgContId)).ToListAsync();
            //return await _context.Test.ToListAsync();
        }

        [Route("[action]/")]
        public async Task<IActionResult> ModificarTest(Test test)
        {
            if (test == null)
            {
                return BadRequest();
            }

            _context.Entry(test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestExists(test.TestId))
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

        // POST: api/Tests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Test>> AgregarTest(Test test)
        {
            _context.Test.Add(test);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTest", new { id = test.TestId }, test);
        }

        // DELETE: api/Tests/5
        [Route("[action]/{testId}")]
        public async Task<IActionResult> BorrarTest(string testId)
        {
            var test = await _context.Test.FindAsync(testId);
            if (test == null)
            {
                return NotFound();
            }

            _context.Test.Remove(test);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestExists(uint id)
        {
            return _context.Test.Any(e => e.TestId == id);
        }
    }
}
