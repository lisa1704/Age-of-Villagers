using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_village.Items.Tree
{
    class ArabBedouinTree : Itree
    {
 

        public void createTree(Coordinate coordinate, Panel villageCanvas)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = villageCanvas.CreateGraphics();
            elem.DrawRectangle(pen, coordinate.X, coordinate.Y, 2, 12);
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X + 1, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X + 4, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X + 6, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X + 8, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X - 3, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X - 5, coordinate.Y - 12));
            elem.DrawLine(pen, new PointF(coordinate.X + 1, coordinate.Y), new PointF(coordinate.X - 7, coordinate.Y - 12));
        }
    }
}
