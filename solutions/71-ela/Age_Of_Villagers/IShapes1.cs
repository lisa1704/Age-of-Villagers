using System.Drawing;

namespace Age_Of_Villagers
{
    internal interface IShapes1
    {
         void Draw(Graphics g, int x, int y, int height, int width, int rotate);
        Rectangle shape();
    }

}