using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.student.Count; i++)
            {
                Student obj = (Student)Form1.student[i];
                string temp = obj.getName();
                comboBox1.Items.Add(temp);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = comboBox1.Text;

            for (int i = 0; i < Form1.student.Count; i++)
            {
                Student obj = (Student)Form1.student[i];
                string tempName = obj.getName();
                if (tempName.Equals(s))
                {
                    labelName.Text = ((Student)obj).name;
                    labelBirth.Text = (((Student)obj).birthDay).ToString();
                    labelGender.Text = ((Student)obj).gender;
                    labelBornIn.Text = ((Student)obj).bornIn;
                }
            }
        }

        private void labelGender_Click(object sender, EventArgs e)
        {

        }
    }
}
