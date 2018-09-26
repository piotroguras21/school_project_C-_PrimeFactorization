using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeFactorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            int number, x=2;

            try
            {
                number = Convert.ToInt32(textBox1.Text);

                if (number <= 1) MessageBox.Show("Error: Enter number greater than 1!");
                else
                {
                    List<int> primefactors = new List<int>();
                    while (number > 1)
                    {
                        if (number % x == 0)
                        {
                            primefactors.Add(x);
                            number = number / x;
                        }
                        else
                        {
                            x = x + 1;
                        }
                    }
                    foreach (int p in primefactors)
                    {
                        textBox2.AppendText(p.ToString() + ' ');
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: It's not a number!");
                MessageBox.Show(exp.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mathsisfun.com/prime-factorization.html");
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 okno = new Form2();
            okno.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

     

        


       
    }
}
