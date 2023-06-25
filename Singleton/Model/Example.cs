using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Model
{
    public sealed class Example
    {
        private static int Counter = 0;
        private static Example Instance = null;
        public static Example GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Example();
            }
            return Instance;

        }
        
        //Constructor is Private means, from outside the class we cannot create an instance of this class
        private Example()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
