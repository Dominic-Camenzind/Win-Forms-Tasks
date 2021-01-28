using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_1._2
{
    public partial class Form1 : Form
    {
        int i = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            list1.Items.Add(i + ": " + input.Text);
            i++;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            list1.Items.Remove(list1.SelectedItem);
        }
    }
}
