using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class Null_Nation : INation
    {
        public Color BackGroundColor()
        {
            return Color.White;

        }

        public void Draw_House(Graphics g, Point point)
        {
            NullVillage_Item NullNationhouse = new NullVillage_Item();
            NullNationhouse.paint();
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
