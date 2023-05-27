using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            
            Observr user1 = new Observr("Anurag");
            subject.RegisterObserver(user1);
            
            Observr user2 = new Observr("Pranaya");
            subject.RegisterObserver(user2);

            Observr user3 = new Observr("Priyanka");
            subject.RegisterObserver(user3);

            Console.WriteLine("Red MI Mobile current state : " + subject.GetAvailability());
            Console.WriteLine();
            subject.RemoveObserver(user3);

            subject.SetAvailability("Available");
            Console.Read();
        }
    }
}
