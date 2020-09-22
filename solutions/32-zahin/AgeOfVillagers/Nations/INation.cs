using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        string DrawHouse(Graphics g, Point point);
        string DrawTree(Graphics g, Point point);
        string DrawWaterSource(Graphics g, Point point);
        Color DrawTerrain();
    }
}
