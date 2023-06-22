using AbstractFactory.Model.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                ES:
                    Patrón de diseño Factoria Abstracta

                    El patrón Abstract Factory es otro patrón creacional que proporciona una interfaz para crear familias de objetos relacionados sin especificar las clases concretas. 
                    Permite crear objetos de diferentes tipos relacionados entre sí, sin que el código cliente esté acoplado a las implementaciones concretas de esos objetos.

                    El patrón Abstract Factory se compone de los siguientes elementos:

                    A.  AbstractFactory (Factoría Abstracta)
                        
                        Es una interfaz o clase abstracta que define los métodos de creación para los diferentes tipos de objetos que la factoría puede producir. 
                        Cada método de creación devuelve un objeto de una familia relacionada de productos.

                    B.  ConcreteFactory (Factoría Concreta)
            
                        Son las implementaciones concretas de la factoría abstracta. 
                        Cada factoría concreta se encarga de crear los objetos concretos de una familia relacionada de productos.

                    AbstractProduct (Producto Abstracto): Es una interfaz o clase abstracta que define el comportamiento común para los diferentes tipos de productos que la factoría puede crear.

                    ConcreteProduct (Producto Concreto): Son las clases concretas que implementan la interfaz o heredan de la clase abstracta AbstractProduct. Cada ConcreteProduct representa una implementación específica de un producto relacionado.
                
                EN:
                    Abstract Factory design pattern

                    The Abstract Factory pattern is another creative pattern that provides an interface for creating families of related objects without specifying the concrete classes. 
                    It allows creating objects of different types related to each other, without the client code being coupled to the concrete implementations of those objects.

                    The Abstract Factory pattern consists of the following elements:

                    A.  AbstractFactory (Abstract Factory)
                        
                        It is an abstract interface or class that defines the creation methods for the different types of objects that the factory can produce. 
                        Each creation method returns an object from a related family of products.

                    B.  ConcreteFactory (ConcreteFactory)
            
                        These are the concrete implementations of the abstract factory. 
                        Each concrete factory is responsible for creating the concrete objects of a related family of products.

                    C.  AbstractProduct: It is an interface or abstract class that defines the common behavior for the different types of products that the factory can create.

                    D.  ConcreteProduct: These are the concrete classes that implement the interface or inherit from the AbstractProduct abstract class. Each ConcreteProduct represents a specific implementation of a related product.
            */

            var regularVehicleFactory = new RegularVehicleFactory();
            var regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();

            var sportVehicleFactory = new SportVehicleFactory();
            var sportCar = sportVehicleFactory.CreateCar();
            sportCar.GetDetails();

            Console.ReadLine();
        }
    }
}
