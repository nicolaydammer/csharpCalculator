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

        private void Btn1_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 1;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 2;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 3;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 4;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 6;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 7;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 8;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 9;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += 0;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text = "";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (calculateTextBox.Text != "")
            {
                Calculate calculate = new Calculate(calculateTextBox.Text);
                calculateTextBox.Text = calculate.getCalculatedValue();
            }
            else
            {
                errorMsg errorMsg = new errorMsg();
                errorMsg.ShowDialog();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "+";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "-";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "*";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            calculateTextBox.Text += "/";
        }
    }
}
