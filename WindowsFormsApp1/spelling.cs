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
    public partial class spelling : Form
    {
        public spelling()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            int correct = 0;
            move.Text = "0";
            proj.Text = "0";
            closet.Text = "0";
            eat.Text = "0";
            rose.Text = "0";
            car.Text = "0";
            if (move.Text == "Transport")
            {
                correct = correct + 1;
            }
            if (proj.Text == "Project")
            {
                correct = correct + 1;

            }
            if (closet.Text == "Wardobe")
            {
                correct = correct + 1;

            }
            if (eat.Text == "Consume")
            {
                correct = correct + 1;

            }
            if (rose.Text == "Garden")
            {
                correct = correct + 1;

            }
            if (car.Text == "Vehicle")
            {
                correct = correct + 1;

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thankyou openup = new Thankyou();
            openup.Show();
        }
    }
    
}
