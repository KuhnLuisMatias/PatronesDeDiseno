using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interface
{
    public interface IChatMediator
    {
        void SendMessage(string message, IUser user);
        void AddUser(IUser user);
    }
}
