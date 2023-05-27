using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Off : Estado
    {
        public override void ChangeState(Switch sw)
        {
            sw.SetState(new On());
        }

        public override string Describe()
        {
            return "Switch Off";
        }
    }
}
