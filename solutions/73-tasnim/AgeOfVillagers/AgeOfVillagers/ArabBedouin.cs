using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBedouin : INation
    {
        public Color Color_Terrain()
        {
            return Color.LightYellow;
        }

        public void Draw_House(Graphics g, Point p)
        {
            ArabBedouinHouse house = new ArabBedouinHouse(p);
            house.Draw_Shape(g);

        }

        public void Draw_Tree(Graphics g, Point p)
        {
            ArabbedouinTree tree = new ArabbedouinTree(p);
            tree.Draw_Shape(g);
        }

        public void Draw_WaterSource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }
    }
}
