using System.Drawing;
namespace Age_of_villagers
{
    public interface INation
    {
        Color get_backcolor();
        void Draw_house(Graphics g, Point p);
        void Draw_tree(Graphics g, Point p);
        void Draw_watersource(Graphics g, Point p);
    }
}
