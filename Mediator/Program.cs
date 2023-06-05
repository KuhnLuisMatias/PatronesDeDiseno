using Mediator.Interface;
using Mediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
              ES:
                  El patrón de diseño Mediator se utiliza para facilitar la comunicación y la interacción entre objetos de manera indirecta, 
                  evitando que los objetos se comuniquen directamente entre sí. 
                  En lugar de que los objetos se conozcan y se comuniquen directamente, 
                  se comunican a través de un objeto mediador centralizado. 
                  El mediador actúa como un intermediario y coordina las interacciones entre los objetos.
              EN:
                  The Mediator design pattern is used to facilitate communication and interaction between objects in an indirect way, 
                  by preventing objects from communicating directly with each other. 
                  Instead of objects meeting and communicating directly with each other, they communicate through a centralized mediator object, 
                  they communicate through a centralized mediator object. 
                  The mediator acts as an intermediary and coordinates the interactions between the objects.
             */

            var chatMediator = new ChatMediator();

            var user1 = new ChatUser(chatMediator, "User 1");
            var user2 = new ChatUser(chatMediator, "User 2");
            var user3 = new ChatUser(chatMediator, "User 3");

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Hello everyone!");
            user2.SendMessage("Hi there!");

            Console.ReadLine();
        }
    }
}
