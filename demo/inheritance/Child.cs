using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.inheritance
{
    internal class Child :Parent
    {
        public int Z {  get; set; }
        public Child(int _x,int _y ,int _z):base(_x,_y) 
        {
        
        Z = _z;
        }
    }
}
