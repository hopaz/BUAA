using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            textBox1.AppendText("1");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String str;
            str = textBox1.Text;
            if (str.Length == 0)
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
            textBox1.AppendText("9");
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
            textBox1.AppendText("0");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
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

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            String expression_str = textBox1.Text;
            List<String> expression_list = new List<String>();
            String tmp = "";
            //表达式string转换成包含操作数+操作符的list
            if(expression_str[0].ToString() == "+" || expression_str[0].ToString() == "-"){
                    
            }
            //if(){
            //}


            for (int cnt = 0; cnt < expression_str.Length; cnt++) { 
                //调度场算法（中缀表达式转后缀表达式）
                if(expression_str[cnt].ToString() == "("){
                }
            }
        }
    }
}
