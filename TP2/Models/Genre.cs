﻿namespace TP2.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Genre>? Genres { get; set; }
    }
}
