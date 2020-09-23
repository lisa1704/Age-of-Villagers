using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabItemFactory : INation
    {
        public Color BackgroundColor()
        {
            return Color.GreenYellow;
        }

        public Object DrawHouse(Point point)
        {
            Composite arabBedouinHouse = new ArabBedouinHouse(point);
            //arabBedouinHouse.Draw(g);
            return arabBedouinHouse;
        }

        public Object DrawTree(Graphics g, Point point)
        {
            Composite arabBedouinTree = new ArabBedouinTree(point);
            //arabBedouinTree.Draw(g);
            return arabBedouinTree;
        }

        public Object DrawWaterSource(Point point)
        {
            Composite arabBedouinWaterSource = new NullItems();
            //arabBedouinWaterSource.drawing();
            return arabBedouinWaterSource;
        }

        
    }
}
