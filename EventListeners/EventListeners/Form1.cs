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
        private int clickCount = 0;
        private int[][] coordinates = new int[9][];
        public Form1()
        {
            InitializeComponent();
        }

        private void drawLines(object sender, EventArgs e)
        {
            MouseEventArgs coord = (MouseEventArgs)e;
            Point mouseCoordinates = coord.Location;
            if (clickCount == 10)
            {
                Array.Clear(coordinates, 0, 9);
            }
            else
            {
                coordinates[clickCount, 0] = mouseCoordinates.X;
                coordinates[clickCount, 1] = mouseCoordinates.Y;
            }
            clickCount++;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            {
                Pen blackPen = new Pen(Color.Black, 3);
                for (int i = 0; i < coordinates.Length; i++)
                {
                    Console.WriteLine(coordinates[i]);
                    //if (coordinates[i][0] != null && coordinates[i][1] != null && i != 0)
                    //{
                    //    e.Graphics.DrawLine(blackPen, coordinates[i][0], coordinates[i][1], coordinates[i - 1][0], coordinates[i - 1][1]);
                    //}
                }
            }
        }
    }
}
