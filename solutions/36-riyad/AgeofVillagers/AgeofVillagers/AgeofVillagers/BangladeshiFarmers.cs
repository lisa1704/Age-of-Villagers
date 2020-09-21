using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class BangladeshiFarmers : INation
    {
        Pen pen = new Pen(Color.Green);
        public string DrawHouse(Graphics g, Point pt)
        {
           
            return "KureGhor";
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
