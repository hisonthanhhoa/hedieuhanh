using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace hedieuhanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        private void btnpaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void btnPP_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName(comboBox1.Text)) 
            process.Kill();
        }
    }
}
