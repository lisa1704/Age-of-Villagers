using System;
using System.Collections.Generic;
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
            
        }

    }
}
