using Interpreter.Interface;
using Interpreter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ES:
                    El patrón de diseño Interpreter se utiliza para definir una gramática para un lenguaje y proporcionar 
                    una forma de evaluar expresiones escritas en ese lenguaje. 
                    Se utiliza principalmente en el campo del procesamiento de lenguaje natural, 
                    donde se pueden crear intérpretes para analizar y evaluar oraciones o comandos.

                EN:
                    The Interpreter design pattern is used to define a grammar for a language and provide 
                    a way to evaluate expressions written in that language. 
                    It is mainly used in the field of natural language processing, 
                    where interpreters can be created to parse and evaluate sentences or commands.
             */

            string[] formatExpression = { "DD/MM/YYYY", "MM/DD/YYYY", "YYYY/DD/MM", "YYYY/MM/DD" };
            Context context = new Context(DateTime.Now);
            
            List<IExpression> expressions = new List<IExpression>();
            expressions.Add(new Day());
            expressions.Add(new Month());
            expressions.Add(new Year());
            expressions.Add(new Separator());

            Console.WriteLine("Please select the date format to convert:");
            Console.WriteLine("1. {0}", formatExpression[0]);
            Console.WriteLine("2. {0}", formatExpression[1]);
            Console.WriteLine("3. {0}", formatExpression[2]);
            Console.WriteLine("4. {0}", formatExpression[3]);

            Console.WriteLine("\nSelected option:"); 
            var option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case 1:
                    context.Expression = formatExpression[0];
                    break;
                case 2:
                    context.Expression = formatExpression[1];
                    break;
                case 3:
                    context.Expression = formatExpression[2];
                    break;
                case 4:
                    context.Expression = formatExpression[3];
                    break;
                default:
                    Console.WriteLine("Input string was not in a correct format..");
                    break;
            }

            foreach (var expression in expressions)
            {
                expression.Evaluate(context);
            }

            Console.WriteLine($"Date converter: {context.Expression}");
            Console.ReadLine();
        }
    }
}
