using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtenMoves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            int y = r.Next(1, 400);
            int x = r.Next(1, 600);

            button1.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
