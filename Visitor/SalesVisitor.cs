using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class SalesVisitor : IVisitor
    {
        public string Name { get; set; }
        public SalesVisitor(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            var visit = (Patient)element;
            Console.WriteLine($"The Sales man {this.Name} did the visit to his customer {visit.Name}",this,visit);
        }
    }
}
