using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianItemFactory : INation
    {
        public Color BackgroundColor()
        {
            return Color.Yellow;
        }

        public Object DrawHouse(Point point)
        {
            Composite egyptianHouse = new EgyptianKingsHouse(point);
            //egyptianHouse.Draw(g);
            return egyptianHouse;
        }

        public Object DrawTree(Graphics g, Point point)
        {
            Composite egyptianTrees = new ArabBedouinTree(point);
            //egyptianTrees.Draw(g);
            return egyptianTrees;
        }

        public Object DrawWaterSource(Point point)
        {
            Composite egyptianWaterSource = new EgyptianKingsWaterSource(point);
            //egyptianWaterSource.Draw(g);
            return egyptianWaterSource;

        }

        
    }
}
