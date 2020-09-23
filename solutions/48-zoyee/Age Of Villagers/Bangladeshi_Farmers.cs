using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public class Bangladeshi_Farmers : INation
    {
        //Pen p = new Pen(Color.Yellow);
        public object Draw_Tree(Graphics g, Point point)
        {
            BangladeshFarmer_Tree bdtree = new BangladeshFarmer_Tree(point);
            bdtree.Draw(g);
            return bdtree;
        }
        public object Draw_House(Graphics g, Point point)
        {
            BangladeshiFarmer_House bd_house = new BangladeshiFarmer_House(point);
            bd_house.Draw(g);
            return bd_house;
        }
        public object Draw_WaterSource(Graphics g, Point point)
        { 
            BangladeshiFarmer_WaterSource bd_ws = new BangladeshiFarmer_WaterSource(point);
            bd_ws.Draw(g);
            return bd_ws;
        }
        public Color BackGroundColor()
        {
            return Color.Green;
        }
        public string Bd_FarmerTest()
        {
            return "Bangladeshi";
        }
    }
}