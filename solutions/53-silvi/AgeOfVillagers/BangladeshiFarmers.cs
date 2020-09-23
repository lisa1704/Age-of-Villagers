using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.BangladeshiFarmers
{
    public class BangladeshiFarmers : INation
    {
        public Color BackgroundColor()
        {
            return Color.Green;
        }

        

        public Object DrawHouse(Point point)
        {
            Composite bdFarmersHouse = new BangladeshiHouse(point);
            //bdFarmersHouse.Draw(g);
            return bdFarmersHouse;
        }

        
        public Object DrawTree(Graphics g, Point point)
        {
            Composite bdFarmersTree = new BangladeshiTree(point);
            //bdFarmersTree.Draw(g);
            return bdFarmersTree;
        }

        

        public Object DrawWaterSource(Point point)
        {
            Composite bdFarmersWaterSource = new BangladeshiWatersource(point);
            //bdFarmersWaterSource.Draw(g);
            return bdFarmersWaterSource;
        }
    }
}
