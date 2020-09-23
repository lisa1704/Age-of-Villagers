using System.Drawing;

namespace AOV
{
    public interface INation
    {
        void DrawHouse(Graphics g, Point p);

        void DrawTree(Graphics g, Point p);

        void DrawWaterSource(Graphics g, Point p);

        Color GetColor();
    }
}
