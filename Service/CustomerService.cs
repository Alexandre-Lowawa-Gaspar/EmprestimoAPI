using EmprestimoAPI.Models;
using EmprestimoAPI.Models.Interfaces;

namespace EmprestimoAPI.Service
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _context;
        private readonly ILoanService _loanService;
        public CustomerService(ICustomerRepository context, ILoanService loanService)
        {
            _context = context;
            _loanService = loanService;

        }

        public Customer Add(Customer customer)
        {
           return _context.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _context.GetAll();  
        }

        public Customer VerifyIfICustomersAllowed(Customer customer)
        {
            List<Loan> LoanAlloewdPierCustomer = new List<Loan>();
            if (customer == null)
            {
                return null;
            }
            else
            {
                if ((customer.Income <= 30000) || ((customer.Income > 30000) || (customer.Income < 50000)) || ((customer.Age < 30) && (customer.Location == "SP")))
                {
                    foreach (var loan in _loanService.GetAll())
                    {
                        if ((loan.Type.Trim().ToLower() == "PERSONAL".Trim().ToLower()) ||( loan.Type.Trim().ToLower() == "GUARANTEED".Trim().ToLower()))
                            LoanAlloewdPierCustomer.Add(loan);
                    }
                    customer.Loans = LoanAlloewdPierCustomer;
                    return customer;
                }
                else
                {
                    if (customer.Income >= 50000)
                    {
                        foreach (var loan in _loanService.GetAll())
                        {
                            if (loan.Type.Trim().ToLower() == "CONSIGNMENT".Trim().ToLower())
                                LoanAlloewdPierCustomer.Add(loan);
                        }

                        customer.Loans = LoanAlloewdPierCustomer;
                        return customer;
                    }
                }
                return null;


            }
        }

    }
}
