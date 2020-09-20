using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    class EgyptianTreeShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private int tree_height;
        private int tree_width;

        public EgyptianTreeShape(Graphics graphics, Pen pen, Point startingPoint, int tree_height, int tree_width)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.tree_height = tree_height;
            this.tree_width = tree_width;
        }

        public void makeShape()
        {
            
        }
    }
}
