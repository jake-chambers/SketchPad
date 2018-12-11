using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad
{
    public class line : shape
    {
        Point p1;
        Point p2;
        Color c;

        public line()
        {
            p1 = new Point(0, 0);
            p2 = new Point(0, 0);
            c = Color.White;
        }
        public line(int p1x, int p1y, int p2x, int p2y)
        {
            p1 = new Point(p1x, p1y);
            p2 = new Point(p2x, p2y);
        }
        public void setPoint1(int p1x, int p1y, Color col)
        {
            p1 = new Point(p1x, p1y);
            c = col;
        }
        public void setPoint2(int p2x, int p2y)
        {
            p2 = new Point(p2x, p2y);
        }
        public Color getColor()
        {
            return c;
        }
        public void setColor(Color col)
        {
            c = col;
        }
        public Point getPoint1()
        {
            return p1;
        }
        public Point getPoint2()
        {
            return p2;
        }
    }
}
