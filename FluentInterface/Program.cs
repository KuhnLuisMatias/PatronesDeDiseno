using FluentInterface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                ES:

                El patrón de diseño Fluent Interface (Interfaz Fluida) 
            
                Es un estilo de diseño en el que se busca lograr una sintaxis de código más expresiva y legible, 
                que se asemeje al lenguaje natural y permita encadenar múltiples llamadas de métodos de forma fluida.

                En lugar de tener métodos separados con parámetros individuales, 
                el patrón Fluent Interface permite encadenar los métodos en una sola expresión, 
                lo que da como resultado un código más conciso y fácil de leer.

                La idea principal del patrón Fluent Interface es proporcionar un conjunto de métodos de objeto que se pueden encadenar en secuencia, 
                donde cada método modifica el estado del objeto y devuelve una referencia al mismo objeto, 
                lo que permite continuar la cadena de llamadas.

                Este patrón se utiliza comúnmente en bibliotecas y frameworks para proporcionar una API más expresiva y fácil de usar.
                Algunos ejemplos de uso del patrón Fluent Interface son las consultas de bases de datos, 
                la construcción de consultas SQL, la configuración de objetos complejos y la construcción de objetos en general.
             
                EN:

                The Fluent Interface design pattern. 
            
                It is a design style that seeks to achieve a more expressive and readable code syntax, 
                that resembles natural language and allows multiple method calls to be chained together in a fluent manner.

                Instead of having separate methods with individual parameters, 
                the Fluent Interface pattern allows methods to be chained together in a single expression, 
                resulting in a more concise and easier to read code.

                The main idea of the Fluent Interface pattern is to provide a set of object methods that can be chained together in sequence, 
                where each method modifies the state of the object and returns a reference to the same object, 
                which allows the chain of calls to continue.

                This pattern is commonly used in libraries and frameworks to provide a more expressive and user-friendly API.
                Some examples of using the Fluent Interface pattern are database queries, 
                SQL query construction, complex object configuration and object construction in general.
            */

            FluentEmployee obj = new FluentEmployee();
            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");
            obj.ShowDetails();

            Console.Read();
        }
    }
}
