using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        public Color Color_Terrain()
        {
            return Color.White;
        }

        public void Draw_House(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void Draw_Tree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void Draw_WaterSource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }
    }
}
