using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public class GFX
    {
        private static Graphics gObject;

        public GFX(Graphics g)
        {
            gObject = g;
            setUpCanvas();
        }

        public static void setUpCanvas()
        {
            Brush bg = new SolidBrush(Color.White);
            Pen lines = new Pen(Color.Black, 3);

            gObject.FillRectangle(bg, new Rectangle(0,0,500,600));

            //vertical
            gObject.DrawLine(lines, new Point(0, 0), new Point(0, 500));
            gObject.DrawLine(lines, new Point(167, 0), new Point(167, 500));
            gObject.DrawLine(lines, new Point(334, 0), new Point(334, 500));
            gObject.DrawLine(lines, new Point(500, 0), new Point(500, 500));

            //horizontal
            gObject.DrawLine(lines, new Point(0, 0), new Point(500, 0));
            gObject.DrawLine(lines, new Point(0, 167), new Point(500, 167));
            gObject.DrawLine(lines, new Point(0, 334), new Point(500, 334));
            gObject.DrawLine(lines, new Point(0, 501), new Point(500, 501));

        }

        public static void drawX(Point location)
        {
            Pen xPen = new Pen(Color.Blue, 5);
            int xAbs = location.X * 167;
            int yAbs = location.Y * 167;

            gObject.DrawLine(xPen, xAbs + 10, yAbs + 10, xAbs + 147, yAbs + 147);

            gObject.DrawLine(xPen, xAbs + 147, yAbs + 10, xAbs + 10, yAbs + 147);
        }
        public static void drawO(Point location)
        {
            Pen oPen = new Pen(Color.Red, 5);
            int xAbs = location.X * 167;
            int yAbs = location.Y * 167;

            gObject.DrawEllipse(oPen, xAbs + 10, yAbs + 10, 147, 147);
        }
    }
}
