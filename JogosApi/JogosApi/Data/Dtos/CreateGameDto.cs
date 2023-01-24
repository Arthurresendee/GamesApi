using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace JogosApi.Data.Dtos
{
    public class CreateGameDto
    {
        [Required(ErrorMessage = "The field name is required.")]
        //[StringLength(maximumLength: 5, MinimumLength = 2)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string? CreatoBy { get; set; }

        [StringLength(30)]
        public string? Owner { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
        
        public string? Platform { get; set; }

        public DateTime? ReleaseDate { get; set; }
    }
}
