using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAPMAKİNESİ1
{
    public partial class Form1 : Form
    {
        double x, y;
        string z;
        public static double sayı = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            x = Convert.ToDouble(textBox1.Text);
            textBox1.ResetText();
            z = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            x = Convert.ToDouble(textBox1.Text);
            textBox1.ResetText();
            z = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            x = Convert.ToDouble(textBox1.Text);
            textBox1.ResetText();
            z = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            x = Convert.ToDouble(textBox1.Text);
            textBox1.ResetText();
            z = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains('.') == false)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox1.Text);
            if (z == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
            }
            if (z == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
            }
            if (z == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
            }
            if (z == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
            }
        }
    }
}
