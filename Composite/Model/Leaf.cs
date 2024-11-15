﻿using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model
{
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Leaf(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"\tComponent Name: {Name} and Price: {Price}");
        }
    }
}
