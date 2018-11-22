using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "K-Browser";
            //webBrowser1.Url = new Uri(@"https://www.google.com");
            webBrowser1.Url = new Uri(@"https://www.cnblogs.com");
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(comboBox1.Text);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            webBrowser1.Height = this.Height;
            webBrowser1.Width = this.Width - 18;
            comboBox1.Width = this.Width - 49;
        }
    }
}
