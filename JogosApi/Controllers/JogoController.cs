using JogosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JogosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class JogoController : ControllerBase
    {
        private static List<Jogo> jogos = new();

        [HttpPost]
        public void InserirJogo([FromBody]Jogo jogo)
        {
            jogos.Add(jogo);
            Console.WriteLine($"{jogo.Nome}\n{jogo.Plataforma}");
        }

        [HttpGet] 
        public List<Jogo> ObterJogo()
        {
            return jogos;
        }
    }
}
