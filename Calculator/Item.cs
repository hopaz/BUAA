using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Item : IItem
    {
        public string Name;
        public string Value;
        public string ItemType()
        {
            //GetType是Object类的方法，所有类继承自Object，故重写
            if (Value == "+" || Value == "-" || Value == "*" || Value == "/" || Value == "(" || Value == ")")
            {
                return "Operator";
            }
            else {
                return "Operand";
            }
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
