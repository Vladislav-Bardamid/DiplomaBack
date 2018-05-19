using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiplomaBack.DAL.Entities;
using DiplomaBack.DAL.EntityFrameworkCore;

namespace DiplomaBack.Controllers
{
    [Produces("application/json")]
    [Route("api/Lessons")]
    public class LessonsController : Controller
    {
        private readonly DataBaseContext _context;

        public LessonsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Lessons
        [HttpGet]
        public IEnumerable<Lesson> GetLessons()
        {
            return _context.Lessons;
        }

        // GET: api/Lessons/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLesson([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lesson = await _context.Lessons.SingleOrDefaultAsync(m => m.Id == id);

            if (lesson == null)
            {
                return NotFound();
            }

            return Ok(lesson);
        }

        // PUT: api/Lessons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLesson([FromRoute] int id, [FromBody] Lesson lesson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lesson.Id)
            {
                return BadRequest();
            }

            _context.Entry(lesson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessonExists(id))
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

        // POST: api/Lessons
        [HttpPost]
        public async Task<IActionResult> PostLesson([FromBody] Lesson lesson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Lessons.Add(lesson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLesson", new { id = lesson.Id }, lesson);
        }

        // DELETE: api/Lessons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLesson([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lesson = await _context.Lessons.SingleOrDefaultAsync(m => m.Id == id);
            if (lesson == null)
            {
                return NotFound();
            }

            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();

            return Ok(lesson);
        }

        private bool LessonExists(int id)
        {
            return _context.Lessons.Any(e => e.Id == id);
        }
    }
}