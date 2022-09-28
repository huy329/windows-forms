using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String movie = (checkBox_Movie.Checked == true) ? "Bạn thích xem phim " + comboBox_Movie.Text + "." : "Không thích xem phim.";
            String sport = (checkBox_Sport.Checked == true) ? "Bạn thích thể thao " + textBox_Sport.Text + "." : "Không thích thể thao.";
            String radio = (radio_Male.Checked == true) ? "Nam" : "Nữ";
            String aDate = dateTime_Birthday.Value.ToString("yyyy");

            MessageBox.Show("Bạn là Nam, Bạn sinh năm " + aDate + ".\n" + movie + "\n" + sport);
        }

        private void checkBox_Movie_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Movie.Checked == true)
            {
                comboBox_Movie.Enabled = true;
            }
            else
            {
                comboBox_Movie.Enabled = false;
            }
        }

        private void checkBox_Sport_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Sport.Checked == true)
            {
                textBox_Sport.Enabled = true;
            }
            else
            {
                textBox_Sport.Enabled = false;
            }
        }
    }
}
