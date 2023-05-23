using System.ComponentModel.DataAnnotations;

namespace EJ2PARCIAL.Models
{
    public class Moto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
    }
}
