﻿namespace TP3.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name{ get; set; }
        public Guid? GenreId { get; set; }
        public Genre? Genre { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
