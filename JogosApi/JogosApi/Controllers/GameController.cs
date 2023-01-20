using JogosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JogosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new();
        private static int _id = 1;

        [HttpPost]
        public string Add([FromBody]Game game)
        {
            string mensagem = "Item Adicionado.";
            games.Add(game);
            game.Id = _id;
            _id++;
            return mensagem;
        }

        [HttpGet]
        public IEnumerable<Game> Get([FromQuery] int skip, int take = 50)
        {
            return games.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public Game? GetById(int id)
        {
            return games.FirstOrDefault(game => game.Id == id);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id,[FromBody]Game newGame)
        {
            try
            {
                var game = games.First(g => g.Id == id);
                if (game != null)
                {
                    game.Name = newGame.Name;
                    game.Platform = newGame.Platform;
                }
                return Ok();
            }
            catch (InvalidOperationException ex) 
            {
                Console.WriteLine("sasa");
                return NotFound();
            }
        }
    }
}
