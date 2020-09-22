using Age_Of_Villagers.Command;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public partial class VillageEditorWindow : Form
    {
        string villageName;
        string nation;
        string rdButton;
        Village village;
        INation ination;
       








        public VillageEditorWindow()
        {
            InitializeComponent();
            
        }


        public List<Point> House_points = new List<Point>();
        public List<Point> Tree_points = new List<Point>();
        public List<Point> WaterSrc_points = new List<Point>();

        

       

        public void getState()
        {
            village.villageName = villNameBox.Text;
            village.housePoints = this.House_points;
            village.treePoints = this.Tree_points;
            village.waterSourcePoints = this.WaterSrc_points;

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void setVillageName(string Name)
        {
            villNameBox.Text = Name;
            villageName = Name;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setNation(string nation)
        {
            
            NationPropertyFactory nationProperty = new NationPropertyFactory();
            ination = nationProperty.getNation(nation);
            ination.setRadiobutton(this);
            ination.setTerrain(this);
        }







        public void radioButton_Click()
        {
            if (rdButtonHouse.Checked)
            {
                rdButton = rdButtonHouse.Text;
            }
            else if (rdButtonTree.Checked)
            {
                rdButton = rdButtonTree.Text;
            }
            else if (rdButtonWaterSrc.Checked)
            {
                rdButton = rdButtonWaterSrc.Text;
            }
            else
                rdButton = "";


        }




        private void saveVill_Click(object sender, EventArgs e)
        {
            getState();
            SaveVillage sv = new SaveVillage(village);
            sv.execute();
            MessageBox.Show("Your village is saved");


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        public void AddPoints(MouseEventArgs e)
        {
            if (rdButton == "House")
            {
                House_points.Add(e.Location);

            }
            else if (rdButton == "Tree")
            {
                Tree_points.Add(e.Location);

            }
            else if (rdButton == "WaterSource")
            {
                WaterSrc_points.Add(e.Location);

            }

        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = Panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            

            radioButton_Click();
            ItemFactory itemFactory = NationFactory.getNation(nation);
            IVillageItem item = itemFactory.getItem(rdButton);
            item.Draw(e.Location, graphics, pen);
            AddPoints( e);


            





        }



        private void newVill_Click(object sender, EventArgs e)
        {
            House_points.Clear();
            Tree_points.Clear();
            WaterSrc_points.Clear();
            villNameBox.Clear();
            nationCombo.ResetText();
            nation = nationCombo.Text;
            NationPropertyFactory nationProperty = new NationPropertyFactory();
            ination = nationProperty.getNation(nation);
            ination.setTerrain(this);
            Panel1.Refresh();
        }
        
        private void rdButtonHouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = nationCombo.Text;
            setNation(nation);


        }

        private void saveVill_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

       

        

        private void openVill_Click(object sender, EventArgs e)
        {
            

        }
    }
}
