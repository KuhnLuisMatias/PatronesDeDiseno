using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Model
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching regular bike details..");
        }
    }
}
