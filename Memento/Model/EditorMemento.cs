using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class EditorMemento
    {
        public string Text { get; }

        public EditorMemento(string text)
        {
            Text = text;
        }
    }
}
