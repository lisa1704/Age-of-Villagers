using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmer : INation
    {
        //private Panel drawingBoard;
        public BdFarmer()
        {
            
        }
        public IShape DrawHouse(Point p)
        {
            return new BdFarmerHouse(p);
        }

       

        public IShape DrawTree(Point p)
        {
            return new BdTree(p);
        }


        public IShape DrawWaterSource(Point p)
        {
            return new BdWater(p);
        }

        public Color PaintTerrain(Point p)
        {
            return Color.Green;
        }

        /*public Color PaintTerrain(Point p, Panel drawingBoard)
        {
            return drawingBoard.BackColor = System.Drawing.Color.Green;
            
        }*/


    }
}
