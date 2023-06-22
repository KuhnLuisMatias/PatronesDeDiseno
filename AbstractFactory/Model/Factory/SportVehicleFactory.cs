using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Model.Factory
{
    public class SportVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportBike();
        }

        public ICar CreateCar()
        {
            return new SportCar();
        }
    }
}
