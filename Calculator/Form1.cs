using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "1";
            }
            else
            {
                textBox1.AppendText("1");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                str = str.Substring(0, str.Length - 1);
                textBox1.Text = str;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "9";
            }
            else
            {
                textBox1.AppendText("9");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String last_char = str.Substring(str.Length - 1, 1);
            String former_str = str.Substring(0, str.Length - 1);
            //Console.WriteLine("last_char={0}, former_strin={1}", last_char, former_str);
            if (last_char == "+" || last_char == "-" || last_char == "*" || last_char == "/")
            {
                textBox1.Text = former_str + "/";
            }
            else
            {
                textBox1.Text = str + "/";
            }    
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "0";
            }
            else
            {
                textBox1.AppendText("0");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "2";
            }
            else
            {
                textBox1.AppendText("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "3";
            }
            else
            {
                textBox1.AppendText("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "4";
            }
            else
            {
                textBox1.AppendText("4");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "5";
            }
            else
            {
                textBox1.AppendText("5");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "6";
            }
            else
            {
                textBox1.AppendText("6");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "7";
            }
            else
            {
                textBox1.AppendText("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "8";
            }
            else
            {
                textBox1.AppendText("8");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String last_char = str.Substring(str.Length - 1, 1);
            String former_str = str.Substring(0, str.Length - 1);
            //Console.WriteLine("last_char={0}, former_strin={1}", last_char, former_str);
            if (last_char == "+" || last_char == "-" || last_char == "*" || last_char == "/")
            {
                textBox1.Text = former_str + "+";
            }
            else {
                textBox1.Text = str + "+";
            }      
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String last_char = str.Substring(str.Length - 1, 1);
            String former_str = str.Substring(0, str.Length - 1);
            //Console.WriteLine("last_char={0}, former_strin={1}", last_char, former_str);
            if (last_char == "+" || last_char == "-" || last_char == "*" || last_char == "/")
            {
                textBox1.Text = former_str + "-";
            }
            else
            {
                textBox1.Text = str + "-";
            }    
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String last_char = str.Substring(str.Length - 1, 1);
            String former_str = str.Substring(0, str.Length - 1);
            //Console.WriteLine("last_char={0}, former_strin={1}", last_char, former_str);
            if (last_char == "+" || last_char == "-" || last_char == "*" || last_char == "/")
            {
                textBox1.Text = former_str + "*";
            }
            else
            {
                textBox1.Text = str + "*";
            }    
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        
        private void button19_Click_1(object sender, EventArgs e)
        {
            String expression_str = textBox1.Text;
            List<String> expression_list = new List<String>();
            String number_tmp = "";
            String OPERAND="0123456789.";
            String OPERATORS = "+-*/()";
            Regex reg_operand_int = new Regex(@"^[1-9][0-9]*$");
            Regex reg_operand_decimal = new Regex(@"^[0-9]{1,}[.][0-9]*$");
            Regex reg_operator = new Regex(@"^[\+\-\*/]$");

            ///<summary>
            ///表达式string转换成包含操作数+操作符的list
            ///<summary>
            Char last_char = expression_str[expression_str.Length - 1];
            if (last_char == '+' || last_char == '-' || last_char == '*' || last_char == '/')            {
                expression_str = expression_str.Remove(expression_str.Length - 1, 1);
            }
            Console.WriteLine(expression_str);
            int len = expression_str.Length;
            for(int i = 0; i < len; i++){
                Char c = expression_str[i];
                if (OPERAND.Contains(c)){
                    number_tmp = number_tmp + c;
                }else if(OPERATORS.Contains(c)){
                    if (number_tmp != "") {
                        expression_list.Add(number_tmp.ToString());
                        number_tmp = "";
                    }
                    expression_list.Add(c.ToString());
                }
                if(i == len - 1){
                    expression_list.Add(number_tmp.ToString());
                }
            }
            foreach (String s1 in expression_list) {
                Console.WriteLine(s1);
            }
            Console.WriteLine("1");

            ///<summary>
            ///调度场算法（中缀表达式转后缀表达式）
            ///<summary>
            //定义优先级
            Hashtable priority = new Hashtable();
            priority.Add("+", 1);
            priority.Add("-", 1);
            priority.Add("*", 2);
            priority.Add("/", 2);
            priority.Add("(", 3);
            //priority.Add(")", "3");

            List<String> expression_post_list = new List<string>();
            //符号栈
            Stack<String> s = new Stack<String>();

            for (int cnt = 0; cnt < expression_list.Count; cnt++) {
                if (reg_operand_int.IsMatch(expression_list[cnt]) || reg_operand_decimal.IsMatch(expression_list[cnt]))
                {
                    //是整数或小数，直接输出
                    expression_post_list.Add(expression_list[cnt]);
                }else if(reg_operator.IsMatch(expression_list[cnt])){
                    //是操作符,循环比较当前操作符与栈顶操作符优先级
                    while(s.Count != 0 && s.Peek() != "(" && (int)priority[expression_list[cnt]] <= (int)priority[s.Peek()]){
                        //当前操作符优先级等于或低于栈顶元素优先级，出栈直到高于栈顶元素优先级或栈空
                        //if (s.Peek() != "(")
                        //{
                            //栈顶元素不是"(",出栈
                            expression_post_list.Add(s.Pop().ToString());
                        //}
                        //栈顶元素是"(",不出栈
                    }
                    //当前栈空或操作符优先级高于栈顶元素优先级，入栈
                    s.Push(expression_list[cnt]);
                }else if(expression_list[cnt] == "("){
                    //是左括号，直接入栈
                    s.Push(expression_list[cnt]);
                }else if(expression_list[cnt] == ")"){
                    //是右括号，依次弹栈，直到遇到左括号
                    while (s.Peek().ToString() != "(")
                    {
                        expression_post_list.Add(s.Pop().ToString());
                    }
                    //"("也弹栈
                    s.Pop();
                }
            }

            while (s.Count != 0)
            {
                //输入数据已经读到末尾，栈中所有操作符出栈
                expression_post_list.Add(s.Pop().ToString());
            }

            Console.WriteLine();
            foreach(String item in expression_post_list){
                Console.WriteLine(item);
            }

            ///<summary>
            ///后缀表达式求值
            ///<summary>
            Stack<String> stk = new Stack<String>();
            Double mid_result = 0;
            for (int j = 0; j < expression_post_list.Count; j++)
            {
                if (reg_operand_int.IsMatch(expression_post_list[j]) || reg_operand_decimal.IsMatch(expression_post_list[j]))
                {
                    //是操作数，则入栈
                    stk.Push(expression_post_list[j]);
                }else if (reg_operator.IsMatch(expression_post_list[j])){
                    //是操作符，则出栈，计算结果再入栈
                    Double a = Double.Parse(stk.Pop());
                    Double b = Double.Parse(stk.Pop());
                    if (expression_post_list[j] == "+")
                    {
                        mid_result = b + a;
                    }
                    else if (expression_post_list[j] == "-")
                    {
                        mid_result = b - a;
                    }
                    else if (expression_post_list[j] == "*")
                    {
                        mid_result = b * a;
                    }
                    else if (expression_post_list[j] == "/")
                    {
                        mid_result = b / a;
                    }
                    stk.Push(mid_result.ToString());
                }else{
                    //非法字符
                    textBox1.Text = "出错";
                }
            }
            textBox1.Text = stk.Pop();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1){
                //expression_str不可以是多个0开头的数字
                textBox1.Text = "(";
            }else{
                textBox1.AppendText("(");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str[0].ToString() == "0" && textBox1.Text.Length == 1)
            {
                //expression_str不可以是多个0开头的数字
                textBox1.Text = ")";
            }
            else
            {
                textBox1.AppendText(")");
            }
        }
    }
}
