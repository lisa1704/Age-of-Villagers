using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Quadrangle : DrawableShapes
    {
        Point topLeftPoint,topRightPoint,bottomRightPoint,bottomLeftPoint;
        Graphics g;
        Pen p;
        int height,width;
        DrawableShapes upLine,downLine,leftLine,rightLine;
        private Point bottomRighttPoint;

        public Quadrangle(Point topLeftPoint, Point topRightPoint, Point bottomLeftPoint, Point bottomRighttPoint)
        {
            this.topLeftPoint = topLeftPoint;
            this.topRightPoint = topRightPoint;
            this.bottomLeftPoint = bottomLeftPoint;
            this.bottomRighttPoint = bottomRighttPoint;
        }

        public override void drawShape()
        {
            upLine.drawShape();
            downLine.drawShape();
            leftLine.drawShape();
            rightLine.drawShape();
        }
      

        public override void makeShape()
        {
           
            upLine = base.getLines(topLeftPoint, topRightPoint, g, p);
            downLine = base.getLines(bottomLeftPoint, bottomRightPoint, g, p);
            rightLine = base.getLines(topRightPoint, bottomRightPoint, g, p);
            leftLine = base.getLines(topLeftPoint, bottomLeftPoint, g, p);
            drawShape();
        }
    }
}
