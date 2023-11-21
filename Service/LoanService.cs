using EmprestimoAPI.Models;
using EmprestimoAPI.Models.Interfaces;

namespace EmprestimoAPI.Service
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _context;
        public LoanService(ILoanRepository context)
        {
            _context = context; 
        }

        public List<Loan> GetAll()
        {
        return  _context.GetAll();
        }
    }
}