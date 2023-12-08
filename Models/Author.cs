using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] //Must start from a capital letter and must contain letters only...
        public string? FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] //As above
        public string? LastName { get; set; }

        // Initialize the collection to prevent NullReferenceException
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

}
