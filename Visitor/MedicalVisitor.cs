using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class MedicalVisitor : IVisitor
    {
        public string Name { get; set; }
        public MedicalVisitor(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            var patient = (Patient) element;
            Console.WriteLine($"The medical visitor {this.Name} made  a medical visit to his patient : {patient.Name}",this,patient);
        }
    }
}
