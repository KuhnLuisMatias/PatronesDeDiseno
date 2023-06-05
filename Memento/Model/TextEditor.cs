using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public EditorMemento Save()
        {
            return new EditorMemento(text);
        }

        public void Restore(EditorMemento memento)
        {
            text = memento.Text;
        }
    }
}
