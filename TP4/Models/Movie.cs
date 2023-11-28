using System.ComponentModel.DataAnnotations;

namespace TP4.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name{ get; set; }
        [Display(Name = "movie added")]
        public DateTime added { get; set; }
        public string photo { get; set; }
        public Guid? GenreId { get; set; }
        public Genre? Genre { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
