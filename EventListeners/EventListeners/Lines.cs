using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventListeners
{
    class Lines
    {
        private PointF[] coordinates = new PointF[11];

        public void addCoordinates(int point1, int point2, int counter)
        {
            coordinates[counter] = new PointF(point1, point2);
        }

        public void emptyCoordinates()
        {
            Array.Clear(coordinates, 0, 9);
        }

        public void drawLine(Graphics gr, int counter)
        {
            if (coordinates[counter - 1].X != 0 && coordinates[counter - 1].Y != 0 && coordinates[counter].X != 0 && coordinates[counter].Y != 0)
            {
                Pen blackPen = new Pen(Color.Black, 2);
                gr.DrawLine(blackPen, coordinates[counter - 1], coordinates[counter]);
            }
        }
    }
}
