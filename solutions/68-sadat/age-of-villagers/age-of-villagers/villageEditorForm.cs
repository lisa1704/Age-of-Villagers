using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using age_of_villagers.age_of_villagers.Nations;
using age_of_villagers.age_of_villagers.utilities;
using age_of_villagers.age_of_villagers.Village;
using age_of_villagers.age_of_villagrs.Nations;
namespace age_of_villagers
{
    public partial class villageEditor : Form
    {
        Ination nation;
        Village thisVillage = new Village();
        VillageSaver thisVillageSaver = new VillageSaver();


        public villageEditor()
        {
            
            InitializeComponent();
            comboBox1.Items.Add("Arab Bedouin");
            comboBox1.Items.Add("Bangladeshi Farmers");
            comboBox1.Items.Add("Egyptian Kings");
            comboBox1.Items.Add("Inuit Hunters");
            comboBox1.Text = "Bangladeshi Farmers";

        }


        private void villageEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void saveVillageButton_Click(object sender, EventArgs e)
        {
            thisVillageSaver.saveVillageState(thisVillage);
        }

        private void openVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void newVillageButton_Click(object sender, EventArgs e)
        {
            VillageCanvas.Invalidate();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void villageNameTextBox_enter(object sender, EventArgs e)
        {
            if (villageNameTextBox.Text == "Enter Village Name")
            {
                villageNameTextBox.Text = "";
            }
        }

        private void villageNameTextBox_leave(object sender, EventArgs e)
        {
            if (villageNameTextBox.Text == "")
            {
                villageNameTextBox.Text = "Enter Village Name";
            }
            else
            {
                thisVillage.setName(villageNameTextBox.Text);
            }

        }

        /*private void nationNameTextBox_enter(object sender, EventArgs e)
        {
            if (nationNameTextBox.Text == "Enter Nation Name")
            {
                nationNameTextBox.Text = "";
            }

        }

        private void nationNameTextBox_leave(object sender, EventArgs e)
        {
            if (nationNameTextBox.Text == "")
            {
                nationNameTextBox.Text = "Enter Nation Name";
            }
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VillageCanvas_MouseClick(object sender, MouseEventArgs e)
        {
           
            if(treeButton.Checked == true)
            {
                nation.createTree(e.X, e.Y);
                thisVillage.addTree(new Coordinate(e.X, e.Y));
                
            }
            else if(houseButton.Checked == true)
            {
                nation.createHouse(e.X, e.Y);
                thisVillage.addHouse(new Coordinate(e.X, e.Y));
            }
            else if(waterSourceButton.Checked == true)
            {
                nation.createWaterSource(e.X, e.Y);
                thisVillage.addWaterSource(new Coordinate(e.X, e.Y));
            };
        }

        private void treeButtonClick(object sender, EventArgs e)
        {
        }

        private void WaterSourceClick(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Arab Bedouin")
            {
                nation = new ArabBedouin(VillageCanvas);
                nation.colorTerrain();
                
            }
            else if (comboBox1.SelectedItem == "Bangladeshi Farmers")
            {
                nation = new BangladeshiFarmer(VillageCanvas);
                nation.colorTerrain();
            }
            else if (comboBox1.SelectedItem == "Egyptian Kings")
            {
                nation = new EgyptianKing(VillageCanvas);
                nation.colorTerrain();
            }
            else if (comboBox1.SelectedItem == "Inuit Hunters")
            {
                nation = new InuitHunter(VillageCanvas);
                nation.colorTerrain();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
