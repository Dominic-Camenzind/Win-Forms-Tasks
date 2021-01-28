using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReisedauerMond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            double result = 0;
            double speed = Convert.ToDouble(input.Text);

            result = 385000 / speed;

            if(indays.Checked)
            {
                result = result / 24;
            }

            output.Text = result.ToString();
        }
    }
}
