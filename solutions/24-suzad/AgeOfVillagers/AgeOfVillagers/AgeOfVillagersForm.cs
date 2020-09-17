﻿using System;
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
        public Graphics graphics;
        public Pen pen;
        public VillageComponentFactory villageComponentFactory =null;
        public VillageSave villageSave = null;
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

        public void setNationName(string name)
        {
            this.lblNationName.Text = name;
            nationName = name;
            villageComponentFactory = NationFactory.getNation(nationName);
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

        private void pnlDrawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            //Graphics graphics = pnlDrawingSpace.CreateGraphics();
            //Pen pen = new Pen(Color.Black);
            setRadioButton();
            //VillageComponentFactory villageComponentFactory = NationFactory.getNation(nationName);
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
            Village village = new Village(nationName,villageName,treePoints,housePoints,riverPoints);
            villageSave.saveVillage(filePath,village);
        }

        private void btnOpenVillage_Click(object sender, EventArgs e)
        {
            //Graphics graphics = pnlDrawingSpace.CreateGraphics();
            //Pen pen = new Pen(Color.Black);
            string filePath = @"D:\Suzad\Books & notes\3-1\S.aov";
            //Village village = new Village(nationName, villageName, treePoints, housePoints, riverPoints);
            Village village=villageSave.openVillage(filePath, this);
            villageSave.draw(this, village);
        }
    }
}
