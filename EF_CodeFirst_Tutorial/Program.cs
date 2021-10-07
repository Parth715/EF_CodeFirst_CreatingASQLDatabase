using SalesDbLib.Controllers;
using System;
using System.Threading.Tasks;

namespace EF_CodeFirst_Tutorial
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var custCtrl = new CustomersController();
            var customers = await custCtrl.GetAll();
            customers.ForEach(c => Console.WriteLine(c.Name));
            var ordCtrl = new OrdersController();
            var orders = await ordCtrl.GetAll();
            orders.ForEach(o => Console.WriteLine($"{o.Description} | {o.Customer.Name}"));
        }
    }
}
