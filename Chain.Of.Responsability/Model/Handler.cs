using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsability
{
    internal abstract class Handler
    {
        protected Handler _handler;

        public void AddNextHandler(Handler next)
        {
            _handler = next;
        }

        public abstract void Process(Purchase c);
    }
}
