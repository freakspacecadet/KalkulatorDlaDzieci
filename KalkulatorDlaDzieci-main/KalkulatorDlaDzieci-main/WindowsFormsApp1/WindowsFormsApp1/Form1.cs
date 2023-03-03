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
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        double x;
        double y;
        double result;
        double number;
        int n2;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            if (double.TryParse(textBox1.Text, out number))
            {
                x = Convert.ToDouble(textBox1.Text);
                //textBox3.Text = "0";
            }
            else {
                textBox3.Text = ":(";
                x = 0;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = " ";
            if (double.TryParse(textBox2.Text, out number))
            {
                y = Convert.ToDouble(textBox2.Text);
                //textBox3.Text = "0";
            }
            else
            {
                textBox3.Text = ":(";
                y = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    textBox3.Text = Convert.ToString(String.Format("{0:0.000}", x + y));
                }
                else if (int.TryParse(textBox2.Text, out n2))
                {
                    textBox3.Text = Convert.ToString(String.Format("{0:0}", x + y));
                }
                else
                {
                    textBox3.Text = ":(";
                }
            }
            if (radioButton2.Checked)
            {
                if (checkBox1.Checked)
                {
                    textBox3.Text = Convert.ToString(String.Format("{0:0.000}", x - y));
                }
                else if (int.TryParse(textBox2.Text, out n2)) {
                        textBox3.Text = Convert.ToString(String.Format("{0:0}", x - y));
                }
                else
                {
                    textBox3.Text = ":(";
                }
            }
            if (radioButton3.Checked)
            {
                if (checkBox1.Checked)
                {
                    textBox3.Text = Convert.ToString(String.Format("{0:0.000}", x * y));
                }
                else if (int.TryParse(textBox2.Text, out n2))
                {
                    textBox3.Text = Convert.ToString(String.Format("{0:0}", x * y));
                }
                else
                {
                    textBox3.Text = ":(";
                }
            }
            if (radioButton4.Checked)
            {
                
                double x1 = Convert.ToDouble(x);
                double y1 = Convert.ToDouble(y);
                int x2 = Convert.ToInt32(x);
                int y2 = Convert.ToInt32(y);
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
                    textBox3.Text = Convert.ToString(x2 / y2);
                }
                
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = " ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = " ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = " ";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
