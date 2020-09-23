using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers.age_of_village.Items.Tree
{
    class EgyptianKingTree : Itree
    {
       
        public void createTree(Coordinate coordinate, Panel villageCanvas)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = villageCanvas.CreateGraphics();
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X + 4, coordinate.Y - 20));
            graphics.DrawLine(pen, new PointF(coordinate.X, coordinate.Y), new PointF(coordinate.X - 4, coordinate.Y - 20));
            graphics.DrawLine(pen, new PointF(coordinate.X + 4, coordinate.Y - 20), new PointF(coordinate.X + 4, coordinate.Y - 24));
            graphics.DrawLine(pen, new PointF(coordinate.X + 4, coordinate.Y - 20), new PointF(coordinate.X + 8, coordinate.Y - 20));
            graphics.DrawLine(pen, new PointF(coordinate.X + 4, coordinate.Y - 20), new PointF(coordinate.X + 8, coordinate.Y - 24));
            graphics.DrawLine(pen, new PointF(coordinate.X - 4, coordinate.Y - 20), new PointF(coordinate.X - 4, coordinate.Y - 24));
            graphics.DrawLine(pen, new PointF(coordinate.X - 4, coordinate.Y - 20), new PointF(coordinate.X - 8, coordinate.Y - 20));
            graphics.DrawLine(pen, new PointF(coordinate.X - 4, coordinate.Y - 20), new PointF(coordinate.X - 8, coordinate.Y - 24));
        }
    }
}
