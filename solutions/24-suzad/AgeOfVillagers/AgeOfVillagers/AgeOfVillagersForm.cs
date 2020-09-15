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
        public Point pt;
        public List<Point> treePoints = new List<Point>();
        public List<Point> housePoints = new List<Point>();
        public List<Point> riverPoints = new List<Point>();
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
            /*if (radiobtnHouse.Checked)
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
            else
            {
                rdbtn = "";
            }*/
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

        private void pnlDrawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            //Point point = e.Location;
            //MessageBox.Show("point" + point);
            Graphics graphics = pnlDrawingSpace.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            setRadioButton();
            VillageComponentFactory villageComponentFactory = NationFactory.getNation(nationName);
            VillageComponent villageComponent = villageComponentFactory.getComponent(rdbtn,e.Location);
            villageComponent.drawComponent(e.Location, graphics, pen);
            pt = villageComponent.getPoint();
            if (rdbtn == "House")
            {
                housePoints.Add(pt);
                /*string str = "";
                foreach (Point item in housePoints)
                {
                    str = str + item.X.ToString() + item.Y.ToString();
                }*/
                //MessageBox.Show(str);
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
            if(nationName=="Bangladeshi Farmer")
            {
                pnlDrawingSpace.BackColor = Color.Green;
            }
        }
        private void pnlDrawingSpace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Suzad\Books & notes\3-1\S.aov";
            //VillageSave villageSave = new VillageSave();
            //villageSave.setFields();
            Village village = new Village(nationName,villageName,treePoints,housePoints,riverPoints);
            //village.setFields();
            /*string str = "";
            foreach (Point item in village.housePoints)
            {
                str = str + item.X.ToString() + item.Y.ToString();
            }
            MessageBox.Show(str);*/
            //MessageBox.Show()
            VillageSave.saveVillage(filePath,village);
        }
    }
}
