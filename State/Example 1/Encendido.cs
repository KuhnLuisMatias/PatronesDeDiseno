using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class On : Estado
    {
        public override void ChangeState(Switch sw)
        {
            sw.SetState(new Off());
        }

        public override string Describe()
        {
            return "Switch On";
        }
    }
}
