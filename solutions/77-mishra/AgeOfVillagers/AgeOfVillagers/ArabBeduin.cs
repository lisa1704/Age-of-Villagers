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
        public Color PaintTerrain(Point p)
        {
            return Color.LightGoldenrodYellow;
        }

        IShape INation.DrawHouse(Point p)
        {
            return new ArabHouse(p);
        }

        IShape INation.DrawTree(Point p)
        {
            return new ArabTree(p);
        }

        IShape INation.DrawWaterSource(Point p)
        {
            return new NullItems();
        }

        /*public Color PaintTerrain(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }
        */

    }
}
