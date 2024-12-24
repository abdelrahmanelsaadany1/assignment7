using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.composition_relation
{
    internal class OrderItem
    {
        //associaction
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Price { get; set; }
        public string Quantity { get; set; }

        OrderItem(Product _Product) { 
        
        Product = _Product;
        }
    }
}
