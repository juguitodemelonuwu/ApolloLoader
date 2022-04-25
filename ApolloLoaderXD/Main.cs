using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using System.Diagnostics;
using System.Net;

namespace ApolloLoaderXD
{
    public partial class Main : MetroSetForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(73, 65, 163);
            button2.ForeColor = Color.FromArgb(73, 65, 163);
            Home.ForeColor = Color.FromArgb(113, 65, 209);
            panel4.Hide();
            panel3.Hide();
            panel2.Show();
            button3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home.ForeColor = Color.FromArgb(73, 65, 163);
            button2.ForeColor = Color.FromArgb(73, 65, 163);
            button1.ForeColor = Color.FromArgb(113, 65, 209);
            panel2.Hide();
            button3.Hide();
            panel4.Hide();
            panel3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home.ForeColor = Color.FromArgb(73, 65, 163);
            button1.ForeColor = Color.FromArgb(73, 65, 163);
            button2.ForeColor = Color.FromArgb(113, 65, 209);
            panel2.Hide();
            button3.Hide();
            panel4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            //richTextBox1.Text = wc.DownloadString("changelog raw text url");
            button1.ForeColor = Color.FromArgb(73, 65, 163);
            button2.ForeColor = Color.FromArgb(73, 65, 163);
            Home.ForeColor = Color.FromArgb(113, 65, 209);
            panel4.Hide();
            panel3.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/anticrash");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/blazesclient");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/invite/EjtzxjTMFG");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/sUWBBpSuwK");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/8sZwrRJDfX");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Process.Start("https://meap.gg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/3fb8eSB9Q7");
        }
    }
}
