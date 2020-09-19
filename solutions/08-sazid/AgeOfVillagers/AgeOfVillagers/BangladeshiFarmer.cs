using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiFarmer : INation
    {
        private Color backGroundColor = Color.Green;
        Pen pen = new Pen(Color.Pink);
        public void DrawHouse(Graphics g, Point p)
        {
            BangladeshiHouse bdHouse = new BangladeshiHouse(new Point(p.X, p.Y), new Point(p.X - 60, p.Y + 30), new Point(p.X + 60, p.Y + 110));
            bdHouse.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            BangladeshiTree bdTree = new BangladeshiTree(p);
            bdTree.draw(g);
        }

        public void DrawWaterResource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public Color GetColor()
        {
            return backGroundColor;
        }
    }
}
