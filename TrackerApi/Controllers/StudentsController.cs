using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackerApi.Models;

namespace TrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly TrackerApiContext _context;

        public StudentsController(TrackerApiContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        // PUT: api/Students/5
        // To protect from over-posting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.StudentId)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        // POST: api/Students
        // To protect from over-posting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.StudentId }, student);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // [Route("/api/promotions")]
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Promotion>>> GetPromotions()
        // {
        //     return await _context.Promotion.ToListAsync();
        // }

        [Route("/api/promotions/{id}")]
        [HttpGet]
        public async  Task<ActionResult<Promotion>> GetPromotion(int id)
        {
            var promotion = await _context.Promotions.FindAsync(id);

            if (promotion == null)
            {
                return NotFound();
            }

            return promotion;
        }

//         [Route("/api/promotions/create")]

//         [HttpPost]
//         public ActionResult CreatePromotion(Student student, int coachId, DateTime promotionDate)
//         {
//             // #nullable enable
//             // Promotion? promotion = _context.Promotions.FirstOrDefault(join => (join.CoachId == coachId && join.StudentId == student.StudentId));
//             // #nullable disable
//             // if (promotion == null)
//             // {
//                 _context.Promotions.Add(new Promotion() { StudentId = student.StudentId, CoachId = coachId, PromotionDate = promotionDate });
//                 _context.SaveChanges();
//                 Promotion mostRecentPromotion = _context.Promotions.ToListAsync().Last();
//             // }

// //             rocking baby to sleep
//             // i listening
//             // does  api build ok ?
//             return CreatedAtAction("GetPromotion", new { id = mostRecentPromotion.PromotionId }, mostRecentPromotion);
//         }


        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
