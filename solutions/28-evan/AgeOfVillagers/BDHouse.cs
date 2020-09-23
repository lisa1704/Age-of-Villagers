using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BDHouse : INation
    {
        Pen p = new Pen(Color.Green);
        public void Draw(Graphics g, Point point)
        {

        }

        public void DrawHouse(Graphics g, Point pt)
        {
            
        }

        public Color DrawTerrain()
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }
    }
}
