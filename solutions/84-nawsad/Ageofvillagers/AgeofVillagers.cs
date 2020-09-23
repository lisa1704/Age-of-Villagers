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
        INation nation = new NullNation();
        public Ageofvillagers()
        {

            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SaveVillage SaveVillage = new SaveVillage();
            SaveVillage.execute(Itemslist);
              
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenVillage openVillage = new OpenVillage();
            openVillage.execute(Itemslist);
        }
    }
    
}
