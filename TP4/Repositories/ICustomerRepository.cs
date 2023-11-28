using TP4.Models;

namespace TP4.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer customer);
    }
}
