using Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Model
{
    public class ChatUser : IUser
    {
        private IChatMediator mediator;
        private string name;

        public ChatUser(IChatMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} received message: {message}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{name} sent message: {message}");
            mediator.SendMessage(message, this);
        }
    }
}
