using System.ComponentModel.DataAnnotations;

namespace JogosApi.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Plataforma { get; set; }
    }
}
