using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carz_Co
{
    internal class Truck : Vehicle, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Trucken kör");
        }

        public Truck(string brand, string model) : base(brand, model)
        {
            base.Brand = brand;
            base.Model = model;
        }
    }
}
