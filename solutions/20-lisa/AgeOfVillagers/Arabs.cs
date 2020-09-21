using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arabs : INation
    {
        private string vName;

        public void DrawHouse(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
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
