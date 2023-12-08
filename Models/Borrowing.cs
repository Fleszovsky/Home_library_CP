using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka.Models
{
    public class Borrowing
    {
        [Key]
        public int BorrowingId { get; set; }

        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; } // Navigation property for Book

        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; } // Navigation property for IdentityUser

        public DateTime TimeBorrowed { get; private set; } = DateTime.Now;
        public bool IsProlonged { get; set; }

        public bool CanProlong { get; set; }

        public bool IsOverdue
        {
            get
            {
                return !IsProlonged && (DateTime.Now - TimeBorrowed).TotalDays > 14;
            }
        }
    }

}
