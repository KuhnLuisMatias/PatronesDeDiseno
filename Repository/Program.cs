using Repository.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                ES:
                    El patrón de diseño Repository pertenece a la categoría de patrones de diseño estructurales. Se utiliza para separar
                    la lógica de acceso a datos de la lógica de negocio en una aplicación. Al hacerlo, proporciona una abstracción entre
                    la capa de acceso a datos y las capas superiores de la aplicación, lo que permite un acoplamiento más bajo y una
                    mayor modularidad.
            
                EN:
                    The Repository design pattern belongs to the category of structural design patterns. It is used to separate the data
                    access logic from the business logic in an application. In doing so, it provides an abstraction between the data
                    access layer and the upper layers of the application, allowing for lower coupling and greater modularity.
             */
            
            SqlConnectionStringBuilder sql_conexion = new SqlConnectionStringBuilder();
            sql_conexion.DataSource = "IPHOST"; 
            sql_conexion.UserID = "SYSDBA";
            sql_conexion.Password = "masterkey";
            sql_conexion.InitialCatalog = @"C:\ATRSistema\BD\DB_ATR.FDB";
            
            var connectionString = sql_conexion.ConnectionString;
            var userRepository = new UserRepository(connectionString);

            var user_I = new User { Name = "John Doe", Age = 30 };
            var user_II = new User { Name = "Jane Smith", Age = 25 };

            userRepository.Add(user_I);
            userRepository.Add(user_II);

            var users = userRepository.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }

            Console.ReadLine();
        }
    }
}
