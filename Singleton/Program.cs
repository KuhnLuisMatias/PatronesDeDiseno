using Singleton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ES:
                El patrón de diseño Singleton se utiliza para garantizar que una clase tenga una única instancia y proporcionar un punto de acceso global a dicha instancia. 
                Esto es útil cuando solo se necesita una única instancia de una clase en todo el programa.

            
                El patrón Singleton es útil en las siguientes situaciones:

                Acceso global a una instancia única: Cuando necesitas tener una única instancia de una clase y quieres acceder a ella desde cualquier parte del programa.

                Recursos compartidos: 
                    Cuando tienes recursos compartidos, como bases de datos o archivos, y necesitas controlar el acceso a ellos para evitar conflictos. 
                    El patrón Singleton garantiza que solo exista una instancia de la clase que gestiona estos recursos y coordina su acceso.

                Configuración global: 
                    Cuando tienes configuraciones globales que deben ser accesibles desde diferentes partes del programa. 
                    El patrón Singleton te permite almacenar estas configuraciones en una única instancia y acceder a ellas de manera sencilla.

                Gestión de caché: 
                    Cuando necesitas implementar una caché de objetos para mejorar el rendimiento y evitar la duplicación de datos. 
                    El patrón Singleton puede ser utilizado para gestionar la instancia de la clase que se encarga de la gestión de la caché.

            EN:
                The Singleton design pattern is used to ensure that a class has a single instance and provide a global access point to that instance. 
                This is useful when only a single instance of a class is needed in the entire program.

                 The Singleton pattern is useful in the following situations:

                Global access to a single instance: when you need to have a single instance of a class and want to access it from anywhere in the program.

                Shared resources: 
                    When you have shared resources, such as databases or files, and you need to control access to them to avoid conflicts. 
                    The Singleton pattern ensures that there is only one instance of the class that manages these resources and coordinates their access.

                Global configuration: 
                    When you have global settings that need to be accessible from different parts of the program. 
                    The Singleton pattern allows you to store these configurations in a single instance and access them easily.

                Cache management: 
                    When you need to implement an object cache to improve performance and avoid data duplication. 
                    The Singleton pattern can be used to manage the instance of the class that is in charge of cache management.
             */

            var singleton = Example.GetInstance();
            singleton.PrintDetails("First message.");

            singleton = Example.GetInstance();
            singleton.PrintDetails("Second message.");

            singleton = Example.GetInstance();
            singleton.PrintDetails("Third message."); 

            Console.Read();

        }
    }
}
