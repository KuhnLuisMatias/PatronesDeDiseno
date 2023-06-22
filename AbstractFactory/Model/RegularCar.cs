using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Model
{
    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching regular car details..");
        }
    }
}
