using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace JogosApi.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field name is required.")]
        public string Name { get; set; }

        [StringLength(40)]
        public string? Platform { get; set; }
    }
}
