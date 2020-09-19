using System.Drawing;
namespace Age_of_villagers
{
    public interface INation
    {
        Color get_backcolor();
        Compositeobj Draw_house(Point p);
        Compositeobj Draw_tree(Point p);
        Compositeobj Draw_watersource(Point p);
    }
}
