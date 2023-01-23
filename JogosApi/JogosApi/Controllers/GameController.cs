using JogosApi.Data;
using JogosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JogosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class GameController : ControllerBase
    {
        private GameContext _context;

        public GameController(GameContext gameContext)
        {
            _context = gameContext;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Game game)
        {
            _context.TB_GAMES.Add(game);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = game.Id},game);
        }

        [HttpGet]
        public IEnumerable<Game> Get([FromQuery] int skip, int take = 50)
        {
            return _context.TB_GAMES.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var game = _context.TB_GAMES.FirstOrDefault(game => game.Id == id);
            if (game == null)
                return NotFound();
            return Ok(game);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody]Game newGame)
        {
            try
            {
                var game = _context.TB_GAMES.FirstOrDefault(g => g.Id == id);
                if (game != null)
                {
                    game.Name = newGame.Name;
                    game.Platform = newGame.Platform;
                }
                return Ok();
            }
            catch (InvalidOperationException ex) 
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var game = _context.TB_GAMES.First(g => g.Id == id);
                if (game != null)
                {
                    _context.TB_GAMES.Remove(game);
                }
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
