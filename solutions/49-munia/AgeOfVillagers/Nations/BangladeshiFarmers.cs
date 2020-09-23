using AgeOfVillagers.NationItems;
using AgeOfVillagers.Nations;
using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = AgeOfVillagers.Shapes.Rectangle;

namespace AgeOfVillagers 
{
    class BangladeshiFarmers : INation 
    {
   
        Pen pen = new Pen(Color.Black);
        BDItems bd = new BDItems();
    
        public void DrawHouse(Graphics g, Point p)
        {
            bd.House(g,p);
        }

        public void DrawTree(Graphics g, Point p)
        {
            bd.Tree(g, p);
        }

        public void DrawWater(Graphics g, Point p)
        {
            bd.Water(g, p);
        }
        public Color TerrainColor()
        {
            return Color.LightGreen;
        }
    }
}
