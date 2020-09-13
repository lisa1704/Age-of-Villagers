using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class CreateEditVIllage : Form
    {
        Village myVillage;
        IPainter nation;
        VillageSerializer myVS;

        public CreateEditVIllage()
        {
            InitializeComponent();
            myVillage = new Village();
            myVS = new VillageSerializer(myVillage);
            nationList.SelectedIndex = 1;
        }

        // buttons

        private void btnSaveVillage_Click(object sender, EventArgs e)
        {
            myVS.saveState(myVillage);
        }

        private void btnNewVillage_Click(object sender, EventArgs e)
        {
            Refresh();
            myVillage.RefreshVillage();
        }

        private void btnOpenVillage_Click(object sender, EventArgs e)
        {
            myVillage = myVS.restoreState();
            Refresh();
            myVillage.repaint(nation);
        }

        // text boxes

        private void textVillageName_TextChanged(object sender, EventArgs e)
        {
            myVillage.setName(textVillageName.Text);
        }

        private void drawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbtnHouse.Checked == true)
            {
                myVillage.addHouse(new Axes(e.X, e.Y), nation);
            }
            else if(rbtnTree.Checked == true)
            {
                myVillage.addTree(new Axes(e.X, e.Y), nation);
            }
            else if(rbtnWaterResource.Checked == true)
            {
                myVillage.addWSource(new Axes(e.X, e.Y), nation);
            }
        }

        private void nationList_TextChanged(object sender, EventArgs e)
        {
            if (nationList.Text == "Arab Bedouin")
            {
                nation = new ArabPainter(drawingSpace);
                
            }
            else if (nationList.Text == "Bangladeshi Farmers")
            {
                nation = new BangladeshiPainter(drawingSpace);
            }
            else if (nationList.Text == "Egyptian Kings")
            {
                nation = new EgyptianPainter(drawingSpace);
            }
            else if (nationList.Text == "Inuit Hunters")
            {
                nation = new InuitPainter(drawingSpace);
                
            }
            Refresh();
            myVillage.repaint(nation);
        }
    }
}
