using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; } // Navigation property to Author

        [Required]
        [StringLength(200)] //Title cannot be longer then 200 characters...
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }
        [Range(1000, 2023)] //Book can be an oldie, but it cannot have a YearPublished year in the future...
        public int YearPublished { get; set; }

        public bool IsBorrowed { get; set; }

        public string CurrentBorrowerId { get; set; } // Nullable for books that are not borrowed
        [ForeignKey("CurrentBorrowerId")]
        public IdentityUser CurrentBorrower { get; set; } // Nullable navigation property

        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
    }
}
