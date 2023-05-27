using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Switch
    {
        private Estado _state;

        public Switch()
        {
            _state = new On();
        }

        public void SetState(Estado state)
        {
            _state = state;
        }

        public void Click()
        {
            _state.ChangeState(this);
            Console.WriteLine(_state.Describe());
        }
    }
}
