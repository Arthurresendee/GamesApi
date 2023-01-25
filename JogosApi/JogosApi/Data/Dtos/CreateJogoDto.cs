using JogosApi.Entities.Enums.Genero.SubGenero;
using JogosApi.Models.Enums.Generos;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace JogosApi.Data.Dtos
{
    public class CreateJogoDto
    {
        [StringLength(50)]
        public string? Nome { get; set; }
        [StringLength(50)]
        public string? Criador { get; set; }
        [StringLength(50)]
        public string? Proprietario { get; set; }
        [StringLength(200)]
        public string? Descricao { get; set; }
        [StringLength(50)]
        public string? Plataforma { get; set; }
        public DateTime? DataLancamento { get; set; }
        public Genero? Genero { get; set; }
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
