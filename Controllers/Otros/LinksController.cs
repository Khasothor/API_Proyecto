﻿using System;
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
    public class LinksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LinksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Links
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Link>>> GetLink()
        {
            return await _context.Link.ToListAsync();
        }

        // GET: api/Links/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Link>> GetLink(int id)
        //{
        //    var link = await _context.Link.FindAsync(id);

        //    if (link == null)
        //    {
        //        return NotFound();
        //    }

        //    return link;
        //}

        // PUT: api/Links/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutLink(int id, Link link)
        //{
        //    if (id != link.LinkId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(link).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LinkExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Links
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Link>> PostLink(Link link)
        //{
        //    _context.Link.Add(link);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetLink", new { id = link.LinkId }, link);
        //}

        // DELETE: api/Links/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLink(int id)
        //{
        //    var link = await _context.Link.FindAsync(id);
        //    if (link == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Link.Remove(link);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool LinkExists(int id)
        //{
        //    return _context.Link.Any(e => e.LinkId == id);
        //}
    }
}
