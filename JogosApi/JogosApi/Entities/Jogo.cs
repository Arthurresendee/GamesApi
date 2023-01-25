using JogosApi.Entities.Enums.Generos;
using JogosApi.Models.Enums.Generos;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace JogosApi.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string? Criador { get; set; }
        public string? Proprietario { get; set; }
        public string? Descricao { get; set; }
        public string? Plataforma { get; set; }
        public DateTime? DataLancamento { get; set; }
        public Categoria? Categoria { get; set; }
        public Acao? Acao { get; set; }
        public Aventura? Aventura { get; set; }
        public EsporteECorrida? EsporteECorrida { get; set; }
        public Estrategia? Estrategia { get; set; }
        public Jogadores? Jogadores { get; set; }
        public RPG? RPG { get; set; }
        public Simulacao? Simulacao { get; set; }
        public Temas? Temas { get; set; }
    }
}
