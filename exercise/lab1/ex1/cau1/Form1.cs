using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String username = txt_Username.Text;
            String password = txt_Password.Text;

            if(username.Length == 0)
            {
                MessageBox.Show("Please enter your username");
            }
            else if(password.Length == 0) {
                MessageBox.Show("Please enter your password");
            } 
            else if(username.Length < 6)
            {
                MessageBox.Show("Username must have at least 6 characters...");
            }
            else if(password.Length < 6)
            {
                MessageBox.Show("Password must have at least 6 characters...");
            }
            else if(username == "huyyyy" && password == "huyyyy")
            {
                MessageBox.Show("Welcome " + username + "! " + "Login successful!");
            } 
            else
            {
                MessageBox.Show("Username & password does not meet requirement");
            }
        }
    }
}
