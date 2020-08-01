using System.Drawing;
namespace Age_of_villagers
{
    public interface INation
    {
        void Draw_house(Graphics g, int X, int Y);
        void Draw_tree(Graphics g, int X, int Y);
        void Draw_watersource(Graphics g, int X, int Y);
    }
}
