using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class InuitHunters : INation
    {

        Pen pen = new Pen(Color.Gray);
        public string DrawHouse(Graphics g, Point p)
        {
            return "Igloo";
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
