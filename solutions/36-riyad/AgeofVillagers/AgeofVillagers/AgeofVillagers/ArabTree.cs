using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class ArabTree : CompositeShape
    {
        public ArabTree(Point mid)
        {
            Point topRight = new Point(mid.X + 20, mid.Y);
            Point bottomRight = new Point(mid.X + 25, mid.Y + 50);
            Point L1topPt = new Point(mid.X -20, mid.Y - 35);
            Point L2topPt = new Point(mid.X, mid.Y - 25);
            Point RTopLeft = new Point(mid.X + 18, mid.Y + 20);

            Point sndleafDN = new Point(mid.X + 20, mid.Y + 20);
            Point ssssUp = new Point(mid.X, mid.Y - 35);

            Point thirdUp = new Point(mid.X + 20, mid.Y - 35);
            Point thirddown = new Point(mid.X + 21, mid.Y + 20);

            Point fourdUp = new Point(mid.X + 35, mid.Y - 35);
            Point fourddown = new Point(mid.X + 24, mid.Y + 20);

            Point fivedUp = new Point(mid.X + 50, mid.Y - 35);
            Point fiveddown = new Point(mid.X + 26, mid.Y + 20);



            AddComponents(new RectangleShape(RTopLeft, bottomRight));
            AddComponents(new LineShape(RTopLeft, L1topPt));
            AddComponents(new LineShape(thirddown, thirdUp));

            AddComponents(new LineShape(sndleafDN, ssssUp));
            AddComponents(new LineShape(fourddown, fourdUp));
            AddComponents(new LineShape(fiveddown, fivedUp));
        }

    }
}
