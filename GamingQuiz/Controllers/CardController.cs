using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly DataContext _context;

        public CardController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Card>>> Get() => Ok(await _context.Cards.ToListAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<Card>> Get(int id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return BadRequest("Card not found!");
            }
            return Ok(card);
        }
    }
}
