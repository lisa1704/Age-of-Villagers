using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKing : INation
    {
       
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


        /*public Color PaintTerrain(Point p, Panel drawingBoard)
        {
            return drawingBoard.BackColor = System.Drawing.Color.Yellow;
        }*/
    }
}
