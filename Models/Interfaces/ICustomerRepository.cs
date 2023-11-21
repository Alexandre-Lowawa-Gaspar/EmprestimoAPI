namespace EmprestimoAPI.Models.Interfaces
{
    public interface ICustomerRepository
    {
        public Customer Add(Customer customer);
       List<Customer> GetAll();
    }
}
