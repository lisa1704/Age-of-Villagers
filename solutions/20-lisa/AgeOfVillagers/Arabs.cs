using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arabs : INation
    {
        private string vName;
        Pen pen = new Pen(Color.Black);

        public void DrawHouse(Graphics graphics, Point point)
        {
            ArabHouse arabHouse = new ArabHouse(point);
            arabHouse.Draw(graphics,pen);
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            ArabTree arabTree = new ArabTree(point);
            arabTree.Draw(graphics, pen);
        }

        public void DrawWaterSource(Graphics graphics, Point point)
        {
            NullItemHandler nullWS = new NullItemHandler();
            nullWS.Draw();

        }

        public string GetVillageName()
        {
            return vName;
        }

        public Color SetTerrain()
        {
            return Color.LightYellow;
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
