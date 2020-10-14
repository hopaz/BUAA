using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OperatorMul : OperandItem, IOperator
    {
        public double Calculate(OperandItem a, OperandItem b)
        {
            return a.ToDouble() * b.ToDouble();
        }
    }
}
