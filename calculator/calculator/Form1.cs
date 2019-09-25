using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //add number to screen
        private void addNumberToString(object sender, EventArgs e)
        {
            calculateTextBox.Text += ((Button)sender).Text;
        }

        //clear textbox
        private void BtnClear_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text = "";
        }

        //calculate string
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (calculateTextBox.Text != "")
            {
                try
                {
                    calculateTextBox.Text = new DataTable().Compute(calculateTextBox.Text, null).ToString();
                }
                catch (EvaluateException)
                {
                    calculateTextBox.Text = "Syntax Error";
                }
            }
            else
            {
                MessageBox.Show("Input can't be empty!");
            }
        }

        //operator button
        private void addOperator(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "x")
            {
                calculateTextBox.Text += "*";
            }
            else
            {
                calculateTextBox.Text += ((Button)sender).Text;
            }
        }
    }
}
