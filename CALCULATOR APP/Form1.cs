using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Error....!Enter Two Numbers");
            }
            else
            {

                float n1 = float.Parse(textBox1.Text);
                float n2 = float.Parse(textBox2.Text);

                float sum = n1 + n2;
                ans.Text = sum.ToString();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") 
            {
                MessageBox.Show("Error....!Enter Two Numbers");
            }
            
            else if(textBox1.Text == "" || textBox2.Text == "0")
            {
                MessageBox.Show("Mathematical Error....! ");
                MessageBox.Show("Mathematical Error....!Divisor can't be 0 ");
            }

            else {
                float n1 = float.Parse(textBox1.Text);
                float n2 = float.Parse(textBox2.Text);

                float sum = n1 / n2;
                ans.Text = sum.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "") {
                MessageBox.Show("Error....!Enter Two Numbers");
            }
            else
            {
                float n1 = float.Parse(textBox1.Text);
                float n2 = float.Parse(textBox2.Text);

                float sum = n1 - n2;
                ans.Text = sum.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") {
                MessageBox.Show("Error....!Enter Two Numbers");
            }
            else if (textBox1.Text == "" || textBox2.Text == "0")
            {
                MessageBox.Show("Mathematical Error....! ");
                MessageBox.Show("Mathematical Error....!Divisor can't be 0 ");
            }



            else
            {
                float n1 = float.Parse(textBox1.Text);
                float n2 = float.Parse(textBox2.Text);

                float sum = n1 % n2;
                ans.Text = sum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") {
                MessageBox.Show("Error....!Enter Two Numbers");
            }
            else
            {
                float n1 = float.Parse(textBox1.Text);
                float n2 = float.Parse(textBox2.Text);

                float sum = n1 * n2;
                ans.Text = sum.ToString();
            }
            }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") {
                MessageBox.Show("Error....!Enter Two Numbers");
            }
            else
            {
                float n1 = float.Parse(textBox1.Text);
                float n2 = float.Parse(textBox2.Text);
                float value = 1;
                for (int i = 1; i <= n2; i++)
                {
                    value = value * n1;
                }
                ans.Text = value.ToString();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
