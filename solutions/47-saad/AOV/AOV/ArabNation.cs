using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    public class ArabNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            ArabHouse arabHouse=new ArabHouse(p);
            arabHouse.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            ArabTree arabTree = new ArabTree(p);
            arabTree.draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            NullShape nothing = new NullShape(p);
            nothing.draw(g);
        }

        public Color GetColor()
        {
            return Color.FromArgb(240, 230, 140);
        }
    }
}
