using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string RegistrationNo { get; set; }

        [Required]
        public int CarModelId { get; set; }
    }
}