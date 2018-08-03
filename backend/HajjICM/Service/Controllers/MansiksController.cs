using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Entity;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MansiksController : ControllerBase
    {
        private readonly DataContext _context;

        public MansiksController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Mansiks
        [HttpGet]
        public IEnumerable<Mansik> GetMansiks()
        {
            return _context.Mansiks;
        }

        // GET: api/Mansiks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMansik([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mansik = await _context.Mansiks.FindAsync(id);

            if (mansik == null)
            {
                return NotFound();
            }

            return Ok(mansik);
        }

        // PUT: api/Mansiks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMansik([FromRoute] int id, [FromBody] Mansik mansik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mansik.Id)
            {
                return BadRequest();
            }

            _context.Entry(mansik).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MansikExists(id))
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

        // POST: api/Mansiks
        [HttpPost]
        public async Task<IActionResult> PostMansik([FromBody] Mansik mansik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Mansiks.Add(mansik);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMansik", new { id = mansik.Id }, mansik);
        }

        // DELETE: api/Mansiks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMansik([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mansik = await _context.Mansiks.FindAsync(id);
            if (mansik == null)
            {
                return NotFound();
            }

            _context.Mansiks.Remove(mansik);
            await _context.SaveChangesAsync();

            return Ok(mansik);
        }

        private bool MansikExists(int id)
        {
            return _context.Mansiks.Any(e => e.Id == id);
        }
    }
}