using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class AgeOfVillagersForm : Form
    {
        BdFarmerNation bdFarmerNation = new BdFarmerNation();
        public AgeOfVillagersForm()
        {
            InitializeComponent();
        }

        private void pnlDrawingSpace_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlDrawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = pnlDrawingSpace.CreateGraphics();
            Pen greenpen = new Pen(Color.Green);
            if (radiobtnHouse.Checked == true)
            {
                bdFarmerNation.houseDrawing(e, graphics, greenpen);
            }
            else if (radiobtnTree.Checked == true)
            {
                bdFarmerNation.treeDrawing(e, graphics, greenpen);
            }
            else if (radiobtnWaterSource.Checked == true)
            {
                bdFarmerNation.riverDrawing(e, graphics, greenpen);
            }
        }

        public void setVillageName(string name)
        {
            this.lblVillageName.Text = name;
        }

        public void setNationName(string name)
        {
            this.lblNationName.Text = name;
        }

        private void btnNewVillage_Click(object sender, EventArgs e)
        {
            NewVillageCreateForm newVillageCreateForm = new NewVillageCreateForm();
            newVillageCreateForm.Show();
            this.Hide();
        }
    }
}
