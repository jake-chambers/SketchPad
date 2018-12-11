using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad
{
    public class squiggle : shape
    {
        Point[] pointsArray = new Point[500];
        public int size = 0;
        Color c;

        public squiggle()
        {
            size = 0;
            c = Color.White;
            for(int i = 0; i<500; i++)
            {
                pointsArray[i] = new Point(0, 0);
            }
        }
        public void setPoint(int x, int y, Color colour)
        {
            try
            {
                pointsArray[size] = new Point(x, y);
                c = colour;
                size++;
            }
            catch(Exception e)
            {
            }
        }
        public void setMovePoint(int x, int y, int t)
        {
            try
            {
                pointsArray[t] = new Point(x, y);
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
            return pointsArray[t];
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
