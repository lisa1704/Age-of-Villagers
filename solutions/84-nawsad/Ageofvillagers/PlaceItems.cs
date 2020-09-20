using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Ageofvillagers;
namespace Ageofvillagers
{
    public partial class Ageofvillagers :Form
    {
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            IShape rec = new Rectangle(g,p,e.Location.X,e.Location.Y);
            rec.drawshape();
          //Ishape l = new Line(g, p, e.Location.X, e.Location.Y);
            IShape T = new Triangle(g, p, e.Location.X, e.Location.Y);
            T.drawshape();
          //  IShape S = new Circle(g, p, e.Location.X, e.Location.Y);
            // g.DrawLine(p,e.Location.X,e.Location.Y, e.Location.X+100, e.Location.Y);
            //  Console.WriteLine(e.Location.X);
            //  Console.WriteLine(e.Location.Y);
          //  g.DrawLine(p, e.Location.X, e.Location.Y, e.Location.X + 100, e.Location.Y);
          //  g.DrawLine(p, e.Location.X, e.Location.Y, e.Location.X, e.Location.Y + 100);
          //  g.DrawLine(p, e.Location.X, e.Location.Y + 100, e.Location.X + 100, e.Location.Y + 100);
          //  g.DrawLine(p, e.Location.X + 100, e.Location.Y + 100, e.Location.X + 100, e.Location.Y);
        }
    }
}
