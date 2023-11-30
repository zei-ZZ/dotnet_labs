namespace TP1.Models
{
    public class Movie
    {
        public Movie()
        {
        }

        public Guid Id { get; set; }
        public string Name{ get; set; }

        public Movie(string name)
        {

            Name = name;
            Id = Guid.NewGuid();
        }
    }
}
