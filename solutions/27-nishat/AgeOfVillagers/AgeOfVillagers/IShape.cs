using System.Drawing;

namespace AgeOfVillagers
{
    public interface IShape
    {
        void Draw(Graphics g, Pen p);
    }

    public abstract class VillageItem : IShape
    {
        public abstract void Draw(Graphics g, Pen p);
        
    }
    public class Sampletree : VillageItem
    {
        private readonly Point point;

        public Sampletree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p,point,new Point(point.X,point.Y-50));
        }
    }
}
