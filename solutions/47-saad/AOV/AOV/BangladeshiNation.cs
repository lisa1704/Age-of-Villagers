using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class BangladeshiNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            
            BdHouse bdHouse=new BdHouse(new Point(p.X,p.Y),new Point(p.X-60,p.Y+30),new Point(p.X+60,p.Y+110));            
            bdHouse.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            BdTree bdTree = new BdTree(p);
            bdTree.draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            BdWaterSource bdWaterSource = new BdWaterSource(p);
            bdWaterSource.draw(g);
        }

        public Color GetColor()
        {
            return Color.Green;
        }
    }
}
