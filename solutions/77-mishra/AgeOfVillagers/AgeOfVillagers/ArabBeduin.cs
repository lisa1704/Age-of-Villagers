using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers
{
	public class ArabBeduin : INation
	{
        //private Panel drawingBoard;
		public ArabBeduin()
		{

        }

        public void DrawHouse(Point p, Panel drawingBoard)
        {
            ArabHouse arabHouse = new ArabHouse(drawingBoard);
            arabHouse.draw(p, drawingBoard);
        }

        public void DrawTree(Point p, Panel drawingBoard)
        {
            ArabTree arabTree = new ArabTree(drawingBoard);
            arabTree.draw(p, drawingBoard);
        }

        public void DrawWaterSource(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }

        public void PaintTerrain(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }
    }
}
