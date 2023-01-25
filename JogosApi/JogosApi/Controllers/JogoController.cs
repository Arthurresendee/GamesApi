using AutoMapper;
using JogosApi.Data;
using JogosApi.Data.Dtos;
using JogosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace JogosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class JogoController : ControllerBase
    {
        private JogoContext _context;
        private IMapper _mapper;

        public JogoController(JogoContext gameContext,IMapper mapper)
        {
            _context = gameContext;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateJogoDto jogoDto)
        {
            Jogo jogo = _mapper.Map<Jogo>(jogoDto);

            _context.TB_GAMES.Add(jogo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = jogo }, jogo);
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
        public IActionResult Put(int id,[FromBody]UpdateJogoDto jogoDto)
        {
            var jogo = _context.TB_GAMES.FirstOrDefault(g => g.Id == id);

            if (jogo == null)
                return NotFound();
            _mapper.Map(jogoDto, jogo);
            _context.SaveChanges();
            return NoContent();

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
