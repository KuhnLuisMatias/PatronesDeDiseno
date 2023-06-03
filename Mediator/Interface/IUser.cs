using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interface
{
    public interface IUser
    {
        void ReceiveMessage(string message);
        void SendMessage(string message);
    }
}
