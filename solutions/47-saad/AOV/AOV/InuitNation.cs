using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    public class InuitNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            InuitHouse igloo = new InuitHouse(p);
            igloo.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            NullShape nothing = new NullShape();
            nothing.draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            NullShape nothing = new NullShape();
            nothing.draw(g);
        }

        public Color GetColor()
        {
            return Color.White;
        }
    }
}
