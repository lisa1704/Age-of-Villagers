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
        public string nationName;
        public string villageName;
        public string rdbtn;
        public AgeOfVillagersForm()
        {
            InitializeComponent();
        }

        public void setVillageName(string name)
        {
            this.lblVillageName.Text = name;
            villageName = name;
        }

        public void setNationName(string name)
        {
            this.lblNationName.Text = name;
            nationName = name;
        }
        public void setRadioButton()
        {
            if (radiobtnHouse.Checked)
            {
                rdbtn = radiobtnHouse.Text;
            }
            else if (radiobtnTree.Checked)
            {
                rdbtn = radiobtnTree.Text;
            }
            else if (radiobtnWaterSource.Checked)
            {
                rdbtn = radiobtnWaterSource.Text;
            }
        }

        private void pnlDrawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = pnlDrawingSpace.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            setRadioButton();
            VillageComponentFactory villageComponentFactory = NationFactory.getNation(nationName);
            IVillageComponent villageComponent = villageComponentFactory.getComponent(rdbtn);
            villageComponent.drawComponent(e, graphics, pen);
        }

        private void btnNewVillage_Click(object sender, EventArgs e)
        {
            NewVillageCreateForm newVillageCreateForm = new NewVillageCreateForm();
            newVillageCreateForm.Show();
            this.Hide();
        }

        private void AgeOfVillagersForm_Load(object sender, EventArgs e)
        {
            if(nationName=="Arab Bedouin")
            {
                radiobtnWaterSource.Enabled = false;
                pnlDrawingSpace.BackColor = Color.LightYellow;
            }
            if(nationName=="Inuit Hunter")
            {
                radiobtnTree.Enabled = false;
                radiobtnWaterSource.Enabled = false;
                pnlDrawingSpace.BackColor = Color.White;
            }
            if(nationName=="Egyptian King")
            {
                pnlDrawingSpace.BackColor = Color.Yellow;
            }
        }
        private void pnlDrawingSpace_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
