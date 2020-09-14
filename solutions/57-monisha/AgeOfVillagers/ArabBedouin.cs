using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.Arc;

namespace AgeOfVillagers
{
    class ArabBedouin : INations
    {
        Pen p = new Pen(Color.Gold);
        public string DrawHouse(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, pt.X + 16, pt.X + 16);
            return "Stonehouse";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            ArabTree Arabtree = new ArabTree(pt);
            Arabtree.Paint(g, p);
        }

        public void DrawWaterSource(Graphics g, Point MPt)
        {
            throw new NotImplementedException();
        }

        public void GetTerrainColor()
        {
            throw new NotImplementedException();
        }
    }
}
