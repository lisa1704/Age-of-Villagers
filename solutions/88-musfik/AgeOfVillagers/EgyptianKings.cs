﻿using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public EgyptianKings()
        {
            color = Color.Yellow;
            nation_name = "Egyptian Kings";
        }

        public object getHouse(Point point)
        {
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            return nation_name;
        }

        public Color getTerrainColor()
        {
            return color;
        }

        public object getTree(Point point)
        {
            throw new NotImplementedException();
        }

        public object getWaterResource(Point point)
        {
            throw new NotImplementedException();
        }
    }

    public class EgyptianKingsHouse : CompositeShape
    {
        public EgyptianKingsHouse(Point selectedPoint)
        {
            Point top = new Point(selectedPoint.X - 4, selectedPoint.Y - 6);
            Point base_left = new Point(selectedPoint.X - 10, selectedPoint.Y + 8);
            Point base_mid = new Point(selectedPoint.X + 0, selectedPoint.Y + 10);
            Point base_right = new Point(selectedPoint.X + 6, selectedPoint.Y + 2);

            AddComponent(new VShape(top , base_left, base_mid));
            AddComponent(new VShape(top, base_right, base_mid));
            AddComponent(new Line(top, base_mid));
        }
    }
}
