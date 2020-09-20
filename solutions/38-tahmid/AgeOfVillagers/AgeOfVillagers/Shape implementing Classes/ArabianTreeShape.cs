using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    class ArabianTreeShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point point;
        private int tREE_HEIGHT;
        private int tREE_WIDTH;

        public ArabianTreeShape(Graphics graphics, Pen pen, Point point, int tREE_HEIGHT, int tREE_WIDTH)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.point = point;
            this.tREE_HEIGHT = tREE_HEIGHT;
            this.tREE_WIDTH = tREE_WIDTH;
        }

        public void makeShape()
        {
            
        }
    }
}
