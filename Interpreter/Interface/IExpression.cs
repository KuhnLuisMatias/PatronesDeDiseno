using Interpreter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Interface
{
    public interface IExpression
    {
        void Evaluate(Context context);
    }
}
