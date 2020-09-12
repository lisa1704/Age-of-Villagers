using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class compositeShape : IShape
    {
        List<IShape> shapelist = new List<IShape>();
        public void addShape(IShape shape)
        {
            shapelist.Add(shape);
        }
        public void draw(Graphics g, Pen pen)
        {
            foreach(var s in shapelist)
            {
                s.draw(g, pen);
                
            }
                
        }
    }
}
