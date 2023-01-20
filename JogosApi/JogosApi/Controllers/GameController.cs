using JogosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JogosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new();

        [HttpPost]
        public void AddGame([FromBody]Game game)
        {
            games.Add(game);
        }

        [HttpGet]
        public List<Game> GetGame()
        {
            return games;
        }
    }
}
