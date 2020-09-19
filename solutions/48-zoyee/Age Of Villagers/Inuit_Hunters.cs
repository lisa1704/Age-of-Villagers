using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_Of_Villagers
{
    class Inuit_Hunters : INation
    {
        Pen p = new Pen(Color.Yellow);

        public Color BackGroundColor()
        {
            return Color.White;
        }
        public void Draw_House(Graphics g, Point point)
        {
            
        }

        public void Draw_Tree(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }

        public void Draw_WaterSource(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
    }
}
