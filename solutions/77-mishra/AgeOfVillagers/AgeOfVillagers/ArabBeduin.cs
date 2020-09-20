using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers
{
	public class ArabBeduin : INation
	{
        //private Panel drawingBoard;
        public IShape DrawHouse(Point p)
        {
            return new ArabHouse(p);
        }

        public IShape DrawTree(Point p)
        {
            return new ArabTree(p);
        }

        public IShape DrawWaterSource(Point p)
        {
            return new NullItems();
        }

        public Color PaintTerrain(Point p)
        {
            return Color.LightGoldenrodYellow;
        }

       
        /*public Color PaintTerrain(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }
        */

    }
}
