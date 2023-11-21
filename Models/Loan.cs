using EmprestimoAPI.Models.Interfaces;

namespace EmprestimoAPI.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string? Type { set; get; }
        public int InterestRate {  set; get; }
     
    }
}