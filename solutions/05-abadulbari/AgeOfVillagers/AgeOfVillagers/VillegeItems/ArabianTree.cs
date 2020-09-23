using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Rectangle = AgeOfVillagers.Shapes.Rectangle;


namespace AgeOfVillagers.VillegeItems
{
    public class ArabianTree : VillageItem
    {
        private readonly Point centre, branch1, branch2, branch3, branch4, branch5, logTopLeft, logBottomRight;

        public ArabianTree(Point point)
        {
            centre = point;
            branch1 = new Point(centre.X - 19, centre.Y - 2);
            branch2 = new Point(centre.X - 15, centre.Y - 14);
            branch3 = new Point(centre.X, centre.Y - 20);
            branch4 = new Point(centre.X + 15, centre.Y - 14);
            branch5 = new Point(centre.X + 19, centre.Y - 2);
            logTopLeft = new Point(centre.X - 2, centre.Y);
            logBottomRight = new Point(centre.X + 2, centre.Y + 20);

            addItem(new Rectangle(logTopLeft, logBottomRight));
            addItem(new Line(centre, branch1));
            addItem(new Line(centre, branch2));
            addItem(new Line(centre, branch3));
            addItem(new Line(centre, branch4));
            addItem(new Line(centre, branch5));
        }
    }
}
