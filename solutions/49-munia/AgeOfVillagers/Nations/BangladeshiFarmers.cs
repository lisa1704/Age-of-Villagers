using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = AgeOfVillagers.Shapes.Rectangle;

namespace AgeOfVillagers 
{
    class BangladeshiFarmers : INation
    {
   
        Pen pen = new Pen(Color.Black);
    
        public void DrawHouse(Graphics g, Point p)
        {
            
            Triangle t = new Triangle(g, p);
            Rectangle r = new Rectangle(g, p);
            t.Draw();
            r.Draw();
        }

        public void DrawTree(Graphics g, Point p)
        {
            Rectangle r = new Rectangle(g, p);
            r.Draw();
        }

        public void drawWater(Graphics g, Point p)
        {
            g.DrawLine(pen, 10, 100, 300, 100);
        }

        public Color terrainColor()
        {
            return Color.LightGreen;
        }
    }
}
