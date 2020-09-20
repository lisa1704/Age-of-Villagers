using System.Drawing;
namespace Age_of_villagers
{
    public interface INation
    {
        Color get_backcolor();
        IObject Draw_house(Point p);
        IObject Draw_tree(Point p);
        IObject Draw_watersource(Point p);
    }
}
