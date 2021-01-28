using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void right_Click(object sender, EventArgs e)
        {
            list.Items.Add(combo.SelectedItem);
            combo.Items.Remove(combo.SelectedItem);
        }

        private void left_Click(object sender, EventArgs e)
        {
            combo.Items.Add(list.SelectedItem);
            list.Items.Remove(list.SelectedItem);
        }
    }
}
