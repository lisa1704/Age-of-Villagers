using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class InuitHunter : INation
    {
       

        public IShape DrawHouse(Point point)
        {
            return new InuitHunterHouse(point);
        }

        

        public IShape DrawTree(Point point)
        {
            return new NullItems();
        }


        public IShape DrawWaterSource(Point point)
        {
            return new NullItems();
        }

        public Color PaintTerrain(Point point)
        {
            return Color.White;
        }

        /*public Color PaintTerrain(Point p, Panel drawingBoard)
        {
            return drawingBoard.BackColor = System.Drawing.Color.White;
        }*/
    }
}
