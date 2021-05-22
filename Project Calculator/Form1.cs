using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculator
{
    public partial class Body : Form
    {
        public Body()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtbx1.Text == "0")
               txtbx1.Clear();

            Button num = (Button)sender;
            txtbx1.Text = txtbx1.Text + num.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void operation_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
        }
    }
}
