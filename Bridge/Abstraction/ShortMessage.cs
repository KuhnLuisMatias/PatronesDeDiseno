using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction
{
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessage message) 
        {
            this._message = message;
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine("SMS Short sended.");
        }
    }
}
