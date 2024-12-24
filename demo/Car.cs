using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Car
    {
        #region attributes
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion
        #region methods
        public override string ToString()
        {
            return $"car id: {Id} \n speed: {Speed} \n model: {Model}";
        }
        public Car(int _id    , double _speed , string _model) {
        
        Id = _id ;
            Model = _model ;
            Speed = _speed ;
        
        }
        public Car(int _id, double _speed):this(_id, _speed,"mazda") 
       {
            Console.WriteLine("constructor 2");
        
        }
        public Car(int _id):this(_id,150, "audi")
        {

            Console.WriteLine("constructor 3");
        }
        #endregion
        #region MyRegion

        #endregion

    }
}
