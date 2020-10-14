using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OperandItem:Item, IOperand
    {
        public double ToDouble(){
            return Double.Parse(this.Value);
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
