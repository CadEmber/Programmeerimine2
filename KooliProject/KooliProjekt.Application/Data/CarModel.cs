using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int CarManufacturerId { get; set; }

        [Required]
        public decimal KmRate { get; set; }

        [Required]
        public decimal HourlyRate { get; set; }
    }
}