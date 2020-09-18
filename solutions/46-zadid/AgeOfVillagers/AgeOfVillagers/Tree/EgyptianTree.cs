using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.Tree
{
    public class EgyptianTree : ITree
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, p.X, p.Y, p.X - sz.width / 3, p.Y - (sz.height-4));
            g.DrawLine(pen, p.X, p.Y, p.X + sz.width / 3, p.Y - (sz.height-4));
            g.DrawLine(pen, p.X - sz.width / 3, p.Y - (sz.height - 4),p.X-sz.width/2,p.Y-sz.height);
            g.DrawLine(pen, p.X + sz.width / 3, p.Y - (sz.height - 4),p.X+sz.width/2, p.Y - sz.height);
        }
    }
}
