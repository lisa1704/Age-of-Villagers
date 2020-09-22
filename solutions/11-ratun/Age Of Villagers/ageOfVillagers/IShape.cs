using System.Drawing;

namespace ageOfVillagers
{
    internal interface IShape
    {
        string draw(int x, int y, Graphics g);
    }
}