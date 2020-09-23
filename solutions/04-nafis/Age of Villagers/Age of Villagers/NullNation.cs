using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class NullNation : INation
    {
        public NullNation(Point point)
        {

        }
        public Point GetHousePoint()
        {
            return new Point();
        }

        public Color GetTerrainColor()
        {
            return Color.Empty;
        }

        public Point GetTreePoint()
        {
            return new Point();
        }

        public Point GetWaterSourcePoint()
        {
            return new Point();
        }

        public IShape HouseDraw()
        {
            return new NullShape();
        }

        public IShape TreeDraw()
        {
            return new NullShape();
        }

        public IShape WaterSourceDraw()
        {
            return new NullShape();
        }
    }
}
