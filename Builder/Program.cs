using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                ES:

                    El patrón de diseño Builder
                    
                    Es un patrón creacional que se utiliza para construir objetos complejos paso a paso. 
                    Proporciona una forma flexible de crear diferentes representaciones de un objeto, separando el proceso de construcción de su representación final.

                    En el patrón Builder, se define una clase Builder que es responsable de construir el objeto paso a paso. 
                    Esta clase tiene métodos para establecer diferentes atributos o características del objeto en construcción. 
                    Luego, se utiliza un Director para controlar el proceso de construcción y generar el objeto final utilizando el Builder.

                    La ventaja del patrón Builder es que permite construir objetos complejos de manera modular y escalable. 
                    Se pueden crear diferentes variantes del objeto al proporcionar diferentes Builders que implementen la misma interfaz. 
                    Esto permite una mayor flexibilidad y extensibilidad en la creación de objetos.

                    El patrón Builder se utiliza en situaciones donde la creación de un objeto implica un proceso complicado y se desea separar la lógica de construcción del objeto de su representación final.
                    También es útil cuando se requiere la creación de múltiples variantes de un objeto con una estructura similar pero con diferentes atributos.

                    Con el fin de separar el proceso de construcción de su representación, el patrón de diseño constructor envuelve cuatro componentes. Son los siguientes 

                    A.  Constructor abstracto: El Constructor es una interfaz que define todos los pasos que se utilizan para hacer el producto concreto. 

                    B.  Constructor Concreto: El Constructor Concreto implementa la interfaz del Constructor Abstracto y proporciona la implementación de todos los métodos abstractos. El Constructor Concreto es responsable de construir y ensamblar las partes individuales del producto implementando la interfaz del Constructor. También define y rastrea la representación que crea.

                    C.  Director: El Director toma los procesos individuales del Constructor y define la secuencia para construir el producto.

                    D.  Producto: El Producto es una clase y queremos crear este objeto producto utilizando el patrón de diseño constructor. Esta clase define las diferentes partes que formarán el producto.

            EN:

                    The Builder design pattern.
                    
                    It is a creative pattern used to build complex objects step by step. 
                    It provides a flexible way to create different representations of an object, separating the building process from its final representation.

                    In the Builder pattern, a Builder class is defined that is responsible for building the object step by step. 
                    This class has methods to set different attributes or characteristics of the object under construction. 
                    Then, a Director is used to control the construction process and generate the final object using the Builder.

                    The advantage of the Builder pattern is that it allows building complex objects in a modular and scalable way. 
                    Different variants of the object can be created by providing different Builders that implement the same interface. 
                    This allows for greater flexibility and extensibility in object creation.

                    The Builder pattern is used in situations where the creation of an object involves a complicated process and it is desired to separate the object's construction logic from its final representation.
                    It is also useful when the creation of multiple variants of an object with a similar structure but with different attributes is required.

                    In order to separate the construction process from its representation, the constructor design pattern involves four components. They are as follows. 

                    A.  Abstract Constructor: The Constructor is an interface that defines all the steps used to make the concrete product. 

                    B.  Concrete Constructor: The Concrete Constructor implements the Abstract Constructor interface and provides the implementation of all abstract methods. The Concrete Builder is responsible for building and assembling the individual parts of the product by implementing the Builder interface. It also defines and tracks the representation it creates.

                    C.  Director: The Director takes the individual processes from the Builder and defines the sequence for building the product.

                    D.  Product: The Product is a class and we want to create this product object using the constructor design pattern. This class defines the different parts that will form the product.
            */

            var pdfReport = new PDFReport();
            var reportDirector = new ReportDirector();
            var report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            
            Console.ReadLine();
        }
    }
}
