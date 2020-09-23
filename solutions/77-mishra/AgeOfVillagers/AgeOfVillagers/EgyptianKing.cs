using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKing : INation
    {
        private Point point;
        public EgyptianKing(Point point)
        {
            this.point = point;
        }
       
        public IShape DrawHouse(Point point)
        {
            return new EgyptianKingHouse(point);
        }

        public IShape DrawTree(Point point)
        {
            return new EgyptianKingTree(point);
        }

        public IShape DrawWaterSource(Point point)
        {
            return new EgyptianKingWater(point);
        }

        public Color PaintTerrain(Point point)
        {
            return Color.Yellow;
        }
    }
}
