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
                foreach( House house in myVillage.houses)
                {
                    painter.drawHouse(house.x, house.y);
                }
                foreach (Tree tree in myVillage.trees)
                {
                    painter.drawTree(tree.x, tree.y);
                }
                foreach (WaterSource ws in myVillage.wSources)
                {
                    painter.drawHouse(ws.x, ws.y);
                }
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


        //radio buttons
        AbstractPainter painter;
        private void drawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbtnHouse.Checked == true)
            {
                painter.drawHouse(e.X, e.Y);
                myVillage.addHouse(new House(e.X, e.Y));
            }
            else if(rbtnTree.Checked == true)
            {
                painter.drawTree(e.X, e.Y);
                myVillage.addTree(new Tree(e.X, e.Y));
            }
            else if(rbtnWaterResource.Checked == true)
            {
                painter.drawWaterSource(e.X, e.Y);
                myVillage.addWSource(new WaterSource(e.X, e.Y));
            }
        }

        private void nationList_TextChanged(object sender, EventArgs e)
        {
            if (nationList.Text == "Arab Bedouin")
            {
                painter = new ArabPainter(drawingSpace);
            }
            else if (nationList.Text == "Bangladeshi Farmers")
            {
                painter = new BangladeshiPainter(drawingSpace);
            }
            else if (nationList.Text == "Egyptian Kings")
            {
                painter = new EgyptianPainter(drawingSpace);
            }
            else if (nationList.Text == "Inuit Hunters")
            {
                painter = new InuitPainter(drawingSpace);
            }
        }
    }
}
