using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class Bangladeshi_Farmers : INation
    {
        Pen p = new Pen(Color.Yellow);
        public void Draw_Tree(Graphics g, Point point)
        {
            BangladeshFarmer_Tree bdtree = new BangladeshFarmer_Tree(point);
            bdtree.Draw(g);
        }
        public void Draw_House(Graphics g, Point point)
        {
            BangladeshiFarmer_House bd_house = new BangladeshiFarmer_House(point);
            bd_house.Draw(g);
        }
        public void Draw_WaterSource(Graphics g, Point point)
        { 
            BangladeshiFarmer_WaterSource bd_ws = new BangladeshiFarmer_WaterSource(point);
            bd_ws.Draw(g);
        }
        public string BangladeshiFarmer_Test()
        {
            return "Bangladeshi";
        }
        public Color BackGroundColor()
        {
            return Color.Green;
        }
    }
}