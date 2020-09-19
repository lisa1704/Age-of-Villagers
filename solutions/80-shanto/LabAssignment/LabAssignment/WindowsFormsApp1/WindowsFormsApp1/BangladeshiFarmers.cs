using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BangladeshiFarmers : INation
    {
        public Point e;
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 2);
        public BangladeshiFarmers(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 50, y);
            g.DrawLine(mypen, x + 50, y, x + 50, y + 25);
            g.DrawLine(mypen, x + 50, y + 25, x, y + 25);
            g.DrawLine(mypen, x, y + 25, x, y);
            g.DrawLine(mypen, x, y, x + 25, y - 25);
            g.DrawLine(mypen, x + 25, y - 25, x + 50, y);
        }

        

        public void DrawTree(MouseEventArgs e)
        {



            int x = e.X;
            int y = e.Y;
            g.DrawArc(mypen, x - 25, y - 25, 50, 50, 0, 360);
            g.DrawLine(mypen, x - 1, y, x + 1, y);
            g.DrawLine(mypen, x + 1, y, x + 1, y + 50);
            g.DrawLine(mypen, x + 1, y + 50, x - 1, y + 50);
            g.DrawLine(mypen, x - 1, y + 50, x - 1, y);
        }

        

        public void DrawWaterSource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 20, y + 16);
            g.DrawLine(mypen, x + 20, y + 16, x + 40, y - 24);
            g.DrawLine(mypen, x + 40, y - 24, x + 8, y - 40);
            g.DrawLine(mypen, x + 8, y - 40, x - 16, y - 24);
            g.DrawLine(mypen, x - 16, y - 24, x - 24, y - 36);
            g.DrawLine(mypen, x - 24, y - 36, x - 36, y - 28);
            g.DrawLine(mypen, x - 36, y - 28, x - 36, y);
            g.DrawLine(mypen, x - 36, y, x - 24, y + 20);
            g.DrawLine(mypen, x - 23, y + 20, x, y);
        }

        
    }

    /*public interface IShapeItem
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
    }*/
}
