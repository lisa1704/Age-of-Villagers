using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class EgyptianNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            EgyptHouse egyptHouse=new EgyptHouse(p);
            egyptHouse.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            EgyptTree egyptTree = new EgyptTree(p);
            egyptTree.draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            EgyptWater egyptWater=new EgyptWater(p);
            egyptWater.draw(g);
        }

        public Color GetColor()
        {
            return Color.Yellow;
        }
    }
}
