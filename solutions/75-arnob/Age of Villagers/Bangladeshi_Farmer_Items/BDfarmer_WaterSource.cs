
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Bangladeshi_Farmer_Item
{
    class BDfarmer_WaterSource : CompositeShaping
    {
        public BDfarmer_WaterSource (Point startPoint, Point point1, Point point2, Point point3, Point point4, Point point5, Point point6, Point point7, Point point8)
        {
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
