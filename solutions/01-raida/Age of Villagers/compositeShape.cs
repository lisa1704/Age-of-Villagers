using System.Collections.Generic;
using System.Drawing;


namespace Age_of_Villagers
{
    class compositeShape : IShape
    {
        private List<IShape> shapelist = new List<IShape>();

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
