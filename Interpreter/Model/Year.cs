using Interpreter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Model
{
    public class Year : IExpression
    {
        public void Evaluate(Context context)
        {
            var Year = context.Expression;
            context.Expression = Year.Replace("YYYY",context.Date.Year.ToString());
        }
    }
}
