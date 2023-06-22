using Factory_Method.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* 
                Patrón de diseño Factory Method 
            ES:

            El patrón de diseño Factory Method (Método de Fábrica) es un patrón creacional que se utiliza para encapsular la creación de objetos en una clase base, delegando la responsabilidad de creación a las subclases.
            El objetivo principal del patrón Factory Method es proporcionar una interfaz común para crear objetos, pero permitiendo que las subclases decidan qué clase concreta instanciar.

            El patrón Factory Method se compone de los siguientes elementos:

            A. Product (Producto): Es la interfaz o clase abstracta que define el comportamiento común de los objetos que serán creados por el Factory Method.

            B. ConcreteProduct (Producto Concreto): Son las clases concretas que implementan la interfaz o heredan de la clase abstracta Product. Cada ConcreteProduct representa una implementación específica de la interfaz Product.

            C. Creator (Creador): Es la clase base que declara el Factory Method, que es responsable de crear objetos del tipo Product. 
            Puede ser una clase abstracta o una interfaz. 
            El Creator también puede proporcionar métodos adicionales que utilicen los objetos creados.

            D. ConcreteCreator (Creador Concreto): Son las subclases del Creator que implementan el Factory Method. 
            Cada ConcreteCreator decide qué clase concreta de Product debe ser creada y devuelve una instancia de ella.

            El patrón Factory Method permite que el código cliente trabaje con la interfaz Product, sin conocer la clase concreta que se está utilizando. 
            Esto proporciona flexibilidad y extensibilidad, ya que se pueden agregar nuevas clases concretas al sistema sin afectar el código existente.

            EN:
            
            The Factory Method design pattern is a creation pattern used to encapsulate the creation of objects in a base class, delegating creation responsibility to subclasses.
            The main purpose of the Factory Method pattern is to provide a common interface for creating objects, but allowing subclasses to decide which particular class to instantiate.

            The Factory Method pattern consists of the following elements:

            A. Product: 
                        This is the interface or abstract class that defines the common behavior of the objects to be created by the Factory Method.

            B. ConcreteProduct: 
                        These are the concrete classes that implement the interface or inherit from the abstract class Product. 
                        Each ConcreteProduct represents a specific implementation of the Product interface.

            C. Creator: 
                        It is the base class that declares the Factory Method, which is responsible for creating objects of the Product type. 
                        It can be an abstract class or an interface. 
                        The Creator can also provide additional methods that use the created objects.

            D. ConcreteCreator: 
                        These are the subclasses of the Creator that implement the Factory Method. 
                        Each ConcreteCreator decides which concrete Product class should be created and returns an instance of it.

            The Factory Method pattern allows the client code to work with the Product interface, without knowing the concrete class being used. 
            This provides flexibility and extensibility, since new concrete classes can be added to the system without affecting the existing code.
            
             */
            var creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            //MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}