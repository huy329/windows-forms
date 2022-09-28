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
    public partial class Form1 : Form
    {
        DbHelper db = new DbHelper();

        public Form1()
        {
            InitializeComponent();
            dataGridView.DataSource = db.Students.ToList();
        }

        

        private void add_Click(object sender, EventArgs e)
        {
            String name = inputName.Text;
            String email = inputEmail.Text;
            Boolean gender = true;
            DateTime date = inputDate.Value;

            if (radioFemale.Checked)
            {
                gender = false;
            }

            Student student = new Student()
            {
                Name = name,
                Email = email,
                Male = gender,
                Birthday = date
            };

            db.Students.Add(student);
            db.SaveChanges();

            dataGridView.DataSource = db.Students.ToList();
            
            MessageBox.Show("Success");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count == 0) return;

            int index = dataGridView.SelectedRows[0].Index;
            int studentAtIndex = (int)dataGridView.Rows[index].Cells[0].Value;

            DialogResult a = MessageBox.Show("Are u sure ?", "Confirm",MessageBoxButtons.YesNo);

            if(a == DialogResult.Yes)
            {
                Student s = db.Students.Where(o => o.ID == studentAtIndex).First();
                db.Students.Remove(s);
                db.SaveChanges();

                dataGridView.DataSource = db.Students.ToList();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputName.Text = "";
            inputEmail.Text = "";
            dataGridView.ClearSelection();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            int index = dataGridView.SelectedRows[0].Index;
            int studentAtIndex = (int)dataGridView.Rows[index].Cells[0].Value;

            String name = inputName.Text;
            String email = inputEmail.Text;
            Boolean gender = true;
            DateTime date = inputDate.Value;

            if (radioFemale.Checked)
            {
                gender = false;
            }

            DialogResult a = MessageBox.Show("Are u sure ?", "Confirm", MessageBoxButtons.YesNo);

            if (a == DialogResult.Yes)
            {
                Student s = db.Students.Where(o => o.ID == studentAtIndex).First();
                db.Students.Remove(s);

                Student student = new Student()
                {
                    Name = name,
                    Email = email,
                    Male = gender,
                    Birthday = date
                };

                db.Students.Add(student);

                db.SaveChanges();

                dataGridView.DataSource = db.Students.ToList();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                add.Enabled = true;
                delete.Enabled = false;
                clear.Enabled = false;
                update.Enabled = false;
                return;
            }

            if(dataGridView.SelectedRows.Count > 0) {
                add.Enabled = false;
                delete.Enabled = true;
                clear.Enabled = true;
                update.Enabled = true;
            }

            int index = dataGridView.SelectedRows[0].Index;
            string name = (string)dataGridView.Rows[index].Cells[1].Value;
            string email = (string)dataGridView.Rows[index].Cells[3].Value;

            inputName.Text = name;
            inputEmail.Text = email;
        }
    }
}
