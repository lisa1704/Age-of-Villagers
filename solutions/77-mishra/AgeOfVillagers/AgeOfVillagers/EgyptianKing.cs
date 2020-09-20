using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKing : INation
    {
        public EgyptianKing()
        {

        }

        public IShape DrawHouse(Point p)
        {
            return new EgyptianKingHouse(p);
        }

        public IShape DrawTree(Point p)
        {
            return new EgyptianKingTree(p);
        }

        public IShape DrawWaterSource(Point p)
        {
            return new EgyptianKingWater(p);
        }

        public Color PaintTerrain(Point p)
        {
            return Color.Yellow;
        }


        /*public Color PaintTerrain(Point p, Panel drawingBoard)
        {
            return drawingBoard.BackColor = System.Drawing.Color.Yellow;
        }*/
    }
}
