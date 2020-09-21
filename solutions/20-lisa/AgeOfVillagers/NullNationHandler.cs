using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class NullNationHandler : INation
    {
        public void DrawHouse(Graphics graphics, Point point)
        {
            NullItemHandler nullHouse = new NullItemHandler();
            nullHouse.Draw();
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            NullItemHandler nullTree = new NullItemHandler();
            nullTree.Draw();
        }

        public void DrawWaterSource(Graphics graphics, Point point)
        {
            NullItemHandler nullWsource = new NullItemHandler();
            nullWsource.Draw();
        }

        public string GetVillageName()
        {
            throw new NotImplementedException();
        }

        public Color SetTerrain()
        {
            return Color.White;
        }

        public void SetVillageName(string vName)
        {
            throw new NotImplementedException();
        }

        public void SetWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
