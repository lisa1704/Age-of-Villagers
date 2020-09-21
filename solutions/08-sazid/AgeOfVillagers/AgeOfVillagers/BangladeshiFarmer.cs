using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class BangladeshiFarmer : INation
    {
        private Color backGroundColor = Color.Green;
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
            BangladeshiWaterSource wSource = new BangladeshiWaterSource(p);
            wSource.draw(g);
        }

        public Color GetColor()
        {
            return backGroundColor;
        }

        public string getNationName()
        {
            return "Bangladeshi Farmers";
        }
    }
}
