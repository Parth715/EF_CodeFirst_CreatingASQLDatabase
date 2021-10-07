using Microsoft.EntityFrameworkCore;
using SalesDbLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDbLib.Controllers
{
    public class OrdersController
    {
        private readonly SalesDbcontext _context;
        public OrdersController()
        {
            _context = new SalesDbcontext();
        }
        public async Task<List<Order>> GetAll()
        {
            return await _context.Orders.Include(x => x.Customer)
                                        .OrderBy(x => x.Description)
                                        .ToListAsync();
                                        
                                        
        }
    }
}
