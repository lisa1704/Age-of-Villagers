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
            INation Nation = new BangladeshiFarmer(g,p);
            Nation.drawHouse(e.Location.X, e.Location.Y);
          //  B.drawHouse(e.Location.X, e.Location.Y);

     


        }
    }
}
