using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDbLib.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        [StringLength(30), Required]
        public string Product { get; set; }
        [StringLength(80)]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required, Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; }
        public int OrdersId { get; set; }
        public virtual Order order { get; set; }

        public OrderLine() { }
    }
}
