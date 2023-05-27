using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal abstract class Estado
    {
        public abstract void ChangeState(Switch sw);
        public abstract string Describe();
    }
}
