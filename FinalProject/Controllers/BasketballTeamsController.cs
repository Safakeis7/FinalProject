using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketballTeamsController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        public BasketballTeamsController(FinalProjectContext context)
        {
            _context = context;
        }

        // GET: api/BasketballTeams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasketballTeams>>> GetBasketballTeams()
        {
            return await _context.BasketballTeams.ToListAsync();
        }

        // GET: api/BasketballTeams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BasketballTeams>> GetBasketballTeam(int id)
        {
            var basketballTeam = await _context.BasketballTeams.FindAsync(id);

            if (basketballTeam == null)
            {
                return NotFound();
            }

            return basketballTeam;
        }

        // POST: api/BasketballTeams
        [HttpPost]
        public async Task<ActionResult<BasketballTeams>> PostBasketballTeam(BasketballTeams basketballTeam)
        {
            _context.BasketballTeams.Add(basketballTeam);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBasketballTeam), new { id = basketballTeam.Id }, basketballTeam);
        }

        // PUT: api/BasketballTeams/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBasketballTeam(int id, BasketballTeams basketballTeam)
        {
            if (id != basketballTeam.Id)
            {
                return BadRequest();
            }

            _context.Entry(basketballTeam).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/BasketballTeams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasketballTeam(int id)
        {
            var basketballTeam = await _context.BasketballTeams.FindAsync(id);
            if (basketballTeam == null)
            {
                return NotFound();
            }

            _context.BasketballTeams.Remove(basketballTeam);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
