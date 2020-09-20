using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    public class EgyptianKings : INation
    {
        public Color BackGroundColor()
        {
            return Color.Yellow;
        }

        public object DrawHouse(Graphics g, Point pt)
        {
            EgyptianHouse ekh = new EgyptianHouse(pt);
            ekh.Draw(g);
            return ekh;
        }

        public object DrawTree(Graphics g, Point pt)
        {
            EgyptianTree ekt = new EgyptianTree(pt);
            ekt.Draw(g);
            return ekt;
        }

        public object DrawWaterSource(Graphics g, Point pt)
        {
            EgytianWaterSource ekws = new EgytianWaterSource(pt);
            ekws.Draw(g);
            return ekws;
        }
    }
}
