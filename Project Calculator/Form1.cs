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
        Double values = 0;
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
            if (num.Text == ".")
            {
                if (!textbox.Text.Contains("."))
                    textbox.Text = textbox.Text + num.Text;
            }
            else
            textbox.Text = textbox.Text + num.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (values != 0)
            {
                Equal.PerformClick();
                operation = num.Text;
                Result.Text = values + " " + operation;
                OperationPerformed = true;
            }
            else
            {

                operation = num.Text;
                values = Double.Parse(textbox.Text);
                Result.Text = values + " " + operation;
                OperationPerformed = true;
            }
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
            values = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textbox.Text = (values + Double.Parse(textbox.Text)).ToString();
                    break;
                case "-":
                    textbox.Text = (values - Double.Parse(textbox.Text)).ToString();
                    break;
                case "*":
                    textbox.Text = (values * Double.Parse(textbox.Text)).ToString();
                    break;
                case "/":
                    textbox.Text = (values / Double.Parse(textbox.Text)).ToString();
                    break;
                case "%":
                    textbox.Text = (values / 100).ToString();
                    break;
                case "^":
                    textbox.Text = (Math.Pow(values, Double.Parse(textbox.Text))).ToString();
                    break;
                case "1/x":
                    textbox.Text = (1 / values).ToString();
                    break;
                case "√":
                    textbox.Text = (Math.Sqrt(Double.Parse(textbox.Text))).ToString();
                    break;

                default:
                    break;
            }
            values = Double.Parse(textbox.Text);
            Result.Text = "";
        }
    }
}


