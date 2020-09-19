using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmer : INation
    {
        private Panel drawingBoard;
        public BdFarmer(Panel drawingBoard)
        {
            this.drawingBoard = drawingBoard;
        }
        public void DrawHouse(Point p, Panel drawingBoard)
        {
            BdFarmerHouse bdHouse = new BdFarmerHouse(drawingBoard);
            bdHouse.draw(p, drawingBoard);
        }

        public void DrawTree(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }
    }
}
