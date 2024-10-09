using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carz_Co
{
    internal class Motorcycle : Vehicle, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Motorcykeln kör");
        }

        public Motorcycle(string brand, string model) : base(brand, model)
        {
            Brand = brand;
            Model = model;
        }
    }
}
