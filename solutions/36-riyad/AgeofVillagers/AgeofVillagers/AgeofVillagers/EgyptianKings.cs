using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class EgyptianKings : INation
    {
        Pen pen = new Pen(Color.SkyBlue);
        public string DrawHouse(Graphics g, Point p)
        {
            return "Piramid";
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
