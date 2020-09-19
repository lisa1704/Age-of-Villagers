using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class AgeOfVillagersForm : Form
    {
        public string nationName;
        public string villageName;
        public string rdbtn;
        public Point pt;
        public List<Point> treePoints = new List<Point>();
        public List<Point> housePoints = new List<Point>();
        public List<Point> riverPoints = new List<Point>();
        public Graphics graphics;
        public Pen pen;
        public VillageComponentFactory villageComponentFactory =null;
        public VillageSave villageSave;
        NationFactory nationFactory = new NationFactory();
        INation iNation;

        public AgeOfVillagersForm()
        {
            InitializeComponent();
            graphics = pnlDrawingSpace.CreateGraphics();
            pen = new Pen(Color.Black);
            villageSave = new VillageSave();
        }

        public void setVillageName(string name)
        {
            this.lblVillageName.Text = name;
            villageName = name;
        }

        public void setNationProperty(string name)
        {
            this.lblNationName.Text = name;
            nationName = name;
            villageComponentFactory = NationComponentFactory.getNation(nationName);
            
            iNation = nationFactory.getNation(lblNationName.Text);
            iNation.setRadioButtonOption(this);
            iNation.setTerrain(this);
        }

        public void setRadioButton()
        {
            RadioButton checkedButton = pnlComponentHolder.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                rdbtn = checkedButton.Text;
            }
            else
            {
                rdbtn = "";
            }
        }

        public void pnlDrawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            setRadioButton();
            VillageComponent villageComponent = villageComponentFactory.getComponent(rdbtn,e.Location);
            villageComponent.drawComponent(e.Location, graphics, pen);
            pt = villageComponent.getPoint();
            if (rdbtn == "House")
            {
                housePoints.Add(pt);
            }
            else if (rdbtn == "Tree")
            {
                treePoints.Add(villageComponent.getPoint());
            }
            else if(rdbtn=="Water source")
            {
                riverPoints.Add(villageComponent.getPoint());
            }

        }

        public void btnNewVillage_Click(object sender, EventArgs e)
        {
            NewVillageCreateForm newVillageCreateForm = new NewVillageCreateForm();
            newVillageCreateForm.Show();
            this.Hide();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            Village village = new Village(villageName,treePoints,housePoints,riverPoints);
            villageSave.saveVillage(village);
        }

        

        public void btnOpenVillage_Click(object sender, EventArgs e)
        {
            string filePath="";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open saved file";
            openFileDialog.Filter = "aov files (*.aov)|*.aov";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            nationName ="Arab Bedouin";
            Village village = villageSave.openVillage(this, filePath, nationName);
            villageSave.draw(this, village, nationName);

            /*OpenVillageForm openVillageForm = new OpenVillageForm(this,villageSave);
            openVillageForm.Show();
            this.Hide();*/
        }

        private void AgeOfVillagersForm_Load(object sender, EventArgs e)
        {
        }
        private void pnlDrawingSpace_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
