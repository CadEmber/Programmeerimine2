using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class InvoiceLine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string LineItem { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(10)]
        public string Unit { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public int BookingId { get; set; }
    }
}