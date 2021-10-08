using Microsoft.EntityFrameworkCore;
using SalesDbLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDbLib.Controllers
{
    public class OrderlinesController
    {
        private readonly SalesDbcontext _context;
        public OrderlinesController()
        {
            _context = new SalesDbcontext();
        }
        public async Task<List<OrderLine>> GetAll()
        {
            return await _context.OrderLines.Include(ol => ol.order)
                                            .OrderBy(ol => ol.Price)
                                            .ToListAsync();
        }

    }
}
