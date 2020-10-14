using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IOperand
    {
        double ToDouble();
        bool IsValid();
    }

    public abstract class OperandItem : Oper, IOperand
    {
        public string Value;
        public OperandItem(string val)
        {
            this.Value = val;
        }
        public double ToDouble()
        {
            return Double.Parse(this.Value);
        }

        public bool IsValid()
        {
            return true;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }

    class OperandDbl : OperandItem
    {
        public OperandDbl(string val) : base(val) { }
    }
}
