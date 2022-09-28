using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;

            if (!string.IsNullOrEmpty(url))
            {
                Thread thread = new Thread(() =>
                {
                    string remoteUri = textBox1.Text;
                    string fileName = Path.GetFileName(remoteUri);
                    // Create a new WebClient instance.
                    WebClient myWebClient = new WebClient();
                    myWebClient.DownloadFile(remoteUri, fileName);
                    listBox1.Items.Add(fileName);
                    label2.Text = listBox1.Items.Count.ToString() + " download(s) in progress";
                });
                thread.Start();
            }
        }
    }
}
