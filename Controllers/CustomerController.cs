using EmprestimoAPI.Models;
using EmprestimoAPI.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmprestimoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILoanService _loanService;
        private readonly ICustomerService _customerService;
        public CustomerController(ILoanService loanService, ICustomerService customerService)
        {
            _loanService = loanService;
            _customerService = customerService;
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return _customerService.GetAll();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            var customerFound=_customerService.GetAll().SingleOrDefault(x => x.Id == id);

            return _customerService.VerifyIfICustomersAllowed(customerFound);
        }

        [HttpPost("customer-loans")]
        public void Post([FromBody] Customer customer)
        {
            _customerService.Add(customer);
        }

     
    }
}
