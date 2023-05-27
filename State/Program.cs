using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            Switch sw = new Switch();
            sw.Click();
            sw.Click();
            #endregion

            #region Example 2
            #endregion

            Console.ReadKey();
        }
    }
}
