using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BangladeshiFarmers : INation
    {
        public Point e;
        public void DrawHouse()
        {
            
        }

        public void DrawTree(Point e, Graphics graphics, Pen mypen)
        {



            int x = e.X;
            int y = e.Y;
            graphics.DrawArc(mypen, x - 8, y - 8, 16, 16, 0, 360);
            graphics.DrawLine(mypen, x - 1, y, x + 1, y);
            graphics.DrawLine(mypen, x + 1, y, x + 1, y + 16);
            graphics.DrawLine(mypen, x + 1, y + 16, x - 1, y + 16);
            graphics.DrawLine(mypen, x - 1, y + 16, x - 1, y);
        }

        

        public void DrawWaterSource()
        {

        }
    }

    public interface IShapeItem
    {
        void Paint(Point e, Graphics g, Pen mypen);
    }

    public abstract class CompositeShape : IShapeItem
    {
        private List<IShapeItem> SComponents;

        protected CompositeShape()
        {
            SComponents = new List<IShapeItem>();
        }

        public void AddComp(IShapeItem shape)
        {
            SComponents.Add(shape);
        }
        public void Paint(Point e, Graphics g, Pen mypen)
        {
            foreach (var component in SComponents)
                component.Paint(e,g, mypen);
        }
    }
}
