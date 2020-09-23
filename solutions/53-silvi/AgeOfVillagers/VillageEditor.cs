using AgeOfVillagers.ItemFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgeOfVillagers
{
    public partial class VillageEditor : Form
    {
        string SelectedItemName = "";
        string name;
        string villageName;
        string nation;
        string VillageType;
        string text;
        private string rdButton;
        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> waterSource_point = new List<Point>();
        AgeOfVillagers.ItemFactory.NationFactory nationfactory = new AgeOfVillagers.ItemFactory.NationFactory();

        ItemFactory myItems;

        

        public VillageEditor()
        {
            InitializeComponent();
        }

        private void VillageBox_TextChanged(object sender, EventArgs e)
        {
            name = VillageBox.Text;
        }
        public void setVillageName(string Name)
        {
            VillageBox.Text = Name;
            string villageName = Name;

        }
        public void radioButton_Click()
        {
            if (House_btn.Checked)
            {
                rdButton = House_btn.Text;
            }
            else if (Tree_btn.Checked)
            {
                rdButton = Tree_btn.Text;
            }
            else if (Water_btn.Checked)
            {
                rdButton = Water_btn.Text;
            }
            else
                rdButton = "";


        }
        public void villageSaveState() //getting the info from form design
        {
            myItems.NationName = comboBox1.Text;
            myItems.VillageName = VillageBox.Text;
            myItems.VillageColor = this.BackColor;
            myItems.Tree = this.Tree_btn;
            myItems.House = this.House_btn;
            myItems.WaterSource = this.Water_btn;
        }

        private void VillegeEditor_Load(object sender, EventArgs e)
        {

        }
        private void Tree_btn_CheckedChanged(object sender, EventArgs e)
        {
            SelectedItemName = "Tree";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            nation = comboBox1.Text;
            panel1.BackColor = nationfactory.GetNation(nation).BackgroundColor();
            BackColor = panel1.BackColor;

        }

        private void Water_btn_CheckedChanged(object sender, EventArgs e)
        {
            SelectedItemName = "WaterSource";
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            villageSaveState();
            SettingsSavingEventHandler save_Village = new SettingsSavingEventHandler(myItems);
            save_Village.saveMyVillage();
            MessageBox.Show(VillageBox.Text + " Village is saved");
            
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            house_point.Clear();
            tree_point.Clear();
            waterSource_point.Clear();
            panel1.Refresh();
            nation.ResetText();
            VillageBox.ResetText();
            panel1.BackColor = Color.White;
            MessageBox.Show("Panel is ready for new village to be created");
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            SettingsSavingEventHandler villageOpen = new SettingsSavingEventHandler(myItems);
            villageOpen.openMyVillage();
            myItems = villageOpen.getmyVillage();
            setSavedVillage(myItems);
            panel1.Refresh();

        }
        public void setSavedVillage(ItemFactory myitem)
        {
            nation.Text = myitem.NationName;
            VillageBox.Text = myitem.VillageName;
            BackColor = myitem.VillageColor;

            foreach (Point point in myitem.House)
            {
                house_point.Add(point);
            }

            foreach (Point point in myitem.Tree)
            {
                tree_point.Add(point);
            }

            foreach (Point point in myitem.WaterSource)
            {
                waterSource_point.Add(point);
            }
        }

        private void House_btn_CheckedChanged(object sender, EventArgs e)
        {
            SelectedItemName = "House";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point point in tree_point)
            {
                nationfactory.GetNation(nation).DrawTree(point).Draw(p, g);
            }

            foreach (Point point in house_point)
            {
                nationfactory.GetNation(nation).DrawHouse(point).Draw(p, g);
            }

            foreach (Point point in waterSource_point)
            {
                nationfactory.GetNation(nation).DrawWaterSource(point).Draw(p, g);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
