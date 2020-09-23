using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_village.Items.Tree
{
    class BangladeshiFarmerTree : Itree
    {
        
        public void createTree(Coordinate coordinate, Panel villageCanvas)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawEllipse(pen, coordinate.X, coordinate.Y, 16, 16);
            graphics.DrawEllipse(pen, coordinate.X + 7, coordinate.Y + 16, 2, 8);
        }
    }
}
