using System.Drawing;

namespace AgeOfVillagers.Items
{
    public interface IItem
    {
        void Draw(Graphics g, Point point);
    }
}
