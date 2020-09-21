using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.EgyptianKings
{
    public class EgyptianKings:INation
    {
        public Color BackgroundColor()
        {
            return Color.Yellow;
        }

        public void DrawHouse(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics g, Point point)
        {
            EgyptianTrees egyptiantree = new EgyptianTrees(point);
            egyptiantree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            EgyptianWaterS egyptianWater= new EgyptianWaterS(point);
            egyptianWater.Draw(g);
        }
    }
}
