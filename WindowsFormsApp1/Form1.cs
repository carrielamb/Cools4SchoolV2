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
    public partial class Login1 : Form
    {
     
        public Login1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "Castle.PNG";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            usernamebox.Visible = false;
            passwordbox.Visible = false;
            string[] users = new string[30];
            users[0] = "carrieL";
            users[1] = "samaA";
            users[2] = "kellyF";
            users[3] = "marinaF";
            string[] pass = new string[30];
            pass[0] = "jones3";
            pass[1] = "jones3";
            pass[2] = "jones3";
            pass[3] = "jones3";
            String username = usernamebox.Text;
            String password = passwordbox.Text;
            bool loggedin = false;
            for (int i = 0; i < 30; i++)
            {
                if (username == users[i])
                {
                    if (password == pass[i])
                    {
                        loggedin = true;
                        Console.WriteLine("Welcome back!");
                        Console.WriteLine("Have you taken your placement test? (Yes/No)");
                        String placementPrompt = Console.ReadLine();

                        welcome.Text = "Welcome Back";
                        placementprompt();


                    }
                    else
                    {
                        welcome.Text = "INVALID";
                    }
                }
            }

        }

        private void welcome_Click(object sender, EventArgs e)
        {
            
        }
        static void placementprompt()
        {
            DialogResult res = MessageBox.Show("Have you taken the placement test?", "Placement Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
            {
                placementtest pullup = new placementtest();
                pullup.Show();

            }
            else
            {
                opengame openup = new opengame();
                openup.Show();
            }

        }



        
    }

    
}


