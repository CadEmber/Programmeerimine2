using System.ComponentModel.DataAnnotations;

using System;
namespace KooliProjekt.Data
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public bool IsPaid { get; set; }
    }
}