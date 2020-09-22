using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        Pen pen = new Pen(Color.Black);
        private string vName;

        public void DrawHouse(Graphics graphics, Point point)
        {
            EgyptianHouse egyptianHouse = new EgyptianHouse(point);
            egyptianHouse.Draw(graphics, pen);
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            EgyptianTree egyptianTree = new EgyptianTree(point);
            egyptianTree.Draw(graphics, pen);
        }

        public void DrawWaterSource(Graphics graphics, Point point)
        {
            EgyptianWaterSource egyptianWS = new EgyptianWaterSource(point);
            egyptianWS.Draw(graphics, pen);
        }

        public string GetVillageName()
        {
            return vName;
        }

        public Color SetTerrain()
        {
            return Color.Yellow;
        }

        public void SetVillageName(string vName)
        {
            this.vName = vName;
        }

        public void SetWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
