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
    public partial class placementtest : Form
    {
       
        public placementtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show results//
           
         

            int math = 0;
            int correct = 0;
            int cs = 0;
            int eng = 0;
            this.Close();
            geoq.Text = "0";
            mq.Text = "0";
            vq.Text = "0";
            csq.Text = "0";
            if(geoq.Text == "4")
            {
                correct = correct + 1;
             
            }
            if(mq.Text == "16")
            {
                correct = correct + 1;
         
            }
            if(vq.Text == "Extend")
            {
                correct = correct + 1;
       
            }
            if(csq.Text == "char")
            {
                correct = correct + 1;
           
            }
            DialogResult res = MessageBox.Show("Amount of answers you got correct: " + correct, "Results", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.No) ;
        }
    }
}
