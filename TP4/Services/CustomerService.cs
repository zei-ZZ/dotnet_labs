using TP4.Models;
using TP4.Repositories;

namespace TP4.Services
{
    public class CustomerService :ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public void AddCustomer(Customer customer)
        {
            // You might perform additional business logic/validation here before saving
            customer.Id = Guid.NewGuid();
            _customerRepository.AddCustomer(customer);
        }
    }
}
