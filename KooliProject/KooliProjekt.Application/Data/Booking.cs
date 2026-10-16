using System.ComponentModel.DataAnnotations;

using System;
namespace KooliProjekt.Data
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Started { get; set; }

        public DateTime? Finished { get; set; }

        [Required]
        public int StartKm { get; set; }

        public int? FinishKm { get; set; }

        [Required]
        public decimal KmRate { get; set; }

        [Required]
        public decimal HourlyRate { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}