using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad
{
    public partial class Form1 : Form
    {
        public Color colour = Color.Black;
        public String mode = "";
        public Point point1;
        public Point point2;
        public Rectangle movingRect = new Rectangle();
        int rcounter = 0;
        int ecounter = 0;
        int lcounter = 0;
        int scounter = 0;
        int spoint = 0;
        int pcounter = 0;
        string type = "";
        int obj = 0;

        public SolidBrush currentBrush = new SolidBrush(Color.Black);
        public int x1, x2, y1, y2;
        public Boolean active = false;

        public Pen currentPen = new Pen(Color.Black, 1);
        public Graphics g;
        public int time = 0;
        public rectangle[] rectangleArray = new rectangle[20];
        public ellipse[] ellipseArray = new ellipse[20];
        public line[] lineArray = new line[20];
        public squiggle[] squiggleArray = new squiggle[20];
        public polygon[] polygonArray = new polygon[20];
        public Point clickedPoint = new Point(0, 0);



        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i<20; i++)
            {
                rectangleArray[i] = new rectangle();
            }
            for (int i = 0; i < 20; i++)
            {
                ellipseArray[i] = new ellipse();
            }
            for (int i = 0; i < 20; i++)
            {
                lineArray[i] = new line();
            }
            for(int i =0; i<20; i++)
            {
                squiggleArray[i] = new squiggle();
            }
            for (int i = 0; i < 20; i++)
            {
                polygonArray[i] = new polygon();
            }
        }
        public void DrawLine()
        {
            lineArray[lcounter] = new line(x1, y1, x2, y2);
            lineArray[lcounter].setColor(colour);
            lcounter++;
            drawPanel.Invalidate();
        }
        public void DrawRectangle()
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if ((x2 - x1) < (y2 - y1))
                {
                    rectangleArray[rcounter] = new rectangle(x1, y1, (x2 - x1), (x2-x1), colour);
                }
                else if((y2 - y1)< (x2 - x1))
                {
                    rectangleArray[rcounter] = new rectangle(x1, y1, (y2 - y1), (y2 - y1), colour);
                }
                else {
                    rectangleArray[rcounter] = new rectangle(x1, y1, (x2 - x1), (x2 - x1), colour);
                }
            }
            else
            {
                rectangleArray[rcounter] = new rectangle(x1, y1, (x2 - x1), (y2 - y1), colour);
            }
            rcounter++;
            drawPanel.Invalidate();
        }
        public void DrawEllipse()
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if ((x2 - x1) < (y2 - y1))
                {
                    ellipseArray[ecounter] = new ellipse(x1, y1, (x2 - x1), (x2 - x1), colour);
                }
                else if ((y2 - y1) < (x2 - x1))
                {
                    ellipseArray[ecounter] = new ellipse(x1, y1, (y2 - y1), (y2 - y1), colour);
                }
                else
                {
                    ellipseArray[ecounter] = new ellipse(x1, y1, (x2 - x1), (x2 - x1), colour);
                }
            }
            else
            {
                ellipseArray[ecounter] = new ellipse(x1, y1, (x2 - x1), (y2 - y1), colour);
            }
            ecounter++;
            drawPanel.Invalidate();
        }
        private void copyButton_Click(object sender, EventArgs e)
        {
            mode = "Copy";
            modeLabel.Text = mode;
        }
        private void blackButton_Click(object sender, EventArgs e)
        {
            colour = Color.Black;
            colourLabel.Text = "Current colour: Black";
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            colour = Color.Red;
            colourLabel.Text = "Current colour: Red";
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            colour = Color.Green;
            colourLabel.Text = "Current colour: Green";
        }

        private void freeHandButton_Click(object sender, EventArgs e)
        {
            mode = "Freehand";
            modeLabel.Text = mode;
            time = 0;
        }
        private void straightButton_Click(object sender, EventArgs e)
        {
            mode = "Straight Line";
            modeLabel.Text = mode;
            time = 0;
        }
        private void rectangleButton_Click(object sender, EventArgs e)
        {
            mode = "Rectangle";
            modeLabel.Text = mode;
            time = 0;
        }
        private void ellipseButton_Click(object sender, EventArgs e)
        {
            mode = "Ellipse";
            modeLabel.Text = mode;
            time = 0;
        }
        private void polygonButton_Click(object sender, EventArgs e)
        {
            mode = "Polygon";
            modeLabel.Text = mode;
            time = 0;
        }
        private void moveButton_Click(object sender, EventArgs e)
        {
            mode = "Move";
            modeLabel.Text = mode;
            time = 0;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            modeLabel.Text = mode;
        }
        private void drawPanel_DoubleClick(object sender, EventArgs e)
        {
            pcounter++;
            point1 = new Point (0,0);
            point2 = new Point(0,0);
            time = 0;
        }
        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            currentPen = new Pen(colour, 2);
            currentBrush = new SolidBrush(colour);
            foreach (rectangle rectangle in rectangleArray)
            {
                Rectangle temp = new Rectangle();
                temp.X = rectangle.getX();
                temp.Y = rectangle.getY();
                temp.Width = rectangle.getWidth();
                temp.Height = rectangle.getHeight();
                currentBrush = new SolidBrush(rectangle.getColor());
                e.Graphics.FillRectangle(currentBrush, temp);
            }
            foreach (ellipse ell in ellipseArray)
            {
                Rectangle temp = new Rectangle();
                temp.X = ell.getX();
                temp.Y = ell.getY();
                temp.Width = ell.getWidth();
                temp.Height = ell.getHeight();
                currentBrush = new SolidBrush(ell.getColor());
                e.Graphics.FillEllipse(currentBrush, temp);
            }
            foreach (line li in lineArray)
            {
                currentPen = new Pen(li.getColor());
                e.Graphics.DrawLine(currentPen, li.getPoint1(), li.getPoint2());
            }
            foreach (squiggle sq in squiggleArray)
            {
                if (sq.getSize() >= 1)
                {
                    for (int i = 1; i < sq.getSize(); i++)
                    {
                        currentPen = new Pen(sq.getColor());
                        e.Graphics.DrawLine(currentPen, sq.getPoint(i), sq.getPoint(i - 1));
                    }
                }
            }
            foreach (polygon p in polygonArray)
            {
                if (p.getSize() >= 1)
                {
                    for (int i = 1; i < p.getSize(); i++)
                    {
                        currentPen = new Pen(p.getColor());
                        e.Graphics.DrawLine(currentPen, p.getPoint(i), p.getPoint(i - 1));
                    }
                }
            }
        }
        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(mode == "Polygon")
            {
                polygonArray[pcounter].setPoint(e.X, e.Y, colour);
                x2 = e.X;
                y2 = e.Y;
                x1 = e.X;
                y1 = e.Y;
                drawPanel.Invalidate();
            }
            else if (mode == "Move"||mode=="Copy"||mode=="Delete")
            {
                for(int i = 0; i<20; i++)
                {
                    int x = rectangleArray[i].getX();
                    int y = rectangleArray[i].getY();
                    int width = rectangleArray[i].getWidth();
                    int height = rectangleArray[i].getHeight();
                    if(e.X >= x && e.X <= (x+width) && e.Y >=y && e.Y <= (y+height))
                    {
                        type = "rect";
                        obj = i;
                    }
                }
                for (int i = 0; i < 20; i++)
                {

                    int x = ellipseArray[i].getX();
                    int y = ellipseArray[i].getY();
                    int width = ellipseArray[i].getWidth();
                    int height = ellipseArray[i].getHeight();
                    if (e.X >= x && e.X <= (x + width) && e.Y >= y && e.Y <= (y + height))
                    {
                        type = "ellips";
                        obj = i;
                    }
                }
                for(int i = 0; i< 20; i++)
                {
                    for(int j = 0; j< squiggleArray[i].getSize(); j++)
                    {
                        Point p = squiggleArray[i].getPoint(j);
                        int x = p.X;
                        int y = p.Y;
                        if (e.X == x && e.Y == y)
                        {
                            type = "squig";
                            obj = i;
                            spoint = j;
                            break;
                        }
                    }
                }
                for(int i = 0; i< 20; i++)
                {
                    Point p1 = lineArray[i].getPoint1();
                    Point p2 = lineArray[i].getPoint2();

                    if(e.X>=p1.X && e.X<=p2.X && e.Y>=p1.Y && e.Y <= p2.Y)
                    {
                        type = "line";
                        obj = i;
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    for(int j = 1; j<20; j++)
                    {
                        Point p1 = polygonArray[i].getPoint(j-1);
                        Point p2 = polygonArray[i].getPoint(j);
                        if (e.X >= p1.X && e.X <= p2.X && e.Y >= p1.Y && e.Y <= p2.Y)
                        {
                            type = "poly";
                            obj = i;
                            break;
                        }
                    }
                }
                clickedPoint = new Point(e.X, e.Y);
            }
            else if (mode == "Line")
            {
                lineArray[lcounter].setPoint1(e.X, e.Y, colour);
                x1 = e.X;
                y1 = e.Y;
            }
            else
            {

                x1 = e.X;
                y1 = e.Y;
                active = true;
                time = 1;
            }


        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(mode=="Copy")
            {
                if (type == "rect")
                {
                    int xDiff = clickedPoint.X - e.X;
                    int yDiff = clickedPoint.Y - e.Y;

                    rectangleArray[rcounter].setColor(rectangleArray[obj].getColor());
                    rectangleArray[rcounter].setX(rectangleArray[obj].getX()-xDiff);
                    rectangleArray[rcounter].setY(rectangleArray[obj].getY() - yDiff);
                    rectangleArray[rcounter].setWidth(rectangleArray[obj].getWidth());
                    rectangleArray[rcounter].setHeight(rectangleArray[obj].getHeight());
                }
                else if (type == "ellips")
                {
                    int xDiff = clickedPoint.X - e.X;
                    int yDiff = clickedPoint.Y - e.Y;
                    ellipseArray[ecounter].setColor(ellipseArray[obj].getColor());
                    ellipseArray[ecounter].setX(ellipseArray[obj].getX() - xDiff);
                    ellipseArray[ecounter].setY(ellipseArray[obj].getY() - yDiff);
                    ellipseArray[ecounter].setWidth(ellipseArray[obj].getWidth());
                    ellipseArray[ecounter].setHeight(ellipseArray[obj].getHeight());
                }
                else if (type == "squig")
                {
                    Point p = squiggleArray[obj].getPoint(spoint);
                    int xDiff = p.X - e.X;
                    int yDiff = p.Y - e.Y;
                    
                    for(int i = 0; i< squiggleArray[obj].getSize(); i++)
                    {
                        Point l = squiggleArray[obj].getPoint(i);
                        squiggleArray[scounter].setColor(squiggleArray[obj].getColor());
                        squiggleArray[scounter].setMovePoint((l.X - xDiff), (l.Y - yDiff), i);
                    }
                    drawPanel.Invalidate();
                }
                else if (type == "line")
                {
                    int xDiff = clickedPoint.X - e.X;
                    int yDiff = clickedPoint.Y - e.Y;
                    Point p = lineArray[obj].getPoint1();
                    Point l = lineArray[obj].getPoint2();
                    lineArray[lcounter].setColor(lineArray[obj].getColor());
                    lineArray[lcounter].setPoint1((p.X- xDiff),(p.Y - yDiff), colour);
                    lineArray[lcounter].setPoint2((l.X - xDiff), (l.Y - yDiff));
                    drawPanel.Invalidate();
                }
                else if (type == "poly")
                {
                    int xDiff = clickedPoint.X - e.X;
                    int yDiff = clickedPoint.Y - e.Y;
                    for (int j = 0; j < 20; j++)
                    {
                        Point p = polygonArray[obj].getPoint(j);
                        polygonArray[pcounter].setColor(polygonArray[obj].getColor());
                        polygonArray[pcounter].setMovePoint((p.X - xDiff), (p.Y - yDiff), j);
                        
                    }

                }
                drawPanel.Invalidate();
                obj = 0;
                type = "";
            }
            else if (mode == "Delete")
            {
                if (type == "rect")
                {
                    rectangleArray[obj].setX(0);
                    rectangleArray[obj].setY(0);
                    rectangleArray[obj].setWidth(0);
                    rectangleArray[obj].setHeight(0);
                    rectangleArray[obj].setColor(Color.White);
                }
                else if (type == "ellips")
                {
                    ellipseArray[obj] = new ellipse();
                }
                else if (type == "squig")
                {
                    squiggleArray[obj] = new squiggle();
                }
                else if (type == "line")
                {
                    lineArray[obj] = new line();
                }
                else if (type == "poly")
                {
                    polygonArray[obj] = new polygon();

                }
                drawPanel.Invalidate();
                obj = 0;
                type = "";
            }
            else if (mode == "Move")
            {
                if (type == "rect")
                {
                    int xDiff = clickedPoint.X - e.X;
                    int yDiff = clickedPoint.Y - e.Y;
                    rectangleArray[obj].setX(rectangleArray[obj].getX() - xDiff);
                    rectangleArray[obj].setY(rectangleArray[obj].getY() - yDiff);
                }
                else if (type == "ellips")
                {
                    int xDiff = clickedPoint.X - e.X;
                    int yDiff = clickedPoint.Y - e.Y;
                    ellipseArray[obj].setX(ellipseArray[obj].getX() - xDiff);
                    ellipseArray[obj].setY(ellipseArray[obj].getY() - yDiff);
                }
                else if (type == "squig")
                {
                    Point p = squiggleArray[obj].getPoint(spoint);
                    int xDiff = p.X - e.X;
                    int yDiff = p.Y - e.Y;
         
                    for (int i = 0; i < squiggleArray[obj].getSize(); i++)
                    {
                        Point l = squiggleArray[obj].getPoint(i);
                        squiggleArray[obj].setMovePoint((l.X - xDiff), (l.Y - yDiff), i);
                    }
                    drawPanel.Invalidate();
                }
                else if (type == "line")
                {
                    int xDiff = clickedPoint.X - e.X;
                    int yDiff = clickedPoint.Y - e.Y;
                    Point p = lineArray[obj].getPoint1();
                    Point l = lineArray[obj].getPoint2();
                    lineArray[obj].setPoint1((p.X - xDiff), (p.Y - yDiff), colour);
                    lineArray[obj].setPoint2((l.X - xDiff), (l.Y - yDiff));
                    drawPanel.Invalidate();
                }
                else if (type == "poly")
                {
                    int xDiff = clickedPoint.X - e.X;
                    int yDiff = clickedPoint.Y - e.Y;
                    for (int j = 0; j < 20; j++)
                    {
                        Point p = polygonArray[obj].getPoint(j);
                        polygonArray[obj].setMovePoint((p.X - xDiff), (p.Y - yDiff), j);

                    }

                }
                drawPanel.Invalidate();
                obj = 0;
                type = "";
            }
            else if(mode == "Line")
            {
                active = false;
                x2 = e.X;
                y2 = e.Y;
                DrawLine();
            }
            else if(mode == "Rectangle")
            {
                active = false;
                point2 = new Point(e.X, e.Y);
                x2 = e.X;
                y2 = e.Y;
                DrawRectangle();
            }
            else if (mode == "Ellipse")
            {
                active = false;
                point2 = new Point(e.X, e.Y);
                x2 = e.X;
                y2 = e.Y;
                DrawEllipse();
            }
            else if(mode == "Freehand")
            {
                scounter++;
            }
            active = false;
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mode == "Freehand")
            {
                if(active == true)
                {
                    squiggleArray[scounter].setPoint(e.X, e.Y, colour);
                    x2 = e.X;
                    y2 = e.Y;
                    drawPanel.Invalidate();
                }
            }
        }
    }
}
