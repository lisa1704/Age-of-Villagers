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
        public CreateEditVIllage()
        {
            InitializeComponent();
        }

        // buttons

        private void btnSaveVillage_Click(object sender, EventArgs e)
        {

        }

        private void btnNewVillage_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void btnOpenVillage_Click(object sender, EventArgs e)
        {

        }

        // text boxes

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void textVillageName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNation_TextChanged(object sender, EventArgs e)
        {

        }


        //radio buttons
        
        private void refreshForm()
        {
            textVillageName.Text = "Name of the Village";
            textNation.Text = "Name of the Nation";
            rbtnHouse.Checked = false;
            rbtnTree.Checked = false;
            rbtnWaterResource.Checked = false;
            this.Invalidate();
        }

        private void drawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            ArabPainter ap = new ArabPainter(drawingSpace);
            

            if(rbtnHouse.Checked == true)
            {
                ap.drawHouse(e.X, e.Y);
            }
            else if(rbtnTree.Checked == true)
            {
                ap.drawTree(e.X, e.Y);
            }
            else if(rbtnWaterResource.Checked == true)
            {
                ap.drawWaterSource(e.X, e.Y);
            }
        }
    }
}
