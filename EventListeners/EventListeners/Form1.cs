using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventListeners
{
    public partial class Form1 : Form
    {
        private Lines lines = new Lines();
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Graphics dc = pictureBox1.CreateGraphics();
            MouseEventArgs e2 = (MouseEventArgs)e;
            lines.addCoordinates(e2.X, e2.Y, counter);
            if (counter == 10)
            {
                lines.emptyCoordinates();
                counter = 0;
                dc.Clear(Color.White);
            }
            else if (counter > 0)
            {
                lines.drawLine(dc, counter);
            }
            counter++;
        }
    }
}
