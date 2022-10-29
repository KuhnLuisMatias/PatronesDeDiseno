using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mementor
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public Memento saveMemento()
        {
            Console.WriteLine("Originator: Guardado memento para "+ Nombre);
            return new Memento(Nombre);
        }

        public void RestoreMemento(Memento memento)
        {
            Nombre = memento.Nombre;
            Console.WriteLine("Originator: Recuperando memento "+ Nombre);
        }
    }
}
