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
            InuitHuntersHouse House = new InuitHuntersHouse(p);
            House.Draw_Shape(g);
        }

        public void Draw_Tree(Graphics g, Point p)
        {
            NullObject NullTree = new NullObject();
            NullTree.Draw_Shape();
        }

        public void Draw_WaterSource(Graphics g, Point p)
        {
            NullObject NullWater = new NullObject();
            NullWater.Draw_Shape();
        }
    }
}
