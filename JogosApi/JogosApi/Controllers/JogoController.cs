using JogosApi.Data;
using JogosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JogosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class JogoController : ControllerBase
    {
        private JogoContext _context;

        public JogoController(JogoContext gameContext)
        {
            _context = gameContext;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Jogo jogo)
        {
            _context.TB_GAMES.Add(jogo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = jogo.Id},jogo);
        }

        [HttpGet]
        public IEnumerable<Jogo> Get([FromQuery] int skip, int take = 50)
        {
            return _context.TB_GAMES.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var jogo = _context.TB_GAMES.FirstOrDefault(jogo => jogo.Id == id);
            if (jogo == null)
                return NotFound();
            return Ok(jogo);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody]Jogo novoJogo)
        {
            try
            {
                var jogo = _context.TB_GAMES.FirstOrDefault(g => g.Id == id);
                if (jogo != null)
                {
                    jogo.Nome = novoJogo.Nome;
                    jogo.Plataforma = novoJogo.Plataforma;
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
                var jogo = _context.TB_GAMES.First(g => g.Id == id);
                if (jogo != null)
                {
                    _context.TB_GAMES.Remove(jogo);
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
