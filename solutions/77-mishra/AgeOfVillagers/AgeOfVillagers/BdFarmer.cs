using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmer : INation
    {
        private Point point;
        public BdFarmer(Point point)
        {
            this.point = point;
        }
        //private Panel drawingBoard;
        
        public IShape DrawHouse(Point point)
        {
            return new BdFarmerHouse(point);
        }

        public IShape DrawTree(Point point)
        {
            return new BdTree(point);
        }

        public IShape DrawWaterSource(Point point)
        {
            return new BdWater(point);
        }

        public Color PaintTerrain(Point point)
        {
            return Color.Green;
        }

        /*public Color PaintTerrain(Point p, Panel drawingBoard)
        {
            return drawingBoard.BackColor = System.Drawing.Color.Green;
            
        }*/


    }
}
