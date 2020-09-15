using System.Drawing;

namespace AgeOfVillagers90
{
    public class InuitHouse : CompositeShape
    {
        public InuitHouse(Point mainPoint)
        {
            Point linePoint1 = new Point(mainPoint.X, mainPoint.Y - 100);
            Point linePoint2 = new Point(mainPoint.X + 200, mainPoint.Y - 100);
            //Point oPoint = new Point(mainPoint.X - 40, mainPoint.Y - 40);
            //Point oPoint2 = new Point(mainPoint.X - 60, mainPoint.Y - 40);
            //Point topPoint1 = new Point(mainPoint.X + 50, mainPoint.Y + 55);
            //Point topPoint2 = new Point(mainPoint.X + 20, mainPoint.Y + 50);
            Point sidePoint1 = new Point(linePoint1.X - 25, linePoint1.Y + 100);
            Point sidePoint2 = new Point(sidePoint1.X + 150, sidePoint1.Y);

            AddComponent(new Line(sidePoint1, sidePoint2));
            AddComponent(new ArcShape(linePoint1.X, linePoint1.Y, 100F, 200F, 0, sweepAngle: -180.0F));
            AddComponent(new ArcShape(linePoint1.X-25, linePoint1.Y - 50, 150F, 300F, 0, sweepAngle: -180.0F));
            //AddComponent(new ArcShape(oPoint.X, oPoint.Y, topPoint2.X - oPoint.X, topPoint2.Y - oPoint.Y, 0, sweepAngle: -180.0F));
            //AddComponent(new ArcShape(oPoint2.X, oPoint2.Y, topPoint1.X - oPoint2.X, topPoint1.Y - oPoint2.Y, 0, -180.0F));
        }
    }
}
