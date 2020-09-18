using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Bangladeshi_Farmers : INation
    {
        Pen p = new Pen(Color.Green);
        public void Draw_Tree(Graphics g, Point point)
        {
            BangladeshFarmer_Tree bdtree = new BangladeshFarmer_Tree(point);
            bdtree.Draw(g);
        }
        public void Draw_House(Graphics g, Point point)
        {
            //System.Drawing.Rectangle rec = new System.Drawing.Rectangle(new Point(point.X, point.Y), (Size)new Point(point.X + 15, point.Y + 25));
            //rec.Draw(g);
            //System.Drawing.Triangle triangle = new System.Drawing.Triangle(new Point(point.X - 5, point.Y + 10), new Point(point.X, point.Y), new Point(point.X + 15, point.Y));
            //Triangle.Draw(g);
            BagladeshiFarmer_House bd_house = new BagladeshiFarmer_House(new Point(point.X, point.Y), new Point(point.X - 50, point.Y * 10), new Point(point.X + 100, point.Y * 10));
        }
        public void Draw_WaterSource(Graphics g, Point point)
        { 
            BangladeshiFarmer_WaterSource bd_ws = new BangladeshiFarmer_WaterSource(point);
            bd_ws.Draw(g);
        }
    }
}