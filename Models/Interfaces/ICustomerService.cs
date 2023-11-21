namespace EmprestimoAPI.Models.Interfaces
{
    public interface ICustomerService
    {
        public Customer Add(Customer customer);
        Customer VerifyIfICustomersAllowed(Customer customer);
        List<Customer> GetAll();
    }
}
