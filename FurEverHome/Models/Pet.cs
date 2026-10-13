using System.ComponentModel.DataAnnotations;

namespace FurEverHome.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Species { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Breed { get; set; }

        [Range(0, 40), Display(Name = "Age (years)")]
        public int Age { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [DataType(DataType.Date), Display(Name = "Date Arrived")]
        public DateTime DateArrived { get; set; }

        [Display(Name = "Adopted?")]
        public bool IsAdopted { get; set; }

        [Display(Name = "Shelter")]
        public int ShelterId { get; set; }
        public Shelter? Shelter { get; set; }
    }
}
