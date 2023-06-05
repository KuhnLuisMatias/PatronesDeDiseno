using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class History
    {
        private Stack<EditorMemento> mementos = new Stack<EditorMemento>();

        public void Save(EditorMemento memento)
        {
            mementos.Push(memento);
        }

        public EditorMemento Undo()
        {
            return mementos.Pop();
        }
    }
}
