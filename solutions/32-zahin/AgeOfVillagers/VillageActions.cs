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
    public partial class VillageActions : Form
    {
        string item;
        string villageName = "NotSpecified";
        string villageType;
        public Village newVillage = new Village();
        public List<Point> house { get; set; } = new List<Point>();
        public List<Point> tree { get; set; } = new List<Point>();
        public List<Point> water { get; set; } = new List<Point>();
        public VillageState state;
        public VillageActions() { InitializeComponent(); }

        private void VillageActions_Load(object sender, EventArgs e){}

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void House_Click(object sender, EventArgs e)
        {
            item = "house";
        }

        private void tree_Click(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void Water_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            state = new VillageState(villageName, house, tree, water);
            state.getState();
            SaveVillage saveVillage = new SaveVillage(state);
            saveVillage.execute();
        }

        private void OpenVIllage_Click(object sender, EventArgs e)
        {
            OpenVillage open = new OpenVillage();
            NewVillage_Click(sender, e);
            open.execute();
            state = open.getVillage();
            state.setState();
            panel1.Refresh();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        { 
            villageType = VillageNation.Text;
            newVillage.GetVillage(villageType);
            panel1.Refresh();
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {   
            Graphics g = panel1.CreateGraphics();
            if (item == "house") 
            {
                house.Add(e.Location);
                foreach(Point point in house)
                    newVillage.GetVillage(villageType).DrawHouse(g, point); 
            }
            else if (item == "tree") 
            {
                tree.Add(e.Location);
                foreach (Point point in tree) 
                    newVillage.GetVillage(villageType).DrawTree(g, point); 
            }
            else if (item == "water") 
            {
                water.Add(e.Location);
                foreach (Point point in water)
                    newVillage.GetVillage(villageType).DrawWaterSource(g, point); 
            }
            panel1.BackColor = newVillage.GetVillage(villageType).DrawTerrain();
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            panel2.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { villageName = textBox1.Text; }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
