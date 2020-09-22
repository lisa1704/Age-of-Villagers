
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Bangladeshi_Farmer_Item
{
    class BDfarmer_WaterSource : CompositeShaping
    {
        public BDfarmer_WaterSource (Point point)
        {
            Point startPoint= new Point(point.X, point.Y);
            Point point1 = new Point(point.X - 12, point.Y + 24);
            Point point2 = new Point(point.X, point.Y + 36);
            Point point3 = new Point(point.X + 18, point.Y + 24);
            Point point4 = new Point(point.X + 12, point.Y + 18);
            Point point5 = new Point(point.X + 36, point.Y + 12);
            Point point6 = new Point(point.X + 30, point.Y - 6);
            Point point7 = new Point(point.X + 12, point.Y + 6);
            Point point8 = new Point(point.X + 12, point.Y - 4);



            AddComponent(new Line(startPoint, point1));
            AddComponent(new Line(point1, point2));
            AddComponent(new Line(point2, point3));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point4, point5));
            AddComponent(new Line(point5, point6));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point7, point8));
            AddComponent(new Line(point8, startPoint));
        }


    } 
    
}
