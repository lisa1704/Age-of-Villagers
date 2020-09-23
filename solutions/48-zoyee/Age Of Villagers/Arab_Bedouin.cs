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

        public void Draw_House(Graphics g, Point point)
        {
            ArabBedouin_House ab_h = new ArabBedouin_House(point);
            ab_h.Draw(g);
        }

        public void Draw_Tree(Graphics g, Point point)
        {
            ArabBedouin_Tree ab_tr = new ArabBedouin_Tree(point);
            ab_tr.Draw(g);
        }

        public void Draw_WaterSource(Graphics g, Point point)
        {
            NullVillage_Item ab_wsNULL = new NullVillage_Item();
            ab_wsNULL.paint();
        }


    }
}
