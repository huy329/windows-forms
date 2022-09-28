using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public static ArrayList student = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            birthdate.ResetText();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            txtBorn.ResetText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }



        private void lbBirth_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (birthdate.Value.Year * 100 + birthdate.Value.Month) * 100 + birthdate.Value.Day;
            var c = (a - b) / 10000;

            //MessageBox.Show(c.ToString());
            if (txtName.Text.Length < 8 )
            {
                MessageBox.Show("Please enter again your name");
            }

            if(txtBorn.Text.Length == 0)
            {
                MessageBox.Show("Please enter again your place");
            }
            if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
               MessageBox.Show("Please choose your gender");
            }
            if( c > 30 || c < 18)
            {
                MessageBox.Show("Please enter again your age");
            }
            if(checkBox1.Checked == true)
            {
                student.Add(new Student(txtName.Text, birthdate.Value, "Male", txtBorn.Text));
            }
            else
            {
                student.Add(new Student(txtName.Text, birthdate.Value, "Female", txtBorn.Text));
            }

            if(txtName.Text.Length > 8 && txtBorn.Text.Length > 0 && 
                ((checkBox1.Checked == true || checkBox2.Checked == true) && (c < 30 && c > 18)))
            {
                linkLabel.Text = student.Count + " student(s) added";
            }
        }


        private void birthdate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }

        private void btnGender_Click(object sender, EventArgs e)
        {

        }
    }
}
