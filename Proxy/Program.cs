using Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            ES:

            De acuerdo con las definiciones de Gang of four, 
            el patrón de diseño de proxy proporciona un sustituto (actuar en nombre de otro) o marcador de posición de otro objeto para controlar el acceso a él. 
            El patrón de diseño proxy nos permite crear una clase que representa la funcionalidad de otras clases. 
            El proxy podría interactuar con cualquier cosa, como una conexión de red, un objeto grande en memoria, un archivo, o algunos otros recursos que son caros o imposibles de duplicar.

            También podemos decir que el Proxy es el objeto que está siendo llamado por el cliente para acceder al objeto real detrás de la escena. 
            Proxy significa en lugar de o en nombre de. Es decir, en el patrón de diseño Proxy, una clase representa la funcionalidad de otra clase. 

            Hay cuatro participantes involucrados en el Patrón de Diseño Proxy. Son los siguientes.

            Sujeto (ISharedFolder): 
                Es una interfaz que define los miembros que van a ser implementados por la clase RealSubject y Proxy para que el Proxy pueda ser utilizado por el cliente en lugar del RealSubject. En nuestro ejemplo, es la interfaz ISharedFolder.

            RealSubject (CarpetaCompartida): 
                Esta es una clase que queremos usar más eficientemente usando la clase proxy. 
                Esta clase debe implementar la interfaz Subject. En nuestro ejemplo, es la clase SharedFolder.

            Proxy (SharedFolderProxy): 
                Es una clase que mantiene una referencia a la clase RealSubject y puede acceder a los miembros de la clase RealSubjecr según sea necesario. 
                Debe implementar la misma interfaz que RealSubject para que ambas puedan utilizarse indistintamente. 
                En nuestro ejemplo, se trata de la clase SharedFolderProxy.

            Cliente: 
                Este Cliente va a ser una clase y la clase cliente va a utilizar la clase Proxy.

            EN:

            According to the Gang of four definitions, Proxy Design Pattern provides a surrogate (act on behalf of another) or placeholder for another object to control access to it. 
            The Proxy Design Pattern allows us to create a class that represents the functionality of other classes. 
            The proxy could interface with anything such as a network connection, a large object in memory, a file, or some other resources that are expensive or impossible to duplicate.

            We can also say that the Proxy is the object which is being called by the client to access the real object behind the scene.
            Proxy means in place of or on behalf of. 
            That means, In Proxy Design Pattern, a class represents the functionality of another class. 

            There are four participants involved in the Proxy Design Pattern. They are as follows:

            Subject (ISharedFolder): 
                This is an interface that defines the members that are going to be implemented by the RealSubject and Proxy class so that the Proxy can be used by the client instead of the RealSubject. 
                In our example, it is the ISharedFolder interface.

            RealSubject (SharedFolder): 
                This is a class that we want to use more efficiently by using the proxy class. 
                This class should implement the Subject Interface. In our example, it is the SharedFolder class.

            Proxy (SharedFolderProxy): This is a class that holds a reference to the RealSubject class and can access RealSubjecr class members as required. It must implement the same interface as the RealSubject so that the two can be used interchangeably. In our example, it is the SharedFolderProxy class.
            Client: This Client is going to be a class and the client class is going to use the Proxy class.
             */

            Console.WriteLine("Client passing employee with Role Developer to folderproxy");

            var emp1 = new Employee("Anurag", "Anurag123", "Developer");
            var folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();

            Console.WriteLine();
            Console.WriteLine("Client passing employee with Role Manager to folderproxy");

            var emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
            var folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformRWOperations();
            Console.Read();

        }
    }
}
