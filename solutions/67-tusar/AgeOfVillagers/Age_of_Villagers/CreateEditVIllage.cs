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
        Village myVillage = new Village();
        VillageSerializer myVS = new VillageSerializer();
        OpenFileDialog ofd = new OpenFileDialog();

        public CreateEditVIllage()
        {
            InitializeComponent();
        }

        // buttons

        private void btnSaveVillage_Click(object sender, EventArgs e)
        {
            myVS.saveState(myVillage);
        }

        private void btnNewVillage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOpenVillage_Click(object sender, EventArgs e)
        {
            ofd.Filter = "aov|*.aov";
            if (ofd.ShowDialog() == DialogResult.OK)    
            {
                string fileName = ofd.FileName;
                myVillage = myVS.openState(fileName);
                textVillageName.Text = myVillage.getName();
                myVillage.repaint();
            }
        }

        // text boxes

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void textVillageName_TextChanged(object sender, EventArgs e)
        {
            myVillage.setName(textVillageName.Text);
        }

        private void textNation_TextChanged(object sender, EventArgs e)
        {

        }
        private void drawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbtnHouse.Checked == true)
            {
                myVillage.addHouse(new Axes(e.X, e.Y));
            }
            else if(rbtnTree.Checked == true)
            {
                myVillage.addTree(new Axes(e.X, e.Y));
            }
            else if(rbtnWaterResource.Checked == true)
            {
                myVillage.addWSource(new Axes(e.X, e.Y));
            }
        }

        private void nationList_TextChanged(object sender, EventArgs e)
        {
            if (nationList.Text == "Arab Bedouin")
            {
                drawingSpace.Invalidate();
                myVillage.setNation(new ArabPainter(drawingSpace));
                myVillage.repaint();
            }
            else if (nationList.Text == "Bangladeshi Farmers")
            {
                drawingSpace.Invalidate();
                myVillage.setNation(new BangladeshiPainter(drawingSpace));
                myVillage.repaint();
            }
            else if (nationList.Text == "Egyptian Kings")
            {
                drawingSpace.Invalidate();
                myVillage.setNation(new EgyptianPainter(drawingSpace));
                myVillage.repaint();
            }
            else if (nationList.Text == "Inuit Hunters")
            {
                drawingSpace.Invalidate();
                myVillage.setNation(new InuitPainter(drawingSpace));
                myVillage.repaint();
            }
        }
    }
}
