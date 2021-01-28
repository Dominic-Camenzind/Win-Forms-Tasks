using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "" + trackBar1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            trackBar1.Value = Convert.ToInt32(textBox1.Text);
        }
    }
}
