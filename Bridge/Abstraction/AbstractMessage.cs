using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction
{
    public abstract class AbstractMessage
    {
        protected IMessage _message;
        public abstract void SendMessage(string message);
    }
}
