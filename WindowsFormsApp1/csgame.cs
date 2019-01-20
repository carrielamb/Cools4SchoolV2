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
    public partial class csgame : Form
    {
        public csgame()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            int correct = 0;
            piee.Text = "0";
            held.Text = "0";
            end.Text = "0";
            loop.Text = "0";
            stat.Text = "0";
            arr.Text = "0";
            if (piee.Text == "Double")
            {
                correct = correct + 1;
            }
            if (held.Text == "Variable")
            {
                correct = correct + 1;

            }
            if (end.Text == "Semicolon")
            {
                correct = correct + 1;

            }
            if (loop.Text == "While")
            {
                correct = correct + 1;

            }
            if (stat.Text == "No")
            {
                correct = correct + 1;

            }
            if (arr.Text == "0")
            {
                correct = correct + 1;

            }


        }
    }
    
}

