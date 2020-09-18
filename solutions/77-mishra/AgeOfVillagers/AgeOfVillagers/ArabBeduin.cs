using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers
{
	public class ArabBeduin : INation
	{
        string name;
		public ArabBeduin()
		{
#pragma warning disable CS1717 // Assignment made to same variable
            //name = name;
#pragma warning restore CS1717 // Assignment made to same variable


        }

        public void DrawHouse(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
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
    }
}
