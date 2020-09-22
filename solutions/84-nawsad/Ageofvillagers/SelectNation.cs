using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ageofvillagers
{
    public partial class Ageofvillagers : Form
    {

        private void Select_Nation_Combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
              Console.WriteLine(Select_Nation_Combo_box.Text);
              Graphics g = panel2.CreateGraphics();
              Pen p = new Pen(Color.Black, 1);
              INationFactory factory = new INationFactory(g, p, Select_Nation_Combo_box.Text);
              nation =factory.get_Nation();
             // nation.drawHouse(mousepositionx,mousepositiony);
        }

    }
}
