using Ageofvillagers.Nations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ageofvillagers
{
    public partial class Ageofvillagers : Form
    {
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenVillage openVillage = new OpenVillage(openFileDialog1.InitialDirectory + openFileDialog1.FileName);
            openVillage.execute(Itemslist);
        }
    }
}
