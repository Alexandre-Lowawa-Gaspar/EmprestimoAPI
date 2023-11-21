using EmprestimoAPI.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Income { get; set; }
        public string? Location { get; set; }
        public List<Loan>? Loans { get; set; }
      
    }

}
