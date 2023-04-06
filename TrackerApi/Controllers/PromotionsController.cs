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
    public class PromotionsController : ControllerBase
    {
        private readonly TrackerApiContext _context;

        public PromotionsController(TrackerApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Promotion>>> GetPromotions()
        {
            return await _context.Promotions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async  Task<ActionResult<Promotion>> GetPromotion(int id)
        {
            var promotion = await _context.Promotions.FindAsync(id);

            if (promotion == null)
            {
                return NotFound();
            }

            return promotion;
        }


        // [Route("/api/promotions/create")]
        [HttpPost]
        public async Task<ActionResult<Promotion>> CreatePromotion(Promotion promotion)
        {
            // #nullable enable
            // Promotion? promotion = _context.Promotions.FirstOrDefault(join => (join.PromotionId == coachId && join.StudentId == student.StudentId));
            // #nullable disable
            // if (promotion == null)
            // {
                _context.Promotions.Add(promotion);
                await _context.SaveChangesAsync();
                List<Promotion> promotionsList = await _context.Promotions.ToListAsync();
                Promotion mostRecentPromotion = promotionsList.Last();
            // }

//             rocking baby to sleep
            // i listening
            // does  api build ok ?
            return CreatedAtAction("GetPromotion", new { id = mostRecentPromotion.PromotionId }, mostRecentPromotion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPromotion(int id, Promotion promotion)
        {
            if (id != promotion.PromotionId)
            {
                return BadRequest();
            }

            _context.Entry(promotion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromotionExists(id))
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

        // DELETE: api/Promotions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromotion(int id)
        {
            var promotion = await _context.Promotions.FindAsync(id);
            if (promotion == null)
            {
                return NotFound();
            }

            _context.Promotions.Remove(promotion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PromotionExists(int id)
        {
            return _context.Promotions.Any(e => e.PromotionId == id);
        }
    }
}
