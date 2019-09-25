using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spinnerApp
{
    public partial class Form1 : Form
    {
        private int count = 0;
        ErrorProvider error = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (numericUpDown1.Value)
            {
                case var n when (n >= 1 && n <= 10):
                    while (count < numericUpDown1.Value)
                    {
                        textBox1.AppendText(textBox2.Text);
                        textBox1.AppendText(Environment.NewLine);
                        count++;
                    }
                    break;
                case var n when (n >= 10 && n <= 20):
                    do
                    {
                        textBox1.AppendText(textBox2.Text);
                        textBox1.AppendText(Environment.NewLine);
                        count++;
                    }
                    while (count < numericUpDown1.Value);
                    break;
                case var n when (n >= 20 && n <= 30):
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        textBox1.AppendText(textBox2.Text);
                        textBox1.AppendText(Environment.NewLine);
                    }
                    break;
                case var n when n > 30:
                    error.SetError(numericUpDown1, "Overload!");
                    break;
                default:
                    MessageBox.Show("Please choose a number!");
                    break;
            }
        }
    }
}
