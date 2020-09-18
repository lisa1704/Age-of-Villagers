using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class Arab_Bedouin : INation
    {
        Pen p = new Pen(Color.Violet);
        public void Draw_House(Graphics g, Point point)
        {
            g.DrawLine(p, point.X, point.Y, 100, 100);
        }

        public void Draw_Tree(Graphics g, Point point)
        {
            g.DrawLine(p, point.X, point.Y, 100, 100);
            ArabBedouin_Tree ab_tr = new ArabBedouin_Tree(point);
            ab_tr.Draw(g);
        }

        public void Draw_WaterSource(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
    }
}
