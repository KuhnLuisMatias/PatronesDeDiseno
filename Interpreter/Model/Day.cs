﻿using Interpreter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Model
{
    public class Day : IExpression
    {
        public void Evaluate(Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("DD",context.Date.Day.ToString());
        }
    }
}
