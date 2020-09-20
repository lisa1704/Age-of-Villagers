using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class CompositeShapes : IShape
    {
        private List<IShape> shapelists = new List<IShape>();

        public void addshapes(IShape shape)
        {
            shapelists.Add(shape);
        }
        public void draw(Point p, Panel drawingBoard)
        {
             foreach(var shapes in shapelists)
            {
                shapes.draw(p, drawingBoard);
            }
        }
    }
}
