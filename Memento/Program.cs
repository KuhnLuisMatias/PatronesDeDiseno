using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             ES:
                El patrón de diseño Memento se utiliza para capturar y almacenar el estado interno de un objeto sin violar su
                encapsulación, de modo que se pueda restaurar a ese estado en un momento posterior. 
                Proporciona una forma de guardar instantáneas del estado de un objeto y revertirlo a un estado anterior si es necesario.

             EN:
                The Memento design pattern is used to capture and store the internal state of an object without violating its
                encapsulation, so that it can be restored to that state at a later time. 
                It provides a way to store snapshots of an object's state and revert it to a previous state if necessary.
             */

            var editor = new TextEditor();
            var history = new History();

            editor.Text = "Hello World";
            var editorMemento = editor.Save();
            history.Save(editorMemento);
            
            editor.Text = "Goodbye World";
            editorMemento = history.Undo();
            editor.Restore(editorMemento);

            Console.WriteLine(editor.Text);  

            Console.ReadLine();
        }
    }
}
