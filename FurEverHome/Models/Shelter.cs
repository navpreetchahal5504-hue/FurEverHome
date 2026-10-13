using System.ComponentModel.DataAnnotations;

namespace FurEverHome.Models
{
    public class Shelter
    {
        public int ShelterId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string City { get; set; } = string.Empty;

        [Phone, Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public List<Pet>? Pets { get; set; }
    }
}
