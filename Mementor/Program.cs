using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mementor
{
    internal class Program
    {
        static CareTaker caretaker = new CareTaker();
        static void Main(string[] args)
        {
            var persona = new Persona();
            persona.Nombre = "Matias";

            caretaker.Add(persona.saveMemento());

            Memento memento = caretaker.GetMememento(0);
            Console.WriteLine(memento.Nombre);

            persona.RestoreMemento(memento);
            Console.ReadKey();

        }
    }
}
