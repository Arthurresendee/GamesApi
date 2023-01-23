using JogosApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace JogosApi.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> opts) : base(opts)
        {

        }

        public DbSet<Game> TB_GAMES { get; set; }
    }
}
