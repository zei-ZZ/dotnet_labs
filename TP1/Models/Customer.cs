namespace TP1.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        public Customer()
        {
        }
    }
}
