using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka.Models
{
    [Table("LibraryUsers")]
    public class ApplicationUser : IdentityUser
    {
        public string? FavoriteGenre { get; set; }

        // Relationship with Reviews
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        // Relationship with Reservations
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }

}
