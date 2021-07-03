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
        private double memory_button;

        public Body()
        {
            InitializeComponent();

            //Memory Buttons
            MClear.Enabled = false;
            MRead.Enabled = false;
        }

        // Numerical Buttons
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
            Result.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
            values = 0;
            Result.Text = "";
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
                case "1/x":
                    textbox.Text = (1 / values).ToString();
                    break;
                case "^":
                    textbox.Text = (Math.Pow(values, Double.Parse(textbox.Text))).ToString();
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

        // Memory Saved Button
        private void MSaved_Click(object sender, EventArgs e)
        {
            memory_button = Double.Parse(textbox.Text);
            MClear.Enabled = true;
            MRead.Enabled = true;
        }

        // Memory Clear Button
        private void MClear_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
            memory_button = 0;
            MClear.Enabled = false;
            MRead.Enabled = false;
        }

        // Memory Read Button
        private void MRead_Click(object sender, EventArgs e)
        {
            textbox.Text = memory_button.ToString();
        }

        // Memory Add Button
        private void MPlus_Click(object sender, EventArgs e)
        {
            memory_button = memory_button + Double.Parse(textbox.Text);
            MRead.Enabled = true;
        }

        //Memory Subtract Button
        private void MSubtract_Click(object sender, EventArgs e)
        {
            memory_button = memory_button - Double.Parse(textbox.Text);
            MRead.Enabled = true;
        }
    }
}


