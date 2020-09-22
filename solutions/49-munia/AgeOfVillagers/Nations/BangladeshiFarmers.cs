using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers 
{
    class BangladeshiFarmers : INation
    {
   
        Pen pen = new Pen(Color.Black);
    
        public void DrawHouse(Graphics g)
        {
            g.DrawLine(pen, 20, 10, 300, 100);
        }

        public void DrawTree(Graphics g)
        {
            g.DrawLine(pen, 20, 100, 300, 100);
        }

        public void drawWater(Graphics g)
        {
            g.DrawLine(pen, 10, 100, 300, 100);
        }

        public Color terrainColor()
        {
            return Color.LightGreen;
        }
    }
}
