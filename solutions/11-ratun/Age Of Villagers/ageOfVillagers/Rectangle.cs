using System.Drawing;

namespace ageOfVillagers
{
    internal class Rectangle
    {
        Graphics g;
        Pen p;
        int x1, y1, x2, y2, x3, y3, x4, y4;
        //private string status = "";
        public Rectangle(Graphics g,Pen p,int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.g = g;
            this.p = p;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }
        public void Draw()
        {
            Line l1 = new Line(g,p,x1, y1, x2, y2);
            l1.Draw();
            Line l2 = new Line(g,p,x2, y2, x3, y3);
            l2.Draw();
            Line l3 = new Line(g,p,x3, y3, x4, y4);
            l3.Draw();
            Line l4 = new Line(g,p,x4, y4, x1, y1);
            l4.Draw();
        }
    }
}