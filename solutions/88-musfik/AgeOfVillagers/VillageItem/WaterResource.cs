using AgeOfVillagers.Shape.CompositeShapes;
using System.Drawing;
using System.Windows.Markup;

namespace AgeOfVillagers
{
    public abstract class WaterResource : IVillageItem
    {
        private int height, width;

        public virtual int getHeight() => height;
        public virtual int getWidth() => width;       
        public virtual IShape getItemShape(Point point) => new NoShape();
    }

    public class BangladeshiWaterResource : WaterResource
    {
        private int height = 24, width = 16;
        
        public override int getHeight() => height;
        public override int getWidth() => width;
        public override IShape getItemShape(Point point) => new BangladeshiWaterSourceShape(point);
    }

    public class EgyptianWaterResource : WaterResource
    {
        private int height = 12, width = 12;
        
        public override int getHeight() => height;
        public override int getWidth() => width;
        public override IShape getItemShape(Point point) => new EgyptianWaterSourceShape(point);
    }
}
