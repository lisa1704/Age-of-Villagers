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
            throw new System.NotImplementedException();
        }

        public void Draw_House(Graphics g, Point point)
        {
            throw new NotImplementedException();
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
