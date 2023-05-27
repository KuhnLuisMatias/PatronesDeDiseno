using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementor
{
    public class SmsMessageSender : IMessage
    {

        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS Message: {message}");
        }
    }
}
