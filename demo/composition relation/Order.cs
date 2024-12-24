using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.composition_relation
{
    internal class Order
    {
        public int Id { get; set; } 
        public string Email { get; set; }    
        public string SubTotal { get; set; }
        public  OrderItem[]  Items { get; set; }

        public Order (int _Id,string _Email, string _SubTotal, OrderItem[] _Items) { 
        
        Id = _Id;
            Email = _Email; 
            SubTotal = _SubTotal;
                Items = _Items;
                
        }
    }
}
