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
    public partial class Mathv : Form
    {
        public Mathv()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            int correct = 0;
            three.Text = "0";
            half.Text = "0";
            six.Text = "0";
            pie.Text = "0";
            length.Text = "0";
            ninty.Text = "0";
            if (three.Text == "3")
            {
                correct = correct + 1;
            }
            if (half.Text == "0.5*b*h")
            {
                correct = correct + 1;
               
            }
            if (six.Text == "6")
            {
                correct = correct + 1;
              
            }
            if (pie.Text == "pi*r^2")
            {
                correct = correct + 1;
            
            }
            if (length.Text == "b*h")
            {
                correct = correct + 1;
               
            }
            if (ninty.Text == "90")
            {
                correct = correct + 1;
               
            }

            DialogResult res = MessageBox.Show("Amount of answers you got correct: " + correct, "Results", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.No) ;
        }
    }
}
