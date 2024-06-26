﻿using JogosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JogosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class JogoControllerSBanco : ControllerBase
    {
        private static List<Jogo> games = new();                                //toda vez que faco uma requisicao ele passa por toda classe de controller, assim sempre passando pela lista e instanciando uma nova, colocando o modificador como static, evitamos de ser criada a cada requisicao, assim pertencendo a propria classe e não á uma instância da mesma.
        private static int _id = 1;

        [HttpPost]
        public IActionResult Add([FromBody] Jogo game)
        {
            games.Add(game);
            game.Id = _id;
            _id++;
            //return Ok(game);
                                                                                return CreatedAtAction(nameof(GetById), new { id = game.Id},game);
        }

        [HttpGet]
        public IEnumerable<Jogo> Get([FromQuery] int skip, int take = 50)
        {
            return games.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var game = games.FirstOrDefault(game => game.Id == id);
            if (game == null)
                return NotFound();
            return Ok(game);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody]Jogo newGame)
        {
            try
            {
                var game = games.FirstOrDefault(g => g.Id == id);
                if (game != null)
                {
                    game.Nome = newGame.Nome;
                    game.Plataforma = newGame.Plataforma;
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
                var game = games.First(g => g.Id == id);
                if (game != null)
                {
                    games.Remove(game);
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
