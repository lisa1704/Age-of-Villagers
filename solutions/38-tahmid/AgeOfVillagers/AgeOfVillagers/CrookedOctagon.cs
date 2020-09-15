using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class CrookedOctagon : Shape
    {
        Graphics graphics;
        Pen pen;
        Point startingPoint;
        int unitHeight, unitWidth;
        Shape topLeftLine, topMidLeftLine, topMidRightLine, topRightLine, bottomLeftLine, bottomMidLeftLine, bottomMidRightLine, bottomRightLine,topMidLine,topEndLine,bottomEndLine;
        Point topLeftPoint, topMidLeftPoint, topMidRightPoint,  bottomLeftPoint, bottomMidLeftPoint, bottomMidRightPoint,endPoint,topMidPoint;

        public CrookedOctagon(Graphics graphics,Pen pen,Point startingPoint,int unitHeight,int uintWidth)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.unitHeight = unitHeight;
            this.unitWidth = uintWidth;


        }
        public override void drawShape()
        {
            topLeftLine.drawShape();


        }

        internal override void makeShape()
        {
            
            
            topLeftPoint = new Point(startingPoint.X +3* unitWidth , startingPoint.Y - 2* unitHeight);
            topMidLeftPoint = new Point(topLeftPoint.X +  unitWidth, startingPoint.Y - 3 * unitHeight);
            topMidPoint = new Point(topMidLeftPoint.X, startingPoint.Y -  unitHeight);
            topMidRightPoint = new Point(topMidPoint.X + 2*unitWidth , startingPoint.Y -4* unitHeight);
            bottomLeftPoint = new Point(startingPoint.X + 3*unitWidth, startingPoint.Y + 4 * unitHeight);
            bottomMidLeftPoint= new Point(bottomLeftPoint.X +  unitWidth, startingPoint.Y + unitHeight);
            bottomMidRightPoint= new Point(bottomMidLeftPoint.X + unitWidth, startingPoint.Y +3* unitHeight);
            endPoint= new Point(startingPoint.X + 8*unitWidth, startingPoint.Y );

            topLeftLine = base.getLines(startingPoint, topLeftPoint,graphics,pen);
            topMidLeftLine = base.getLines(topLeftPoint, topMidLeftPoint, graphics, pen);
            topMidLine = base.getLines(topMidLeftPoint, topMidPoint, graphics, pen);
            topMidRightLine = base.getLines(topMidPoint, topMidRightPoint, graphics, pen);
            topEndLine=base.getLines(topMidRightPoint, endPoint, graphics, pen);
            bottomLeftLine = base.getLines(startingPoint, bottomLeftPoint, graphics, pen);
            bottomMidLeftLine = base.getLines(bottomLeftPoint, bottomMidLeftPoint, graphics, pen);  
            bottomMidRightLine = base.getLines(bottomMidLeftPoint, bottomMidRightPoint, graphics, pen);
            bottomEndLine = base.getLines(bottomMidRightPoint, endPoint, graphics, pen);
            drawShape();





            drawShape();
        }
    }
}
