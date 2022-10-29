using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mementor
{
    internal class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento memento)
        {
            mementoList.Add(memento);
        }

        public Memento GetMememento(int index)
        {
            return mementoList[index];
        }

    }
}
