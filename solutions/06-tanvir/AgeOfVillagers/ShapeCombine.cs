using System.Collections.Generic;
using System.Drawing;


namespace AgeOfVillager
{
    public class ShapeCombine : IShape
    {
        private List<IShape> shape_list = new List<IShape>();

        public void addShape(IShape shape)
        {
            shape_list.Add(shape);
        }
        public void Draw(Graphics grap, Pen pen)
        {
            foreach(var x in shape_list)
            {
                x.Draw(grap, pen);
                
            }
                
        }
    }
}