using System.Drawing;

namespace Age_of_villagers.Shapes
{
    interface IShape
    {
        void Draw(Graphics g, int x, int y, int height, int width);
        Rectangle shape();

    }
}
