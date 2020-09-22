using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Ageofvillagers;
using Ageofvillagers.Nations;

namespace Ageofvillagers
{
    public partial class Ageofvillagers :Form
    {
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            INation B = new ArabBeduin(g,p);
            B.drawTree(e.Location.X, e.Location.Y);
           B.drawWaterSource(e.Location.X, e.Location.Y);

            //   IShape rec = new Rectangle(g,p,e.Location.X,e.Location.Y);
            //   rec.drawshape();
            //Ishape l = new Line(g, p, e.Location.X, e.Location.Y);
            // IShape T = new Triangle(g, p, e.Location.X, e.Location.Y);
            // T.drawshape();
            //  IShape S = new Circle(g, p, e.Location.X, e.Location.Y);


        }
    }
}
