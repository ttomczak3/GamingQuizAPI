using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace GamingQuiz.Controllers
{
    [Route("api")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly DataContext _context;

        public CardController(DataContext context)
        {
            _context = context;
        }

        [EnableCors("MyPolicy")]
        [HttpGet("card")]
        public async Task<ActionResult<List<Card>>> Get() => Ok(await _context.Cards.ToListAsync());

        [EnableCors("MyPolicy")]
        [HttpGet("card/{id}")]
        public async Task<ActionResult<Card>> Get(int id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return BadRequest("Card not found!");
            }
            return Ok(card);
        }

        [EnableCors("MyPolicy")]
        [HttpGet("random/card")]
        public async Task<ActionResult<List<Card>>> Random() => Ok(await _context.Cards.OrderBy(o => System.Guid.NewGuid()).Take(1).ToListAsync());
    }
}
