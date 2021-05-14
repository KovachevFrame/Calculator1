using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калкулатор
{

    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "0";
            label1.Text += userInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            function = '.';
            first = userInput;
            userInput = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "1";
            label1.Text += userInput;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "2";
            label1.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "3";
            label1.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "4";
            label1.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "5";
            label1.Text += userInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "6";
            label1.Text += userInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "7";
            label1.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "8";
            label1.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "9";
            label1.Text += userInput;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //Plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                label1.Text = result.ToString();
            }
            //Minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                label1.Text = result.ToString();
            }
            //Divide
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    label1.Text = "Оо не";
                }
                else
                {
                    result = firstNum / secondNum;
                    label1.Text = result.ToString();
                }
                
            }

            //Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                label1.Text = result.ToString();
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            label1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }
    }
}
