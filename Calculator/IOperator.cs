using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IOperator
    {
        double Calculate(OperandItem a, OperandItem b);
    }
}
