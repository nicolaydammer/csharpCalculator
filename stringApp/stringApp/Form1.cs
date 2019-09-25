using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string text = "Lorem ipsum dolor   sit amet, consectetur adipiscing elit, sed do eiusmod tempor  incididunt  ut labore  et dolore  magna aliqua";
            int count = 0;

            Console.WriteLine(text.Length);
            Console.WriteLine(text[4]);
            Console.WriteLine(text.ToUpper());
            Console.WriteLine();
            for (int i = 0; i < 14; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine(text.IndexOf("dolor", 0) + " " + "dolor".Length);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals("m"))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int count = 0;

            Console.WriteLine(text.Length);
            if (text.Length > 3)
            {
                Console.WriteLine(text[4]);
            }
            else
            {
                Console.WriteLine("your text is not long enough.");
            }
            Console.WriteLine(text.ToUpper());
            Console.WriteLine();
            if (text.Length > 14)
            {
                for (int i = 0; i < 14; i++)
                {
                    Console.Write(text[i]);
                }
            }
            else
            {
                Console.WriteLine("your text is not long enough.");
            }
            if (text.Contains("dolor"))
            {
                Console.WriteLine(text.IndexOf("dolor", 0) + " " + "dolor".Length);
            }
            else
            {
                Console.WriteLine("your text does not contain dolor");
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals("m"))
                {
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("does not contain letter M");
            }
            else
            {
                Console.WriteLine(count);
            }
            int count2 = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        count2++;
                        break;
                    case 'e':
                        count2++;
                        break;
                    case 'o':
                        count2++;
                        break;
                    case 'u':
                        count2++;
                        break;
                    case 'i':
                        count2++;
                        break;
                }
            }
            Console.WriteLine(count2 + " klinkers");
        }
    }
}
