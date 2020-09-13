﻿using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianWell : VillageItem
    {
        private readonly Point point;

        public EgyptianWell(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape watersource = new WellShape(new Point(point.X - 6, point.Y - 6), new Point(point.X + 6, point.Y + 6));
            watersource.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
}
