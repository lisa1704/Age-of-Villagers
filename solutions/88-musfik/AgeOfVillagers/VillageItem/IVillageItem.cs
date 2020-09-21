using System.Drawing;

namespace AgeOfVillagers
{
    interface IVillageItem
    {
        Point getItemLocation();
        IShape getItemShape(Point point);
    }
}
