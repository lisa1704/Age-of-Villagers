using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        Pen pen = new Pen(Color.Black);
        private string vName;

        public void DrawHouse(Graphics graphics, Point point)
        {
            InuitHouse inuitHouse = new InuitHouse(point);
            inuitHouse.Draw(graphics, pen);
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            NullItemHandler nullInuitTree = new NullItemHandler();
            nullInuitTree.Draw();
        }

        public void DrawWaterSource(Graphics graphics, Point point)
        {
            NullItemHandler nullInuitWS = new NullItemHandler();
            nullInuitWS.Draw();
        }

        public string GetVillageName()
        {
            return vName;
        }

        public Color SetTerrain()
        {
            return Color.White;
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
