using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }

        [Required]
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; }

        public DateTime ReservationDate { get; set; }
        public bool IsActive { get; set; }
    }

}
