using Bridge.Abstraction;
using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessage message = new SmsMessageSender();
            ShortMessage shortMessage = new ShortMessage(message);
            shortMessage.SendMessage("Test");

            Console.ReadLine();
        }
    }
}