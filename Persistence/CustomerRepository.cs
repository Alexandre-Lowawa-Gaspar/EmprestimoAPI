using EmprestimoAPI.Models;
using EmprestimoAPI.Models.Interfaces;

namespace EmprestimoAPI.Persistence
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EmprestimoContext _context;
        public CustomerRepository(EmprestimoContext context)
        {
            _context = context;
        }

        public Customer Add(Customer customer)
        {
            _context.Customers.Add(customer);
            return customer;
        }

        public List<Customer> GetAll()
        {
           return _context.Customers;
        }
    }
}
