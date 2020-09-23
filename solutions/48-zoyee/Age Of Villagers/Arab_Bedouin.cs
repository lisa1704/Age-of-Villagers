using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class Arab_Bedouin : INation
    {
        //Pen p = new Pen(Color.Red);

        public Color BackGroundColor()
        {
            return Color.Yellow;
        }

        public IShape Draw_House(Point point)
        {
            CompositeShape ab_h = new ArabBedouin_House(point);
            return ab_h;
        }

        public IShape Draw_Tree(Point point)
        {
            CompositeShape ab_tr = new ArabBedouin_Tree(point);
            return ab_tr;
        }

        public IShape Draw_WaterSource(Point point)
        {
            CompositeShape ab_wsNULL = new NullVillage_Item();
             return ab_wsNULL;
        }
    }
}
