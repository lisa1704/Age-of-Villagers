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
            throw new NotImplementedException();
        }
        public void Draw_House(Graphics g, Point point)
        {
            System.Drawing.Rectangle rec = new System.Drawing.Rectangle(new Point(point.X, point.Y), (Size)new Point(point.X + 15, point.Y + 25));
            rec.Draw(g);
        }
        public void Draw_WaterSource(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
    }
}