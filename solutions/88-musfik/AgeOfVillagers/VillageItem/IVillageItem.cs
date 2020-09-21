using System.Drawing;

namespace AgeOfVillagers
{
    interface IVillageItem
    {
        Point getItemLocation();
        CompositeShape getItemShape(Point point);
    }
}
