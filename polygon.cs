using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad
{
    public class polygon
    {
        Point[] pointArray = new Point[20];
        public int size = 0;
        Color c;
        public polygon()
        {
            size = 0;
            c = Color.White;
            for (int i = 0; i < 20; i++)
            {
                pointArray[i] = new Point(0, 0);
            }
        }
        public void setPoint(int x, int y, Color colour)
        {
            try
            {
                pointArray[size] = new Point(x, y);
                c = colour;
                size++;
            }
            catch (Exception e)
            {
            }
        }
        public void setMovePoint(int x, int y, int t)
        {
            try
            {
                pointArray[t] = new Point(x, y);
            }
            catch (Exception e)
            {
            }
        }
        public Color getColor()
        {
            return c;
        }
        public void setColor(Color col)
        {
            c = col;
        }
        public Point getPoint(int t)
        {
            return pointArray[t];
        }
        public int getSize()
        {
            return size;
        }
        public void setSize(int s)
        {
            size = s;
        }
    }
}
