using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar bmw = new BMWCar();

            PetrolCarDecorator petrolCar = new PetrolCarDecorator(bmw);
            petrolCar.ManufactureCar();
            Console.WriteLine(bmw.ToString());

            DieselDecorator dieselCar = new DieselDecorator(bmw);
            dieselCar.ManufactureCar();
            Console.WriteLine(bmw.ToString());


            Console.ReadLine();
        }
        public interface ICar
        {
            ICar ManufactureCar();
        }

        public class BMWCar : ICar
        {
            public string Motor { get; set; }
            public string Color { get; set; }

            public ICar ManufactureCar()
            {
                Color = "Blue";
                return this;
            }

            public override string ToString()
            {
                return $"BMW con Color {Color} y con Motor {Motor}";
            }
        }

        public class DieselDecorator : CarDecorator
        {
            public DieselDecorator(ICar car) : base(car)
            {
            }

            public override ICar ManufactureCar()
            {
                _car.ManufactureCar();
                AgregarMotor(_car);
                return _car;
            }

            public void AgregarMotor(ICar car)
            {
                if (car is BMWCar bmw)
                    bmw.Motor = "Diesel";
            }

        }

        public abstract class CarDecorator : ICar
        {
            /*
                La clase CarDecorator actúa como una clase base para todos los decoradores, 
                proporcionando un método común para el método Fabricar(). 
                Luego, cada decorador hereda de DecoradorAuto y anula el método Fabricar() 
                para agregar funcionalidad adicional antes o después de llamar al método Fabricar() en el objeto IAuto.
            */
            protected ICar _car;
            public CarDecorator(ICar car)
            {
                this._car = car;
            }
            public virtual ICar ManufactureCar()
            {
                //Call the Existing Car Object ManufactureCar method to return the car without engine
                //Later in the Child class of this abstract we will see how to call this method 
                //and how to add an Engine
                return _car.ManufactureCar();
            }
        }

        public class PetrolCarDecorator : CarDecorator
        {
            public PetrolCarDecorator(ICar car) : base(car)
            {
            }

            public override ICar ManufactureCar()
            {
                _car.ManufactureCar();
                AgregarMotor(_car);
                return _car;
            }

            public void AgregarMotor(ICar car)
            {
                if (car is BMWCar bmw)
                {
                    bmw.Motor = "Petrol";
                }
            }
        }
    }
}
