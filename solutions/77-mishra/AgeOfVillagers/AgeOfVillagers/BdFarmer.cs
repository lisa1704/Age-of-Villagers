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
        public void DrawHouse(Point p, Panel drawingBoard)
        {
            BdFarmerHouse bdHouse = new BdFarmerHouse(drawingBoard);
            bdHouse.draw(p, drawingBoard);
        }

        public void DrawTree(Point p, Panel drawingBoard)
        {
            BdTree bdTree = new BdTree(drawingBoard);
            bdTree.draw(p, drawingBoard);

        }

        public void DrawWaterSource(Point p, Panel drawingBoard)
        {
            BdWater bdWater = new BdWater(drawingBoard);
            bdWater.draw(p, drawingBoard);
        }

        public void PaintTerrain(Point p, Panel drawingBoard)
        {
            drawingBoard.BackColor = System.Drawing.Color.Green;
        }
    }
}
