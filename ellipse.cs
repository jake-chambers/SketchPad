using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad
{
    public class ellipse : shape
    {
        int x;
        int y;
        int width;
        int height;
        Color c;

        public ellipse() 
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            c = Color.White;
        }
        public ellipse(int newX, int newY, int newWidth, int newHeight, Color newColour)
        {
            x = newX;
            y = newY;
            width = newWidth;
            height = newHeight;
            c = newColour;
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
            x = t;
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
