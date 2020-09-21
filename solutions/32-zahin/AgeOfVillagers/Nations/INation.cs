using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        void DrawHouse(Graphics g, Point point);
        void DrawTree(Graphics g, Point point);
        void DrawWaterSource(Graphics g, Point point);
        Color DrawTerrain();
    }
}
