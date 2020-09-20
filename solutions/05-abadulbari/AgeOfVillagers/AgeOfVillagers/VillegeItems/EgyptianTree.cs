using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    class EgyptianTree : VillageItem
    {
        private readonly Point bottom, mid1, mid2, top11, top12, top13, top21, top22, top23;

        public EgyptianTree(Point point)
        {
            bottom = point;
            top11 = new Point(bottom.X - 35, bottom.Y - 60);
            top12 = new Point(bottom.X - 20, bottom.Y - 60);
            top13 = new Point(bottom.X - 5, bottom.Y - 60);
            top21 = new Point(bottom.X + 5, bottom.Y - 60);
            top22 = new Point(bottom.X + 20, bottom.Y - 60);
            top23 = new Point(bottom.X + 35, bottom.Y - 60);
            mid1 = new Point((bottom.X + top12.X)/2, (bottom.Y + top12.Y)/2);
            mid1 = new Point((bottom.X + top22.X)/2, (bottom.Y + top22.Y)/2);
            addItem(new Line(bottom, top12));
            addItem(new Line(mid1, top11));
            addItem(new Line(mid1, top13));
            addItem(new Line(bottom, top22));
            addItem(new Line(mid2, top21));
            addItem(new Line(mid2, top23));
        }
    }
}
