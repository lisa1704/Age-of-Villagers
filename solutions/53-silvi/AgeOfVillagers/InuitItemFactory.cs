using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.InuitItemFactory
{
    public class InuitItemFactory : INation
    {
        public Color BackgroundColor()
        {
            return Color.White;
        }

        public IShape DrawHouse(Point point)
        {
            Composite InuitHunterHouse = new InuitHunterHouse(point);
            //inuitHunterHouse.Draw(g);
            return (IShape)InuitHunterHouse;
        }

        public IShape DrawTree(Point point)
        {
            Composite InuitHunterTree = new NullItems();
            //inuitHunterTree.drawing();
            return (IShape)InuitHunterTree;
        }


        public IShape DrawWaterSource(Point point)
        {
            Composite InuitHunterWaterSource = new NullItems();
            //inuitHunterWaterSource.drawing();
            return (IShape)InuitHunterWaterSource;
        }

        
    }
}
