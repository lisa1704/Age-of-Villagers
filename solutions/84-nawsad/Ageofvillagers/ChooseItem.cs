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
        public string Item_type;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Item_type = "House";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Item_type = "Tree";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Item_type = "Water Source";
        }
    }
}
