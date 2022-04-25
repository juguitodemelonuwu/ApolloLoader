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

namespace ApolloLoaderXD
{
    public partial class Form1 : MetroSetForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(73, 65, 163);
            button2.ForeColor = Color.FromArgb(73, 65, 163);
            Home.ForeColor = Color.FromArgb(113, 65, 209);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home.ForeColor = Color.FromArgb(73, 65, 163);
            button2.ForeColor = Color.FromArgb(73, 65, 163);
            button1.ForeColor = Color.FromArgb(113, 65, 209);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home.ForeColor = Color.FromArgb(73, 65, 163);
            button1.ForeColor = Color.FromArgb(73, 65, 163);
            button2.ForeColor = Color.FromArgb(113, 65, 209);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(73, 65, 163);
            button2.ForeColor = Color.FromArgb(73, 65, 163);
            Home.ForeColor = Color.FromArgb(113, 65, 209);
        }
    }
}
