using JogosApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace JogosApi.Data
{
    public class JogoContext : DbContext
    {
        public JogoContext(DbContextOptions<JogoContext> opts) : base(opts)
        {

        }

        public DbSet<Jogo> TB_GAMES { get; set; }
    }
}
