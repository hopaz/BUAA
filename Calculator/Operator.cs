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
    public abstract class OperatorItem : Oper
    {
        public abstract double Calculate(OperandItem a, OperandItem b);
        public abstract int Priority();
    }
    class OperatorLParan : OperatorItem
    {
        public override double Calculate(OperandItem a, OperandItem b) { return 0; }
        public override string ToString() { return "("; }
        public override int Priority() { return 3; }
    }
    class OperatorRParan : OperatorItem
    {
        public override double Calculate(OperandItem a, OperandItem b) { return 0; }
        public override string ToString() { return ")"; }
        public override int Priority() { return 3; }
    }
    class OperatorAdd : OperatorItem, IOperator
    {
        public override double Calculate(OperandItem a, OperandItem b) { return a.ToDouble() + b.ToDouble(); }
        public override string ToString() { return "+"; }
        public override int Priority() { return 1; }
    }
    class OperatorSub : OperatorItem, IOperator
    {
        public override double Calculate(OperandItem a, OperandItem b) { return a.ToDouble() - b.ToDouble(); }
        public override string ToString() { return "-"; }
        public override int Priority() { return 1; }
    }
    class OperatorMul : OperatorItem, IOperator
    {
        public override double Calculate(OperandItem a, OperandItem b) { return a.ToDouble() * b.ToDouble(); }
        public override string ToString() { return "*"; }
        public override int Priority() { return 2; }
    }
    class OperatorDiv : OperatorItem, IOperator
    {
        public override double Calculate(OperandItem a, OperandItem b) { return a.ToDouble() / b.ToDouble(); }
        public override string ToString() { return "/"; }
        public override int Priority() { return 2; }
    }
}
