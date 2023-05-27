using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patient = new Patient("Matias");
            var medicalVisitor = new MedicalVisitor("Favarolo");

            patient.Accept(medicalVisitor);

            var salesMan = new SalesVisitor("John");
            patient.Accept(salesMan);

            Console.ReadLine();
        }
    }
}
