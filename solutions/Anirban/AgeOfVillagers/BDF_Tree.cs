using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers
{
    class BDF_Tree : IVillage_Item
    {
        Pen pen = new Pen(Color.Black);

        public void Draw_item(Graphics g, Point p)
        {
            Point root1 = new Point(p.X - 2, p.Y + 20);
            Point root2 = new Point(p.X + 2, p.Y + 20);
            Point head1 = new Point(p.X - 2, p.Y - 5);
            Point head2 = new Point(p.X + 2, p.Y - 5);

            Rectangle_shape rectangle = new Rectangle_shape(head2, head1, root1, root2);
            rectangle.Draw_shapes(p, g, pen);
            Circle_shape circle = new Circle_shape(p, 24, 24);
            circle.Draw_shapes(p, g, pen);
        }
    }

}
