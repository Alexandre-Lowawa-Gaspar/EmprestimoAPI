using EmprestimoAPI.Models;
using EmprestimoAPI.Models.Interfaces;

namespace EmprestimoAPI.Persistence
{
    public class LoanRepository:ILoanRepository
    {
        public List<Loan> GetAll()
        {
            List<Loan> Loans = new List<Loan>();
            Loans.Add(new()
            {
                Id=1,
                Type = "PERSONAL ",
                InterestRate = 4,
            });
            Loans.Add(new()
            {
                Id=2,
                Type = "GUARANTEED ",
                InterestRate = 3,
            });
            Loans.Add(new()
            {
                Id=3,
                Type = "CONSIGNMENT ",
                InterestRate = 2,
            });
            return Loans;
        }
    }
}