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
        Double results = 0;
        String operation = "";
        bool OperationPerformed = false;


        public Body()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textbox.Text == "0") || (OperationPerformed))
                textbox.Clear();

            OperationPerformed = false;
            Button num = (Button)sender;
            textbox.Text = textbox.Text + num.Text;
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
            operation = num.Text;
            results = Double.Parse(textbox.Text);
            Result.Text = results + " " + operation;
            OperationPerformed = true;
        }


        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
            results = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textbox.Text = (results + Double.Parse(textbox.Text)).ToString();
                    break;
                case "-":
                    textbox.Text = (results - Double.Parse(textbox.Text)).ToString();
                    break;
                case "*":
                    textbox.Text = (results * Double.Parse(textbox.Text)).ToString();
                    break;
                case "/":
                    textbox.Text = (results / Double.Parse(textbox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}


