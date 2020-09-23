using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgeOfVillagers.Shapes;
using System.Drawing;
using System.Threading.Tasks;
using AgeOfVillagers.Shapes;


namespace AgeOfVillagers
{
    class BDF_House : IVillage_Item
    {
        Pen pen = new Pen(Color.Black);


        public void Draw_item(Graphics g, Point p)
        {
            Point tb1 = new Point(p.X + 16, p.Y - 16);
            Point tb2 = new Point(p.X + 24, p.Y);

            Point rb1 = new Point(tb2.X, tb2.Y + 16);
            Point rb2 = new Point(p.X, p.Y + 16);

            Triangle_shape triangle = new Triangle_shape(p, tb1, tb2);
            triangle.Draw_shapes(p, g, pen);
            Rectangle_shape rectangle = new Rectangle_shape(p, tb2, rb1, rb2);
            rectangle.Draw_shapes(p, g, pen);
        }
    }
}