using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x;
        int y;
        double result;
        int number;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out number))
            {
                x = Convert.ToInt32(textBox1.Text);
                textBox3.Text = "0";
            }
            else {
                textBox3.Text = "INT";
                x = 0;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out number))
            {
                y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = "0";
            }
            else
            {
                textBox3.Text = "INT";
                y = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Text = Convert.ToString(x + y);
            }
            if (radioButton2.Checked)
            {
                textBox3.Text = Convert.ToString(x - y);
            }
            if (radioButton3.Checked)
            {
                textBox3.Text = Convert.ToString(x * y);
            }
            if (radioButton4.Checked)
            {
                
                double x1 = Convert.ToDouble(x);
                double y1 = Convert.ToDouble(y);
                result = x1 / y1;

                if (checkBox1.Checked && y1 != 0) {
                    textBox3.Text = Convert.ToString(String.Format("{0:0.000}", result));
                }
                else if (y1 == 0)
                {
                    textBox3.Text = ":(";
                }
                else
                {
                    textBox3.Text = Convert.ToString(String.Format("{0:0}", result));
                }
                
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }
    }
}
