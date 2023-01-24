using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace JogosApi.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? CreatoBy { get; set; }
        public string? Owner { get; set; }
        public string? Description { get; set; }
        public string? Platform { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
