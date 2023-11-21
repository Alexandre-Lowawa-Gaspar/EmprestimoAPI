using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoAPI.Models
{
    public class EmprestimoContext:DbContext
    {
        public List<Customer> Customers { get; set; }
        public EmprestimoContext()
        {
            Customers = new List<Customer>();
        }
    }
}
