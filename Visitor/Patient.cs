using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Patient : IElement
    {
        public string Name { get; set; }
        public Patient(string name)
        {
            Name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
