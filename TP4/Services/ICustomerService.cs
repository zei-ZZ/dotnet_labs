using TP4.Models;

namespace TP4.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer customer);
    }
}
