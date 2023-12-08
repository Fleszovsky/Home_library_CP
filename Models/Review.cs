using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }

        [Required]
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        public string? Comment { get; set; }
    }
}
