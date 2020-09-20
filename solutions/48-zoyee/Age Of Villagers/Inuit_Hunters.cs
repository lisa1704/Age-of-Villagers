using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class Inuit_Hunters : INation
    {

        public Color BackGroundColor()
        {
            return Color.White;
        }
        public void Draw_House(Graphics g, Point point)
        {
            Inuit_House inhouse = new Inuit_House(point);
            inhouse.Draw(g);
        }

        public void Draw_Tree(Graphics g, Point point)
        {
            NullVillage_Item NullNationtree = new NullVillage_Item();
            NullNationtree.paint();
        }

        public void Draw_WaterSource(Graphics g, Point point)
        {
            NullVillage_Item NullNationws = new NullVillage_Item();
            NullNationws.paint();
        }
    }
}
