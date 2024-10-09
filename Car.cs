using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carz_Co
{
    internal class Car : Vehicle, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Bilen kör");
        }
        public Car(string brand, string model) : base(brand, model)
        {
            Brand = brand;
            Model = model;
        }
    }
}
