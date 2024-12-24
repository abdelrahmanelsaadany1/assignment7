using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.aggregation
{
    internal class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Employee[] Employee { get; set; }

        public Department(string _Name, Employee[] _Employee) { 
        
        Name = _Name;
            Employee = _Employee;
        }
    }
}
