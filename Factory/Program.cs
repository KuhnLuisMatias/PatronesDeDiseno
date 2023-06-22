using Factory.Interface;
using Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            ES:
                El patrón de diseño Factory (o Fábrica) 
            
                En C# es un patrón creacional que permite encapsular la creación de objetos en una clase separada, 
                llamada fábrica, en lugar de crear los objetos directamente en el código cliente. 
                La fábrica es responsable de instanciar y devolver los objetos solicitados por el cliente, 
                ocultando los detalles de implementación y simplificando el proceso de creación.

                El patrón Factory consta de los siguientes elementos:

                a.  Producto: Es la interfaz o clase base común a todos los productos concretos que se pueden crear.
                b.  Productos concretos: Son las clases que implementan la interfaz o heredan de la clase base Producto. Representan los objetos que se crearán mediante la fábrica.
                c.  Fábrica: Es la clase responsable de crear los objetos del producto. Puede tener métodos para crear diferentes tipos de productos o puede utilizar parámetros para determinar qué tipo de objeto crear.

            EN:

                The Factory design pattern 
            
                In C# it is a creational pattern that allows to encapsulate the creation of objects in a separate class, 
                called factory, instead of creating the objects directly in the client code. 
                The factory is responsible for instantiating and returning the objects requested by the client, 
                hiding the implementation details and simplifying the creation process.

                The Factory pattern consists of the following elements:

                a.  Product: it is the interface or base class common to all concrete products that can be created.
                b.  Concrete products: These are the classes that implement the interface or inherit from the base class Product. They represent the objects that will be created by the factory.
                c.  Factory: It is the class responsible for creating the product objects. It can have methods to create different types of products or it can use parameters to determine what type of object to create.
             */

            var cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
                Console.Write("Invalid Card Type");

            Console.ReadLine();
        }
    }
}
