using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double temp = 0;
        Double temp1 = 1;
        Int32 x = 0;
        String s;
        Double a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button4.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += button9.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += Convert.ToString(0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += ".";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //temp = 0;
            if (x == 2)
            {
                textBox1.Text = Convert.ToString(temp - Convert.ToDouble(textBox1.Text));

                temp = 0;
            }
            else if (x == 3)
            {
                textBox1.Text = Convert.ToString(temp1 / Convert.ToDouble(textBox1.Text));

                temp1 = 1;
            }
            else if (x == 4)
            {
                textBox1.Text = Convert.ToString(temp1 * Convert.ToDouble(textBox1.Text));

                temp1 = 1;
            }
            x = 1;
            temp = temp + Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = button13.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                textBox1.Text = Convert.ToString(temp + Convert.ToDouble(textBox1.Text));
                temp = 0;

            }
            else if (x == 2)
            {
                textBox1.Text = Convert.ToString(temp - Convert.ToDouble(textBox1.Text));
                
                temp = 0;
            }
            else if (x == 3)
            {
                textBox1.Text = Convert.ToString(temp1 / Convert.ToDouble(textBox1.Text));
               
                temp1 = 1;
            }
            else if (x == 4)
            {
                textBox1.Text = Convert.ToString(temp1 * Convert.ToDouble(textBox1.Text));
                
                temp1 = 1;
            }
            x = 0;
        }




        private void button10_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                textBox1.Text = Convert.ToString(temp + Convert.ToDouble(textBox1.Text));
                temp = 0;
            }
            else if (x == 3)
            {
                textBox1.Text = Convert.ToString(temp1 / Convert.ToDouble(textBox1.Text));

                temp1 = 1;
            }
            else if (x == 4)
            {
                textBox1.Text = Convert.ToString(temp1 * Convert.ToDouble(textBox1.Text));

                temp1 = 1;
            }
            
            x = 2;
            if (temp == 0)
                temp = temp + Convert.ToDouble(textBox1.Text);
            else
                temp = temp - Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = button10.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                textBox1.Text = Convert.ToString(temp + Convert.ToDouble(textBox1.Text));
                temp = 0;

            }
            else if (x == 2)
            {
                textBox1.Text = Convert.ToString(temp - Convert.ToDouble(textBox1.Text));

                temp = 0;
            }
           
            else if (x == 4)
            {
                textBox1.Text = Convert.ToString(temp1 * Convert.ToDouble(textBox1.Text));

                temp1 = 1;
            }
            x = 3;
           if(temp1==1)
            temp1 = temp1*Convert.ToDouble(textBox1.Text);
            else
               temp1 = temp1 / Convert.ToDouble(textBox1.Text);

            textBox1.Text = "";
            s = button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                textBox1.Text = Convert.ToString(temp + Convert.ToDouble(textBox1.Text));
                temp = 0;

            }
            else if (x == 2)
            {
                textBox1.Text = Convert.ToString(temp - Convert.ToDouble(textBox1.Text));

                temp = 0;
            }
            else if (x == 3)
            {
                textBox1.Text = Convert.ToString(temp1 / Convert.ToDouble(textBox1.Text));

                temp1 = 1;
            }
            x = 4;
            temp1 = temp1*Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = button11.Text;

        }

        private void button19_Click(object sender, EventArgs e)
        {Double a;
        if (s == "+")
        {
            a = temp + Convert.ToDouble(textBox1.Text) * temp / 100;
            textBox1.Text = Convert.ToString(a);
            s = null;
            temp = 0;
            x = 0;
        }
        if (s == "-")
        {
            a = temp - Convert.ToDouble(textBox1.Text) * temp / 100;
            textBox1.Text = Convert.ToString(a);
            s = null;
            temp = 0;
            x = 0;
        }
        if (s == "*")
        {
            a = temp1*Convert.ToDouble(textBox1.Text) * temp1 / 100;
            textBox1.Text = Convert.ToString(a);
            s = null;
            temp1 = 1;
            x = 0;
        }
        if (s == "/")
        {
            a = temp1 /(Convert.ToDouble(textBox1.Text) * temp1/ 100);
            textBox1.Text = Convert.ToString(a);
            s = null;
            temp1 = 1;
            x = 0;
        }


            
                

            

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Int32 i,l;
            String a = textBox1.Text;
            
            l = a.Length;
            textBox1.Text = "";
            for (i = 0; i < l - 1; i++)
            {
                textBox1.Text += a[i];
            }


        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text=Convert.ToString(Convert.ToDouble(1/Convert.ToDouble(textBox1.Text)));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            a = Math.Sqrt(a);
            textBox1.Text = Convert.ToString(a);
        }
    }
}
