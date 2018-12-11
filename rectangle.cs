using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad
{
    public class rectangle : shape
    {
        int x;
        int y;
        int width;
        int height;
        Color c;

        public rectangle()
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            c = Color.White;
        }
        public rectangle(int myX, int myY, int myWidth, int myHeight, Color col)
        {
            x = myX;
            y = myY;
            width = myWidth;
            height = myHeight;
            c = col;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }
        public Color getColor()
        {
            return c;
        }
        public void setColor(Color col)
        {
            c = col;
        }
        public void setX(int t)
        {
            System.Console.Write("I will attempt to set x to: " + t +"\n");
            x = t;
            System.Console.Write("I have just set x to: " + x+"\n");
        }
        public void setY(int t)
        {
            y = t;
        }
        public void setWidth(int t)
        {
            width = t;
        }
        public void setHeight(int t)
        {
            height = t;
        }
    }
}
