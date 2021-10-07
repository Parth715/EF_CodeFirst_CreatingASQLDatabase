using Microsoft.EntityFrameworkCore;
using SalesDbLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDbLib.Controllers
{
    public class CustomersController
    {
        private readonly SalesDbcontext _context;
        
        public CustomersController()
        {
            _context = new SalesDbcontext();
        }
        public async Task<List<Customer>> GetAll()
        {
            return await _context.Customers.OrderBy(x =>x.Name)
                                           .ToListAsync();
        }
    }
}
