using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP4.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name{ get; set; }
        [Display(Name = "movie added")]
        public DateTime DateAdded { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public Guid? GenreId { get; set; }
        public Genre? Genre { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
