using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgeOfVillagers.Shapes;
using System.Drawing;
using System.Threading.Tasks;


namespace AgeOfVillagers
{
    class BDF_House : Village_Item
    {
        private readonly Point apex, top1, top2, bottom1, bottom2;
        public void createHouse()
        { 
        }

        public BDF_House(Point point)
        {
            apex = point;
            top1 = new Point(apex.X - 10, apex.Y + 20);
            top2 = new Point(apex.X + 10, apex.Y + 20);
            //bottomLeft = new Point(top.X-10, top.Y+40);
            bottom2 = new Point(apex.X + 10, apex.Y + 40);
            Add_item(new Triangle_shape(apex, top1, top2));
            Add_item(new Rectangle_shape(top1, top2,bottom1, bottom2));
        }
    }
}