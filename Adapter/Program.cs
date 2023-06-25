using Adapter.Interface;
using Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            ES:
            
               El Patrón de Diseño de Adaptadores está formado por cuatro componentes. Son los siguientes

               Cliente: 
                    La clase Cliente solo puede ver la interfaz ITarget, es decir, la clase que implementa la interfaz ITarget, que en nuestro ejemplo es el adaptador (EmployeeAdapter). 
                    Utilizando ese objeto adaptador (EmployeeAdapter), el cliente se comunicará con el Adaptee, que no es compatible con el cliente.

                ITarget: 
                    Esta será una interfaz y debe ser implementada por el adaptador. 
                    El cliente solo puede ver esta interfaz, es decir, la clase que implementa esta interfaz.

                Adaptador: 
                    Esta es la clase que hace que dos interfaces o sistemas incompatibles trabajen juntos. 
                    La clase Adaptador implementa la interfaz ITarget y proporciona la implementación del método de la interfaz. 
                    Esta clase también está compuesta por el Adaptee, es decir, tiene una referencia al objeto Adaptee, ya que estamos utilizando el patrón de diseño Adaptador de Objeto. 
                    En nuestro ejemplo, es la clase EmployeeAdapter la que implementa la interfaz ITarget y proporciona implementaciones para el método ProcessCompanySalary de la interfaz ITarget. 
                    Esta clase también tiene una referencia al objeto ThirdPartyBillingSystem.

                Adaptee: 
                    Esta clase contiene la funcionalidad que el cliente requiere, pero no es compatible con el código del cliente existente. Por lo tanto, requiere alguna adaptación o algún tipo de transformación antes de que el cliente pueda usarlo. 
                    Esto significa que el cliente llamará al adaptador y el adaptador realizará las conversiones necesarias, si es necesario, y luego realizará una llamada al Adaptee.

            EN:
            
                The Adapter Design Pattern is composed of four components. They are as follows:

                Client: 
                    The Client class can only see the ITarget interface i.e. the class which implements the ITarget interface i.e. Adapter (in our example it is the EmployeeAdapter). 
                    Using that Adapter (EmployeeAdapter) object, the client will communicate with the Adaptee which is not compatible with the client.

                ITarget: 
                    This is going to be an interface and this interface needs to be implemented by the Adapter. 
                    The client can only see this interface i.e. the class which implements this interface.

                Adapter: 
                    This is the class that makes two incompatible interfaces or systems work together. 
                    The Adapter class implements the ITrager interface and provides the implementation for the interface method. 
                    This class is also composed of the Adaptee i.e. it has a reference to the Adaptee object as we are using Object Adapter Design Pattern. 
                    In our example, it is the EmployeeAdapter class that implements the ITarget Interface and provides implementations to the ProcessCompanySalary method of the ITarget Interface. This class also has a reference to the ThirdPartyBillingSystem object.

                Adaptee: 
                    This class contains the functionality which the client requires but it is not compatible with the existing client code. So, it requires some adaptation or some kind of transformation before the client can use it. 
                    It means the client will call the Adapter and the Adapter will do the required conversions if required and then it will make a call to the Adaptee.
            */
            string[,] employeesArray = new string[5, 4]
            {
                    {"101","John","SE","10000"},
                    {"102","Smith","SE","20000"},
                    {"103","Dev","SSE","30000"},
                    {"104","Pam","SE","40000"},
                    {"105","Sara","SSE","50000"}
            };
            
            //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            Console.WriteLine("HR system passes employee string array to Adapter\n");

            var target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
            
            Console.Read();
        }
    }
}
