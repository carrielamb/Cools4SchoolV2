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
    public partial class opengame : Form
    {
        public opengame()
        {
            InitializeComponent();
        }

        private void opengame_Load(object sender, EventArgs e)
        {
            
        }

        private void gamechoice_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mathv openup = new Mathv();
            openup.Show();
        }
        static void rungame()
        {
            Mathv openup = new Mathv();
            openup.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            csgame openup = new csgame();
            openup.Show();
        }
    }
}


